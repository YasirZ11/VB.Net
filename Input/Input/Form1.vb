Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m As Integer

        m = InputBox("Enter a number", "Value")

        If m > 50 Then
            MsgBox("The number is greater than 50")

        ElseIf m = 50 Then
            MsgBox("The number is equal to 50")

        Else
            MsgBox("The number is less than50")
        End If
    End Sub
End Class
