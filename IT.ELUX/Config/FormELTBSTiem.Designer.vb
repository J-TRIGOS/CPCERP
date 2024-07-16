<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormELTBSTiem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormELTBSTiem))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtt_doc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbdni = New System.Windows.Forms.ComboBox()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.dgvtiemper = New System.Windows.Forms.DataGridView()
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.cmbc_costo = New System.Windows.Forms.ComboBox()
        Me.txtc_costo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtdifhora = New System.Windows.Forms.TextBox()
        Me.dtphoratermino = New System.Windows.Forms.DateTimePicker()
        Me.dtphoragene = New System.Windows.Forms.DateTimePicker()
        Me.dtpfec_termino = New System.Windows.Forms.DateTimePicker()
        Me.dtpfec_inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtact = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnact = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtobs = New System.Windows.Forms.TextBox()
        Me.dtpfec_gene = New System.Windows.Forms.DateTimePicker()
        Me.cmbserie = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbt_doc = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnmod = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtobsjf = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmb_linea = New System.Windows.Forms.ComboBox()
        Me.txt_linea = New System.Windows.Forms.TextBox()
        Me.txtobservacion_rh = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtobsj = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblNroOm = New System.Windows.Forms.Label()
        Me.txtNroOm = New System.Windows.Forms.TextBox()
        Me.btnNroOm = New System.Windows.Forms.Button()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.lblTdoc = New System.Windows.Forms.Label()
        Me.lblSdoc = New System.Windows.Forms.Label()
        Me.cmbactividad = New System.Windows.Forms.ComboBox()
        CType(Me.dgvtiemper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsbForm.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo"
        '
        'txtt_doc
        '
        Me.txtt_doc.Location = New System.Drawing.Point(6, 19)
        Me.txtt_doc.MaxLength = 5
        Me.txtt_doc.Name = "txtt_doc"
        Me.txtt_doc.Size = New System.Drawing.Size(58, 20)
        Me.txtt_doc.TabIndex = 180
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Centro Costo :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Supervisor"
        '
        'cmbdni
        '
        Me.cmbdni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdni.FormattingEnabled = True
        Me.cmbdni.ItemHeight = 13
        Me.cmbdni.Location = New System.Drawing.Point(222, 93)
        Me.cmbdni.Name = "cmbdni"
        Me.cmbdni.Size = New System.Drawing.Size(372, 21)
        Me.cmbdni.TabIndex = 7
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(133, 93)
        Me.txtdni.MaxLength = 8
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(83, 20)
        Me.txtdni.TabIndex = 6
        '
        'dgvtiemper
        '
        Me.dgvtiemper.AllowUserToAddRows = False
        Me.dgvtiemper.AllowUserToDeleteRows = False
        Me.dgvtiemper.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvtiemper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtiemper.Location = New System.Drawing.Point(12, 364)
        Me.dgvtiemper.Name = "dgvtiemper"
        Me.dgvtiemper.ReadOnly = True
        Me.dgvtiemper.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvtiemper.Size = New System.Drawing.Size(536, 244)
        Me.dgvtiemper.TabIndex = 39
        '
        'cmbestado
        '
        Me.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.cmbestado.Location = New System.Drawing.Point(375, 18)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(121, 21)
        Me.cmbestado.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(224, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Serie"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 35)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Agregar Persona"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 35)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "Eliminar Persona"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 93)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 35)
        Me.Button3.TabIndex = 44
        Me.Button3.Text = "Agregar Grupo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbimprimir, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(659, 25)
        Me.tsbForm.TabIndex = 45
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Tag = "anular"
        Me.ToolStripButton1.Text = "Anular Documento"
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
        'cmbc_costo
        '
        Me.cmbc_costo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbc_costo.FormattingEnabled = True
        Me.cmbc_costo.Location = New System.Drawing.Point(184, 120)
        Me.cmbc_costo.Name = "cmbc_costo"
        Me.cmbc_costo.Size = New System.Drawing.Size(410, 21)
        Me.cmbc_costo.TabIndex = 9
        '
        'txtc_costo
        '
        Me.txtc_costo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtc_costo.Location = New System.Drawing.Point(134, 120)
        Me.txtc_costo.MaxLength = 3
        Me.txtc_costo.Name = "txtc_costo"
        Me.txtc_costo.Size = New System.Drawing.Size(44, 20)
        Me.txtc_costo.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Actividad a Realizar:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(347, 179)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(81, 13)
        Me.Label25.TabIndex = 173
        Me.Label25.Text = "Diferencia Hora"
        '
        'txtdifhora
        '
        Me.txtdifhora.Location = New System.Drawing.Point(340, 196)
        Me.txtdifhora.Name = "txtdifhora"
        Me.txtdifhora.ReadOnly = True
        Me.txtdifhora.Size = New System.Drawing.Size(100, 20)
        Me.txtdifhora.TabIndex = 172
        '
        'dtphoratermino
        '
        Me.dtphoratermino.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtphoratermino.Location = New System.Drawing.Point(238, 201)
        Me.dtphoratermino.Name = "dtphoratermino"
        Me.dtphoratermino.ShowUpDown = True
        Me.dtphoratermino.Size = New System.Drawing.Size(96, 20)
        Me.dtphoratermino.TabIndex = 13
        '
        'dtphoragene
        '
        Me.dtphoragene.CustomFormat = ""
        Me.dtphoragene.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtphoragene.Location = New System.Drawing.Point(238, 177)
        Me.dtphoragene.Name = "dtphoragene"
        Me.dtphoragene.ShowUpDown = True
        Me.dtphoragene.Size = New System.Drawing.Size(96, 20)
        Me.dtphoragene.TabIndex = 12
        '
        'dtpfec_termino
        '
        Me.dtpfec_termino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_termino.Location = New System.Drawing.Point(133, 201)
        Me.dtpfec_termino.Name = "dtpfec_termino"
        Me.dtpfec_termino.Size = New System.Drawing.Size(100, 20)
        Me.dtpfec_termino.TabIndex = 11
        '
        'dtpfec_inicio
        '
        Me.dtpfec_inicio.Enabled = False
        Me.dtpfec_inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_inicio.Location = New System.Drawing.Point(133, 177)
        Me.dtpfec_inicio.Name = "dtpfec_inicio"
        Me.dtpfec_inicio.Size = New System.Drawing.Size(100, 20)
        Me.dtpfec_inicio.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(35, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 167
        Me.Label11.Text = "Fecha Termino  :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 166
        Me.Label10.Text = "Fecha Inicio  :"
        '
        'txtact
        '
        Me.txtact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtact.Location = New System.Drawing.Point(145, 230)
        Me.txtact.Name = "txtact"
        Me.txtact.Size = New System.Drawing.Size(408, 20)
        Me.txtact.TabIndex = 14
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(608, 93)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(39, 23)
        Me.Button4.TabIndex = 175
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(608, 118)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(39, 23)
        Me.Button5.TabIndex = 176
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnact
        '
        Me.btnact.Location = New System.Drawing.Point(572, 228)
        Me.btnact.Name = "btnact"
        Me.btnact.Size = New System.Drawing.Size(62, 23)
        Me.btnact.TabIndex = 177
        Me.btnact.Text = "Incluir"
        Me.btnact.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(446, 194)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 23)
        Me.Button6.TabIndex = 178
        Me.Button6.Text = "Incluir"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 179
        Me.Label3.Text = "Observacion:"
        '
        'txtobs
        '
        Me.txtobs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobs.Location = New System.Drawing.Point(145, 257)
        Me.txtobs.Name = "txtobs"
        Me.txtobs.Size = New System.Drawing.Size(408, 20)
        Me.txtobs.TabIndex = 15
        '
        'dtpfec_gene
        '
        Me.dtpfec_gene.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_gene.Location = New System.Drawing.Point(504, 19)
        Me.dtpfec_gene.Name = "dtpfec_gene"
        Me.dtpfec_gene.Size = New System.Drawing.Size(100, 20)
        Me.dtpfec_gene.TabIndex = 5
        '
        'cmbserie
        '
        Me.cmbserie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbserie.Enabled = False
        Me.cmbserie.FormattingEnabled = True
        Me.cmbserie.Items.AddRange(New Object() {"2018", "2019", "2020", "2021", "2022", "2023", "2024"})
        Me.cmbserie.Location = New System.Drawing.Point(192, 18)
        Me.cmbserie.Name = "cmbserie"
        Me.cmbserie.Size = New System.Drawing.Size(76, 21)
        Me.cmbserie.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(434, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 183
        Me.Label4.Text = "Estado"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(305, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 185
        Me.Label8.Text = "Numero"
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(271, 19)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.ReadOnly = True
        Me.txtnumero.Size = New System.Drawing.Size(98, 20)
        Me.txtnumero.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(539, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 186
        Me.Label9.Text = "Fecha"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbt_doc)
        Me.GroupBox1.Controls.Add(Me.txtt_doc)
        Me.GroupBox1.Controls.Add(Me.dtpfec_gene)
        Me.GroupBox1.Controls.Add(Me.txtnumero)
        Me.GroupBox1.Controls.Add(Me.cmbestado)
        Me.GroupBox1.Controls.Add(Me.cmbserie)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 46)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cmbt_doc
        '
        Me.cmbt_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbt_doc.FormattingEnabled = True
        Me.cmbt_doc.Items.AddRange(New Object() {"SOBRE TIEMPO"})
        Me.cmbt_doc.Location = New System.Drawing.Point(70, 18)
        Me.cmbt_doc.Name = "cmbt_doc"
        Me.cmbt_doc.Size = New System.Drawing.Size(116, 21)
        Me.cmbt_doc.TabIndex = 181
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.btnmod)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(554, 354)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(93, 254)
        Me.GroupBox2.TabIndex = 188
        Me.GroupBox2.TabStop = False
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(6, 213)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 35)
        Me.Button8.TabIndex = 47
        Me.Button8.Text = "Limpiar Activdad"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(6, 173)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 35)
        Me.Button7.TabIndex = 46
        Me.Button7.Text = "Limpiar Hora"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btnmod
        '
        Me.btnmod.Location = New System.Drawing.Point(6, 134)
        Me.btnmod.Name = "btnmod"
        Me.btnmod.Size = New System.Drawing.Size(75, 35)
        Me.btnmod.TabIndex = 45
        Me.btnmod.Text = "Mod. Persona."
        Me.btnmod.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(587, 194)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 189
        Me.Label12.Text = "Label12"
        Me.Label12.Visible = False
        '
        'txtobsjf
        '
        Me.txtobsjf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobsjf.Location = New System.Drawing.Point(145, 311)
        Me.txtobsjf.Name = "txtobsjf"
        Me.txtobsjf.ReadOnly = True
        Me.txtobsjf.Size = New System.Drawing.Size(408, 20)
        Me.txtobsjf.TabIndex = 190
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 314)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 13)
        Me.Label13.TabIndex = 191
        Me.Label13.Text = "Observacion JF Planta:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(35, 150)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 194
        Me.Label14.Text = "Linea :"
        '
        'cmb_linea
        '
        Me.cmb_linea.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmb_linea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_linea.FormattingEnabled = True
        Me.cmb_linea.Location = New System.Drawing.Point(184, 146)
        Me.cmb_linea.Name = "cmb_linea"
        Me.cmb_linea.Size = New System.Drawing.Size(410, 21)
        Me.cmb_linea.TabIndex = 197
        '
        'txt_linea
        '
        Me.txt_linea.BackColor = System.Drawing.Color.White
        Me.txt_linea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_linea.Location = New System.Drawing.Point(134, 147)
        Me.txt_linea.MaxLength = 4
        Me.txt_linea.Name = "txt_linea"
        Me.txt_linea.Size = New System.Drawing.Size(44, 20)
        Me.txt_linea.TabIndex = 196
        '
        'txtobservacion_rh
        '
        Me.txtobservacion_rh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobservacion_rh.Location = New System.Drawing.Point(145, 337)
        Me.txtobservacion_rh.Name = "txtobservacion_rh"
        Me.txtobservacion_rh.ReadOnly = True
        Me.txtobservacion_rh.Size = New System.Drawing.Size(408, 20)
        Me.txtobservacion_rh.TabIndex = 198
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(35, 341)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 13)
        Me.Label15.TabIndex = 199
        Me.Label15.Text = "Observacion RH:"
        '
        'txtobsj
        '
        Me.txtobsj.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobsj.Location = New System.Drawing.Point(145, 283)
        Me.txtobsj.Name = "txtobsj"
        Me.txtobsj.ReadOnly = True
        Me.txtobsj.Size = New System.Drawing.Size(408, 20)
        Me.txtobsj.TabIndex = 200
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(35, 287)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 13)
        Me.Label16.TabIndex = 201
        Me.Label16.Text = "Observacion JF:"
        '
        'lblNroOm
        '
        Me.lblNroOm.AutoSize = True
        Me.lblNroOm.Location = New System.Drawing.Point(35, 366)
        Me.lblNroOm.Name = "lblNroOm"
        Me.lblNroOm.Size = New System.Drawing.Size(67, 13)
        Me.lblNroOm.TabIndex = 202
        Me.lblNroOm.Text = "Numero OM:"
        Me.lblNroOm.Visible = False
        '
        'txtNroOm
        '
        Me.txtNroOm.Location = New System.Drawing.Point(144, 363)
        Me.txtNroOm.MaxLength = 8
        Me.txtNroOm.Name = "txtNroOm"
        Me.txtNroOm.Size = New System.Drawing.Size(100, 20)
        Me.txtNroOm.TabIndex = 203
        Me.txtNroOm.Visible = False
        '
        'btnNroOm
        '
        Me.btnNroOm.Location = New System.Drawing.Point(248, 361)
        Me.btnNroOm.Name = "btnNroOm"
        Me.btnNroOm.Size = New System.Drawing.Size(39, 23)
        Me.btnNroOm.TabIndex = 204
        Me.btnNroOm.Text = "..."
        Me.btnNroOm.UseVisualStyleBackColor = True
        Me.btnNroOm.Visible = False
        '
        'btnIncluir
        '
        Me.btnIncluir.Location = New System.Drawing.Point(293, 361)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(88, 23)
        Me.btnIncluir.TabIndex = 205
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = True
        Me.btnIncluir.Visible = False
        '
        'lblTdoc
        '
        Me.lblTdoc.AutoSize = True
        Me.lblTdoc.Location = New System.Drawing.Point(395, 366)
        Me.lblTdoc.Name = "lblTdoc"
        Me.lblTdoc.Size = New System.Drawing.Size(0, 13)
        Me.lblTdoc.TabIndex = 206
        Me.lblTdoc.Visible = False
        '
        'lblSdoc
        '
        Me.lblSdoc.AutoSize = True
        Me.lblSdoc.Location = New System.Drawing.Point(446, 366)
        Me.lblSdoc.Name = "lblSdoc"
        Me.lblSdoc.Size = New System.Drawing.Size(0, 13)
        Me.lblSdoc.TabIndex = 207
        Me.lblSdoc.Visible = False
        '
        'cmbactividad
        '
        Me.cmbactividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbactividad.FormattingEnabled = True
        Me.cmbactividad.Location = New System.Drawing.Point(145, 230)
        Me.cmbactividad.Name = "cmbactividad"
        Me.cmbactividad.Size = New System.Drawing.Size(408, 21)
        Me.cmbactividad.TabIndex = 249
        Me.cmbactividad.Visible = False
        '
        'FormELTBSTiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 620)
        Me.Controls.Add(Me.cmbactividad)
        Me.Controls.Add(Me.lblSdoc)
        Me.Controls.Add(Me.lblTdoc)
        Me.Controls.Add(Me.btnIncluir)
        Me.Controls.Add(Me.btnNroOm)
        Me.Controls.Add(Me.txtNroOm)
        Me.Controls.Add(Me.lblNroOm)
        Me.Controls.Add(Me.txtobsj)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtobservacion_rh)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmb_linea)
        Me.Controls.Add(Me.txt_linea)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtobsjf)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtobs)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btnact)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtact)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtdifhora)
        Me.Controls.Add(Me.dtphoratermino)
        Me.Controls.Add(Me.dtphoragene)
        Me.Controls.Add(Me.dtpfec_termino)
        Me.Controls.Add(Me.dtpfec_inicio)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbc_costo)
        Me.Controls.Add(Me.txtc_costo)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.dgvtiemper)
        Me.Controls.Add(Me.cmbdni)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormELTBSTiem"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormELTBSTiem"
        CType(Me.dgvtiemper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtt_doc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbdni As ComboBox
    Friend WithEvents txtdni As TextBox
    Friend WithEvents dgvtiemper As DataGridView
    Friend WithEvents cmbestado As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents cmbc_costo As ComboBox
    Friend WithEvents txtc_costo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtdifhora As TextBox
    Friend WithEvents dtphoratermino As DateTimePicker
    Friend WithEvents dtphoragene As DateTimePicker
    Friend WithEvents dtpfec_termino As DateTimePicker
    Friend WithEvents dtpfec_inicio As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents txtact As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnact As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtobs As TextBox
    Friend WithEvents dtpfec_gene As DateTimePicker
    Friend WithEvents cmbserie As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbt_doc As ComboBox
    Friend WithEvents btnmod As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtobsjf As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cmb_linea As ComboBox
    Friend WithEvents txt_linea As TextBox
    Friend WithEvents txtobservacion_rh As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents txtobsj As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents lblNroOm As Label
    Friend WithEvents txtNroOm As TextBox
    Friend WithEvents btnNroOm As Button
    Friend WithEvents btnIncluir As Button
    Friend WithEvents lblTdoc As Label
    Friend WithEvents lblSdoc As Label
    Friend WithEvents cmbactividad As ComboBox
End Class
