Public Class folderControl
    Inherits UserControl

    Friend Title As String

    Public Sub New()
        ' Initialize the control
        InitializeComponent()
    End Sub

    Private Sub FolderControl_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Dim edit As New Form5
        edit.Show()
        Me.Hide()



    End Sub


End Class
