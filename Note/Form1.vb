Imports System.Text.RegularExpressions

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

<<<<<<< HEAD
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
=======
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
>>>>>>> d6b9f6266a2d0d1d94033548a9d19250eda27555

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
<<<<<<< HEAD
End Class
=======

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim form2Instance As New Form2()

        ' Show Form2
        form2Instance.Show()

        ' Optionally, hide Form1 if you don't want it to remain visible
        Me.Hide()
    End Sub
End Class
>>>>>>> d6b9f6266a2d0d1d94033548a9d19250eda27555
