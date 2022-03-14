Public Class VistaAdmin
    Private Sub btnVendedoress_Click(sender As Object, e As EventArgs) Handles btnVendedoress.Click
        CRUD_Vendedor.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        CRUD_Productos.Show()
        Me.Hide()
    End Sub
End Class