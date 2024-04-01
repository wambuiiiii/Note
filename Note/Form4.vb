Public Class Form4

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim newFolder As New folderControl()

        ' Calculate the position for the new folder
        Dim x As Integer = 50 ' Set initial x-coordinate to the edge of the page
        Dim y As Integer = Button3.Location.Y + Button3.Height + 60 ' Set y-coordinate below the last button
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
    End Sub






End Class

