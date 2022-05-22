Public Class Venta
    Dim Query As String = ""
    Public CodProducto As String = ""
    Public ExistenciaProducto As Integer = 0
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles cjaVenta_Total.TextChanged

    End Sub

    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnVenta_Cancelar_Click(sender As Object, e As EventArgs) Handles btnVenta_Cancelar.Click
        Query = "SELECT * FROM PRODUCTO"
        Form1.Conexion.MostrarTablaProductos(VistaVendedor.dgv_VVProductos, Query)
        limpiarVariables()
        VistaVendedor.Show()
        Me.Hide()
    End Sub

    Private Sub btnVenta_Buscar_Click(sender As Object, e As EventArgs) Handles btnVenta_Buscar.Click
        If cjaVenta_Codigo.Text <> "" And IsNumeric(cjaVenta_Codigo.Text) Then
            Query = "SELECT * FROM PRODUCTO WHERE codigo_producto=" & Integer.Parse(cjaVenta_Codigo.Text)
            Form1.Conexion.BUSCAR_PRODUCTOVENTA(Query)
        Else
            MessageBox.Show("INGRESE CODIGO DE PRODUCTO TIPO NUMERICO")
        End If
    End Sub

    Private Sub limpiarVariables()
        'cjaVenta_Cantidad.Text = ""
        cjaVenta_Codigo.Text = ""
        cjaVenta_NIT.Text = ""
        cjaVenta_NombreCliente.Text = ""
        cjaVenta_Precio.Text = ""
        cjaVenta_Producto.Text = ""
        cjaVenta_SubTotal.Text = ""
        cjaVenta_Total.Text = ""
        CodProducto = ""
        ExistenciaProducto = 0
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles cjaVenta_Cantidad.TextChanged
        If CodProducto <> "" Then
            If cjaVenta_Cantidad.Text = "" Then
                cjaVenta_Cantidad.Text = 0
            End If

            If cjaVenta_Precio.Text <> "" And IsNumeric(cjaVenta_Cantidad.Text) Then
                cjaVenta_SubTotal.Text = Decimal.Parse(cjaVenta_Precio.Text) * Integer.Parse(cjaVenta_Cantidad.Text)
                cjaVenta_Total.Text = cjaVenta_SubTotal.Text
            Else
                MessageBox.Show("INGRESE EL PRECIO Y LA CANTIDAD PARA PODER REALIZAR EL CALCULO")
            End If
        Else
            MessageBox.Show("BUSQUE UN PRODUCTO A VENDER POR SU CODIGO")
        End If
    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        If cjaVenta_NombreCliente.Text <> "" And cjaVenta_NIT.Text <> "" And cjaVenta_Total.Text <> "" And cjaVenta_Cantidad.Text <> "" And CodProducto <> "" Then
            Query = "INSERT INTO venta(nombre_cliente,nit_cliente,total_pagar,codigo_vendedor) VALUES('" & cjaVenta_NombreCliente.Text & "','" & cjaVenta_NIT.Text & "'," & Decimal.Parse(cjaVenta_Total.Text) & "," & Integer.Parse(Form1.Conexion.CodUser) & ")"
            If Form1.Conexion.ExecuteQuery2(Query, "NO SE PUDO REGISTRAR LA VENTA") Then
                Query = "INSERT INTO detalle_venta(codigo_venta,codigo_producto,cantidad_producto) SELECT MAX(codigo_venta) as codigo_venta," & Integer.Parse(CodProducto) & " as codigo_producto," & Integer.Parse(cjaVenta_Cantidad.Text) & " as cantidad_producto FROM venta"
                If Form1.Conexion.ExecuteQuery2(Query, "NO SE PUDO REGISTRAR DETALLE VENTA") Then
                    Query = "UPDATE producto SET stock=stock-" & Integer.Parse(cjaVenta_Cantidad.Text) & " WHERE codigo_producto=" & Integer.Parse(CodProducto)
                    If Form1.Conexion.ExecuteQuery2(Query, "NO SE PUDO ACTUALIZAR INVENTARIO") Then
                        MessageBox.Show("VENTA REGISTRADA EXITOSAMENTE")
                        limpiarVariables()
                    End If
                End If
            End If
        Else
            MessageBox.Show("TODOS LOS CAMPOS SON OBLIGATORIOS")
        End If

    End Sub
End Class