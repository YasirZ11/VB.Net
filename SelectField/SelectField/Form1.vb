Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True Then
            MsgBox("Your Favourite Field are: Networking , IP & AI ", MsgBoxStyle.OkOnly, "eg_check2")
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True Then
            MsgBox("Your Favourite Field are: Networking & IP ", MsgBoxStyle.OkOnly, "eg_check2")
        ElseIf CheckBox1.Checked = True And CheckBox3.Checked = True Then
            MsgBox("Your Favourite Field are: Networking & AI ", MsgBoxStyle.OkOnly, "eg_check2")
        ElseIf CheckBox2.Checked = True And CheckBox3.Checked = True Then
            MsgBox("Your Favourite Field are: IP & AI ", MsgBoxStyle.OkOnly, "eg_check2")
        ElseIf CheckBox1.Checked = True Then
            MsgBox("Your Favourite Field is: Networking ", MsgBoxStyle.OkOnly, "eg_check2")
        ElseIf CheckBox2.Checked = True Then
            MsgBox("Your Favourite Field is: Image Processing ", MsgBoxStyle.OkOnly, "eg_check2")
        ElseIf CheckBox3.Checked = True Then
            MsgBox("Your Favourite Field is: Artificial Intelligence ", MsgBoxStyle.OkOnly, "eg_check2")
        End If

    End Sub
End Class
