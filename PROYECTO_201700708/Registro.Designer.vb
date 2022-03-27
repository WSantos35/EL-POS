<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cjaRegistro_Nombre = New System.Windows.Forms.TextBox()
        Me.cjaRegistro_Usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cjaRegistro_Password = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cjaRegistro_File = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRegistrarse = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.cjaRegistro_Sexo = New System.Windows.Forms.ComboBox()
        Me.cjaRegistro_Tipo = New System.Windows.Forms.ComboBox()
        Me.cjaRegistro_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.btnRegistro_Buscar = New System.Windows.Forms.Button()
        Me.btnRegistro_Eliminar = New System.Windows.Forms.Button()
        Me.btnRegistro_File = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(125, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'cjaRegistro_Nombre
        '
        Me.cjaRegistro_Nombre.Location = New System.Drawing.Point(345, 91)
        Me.cjaRegistro_Nombre.Name = "cjaRegistro_Nombre"
        Me.cjaRegistro_Nombre.Size = New System.Drawing.Size(198, 27)
        Me.cjaRegistro_Nombre.TabIndex = 1
        '
        'cjaRegistro_Usuario
        '
        Me.cjaRegistro_Usuario.Location = New System.Drawing.Point(345, 47)
        Me.cjaRegistro_Usuario.Name = "cjaRegistro_Usuario"
        Me.cjaRegistro_Usuario.Size = New System.Drawing.Size(198, 27)
        Me.cjaRegistro_Usuario.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(125, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha Nacimiento"
        '
        'cjaRegistro_Password
        '
        Me.cjaRegistro_Password.Location = New System.Drawing.Point(345, 187)
        Me.cjaRegistro_Password.Name = "cjaRegistro_Password"
        Me.cjaRegistro_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.cjaRegistro_Password.Size = New System.Drawing.Size(198, 27)
        Me.cjaRegistro_Password.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(125, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(125, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Sexo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(125, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tipo Usuario"
        '
        'cjaRegistro_File
        '
        Me.cjaRegistro_File.Location = New System.Drawing.Point(405, 344)
        Me.cjaRegistro_File.Name = "cjaRegistro_File"
        Me.cjaRegistro_File.Size = New System.Drawing.Size(198, 27)
        Me.cjaRegistro_File.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(125, 347)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fotografia"
        '
        'btnRegistrarse
        '
        Me.btnRegistrarse.Location = New System.Drawing.Point(188, 417)
        Me.btnRegistrarse.Name = "btnRegistrarse"
        Me.btnRegistrarse.Size = New System.Drawing.Size(94, 29)
        Me.btnRegistrarse.TabIndex = 16
        Me.btnRegistrarse.Text = "Registrar"
        Me.btnRegistrarse.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(558, 417)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(94, 29)
        Me.btnRegresar.TabIndex = 17
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'cjaRegistro_Sexo
        '
        Me.cjaRegistro_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cjaRegistro_Sexo.FormattingEnabled = True
        Me.cjaRegistro_Sexo.Items.AddRange(New Object() {"Masculino", "Femenino", "Indefinido"})
        Me.cjaRegistro_Sexo.Location = New System.Drawing.Point(345, 237)
        Me.cjaRegistro_Sexo.Name = "cjaRegistro_Sexo"
        Me.cjaRegistro_Sexo.Size = New System.Drawing.Size(198, 28)
        Me.cjaRegistro_Sexo.TabIndex = 18
        '
        'cjaRegistro_Tipo
        '
        Me.cjaRegistro_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cjaRegistro_Tipo.FormattingEnabled = True
        Me.cjaRegistro_Tipo.Items.AddRange(New Object() {"Administrador", "Vendedor"})
        Me.cjaRegistro_Tipo.Location = New System.Drawing.Point(345, 293)
        Me.cjaRegistro_Tipo.Name = "cjaRegistro_Tipo"
        Me.cjaRegistro_Tipo.Size = New System.Drawing.Size(198, 28)
        Me.cjaRegistro_Tipo.TabIndex = 19
        '
        'cjaRegistro_Fecha
        '
        Me.cjaRegistro_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cjaRegistro_Fecha.Location = New System.Drawing.Point(345, 139)
        Me.cjaRegistro_Fecha.Name = "cjaRegistro_Fecha"
        Me.cjaRegistro_Fecha.Size = New System.Drawing.Size(129, 27)
        Me.cjaRegistro_Fecha.TabIndex = 20
        Me.cjaRegistro_Fecha.Value = New Date(2022, 3, 12, 0, 0, 0, 0)
        '
        'btnRegistro_Buscar
        '
        Me.btnRegistro_Buscar.Location = New System.Drawing.Point(314, 417)
        Me.btnRegistro_Buscar.Name = "btnRegistro_Buscar"
        Me.btnRegistro_Buscar.Size = New System.Drawing.Size(94, 29)
        Me.btnRegistro_Buscar.TabIndex = 21
        Me.btnRegistro_Buscar.Text = "Buscar"
        Me.btnRegistro_Buscar.UseVisualStyleBackColor = True
        '
        'btnRegistro_Eliminar
        '
        Me.btnRegistro_Eliminar.Location = New System.Drawing.Point(430, 417)
        Me.btnRegistro_Eliminar.Name = "btnRegistro_Eliminar"
        Me.btnRegistro_Eliminar.Size = New System.Drawing.Size(94, 29)
        Me.btnRegistro_Eliminar.TabIndex = 22
        Me.btnRegistro_Eliminar.Text = "Eliminar"
        Me.btnRegistro_Eliminar.UseVisualStyleBackColor = True
        '
        'btnRegistro_File
        '
        Me.btnRegistro_File.Location = New System.Drawing.Point(345, 344)
        Me.btnRegistro_File.Name = "btnRegistro_File"
        Me.btnRegistro_File.Size = New System.Drawing.Size(54, 27)
        Me.btnRegistro_File.TabIndex = 23
        Me.btnRegistro_File.Text = "File..."
        Me.btnRegistro_File.UseVisualStyleBackColor = True
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 509)
        Me.Controls.Add(Me.btnRegistro_File)
        Me.Controls.Add(Me.btnRegistro_Eliminar)
        Me.Controls.Add(Me.btnRegistro_Buscar)
        Me.Controls.Add(Me.cjaRegistro_Fecha)
        Me.Controls.Add(Me.cjaRegistro_Tipo)
        Me.Controls.Add(Me.cjaRegistro_Sexo)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnRegistrarse)
        Me.Controls.Add(Me.cjaRegistro_File)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cjaRegistro_Password)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cjaRegistro_Usuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cjaRegistro_Nombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Registro"
        Me.Text = "Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cjaRegistro_Nombre As TextBox
    Friend WithEvents cjaRegistro_Usuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cjaRegistro_Password As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cjaRegistro_File As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRegistrarse As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents cjaRegistro_Sexo As ComboBox
    Friend WithEvents cjaRegistro_Tipo As ComboBox
    Friend WithEvents cjaRegistro_Fecha As DateTimePicker
    Friend WithEvents btnRegistro_Buscar As Button
    Friend WithEvents btnRegistro_Eliminar As Button
    Friend WithEvents btnRegistro_File As Button
End Class
