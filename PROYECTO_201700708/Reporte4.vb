Public Class Reporte4
    Dim posX As Integer = 170
    Dim posY As Integer = 110
    Dim grosor As Integer = 50
    Dim Largo As Integer = 10
    Dim Query As String = ""

    Private Sub Reporte4_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim rectangulo As Graphics
        rectangulo = Me.CreateGraphics
        rectangulo.FillRectangle(New SolidBrush(Color.Blue), posX, posY, Largo * Integer.Parse(et_CantProd1.Text), grosor)
        rectangulo.FillRectangle(New SolidBrush(Color.Blue), posX, posY + grosor * 2, Largo * Integer.Parse(et_CantProd2.Text), grosor)
        rectangulo.FillRectangle(New SolidBrush(Color.Blue), posX, posY + grosor * 4, Largo * Integer.Parse(et_CantProd3.Text), grosor)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Reportes.Show()
        Me.Hide()
    End Sub

    Private Sub Reporte4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Query = "SELECT TOP 3 P.nombre, SUM(DV.cantidad_producto) AS CANTIDAD FROM producto P, detalle_venta DV WHERE P.codigo_producto=DV.codigo_producto GROUP BY P.nombre ORDER BY SUM(DV.cantidad_producto) DESC"
        Form1.Conexion.SetDataGrafica(Query, et_CantProd1, et_CantProd2, et_CantProd3, et_Producto1, et_Producto2, et_Producto3)
    End Sub
End Class