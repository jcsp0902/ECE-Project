Public Class Port
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.comport = TextBox1.Text
        My.Settings.Save()
        MsgBox("ComPort Updated!")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()

    End Sub

    Private Sub Port_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.comport
        TextBox2.Text = My.Settings.delay
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.delay = TextBox2.Text
        My.Settings.Save()
        MsgBox("delay Updated!")
    End Sub
End Class