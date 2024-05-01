Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Then
            MsgBox("Please fill the First Name", MsgBoxStyle.Exclamation, "Error")
        ElseIf TextBox2.Text = Nothing Then
            MsgBox("Please fill the Last Name", MsgBoxStyle.Exclamation, "Error")
        ElseIf TextBox3.Text = Nothing Then
            MsgBox("Please fill the Age", MsgBoxStyle.Exclamation, "Error")
        ElseIf RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MsgBox("Please select the Gender", MsgBoxStyle.Exclamation, "Error")
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False Then
            MsgBox("Please select the Other Languages", MsgBoxStyle.Exclamation, "Error")

        Else
            ListBox1.Items.Add("Full Name : " + TextBox1.Text + " " + TextBox2.Text)
            ListBox1.Items.Add("Age : " + TextBox3.Text)

            If RadioButton1.Checked = True Then
                ListBox1.Items.Add("Gender : Male")
            ElseIf RadioButton2.Checked = True Then
                ListBox1.Items.Add("Gender : Female")
            End If

            If CheckBox1.Checked = True And CheckBox2.Checked = True Then
                ListBox1.Items.Add("Other Fluent Language : English & French")
            ElseIf CheckBox1.Checked = True Then
                ListBox1.Items.Add("Other Fluent Language : English ")
            ElseIf CheckBox2.Checked = True Then
                ListBox1.Items.Add("Other Fluent Language : French ")
            End If
            ListBox1.Items.Add("")
            TextBox1.Text = ("")
            TextBox2.Text = ("")
            TextBox3.Text = ("")
            RadioButton1.Checked = False
            RadioButton1.Checked = False
            CheckBox1.Checked = False
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Remove("Full Name : " + TextBox1.Text + " " + TextBox2.Text)
        ListBox1.Items.Remove("Age : " + TextBox3.Text)

        If RadioButton1.Checked = True Then
            ListBox1.Items.Remove("Gender : Male")
        ElseIf RadioButton2.Checked = True Then
            ListBox1.Items.Remove("Gender : Female")
        End If

        If CheckBox1.Checked = True And CheckBox2.Checked = True Then
            ListBox1.Items.Remove("Other Fluent Language : English & French")
        ElseIf CheckBox1.Checked = True Then
            ListBox1.Items.Remove("Other Fluent Language : English ")
        ElseIf CheckBox2.Checked = True Then
            ListBox1.Items.Remove("Other Fluent Language : French ")
        End If

        ListBox1.Items.Add("")
        TextBox1.Text = ("")
        TextBox2.Text = ("")
        TextBox3.Text = ("")
        RadioButton1.Checked = False
        RadioButton1.Checked = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

