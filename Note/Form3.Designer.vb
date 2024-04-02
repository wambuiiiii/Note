<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Button1 = New Button()
        Label1 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        TextBox1 = New TextBox()
        Panel1 = New Panel()
        Panel5 = New Panel()
        Button6 = New Button()
        PictureBox4 = New PictureBox()
        Panel4 = New Panel()
        Button7 = New Button()
        PictureBox3 = New PictureBox()
        Panel3 = New Panel()
        Button8 = New Button()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        openmenu = New Timer(components)
        closemenu = New Timer(components)
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Rage Italic", 20.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(420, 76)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(230, 294)
        Button1.TabIndex = 0
        Button1.Text = "Personal"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rage Italic", 20.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(505, 16)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(182, 43)
        Label1.TabIndex = 1
        Label1.Text = "My Notebook"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.WhiteSmoke
        Button2.AutoSize = True
        Button2.BackColor = SystemColors.ButtonFace
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.Font = New Font("Rage Italic", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(1119, 600)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(143, 40)
        Button2.TabIndex = 2
        Button2.Text = "Add Folder"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.Font = New Font("Rage Italic", 20.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(462, 124)
        Button3.Name = "Button3"
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(184, 235)
        Button3.TabIndex = 3
        Button3.Text = "Travel"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.Font = New Font("Rage Italic", 20.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.Location = New Point(817, 124)
        Button4.Location = New Point(747, 76)
        Button4.Margin = New Padding(2)
        Button4.Name = "Button4"
        Button4.Size = New Size(184, 235)
        Button4.TabIndex = 4
        Button4.Text = "Work"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), Image)
        Button5.BackgroundImageLayout = ImageLayout.Zoom
        Button5.Cursor = Cursors.Hand
        Button5.Cursor = Cursors.Hand
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(900, 16)
        Button5.Margin = New Padding(2)
        Button5.Name = "Button5"
        Button5.Size = New Size(31, 34)
        Button5.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(1387, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(355, 31)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(325, 27)
        TextBox1.TabIndex = 6
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(53))
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(180, 654)
        Panel1.TabIndex = 7
        ' 
        ' Panel5
        ' 
        Panel5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel5.Controls.Add(Button6)
        Panel5.Controls.Add(PictureBox4)
        Panel5.Location = New Point(3, 420)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(177, 58)
        Panel5.TabIndex = 2
        ' 
        ' Button6
        ' 
        Button6.AutoSize = True
        Button6.BackgroundImageLayout = ImageLayout.None
        Button6.Cursor = Cursors.Hand
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Rage Italic", 13.0F)
        Button6.ForeColor = SystemColors.ButtonFace
        Button6.Location = New Point(68, 9)
        Button6.Name = "Button6"
        Button6.Size = New Size(94, 38)
        Button6.TabIndex = 1
        Button6.Text = "Logout"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImageLayout = ImageLayout.None
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(5, 4)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(57, 51)
        PictureBox4.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel4.Controls.Add(Button7)
        Panel4.Controls.Add(PictureBox3)
        Panel4.Location = New Point(2, 299)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(178, 62)
        Panel4.TabIndex = 1
        ' 
        ' Button7
        ' 
        Button7.AutoSize = True
        Button7.BackgroundImageLayout = ImageLayout.None
        Button7.Cursor = Cursors.Hand
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Rage Italic", 13.0F)
        Button7.ForeColor = SystemColors.ButtonFace
        Button7.Location = New Point(68, 14)
        Button7.Name = "Button7"
        Button7.Size = New Size(94, 38)
        Button7.TabIndex = 2
        Button7.Text = "Settings"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImageLayout = ImageLayout.None
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(5, 7)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(57, 51)
        PictureBox3.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.Controls.Add(Button8)
        Panel3.Controls.Add(PictureBox2)
        Panel3.Location = New Point(0, 206)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(180, 63)
        Panel3.TabIndex = 0
        ' 
        ' Button8
        ' 
        Button8.AutoSize = True
        Button8.BackgroundImageLayout = ImageLayout.None
        Button8.Cursor = Cursors.Hand
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Rage Italic", 13.0F)
        Button8.ForeColor = SystemColors.ButtonFace
        Button8.Location = New Point(71, 14)
        Button8.Name = "Button8"
        Button8.Size = New Size(94, 38)
        Button8.TabIndex = 2
        Button8.Text = "Themes"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.None
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(5, 9)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(57, 51)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.WhiteSmoke
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Button4)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(180, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1282, 654)
        Panel2.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(6, 11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(48, 32)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' openmenu
        ' 
        ' 
        ' closemenu
        ' 
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1462, 654)
        Controls.Add(TextBox1)
        Controls.Add(Button5)
        Margin = New Padding(2)
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents openmenu As Timer
    Friend WithEvents closemenu As Timer
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
