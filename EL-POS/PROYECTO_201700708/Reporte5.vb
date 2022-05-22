Public Class Reporte5
    Dim posX As Integer = 170
    Dim posY As Integer = 110
    Dim grosor As Integer = 50
    Dim Largo As Integer = 10
    Dim Query As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Reportes.Show()
        Me.Hide()
    End Sub

    Private Sub Reporte5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Query = "SELECT TOP 3 VEND.nombre,COUNT(VENT.codigo_vendedor) AS CANTIDAD FROM vendedor VEND, venta VENT WHERE VEND.codigo_vendedor=VENT.codigo_vendedor GROUP BY VEND.nombre ORDER BY COUNT(VENT.codigo_vendedor) DESC"
        Form1.Conexion.SetDataGrafica(Query, et_CantProd1, et_CantProd2, et_CantProd3, et_Producto1, et_Producto2, et_Producto3)
    End Sub

    Private Sub Reporte5_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim rectangulo As Graphics
        rectangulo = Me.CreateGraphics
        rectangulo.FillRectangle(New SolidBrush(Color.Green), posX, posY, Largo * Integer.Parse(et_CantProd1.Text), grosor)
        rectangulo.FillRectangle(New SolidBrush(Color.Green), posX, posY + grosor * 2, Largo * Integer.Parse(et_CantProd2.Text), grosor)
        rectangulo.FillRectangle(New SolidBrush(Color.Green), posX, posY + grosor * 4, Largo * Integer.Parse(et_CantProd3.Text), grosor)
    End Sub
End Class