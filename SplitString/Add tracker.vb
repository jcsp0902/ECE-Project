Public Class Add_tracker
    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Settings.tracker = 0 Then
            TextBox1.Text = My.Settings.tra1id
            TextBox2.Text = My.Settings.tra1name
            My.Settings.tracker = 1
            My.Settings.Save()
            MsgBox("Tracker " + TextBox1.Text + " Successfully Added!")
            adminmode.Show()
            Me.Close()

        ElseIf My.Settings.tracker = 1 Then
            TextBox1.Text = My.Settings.tra2id
            TextBox2.Text = My.Settings.tra2name
            My.Settings.tracker = 2
            My.Settings.Save()
            MsgBox("Tracker " + TextBox1.Text + " Successfully Added!")
            adminmode.Show()
            Me.Close()
        ElseIf My.Settings.tracker = 2 Then
            TextBox1.Text = My.Settings.tra3id
            TextBox2.Text = My.Settings.tra3name
            My.Settings.tracker = 2
            My.Settings.Save()
            MsgBox("Tracker " + TextBox1.Text + " Successfully Added!")
            adminmode.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Add_tracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.tracker = 0 Then
            Label10.Text = "TRACKER 1"
        ElseIf My.Settings.tracker = 1 Then
            Label10.Text = "TRACKER 2"
        ElseIf My.Settings.tracker = 2 Then
            Label10.Text = "TRACKER 3"
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub
End Class