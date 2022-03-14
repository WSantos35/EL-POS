Public Class VistaVendedor
    Private Sub btnVendedor_Salir_Click(sender As Object, e As EventArgs) Handles btnVendedor_Salir.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnVendedor_Configuracion_Click(sender As Object, e As EventArgs) Handles btnVendedor_Configuracion.Click
        ConfigPerfil.Show()
        Me.Hide()
    End Sub
End Class