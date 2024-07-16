<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMantELTBPROGPAGO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantELTBPROGPAGO))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbt_ope = New System.Windows.Forms.ComboBox()
        Me.txtt_ope = New System.Windows.Forms.TextBox()
        Me.dtpfanul = New System.Windows.Forms.DateTimePicker()
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.cmb_serdoc = New System.Windows.Forms.ComboBox()
        Me.cmbt_doc = New System.Windows.Forms.ComboBox()
        Me.txtt_doc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtobservacion = New System.Windows.Forms.TextBox()
        Me.cmb_mon = New System.Windows.Forms.ComboBox()
        Me.txtmon = New System.Windows.Forms.TextBox()
        Me.btncliente = New System.Windows.Forms.Button()
        Me.cmb_ctct_cod = New System.Windows.Forms.ComboBox()
        Me.txtctct_cod = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnro_cheque = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txttcomprad = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txttcompras = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtt_igv_dolar = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtt_igv = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txttprecio_dcompra = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txttprecio_compra = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btndocu = New System.Windows.Forms.Button()
        Me.dgvt_doc = New System.Windows.Forms.DataGridView()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.lstValor = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.npd_perc = New System.Windows.Forms.NumericUpDown()
        Me.chkperc = New System.Windows.Forms.CheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpfec_vigencia = New System.Windows.Forms.DateTimePicker()
        Me.cmb_ext_bank = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmb_flujo_caja = New System.Windows.Forms.ComboBox()
        Me.txtflujo_caja = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtnro_ope = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmb_activ_flujo = New System.Windows.Forms.ComboBox()
        Me.txtact_flujo = New System.Windows.Forms.TextBox()
        Me.cmb_cobra = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtcbco = New System.Windows.Forms.TextBox()
        Me.cmb_ccbco = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpfec_prov = New System.Windows.Forms.DateTimePicker()
        Me.npdtcamb = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox3.SuspendLayout()
        Me.tsbForm.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.npd_perc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdtcamb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Tipo Documento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(720, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "Estado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(622, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(535, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Numero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(442, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Serie"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbt_ope)
        Me.GroupBox3.Controls.Add(Me.txtt_ope)
        Me.GroupBox3.Controls.Add(Me.dtpfanul)
        Me.GroupBox3.Controls.Add(Me.cmbestado)
        Me.GroupBox3.Controls.Add(Me.dtpfecha)
        Me.GroupBox3.Controls.Add(Me.txtnumero)
        Me.GroupBox3.Controls.Add(Me.cmb_serdoc)
        Me.GroupBox3.Controls.Add(Me.cmbt_doc)
        Me.GroupBox3.Controls.Add(Me.txtt_doc)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(917, 42)
        Me.GroupBox3.TabIndex = 103
        Me.GroupBox3.TabStop = False
        '
        'cmbt_ope
        '
        Me.cmbt_ope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbt_ope.FormattingEnabled = True
        Me.cmbt_ope.Items.AddRange(New Object() {"PROCESO DE PAGO"})
        Me.cmbt_ope.Location = New System.Drawing.Point(47, 14)
        Me.cmbt_ope.Name = "cmbt_ope"
        Me.cmbt_ope.Size = New System.Drawing.Size(150, 21)
        Me.cmbt_ope.TabIndex = 2
        '
        'txtt_ope
        '
        Me.txtt_ope.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtt_ope.Location = New System.Drawing.Point(4, 14)
        Me.txtt_ope.Name = "txtt_ope"
        Me.txtt_ope.Size = New System.Drawing.Size(40, 20)
        Me.txtt_ope.TabIndex = 1
        '
        'dtpfanul
        '
        Me.dtpfanul.Checked = False
        Me.dtpfanul.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfanul.Location = New System.Drawing.Point(804, 15)
        Me.dtpfanul.Name = "dtpfanul"
        Me.dtpfanul.ShowCheckBox = True
        Me.dtpfanul.Size = New System.Drawing.Size(106, 20)
        Me.dtpfanul.TabIndex = 9
        '
        'cmbestado
        '
        Me.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"Habilitado ", "Anulado"})
        Me.cmbestado.Location = New System.Drawing.Point(710, 14)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(86, 21)
        Me.cmbestado.TabIndex = 8
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(617, 14)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(82, 20)
        Me.dtpfecha.TabIndex = 7
        '
        'txtnumero
        '
        Me.txtnumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnumero.Location = New System.Drawing.Point(523, 14)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(78, 20)
        Me.txtnumero.TabIndex = 6
        '
        'cmb_serdoc
        '
        Me.cmb_serdoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_serdoc.FormattingEnabled = True
        Me.cmb_serdoc.Items.AddRange(New Object() {"2019", "2020", "2021", "2022", "2023"})
        Me.cmb_serdoc.Location = New System.Drawing.Point(433, 14)
        Me.cmb_serdoc.Name = "cmb_serdoc"
        Me.cmb_serdoc.Size = New System.Drawing.Size(71, 21)
        Me.cmb_serdoc.TabIndex = 5
        '
        'cmbt_doc
        '
        Me.cmbt_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbt_doc.FormattingEnabled = True
        Me.cmbt_doc.Items.AddRange(New Object() {"PROCESO DE PAGO"})
        Me.cmbt_doc.Location = New System.Drawing.Point(257, 14)
        Me.cmbt_doc.Name = "cmbt_doc"
        Me.cmbt_doc.Size = New System.Drawing.Size(161, 21)
        Me.cmbt_doc.TabIndex = 4
        '
        'txtt_doc
        '
        Me.txtt_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtt_doc.Location = New System.Drawing.Point(214, 14)
        Me.txtt_doc.Name = "txtt_doc"
        Me.txtt_doc.Size = New System.Drawing.Size(40, 20)
        Me.txtt_doc.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(815, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "F. Anulacion"
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbimprimir, Me.ToolStripButton1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(936, 25)
        Me.tsbForm.TabIndex = 109
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
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(7, 135)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 16)
        Me.Label18.TabIndex = 111
        Me.Label18.Text = "Concepto"
        '
        'txtobservacion
        '
        Me.txtobservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobservacion.Location = New System.Drawing.Point(78, 134)
        Me.txtobservacion.Name = "txtobservacion"
        Me.txtobservacion.Size = New System.Drawing.Size(470, 20)
        Me.txtobservacion.TabIndex = 19
        '
        'cmb_mon
        '
        Me.cmb_mon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mon.FormattingEnabled = True
        Me.cmb_mon.Location = New System.Drawing.Point(464, 79)
        Me.cmb_mon.Name = "cmb_mon"
        Me.cmb_mon.Size = New System.Drawing.Size(161, 21)
        Me.cmb_mon.TabIndex = 13
        '
        'txtmon
        '
        Me.txtmon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmon.Location = New System.Drawing.Point(427, 79)
        Me.txtmon.Name = "txtmon"
        Me.txtmon.Size = New System.Drawing.Size(34, 20)
        Me.txtmon.TabIndex = 12
        '
        'btncliente
        '
        Me.btncliente.Location = New System.Drawing.Point(701, 106)
        Me.btncliente.Name = "btncliente"
        Me.btncliente.Size = New System.Drawing.Size(39, 23)
        Me.btncliente.TabIndex = 17
        Me.btncliente.Text = "..."
        Me.btncliente.UseVisualStyleBackColor = True
        '
        'cmb_ctct_cod
        '
        Me.cmb_ctct_cod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ctct_cod.FormattingEnabled = True
        Me.cmb_ctct_cod.Location = New System.Drawing.Point(173, 107)
        Me.cmb_ctct_cod.Name = "cmb_ctct_cod"
        Me.cmb_ctct_cod.Size = New System.Drawing.Size(527, 21)
        Me.cmb_ctct_cod.TabIndex = 16
        '
        'txtctct_cod
        '
        Me.txtctct_cod.Location = New System.Drawing.Point(78, 107)
        Me.txtctct_cod.Name = "txtctct_cod"
        Me.txtctct_cod.Size = New System.Drawing.Size(89, 20)
        Me.txtctct_cod.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(5, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 16)
        Me.Label13.TabIndex = 133
        Me.Label13.Text = "Proveedor"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(367, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 16)
        Me.Label12.TabIndex = 130
        Me.Label12.Text = "Moneda"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(749, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Fec. Prog."
        '
        'txtnro_cheque
        '
        Me.txtnro_cheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnro_cheque.Location = New System.Drawing.Point(639, 134)
        Me.txtnro_cheque.MaxLength = 10
        Me.txtnro_cheque.Name = "txtnro_cheque"
        Me.txtnro_cheque.Size = New System.Drawing.Size(99, 20)
        Me.txtnro_cheque.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(554, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 16)
        Me.Label9.TabIndex = 140
        Me.Label9.Text = "Nro. Cheque"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.txttcomprad)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.txttcompras)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.txtt_igv_dolar)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.txtt_igv)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txttprecio_dcompra)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txttprecio_compra)
        Me.GroupBox4.Location = New System.Drawing.Point(4, 239)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(925, 122)
        Me.GroupBox4.TabIndex = 141
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Totales"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(640, 72)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(81, 16)
        Me.Label24.TabIndex = 51
        Me.Label24.Text = "Compra ($/.)"
        '
        'txttcomprad
        '
        Me.txttcomprad.Location = New System.Drawing.Point(611, 91)
        Me.txttcomprad.Name = "txttcomprad"
        Me.txttcomprad.ReadOnly = True
        Me.txttcomprad.Size = New System.Drawing.Size(139, 20)
        Me.txttcomprad.TabIndex = 50
        Me.txttcomprad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(638, 19)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(83, 16)
        Me.Label23.TabIndex = 49
        Me.Label23.Text = "Compra (S/.)"
        '
        'txttcompras
        '
        Me.txttcompras.Location = New System.Drawing.Point(611, 38)
        Me.txttcompras.Name = "txttcompras"
        Me.txttcompras.ReadOnly = True
        Me.txttcompras.Size = New System.Drawing.Size(139, 20)
        Me.txttcompras.TabIndex = 48
        Me.txttcompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(427, 72)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(89, 16)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "Total IGV ($/.)"
        '
        'txtt_igv_dolar
        '
        Me.txtt_igv_dolar.Location = New System.Drawing.Point(403, 91)
        Me.txtt_igv_dolar.Name = "txtt_igv_dolar"
        Me.txtt_igv_dolar.ReadOnly = True
        Me.txtt_igv_dolar.Size = New System.Drawing.Size(146, 20)
        Me.txtt_igv_dolar.TabIndex = 46
        Me.txtt_igv_dolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(427, 19)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(91, 16)
        Me.Label21.TabIndex = 45
        Me.Label21.Text = "Total IGV (S/.)"
        '
        'txtt_igv
        '
        Me.txtt_igv.Location = New System.Drawing.Point(403, 38)
        Me.txtt_igv.Name = "txtt_igv"
        Me.txtt_igv.ReadOnly = True
        Me.txtt_igv.Size = New System.Drawing.Size(146, 20)
        Me.txtt_igv.TabIndex = 44
        Me.txtt_igv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(219, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 16)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Compra Total ($/.)"
        '
        'txttprecio_dcompra
        '
        Me.txttprecio_dcompra.Location = New System.Drawing.Point(204, 91)
        Me.txttprecio_dcompra.Name = "txttprecio_dcompra"
        Me.txttprecio_dcompra.ReadOnly = True
        Me.txttprecio_dcompra.Size = New System.Drawing.Size(142, 20)
        Me.txttprecio_dcompra.TabIndex = 38
        Me.txttprecio_dcompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(219, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 16)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Compra Total (S/.)"
        '
        'txttprecio_compra
        '
        Me.txttprecio_compra.Location = New System.Drawing.Point(204, 38)
        Me.txttprecio_compra.Name = "txttprecio_compra"
        Me.txttprecio_compra.ReadOnly = True
        Me.txttprecio_compra.Size = New System.Drawing.Size(142, 20)
        Me.txttprecio_compra.TabIndex = 26
        Me.txttprecio_compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btndocu)
        Me.GroupBox1.Controls.Add(Me.dgvt_doc)
        Me.GroupBox1.Controls.Add(Me.btnborrar)
        Me.GroupBox1.Controls.Add(Me.btnmodificar)
        Me.GroupBox1.Controls.Add(Me.btnagregar)
        Me.GroupBox1.Controls.Add(Me.lstValor)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 357)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(926, 237)
        Me.GroupBox1.TabIndex = 142
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(832, 167)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 23)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Doc. Re/Pag"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(832, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Docum. Liq."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btndocu
        '
        Me.btndocu.Location = New System.Drawing.Point(832, 109)
        Me.btndocu.Name = "btndocu"
        Me.btndocu.Size = New System.Drawing.Size(81, 23)
        Me.btndocu.TabIndex = 30
        Me.btndocu.Text = "Docum. Prov"
        Me.btndocu.UseVisualStyleBackColor = True
        '
        'dgvt_doc
        '
        Me.dgvt_doc.AllowUserToAddRows = False
        Me.dgvt_doc.AllowUserToDeleteRows = False
        Me.dgvt_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc.Location = New System.Drawing.Point(7, 22)
        Me.dgvt_doc.Name = "dgvt_doc"
        Me.dgvt_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc.Size = New System.Drawing.Size(812, 208)
        Me.dgvt_doc.TabIndex = 31
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(832, 80)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(81, 23)
        Me.btnborrar.TabIndex = 29
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(832, 51)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(81, 23)
        Me.btnmodificar.TabIndex = 28
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(832, 22)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(81, 23)
        Me.btnagregar.TabIndex = 27
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'lstValor
        '
        Me.lstValor.FormattingEnabled = True
        Me.lstValor.Location = New System.Drawing.Point(230, 47)
        Me.lstValor.Name = "lstValor"
        Me.lstValor.Size = New System.Drawing.Size(251, 147)
        Me.lstValor.TabIndex = 34
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.npdtcamb)
        Me.GroupBox2.Controls.Add(Me.npd_perc)
        Me.GroupBox2.Controls.Add(Me.chkperc)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.dtpfec_vigencia)
        Me.GroupBox2.Controls.Add(Me.cmb_ext_bank)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.cmb_flujo_caja)
        Me.GroupBox2.Controls.Add(Me.txtflujo_caja)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtnro_ope)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.cmb_activ_flujo)
        Me.GroupBox2.Controls.Add(Me.txtact_flujo)
        Me.GroupBox2.Controls.Add(Me.cmb_cobra)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtcbco)
        Me.GroupBox2.Controls.Add(Me.cmb_ccbco)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtobservacion)
        Me.GroupBox2.Controls.Add(Me.txtctct_cod)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.cmb_ctct_cod)
        Me.GroupBox2.Controls.Add(Me.txtnro_cheque)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.btncliente)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmb_mon)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.dtpfec_prov)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtmon)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(926, 216)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        '
        'npd_perc
        '
        Me.npd_perc.DecimalPlaces = 3
        Me.npd_perc.Enabled = False
        Me.npd_perc.Location = New System.Drawing.Point(505, 186)
        Me.npd_perc.Name = "npd_perc"
        Me.npd_perc.Size = New System.Drawing.Size(120, 20)
        Me.npd_perc.TabIndex = 160
        '
        'chkperc
        '
        Me.chkperc.AutoSize = True
        Me.chkperc.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkperc.Location = New System.Drawing.Point(413, 189)
        Me.chkperc.Name = "chkperc"
        Me.chkperc.Size = New System.Drawing.Size(80, 17)
        Me.chkperc.TabIndex = 159
        Me.chkperc.Text = "Percepcion"
        Me.chkperc.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(200, 189)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(73, 16)
        Me.Label25.TabIndex = 158
        Me.Label25.Text = "Fec.Banco"
        '
        'dtpfec_vigencia
        '
        Me.dtpfec_vigencia.Checked = False
        Me.dtpfec_vigencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_vigencia.Location = New System.Drawing.Point(279, 188)
        Me.dtpfec_vigencia.Name = "dtpfec_vigencia"
        Me.dtpfec_vigencia.ShowCheckBox = True
        Me.dtpfec_vigencia.Size = New System.Drawing.Size(116, 20)
        Me.dtpfec_vigencia.TabIndex = 27
        '
        'cmb_ext_bank
        '
        Me.cmb_ext_bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ext_bank.FormattingEnabled = True
        Me.cmb_ext_bank.Items.AddRange(New Object() {"COBRADO", "PENDIENTE"})
        Me.cmb_ext_bank.Location = New System.Drawing.Point(812, 135)
        Me.cmb_ext_bank.Name = "cmb_ext_bank"
        Me.cmb_ext_bank.Size = New System.Drawing.Size(110, 21)
        Me.cmb_ext_bank.TabIndex = 21
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(740, 136)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 16)
        Me.Label20.TabIndex = 156
        Me.Label20.Text = "Ext.Banco"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(323, 161)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 16)
        Me.Label17.TabIndex = 153
        Me.Label17.Text = "Flujo.Caja"
        '
        'cmb_flujo_caja
        '
        Me.cmb_flujo_caja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_flujo_caja.FormattingEnabled = True
        Me.cmb_flujo_caja.Location = New System.Drawing.Point(430, 160)
        Me.cmb_flujo_caja.Name = "cmb_flujo_caja"
        Me.cmb_flujo_caja.Size = New System.Drawing.Size(492, 21)
        Me.cmb_flujo_caja.TabIndex = 25
        '
        'txtflujo_caja
        '
        Me.txtflujo_caja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtflujo_caja.Location = New System.Drawing.Point(394, 160)
        Me.txtflujo_caja.Name = "txtflujo_caja"
        Me.txtflujo_caja.Size = New System.Drawing.Size(34, 20)
        Me.txtflujo_caja.TabIndex = 24
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 161)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 16)
        Me.Label16.TabIndex = 150
        Me.Label16.Text = "Activ.Flujo"
        '
        'txtnro_ope
        '
        Me.txtnro_ope.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnro_ope.Location = New System.Drawing.Point(95, 186)
        Me.txtnro_ope.MaxLength = 10
        Me.txtnro_ope.Name = "txtnro_ope"
        Me.txtnro_ope.Size = New System.Drawing.Size(99, 20)
        Me.txtnro_ope.TabIndex = 26
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 187)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 16)
        Me.Label19.TabIndex = 155
        Me.Label19.Text = "Nro. Operac"
        '
        'cmb_activ_flujo
        '
        Me.cmb_activ_flujo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_activ_flujo.FormattingEnabled = True
        Me.cmb_activ_flujo.Location = New System.Drawing.Point(115, 160)
        Me.cmb_activ_flujo.Name = "cmb_activ_flujo"
        Me.cmb_activ_flujo.Size = New System.Drawing.Size(202, 21)
        Me.cmb_activ_flujo.TabIndex = 23
        '
        'txtact_flujo
        '
        Me.txtact_flujo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtact_flujo.Location = New System.Drawing.Point(77, 160)
        Me.txtact_flujo.Name = "txtact_flujo"
        Me.txtact_flujo.Size = New System.Drawing.Size(34, 20)
        Me.txtact_flujo.TabIndex = 22
        '
        'cmb_cobra
        '
        Me.cmb_cobra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cobra.FormattingEnabled = True
        Me.cmb_cobra.Items.AddRange(New Object() {"CANCELADO", "NO CANCELADO", "LETRAS EN CARTERA ACEPTADA", "LETRAS COBRANZA LIBRE", "LETRA COBRANZA LIBRE", "LETRAS PROTESTADAS", "LETRAS RENOBADAS", "ABANCES ENCUESTAS", "PAGA PARCIAL"})
        Me.cmb_cobra.Location = New System.Drawing.Point(701, 79)
        Me.cmb_cobra.Name = "cmb_cobra"
        Me.cmb_cobra.Size = New System.Drawing.Size(218, 21)
        Me.cmb_cobra.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(631, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 16)
        Me.Label15.TabIndex = 146
        Me.Label15.Text = "Cobranza"
        '
        'txtcbco
        '
        Me.txtcbco.Location = New System.Drawing.Point(65, 80)
        Me.txtcbco.Name = "txtcbco"
        Me.txtcbco.Size = New System.Drawing.Size(34, 20)
        Me.txtcbco.TabIndex = 10
        '
        'cmb_ccbco
        '
        Me.cmb_ccbco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ccbco.FormattingEnabled = True
        Me.cmb_ccbco.Location = New System.Drawing.Point(102, 80)
        Me.cmb_ccbco.Name = "cmb_ccbco"
        Me.cmb_ccbco.Size = New System.Drawing.Size(261, 21)
        Me.cmb_ccbco.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = "Banco"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 16)
        Me.Label10.TabIndex = 142
        Me.Label10.Text = "Tipo Operacion"
        '
        'dtpfec_prov
        '
        Me.dtpfec_prov.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_prov.Location = New System.Drawing.Point(821, 109)
        Me.dtpfec_prov.Name = "dtpfec_prov"
        Me.dtpfec_prov.Size = New System.Drawing.Size(101, 20)
        Me.dtpfec_prov.TabIndex = 18
        '
        'npdtcamb
        '
        Me.npdtcamb.DecimalPlaces = 3
        Me.npdtcamb.Enabled = False
        Me.npdtcamb.Location = New System.Drawing.Point(821, 186)
        Me.npdtcamb.Name = "npdtcamb"
        Me.npdtcamb.ReadOnly = True
        Me.npdtcamb.Size = New System.Drawing.Size(99, 20)
        Me.npdtcamb.TabIndex = 161
        '
        'FormMantELTBPROGPAGO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 599)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.tsbForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormMantELTBPROGPAGO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMantELTBPROGPAGO"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.npd_perc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdtcamb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbestado As ComboBox
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents cmb_serdoc As ComboBox
    Friend WithEvents cmbt_doc As ComboBox
    Friend WithEvents txtt_doc As TextBox
    Friend WithEvents dtpfanul As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents Label18 As Label
    Friend WithEvents txtobservacion As TextBox
    Friend WithEvents cmb_mon As ComboBox
    Friend WithEvents txtmon As TextBox
    Friend WithEvents btncliente As Button
    Friend WithEvents cmb_ctct_cod As ComboBox
    Friend WithEvents txtctct_cod As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnro_cheque As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txttcomprad As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txttcompras As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtt_igv_dolar As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtt_igv As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txttprecio_dcompra As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txttprecio_compra As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btndocu As Button
    Friend WithEvents dgvt_doc As DataGridView
    Friend WithEvents btnborrar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents lstValor As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpfec_prov As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbt_ope As ComboBox
    Friend WithEvents txtt_ope As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents cmb_ext_bank As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtnro_ope As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmb_flujo_caja As ComboBox
    Friend WithEvents txtflujo_caja As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cmb_activ_flujo As ComboBox
    Friend WithEvents txtact_flujo As TextBox
    Friend WithEvents cmb_cobra As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtcbco As TextBox
    Friend WithEvents cmb_ccbco As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpfec_vigencia As DateTimePicker
    Friend WithEvents chkperc As CheckBox
    Friend WithEvents npd_perc As NumericUpDown
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents npdtcamb As NumericUpDown
End Class
