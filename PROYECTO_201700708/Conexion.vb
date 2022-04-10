
Imports System.Data.SqlClient
Imports System.Data
Public Class Conexion
    'VARIABLES DE CONEXION Y COMUNICACIÓN CON DB
    Dim myConextion As SqlConnection
    Dim execute As SqlCommand
    Dim ValoresTabla As SqlDataReader
    Dim Status As Boolean = False

    'VARIABLES DE USUARIO CONECTADO
    Public User As String = ""
    Public Nombre As String = ""
    Public FechaNac As String = ""
    Public Sexo As String = ""
    Public Password As String = ""
    Public TipoUser As String = ""
    Public CodUser As Integer = 0
    Public Fotografia As String = ""
    Dim img As Image
    'USUARIOS GENERALES
    Dim LocUser As String = ""
    Dim LocNombre As String = ""
    Dim LocFechaNac As String = ""
    Dim LocSexo As String = ""
    Dim LocTipoUser As String = ""
    Dim LocCodUser As String = ""
    'VALIDACIONES LECTURA
    Dim Lectura As Boolean

    Public Sub SetCredentials(Us As String, Nom As String, Fec As String, Sex As String, Pass As String, Tipo As String, Cod As String, Fot As String)
        Me.User = Us
        Me.Nombre = Nom
        Me.FechaNac = Fec
        Me.Sexo = Sex
        Me.Password = Pass
        Me.TipoUser = Tipo
        Me.CodUser = Cod
        Me.Fotografia = Fot
    End Sub

    Public Sub Conectar()
        Try
            myConextion = New SqlConnection("server=LAPTOP-NGF6J7FP;database=BD_201700708;integrated security=TRUE")
            myConextion.Open()
            MessageBox.Show("CONEXION REALIZADA EXITOSAMENTE")
            Status = True
        Catch ex As Exception
            MessageBox.Show("NO PUDO RELALIZAR LA CONEXION ERROR: " & ex.ToString())
        End Try


    End Sub

    Public Sub CerrarConexion()
        If Status Then
            myConextion.Close()
            MessageBox.Show("CONEXION CERRADA EXITOSAMENTE")
        End If
    End Sub

    Function getStatus() As Boolean
        Return Status
    End Function

    Public Sub ExecuteLogin(Query As String)
        Try
            execute = New SqlCommand(Query, myConextion)
            ValoresTabla = execute.ExecuteReader
            While ValoresTabla.Read
                Me.CodUser = Integer.Parse(ValoresTabla.Item(0).ToString())
                Me.Nombre = ValoresTabla.Item(1).ToString()
                Me.FechaNac = ValoresTabla.Item(2).ToString()
                Me.Sexo = ValoresTabla.Item(3).ToString()
                Me.User = ValoresTabla.Item(4).ToString()
                Me.Password = ValoresTabla.Item(5).ToString()
                Me.TipoUser = ValoresTabla.Item(6).ToString()
                Me.Fotografia = ValoresTabla.Item(7).ToString()
            End While
            ValoresTabla.Close()
            execute.Clone()
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO INICIAR SESION, ERROR: " & ex.ToString())
        End Try
    End Sub

    Public Sub MostrarTablaUsuarios(dg As DataGridView, Query As String)
        Try
            dg.Rows.Clear()
            execute = New SqlCommand(Query, myConextion)
            ValoresTabla = execute.ExecuteReader
            While ValoresTabla.Read

                Me.LocCodUser = ValoresTabla.Item(0).ToString()
                Me.LocNombre = ValoresTabla.Item(1).ToString()
                Me.LocFechaNac = ValoresTabla.Item(2).ToString()
                Me.LocSexo = ValoresTabla.Item(3).ToString()
                If Me.LocSexo = "M" Then
                    Me.LocSexo = "MASCULINO"
                ElseIf Me.LocSexo = "F" Then
                    Me.LocSexo = "FEMENINO"
                Else
                    Me.LocSexo = "Indefinido"
                End If

                Me.LocUser = ValoresTabla.Item(4).ToString()
                Me.LocTipoUser = ValoresTabla.Item(5).ToString()
                If Me.LocTipoUser = "2" Then
                    Me.LocTipoUser = "Administrador"
                ElseIf Me.LocTipoUser = "1" Then
                    Me.LocTipoUser = "Vendedor"
                End If
                dg.Rows.Add(Me.LocCodUser, Me.LocNombre, Me.LocFechaNac, Me.LocSexo, Me.LocUser, Me.LocTipoUser)
            End While
            ValoresTabla.Close()
            execute.Clone()
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO OBTENER DATOS, ERROR: " & ex.ToString())
        End Try
    End Sub

    Public Sub MostrarTablaProductos(dg As DataGridView, Query As String)
        Try
            dg.Rows.Clear()
            execute = New SqlCommand(Query, myConextion)
            ValoresTabla = execute.ExecuteReader
            Dim codProducto As String = ""
            Dim Nombre As String = ""
            Dim Precio As String = ""
            Dim Stock As String = ""
            Dim Descripcion As String = ""
            While ValoresTabla.Read
                codProducto = ValoresTabla.Item(0).ToString()
                Nombre = ValoresTabla.Item(1).ToString()
                Precio = ValoresTabla.Item(2).ToString()
                Stock = ValoresTabla.Item(3).ToString()
                Descripcion = ValoresTabla.Item(4).ToString()
                dg.Rows.Add(codProducto, Nombre, Precio, Stock, Descripcion)
            End While
            ValoresTabla.Close()
            execute.Clone()
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO OBTENER DATOS, ERROR: " & ex.ToString())
        End Try
    End Sub


    Public Sub LimpiarCredenciales()
        Me.User = ""
        Me.Nombre = ""
        Me.FechaNac = ""
        Me.Sexo = ""
        Me.Password = ""
        Me.TipoUser = ""
        Me.CodUser = 0
        Me.Fotografia = ""
    End Sub

    Public Sub RegistrarUsuario(Query As String)
        Try
            execute = New SqlCommand(Query, myConextion)
            If execute.ExecuteNonQuery() > 0 Then
                MessageBox.Show("USUARIO REGISTRADO EXITOSAMENTE")
            Else
                MessageBox.Show("NO SE PUDO REGISTRAR AL USUARIO")
            End If
            execute.Clone()
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO REGISTRAR USUARIO, ERROR: " & ex.ToString())
        End Try
    End Sub

    Public Sub AsignarPerfil(Nom As TextBox, sex As TextBox, fec As TextBox, user As TextBox, pasw As TextBox, fot As PictureBox)
        Try
            Nom.Text = Me.Nombre
            sex.Text = Me.Sexo
            fec.Text = Me.FechaNac
            user.Text = Me.User
            pasw.Text = Me.Password
            img = Image.FromFile(Me.Fotografia)
            fot.SizeMode = PictureBoxSizeMode.Zoom 'PictureBoxSizeMode.Zoom
            fot.Image = img
        Catch ex As Exception

        End Try
    End Sub
    Public Sub ExecuteQuery(Query As String, Mensaje As String, Mensaje2 As String)
        Try
            execute = New SqlCommand(Query, myConextion)
            If execute.ExecuteNonQuery() > 0 Then
                MessageBox.Show(Mensaje)
            Else
                MessageBox.Show(Mensaje2)
            End If
            execute.Clone()
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO REGISTRAR USUARIO, ERROR: " & ex.ToString())
        End Try
    End Sub
    Public Sub BUSCAR_USUARIOS(Query As String)
        Lectura = True
        Try
            execute = New SqlCommand(Query, myConextion)
            ValoresTabla = execute.ExecuteReader
            While ValoresTabla.Read
                Registro.cjaRegistro_Nombre.Text = ValoresTabla.Item(0).ToString()
                Registro.cjaRegistro_Fecha.Value = ValoresTabla.Item(1).ToString()
                Registro.cjaRegistro_Sexo.Text = getTipoSexo(ValoresTabla.Item(2).ToString())
                Registro.cjaRegistro_Usuario.Text = ValoresTabla.Item(3).ToString()
                Registro.cjaRegistro_Tipo.Text = getTipoUsuario(ValoresTabla.Item(5).ToString())
                Lectura = False
            End While
            ValoresTabla.Close()
            execute.Clone()
            If Lectura Then
                MessageBox.Show("Usuario no existe")
            End If
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO OBTENER DATOS, ERROR: " & ex.ToString())
        End Try
    End Sub

    Sub BUSCAR_PRODUCTOS(Query As String)
        Lectura = True
        Try
            execute = New SqlCommand(Query, myConextion)
            ValoresTabla = execute.ExecuteReader
            While ValoresTabla.Read
                RegistroProducto.cjaNombreProducto.Text = ValoresTabla.Item(1).ToString()
                RegistroProducto.cjaPrecioProducto.Text = ValoresTabla.Item(2).ToString()
                RegistroProducto.cjaExistenciasProducto.Text = ValoresTabla.Item(3).ToString()
                RegistroProducto.cjaDescripcionProducto.Text = ValoresTabla.Item(4).ToString()
                Lectura = False
            End While
            ValoresTabla.Close()
            execute.Clone()
            If Lectura Then
                MessageBox.Show("Sin producto Existente")
            End If
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO OBTENER DATOS, ERROR: " & ex.ToString())
        End Try
    End Sub

    Function getTipoUsuario(tipo As String) As String
        If tipo = "1" Then
            Return "Vendedor"
        Else
            Return "Administrador"
        End If
    End Function

    Function getTipoSexo(tipo As String) As String
        If tipo = "M" Then
            Return "Masculino"
        ElseIf tipo = "F" Then
            Return "Femenino"
        Else
            Return "Indefinido"
        End If
    End Function
End Class
