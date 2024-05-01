Public Class Form1

    Dim v1, v2 As Integer
          v1 = TextBox2.Text
         v2 = TextBox3.Text

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text = v1 + v2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        
        TextBox1.Text = v1 - v2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
       
        TextBox1.Text = v1 * v2
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        
        TextBox1.Text = v1 / v2
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
