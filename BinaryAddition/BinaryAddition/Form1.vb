Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            MsgBox("Your Answer is correct", MsgBoxStyle.ApplicationModal, "eg_check")
        ElseIf RadioButton2.Checked = True Then
            MsgBox("Your Answer is wrong", MsgBoxStyle.ApplicationModal, "eg_check")
        End If

    End Sub
End Class
