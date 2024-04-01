Imports System.Drawing

Public Class UserControl1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.Title = "Select Image File"
        openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        openFileDialog1.Multiselect = False

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ' User selected an image file
            Dim selectedImagePath As String = openFileDialog1.FileName

            ' Now, allow the user to input a title for the folder
            Dim folderTitle As String = InputBox("Enter title for the folder:", "Folder Title")

            ' Resize the selected image to fit the dimensions of the folder control
            Dim resizedImage As Image = ResizeImage(selectedImagePath, 230, 294)

            ' Once the title is obtained, you can create a customized folder with the selected image and title
            Dim newFolder As New UserControl2()
            newFolder.BackgroundImage = resizedImage
            newFolder.Title = folderTitle

            ' Add the new folder control to the form
            Me.Controls.Add(newFolder)

            ' Optionally, you can adjust the location of the new folder control
            ' based on your layout requirements
        End If
    End Sub

    Private Function ResizeImage(imagePath As String, width As Integer, height As Integer) As Image
        Dim originalImage As Image = Image.FromFile(imagePath)
        Dim resizedImage As New Bitmap(width, height)

        Using g As Graphics = Graphics.FromImage(resizedImage)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(originalImage, 0, 0, width, height)
        End Using

        Return resizedImage
    End Function
End Class
