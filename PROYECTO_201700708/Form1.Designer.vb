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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnRegistrarse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cjaUsuario = New System.Windows.Forms.TextBox()
        Me.cjaPassword = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(143, 171)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(94, 29)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnRegistrarse
        '
        Me.btnRegistrarse.Location = New System.Drawing.Point(273, 171)
        Me.btnRegistrarse.Name = "btnRegistrarse"
        Me.btnRegistrarse.Size = New System.Drawing.Size(94, 29)
        Me.btnRegistrarse.TabIndex = 1
        Me.btnRegistrarse.Text = "Salir"
        Me.btnRegistrarse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'cjaUsuario
        '
        Me.cjaUsuario.Location = New System.Drawing.Point(153, 34)
        Me.cjaUsuario.Name = "cjaUsuario"
        Me.cjaUsuario.Size = New System.Drawing.Size(261, 27)
        Me.cjaUsuario.TabIndex = 4
        '
        'cjaPassword
        '
        Me.cjaPassword.Location = New System.Drawing.Point(153, 86)
        Me.cjaPassword.Name = "cjaPassword"
        Me.cjaPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.cjaPassword.Size = New System.Drawing.Size(261, 27)
        Me.cjaPassword.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(321, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 40)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Conectar BD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 298)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cjaPassword)
        Me.Controls.Add(Me.cjaUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegistrarse)
        Me.Controls.Add(Me.btnLogin)
        Me.Name = "Form1"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegistrarse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cjaUsuario As TextBox
    Friend WithEvents cjaPassword As TextBox
    Friend WithEvents Button1 As Button
End Class
