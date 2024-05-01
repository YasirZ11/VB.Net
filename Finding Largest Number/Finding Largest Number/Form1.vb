Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim n1, n2, n3, largest As Integer
       
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        n3 = TextBox3.Text

        If n1 > n2 And n1 > n3 Then
            largest = n1

        ElseIf n2 > n1 And n2 > n3 Then
            largest = n2

        Else
            largest = n3
        End If

        TextBox4.Text = largest
    End Sub


End Class
