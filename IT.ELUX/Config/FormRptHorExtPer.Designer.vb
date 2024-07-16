<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRptHorExtPer
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
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbmes1 = New System.Windows.Forms.ComboBox()
        Me.cmbmes2 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtc_costo2 = New System.Windows.Forms.TextBox()
        Me.txtc_costo = New System.Windows.Forms.TextBox()
        Me.cmbc_costo2 = New System.Windows.Forms.ComboBox()
        Me.cmbc_costo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.dgvt_doc = New System.Windows.Forms.DataGridView()
        Me.dtpfec_ini = New System.Windows.Forms.DateTimePicker()
        Me.txt_periodo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txt_periodo1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño.Location = New System.Drawing.Point(119, 41)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(121, 21)
        Me.cmbaño.TabIndex = 150
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(660, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 155
        Me.Label2.Text = "Mes2 :"
        Me.Label2.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(482, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 153
        Me.Label5.Text = "Mes1 :"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 154
        Me.Label4.Text = "Año :"
        '
        'cmbmes1
        '
        Me.cmbmes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes1.FormattingEnabled = True
        Me.cmbmes1.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes1.Location = New System.Drawing.Point(543, 41)
        Me.cmbmes1.Name = "cmbmes1"
        Me.cmbmes1.Size = New System.Drawing.Size(100, 21)
        Me.cmbmes1.TabIndex = 151
        Me.cmbmes1.Visible = False
        '
        'cmbmes2
        '
        Me.cmbmes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes2.FormattingEnabled = True
        Me.cmbmes2.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes2.Location = New System.Drawing.Point(705, 41)
        Me.cmbmes2.Name = "cmbmes2"
        Me.cmbmes2.Size = New System.Drawing.Size(128, 21)
        Me.cmbmes2.TabIndex = 152
        Me.cmbmes2.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(442, 97)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 23)
        Me.Button3.TabIndex = 161
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(442, 71)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 23)
        Me.Button4.TabIndex = 158
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtc_costo2
        '
        Me.txtc_costo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtc_costo2.Location = New System.Drawing.Point(119, 97)
        Me.txtc_costo2.MaxLength = 3
        Me.txtc_costo2.Name = "txtc_costo2"
        Me.txtc_costo2.Size = New System.Drawing.Size(40, 20)
        Me.txtc_costo2.TabIndex = 159
        Me.txtc_costo2.Visible = False
        '
        'txtc_costo
        '
        Me.txtc_costo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtc_costo.Location = New System.Drawing.Point(119, 71)
        Me.txtc_costo.MaxLength = 3
        Me.txtc_costo.Name = "txtc_costo"
        Me.txtc_costo.Size = New System.Drawing.Size(40, 20)
        Me.txtc_costo.TabIndex = 156
        '
        'cmbc_costo2
        '
        Me.cmbc_costo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbc_costo2.FormattingEnabled = True
        Me.cmbc_costo2.Location = New System.Drawing.Point(164, 97)
        Me.cmbc_costo2.Name = "cmbc_costo2"
        Me.cmbc_costo2.Size = New System.Drawing.Size(272, 21)
        Me.cmbc_costo2.TabIndex = 160
        Me.cmbc_costo2.Visible = False
        '
        'cmbc_costo
        '
        Me.cmbc_costo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbc_costo.FormattingEnabled = True
        Me.cmbc_costo.Location = New System.Drawing.Point(165, 70)
        Me.cmbc_costo.Name = "cmbc_costo"
        Me.cmbc_costo.Size = New System.Drawing.Size(271, 21)
        Me.cmbc_costo.TabIndex = 157
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 163
        Me.Label6.Text = "Centro Costo2 :"
        Me.Label6.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 162
        Me.Label1.Text = "Centro Costo1 :"
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(145, 123)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 164
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(239, 123)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 165
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'dgvt_doc
        '
        Me.dgvt_doc.AllowUserToAddRows = False
        Me.dgvt_doc.AllowUserToDeleteRows = False
        Me.dgvt_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc.Location = New System.Drawing.Point(480, 79)
        Me.dgvt_doc.Name = "dgvt_doc"
        Me.dgvt_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc.Size = New System.Drawing.Size(353, 105)
        Me.dgvt_doc.TabIndex = 166
        Me.dgvt_doc.Visible = False
        '
        'dtpfec_ini
        '
        Me.dtpfec_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ini.Location = New System.Drawing.Point(684, 96)
        Me.dtpfec_ini.Name = "dtpfec_ini"
        Me.dtpfec_ini.ShowCheckBox = True
        Me.dtpfec_ini.Size = New System.Drawing.Size(100, 20)
        Me.dtpfec_ini.TabIndex = 169
        '
        'txt_periodo
        '
        Me.txt_periodo.Location = New System.Drawing.Point(579, 96)
        Me.txt_periodo.Name = "txt_periodo"
        Me.txt_periodo.Size = New System.Drawing.Size(100, 20)
        Me.txt_periodo.TabIndex = 168
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(507, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 167
        Me.Label3.Text = "Periodo :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(685, 122)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowCheckBox = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 172
        '
        'txt_periodo1
        '
        Me.txt_periodo1.Location = New System.Drawing.Point(579, 122)
        Me.txt_periodo1.Name = "txt_periodo1"
        Me.txt_periodo1.Size = New System.Drawing.Size(100, 20)
        Me.txt_periodo1.TabIndex = 171
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(501, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 170
        Me.Label7.Text = "Periodo1 :"
        '
        'FormRptHorExtPer
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 182)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txt_periodo1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpfec_ini)
        Me.Controls.Add(Me.txt_periodo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvt_doc)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtc_costo2)
        Me.Controls.Add(Me.txtc_costo)
        Me.Controls.Add(Me.cmbc_costo2)
        Me.Controls.Add(Me.cmbc_costo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbaño)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbmes1)
        Me.Controls.Add(Me.cmbmes2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRptHorExtPer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptHorExtPer"
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbaño As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbmes1 As ComboBox
    Friend WithEvents cmbmes2 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txtc_costo2 As TextBox
    Friend WithEvents txtc_costo As TextBox
    Friend WithEvents cmbc_costo2 As ComboBox
    Friend WithEvents cmbc_costo As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnreporte As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents dgvt_doc As DataGridView
    Friend WithEvents dtpfec_ini As DateTimePicker
    Friend WithEvents txt_periodo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txt_periodo1 As TextBox
    Friend WithEvents Label7 As Label
End Class
