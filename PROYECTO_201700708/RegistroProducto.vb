Public Class RegistroProducto
    Private Sub btnProducto_Regresar_Click(sender As Object, e As EventArgs) Handles btnProducto_Regresar.Click
        CRUD_Productos.Show()
        Me.Hide()
    End Sub
End Class