<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMantPallet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantPallet))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.cmb_serdoc = New System.Windows.Forms.ComboBox()
        Me.cmbt_doc = New System.Windows.Forms.ComboBox()
        Me.txtt_doc = New System.Windows.Forms.TextBox()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtobserva2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.npdcantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtfardo = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtlote = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbturno = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbdni = New System.Windows.Forms.ComboBox()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.GroupBox3.SuspendLayout()
        Me.tsbForm.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.npdcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Tipo Documento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(595, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "Estado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(502, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(417, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Numero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Serie"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbestado)
        Me.GroupBox3.Controls.Add(Me.dtpfecha)
        Me.GroupBox3.Controls.Add(Me.txtnumero)
        Me.GroupBox3.Controls.Add(Me.cmb_serdoc)
        Me.GroupBox3.Controls.Add(Me.cmbt_doc)
        Me.GroupBox3.Controls.Add(Me.txtt_doc)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 31)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(657, 42)
        Me.GroupBox3.TabIndex = 103
        Me.GroupBox3.TabStop = False
        '
        'cmbestado
        '
        Me.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"Activo", "Anulado", "Compra", "Transferido", "Suspendido", "Previo"})
        Me.cmbestado.Location = New System.Drawing.Point(565, 14)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(86, 21)
        Me.cmbestado.TabIndex = 7
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(477, 16)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(82, 20)
        Me.dtpfecha.TabIndex = 5
        '
        'txtnumero
        '
        Me.txtnumero.Enabled = False
        Me.txtnumero.Location = New System.Drawing.Point(393, 16)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(78, 20)
        Me.txtnumero.TabIndex = 4
        '
        'cmb_serdoc
        '
        Me.cmb_serdoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_serdoc.FormattingEnabled = True
        Me.cmb_serdoc.Items.AddRange(New Object() {"ALM", "ASQ", "AUD", "COM", "DES", "ENS", "GER", "ING", "PRO", "PRE", "REH", "TWO", "VEN", "001", "COR", "INF"})
        Me.cmb_serdoc.Location = New System.Drawing.Point(316, 16)
        Me.cmb_serdoc.Name = "cmb_serdoc"
        Me.cmb_serdoc.Size = New System.Drawing.Size(71, 21)
        Me.cmb_serdoc.TabIndex = 3
        '
        'cmbt_doc
        '
        Me.cmbt_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbt_doc.FormattingEnabled = True
        Me.cmbt_doc.Location = New System.Drawing.Point(65, 15)
        Me.cmbt_doc.Name = "cmbt_doc"
        Me.cmbt_doc.Size = New System.Drawing.Size(225, 21)
        Me.cmbt_doc.TabIndex = 2
        '
        'txtt_doc
        '
        Me.txtt_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtt_doc.Location = New System.Drawing.Point(6, 15)
        Me.txtt_doc.Name = "txtt_doc"
        Me.txtt_doc.Size = New System.Drawing.Size(48, 20)
        Me.txtt_doc.TabIndex = 1
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbimprimir, Me.ToolStripButton1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(729, 25)
        Me.tsbForm.TabIndex = 110
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtobserva2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.npdcantidad)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtfardo)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtlote)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cmbturno)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(688, 192)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'txtobserva2
        '
        Me.txtobserva2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtobserva2.Enabled = False
        Me.txtobserva2.Location = New System.Drawing.Point(19, 141)
        Me.txtobserva2.Multiline = True
        Me.txtobserva2.Name = "txtobserva2"
        Me.txtobserva2.Size = New System.Drawing.Size(651, 44)
        Me.txtobserva2.TabIndex = 119
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 118
        Me.Label6.Text = "Observación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "Fec. Produccion"
        '
        'npdcantidad
        '
        Me.npdcantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.npdcantidad.DecimalPlaces = 3
        Me.npdcantidad.Enabled = False
        Me.npdcantidad.Location = New System.Drawing.Point(547, 91)
        Me.npdcantidad.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.npdcantidad.Name = "npdcantidad"
        Me.npdcantidad.Size = New System.Drawing.Size(120, 20)
        Me.npdcantidad.TabIndex = 115
        Me.npdcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(577, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 116
        Me.Label15.Text = "Cantidad"
        '
        'txtfardo
        '
        Me.txtfardo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtfardo.Enabled = False
        Me.txtfardo.Location = New System.Drawing.Point(422, 91)
        Me.txtfardo.Name = "txtfardo"
        Me.txtfardo.Size = New System.Drawing.Size(119, 20)
        Me.txtfardo.TabIndex = 111
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(463, 76)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(34, 13)
        Me.Label20.TabIndex = 114
        Me.Label20.Text = "Fardo"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(183, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 13)
        Me.Label16.TabIndex = 113
        Me.Label16.Text = "Turno"
        '
        'txtlote
        '
        Me.txtlote.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtlote.Enabled = False
        Me.txtlote.Location = New System.Drawing.Point(297, 91)
        Me.txtlote.Name = "txtlote"
        Me.txtlote.Size = New System.Drawing.Size(119, 20)
        Me.txtlote.TabIndex = 110
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(328, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 13)
        Me.Label13.TabIndex = 112
        Me.Label13.Text = "Lote"
        '
        'cmbturno
        '
        Me.cmbturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbturno.Enabled = False
        Me.cmbturno.FormattingEnabled = True
        Me.cmbturno.Items.AddRange(New Object() {"8:00 a.m. - 5:15 p.m.", "8:00 p.m. - 5:15 a.m."})
        Me.cmbturno.Location = New System.Drawing.Point(123, 91)
        Me.cmbturno.Name = "cmbturno"
        Me.cmbturno.Size = New System.Drawing.Size(168, 21)
        Me.cmbturno.TabIndex = 109
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(19, 92)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePicker1.TabIndex = 108
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmbdni)
        Me.GroupBox2.Controls.Add(Me.txtdni)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 226)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(688, 100)
        Me.GroupBox2.TabIndex = 111
        Me.GroupBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(46, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Empacador Linea"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.ItemHeight = 13
        Me.ComboBox2.Location = New System.Drawing.Point(101, 73)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(226, 21)
        Me.ComboBox2.TabIndex = 22
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 73)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(84, 20)
        Me.TextBox2.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(386, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Encargado Linea"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ItemHeight = 13
        Me.ComboBox1.Location = New System.Drawing.Point(441, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(226, 21)
        Me.ComboBox1.TabIndex = 19
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(352, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(84, 20)
        Me.TextBox1.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(74, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Supervisor Linea"
        '
        'cmbdni
        '
        Me.cmbdni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdni.FormattingEnabled = True
        Me.cmbdni.ItemHeight = 13
        Me.cmbdni.Location = New System.Drawing.Point(101, 33)
        Me.cmbdni.Name = "cmbdni"
        Me.cmbdni.Size = New System.Drawing.Size(226, 21)
        Me.cmbdni.TabIndex = 16
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(12, 33)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(84, 20)
        Me.txtdni.TabIndex = 15
        '
        'FormMantPallet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 404)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tsbForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormMantPallet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPallet"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.npdcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cmbturno As ComboBox
    Friend WithEvents txtfardo As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtlote As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents npdcantidad As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtobserva2 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbdni As ComboBox
    Friend WithEvents txtdni As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
End Class
