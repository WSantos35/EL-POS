<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reporte4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.et_Producto1 = New System.Windows.Forms.Label()
        Me.et_Producto2 = New System.Windows.Forms.Label()
        Me.et_Producto3 = New System.Windows.Forms.Label()
        Me.et_CantProd1 = New System.Windows.Forms.Label()
        Me.et_CantProd2 = New System.Windows.Forms.Label()
        Me.et_CantProd3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(665, 511)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'et_Producto1
        '
        Me.et_Producto1.AutoSize = True
        Me.et_Producto1.Location = New System.Drawing.Point(31, 123)
        Me.et_Producto1.Name = "et_Producto1"
        Me.et_Producto1.Size = New System.Drawing.Size(132, 20)
        Me.et_Producto1.TabIndex = 1
        Me.et_Producto1.Text = "EtiquetaProducto1"
        '
        'et_Producto2
        '
        Me.et_Producto2.AutoSize = True
        Me.et_Producto2.Location = New System.Drawing.Point(31, 228)
        Me.et_Producto2.Name = "et_Producto2"
        Me.et_Producto2.Size = New System.Drawing.Size(132, 20)
        Me.et_Producto2.TabIndex = 2
        Me.et_Producto2.Text = "EtiquetaProducto2"
        '
        'et_Producto3
        '
        Me.et_Producto3.AutoSize = True
        Me.et_Producto3.Location = New System.Drawing.Point(31, 329)
        Me.et_Producto3.Name = "et_Producto3"
        Me.et_Producto3.Size = New System.Drawing.Size(132, 20)
        Me.et_Producto3.TabIndex = 3
        Me.et_Producto3.Text = "EtiquetaProducto3"
        '
        'et_CantProd1
        '
        Me.et_CantProd1.AutoSize = True
        Me.et_CantProd1.Location = New System.Drawing.Point(656, 123)
        Me.et_CantProd1.Name = "et_CantProd1"
        Me.et_CantProd1.Size = New System.Drawing.Size(132, 20)
        Me.et_CantProd1.TabIndex = 4
        Me.et_CantProd1.Text = "EtiquetaProducto1"
        '
        'et_CantProd2
        '
        Me.et_CantProd2.AutoSize = True
        Me.et_CantProd2.Location = New System.Drawing.Point(656, 228)
        Me.et_CantProd2.Name = "et_CantProd2"
        Me.et_CantProd2.Size = New System.Drawing.Size(132, 20)
        Me.et_CantProd2.TabIndex = 5
        Me.et_CantProd2.Text = "EtiquetaProducto2"
        '
        'et_CantProd3
        '
        Me.et_CantProd3.AutoSize = True
        Me.et_CantProd3.Location = New System.Drawing.Point(656, 329)
        Me.et_CantProd3.Name = "et_CantProd3"
        Me.et_CantProd3.Size = New System.Drawing.Size(132, 20)
        Me.et_CantProd3.TabIndex = 6
        Me.et_CantProd3.Text = "EtiquetaProducto3"
        '
        'Reporte4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.et_CantProd3)
        Me.Controls.Add(Me.et_CantProd2)
        Me.Controls.Add(Me.et_CantProd1)
        Me.Controls.Add(Me.et_Producto3)
        Me.Controls.Add(Me.et_Producto2)
        Me.Controls.Add(Me.et_Producto1)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Reporte4"
        Me.Text = "Reporte4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Public WithEvents et_Producto1 As Label
    Public WithEvents et_Producto2 As Label
    Public WithEvents et_Producto3 As Label
    Public WithEvents et_CantProd1 As Label
    Public WithEvents et_CantProd2 As Label
    Public WithEvents et_CantProd3 As Label
End Class
