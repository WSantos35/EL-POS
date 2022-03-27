Public Class Venta
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles cjaVenta_Total.TextChanged

    End Sub

    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnVenta_Cancelar_Click(sender As Object, e As EventArgs) Handles btnVenta_Cancelar.Click
        VistaVendedor.Show()
        Me.Hide()
    End Sub
End Class