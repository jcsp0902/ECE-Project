Public Class fullmap
    Private Sub fullmap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebKitBrowser1.Navigate(Label1.Text)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form1.Show()

        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class