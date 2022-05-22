<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
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
        Me.btnReportes_Regresar = New System.Windows.Forms.Button()
        Me.btnReporte1 = New System.Windows.Forms.Button()
        Me.btnReporte2 = New System.Windows.Forms.Button()
        Me.btnReporte3 = New System.Windows.Forms.Button()
        Me.btnReporte4 = New System.Windows.Forms.Button()
        Me.btnReport5 = New System.Windows.Forms.Button()
        Me.btnReport6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReportes_Regresar
        '
        Me.btnReportes_Regresar.Location = New System.Drawing.Point(656, 406)
        Me.btnReportes_Regresar.Name = "btnReportes_Regresar"
        Me.btnReportes_Regresar.Size = New System.Drawing.Size(132, 32)
        Me.btnReportes_Regresar.TabIndex = 0
        Me.btnReportes_Regresar.Text = "Regresar"
        Me.btnReportes_Regresar.UseVisualStyleBackColor = True
        '
        'btnReporte1
        '
        Me.btnReporte1.Location = New System.Drawing.Point(38, 48)
        Me.btnReporte1.Name = "btnReporte1"
        Me.btnReporte1.Size = New System.Drawing.Size(213, 83)
        Me.btnReporte1.TabIndex = 1
        Me.btnReporte1.Text = "CANTIDAD VENTAS POR VENDEDOR"
        Me.btnReporte1.UseVisualStyleBackColor = True
        '
        'btnReporte2
        '
        Me.btnReporte2.Location = New System.Drawing.Point(289, 48)
        Me.btnReporte2.Name = "btnReporte2"
        Me.btnReporte2.Size = New System.Drawing.Size(213, 83)
        Me.btnReporte2.TabIndex = 2
        Me.btnReporte2.Text = "CANTIDAD DE VENTAS POR PRODUCTO"
        Me.btnReporte2.UseVisualStyleBackColor = True
        '
        'btnReporte3
        '
        Me.btnReporte3.Location = New System.Drawing.Point(541, 48)
        Me.btnReporte3.Name = "btnReporte3"
        Me.btnReporte3.Size = New System.Drawing.Size(213, 83)
        Me.btnReporte3.TabIndex = 3
        Me.btnReporte3.Text = "CANTIDAD DE VECES QUE VENDEDOR VENDE UN PRODUCTO"
        Me.btnReporte3.UseVisualStyleBackColor = True
        '
        'btnReporte4
        '
        Me.btnReporte4.Location = New System.Drawing.Point(38, 191)
        Me.btnReporte4.Name = "btnReporte4"
        Me.btnReporte4.Size = New System.Drawing.Size(213, 83)
        Me.btnReporte4.TabIndex = 4
        Me.btnReporte4.Text = "TOP 3 PRODUCTOS MAS VENDIDOS"
        Me.btnReporte4.UseVisualStyleBackColor = True
        '
        'btnReport5
        '
        Me.btnReport5.Location = New System.Drawing.Point(289, 191)
        Me.btnReport5.Name = "btnReport5"
        Me.btnReport5.Size = New System.Drawing.Size(213, 83)
        Me.btnReport5.TabIndex = 5
        Me.btnReport5.Text = "TOPO 3 VENDEDORES CON MAS VENTAS"
        Me.btnReport5.UseVisualStyleBackColor = True
        '
        'btnReport6
        '
        Me.btnReport6.Location = New System.Drawing.Point(541, 191)
        Me.btnReport6.Name = "btnReport6"
        Me.btnReport6.Size = New System.Drawing.Size(213, 83)
        Me.btnReport6.TabIndex = 6
        Me.btnReport6.Text = "TOP 3 VENDEDORES CON MENOS VENTAS"
        Me.btnReport6.UseVisualStyleBackColor = True
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnReport6)
        Me.Controls.Add(Me.btnReport5)
        Me.Controls.Add(Me.btnReporte4)
        Me.Controls.Add(Me.btnReporte3)
        Me.Controls.Add(Me.btnReporte2)
        Me.Controls.Add(Me.btnReporte1)
        Me.Controls.Add(Me.btnReportes_Regresar)
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReportes_Regresar As Button
    Friend WithEvents btnReporte1 As Button
    Friend WithEvents btnReporte2 As Button
    Friend WithEvents btnReporte3 As Button
    Friend WithEvents btnReporte4 As Button
    Friend WithEvents btnReport5 As Button
    Friend WithEvents btnReport6 As Button
End Class
