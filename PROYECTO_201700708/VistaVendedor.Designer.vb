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
        Me.cjaBuscar = New System.Windows.Forms.TextBox()
        Me.btnVendedor_Buscar = New System.Windows.Forms.Button()
        Me.btnVendedor_Vender = New System.Windows.Forms.Button()
        Me.dgv_VVProductos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_VVProductos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'cjaBuscar
        '
        Me.cjaBuscar.Location = New System.Drawing.Point(12, 12)
        Me.cjaBuscar.Name = "cjaBuscar"
        Me.cjaBuscar.Size = New System.Drawing.Size(390, 27)
        Me.cjaBuscar.TabIndex = 2
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
        'dgv_VVProductos
        '
        Me.dgv_VVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_VVProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv_VVProductos.Location = New System.Drawing.Point(24, 73)
        Me.dgv_VVProductos.Name = "dgv_VVProductos"
        Me.dgv_VVProductos.RowHeadersWidth = 51
        Me.dgv_VVProductos.RowTemplate.Height = 29
        Me.dgv_VVProductos.Size = New System.Drawing.Size(750, 298)
        Me.dgv_VVProductos.TabIndex = 5
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
        'VistaVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgv_VVProductos)
        Me.Controls.Add(Me.btnVendedor_Vender)
        Me.Controls.Add(Me.btnVendedor_Buscar)
        Me.Controls.Add(Me.cjaBuscar)
        Me.Controls.Add(Me.btnVendedor_Salir)
        Me.Controls.Add(Me.btnVendedor_Configuracion)
        Me.Name = "VistaVendedor"
        Me.Text = "Vendedor"
        CType(Me.dgv_VVProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVendedor_Configuracion As Button
    Friend WithEvents btnVendedor_Salir As Button
    Friend WithEvents cjaBuscar As TextBox
    Friend WithEvents btnVendedor_Buscar As Button
    Friend WithEvents btnVendedor_Vender As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Public WithEvents dgv_VVProductos As DataGridView
End Class
