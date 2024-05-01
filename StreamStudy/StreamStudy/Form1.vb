Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            MsgBox("Your stream is Physical Science", MsgBoxStyle.Exclamation, "Confirmation")
        ElseIf RadioButton2.Checked = True Then
            MsgBox("Your stream is Bio Science", MsgBoxStyle.Exclamation, "Confirmation")
        End If

    End Sub
End Class
