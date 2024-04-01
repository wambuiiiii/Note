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
        Button5 = New Button()
        TextBox1 = New TextBox()
        Button4 = New Button()
        Button3 = New Button()
        Panel1 = New Panel()
        Panel5 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox4 = New PictureBox()
        Panel4 = New Panel()
        Label4 = New Label()
        PictureBox3 = New PictureBox()
        Panel3 = New Panel()
        Label5 = New Label()
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
        Button1.Font = New Font("Rage Italic", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.WhiteSmoke
        Button1.Location = New Point(809, 122)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(230, 294)
        Button1.TabIndex = 0
        Button1.Text = "Work"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rage Italic", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(502, 14)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(212, 50)
        Label1.TabIndex = 3
        Label1.Text = "My Notebook"
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.Font = New Font("Rage Italic", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(438, 122)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(230, 294)
        Button2.TabIndex = 1
        Button2.Text = "Travel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Button5.Font = New Font("Rage Italic", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(1405, 638)
        Button5.Margin = New Padding(2)
        Button5.Name = "Button5"
        Button5.Size = New Size(170, 41)
        Button5.TabIndex = 6
        Button5.Text = "Add Folder"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.Location = New Point(1258, 14)
        TextBox1.Margin = New Padding(2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(316, 31)
        TextBox1.TabIndex = 5
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.BackgroundImageLayout = ImageLayout.Zoom
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(1199, 6)
        Button4.Margin = New Padding(2)
        Button4.Name = "Button4"
        Button4.Size = New Size(42, 45)
        Button4.TabIndex = 4
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.Font = New Font("Rage Italic", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(48, 122)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(230, 294)
        Button3.TabIndex = 2
        Button3.Text = "Personal"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(237, 692)
        Panel1.TabIndex = 7
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Transparent
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(Label3)
        Panel5.Controls.Add(Label2)
        Panel5.Controls.Add(PictureBox4)
        Panel5.Cursor = Cursors.Hand
        Panel5.Location = New Point(0, 521)
        Panel5.Margin = New Padding(4)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(218, 72)
        Panel5.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Rage Italic", 15F)
        Label3.ForeColor = Color.WhiteSmoke
        Label3.Location = New Point(69, 21)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 31)
        Label3.TabIndex = 2
        Label3.Text = "Logout"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(69, 21)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 31)
        Label2.TabIndex = 1
        Label2.Text = "Logout"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Center
        PictureBox4.Dock = DockStyle.Left
        PictureBox4.Location = New Point(0, 0)
        PictureBox4.Margin = New Padding(4)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(61, 70)
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(PictureBox3)
        Panel4.Cursor = Cursors.Hand
        Panel4.Location = New Point(11, 212)
        Panel4.Margin = New Padding(4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(218, 72)
        Panel4.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Rage Italic", 15F)
        Label4.ForeColor = Color.WhiteSmoke
        Label4.Location = New Point(69, 21)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 31)
        Label4.TabIndex = 3
        Label4.Text = "Themes"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Center
        PictureBox3.Dock = DockStyle.Left
        PictureBox3.Location = New Point(0, 0)
        PictureBox3.Margin = New Padding(4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(61, 70)
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Transparent
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(PictureBox2)
        Panel3.Cursor = Cursors.Hand
        Panel3.Location = New Point(11, 84)
        Panel3.Margin = New Padding(4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(218, 72)
        Panel3.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Rage Italic", 15F)
        Label5.ForeColor = Color.WhiteSmoke
        Label5.Location = New Point(8, 74)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 31)
        Label5.TabIndex = 3
        Label5.Text = "Settings"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Center
        PictureBox2.Dock = DockStyle.Left
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Margin = New Padding(4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(61, 70)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(237, 0)
        Panel2.Margin = New Padding(4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1588, 692)
        Panel2.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(6, 7)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(56, 44)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 6
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
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSize = True
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1825, 692)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(2)
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents openmenu As Timer
    Friend WithEvents closemenu As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class