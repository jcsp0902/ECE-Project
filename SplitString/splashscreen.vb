Public Class splashscreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Login.Show()

        Me.Close()

    End Sub
End Class