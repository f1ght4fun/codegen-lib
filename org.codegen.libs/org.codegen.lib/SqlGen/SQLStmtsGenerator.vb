
Imports System.IO
Imports System.Collections.Generic
Imports System.Text

Public Class SQLStmtsGenerator

    Private Property dbTable As IDBTable
    Private paramPrefix As String

    Sub New(ByVal dbTable As IDBTable)
        Me._dbTable = dbTable
        Me.paramPrefix = CStr(IIf(ModelGenerator.Current.DbConnStringDialect = DBUtils.enumSqlDialect.ORACLE, ":", "@"))
    End Sub

    Protected Friend Overridable Function getSelectStatement(ByVal forpkey As Boolean) As String

        Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder()
        Dim vec As Dictionary(Of String, IDBField) = dbTable.Fields()
        Dim fldLineCnt As Integer = 0
        Dim count As Integer = 0
        Dim sfields As List(Of String) = New List(Of String)

        sb.Append("SELECT ")

        For Each field As IDBField In vec.Values
            If Not field.isBinaryField Then
                fldLineCnt = fldLineCnt + 1
                sfields.Add(field.FieldName())

                count += 1

                If fldLineCnt = 5 AndAlso count < vec.Count Then
                    fldLineCnt = 0
                End If
            End If

        Next

        sb.Append(String.Join(",", sfields)).Append(" FROM " & Me.dbTable.quotedTableName())

        If forpkey Then

            sb.Append(" WHERE " & dbTable.getPrimaryKeyName() & "=" & paramPrefix & "0")
        End If

        Return sb.ToString()
    End Function



    Protected Friend Overridable Function deleteStatement() As String
        Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder()
        Dim vec As Dictionary(Of String, IDBField) = dbTable.Fields()

        Dim keyparam As Integer = 0
        sb.Append("DELETE FROM ")
        Dim count As Integer = 1

        For Each field As DBField In vec.Values
            If Not (field.FieldName().Equals(dbTable.getPrimaryKeyName())) Then
                count += 1
            Else
                keyparam = count
                count += 1
            End If
        Next

        sb.Append(Me.dbTable.quotedTableName())
        sb.Append(" WHERE ")
        sb.Append(dbTable.getPrimaryKeyName())
        sb.Append("=")
        sb.Append(paramPrefix)
        sb.Append("0")

        Return sb.ToString()
    End Function

    Protected Friend Overridable Function updateStatement() As String

        Dim sql As String = "" 'the sql string to be executed for this method.
        Dim sbf As System.Text.StringBuilder = New System.Text.StringBuilder() 'buffre for the parameters numbers
        Dim vec As Dictionary(Of String, IDBField) = Me.dbTable.Fields() 'loads the field vector in out vector (vec).

        'Iterator a = new Iterator();
        Dim parameterCounter As Integer = 1
        Dim keyparam As Integer = 0
        Dim fldLineCnt As Integer = 0

        Dim tblName As String = Me.dbTable.TableName

        For Each field As IDBField In vec.Values
            If field.IsTableField Then

                Dim skipit As Boolean = field.isBinaryField OrElse (Me.dbTable.isPrimaryKeyAutogenerated AndAlso _
                        field.isPrimaryKey)

                If Not skipit Then
                    If sbf.Length > 0 Then
                        sbf.Append(",")
                    End If
                    fldLineCnt = fldLineCnt + 1
                    If fldLineCnt = 5 Then
                        'sbf.Append(vbCrLf & vbTab)
                        fldLineCnt = 0
                    End If
                    sbf.Append(field.FieldName())
                    sbf.Append("=" & paramPrefix)

                    sbf.Append(field.RuntimeFieldName())

                    parameterCounter += 1
                End If
            End If
        Next

        'sbf.delete(sbf.length() - 1, sbf.length());
        sbf.Append(" WHERE ")
        sbf.Append(dbTable.getPrimaryKeyName())
        sbf.Append("=" & paramPrefix)
        'sbf.Append(parameterCounter)
        sbf.Append(Me.dbTable.getPrimaryKeyField.RuntimeFieldName)
        'sbf.Append(vbCrLf)
        sbf.Insert(0, "UPDATE " & Me.dbTable.quotedTableName() & " SET ")
        Return sbf.ToString()

    End Function


    Public Overridable Function insertStatementMSSQL() As String

        Dim sbf As New List(Of String)  'buffre for the parameters numbers
        Dim sbv As New List(Of String) ' string buffer where we add/append elements through the loop

        Dim vec As Dictionary(Of String, IDBField) = Me.dbTable.Fields() 'loads the field vector in out vector (vec).

        Dim fldLineCnt As Integer = 0
        Dim parameterCounter As Integer = 1
        Dim keyparam As Integer = 0

        'Dim tblName As String = "[" & Me.dbTable.TableName & "]"
        'note: do not use above [] to support generation from a foreign schema select * from [dbname.dbo.table] fails!
        Dim tblName As String = Me.dbTable.TableName

        For Each field As DBField In vec.Values
            If field.IsTableField Then
                Dim skipit As Boolean = field.isBinaryField OrElse (Me.dbTable.isPrimaryKeyAutogenerated AndAlso _
                        field.FieldName().ToLower().Equals(Me.dbTable.getPrimaryKeyName.ToLower()))

                If Not skipit Then

                    sbf.Add(field.FieldName())
                    sbv.Add("@" & field.RuntimeFieldName())

                    parameterCounter += 1
                End If
            End If

        Next

        Return "insert into " & tblName & " (" & String.Join(",", sbf) & _
                ") values (" & String.Join(",", sbv) & ")"

        

    End Function


    Public Overridable Function insertStatementOracle() As String

        Dim sql As String = "" 'the sql string to be executed for this method.
        Dim sbf As System.Text.StringBuilder = New System.Text.StringBuilder() 'buffre for the parameters numbers
        Dim sbv As System.Text.StringBuilder = New System.Text.StringBuilder() ' string buffer where we add/append elements through the loop
        Dim sbsp As System.Text.StringBuilder = New System.Text.StringBuilder() ' buffer for the set parameters
        Dim vec As Dictionary(Of String, IDBField) = Me.dbTable.Fields() 'loads the field vector in out vector (vec).

        'Iterator a = new Iterator();
        Dim parameterCounter As Integer = 1
        Dim keyparam As Integer = 0
        Dim fldLineCnt As Integer = 0

        For Each field As DBField In vec.Values

            If field.isBinaryField AndAlso Not (field.FieldName().ToLower.Equals(Me.dbTable.getPrimaryKeyName().ToLower)) Then

                If (Not sbf.ToString().Equals("")) Then
                    sbf.Append(",")
                End If
                sbf.Append(field.FieldName())

                If (Not sbv.ToString().Equals("")) Then
                    sbv.Append(",:")
                End If
                'sbv.Append(parameterCounter)''change: take param name
                sbv.Append(field.FieldName())
                fldLineCnt = fldLineCnt + 1
                If fldLineCnt = 5 Then
                    'sbf.Append(vbCrLf & vbTab)
                    'sbv.Append(vbCrLf & vbTab)
                    fldLineCnt = 0
                End If

                parameterCounter += 1
            End If
        Next

        'sbf.append(me.dbTable.getPrimaryKey());
        sbf.Append(") values (:")
        'sbv.Append(") RETURNING " & Me.DbTable.getPrimaryKeyName() & " INTO :" & parameterCounter & ";END;")
        sbv.Append(") RETURNING " & Me.dbTable.getPrimaryKeyName() & " INTO :" & Me.dbTable.getPrimaryKeyName() & ";END;")
        sbf.Append(sbv)

        sbf.Insert(0, "BEGIN insert into " & Me.dbTable.quotedTableName() & " (" & vbCrLf)

        Return sbf.ToString()

    End Function

    Function insertStatement() As String
        If ModelGenerator.Current.DbConnStringDialect = DBUtils.enumSqlDialect.ORACLE Then
            Return insertStatementOracle()
        Else
            Return insertStatementMSSQL()
        End If

    End Function

End Class
