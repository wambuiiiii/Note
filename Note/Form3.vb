Public Class Form3


    Private folders As New List(Of UserControl1)()
    Private folder As Control

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim note As New Form4
        note.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim newFolder As New UserControl1

        ' Calculate the position for the new folder
        Dim x As Integer = Button3.Location.X + 340 ' Set initial x-coordinate to the edge of the page
        Dim y As Integer = Button3.Location.Y ' Set y-coordinate below the last button
        For Each control As Control In Me.Controls
            If TypeOf control Is UserControl1 Then
                Dim folder As UserControl1 = DirectCast(control, UserControl1)
                If folder.Location.X + folder.Width + 125 < Me.ClientSize.Width Then
                    ' Move to the next position
                    x = folder.Location.X + folder.Width + 125
                    y = folder.Location.Y
                Else
                    ' Start a new row
                    x = 83
                    y = folder.Location.Y + folder.Height + 60
                End If
            End If
        Next

        ' Set the location of the new folder
        newFolder.Location = New Point(x, y)

        ' Add the new folder control to the form
        Me.Controls.Add(newFolder)
        folders.Add(newFolder)

    End Sub
    Public Sub AddExistingFolders()
        For Each folder As UserControl1 In folders

        Next
        Me.Controls.Add(folder)
    End Sub

End Class