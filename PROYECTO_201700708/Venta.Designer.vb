<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta
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
        Me.cjaVenta_Codigo = New System.Windows.Forms.TextBox()
        Me.cjaVenta_Producto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cjaVenta_Cantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cjaVenta_SubTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cjaVenta_Total = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cjaVenta_Precio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnVenta_Buscar = New System.Windows.Forms.Button()
        Me.btnVenta_Cancelar = New System.Windows.Forms.Button()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.cjaVenta_NombreCliente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cjaVenta_NIT = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'cjaVenta_Codigo
        '
        Me.cjaVenta_Codigo.Location = New System.Drawing.Point(173, 64)
        Me.cjaVenta_Codigo.Name = "cjaVenta_Codigo"
        Me.cjaVenta_Codigo.Size = New System.Drawing.Size(200, 27)
        Me.cjaVenta_Codigo.TabIndex = 1
        '
        'cjaVenta_Producto
        '
        Me.cjaVenta_Producto.Location = New System.Drawing.Point(173, 123)
        Me.cjaVenta_Producto.Name = "cjaVenta_Producto"
        Me.cjaVenta_Producto.ReadOnly = True
        Me.cjaVenta_Producto.Size = New System.Drawing.Size(200, 27)
        Me.cjaVenta_Producto.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Producto"
        '
        'cjaVenta_Cantidad
        '
        Me.cjaVenta_Cantidad.Location = New System.Drawing.Point(173, 171)
        Me.cjaVenta_Cantidad.Name = "cjaVenta_Cantidad"
        Me.cjaVenta_Cantidad.Size = New System.Drawing.Size(200, 27)
        Me.cjaVenta_Cantidad.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad"
        '
        'cjaVenta_SubTotal
        '
        Me.cjaVenta_SubTotal.Location = New System.Drawing.Point(173, 269)
        Me.cjaVenta_SubTotal.Name = "cjaVenta_SubTotal"
        Me.cjaVenta_SubTotal.ReadOnly = True
        Me.cjaVenta_SubTotal.Size = New System.Drawing.Size(200, 27)
        Me.cjaVenta_SubTotal.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(87, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sub-Total"
        '
        'cjaVenta_Total
        '
        Me.cjaVenta_Total.Location = New System.Drawing.Point(173, 316)
        Me.cjaVenta_Total.Name = "cjaVenta_Total"
        Me.cjaVenta_Total.ReadOnly = True
        Me.cjaVenta_Total.Size = New System.Drawing.Size(200, 27)
        Me.cjaVenta_Total.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total"
        '
        'cjaVenta_Precio
        '
        Me.cjaVenta_Precio.Location = New System.Drawing.Point(173, 222)
        Me.cjaVenta_Precio.Name = "cjaVenta_Precio"
        Me.cjaVenta_Precio.ReadOnly = True
        Me.cjaVenta_Precio.Size = New System.Drawing.Size(200, 27)
        Me.cjaVenta_Precio.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(87, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Precio"
        '
        'btnVenta_Buscar
        '
        Me.btnVenta_Buscar.Location = New System.Drawing.Point(206, 402)
        Me.btnVenta_Buscar.Name = "btnVenta_Buscar"
        Me.btnVenta_Buscar.Size = New System.Drawing.Size(94, 29)
        Me.btnVenta_Buscar.TabIndex = 12
        Me.btnVenta_Buscar.Text = "Buscar"
        Me.btnVenta_Buscar.UseVisualStyleBackColor = True
        '
        'btnVenta_Cancelar
        '
        Me.btnVenta_Cancelar.Location = New System.Drawing.Point(489, 402)
        Me.btnVenta_Cancelar.Name = "btnVenta_Cancelar"
        Me.btnVenta_Cancelar.Size = New System.Drawing.Size(94, 29)
        Me.btnVenta_Cancelar.TabIndex = 13
        Me.btnVenta_Cancelar.Text = "Cancelar"
        Me.btnVenta_Cancelar.UseVisualStyleBackColor = True
        '
        'btnVender
        '
        Me.btnVender.Location = New System.Drawing.Point(368, 402)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(94, 29)
        Me.btnVender.TabIndex = 15
        Me.btnVender.Text = "Vender"
        Me.btnVender.UseVisualStyleBackColor = True
        '
        'cjaVenta_NombreCliente
        '
        Me.cjaVenta_NombreCliente.Location = New System.Drawing.Point(542, 64)
        Me.cjaVenta_NombreCliente.Name = "cjaVenta_NombreCliente"
        Me.cjaVenta_NombreCliente.Size = New System.Drawing.Size(200, 27)
        Me.cjaVenta_NombreCliente.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(422, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Nombre Cliente"
        '
        'cjaVenta_NIT
        '
        Me.cjaVenta_NIT.Location = New System.Drawing.Point(542, 123)
        Me.cjaVenta_NIT.Name = "cjaVenta_NIT"
        Me.cjaVenta_NIT.Size = New System.Drawing.Size(200, 27)
        Me.cjaVenta_NIT.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(422, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "NIT"
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 509)
        Me.ControlBox = False
        Me.Controls.Add(Me.cjaVenta_NIT)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cjaVenta_NombreCliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnVender)
        Me.Controls.Add(Me.btnVenta_Cancelar)
        Me.Controls.Add(Me.btnVenta_Buscar)
        Me.Controls.Add(Me.cjaVenta_Precio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cjaVenta_Total)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cjaVenta_SubTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cjaVenta_Cantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cjaVenta_Producto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cjaVenta_Codigo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Venta"
        Me.Text = "Venta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cjaVenta_Codigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cjaVenta_Cantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cjaVenta_SubTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cjaVenta_Total As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnVenta_Buscar As Button
    Friend WithEvents btnVenta_Cancelar As Button
    Friend WithEvents btnVender As Button
    Public WithEvents cjaVenta_Producto As TextBox
    Public WithEvents cjaVenta_Precio As TextBox
    Friend WithEvents cjaVenta_NombreCliente As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cjaVenta_NIT As TextBox
    Friend WithEvents Label8 As Label
End Class
