Public Class Form1


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Create an instance of Form1




        Dim button As New Form2


        button.Show()
        button.Focus()
        Me.Hide()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
