Imports System.Collections.Generic

Imports org.codegen.lib.FileComponents

Namespace Tokens

    Public Class ModelBaseClassToken
        Inherits ReplacementToken
        Sub New()
            Me.StringToReplace = "MODEL_BASE_CLASS"
        End Sub
        Public Overrides Function getReplacementCode(ByVal og As IObjectToGenerate) As String

            Return og.ModelBaseClass

        End Function

    End Class



    Public Class ModelImplementedInterfacesToken
        Inherits ReplacementToken

        Sub New()
            Me.StringToReplace = "implements"
        End Sub

        Public Overrides Function getReplacementCode(ByVal og As IObjectToGenerate) As String

            Dim SortField As String = XMLClassGenerator.getRowValue(og.XMLDefinition, _
                                                    XMLClassGenerator.XML_ATTR_SORT_FIELD, String.Empty)

            If Not String.IsNullOrEmpty(SortField) Then
                If ModelGenerator.Current.dotNetLanguage = ModelGenerator.enumLanguage.VB Then
                    og.DbTable.addImplemetedInterface("System.IComparable(Of " & CType(og, ObjectToGenerate).ClassName & ")")
                Else
                    og.DbTable.addImplemetedInterface("System.IComparable< " & CType(og, ObjectToGenerate).ClassName & ">")
                End If

            End If

            
            Return og.DbTable.ImplementsAsString

        End Function
    End Class
End Namespace
