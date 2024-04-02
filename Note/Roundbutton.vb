Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class RoundButton
    Inherits Button

    Public Sub New()
        Me.BackColor = Color.Transparent
        Me.FlatStyle = FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 0
    End Sub
End Class
