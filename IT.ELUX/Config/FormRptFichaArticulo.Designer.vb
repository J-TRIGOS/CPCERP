<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptFichaArticulo
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
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.txtnomlinea = New System.Windows.Forms.TextBox()
        Me.txtlinea = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnomsublinea = New System.Windows.Forms.TextBox()
        Me.txtsublinea = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnomart = New System.Windows.Forms.TextBox()
        Me.txtcodart = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Articulo:"
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(107, 121)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 4
        Me.btnreporte.Text = "Abrir Archivo"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(202, 121)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 5
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'txtnomlinea
        '
        Me.txtnomlinea.Location = New System.Drawing.Point(141, 29)
        Me.txtnomlinea.MaxLength = 4
        Me.txtnomlinea.Name = "txtnomlinea"
        Me.txtnomlinea.ReadOnly = True
        Me.txtnomlinea.Size = New System.Drawing.Size(229, 20)
        Me.txtnomlinea.TabIndex = 113
        '
        'txtlinea
        '
        Me.txtlinea.Location = New System.Drawing.Point(86, 29)
        Me.txtlinea.MaxLength = 4
        Me.txtlinea.Name = "txtlinea"
        Me.txtlinea.Size = New System.Drawing.Size(49, 20)
        Me.txtlinea.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Linea:"
        '
        'txtnomsublinea
        '
        Me.txtnomsublinea.Location = New System.Drawing.Point(141, 55)
        Me.txtnomsublinea.MaxLength = 4
        Me.txtnomsublinea.Name = "txtnomsublinea"
        Me.txtnomsublinea.ReadOnly = True
        Me.txtnomsublinea.Size = New System.Drawing.Size(229, 20)
        Me.txtnomsublinea.TabIndex = 110
        '
        'txtsublinea
        '
        Me.txtsublinea.Location = New System.Drawing.Point(86, 55)
        Me.txtsublinea.MaxLength = 4
        Me.txtsublinea.Name = "txtsublinea"
        Me.txtsublinea.Size = New System.Drawing.Size(49, 20)
        Me.txtsublinea.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Sub Linea:"
        '
        'txtnomart
        '
        Me.txtnomart.Location = New System.Drawing.Point(153, 84)
        Me.txtnomart.MaxLength = 4
        Me.txtnomart.Name = "txtnomart"
        Me.txtnomart.ReadOnly = True
        Me.txtnomart.Size = New System.Drawing.Size(217, 20)
        Me.txtnomart.TabIndex = 115
        '
        'txtcodart
        '
        Me.txtcodart.Location = New System.Drawing.Point(86, 84)
        Me.txtcodart.MaxLength = 8
        Me.txtcodart.Name = "txtcodart"
        Me.txtcodart.Size = New System.Drawing.Size(61, 20)
        Me.txtcodart.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(376, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 23)
        Me.Button1.TabIndex = 116
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(376, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 23)
        Me.Button2.TabIndex = 117
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(376, 26)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 23)
        Me.Button3.TabIndex = 118
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FormRptFichaArticulo
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 164)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtnomart)
        Me.Controls.Add(Me.txtcodart)
        Me.Controls.Add(Me.txtnomlinea)
        Me.Controls.Add(Me.txtlinea)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnomsublinea)
        Me.Controls.Add(Me.txtsublinea)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRptFichaArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptFichaArticulo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnreporte As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents txtnomlinea As TextBox
    Friend WithEvents txtlinea As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnomsublinea As TextBox
    Friend WithEvents txtsublinea As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnomart As TextBox
    Friend WithEvents txtcodart As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
