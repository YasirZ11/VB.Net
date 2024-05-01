Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Please Enter The Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Focus()
            TextBox1.BackColor = Color.Blue
            Return
        End If

        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Please Enter The Employee ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox2.Focus()
            TextBox2.BackColor = Color.Blue
            Return
        End If

        If ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("Please Select The Department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ComboBox1.Focus()
            ComboBox1.BackColor = Color.Blue
            Return
        End If

        If String.IsNullOrWhiteSpace(TextBox3.Text) Then
            MessageBox.Show("Please Enter The Town", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox3.Focus()
            TextBox3.BackColor = Color.Blue
            Return
        End If

        If String.IsNullOrWhiteSpace(TextBox4.Text) Then
            MessageBox.Show("Please Enter The Working Hours", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox4.Focus()
            TextBox4.BackColor = Color.Blue
            Return
        End If

        Dim PI As Integer = New Random().Next(1000, 10001)
        TextBox6.Text = PI.ToString()

        Dim WH As Integer
        Dim PR As Integer
        Dim GP As Integer

        Integer.TryParse(TextBox4.Text, WH)
        Integer.TryParse(TextBox5.Text, PR)

        If WH >= 1 And WH <= 5 Then
            PR = 100
        ElseIf WH >= 6 And WH <= 10 Then
            PR = 125
        ElseIf WH >= 11 And WH <= 15 Then
            PR = 150
        ElseIf WH > 15 Then
            PR = 200
        Else
            PR = 0
        End If

        TextBox5.Text = PR.ToString()
        GP = WH * PR * 30


        GrossPay.Text = GP.ToString()

        Dim INS As Integer
        If CheckBox1.Checked And CheckBox2.Checked Then
            INS = 3000
        ElseIf CheckBox1.Checked Then
            INS = 1000
        ElseIf CheckBox2.Checked Then
            INS = 2000
        Else
            INS = 0
        End If

        Benefits.Text = INS.ToString()

        Dim GP2 As Decimal
        Dim FT1 As Decimal

        Decimal.TryParse(GrossPay.Text, GP2)

        FT1 = GP2 * 0.1
        FederalTax.Text = FT1.ToString()


        Dim GP1 As Decimal
        Dim FT As Decimal
        Dim Be As Decimal
        Dim NP As Decimal

        Decimal.TryParse(GrossPay.Text, GP1)
        Decimal.TryParse(FederalTax.Text, FT)
        Decimal.TryParse(Benefits.Text, Be)


        NP = GP1 - FT - Be
        NetPay.Text = NP.ToString()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.SelectedIndex = -1
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        CheckBox1.Checked = False
        CheckBox1.Checked = False
        TextBox6.Clear()
        GrossPay.Clear()
        FederalTax.Clear()
        Benefits.Clear()
        NetPay.Clear()

    End Sub
End Class
