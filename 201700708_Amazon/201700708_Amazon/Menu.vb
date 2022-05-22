Public Class Menu
    Dim NuevoProducto As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnLimpiarListbox_Click(sender As Object, e As EventArgs) Handles btnLimpiarListbox.Click
        lboxListadoProductos.Items.Clear()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'If Form1.Contador < 8 Then

        'Else
        'MessageBox.Show("Alcanzo el máximo de clientes permitidos")
        'End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class