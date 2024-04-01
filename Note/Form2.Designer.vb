<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Panel1 = New Panel()
        LinkLabel1 = New LinkLabel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(121), CByte(105), CByte(241), CByte(255))
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Button1.Location = New Point(45, 321)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(348, 47)
        Button1.TabIndex = 0
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(64, 245)
        TextBox1.Margin = New Padding(2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(329, 27)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(64, 122)
        TextBox2.Margin = New Padding(2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(329, 27)
        TextBox2.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLightLight
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Location = New Point(36, 53)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(415, 504)
        Panel1.TabIndex = 3
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        LinkLabel1.AutoSize = True
        LinkLabel1.DisabledLinkColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        LinkLabel1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        LinkLabel1.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabel1.LinkColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        LinkLabel1.Location = New Point(126, 384)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(196, 25)
        LinkLabel1.TabIndex = 8
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "New? Click here to sign up "
        LinkLabel1.UseCompatibleTextRendering = True
        LinkLabel1.VisitedLinkColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(31, 243)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(29, 37)
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(31, 122)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(29, 25)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(64, 212)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 20)
        Label2.TabIndex = 5
        Label2.Text = "Password:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(64, 91)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 20)
        Label1.TabIndex = 4
        Label1.Text = "Email:"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(489, 648)
        Controls.Add(Panel1)
        Margin = New Padding(2)
        MaximizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
