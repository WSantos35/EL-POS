<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte5
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
        Me.et_CantProd3 = New System.Windows.Forms.Label()
        Me.et_CantProd2 = New System.Windows.Forms.Label()
        Me.et_CantProd1 = New System.Windows.Forms.Label()
        Me.et_Producto3 = New System.Windows.Forms.Label()
        Me.et_Producto2 = New System.Windows.Forms.Label()
        Me.et_Producto1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'et_CantProd3
        '
        Me.et_CantProd3.AutoSize = True
        Me.et_CantProd3.Location = New System.Drawing.Point(656, 329)
        Me.et_CantProd3.Name = "et_CantProd3"
        Me.et_CantProd3.Size = New System.Drawing.Size(132, 20)
        Me.et_CantProd3.TabIndex = 13
        Me.et_CantProd3.Text = "EtiquetaProducto3"
        '
        'et_CantProd2
        '
        Me.et_CantProd2.AutoSize = True
        Me.et_CantProd2.Location = New System.Drawing.Point(656, 228)
        Me.et_CantProd2.Name = "et_CantProd2"
        Me.et_CantProd2.Size = New System.Drawing.Size(132, 20)
        Me.et_CantProd2.TabIndex = 12
        Me.et_CantProd2.Text = "EtiquetaProducto2"
        '
        'et_CantProd1
        '
        Me.et_CantProd1.AutoSize = True
        Me.et_CantProd1.Location = New System.Drawing.Point(656, 123)
        Me.et_CantProd1.Name = "et_CantProd1"
        Me.et_CantProd1.Size = New System.Drawing.Size(132, 20)
        Me.et_CantProd1.TabIndex = 11
        Me.et_CantProd1.Text = "EtiquetaProducto1"
        '
        'et_Producto3
        '
        Me.et_Producto3.AutoSize = True
        Me.et_Producto3.Location = New System.Drawing.Point(31, 329)
        Me.et_Producto3.Name = "et_Producto3"
        Me.et_Producto3.Size = New System.Drawing.Size(132, 20)
        Me.et_Producto3.TabIndex = 10
        Me.et_Producto3.Text = "EtiquetaProducto3"
        '
        'et_Producto2
        '
        Me.et_Producto2.AutoSize = True
        Me.et_Producto2.Location = New System.Drawing.Point(31, 228)
        Me.et_Producto2.Name = "et_Producto2"
        Me.et_Producto2.Size = New System.Drawing.Size(132, 20)
        Me.et_Producto2.TabIndex = 9
        Me.et_Producto2.Text = "EtiquetaProducto2"
        '
        'et_Producto1
        '
        Me.et_Producto1.AutoSize = True
        Me.et_Producto1.Location = New System.Drawing.Point(31, 123)
        Me.et_Producto1.Name = "et_Producto1"
        Me.et_Producto1.Size = New System.Drawing.Size(132, 20)
        Me.et_Producto1.TabIndex = 8
        Me.et_Producto1.Text = "EtiquetaProducto1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(665, 511)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Reporte5
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
        Me.Name = "Reporte5"
        Me.Text = "Reporte5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents et_CantProd3 As Label
    Public WithEvents et_CantProd2 As Label
    Public WithEvents et_CantProd1 As Label
    Public WithEvents et_Producto3 As Label
    Public WithEvents et_Producto2 As Label
    Public WithEvents et_Producto1 As Label
    Friend WithEvents Button1 As Button
End Class
