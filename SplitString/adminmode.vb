Public Class adminmode
    Private Sub adminmode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebKitBrowser1.Navigate("http://maps.google.com/maps?q=14%C2%B0+50%27+20.40%22+N,+120%C2%B0+44%27+41.48%22+E")
        Label1.Text = My.Settings.tra1id
        Label17.Text = My.Settings.tra1name

        Label26.Text = My.Settings.tra2id
        Label5.Text = My.Settings.tra2name


        Label40.Text = My.Settings.tra3id
        Label29.Text = My.Settings.tra3name
        MsgBox(My.Settings.tracker)
        If My.Settings.tracker = 1 Then
            Panel1.Show()
            Panel3.Hide()
            Panel4.Hide()


        ElseIf My.Settings.tracker = 2 Then
            Panel1.Show()
            Panel3.Show()
            Panel4.Hide()

        ElseIf My.Settings.tracker = 3 Then
            Panel1.Show()
            Panel3.Show()
            Panel4.Show()

        End If
        If My.Settings.tracker = 3 Then
            PictureBox4.Enabled = False

        End If

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Add_tracker.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click
        Login.Show()

        Me.Close()

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Label43.Text = "TRACKER 1"
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Label43.Text = "TRACKER 2"
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        Label43.Text = "TRACKER 3"
    End Sub
End Class