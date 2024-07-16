<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormELTBPERCEP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormELTBPERCEP))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvt_doc = New System.Windows.Forms.DataGridView()
        Me.txttdoc = New System.Windows.Forms.TextBox()
        Me.txtsdoc = New System.Windows.Forms.TextBox()
        Me.txtndoc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpfec = New System.Windows.Forms.DateTimePicker()
        Me.txtctct_cod = New System.Windows.Forms.TextBox()
        Me.txtnomctct = New System.Windows.Forms.TextBox()
        Me.btndocu = New System.Windows.Forms.Button()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.npdmonperc = New System.Windows.Forms.NumericUpDown()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.npdtaza = New System.Windows.Forms.NumericUpDown()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.cmbmes = New System.Windows.Forms.ComboBox()
        Me.lblndoc = New System.Windows.Forms.Label()
        Me.txtmskfecprov = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdmonperc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsbForm.SuspendLayout()
        CType(Me.npdtaza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Serie"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(263, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Numero"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "RUC"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Importe"
        '
        'dgvt_doc
        '
        Me.dgvt_doc.AllowUserToAddRows = False
        Me.dgvt_doc.AllowUserToDeleteRows = False
        Me.dgvt_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc.Location = New System.Drawing.Point(12, 160)
        Me.dgvt_doc.Name = "dgvt_doc"
        Me.dgvt_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc.Size = New System.Drawing.Size(498, 165)
        Me.dgvt_doc.TabIndex = 33
        '
        'txttdoc
        '
        Me.txttdoc.Location = New System.Drawing.Point(57, 67)
        Me.txttdoc.Name = "txttdoc"
        Me.txttdoc.ReadOnly = True
        Me.txttdoc.Size = New System.Drawing.Size(77, 20)
        Me.txttdoc.TabIndex = 30
        '
        'txtsdoc
        '
        Me.txtsdoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsdoc.Location = New System.Drawing.Point(177, 67)
        Me.txtsdoc.MaxLength = 4
        Me.txtsdoc.Name = "txtsdoc"
        Me.txtsdoc.Size = New System.Drawing.Size(80, 20)
        Me.txtsdoc.TabIndex = 2
        '
        'txtndoc
        '
        Me.txtndoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtndoc.Location = New System.Drawing.Point(313, 67)
        Me.txtndoc.Name = "txtndoc"
        Me.txtndoc.Size = New System.Drawing.Size(99, 20)
        Me.txtndoc.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(425, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Fecha"
        '
        'dtpfec
        '
        Me.dtpfec.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec.Location = New System.Drawing.Point(468, 67)
        Me.dtpfec.Name = "dtpfec"
        Me.dtpfec.Size = New System.Drawing.Size(84, 20)
        Me.dtpfec.TabIndex = 4
        Me.dtpfec.Visible = False
        '
        'txtctct_cod
        '
        Me.txtctct_cod.Location = New System.Drawing.Point(57, 99)
        Me.txtctct_cod.Name = "txtctct_cod"
        Me.txtctct_cod.Size = New System.Drawing.Size(77, 20)
        Me.txtctct_cod.TabIndex = 5
        '
        'txtnomctct
        '
        Me.txtnomctct.Location = New System.Drawing.Point(143, 99)
        Me.txtnomctct.Name = "txtnomctct"
        Me.txtnomctct.ReadOnly = True
        Me.txtnomctct.Size = New System.Drawing.Size(367, 20)
        Me.txtnomctct.TabIndex = 40
        '
        'btndocu
        '
        Me.btndocu.Location = New System.Drawing.Point(516, 187)
        Me.btndocu.Name = "btndocu"
        Me.btndocu.Size = New System.Drawing.Size(81, 23)
        Me.btndocu.TabIndex = 10
        Me.btndocu.Text = "Docum."
        Me.btndocu.UseVisualStyleBackColor = True
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(516, 158)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(81, 23)
        Me.btnborrar.TabIndex = 9
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(516, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 23)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'npdmonperc
        '
        Me.npdmonperc.DecimalPlaces = 3
        Me.npdmonperc.Location = New System.Drawing.Point(71, 128)
        Me.npdmonperc.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.npdmonperc.Name = "npdmonperc"
        Me.npdmonperc.Size = New System.Drawing.Size(160, 20)
        Me.npdmonperc.TabIndex = 6
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbimprimir, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(608, 25)
        Me.tsbForm.TabIndex = 46
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Año"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(145, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Mes"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(249, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Taza"
        '
        'npdtaza
        '
        Me.npdtaza.DecimalPlaces = 2
        Me.npdtaza.Location = New System.Drawing.Point(286, 128)
        Me.npdtaza.Name = "npdtaza"
        Me.npdtaza.Size = New System.Drawing.Size(160, 20)
        Me.npdtaza.TabIndex = 50
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño.Location = New System.Drawing.Point(59, 33)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(60, 21)
        Me.cmbaño.TabIndex = 115
        '
        'cmbmes
        '
        Me.cmbmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes.FormattingEnabled = True
        Me.cmbmes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes.Location = New System.Drawing.Point(174, 33)
        Me.cmbmes.Name = "cmbmes"
        Me.cmbmes.Size = New System.Drawing.Size(106, 21)
        Me.cmbmes.TabIndex = 116
        '
        'lblndoc
        '
        Me.lblndoc.AutoSize = True
        Me.lblndoc.Location = New System.Drawing.Point(465, 130)
        Me.lblndoc.Name = "lblndoc"
        Me.lblndoc.Size = New System.Drawing.Size(27, 13)
        Me.lblndoc.TabIndex = 117
        Me.lblndoc.Text = "Mes"
        Me.lblndoc.Visible = False
        '
        'txtmskfecprov
        '
        Me.txtmskfecprov.Location = New System.Drawing.Point(468, 67)
        Me.txtmskfecprov.Mask = "00/00/0000"
        Me.txtmskfecprov.Name = "txtmskfecprov"
        Me.txtmskfecprov.Size = New System.Drawing.Size(82, 20)
        Me.txtmskfecprov.TabIndex = 4
        Me.txtmskfecprov.ValidatingType = GetType(Date)
        '
        'FormELTBPERCEP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 351)
        Me.Controls.Add(Me.txtmskfecprov)
        Me.Controls.Add(Me.lblndoc)
        Me.Controls.Add(Me.cmbaño)
        Me.Controls.Add(Me.cmbmes)
        Me.Controls.Add(Me.npdtaza)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.npdmonperc)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btndocu)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.txtnomctct)
        Me.Controls.Add(Me.txtctct_cod)
        Me.Controls.Add(Me.dtpfec)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtndoc)
        Me.Controls.Add(Me.txtsdoc)
        Me.Controls.Add(Me.txttdoc)
        Me.Controls.Add(Me.dgvt_doc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormELTBPERCEP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormELTBPERCEP"
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdmonperc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        CType(Me.npdtaza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvt_doc As DataGridView
    Friend WithEvents txttdoc As TextBox
    Friend WithEvents txtsdoc As TextBox
    Friend WithEvents txtndoc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpfec As DateTimePicker
    Friend WithEvents txtctct_cod As TextBox
    Friend WithEvents txtnomctct As TextBox
    Friend WithEvents btndocu As Button
    Friend WithEvents btnborrar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents npdmonperc As NumericUpDown
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents npdtaza As NumericUpDown
    Friend WithEvents cmbaño As ComboBox
    Friend WithEvents cmbmes As ComboBox
    Friend WithEvents lblndoc As Label
    Friend WithEvents txtmskfecprov As MaskedTextBox
End Class
