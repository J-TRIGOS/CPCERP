<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMantLtEst
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantLtEst))
        Me.txtnom_ctct = New System.Windows.Forms.TextBox()
        Me.txtctct_cod = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.txtnom_t_doc = New System.Windows.Forms.TextBox()
        Me.txtt_doc = New System.Windows.Forms.TextBox()
        Me.cmb_serdoc = New System.Windows.Forms.ComboBox()
        Me.chkx_d = New System.Windows.Forms.CheckBox()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmontopagadod = New System.Windows.Forms.TextBox()
        Me.txtmontopagados = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkbinteres = New System.Windows.Forms.CheckBox()
        Me.dtpfechaprov = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbest1 = New System.Windows.Forms.ComboBox()
        Me.dgvt_doc = New System.Windows.Forms.DataGridView()
        Me.txtmoneda = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tsbForm.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnom_ctct
        '
        Me.txtnom_ctct.Location = New System.Drawing.Point(179, 91)
        Me.txtnom_ctct.Name = "txtnom_ctct"
        Me.txtnom_ctct.ReadOnly = True
        Me.txtnom_ctct.Size = New System.Drawing.Size(421, 20)
        Me.txtnom_ctct.TabIndex = 49
        '
        'txtctct_cod
        '
        Me.txtctct_cod.Location = New System.Drawing.Point(57, 91)
        Me.txtctct_cod.Name = "txtctct_cod"
        Me.txtctct_cod.ReadOnly = True
        Me.txtctct_cod.Size = New System.Drawing.Size(116, 20)
        Me.txtctct_cod.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Cliente"
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(784, 25)
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
        'txtnom_t_doc
        '
        Me.txtnom_t_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnom_t_doc.Location = New System.Drawing.Point(88, 42)
        Me.txtnom_t_doc.Name = "txtnom_t_doc"
        Me.txtnom_t_doc.ReadOnly = True
        Me.txtnom_t_doc.Size = New System.Drawing.Size(167, 20)
        Me.txtnom_t_doc.TabIndex = 45
        '
        'txtt_doc
        '
        Me.txtt_doc.Location = New System.Drawing.Point(46, 42)
        Me.txtt_doc.Name = "txtt_doc"
        Me.txtt_doc.ReadOnly = True
        Me.txtt_doc.Size = New System.Drawing.Size(40, 20)
        Me.txtt_doc.TabIndex = 44
        '
        'cmb_serdoc
        '
        Me.cmb_serdoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_serdoc.Enabled = False
        Me.cmb_serdoc.FormattingEnabled = True
        Me.cmb_serdoc.Items.AddRange(New Object() {"2017", "2018", "2019", "2020"})
        Me.cmb_serdoc.Location = New System.Drawing.Point(298, 39)
        Me.cmb_serdoc.Name = "cmb_serdoc"
        Me.cmb_serdoc.Size = New System.Drawing.Size(71, 21)
        Me.cmb_serdoc.TabIndex = 43
        '
        'chkx_d
        '
        Me.chkx_d.AutoSize = True
        Me.chkx_d.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkx_d.Location = New System.Drawing.Point(687, 66)
        Me.chkx_d.Name = "chkx_d"
        Me.chkx_d.Size = New System.Drawing.Size(72, 17)
        Me.chkx_d.TabIndex = 42
        Me.chkx_d.Text = "Recogido"
        Me.chkx_d.UseVisualStyleBackColor = True
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(425, 40)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.ReadOnly = True
        Me.txtnumero.Size = New System.Drawing.Size(78, 20)
        Me.txtnumero.TabIndex = 41
        '
        'dtpfecha
        '
        Me.dtpfecha.Enabled = False
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(677, 40)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(82, 20)
        Me.dtpfecha.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(699, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Fecha"
        '
        'GroupBox4
        '
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
        Me.GroupBox4.Location = New System.Drawing.Point(12, 125)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(754, 126)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Totales"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(614, 73)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(81, 16)
        Me.Label24.TabIndex = 51
        Me.Label24.Text = "Compra ($/.)"
        '
        'txttcomprad
        '
        Me.txttcomprad.Location = New System.Drawing.Point(585, 92)
        Me.txttcomprad.Name = "txttcomprad"
        Me.txttcomprad.ReadOnly = True
        Me.txttcomprad.Size = New System.Drawing.Size(139, 20)
        Me.txttcomprad.TabIndex = 50
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(612, 21)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(83, 16)
        Me.Label23.TabIndex = 49
        Me.Label23.Text = "Compra (S/.)"
        '
        'txttcompras
        '
        Me.txttcompras.Location = New System.Drawing.Point(585, 40)
        Me.txttcompras.Name = "txttcompras"
        Me.txttcompras.ReadOnly = True
        Me.txttcompras.Size = New System.Drawing.Size(139, 20)
        Me.txttcompras.TabIndex = 48
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(435, 73)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(89, 16)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "Total IGV ($/.)"
        '
        'txtt_igv_dolar
        '
        Me.txtt_igv_dolar.Location = New System.Drawing.Point(411, 92)
        Me.txtt_igv_dolar.Name = "txtt_igv_dolar"
        Me.txtt_igv_dolar.ReadOnly = True
        Me.txtt_igv_dolar.Size = New System.Drawing.Size(146, 20)
        Me.txtt_igv_dolar.TabIndex = 46
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(435, 21)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(91, 16)
        Me.Label21.TabIndex = 45
        Me.Label21.Text = "Total IGV (S/.)"
        '
        'txtt_igv
        '
        Me.txtt_igv.Location = New System.Drawing.Point(411, 40)
        Me.txtt_igv.Name = "txtt_igv"
        Me.txtt_igv.ReadOnly = True
        Me.txtt_igv.Size = New System.Drawing.Size(146, 20)
        Me.txtt_igv.TabIndex = 44
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(249, 73)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(98, 16)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Descuento ($/.)"
        '
        'txtt_dcto_dolar
        '
        Me.txtt_dcto_dolar.Location = New System.Drawing.Point(215, 92)
        Me.txtt_dcto_dolar.Name = "txtt_dcto_dolar"
        Me.txtt_dcto_dolar.ReadOnly = True
        Me.txtt_dcto_dolar.Size = New System.Drawing.Size(168, 20)
        Me.txtt_dcto_dolar.TabIndex = 42
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(246, 21)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 16)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Descuento (S/.)"
        '
        'txtt_dcto
        '
        Me.txtt_dcto.Location = New System.Drawing.Point(212, 40)
        Me.txtt_dcto.Name = "txtt_dcto"
        Me.txtt_dcto.ReadOnly = True
        Me.txtt_dcto.Size = New System.Drawing.Size(168, 20)
        Me.txtt_dcto.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(44, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Compra Total ($/.)"
        '
        'txttprecio_dcompra
        '
        Me.txttprecio_dcompra.Location = New System.Drawing.Point(29, 92)
        Me.txttprecio_dcompra.Name = "txttprecio_dcompra"
        Me.txttprecio_dcompra.ReadOnly = True
        Me.txttprecio_dcompra.Size = New System.Drawing.Size(142, 20)
        Me.txttprecio_dcompra.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 16)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Compra Total (S/.)"
        '
        'txttprecio_compra
        '
        Me.txttprecio_compra.Location = New System.Drawing.Point(29, 40)
        Me.txttprecio_compra.Name = "txttprecio_compra"
        Me.txttprecio_compra.ReadOnly = True
        Me.txttprecio_compra.Size = New System.Drawing.Size(142, 20)
        Me.txttprecio_compra.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(447, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Numero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(318, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Serie"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Tipo"
        '
        'txtmontopagadod
        '
        Me.txtmontopagadod.Location = New System.Drawing.Point(94, 67)
        Me.txtmontopagadod.Name = "txtmontopagadod"
        Me.txtmontopagadod.ReadOnly = True
        Me.txtmontopagadod.Size = New System.Drawing.Size(146, 20)
        Me.txtmontopagadod.TabIndex = 50
        '
        'txtmontopagados
        '
        Me.txtmontopagados.Location = New System.Drawing.Point(309, 66)
        Me.txtmontopagados.Name = "txtmontopagados"
        Me.txtmontopagados.ReadOnly = True
        Me.txtmontopagados.Size = New System.Drawing.Size(139, 20)
        Me.txtmontopagados.TabIndex = 51
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(243, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Monto Soles"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Monto Dolares"
        '
        'chkbinteres
        '
        Me.chkbinteres.AutoSize = True
        Me.chkbinteres.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkbinteres.Location = New System.Drawing.Point(452, 67)
        Me.chkbinteres.Name = "chkbinteres"
        Me.chkbinteres.Size = New System.Drawing.Size(95, 17)
        Me.chkbinteres.TabIndex = 54
        Me.chkbinteres.Text = "Letra al Banco"
        Me.chkbinteres.UseVisualStyleBackColor = True
        '
        'dtpfechaprov
        '
        Me.dtpfechaprov.Enabled = False
        Me.dtpfechaprov.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaprov.Location = New System.Drawing.Point(681, 91)
        Me.dtpfechaprov.Name = "dtpfechaprov"
        Me.dtpfechaprov.Size = New System.Drawing.Size(82, 20)
        Me.dtpfechaprov.TabIndex = 56
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(606, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Fecha Vcto."
        '
        'cmbest1
        '
        Me.cmbest1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbest1.FormattingEnabled = True
        Me.cmbest1.Items.AddRange(New Object() {"", "Tramitado", "No Tramitado"})
        Me.cmbest1.Location = New System.Drawing.Point(551, 65)
        Me.cmbest1.Name = "cmbest1"
        Me.cmbest1.Size = New System.Drawing.Size(114, 21)
        Me.cmbest1.TabIndex = 57
        '
        'dgvt_doc
        '
        Me.dgvt_doc.AllowUserToAddRows = False
        Me.dgvt_doc.AllowUserToDeleteRows = False
        Me.dgvt_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc.Location = New System.Drawing.Point(41, 255)
        Me.dgvt_doc.Name = "dgvt_doc"
        Me.dgvt_doc.ReadOnly = True
        Me.dgvt_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc.Size = New System.Drawing.Size(706, 80)
        Me.dgvt_doc.TabIndex = 58
        '
        'txtmoneda
        '
        Me.txtmoneda.Location = New System.Drawing.Point(540, 39)
        Me.txtmoneda.Name = "txtmoneda"
        Me.txtmoneda.ReadOnly = True
        Me.txtmoneda.Size = New System.Drawing.Size(78, 20)
        Me.txtmoneda.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(556, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Moneda"
        '
        'FormMantLtEst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 343)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtmoneda)
        Me.Controls.Add(Me.dgvt_doc)
        Me.Controls.Add(Me.cmbest1)
        Me.Controls.Add(Me.dtpfechaprov)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.chkbinteres)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtmontopagados)
        Me.Controls.Add(Me.txtmontopagadod)
        Me.Controls.Add(Me.txtnom_ctct)
        Me.Controls.Add(Me.txtctct_cod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.txtnom_t_doc)
        Me.Controls.Add(Me.txtt_doc)
        Me.Controls.Add(Me.cmb_serdoc)
        Me.Controls.Add(Me.chkx_d)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormMantLtEst"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMantLtEst"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnom_ctct As TextBox
    Friend WithEvents txtctct_cod As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents txtnom_t_doc As TextBox
    Friend WithEvents txtt_doc As TextBox
    Friend WithEvents cmb_serdoc As ComboBox
    Friend WithEvents chkx_d As CheckBox
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txttcomprad As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txttcompras As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtt_igv_dolar As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtt_igv As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtt_dcto_dolar As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtt_dcto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txttprecio_dcompra As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txttprecio_compra As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtmontopagadod As TextBox
    Friend WithEvents txtmontopagados As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents chkbinteres As CheckBox
    Friend WithEvents dtpfechaprov As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbest1 As ComboBox
    Friend WithEvents dgvt_doc As DataGridView
    Friend WithEvents txtmoneda As TextBox
    Friend WithEvents Label11 As Label
End Class
