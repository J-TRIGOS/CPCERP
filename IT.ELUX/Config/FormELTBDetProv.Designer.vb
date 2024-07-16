<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormELTBDetProv
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtserv = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtpago = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtt_ope = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnomserv = New System.Windows.Forms.TextBox()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.npdporc = New System.Windows.Forms.NumericUpDown()
        Me.txtnomope = New System.Windows.Forms.TextBox()
        CType(Me.npdporc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cuenta"
        '
        'txtcta
        '
        Me.txtcta.Location = New System.Drawing.Point(97, 28)
        Me.txtcta.Name = "txtcta"
        Me.txtcta.Size = New System.Drawing.Size(84, 20)
        Me.txtcta.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Servicio"
        '
        'txtserv
        '
        Me.txtserv.Location = New System.Drawing.Point(97, 54)
        Me.txtserv.MaxLength = 3
        Me.txtserv.Name = "txtserv"
        Me.txtserv.Size = New System.Drawing.Size(49, 20)
        Me.txtserv.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Porcentaje"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(97, 132)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(84, 20)
        Me.txttotal.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Total"
        '
        'txtpago
        '
        Me.txtpago.Location = New System.Drawing.Point(97, 158)
        Me.txtpago.Name = "txtpago"
        Me.txtpago.ReadOnly = True
        Me.txtpago.Size = New System.Drawing.Size(84, 20)
        Me.txtpago.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Pago"
        '
        'txtt_ope
        '
        Me.txtt_ope.Location = New System.Drawing.Point(97, 80)
        Me.txtt_ope.MaxLength = 2
        Me.txtt_ope.Name = "txtt_ope"
        Me.txtt_ope.Size = New System.Drawing.Size(49, 20)
        Me.txtt_ope.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Tip. Operacion"
        '
        'txtnomserv
        '
        Me.txtnomserv.Location = New System.Drawing.Point(152, 54)
        Me.txtnomserv.Name = "txtnomserv"
        Me.txtnomserv.ReadOnly = True
        Me.txtnomserv.Size = New System.Drawing.Size(171, 20)
        Me.txtnomserv.TabIndex = 3
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(84, 189)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificar.TabIndex = 8
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(193, 189)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 9
        Me.btnsalir.Text = "Cancelar"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'npdporc
        '
        Me.npdporc.DecimalPlaces = 3
        Me.npdporc.Location = New System.Drawing.Point(97, 106)
        Me.npdporc.Name = "npdporc"
        Me.npdporc.Size = New System.Drawing.Size(84, 20)
        Me.npdporc.TabIndex = 6
        '
        'txtnomope
        '
        Me.txtnomope.Location = New System.Drawing.Point(152, 80)
        Me.txtnomope.Name = "txtnomope"
        Me.txtnomope.ReadOnly = True
        Me.txtnomope.Size = New System.Drawing.Size(171, 20)
        Me.txtnomope.TabIndex = 5
        '
        'FormELTBDetProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 219)
        Me.Controls.Add(Me.txtnomope)
        Me.Controls.Add(Me.npdporc)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.txtnomserv)
        Me.Controls.Add(Me.txtt_ope)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpago)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtserv)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcta)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormELTBDetProv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormELTBDetProv"
        CType(Me.npdporc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcta As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtserv As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtpago As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtt_ope As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnomserv As TextBox
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents npdporc As NumericUpDown
    Friend WithEvents txtnomope As TextBox
End Class
