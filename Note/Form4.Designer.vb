﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
<<<<<<< HEAD
        Label1.Font = New Font("Rage Italic", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(809, 9)
=======
        Label1.Font = New Font("Rage Italic", 20.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(647, 7)
        Label1.Margin = New Padding(2, 0, 2, 0)
>>>>>>> d6b9f6266a2d0d1d94033548a9d19250eda27555
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 43)
        Label1.TabIndex = 1
        Label1.Text = "My Notes"
        ' 
        ' RoundButton1
        ' 
        RoundButton1.BackColor = Color.Transparent
        RoundButton1.FlatAppearance.BorderSize = 0
        RoundButton1.FlatStyle = FlatStyle.Flat
        RoundButton1.Image = CType(resources.GetObject("RoundButton1.Image"), Image)
        RoundButton1.Location = New Point(10, 15)
        RoundButton1.Margin = New Padding(2, 2, 2, 2)
        RoundButton1.Name = "RoundButton1"
        RoundButton1.Size = New Size(40, 40)
        RoundButton1.TabIndex = 4
        RoundButton1.UseVisualStyleBackColor = False
        ' 
        ' RoundButton2
        ' 
        RoundButton2.BackColor = Color.Transparent
        RoundButton2.FlatAppearance.BorderSize = 0
        RoundButton2.FlatStyle = FlatStyle.Flat
        RoundButton2.Image = CType(resources.GetObject("RoundButton2.Image"), Image)
<<<<<<< HEAD
        RoundButton2.Location = New Point(92, 21)
=======
        RoundButton2.Location = New Point(74, 17)
        RoundButton2.Margin = New Padding(2, 2, 2, 2)
>>>>>>> d6b9f6266a2d0d1d94033548a9d19250eda27555
        RoundButton2.Name = "RoundButton2"
        RoundButton2.Size = New Size(38, 38)
        RoundButton2.TabIndex = 5
        RoundButton2.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
<<<<<<< HEAD
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSize = True
        BackColor = Color.Teal
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1554, 673)
=======
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSize = True
        BackColor = Color.MintCream
        ClientSize = New Size(1243, 538)
>>>>>>> d6b9f6266a2d0d1d94033548a9d19250eda27555
        Controls.Add(RoundButton2)
        Controls.Add(RoundButton1)
        Controls.Add(Label1)
        Margin = New Padding(2, 2, 2, 2)
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