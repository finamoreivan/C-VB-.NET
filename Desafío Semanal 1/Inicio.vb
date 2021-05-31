Public Class Inicio
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bIniciar_Click(sender As Object, e As EventArgs) Handles bIniciar.Click
        Dim inicio As New Presentación
        inicio.ShowDialog()

    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        If MessageBox.Show("¿Está seguro que desea salir del juego?", "Salir del juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then End
    End Sub
End Class
