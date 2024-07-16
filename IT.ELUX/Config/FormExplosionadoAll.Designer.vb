<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExplosionadoAll
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormExplosionadoAll))
        Me.tvwExplosion = New System.Windows.Forms.TreeView()
        Me.imgExplosion = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnomartpri = New System.Windows.Forms.TextBox()
        Me.txtartcodpri = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtnomart = New System.Windows.Forms.TextBox()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnbus = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.cmbSublineas = New System.Windows.Forms.ComboBox()
        Me.cmbLineas = New System.Windows.Forms.ComboBox()
        Me.txtcodart = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbtipocomp = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.npdcantcomp = New System.Windows.Forms.NumericUpDown()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnmod = New System.Windows.Forms.Button()
        Me.btnquitar = New System.Windows.Forms.Button()
        Me.dgvcomponente = New System.Windows.Forms.DataGridView()
        Me.txtcodartpart = New System.Windows.Forms.TextBox()
        Me.txtnomartpart = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.lblcc = New System.Windows.Forms.Label()
        Me.lblcodalm = New System.Windows.Forms.Label()
        Me.lblund = New System.Windows.Forms.Label()
        Me.lblformato = New System.Windows.Forms.Label()
        Me.dgvnivel1 = New System.Windows.Forms.DataGridView()
        Me.lblproc = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgvarbol = New System.Windows.Forms.DataGridView()
        Me.lblart_solm = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.npdcantcomp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvcomponente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsbForm.SuspendLayout()
        CType(Me.dgvnivel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvarbol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tvwExplosion
        '
        Me.tvwExplosion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvwExplosion.ImageIndex = 0
        Me.tvwExplosion.ImageList = Me.imgExplosion
        Me.tvwExplosion.Location = New System.Drawing.Point(661, 28)
        Me.tvwExplosion.Name = "tvwExplosion"
        Me.tvwExplosion.SelectedImageIndex = 0
        Me.tvwExplosion.Size = New System.Drawing.Size(502, 257)
        Me.tvwExplosion.TabIndex = 0
        '
        'imgExplosion
        '
        Me.imgExplosion.ImageStream = CType(resources.GetObject("imgExplosion.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgExplosion.TransparentColor = System.Drawing.Color.Transparent
        Me.imgExplosion.Images.SetKeyName(0, "can.ico")
        Me.imgExplosion.Images.SetKeyName(1, "componentes2.ico")
        Me.imgExplosion.Images.SetKeyName(2, "insumos.ico")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Articulo Raiz"
        '
        'txtnomartpri
        '
        Me.txtnomartpri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnomartpri.Location = New System.Drawing.Point(177, 33)
        Me.txtnomartpri.Name = "txtnomartpri"
        Me.txtnomartpri.ReadOnly = True
        Me.txtnomartpri.Size = New System.Drawing.Size(478, 20)
        Me.txtnomartpri.TabIndex = 2
        '
        'txtartcodpri
        '
        Me.txtartcodpri.Location = New System.Drawing.Point(99, 33)
        Me.txtartcodpri.MaxLength = 8
        Me.txtartcodpri.Name = "txtartcodpri"
        Me.txtartcodpri.ReadOnly = True
        Me.txtartcodpri.Size = New System.Drawing.Size(72, 20)
        Me.txtartcodpri.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.txtnomart)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.btnbus)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.cmbSublineas)
        Me.GroupBox1.Controls.Add(Me.cmbLineas)
        Me.GroupBox1.Controls.Add(Me.txtcodart)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.cmbtipocomp)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.npdcantcomp)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.btnmod)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(650, 171)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Articulos"
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(602, 99)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(32, 23)
        Me.btnbuscar.TabIndex = 93
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'txtnomart
        '
        Me.txtnomart.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnomart.Location = New System.Drawing.Point(156, 100)
        Me.txtnomart.Name = "txtnomart"
        Me.txtnomart.Size = New System.Drawing.Size(440, 20)
        Me.txtnomart.TabIndex = 91
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(407, 126)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(61, 23)
        Me.btnnuevo.TabIndex = 92
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btnbus
        '
        Me.btnbus.Location = New System.Drawing.Point(474, 126)
        Me.btnbus.Name = "btnbus"
        Me.btnbus.Size = New System.Drawing.Size(92, 23)
        Me.btnbus.TabIndex = 82
        Me.btnbus.Text = "Buscar Sublinea"
        Me.btnbus.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(572, 126)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(62, 23)
        Me.btnsave.TabIndex = 80
        Me.btnsave.Text = "Guardar"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'cmbSublineas
        '
        Me.cmbSublineas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSublineas.FormattingEnabled = True
        Me.cmbSublineas.Location = New System.Drawing.Point(84, 73)
        Me.cmbSublineas.Name = "cmbSublineas"
        Me.cmbSublineas.Size = New System.Drawing.Size(418, 21)
        Me.cmbSublineas.TabIndex = 46
        '
        'cmbLineas
        '
        Me.cmbLineas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLineas.FormattingEnabled = True
        Me.cmbLineas.Location = New System.Drawing.Point(84, 46)
        Me.cmbLineas.Name = "cmbLineas"
        Me.cmbLineas.Size = New System.Drawing.Size(389, 21)
        Me.cmbLineas.TabIndex = 45
        '
        'txtcodart
        '
        Me.txtcodart.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodart.Location = New System.Drawing.Point(84, 100)
        Me.txtcodart.MaxLength = 8
        Me.txtcodart.Name = "txtcodart"
        Me.txtcodart.ReadOnly = True
        Me.txtcodart.Size = New System.Drawing.Size(66, 20)
        Me.txtcodart.TabIndex = 44
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 76)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(61, 13)
        Me.Label25.TabIndex = 39
        Me.Label25.Text = "Sub Linea :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(28, 49)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(39, 13)
        Me.Label24.TabIndex = 38
        Me.Label24.Text = "Linea :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(21, 103)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(46, 13)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "Codigo :"
        '
        'cmbtipocomp
        '
        Me.cmbtipocomp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipocomp.FormattingEnabled = True
        Me.cmbtipocomp.Items.AddRange(New Object() {"01 Componente", "02 Insumo"})
        Me.cmbtipocomp.Location = New System.Drawing.Point(84, 19)
        Me.cmbtipocomp.Name = "cmbtipocomp"
        Me.cmbtipocomp.Size = New System.Drawing.Size(163, 21)
        Me.cmbtipocomp.TabIndex = 35
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(33, 22)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(34, 13)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "Tipo :"
        '
        'npdcantcomp
        '
        Me.npdcantcomp.DecimalPlaces = 7
        Me.npdcantcomp.Location = New System.Drawing.Point(353, 19)
        Me.npdcantcomp.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.npdcantcomp.Name = "npdcantcomp"
        Me.npdcantcomp.Size = New System.Drawing.Size(120, 20)
        Me.npdcantcomp.TabIndex = 33
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(293, 22)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 13)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "Factor :"
        '
        'btnmod
        '
        Me.btnmod.Location = New System.Drawing.Point(572, 126)
        Me.btnmod.Name = "btnmod"
        Me.btnmod.Size = New System.Drawing.Size(62, 23)
        Me.btnmod.TabIndex = 81
        Me.btnmod.Text = "Modificar"
        Me.btnmod.UseVisualStyleBackColor = True
        '
        'btnquitar
        '
        Me.btnquitar.Location = New System.Drawing.Point(587, 85)
        Me.btnquitar.Name = "btnquitar"
        Me.btnquitar.Size = New System.Drawing.Size(62, 23)
        Me.btnquitar.TabIndex = 77
        Me.btnquitar.Text = "Quitar"
        Me.btnquitar.UseVisualStyleBackColor = True
        '
        'dgvcomponente
        '
        Me.dgvcomponente.AllowUserToAddRows = False
        Me.dgvcomponente.AllowUserToDeleteRows = False
        Me.dgvcomponente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvcomponente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcomponente.Location = New System.Drawing.Point(668, 179)
        Me.dgvcomponente.Name = "dgvcomponente"
        Me.dgvcomponente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvcomponente.Size = New System.Drawing.Size(476, 95)
        Me.dgvcomponente.TabIndex = 10
        Me.dgvcomponente.Visible = False
        '
        'txtcodartpart
        '
        Me.txtcodartpart.Location = New System.Drawing.Point(99, 59)
        Me.txtcodartpart.MaxLength = 8
        Me.txtcodartpart.Name = "txtcodartpart"
        Me.txtcodartpart.ReadOnly = True
        Me.txtcodartpart.Size = New System.Drawing.Size(72, 20)
        Me.txtcodartpart.TabIndex = 12
        '
        'txtnomartpart
        '
        Me.txtnomartpart.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnomartpart.Location = New System.Drawing.Point(177, 59)
        Me.txtnomartpart.Name = "txtnomartpart"
        Me.txtnomartpart.ReadOnly = True
        Me.txtnomartpart.Size = New System.Drawing.Size(478, 20)
        Me.txtnomartpart.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(20, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Articulo Sec."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(1171, 25)
        Me.tsbForm.TabIndex = 74
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
        'lblcc
        '
        Me.lblcc.AutoSize = True
        Me.lblcc.Location = New System.Drawing.Point(693, 55)
        Me.lblcc.Name = "lblcc"
        Me.lblcc.Size = New System.Drawing.Size(0, 13)
        Me.lblcc.TabIndex = 85
        Me.lblcc.Visible = False
        '
        'lblcodalm
        '
        Me.lblcodalm.AutoSize = True
        Me.lblcodalm.Location = New System.Drawing.Point(699, 55)
        Me.lblcodalm.Name = "lblcodalm"
        Me.lblcodalm.Size = New System.Drawing.Size(0, 13)
        Me.lblcodalm.TabIndex = 86
        Me.lblcodalm.Visible = False
        '
        'lblund
        '
        Me.lblund.AutoSize = True
        Me.lblund.Location = New System.Drawing.Point(693, 90)
        Me.lblund.Name = "lblund"
        Me.lblund.Size = New System.Drawing.Size(0, 13)
        Me.lblund.TabIndex = 87
        Me.lblund.Visible = False
        '
        'lblformato
        '
        Me.lblformato.AutoSize = True
        Me.lblformato.Location = New System.Drawing.Point(724, 90)
        Me.lblformato.Name = "lblformato"
        Me.lblformato.Size = New System.Drawing.Size(0, 13)
        Me.lblformato.TabIndex = 88
        Me.lblformato.Visible = False
        '
        'dgvnivel1
        '
        Me.dgvnivel1.AllowUserToAddRows = False
        Me.dgvnivel1.AllowUserToDeleteRows = False
        Me.dgvnivel1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvnivel1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvnivel1.Location = New System.Drawing.Point(7, 121)
        Me.dgvnivel1.Name = "dgvnivel1"
        Me.dgvnivel1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvnivel1.Size = New System.Drawing.Size(642, 103)
        Me.dgvnivel1.TabIndex = 90
        Me.dgvnivel1.Visible = False
        '
        'lblproc
        '
        Me.lblproc.AutoSize = True
        Me.lblproc.Location = New System.Drawing.Point(754, 99)
        Me.lblproc.Name = "lblproc"
        Me.lblproc.Size = New System.Drawing.Size(0, 13)
        Me.lblproc.TabIndex = 91
        Me.lblproc.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(519, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 23)
        Me.Button2.TabIndex = 94
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(814, 99)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(0, 13)
        Me.lbltipo.TabIndex = 95
        Me.lbltipo.Visible = False
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(808, 99)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(0, 13)
        Me.lblcantidad.TabIndex = 96
        Me.lblcantidad.Visible = False
        '
        'dgvarbol
        '
        Me.dgvarbol.AllowUserToAddRows = False
        Me.dgvarbol.AllowUserToDeleteRows = False
        Me.dgvarbol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvarbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvarbol.Location = New System.Drawing.Point(668, 179)
        Me.dgvarbol.Name = "dgvarbol"
        Me.dgvarbol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvarbol.Size = New System.Drawing.Size(476, 95)
        Me.dgvarbol.TabIndex = 97
        Me.dgvarbol.Visible = False
        '
        'lblart_solm
        '
        Me.lblart_solm.AutoSize = True
        Me.lblart_solm.Location = New System.Drawing.Point(728, 147)
        Me.lblart_solm.Name = "lblart_solm"
        Me.lblart_solm.Size = New System.Drawing.Size(0, 13)
        Me.lblart_solm.TabIndex = 98
        Me.lblart_solm.Visible = False
        '
        'FormExplosionadoAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 306)
        Me.Controls.Add(Me.lblart_solm)
        Me.Controls.Add(Me.dgvarbol)
        Me.Controls.Add(Me.lblcantidad)
        Me.Controls.Add(Me.lbltipo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgvcomponente)
        Me.Controls.Add(Me.lblproc)
        Me.Controls.Add(Me.txtartcodpri)
        Me.Controls.Add(Me.txtnomartpri)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnquitar)
        Me.Controls.Add(Me.lblformato)
        Me.Controls.Add(Me.lblund)
        Me.Controls.Add(Me.lblcodalm)
        Me.Controls.Add(Me.lblcc)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcodartpart)
        Me.Controls.Add(Me.txtnomartpart)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvnivel1)
        Me.Controls.Add(Me.tvwExplosion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "FormExplosionadoAll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.npdcantcomp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvcomponente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        CType(Me.dgvnivel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvarbol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnomartpri As TextBox
    Friend WithEvents imgExplosion As ImageList
    Friend WithEvents txtartcodpri As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents npdcantcomp As NumericUpDown
    Friend WithEvents Label23 As Label
    Friend WithEvents cmbtipocomp As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents cmbSublineas As ComboBox
    Friend WithEvents cmbLineas As ComboBox
    Friend WithEvents txtcodart As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents tvwExplosion As TreeView
    Friend WithEvents dgvcomponente As DataGridView
    Friend WithEvents txtcodartpart As TextBox
    Friend WithEvents txtnomartpart As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents btnquitar As Button
    Friend WithEvents btnbus As Button
    Friend WithEvents btnmod As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents lblcc As Label
    Friend WithEvents lblcodalm As Label
    Friend WithEvents lblund As Label
    Friend WithEvents lblformato As Label
    Friend WithEvents dgvnivel1 As DataGridView
    Friend WithEvents btnnuevo As Button
    Friend WithEvents txtnomart As TextBox
    Friend WithEvents lblproc As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents lbltipo As Label
    Friend WithEvents lblcantidad As Label
    Friend WithEvents btnbuscar As Button
    Friend WithEvents dgvarbol As DataGridView
    Friend WithEvents lblart_solm As Label
End Class
