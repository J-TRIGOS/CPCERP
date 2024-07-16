<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDuplicarDetDocumento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDuplicarDetDocumento))
        Me.dtpfecprov = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_fec_emi = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.txtnro = New System.Windows.Forms.TextBox()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.btnduplicar = New System.Windows.Forms.Button()
        Me.rdbagua = New System.Windows.Forms.RadioButton()
        Me.rdbluz = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtruc = New System.Windows.Forms.TextBox()
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.rdbgas = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.npdmonto_total = New System.Windows.Forms.NumericUpDown()
        Me.dgvt_doc = New System.Windows.Forms.DataGridView()
        Me.ordreq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant_Per = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Luz = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.afecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inafecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.npdestrrural = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.npdigv = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_fec_emi = New System.Windows.Forms.MaskedTextBox()
        Me.txtfecprov = New System.Windows.Forms.MaskedTextBox()
        Me.tsbForm.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.npdmonto_total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdestrrural, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdigv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpfecprov
        '
        Me.dtpfecprov.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecprov.Location = New System.Drawing.Point(155, 266)
        Me.dtpfecprov.Name = "dtpfecprov"
        Me.dtpfecprov.Size = New System.Drawing.Size(90, 20)
        Me.dtpfecprov.TabIndex = 7
        Me.dtpfecprov.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha Provision"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Emision"
        '
        'dtp_fec_emi
        '
        Me.dtp_fec_emi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fec_emi.Location = New System.Drawing.Point(155, 240)
        Me.dtp_fec_emi.Name = "dtp_fec_emi"
        Me.dtp_fec_emi.Size = New System.Drawing.Size(90, 20)
        Me.dtp_fec_emi.TabIndex = 6
        Me.dtp_fec_emi.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Serie"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Numero"
        '
        'txtserie
        '
        Me.txtserie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtserie.Location = New System.Drawing.Point(155, 112)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(100, 20)
        Me.txtserie.TabIndex = 1
        '
        'txtnro
        '
        Me.txtnro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnro.Location = New System.Drawing.Point(155, 138)
        Me.txtnro.Name = "txtnro"
        Me.txtnro.Size = New System.Drawing.Size(100, 20)
        Me.txtnro.TabIndex = 2
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(826, 25)
        Me.tsbForm.TabIndex = 113
        Me.tsbForm.Text = "Grabar"
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
        'btnduplicar
        '
        Me.btnduplicar.Location = New System.Drawing.Point(106, 292)
        Me.btnduplicar.Name = "btnduplicar"
        Me.btnduplicar.Size = New System.Drawing.Size(75, 23)
        Me.btnduplicar.TabIndex = 8
        Me.btnduplicar.Text = "Duplicar"
        Me.btnduplicar.UseVisualStyleBackColor = True
        '
        'rdbagua
        '
        Me.rdbagua.AutoSize = True
        Me.rdbagua.Location = New System.Drawing.Point(20, 19)
        Me.rdbagua.Name = "rdbagua"
        Me.rdbagua.Size = New System.Drawing.Size(50, 17)
        Me.rdbagua.TabIndex = 115
        Me.rdbagua.TabStop = True
        Me.rdbagua.Text = "Agua"
        Me.rdbagua.UseVisualStyleBackColor = True
        Me.rdbagua.Visible = False
        '
        'rdbluz
        '
        Me.rdbluz.AutoSize = True
        Me.rdbluz.Location = New System.Drawing.Point(110, 19)
        Me.rdbluz.Name = "rdbluz"
        Me.rdbluz.Size = New System.Drawing.Size(42, 17)
        Me.rdbluz.TabIndex = 116
        Me.rdbluz.TabStop = True
        Me.rdbluz.Text = "Luz"
        Me.rdbluz.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtruc)
        Me.GroupBox1.Controls.Add(Me.cmbtipo)
        Me.GroupBox1.Controls.Add(Me.rdbgas)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.rdbluz)
        Me.GroupBox1.Controls.Add(Me.rdbagua)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 78)
        Me.GroupBox1.TabIndex = 117
        Me.GroupBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 122
        Me.Label9.Text = "Ruc"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "Empresa"
        '
        'txtruc
        '
        Me.txtruc.Location = New System.Drawing.Point(76, 42)
        Me.txtruc.Name = "txtruc"
        Me.txtruc.ReadOnly = True
        Me.txtruc.Size = New System.Drawing.Size(193, 20)
        Me.txtruc.TabIndex = 120
        '
        'cmbtipo
        '
        Me.cmbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"AGUA", "LUZ", "GAS", "TELEFONO", "INTERNET TORRES", "PEAJE LINEA AMARILLA 11.40", "PEAJE LINEA AMARILLA 5", "PACIFICO SEGUROS EMPLEADOS", "PACIFICO SEGUROS OBREROS", "GRIFO JIARA S.A.C 50", "GRIFO JIARA S.A.C 100", "CELULARES SIN IGV", "LUZ STATKRAFT SOLES", "LUZ STATKRAFT DOLARES", "INTERNET ELOY", "RIMAC OBREROS", "RIMAC EMPLEADOS", "GASTOS REPRESENTACION", "CELULARES IGV", "PEAJE LINEA AMARILLA 11.40 - 2", "PEAJE LINEA AMARILLA 10.40", "CREATECH INGENIERIA Y PROYECTO S.A.C.", "ENTEL", "MEDICO", "PEAJE LINEA AMARILLA 11.80"})
        Me.cmbtipo.Location = New System.Drawing.Point(76, 18)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(194, 21)
        Me.cmbtipo.TabIndex = 119
        '
        'rdbgas
        '
        Me.rdbgas.AutoSize = True
        Me.rdbgas.Location = New System.Drawing.Point(238, 19)
        Me.rdbgas.Name = "rdbgas"
        Me.rdbgas.Size = New System.Drawing.Size(44, 17)
        Me.rdbgas.TabIndex = 118
        Me.rdbgas.TabStop = True
        Me.rdbgas.Text = "Gas"
        Me.rdbgas.UseVisualStyleBackColor = True
        Me.rdbgas.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(180, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(52, 17)
        Me.RadioButton1.TabIndex = 117
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Peaje"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Monto Total"
        '
        'npdmonto_total
        '
        Me.npdmonto_total.DecimalPlaces = 4
        Me.npdmonto_total.Location = New System.Drawing.Point(155, 162)
        Me.npdmonto_total.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.npdmonto_total.Name = "npdmonto_total"
        Me.npdmonto_total.Size = New System.Drawing.Size(120, 20)
        Me.npdmonto_total.TabIndex = 3
        '
        'dgvt_doc
        '
        Me.dgvt_doc.AllowUserToAddRows = False
        Me.dgvt_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ordreq, Me.Cant_Per, Me.Luz, Me.afecto, Me.inafecto})
        Me.dgvt_doc.Location = New System.Drawing.Point(337, 46)
        Me.dgvt_doc.Name = "dgvt_doc"
        Me.dgvt_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc.Size = New System.Drawing.Size(463, 180)
        Me.dgvt_doc.TabIndex = 120
        '
        'ordreq
        '
        Me.ordreq.HeaderText = "Orden Requerimiento"
        Me.ordreq.Name = "ordreq"
        Me.ordreq.Width = 121
        '
        'Cant_Per
        '
        Me.Cant_Per.HeaderText = "Cantidad Personal"
        Me.Cant_Per.Name = "Cant_Per"
        Me.Cant_Per.Width = 108
        '
        'Luz
        '
        Me.Luz.HeaderText = "Luz"
        Me.Luz.Name = "Luz"
        Me.Luz.Width = 49
        '
        'afecto
        '
        Me.afecto.HeaderText = "Afecto"
        Me.afecto.Name = "afecto"
        Me.afecto.Width = 63
        '
        'inafecto
        '
        Me.inafecto.HeaderText = "Inafecto"
        Me.inafecto.Name = "inafecto"
        Me.inafecto.Width = 71
        '
        'npdestrrural
        '
        Me.npdestrrural.DecimalPlaces = 4
        Me.npdestrrural.Location = New System.Drawing.Point(155, 188)
        Me.npdestrrural.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.npdestrrural.Name = "npdestrrural"
        Me.npdestrrural.Size = New System.Drawing.Size(120, 20)
        Me.npdestrrural.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 121
        Me.Label6.Text = "Electrificacion Rural"
        '
        'npdigv
        '
        Me.npdigv.DecimalPlaces = 4
        Me.npdigv.Location = New System.Drawing.Point(155, 214)
        Me.npdigv.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.npdigv.Name = "npdigv"
        Me.npdigv.Size = New System.Drawing.Size(120, 20)
        Me.npdigv.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 123
        Me.Label7.Text = "IGV"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(271, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 123
        Me.Label10.Text = "Label10"
        Me.Label10.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(271, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 124
        Me.Label11.Text = "Label11"
        Me.Label11.Visible = False
        '
        'txt_fec_emi
        '
        Me.txt_fec_emi.Location = New System.Drawing.Point(155, 240)
        Me.txt_fec_emi.Mask = "00/00/0000"
        Me.txt_fec_emi.Name = "txt_fec_emi"
        Me.txt_fec_emi.Size = New System.Drawing.Size(90, 20)
        Me.txt_fec_emi.TabIndex = 125
        Me.txt_fec_emi.ValidatingType = GetType(Date)
        '
        'txtfecprov
        '
        Me.txtfecprov.Location = New System.Drawing.Point(155, 266)
        Me.txtfecprov.Mask = "00/00/0000"
        Me.txtfecprov.Name = "txtfecprov"
        Me.txtfecprov.Size = New System.Drawing.Size(90, 20)
        Me.txtfecprov.TabIndex = 126
        Me.txtfecprov.ValidatingType = GetType(Date)
        '
        'FormDuplicarDetDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 327)
        Me.Controls.Add(Me.txtfecprov)
        Me.Controls.Add(Me.txt_fec_emi)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.npdigv)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.npdestrrural)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvt_doc)
        Me.Controls.Add(Me.npdmonto_total)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnduplicar)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.txtnro)
        Me.Controls.Add(Me.txtserie)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtp_fec_emi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpfecprov)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormDuplicarDetDocumento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDuplicarDetDocumento"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.npdmonto_total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdestrrural, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdigv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpfecprov As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_fec_emi As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtserie As TextBox
    Friend WithEvents txtnro As TextBox
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents btnduplicar As Button
    Friend WithEvents rdbagua As RadioButton
    Friend WithEvents rdbluz As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents npdmonto_total As NumericUpDown
    Friend WithEvents dgvt_doc As DataGridView
    Friend WithEvents npdestrrural As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents npdigv As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents ordreq As DataGridViewTextBoxColumn
    Friend WithEvents Cant_Per As DataGridViewTextBoxColumn
    Friend WithEvents Luz As DataGridViewTextBoxColumn
    Friend WithEvents afecto As DataGridViewTextBoxColumn
    Friend WithEvents inafecto As DataGridViewTextBoxColumn
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents rdbgas As RadioButton
    Friend WithEvents cmbtipo As ComboBox
    Friend WithEvents txtruc As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_fec_emi As MaskedTextBox
    Friend WithEvents txtfecprov As MaskedTextBox
End Class
