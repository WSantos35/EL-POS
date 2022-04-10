Public Class CRUD_Productos
    Private Sub btnProductos_Registrarse_Click(sender As Object, e As EventArgs) Handles btnProductos_Registrarse.Click
        RegistroProducto.Show()
        Me.Hide()
    End Sub

    Private Sub btnProductos_Regresar_Click(sender As Object, e As EventArgs) Handles btnProductos_Regresar.Click
        VistaAdmin.Show()
        Me.Hide()
    End Sub

    Public Sub MostrarProductos()

    End Sub
End Class