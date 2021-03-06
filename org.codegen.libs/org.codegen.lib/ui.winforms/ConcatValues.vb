Imports System.Collections.Generic
Imports org.codegen.lib.Tokens
Namespace org.codegen.lib.Tokens
    Public Class ConcatValues
        Inherits ReplacementToken

        Sub New()
            Me.StringToReplace = "CONCAT_VALUES"
        End Sub

        Public Overrides Function getReplacementCode(ByVal t as IObjectToGenerate) As String

            Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder()
            Dim vec As List(Of IDBField) = t.DbTable.Fields(). _
                        Values.ToList.FindAll(Function(p)
                                                  Return p.IsTableField = True _
                                                      AndAlso p.isPrimaryKey = False _
                                                      AndAlso p.isAuditField = False
                                              End Function)


            Dim i As Integer = 0
            For Each field As DBField In vec
                If Not field.isBinaryField Then
                    Dim fldName As String = DBTable.getRuntimeName(field.FieldName())
                    If (i > 0) Then
                        sb.Append(vbTab)
                        sb.Append(" & _").Append(vbCrLf)
                    End If
                    sb.Append(vbTab & "Me.").Append(fldName).Append(".Text")
                    i = i + 1
                End If


            Next

            Return sb.ToString
        End Function
    End Class
End Namespace
