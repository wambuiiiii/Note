﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Panel1 = New Panel()
        parentPanel = New Panel()
        Button7 = New Button()
        PictureBox2 = New PictureBox()
        Panel5 = New Panel()
        Label3 = New Label()
        PictureBox4 = New PictureBox()
        Panel4 = New Panel()
        PictureBox3 = New PictureBox()
        Button6 = New Button()
        openmenu = New Timer(components)
        closemenu = New Timer(components)
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button4 = New Button()
        Button1 = New Button()
        Button3 = New Button()
        Button5 = New Button()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        ContextMenuStrip2 = New ContextMenuStrip(components)
        Panel1.SuspendLayout()
        parentPanel.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(64, 64, 64)
        Panel1.Controls.Add(parentPanel)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(175, 554)
        Panel1.TabIndex = 7
        ' 
        ' parentPanel
        ' 
        parentPanel.AutoSize = True
        parentPanel.BackColor = Color.FromArgb(64, 64, 64)
        parentPanel.BorderStyle = BorderStyle.FixedSingle
        parentPanel.Controls.Add(Button7)
        parentPanel.Controls.Add(PictureBox2)
        parentPanel.Cursor = Cursors.Hand
        parentPanel.Location = New Point(-1, 302)
        parentPanel.Name = "parentPanel"
        parentPanel.Size = New Size(175, 54)
        parentPanel.TabIndex = 0
        ' 
        ' Button7
        ' 
        Button7.Dock = DockStyle.Fill
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Rage Italic", 15.0F)
        Button7.ForeColor = Color.WhiteSmoke
        Button7.Location = New Point(48, 0)
        Button7.Name = "Button7"
        Button7.Size = New Size(125, 52)
        Button7.TabIndex = 8
        Button7.Text = "Settings"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Center
        PictureBox2.Dock = DockStyle.Left
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(48, 52)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(64, 64, 64)
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(Label3)
        Panel5.Controls.Add(PictureBox4)
        Panel5.Cursor = Cursors.Hand
        Panel5.Location = New Point(0, 417)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(175, 58)
        Panel5.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Rage Italic", 15.0F)
        Label3.ForeColor = Color.WhiteSmoke
        Label3.Location = New Point(49, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 56)
        Label3.TabIndex = 3
        Label3.Text = "Logout"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Center
        PictureBox4.Dock = DockStyle.Left
        PictureBox4.Location = New Point(0, 0)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(49, 56)
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(PictureBox3)
        Panel4.Controls.Add(Button6)
        Panel4.Cursor = Cursors.Hand
        Panel4.Location = New Point(0, 212)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(175, 58)
        Panel4.TabIndex = 1
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Center
        PictureBox3.Dock = DockStyle.Left
        PictureBox3.Location = New Point(0, 0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(49, 56)
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.Dock = DockStyle.Fill
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button6.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Rage Italic", 15.0F)
        Button6.ForeColor = Color.Transparent
        Button6.Location = New Point(0, 0)
        Button6.Name = "Button6"
        Button6.Size = New Size(173, 56)
        Button6.TabIndex = 7
        Button6.Text = " Themes"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' openmenu
        ' 
        ' 
        ' closemenu
        ' 
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rage Italic", 20.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label1.Location = New Point(402, 11)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(182, 43)
        Label1.TabIndex = 3
        Label1.Text = "My Notebook"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.Location = New Point(1006, 11)
        TextBox1.Margin = New Padding(2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(268, 27)
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
        Button4.Location = New Point(959, 5)
        Button4.Margin = New Padding(2)
        Button4.Name = "Button4"
        Button4.Size = New Size(34, 36)
        Button4.TabIndex = 4
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Rage Italic", 20.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Button1.ForeColor = Color.WhiteSmoke
        Button1.Location = New Point(647, 98)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(184, 235)
        Button1.TabIndex = 0
        Button1.Text = "Work"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.Cursor = Cursors.Hand
        Button3.Font = New Font("Rage Italic", 20.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Button3.Location = New Point(38, 98)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(184, 235)
        Button3.TabIndex = 2
        Button3.Text = "Personal"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button5.BackColor = Color.Gainsboro
        Button5.Cursor = Cursors.Hand
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Rage Italic", 16.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Button5.Location = New Point(1124, 480)
        Button5.Margin = New Padding(2)
        Button5.Name = "Button5"
        Button5.Size = New Size(150, 33)
        Button5.TabIndex = 6
        Button5.Text = "Add Folder"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Rage Italic", 20.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Button2.Location = New Point(350, 98)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(184, 235)
        Button2.TabIndex = 1
        Button2.Text = "Travel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(6, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(45, 35)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.AutoSize = True
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(175, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1285, 554)
        Panel2.TabIndex = 8
        ' 
        ' ContextMenuStrip2
        ' 
        ContextMenuStrip2.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip2.Name = "ContextMenuStrip2"
        ContextMenuStrip2.Size = New Size(211, 32)
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSize = True
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1460, 554)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(2)
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        parentPanel.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents openmenu As Timer
    Friend WithEvents closemenu As Timer
    Friend WithEvents parentPanel As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
End Class