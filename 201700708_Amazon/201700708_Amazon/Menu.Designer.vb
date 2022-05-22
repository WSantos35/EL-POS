<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnLimpiarListbox = New System.Windows.Forms.Button()
        Me.btnLimpiarMatriz = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lboxListadoProductos = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(61, 49)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(94, 29)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnLimpiarListbox
        '
        Me.btnLimpiarListbox.Location = New System.Drawing.Point(178, 49)
        Me.btnLimpiarListbox.Name = "btnLimpiarListbox"
        Me.btnLimpiarListbox.Size = New System.Drawing.Size(134, 29)
        Me.btnLimpiarListbox.TabIndex = 1
        Me.btnLimpiarListbox.Text = "Limpiar Listbox"
        Me.btnLimpiarListbox.UseVisualStyleBackColor = True
        '
        'btnLimpiarMatriz
        '
        Me.btnLimpiarMatriz.Location = New System.Drawing.Point(345, 49)
        Me.btnLimpiarMatriz.Name = "btnLimpiarMatriz"
        Me.btnLimpiarMatriz.Size = New System.Drawing.Size(141, 29)
        Me.btnLimpiarMatriz.TabIndex = 2
        Me.btnLimpiarMatriz.Text = "Limpiar Matriz"
        Me.btnLimpiarMatriz.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(501, 49)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 29)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lboxListadoProductos
        '
        Me.lboxListadoProductos.FormattingEnabled = True
        Me.lboxListadoProductos.ItemHeight = 20
        Me.lboxListadoProductos.Location = New System.Drawing.Point(61, 158)
        Me.lboxListadoProductos.Name = "lboxListadoProductos"
        Me.lboxListadoProductos.Size = New System.Drawing.Size(627, 204)
        Me.lboxListadoProductos.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(612, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 432)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lboxListadoProductos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiarMatriz)
        Me.Controls.Add(Me.btnLimpiarListbox)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnLimpiarListbox As Button
    Friend WithEvents btnLimpiarMatriz As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Button1 As Button
    Public WithEvents lboxListadoProductos As ListBox
End Class
