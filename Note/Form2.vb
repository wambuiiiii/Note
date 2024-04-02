Imports Azure.Identity
Imports MySqlConnector
Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim email As String
        Dim password As String

        email = Me.TextBox1.Text
        password = Me.TextBox2.Text

        Dim connectionString As String = "Server=127.0.0.1;Database=notebook;Uid=Mutugi;password=keepitreal19"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()

        Dim query As String = "SELECT * FROM users WHERE password = @password AND email = @email"
        Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@email", Me.TextBox2.Text)
        command.Parameters.AddWithValue("@password", Me.TextBox1.Text)
        Dim Reader As MySqlDataReader = command.ExecuteReader()
        If (Reader.Read()) Then
            Dim folders As New Form3
            folders.Show()
            Me.Hide()
        Else
            MsgBox("Wrong credentials")
        End If
        connection.Close()



    End Sub
End Class