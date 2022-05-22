Public Class Form1
    Dim ProducSelect As Boolean
    Dim TypeSelect As Boolean
    Dim NuevoProducto As String
    Public Producto(8) As String
    Dim TipoEnvio As Integer
    Dim ValorProducto As Decimal
    Dim ValorImpuesto As Decimal
    Dim PagoParcial As Decimal
    Dim PagoTotal As Decimal
    Dim NombreArticulo As String
    Public Contador As Integer
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        ProducSelect = rbCelulares.Checked Or rbLaptop.Checked Or rbRopa.Checked Or rbTablets.Checked Or rbVideoJuegos.Checked
        TypeSelect = rbEnvioCasa.Checked Or rbEnvioCC.Checked
        If (ProducSelect And TypeSelect And (cjaNombreCliente.Text <> "") And (cjaNumeroTarjeta.Text <> "") And (cjaValorArticulo.Text <> "")) Then
            NuevoProducto = ""
            NombreArticulo = ""
            ValorProducto = Decimal.Parse(cjaValorArticulo.Text)

            If rbEnvioCasa.Checked Then
                TipoEnvio = 10
            Else
                TipoEnvio = 5
            End If

            If rbCelulares.Checked Then
                ValorImpuesto = ValorProducto * 0.06
                NombreArticulo = "Celulares"
            ElseIf rbLaptop.Checked Then
                ValorImpuesto = ValorProducto * 0.02
                NombreArticulo = "Laptop"
            ElseIf rbRopa.Checked Then
                ValorImpuesto = ValorProducto * 0.03
                NombreArticulo = "Ropa"
            ElseIf rbTablets.Checked Then
                ValorImpuesto = ValorProducto * 0.05
                NombreArticulo = "Tablets"
            ElseIf rbVideoJuegos.Checked Then
                ValorImpuesto = ValorProducto * 0.04
                NombreArticulo = "Video Juegos"
            End If

            PagoParcial = ValorProducto
            PagoTotal = ValorProducto + TipoEnvio + ValorImpuesto
            NuevoProducto = cjaNombreCliente.Text + " | " + NombreArticulo + " | " + ValorProducto.ToString() + " | " + cjaNumeroTarjeta.Text + " | " + PagoParcial.ToString() + " | " + ValorImpuesto.ToString() + " | " + PagoTotal.ToString()
            Contador = Contador + 1
            'Producto(Contador) = NuevoProducto
            If Menu.lboxListadoProductos.Items.Count < 8 Then
                Menu.lboxListadoProductos.Items.Add(NuevoProducto)
            Else
                MessageBox.Show("Llego al Limite de Clientes Permitidos")
            End If
            cjaNombreCliente.Text = ""
            cjaNumeroTarjeta.Text = ""
            cjaValorArticulo.Text = ""
            rbCelulares.Checked = False
            rbEnvioCasa.Checked = False
            rbEnvioCC.Checked = False
            rbLaptop.Checked = False
            rbRopa.Checked = False
            rbTablets.Checked = False
            rbVideoJuegos.Checked = False
            'MessageBox.Show(NuevoProducto)
            Menu.Show()
                Me.Hide()
            Else
                MessageBox.Show("Ingrese todos los campos solicitados")
        End If
    End Sub

    Private Sub btnCargarDatos_Click(sender As Object, e As EventArgs) Handles btnCargarDatos.Click
        cjaNombreCliente.Text = InputBox("Ingrese el nombre del Cliente", "Nombre", "", 2)
        cjaValorArticulo.Text = InputBox("Ingrese el valor del artículo ($)", "Valor", "", 1)
        cjaNumeroTarjeta.Text = InputBox("Ingrese el número de Tarjeta", "Tarjeta", "", 1)
    End Sub
End Class
