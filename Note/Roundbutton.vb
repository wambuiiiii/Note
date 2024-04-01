Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class RoundButton
    Inherits Button

    Public Sub New()
        Me.BackColor = Color.Transparent
        Me.FlatStyle = FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 0
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim graphicsPath As New GraphicsPath()
        graphicsPath.AddEllipse(0, 0, Me.Width, Me.Height)
        Me.Region = New Region(graphicsPath)
        MyBase.OnPaint(e)
    End Sub
End Class
