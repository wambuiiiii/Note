Imports MySqlConnector

Public Class Form4


    Private Sub RoundButton2_Click(sender As Object, e As EventArgs) Handles RoundButton2.Click
        Dim newFolder As New folderControl()

        ' Calculate the position for the new folder
        Dim x As Integer = 50 ' Set initial x-coordinate to the edge of the page
        Dim y As Integer = RoundButton2.Location.Y + RoundButton2.Height + 60 ' Set y-coordinate below the last button
        For Each control As Control In Me.Controls
            If TypeOf control Is folderControl Then
                Dim folder As folderControl = DirectCast(control, folderControl)
                If folder.Location.X + folder.Width + 120 < Me.ClientSize.Width Then
                    ' Move to the next position
                    x = folder.Location.X + folder.Width + 120
                    y = folder.Location.Y
                Else
                    ' Start a new row
                    x = 50
                    y = folder.Location.Y + folder.Height + 60
                End If
            End If
        Next

        ' Set the location of the new folder
        newFolder.Location = New Point(x, y)

        ' Add the new folder control to the form
        Me.Controls.Add(newFolder)
        Dim folderBrowser As New FolderBrowserDialog()
        If folderBrowser.ShowDialog() = DialogResult.OK Then
            Dim oldFolderPath As String = folderBrowser.SelectedPath
            Dim newFolderName As String = InputBox("Enter the new folder name:", "Rename Folder")

            If Not String.IsNullOrEmpty(newFolderName) Then
                Dim newFolderPath As String = IO.Path.Combine(IO.Path.GetDirectoryName(oldFolderPath), newFolderName)
                FileSystem.RenameDirectory(oldFolderPath, newFolderPath)
                MessageBox.Show("Folder renamed successfully!")
            Else
                MessageBox.Show("Please enter a valid folder name.")
            End If
        End If
    End Sub

    Private Sub RoundButton1_Click(sender As Object, e As EventArgs) Handles RoundButton1.Click
        Dim back As New Form3
        back.Show()
        Me.Hide()

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Path\To\Your\Database.accdb"
        Dim query As String = "SELECT NoteID, Title, Content FROM Notes"

        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim adapter As New MySqlCommand(query, connection)
            Dim notesTable As New DataTable()
            adapter.Fill(notesTable)

            ' Assuming you have a DataGridView named dgvNotes on your form:
            dgvNotes.DataSource = notesTable
        End Using
    End Sub
End Class

