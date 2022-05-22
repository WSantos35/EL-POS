<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigPerfil
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
        Me.btnConfig_Regresar = New System.Windows.Forms.Button()
        Me.pb_ImagePerfil = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cjaPerfil_Nombre = New System.Windows.Forms.TextBox()
        Me.cjaPerfil_Sexo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cjaPerfil_FechaNac = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cjaPerfil_Usuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cjaPerfil_Password = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnPerfil_Actualizar = New System.Windows.Forms.Button()
        Me.btnPerfil_Rotar = New System.Windows.Forms.Button()
        CType(Me.pb_ImagePerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConfig_Regresar
        '
        Me.btnConfig_Regresar.Location = New System.Drawing.Point(672, 394)
        Me.btnConfig_Regresar.Name = "btnConfig_Regresar"
        Me.btnConfig_Regresar.Size = New System.Drawing.Size(94, 29)
        Me.btnConfig_Regresar.TabIndex = 0
        Me.btnConfig_Regresar.Text = "Regresar"
        Me.btnConfig_Regresar.UseVisualStyleBackColor = True
        '
        'pb_ImagePerfil
        '
        Me.pb_ImagePerfil.Location = New System.Drawing.Point(41, 27)
        Me.pb_ImagePerfil.Name = "pb_ImagePerfil"
        Me.pb_ImagePerfil.Size = New System.Drawing.Size(189, 206)
        Me.pb_ImagePerfil.TabIndex = 1
        Me.pb_ImagePerfil.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'cjaPerfil_Nombre
        '
        Me.cjaPerfil_Nombre.Location = New System.Drawing.Point(354, 50)
        Me.cjaPerfil_Nombre.Name = "cjaPerfil_Nombre"
        Me.cjaPerfil_Nombre.Size = New System.Drawing.Size(267, 27)
        Me.cjaPerfil_Nombre.TabIndex = 3
        '
        'cjaPerfil_Sexo
        '
        Me.cjaPerfil_Sexo.Location = New System.Drawing.Point(354, 104)
        Me.cjaPerfil_Sexo.Name = "cjaPerfil_Sexo"
        Me.cjaPerfil_Sexo.ReadOnly = True
        Me.cjaPerfil_Sexo.Size = New System.Drawing.Size(267, 27)
        Me.cjaPerfil_Sexo.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(272, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sexo"
        '
        'cjaPerfil_FechaNac
        '
        Me.cjaPerfil_FechaNac.Location = New System.Drawing.Point(420, 147)
        Me.cjaPerfil_FechaNac.Name = "cjaPerfil_FechaNac"
        Me.cjaPerfil_FechaNac.ReadOnly = True
        Me.cjaPerfil_FechaNac.Size = New System.Drawing.Size(201, 27)
        Me.cjaPerfil_FechaNac.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(272, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha Nacimiento"
        '
        'cjaPerfil_Usuario
        '
        Me.cjaPerfil_Usuario.Location = New System.Drawing.Point(354, 199)
        Me.cjaPerfil_Usuario.Name = "cjaPerfil_Usuario"
        Me.cjaPerfil_Usuario.ReadOnly = True
        Me.cjaPerfil_Usuario.Size = New System.Drawing.Size(267, 27)
        Me.cjaPerfil_Usuario.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(272, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Usuario"
        '
        'cjaPerfil_Password
        '
        Me.cjaPerfil_Password.Location = New System.Drawing.Point(354, 248)
        Me.cjaPerfil_Password.Name = "cjaPerfil_Password"
        Me.cjaPerfil_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.cjaPerfil_Password.Size = New System.Drawing.Size(267, 27)
        Me.cjaPerfil_Password.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(272, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Password"
        '
        'btnPerfil_Actualizar
        '
        Me.btnPerfil_Actualizar.Location = New System.Drawing.Point(549, 394)
        Me.btnPerfil_Actualizar.Name = "btnPerfil_Actualizar"
        Me.btnPerfil_Actualizar.Size = New System.Drawing.Size(94, 29)
        Me.btnPerfil_Actualizar.TabIndex = 12
        Me.btnPerfil_Actualizar.Text = "Actualizar"
        Me.btnPerfil_Actualizar.UseVisualStyleBackColor = True
        '
        'btnPerfil_Rotar
        '
        Me.btnPerfil_Rotar.Location = New System.Drawing.Point(76, 242)
        Me.btnPerfil_Rotar.Name = "btnPerfil_Rotar"
        Me.btnPerfil_Rotar.Size = New System.Drawing.Size(94, 29)
        Me.btnPerfil_Rotar.TabIndex = 13
        Me.btnPerfil_Rotar.Text = "Rotar"
        Me.btnPerfil_Rotar.UseVisualStyleBackColor = True
        '
        'ConfigPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPerfil_Rotar)
        Me.Controls.Add(Me.btnPerfil_Actualizar)
        Me.Controls.Add(Me.cjaPerfil_Password)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cjaPerfil_Usuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cjaPerfil_FechaNac)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cjaPerfil_Sexo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cjaPerfil_Nombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb_ImagePerfil)
        Me.Controls.Add(Me.btnConfig_Regresar)
        Me.Name = "ConfigPerfil"
        Me.Text = "Perfil"
        CType(Me.pb_ImagePerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConfig_Regresar As Button
    Public WithEvents pb_ImagePerfil As PictureBox
    Friend WithEvents Label1 As Label
    Public WithEvents cjaPerfil_Nombre As TextBox
    Friend WithEvents cjaPerfil_Sexo As TextBox
    Friend WithEvents Label2 As Label
    Public WithEvents cjaPerfil_FechaNac As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cjaPerfil_Usuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cjaPerfil_Password As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnPerfil_Actualizar As Button
    Friend WithEvents btnPerfil_Rotar As Button
End Class
