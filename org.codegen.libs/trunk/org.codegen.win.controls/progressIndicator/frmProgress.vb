﻿Namespace BackroundWorkerProgressIndicator

    Public Class frmProgress

        Public Event ProgressCancelled(ByVal sender As Object, ByVal e As EventArgs)

        Private Sub frmProgress_Load(ByVal sender As Object, _
                                     ByVal e As System.EventArgs) Handles Me.Load

            Me.btnCancel.Text = WinControlsLocalizer.getString("cmdCancel")

        End Sub


        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                    Handles btnCancel.Click

            Dim restoreTopMost As Boolean

            Try
                restoreTopMost = Me.TopMost
                If Me.TopMost Then
                    Me.TopMost = False
                End If
                If winUtils.MsgboxQuestion(WinControlsLocalizer.getString("cancel_progress")) = vbYes Then

                    RaiseEvent ProgressCancelled(Me, New EventArgs())
                    
                End If

            Finally
                Me.TopMost = restoreTopMost
            End Try

        End Sub


        Public Sub Progress(ByVal currentStep As Integer, ByVal msg As String)

            If currentStep > Me.ProgressBar.Maximum Then currentStep = Me.ProgressBar.Maximum
            If currentStep < Me.ProgressBar.Minimum Then currentStep = Me.ProgressBar.Minimum

            Me.ProgressBar.Value = currentStep
            Me.lblPercentage.Text = currentStep & "%"

            If String.IsNullOrEmpty(msg) = False Then
                Me.lblMessage.Text = msg
            End If

        End Sub

    End Class

End Namespace