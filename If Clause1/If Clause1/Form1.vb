Public Class Form1

 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        n = InputBox("Enter the number", "Value")

        MsgBox("You have entered " & n)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox("form alert")
    End Sub
End Class
