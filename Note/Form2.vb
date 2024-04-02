Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Check if email follows the right criteria
        Dim emailRegex As New Regex("^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")
        If Not emailRegex.IsMatch(TextBox2.Text) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox2.Focus()
            Return
        End If


        ' Check if password meets the criteria
        Dim passwordRegex As New Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%?&])[A-Za-z\d@$!%?&]{12,}$")
        If Not passwordRegex.IsMatch(TextBox1.Text) Then
            MessageBox.Show("Password must be at least 12 characters long and contain at least one uppercase letter, one lowercase letter, one number, and one special character.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'txtConfirmPassword.Clear()
            TextBox1.Focus()
            Return
        End If

        ' If username, email and password meet criteria, log in is successful
        MessageBox.Show("Log in successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Redirect to home page
        Form3.Show()
        Me.Hide()

        Dim form3Instance As New Form3()


        ' Show Form2
        form3Instance.Show()

        ' Optionally, hide Form1 if you don't want it to remain visible
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim form1Instance As New Form1()

<<<<<<< HEAD
        ' Show Form2
        form1Instance.Show()

        ' Optionally, hide Form1 if you don't want it to remain visible
        Me.Hide()
=======
        'Dim folders As New Form3
        'folders.Show()
        'Me.Hide()


>>>>>>> 82e9248b680ce1eb26a78e1ca1b44f18456de091
    End Sub
End Class