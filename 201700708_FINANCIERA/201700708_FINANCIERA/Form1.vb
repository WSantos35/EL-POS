Public Class Form1
    'VARIABLES
    Dim costoAsesoria As Decimal = 0
    Dim descuento As Decimal = 0
    Dim Total As Decimal = 0

    Dim vNumeroServicio As Integer
    Dim vPlazoContrato As String
    Dim vTipoServicio As String
    Dim vFormaPago As String
    'VECTORES
    Public NumeroServicio(6) As Integer
    Public PlazoContrato(6) As String
    Public TipoServicio(6) As String
    Public FormaPago(6) As String
    Public Subtotal(6) As Decimal
    Public rTotal(6) As Decimal

    Dim Fila As Integer
    Dim Contador As Integer = 0
    Dim TmpContador = 0
    Dim Encontrado As Boolean
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

        If (e.ClickedItem.Text = "Aceptar") Then
            'MessageBox.Show(e.ClickedItem.Text)
            Aceptar()
            MessageBox.Show("DATO AGREGADO EXITOSAMENTE")
        ElseIf e.ClickedItem.Text = "Limpiar" Then
            LimpiarArreglos()
        ElseIf e.ClickedItem.Text = "Consultar" Then
            Consultar()
        ElseIf e.ClickedItem.Text = "Mostrar" Then
            Mostrar()
        ElseIf e.ClickedItem.Text = "Eliminar" Then
            Eliminar()
            MessageBox.Show("DATO ELIMINADO EXITOSAMENTE")
        ElseIf e.ClickedItem.Text = "Actualizar" Then
            Actualizar()
            MessageBox.Show("DATO ACTUALIZADO EXITOSAMENTE")
        End If
    End Sub

    Private Sub Actualizar()
        TmpContador = Contador
        Encontrado = False
        For i = 0 To dgv_Tabla.Rows.Count
            If NumeroServicio(i) <> Nothing Then
                If NumeroServicio(i) = vNumeroServicio Then
                    Contador = i
                    Encontrado = True
                End If
            End If
        Next
        If Encontrado Then
            Aceptar()
        Else
            MessageBox.Show("NO EXISTE SERVICIO")
        End If
        Contador = TmpContador
    End Sub
    Private Sub Mostrar()
        dgv_Tabla.Rows.Clear()
        Encontrado = False
        For i = 0 To 5
            If NumeroServicio(i) <> Nothing Then
                Fila = i
                Encontrado = True
                dgv_Tabla.Rows.Add(NumeroServicio(Fila), PlazoContrato(Fila), TipoServicio(Fila), FormaPago(Fila), Subtotal(Fila), rTotal(Fila))
            End If
        Next

        If Encontrado = False Then
            MessageBox.Show("NO EXISTE EL SERVICIOS")
        End If
    End Sub

    Private Sub Consultar()
        vNumeroServicio = Integer.Parse(cja_NumeroServicio.Text)
        For i = 0 To dgv_Tabla.Rows.Count
            If NumeroServicio(i) <> Nothing Then
                If NumeroServicio(i) = vNumeroServicio Then
                    dgv_Tabla.Rows.Clear()
                    Fila = i
                    dgv_Tabla.Rows.Add(NumeroServicio(Fila), PlazoContrato(Fila), TipoServicio(Fila), FormaPago(Fila), Subtotal(Fila), rTotal(Fila))
                End If
            End If
        Next
    End Sub

    Private Sub Eliminar()
        vNumeroServicio = Integer.Parse(cja_NumeroServicio.Text)
        dgv_Tabla.Rows.Clear()
        For i = 0 To dgv_Tabla.Rows.Count
            If NumeroServicio(i) <> Nothing Then
                If NumeroServicio(i) = vNumeroServicio Then
                    Fila = i
                    NumeroServicio(i) = Nothing
                    PlazoContrato(i) = Nothing
                    TipoServicio(i) = Nothing
                    FormaPago(i) = Nothing
                    Subtotal(i) = Nothing
                    rTotal(i) = Nothing
                End If
                If NumeroServicio(i) <> vNumeroServicio Then
                    Fila = i
                    dgv_Tabla.Rows.Add(NumeroServicio(Fila), PlazoContrato(Fila), TipoServicio(Fila), FormaPago(Fila), Subtotal(Fila), rTotal(Fila))
                End If
            End If
        Next
    End Sub
    Private Sub LimpiarArreglos()
        Dim i As Integer
        For i = 0 To 5
            NumeroServicio(i) = Nothing
            PlazoContrato(i) = Nothing
            TipoServicio(i) = Nothing
            FormaPago(i) = Nothing
            Subtotal(i) = Nothing
            rTotal(i) = Nothing
        Next
        Contador = 0
        dgv_Tabla.Rows.Clear()
    End Sub
    Private Sub Aceptar()
        costoAsesoria = 0
        descuento = 0
        Total = 0
        vTipoServicio = ""
        If Contador > 6 Then
            MessageBox.Show("Llego Limite de Registros")
            Return
        End If
        Fila = Contador
        Contador = Contador + 1
        'MessageBox.Show(Contador)
        'MessageBox.Show(Fila)
        'CALCULO DE LA CONSULTORIA (SUB-TOTAL)
        If cbx_AsesoriaFinanciera.Checked Then
            vTipoServicio = "Asesoria Financiera |"
            If rbtn_Corto.Checked Then
                vPlazoContrato = "Corto"
                costoAsesoria += 4000
            ElseIf rbtn_Mediano.Checked Then
                vPlazoContrato = "Mediano"
                costoAsesoria += 5000
            ElseIf rbtn_Largo.Checked Then
                vPlazoContrato = "Largo"
                costoAsesoria += 6000
            End If
        End If

        If cbx_AsistenciaViajes.Checked Then
            vTipoServicio += "Asistencia Viajes |"
            If rbtn_Corto.Checked Then
                vPlazoContrato = "Corto"
                costoAsesoria += 2000
            ElseIf rbtn_Mediano.Checked Then
                vPlazoContrato = "Mediano"
                costoAsesoria += 3000
            ElseIf rbtn_Largo.Checked Then
                vPlazoContrato = "Largo"
                costoAsesoria += 4000
            End If
        End If

        If cbx_CajaSeguridad.Checked Then
            vTipoServicio += "Caja Seguridad |"
            If rbtn_Corto.Checked Then
                vPlazoContrato = "Corto"
                costoAsesoria += 3000
            ElseIf rbtn_Mediano.Checked Then
                vPlazoContrato = "Mediano"
                costoAsesoria += 4000
            ElseIf rbtn_Largo.Checked Then
                vPlazoContrato = "Largo"
                costoAsesoria += 5000
            End If
        End If
        'CALCULO DEL DESCUENTO
        If rbtn_tarjeta.Checked Then
            vFormaPago = "Tarjeta"
            If costoAsesoria >= 4000 And costoAsesoria <= 8000 Then
                descuento = costoAsesoria * 0.03
            ElseIf costoAsesoria >= 8000.01 Then
                descuento = costoAsesoria * 0.07
            End If
        ElseIf rbtn_Transferencia.Checked Then
            vFormaPago = "Transferencia ACH"
            If costoAsesoria >= 3000 And costoAsesoria <= 7000 Then
                descuento = costoAsesoria * 0.04
            ElseIf costoAsesoria >= 7000.01 And costoAsesoria <= 10000 Then
                descuento = costoAsesoria * 0.06
            End If
        End If
        Total = costoAsesoria - descuento
        vNumeroServicio = cja_NumeroServicio.Text
        NumeroServicio(Fila) = Integer.Parse(vNumeroServicio)
        PlazoContrato(Fila) = vPlazoContrato
        TipoServicio(Fila) = vTipoServicio
        FormaPago(Fila) = vFormaPago
        Subtotal(Fila) = costoAsesoria
        rTotal(Fila) = Total

    End Sub


End Class
