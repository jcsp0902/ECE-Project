Imports System
Imports System.IO.Ports
Public Class Form1

    Dim comPORT As String
    Dim receivedData As String = ""
    Dim count As Integer
    Dim time As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebKitBrowser1.Navigate("http://maps.google.com/maps?q=14%C2%B0+50%27+20.40%22+N,+120%C2%B0+44%27+41.48%22+E")
        Label1.Text = My.Settings.tra1id
        Label17.Text = My.Settings.tra1name

        Label26.Text = My.Settings.tra2id
        Label5.Text = My.Settings.tra2name


        Label40.Text = My.Settings.tra3id
        Label29.Text = My.Settings.tra3name








        If My.Settings.tracker = 1 Then
            Panel1.Show()
            Panel2.Hide()
            Panel3.Hide()


        ElseIf My.Settings.tracker = 2 Then
            Panel1.Show()
            Panel2.Show()
            Panel3.Hide()

        ElseIf My.Settings.tracker = 3 Then
            Panel1.Show()
            Panel2.Show()
            Panel3.Show()

        End If
        Try
            SerialPort1.Close()
            SerialPort1.PortName = My.Settings.comport
            SerialPort1.BaudRate = 115200
            SerialPort1.DataBits = 8
            SerialPort1.Parity = Parity.None
            SerialPort1.StopBits = StopBits.One
            SerialPort1.Handshake = Handshake.None
            SerialPort1.Encoding = System.Text.Encoding.Default 'very important!
            SerialPort1.ReadTimeout = 10000
            SerialPort1.Open()
            Timer1.Enabled = True

            RichTextBox1.Clear()
            receivedData = ReceiveSerialData()
            RichTextBox1.Text &= receivedData
            If Not RichTextBox1.Text = "" Then
                Label9.Text = RichTextBox1.Text
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        SerialPort1.Write(1)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RichTextBox1.Clear()
        receivedData = ReceiveSerialData()
        RichTextBox1.Text &= receivedData
        If Not RichTextBox1.Text = "" Then
            Label9.Text = RichTextBox1.Text
        End If
    End Sub
    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try

    End Function

    Private Sub Label9_TextChanged(sender As Object, e As EventArgs) Handles Label9.TextChanged
        count = 0
        'Dim s As String = "1234567890*0*29.58*"
        If Label9.Text = "222" Then
            PictureBox7.BackgroundImage = My.Resources.exclamation
        ElseIf Label9.Text = "2" Then
            PictureBox7.BackgroundImage = My.Resources.exclamation
        ElseIf Label9.Text = "22" Then
            PictureBox7.BackgroundImage = My.Resources.exclamation
        Else
            If time = 30 Then
                Dim s As String = Label9.Text
                ' Split string based on comma

                If Not s.Contains("$") Then
                    Dim words As String() = s.Split(New Char() {"*"c})

                    ' Use For Each loop over words and display them

                    Dim word As String
                    For Each word In words
                        If count = 0 Then
                            Label1.Text = word
                        ElseIf count = 1 Then
                            Label2.Text = word
                        ElseIf count = 2 Then
                            Label3.Text = word
                        ElseIf count = 3 Then
                            Label44.Text = word
                        ElseIf count = 4 Then
                            Label45.Text = word
                        ElseIf count = 5 Then
                            Try
                                If Not word = "" Then
                                    Label4.Text = word
                                End If

                            Catch ex As Exception

                            End Try
                        Else
                            count = 0
                        End If
                        count = count + 1
                    Next
                    MsgBox("yow")
                End If
                time = 0
            Else
                time = time + 1
                MsgBox(time)
            End If

        End If


    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()

        fullmap.Label1.Text = Label4.Text
        fullmap.Show()

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel4_MouseClick(sender As Object, e As MouseEventArgs)
        Me.Close()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()

    End Sub

    Private Sub Label2_TextChanged(sender As Object, e As EventArgs) Handles Label2.TextChanged
        If Label2.Text >= 40 Then
            Label7.Text = "Normal"
            PictureBox4.BackgroundImage = My.Resources.green
        ElseIf Label2.Text > 0 Then
            Label7.Text = "Critical"
            PictureBox4.BackgroundImage = My.Resources.Ski_trail_rating_symbol_red_circle
        ElseIf Label2.Text = 0 Then
            Label7.Text = "Dead"
            PictureBox4.BackgroundImage = My.Resources.black
        End If
    End Sub

    Private Sub Label28_TextChanged(sender As Object, e As EventArgs) Handles Label28.TextChanged
        If Label28.Text >= 40 Then
            Label19.Text = "Normal"
            PictureBox5.BackgroundImage = My.Resources.green
        ElseIf Label28.Text > 0 Then
            Label19.Text = "Critical"
            PictureBox5.BackgroundImage = My.Resources.Ski_trail_rating_symbol_red_circle
        ElseIf Label28.Text = 0 Then
            Label19.Text = "Dead"
            PictureBox5.BackgroundImage = My.Resources.black
        End If
    End Sub

    Private Sub Label42_TextChanged(sender As Object, e As EventArgs) Handles Label42.TextChanged
        If Label42.Text >= 40 Then

            Label33.Text = "Normal"
            PictureBox6.BackgroundImage = My.Resources.green
        ElseIf Label42.Text > 0 Then
            Label33.Text = "Critical"
            PictureBox6.BackgroundImage = My.Resources.Ski_trail_rating_symbol_red_circle
        ElseIf Label42.Text = 0 Then
            Label33.Text = "Dead"
            PictureBox6.BackgroundImage = My.Resources.black
        End If
    End Sub

    Private Sub Label43_MouseClick(sender As Object, e As MouseEventArgs) Handles Label43.MouseClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        Label43.Text = "TRACKER 2"
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Label43.Text = "TRACKER 1"
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Label43.Text = "TRACKER 3"
    End Sub

    Private Sub Label43_TextChanged(sender As Object, e As EventArgs) Handles Label43.TextChanged
        If Label43.Text = "TRACKER 1" Then
            WebKitBrowser1.Navigate(Label4.Text)
        ElseIf Label43.Text = "TRACKER 2" Then
            WebKitBrowser1.Navigate(Label25.Text)
        ElseIf Label43.Text = "TRACKER 3" Then
            WebKitBrowser1.Navigate(Label39.Text)
        End If
    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        PictureBox7.BackgroundImage = My.Resources.Circle___black_simple_fullpage_svg
        SerialPort1.Write(1)
    End Sub

    Private Sub Label4_TextChanged(sender As Object, e As EventArgs) Handles Label4.TextChanged
        WebKitBrowser1.Navigate(Label4.Text)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label4.Text = "http://maps.google.com/maps?q=14%C2%B0+50%27+20.40%22+N,+120%C2%B0+44%27+41.48%22+W"
    End Sub
End Class
