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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Button1 = New Button()
        Label1 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.Font = New Font("Rage Italic", 20.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(107, 124)
        Button1.Name = "Button1"
        Button1.Size = New Size(161, 176)
        Button1.TabIndex = 0
        Button1.Text = "Personal"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rage Italic", 20.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(821, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(212, 50)
        Label1.TabIndex = 1
        Label1.Text = "My Notebook"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.WhiteSmoke
        Button2.Font = New Font("Rage Italic", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(1625, 605)
        Button2.Name = "Button2"
        Button2.Size = New Size(230, 294)
        Button2.TabIndex = 1
        Button2.Text = "Add Folder"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.Font = New Font("Rage Italic", 20.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(793, 125)
        Button3.Name = "Button3"
        Button3.Size = New Size(230, 294)
        Button3.TabIndex = 2
        Button3.Text = "Travel"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.Location = New Point(1340, 12)
        Button4.Name = "Button4"
        Button4.Size = New Size(38, 34)
        Button4.TabIndex = 4
        Button4.Text = "Work"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(1378, 12)
        TextBox1.Name = "TextBox1"
        Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), Image)
        Button5.Location = New Point(1353, 12)
        Button5.Name = "Button5"
        TextBox1.TabIndex = 5
        Button5.TabIndex = 5
        ' Button5
        ' 
        Button5.Font = New Font("Rage Italic", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(83, 30)
        ' 
        TextBox1.Location = New Point(1387, 12)
        TextBox1.Size = New Size(355, 31)
        TextBox1.TabIndex = 6
        TextBox1.TabIndex = 6
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1825, 693)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
