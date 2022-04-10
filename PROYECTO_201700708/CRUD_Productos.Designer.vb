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
        Me.dgv_TablaProductos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_TablaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'dgv_TablaProductos
        '
        Me.dgv_TablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_TablaProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv_TablaProductos.Location = New System.Drawing.Point(28, 90)
        Me.dgv_TablaProductos.Name = "dgv_TablaProductos"
        Me.dgv_TablaProductos.RowHeadersWidth = 51
        Me.dgv_TablaProductos.RowTemplate.Height = 29
        Me.dgv_TablaProductos.Size = New System.Drawing.Size(861, 358)
        Me.dgv_TablaProductos.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Precio"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Stock"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Descripcion"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'CRUD_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 516)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgv_TablaProductos)
        Me.Controls.Add(Me.btnProductos_Regresar)
        Me.Controls.Add(Me.btnProductos_Registrarse)
        Me.Name = "CRUD_Productos"
        Me.Text = "CRUD Productos"
        CType(Me.dgv_TablaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProductos_Registrarse As Button
    Friend WithEvents btnProductos_Regresar As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Public WithEvents dgv_TablaProductos As DataGridView
End Class
