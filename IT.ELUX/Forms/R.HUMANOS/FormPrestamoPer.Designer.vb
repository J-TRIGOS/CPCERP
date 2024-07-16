<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrestamoPer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrestamoPer))
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.txtnt_doc = New System.Windows.Forms.TextBox()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.cmb_serdoc = New System.Windows.Forms.ComboBox()
        Me.txtt_doc = New System.Windows.Forms.TextBox()
        Me.dgvt_doc = New System.Windows.Forms.DataGridView()
        Me.CUOTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECVENC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRDOPAGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPAGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.npdmonto = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.npdcuotas = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtper_cod = New System.Windows.Forms.TextBox()
        Me.txtper_nom = New System.Windows.Forms.TextBox()
        Me.btnBuscarPersonal = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCuota = New System.Windows.Forms.Button()
        Me.cmbPrdoPago = New System.Windows.Forms.ComboBox()
        Me.dtpFec1 = New System.Windows.Forms.DateTimePicker()
        Me.btnBoleta = New System.Windows.Forms.Button()
        Me.lblNN = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tsbForm.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdmonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdcuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbimprimir, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(962, 25)
        Me.tsbForm.TabIndex = 23
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Tipo Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(364, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Serie"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(437, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Numero"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(530, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Fecha"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbEstado)
        Me.GroupBox3.Controls.Add(Me.txtnt_doc)
        Me.GroupBox3.Controls.Add(Me.dtpfecha)
        Me.GroupBox3.Controls.Add(Me.txtnumero)
        Me.GroupBox3.Controls.Add(Me.cmb_serdoc)
        Me.GroupBox3.Controls.Add(Me.txtt_doc)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(718, 42)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"PENDIENTE", "PAGADO"})
        Me.cmbEstado.Location = New System.Drawing.Point(588, 12)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(121, 21)
        Me.cmbEstado.TabIndex = 6
        '
        'txtnt_doc
        '
        Me.txtnt_doc.Location = New System.Drawing.Point(52, 14)
        Me.txtnt_doc.Name = "txtnt_doc"
        Me.txtnt_doc.ReadOnly = True
        Me.txtnt_doc.Size = New System.Drawing.Size(270, 20)
        Me.txtnt_doc.TabIndex = 2
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(499, 14)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(82, 20)
        Me.dtpfecha.TabIndex = 5
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(406, 14)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(78, 20)
        Me.txtnumero.TabIndex = 4
        '
        'cmb_serdoc
        '
        Me.cmb_serdoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_serdoc.FormattingEnabled = True
        Me.cmb_serdoc.Items.AddRange(New Object() {"2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027"})
        Me.cmb_serdoc.Location = New System.Drawing.Point(328, 13)
        Me.cmb_serdoc.Name = "cmb_serdoc"
        Me.cmb_serdoc.Size = New System.Drawing.Size(71, 21)
        Me.cmb_serdoc.TabIndex = 3
        '
        'txtt_doc
        '
        Me.txtt_doc.Location = New System.Drawing.Point(6, 15)
        Me.txtt_doc.Name = "txtt_doc"
        Me.txtt_doc.Size = New System.Drawing.Size(40, 20)
        Me.txtt_doc.TabIndex = 1
        '
        'dgvt_doc
        '
        Me.dgvt_doc.AllowUserToAddRows = False
        Me.dgvt_doc.AllowUserToDeleteRows = False
        Me.dgvt_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CUOTA, Me.TIPO, Me.SERIE, Me.NUMERO, Me.FECVENC, Me.MONTO, Me.PRDO, Me.PRDOPAGO, Me.ESTADO, Me.TPAGO})
        Me.dgvt_doc.Location = New System.Drawing.Point(12, 198)
        Me.dgvt_doc.Name = "dgvt_doc"
        Me.dgvt_doc.ReadOnly = True
        Me.dgvt_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc.Size = New System.Drawing.Size(851, 281)
        Me.dgvt_doc.TabIndex = 32
        '
        'CUOTA
        '
        Me.CUOTA.DataPropertyName = "CUOTA"
        Me.CUOTA.HeaderText = "CUOTA"
        Me.CUOTA.Name = "CUOTA"
        Me.CUOTA.ReadOnly = True
        Me.CUOTA.Width = 69
        '
        'TIPO
        '
        Me.TIPO.DataPropertyName = "TIPO"
        Me.TIPO.HeaderText = "TIPO"
        Me.TIPO.Name = "TIPO"
        Me.TIPO.ReadOnly = True
        Me.TIPO.Width = 57
        '
        'SERIE
        '
        Me.SERIE.DataPropertyName = "SERIE"
        Me.SERIE.HeaderText = "SERIE"
        Me.SERIE.Name = "SERIE"
        Me.SERIE.ReadOnly = True
        Me.SERIE.Width = 64
        '
        'NUMERO
        '
        Me.NUMERO.DataPropertyName = "NUMERO"
        Me.NUMERO.HeaderText = "NUMERO"
        Me.NUMERO.Name = "NUMERO"
        Me.NUMERO.ReadOnly = True
        Me.NUMERO.Width = 80
        '
        'FECVENC
        '
        Me.FECVENC.DataPropertyName = "FECVENC"
        Me.FECVENC.HeaderText = "VENCIMIENTO"
        Me.FECVENC.Name = "FECVENC"
        Me.FECVENC.ReadOnly = True
        Me.FECVENC.Width = 106
        '
        'MONTO
        '
        Me.MONTO.DataPropertyName = "MONTO"
        Me.MONTO.HeaderText = "MONTO"
        Me.MONTO.Name = "MONTO"
        Me.MONTO.ReadOnly = True
        Me.MONTO.Width = 72
        '
        'PRDO
        '
        Me.PRDO.DataPropertyName = "PRDO"
        Me.PRDO.HeaderText = "PERIODO"
        Me.PRDO.Name = "PRDO"
        Me.PRDO.ReadOnly = True
        Me.PRDO.Width = 81
        '
        'PRDOPAGO
        '
        Me.PRDOPAGO.DataPropertyName = "PRDOPAGO"
        Me.PRDOPAGO.HeaderText = "PRDO. PAGO"
        Me.PRDOPAGO.Name = "PRDOPAGO"
        Me.PRDOPAGO.ReadOnly = True
        Me.PRDOPAGO.Width = 99
        '
        'ESTADO
        '
        Me.ESTADO.DataPropertyName = "ESTADO"
        Me.ESTADO.HeaderText = "ESTADO"
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.ReadOnly = True
        Me.ESTADO.Width = 76
        '
        'TPAGO
        '
        Me.TPAGO.HeaderText = "DESCUENTO"
        Me.TPAGO.Name = "TPAGO"
        Me.TPAGO.ReadOnly = True
        Me.TPAGO.Width = 99
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(869, 283)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(81, 34)
        Me.btnmodificar.TabIndex = 34
        Me.btnmodificar.Text = "Modificar Cuota"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(621, 143)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(81, 40)
        Me.btnagregar.TabIndex = 33
        Me.btnagregar.Text = "Calcular Cuotas"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Monto"
        '
        'npdmonto
        '
        Me.npdmonto.DecimalPlaces = 3
        Me.npdmonto.Location = New System.Drawing.Point(74, 154)
        Me.npdmonto.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npdmonto.Name = "npdmonto"
        Me.npdmonto.Size = New System.Drawing.Size(120, 20)
        Me.npdmonto.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(211, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 16)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Cuotas"
        '
        'npdcuotas
        '
        Me.npdcuotas.Location = New System.Drawing.Point(271, 154)
        Me.npdcuotas.Name = "npdcuotas"
        Me.npdcuotas.Size = New System.Drawing.Size(79, 20)
        Me.npdcuotas.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 16)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Personal"
        '
        'txtper_cod
        '
        Me.txtper_cod.Location = New System.Drawing.Point(92, 98)
        Me.txtper_cod.Name = "txtper_cod"
        Me.txtper_cod.Size = New System.Drawing.Size(78, 20)
        Me.txtper_cod.TabIndex = 6
        '
        'txtper_nom
        '
        Me.txtper_nom.Location = New System.Drawing.Point(176, 98)
        Me.txtper_nom.Name = "txtper_nom"
        Me.txtper_nom.ReadOnly = True
        Me.txtper_nom.Size = New System.Drawing.Size(351, 20)
        Me.txtper_nom.TabIndex = 99
        '
        'btnBuscarPersonal
        '
        Me.btnBuscarPersonal.Location = New System.Drawing.Point(533, 96)
        Me.btnBuscarPersonal.Name = "btnBuscarPersonal"
        Me.btnBuscarPersonal.Size = New System.Drawing.Size(49, 23)
        Me.btnBuscarPersonal.TabIndex = 99
        Me.btnBuscarPersonal.Text = "..."
        Me.btnBuscarPersonal.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(632, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 16)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Estado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(356, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Prdo. 1ra Cuota"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Obs.:"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(92, 125)
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(435, 20)
        Me.txtObs.TabIndex = 102
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(869, 198)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(81, 38)
        Me.btnNuevo.TabIndex = 103
        Me.btnNuevo.Text = "Nuevo Prestamo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        Me.btnNuevo.Visible = False
        '
        'btnCuota
        '
        Me.btnCuota.Location = New System.Drawing.Point(869, 242)
        Me.btnCuota.Name = "btnCuota"
        Me.btnCuota.Size = New System.Drawing.Size(81, 35)
        Me.btnCuota.TabIndex = 104
        Me.btnCuota.Text = "Agregar Cuota"
        Me.btnCuota.UseVisualStyleBackColor = True
        '
        'cmbPrdoPago
        '
        Me.cmbPrdoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrdoPago.FormattingEnabled = True
        Me.cmbPrdoPago.Location = New System.Drawing.Point(444, 153)
        Me.cmbPrdoPago.Name = "cmbPrdoPago"
        Me.cmbPrdoPago.Size = New System.Drawing.Size(83, 21)
        Me.cmbPrdoPago.TabIndex = 105
        '
        'dtpFec1
        '
        Me.dtpFec1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFec1.Location = New System.Drawing.Point(533, 155)
        Me.dtpFec1.Name = "dtpFec1"
        Me.dtpFec1.Size = New System.Drawing.Size(82, 20)
        Me.dtpFec1.TabIndex = 7
        Me.dtpFec1.Visible = False
        '
        'btnBoleta
        '
        Me.btnBoleta.Location = New System.Drawing.Point(869, 323)
        Me.btnBoleta.Name = "btnBoleta"
        Me.btnBoleta.Size = New System.Drawing.Size(81, 36)
        Me.btnBoleta.TabIndex = 106
        Me.btnBoleta.Text = "Boleta de Pago"
        Me.btnBoleta.UseVisualStyleBackColor = True
        '
        'lblNN
        '
        Me.lblNN.AutoSize = True
        Me.lblNN.Location = New System.Drawing.Point(766, 111)
        Me.lblNN.Name = "lblNN"
        Me.lblNN.Size = New System.Drawing.Size(45, 13)
        Me.lblNN.TabIndex = 107
        Me.lblNN.Text = "Label11"
        Me.lblNN.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(869, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 36)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "Eliminar Pago"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormPrestamoPer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 491)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblNN)
        Me.Controls.Add(Me.btnBoleta)
        Me.Controls.Add(Me.cmbPrdoPago)
        Me.Controls.Add(Me.btnCuota)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpFec1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnBuscarPersonal)
        Me.Controls.Add(Me.txtper_nom)
        Me.Controls.Add(Me.txtper_cod)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.npdcuotas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.npdmonto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.dgvt_doc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.tsbForm)
        Me.Name = "FormPrestamoPer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPrestamoPer"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdmonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdcuotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents cmb_serdoc As ComboBox
    Friend WithEvents txtt_doc As TextBox
    Friend WithEvents dgvt_doc As DataGridView
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents txtnt_doc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents npdmonto As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents npdcuotas As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents txtper_cod As TextBox
    Friend WithEvents txtper_nom As TextBox
    Friend WithEvents btnBuscarPersonal As Button
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtObs As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCuota As Button
    Friend WithEvents cmbPrdoPago As ComboBox
    Friend WithEvents dtpFec1 As DateTimePicker
    Friend WithEvents CUOTA As DataGridViewTextBoxColumn
    Friend WithEvents TIPO As DataGridViewTextBoxColumn
    Friend WithEvents SERIE As DataGridViewTextBoxColumn
    Friend WithEvents NUMERO As DataGridViewTextBoxColumn
    Friend WithEvents FECVENC As DataGridViewTextBoxColumn
    Friend WithEvents MONTO As DataGridViewTextBoxColumn
    Friend WithEvents PRDO As DataGridViewTextBoxColumn
    Friend WithEvents PRDOPAGO As DataGridViewTextBoxColumn
    Friend WithEvents ESTADO As DataGridViewTextBoxColumn
    Friend WithEvents TPAGO As DataGridViewTextBoxColumn
    Friend WithEvents btnBoleta As Button
    Friend WithEvents lblNN As Label
    Friend WithEvents Button1 As Button
End Class
