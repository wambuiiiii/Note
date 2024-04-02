Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newFolder As New UserControl1

        ' Calculate the position for the new folder
        Dim x As Integer = Button4.Location.X + 355 ' Set initial x-coordinate to the edge of the page
        Dim y As Integer = Button4.Location.Y ' Set y-coordinate below the last button
        For Each control As Control In Me.Controls ' Iterate through controls within the panel
            If TypeOf control Is UserControl1 Then
                Dim folder As UserControl1 = DirectCast(control, UserControl1)
                If folder.Location.X + folder.Width + 125 < Me.ClientSize.Width Then
                    x = folder.Location.X + folder.Width + 125
                    y = folder.Location.Y
                Else
                    ' Start a new row
                    x = 107 ' Reset x-coordinate to start a new row
                    y = folder.Location.Y + folder.Height + 70
                End If
            End If
        Next

        ' Set the location of the new folder
        newFolder.Location = New Point(x, y)

        ' Add the new folder control to the panel
        Me.Controls.Add(newFolder)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim note As New Form4
        note.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim note As New Form4
        note.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim note As New Form4
        note.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class