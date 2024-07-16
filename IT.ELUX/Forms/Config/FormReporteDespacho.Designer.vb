<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteDespacho
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
        Me.txtvend1 = New System.Windows.Forms.TextBox()
        Me.txtvend = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.dtpfec2 = New System.Windows.Forms.DateTimePicker()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.dtpfec1 = New System.Windows.Forms.DateTimePicker()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtformato1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtformato2 = New System.Windows.Forms.TextBox()
        Me.txtcliente2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtcliente1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtvend1
        '
        Me.txtvend1.Location = New System.Drawing.Point(289, 79)
        Me.txtvend1.Name = "txtvend1"
        Me.txtvend1.Size = New System.Drawing.Size(147, 20)
        Me.txtvend1.TabIndex = 6
        '
        'txtvend
        '
        Me.txtvend.Location = New System.Drawing.Point(94, 79)
        Me.txtvend.Name = "txtvend"
        Me.txtvend.Size = New System.Drawing.Size(147, 20)
        Me.txtvend.TabIndex = 5
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(247, 77)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(35, 23)
        Me.Button5.TabIndex = 35
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Vendedor"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(442, 79)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(35, 23)
        Me.Button6.TabIndex = 36
        Me.Button6.Text = "..."
        Me.Button6.UseVisualStyleBackColor = True
        '
        'dtpfec2
        '
        Me.dtpfec2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec2.Location = New System.Drawing.Point(289, 50)
        Me.dtpfec2.Name = "dtpfec2"
        Me.dtpfec2.Size = New System.Drawing.Size(147, 20)
        Me.dtpfec2.TabIndex = 4
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(166, 132)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 37
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'dtpfec1
        '
        Me.dtpfec1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec1.Location = New System.Drawing.Point(94, 50)
        Me.dtpfec1.Name = "dtpfec1"
        Me.dtpfec1.Size = New System.Drawing.Size(147, 20)
        Me.dtpfec1.TabIndex = 3
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(297, 132)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 38
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Formato"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(442, 21)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 23)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtformato1
        '
        Me.txtformato1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtformato1.Location = New System.Drawing.Point(94, 106)
        Me.txtformato1.Name = "txtformato1"
        Me.txtformato1.Size = New System.Drawing.Size(147, 20)
        Me.txtformato1.TabIndex = 39
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(247, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtformato2
        '
        Me.txtformato2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtformato2.Location = New System.Drawing.Point(289, 106)
        Me.txtformato2.Name = "txtformato2"
        Me.txtformato2.Size = New System.Drawing.Size(147, 20)
        Me.txtformato2.TabIndex = 40
        '
        'txtcliente2
        '
        Me.txtcliente2.Location = New System.Drawing.Point(289, 24)
        Me.txtcliente2.Name = "txtcliente2"
        Me.txtcliente2.Size = New System.Drawing.Size(147, 20)
        Me.txtcliente2.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(247, 104)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 23)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtcliente1
        '
        Me.txtcliente1.Location = New System.Drawing.Point(94, 24)
        Me.txtcliente1.Name = "txtcliente1"
        Me.txtcliente1.Size = New System.Drawing.Size(147, 20)
        Me.txtcliente1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(442, 106)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 23)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Cliente"
        '
        'FormReporteDespacho
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 189)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtcliente1)
        Me.Controls.Add(Me.txtvend1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtvend)
        Me.Controls.Add(Me.txtcliente2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtformato2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.txtformato1)
        Me.Controls.Add(Me.dtpfec2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpfec1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnsalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormReporteDespacho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormReporteDespacho"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtvend1 As TextBox
    Friend WithEvents txtvend As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents dtpfec2 As DateTimePicker
    Friend WithEvents btnreporte As Button
    Friend WithEvents dtpfec1 As DateTimePicker
    Friend WithEvents btnsalir As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents txtformato1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtformato2 As TextBox
    Friend WithEvents txtcliente2 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents txtcliente1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
End Class
