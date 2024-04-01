Imports System.Reflection.Emit

Public Class UserControl2


    Public Property Title As String
        Get
            Return Label1.Text
        End Get
        Set(value As String)
            Label1.Text = value
            CenterTitle() ' Call the method to center the title label
        End Set
    End Property

    Public Property Label1 As Object

    ' Method to center the title label horizontally
    Private Sub CenterTitle()
        Label1.Location = New Point((Me.Width - Label1.Width) \ 2, 99)
    End Sub

    ' Handle the Load event of the folderControl
    Private Sub folderControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the font and size of the title label
        Label1.Font = New Font("Rage Italic", 20, FontStyle.Regular)
        ' Center the title label initially
        CenterTitle()
    End Sub

    ' Handle the Click event of the folderControl
    Private Sub folderControl_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        ' Open a new form when the folder control is clicked
        Dim newForm As New Form()
        newForm.Text = Title ' Set the title of the new form to the folder title
        newForm.ShowDialog()
    End Sub

End Class
