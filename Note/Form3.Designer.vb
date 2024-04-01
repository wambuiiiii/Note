<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Button4 = New Button()
        TextBox1 = New TextBox()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        openmenu = New Timer(components)
        closemenu = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Button5 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.Font = New Font("Rage Italic", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(53, 78)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(184, 235)
        Button1.TabIndex = 0
        Button1.Text = "Work"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.Font = New Font("Rage Italic", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(453, 78)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(184, 235)
        Button2.TabIndex = 1
        Button2.Text = "Travel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.Font = New Font("Rage Italic", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))

        Button3.Location = New Point(874, 78)
        Button3.Margin = New Padding(2)

        Button3.Location = New Point(793, 125)

        Button3.Name = "Button3"
        Button3.Size = New Size(184, 235)
        Button3.TabIndex = 2
        Button3.Text = "Personal"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rage Italic", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(303, 9)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(182, 43)
        Label1.TabIndex = 3
        Label1.Text = "My Notebook"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(808, 12)
        Button4.Margin = New Padding(2)
        Button4.Name = "Button4"
        Button4.Padding = New Padding(2)
        Button4.Size = New Size(30, 27)
        Button4.TabIndex = 4
        Button4.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.WhiteSmoke
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(862, 12)
        TextBox1.Margin = New Padding(2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(281, 27)
        TextBox1.TabIndex = 5
        ' 

        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(242, 593)
        Panel1.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(108, 40)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(242, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1218, 593)
        Panel2.TabIndex = 7
        ' 
        ' openmenu
        ' 
        ' 
        ' closemenu
        ' 

        ' Button5
        ' 
        Button5.Font = New Font("Rage Italic", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(83, 30)
        Button5.Name = "Button5"
        Button5.Size = New Size(187, 41)
        Button5.TabIndex = 6
        Button5.Text = "Add Folder"
        Button5.UseVisualStyleBackColor = True

        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSize = True
        BackColor = Color.WhiteSmoke

        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1460, 593)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(2)

        ClientSize = New Size(1825, 693)
        Controls.Add(Button5)
        Controls.Add(TextBox1)
        Controls.Add(Button4)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)

        Name = "Form3"
        Text = "Form3"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents openmenu As Timer
    Friend WithEvents closemenu As Timer

    Friend WithEvents Button5 As Button

End Class
