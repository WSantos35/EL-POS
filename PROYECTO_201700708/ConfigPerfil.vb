Public Class ConfigPerfil
    Private Sub btnConfig_Regresar_Click(sender As Object, e As EventArgs) Handles btnConfig_Regresar.Click
        If Form1.Conexion.TipoUser = "2" Then
            VistaAdmin.Show()
            Me.Hide()
        ElseIf Form1.Conexion.TipoUser = "1" Then
            VistaVendedor.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnPerfil_Rotar_Click(sender As Object, e As EventArgs) Handles btnPerfil_Rotar.Click
        Try
            pb_ImagePerfil.Image.RotateFlip(RotateFlipType.Rotate90FlipX)
            pb_ImagePerfil.Refresh()
        Catch ex As Exception

        End Try
    End Sub
End Class