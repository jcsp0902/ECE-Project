
Imports System
Imports System.IO.Ports
Public Class adminmode

    Dim comPORT As String
    Dim receivedData As String = ""
    Dim count As Integer
    Dim time As Integer
    Private Sub adminmode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'WebKitBrowser1.Navigate("http://maps.google.com/maps?q=14%C2%B0+50%27+20.40%22+N,+120%C2%B0+44%27+41.48%22+E")
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

        If My.Settings.tra1e = True Then
            PictureBox7.BackgroundImage = My.Resources.exclamation
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
        SerialPort1.Close()

        Login.Show()

        Me.Close()

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        SerialPort1.Write(1)
        PictureBox8.BackgroundImage = My.Resources.Ski_trail_rating_symbol_red_circle
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

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label1.Text = My.Settings.tra1id
        Label17.Text = My.Settings.tra1name

        Label26.Text = My.Settings.tra2id
        Label5.Text = My.Settings.tra2name


        Label40.Text = My.Settings.tra3id
        Label29.Text = My.Settings.tra3name
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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Port.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RichTextBox1.Clear()
        receivedData = ReceiveSerialData()
        RichTextBox1.Text &= receivedData
        If Not RichTextBox1.Text = "" Then
            Label9.Text = RichTextBox1.Text
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Edit.Show()
        Edit.Label10.Text = "TRACKER 1"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Edit.Show()
        Edit.Label10.Text = "TRACKER 2"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Edit.Show()
        Edit.Label10.Text = "TRACKER 3"
    End Sub

    Private Sub Label9_TextChanged(sender As Object, e As EventArgs) Handles Label9.TextChanged
        count = 0
        'Dim s As String = "1234567890*0*29.58*"
        If Label9.Text = "222" Then
            PictureBox7.BackgroundImage = My.Resources.exclamation
            My.Settings.tra1e = True
            My.Settings.Save()

        ElseIf Label9.Text = "2" Then
            PictureBox7.BackgroundImage = My.Resources.exclamation
            My.Settings.tra1e = True
            My.Settings.Save()
        ElseIf Label9.Text = "22" Then
            PictureBox7.BackgroundImage = My.Resources.exclamation
            My.Settings.tra1e = True
            My.Settings.Save()
        ElseIf Label9.Text = "2222" Then
            PictureBox7.BackgroundImage = My.Resources.exclamation
            My.Settings.tra1e = True
            My.Settings.Save()
        ElseIf Label9.Text = "22222" Then
            PictureBox7.BackgroundImage = My.Resources.exclamation
            My.Settings.tra1e = True
            My.Settings.Save()
        Else

            Dim s As String = Label9.Text
            ' Split string based on comma

            If Not s.Contains("G") Then
                Dim words As String() = s.Split(New Char() {"*"c})

                ' Use For Each loop over words and display them

                Dim word As String
                For Each word In words
                    If count = 0 Then
                        ' Label1.Text = word
                    ElseIf count = 1 Then
                        'Label2.Text = word
                    ElseIf count = 2 Then
                        Try
                            Label3.Text = word

                        Catch ex As Exception

                        End Try
                    ElseIf count = 3 Then
                        Try
                            Label44.Text = word

                        Catch ex As Exception

                        End Try
                    ElseIf count = 4 Then
                        Try
                            Label45.Text = word

                        Catch ex As Exception

                        End Try
                    ElseIf count = 5 Then
                        Try
                            If Not word = "" Then
                                If time = 10 Then
                                    Label4.Text = word
                                    time = 0
                                Else
                                    time = time + 1
                                End If
                            End If

                        Catch ex As Exception

                        End Try
                    Else
                        count = 0
                    End If
                    count = count + 1
                Next
            End If



        End If

    End Sub

    Private Sub Label4_TextChanged(sender As Object, e As EventArgs) Handles Label4.TextChanged
        WebKitBrowser1.Navigate(Label4.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        fullmap.Label1.Text = Label4.Text
    End Sub

    Private Sub Label2_TextChanged(sender As Object, e As EventArgs) Handles Label2.TextChanged
        If Label2.Text >= 40 Then
            Label7.Text = "Normal"
            PictureBox5.BackgroundImage = My.Resources.green
        ElseIf Label2.Text > 0 Then
            Label7.Text = "Critical"
            PictureBox5.BackgroundImage = My.Resources.Ski_trail_rating_symbol_red_circle
        ElseIf Label2.Text > 0 Then
            Label7.Text = "Critical"
            PictureBox5.BackgroundImage = My.Resources.Ski_trail_rating_symbol_red_circle
        ElseIf Label2.Text = 0 Then
            Label7.Text = "Dead"
            PictureBox5.BackgroundImage = My.Resources.black
        End If
    End Sub

    Private Sub Label6_TextChanged(sender As Object, e As EventArgs) Handles Label6.TextChanged
        If Label6.Text >= 40 Then
            Label27.Text = "Normal"
            PictureBox10.BackgroundImage = My.Resources.green
        ElseIf Label6.Text > 0 Then
            Label27.Text = "Critical"
            PictureBox10.BackgroundImage = My.Resources.Ski_trail_rating_symbol_red_circle
        ElseIf Label6.Text > 0 Then
            Label27.Text = "Critical"
            PictureBox10.BackgroundImage = My.Resources.Ski_trail_rating_symbol_red_circle
        ElseIf Label6.Text = 0 Then
            Label27.Text = "Dead"
            PictureBox10.BackgroundImage = My.Resources.black
        End If
    End Sub

    Private Sub Label30_TextChanged(sender As Object, e As EventArgs) Handles Label30.TextChanged
        If Label30.Text >= 40 Then
            Label41.Text = "Normal"
            PictureBox13.BackgroundImage = My.Resources.green
        ElseIf Label30.Text > 0 Then
            Label41.Text = "Critical"
            PictureBox13.BackgroundImage = My.Resources.Ski_trail_rating_symbol_red_circle
        ElseIf Label30.Text > 0 Then
            Label41.Text = "Critical"
            PictureBox13.BackgroundImage = My.Resources.Ski_trail_rating_symbol_red_circle
        ElseIf Label30.Text = 0 Then
            Label41.Text = "Dead"
            PictureBox13.BackgroundImage = My.Resources.black
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        PictureBox7.BackgroundImage = My.Resources.Circle___black_simple_fullpage1
        PictureBox8.BackgroundImage = My.Resources.orange
        My.Settings.tra1e = False
        My.Settings.Save()

    End Sub
End Class