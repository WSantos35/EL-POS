Public Class VistaVendedor
    Private Sub btnVendedor_Salir_Click(sender As Object, e As EventArgs) Handles btnVendedor_Salir.Click
        Form1.Conexion.LimpiarCredenciales()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnVendedor_Configuracion_Click(sender As Object, e As EventArgs) Handles btnVendedor_Configuracion.Click
        ConfigPerfil.Show()
        Me.Hide()
    End Sub

    Private Sub btnVendedor_Vender_Click(sender As Object, e As EventArgs) Handles btnVendedor_Vender.Click
        Venta.Show()
        Me.Hide()
    End Sub
End Class