Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        System.Diagnostics.Process.Start("https://www.google.com/search?q=" & tBuscar.Text & "&oq=" & tBuscar.Text & "&aqs=chrome..69i57j69i59l2j69i60l2j69i65j69i61l2.592j0j1&sourceid=chrome&ie=UTF-8")

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tBuscar.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bRojo_Click(sender As Object, e As EventArgs) Handles bRojo.Click
        Me.BackColor = Color.Red
    End Sub

    Private Sub bVerde_Click(sender As Object, e As EventArgs) Handles bVerde.Click
        Me.BackColor = Color.Green
    End Sub

    Private Sub bAzul_Click(sender As Object, e As EventArgs) Handles bAzul.Click
        Me.BackColor = Color.Blue
    End Sub

    Private Sub bVer_Click(sender As Object, e As EventArgs) Handles bVer.Click
        bBuscar.Visible = Not bBuscar.Visible
    End Sub

    Private Sub bIr_Click(sender As Object, e As EventArgs) Handles bIr.Click
        If (String.IsNullOrEmpty(tBuscar.Text)) Then
            Return
        End If
        If (tBuscar.Equals("about:blank")) Then
            Return
        End If
        If Not tBuscar.Text.StartsWith("http://") And Not tBuscar.Text.StartsWith("https://") Then
            tBuscar.Text = "http://" + tBuscar.Text

            Try
                WebBrowser1.Navigate(New Uri(tBuscar.Text))
            Catch
                MessageBox.Show("Se produjo un error.")
            End Try

        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class
