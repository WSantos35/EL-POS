<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VistaVendedor
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
        Me.btnVendedor_Configuracion = New System.Windows.Forms.Button()
        Me.btnVendedor_Salir = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnVendedor_Buscar = New System.Windows.Forms.Button()
        Me.btnVendedor_Vender = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVendedor_Configuracion
        '
        Me.btnVendedor_Configuracion.Location = New System.Drawing.Point(529, 399)
        Me.btnVendedor_Configuracion.Name = "btnVendedor_Configuracion"
        Me.btnVendedor_Configuracion.Size = New System.Drawing.Size(96, 30)
        Me.btnVendedor_Configuracion.TabIndex = 0
        Me.btnVendedor_Configuracion.Text = "Perfil"
        Me.btnVendedor_Configuracion.UseVisualStyleBackColor = True
        '
        'btnVendedor_Salir
        '
        Me.btnVendedor_Salir.Location = New System.Drawing.Point(643, 399)
        Me.btnVendedor_Salir.Name = "btnVendedor_Salir"
        Me.btnVendedor_Salir.Size = New System.Drawing.Size(131, 30)
        Me.btnVendedor_Salir.TabIndex = 1
        Me.btnVendedor_Salir.Text = "Salir"
        Me.btnVendedor_Salir.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(390, 27)
        Me.TextBox1.TabIndex = 2
        '
        'btnVendedor_Buscar
        '
        Me.btnVendedor_Buscar.Location = New System.Drawing.Point(408, 12)
        Me.btnVendedor_Buscar.Name = "btnVendedor_Buscar"
        Me.btnVendedor_Buscar.Size = New System.Drawing.Size(94, 29)
        Me.btnVendedor_Buscar.TabIndex = 3
        Me.btnVendedor_Buscar.Text = "Buscar"
        Me.btnVendedor_Buscar.UseVisualStyleBackColor = True
        '
        'btnVendedor_Vender
        '
        Me.btnVendedor_Vender.Location = New System.Drawing.Point(694, 10)
        Me.btnVendedor_Vender.Name = "btnVendedor_Vender"
        Me.btnVendedor_Vender.Size = New System.Drawing.Size(94, 29)
        Me.btnVendedor_Vender.TabIndex = 4
        Me.btnVendedor_Vender.Text = "Vender"
        Me.btnVendedor_Vender.UseVisualStyleBackColor = True
        '
        'VistaVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnVendedor_Vender)
        Me.Controls.Add(Me.btnVendedor_Buscar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnVendedor_Salir)
        Me.Controls.Add(Me.btnVendedor_Configuracion)
        Me.Name = "VistaVendedor"
        Me.Text = "Vendedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVendedor_Configuracion As Button
    Friend WithEvents btnVendedor_Salir As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnVendedor_Buscar As Button
    Friend WithEvents btnVendedor_Vender As Button
End Class
