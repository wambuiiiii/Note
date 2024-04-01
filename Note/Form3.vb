Imports System.Runtime.InteropServices


﻿Imports System.Runtime.InteropServices
Public Class Form3
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim mnop As Boolean
    Dim mnoc As Boolean
    Dim borderSize As Integer = 5
    Private border As Form = New Form()
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mnoc = True
        mnop = False
        Panel1.Size = New Size(0, Me.Height)
        border.Opacity = 0.1
        border.ShowInTaskbar = False
        border.BackColor = Color.DarkGray
        border.Enabled = False

    End Sub

﻿Public Class Form3


    Private folders As New List(Of UserControl1)()
    Private folder As Control


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim note As New Form4
        note.Show()
        Me.Hide()

    End Sub


    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        drag = True
        mousex = System.Windows.Forms.Cursor.Position.Y - Me.Left
        mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        drag = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Panel1.Size.Width < 175 Then
            openmenu.Enabled = True
            closemenu.Enabled = False
        End If
        If Panel1.Size.Width = 175 Then
            openmenu.Enabled = False
            closemenu.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles openmenu.Tick
        Do Until Panel1.Size.Width = (175)
            Panel1.Size = New Size(Panel1.Width + 1, Me.Height)
            mnoc = False
            mnop = True
        Loop
        If Panel1.Size.Width = (175) Then
            Panel2.Visible = True
            Panel2.Location = New Point(Panel1.Right, Panel2.Top)
            Panel2.Size = New Size(Me.ClientSize.Width - Panel1.Width, Panel2.Height)
        End If
    End Sub

    Private Sub closemenu_Tick(sender As Object, e As EventArgs) Handles closemenu.Tick
        Do Until Panel1.Size.Width = (0)
            Panel1.Size = New Size(Panel1.Width - 1, Me.Height)
            mnoc = True
            mnop = False
        Loop
        If Panel1.Size.Width = (0) Then
            Panel2.Visible = True
        End If
    End Sub

    Private Sub refreshborder()
        border.Show()
        border.Size = New Size(Me.Width + borderSize * 2, Me.Height + borderSize * 2)
        border.Location = New Point(Me.Location.X - borderSize, Me.Location.Y - borderSize)
        SetWindowPos(border.Handle, Me.Handle, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE Or SWP_NOACTIVATE)
    End Sub
    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function SetWindowPos(ByVal hWnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal uFlags As UInteger) As Boolean
    End Function
    Public Const SWP_NOMOVE As Integer = &H2
    Public Const SWP_NOSIZE As Integer = &H1
    Public Const SWP_NOACTIVATE As Integer = &H10

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim newFolder As New UserControl1

        ' Calculate the position for the new folder
        Dim x As Integer = Button3.Location.X + 340 ' Set initial x-coordinate to the edge of the page
        Dim y As Integer = Button3.Location.Y ' Set y-coordinate below the last button
        For Each control As Control In Me.Controls
            If TypeOf control Is UserControl1 Then
                Dim folder As UserControl1 = DirectCast(control, UserControl1)
                If folder.Location.X + folder.Width + 125 < Me.ClientSize.Width Then
                    ' Move to the next position
                    x = folder.Location.X + folder.Width + 125
                    y = folder.Location.Y
                Else
                    ' Start a new row
                    x = 83
                    y = folder.Location.Y + folder.Height + 60
                End If
            End If
        Next

        ' Set the location of the new folder
        newFolder.Location = New Point(x, y)

        ' Add the new folder control to the form
        Me.Controls.Add(newFolder)
        folders.Add(newFolder)

    End Sub
    Public Sub AddExistingFolders()
        For Each folder As UserControl1 In folders

        Next
        Me.Controls.Add(folder)
    End Sub
End Class