﻿Public Class Form4


    Private Sub RoundButton2_Click(sender As Object, e As EventArgs) Handles RoundButton2.Click
        Dim newFolder As New folderControl()

        ' Calculate the position for the new folder
        Dim x As Integer = 50 ' Set initial x-coordinate to the edge of the page
        Dim y As Integer = 50 ' Set y-coordinate below the last button
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

    Private Sub RoundButton1_Click(sender As Object, e As EventArgs) Handles RoundButton1.Click
        Dim back As New Form3
        back.Show()
        Me.Hide()

    End Sub



End Class





<<<<<<< HEAD
    End Sub

End Class
=======
>>>>>>> 82e9248b680ce1eb26a78e1ca1b44f18456de091
