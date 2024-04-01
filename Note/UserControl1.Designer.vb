<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
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
        btnEdit = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = SystemColors.MenuBar
        btnEdit.Font = New Font("Rage Italic", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEdit.ForeColor = SystemColors.ActiveCaptionText
        btnEdit.Location = New Point(96, 244)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(112, 34)
        btnEdit.TabIndex = 0
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Rage Italic", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(62, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 50)
        Label1.TabIndex = 1
        Label1.Text = "Title"
        ' 
        ' UserControl1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        Controls.Add(Label1)
        Controls.Add(btnEdit)
        Name = "UserControl1"
        Size = New Size(230, 294)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnEdit As Button
    Friend WithEvents Label1 As Label

End Class
