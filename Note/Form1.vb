﻿Imports Microsoft.VisualBasic.ApplicationServices
Imports MySqlConnector

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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


        Dim connectionString As String = "Server=127.0.0.1;Database=notebook;username=Mutugi;password=keepitreal19"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()

        Dim query As String = "INSERT INTO users(email, username, password) VALUE(@email, @username, @password)"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@Email", Me.TextBox2.Text)
        cmd.Parameters.AddWithValue("@Username", Me.TextBox1.Text)
        cmd.Parameters.AddWithValue("@Password", Me.TextBox3.Text)
        cmd.ExecuteNonQuery()




        connection.Close()

        Me.Hide()
        Form2.Show()
    End Sub
End Class
