<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRUD_Productos
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
        Me.btnProductos_Registrarse = New System.Windows.Forms.Button()
        Me.btnProductos_Regresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProductos_Registrarse
        '
        Me.btnProductos_Registrarse.Location = New System.Drawing.Point(906, 41)
        Me.btnProductos_Registrarse.Name = "btnProductos_Registrarse"
        Me.btnProductos_Registrarse.Size = New System.Drawing.Size(150, 32)
        Me.btnProductos_Registrarse.TabIndex = 0
        Me.btnProductos_Registrarse.Text = "Registrar Producto"
        Me.btnProductos_Registrarse.UseVisualStyleBackColor = True
        '
        'btnProductos_Regresar
        '
        Me.btnProductos_Regresar.Location = New System.Drawing.Point(906, 90)
        Me.btnProductos_Regresar.Name = "btnProductos_Regresar"
        Me.btnProductos_Regresar.Size = New System.Drawing.Size(150, 34)
        Me.btnProductos_Regresar.TabIndex = 1
        Me.btnProductos_Regresar.Text = "Regresar"
        Me.btnProductos_Regresar.UseVisualStyleBackColor = True
        '
        'CRUD_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 516)
        Me.Controls.Add(Me.btnProductos_Regresar)
        Me.Controls.Add(Me.btnProductos_Registrarse)
        Me.Name = "CRUD_Productos"
        Me.Text = "CRUD Productos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProductos_Registrarse As Button
    Friend WithEvents btnProductos_Regresar As Button
End Class
