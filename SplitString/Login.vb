Public Class Login
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.close
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            adminmode.Show()
            Me.Close()
        Else
            MsgBox("Wrong Username or Password!")
        End If
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        If TextBox1.Text = "estef" And TextBox2.Text = "ganda" Then

            Form1.Show()

            Me.Close()
        Else
            MsgBox("Wrong Username and password")
        End If

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.Close()

    End Sub
End Class