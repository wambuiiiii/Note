Imports System.Runtime.InteropServices
Public Class Form3
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim mnop As Boolean
    Dim mnoc As Boolean
    Dim borderSize As Integer = 5
    Private border As Form = New Form()
    Private darkTheme As Boolean = False ' Track the current theme state

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mnoc = True
        mnop = False
        Panel1.Size = New Size(0, Me.Height)
        ApplyTheme()
    End Sub


    Private Sub ApplyTheme()
        If darkTheme Then
            ' Apply dark theme
            Panel2.BackColor = Color.FromArgb(49, 54, 63) ' Set the panel's background color to dark
            For Each ctrl As Control In Me.Controls
                ctrl.ForeColor = Color.White ' Set the text color of all controls to white
            Next
        Else
            ' Apply light theme
            Panel2.BackColor = Color.FromArgb(247, 247, 247) ' Set the panel's background color to light
            For Each ctrl As Control In Me.Controls
                ctrl.ForeColor = SystemColors.ControlText ' Set the text color of all controls to default
            Next
        End If
    End Sub
    Private Sub ToggleTheme()
        darkTheme = Not darkTheme ' Toggle the theme state
        ApplyTheme() ' Apply the updated theme
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



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim note As New Form4
        note.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim newFolder As New UserControl1

        ' Calculate the position for the new folder
        Dim x As Integer = Button1.Location.X + 350 ' Set initial x-coordinate to the edge of the page
        Dim y As Integer = Button1.Location.Y ' Set y-coordinate below the last button
        For Each control As Control In Panel2.Controls ' Iterate through controls within the panel
            If TypeOf control Is UserControl1 Then
                Dim folder As UserControl1 = DirectCast(control, UserControl1)
                If folder.Location.X + folder.Width + 125 < Panel2.ClientSize.Width Then
                    x = folder.Location.X + folder.Width + 125
                    y = folder.Location.Y
                Else
                    ' Start a new row
                    x = 83 ' Reset x-coordinate to start a new row
                    y = folder.Location.Y + folder.Height + 60
                End If
            End If
        Next

        ' Set the location of the new folder
        newFolder.Location = New Point(x, y)

        ' Add the new folder control to the panel
        Panel2.Controls.Add(newFolder)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim note As New Form4
        note.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim note As New Form4
        note.Show()
        Me.Hide()
    End Sub
    Private Sub UserControl1_Click(sender As Object, e As EventArgs)
        Dim note As New Form4
        note.Show()
        Hide()
    End Sub
    Private Sub UserControl2_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Dim note As New Form4
        note.Show()
        Me.Hide()
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
            Panel1.Size = New Size(Panel1.Width + 7, Me.Height)
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
            Panel1.Size = New Size(Panel1.Width - 7, Me.Height)
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Me.DoubleBuffered = True
        Me.BackColor = Color.FromArgb(64, 64, 64)
    End Sub


    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ToggleTheme()
    End Sub

    Private Sub parentPanel_Paint(sender As Object, e As PaintEventArgs) Handles parentPanel.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ' Navigate to the login screen or another appropriate destination
        Dim Form2 As New Form2()
        Form2.Show()

        ' Close or hide the current form
        Me.Close()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub
End Class