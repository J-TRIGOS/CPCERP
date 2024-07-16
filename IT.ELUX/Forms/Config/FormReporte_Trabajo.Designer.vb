<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReporte_Trabajo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporte_Trabajo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_linea = New System.Windows.Forms.ComboBox()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbt_doc = New System.Windows.Forms.ComboBox()
        Me.txtt_doc = New System.Windows.Forms.TextBox()
        Me.dtpfec_gene = New System.Windows.Forms.DateTimePicker()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.cmbserie = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmbc_costo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvdiaper = New System.Windows.Forms.DataGridView()
        Me.cmbdni = New System.Windows.Forms.ComboBox()
        Me.txt_linea = New System.Windows.Forms.TextBox()
        Me.txtc_costo = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cmbTurno = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tsbForm.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvdiaper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tecnico:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Linea:"
        '
        'cmb_linea
        '
        Me.cmb_linea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_linea.FormattingEnabled = True
        Me.cmb_linea.Location = New System.Drawing.Point(141, 145)
        Me.cmb_linea.Name = "cmb_linea"
        Me.cmb_linea.Size = New System.Drawing.Size(345, 21)
        Me.cmb_linea.TabIndex = 229
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbimprimir, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(687, 25)
        Me.tsbForm.TabIndex = 232
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(319, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 237
        Me.Label8.Text = "Numero"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbt_doc)
        Me.GroupBox1.Controls.Add(Me.txtt_doc)
        Me.GroupBox1.Controls.Add(Me.dtpfec_gene)
        Me.GroupBox1.Controls.Add(Me.txtnumero)
        Me.GroupBox1.Controls.Add(Me.cmbestado)
        Me.GroupBox1.Controls.Add(Me.cmbserie)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(678, 36)
        Me.GroupBox1.TabIndex = 234
        Me.GroupBox1.TabStop = False
        '
        'cmbt_doc
        '
        Me.cmbt_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbt_doc.FormattingEnabled = True
        Me.cmbt_doc.Items.AddRange(New Object() {"HORAS DE MANTENIMIENTO "})
        Me.cmbt_doc.Location = New System.Drawing.Point(54, 10)
        Me.cmbt_doc.Name = "cmbt_doc"
        Me.cmbt_doc.Size = New System.Drawing.Size(168, 21)
        Me.cmbt_doc.TabIndex = 181
        '
        'txtt_doc
        '
        Me.txtt_doc.Enabled = False
        Me.txtt_doc.Location = New System.Drawing.Point(6, 11)
        Me.txtt_doc.MaxLength = 5
        Me.txtt_doc.Name = "txtt_doc"
        Me.txtt_doc.Size = New System.Drawing.Size(46, 20)
        Me.txtt_doc.TabIndex = 180
        '
        'dtpfec_gene
        '
        Me.dtpfec_gene.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_gene.Location = New System.Drawing.Point(550, 11)
        Me.dtpfec_gene.Name = "dtpfec_gene"
        Me.dtpfec_gene.Size = New System.Drawing.Size(117, 20)
        Me.dtpfec_gene.TabIndex = 5
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(310, 10)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.ReadOnly = True
        Me.txtnumero.Size = New System.Drawing.Size(118, 20)
        Me.txtnumero.TabIndex = 3
        '
        'cmbestado
        '
        Me.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.cmbestado.Location = New System.Drawing.Point(434, 11)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(108, 21)
        Me.cmbestado.TabIndex = 4
        '
        'cmbserie
        '
        Me.cmbserie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbserie.Enabled = False
        Me.cmbserie.FormattingEnabled = True
        Me.cmbserie.Items.AddRange(New Object() {"2018", "2019", "2020", "2021", "2022", "2023", "2024"})
        Me.cmbserie.Location = New System.Drawing.Point(228, 10)
        Me.cmbserie.Name = "cmbserie"
        Me.cmbserie.Size = New System.Drawing.Size(76, 21)
        Me.cmbserie.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(559, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 238
        Me.Label9.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 233
        Me.Label4.Text = "Tipo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(237, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 235
        Me.Label7.Text = "Serie"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(443, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 236
        Me.Label5.Text = "Estado"
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(94, 90)
        Me.txtdni.MaxLength = 8
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(83, 20)
        Me.txtdni.TabIndex = 239
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(634, 88)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(39, 23)
        Me.Button4.TabIndex = 241
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cmbc_costo
        '
        Me.cmbc_costo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbc_costo.FormattingEnabled = True
        Me.cmbc_costo.Location = New System.Drawing.Point(141, 118)
        Me.cmbc_costo.Name = "cmbc_costo"
        Me.cmbc_costo.Size = New System.Drawing.Size(346, 21)
        Me.cmbc_costo.TabIndex = 243
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 242
        Me.Label6.Text = "Centro Costo:"
        '
        'dgvdiaper
        '
        Me.dgvdiaper.AllowUserToAddRows = False
        Me.dgvdiaper.AllowUserToDeleteRows = False
        Me.dgvdiaper.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvdiaper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdiaper.Location = New System.Drawing.Point(16, 178)
        Me.dgvdiaper.Name = "dgvdiaper"
        Me.dgvdiaper.ReadOnly = True
        Me.dgvdiaper.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdiaper.Size = New System.Drawing.Size(584, 278)
        Me.dgvdiaper.TabIndex = 244
        '
        'cmbdni
        '
        Me.cmbdni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdni.FormattingEnabled = True
        Me.cmbdni.ItemHeight = 13
        Me.cmbdni.Location = New System.Drawing.Point(180, 89)
        Me.cmbdni.Name = "cmbdni"
        Me.cmbdni.Size = New System.Drawing.Size(452, 21)
        Me.cmbdni.TabIndex = 247
        '
        'txt_linea
        '
        Me.txt_linea.BackColor = System.Drawing.Color.White
        Me.txt_linea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_linea.Location = New System.Drawing.Point(94, 145)
        Me.txt_linea.MaxLength = 4
        Me.txt_linea.Name = "txt_linea"
        Me.txt_linea.Size = New System.Drawing.Size(44, 20)
        Me.txt_linea.TabIndex = 250
        '
        'txtc_costo
        '
        Me.txtc_costo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtc_costo.Location = New System.Drawing.Point(94, 119)
        Me.txtc_costo.MaxLength = 3
        Me.txtc_costo.Name = "txtc_costo"
        Me.txtc_costo.Size = New System.Drawing.Size(44, 20)
        Me.txtc_costo.TabIndex = 249
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(489, 117)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(39, 23)
        Me.Button5.TabIndex = 251
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(606, 188)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 35)
        Me.btnAgregar.TabIndex = 261
        Me.btnAgregar.Text = "Agregar OM"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'cmbTurno
        '
        Me.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTurno.FormattingEnabled = True
        Me.cmbTurno.Items.AddRange(New Object() {"DIA", "NOCHE"})
        Me.cmbTurno.Location = New System.Drawing.Point(544, 145)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Size = New System.Drawing.Size(127, 21)
        Me.cmbTurno.TabIndex = 264
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(502, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 265
        Me.Label2.Text = "Turno:"
        '
        'Button8
        '
        Me.Button8.Enabled = False
        Me.Button8.Location = New System.Drawing.Point(606, 225)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 35)
        Me.Button8.TabIndex = 270
        Me.Button8.Text = "Eliminar OM"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Location = New System.Drawing.Point(569, 121)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(27, 13)
        Me.lbluser.TabIndex = 272
        Me.lbluser.Text = "user"
        Me.lbluser.Visible = False
        '
        'Button10
        '
        Me.Button10.Enabled = False
        Me.Button10.Location = New System.Drawing.Point(606, 432)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 22)
        Me.Button10.TabIndex = 273
        Me.Button10.Text = "Finalizar OM"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(605, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 274
        Me.Label10.Text = "____"
        Me.Label10.Visible = False
        '
        'FormReporte_Trabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 465)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbTurno)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txt_linea)
        Me.Controls.Add(Me.txtc_costo)
        Me.Controls.Add(Me.cmbdni)
        Me.Controls.Add(Me.dgvdiaper)
        Me.Controls.Add(Me.cmbc_costo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.cmb_linea)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormReporte_Trabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormReporte_Trabajo"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvdiaper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_linea As ComboBox
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbt_doc As ComboBox
    Friend WithEvents txtt_doc As TextBox
    Friend WithEvents dtpfec_gene As DateTimePicker
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents cmbestado As ComboBox
    Friend WithEvents cmbserie As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtdni As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents cmbc_costo As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvdiaper As DataGridView
    Friend WithEvents cmbdni As ComboBox
    Friend WithEvents txt_linea As TextBox
    Friend WithEvents txtc_costo As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cmbTurno As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents lbluser As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Label10 As Label
End Class
