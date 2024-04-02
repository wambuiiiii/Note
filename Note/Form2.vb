Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form3Instance As New Form3()

        ' Show Form2
        form3Instance.Show()

        ' Optionally, hide Form1 if you don't want it to remain visible
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim form1Instance As New Form1()

        ' Show Form2
        form1Instance.Show()

        ' Optionally, hide Form1 if you don't want it to remain visible
        Me.Hide()
    End Sub
End Class