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
        Me.components = New System.ComponentModel.Container()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cjaNombreCliente = New System.Windows.Forms.TextBox()
        Me.cjaValorArticulo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cjaNumeroTarjeta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbRopa = New System.Windows.Forms.RadioButton()
        Me.rbTablets = New System.Windows.Forms.RadioButton()
        Me.rbCelulares = New System.Windows.Forms.RadioButton()
        Me.rbVideoJuegos = New System.Windows.Forms.RadioButton()
        Me.rbLaptop = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbEnvioCasa = New System.Windows.Forms.RadioButton()
        Me.rbEnvioCC = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnCargarDatos = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(572, 27)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(186, 38)
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre Cliente"
        '
        'cjaNombreCliente
        '
        Me.cjaNombreCliente.Enabled = False
        Me.cjaNombreCliente.Location = New System.Drawing.Point(182, 38)
        Me.cjaNombreCliente.Name = "cjaNombreCliente"
        Me.cjaNombreCliente.Size = New System.Drawing.Size(280, 27)
        Me.cjaNombreCliente.TabIndex = 2
        '
        'cjaValorArticulo
        '
        Me.cjaValorArticulo.Enabled = False
        Me.cjaValorArticulo.Location = New System.Drawing.Point(182, 91)
        Me.cjaValorArticulo.Name = "cjaValorArticulo"
        Me.cjaValorArticulo.Size = New System.Drawing.Size(280, 27)
        Me.cjaValorArticulo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Valor Articulo ($)"
        '
        'cjaNumeroTarjeta
        '
        Me.cjaNumeroTarjeta.Enabled = False
        Me.cjaNumeroTarjeta.Location = New System.Drawing.Point(182, 144)
        Me.cjaNumeroTarjeta.Name = "cjaNumeroTarjeta"
        Me.cjaNumeroTarjeta.Size = New System.Drawing.Size(280, 27)
        Me.cjaNumeroTarjeta.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Numero Tarjeta"
        '
        'rbRopa
        '
        Me.rbRopa.AutoSize = True
        Me.rbRopa.Location = New System.Drawing.Point(16, 10)
        Me.rbRopa.Name = "rbRopa"
        Me.rbRopa.Size = New System.Drawing.Size(65, 24)
        Me.rbRopa.TabIndex = 8
        Me.rbRopa.TabStop = True
        Me.rbRopa.Text = "Ropa"
        Me.rbRopa.UseVisualStyleBackColor = True
        '
        'rbTablets
        '
        Me.rbTablets.AutoSize = True
        Me.rbTablets.Location = New System.Drawing.Point(16, 40)
        Me.rbTablets.Name = "rbTablets"
        Me.rbTablets.Size = New System.Drawing.Size(76, 24)
        Me.rbTablets.TabIndex = 9
        Me.rbTablets.TabStop = True
        Me.rbTablets.Text = "Tablets"
        Me.rbTablets.UseVisualStyleBackColor = True
        '
        'rbCelulares
        '
        Me.rbCelulares.AutoSize = True
        Me.rbCelulares.Location = New System.Drawing.Point(16, 70)
        Me.rbCelulares.Name = "rbCelulares"
        Me.rbCelulares.Size = New System.Drawing.Size(90, 24)
        Me.rbCelulares.TabIndex = 11
        Me.rbCelulares.TabStop = True
        Me.rbCelulares.Text = "Celulares"
        Me.rbCelulares.UseVisualStyleBackColor = True
        '
        'rbVideoJuegos
        '
        Me.rbVideoJuegos.AutoSize = True
        Me.rbVideoJuegos.Location = New System.Drawing.Point(16, 100)
        Me.rbVideoJuegos.Name = "rbVideoJuegos"
        Me.rbVideoJuegos.Size = New System.Drawing.Size(114, 24)
        Me.rbVideoJuegos.TabIndex = 10
        Me.rbVideoJuegos.TabStop = True
        Me.rbVideoJuegos.Text = "VideoJuegos"
        Me.rbVideoJuegos.UseVisualStyleBackColor = True
        '
        'rbLaptop
        '
        Me.rbLaptop.AutoSize = True
        Me.rbLaptop.Location = New System.Drawing.Point(16, 130)
        Me.rbLaptop.Name = "rbLaptop"
        Me.rbLaptop.Size = New System.Drawing.Size(77, 24)
        Me.rbLaptop.TabIndex = 12
        Me.rbLaptop.TabStop = True
        Me.rbLaptop.Text = "Laptop"
        Me.rbLaptop.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbVideoJuegos)
        Me.Panel1.Controls.Add(Me.rbLaptop)
        Me.Panel1.Controls.Add(Me.rbRopa)
        Me.Panel1.Controls.Add(Me.rbCelulares)
        Me.Panel1.Controls.Add(Me.rbTablets)
        Me.Panel1.Location = New System.Drawing.Point(50, 243)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(133, 175)
        Me.Panel1.TabIndex = 13
        '
        'rbEnvioCasa
        '
        Me.rbEnvioCasa.AutoSize = True
        Me.rbEnvioCasa.Location = New System.Drawing.Point(10, 11)
        Me.rbEnvioCasa.Name = "rbEnvioCasa"
        Me.rbEnvioCasa.Size = New System.Drawing.Size(180, 24)
        Me.rbEnvioCasa.TabIndex = 14
        Me.rbEnvioCasa.TabStop = True
        Me.rbEnvioCasa.Text = "Envío directo a su casa"
        Me.rbEnvioCasa.UseVisualStyleBackColor = True
        '
        'rbEnvioCC
        '
        Me.rbEnvioCC.AutoSize = True
        Me.rbEnvioCC.Location = New System.Drawing.Point(10, 41)
        Me.rbEnvioCC.Name = "rbEnvioCC"
        Me.rbEnvioCC.Size = New System.Drawing.Size(310, 24)
        Me.rbEnvioCC.TabIndex = 15
        Me.rbEnvioCC.TabStop = True
        Me.rbEnvioCC.Text = "Envío para recoger en un centro comercial"
        Me.rbEnvioCC.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbEnvioCasa)
        Me.Panel2.Controls.Add(Me.rbEnvioCC)
        Me.Panel2.Location = New System.Drawing.Point(230, 243)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(333, 84)
        Me.Panel2.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Productos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(230, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Tipo de Envío"
        '
        'btnCargarDatos
        '
        Me.btnCargarDatos.Location = New System.Drawing.Point(572, 94)
        Me.btnCargarDatos.Name = "btnCargarDatos"
        Me.btnCargarDatos.Size = New System.Drawing.Size(186, 35)
        Me.btnCargarDatos.TabIndex = 19
        Me.btnCargarDatos.Text = "Cargar Datos"
        Me.btnCargarDatos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCargarDatos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cjaNumeroTarjeta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cjaValorArticulo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cjaNombreCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMenu)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMenu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cjaNombreCliente As TextBox
    Friend WithEvents cjaValorArticulo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cjaNumeroTarjeta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rbRopa As RadioButton
    Friend WithEvents rbTablets As RadioButton
    Friend WithEvents rbCelulares As RadioButton
    Friend WithEvents rbVideoJuegos As RadioButton
    Friend WithEvents rbLaptop As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbEnvioCasa As RadioButton
    Friend WithEvents rbEnvioCC As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents btnCargarDatos As Button
End Class
