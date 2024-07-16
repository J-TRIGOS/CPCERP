<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormELTBCUENTA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormELTBCUENTA))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.dtpfec_ingreso = New System.Windows.Forms.DateTimePicker()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_cta_des2 = New System.Windows.Forms.TextBox()
        Me.txt_cta_des1 = New System.Windows.Forms.TextBox()
        Me.txt_cod_ajuste2 = New System.Windows.Forms.TextBox()
        Me.txt_cod_ajuste1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_xpadre = New System.Windows.Forms.CheckBox()
        Me.chk_x_balance = New System.Windows.Forms.CheckBox()
        Me.chk_x_modulo = New System.Windows.Forms.CheckBox()
        Me.chk_xlabor = New System.Windows.Forms.CheckBox()
        Me.chk_x_difcmb = New System.Windows.Forms.CheckBox()
        Me.chk_tdoc = New System.Windows.Forms.CheckBox()
        Me.chk_tsaldo = New System.Windows.Forms.CheckBox()
        Me.chk_xsucu = New System.Windows.Forms.CheckBox()
        Me.chk_t_conv = New System.Windows.Forms.CheckBox()
        Me.chk_xfuente = New System.Windows.Forms.CheckBox()
        Me.chk_hco = New System.Windows.Forms.CheckBox()
        Me.chk_x_linea = New System.Windows.Forms.CheckBox()
        Me.chk_x_proy = New System.Windows.Forms.CheckBox()
        Me.chk_x_tgasto = New System.Windows.Forms.CheckBox()
        Me.chk_ctct = New System.Windows.Forms.CheckBox()
        Me.chk_t_ajuste = New System.Windows.Forms.CheckBox()
        Me.chk_x_cco = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_xtcmb = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcta_cod = New System.Windows.Forms.TextBox()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.txtcod_abono = New System.Windows.Forms.TextBox()
        Me.cmb_año = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcta_alt_cod = New System.Windows.Forms.TextBox()
        Me.cmb_moneda = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcod_cargo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1.SuspendLayout()
        Me.General.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tsbForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(723, 378)
        Me.TabControl1.TabIndex = 25
        '
        'General
        '
        Me.General.BackColor = System.Drawing.Color.White
        Me.General.Controls.Add(Me.dtpfec_ingreso)
        Me.General.Controls.Add(Me.txt_nom)
        Me.General.Controls.Add(Me.txt_cta_des2)
        Me.General.Controls.Add(Me.txt_cta_des1)
        Me.General.Controls.Add(Me.txt_cod_ajuste2)
        Me.General.Controls.Add(Me.txt_cod_ajuste1)
        Me.General.Controls.Add(Me.Label13)
        Me.General.Controls.Add(Me.GroupBox1)
        Me.General.Controls.Add(Me.Label8)
        Me.General.Controls.Add(Me.Label15)
        Me.General.Controls.Add(Me.Label6)
        Me.General.Controls.Add(Me.txtcta_cod)
        Me.General.Controls.Add(Me.txtcod)
        Me.General.Controls.Add(Me.txtcod_abono)
        Me.General.Controls.Add(Me.cmb_año)
        Me.General.Controls.Add(Me.Label14)
        Me.General.Controls.Add(Me.Label11)
        Me.General.Controls.Add(Me.Label10)
        Me.General.Controls.Add(Me.Label9)
        Me.General.Controls.Add(Me.Label7)
        Me.General.Controls.Add(Me.txtcta_alt_cod)
        Me.General.Controls.Add(Me.cmb_moneda)
        Me.General.Controls.Add(Me.Label2)
        Me.General.Controls.Add(Me.Label1)
        Me.General.Controls.Add(Me.Label5)
        Me.General.Controls.Add(Me.txtcod_cargo)
        Me.General.Controls.Add(Me.Label3)
        Me.General.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(715, 352)
        Me.General.TabIndex = 0
        Me.General.Text = "GENERAL"
        '
        'dtpfec_ingreso
        '
        Me.dtpfec_ingreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ingreso.Location = New System.Drawing.Point(584, 81)
        Me.dtpfec_ingreso.Name = "dtpfec_ingreso"
        Me.dtpfec_ingreso.ShowCheckBox = True
        Me.dtpfec_ingreso.Size = New System.Drawing.Size(106, 21)
        Me.dtpfec_ingreso.TabIndex = 122
        Me.dtpfec_ingreso.Value = New Date(2018, 11, 8, 0, 0, 0, 0)
        '
        'txt_nom
        '
        Me.txt_nom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nom.Location = New System.Drawing.Point(400, 55)
        Me.txt_nom.MaxLength = 100
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(290, 21)
        Me.txt_nom.TabIndex = 8
        '
        'txt_cta_des2
        '
        Me.txt_cta_des2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cta_des2.Location = New System.Drawing.Point(400, 164)
        Me.txt_cta_des2.MaxLength = 15
        Me.txt_cta_des2.Name = "txt_cta_des2"
        Me.txt_cta_des2.Size = New System.Drawing.Size(92, 21)
        Me.txt_cta_des2.TabIndex = 12
        '
        'txt_cta_des1
        '
        Me.txt_cta_des1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cta_des1.Location = New System.Drawing.Point(400, 137)
        Me.txt_cta_des1.MaxLength = 15
        Me.txt_cta_des1.Name = "txt_cta_des1"
        Me.txt_cta_des1.Size = New System.Drawing.Size(92, 21)
        Me.txt_cta_des1.TabIndex = 11
        '
        'txt_cod_ajuste2
        '
        Me.txt_cod_ajuste2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cod_ajuste2.Location = New System.Drawing.Point(400, 110)
        Me.txt_cod_ajuste2.MaxLength = 15
        Me.txt_cod_ajuste2.Name = "txt_cod_ajuste2"
        Me.txt_cod_ajuste2.Size = New System.Drawing.Size(92, 21)
        Me.txt_cod_ajuste2.TabIndex = 10
        '
        'txt_cod_ajuste1
        '
        Me.txt_cod_ajuste1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cod_ajuste1.Location = New System.Drawing.Point(400, 83)
        Me.txt_cod_ajuste1.MaxLength = 15
        Me.txt_cod_ajuste1.Name = "txt_cod_ajuste1"
        Me.txt_cod_ajuste1.Size = New System.Drawing.Size(92, 21)
        Me.txt_cod_ajuste1.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(517, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 121
        Me.Label13.Text = "Fecha Ing."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_xpadre)
        Me.GroupBox1.Controls.Add(Me.chk_x_balance)
        Me.GroupBox1.Controls.Add(Me.chk_x_modulo)
        Me.GroupBox1.Controls.Add(Me.chk_xlabor)
        Me.GroupBox1.Controls.Add(Me.chk_x_difcmb)
        Me.GroupBox1.Controls.Add(Me.chk_tdoc)
        Me.GroupBox1.Controls.Add(Me.chk_tsaldo)
        Me.GroupBox1.Controls.Add(Me.chk_xsucu)
        Me.GroupBox1.Controls.Add(Me.chk_t_conv)
        Me.GroupBox1.Controls.Add(Me.chk_xfuente)
        Me.GroupBox1.Controls.Add(Me.chk_hco)
        Me.GroupBox1.Controls.Add(Me.chk_x_linea)
        Me.GroupBox1.Controls.Add(Me.chk_x_proy)
        Me.GroupBox1.Controls.Add(Me.chk_x_tgasto)
        Me.GroupBox1.Controls.Add(Me.chk_ctct)
        Me.GroupBox1.Controls.Add(Me.chk_t_ajuste)
        Me.GroupBox1.Controls.Add(Me.chk_x_cco)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cmb_xtcmb)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 211)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(678, 129)
        Me.GroupBox1.TabIndex = 97
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Indicadores"
        '
        'chk_xpadre
        '
        Me.chk_xpadre.AutoSize = True
        Me.chk_xpadre.Location = New System.Drawing.Point(600, 72)
        Me.chk_xpadre.Name = "chk_xpadre"
        Me.chk_xpadre.Size = New System.Drawing.Size(63, 17)
        Me.chk_xpadre.TabIndex = 115
        Me.chk_xpadre.Text = "X Padre"
        Me.chk_xpadre.UseVisualStyleBackColor = True
        '
        'chk_x_balance
        '
        Me.chk_x_balance.AutoSize = True
        Me.chk_x_balance.Location = New System.Drawing.Point(603, 107)
        Me.chk_x_balance.Name = "chk_x_balance"
        Me.chk_x_balance.Size = New System.Drawing.Size(72, 17)
        Me.chk_x_balance.TabIndex = 114
        Me.chk_x_balance.Text = "X Balance"
        Me.chk_x_balance.UseVisualStyleBackColor = True
        '
        'chk_x_modulo
        '
        Me.chk_x_modulo.AutoSize = True
        Me.chk_x_modulo.Location = New System.Drawing.Point(559, 34)
        Me.chk_x_modulo.Name = "chk_x_modulo"
        Me.chk_x_modulo.Size = New System.Drawing.Size(69, 17)
        Me.chk_x_modulo.TabIndex = 113
        Me.chk_x_modulo.Text = "X Modulo"
        Me.chk_x_modulo.UseVisualStyleBackColor = True
        '
        'chk_xlabor
        '
        Me.chk_xlabor.AutoSize = True
        Me.chk_xlabor.Location = New System.Drawing.Point(505, 107)
        Me.chk_xlabor.Name = "chk_xlabor"
        Me.chk_xlabor.Size = New System.Drawing.Size(53, 17)
        Me.chk_xlabor.TabIndex = 112
        Me.chk_xlabor.Text = "Labor"
        Me.chk_xlabor.UseVisualStyleBackColor = True
        '
        'chk_x_difcmb
        '
        Me.chk_x_difcmb.AutoSize = True
        Me.chk_x_difcmb.Location = New System.Drawing.Point(400, 107)
        Me.chk_x_difcmb.Name = "chk_x_difcmb"
        Me.chk_x_difcmb.Size = New System.Drawing.Size(67, 17)
        Me.chk_x_difcmb.TabIndex = 111
        Me.chk_x_difcmb.Text = "Dif. Cmb"
        Me.chk_x_difcmb.UseVisualStyleBackColor = True
        '
        'chk_tdoc
        '
        Me.chk_tdoc.AutoSize = True
        Me.chk_tdoc.Location = New System.Drawing.Point(305, 107)
        Me.chk_tdoc.Name = "chk_tdoc"
        Me.chk_tdoc.Size = New System.Drawing.Size(57, 17)
        Me.chk_tdoc.TabIndex = 110
        Me.chk_tdoc.Text = "T. Doc"
        Me.chk_tdoc.UseVisualStyleBackColor = True
        '
        'chk_tsaldo
        '
        Me.chk_tsaldo.AutoSize = True
        Me.chk_tsaldo.Location = New System.Drawing.Point(196, 107)
        Me.chk_tsaldo.Name = "chk_tsaldo"
        Me.chk_tsaldo.Size = New System.Drawing.Size(65, 17)
        Me.chk_tsaldo.TabIndex = 109
        Me.chk_tsaldo.Text = "T. Saldo"
        Me.chk_tsaldo.UseVisualStyleBackColor = True
        '
        'chk_xsucu
        '
        Me.chk_xsucu.AutoSize = True
        Me.chk_xsucu.Location = New System.Drawing.Point(99, 107)
        Me.chk_xsucu.Name = "chk_xsucu"
        Me.chk_xsucu.Size = New System.Drawing.Size(53, 17)
        Me.chk_xsucu.TabIndex = 108
        Me.chk_xsucu.Text = "Sucu."
        Me.chk_xsucu.UseVisualStyleBackColor = True
        '
        'chk_t_conv
        '
        Me.chk_t_conv.AutoSize = True
        Me.chk_t_conv.Location = New System.Drawing.Point(9, 107)
        Me.chk_t_conv.Name = "chk_t_conv"
        Me.chk_t_conv.Size = New System.Drawing.Size(68, 17)
        Me.chk_t_conv.TabIndex = 107
        Me.chk_t_conv.Text = "T. Conv."
        Me.chk_t_conv.UseVisualStyleBackColor = True
        '
        'chk_xfuente
        '
        Me.chk_xfuente.AutoSize = True
        Me.chk_xfuente.Location = New System.Drawing.Point(505, 72)
        Me.chk_xfuente.Name = "chk_xfuente"
        Me.chk_xfuente.Size = New System.Drawing.Size(60, 17)
        Me.chk_xfuente.TabIndex = 106
        Me.chk_xfuente.Text = "Fuente"
        Me.chk_xfuente.UseVisualStyleBackColor = True
        '
        'chk_hco
        '
        Me.chk_hco.AutoSize = True
        Me.chk_hco.Location = New System.Drawing.Point(400, 72)
        Me.chk_hco.Name = "chk_hco"
        Me.chk_hco.Size = New System.Drawing.Size(75, 17)
        Me.chk_hco.TabIndex = 105
        Me.chk_hco.Text = "H. Control"
        Me.chk_hco.UseVisualStyleBackColor = True
        '
        'chk_x_linea
        '
        Me.chk_x_linea.AutoSize = True
        Me.chk_x_linea.Location = New System.Drawing.Point(305, 72)
        Me.chk_x_linea.Name = "chk_x_linea"
        Me.chk_x_linea.Size = New System.Drawing.Size(51, 17)
        Me.chk_x_linea.TabIndex = 104
        Me.chk_x_linea.Text = "Linea"
        Me.chk_x_linea.UseVisualStyleBackColor = True
        '
        'chk_x_proy
        '
        Me.chk_x_proy.AutoSize = True
        Me.chk_x_proy.Location = New System.Drawing.Point(196, 72)
        Me.chk_x_proy.Name = "chk_x_proy"
        Me.chk_x_proy.Size = New System.Drawing.Size(48, 17)
        Me.chk_x_proy.TabIndex = 103
        Me.chk_x_proy.Text = "Proy"
        Me.chk_x_proy.UseVisualStyleBackColor = True
        '
        'chk_x_tgasto
        '
        Me.chk_x_tgasto.AutoSize = True
        Me.chk_x_tgasto.Location = New System.Drawing.Point(99, 72)
        Me.chk_x_tgasto.Name = "chk_x_tgasto"
        Me.chk_x_tgasto.Size = New System.Drawing.Size(67, 17)
        Me.chk_x_tgasto.TabIndex = 102
        Me.chk_x_tgasto.Text = "T. Gasto"
        Me.chk_x_tgasto.UseVisualStyleBackColor = True
        '
        'chk_ctct
        '
        Me.chk_ctct.AutoSize = True
        Me.chk_ctct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk_ctct.Location = New System.Drawing.Point(9, 72)
        Me.chk_ctct.Name = "chk_ctct"
        Me.chk_ctct.Size = New System.Drawing.Size(71, 17)
        Me.chk_ctct.TabIndex = 101
        Me.chk_ctct.Text = "Cta. Cte."
        Me.chk_ctct.UseVisualStyleBackColor = True
        '
        'chk_t_ajuste
        '
        Me.chk_t_ajuste.AutoSize = True
        Me.chk_t_ajuste.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk_t_ajuste.Location = New System.Drawing.Point(434, 34)
        Me.chk_t_ajuste.Name = "chk_t_ajuste"
        Me.chk_t_ajuste.Size = New System.Drawing.Size(74, 17)
        Me.chk_t_ajuste.TabIndex = 100
        Me.chk_t_ajuste.Text = "Ajuste Inf"
        Me.chk_t_ajuste.UseVisualStyleBackColor = True
        '
        'chk_x_cco
        '
        Me.chk_x_cco.AutoSize = True
        Me.chk_x_cco.Location = New System.Drawing.Point(305, 34)
        Me.chk_x_cco.Name = "chk_x_cco"
        Me.chk_x_cco.Size = New System.Drawing.Size(90, 17)
        Me.chk_x_cco.TabIndex = 99
        Me.chk_x_cco.Text = "Centro Costo"
        Me.chk_x_cco.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 23)
        Me.Label12.TabIndex = 98
        Me.Label12.Text = "X T Cmb"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_xtcmb
        '
        Me.cmb_xtcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_xtcmb.FormattingEnabled = True
        Me.cmb_xtcmb.Items.AddRange(New Object() {"N - DOLARES AMERICANOS", "V - DOLARES PARALELOS", "S - NUEVOS SOLES", "C - DOLARES PROMEDIO"})
        Me.cmb_xtcmb.Location = New System.Drawing.Point(99, 30)
        Me.cmb_xtcmb.Name = "cmb_xtcmb"
        Me.cmb_xtcmb.Size = New System.Drawing.Size(157, 21)
        Me.cmb_xtcmb.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(322, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 23)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "Cta Destino 2"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(322, 142)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 23)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "Cta Destino 1"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(322, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 23)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Cta Ajuste 2"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcta_cod
        '
        Me.txtcta_cod.Location = New System.Drawing.Point(110, 140)
        Me.txtcta_cod.MaxLength = 15
        Me.txtcta_cod.Name = "txtcta_cod"
        Me.txtcta_cod.Size = New System.Drawing.Size(92, 21)
        Me.txtcta_cod.TabIndex = 5
        '
        'txtcod
        '
        Me.txtcod.Location = New System.Drawing.Point(110, 55)
        Me.txtcod.MaxLength = 15
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(92, 21)
        Me.txtcod.TabIndex = 2
        '
        'txtcod_abono
        '
        Me.txtcod_abono.Location = New System.Drawing.Point(110, 83)
        Me.txtcod_abono.MaxLength = 5
        Me.txtcod_abono.Name = "txtcod_abono"
        Me.txtcod_abono.Size = New System.Drawing.Size(92, 21)
        Me.txtcod_abono.TabIndex = 3
        '
        'cmb_año
        '
        Me.cmb_año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_año.FormattingEnabled = True
        Me.cmb_año.Items.AddRange(New Object() {"2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025"})
        Me.cmb_año.Location = New System.Drawing.Point(110, 26)
        Me.cmb_año.Name = "cmb_año"
        Me.cmb_año.Size = New System.Drawing.Size(61, 21)
        Me.cmb_año.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(17, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 23)
        Me.Label14.TabIndex = 87
        Me.Label14.Text = "Año"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(322, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 23)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Cta Ajuste 1"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(322, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 23)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Descripción"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(322, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 23)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Moneda"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 23)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Codigo Cta Alt"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcta_alt_cod
        '
        Me.txtcta_alt_cod.Location = New System.Drawing.Point(110, 170)
        Me.txtcta_alt_cod.MaxLength = 15
        Me.txtcta_alt_cod.Name = "txtcta_alt_cod"
        Me.txtcta_alt_cod.Size = New System.Drawing.Size(92, 21)
        Me.txtcta_alt_cod.TabIndex = 6
        '
        'cmb_moneda
        '
        Me.cmb_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_moneda.FormattingEnabled = True
        Me.cmb_moneda.Location = New System.Drawing.Point(400, 26)
        Me.cmb_moneda.Name = "cmb_moneda"
        Me.cmb_moneda.Size = New System.Drawing.Size(146, 21)
        Me.cmb_moneda.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Codigo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 23)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Codigo Cargo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 23)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Codigo Cta"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcod_cargo
        '
        Me.txtcod_cargo.Location = New System.Drawing.Point(110, 110)
        Me.txtcod_cargo.MaxLength = 5
        Me.txtcod_cargo.Name = "txtcod_cargo"
        Me.txtcod_cargo.Size = New System.Drawing.Size(92, 21)
        Me.txtcod_cargo.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 23)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Codigo Abono"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbBorrar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(747, 25)
        Me.tsbForm.TabIndex = 26
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
        'tsbBorrar
        '
        Me.tsbBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbBorrar.Image = CType(resources.GetObject("tsbBorrar.Image"), System.Drawing.Image)
        Me.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBorrar.Name = "tsbBorrar"
        Me.tsbBorrar.Size = New System.Drawing.Size(23, 22)
        Me.tsbBorrar.Tag = "delete"
        Me.tsbBorrar.Text = "Borrar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'FormELTBCUENTA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 420)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormELTBCUENTA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Cuenta"
        Me.TabControl1.ResumeLayout(False)
        Me.General.ResumeLayout(False)
        Me.General.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents General As TabPage
    Friend WithEvents txtcod_abono As TextBox
    Friend WithEvents cmb_año As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcta_alt_cod As TextBox
    Friend WithEvents cmb_moneda As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_xtcmb As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcod_cargo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chk_xpadre As CheckBox
    Friend WithEvents chk_x_balance As CheckBox
    Friend WithEvents chk_x_modulo As CheckBox
    Friend WithEvents chk_xlabor As CheckBox
    Friend WithEvents chk_x_difcmb As CheckBox
    Friend WithEvents chk_tdoc As CheckBox
    Friend WithEvents chk_tsaldo As CheckBox
    Friend WithEvents chk_xsucu As CheckBox
    Friend WithEvents chk_t_conv As CheckBox
    Friend WithEvents chk_xfuente As CheckBox
    Friend WithEvents chk_hco As CheckBox
    Friend WithEvents chk_x_linea As CheckBox
    Friend WithEvents chk_x_proy As CheckBox
    Friend WithEvents chk_x_tgasto As CheckBox
    Friend WithEvents chk_ctct As CheckBox
    Friend WithEvents chk_t_ajuste As CheckBox
    Friend WithEvents chk_x_cco As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcta_cod As TextBox
    Friend WithEvents txtcod As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbBorrar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_cta_des2 As TextBox
    Friend WithEvents txt_cta_des1 As TextBox
    Friend WithEvents txt_cod_ajuste2 As TextBox
    Friend WithEvents txt_cod_ajuste1 As TextBox
    Friend WithEvents dtpfec_ingreso As DateTimePicker
End Class
