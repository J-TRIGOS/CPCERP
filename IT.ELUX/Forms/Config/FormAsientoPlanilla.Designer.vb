<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAsientoPlanilla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAsientoPlanilla))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttdoc = New System.Windows.Forms.TextBox()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.txtndoc = New System.Windows.Forms.TextBox()
        Me.npdtcmb = New System.Windows.Forms.NumericUpDown()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbvaca = New System.Windows.Forms.RadioButton()
        Me.rdbgra = New System.Windows.Forms.RadioButton()
        Me.rdbcts = New System.Windows.Forms.RadioButton()
        Me.rdbplan = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpfec_ini9 = New System.Windows.Forms.DateTimePicker()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.txtcontrato_prdo9 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.cmbt_pago = New System.Windows.Forms.ComboBox()
        Me.dtpfec_ini = New System.Windows.Forms.DateTimePicker()
        Me.txt_periodo = New System.Windows.Forms.TextBox()
        Me.cmbmes1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpfec_ini1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcontrato_prdo1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txttdoc1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbvaca1 = New System.Windows.Forms.RadioButton()
        Me.rdbgra1 = New System.Windows.Forms.RadioButton()
        Me.rdbcts1 = New System.Windows.Forms.RadioButton()
        Me.rdbplan1 = New System.Windows.Forms.RadioButton()
        Me.cmbaño1 = New System.Windows.Forms.ComboBox()
        Me.dtpfecha1 = New System.Windows.Forms.DateTimePicker()
        Me.txtndoc1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.npdtcmb1 = New System.Windows.Forms.NumericUpDown()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.npdtcmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsbForm.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.npdtcmb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Serie"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "T. Camb."
        '
        'txttdoc
        '
        Me.txttdoc.Location = New System.Drawing.Point(83, 17)
        Me.txttdoc.Name = "txttdoc"
        Me.txttdoc.Size = New System.Drawing.Size(61, 20)
        Me.txttdoc.TabIndex = 1
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño.Location = New System.Drawing.Point(83, 45)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(61, 21)
        Me.cmbaño.TabIndex = 2
        '
        'txtndoc
        '
        Me.txtndoc.Location = New System.Drawing.Point(83, 73)
        Me.txtndoc.Name = "txtndoc"
        Me.txtndoc.Size = New System.Drawing.Size(115, 20)
        Me.txtndoc.TabIndex = 3
        '
        'npdtcmb
        '
        Me.npdtcmb.DecimalPlaces = 3
        Me.npdtcmb.Location = New System.Drawing.Point(83, 160)
        Me.npdtcmb.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.npdtcmb.Name = "npdtcmb"
        Me.npdtcmb.Size = New System.Drawing.Size(115, 20)
        Me.npdtcmb.TabIndex = 5
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(452, 25)
        Me.tsbForm.TabIndex = 66
        Me.tsbForm.Text = "Grabar"
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(23, 22)
        Me.tsbSalir.Tag = "exit"
        Me.tsbSalir.Text = "Salir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Fecha"
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(83, 100)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(103, 20)
        Me.dtpfecha.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbvaca)
        Me.GroupBox1.Controls.Add(Me.rdbgra)
        Me.GroupBox1.Controls.Add(Me.rdbcts)
        Me.GroupBox1.Controls.Add(Me.rdbplan)
        Me.GroupBox1.Location = New System.Drawing.Point(204, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(82, 110)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        '
        'rdbvaca
        '
        Me.rdbvaca.AutoSize = True
        Me.rdbvaca.Location = New System.Drawing.Point(6, 82)
        Me.rdbvaca.Name = "rdbvaca"
        Me.rdbvaca.Size = New System.Drawing.Size(53, 17)
        Me.rdbvaca.TabIndex = 3
        Me.rdbvaca.TabStop = True
        Me.rdbvaca.Text = "Vaca."
        Me.rdbvaca.UseVisualStyleBackColor = True
        '
        'rdbgra
        '
        Me.rdbgra.AutoSize = True
        Me.rdbgra.Location = New System.Drawing.Point(6, 59)
        Me.rdbgra.Name = "rdbgra"
        Me.rdbgra.Size = New System.Drawing.Size(45, 17)
        Me.rdbgra.TabIndex = 2
        Me.rdbgra.TabStop = True
        Me.rdbgra.Text = "Gra."
        Me.rdbgra.UseVisualStyleBackColor = True
        '
        'rdbcts
        '
        Me.rdbcts.AutoSize = True
        Me.rdbcts.Location = New System.Drawing.Point(6, 36)
        Me.rdbcts.Name = "rdbcts"
        Me.rdbcts.Size = New System.Drawing.Size(49, 17)
        Me.rdbcts.TabIndex = 1
        Me.rdbcts.TabStop = True
        Me.rdbcts.Text = "CTS."
        Me.rdbcts.UseVisualStyleBackColor = True
        '
        'rdbplan
        '
        Me.rdbplan.AutoSize = True
        Me.rdbplan.Checked = True
        Me.rdbplan.Location = New System.Drawing.Point(6, 17)
        Me.rdbplan.Name = "rdbplan"
        Me.rdbplan.Size = New System.Drawing.Size(49, 17)
        Me.rdbplan.TabIndex = 0
        Me.rdbplan.TabStop = True
        Me.rdbplan.Text = "Plan."
        Me.rdbplan.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Periodo"
        '
        'dtpfec_ini9
        '
        Me.dtpfec_ini9.Checked = False
        Me.dtpfec_ini9.Enabled = False
        Me.dtpfec_ini9.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ini9.Location = New System.Drawing.Point(188, 130)
        Me.dtpfec_ini9.Name = "dtpfec_ini9"
        Me.dtpfec_ini9.ShowCheckBox = True
        Me.dtpfec_ini9.Size = New System.Drawing.Size(98, 20)
        Me.dtpfec_ini9.TabIndex = 187
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(149, 128)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(32, 23)
        Me.Button19.TabIndex = 186
        Me.Button19.Text = "..."
        Me.Button19.UseVisualStyleBackColor = True
        '
        'txtcontrato_prdo9
        '
        Me.txtcontrato_prdo9.Location = New System.Drawing.Point(83, 130)
        Me.txtcontrato_prdo9.Name = "txtcontrato_prdo9"
        Me.txtcontrato_prdo9.Size = New System.Drawing.Size(61, 20)
        Me.txtcontrato_prdo9.TabIndex = 185
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(11, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(427, 231)
        Me.TabControl1.TabIndex = 188
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button6)
        Me.TabPage3.Controls.Add(Me.btnreporte)
        Me.TabPage3.Controls.Add(Me.btnsalir)
        Me.TabPage3.Controls.Add(Me.cmbt_pago)
        Me.TabPage3.Controls.Add(Me.dtpfec_ini)
        Me.TabPage3.Controls.Add(Me.txt_periodo)
        Me.TabPage3.Controls.Add(Me.cmbmes1)
        Me.TabPage3.Controls.Add(Me.ComboBox1)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(419, 205)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Generar Asiento"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(88, 158)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 164
        Me.btnreporte.Text = "Generar"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(250, 158)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(86, 36)
        Me.btnsalir.TabIndex = 165
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'cmbt_pago
        '
        Me.cmbt_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbt_pago.FormattingEnabled = True
        Me.cmbt_pago.Items.AddRange(New Object() {"MENSUAL", "GRATIFICACION"})
        Me.cmbt_pago.Location = New System.Drawing.Point(182, 116)
        Me.cmbt_pago.Name = "cmbt_pago"
        Me.cmbt_pago.Size = New System.Drawing.Size(114, 21)
        Me.cmbt_pago.TabIndex = 163
        '
        'dtpfec_ini
        '
        Me.dtpfec_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ini.Location = New System.Drawing.Point(250, 80)
        Me.dtpfec_ini.Name = "dtpfec_ini"
        Me.dtpfec_ini.ShowCheckBox = True
        Me.dtpfec_ini.Size = New System.Drawing.Size(100, 20)
        Me.dtpfec_ini.TabIndex = 162
        '
        'txt_periodo
        '
        Me.txt_periodo.Location = New System.Drawing.Point(182, 80)
        Me.txt_periodo.Name = "txt_periodo"
        Me.txt_periodo.Size = New System.Drawing.Size(61, 20)
        Me.txt_periodo.TabIndex = 161
        '
        'cmbmes1
        '
        Me.cmbmes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes1.FormattingEnabled = True
        Me.cmbmes1.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes1.Location = New System.Drawing.Point(182, 44)
        Me.cmbmes1.Name = "cmbmes1"
        Me.cmbmes1.Size = New System.Drawing.Size(92, 21)
        Me.cmbmes1.TabIndex = 160
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.ComboBox1.Location = New System.Drawing.Point(182, 11)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox1.TabIndex = 159
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(69, 119)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 158
        Me.Label13.Text = "Tipo Pago"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(69, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 13)
        Me.Label14.TabIndex = 157
        Me.Label14.Text = "Ingrese Periodo"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(69, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 156
        Me.Label15.Text = "Ingrese Mes"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(69, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 13)
        Me.Label16.TabIndex = 155
        Me.Label16.Text = "Ingrese Año"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.dtpfec_ini1)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtcontrato_prdo1)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txttdoc1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.cmbaño1)
        Me.TabPage1.Controls.Add(Me.dtpfecha1)
        Me.TabPage1.Controls.Add(Me.txtndoc1)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.npdtcmb1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(419, 205)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Nuevo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(325, 50)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 206
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(325, 21)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 205
        Me.Button4.Text = "Guardar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 191
        Me.Label7.Text = "Tipo"
        '
        'dtpfec_ini1
        '
        Me.dtpfec_ini1.Checked = False
        Me.dtpfec_ini1.Enabled = False
        Me.dtpfec_ini1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ini1.Location = New System.Drawing.Point(188, 130)
        Me.dtpfec_ini1.Name = "dtpfec_ini1"
        Me.dtpfec_ini1.ShowCheckBox = True
        Me.dtpfec_ini1.Size = New System.Drawing.Size(98, 20)
        Me.dtpfec_ini1.TabIndex = 204
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 190
        Me.Label8.Text = "Numero"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(149, 128)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 23)
        Me.Button5.TabIndex = 203
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 194
        Me.Label9.Text = "Serie"
        '
        'txtcontrato_prdo1
        '
        Me.txtcontrato_prdo1.Location = New System.Drawing.Point(83, 130)
        Me.txtcontrato_prdo1.Name = "txtcontrato_prdo1"
        Me.txtcontrato_prdo1.Size = New System.Drawing.Size(61, 20)
        Me.txtcontrato_prdo1.TabIndex = 202
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 195
        Me.Label10.Text = "T. Camb."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 201
        Me.Label11.Text = "Periodo"
        '
        'txttdoc1
        '
        Me.txttdoc1.Location = New System.Drawing.Point(83, 17)
        Me.txttdoc1.Name = "txttdoc1"
        Me.txttdoc1.Size = New System.Drawing.Size(61, 20)
        Me.txttdoc1.TabIndex = 192
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbvaca1)
        Me.GroupBox2.Controls.Add(Me.rdbgra1)
        Me.GroupBox2.Controls.Add(Me.rdbcts1)
        Me.GroupBox2.Controls.Add(Me.rdbplan1)
        Me.GroupBox2.Location = New System.Drawing.Point(204, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(82, 110)
        Me.GroupBox2.TabIndex = 200
        Me.GroupBox2.TabStop = False
        '
        'rdbvaca1
        '
        Me.rdbvaca1.AutoSize = True
        Me.rdbvaca1.Location = New System.Drawing.Point(6, 82)
        Me.rdbvaca1.Name = "rdbvaca1"
        Me.rdbvaca1.Size = New System.Drawing.Size(53, 17)
        Me.rdbvaca1.TabIndex = 3
        Me.rdbvaca1.TabStop = True
        Me.rdbvaca1.Text = "Vaca."
        Me.rdbvaca1.UseVisualStyleBackColor = True
        '
        'rdbgra1
        '
        Me.rdbgra1.AutoSize = True
        Me.rdbgra1.Location = New System.Drawing.Point(6, 59)
        Me.rdbgra1.Name = "rdbgra1"
        Me.rdbgra1.Size = New System.Drawing.Size(45, 17)
        Me.rdbgra1.TabIndex = 2
        Me.rdbgra1.TabStop = True
        Me.rdbgra1.Text = "Gra."
        Me.rdbgra1.UseVisualStyleBackColor = True
        '
        'rdbcts1
        '
        Me.rdbcts1.AutoSize = True
        Me.rdbcts1.Location = New System.Drawing.Point(6, 36)
        Me.rdbcts1.Name = "rdbcts1"
        Me.rdbcts1.Size = New System.Drawing.Size(49, 17)
        Me.rdbcts1.TabIndex = 1
        Me.rdbcts1.TabStop = True
        Me.rdbcts1.Text = "CTS."
        Me.rdbcts1.UseVisualStyleBackColor = True
        '
        'rdbplan1
        '
        Me.rdbplan1.AutoSize = True
        Me.rdbplan1.Checked = True
        Me.rdbplan1.Location = New System.Drawing.Point(6, 17)
        Me.rdbplan1.Name = "rdbplan1"
        Me.rdbplan1.Size = New System.Drawing.Size(49, 17)
        Me.rdbplan1.TabIndex = 0
        Me.rdbplan1.TabStop = True
        Me.rdbplan1.Text = "Plan."
        Me.rdbplan1.UseVisualStyleBackColor = True
        '
        'cmbaño1
        '
        Me.cmbaño1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño1.FormattingEnabled = True
        Me.cmbaño1.Items.AddRange(New Object() {"2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño1.Location = New System.Drawing.Point(83, 45)
        Me.cmbaño1.Name = "cmbaño1"
        Me.cmbaño1.Size = New System.Drawing.Size(61, 21)
        Me.cmbaño1.TabIndex = 193
        '
        'dtpfecha1
        '
        Me.dtpfecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha1.Location = New System.Drawing.Point(83, 100)
        Me.dtpfecha1.Name = "dtpfecha1"
        Me.dtpfecha1.Size = New System.Drawing.Size(103, 20)
        Me.dtpfecha1.TabIndex = 197
        '
        'txtndoc1
        '
        Me.txtndoc1.Location = New System.Drawing.Point(83, 73)
        Me.txtndoc1.Name = "txtndoc1"
        Me.txtndoc1.Size = New System.Drawing.Size(115, 20)
        Me.txtndoc1.TabIndex = 196
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 199
        Me.Label12.Text = "Fecha"
        '
        'npdtcmb1
        '
        Me.npdtcmb1.DecimalPlaces = 3
        Me.npdtcmb1.Location = New System.Drawing.Point(83, 160)
        Me.npdtcmb1.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.npdtcmb1.Name = "npdtcmb1"
        Me.npdtcmb1.Size = New System.Drawing.Size(115, 20)
        Me.npdtcmb1.TabIndex = 198
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.dtpfec_ini9)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Button19)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtcontrato_prdo9)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txttdoc)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.cmbaño)
        Me.TabPage2.Controls.Add(Me.dtpfecha)
        Me.TabPage2.Controls.Add(Me.txtndoc)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.npdtcmb)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(419, 205)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Antiguo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(325, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 189
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(325, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 188
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(169, 158)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 36)
        Me.Button6.TabIndex = 166
        Me.Button6.Text = "Imprimir"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'FormAsientoPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 267)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.tsbForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormAsientoPlanilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAsientoPlanilla"
        CType(Me.npdtcmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.npdtcmb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txttdoc As TextBox
    Friend WithEvents cmbaño As ComboBox
    Friend WithEvents txtndoc As TextBox
    Friend WithEvents npdtcmb As NumericUpDown
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbvaca As RadioButton
    Friend WithEvents rdbgra As RadioButton
    Friend WithEvents rdbcts As RadioButton
    Friend WithEvents rdbplan As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpfec_ini9 As DateTimePicker
    Friend WithEvents Button19 As Button
    Friend WithEvents txtcontrato_prdo9 As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpfec_ini1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtcontrato_prdo1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txttdoc1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdbvaca1 As RadioButton
    Friend WithEvents rdbgra1 As RadioButton
    Friend WithEvents rdbcts1 As RadioButton
    Friend WithEvents rdbplan1 As RadioButton
    Friend WithEvents cmbaño1 As ComboBox
    Friend WithEvents dtpfecha1 As DateTimePicker
    Friend WithEvents txtndoc1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents npdtcmb1 As NumericUpDown
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnreporte As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents cmbt_pago As ComboBox
    Friend WithEvents dtpfec_ini As DateTimePicker
    Friend WithEvents txt_periodo As TextBox
    Friend WithEvents cmbmes1 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Button6 As Button
End Class
