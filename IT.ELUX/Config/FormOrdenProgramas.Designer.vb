<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrdenProgramas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOrdenProgramas))
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnsolm = New System.Windows.Forms.Button()
        Me.btncal = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtnomgrup = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtnom_cco = New System.Windows.Forms.TextBox()
        Me.txtcco_cod = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btndocu = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbturno = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvt_doc = New System.Windows.Forms.DataGridView()
        Me.Seq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cod_Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pendiente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Atendido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Duracion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_ini = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_dif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_DOC_REF1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SER_DOC_REF1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRO_DOC_REF1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dif_hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtdocumento = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtgrupo_tra = New System.Windows.Forms.TextBox()
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpfec_fin = New System.Windows.Forms.DateTimePicker()
        Me.dtpfec_inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbllin_prod = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtlin_prod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tspr = New System.Windows.Forms.ToolStripButton()
        Me.tsbForm.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.General.SuspendLayout()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbimprimir, Me.tspr, Me.ToolStripButton1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(895, 25)
        Me.tsbForm.TabIndex = 24
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 36)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(871, 504)
        Me.TabControl1.TabIndex = 25
        '
        'General
        '
        Me.General.BackColor = System.Drawing.Color.White
        Me.General.Controls.Add(Me.Label11)
        Me.General.Controls.Add(Me.btnsolm)
        Me.General.Controls.Add(Me.btncal)
        Me.General.Controls.Add(Me.btnmodificar)
        Me.General.Controls.Add(Me.Button4)
        Me.General.Controls.Add(Me.txtnomgrup)
        Me.General.Controls.Add(Me.Button3)
        Me.General.Controls.Add(Me.txtnom_cco)
        Me.General.Controls.Add(Me.txtcco_cod)
        Me.General.Controls.Add(Me.Label10)
        Me.General.Controls.Add(Me.Button2)
        Me.General.Controls.Add(Me.btndocu)
        Me.General.Controls.Add(Me.TextBox1)
        Me.General.Controls.Add(Me.TextBox2)
        Me.General.Controls.Add(Me.Label2)
        Me.General.Controls.Add(Me.Label9)
        Me.General.Controls.Add(Me.cmbturno)
        Me.General.Controls.Add(Me.Button5)
        Me.General.Controls.Add(Me.btnQuitar)
        Me.General.Controls.Add(Me.btnAgregar)
        Me.General.Controls.Add(Me.dgvt_doc)
        Me.General.Controls.Add(Me.txtdocumento)
        Me.General.Controls.Add(Me.Label8)
        Me.General.Controls.Add(Me.txtgrupo_tra)
        Me.General.Controls.Add(Me.cmbestado)
        Me.General.Controls.Add(Me.Label7)
        Me.General.Controls.Add(Me.Label6)
        Me.General.Controls.Add(Me.Label5)
        Me.General.Controls.Add(Me.dtpfec_fin)
        Me.General.Controls.Add(Me.dtpfec_inicio)
        Me.General.Controls.Add(Me.Label4)
        Me.General.Controls.Add(Me.lbllin_prod)
        Me.General.Controls.Add(Me.Label3)
        Me.General.Controls.Add(Me.txtlin_prod)
        Me.General.Controls.Add(Me.Label1)
        Me.General.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(863, 478)
        Me.General.TabIndex = 0
        Me.General.Text = "GENERAL"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(445, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 265
        Me.Label11.Text = "Label11"
        Me.Label11.Visible = False
        '
        'btnsolm
        '
        Me.btnsolm.Location = New System.Drawing.Point(787, 277)
        Me.btnsolm.Name = "btnsolm"
        Me.btnsolm.Size = New System.Drawing.Size(70, 24)
        Me.btnsolm.TabIndex = 263
        Me.btnsolm.Text = "Solm/Tiempo"
        Me.btnsolm.UseVisualStyleBackColor = True
        '
        'btncal
        '
        Me.btncal.Location = New System.Drawing.Point(443, 133)
        Me.btncal.Name = "btncal"
        Me.btncal.Size = New System.Drawing.Size(97, 24)
        Me.btncal.TabIndex = 262
        Me.btncal.Text = "Calcular"
        Me.btncal.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(787, 277)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(70, 24)
        Me.btnmodificar.TabIndex = 258
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(443, 104)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(39, 23)
        Me.Button4.TabIndex = 257
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtnomgrup
        '
        Me.txtnomgrup.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnomgrup.Location = New System.Drawing.Point(164, 104)
        Me.txtnomgrup.MaxLength = 15
        Me.txtnomgrup.Name = "txtnomgrup"
        Me.txtnomgrup.ReadOnly = True
        Me.txtnomgrup.Size = New System.Drawing.Size(273, 21)
        Me.txtnomgrup.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(443, 48)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(39, 23)
        Me.Button3.TabIndex = 255
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtnom_cco
        '
        Me.txtnom_cco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnom_cco.Location = New System.Drawing.Point(159, 50)
        Me.txtnom_cco.Name = "txtnom_cco"
        Me.txtnom_cco.ReadOnly = True
        Me.txtnom_cco.Size = New System.Drawing.Size(278, 21)
        Me.txtnom_cco.TabIndex = 2
        '
        'txtcco_cod
        '
        Me.txtcco_cod.Location = New System.Drawing.Point(101, 50)
        Me.txtcco_cod.MaxLength = 4
        Me.txtcco_cod.Name = "txtcco_cod"
        Me.txtcco_cod.Size = New System.Drawing.Size(52, 21)
        Me.txtcco_cod.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 254
        Me.Label10.Text = "C. Costo"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(443, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 23)
        Me.Button2.TabIndex = 251
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btndocu
        '
        Me.btndocu.Location = New System.Drawing.Point(788, 277)
        Me.btndocu.Name = "btndocu"
        Me.btndocu.Size = New System.Drawing.Size(70, 24)
        Me.btndocu.TabIndex = 13
        Me.btndocu.Text = "Docum"
        Me.btndocu.UseVisualStyleBackColor = True
        Me.btndocu.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(164, 158)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(273, 21)
        Me.TextBox1.TabIndex = 249
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(101, 158)
        Me.TextBox2.MaxLength = 15
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(62, 21)
        Me.TextBox2.TabIndex = 248
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 23)
        Me.Label2.TabIndex = 247
        Me.Label2.Text = "Maquina"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(417, 23)
        Me.Label9.TabIndex = 246
        Me.Label9.Text = "Arrastre los items hacia arriba o abajo para ordenarlos según su criterio"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbturno
        '
        Me.cmbturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbturno.FormattingEnabled = True
        Me.cmbturno.Items.AddRange(New Object() {"8:00 a.m. - 5:15 p.m.", "8:00 p.m. - 5:15 a.m."})
        Me.cmbturno.Location = New System.Drawing.Point(102, 131)
        Me.cmbturno.Name = "cmbturno"
        Me.cmbturno.Size = New System.Drawing.Size(119, 21)
        Me.cmbturno.TabIndex = 7
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(798, 430)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(31, 24)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Σ"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(787, 247)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(70, 24)
        Me.btnQuitar.TabIndex = 11
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Location = New System.Drawing.Point(787, 217)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(70, 24)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvt_doc
        '
        Me.dgvt_doc.AllowDrop = True
        Me.dgvt_doc.AllowUserToAddRows = False
        Me.dgvt_doc.AllowUserToDeleteRows = False
        Me.dgvt_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seq, Me.Cod_Articulo, Me.Articulo, Me.Cantidad, Me.Pendiente, Me.Atendido, Me.Duracion, Me.Fecha_ini, Me.Fecha_Fin, Me.EST, Me.PROC, Me.num_dif, Me.T_DOC_REF1, Me.SER_DOC_REF1, Me.NRO_DOC_REF1, Me.dif_hora})
        Me.dgvt_doc.Location = New System.Drawing.Point(20, 205)
        Me.dgvt_doc.Name = "dgvt_doc"
        Me.dgvt_doc.ReadOnly = True
        Me.dgvt_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc.Size = New System.Drawing.Size(761, 249)
        Me.dgvt_doc.TabIndex = 239
        '
        'Seq
        '
        Me.Seq.HeaderText = "Seq"
        Me.Seq.Name = "Seq"
        Me.Seq.ReadOnly = True
        Me.Seq.Width = 50
        '
        'Cod_Articulo
        '
        Me.Cod_Articulo.HeaderText = "Cod_Articulo"
        Me.Cod_Articulo.Name = "Cod_Articulo"
        Me.Cod_Articulo.ReadOnly = True
        Me.Cod_Articulo.Width = 93
        '
        'Articulo
        '
        Me.Articulo.HeaderText = "Articulo"
        Me.Articulo.Name = "Articulo"
        Me.Articulo.ReadOnly = True
        Me.Articulo.Width = 68
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 75
        '
        'Pendiente
        '
        Me.Pendiente.HeaderText = "Pendiente"
        Me.Pendiente.Name = "Pendiente"
        Me.Pendiente.ReadOnly = True
        Me.Pendiente.Width = 80
        '
        'Atendido
        '
        Me.Atendido.HeaderText = "Atendido"
        Me.Atendido.Name = "Atendido"
        Me.Atendido.ReadOnly = True
        Me.Atendido.Width = 75
        '
        'Duracion
        '
        Me.Duracion.HeaderText = "Duracion"
        Me.Duracion.Name = "Duracion"
        Me.Duracion.ReadOnly = True
        Me.Duracion.Width = 74
        '
        'Fecha_ini
        '
        Me.Fecha_ini.HeaderText = "Fecha Inicio"
        Me.Fecha_ini.Name = "Fecha_ini"
        Me.Fecha_ini.ReadOnly = True
        Me.Fecha_ini.Width = 89
        '
        'Fecha_Fin
        '
        Me.Fecha_Fin.HeaderText = "Fecha Fin"
        Me.Fecha_Fin.Name = "Fecha_Fin"
        Me.Fecha_Fin.ReadOnly = True
        Me.Fecha_Fin.Width = 78
        '
        'EST
        '
        Me.EST.HeaderText = "Estado"
        Me.EST.Name = "EST"
        Me.EST.ReadOnly = True
        Me.EST.Width = 65
        '
        'PROC
        '
        Me.PROC.HeaderText = "PROC"
        Me.PROC.Name = "PROC"
        Me.PROC.ReadOnly = True
        Me.PROC.Visible = False
        Me.PROC.Width = 60
        '
        'num_dif
        '
        Me.num_dif.HeaderText = "num_dif"
        Me.num_dif.Name = "num_dif"
        Me.num_dif.ReadOnly = True
        Me.num_dif.Visible = False
        Me.num_dif.Width = 70
        '
        'T_DOC_REF1
        '
        Me.T_DOC_REF1.HeaderText = "T_DOC_REF1"
        Me.T_DOC_REF1.Name = "T_DOC_REF1"
        Me.T_DOC_REF1.ReadOnly = True
        Me.T_DOC_REF1.Visible = False
        Me.T_DOC_REF1.Width = 97
        '
        'SER_DOC_REF1
        '
        Me.SER_DOC_REF1.HeaderText = "SER_DOC_REF1"
        Me.SER_DOC_REF1.Name = "SER_DOC_REF1"
        Me.SER_DOC_REF1.ReadOnly = True
        Me.SER_DOC_REF1.Visible = False
        Me.SER_DOC_REF1.Width = 110
        '
        'NRO_DOC_REF1
        '
        Me.NRO_DOC_REF1.HeaderText = "NRO_DOC_REF1"
        Me.NRO_DOC_REF1.Name = "NRO_DOC_REF1"
        Me.NRO_DOC_REF1.ReadOnly = True
        Me.NRO_DOC_REF1.Visible = False
        Me.NRO_DOC_REF1.Width = 113
        '
        'dif_hora
        '
        Me.dif_hora.HeaderText = "dif_hora"
        Me.dif_hora.Name = "dif_hora"
        Me.dif_hora.ReadOnly = True
        Me.dif_hora.Visible = False
        Me.dif_hora.Width = 72
        '
        'txtdocumento
        '
        Me.txtdocumento.BackColor = System.Drawing.Color.Gainsboro
        Me.txtdocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdocumento.Location = New System.Drawing.Point(102, 23)
        Me.txtdocumento.MaxLength = 9
        Me.txtdocumento.Name = "txtdocumento"
        Me.txtdocumento.ReadOnly = True
        Me.txtdocumento.Size = New System.Drawing.Size(119, 21)
        Me.txtdocumento.TabIndex = 237
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 23)
        Me.Label8.TabIndex = 236
        Me.Label8.Text = "Grupo Trabajo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtgrupo_tra
        '
        Me.txtgrupo_tra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtgrupo_tra.Location = New System.Drawing.Point(101, 104)
        Me.txtgrupo_tra.MaxLength = 4
        Me.txtgrupo_tra.Name = "txtgrupo_tra"
        Me.txtgrupo_tra.Size = New System.Drawing.Size(62, 21)
        Me.txtgrupo_tra.TabIndex = 5
        '
        'cmbestado
        '
        Me.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"ACTIVO", "PROCESADO", "DECLARADO", "CERRADO"})
        Me.cmbestado.Location = New System.Drawing.Point(633, 89)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(111, 21)
        Me.cmbestado.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(553, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 23)
        Me.Label7.TabIndex = 231
        Me.Label7.Text = "Estado"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(553, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 23)
        Me.Label6.TabIndex = 230
        Me.Label6.Text = "Fecha Fin"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(552, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 23)
        Me.Label5.TabIndex = 229
        Me.Label5.Text = "Fecha Inicio"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpfec_fin
        '
        Me.dtpfec_fin.Enabled = False
        Me.dtpfec_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_fin.Location = New System.Drawing.Point(633, 55)
        Me.dtpfec_fin.Name = "dtpfec_fin"
        Me.dtpfec_fin.Size = New System.Drawing.Size(174, 21)
        Me.dtpfec_fin.TabIndex = 9
        Me.dtpfec_fin.Value = New Date(2019, 3, 7, 0, 0, 0, 0)
        '
        'dtpfec_inicio
        '
        Me.dtpfec_inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_inicio.Location = New System.Drawing.Point(632, 23)
        Me.dtpfec_inicio.Name = "dtpfec_inicio"
        Me.dtpfec_inicio.Size = New System.Drawing.Size(175, 21)
        Me.dtpfec_inicio.TabIndex = 8
        Me.dtpfec_inicio.Value = New Date(2019, 3, 7, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 23)
        Me.Label4.TabIndex = 197
        Me.Label4.Text = "Turno"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbllin_prod
        '
        Me.lbllin_prod.BackColor = System.Drawing.SystemColors.Control
        Me.lbllin_prod.Location = New System.Drawing.Point(164, 77)
        Me.lbllin_prod.Name = "lbllin_prod"
        Me.lbllin_prod.ReadOnly = True
        Me.lbllin_prod.Size = New System.Drawing.Size(273, 21)
        Me.lbllin_prod.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 23)
        Me.Label3.TabIndex = 194
        Me.Label3.Text = "Area"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtlin_prod
        '
        Me.txtlin_prod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlin_prod.Location = New System.Drawing.Point(101, 77)
        Me.txtlin_prod.MaxLength = 4
        Me.txtlin_prod.Name = "txtlin_prod"
        Me.txtlin_prod.Size = New System.Drawing.Size(62, 21)
        Me.txtlin_prod.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Documento"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tspr
        '
        Me.tspr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tspr.Image = CType(resources.GetObject("tspr.Image"), System.Drawing.Image)
        Me.tspr.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tspr.Name = "tspr"
        Me.tspr.Size = New System.Drawing.Size(23, 22)
        Me.tspr.Tag = "pr"
        Me.tspr.Text = "prueba"
        '
        'FormOrdenProgramas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 552)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.tsbForm)
        Me.Name = "FormOrdenProgramas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Programas"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.General.ResumeLayout(False)
        Me.General.PerformLayout()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents General As TabPage
    Friend WithEvents txtlin_prod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbllin_prod As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpfec_fin As DateTimePicker
    Friend WithEvents dtpfec_inicio As DateTimePicker
    Friend WithEvents cmbestado As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtdocumento As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtgrupo_tra As TextBox
    Friend WithEvents dgvt_doc As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cmbturno As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btndocu As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtnom_cco As TextBox
    Friend WithEvents txtcco_cod As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txtnomgrup As TextBox
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btncal As Button
    Friend WithEvents btnsolm As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Seq As DataGridViewTextBoxColumn
    Friend WithEvents Cod_Articulo As DataGridViewTextBoxColumn
    Friend WithEvents Articulo As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Pendiente As DataGridViewTextBoxColumn
    Friend WithEvents Atendido As DataGridViewTextBoxColumn
    Friend WithEvents Duracion As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_ini As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Fin As DataGridViewTextBoxColumn
    Friend WithEvents EST As DataGridViewTextBoxColumn
    Friend WithEvents PROC As DataGridViewTextBoxColumn
    Friend WithEvents num_dif As DataGridViewTextBoxColumn
    Friend WithEvents T_DOC_REF1 As DataGridViewTextBoxColumn
    Friend WithEvents SER_DOC_REF1 As DataGridViewTextBoxColumn
    Friend WithEvents NRO_DOC_REF1 As DataGridViewTextBoxColumn
    Friend WithEvents dif_hora As DataGridViewTextBoxColumn
    Friend WithEvents tspr As ToolStripButton
End Class
