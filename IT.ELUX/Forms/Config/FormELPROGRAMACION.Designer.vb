<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormELPROGRAMACION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormELPROGRAMACION))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.PER_COD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_PROGRAMADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MINUTOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIN1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIN2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIEMPO_DSCTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_DSCTO1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_DSCTO2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DSCTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRDO_COD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PERIODO_COD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LINEA_COD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AREA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtobservacion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtdscto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtt_dscto2 = New System.Windows.Forms.TextBox()
        Me.txtt_dscto1 = New System.Windows.Forms.TextBox()
        Me.txttiempo_dscto = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmin2 = New System.Windows.Forms.TextBox()
        Me.txtmin1 = New System.Windows.Forms.TextBox()
        Me.txtminutos = New System.Windows.Forms.TextBox()
        Me.lbllinea_cod = New System.Windows.Forms.Label()
        Me.txtlinea_cod = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpprogra_ini = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblprdo_cod = New System.Windows.Forms.Label()
        Me.txtprdo_cod = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblper_cod = New System.Windows.Forms.Label()
        Me.txtper_cod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1.SuspendLayout()
        Me.General.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tsbForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(11, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(723, 485)
        Me.TabControl1.TabIndex = 19
        '
        'General
        '
        Me.General.BackColor = System.Drawing.Color.White
        Me.General.Controls.Add(Me.Button1)
        Me.General.Controls.Add(Me.btnBorrar)
        Me.General.Controls.Add(Me.dgvDatos)
        Me.General.Controls.Add(Me.txtobservacion)
        Me.General.Controls.Add(Me.Label13)
        Me.General.Controls.Add(Me.txtdscto)
        Me.General.Controls.Add(Me.Label12)
        Me.General.Controls.Add(Me.GroupBox2)
        Me.General.Controls.Add(Me.GroupBox1)
        Me.General.Controls.Add(Me.lbllinea_cod)
        Me.General.Controls.Add(Me.txtlinea_cod)
        Me.General.Controls.Add(Me.Label3)
        Me.General.Controls.Add(Me.dtpprogra_ini)
        Me.General.Controls.Add(Me.Label7)
        Me.General.Controls.Add(Me.lblprdo_cod)
        Me.General.Controls.Add(Me.txtprdo_cod)
        Me.General.Controls.Add(Me.Label6)
        Me.General.Controls.Add(Me.lblper_cod)
        Me.General.Controls.Add(Me.txtper_cod)
        Me.General.Controls.Add(Me.Label1)
        Me.General.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(715, 459)
        Me.General.TabIndex = 0
        Me.General.Text = "GENERAL"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(127, 434)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 23)
        Me.Button1.TabIndex = 128
        Me.Button1.Text = "Borrar Todo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(15, 434)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(95, 23)
        Me.btnBorrar.TabIndex = 127
        Me.btnBorrar.Text = "Borrar Item"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PER_COD, Me.NOMBRES, Me.D_PROGRAMADO, Me.MINUTOS, Me.MIN1, Me.MIN2, Me.TIEMPO_DSCTO, Me.T_DSCTO1, Me.T_DSCTO2, Me.DSCTO, Me.OBSERVACION, Me.PRDO_COD, Me.PERIODO_COD, Me.LINEA_COD, Me.AREA})
        Me.dgvDatos.Location = New System.Drawing.Point(16, 226)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.Size = New System.Drawing.Size(671, 207)
        Me.dgvDatos.TabIndex = 67
        '
        'PER_COD
        '
        Me.PER_COD.HeaderText = "Dni"
        Me.PER_COD.Name = "PER_COD"
        Me.PER_COD.Visible = False
        '
        'NOMBRES
        '
        Me.NOMBRES.HeaderText = "Nombres"
        Me.NOMBRES.Name = "NOMBRES"
        Me.NOMBRES.Width = 200
        '
        'D_PROGRAMADO
        '
        Me.D_PROGRAMADO.HeaderText = "Dia - Fecha"
        Me.D_PROGRAMADO.Name = "D_PROGRAMADO"
        Me.D_PROGRAMADO.Width = 85
        '
        'MINUTOS
        '
        Me.MINUTOS.HeaderText = "Min 100% "
        Me.MINUTOS.Name = "MINUTOS"
        Me.MINUTOS.Width = 50
        '
        'MIN1
        '
        Me.MIN1.HeaderText = "Min 25%"
        Me.MIN1.Name = "MIN1"
        Me.MIN1.Width = 50
        '
        'MIN2
        '
        Me.MIN2.HeaderText = "Min 35%"
        Me.MIN2.Name = "MIN2"
        Me.MIN2.Width = 50
        '
        'TIEMPO_DSCTO
        '
        Me.TIEMPO_DSCTO.HeaderText = "Dscto 100%"
        Me.TIEMPO_DSCTO.Name = "TIEMPO_DSCTO"
        Me.TIEMPO_DSCTO.Width = 50
        '
        'T_DSCTO1
        '
        Me.T_DSCTO1.HeaderText = "Dscto 25%"
        Me.T_DSCTO1.Name = "T_DSCTO1"
        Me.T_DSCTO1.Width = 50
        '
        'T_DSCTO2
        '
        Me.T_DSCTO2.HeaderText = "Dscto 35%"
        Me.T_DSCTO2.Name = "T_DSCTO2"
        Me.T_DSCTO2.Width = 50
        '
        'DSCTO
        '
        Me.DSCTO.HeaderText = "T. dscto"
        Me.DSCTO.Name = "DSCTO"
        Me.DSCTO.Width = 50
        '
        'OBSERVACION
        '
        Me.OBSERVACION.HeaderText = "Observación"
        Me.OBSERVACION.Name = "OBSERVACION"
        Me.OBSERVACION.Width = 110
        '
        'PRDO_COD
        '
        Me.PRDO_COD.HeaderText = "PRDO_COD"
        Me.PRDO_COD.Name = "PRDO_COD"
        Me.PRDO_COD.Visible = False
        '
        'PERIODO_COD
        '
        Me.PERIODO_COD.HeaderText = "Periódo Pago"
        Me.PERIODO_COD.Name = "PERIODO_COD"
        '
        'LINEA_COD
        '
        Me.LINEA_COD.HeaderText = "LINEA_COD"
        Me.LINEA_COD.Name = "LINEA_COD"
        Me.LINEA_COD.Visible = False
        '
        'AREA
        '
        Me.AREA.HeaderText = "Area"
        Me.AREA.Name = "AREA"
        '
        'txtobservacion
        '
        Me.txtobservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobservacion.Location = New System.Drawing.Point(111, 183)
        Me.txtobservacion.MaxLength = 100
        Me.txtobservacion.Multiline = True
        Me.txtobservacion.Name = "txtobservacion"
        Me.txtobservacion.Size = New System.Drawing.Size(472, 33)
        Me.txtobservacion.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 200)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "Observación"
        '
        'txtdscto
        '
        Me.txtdscto.Location = New System.Drawing.Point(111, 115)
        Me.txtdscto.MaxLength = 8
        Me.txtdscto.Name = "txtdscto"
        Me.txtdscto.Size = New System.Drawing.Size(95, 21)
        Me.txtdscto.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 121)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Total Dscto."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtt_dscto2)
        Me.GroupBox2.Controls.Add(Me.txtt_dscto1)
        Me.GroupBox2.Controls.Add(Me.txttiempo_dscto)
        Me.GroupBox2.Location = New System.Drawing.Point(394, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 61)
        Me.GroupBox2.TabIndex = 62
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dscto. Minutos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(226, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "35%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(133, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "25%"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(30, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "100%"
        '
        'txtt_dscto2
        '
        Me.txtt_dscto2.Location = New System.Drawing.Point(205, 34)
        Me.txtt_dscto2.MaxLength = 4
        Me.txtt_dscto2.Name = "txtt_dscto2"
        Me.txtt_dscto2.Size = New System.Drawing.Size(77, 21)
        Me.txtt_dscto2.TabIndex = 10
        '
        'txtt_dscto1
        '
        Me.txtt_dscto1.Location = New System.Drawing.Point(112, 34)
        Me.txtt_dscto1.MaxLength = 4
        Me.txtt_dscto1.Name = "txtt_dscto1"
        Me.txtt_dscto1.Size = New System.Drawing.Size(77, 21)
        Me.txtt_dscto1.TabIndex = 9
        '
        'txttiempo_dscto
        '
        Me.txttiempo_dscto.Location = New System.Drawing.Point(11, 33)
        Me.txttiempo_dscto.MaxLength = 4
        Me.txttiempo_dscto.Name = "txttiempo_dscto"
        Me.txttiempo_dscto.Size = New System.Drawing.Size(77, 21)
        Me.txttiempo_dscto.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtmin2)
        Me.GroupBox1.Controls.Add(Me.txtmin1)
        Me.GroupBox1.Controls.Add(Me.txtminutos)
        Me.GroupBox1.Location = New System.Drawing.Point(394, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 61)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Minutos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(225, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "35%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(132, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "25%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "100%"
        '
        'txtmin2
        '
        Me.txtmin2.Location = New System.Drawing.Point(205, 34)
        Me.txtmin2.MaxLength = 4
        Me.txtmin2.Name = "txtmin2"
        Me.txtmin2.Size = New System.Drawing.Size(77, 21)
        Me.txtmin2.TabIndex = 7
        '
        'txtmin1
        '
        Me.txtmin1.Location = New System.Drawing.Point(112, 34)
        Me.txtmin1.MaxLength = 4
        Me.txtmin1.Name = "txtmin1"
        Me.txtmin1.Size = New System.Drawing.Size(77, 21)
        Me.txtmin1.TabIndex = 6
        '
        'txtminutos
        '
        Me.txtminutos.Location = New System.Drawing.Point(11, 34)
        Me.txtminutos.MaxLength = 4
        Me.txtminutos.Name = "txtminutos"
        Me.txtminutos.Size = New System.Drawing.Size(77, 21)
        Me.txtminutos.TabIndex = 5
        '
        'lbllinea_cod
        '
        Me.lbllinea_cod.BackColor = System.Drawing.Color.Gainsboro
        Me.lbllinea_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbllinea_cod.Location = New System.Drawing.Point(167, 149)
        Me.lbllinea_cod.Name = "lbllinea_cod"
        Me.lbllinea_cod.Size = New System.Drawing.Size(197, 21)
        Me.lbllinea_cod.TabIndex = 60
        Me.lbllinea_cod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtlinea_cod
        '
        Me.txtlinea_cod.Location = New System.Drawing.Point(111, 149)
        Me.txtlinea_cod.MaxLength = 5
        Me.txtlinea_cod.Name = "txtlinea_cod"
        Me.txtlinea_cod.Size = New System.Drawing.Size(55, 21)
        Me.txtlinea_cod.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Area"
        '
        'dtpprogra_ini
        '
        Me.dtpprogra_ini.Checked = False
        Me.dtpprogra_ini.CustomFormat = ""
        Me.dtpprogra_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpprogra_ini.Location = New System.Drawing.Point(111, 84)
        Me.dtpprogra_ini.Name = "dtpprogra_ini"
        Me.dtpprogra_ini.Size = New System.Drawing.Size(95, 21)
        Me.dtpprogra_ini.TabIndex = 11
        Me.dtpprogra_ini.Value = New Date(2018, 12, 21, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Dia Programado"
        '
        'lblprdo_cod
        '
        Me.lblprdo_cod.BackColor = System.Drawing.Color.Gainsboro
        Me.lblprdo_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblprdo_cod.Location = New System.Drawing.Point(166, 55)
        Me.lblprdo_cod.Name = "lblprdo_cod"
        Me.lblprdo_cod.Size = New System.Drawing.Size(197, 21)
        Me.lblprdo_cod.TabIndex = 49
        Me.lblprdo_cod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtprdo_cod
        '
        Me.txtprdo_cod.Location = New System.Drawing.Point(110, 55)
        Me.txtprdo_cod.MaxLength = 6
        Me.txtprdo_cod.Name = "txtprdo_cod"
        Me.txtprdo_cod.Size = New System.Drawing.Size(55, 21)
        Me.txtprdo_cod.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Periódo Pago"
        '
        'lblper_cod
        '
        Me.lblper_cod.BackColor = System.Drawing.Color.Gainsboro
        Me.lblper_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblper_cod.Location = New System.Drawing.Point(201, 22)
        Me.lblper_cod.Name = "lblper_cod"
        Me.lblper_cod.Size = New System.Drawing.Size(382, 21)
        Me.lblper_cod.TabIndex = 43
        Me.lblper_cod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtper_cod
        '
        Me.txtper_cod.Location = New System.Drawing.Point(110, 22)
        Me.txtper_cod.MaxLength = 8
        Me.txtper_cod.Name = "txtper_cod"
        Me.txtper_cod.Size = New System.Drawing.Size(90, 21)
        Me.txtper_cod.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Personal"
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbBorrar, Me.ToolStripSeparator1, Me.tsbSalir, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(747, 25)
        Me.tsbForm.TabIndex = 20
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Tag = "Periodo"
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Reporte Periodo"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Tag = "Personal"
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "Reporte Personal"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Tag = "ccosto"
        Me.ToolStripButton3.Text = "ToolStripButton3"
        Me.ToolStripButton3.ToolTipText = "Reporte c. costo"
        '
        'FormELPROGRAMACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 523)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormELPROGRAMACION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programación de Horas Extras"
        Me.TabControl1.ResumeLayout(False)
        Me.General.ResumeLayout(False)
        Me.General.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents General As TabPage
    Friend WithEvents dtpprogra_ini As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents lblprdo_cod As Label
    Friend WithEvents txtprdo_cod As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblper_cod As Label
    Friend WithEvents txtper_cod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbBorrar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents txtobservacion As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtdscto As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtt_dscto2 As TextBox
    Friend WithEvents txtt_dscto1 As TextBox
    Friend WithEvents txttiempo_dscto As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtmin2 As TextBox
    Friend WithEvents txtmin1 As TextBox
    Friend WithEvents txtminutos As TextBox
    Friend WithEvents lbllinea_cod As Label
    Friend WithEvents txtlinea_cod As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents PER_COD As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRES As DataGridViewTextBoxColumn
    Friend WithEvents D_PROGRAMADO As DataGridViewTextBoxColumn
    Friend WithEvents MINUTOS As DataGridViewTextBoxColumn
    Friend WithEvents MIN1 As DataGridViewTextBoxColumn
    Friend WithEvents MIN2 As DataGridViewTextBoxColumn
    Friend WithEvents TIEMPO_DSCTO As DataGridViewTextBoxColumn
    Friend WithEvents T_DSCTO1 As DataGridViewTextBoxColumn
    Friend WithEvents T_DSCTO2 As DataGridViewTextBoxColumn
    Friend WithEvents DSCTO As DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACION As DataGridViewTextBoxColumn
    Friend WithEvents PRDO_COD As DataGridViewTextBoxColumn
    Friend WithEvents PERIODO_COD As DataGridViewTextBoxColumn
    Friend WithEvents LINEA_COD As DataGridViewTextBoxColumn
    Friend WithEvents AREA As DataGridViewTextBoxColumn
    Friend WithEvents btnBorrar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
End Class
