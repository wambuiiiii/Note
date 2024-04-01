Public Class folderControl
    Inherits UserControl

    Public Sub New()
        ' Initialize the control
        InitializeComponent()
    End Sub

    Private Sub FolderControl_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Dim edit As New Form5
        edit.Show()
        Me.Hide()


        MessageBox.Show("Folder Clicked!") ' For example, show a message box
    End Sub
End Class
