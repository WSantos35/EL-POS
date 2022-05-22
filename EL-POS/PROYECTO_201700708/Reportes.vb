Public Class Reportes
    Dim Query As String = ""
    Private Sub btnReportes_Regresar_Click(sender As Object, e As EventArgs) Handles btnReportes_Regresar.Click
        VistaAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub btnReporte1_Click(sender As Object, e As EventArgs) Handles btnReporte1.Click
        Query = "select nombre ,count(*) as Total_Ventas from vendedor inner join venta on vendedor.tipo =1 and venta.codigo_vendedor=vendedor.codigo_vendedor group by vendedor.codigo_vendedor,vendedor.nombre order by 2 desc"
        Form1.Conexion.Reporte1_Reporte2(Reporte1.DataGridView1, Query)
        Me.Hide()
        Reporte1.Show()
    End Sub

    Private Sub btnReporte2_Click(sender As Object, e As EventArgs) Handles btnReporte2.Click
        Query = "SELECT P.nombre, COUNT(P.codigo_producto) as cantidad_ventas FROM detalle_venta DV, producto P WHERE DV.codigo_producto=P.codigo_producto GROUP BY P.nombre, P.codigo_producto ORDER BY 2 DESC"
        Form1.Conexion.Reporte1_Reporte2(Reporte2.DataGridView1, Query)
        Me.Hide()
        Reporte2.Show()
    End Sub

    Private Sub btnReporte3_Click(sender As Object, e As EventArgs) Handles btnReporte3.Click
        Query = "SELECT VEND.nombre,P.nombre, COUNT(P.codigo_producto) as cantidad_ventas FROM detalle_venta DV,	producto P, vendedor VEND, venta VENT WHERE DV.codigo_producto=P.codigo_producto AND VEND.codigo_vendedor=VENT.codigo_vendedor AND VENT.codigo_venta=DV.codigo_venta GROUP BY P.nombre, P.codigo_producto,VEND.nombre,VEND.codigo_vendedor ORDER BY 2 DESC"
        Form1.Conexion.Reporte3(Reporte3.DataGridView1, Query)
        Me.Hide()
        Reporte3.Show()
    End Sub

    Private Sub btnReporte4_Click(sender As Object, e As EventArgs) Handles btnReporte4.Click
        Reporte4.Show()
        Me.Hide()
    End Sub

    Private Sub btnReport5_Click(sender As Object, e As EventArgs) Handles btnReport5.Click
        Reporte5.Show()
        Me.Hide()
    End Sub

    Private Sub btnReport6_Click(sender As Object, e As EventArgs) Handles btnReport6.Click
        Reporte6.Show()
        Me.Hide()
    End Sub
End Class