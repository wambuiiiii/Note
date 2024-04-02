Public Class Form6
    Private darkTheme As Boolean = True ' Track the current theme state

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Apply the initial theme
        ApplyTheme()
    End Sub

    Private Sub ApplyTheme()
        If darkTheme Then
            ' Apply dark theme
            Panel1.BackColor = Color.FromArgb(32, 32, 32) ' Set the panel's background color to dark
            For Each ctrl As Control In Me.Controls
                ctrl.ForeColor = Color.White ' Set the text color of all controls to white
            Next
        Else
            ' Apply light theme
            Panel1.BackColor = SystemColors.Control ' Set the panel's background color to light
            For Each ctrl As Control In Me.Controls
                ctrl.ForeColor = SystemColors.ControlText ' Set the text color of all controls to default
            Next
        End If
    End Sub

    Private Sub ToggleTheme()
        darkTheme = Not darkTheme ' Toggle the theme state
        ApplyTheme() ' Apply the updated theme
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ToggleTheme() ' Toggle the theme when the button is clicked
    End Sub
End Class