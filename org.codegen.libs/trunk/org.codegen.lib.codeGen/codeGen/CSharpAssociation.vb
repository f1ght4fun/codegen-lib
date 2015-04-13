Imports Microsoft.VisualBasic
Imports System.Text
Imports org.codegen.lib.codeGen.FileComponents

Public Class CSharpAssociation
    Inherits Association
    Implements IAssociation

    
    ''' <summary>
    ''' declartation of this in the properties of the interface
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function getInterfaceDeclaration() As String Implements IAssociation.getInterfaceDeclaration
        Dim sbdr As StringBuilder = New StringBuilder()

        If Me.isCardinalityMany Then
            sbdr.Append("IEnumerable< " & Me.DataType & ">"). _
               Append(Me.associationName & " {get; set;}")

            sbdr.Append(vbCrLf)
            sbdr.Append(vbTab & vbTab & "void Add").Append(Me.associationNameSingular).Append("(").Append(Me.DataType).Append(" val);").Append(vbCrLf)
            sbdr.Append(vbTab & vbTab & "void Remove").Append(Me.associationNameSingular).Append("("). _
                                Append(Me.DataType).Append(" val);").Append(vbCrLf)

            sbdr.Append(vbTab & vbTab & "IEnumerable<").Append(Me.DataType).Append(">") _
                        .Append("getDeleted").Append(Me.associationName).Append("();").Append(vbCrLf)

            sbdr.Append(vbTab & vbTab & Me.DataType & " get").Append(Me.associationNameSingular).Append("( int i ) "). _
                                Append(";").Append(vbCrLf)
            '
        Else
            sbdr.Append(Me.getDataTypeVariable).Append(" ").Append(Me.associationName).Append(" {get;set;} //association")
        End If
        Return sbdr.ToString
    End Function

    Public Overrides Function getDataTypeVariable() As String Implements IAssociation.getDataTypeVariable

        If Me.isCardinalityMany Then
            Return "List< " & Me.DataType & ">"
        Else
            Return Me.DataType
        End If

    End Function

    Public Overrides Function getTestCode() As String Implements IAssociation.getTestCode

        Dim ret As String = "Assert."
        If Me._cardinality.Equals("*") Then
            ret &= "IsTrue(p." & Me.getGet & " != null);"

        Else
            ret &= "IsTrue(p." & Me.getGet & " != null);"
        End If

        Return ret

    End Function
   

    Public Overrides Function getVariable() As String Implements IAssociation.getVariable

        Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder() ' TODO type initialisation here
        sb.Append(vbTab & "private ")
        sb.Append(Me.getDataTypeVariable())
        sb.Append(" _")
        sb.Append(Me.getVariableName)
        sb.Append(" = null;  // initialize to nothing, for lazy load logic below !!!")
        sb.Append(vbCrLf)
        Return sb.ToString()
    End Function

    Public Overrides Function getDeletedVariable() As String Implements IAssociation.getDeletedVariable

        If Me.isCardinalityMany Then
            Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder() ' TODO type initialisation here

            sb.Append(vbTab & " private List< " & Me.DataType & ">").Append(" _deleted").Append(Me.associationName)
            sb.Append(" = new ").Append("List< " & Me.DataType & ">();").Append("// initialize to empty list !!!")
            sb.Append(vbCrLf)
            Return sb.ToString()
        Else
            Return String.Empty
        End If

    End Function

    Public Overrides Function getSaveParentCode(ByVal parentMoObjType As String) As String Implements IAssociation.getSaveParentCode
        Dim ret As String = ""
        If isParent() Then
            ' parent relationship!
            ' need to update self when parent is 
            ' updated. Example: Employer->Address. with link
            ' field address_id on the Employer table.
            '
            ' for example: address is saved first, employer second.

            If Me.IsReadOnly Then
                'in case of readonly association, just append a comment
                ret += vbTab + vbTab & "//***Readonly Parent Association:" & Me.associationName.ToLower() & " ***!" & vbCrLf
            Else

                Dim mapperClassName As String = GetAssociatedMapperClassName()
                Dim mappervar As String = Me.associationName.ToLower() & "Mapper"
                ret += vbTab + vbTab & "//*** Parent Association:" & Me.associationName.ToLower() & vbCrLf
                ret += vbTab + vbTab & "if (thisMo." & Me.getGet() & "Loaded && thisMo." & Me.getGet() & ".NeedsSave) {" & vbCrLf
                ret += vbTab + vbTab + vbTab + mapperClassName & " mappervar = new " & mapperClassName & "(this.dbConn);" & vbCrLf
                ret += vbTab + vbTab + vbTab + "mappervar.save(thisMo." & Me.getGet() & ");" & vbCrLf
                ret += vbTab + vbTab & vbTab + "thisMo." & DBTable.getRuntimeName(Me.ChildFieldName()) & " = thisMo." & Me.getGet() & "." & DBTable.getRuntimeName(Me.ParentFieldName()) & ";" & vbCrLf
                ret += vbTab + vbTab & "}" & vbCrLf
                ret += vbTab + vbTab + vbCrLf

            End If
        End If
        Return ret

    End Function

    Public Overrides Function getSaveChildrenCode() As String Implements IAssociation.getSaveChildrenCode

        Dim ret As String = ""
        If isParent() Then
            ' parent relationship!
            ' need to update self when parent is 
            ' updated. Example: Employer->Address
            ' address is saved first, employer second.

        Else
            If Me.IsReadOnly Then
                ret += vbTab + vbTab & "//***Readonly Child Association:" & Me.associationName.ToLower() & " ***!" & vbCrLf
            Else

                Dim mapperClassName As String = GetAssociatedMapperClassName()
                Dim mappervar As String = Me.associationName.ToLower() & "Mapper"
                ret = vbTab + vbTab & "//***Child Association:" & Me.associationName.ToLower() & vbCrLf
                ret &= vbTab & vbTab & "if (ret." & Me.associationName & "Loaded) {" & vbCrLf
                ret &= vbTab & vbTab & vbTab & mapperClassName & " " & mappervar & _
                                " = new " & mapperClassName & "(this.dbConn);" & vbCrLf

                If Me.isCardinalityMany Then
                    ret &= vbTab & vbTab & vbTab & mappervar & ".saveList(ret." & Me.getGet() & ");" & vbCrLf
                    ret &= vbTab & vbTab & vbTab & mappervar & ".deleteList(ret.getDeleted" & Me.associationName() & "());" & vbCrLf
                Else
                    ret &= vbTab & vbTab & vbTab & mappervar & ".save(ret." & Me.getGet() & ");" & vbCrLf
                End If
                ret &= vbTab & vbTab & "}"
                ret &= vbCrLf

            End If

        End If

        Return ret

    End Function

  
    Public Overrides Function getSetterGetter() As String Implements IAssociation.getSetterGetter

        Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder()
        Dim fieldName As String = Me.associationName
        Dim PropertyInterface As String = DirectCast( _
                ModelGenerator.Current.CurrentObjectBeingGenerated.FileGroup(ModelObjectFileComponent.KEY),  _
                DotNetClassFileComponent).ClassInterface

        If Me.isCardinalityMany And Me.RelationType = STR_RELATION_PARENT Then
            Throw New ApplicationException("PARENT relationship with cardinality ""MANY"" not allowed!")
        End If


        Dim stmpl As String = templateText

        stmpl = stmpl.Replace("<sort>", CStr(IIf(String.IsNullOrEmpty(Me.SortField) = False, _
                                                 "this._<association_name>.Sort()", "")))

        stmpl = stmpl.Replace("<association_name_singular>", Me.associationNameSingular)
        stmpl = stmpl.Replace("<association_name>", fieldName)
        stmpl = stmpl.Replace("<db_mapper>", _
                Me.GetAssociatedMapperClassName)
        stmpl = stmpl.Replace("<datatype>", Me.DataType)
        stmpl = stmpl.Replace("<parent_field_runtime>", DBTable.getRuntimeName(Me.ParentFieldName))
        stmpl = stmpl.Replace("<child_field_runtime>", DBTable.getRuntimeName(Me.ChildFieldName))
        stmpl = stmpl.Replace("<child_field_runtime_as_integer>", _
                              "CInt(this." & DBTable.getRuntimeName(Me.ChildFieldName) & ")")

        stmpl = stmpl.Replace("<child_field>", Me.ChildFieldName)
        stmpl = stmpl.Replace("<parent_field>", Me.ParentFieldName)
        stmpl = stmpl.Replace("<implements>", PropertyInterface)
        stmpl = stmpl.Replace("<iface>", PropertyInterface)
        sb.Append(stmpl)

        Return sb.ToString()

    End Function

  
    
    

End Class
