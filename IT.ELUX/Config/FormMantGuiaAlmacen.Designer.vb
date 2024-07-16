<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMantGuiaAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantGuiaAlmacen))
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbalmacen = New System.Windows.Forms.ComboBox()
        Me.chk_m = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbdni = New System.Windows.Forms.ComboBox()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtobservacion = New System.Windows.Forms.TextBox()
        Me.cmbdir = New System.Windows.Forms.ComboBox()
        Me.txtdir = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbproveedor = New System.Windows.Forms.ComboBox()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbc_costo = New System.Windows.Forms.ComboBox()
        Me.txtc_costo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbmon = New System.Windows.Forms.ComboBox()
        Me.txtmon = New System.Windows.Forms.TextBox()
        Me.txtfor_ent = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtt_movinv = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbalmac = New System.Windows.Forms.ComboBox()
        Me.dtpfanul = New System.Windows.Forms.DateTimePicker()
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.cmb_serdoc = New System.Windows.Forms.ComboBox()
        Me.cmbt_doc = New System.Windows.Forms.ComboBox()
        Me.txtt_doc = New System.Windows.Forms.TextBox()
        Me.cmbturno = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbt_movinv = New System.Windows.Forms.ComboBox()
        Me.cmbt_pago = New System.Windows.Forms.ComboBox()
        Me.txtt_pago = New System.Windows.Forms.TextBox()
        Me.cmbfor_ent = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtobserva1 = New System.Windows.Forms.TextBox()
        Me.btndocu = New System.Windows.Forms.Button()
        Me.dgvt_doc = New System.Windows.Forms.DataGridView()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.lstValor = New System.Windows.Forms.ListBox()
        Me.dgvsum = New System.Windows.Forms.DataGridView()
        Me.tsbForm.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvsum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbimprimir, Me.ToolStripButton1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(865, 25)
        Me.tsbForm.TabIndex = 12
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmbalmacen)
        Me.GroupBox2.Controls.Add(Me.chk_m)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.cmbdni)
        Me.GroupBox2.Controls.Add(Me.txtdni)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtobservacion)
        Me.GroupBox2.Controls.Add(Me.cmbdir)
        Me.GroupBox2.Controls.Add(Me.txtdir)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.cmbproveedor)
        Me.GroupBox2.Controls.Add(Me.txtproveedor)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.cmbc_costo)
        Me.GroupBox2.Controls.Add(Me.txtc_costo)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cmbmon)
        Me.GroupBox2.Controls.Add(Me.txtmon)
        Me.GroupBox2.Controls.Add(Me.txtfor_ent)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtt_movinv)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.cmbturno)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.cmbt_movinv)
        Me.GroupBox2.Controls.Add(Me.cmbt_pago)
        Me.GroupBox2.Controls.Add(Me.txtt_pago)
        Me.GroupBox2.Controls.Add(Me.cmbfor_ent)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(828, 236)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 16)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "Almacen"
        '
        'cmbalmacen
        '
        Me.cmbalmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbalmacen.FormattingEnabled = True
        Me.cmbalmacen.Location = New System.Drawing.Point(102, 209)
        Me.cmbalmacen.Name = "cmbalmacen"
        Me.cmbalmacen.Size = New System.Drawing.Size(231, 21)
        Me.cmbalmacen.TabIndex = 103
        '
        'chk_m
        '
        Me.chk_m.AutoSize = True
        Me.chk_m.Location = New System.Drawing.Point(727, 185)
        Me.chk_m.Name = "chk_m"
        Me.chk_m.Size = New System.Drawing.Size(68, 17)
        Me.chk_m.TabIndex = 102
        Me.chk_m.Text = "Nacional"
        Me.chk_m.UseVisualStyleBackColor = True
        Me.chk_m.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(14, 130)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 16)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Solicita"
        '
        'cmbdni
        '
        Me.cmbdni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdni.FormattingEnabled = True
        Me.cmbdni.ItemHeight = 13
        Me.cmbdni.Location = New System.Drawing.Point(197, 130)
        Me.cmbdni.Name = "cmbdni"
        Me.cmbdni.Size = New System.Drawing.Size(565, 21)
        Me.cmbdni.TabIndex = 14
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(102, 129)
        Me.txtdni.MaxLength = 8
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(84, 20)
        Me.txtdni.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(485, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 16)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Mov. Almacen"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(765, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 23)
        Me.Button1.TabIndex = 100
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(9, 185)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 16)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Observaciones"
        '
        'txtobservacion
        '
        Me.txtobservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobservacion.Location = New System.Drawing.Point(115, 184)
        Me.txtobservacion.Name = "txtobservacion"
        Me.txtobservacion.Size = New System.Drawing.Size(602, 20)
        Me.txtobservacion.TabIndex = 26
        '
        'cmbdir
        '
        Me.cmbdir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdir.FormattingEnabled = True
        Me.cmbdir.Location = New System.Drawing.Point(197, 183)
        Me.cmbdir.Name = "cmbdir"
        Me.cmbdir.Size = New System.Drawing.Size(520, 21)
        Me.cmbdir.TabIndex = 24
        Me.cmbdir.Visible = False
        '
        'txtdir
        '
        Me.txtdir.Location = New System.Drawing.Point(102, 183)
        Me.txtdir.Name = "txtdir"
        Me.txtdir.Size = New System.Drawing.Size(89, 20)
        Me.txtdir.TabIndex = 23
        Me.txtdir.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Documento"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(9, 184)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 16)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Direccion"
        Me.Label16.Visible = False
        '
        'cmbproveedor
        '
        Me.cmbproveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbproveedor.FormattingEnabled = True
        Me.cmbproveedor.Location = New System.Drawing.Point(197, 157)
        Me.cmbproveedor.Name = "cmbproveedor"
        Me.cmbproveedor.Size = New System.Drawing.Size(565, 21)
        Me.cmbproveedor.TabIndex = 22
        '
        'txtproveedor
        '
        Me.txtproveedor.Location = New System.Drawing.Point(102, 157)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(89, 20)
        Me.txtproveedor.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 158)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 16)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Proveedor"
        '
        'cmbc_costo
        '
        Me.cmbc_costo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbc_costo.FormattingEnabled = True
        Me.cmbc_costo.Location = New System.Drawing.Point(621, 98)
        Me.cmbc_costo.Name = "cmbc_costo"
        Me.cmbc_costo.Size = New System.Drawing.Size(182, 21)
        Me.cmbc_costo.TabIndex = 12
        '
        'txtc_costo
        '
        Me.txtc_costo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtc_costo.Location = New System.Drawing.Point(571, 98)
        Me.txtc_costo.Name = "txtc_costo"
        Me.txtc_costo.Size = New System.Drawing.Size(44, 20)
        Me.txtc_costo.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(591, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 16)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Centro Costo"
        '
        'cmbmon
        '
        Me.cmbmon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmon.FormattingEnabled = True
        Me.cmbmon.Location = New System.Drawing.Point(698, 98)
        Me.cmbmon.Name = "cmbmon"
        Me.cmbmon.Size = New System.Drawing.Size(105, 21)
        Me.cmbmon.TabIndex = 16
        Me.cmbmon.Visible = False
        '
        'txtmon
        '
        Me.txtmon.Location = New System.Drawing.Point(659, 98)
        Me.txtmon.Name = "txtmon"
        Me.txtmon.Size = New System.Drawing.Size(34, 20)
        Me.txtmon.TabIndex = 15
        Me.txtmon.Visible = False
        '
        'txtfor_ent
        '
        Me.txtfor_ent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfor_ent.Location = New System.Drawing.Point(604, 98)
        Me.txtfor_ent.Name = "txtfor_ent"
        Me.txtfor_ent.Size = New System.Drawing.Size(38, 20)
        Me.txtfor_ent.TabIndex = 13
        Me.txtfor_ent.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Tipo Movimiento"
        '
        'txtt_movinv
        '
        Me.txtt_movinv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtt_movinv.Location = New System.Drawing.Point(12, 98)
        Me.txtt_movinv.Name = "txtt_movinv"
        Me.txtt_movinv.Size = New System.Drawing.Size(40, 20)
        Me.txtt_movinv.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(722, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "F. Anulacion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(607, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Estado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(406, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(321, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Numero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(248, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Serie"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbalmac)
        Me.GroupBox3.Controls.Add(Me.dtpfanul)
        Me.GroupBox3.Controls.Add(Me.cmbestado)
        Me.GroupBox3.Controls.Add(Me.dtpfecha)
        Me.GroupBox3.Controls.Add(Me.txtnumero)
        Me.GroupBox3.Controls.Add(Me.cmb_serdoc)
        Me.GroupBox3.Controls.Add(Me.cmbt_doc)
        Me.GroupBox3.Controls.Add(Me.txtt_doc)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 29)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(816, 42)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'cmbalmac
        '
        Me.cmbalmac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbalmac.Enabled = False
        Me.cmbalmac.FormattingEnabled = True
        Me.cmbalmac.Items.AddRange(New Object() {"Entrada", "Salida", "Devolucion"})
        Me.cmbalmac.Location = New System.Drawing.Point(475, 12)
        Me.cmbalmac.Name = "cmbalmac"
        Me.cmbalmac.Size = New System.Drawing.Size(107, 21)
        Me.cmbalmac.TabIndex = 6
        '
        'dtpfanul
        '
        Me.dtpfanul.Checked = False
        Me.dtpfanul.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfanul.Location = New System.Drawing.Point(692, 12)
        Me.dtpfanul.Name = "dtpfanul"
        Me.dtpfanul.ShowCheckBox = True
        Me.dtpfanul.Size = New System.Drawing.Size(106, 20)
        Me.dtpfanul.TabIndex = 8
        '
        'cmbestado
        '
        Me.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"Activo", "Anulado", "Compra", "Transferido", "Suspendido", "Previo"})
        Me.cmbestado.Location = New System.Drawing.Point(588, 12)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(86, 21)
        Me.cmbestado.TabIndex = 7
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(387, 14)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(82, 20)
        Me.dtpfecha.TabIndex = 5
        '
        'txtnumero
        '
        Me.txtnumero.Enabled = False
        Me.txtnumero.Location = New System.Drawing.Point(303, 14)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(78, 20)
        Me.txtnumero.TabIndex = 4
        '
        'cmb_serdoc
        '
        Me.cmb_serdoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_serdoc.FormattingEnabled = True
        Me.cmb_serdoc.Items.AddRange(New Object() {"ALM", "ASQ", "AUD", "COM", "DES", "ENS", "GER", "ING", "PRO", "PRE", "REH", "TWO", "VEN", "001", "COR", "INF", "002", "T001"})
        Me.cmb_serdoc.Location = New System.Drawing.Point(226, 14)
        Me.cmb_serdoc.Name = "cmb_serdoc"
        Me.cmb_serdoc.Size = New System.Drawing.Size(71, 21)
        Me.cmb_serdoc.TabIndex = 3
        '
        'cmbt_doc
        '
        Me.cmbt_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbt_doc.FormattingEnabled = True
        Me.cmbt_doc.Location = New System.Drawing.Point(53, 15)
        Me.cmbt_doc.Name = "cmbt_doc"
        Me.cmbt_doc.Size = New System.Drawing.Size(161, 21)
        Me.cmbt_doc.TabIndex = 2
        '
        'txtt_doc
        '
        Me.txtt_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtt_doc.Location = New System.Drawing.Point(6, 15)
        Me.txtt_doc.Name = "txtt_doc"
        Me.txtt_doc.Size = New System.Drawing.Size(40, 20)
        Me.txtt_doc.TabIndex = 1
        '
        'cmbturno
        '
        Me.cmbturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbturno.FormattingEnabled = True
        Me.cmbturno.Location = New System.Drawing.Point(102, 246)
        Me.cmbturno.Name = "cmbturno"
        Me.cmbturno.Size = New System.Drawing.Size(89, 21)
        Me.cmbturno.TabIndex = 25
        Me.cmbturno.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 247)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 16)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Turno"
        Me.Label17.Visible = False
        '
        'cmbt_movinv
        '
        Me.cmbt_movinv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbt_movinv.FormattingEnabled = True
        Me.cmbt_movinv.Location = New System.Drawing.Point(58, 98)
        Me.cmbt_movinv.Name = "cmbt_movinv"
        Me.cmbt_movinv.Size = New System.Drawing.Size(479, 21)
        Me.cmbt_movinv.TabIndex = 10
        '
        'cmbt_pago
        '
        Me.cmbt_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbt_pago.FormattingEnabled = True
        Me.cmbt_pago.Location = New System.Drawing.Point(409, 98)
        Me.cmbt_pago.Name = "cmbt_pago"
        Me.cmbt_pago.Size = New System.Drawing.Size(169, 21)
        Me.cmbt_pago.TabIndex = 12
        Me.cmbt_pago.Visible = False
        '
        'txtt_pago
        '
        Me.txtt_pago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtt_pago.Location = New System.Drawing.Point(380, 98)
        Me.txtt_pago.Name = "txtt_pago"
        Me.txtt_pago.Size = New System.Drawing.Size(37, 20)
        Me.txtt_pago.TabIndex = 11
        Me.txtt_pago.Visible = False
        '
        'cmbfor_ent
        '
        Me.cmbfor_ent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbfor_ent.FormattingEnabled = True
        Me.cmbfor_ent.Location = New System.Drawing.Point(621, 98)
        Me.cmbfor_ent.Name = "cmbfor_ent"
        Me.cmbfor_ent.Size = New System.Drawing.Size(182, 21)
        Me.cmbfor_ent.TabIndex = 14
        Me.cmbfor_ent.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtobserva1)
        Me.GroupBox1.Controls.Add(Me.btndocu)
        Me.GroupBox1.Controls.Add(Me.dgvt_doc)
        Me.GroupBox1.Controls.Add(Me.btnborrar)
        Me.GroupBox1.Controls.Add(Me.btnmodificar)
        Me.GroupBox1.Controls.Add(Me.btnagregar)
        Me.GroupBox1.Controls.Add(Me.lstValor)
        Me.GroupBox1.Controls.Add(Me.dgvsum)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 270)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(828, 217)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'txtobserva1
        '
        Me.txtobserva1.Location = New System.Drawing.Point(703, 184)
        Me.txtobserva1.Name = "txtobserva1"
        Me.txtobserva1.Size = New System.Drawing.Size(100, 20)
        Me.txtobserva1.TabIndex = 102
        Me.txtobserva1.Visible = False
        '
        'btndocu
        '
        Me.btndocu.Location = New System.Drawing.Point(724, 123)
        Me.btndocu.Name = "btndocu"
        Me.btndocu.Size = New System.Drawing.Size(75, 23)
        Me.btndocu.TabIndex = 30
        Me.btndocu.Text = "Docum."
        Me.btndocu.UseVisualStyleBackColor = True
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
        Me.dgvt_doc.Size = New System.Drawing.Size(695, 185)
        Me.dgvt_doc.TabIndex = 31
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(724, 94)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(75, 23)
        Me.btnborrar.TabIndex = 29
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(724, 65)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificar.TabIndex = 28
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(724, 36)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 27
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'lstValor
        '
        Me.lstValor.FormattingEnabled = True
        Me.lstValor.Location = New System.Drawing.Point(289, 35)
        Me.lstValor.Name = "lstValor"
        Me.lstValor.Size = New System.Drawing.Size(251, 147)
        Me.lstValor.TabIndex = 103
        '
        'dgvsum
        '
        Me.dgvsum.AllowUserToAddRows = False
        Me.dgvsum.AllowUserToDeleteRows = False
        Me.dgvsum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvsum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsum.Location = New System.Drawing.Point(6, 31)
        Me.dgvsum.Name = "dgvsum"
        Me.dgvsum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvsum.Size = New System.Drawing.Size(674, 154)
        Me.dgvsum.TabIndex = 104
        Me.dgvsum.Visible = False
        '
        'FormMantGuiaAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 498)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tsbForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormMantGuiaAlmacen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMantGuiaAlmacen"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvsum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents txtobservacion As TextBox
    Friend WithEvents cmbturno As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbdir As ComboBox
    Friend WithEvents txtdir As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cmbproveedor As ComboBox
    Friend WithEvents txtproveedor As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbdni As ComboBox
    Friend WithEvents txtdni As TextBox
    Friend WithEvents cmbc_costo As ComboBox
    Friend WithEvents txtc_costo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbmon As ComboBox
    Friend WithEvents txtmon As TextBox
    Friend WithEvents cmbfor_ent As ComboBox
    Friend WithEvents txtfor_ent As TextBox
    Friend WithEvents cmbt_pago As ComboBox
    Friend WithEvents txtt_pago As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbt_movinv As ComboBox
    Friend WithEvents txtt_movinv As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtpfanul As DateTimePicker
    Friend WithEvents cmbestado As ComboBox
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents cmb_serdoc As ComboBox
    Friend WithEvents cmbt_doc As ComboBox
    Friend WithEvents txtt_doc As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvt_doc As DataGridView
    Friend WithEvents btnborrar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents cmbalmac As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btndocu As Button
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents txtobserva1 As TextBox
    Friend WithEvents chk_m As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbalmacen As ComboBox
    Friend WithEvents lstValor As ListBox
    Friend WithEvents dgvsum As DataGridView
End Class
