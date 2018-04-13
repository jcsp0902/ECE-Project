Public Class Edit
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Label10.Text = "TRACKER 1" Then
            My.Settings.tra1id = TextBox1.Text
            My.Settings.tra1name = TextBox2.Text
            MsgBox("Tracker 1 Updated!")
            My.Settings.Save()
            adminmode.Show()
            adminmode.Timer2.Start()
            Me.Close()
        ElseIf Label10.Text = "TRACKER 2" Then
            My.Settings.tra2id = TextBox1.Text
            My.Settings.tra2name = TextBox2.Text
            MsgBox("Tracker 2 Updated!")
            My.Settings.Save()
            adminmode.Show()
            adminmode.Timer2.Start()
            Me.Close()
        ElseIf Label10.Text = "TRACKER 3" Then
            My.Settings.tra3id = TextBox1.Text
            My.Settings.tra3name = TextBox2.Text
            MsgBox("Tracker 3 Updated!")
            My.Settings.Save()
            adminmode.Show()
            adminmode.Timer2.Start()
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Label10.Text = "TRACKER 1" Then
            TextBox1.Text = My.Settings.tra1id
            TextBox2.Text = My.Settings.tra1name
        ElseIf Label10.Text = "TRACKER 2" Then
            TextBox1.Text = My.Settings.tra2id
            TextBox2.Text = My.Settings.tra2name
        ElseIf Label10.Text = "TRACKER 3" Then
            TextBox1.Text = My.Settings.tra3id
            TextBox2.Text = My.Settings.tra3name
        End If
    End Sub
End Class