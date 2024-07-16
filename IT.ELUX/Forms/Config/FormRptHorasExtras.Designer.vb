<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRptHorasExtras
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
        Me.txtnomcco = New System.Windows.Forms.TextBox()
        Me.txtcco_cod = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.txtuserrep = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnomape = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtlinea = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnomlinea = New System.Windows.Forms.TextBox()
        Me.txtnro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbmes1 = New System.Windows.Forms.ComboBox()
        Me.cmbmes2 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbest = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.dtpfec_ini = New System.Windows.Forms.DateTimePicker()
        Me.txt_periodo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbc_costo = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.rdbdet = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbincon = New System.Windows.Forms.RadioButton()
        Me.rdbboleta = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbaño1 = New System.Windows.Forms.ComboBox()
        Me.cmbproc = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtcco_cod2 = New System.Windows.Forms.TextBox()
        Me.txtnro2 = New System.Windows.Forms.TextBox()
        Me.txtnomlinea2 = New System.Windows.Forms.TextBox()
        Me.txtnomcco2 = New System.Windows.Forms.TextBox()
        Me.txtdni2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtnomape2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtlinea2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpfecini2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpfecfin2 = New System.Windows.Forms.DateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmbprogramacion = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbtareo = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtpfecini3 = New System.Windows.Forms.DateTimePicker()
        Me.dtpfecfin3 = New System.Windows.Forms.DateTimePicker()
        Me.dgvtiemper = New System.Windows.Forms.DataGridView()
        Me.dgvinc = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvtiemper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvinc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnomcco
        '
        Me.txtnomcco.Location = New System.Drawing.Point(150, 64)
        Me.txtnomcco.MaxLength = 2
        Me.txtnomcco.Name = "txtnomcco"
        Me.txtnomcco.ReadOnly = True
        Me.txtnomcco.Size = New System.Drawing.Size(163, 20)
        Me.txtnomcco.TabIndex = 69
        '
        'txtcco_cod
        '
        Me.txtcco_cod.Location = New System.Drawing.Point(109, 64)
        Me.txtcco_cod.MaxLength = 3
        Me.txtcco_cod.Name = "txtcco_cod"
        Me.txtcco_cod.Size = New System.Drawing.Size(35, 20)
        Me.txtcco_cod.TabIndex = 1
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(319, 62)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(35, 23)
        Me.Button7.TabIndex = 65
        Me.Button7.Text = "..."
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Centro Costo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(225, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 23)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(143, 278)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 8
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(62, 278)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 7
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'txtuserrep
        '
        Me.txtuserrep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtuserrep.Location = New System.Drawing.Point(109, 112)
        Me.txtuserrep.Name = "txtuserrep"
        Me.txtuserrep.Size = New System.Drawing.Size(110, 20)
        Me.txtuserrep.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Usuario Reporte"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(319, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 23)
        Me.Button2.TabIndex = 72
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtdni
        '
        Me.txtdni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdni.Location = New System.Drawing.Point(109, 138)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(58, 20)
        Me.txtdni.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Persona"
        '
        'txtnomape
        '
        Me.txtnomape.Location = New System.Drawing.Point(173, 138)
        Me.txtnomape.MaxLength = 2
        Me.txtnomape.Name = "txtnomape"
        Me.txtnomape.ReadOnly = True
        Me.txtnomape.Size = New System.Drawing.Size(140, 20)
        Me.txtnomape.TabIndex = 73
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(319, 88)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 23)
        Me.Button3.TabIndex = 76
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtlinea
        '
        Me.txtlinea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlinea.Location = New System.Drawing.Point(109, 90)
        Me.txtlinea.Name = "txtlinea"
        Me.txtlinea.Size = New System.Drawing.Size(42, 20)
        Me.txtlinea.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Linea"
        '
        'txtnomlinea
        '
        Me.txtnomlinea.Location = New System.Drawing.Point(157, 90)
        Me.txtnomlinea.MaxLength = 2
        Me.txtnomlinea.Name = "txtnomlinea"
        Me.txtnomlinea.ReadOnly = True
        Me.txtnomlinea.Size = New System.Drawing.Size(156, 20)
        Me.txtnomlinea.TabIndex = 77
        '
        'txtnro
        '
        Me.txtnro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnro.Location = New System.Drawing.Point(109, 162)
        Me.txtnro.MaxLength = 7
        Me.txtnro.Name = "txtnro"
        Me.txtnro.Size = New System.Drawing.Size(101, 20)
        Me.txtnro.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Nro. Boleta"
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño.Location = New System.Drawing.Point(65, 5)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(121, 21)
        Me.cmbaño.TabIndex = 115
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Mes2 :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "Mes1 :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 119
        Me.Label7.Text = "Año :"
        '
        'cmbmes1
        '
        Me.cmbmes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes1.FormattingEnabled = True
        Me.cmbmes1.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes1.Location = New System.Drawing.Point(65, 33)
        Me.cmbmes1.Name = "cmbmes1"
        Me.cmbmes1.Size = New System.Drawing.Size(119, 21)
        Me.cmbmes1.TabIndex = 116
        '
        'cmbmes2
        '
        Me.cmbmes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes2.FormattingEnabled = True
        Me.cmbmes2.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes2.Location = New System.Drawing.Point(235, 33)
        Me.cmbmes2.Name = "cmbmes2"
        Me.cmbmes2.Size = New System.Drawing.Size(119, 21)
        Me.cmbmes2.TabIndex = 117
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "Estado"
        '
        'cmbest
        '
        Me.cmbest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbest.FormattingEnabled = True
        Me.cmbest.Items.AddRange(New Object() {"", "PROCESADO", "DESPAROBADO", "PENDIENTE", "ANULADO"})
        Me.cmbest.Location = New System.Drawing.Point(109, 194)
        Me.cmbest.Name = "cmbest"
        Me.cmbest.Size = New System.Drawing.Size(159, 21)
        Me.cmbest.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.dtpfec_ini)
        Me.Panel1.Controls.Add(Me.txt_periodo)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.cmbc_costo)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cmbest)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cmbaño)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtuserrep)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtnomape)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.txtcco_cod)
        Me.Panel1.Controls.Add(Me.txtdni)
        Me.Panel1.Controls.Add(Me.cmbmes1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtnomcco)
        Me.Panel1.Controls.Add(Me.cmbmes2)
        Me.Panel1.Controls.Add(Me.txtnro)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtnomlinea)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtlinea)
        Me.Panel1.Location = New System.Drawing.Point(12, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(374, 271)
        Me.Panel1.TabIndex = 122
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(215, 220)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(35, 23)
        Me.Button8.TabIndex = 139
        Me.Button8.Text = "..."
        Me.Button8.UseVisualStyleBackColor = True
        '
        'dtpfec_ini
        '
        Me.dtpfec_ini.Enabled = False
        Me.dtpfec_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ini.Location = New System.Drawing.Point(109, 247)
        Me.dtpfec_ini.Name = "dtpfec_ini"
        Me.dtpfec_ini.ShowCheckBox = True
        Me.dtpfec_ini.Size = New System.Drawing.Size(100, 20)
        Me.dtpfec_ini.TabIndex = 138
        '
        'txt_periodo
        '
        Me.txt_periodo.Location = New System.Drawing.Point(109, 222)
        Me.txt_periodo.Name = "txt_periodo"
        Me.txt_periodo.Size = New System.Drawing.Size(100, 20)
        Me.txt_periodo.TabIndex = 137
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 225)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 136
        Me.Label13.Text = "Periodo"
        '
        'cmbc_costo
        '
        Me.cmbc_costo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbc_costo.FormattingEnabled = True
        Me.cmbc_costo.Location = New System.Drawing.Point(154, 89)
        Me.cmbc_costo.Name = "cmbc_costo"
        Me.cmbc_costo.Size = New System.Drawing.Size(159, 21)
        Me.cmbc_costo.TabIndex = 123
        Me.cmbc_costo.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(357, 93)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 122
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'rdbdet
        '
        Me.rdbdet.AutoSize = True
        Me.rdbdet.Checked = True
        Me.rdbdet.Location = New System.Drawing.Point(13, 13)
        Me.rdbdet.Name = "rdbdet"
        Me.rdbdet.Size = New System.Drawing.Size(58, 17)
        Me.rdbdet.TabIndex = 123
        Me.rdbdet.TabStop = True
        Me.rdbdet.Text = "Detalle"
        Me.rdbdet.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbincon)
        Me.GroupBox1.Controls.Add(Me.rdbboleta)
        Me.GroupBox1.Controls.Add(Me.rdbdet)
        Me.GroupBox1.Location = New System.Drawing.Point(224, 248)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(143, 72)
        Me.GroupBox1.TabIndex = 124
        Me.GroupBox1.TabStop = False
        '
        'rdbincon
        '
        Me.rdbincon.AutoSize = True
        Me.rdbincon.Location = New System.Drawing.Point(13, 51)
        Me.rdbincon.Name = "rdbincon"
        Me.rdbincon.Size = New System.Drawing.Size(98, 17)
        Me.rdbincon.TabIndex = 125
        Me.rdbincon.Text = "Inconsistencias"
        Me.rdbincon.UseVisualStyleBackColor = True
        '
        'rdbboleta
        '
        Me.rdbboleta.AutoSize = True
        Me.rdbboleta.Location = New System.Drawing.Point(13, 32)
        Me.rdbboleta.Name = "rdbboleta"
        Me.rdbboleta.Size = New System.Drawing.Size(55, 17)
        Me.rdbboleta.TabIndex = 124
        Me.rdbboleta.Text = "Boleta"
        Me.rdbboleta.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.cmbaño1)
        Me.Panel2.Controls.Add(Me.cmbproc)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.txtcco_cod2)
        Me.Panel2.Controls.Add(Me.txtnro2)
        Me.Panel2.Controls.Add(Me.txtnomlinea2)
        Me.Panel2.Controls.Add(Me.txtnomcco2)
        Me.Panel2.Controls.Add(Me.txtdni2)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.txtnomape2)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtlinea2)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.dtpfecini2)
        Me.Panel2.Controls.Add(Me.dtpfecfin2)
        Me.Panel2.Location = New System.Drawing.Point(12, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(374, 250)
        Me.Panel2.TabIndex = 125
        Me.Panel2.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(209, 141)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 13)
        Me.Label18.TabIndex = 133
        Me.Label18.Text = "Año :"
        '
        'cmbaño1
        '
        Me.cmbaño1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño1.Enabled = False
        Me.cmbaño1.FormattingEnabled = True
        Me.cmbaño1.Items.AddRange(New Object() {"2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño1.Location = New System.Drawing.Point(247, 138)
        Me.cmbaño1.Name = "cmbaño1"
        Me.cmbaño1.Size = New System.Drawing.Size(66, 21)
        Me.cmbaño1.TabIndex = 132
        '
        'cmbproc
        '
        Me.cmbproc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbproc.FormattingEnabled = True
        Me.cmbproc.Items.AddRange(New Object() {"", "PROCESADO", "DESPAROBADO", "PENDIENTE", "ANULADO"})
        Me.cmbproc.Location = New System.Drawing.Point(106, 167)
        Me.cmbproc.Name = "cmbproc"
        Me.cmbproc.Size = New System.Drawing.Size(159, 21)
        Me.cmbproc.TabIndex = 130
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(18, 170)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 13)
        Me.Label17.TabIndex = 131
        Me.Label17.Text = "Est. Proceso"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(316, 113)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(35, 23)
        Me.Button6.TabIndex = 122
        Me.Button6.Text = "..."
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(18, 67)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 13)
        Me.Label16.TabIndex = 123
        Me.Label16.Text = "Centro Costo"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(316, 60)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(35, 23)
        Me.Button5.TabIndex = 124
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtcco_cod2
        '
        Me.txtcco_cod2.Location = New System.Drawing.Point(106, 62)
        Me.txtcco_cod2.MaxLength = 3
        Me.txtcco_cod2.Name = "txtcco_cod2"
        Me.txtcco_cod2.Size = New System.Drawing.Size(35, 20)
        Me.txtcco_cod2.TabIndex = 122
        '
        'txtnro2
        '
        Me.txtnro2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnro2.Location = New System.Drawing.Point(106, 140)
        Me.txtnro2.MaxLength = 7
        Me.txtnro2.Name = "txtnro2"
        Me.txtnro2.Size = New System.Drawing.Size(101, 20)
        Me.txtnro2.TabIndex = 128
        '
        'txtnomlinea2
        '
        Me.txtnomlinea2.Location = New System.Drawing.Point(170, 88)
        Me.txtnomlinea2.MaxLength = 2
        Me.txtnomlinea2.Name = "txtnomlinea2"
        Me.txtnomlinea2.ReadOnly = True
        Me.txtnomlinea2.Size = New System.Drawing.Size(140, 20)
        Me.txtnomlinea2.TabIndex = 127
        '
        'txtnomcco2
        '
        Me.txtnomcco2.Location = New System.Drawing.Point(147, 62)
        Me.txtnomcco2.MaxLength = 2
        Me.txtnomcco2.Name = "txtnomcco2"
        Me.txtnomcco2.ReadOnly = True
        Me.txtnomcco2.Size = New System.Drawing.Size(163, 20)
        Me.txtnomcco2.TabIndex = 125
        '
        'txtdni2
        '
        Me.txtdni2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdni2.Location = New System.Drawing.Point(106, 114)
        Me.txtdni2.Name = "txtdni2"
        Me.txtdni2.Size = New System.Drawing.Size(58, 20)
        Me.txtdni2.TabIndex = 74
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(18, 145)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 13)
        Me.Label15.TabIndex = 129
        Me.Label15.Text = "Nro. Boleta"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(316, 86)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 23)
        Me.Button4.TabIndex = 126
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtnomape2
        '
        Me.txtnomape2.Location = New System.Drawing.Point(170, 114)
        Me.txtnomape2.MaxLength = 2
        Me.txtnomape2.Name = "txtnomape2"
        Me.txtnomape2.ReadOnly = True
        Me.txtnomape2.Size = New System.Drawing.Size(140, 20)
        Me.txtnomape2.TabIndex = 76
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 93)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 125
        Me.Label14.Text = "Linea"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Persona"
        '
        'txtlinea2
        '
        Me.txtlinea2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlinea2.Location = New System.Drawing.Point(106, 88)
        Me.txtlinea2.Name = "txtlinea2"
        Me.txtlinea2.Size = New System.Drawing.Size(58, 20)
        Me.txtlinea2.TabIndex = 124
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Fecha Inicio"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "Fecha Fin"
        '
        'dtpfecini2
        '
        Me.dtpfecini2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecini2.Location = New System.Drawing.Point(106, 6)
        Me.dtpfecini2.Name = "dtpfecini2"
        Me.dtpfecini2.Size = New System.Drawing.Size(109, 20)
        Me.dtpfecini2.TabIndex = 79
        '
        'dtpfecfin2
        '
        Me.dtpfecfin2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecfin2.Location = New System.Drawing.Point(106, 36)
        Me.dtpfecfin2.Name = "dtpfecfin2"
        Me.dtpfecfin2.Size = New System.Drawing.Size(109, 20)
        Me.dtpfecfin2.TabIndex = 80
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmbprogramacion)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.cmbtareo)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.dtpfecini3)
        Me.Panel3.Controls.Add(Me.dtpfecfin3)
        Me.Panel3.Location = New System.Drawing.Point(12, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(374, 250)
        Me.Panel3.TabIndex = 126
        Me.Panel3.Visible = False
        '
        'cmbprogramacion
        '
        Me.cmbprogramacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbprogramacion.FormattingEnabled = True
        Me.cmbprogramacion.Items.AddRange(New Object() {"", "DIA", "NOCHE", "NO TIENE"})
        Me.cmbprogramacion.Location = New System.Drawing.Point(115, 95)
        Me.cmbprogramacion.Name = "cmbprogramacion"
        Me.cmbprogramacion.Size = New System.Drawing.Size(109, 21)
        Me.cmbprogramacion.TabIndex = 136
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(27, 99)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 13)
        Me.Label22.TabIndex = 135
        Me.Label22.Text = "Programacion"
        '
        'cmbtareo
        '
        Me.cmbtareo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtareo.FormattingEnabled = True
        Me.cmbtareo.Items.AddRange(New Object() {"", "SI", "NO"})
        Me.cmbtareo.Location = New System.Drawing.Point(115, 66)
        Me.cmbtareo.Name = "cmbtareo"
        Me.cmbtareo.Size = New System.Drawing.Size(109, 21)
        Me.cmbtareo.TabIndex = 134
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(27, 70)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(35, 13)
        Me.Label21.TabIndex = 85
        Me.Label21.Text = "Tareo"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(27, 11)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 13)
        Me.Label19.TabIndex = 81
        Me.Label19.Text = "Fecha Inicio"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(27, 35)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 13)
        Me.Label20.TabIndex = 82
        Me.Label20.Text = "Fecha Fin"
        '
        'dtpfecini3
        '
        Me.dtpfecini3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecini3.Location = New System.Drawing.Point(115, 5)
        Me.dtpfecini3.Name = "dtpfecini3"
        Me.dtpfecini3.Size = New System.Drawing.Size(109, 20)
        Me.dtpfecini3.TabIndex = 83
        '
        'dtpfecfin3
        '
        Me.dtpfecfin3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecfin3.Location = New System.Drawing.Point(115, 35)
        Me.dtpfecfin3.Name = "dtpfecfin3"
        Me.dtpfecfin3.Size = New System.Drawing.Size(109, 20)
        Me.dtpfecfin3.TabIndex = 84
        '
        'dgvtiemper
        '
        Me.dgvtiemper.AllowUserToAddRows = False
        Me.dgvtiemper.AllowUserToDeleteRows = False
        Me.dgvtiemper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtiemper.Location = New System.Drawing.Point(411, 7)
        Me.dgvtiemper.Name = "dgvtiemper"
        Me.dgvtiemper.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvtiemper.Size = New System.Drawing.Size(391, 221)
        Me.dgvtiemper.TabIndex = 127
        '
        'dgvinc
        '
        Me.dgvinc.AllowUserToAddRows = False
        Me.dgvinc.AllowUserToDeleteRows = False
        Me.dgvinc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvinc.Location = New System.Drawing.Point(411, 47)
        Me.dgvinc.Name = "dgvinc"
        Me.dgvinc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvinc.Size = New System.Drawing.Size(391, 221)
        Me.dgvinc.TabIndex = 128
        '
        'FormRptHorasExtras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 326)
        Me.Controls.Add(Me.dgvinc)
        Me.Controls.Add(Me.dgvtiemper)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRptHorasExtras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptHorasExtras"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvtiemper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvinc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtnomcco As TextBox
    Friend WithEvents txtcco_cod As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnreporte As Button
    Friend WithEvents txtuserrep As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents txtdni As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnomape As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents txtlinea As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnomlinea As TextBox
    Friend WithEvents txtnro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbaño As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbmes1 As ComboBox
    Friend WithEvents cmbmes2 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbest As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rdbdet As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbboleta As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtdni2 As TextBox
    Friend WithEvents txtnomape2 As TextBox
    Friend WithEvents txtnomlinea2 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents txtlinea2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents dtpfecini2 As DateTimePicker
    Friend WithEvents dtpfecfin2 As DateTimePicker
    Friend WithEvents txtnro2 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents txtcco_cod2 As TextBox
    Friend WithEvents txtnomcco2 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents cmbproc As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents cmbc_costo As ComboBox
    Friend WithEvents Button8 As Button
    Friend WithEvents dtpfec_ini As DateTimePicker
    Friend WithEvents txt_periodo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents cmbaño1 As ComboBox
    Friend WithEvents rdbincon As RadioButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cmbprogramacion As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cmbtareo As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents dtpfecini3 As DateTimePicker
    Friend WithEvents dtpfecfin3 As DateTimePicker
    Friend WithEvents dgvtiemper As DataGridView
    Friend WithEvents dgvinc As DataGridView
End Class
