Imports System.Text.RegularExpressions

Public Class Form1


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Create an instance of Form1




        Dim button As New Form2


        button.Show()
        button.Focus()
        Me.Hide()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Check if username follows the right criteria
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Please enter a username.", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Focus()
            Return
        End If

        ' Check if email follows the right criteria
        Dim emailRegex As New Regex("^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")
        If Not emailRegex.IsMatch(TextBox2.Text) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox2.Focus()
            Return
        End If

        ' Check if password meets the criteria
        Dim passwordRegex As New Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%?&])[A-Za-z\d@$!%?&]{12,}$")

        If Not passwordRegex.IsMatch(TextBox3.Text) Then
            MessageBox.Show("Password must be at least 12 characters long and contain at least one uppercase letter, one lowercase letter, one number, and one special character.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'txtConfirmPassword.Clear()
            TextBox3.Focus()
            Return
        End If

        ' If username, email and password meet criteria, sign up is successful
        MessageBox.Show("Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Redirect to login page
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class