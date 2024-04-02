<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Label1 = New Label()
        RoundButton1 = New RoundButton()
        RoundButton2 = New RoundButton()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Rage Italic", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(740, 9)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(166, 50)
        Label1.TabIndex = 1
        Label1.Text = "My Notes"
        ' 
        ' RoundButton1
        ' 
        RoundButton1.BackColor = Color.Transparent
        RoundButton1.FlatAppearance.BorderSize = 0
        RoundButton1.FlatStyle = FlatStyle.Flat
        RoundButton1.Image = CType(resources.GetObject("RoundButton1.Image"), Image)
        RoundButton1.Location = New Point(11, 11)
        RoundButton1.Margin = New Padding(2)
        RoundButton1.Name = "RoundButton1"
        RoundButton1.Size = New Size(45, 45)
        RoundButton1.TabIndex = 4
        RoundButton1.UseVisualStyleBackColor = False
        ' 
        ' RoundButton2
        ' 
        RoundButton2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        RoundButton2.AutoSize = True
        RoundButton2.BackColor = Color.Transparent
        RoundButton2.BackgroundImage = CType(resources.GetObject("RoundButton2.BackgroundImage"), Image)
        RoundButton2.BackgroundImageLayout = ImageLayout.Center
        RoundButton2.Cursor = Cursors.Hand
        RoundButton2.FlatAppearance.BorderSize = 0
        RoundButton2.FlatStyle = FlatStyle.Flat
        RoundButton2.Location = New Point(1466, 587)
        RoundButton2.Margin = New Padding(2)
        RoundButton2.Name = "RoundButton2"
        RoundButton2.Size = New Size(66, 63)
        RoundButton2.TabIndex = 5
        RoundButton2.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSize = True
        BackColor = Color.WhiteSmoke
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1554, 672)
        Controls.Add(RoundButton2)
        Controls.Add(RoundButton1)
        Controls.Add(Label1)
        ForeColor = SystemColors.ActiveCaptionText
        Margin = New Padding(2)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundButton1 As RoundButton
    Friend WithEvents RoundButton2 As RoundButton
End Class