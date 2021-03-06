Imports System.Reflection
Imports System.Text
Imports System.Globalization
Imports org.codegen.common.TranslationServices

Public Interface IMessageBoxHandler

    Sub showInformationMessageBox(ByVal msg As String)
    Sub showErrorBox(ByVal msg As String)
    Function showQuestionBox(ByVal msg As String) As DialogResult

End Interface

Public NotInheritable Class DefaultMessageBoxHandler
    Implements IMessageBoxHandler

    Public Sub showErrorBox(msg As String) Implements IMessageBoxHandler.showErrorBox
        Call MsgBox(msg, MsgBoxStyle.Critical, FormsApplicationContext.current.ApplicationTitle)
    End Sub

    Public Sub showMessageBox(msg As String) Implements IMessageBoxHandler.showInformationMessageBox
        Call MsgBox(msg, MsgBoxStyle.Information, FormsApplicationContext.current.ApplicationTitle)
    End Sub

    Public Function showQuestionBox(msg As String) As DialogResult _
            Implements IMessageBoxHandler.showQuestionBox

        Return MessageBox.Show(msg, FormsApplicationContext.current.ApplicationTitle, _
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)


    End Function
End Class

Public NotInheritable Class winUtils
    Public Shared Sub MsgboxInfoTranslated(ByVal langKey As String, ParamArray params() As String)
        Dim msg As String = Translator.getString(langKey, params)
        Call MsgboxInfo(msg)
    End Sub
    Public Shared Sub MsgboxInfo(ByVal msg As String, ParamArray params() As String)
        Dim lmsg As String
        If params.Length > 0 Then
            lmsg = String.Format(msg, params)
        Else
            lmsg = msg
        End If

        FormsApplicationContext.current().MessageBoxHandler.showInformationMessageBox(lmsg)
    End Sub

    Public Shared Sub MsgboxStopTranslated(ByVal langKey As String, ParamArray params() As String)
        Dim msg As String = Translator.getString(langKey, params)
        Call MsgboxStop(msg)
    End Sub
    Public Shared Sub MsgboxStop(ByVal msg As String, ParamArray params() As String)
        Dim lmsg As String
        If params.Length > 0 Then
            lmsg = String.Format(msg, params)
        Else
            lmsg = msg
        End If
        FormsApplicationContext.current().MessageBoxHandler.showErrorBox(lmsg)

    End Sub

    Public Shared Function MsgboxQuestionTranslated(ByVal langKey As String, ParamArray params() As String) As DialogResult
        Dim msg As String = Translator.getString(langKey, params)
        Return MsgboxQuestion(msg)
    End Function

    Public Shared Function MsgboxQuestion(ByVal msg As String, ParamArray params() As String) As DialogResult
        Dim lmsg As String
        If params.Length > 0 Then
            lmsg = String.Format(msg, params)
        Else
            lmsg = msg
        End If

        Return FormsApplicationContext.current().MessageBoxHandler.showQuestionBox(lmsg)

    End Function

    Public Shared Function hasUnicode(ByVal str As String) As Boolean
        Dim flag As Boolean
        Dim num2 As Integer = Strings.Len(str)
        Dim i As Integer = 1
        Do While (i <= num2)
            If (Strings.Asc(Strings.Mid(str, i, 1)) > &H7F) Then
                Return True
            End If
            i += 1
        Loop
        Return flag
    End Function

    Public Shared Sub HourglassOff()
        Cursor.Current = Cursors.Default
    End Sub

    Public Shared Sub HourglassOn()
        Cursor.Current = Cursors.WaitCursor
    End Sub


    Public Shared Sub sizeMdiChild(ByVal f As Form)

        If f.IsMdiChild Then
            Const HEIGHT_OF_MENU_STATUS_BARS As Integer = 50
            ' Const WIDTH_OF_MENU_STATUS_BARS As Integer = 141

            f.Location = New Point(0, 0)
            f.Size = New Size(f.MdiParent.ClientRectangle.Width - 5, _
                f.MdiParent.ClientRectangle.Height - HEIGHT_OF_MENU_STATUS_BARS)
        End If

    End Sub




End Class