<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rb_Pantalon = New System.Windows.Forms.RadioButton()
        Me.rb_Playeras = New System.Windows.Forms.RadioButton()
        Me.rb_camisas = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rb_clienteMenudeo = New System.Windows.Forms.RadioButton()
        Me.rb_mayorista = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cja_CantidadDocenas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cja_RegistroUnico = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cja_NombreCliente = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(26, 273)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(1032, 218)
        Me.DataGridView1.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rb_Pantalon)
        Me.Panel2.Controls.Add(Me.rb_Playeras)
        Me.Panel2.Controls.Add(Me.rb_camisas)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(783, 76)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(162, 148)
        Me.Panel2.TabIndex = 17
        '
        'rb_Pantalon
        '
        Me.rb_Pantalon.AutoSize = True
        Me.rb_Pantalon.Location = New System.Drawing.Point(15, 99)
        Me.rb_Pantalon.Name = "rb_Pantalon"
        Me.rb_Pantalon.Size = New System.Drawing.Size(87, 24)
        Me.rb_Pantalon.TabIndex = 12
        Me.rb_Pantalon.TabStop = True
        Me.rb_Pantalon.Text = "Pantalon"
        Me.rb_Pantalon.UseVisualStyleBackColor = True
        '
        'rb_Playeras
        '
        Me.rb_Playeras.AutoSize = True
        Me.rb_Playeras.Location = New System.Drawing.Point(15, 69)
        Me.rb_Playeras.Name = "rb_Playeras"
        Me.rb_Playeras.Size = New System.Drawing.Size(84, 24)
        Me.rb_Playeras.TabIndex = 11
        Me.rb_Playeras.TabStop = True
        Me.rb_Playeras.Text = "Playeras"
        Me.rb_Playeras.UseVisualStyleBackColor = True
        '
        'rb_camisas
        '
        Me.rb_camisas.AutoSize = True
        Me.rb_camisas.Location = New System.Drawing.Point(15, 39)
        Me.rb_camisas.Name = "rb_camisas"
        Me.rb_camisas.Size = New System.Drawing.Size(84, 24)
        Me.rb_camisas.TabIndex = 10
        Me.rb_camisas.TabStop = True
        Me.rb_camisas.Text = "Camisas"
        Me.rb_camisas.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tipo de Prenda"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rb_clienteMenudeo)
        Me.Panel1.Controls.Add(Me.rb_mayorista)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(540, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(199, 125)
        Me.Panel1.TabIndex = 16
        '
        'rb_clienteMenudeo
        '
        Me.rb_clienteMenudeo.AutoSize = True
        Me.rb_clienteMenudeo.Location = New System.Drawing.Point(13, 69)
        Me.rb_clienteMenudeo.Name = "rb_clienteMenudeo"
        Me.rb_clienteMenudeo.Size = New System.Drawing.Size(159, 24)
        Me.rb_clienteMenudeo.TabIndex = 10
        Me.rb_clienteMenudeo.TabStop = True
        Me.rb_clienteMenudeo.Text = "Cliente al Menudeo"
        Me.rb_clienteMenudeo.UseVisualStyleBackColor = True
        '
        'rb_mayorista
        '
        Me.rb_mayorista.AutoSize = True
        Me.rb_mayorista.Location = New System.Drawing.Point(13, 39)
        Me.rb_mayorista.Name = "rb_mayorista"
        Me.rb_mayorista.Size = New System.Drawing.Size(89, 24)
        Me.rb_mayorista.TabIndex = 9
        Me.rb_mayorista.TabStop = True
        Me.rb_mayorista.Text = "Mayorita"
        Me.rb_mayorista.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tipo Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Cantidad Docenas"
        '
        'cja_CantidadDocenas
        '
        Me.cja_CantidadDocenas.Location = New System.Drawing.Point(172, 178)
        Me.cja_CantidadDocenas.Name = "cja_CantidadDocenas"
        Me.cja_CantidadDocenas.Size = New System.Drawing.Size(318, 27)
        Me.cja_CantidadDocenas.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Registro Unico"
        '
        'cja_RegistroUnico
        '
        Me.cja_RegistroUnico.Location = New System.Drawing.Point(172, 129)
        Me.cja_RegistroUnico.Name = "cja_RegistroUnico"
        Me.cja_RegistroUnico.Size = New System.Drawing.Size(318, 27)
        Me.cja_RegistroUnico.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nombre Cliente"
        '
        'cja_NombreCliente
        '
        Me.cja_NombreCliente.Location = New System.Drawing.Point(172, 82)
        Me.cja_NombreCliente.Name = "cja_NombreCliente"
        Me.cja_NombreCliente.Size = New System.Drawing.Size(318, 27)
        Me.cja_NombreCliente.TabIndex = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1082, 28)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(75, 24)
        Me.ToolStripMenuItem1.Text = "Aceptar"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(74, 24)
        Me.ToolStripMenuItem2.Text = "Mostrar"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(66, 24)
        Me.ToolStripMenuItem3.Text = "Buscar"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(91, 24)
        Me.ToolStripMenuItem4.Text = "Orden Asc"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(133, 24)
        Me.ToolStripMenuItem5.Text = "Limpiar Vectores"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(52, 24)
        Me.ToolStripMenuItem6.Text = "Salir"
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
        Me.Column2.HeaderText = "Registro U"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Tipo Cliente"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tipo Prenda"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Cantidad Docenas"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Sub Total"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "Total"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 536)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cja_CantidadDocenas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cja_RegistroUnico)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cja_NombreCliente)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rb_Pantalon As RadioButton
    Friend WithEvents rb_Playeras As RadioButton
    Friend WithEvents rb_camisas As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rb_clienteMenudeo As RadioButton
    Friend WithEvents rb_mayorista As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cja_CantidadDocenas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cja_RegistroUnico As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cja_NombreCliente As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
