<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormELTBPreciosArt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormELTBPreciosArt))
        Me.dgvt_doc = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.txtart_cod = New System.Windows.Forms.TextBox()
        Me.txtdoc = New System.Windows.Forms.TextBox()
        Me.dtpfec_gene = New System.Windows.Forms.DateTimePicker()
        Me.npdpreciodolares = New System.Windows.Forms.NumericUpDown()
        Me.npdpreciosoles = New System.Windows.Forms.NumericUpDown()
        Me.cmbmon = New System.Windows.Forms.ComboBox()
        Me.txtmon = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdpreciodolares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdpreciosoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsbForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvt_doc
        '
        Me.dgvt_doc.AllowUserToAddRows = False
        Me.dgvt_doc.AllowUserToDeleteRows = False
        Me.dgvt_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc.Location = New System.Drawing.Point(12, 149)
        Me.dgvt_doc.Name = "dgvt_doc"
        Me.dgvt_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc.Size = New System.Drawing.Size(659, 208)
        Me.dgvt_doc.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Proveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Articulo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Moneda"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(448, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Precio Soles"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(448, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Precio Dolares"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(448, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Fecha"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Documento"
        '
        'txtproveedor
        '
        Me.txtproveedor.Location = New System.Drawing.Point(94, 42)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.ReadOnly = True
        Me.txtproveedor.Size = New System.Drawing.Size(89, 20)
        Me.txtproveedor.TabIndex = 40
        '
        'txtart_cod
        '
        Me.txtart_cod.Location = New System.Drawing.Point(94, 68)
        Me.txtart_cod.MaxLength = 8
        Me.txtart_cod.Name = "txtart_cod"
        Me.txtart_cod.ReadOnly = True
        Me.txtart_cod.Size = New System.Drawing.Size(89, 20)
        Me.txtart_cod.TabIndex = 41
        '
        'txtdoc
        '
        Me.txtdoc.Location = New System.Drawing.Point(94, 118)
        Me.txtdoc.Name = "txtdoc"
        Me.txtdoc.ReadOnly = True
        Me.txtdoc.Size = New System.Drawing.Size(563, 20)
        Me.txtdoc.TabIndex = 43
        '
        'dtpfec_gene
        '
        Me.dtpfec_gene.Enabled = False
        Me.dtpfec_gene.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_gene.Location = New System.Drawing.Point(537, 92)
        Me.dtpfec_gene.Name = "dtpfec_gene"
        Me.dtpfec_gene.Size = New System.Drawing.Size(95, 20)
        Me.dtpfec_gene.TabIndex = 44
        '
        'npdpreciodolares
        '
        Me.npdpreciodolares.DecimalPlaces = 3
        Me.npdpreciodolares.Enabled = False
        Me.npdpreciodolares.Location = New System.Drawing.Point(537, 69)
        Me.npdpreciodolares.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npdpreciodolares.Name = "npdpreciodolares"
        Me.npdpreciodolares.Size = New System.Drawing.Size(120, 20)
        Me.npdpreciodolares.TabIndex = 45
        '
        'npdpreciosoles
        '
        Me.npdpreciosoles.DecimalPlaces = 3
        Me.npdpreciosoles.Enabled = False
        Me.npdpreciosoles.Location = New System.Drawing.Point(537, 43)
        Me.npdpreciosoles.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npdpreciosoles.Name = "npdpreciosoles"
        Me.npdpreciosoles.Size = New System.Drawing.Size(120, 20)
        Me.npdpreciosoles.TabIndex = 46
        '
        'cmbmon
        '
        Me.cmbmon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmon.Enabled = False
        Me.cmbmon.FormattingEnabled = True
        Me.cmbmon.Location = New System.Drawing.Point(134, 91)
        Me.cmbmon.Name = "cmbmon"
        Me.cmbmon.Size = New System.Drawing.Size(158, 21)
        Me.cmbmon.TabIndex = 47
        '
        'txtmon
        '
        Me.txtmon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmon.Location = New System.Drawing.Point(94, 92)
        Me.txtmon.Name = "txtmon"
        Me.txtmon.ReadOnly = True
        Me.txtmon.Size = New System.Drawing.Size(34, 20)
        Me.txtmon.TabIndex = 48
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(189, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(253, 20)
        Me.TextBox1.TabIndex = 49
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(189, 68)
        Me.TextBox2.MaxLength = 8
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(253, 20)
        Me.TextBox2.TabIndex = 50
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbimprimir, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(685, 25)
        Me.tsbForm.TabIndex = 51
        Me.tsbForm.Text = "Grabar"
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
        'FormELTBPreciosArt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 369)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtmon)
        Me.Controls.Add(Me.cmbmon)
        Me.Controls.Add(Me.npdpreciosoles)
        Me.Controls.Add(Me.npdpreciodolares)
        Me.Controls.Add(Me.dtpfec_gene)
        Me.Controls.Add(Me.txtdoc)
        Me.Controls.Add(Me.txtart_cod)
        Me.Controls.Add(Me.txtproveedor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvt_doc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormELTBPreciosArt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormELTBPreciosArt"
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdpreciodolares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdpreciosoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvt_doc As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtproveedor As TextBox
    Friend WithEvents txtart_cod As TextBox
    Friend WithEvents txtdoc As TextBox
    Friend WithEvents dtpfec_gene As DateTimePicker
    Friend WithEvents npdpreciodolares As NumericUpDown
    Friend WithEvents npdpreciosoles As NumericUpDown
    Friend WithEvents cmbmon As ComboBox
    Friend WithEvents txtmon As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
End Class
