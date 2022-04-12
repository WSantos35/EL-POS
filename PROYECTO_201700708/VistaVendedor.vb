Public Class VistaVendedor
    Dim Query As String = ""
    Private Sub btnVendedor_Salir_Click(sender As Object, e As EventArgs) Handles btnVendedor_Salir.Click
        Form1.Conexion.LimpiarCredenciales()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnVendedor_Configuracion_Click(sender As Object, e As EventArgs) Handles btnVendedor_Configuracion.Click
        Form1.Conexion.AsignarPerfil(ConfigPerfil.cjaPerfil_Nombre, ConfigPerfil.cjaPerfil_Sexo, ConfigPerfil.cjaPerfil_FechaNac, ConfigPerfil.cjaPerfil_Usuario, ConfigPerfil.cjaPerfil_Password, ConfigPerfil.pb_ImagePerfil)
        ConfigPerfil.Show()
        Me.Hide()
    End Sub

    Private Sub btnVendedor_Vender_Click(sender As Object, e As EventArgs) Handles btnVendedor_Vender.Click
        Venta.Show()
        Me.Hide()
    End Sub

    Private Sub btnVendedor_Buscar_Click(sender As Object, e As EventArgs) Handles btnVendedor_Buscar.Click
        Query = "SELECT * FROM producto WHERE nombre LIKE '%" & cjaBuscar.Text & "%'"
        Form1.Conexion.MostrarTablaProductos(dgv_VVProductos, Query)
    End Sub
End Class