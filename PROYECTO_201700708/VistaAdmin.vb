Public Class VistaAdmin
    Dim Query = ""
    Private Sub btnVendedoress_Click(sender As Object, e As EventArgs) Handles btnVendedoress.Click
        Query = "SELECT CODIGO_VENDEDOR,NOMBRE,FECHA_NACIMIENTO,SEXO,USUARIO,TIPO FROM VENDEDOR"
        Form1.Conexion.MostrarTablaUsuarios(CRUD_Vendedor.dg_TablaVendedores, Query)
        CRUD_Vendedor.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Form1.Conexion.LimpiarCredenciales()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        CRUD_Productos.Show()
        Me.Hide()
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        Reportes.Show()
        Me.Hide()
    End Sub
End Class