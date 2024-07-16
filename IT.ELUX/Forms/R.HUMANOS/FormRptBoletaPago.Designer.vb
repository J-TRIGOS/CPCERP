<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptBoletaPago
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
        Me.Cmbt_per2 = New System.Windows.Forms.ComboBox()
        Me.Cmbt_per1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkperiodo = New System.Windows.Forms.CheckBox()
        Me.dtpfec_ini = New System.Windows.Forms.DateTimePicker()
        Me.txt_periodo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.cmbt_pago = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtnomper2 = New System.Windows.Forms.TextBox()
        Me.txtnomper1 = New System.Windows.Forms.TextBox()
        Me.txtper2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtper1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpfec_fin = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cmbt_per2
        '
        Me.Cmbt_per2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbt_per2.FormattingEnabled = True
        Me.Cmbt_per2.Items.AddRange(New Object() {"", "OBREROS", "EMPLEADOS"})
        Me.Cmbt_per2.Location = New System.Drawing.Point(212, 79)
        Me.Cmbt_per2.Name = "Cmbt_per2"
        Me.Cmbt_per2.Size = New System.Drawing.Size(89, 21)
        Me.Cmbt_per2.TabIndex = 5
        '
        'Cmbt_per1
        '
        Me.Cmbt_per1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbt_per1.FormattingEnabled = True
        Me.Cmbt_per1.Items.AddRange(New Object() {"", "OBREROS", "EMPLEADOS"})
        Me.Cmbt_per1.Location = New System.Drawing.Point(116, 79)
        Me.Cmbt_per1.Name = "Cmbt_per1"
        Me.Cmbt_per1.Size = New System.Drawing.Size(89, 21)
        Me.Cmbt_per1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Tipo Personal"
        '
        'chkperiodo
        '
        Me.chkperiodo.AutoSize = True
        Me.chkperiodo.Location = New System.Drawing.Point(417, 50)
        Me.chkperiodo.Name = "chkperiodo"
        Me.chkperiodo.Size = New System.Drawing.Size(116, 17)
        Me.chkperiodo.TabIndex = 47
        Me.chkperiodo.Text = "Todos los Periodos"
        Me.chkperiodo.UseVisualStyleBackColor = True
        Me.chkperiodo.Visible = False
        '
        'dtpfec_ini
        '
        Me.dtpfec_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ini.Location = New System.Drawing.Point(163, 22)
        Me.dtpfec_ini.Name = "dtpfec_ini"
        Me.dtpfec_ini.ShowCheckBox = True
        Me.dtpfec_ini.Size = New System.Drawing.Size(100, 20)
        Me.dtpfec_ini.TabIndex = 46
        '
        'txt_periodo
        '
        Me.txt_periodo.Location = New System.Drawing.Point(116, 22)
        Me.txt_periodo.MaxLength = 4
        Me.txt_periodo.Name = "txt_periodo"
        Me.txt_periodo.Size = New System.Drawing.Size(41, 20)
        Me.txt_periodo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Periodo"
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(199, 177)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 42
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(292, 177)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(86, 36)
        Me.btnsalir.TabIndex = 43
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'cmbt_pago
        '
        Me.cmbt_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbt_pago.FormattingEnabled = True
        Me.cmbt_pago.Items.AddRange(New Object() {"", "MENSUAL", "GRATIFICACION"})
        Me.cmbt_pago.Location = New System.Drawing.Point(116, 48)
        Me.cmbt_pago.Name = "cmbt_pago"
        Me.cmbt_pago.Size = New System.Drawing.Size(185, 21)
        Me.cmbt_pago.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Tipo Planilla"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(501, 134)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 23)
        Me.Button2.TabIndex = 89
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(501, 108)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 23)
        Me.Button5.TabIndex = 88
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtnomper2
        '
        Me.txtnomper2.Location = New System.Drawing.Point(183, 137)
        Me.txtnomper2.Name = "txtnomper2"
        Me.txtnomper2.ReadOnly = True
        Me.txtnomper2.Size = New System.Drawing.Size(312, 20)
        Me.txtnomper2.TabIndex = 87
        '
        'txtnomper1
        '
        Me.txtnomper1.Location = New System.Drawing.Point(183, 110)
        Me.txtnomper1.Name = "txtnomper1"
        Me.txtnomper1.ReadOnly = True
        Me.txtnomper1.Size = New System.Drawing.Size(312, 20)
        Me.txtnomper1.TabIndex = 86
        '
        'txtper2
        '
        Me.txtper2.Location = New System.Drawing.Point(116, 137)
        Me.txtper2.Name = "txtper2"
        Me.txtper2.Size = New System.Drawing.Size(61, 20)
        Me.txtper2.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Personal 2"
        '
        'txtper1
        '
        Me.txtper1.Location = New System.Drawing.Point(116, 110)
        Me.txtper1.MaxLength = 8
        Me.txtper1.Name = "txtper1"
        Me.txtper1.Size = New System.Drawing.Size(61, 20)
        Me.txtper1.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Personal 1"
        '
        'dtpfec_fin
        '
        Me.dtpfec_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_fin.Location = New System.Drawing.Point(384, 22)
        Me.dtpfec_fin.Name = "dtpfec_fin"
        Me.dtpfec_fin.ShowCheckBox = True
        Me.dtpfec_fin.Size = New System.Drawing.Size(100, 20)
        Me.dtpfec_fin.TabIndex = 92
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(329, 22)
        Me.TextBox1.MaxLength = 4
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(49, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(282, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Periodo"
        '
        'FormRptBoletaPago
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 232)
        Me.Controls.Add(Me.dtpfec_fin)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtnomper2)
        Me.Controls.Add(Me.txtnomper1)
        Me.Controls.Add(Me.txtper2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtper1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Cmbt_per2)
        Me.Controls.Add(Me.Cmbt_per1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkperiodo)
        Me.Controls.Add(Me.dtpfec_ini)
        Me.Controls.Add(Me.txt_periodo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.cmbt_pago)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormRptBoletaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptBoletaPago"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cmbt_per2 As ComboBox
    Friend WithEvents Cmbt_per1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkperiodo As CheckBox
    Friend WithEvents dtpfec_ini As DateTimePicker
    Friend WithEvents txt_periodo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnreporte As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents cmbt_pago As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents txtnomper2 As TextBox
    Friend WithEvents txtnomper1 As TextBox
    Friend WithEvents txtper2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtper1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpfec_fin As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
End Class
