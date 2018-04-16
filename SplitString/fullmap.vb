Public Class fullmap
    Private Sub fullmap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'WebKitBrowser1.Navigate("http://maps.google.com/maps?q=14%C2%B0+50%27+20.40%22+N,+120%C2%B0+44%27+41.48%22+E")
        WebKitBrowser1.Navigate(Label1.Text)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click


        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub WebKitBrowser1_Load(sender As Object, e As EventArgs) Handles WebKitBrowser1.Load

    End Sub
End Class