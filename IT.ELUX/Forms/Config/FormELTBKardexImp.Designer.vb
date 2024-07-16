<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormELTBKardexImp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormELTBKardexImp))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.cmb_serdoc = New System.Windows.Forms.ComboBox()
        Me.cmbt_doc = New System.Windows.Forms.ComboBox()
        Me.txtt_doc = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtobservacion = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btndocu = New System.Windows.Forms.Button()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.dgvt_doc = New System.Windows.Forms.DataGridView()
        Me.lstValor = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbmon = New System.Windows.Forms.ComboBox()
        Me.txtmon = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnumdua = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpfecdua = New System.Windows.Forms.DateTimePicker()
        Me.txt_nrofactimp = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpfecnro = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtajuste = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txttcomprad = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txttcompras = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtt_igv_dolar = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtt_igv = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtt_dcto_dolar = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtt_dcto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txttprecio_dcompra = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txttprecio_compra = New System.Windows.Forms.TextBox()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.txtnomproveedor = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtnro_oreq = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbsguia = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtnguia = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.tsbForm.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Tipo Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(404, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Serie"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(482, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Numero"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(582, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Fecha"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(689, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Estado"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbestado)
        Me.GroupBox3.Controls.Add(Me.dtpfecha)
        Me.GroupBox3.Controls.Add(Me.txtnumero)
        Me.GroupBox3.Controls.Add(Me.cmb_serdoc)
        Me.GroupBox3.Controls.Add(Me.cmbt_doc)
        Me.GroupBox3.Controls.Add(Me.txtt_doc)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(775, 42)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'cmbestado
        '
        Me.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"Activo", "Anulado"})
        Me.cmbestado.Location = New System.Drawing.Point(650, 12)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(107, 21)
        Me.cmbestado.TabIndex = 6
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(554, 15)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(82, 20)
        Me.dtpfecha.TabIndex = 5
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(461, 15)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.ReadOnly = True
        Me.txtnumero.Size = New System.Drawing.Size(78, 20)
        Me.txtnumero.TabIndex = 4
        '
        'cmb_serdoc
        '
        Me.cmb_serdoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_serdoc.FormattingEnabled = True
        Me.cmb_serdoc.Items.AddRange(New Object() {"2019", "2020", "2021", "2022", "2023"})
        Me.cmb_serdoc.Location = New System.Drawing.Point(375, 14)
        Me.cmb_serdoc.Name = "cmb_serdoc"
        Me.cmb_serdoc.Size = New System.Drawing.Size(71, 21)
        Me.cmb_serdoc.TabIndex = 3
        '
        'cmbt_doc
        '
        Me.cmbt_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbt_doc.FormattingEnabled = True
        Me.cmbt_doc.Items.AddRange(New Object() {"DOCUMENTOS IMPORTACION"})
        Me.cmbt_doc.Location = New System.Drawing.Point(53, 15)
        Me.cmbt_doc.Name = "cmbt_doc"
        Me.cmbt_doc.Size = New System.Drawing.Size(301, 21)
        Me.cmbt_doc.TabIndex = 2
        '
        'txtt_doc
        '
        Me.txtt_doc.Location = New System.Drawing.Point(6, 15)
        Me.txtt_doc.Name = "txtt_doc"
        Me.txtt_doc.Size = New System.Drawing.Size(40, 20)
        Me.txtt_doc.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 149)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 16)
        Me.Label13.TabIndex = 108
        Me.Label13.Text = "Proveedor"
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbimprimir, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(801, 25)
        Me.tsbForm.TabIndex = 111
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
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(15, 182)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 16)
        Me.Label18.TabIndex = 113
        Me.Label18.Text = "Observaciones"
        '
        'txtobservacion
        '
        Me.txtobservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobservacion.Location = New System.Drawing.Point(121, 181)
        Me.txtobservacion.Name = "txtobservacion"
        Me.txtobservacion.Size = New System.Drawing.Size(660, 20)
        Me.txtobservacion.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btndocu)
        Me.GroupBox1.Controls.Add(Me.btnborrar)
        Me.GroupBox1.Controls.Add(Me.btnmodificar)
        Me.GroupBox1.Controls.Add(Me.dgvt_doc)
        Me.GroupBox1.Controls.Add(Me.lstValor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 371)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 243)
        Me.GroupBox1.TabIndex = 114
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(678, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Borrar Todo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(679, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Costeo Imp."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btndocu
        '
        Me.btndocu.Location = New System.Drawing.Point(679, 77)
        Me.btndocu.Name = "btndocu"
        Me.btndocu.Size = New System.Drawing.Size(81, 23)
        Me.btndocu.TabIndex = 20
        Me.btndocu.Text = "Docum."
        Me.btndocu.UseVisualStyleBackColor = True
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(679, 19)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(81, 23)
        Me.btnborrar.TabIndex = 18
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(680, 19)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(81, 23)
        Me.btnmodificar.TabIndex = 28
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'dgvt_doc
        '
        Me.dgvt_doc.AllowUserToAddRows = False
        Me.dgvt_doc.AllowUserToDeleteRows = False
        Me.dgvt_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc.Location = New System.Drawing.Point(6, 19)
        Me.dgvt_doc.Name = "dgvt_doc"
        Me.dgvt_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc.Size = New System.Drawing.Size(666, 208)
        Me.dgvt_doc.TabIndex = 31
        '
        'lstValor
        '
        Me.lstValor.FormattingEnabled = True
        Me.lstValor.Location = New System.Drawing.Point(333, 48)
        Me.lstValor.Name = "lstValor"
        Me.lstValor.Size = New System.Drawing.Size(251, 147)
        Me.lstValor.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(666, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 16)
        Me.Label12.TabIndex = 118
        Me.Label12.Text = "Moneda"
        '
        'cmbmon
        '
        Me.cmbmon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmon.FormattingEnabled = True
        Me.cmbmon.Location = New System.Drawing.Point(685, 111)
        Me.cmbmon.Name = "cmbmon"
        Me.cmbmon.Size = New System.Drawing.Size(97, 21)
        Me.cmbmon.TabIndex = 12
        '
        'txtmon
        '
        Me.txtmon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmon.Location = New System.Drawing.Point(645, 111)
        Me.txtmon.Name = "txtmon"
        Me.txtmon.Size = New System.Drawing.Size(34, 20)
        Me.txtmon.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 35)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "Num. Dua"
        '
        'txtnumdua
        '
        Me.txtnumdua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnumdua.Location = New System.Drawing.Point(64, 111)
        Me.txtnumdua.Name = "txtnumdua"
        Me.txtnumdua.ReadOnly = True
        Me.txtnumdua.Size = New System.Drawing.Size(93, 20)
        Me.txtnumdua.TabIndex = 7
        Me.txtnumdua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(167, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 35)
        Me.Label6.TabIndex = 121
        Me.Label6.Text = "Fec. Dua."
        '
        'dtpfecdua
        '
        Me.dtpfecdua.Enabled = False
        Me.dtpfecdua.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecdua.Location = New System.Drawing.Point(215, 111)
        Me.dtpfecdua.Name = "dtpfecdua"
        Me.dtpfecdua.Size = New System.Drawing.Size(82, 20)
        Me.dtpfecdua.TabIndex = 8
        '
        'txt_nrofactimp
        '
        Me.txt_nrofactimp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nrofactimp.Location = New System.Drawing.Point(378, 111)
        Me.txt_nrofactimp.Name = "txt_nrofactimp"
        Me.txt_nrofactimp.Size = New System.Drawing.Size(93, 20)
        Me.txt_nrofactimp.TabIndex = 9
        Me.txt_nrofactimp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(305, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 34)
        Me.Label8.TabIndex = 122
        Me.Label8.Text = "Num. Invoice."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpfecnro
        '
        Me.dtpfecnro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecnro.Location = New System.Drawing.Point(556, 111)
        Me.dtpfecnro.Name = "dtpfecnro"
        Me.dtpfecnro.Size = New System.Drawing.Size(82, 20)
        Me.dtpfecnro.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(477, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 34)
        Me.Label9.TabIndex = 125
        Me.Label9.Text = "Fec. Invoice"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtajuste)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.txttcomprad)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.txttcompras)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.txtt_igv_dolar)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.txtt_igv)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.txtt_dcto_dolar)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.txtt_dcto)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txttprecio_dcompra)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txttprecio_compra)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 239)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(769, 126)
        Me.GroupBox4.TabIndex = 126
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Totales"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(696, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 16)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Ajuste"
        '
        'txtajuste
        '
        Me.txtajuste.BackColor = System.Drawing.Color.LightGreen
        Me.txtajuste.Location = New System.Drawing.Point(668, 63)
        Me.txtajuste.Name = "txtajuste"
        Me.txtajuste.ReadOnly = True
        Me.txtajuste.Size = New System.Drawing.Size(95, 20)
        Me.txtajuste.TabIndex = 52
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(549, 67)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(81, 16)
        Me.Label24.TabIndex = 51
        Me.Label24.Text = "Compra ($/.)"
        '
        'txttcomprad
        '
        Me.txttcomprad.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txttcomprad.Location = New System.Drawing.Point(520, 86)
        Me.txttcomprad.Name = "txttcomprad"
        Me.txttcomprad.ReadOnly = True
        Me.txttcomprad.Size = New System.Drawing.Size(139, 20)
        Me.txttcomprad.TabIndex = 50
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(547, 15)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(83, 16)
        Me.Label23.TabIndex = 49
        Me.Label23.Text = "Compra (S/.)"
        '
        'txttcompras
        '
        Me.txttcompras.BackColor = System.Drawing.Color.LightGreen
        Me.txttcompras.Location = New System.Drawing.Point(520, 34)
        Me.txttcompras.Name = "txttcompras"
        Me.txttcompras.ReadOnly = True
        Me.txttcompras.Size = New System.Drawing.Size(139, 20)
        Me.txttcompras.TabIndex = 48
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(382, 67)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(89, 16)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "Total IGV ($/.)"
        '
        'txtt_igv_dolar
        '
        Me.txtt_igv_dolar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtt_igv_dolar.Location = New System.Drawing.Point(358, 86)
        Me.txtt_igv_dolar.Name = "txtt_igv_dolar"
        Me.txtt_igv_dolar.ReadOnly = True
        Me.txtt_igv_dolar.Size = New System.Drawing.Size(146, 20)
        Me.txtt_igv_dolar.TabIndex = 46
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(382, 15)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(91, 16)
        Me.Label21.TabIndex = 45
        Me.Label21.Text = "Total IGV (S/.)"
        '
        'txtt_igv
        '
        Me.txtt_igv.BackColor = System.Drawing.Color.LightGreen
        Me.txtt_igv.Location = New System.Drawing.Point(358, 34)
        Me.txtt_igv.Name = "txtt_igv"
        Me.txtt_igv.ReadOnly = True
        Me.txtt_igv.Size = New System.Drawing.Size(146, 20)
        Me.txtt_igv.TabIndex = 44
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(207, 67)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(98, 16)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Descuento ($/.)"
        '
        'txtt_dcto_dolar
        '
        Me.txtt_dcto_dolar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtt_dcto_dolar.Location = New System.Drawing.Point(173, 86)
        Me.txtt_dcto_dolar.Name = "txtt_dcto_dolar"
        Me.txtt_dcto_dolar.ReadOnly = True
        Me.txtt_dcto_dolar.Size = New System.Drawing.Size(168, 20)
        Me.txtt_dcto_dolar.TabIndex = 42
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(204, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 16)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Descuento (S/.)"
        '
        'txtt_dcto
        '
        Me.txtt_dcto.BackColor = System.Drawing.Color.LightGreen
        Me.txtt_dcto.Location = New System.Drawing.Point(170, 34)
        Me.txtt_dcto.Name = "txtt_dcto"
        Me.txtt_dcto.ReadOnly = True
        Me.txtt_dcto.Size = New System.Drawing.Size(168, 20)
        Me.txtt_dcto.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 16)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Compra Total ($/.)"
        '
        'txttprecio_dcompra
        '
        Me.txttprecio_dcompra.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txttprecio_dcompra.Location = New System.Drawing.Point(6, 86)
        Me.txttprecio_dcompra.Name = "txttprecio_dcompra"
        Me.txttprecio_dcompra.ReadOnly = True
        Me.txttprecio_dcompra.Size = New System.Drawing.Size(142, 20)
        Me.txttprecio_dcompra.TabIndex = 38
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(21, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 16)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Compra Total (S/.)"
        '
        'txttprecio_compra
        '
        Me.txttprecio_compra.BackColor = System.Drawing.Color.LightGreen
        Me.txttprecio_compra.Location = New System.Drawing.Point(6, 34)
        Me.txttprecio_compra.Name = "txttprecio_compra"
        Me.txttprecio_compra.ReadOnly = True
        Me.txttprecio_compra.Size = New System.Drawing.Size(142, 20)
        Me.txttprecio_compra.TabIndex = 26
        '
        'txtproveedor
        '
        Me.txtproveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtproveedor.Location = New System.Drawing.Point(93, 149)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(82, 20)
        Me.txtproveedor.TabIndex = 13
        '
        'txtnomproveedor
        '
        Me.txtnomproveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnomproveedor.Location = New System.Drawing.Point(181, 149)
        Me.txtnomproveedor.Name = "txtnomproveedor"
        Me.txtnomproveedor.ReadOnly = True
        Me.txtnomproveedor.Size = New System.Drawing.Size(447, 20)
        Me.txtnomproveedor.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(634, 149)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 16)
        Me.Label15.TabIndex = 127
        Me.Label15.Text = "Oreq."
        '
        'txtnro_oreq
        '
        Me.txtnro_oreq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnro_oreq.Location = New System.Drawing.Point(678, 149)
        Me.txtnro_oreq.Name = "txtnro_oreq"
        Me.txtnro_oreq.ReadOnly = True
        Me.txtnro_oreq.Size = New System.Drawing.Size(104, 20)
        Me.txtnro_oreq.TabIndex = 128
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(634, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 129
        Me.Label16.Text = "Label16"
        Me.Label16.Visible = False
        '
        'cmbsguia
        '
        Me.cmbsguia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsguia.FormattingEnabled = True
        Me.cmbsguia.Items.AddRange(New Object() {"", "ALM", "001", "002", "003", "ENS", "PRO", "TWO"})
        Me.cmbsguia.Location = New System.Drawing.Point(73, 209)
        Me.cmbsguia.Name = "cmbsguia"
        Me.cmbsguia.Size = New System.Drawing.Size(73, 21)
        Me.cmbsguia.TabIndex = 16
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(152, 212)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(44, 13)
        Me.Label34.TabIndex = 133
        Me.Label34.Text = "Numero"
        '
        'txtnguia
        '
        Me.txtnguia.Location = New System.Drawing.Point(202, 209)
        Me.txtnguia.MaxLength = 12
        Me.txtnguia.Multiline = True
        Me.txtnguia.Name = "txtnguia"
        Me.txtnguia.Size = New System.Drawing.Size(84, 21)
        Me.txtnguia.TabIndex = 17
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(15, 212)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(56, 13)
        Me.Label35.TabIndex = 132
        Me.Label35.Text = "Guia Serie"
        '
        'FormELTBKardexImp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 628)
        Me.Controls.Add(Me.cmbsguia)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.txtnguia)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtnro_oreq)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtproveedor)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.txtnomproveedor)
        Me.Controls.Add(Me.dtpfecnro)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_nrofactimp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpfecdua)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnumdua)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbmon)
        Me.Controls.Add(Me.txtmon)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtobservacion)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormELTBKardexImp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormELTBKardexImp"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbestado As ComboBox
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents cmb_serdoc As ComboBox
    Friend WithEvents cmbt_doc As ComboBox
    Friend WithEvents txtt_doc As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents Label18 As Label
    Friend WithEvents txtobservacion As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btndocu As Button
    Friend WithEvents dgvt_doc As DataGridView
    Friend WithEvents btnborrar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents lstValor As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbmon As ComboBox
    Friend WithEvents txtmon As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnumdua As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpfecdua As DateTimePicker
    Friend WithEvents txt_nrofactimp As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpfecnro As DateTimePicker
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
    Friend WithEvents Label20 As Label
    Friend WithEvents txtt_dcto_dolar As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtt_dcto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txttprecio_dcompra As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txttprecio_compra As TextBox
    Friend WithEvents txtproveedor As TextBox
    Friend WithEvents txtnomproveedor As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents txtajuste As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtnro_oreq As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cmbsguia As ComboBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtnguia As TextBox
    Friend WithEvents Label35 As Label
End Class
