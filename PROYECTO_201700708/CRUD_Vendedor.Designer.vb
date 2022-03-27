<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRUD_Vendedor
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
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.dg_TablaVendedores = New System.Windows.Forms.DataGridView()
        Me.Columna1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dg_TablaVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(903, 94)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(144, 30)
        Me.btnRegresar.TabIndex = 0
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(902, 48)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(145, 32)
        Me.btnRegistrar.TabIndex = 1
        Me.btnRegistrar.Text = "Registrar Vendedor"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'dg_TablaVendedores
        '
        Me.dg_TablaVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_TablaVendedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Columna1, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dg_TablaVendedores.Location = New System.Drawing.Point(33, 104)
        Me.dg_TablaVendedores.Name = "dg_TablaVendedores"
        Me.dg_TablaVendedores.RowHeadersWidth = 51
        Me.dg_TablaVendedores.RowTemplate.Height = 29
        Me.dg_TablaVendedores.Size = New System.Drawing.Size(848, 374)
        Me.dg_TablaVendedores.TabIndex = 2
        '
        'Columna1
        '
        Me.Columna1.HeaderText = "Codigo Usuario"
        Me.Columna1.MinimumWidth = 6
        Me.Columna1.Name = "Columna1"
        Me.Columna1.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Fecha Nacimiento"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Sexo"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Usuario"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Tipo"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'CRUD_Vendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 516)
        Me.Controls.Add(Me.dg_TablaVendedores)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "CRUD_Vendedor"
        Me.Text = "CRUD Vendedor"
        CType(Me.dg_TablaVendedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Columna1 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Public WithEvents dg_TablaVendedores As DataGridView
End Class
