<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormELDOCUMENTO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormELDOCUMENTO))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.lblproveedor = New System.Windows.Forms.TextBox()
        Me.txtnombanco = New System.Windows.Forms.TextBox()
        Me.lblmoneda = New System.Windows.Forms.TextBox()
        Me.cmbt_ope = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbtipo1 = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtnro_doc_ref1 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtt_cambio = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txttprecio_dcompra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttprecio_compra = New System.Windows.Forms.TextBox()
        Me.txtmoneda = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpfec_pago = New System.Windows.Forms.DateTimePicker()
        Me.txtconcepto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpfec_gene = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbltipo = New System.Windows.Forms.TextBox()
        Me.txtnro_doc_ref = New System.Windows.Forms.TextBox()
        Me.txtt_doc_ref = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtser_doc_ref = New System.Windows.Forms.TextBox()
        Me.txtcbco_cod = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1.SuspendLayout()
        Me.General.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tsbForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 40)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(782, 378)
        Me.TabControl1.TabIndex = 20
        '
        'General
        '
        Me.General.BackColor = System.Drawing.Color.White
        Me.General.Controls.Add(Me.lblproveedor)
        Me.General.Controls.Add(Me.txtnombanco)
        Me.General.Controls.Add(Me.lblmoneda)
        Me.General.Controls.Add(Me.cmbt_ope)
        Me.General.Controls.Add(Me.Label19)
        Me.General.Controls.Add(Me.cmbtipo1)
        Me.General.Controls.Add(Me.Label18)
        Me.General.Controls.Add(Me.txtnro_doc_ref1)
        Me.General.Controls.Add(Me.Label17)
        Me.General.Controls.Add(Me.txtt_cambio)
        Me.General.Controls.Add(Me.Label16)
        Me.General.Controls.Add(Me.txttprecio_dcompra)
        Me.General.Controls.Add(Me.Label2)
        Me.General.Controls.Add(Me.txttprecio_compra)
        Me.General.Controls.Add(Me.txtmoneda)
        Me.General.Controls.Add(Me.Label15)
        Me.General.Controls.Add(Me.Label13)
        Me.General.Controls.Add(Me.dtpfec_pago)
        Me.General.Controls.Add(Me.txtconcepto)
        Me.General.Controls.Add(Me.Label12)
        Me.General.Controls.Add(Me.txtproveedor)
        Me.General.Controls.Add(Me.Label11)
        Me.General.Controls.Add(Me.Label9)
        Me.General.Controls.Add(Me.dtpfec_gene)
        Me.General.Controls.Add(Me.GroupBox1)
        Me.General.Controls.Add(Me.txtcbco_cod)
        Me.General.Controls.Add(Me.Label3)
        Me.General.Controls.Add(Me.Label1)
        Me.General.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(774, 352)
        Me.General.TabIndex = 0
        Me.General.Text = "GENERAL"
        '
        'lblproveedor
        '
        Me.lblproveedor.BackColor = System.Drawing.Color.Gainsboro
        Me.lblproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblproveedor.Location = New System.Drawing.Point(196, 216)
        Me.lblproveedor.Name = "lblproveedor"
        Me.lblproveedor.ReadOnly = True
        Me.lblproveedor.Size = New System.Drawing.Size(381, 21)
        Me.lblproveedor.TabIndex = 193
        '
        'txtnombanco
        '
        Me.txtnombanco.BackColor = System.Drawing.Color.Gainsboro
        Me.txtnombanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombanco.Location = New System.Drawing.Point(154, 152)
        Me.txtnombanco.Name = "txtnombanco"
        Me.txtnombanco.ReadOnly = True
        Me.txtnombanco.Size = New System.Drawing.Size(235, 21)
        Me.txtnombanco.TabIndex = 192
        '
        'lblmoneda
        '
        Me.lblmoneda.BackColor = System.Drawing.Color.Gainsboro
        Me.lblmoneda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmoneda.Location = New System.Drawing.Point(154, 314)
        Me.lblmoneda.Name = "lblmoneda"
        Me.lblmoneda.ReadOnly = True
        Me.lblmoneda.Size = New System.Drawing.Size(235, 21)
        Me.lblmoneda.TabIndex = 188
        '
        'cmbt_ope
        '
        Me.cmbt_ope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbt_ope.FormattingEnabled = True
        Me.cmbt_ope.Items.AddRange(New Object() {"PAGOS", "COBRANZA"})
        Me.cmbt_ope.Location = New System.Drawing.Point(100, 18)
        Me.cmbt_ope.Name = "cmbt_ope"
        Me.cmbt_ope.Size = New System.Drawing.Size(95, 21)
        Me.cmbt_ope.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(478, 150)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(76, 23)
        Me.Label19.TabIndex = 187
        Me.Label19.Text = "Estado"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbtipo1
        '
        Me.cmbtipo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipo1.FormattingEnabled = True
        Me.cmbtipo1.Items.AddRange(New Object() {"COBRADO", "PENDIENTE"})
        Me.cmbtipo1.Location = New System.Drawing.Point(573, 150)
        Me.cmbtipo1.Name = "cmbtipo1"
        Me.cmbtipo1.Size = New System.Drawing.Size(101, 21)
        Me.cmbtipo1.TabIndex = 15
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(478, 119)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 23)
        Me.Label18.TabIndex = 185
        Me.Label18.Text = "Nro docu"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnro_doc_ref1
        '
        Me.txtnro_doc_ref1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnro_doc_ref1.Location = New System.Drawing.Point(573, 119)
        Me.txtnro_doc_ref1.MaxLength = 5
        Me.txtnro_doc_ref1.Name = "txtnro_doc_ref1"
        Me.txtnro_doc_ref1.Size = New System.Drawing.Size(101, 21)
        Me.txtnro_doc_ref1.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(478, 89)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 23)
        Me.Label17.TabIndex = 183
        Me.Label17.Text = "Tipo Cambio"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtt_cambio
        '
        Me.txtt_cambio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtt_cambio.Location = New System.Drawing.Point(573, 89)
        Me.txtt_cambio.MaxLength = 5
        Me.txtt_cambio.Name = "txtt_cambio"
        Me.txtt_cambio.Size = New System.Drawing.Size(101, 21)
        Me.txtt_cambio.TabIndex = 13
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(478, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 23)
        Me.Label16.TabIndex = 181
        Me.Label16.Text = "Precio Dolar"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txttprecio_dcompra
        '
        Me.txttprecio_dcompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttprecio_dcompra.Location = New System.Drawing.Point(573, 50)
        Me.txttprecio_dcompra.MaxLength = 5
        Me.txttprecio_dcompra.Name = "txttprecio_dcompra"
        Me.txttprecio_dcompra.Size = New System.Drawing.Size(101, 21)
        Me.txttprecio_dcompra.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(478, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 23)
        Me.Label2.TabIndex = 179
        Me.Label2.Text = "Precio Soles"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txttprecio_compra
        '
        Me.txttprecio_compra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttprecio_compra.Location = New System.Drawing.Point(573, 20)
        Me.txttprecio_compra.MaxLength = 5
        Me.txttprecio_compra.Name = "txttprecio_compra"
        Me.txttprecio_compra.Size = New System.Drawing.Size(101, 21)
        Me.txttprecio_compra.TabIndex = 11
        '
        'txtmoneda
        '
        Me.txtmoneda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmoneda.Location = New System.Drawing.Point(100, 314)
        Me.txtmoneda.MaxLength = 2
        Me.txtmoneda.Name = "txtmoneda"
        Me.txtmoneda.Size = New System.Drawing.Size(53, 21)
        Me.txtmoneda.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(19, 312)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 23)
        Me.Label15.TabIndex = 175
        Me.Label15.Text = "Moneda"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(19, 281)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 23)
        Me.Label13.TabIndex = 174
        Me.Label13.Text = "Fecha Pago"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpfec_pago
        '
        Me.dtpfec_pago.Checked = False
        Me.dtpfec_pago.CustomFormat = ""
        Me.dtpfec_pago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_pago.Location = New System.Drawing.Point(100, 282)
        Me.dtpfec_pago.Name = "dtpfec_pago"
        Me.dtpfec_pago.Size = New System.Drawing.Size(95, 21)
        Me.dtpfec_pago.TabIndex = 9
        Me.dtpfec_pago.Value = New Date(2019, 1, 9, 0, 0, 0, 0)
        '
        'txtconcepto
        '
        Me.txtconcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtconcepto.Location = New System.Drawing.Point(100, 249)
        Me.txtconcepto.MaxLength = 8
        Me.txtconcepto.Name = "txtconcepto"
        Me.txtconcepto.Size = New System.Drawing.Size(477, 21)
        Me.txtconcepto.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 248)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 23)
        Me.Label12.TabIndex = 171
        Me.Label12.Text = "Concepto"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtproveedor
        '
        Me.txtproveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtproveedor.Location = New System.Drawing.Point(100, 216)
        Me.txtproveedor.MaxLength = 15
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(95, 21)
        Me.txtproveedor.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 23)
        Me.Label11.TabIndex = 168
        Me.Label11.Text = "Proveedor"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 23)
        Me.Label9.TabIndex = 167
        Me.Label9.Text = "Fecha Gen."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpfec_gene
        '
        Me.dtpfec_gene.Checked = False
        Me.dtpfec_gene.CustomFormat = ""
        Me.dtpfec_gene.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_gene.Location = New System.Drawing.Point(100, 184)
        Me.dtpfec_gene.Name = "dtpfec_gene"
        Me.dtpfec_gene.Size = New System.Drawing.Size(95, 21)
        Me.dtpfec_gene.TabIndex = 6
        Me.dtpfec_gene.Value = New Date(2019, 2, 18, 0, 0, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbltipo)
        Me.GroupBox1.Controls.Add(Me.txtnro_doc_ref)
        Me.GroupBox1.Controls.Add(Me.txtt_doc_ref)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtser_doc_ref)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 100)
        Me.GroupBox1.TabIndex = 165
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Documento"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 23)
        Me.Label8.TabIndex = 166
        Me.Label8.Text = "Nro."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbltipo
        '
        Me.lbltipo.BackColor = System.Drawing.Color.Gainsboro
        Me.lbltipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltipo.Location = New System.Drawing.Point(141, 17)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.ReadOnly = True
        Me.lbltipo.Size = New System.Drawing.Size(235, 21)
        Me.lbltipo.TabIndex = 189
        '
        'txtnro_doc_ref
        '
        Me.txtnro_doc_ref.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnro_doc_ref.Location = New System.Drawing.Point(87, 74)
        Me.txtnro_doc_ref.MaxLength = 5
        Me.txtnro_doc_ref.Name = "txtnro_doc_ref"
        Me.txtnro_doc_ref.Size = New System.Drawing.Size(95, 21)
        Me.txtnro_doc_ref.TabIndex = 5
        '
        'txtt_doc_ref
        '
        Me.txtt_doc_ref.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtt_doc_ref.Location = New System.Drawing.Point(87, 17)
        Me.txtt_doc_ref.MaxLength = 5
        Me.txtt_doc_ref.Name = "txtt_doc_ref"
        Me.txtt_doc_ref.Size = New System.Drawing.Size(53, 21)
        Me.txtt_doc_ref.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 23)
        Me.Label6.TabIndex = 162
        Me.Label6.Text = "Tipo "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 23)
        Me.Label5.TabIndex = 155
        Me.Label5.Text = "Serie"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtser_doc_ref
        '
        Me.txtser_doc_ref.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtser_doc_ref.Location = New System.Drawing.Point(87, 46)
        Me.txtser_doc_ref.MaxLength = 5
        Me.txtser_doc_ref.Name = "txtser_doc_ref"
        Me.txtser_doc_ref.Size = New System.Drawing.Size(95, 21)
        Me.txtser_doc_ref.TabIndex = 4
        '
        'txtcbco_cod
        '
        Me.txtcbco_cod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcbco_cod.Location = New System.Drawing.Point(100, 152)
        Me.txtcbco_cod.MaxLength = 5
        Me.txtcbco_cod.Name = "txtcbco_cod"
        Me.txtcbco_cod.Size = New System.Drawing.Size(53, 21)
        Me.txtcbco_cod.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 23)
        Me.Label3.TabIndex = 161
        Me.Label3.Text = "Banco"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 23)
        Me.Label1.TabIndex = 158
        Me.Label1.Text = "Tipo Ope."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbBorrar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(806, 25)
        Me.tsbForm.TabIndex = 21
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
        'tsbBorrar
        '
        Me.tsbBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbBorrar.Image = CType(resources.GetObject("tsbBorrar.Image"), System.Drawing.Image)
        Me.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBorrar.Name = "tsbBorrar"
        Me.tsbBorrar.Size = New System.Drawing.Size(23, 22)
        Me.tsbBorrar.Tag = "delete"
        Me.tsbBorrar.Text = "Borrar"
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
        'FormELDOCUMENTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 420)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormELDOCUMENTO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Extracto Bancario"
        Me.TabControl1.ResumeLayout(False)
        Me.General.ResumeLayout(False)
        Me.General.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents General As TabPage
    Friend WithEvents txtser_doc_ref As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbBorrar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnro_doc_ref As TextBox
    Friend WithEvents txtt_doc_ref As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcbco_cod As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cmbtipo1 As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtnro_doc_ref1 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtt_cambio As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txttprecio_dcompra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txttprecio_compra As TextBox
    Friend WithEvents txtmoneda As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpfec_pago As DateTimePicker
    Friend WithEvents txtconcepto As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtproveedor As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpfec_gene As DateTimePicker
    Friend WithEvents cmbt_ope As ComboBox
    Friend WithEvents lblmoneda As TextBox
    Friend WithEvents lbltipo As TextBox
    Friend WithEvents lblproveedor As TextBox
    Friend WithEvents txtnombanco As TextBox
End Class
