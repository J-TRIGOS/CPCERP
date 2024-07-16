<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMantRequerimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantRequerimiento))
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btndocu = New System.Windows.Forms.Button()
        Me.dgvt_doc = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtobservacion = New System.Windows.Forms.TextBox()
        Me.cmbturno = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbdir = New System.Windows.Forms.ComboBox()
        Me.txtdir = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbproveedor = New System.Windows.Forms.ComboBox()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbdni = New System.Windows.Forms.ComboBox()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.cmbc_costo = New System.Windows.Forms.ComboBox()
        Me.txtc_costo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbmon = New System.Windows.Forms.ComboBox()
        Me.txtmon = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbfor_ent = New System.Windows.Forms.ComboBox()
        Me.txtfor_ent = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbt_pago = New System.Windows.Forms.ComboBox()
        Me.txtt_pago = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbt_movinv = New System.Windows.Forms.ComboBox()
        Me.txtt_movinv = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtpfanul = New System.Windows.Forms.DateTimePicker()
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.cmb_serdoc = New System.Windows.Forms.ComboBox()
        Me.cmbt_doc = New System.Windows.Forms.ComboBox()
        Me.txtt_doc = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkbar_cod = New System.Windows.Forms.CheckBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtporcentaje = New System.Windows.Forms.TextBox()
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttprecio_dcompra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttprecio_compra = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tsbForm.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(725, 19)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 0
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        Me.btnagregar.Visible = False
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(725, 45)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificar.TabIndex = 1
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(725, 72)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(75, 23)
        Me.btnborrar.TabIndex = 2
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbimprimir, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(852, 25)
        Me.tsbForm.TabIndex = 11
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btnadd)
        Me.GroupBox1.Controls.Add(Me.btndocu)
        Me.GroupBox1.Controls.Add(Me.dgvt_doc)
        Me.GroupBox1.Controls.Add(Me.btnborrar)
        Me.GroupBox1.Controls.Add(Me.btnmodificar)
        Me.GroupBox1.Controls.Add(Me.btnagregar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 408)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(828, 186)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'btnadd
        '
        Me.btnadd.Enabled = False
        Me.btnadd.Location = New System.Drawing.Point(725, 126)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 6
        Me.btnadd.Text = "Agregar Imp."
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btndocu
        '
        Me.btndocu.Location = New System.Drawing.Point(725, 99)
        Me.btndocu.Name = "btndocu"
        Me.btndocu.Size = New System.Drawing.Size(75, 23)
        Me.btndocu.TabIndex = 5
        Me.btndocu.Text = "Docum."
        Me.btndocu.UseVisualStyleBackColor = True
        '
        'dgvt_doc
        '
        Me.dgvt_doc.AllowUserToAddRows = False
        Me.dgvt_doc.AllowUserToDeleteRows = False
        Me.dgvt_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc.Location = New System.Drawing.Point(6, 24)
        Me.dgvt_doc.Name = "dgvt_doc"
        Me.dgvt_doc.ReadOnly = True
        Me.dgvt_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc.Size = New System.Drawing.Size(695, 156)
        Me.dgvt_doc.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtobservacion)
        Me.GroupBox2.Controls.Add(Me.cmbturno)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.cmbdir)
        Me.GroupBox2.Controls.Add(Me.txtdir)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.cmbproveedor)
        Me.GroupBox2.Controls.Add(Me.txtproveedor)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.cmbdni)
        Me.GroupBox2.Controls.Add(Me.txtdni)
        Me.GroupBox2.Controls.Add(Me.cmbc_costo)
        Me.GroupBox2.Controls.Add(Me.txtc_costo)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cmbmon)
        Me.GroupBox2.Controls.Add(Me.txtmon)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cmbfor_ent)
        Me.GroupBox2.Controls.Add(Me.txtfor_ent)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cmbt_pago)
        Me.GroupBox2.Controls.Add(Me.txtt_pago)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cmbt_movinv)
        Me.GroupBox2.Controls.Add(Me.txtt_movinv)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(828, 240)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(295, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Serie"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(375, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Numero"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(482, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Fecha"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(599, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Estado"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(722, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "F. Anulacion"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(765, 150)
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
        Me.Label18.Location = New System.Drawing.Point(197, 213)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 16)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Observaciones"
        '
        'txtobservacion
        '
        Me.txtobservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobservacion.Location = New System.Drawing.Point(303, 209)
        Me.txtobservacion.Name = "txtobservacion"
        Me.txtobservacion.Size = New System.Drawing.Size(501, 20)
        Me.txtobservacion.TabIndex = 25
        '
        'cmbturno
        '
        Me.cmbturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbturno.FormattingEnabled = True
        Me.cmbturno.Location = New System.Drawing.Point(102, 208)
        Me.cmbturno.Name = "cmbturno"
        Me.cmbturno.Size = New System.Drawing.Size(89, 21)
        Me.cmbturno.TabIndex = 24
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 209)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 16)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Turno"
        '
        'cmbdir
        '
        Me.cmbdir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdir.FormattingEnabled = True
        Me.cmbdir.Location = New System.Drawing.Point(197, 180)
        Me.cmbdir.Name = "cmbdir"
        Me.cmbdir.Size = New System.Drawing.Size(607, 21)
        Me.cmbdir.TabIndex = 23
        '
        'txtdir
        '
        Me.txtdir.Location = New System.Drawing.Point(102, 180)
        Me.txtdir.Name = "txtdir"
        Me.txtdir.Size = New System.Drawing.Size(89, 20)
        Me.txtdir.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(9, 181)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 16)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Direccion"
        '
        'cmbproveedor
        '
        Me.cmbproveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbproveedor.FormattingEnabled = True
        Me.cmbproveedor.Location = New System.Drawing.Point(197, 152)
        Me.cmbproveedor.Name = "cmbproveedor"
        Me.cmbproveedor.Size = New System.Drawing.Size(565, 21)
        Me.cmbproveedor.TabIndex = 21
        '
        'txtproveedor
        '
        Me.txtproveedor.Location = New System.Drawing.Point(102, 152)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(89, 20)
        Me.txtproveedor.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 153)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 16)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Proveedor"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(384, 123)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 16)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Solicita"
        '
        'cmbdni
        '
        Me.cmbdni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdni.FormattingEnabled = True
        Me.cmbdni.Location = New System.Drawing.Point(538, 122)
        Me.cmbdni.Name = "cmbdni"
        Me.cmbdni.Size = New System.Drawing.Size(266, 21)
        Me.cmbdni.TabIndex = 19
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(442, 122)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(84, 20)
        Me.txtdni.TabIndex = 18
        '
        'cmbc_costo
        '
        Me.cmbc_costo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbc_costo.FormattingEnabled = True
        Me.cmbc_costo.Location = New System.Drawing.Point(148, 122)
        Me.cmbc_costo.Name = "cmbc_costo"
        Me.cmbc_costo.Size = New System.Drawing.Size(223, 21)
        Me.cmbc_costo.TabIndex = 17
        '
        'txtc_costo
        '
        Me.txtc_costo.Location = New System.Drawing.Point(102, 122)
        Me.txtc_costo.Name = "txtc_costo"
        Me.txtc_costo.Size = New System.Drawing.Size(40, 20)
        Me.txtc_costo.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 123)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 16)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Centro Costo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(612, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 16)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Moneda"
        '
        'cmbmon
        '
        Me.cmbmon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmon.FormattingEnabled = True
        Me.cmbmon.Location = New System.Drawing.Point(625, 93)
        Me.cmbmon.Name = "cmbmon"
        Me.cmbmon.Size = New System.Drawing.Size(105, 21)
        Me.cmbmon.TabIndex = 15
        '
        'txtmon
        '
        Me.txtmon.Location = New System.Drawing.Point(586, 93)
        Me.txtmon.Name = "txtmon"
        Me.txtmon.Size = New System.Drawing.Size(34, 20)
        Me.txtmon.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(395, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 16)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Forma de Entrega"
        '
        'cmbfor_ent
        '
        Me.cmbfor_ent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbfor_ent.FormattingEnabled = True
        Me.cmbfor_ent.Location = New System.Drawing.Point(428, 93)
        Me.cmbfor_ent.Name = "cmbfor_ent"
        Me.cmbfor_ent.Size = New System.Drawing.Size(135, 21)
        Me.cmbfor_ent.TabIndex = 13
        '
        'txtfor_ent
        '
        Me.txtfor_ent.Location = New System.Drawing.Point(384, 93)
        Me.txtfor_ent.Name = "txtfor_ent"
        Me.txtfor_ent.Size = New System.Drawing.Size(38, 20)
        Me.txtfor_ent.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(22, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Forma de Pago"
        '
        'cmbt_pago
        '
        Me.cmbt_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbt_pago.FormattingEnabled = True
        Me.cmbt_pago.Location = New System.Drawing.Point(52, 93)
        Me.cmbt_pago.Name = "cmbt_pago"
        Me.cmbt_pago.Size = New System.Drawing.Size(300, 21)
        Me.cmbt_pago.TabIndex = 11
        '
        'txtt_pago
        '
        Me.txtt_pago.Location = New System.Drawing.Point(9, 93)
        Me.txtt_pago.Name = "txtt_pago"
        Me.txtt_pago.Size = New System.Drawing.Size(37, 20)
        Me.txtt_pago.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Tipo Movimiento"
        Me.Label9.Visible = False
        '
        'cmbt_movinv
        '
        Me.cmbt_movinv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbt_movinv.FormattingEnabled = True
        Me.cmbt_movinv.Location = New System.Drawing.Point(59, 93)
        Me.cmbt_movinv.Name = "cmbt_movinv"
        Me.cmbt_movinv.Size = New System.Drawing.Size(153, 21)
        Me.cmbt_movinv.TabIndex = 9
        Me.cmbt_movinv.Visible = False
        '
        'txtt_movinv
        '
        Me.txtt_movinv.Location = New System.Drawing.Point(12, 93)
        Me.txtt_movinv.Name = "txtt_movinv"
        Me.txtt_movinv.Size = New System.Drawing.Size(40, 20)
        Me.txtt_movinv.TabIndex = 8
        Me.txtt_movinv.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtpfanul)
        Me.GroupBox3.Controls.Add(Me.cmbestado)
        Me.GroupBox3.Controls.Add(Me.dtpfecha)
        Me.GroupBox3.Controls.Add(Me.txtnumero)
        Me.GroupBox3.Controls.Add(Me.cmb_serdoc)
        Me.GroupBox3.Controls.Add(Me.cmbt_doc)
        Me.GroupBox3.Controls.Add(Me.txtt_doc)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 26)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(816, 42)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'dtpfanul
        '
        Me.dtpfanul.Checked = False
        Me.dtpfanul.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfanul.Location = New System.Drawing.Point(692, 12)
        Me.dtpfanul.Name = "dtpfanul"
        Me.dtpfanul.ShowCheckBox = True
        Me.dtpfanul.Size = New System.Drawing.Size(106, 20)
        Me.dtpfanul.TabIndex = 7
        '
        'cmbestado
        '
        Me.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"Activo", "Anulado", "Compra", "Transferido", "Suspendido", "Previo"})
        Me.cmbestado.Location = New System.Drawing.Point(567, 12)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(107, 21)
        Me.cmbestado.TabIndex = 6
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(461, 15)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(82, 20)
        Me.dtpfecha.TabIndex = 5
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(360, 15)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(78, 20)
        Me.txtnumero.TabIndex = 4
        '
        'cmb_serdoc
        '
        Me.cmb_serdoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_serdoc.FormattingEnabled = True
        Me.cmb_serdoc.Items.AddRange(New Object() {"001", "002", "003", "004", "005", "006", "007"})
        Me.cmb_serdoc.Location = New System.Drawing.Point(267, 14)
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
        Me.cmbt_doc.Size = New System.Drawing.Size(175, 21)
        Me.cmbt_doc.TabIndex = 2
        '
        'txtt_doc
        '
        Me.txtt_doc.Location = New System.Drawing.Point(6, 15)
        Me.txtt_doc.Name = "txtt_doc"
        Me.txtt_doc.Size = New System.Drawing.Size(40, 20)
        Me.txtt_doc.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkbar_cod)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.txtporcentaje)
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
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txttprecio_dcompra)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txttprecio_compra)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 276)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(828, 126)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Totales"
        '
        'chkbar_cod
        '
        Me.chkbar_cod.AutoSize = True
        Me.chkbar_cod.Location = New System.Drawing.Point(707, 87)
        Me.chkbar_cod.Name = "chkbar_cod"
        Me.chkbar_cod.Size = New System.Drawing.Size(81, 17)
        Me.chkbar_cod.TabIndex = 103
        Me.chkbar_cod.Text = "Importacion"
        Me.chkbar_cod.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(718, 16)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(61, 16)
        Me.Label29.TabIndex = 102
        Me.Label29.Text = "Volumen"
        '
        'txtporcentaje
        '
        Me.txtporcentaje.Location = New System.Drawing.Point(704, 35)
        Me.txtporcentaje.Name = "txtporcentaje"
        Me.txtporcentaje.Size = New System.Drawing.Size(84, 20)
        Me.txtporcentaje.TabIndex = 101
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(598, 68)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(81, 16)
        Me.Label24.TabIndex = 51
        Me.Label24.Text = "Compra ($/.)"
        '
        'txttcomprad
        '
        Me.txttcomprad.Enabled = False
        Me.txttcomprad.Location = New System.Drawing.Point(579, 87)
        Me.txttcomprad.Name = "txttcomprad"
        Me.txttcomprad.Size = New System.Drawing.Size(114, 20)
        Me.txttcomprad.TabIndex = 50
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(596, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(83, 16)
        Me.Label23.TabIndex = 49
        Me.Label23.Text = "Compra (S/.)"
        '
        'txttcompras
        '
        Me.txttcompras.Enabled = False
        Me.txttcompras.Location = New System.Drawing.Point(579, 35)
        Me.txttcompras.Name = "txttcompras"
        Me.txttcompras.Size = New System.Drawing.Size(114, 20)
        Me.txttcompras.TabIndex = 48
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(407, 68)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(89, 16)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "Total IGV ($/.)"
        '
        'txtt_igv_dolar
        '
        Me.txtt_igv_dolar.Enabled = False
        Me.txtt_igv_dolar.Location = New System.Drawing.Point(394, 87)
        Me.txtt_igv_dolar.Name = "txtt_igv_dolar"
        Me.txtt_igv_dolar.Size = New System.Drawing.Size(114, 20)
        Me.txtt_igv_dolar.TabIndex = 46
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(407, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(91, 16)
        Me.Label21.TabIndex = 45
        Me.Label21.Text = "Total IGV (S/.)"
        '
        'txtt_igv
        '
        Me.txtt_igv.Enabled = False
        Me.txtt_igv.Location = New System.Drawing.Point(394, 35)
        Me.txtt_igv.Name = "txtt_igv"
        Me.txtt_igv.Size = New System.Drawing.Size(114, 20)
        Me.txtt_igv.TabIndex = 44
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(237, 68)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(98, 16)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Descuento ($/.)"
        '
        'txtt_dcto_dolar
        '
        Me.txtt_dcto_dolar.Enabled = False
        Me.txtt_dcto_dolar.Location = New System.Drawing.Point(230, 87)
        Me.txtt_dcto_dolar.Name = "txtt_dcto_dolar"
        Me.txtt_dcto_dolar.Size = New System.Drawing.Size(114, 20)
        Me.txtt_dcto_dolar.TabIndex = 42
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(234, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 16)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Descuento (S/.)"
        '
        'txtt_dcto
        '
        Me.txtt_dcto.Enabled = False
        Me.txtt_dcto.Location = New System.Drawing.Point(227, 35)
        Me.txtt_dcto.Name = "txtt_dcto"
        Me.txtt_dcto.Size = New System.Drawing.Size(114, 20)
        Me.txtt_dcto.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(56, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Compra Total ($/.)"
        '
        'txttprecio_dcompra
        '
        Me.txttprecio_dcompra.Enabled = False
        Me.txttprecio_dcompra.Location = New System.Drawing.Point(59, 87)
        Me.txttprecio_dcompra.Name = "txttprecio_dcompra"
        Me.txttprecio_dcompra.Size = New System.Drawing.Size(114, 20)
        Me.txttprecio_dcompra.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 16)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Compra Total (S/.)"
        '
        'txttprecio_compra
        '
        Me.txttprecio_compra.Enabled = False
        Me.txttprecio_compra.Location = New System.Drawing.Point(59, 35)
        Me.txttprecio_compra.Name = "txttprecio_compra"
        Me.txttprecio_compra.Size = New System.Drawing.Size(114, 20)
        Me.txttprecio_compra.TabIndex = 26
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(388, 602)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(37, 13)
        Me.Label25.TabIndex = 15
        Me.Label25.Text = "Fecha"
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(428, 597)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(126, 23)
        Me.Label26.TabIndex = 16
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(586, 601)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(43, 13)
        Me.Label27.TabIndex = 17
        Me.Label27.Text = "Usuario"
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(635, 598)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(126, 23)
        Me.Label28.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(725, 153)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Peso"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormMantRequerimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 624)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tsbForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormMantRequerimiento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMantRequerimiento"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnagregar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnborrar As Button
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbt_doc As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtt_doc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_serdoc As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbestado As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpfanul As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbt_movinv As ComboBox
    Friend WithEvents txtt_movinv As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbt_pago As ComboBox
    Friend WithEvents txtt_pago As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbfor_ent As ComboBox
    Friend WithEvents txtfor_ent As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbmon As ComboBox
    Friend WithEvents txtmon As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbc_costo As ComboBox
    Friend WithEvents txtc_costo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbdni As ComboBox
    Friend WithEvents txtdni As TextBox
    Friend WithEvents cmbproveedor As ComboBox
    Friend WithEvents txtproveedor As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbdir As ComboBox
    Friend WithEvents txtdir As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbturno As ComboBox
    Friend WithEvents txtobservacion As TextBox
    Friend WithEvents dgvt_doc As DataGridView
    Friend WithEvents Label18 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txttprecio_compra As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txttprecio_dcompra As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtt_dcto As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtt_dcto_dolar As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txttcomprad As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txttcompras As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtt_igv_dolar As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtt_igv As TextBox
    Friend WithEvents btndocu As Button
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents Label29 As Label
    Friend WithEvents txtporcentaje As TextBox
    Friend WithEvents chkbar_cod As CheckBox
    Friend WithEvents Button2 As Button
End Class
