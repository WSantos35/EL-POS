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
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnReportes_Regresar)
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReportes_Regresar As Button
End Class
