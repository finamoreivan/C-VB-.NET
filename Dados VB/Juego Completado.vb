Public Class Juego_Completado
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("¿Está seguro que desea salir del juego?", "Salir del juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then End
    End Sub
End Class