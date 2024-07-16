<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRPTVentasAnualCli
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
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtvend1 = New System.Windows.Forms.TextBox()
        Me.txtvend = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtcliente2 = New System.Windows.Forms.TextBox()
        Me.txtcliente1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpfec1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpfec2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(133, 108)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 7
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(227, 108)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 115
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(337, 82)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(35, 23)
        Me.Button6.TabIndex = 107
        Me.Button6.Text = "..."
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(171, 80)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(35, 23)
        Me.Button5.TabIndex = 106
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtvend1
        '
        Me.txtvend1.Location = New System.Drawing.Point(212, 82)
        Me.txtvend1.MaxLength = 8
        Me.txtvend1.Name = "txtvend1"
        Me.txtvend1.Size = New System.Drawing.Size(119, 20)
        Me.txtvend1.TabIndex = 6
        '
        'txtvend
        '
        Me.txtvend.Location = New System.Drawing.Point(66, 82)
        Me.txtvend.MaxLength = 8
        Me.txtvend.Name = "txtvend"
        Me.txtvend.Size = New System.Drawing.Size(99, 20)
        Me.txtvend.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Vendedor"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(414, 54)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 23)
        Me.Button4.TabIndex = 102
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(219, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 23)
        Me.Button1.TabIndex = 101
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtcliente2
        '
        Me.txtcliente2.Location = New System.Drawing.Point(261, 56)
        Me.txtcliente2.Name = "txtcliente2"
        Me.txtcliente2.Size = New System.Drawing.Size(147, 20)
        Me.txtcliente2.TabIndex = 4
        '
        'txtcliente1
        '
        Me.txtcliente1.Location = New System.Drawing.Point(66, 56)
        Me.txtcliente1.Name = "txtcliente1"
        Me.txtcliente1.Size = New System.Drawing.Size(147, 20)
        Me.txtcliente1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Fecha Inicial"
        '
        'dtpfec1
        '
        Me.dtpfec1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec1.Location = New System.Drawing.Point(78, 30)
        Me.dtpfec1.Name = "dtpfec1"
        Me.dtpfec1.Size = New System.Drawing.Size(110, 20)
        Me.dtpfec1.TabIndex = 1
        '
        'dtpfec2
        '
        Me.dtpfec2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec2.Location = New System.Drawing.Point(292, 30)
        Me.dtpfec2.Name = "dtpfec2"
        Me.dtpfec2.Size = New System.Drawing.Size(116, 20)
        Me.dtpfec2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Fecha Final"
        '
        'FormRPTVentasAnualCli
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 166)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpfec1)
        Me.Controls.Add(Me.dtpfec2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtvend1)
        Me.Controls.Add(Me.txtvend)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtcliente2)
        Me.Controls.Add(Me.txtcliente1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormRPTVentasAnualCli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRPTVentasAnualCli"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnreporte As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents txtvend1 As TextBox
    Friend WithEvents txtvend As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtcliente2 As TextBox
    Friend WithEvents txtcliente1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpfec1 As DateTimePicker
    Friend WithEvents dtpfec2 As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
