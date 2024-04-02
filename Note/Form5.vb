

Imports MySqlConnector

Public Class Form5




    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        MsgBox("Do you want to save the changes..", MsgBoxStyle.YesNoCancel)
        TextBox2.Text = ""
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

        Dim notes As String
        Dim notesname As String

        notes = Me.TextBox2.Text
        notesname = Me.Name


        Dim connectionString As String = "Server=127.0.0.1;Database=notebook;Uid=Mutugi;password=keepitreal19"
        Dim connection As New MySqlConnection(connectionString)

        Dim query As String = "INSERT INTO notes(notesname, notes) VALUE(@notesname, @notes)"
        Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@notesname", Me.Name)
        command.Parameters.AddWithValue("@notes", Me.TextBox2.Text)

        Try
            connection.Open()
            command.ExecuteNonQuery()
            MessageBox.Show("Data saved successfully!")
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        TextBox2.Undo()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        TextBox2.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TextBox2.Paste()

    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        TextBox2.SelectAll()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox2.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox2.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Developed By Us")
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class