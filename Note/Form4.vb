Public Class Form4
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim newFolder As New folderControl()

        ' Set its position next to the last folder
        Dim lastFolder As Control = If(Me.Controls.OfType(Of folderControl)().LastOrDefault(), Button3)
        Dim x As Integer = lastFolder.Location.X + lastFolder.Width + 140 ' Adjust the spacing
        Dim y As Integer = lastFolder.Location.Y
        If x + newFolder.Width > Me.ClientSize.Width Then ' Check if new row is needed
            x = Button3.Location.X
            y += lastFolder.Height + 50 ' Adjust vertical spacing
        End If
        newFolder.Location = New Point(x, y)

        ' Add the new folder control to the form
        Me.Controls.Add(newFolder)
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class

