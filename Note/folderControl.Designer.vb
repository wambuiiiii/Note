<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class folderControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rage Italic", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(29, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 50)
        Label1.TabIndex = 0
        Label1.Text = "Blank "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rage Italic", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(40, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 50)
        Label2.TabIndex = 1
        Label2.Text = "Note" & vbCrLf
        ' 
        ' folderControl
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "folderControl"
        Size = New Size(191, 255)
        Tag = "Blank Note"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
