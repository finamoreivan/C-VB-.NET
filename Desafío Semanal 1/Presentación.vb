Public Class Presentación
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim per As New Perdiste
        per.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resp1 As New Dragon1
        resp1.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim resp2 As New Demonio1
        resp2.ShowDialog()
    End Sub
End Class