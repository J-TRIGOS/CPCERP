<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSUBSIDIOMONTOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSUBSIDIOMONTOS))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtper1 = New System.Windows.Forms.TextBox()
        Me.txtnomper1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.npddif_ajuste_cts = New System.Windows.Forms.NumericUpDown()
        Me.npdprov_acum_cts = New System.Windows.Forms.NumericUpDown()
        Me.npdmonto_cts = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpfec_ini = New System.Windows.Forms.DateTimePicker()
        Me.txt_periodo = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.npddif_ajuste_vaca = New System.Windows.Forms.NumericUpDown()
        Me.npdprov_acum_vaca = New System.Windows.Forms.NumericUpDown()
        Me.npdvacaciones = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.npddif_ajuste_grati = New System.Windows.Forms.NumericUpDown()
        Me.ndpprov_acum_grati = New System.Windows.Forms.NumericUpDown()
        Me.npdgrati = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.drpfecini = New System.Windows.Forms.DateTimePicker()
        Me.dtpfecfin = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.npdhextras = New System.Windows.Forms.NumericUpDown()
        Me.npdcomision = New System.Windows.Forms.NumericUpDown()
        Me.npdotros = New System.Windows.Forms.NumericUpDown()
        Me.npdsubsidio = New System.Windows.Forms.NumericUpDown()
        Me.npddscto_quinta = New System.Windows.Forms.NumericUpDown()
        Me.npdotros_dsctos = New System.Windows.Forms.NumericUpDown()
        Me.npdmonto_prest = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1.SuspendLayout()
        CType(Me.npddif_ajuste_cts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdprov_acum_cts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdmonto_cts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.npddif_ajuste_vaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdprov_acum_vaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdvacaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.npddif_ajuste_grati, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndpprov_acum_grati, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdgrati, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsbForm.SuspendLayout()
        CType(Me.npdhextras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdcomision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdotros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdsubsidio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npddscto_quinta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdotros_dsctos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdmonto_prest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Personal:"
        '
        'txtper1
        '
        Me.txtper1.Location = New System.Drawing.Point(73, 44)
        Me.txtper1.MaxLength = 8
        Me.txtper1.Name = "txtper1"
        Me.txtper1.Size = New System.Drawing.Size(77, 20)
        Me.txtper1.TabIndex = 1
        '
        'txtnomper1
        '
        Me.txtnomper1.Location = New System.Drawing.Point(156, 44)
        Me.txtnomper1.Name = "txtnomper1"
        Me.txtnomper1.ReadOnly = True
        Me.txtnomper1.Size = New System.Drawing.Size(304, 20)
        Me.txtnomper1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pagado:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.npddif_ajuste_cts)
        Me.GroupBox1.Controls.Add(Me.npdprov_acum_cts)
        Me.GroupBox1.Controls.Add(Me.npdmonto_cts)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 113)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Provision CTS"
        '
        'npddif_ajuste_cts
        '
        Me.npddif_ajuste_cts.DecimalPlaces = 2
        Me.npddif_ajuste_cts.Location = New System.Drawing.Point(75, 80)
        Me.npddif_ajuste_cts.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npddif_ajuste_cts.Name = "npddif_ajuste_cts"
        Me.npddif_ajuste_cts.Size = New System.Drawing.Size(120, 20)
        Me.npddif_ajuste_cts.TabIndex = 9
        '
        'npdprov_acum_cts
        '
        Me.npdprov_acum_cts.DecimalPlaces = 2
        Me.npdprov_acum_cts.Location = New System.Drawing.Point(75, 54)
        Me.npdprov_acum_cts.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npdprov_acum_cts.Name = "npdprov_acum_cts"
        Me.npdprov_acum_cts.Size = New System.Drawing.Size(120, 20)
        Me.npdprov_acum_cts.TabIndex = 8
        '
        'npdmonto_cts
        '
        Me.npdmonto_cts.DecimalPlaces = 2
        Me.npdmonto_cts.Location = New System.Drawing.Point(75, 28)
        Me.npdmonto_cts.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npdmonto_cts.Name = "npdmonto_cts"
        Me.npdmonto_cts.Size = New System.Drawing.Size(120, 20)
        Me.npdmonto_cts.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Ajuste:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Acumulado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Periodo:"
        '
        'dtpfec_ini
        '
        Me.dtpfec_ini.Enabled = False
        Me.dtpfec_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ini.Location = New System.Drawing.Point(120, 85)
        Me.dtpfec_ini.Name = "dtpfec_ini"
        Me.dtpfec_ini.ShowCheckBox = True
        Me.dtpfec_ini.Size = New System.Drawing.Size(100, 20)
        Me.dtpfec_ini.TabIndex = 48
        '
        'txt_periodo
        '
        Me.txt_periodo.Location = New System.Drawing.Point(73, 85)
        Me.txt_periodo.MaxLength = 4
        Me.txt_periodo.Name = "txt_periodo"
        Me.txt_periodo.Size = New System.Drawing.Size(41, 20)
        Me.txt_periodo.TabIndex = 3
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(466, 42)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 49
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.npddif_ajuste_vaca)
        Me.GroupBox2.Controls.Add(Me.npdprov_acum_vaca)
        Me.GroupBox2.Controls.Add(Me.npdvacaciones)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(237, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(218, 113)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Provision Vaca"
        '
        'npddif_ajuste_vaca
        '
        Me.npddif_ajuste_vaca.DecimalPlaces = 2
        Me.npddif_ajuste_vaca.Location = New System.Drawing.Point(75, 80)
        Me.npddif_ajuste_vaca.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npddif_ajuste_vaca.Name = "npddif_ajuste_vaca"
        Me.npddif_ajuste_vaca.Size = New System.Drawing.Size(120, 20)
        Me.npddif_ajuste_vaca.TabIndex = 13
        '
        'npdprov_acum_vaca
        '
        Me.npdprov_acum_vaca.DecimalPlaces = 2
        Me.npdprov_acum_vaca.Location = New System.Drawing.Point(75, 54)
        Me.npdprov_acum_vaca.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npdprov_acum_vaca.Name = "npdprov_acum_vaca"
        Me.npdprov_acum_vaca.Size = New System.Drawing.Size(120, 20)
        Me.npdprov_acum_vaca.TabIndex = 12
        '
        'npdvacaciones
        '
        Me.npdvacaciones.DecimalPlaces = 2
        Me.npdvacaciones.Location = New System.Drawing.Point(75, 28)
        Me.npdvacaciones.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npdvacaciones.Name = "npdvacaciones"
        Me.npdvacaciones.Size = New System.Drawing.Size(120, 20)
        Me.npdvacaciones.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Ajuste:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Acumulado:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Pagado:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.npddif_ajuste_grati)
        Me.GroupBox3.Controls.Add(Me.ndpprov_acum_grati)
        Me.GroupBox3.Controls.Add(Me.npdgrati)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(461, 116)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(218, 113)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Provision Grati"
        '
        'npddif_ajuste_grati
        '
        Me.npddif_ajuste_grati.DecimalPlaces = 2
        Me.npddif_ajuste_grati.Location = New System.Drawing.Point(75, 80)
        Me.npddif_ajuste_grati.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npddif_ajuste_grati.Name = "npddif_ajuste_grati"
        Me.npddif_ajuste_grati.Size = New System.Drawing.Size(120, 20)
        Me.npddif_ajuste_grati.TabIndex = 17
        '
        'ndpprov_acum_grati
        '
        Me.ndpprov_acum_grati.DecimalPlaces = 2
        Me.ndpprov_acum_grati.Location = New System.Drawing.Point(75, 54)
        Me.ndpprov_acum_grati.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.ndpprov_acum_grati.Name = "ndpprov_acum_grati"
        Me.ndpprov_acum_grati.Size = New System.Drawing.Size(120, 20)
        Me.ndpprov_acum_grati.TabIndex = 16
        '
        'npdgrati
        '
        Me.npdgrati.DecimalPlaces = 2
        Me.npdgrati.Location = New System.Drawing.Point(75, 28)
        Me.npdgrati.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npdgrati.Name = "npdgrati"
        Me.npdgrati.Size = New System.Drawing.Size(120, 20)
        Me.npdgrati.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Ajuste:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Acumulado:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Pagado:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 245)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Horas Ext:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(30, 269)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Comision:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 294)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Otros Pagos:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(243, 245)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 13)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "Pago Subsidio:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(243, 269)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 13)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Dscto 5ta:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(243, 294)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 13)
        Me.Label17.TabIndex = 58
        Me.Label17.Text = "Otros Dscto:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(458, 245)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 13)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Prestamo:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(255, 88)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 13)
        Me.Label19.TabIndex = 60
        Me.Label19.Text = "Vacaciones:"
        '
        'drpfecini
        '
        Me.drpfecini.Checked = False
        Me.drpfecini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.drpfecini.Location = New System.Drawing.Point(327, 85)
        Me.drpfecini.Name = "drpfecini"
        Me.drpfecini.ShowCheckBox = True
        Me.drpfecini.Size = New System.Drawing.Size(93, 20)
        Me.drpfecini.TabIndex = 4
        '
        'dtpfecfin
        '
        Me.dtpfecfin.Checked = False
        Me.dtpfecfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecfin.Location = New System.Drawing.Point(437, 85)
        Me.dtpfecfin.Name = "dtpfecfin"
        Me.dtpfecfin.ShowCheckBox = True
        Me.dtpfecfin.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecfin.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(354, 69)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(32, 13)
        Me.Label20.TabIndex = 63
        Me.Label20.Text = "Inicio"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(470, 68)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(21, 13)
        Me.Label21.TabIndex = 64
        Me.Label21.Text = "Fin"
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbimprimir, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(709, 25)
        Me.tsbForm.TabIndex = 65
        Me.tsbForm.Text = "Grabar"
        '
        'tsbGrabar
        '
        Me.tsbGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGrabar.Image = CType(resources.GetObject("tsbGrabar.Image"), System.Drawing.Image)
        Me.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabar.Name = "tsbGrabar"
        Me.tsbGrabar.Size = New System.Drawing.Size(23, 22)
        Me.tsbGrabar.Tag = "save"
        Me.tsbGrabar.Text = "Grabar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbimprimir
        '
        Me.tsbimprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbimprimir.Image = CType(resources.GetObject("tsbimprimir.Image"), System.Drawing.Image)
        Me.tsbimprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbimprimir.Name = "tsbimprimir"
        Me.tsbimprimir.Size = New System.Drawing.Size(23, 22)
        Me.tsbimprimir.Tag = "Print"
        Me.tsbimprimir.Text = "Imprimir"
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
        'npdhextras
        '
        Me.npdhextras.DecimalPlaces = 2
        Me.npdhextras.Location = New System.Drawing.Point(88, 243)
        Me.npdhextras.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npdhextras.Name = "npdhextras"
        Me.npdhextras.Size = New System.Drawing.Size(120, 20)
        Me.npdhextras.TabIndex = 18
        '
        'npdcomision
        '
        Me.npdcomision.DecimalPlaces = 2
        Me.npdcomision.Location = New System.Drawing.Point(88, 267)
        Me.npdcomision.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npdcomision.Name = "npdcomision"
        Me.npdcomision.Size = New System.Drawing.Size(120, 20)
        Me.npdcomision.TabIndex = 19
        '
        'npdotros
        '
        Me.npdotros.DecimalPlaces = 2
        Me.npdotros.Location = New System.Drawing.Point(88, 292)
        Me.npdotros.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npdotros.Name = "npdotros"
        Me.npdotros.Size = New System.Drawing.Size(120, 20)
        Me.npdotros.TabIndex = 20
        '
        'npdsubsidio
        '
        Me.npdsubsidio.DecimalPlaces = 2
        Me.npdsubsidio.Location = New System.Drawing.Point(327, 243)
        Me.npdsubsidio.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npdsubsidio.Name = "npdsubsidio"
        Me.npdsubsidio.Size = New System.Drawing.Size(120, 20)
        Me.npdsubsidio.TabIndex = 21
        '
        'npddscto_quinta
        '
        Me.npddscto_quinta.DecimalPlaces = 2
        Me.npddscto_quinta.Location = New System.Drawing.Point(327, 267)
        Me.npddscto_quinta.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npddscto_quinta.Name = "npddscto_quinta"
        Me.npddscto_quinta.Size = New System.Drawing.Size(120, 20)
        Me.npddscto_quinta.TabIndex = 22
        '
        'npdotros_dsctos
        '
        Me.npdotros_dsctos.DecimalPlaces = 2
        Me.npdotros_dsctos.Location = New System.Drawing.Point(327, 292)
        Me.npdotros_dsctos.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npdotros_dsctos.Name = "npdotros_dsctos"
        Me.npdotros_dsctos.Size = New System.Drawing.Size(120, 20)
        Me.npdotros_dsctos.TabIndex = 23
        '
        'npdmonto_prest
        '
        Me.npdmonto_prest.DecimalPlaces = 2
        Me.npdmonto_prest.Location = New System.Drawing.Point(518, 243)
        Me.npdmonto_prest.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npdmonto_prest.Name = "npdmonto_prest"
        Me.npdmonto_prest.Size = New System.Drawing.Size(120, 20)
        Me.npdmonto_prest.TabIndex = 24
        '
        'FormSUBSIDIOMONTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 337)
        Me.Controls.Add(Me.npdmonto_prest)
        Me.Controls.Add(Me.npdotros_dsctos)
        Me.Controls.Add(Me.npddscto_quinta)
        Me.Controls.Add(Me.npdsubsidio)
        Me.Controls.Add(Me.npdotros)
        Me.Controls.Add(Me.npdcomision)
        Me.Controls.Add(Me.npdhextras)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.dtpfecfin)
        Me.Controls.Add(Me.drpfecini)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.dtpfec_ini)
        Me.Controls.Add(Me.txt_periodo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtnomper1)
        Me.Controls.Add(Me.txtper1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormSUBSIDIOMONTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSUBSIDIOMONTOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.npddif_ajuste_cts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdprov_acum_cts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdmonto_cts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.npddif_ajuste_vaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdprov_acum_vaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdvacaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.npddif_ajuste_grati, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndpprov_acum_grati, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdgrati, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        CType(Me.npdhextras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdcomision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdotros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdsubsidio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npddscto_quinta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdotros_dsctos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdmonto_prest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtper1 As TextBox
    Friend WithEvents txtnomper1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpfec_ini As DateTimePicker
    Friend WithEvents txt_periodo As TextBox
    Friend WithEvents npddif_ajuste_cts As NumericUpDown
    Friend WithEvents npdprov_acum_cts As NumericUpDown
    Friend WithEvents npdmonto_cts As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnbuscar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents npddif_ajuste_vaca As NumericUpDown
    Friend WithEvents npdprov_acum_vaca As NumericUpDown
    Friend WithEvents npdvacaciones As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents npddif_ajuste_grati As NumericUpDown
    Friend WithEvents ndpprov_acum_grati As NumericUpDown
    Friend WithEvents npdgrati As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents drpfecini As DateTimePicker
    Friend WithEvents dtpfecfin As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents npdhextras As NumericUpDown
    Friend WithEvents npdcomision As NumericUpDown
    Friend WithEvents npdotros As NumericUpDown
    Friend WithEvents npdsubsidio As NumericUpDown
    Friend WithEvents npddscto_quinta As NumericUpDown
    Friend WithEvents npdotros_dsctos As NumericUpDown
    Friend WithEvents npdmonto_prest As NumericUpDown
End Class
