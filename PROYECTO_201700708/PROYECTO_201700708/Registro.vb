Public Class Registro
    'DATOS PARA EL REGISTRO
    Dim Nombre As String = ""
    Dim Fecha As String = ""
    Dim Sexo As String = ""
    Dim Password As String = ""
    Dim User As String = ""
    Dim Tipo As String = ""
    Dim Foto As String = ""

    Dim Query As String = ""
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Query = "SELECT CODIGO_VENDEDOR,NOMBRE,FECHA_NACIMIENTO,SEXO,USUARIO,TIPO FROM VENDEDOR"
        Form1.Conexion.MostrarTablaUsuarios(CRUD_Vendedor.dg_TablaVendedores, Query)
        CRUD_Vendedor.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        Nombre = cjaRegistro_Nombre.Text
        Fecha = Format(CDate(cjaRegistro_Fecha.Text), "yyyyMMdd")
        Sexo = cjaRegistro_Sexo.Text
        If Sexo = "Masculino" Then
            Sexo = "M"
        ElseIf Sexo = "Femenino" Then
            Sexo = "F"
        ElseIf Sexo = "Indenfino" Then
            Sexo = "I"
        End If
        Password = cjaRegistro_Password.Text
        User = cjaRegistro_Usuario.Text
        Tipo = cjaRegistro_Tipo.Text
        If Tipo = "Vendedor" Then
            Tipo = "1"
        ElseIf Tipo = "Administrador" Then
            Tipo = "2"
        End If
        Foto = cjaRegistro_File.Text

        If Nombre <> "" And Fecha <> "" And Sexo <> "" And Password <> "" And User <> "" And Tipo <> "" And Foto <> "" Then
            Query = "INSERT INTO vendedor(nombre,fecha_nacimiento,sexo,contrasenia,usuario,tipo,foto) VALUES('" & Nombre & "','" & Fecha & "','" & Sexo &
                "','" & Password & "','" & User & "'," & Integer.Parse(Tipo) & ",'" & Foto & "')"
            Form1.Conexion.RegistrarUsuario(Query)
            LimpiarRegistros()
        Else
            MessageBox.Show("TODOS LOS CAMPOS SON OBLIGATORIOS")
        End If
    End Sub

    Private Sub btnRegistro_File_Click(sender As Object, e As EventArgs) Handles btnRegistro_File.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            cjaRegistro_File.Text = fd.FileName
        End If
    End Sub

    Private Sub LimpiarRegistros()
        cjaRegistro_Nombre.Text = ""
        cjaRegistro_Fecha.ResetText()
        cjaRegistro_File.Text = ""
        cjaRegistro_Password.Text = ""
        cjaRegistro_Sexo.Text = ""
        cjaRegistro_Tipo.Text = ""
        cjaRegistro_Usuario.Text = ""
    End Sub

    Private Sub btnRegistro_Buscar_Click(sender As Object, e As EventArgs) Handles btnRegistro_Buscar.Click
        If cjaRegistro_Usuario.Text.Equals("") Then
            MessageBox.Show("Ingrese el usuario del vendedor a buscar")
        Else
            Query = "SELECT nombre,fecha_nacimiento,sexo,usuario,contrasenia,tipo FROM VENDEDOR WHERE usuario='" & cjaRegistro_Usuario.Text & "'"
            Form1.Conexion.BUSCAR_USUARIOS(Query)
        End If
    End Sub

    Private Sub btnRegistro_Eliminar_Click(sender As Object, e As EventArgs) Handles btnRegistro_Eliminar.Click
        If cjaRegistro_Usuario.Text.Equals("") Then
            MessageBox.Show("Ingrese el usuario del vendedor a eliminar")
        Else
            Query = "DELETE vendedor WHERE usuario='" & cjaRegistro_Usuario.Text & "'"
            Form1.Conexion.ExecuteQuery(Query, "USUARIO ELIMINADO EXITOSAMENTE", "USUARIO NO EXISTE")
            LimpiarRegistros()
        End If
    End Sub
End Class