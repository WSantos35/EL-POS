﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroProducto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cjaNombreProducto = New System.Windows.Forms.TextBox()
        Me.cjaPrecioProducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cjaExistenciasProducto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cjaDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnProducto_Registrar = New System.Windows.Forms.Button()
        Me.btnProducto_Regresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Producto"
        '
        'cjaNombreProducto
        '
        Me.cjaNombreProducto.Location = New System.Drawing.Point(275, 73)
        Me.cjaNombreProducto.Name = "cjaNombreProducto"
        Me.cjaNombreProducto.Size = New System.Drawing.Size(218, 27)
        Me.cjaNombreProducto.TabIndex = 1
        '
        'cjaPrecioProducto
        '
        Me.cjaPrecioProducto.Location = New System.Drawing.Point(275, 126)
        Me.cjaPrecioProducto.Name = "cjaPrecioProducto"
        Me.cjaPrecioProducto.Size = New System.Drawing.Size(218, 27)
        Me.cjaPrecioProducto.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Precio"
        '
        'cjaExistenciasProducto
        '
        Me.cjaExistenciasProducto.Location = New System.Drawing.Point(275, 177)
        Me.cjaExistenciasProducto.Name = "cjaExistenciasProducto"
        Me.cjaExistenciasProducto.Size = New System.Drawing.Size(218, 27)
        Me.cjaExistenciasProducto.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(106, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Existencias"
        '
        'cjaDescripcionProducto
        '
        Me.cjaDescripcionProducto.Location = New System.Drawing.Point(275, 226)
        Me.cjaDescripcionProducto.Multiline = True
        Me.cjaDescripcionProducto.Name = "cjaDescripcionProducto"
        Me.cjaDescripcionProducto.Size = New System.Drawing.Size(218, 141)
        Me.cjaDescripcionProducto.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(106, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Descripción"
        '
        'btnProducto_Registrar
        '
        Me.btnProducto_Registrar.Location = New System.Drawing.Point(181, 418)
        Me.btnProducto_Registrar.Name = "btnProducto_Registrar"
        Me.btnProducto_Registrar.Size = New System.Drawing.Size(94, 29)
        Me.btnProducto_Registrar.TabIndex = 8
        Me.btnProducto_Registrar.Text = "Registrar"
        Me.btnProducto_Registrar.UseVisualStyleBackColor = True
        '
        'btnProducto_Regresar
        '
        Me.btnProducto_Regresar.Location = New System.Drawing.Point(348, 418)
        Me.btnProducto_Regresar.Name = "btnProducto_Regresar"
        Me.btnProducto_Regresar.Size = New System.Drawing.Size(94, 29)
        Me.btnProducto_Regresar.TabIndex = 9
        Me.btnProducto_Regresar.Text = "Regresar"
        Me.btnProducto_Regresar.UseVisualStyleBackColor = True
        '
        'RegistroProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 509)
        Me.Controls.Add(Me.btnProducto_Regresar)
        Me.Controls.Add(Me.btnProducto_Registrar)
        Me.Controls.Add(Me.cjaDescripcionProducto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cjaExistenciasProducto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cjaPrecioProducto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cjaNombreProducto)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegistroProducto"
        Me.Text = "RegistroProducto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cjaNombreProducto As TextBox
    Friend WithEvents cjaPrecioProducto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cjaExistenciasProducto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cjaDescripcionProducto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnProducto_Registrar As Button
    Friend WithEvents btnProducto_Regresar As Button
End Class