<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRptBoletaPagoNuevo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtnomper1 = New System.Windows.Forms.TextBox()
        Me.txtper1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cmbt_per1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpfec_ini = New System.Windows.Forms.DateTimePicker()
        Me.txt_periodo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Cmbt_pla = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbAnho = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(500, 99)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 23)
        Me.Button5.TabIndex = 122
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtnomper1
        '
        Me.txtnomper1.Location = New System.Drawing.Point(182, 101)
        Me.txtnomper1.Name = "txtnomper1"
        Me.txtnomper1.ReadOnly = True
        Me.txtnomper1.Size = New System.Drawing.Size(312, 20)
        Me.txtnomper1.TabIndex = 121
        '
        'txtper1
        '
        Me.txtper1.Location = New System.Drawing.Point(115, 101)
        Me.txtper1.MaxLength = 8
        Me.txtper1.Name = "txtper1"
        Me.txtper1.Size = New System.Drawing.Size(61, 20)
        Me.txtper1.TabIndex = 114
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 120
        Me.Label5.Text = "Personal 1"
        '
        'Cmbt_per1
        '
        Me.Cmbt_per1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbt_per1.FormattingEnabled = True
        Me.Cmbt_per1.Items.AddRange(New Object() {"EMPLEADOS", "OBREROS"})
        Me.Cmbt_per1.Location = New System.Drawing.Point(115, 74)
        Me.Cmbt_per1.Name = "Cmbt_per1"
        Me.Cmbt_per1.Size = New System.Drawing.Size(89, 21)
        Me.Cmbt_per1.TabIndex = 113
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Tipo Personal"
        '
        'dtpfec_ini
        '
        Me.dtpfec_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ini.Location = New System.Drawing.Point(162, 21)
        Me.dtpfec_ini.Name = "dtpfec_ini"
        Me.dtpfec_ini.ShowCheckBox = True
        Me.dtpfec_ini.Size = New System.Drawing.Size(100, 20)
        Me.dtpfec_ini.TabIndex = 118
        '
        'txt_periodo
        '
        Me.txt_periodo.Location = New System.Drawing.Point(115, 21)
        Me.txt_periodo.MaxLength = 4
        Me.txt_periodo.Name = "txt_periodo"
        Me.txt_periodo.Size = New System.Drawing.Size(41, 20)
        Me.txt_periodo.TabIndex = 112
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Periodo"
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(150, 142)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 115
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(256, 142)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(86, 36)
        Me.btnsalir.TabIndex = 116
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Cmbt_pla
        '
        Me.Cmbt_pla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbt_pla.FormattingEnabled = True
        Me.Cmbt_pla.Items.AddRange(New Object() {"MENSUAL", "GRATIFICACION", "UTILIDADES"})
        Me.Cmbt_pla.Location = New System.Drawing.Point(115, 47)
        Me.Cmbt_pla.Name = "Cmbt_pla"
        Me.Cmbt_pla.Size = New System.Drawing.Size(89, 21)
        Me.Cmbt_pla.TabIndex = 123
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Tipo Planilla"
        '
        'cmbAnho
        '
        Me.cmbAnho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnho.FormattingEnabled = True
        Me.cmbAnho.Items.AddRange(New Object() {"2019", "2020", "2021", "2022", "2023"})
        Me.cmbAnho.Location = New System.Drawing.Point(210, 47)
        Me.cmbAnho.Name = "cmbAnho"
        Me.cmbAnho.Size = New System.Drawing.Size(107, 21)
        Me.cmbAnho.TabIndex = 125
        Me.cmbAnho.Visible = False
        '
        'FormRptBoletaPagoNuevo
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 198)
        Me.Controls.Add(Me.cmbAnho)
        Me.Controls.Add(Me.Cmbt_pla)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtnomper1)
        Me.Controls.Add(Me.txtper1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Cmbt_per1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpfec_ini)
        Me.Controls.Add(Me.txt_periodo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btnsalir)
        Me.Name = "FormRptBoletaPagoNuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptBoletaPagoNuevo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents txtnomper1 As TextBox
    Friend WithEvents txtper1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Cmbt_per1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpfec_ini As DateTimePicker
    Friend WithEvents txt_periodo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnreporte As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents Cmbt_pla As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbAnho As ComboBox
End Class
