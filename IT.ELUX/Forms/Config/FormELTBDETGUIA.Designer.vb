<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormELTBDETGUIA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormELTBDETGUIA))
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.npdcantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvt_doc = New System.Windows.Forms.DataGridView()
        Me.txtnroop = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbt_doc = New System.Windows.Forms.ComboBox()
        Me.txtt_doc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_serdoc = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtArt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblHojas = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ckbLimpiar = New System.Windows.Forms.CheckBox()
        Me.lblPesBru = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblPesNet = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblCanTot = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.lblArt = New System.Windows.Forms.Label()
        Me.lblnro = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblSer = New System.Windows.Forms.Label()
        Me.npdPesoBruto = New System.Windows.Forms.NumericUpDown()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.npdPesoNeto = New System.Windows.Forms.NumericUpDown()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFecGen = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.T_DOC_REF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SER_DOC_REF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRO_DOC_REF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_DOC_REF1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SER_DOC_REF1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRO_DOC_REF1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ART_COD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD_FAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FEC_GENE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESO_NETO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESO_BRUTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HOJAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsbForm.SuspendLayout()
        CType(Me.npdcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.npdPesoBruto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdPesoNeto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbimprimir, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(723, 25)
        Me.tsbForm.TabIndex = 145
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
        'npdcantidad
        '
        Me.npdcantidad.DecimalPlaces = 3
        Me.npdcantidad.Location = New System.Drawing.Point(313, 18)
        Me.npdcantidad.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.npdcantidad.Name = "npdcantidad"
        Me.npdcantidad.Size = New System.Drawing.Size(120, 20)
        Me.npdcantidad.TabIndex = 144
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(246, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "Hojas:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(616, 115)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 23)
        Me.Button4.TabIndex = 142
        Me.Button4.Text = "Borrar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(616, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 137
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvt_doc
        '
        Me.dgvt_doc.AllowUserToAddRows = False
        Me.dgvt_doc.AllowUserToDeleteRows = False
        Me.dgvt_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.T_DOC_REF, Me.SER_DOC_REF, Me.NRO_DOC_REF, Me.T_DOC_REF1, Me.SER_DOC_REF1, Me.NRO_DOC_REF1, Me.ART_COD, Me.COD_FAR, Me.FEC_GENE, Me.ESTADO, Me.PESO_NETO, Me.PESO_BRUTO, Me.HOJAS})
        Me.dgvt_doc.Location = New System.Drawing.Point(11, 86)
        Me.dgvt_doc.Name = "dgvt_doc"
        Me.dgvt_doc.ReadOnly = True
        Me.dgvt_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc.Size = New System.Drawing.Size(599, 221)
        Me.dgvt_doc.TabIndex = 136
        '
        'txtnroop
        '
        Me.txtnroop.Location = New System.Drawing.Point(540, 18)
        Me.txtnroop.MaxLength = 9
        Me.txtnroop.Name = "txtnroop"
        Me.txtnroop.ReadOnly = True
        Me.txtnroop.Size = New System.Drawing.Size(140, 20)
        Me.txtnroop.TabIndex = 134
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(479, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Numero:"
        '
        'cmbt_doc
        '
        Me.cmbt_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbt_doc.FormattingEnabled = True
        Me.cmbt_doc.Items.AddRange(New Object() {"FARDO"})
        Me.cmbt_doc.Location = New System.Drawing.Point(132, 15)
        Me.cmbt_doc.Name = "cmbt_doc"
        Me.cmbt_doc.Size = New System.Drawing.Size(170, 21)
        Me.cmbt_doc.TabIndex = 152
        '
        'txtt_doc
        '
        Me.txtt_doc.Location = New System.Drawing.Point(63, 16)
        Me.txtt_doc.Name = "txtt_doc"
        Me.txtt_doc.ReadOnly = True
        Me.txtt_doc.Size = New System.Drawing.Size(67, 20)
        Me.txtt_doc.TabIndex = 151
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 150
        Me.Label5.Text = "Tipo:"
        '
        'cmb_serdoc
        '
        Me.cmb_serdoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_serdoc.FormattingEnabled = True
        Me.cmb_serdoc.Items.AddRange(New Object() {"2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmb_serdoc.Location = New System.Drawing.Point(371, 16)
        Me.cmb_serdoc.Name = "cmb_serdoc"
        Me.cmb_serdoc.Size = New System.Drawing.Size(87, 21)
        Me.cmb_serdoc.TabIndex = 153
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(326, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 154
        Me.Label6.Text = "Serie:"
        '
        'txtArt
        '
        Me.txtArt.Location = New System.Drawing.Point(528, 17)
        Me.txtArt.Multiline = True
        Me.txtArt.Name = "txtArt"
        Me.txtArt.ReadOnly = True
        Me.txtArt.Size = New System.Drawing.Size(143, 20)
        Me.txtArt.TabIndex = 155
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(448, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 16)
        Me.Label7.TabIndex = 156
        Me.Label7.Text = "Cod. Fardo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.lblCant)
        Me.GroupBox1.Controls.Add(Me.lblArt)
        Me.GroupBox1.Controls.Add(Me.lblnro)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblSer)
        Me.GroupBox1.Controls.Add(Me.npdPesoBruto)
        Me.GroupBox1.Controls.Add(Me.lblTipo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.npdPesoNeto)
        Me.GroupBox1.Controls.Add(Me.dtpfecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblFecGen)
        Me.GroupBox1.Controls.Add(Me.dgvt_doc)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtArt)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.npdcantidad)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(712, 313)
        Me.GroupBox1.TabIndex = 157
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(619, 284)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 23)
        Me.Button2.TabIndex = 173
        Me.Button2.Text = "Importar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblHojas)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.ckbLimpiar)
        Me.GroupBox3.Controls.Add(Me.lblPesBru)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.lblPesNet)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.lblCanTot)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(613, 137)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(91, 137)
        Me.GroupBox3.TabIndex = 172
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'lblHojas
        '
        Me.lblHojas.AutoSize = True
        Me.lblHojas.Location = New System.Drawing.Point(8, 152)
        Me.lblHojas.Name = "lblHojas"
        Me.lblHojas.Size = New System.Drawing.Size(13, 13)
        Me.lblHojas.TabIndex = 8
        Me.lblHojas.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1, 137)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Hojas Total:"
        '
        'ckbLimpiar
        '
        Me.ckbLimpiar.AutoSize = True
        Me.ckbLimpiar.Location = New System.Drawing.Point(6, 13)
        Me.ckbLimpiar.Name = "ckbLimpiar"
        Me.ckbLimpiar.Size = New System.Drawing.Size(72, 17)
        Me.ckbLimpiar.TabIndex = 6
        Me.ckbLimpiar.Text = "No limpiar"
        Me.ckbLimpiar.UseVisualStyleBackColor = True
        '
        'lblPesBru
        '
        Me.lblPesBru.AutoSize = True
        Me.lblPesBru.Location = New System.Drawing.Point(8, 119)
        Me.lblPesBru.Name = "lblPesBru"
        Me.lblPesBru.Size = New System.Drawing.Size(13, 13)
        Me.lblPesBru.TabIndex = 5
        Me.lblPesBru.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Peso Bruto Total:"
        '
        'lblPesNet
        '
        Me.lblPesNet.AutoSize = True
        Me.lblPesNet.Location = New System.Drawing.Point(8, 84)
        Me.lblPesNet.Name = "lblPesNet"
        Me.lblPesNet.Size = New System.Drawing.Size(13, 13)
        Me.lblPesNet.TabIndex = 3
        Me.lblPesNet.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(2, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Peso Neto Total:"
        '
        'lblCanTot
        '
        Me.lblCanTot.AutoSize = True
        Me.lblCanTot.Location = New System.Drawing.Point(8, 50)
        Me.lblCanTot.Name = "lblCanTot"
        Me.lblCanTot.Size = New System.Drawing.Size(13, 13)
        Me.lblCanTot.TabIndex = 1
        Me.lblCanTot.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(2, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Cantidad Total:"
        '
        'lblCant
        '
        Me.lblCant.AutoSize = True
        Me.lblCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant.Location = New System.Drawing.Point(641, 216)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(33, 16)
        Me.lblCant.TabIndex = 161
        Me.lblCant.Text = "cant"
        Me.lblCant.Visible = False
        '
        'lblArt
        '
        Me.lblArt.AutoSize = True
        Me.lblArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArt.Location = New System.Drawing.Point(641, 199)
        Me.lblArt.Name = "lblArt"
        Me.lblArt.Size = New System.Drawing.Size(23, 16)
        Me.lblArt.TabIndex = 160
        Me.lblArt.Text = "art"
        Me.lblArt.Visible = False
        '
        'lblnro
        '
        Me.lblnro.AutoSize = True
        Me.lblnro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnro.Location = New System.Drawing.Point(641, 183)
        Me.lblnro.Name = "lblnro"
        Me.lblnro.Size = New System.Drawing.Size(27, 16)
        Me.lblnro.TabIndex = 159
        Me.lblnro.Text = "nro"
        Me.lblnro.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(234, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 168
        Me.Label8.Text = "Peso Bruto:"
        '
        'lblSer
        '
        Me.lblSer.AutoSize = True
        Me.lblSer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSer.Location = New System.Drawing.Point(641, 167)
        Me.lblSer.Name = "lblSer"
        Me.lblSer.Size = New System.Drawing.Size(27, 16)
        Me.lblSer.TabIndex = 158
        Me.lblSer.Text = "ser"
        Me.lblSer.Visible = False
        '
        'npdPesoBruto
        '
        Me.npdPesoBruto.DecimalPlaces = 3
        Me.npdPesoBruto.Location = New System.Drawing.Point(313, 48)
        Me.npdPesoBruto.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.npdPesoBruto.Name = "npdPesoBruto"
        Me.npdPesoBruto.Size = New System.Drawing.Size(120, 20)
        Me.npdPesoBruto.TabIndex = 169
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(641, 151)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(30, 16)
        Me.lblTipo.TabIndex = 157
        Me.lblTipo.Text = "tipo"
        Me.lblTipo.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 166
        Me.Label4.Text = "Peso Neto:"
        '
        'npdPesoNeto
        '
        Me.npdPesoNeto.DecimalPlaces = 3
        Me.npdPesoNeto.Location = New System.Drawing.Point(89, 47)
        Me.npdPesoNeto.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.npdPesoNeto.Name = "npdPesoNeto"
        Me.npdPesoNeto.Size = New System.Drawing.Size(120, 20)
        Me.npdPesoNeto.TabIndex = 167
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(91, 18)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(118, 20)
        Me.dtpfecha.TabIndex = 165
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 164
        Me.Label1.Text = "Fecha:"
        '
        'lblFecGen
        '
        Me.lblFecGen.AutoSize = True
        Me.lblFecGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecGen.Location = New System.Drawing.Point(641, 232)
        Me.lblFecGen.Name = "lblFecGen"
        Me.lblFecGen.Size = New System.Drawing.Size(41, 16)
        Me.lblFecGen.TabIndex = 162
        Me.lblFecGen.Text = "fecha"
        Me.lblFecGen.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbt_doc)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtt_doc)
        Me.GroupBox2.Controls.Add(Me.cmb_serdoc)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtnroop)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(708, 48)
        Me.GroupBox2.TabIndex = 158
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cabezera"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'T_DOC_REF
        '
        Me.T_DOC_REF.FillWeight = 70.0!
        Me.T_DOC_REF.HeaderText = "Documento"
        Me.T_DOC_REF.Name = "T_DOC_REF"
        Me.T_DOC_REF.ReadOnly = True
        Me.T_DOC_REF.Width = 87
        '
        'SER_DOC_REF
        '
        Me.SER_DOC_REF.HeaderText = "Serie Documento"
        Me.SER_DOC_REF.Name = "SER_DOC_REF"
        Me.SER_DOC_REF.ReadOnly = True
        Me.SER_DOC_REF.Width = 105
        '
        'NRO_DOC_REF
        '
        Me.NRO_DOC_REF.HeaderText = "Numero Documento"
        Me.NRO_DOC_REF.Name = "NRO_DOC_REF"
        Me.NRO_DOC_REF.ReadOnly = True
        Me.NRO_DOC_REF.Width = 116
        '
        'T_DOC_REF1
        '
        Me.T_DOC_REF1.HeaderText = "Tipo"
        Me.T_DOC_REF1.Name = "T_DOC_REF1"
        Me.T_DOC_REF1.ReadOnly = True
        Me.T_DOC_REF1.Visible = False
        Me.T_DOC_REF1.Width = 53
        '
        'SER_DOC_REF1
        '
        Me.SER_DOC_REF1.HeaderText = "Ser. Art"
        Me.SER_DOC_REF1.Name = "SER_DOC_REF1"
        Me.SER_DOC_REF1.ReadOnly = True
        Me.SER_DOC_REF1.Visible = False
        Me.SER_DOC_REF1.Width = 51
        '
        'NRO_DOC_REF1
        '
        Me.NRO_DOC_REF1.HeaderText = "Nro. Art"
        Me.NRO_DOC_REF1.Name = "NRO_DOC_REF1"
        Me.NRO_DOC_REF1.ReadOnly = True
        Me.NRO_DOC_REF1.Visible = False
        Me.NRO_DOC_REF1.Width = 63
        '
        'ART_COD
        '
        Me.ART_COD.HeaderText = "Articulo"
        Me.ART_COD.Name = "ART_COD"
        Me.ART_COD.ReadOnly = True
        Me.ART_COD.Width = 67
        '
        'COD_FAR
        '
        Me.COD_FAR.HeaderText = "Codigó Fardo"
        Me.COD_FAR.Name = "COD_FAR"
        Me.COD_FAR.ReadOnly = True
        Me.COD_FAR.Width = 87
        '
        'FEC_GENE
        '
        Me.FEC_GENE.HeaderText = "Fecha"
        Me.FEC_GENE.Name = "FEC_GENE"
        Me.FEC_GENE.ReadOnly = True
        Me.FEC_GENE.Width = 62
        '
        'ESTADO
        '
        Me.ESTADO.HeaderText = "Est"
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.ReadOnly = True
        Me.ESTADO.Visible = False
        Me.ESTADO.Width = 47
        '
        'PESO_NETO
        '
        Me.PESO_NETO.HeaderText = "PESO NETO"
        Me.PESO_NETO.Name = "PESO_NETO"
        Me.PESO_NETO.ReadOnly = True
        Me.PESO_NETO.Width = 87
        '
        'PESO_BRUTO
        '
        Me.PESO_BRUTO.HeaderText = "PESO BRUTO"
        Me.PESO_BRUTO.Name = "PESO_BRUTO"
        Me.PESO_BRUTO.ReadOnly = True
        Me.PESO_BRUTO.Width = 94
        '
        'HOJAS
        '
        Me.HOJAS.HeaderText = "HOJAS"
        Me.HOJAS.Name = "HOJAS"
        Me.HOJAS.ReadOnly = True
        Me.HOJAS.Width = 67
        '
        'FormELTBDETGUIA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 406)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tsbForm)
        Me.Name = "FormELTBDETGUIA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FARDO"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        CType(Me.npdcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.npdPesoBruto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdPesoNeto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents npdcantidad As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvt_doc As DataGridView
    Friend WithEvents txtnroop As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbt_doc As ComboBox
    Friend WithEvents txtt_doc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_serdoc As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtArt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblArt As Label
    Friend WithEvents lblnro As Label
    Friend WithEvents lblSer As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblCant As Label
    Friend WithEvents lblFecGen As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents npdPesoBruto As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents npdPesoNeto As NumericUpDown
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblCanTot As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblPesBru As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblPesNet As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ckbLimpiar As CheckBox
    Friend WithEvents lblHojas As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents Button2 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents T_DOC_REF As DataGridViewTextBoxColumn
    Friend WithEvents SER_DOC_REF As DataGridViewTextBoxColumn
    Friend WithEvents NRO_DOC_REF As DataGridViewTextBoxColumn
    Friend WithEvents T_DOC_REF1 As DataGridViewTextBoxColumn
    Friend WithEvents SER_DOC_REF1 As DataGridViewTextBoxColumn
    Friend WithEvents NRO_DOC_REF1 As DataGridViewTextBoxColumn
    Friend WithEvents ART_COD As DataGridViewTextBoxColumn
    Friend WithEvents COD_FAR As DataGridViewTextBoxColumn
    Friend WithEvents FEC_GENE As DataGridViewTextBoxColumn
    Friend WithEvents ESTADO As DataGridViewTextBoxColumn
    Friend WithEvents PESO_NETO As DataGridViewTextBoxColumn
    Friend WithEvents PESO_BRUTO As DataGridViewTextBoxColumn
    Friend WithEvents HOJAS As DataGridViewTextBoxColumn
End Class
