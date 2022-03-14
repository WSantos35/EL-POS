Public Class Form1
    Dim User As String = ""
    Dim Password As String = ""
    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        Dim respuesta = MessageBox.Show("¿Desea salir del programa?", "", MessageBoxButtons.YesNoCancel)
        If (respuesta = DialogResult.Yes) Then
            End
        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        User = cjaUsuario.Text
        Password = cjaPassword.Text
        If User = "Admin" And Password = "Admin" Then
            VistaAdmin.Show()
            Me.Hide()
        ElseIf User = "Vendedor" And Password = "Vendedor" Then
            VistaVendedor.Show()
            Me.Hide()
        End If
    End Sub
End Class
