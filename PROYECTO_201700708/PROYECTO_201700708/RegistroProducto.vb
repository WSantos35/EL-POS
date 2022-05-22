Public Class RegistroProducto
    Dim Query As String = ""
    Private Sub btnProducto_Regresar_Click(sender As Object, e As EventArgs) Handles btnProducto_Regresar.Click
        Query = "SELECT * FROM producto"
        Form1.Conexion.MostrarTablaProductos(CRUD_Productos.dgv_TablaProductos, Query)
        LimpiarVariables()
        CRUD_Productos.Show()
        Me.Hide()
    End Sub

    Private Sub LimpiarVariables()
        cjaProducto_Codigo.Text = ""
        cjaNombreProducto.Text = ""
        cjaPrecioProducto.Text = ""
        cjaExistenciasProducto.Text = ""
        cjaDescripcionProducto.Text = ""
        cjaProducto_Codigo.Text = ""
    End Sub

    Private Sub btnProducto_Registrar_Click(sender As Object, e As EventArgs) Handles btnProducto_Registrar.Click
        If cjaNombreProducto.Text <> "" And cjaPrecioProducto.Text <> "" And cjaExistenciasProducto.Text <> "" And cjaDescripcionProducto.Text <> "" Then
            If cjaProducto_Codigo.Text = "" Then
                Query = "INSERT INTO producto(nombre,precio,stock,descripcion) VALUES('" & cjaNombreProducto.Text & "'," & Decimal.Parse(cjaPrecioProducto.Text) & "," & Integer.Parse(cjaExistenciasProducto.Text) & ",'" & cjaDescripcionProducto.Text & "')"
                Form1.Conexion.ExecuteQuery(Query, "PRODUCTO REGISTRADO EXITOSAMENTE", "NO SE PUDO REGISTRAR EL PRODUCTO VERIFICAR DATOS")
                LimpiarVariables()
            Else
                MessageBox.Show("INGRESE CODIGO DE PRODUCTO UNICAMENTE PARA ELIMINAR, BUSCAR O ACTUALIZAR PRODUCTO")
            End If
        Else
            MessageBox.Show("INGRESE TODOS LOS CAMPOS")
        End If
    End Sub

    Private Sub btnProducto_Eliminar_Click(sender As Object, e As EventArgs) Handles btnProducto_Eliminar.Click
        If cjaProducto_Codigo.Text <> "" Then
            Query = "DELETE FROM producto WHERE codigo_producto=" & Integer.Parse(cjaProducto_Codigo.Text)
            Form1.Conexion.ExecuteQuery(Query, "PRODUCTO ELIMINADO EXITOSAMENTE", "EL PRODUCTO NO EXISTE")
            LimpiarVariables()
        Else
            MessageBox.Show("INGRESE EL CODIGO DEL PRODUCTO A ELIMINAR")
        End If
    End Sub

    Private Sub btnRegistroProd_Actualizar_Click(sender As Object, e As EventArgs) Handles btnRegistroProd_Actualizar.Click
        If cjaProducto_Codigo.Text <> "" Then
            If cjaNombreProducto.Text <> "" And cjaPrecioProducto.Text <> "" And cjaExistenciasProducto.Text <> "" And cjaDescripcionProducto.Text <> "" Then
                Query = "UPDATE producto SET nombre='" & cjaNombreProducto.Text & "', precio=" & Decimal.Parse(cjaPrecioProducto.Text) & " , stock=" & Integer.Parse(cjaExistenciasProducto.Text) & " , descripcion='" & cjaDescripcionProducto.Text & "' WHERE codigo_producto=" & Integer.Parse(cjaProducto_Codigo.Text)
                Form1.Conexion.ExecuteQuery(Query, "PRODUCTO ACTUALIZADO EXITOSAMENTE", "PRODUCTO NO EXISTE")
                LimpiarVariables()
            Else
                MessageBox.Show("TODOS LOS DATOS SON NECESARIOS")
            End If

        Else
                MessageBox.Show("INGRESE EL CODIGO DEL RPODUCTO ACTUALIZAR")
        End If
    End Sub

    Private Sub btnProducto_Buscar_Click(sender As Object, e As EventArgs) Handles btnProducto_Buscar.Click
        If cjaProducto_Codigo.Text <> "" Then
            Query = "SELECT * FROM producto where codigo_producto=" & Integer.Parse(cjaProducto_Codigo.Text)
            Form1.Conexion.BUSCAR_PRODUCTOS(Query)
        Else
            MessageBox.Show("INGRESE UN CODIGO DE PRODUCTO PARA LA BUSQUEDA")
        End If
    End Sub
End Class