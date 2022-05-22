Public Class Form1

    Public NombreCliente(6) As String
    Public RegistroCliente(6) As String
    Public TipoCliente(6) As String
    Public TipoPrenda(6) As String
    Public CantidadDocenasPrenda(6) As Integer
    Public SubTotalRegistro(6) As Decimal
    Public TotalRegistro(6) As Decimal

    Public Nombre As String
    Public Registro As String
    Public TipoC As String
    Public TipoP As String
    Public CantidadP As Integer
    Public subT As Decimal
    Public tot As Decimal

    Public Existe As Boolean
    Public Index As Integer
    Public IndexRegistro As Integer = 0
    Public CantidadDescuento As Decimal = 0
    Public PrecioDocena As Integer = 0
    Public SubTotal As Integer = 0
    Public Total As Decimal = 0
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        If (e.ClickedItem.Text = "Aceptar") Then
            Aceptar()
        ElseIf (e.ClickedItem.Text = "Salir") Then
            End
        ElseIf (e.ClickedItem.Text = "Buscar") Then
            Buscar()
        ElseIf e.ClickedItem.Text = "Mostrar" Then
            Mostrar()
        ElseIf e.ClickedItem.Text = "Limpiar Vectores" Then
            Limpiar()
        End If
    End Sub


    Private Sub Ordenar()
        Dim indexTempo As Integer = 0
        Dim tmpRegistrUnico As String = ""
        Index = 0

        While (indexTempo < 6)
            tmpRegistrUnico = RegistroCliente(indexTempo)
            Index = indexTempo
            While (Index < 6)
                If (RegistroCliente(indexTempo) > RegistroCliente(Index)) Then

                    Nombre = NombreCliente(Index)
                    Registro = RegistroCliente(Index)
                    TipoC = TipoCliente(Index)
                    TipoP = TipoPrenda(Index)
                    CantidadP = CantidadDocenasPrenda(Index)
                    subT = SubTotalRegistro(Index)
                    tot = TotalRegistro(Index)

                    NombreCliente(Index) = NombreCliente(indexTempo)
                    RegistroCliente(Index) = RegistroCliente(indexTempo)
                    TipoCliente(Index) = TipoCliente(indexTempo)
                    TipoPrenda(Index) = TipoPrenda(indexTempo)
                    CantidadDocenasPrenda(Index) = CantidadDocenasPrenda(indexTempo)
                    SubTotalRegistro(Index) = SubTotalRegistro(indexTempo)
                    TotalRegistro(Index) = TotalRegistro(indexTempo)


                    NombreCliente(indexTempo) = Nombre
                    RegistroCliente(indexTempo) = Registro
                    TipoC = TipoCliente(Index)
                    TipoP = TipoPrenda(Index)
                    CantidadP = CantidadDocenasPrenda(Index)
                    subT = SubTotalRegistro(Index)
                    tot = TotalRegistro(Index)

                End If
                Index = Index + 1
            End While
            indexTempo = indexTempo + 1
        End While
    End Sub
    Private Sub Limpiar()
        DataGridView1.Rows.Clear()
        Index = 0
        While (Index < 6)
            NombreCliente(Index) = Nothing
            RegistroCliente(Index) = Nothing
            TipoCliente(Index) = Nothing
            TipoPrenda(Index) = Nothing
            CantidadDocenasPrenda(Index) = Nothing
            SubTotalRegistro(Index) = Nothing
            TotalRegistro(Index) = Nothing
            Index = Index + 1
        End While
        cja_NombreCliente.Text = ""
        cja_CantidadDocenas.Text = ""
        cja_RegistroUnico.Text = ""
        rb_camisas.Checked = False
        rb_clienteMenudeo.Checked = False
        rb_mayorista.Checked = False
        rb_Pantalon.Checked = False
        rb_Playeras.Checked = False
        IndexRegistro = 0
        Index = 0
    End Sub

    Private Sub Buscar()
        If (cja_RegistroUnico.Text = "") Then
            MessageBox.Show("INGRESE REGISTRO UNICO A BUSCAR")
            Return
        End If
        Index = 0
        Existe = False
        ExisteRegistro()
        If (Existe) Then
            Index = Index - 1
            DataGridView1.Rows.Clear()
            cja_NombreCliente.Text = NombreCliente(Index)
            cja_CantidadDocenas.Text = CantidadDocenasPrenda(Index)
            If TipoCliente(Index) = "Mayorista" Then
                rb_clienteMenudeo.Checked = False
                rb_mayorista.Checked = True
            Else
                rb_mayorista.Checked = False
                rb_clienteMenudeo.Checked = True
            End If

            If TipoPrenda(Index) = "CA" Then
                rb_Pantalon.Checked = False
                rb_Playeras.Checked = False
                rb_camisas.Checked = True
            ElseIf TipoPrenda(Index) = "PL" Then
                rb_Pantalon.Checked = False
                rb_camisas.Checked = False
                rb_Playeras.Checked = True
            Else
                rb_camisas.Checked = False
                rb_Playeras.Checked = False
                rb_Pantalon.Checked = True
            End If
            DataGridView1.Rows.Add(NombreCliente(Index), RegistroCliente(Index), TipoCliente(Index), getTipoCompletoPrenda(TipoPrenda(Index)), CantidadDocenasPrenda(Index), SubTotalRegistro(Index), TotalRegistro(Index))
        Else
            MessageBox.Show("EL REGISTRO UNICO NO EXISTE")
        End If
    End Sub


    Private Sub Mostrar()
        Index = 0
        DataGridView1.Rows.Clear()
        While (Index < IndexRegistro)
            DataGridView1.Rows.Add(NombreCliente(Index), RegistroCliente(Index), TipoCliente(Index), getTipoCompletoPrenda(TipoPrenda(Index)), CantidadDocenasPrenda(Index), SubTotalRegistro(Index), TotalRegistro(Index))
            Index = Index + 1
        End While
    End Sub

    Private Sub Aceptar()

        If (IndexRegistro >= 6) Then
            MessageBox.Show("LIMITE REGISTROS ALCANZADO")
            Return
        End If

        Nombre = cja_NombreCliente.Text
        Existe = False
        ExisteRegistro()
        Index = 0
        If (Existe) Then
            MessageBox.Show("El registro ya existe")
            Return
        End If
        Registro = cja_RegistroUnico.Text
        If (rb_mayorista.Checked) Then
            TipoC = "Mayorista"
        ElseIf rb_clienteMenudeo.Checked Then
            TipoC = "Cliente al Menudeo"
        End If

        If rb_camisas.Checked Then
            TipoP = getTipoCompletoPrenda(rb_camisas.Text)
            If rb_mayorista.Checked Then
                CantidadDescuento = 0.1
            Else
                CantidadDescuento = 0.05
            End If
            PrecioDocena = 420
        ElseIf rb_Playeras.Checked Then
            TipoP = getTipoCompletoPrenda(rb_Playeras.Text)
            If rb_mayorista.Checked Then
                CantidadDescuento = 0.05
            Else
                CantidadDescuento = 0.03
            End If
            PrecioDocena = 216
        ElseIf rb_Pantalon.Checked Then
            TipoP = getTipoCompletoPrenda(rb_Pantalon.Text)
            If rb_mayorista.Checked Then
                CantidadDescuento = 0.03
            Else
                CantidadDescuento = 0.01
            End If
            PrecioDocena = 480
        End If

        SubTotal = PrecioDocena * Int(cja_CantidadDocenas.Text)
        CantidadDescuento = SubTotal * CantidadDescuento
        'REDONDEO A DOS DECIMALES
        Total = SubTotal - Math.Round(CantidadDescuento, 2)
        NombreCliente(IndexRegistro) = Nombre
        RegistroCliente(IndexRegistro) = Registro
        TipoCliente(IndexRegistro) = TipoC
        TipoPrenda(IndexRegistro) = TipoP
        CantidadDocenasPrenda(IndexRegistro) = Int(cja_CantidadDocenas.Text)
        SubTotalRegistro(IndexRegistro) = SubTotal
        'REDONDEO A DOS DECIMALES
        TotalRegistro(IndexRegistro) = Math.Round(Total, 2)
        IndexRegistro = IndexRegistro + 1
        cja_NombreCliente.Text = ""
        cja_CantidadDocenas.Text = ""
        cja_RegistroUnico.Text = ""
        rb_camisas.Checked = False
        rb_clienteMenudeo.Checked = False
        rb_mayorista.Checked = False
        rb_Pantalon.Checked = False
        rb_Playeras.Checked = False
    End Sub

    Private Sub ExisteRegistro()
        Index = 0
        While (Index < 6 And Not (Existe))
            If (RegistroCliente(Index) = cja_RegistroUnico.Text) Then
                Existe = True
            End If
            Index = Index + 1
        End While
    End Sub

    Function getTipoCompletoPrenda(tipo As String) As String
        If (tipo = "Camisas") Then
            Return "CA"
        ElseIf (tipo = "Playeras") Then
            Return "PL"
        ElseIf (tipo = "Pantalon") Then
            Return "PT"
        ElseIf tipo = "CA" Then
            Return "Camisas"
        ElseIf tipo = "PL" Then
            Return "Playeras"
        ElseIf tipo = "PT" Then
            Return "Pantalon"
        End If
        Return ""
    End Function



End Class
