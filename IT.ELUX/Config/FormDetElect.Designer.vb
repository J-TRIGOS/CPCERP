<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetElect
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
        Me.btnregresar = New System.Windows.Forms.Button()
        Me.btngenerar = New System.Windows.Forms.Button()
        Me.txttexto = New System.Windows.Forms.TextBox()
        Me.btnvirtual = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnregresar
        '
        Me.btnregresar.Location = New System.Drawing.Point(551, 313)
        Me.btnregresar.Name = "btnregresar"
        Me.btnregresar.Size = New System.Drawing.Size(75, 23)
        Me.btnregresar.TabIndex = 5
        Me.btnregresar.Text = "Regresar"
        Me.btnregresar.UseVisualStyleBackColor = True
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(244, 313)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(91, 23)
        Me.btngenerar.TabIndex = 4
        Me.btngenerar.Text = "Texto Sunat"
        Me.btngenerar.UseVisualStyleBackColor = True
        Me.btngenerar.Visible = False
        '
        'txttexto
        '
        Me.txttexto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttexto.Location = New System.Drawing.Point(12, 12)
        Me.txttexto.MaxLength = 32767000
        Me.txttexto.Multiline = True
        Me.txttexto.Name = "txttexto"
        Me.txttexto.Size = New System.Drawing.Size(614, 295)
        Me.txttexto.TabIndex = 3
        '
        'btnvirtual
        '
        Me.btnvirtual.Location = New System.Drawing.Point(341, 313)
        Me.btnvirtual.Name = "btnvirtual"
        Me.btnvirtual.Size = New System.Drawing.Size(75, 23)
        Me.btnvirtual.TabIndex = 6
        Me.btnvirtual.Text = "Pago Virtual"
        Me.btnvirtual.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(431, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Generar Texto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormDetElect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 363)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnregresar)
        Me.Controls.Add(Me.btngenerar)
        Me.Controls.Add(Me.txttexto)
        Me.Controls.Add(Me.btnvirtual)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormDetElect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDetElect"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnregresar As Button
    Friend WithEvents btngenerar As Button
    Friend WithEvents txttexto As TextBox
    Friend WithEvents btnvirtual As Button
    Friend WithEvents Button1 As Button
End Class
