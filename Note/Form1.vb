Imports Microsoft.VisualBasic.ApplicationServices
Imports MySqlConnector

Public Class Form1





    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged
        ' Store the current text of the TextBox
        Dim currentText = TextBox3.Text

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim email As String
        Dim username As String
        Dim password As String

        username = Me.TextBox1.Text
        email = Me.TextBox2.Text
        password = Me.TextBox3.Text

        ' Wait for a brief moment (e.g., 500 milliseconds) before hiding the characters
        Threading.Thread.Sleep(3000)

        Dim connectionString As String = "Server=127.0.0.1;Database=notebook;username=Mutugi;password=keepitreal19"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()

        Dim query As String = "INSERT INTO users(email, username, password) VALUE(@email, @username, @password)"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@Email", Me.TextBox2.Text)
        cmd.Parameters.AddWithValue("@Username", Me.TextBox1.Text)
        cmd.Parameters.AddWithValue("@Password", Me.TextBox3.Text)
        cmd.ExecuteNonQuery()

        If Not passwordRegex.IsMatch(TextBox3.Text) Then
            MessageBox.Show("Password must be at least 12 characters long and contain at least one uppercase letter, one lowercase letter, one number, and one special character.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'txtConfirmPassword.Clear()
            TextBox3.Focus()
            Return
        End If



        connection.Close()

        Me.Hide()
        Form2.Show()

        Me.Hide()



    End Sub





    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim form2Instance As New Form2()


        form2Instance.Show()


        Me.Hide()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub




    ' Optionally, hide Form1 if you don't want it to remain visible

End Class

