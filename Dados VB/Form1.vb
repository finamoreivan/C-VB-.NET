Public Class Form1

    Dim Numero = 1
    Dim Vuelta = 1

    Dim Azar As Boolean = True

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bTirar.Click
    '    Randomize()
    '    Dim Num As Integer = Int(Rnd() * 6 + 1)
    '    MessageBox.Show(NumDado(Azar))
    'End Sub
    Function NumDado(Random As Boolean) As Integer
        If Random Then Randomize()
        Return Int(Rnd() * 6 + 1)
    End Function
    Private Sub Cubilete_Click(sender As Object, e As EventArgs) Handles Cubilete.Click
        CambiaDado(Dado1)
        CambiaDado(Dado2)
        CambiaDado(Dado3)
        CambiaDado(Dado4)
        CambiaDado(Dado5)

        Dim Turno = MsgBox("Tiro número " & Numero & " de la vuelta " & Vuelta & " realizado")
        Numero += 1
        If Numero > 3 Then
            Numero = 1
            Vuelta += 1
        End If
        If Vuelta = 11 Then
            Dim final As New Juego_Completado
            final.ShowDialog()
        End If
    End Sub
    Sub CambiaDado(ByRef DadoX As PictureBox)
        Dim Num As Integer = NumDado(Azar)
        Select Case Num
            Case 1 : DadoX.Image = My.Resources.dado1
            Case 2 : DadoX.Image = My.Resources.dado2
            Case 3 : DadoX.Image = My.Resources.dado3
            Case 4 : DadoX.Image = My.Resources.dado4
            Case 5 : DadoX.Image = My.Resources.dado5
            Case 6 : DadoX.Image = My.Resources.dado6
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("¿Está seguro que desea salir del juego?", "Salir del juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then End
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Dim monto As Decimal = 1000
    '    Dim IVA As Decimal = 0, IIBB As Decimal = 0, interes1 As Decimal = 0
    '    CalcularValores(monto, IVA, IIBB, interes1)
    '    MessageBox.Show(" Monto: " & monto & " IVA: " & IVA & " IIBB: " & IIBB & " interes: " & interes1)
    'End Sub

    'Private Sub CalcularValores(ByVal montoX As Decimal, ByRef IVA As Decimal, ByRef IIBB As Decimal, ByRef interes1 As Decimal)
    '    IVA = montoX * 21 / 100
    '    IIBB = montoX * 3 / 100
    '    interes1 = montoX * 5 / 100
    'End Sub
End Class
