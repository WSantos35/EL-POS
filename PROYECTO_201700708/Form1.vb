Public Class Form1
    Dim User As String = ""
    Dim Password As String = ""
    Public Conexion As Conexion = New Conexion()
    Dim Query As String = ""
    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        Dim respuesta = MessageBox.Show("¿Desea salir del programa?", "", MessageBoxButtons.YesNoCancel)
        If (respuesta = DialogResult.Yes) Then
            Conexion.CerrarConexion()
            End
        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        User = cjaUsuario.Text
        Password = cjaPassword.Text
        If Conexion.getStatus() Then
            Query = "SELECT * FROM vendedor WHERE usuario='" & User & "' AND contrasenia='" & Password & "'"
            Conexion.ExecuteLogin(Query)
            If Conexion.TipoUser = "2" Then
                cjaUsuario.Text = ""
                cjaPassword.Text = ""
                VistaAdmin.Show()
                Me.Hide()
            ElseIf Me.Conexion.TipoUser = "1" Then
                Query = "SELECT * FROM PRODUCTO"
                Conexion.MostrarTablaProductos(VistaVendedor.dgv_VVProductos, Query)
                cjaUsuario.Text = ""
                cjaPassword.Text = ""
                VistaVendedor.Show()
                Me.Hide()
            Else
                MessageBox.Show("NO SE PUDO INICIAR SESION, VERIFIQUE USER/PASSWORD")
            End If
        Else
            MessageBox.Show("NO SE ENCUENTRA CONECTADO A LA BD")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Conexion.Conectar()
    End Sub
End Class
