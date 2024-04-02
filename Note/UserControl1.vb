Imports System.Drawing
Imports System.Reflection.Emit

Public Class UserControl1

    Public Property Title As String
        Get
            Return Label1.Text
        End Get
        Set(value As String)
            Label1.Text = value
            CenterTitle() ' Center the title horizontally and vertically
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
        ' Set default font properties for the title label
        Label1.Font = New Font("Rage Italic", 20, FontStyle.Regular)
        Label1.ForeColor = Color.Black ' Default color
    End Sub

    ' Method to center the title label horizontally and vertically
    Private Sub CenterTitle()
        Label1.Location = New Point((Me.Width - Label1.Width) \ 2, (Me.Height - Label1.Height) \ 2)
    End Sub

    ' Handle the Load event of the UserControl1
    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Center the title label initially
        CenterTitle()
    End Sub

    ' Handle the Click event of the UserControl1
    Private Sub UserControl1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Dim note As New Form4
        note.Show()
        Me.Hide()
    End Sub

    ' Handle the Click event of the Edit button
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.Title = "Select Image File"
        openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        openFileDialog1.Multiselect = False

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ' User selected an image file
            Dim selectedImagePath As String = openFileDialog1.FileName

            ' Now, allow the user to input a title for the folder
            Dim folderTitle As String = InputBox("Enter title for the folder:", "Folder Title")
            Dim colorDialog As New ColorDialog()
            If colorDialog.ShowDialog() = DialogResult.OK Then
                ' Set the color of the title label to the selected color
                Label1.ForeColor = colorDialog.Color
            End If

            ' Resize the selected image to fit the dimensions of the folder control
            Dim resizedImage As Image = ResizeImage(selectedImagePath, 230, 294)

            ' Update the properties of UserControl1 to reflect the changes
            Me.BackgroundImage = resizedImage
            Me.Title = folderTitle

            ' Hide the edit button
            btnEdit.Visible = False
        End If
    End Sub

    ' Method to resize the selected image
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
