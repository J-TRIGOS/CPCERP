<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormELPAGO_DOCUMENTO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormELPAGO_DOCUMENTO))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbt_ope = New System.Windows.Forms.ComboBox()
        Me.dtpfec_dia = New System.Windows.Forms.DateTimePicker()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtpfec_pago = New System.Windows.Forms.DateTimePicker()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtporcentaje = New System.Windows.Forms.TextBox()
        Me.lblt_doc = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtreten = New System.Windows.Forms.TextBox()
        Me.dtpf_gene = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtt_doc = New System.Windows.Forms.TextBox()
        Me.dtpfec_vigencia = New System.Windows.Forms.DateTimePicker()
        Me.cmbcobranza = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbtipo1 = New System.Windows.Forms.ComboBox()
        Me.lvlcco_cod = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcco_cod = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblproveedor = New System.Windows.Forms.TextBox()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtobserva = New System.Windows.Forms.TextBox()
        Me.cmbest1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblmon = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.lblcbco = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtmon = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcbco_cod = New System.Windows.Forms.TextBox()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btndocu = New System.Windows.Forms.Button()
        Me.dgvt_doc = New System.Windows.Forms.DataGridView()
        Me.T_DOC_REF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIE_DOC_REF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRO_DOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Afecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cta_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Signo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_cambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_Soles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_Dolares = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_Compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.lstValor = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblSoles = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbldolares = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtpagoparcial = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtregcontable = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.tsbForm.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbt_ope)
        Me.GroupBox2.Controls.Add(Me.dtpfec_dia)
        Me.GroupBox2.Controls.Add(Me.txtserie)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.dtpfec_pago)
        Me.GroupBox2.Controls.Add(Me.txtnumero)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtporcentaje)
        Me.GroupBox2.Controls.Add(Me.lblt_doc)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtreten)
        Me.GroupBox2.Controls.Add(Me.dtpf_gene)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtt_doc)
        Me.GroupBox2.Controls.Add(Me.dtpfec_vigencia)
        Me.GroupBox2.Controls.Add(Me.cmbcobranza)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cmbtipo1)
        Me.GroupBox2.Controls.Add(Me.lvlcco_cod)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtcco_cod)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblproveedor)
        Me.GroupBox2.Controls.Add(Me.txtproveedor)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtobserva)
        Me.GroupBox2.Controls.Add(Me.cmbest1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblmon)
        Me.GroupBox2.Controls.Add(Me.txtcantidad)
        Me.GroupBox2.Controls.Add(Me.lblcbco)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtmon)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtcbco_cod)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(916, 246)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'cmbt_ope
        '
        Me.cmbt_ope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbt_ope.FormattingEnabled = True
        Me.cmbt_ope.Items.AddRange(New Object() {"010 - PAGOS", "013 - COBRANZAS"})
        Me.cmbt_ope.Location = New System.Drawing.Point(12, 33)
        Me.cmbt_ope.Name = "cmbt_ope"
        Me.cmbt_ope.Size = New System.Drawing.Size(207, 21)
        Me.cmbt_ope.TabIndex = 220
        '
        'dtpfec_dia
        '
        Me.dtpfec_dia.Checked = False
        Me.dtpfec_dia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_dia.Location = New System.Drawing.Point(376, 79)
        Me.dtpfec_dia.Name = "dtpfec_dia"
        Me.dtpfec_dia.ShowCheckBox = True
        Me.dtpfec_dia.Size = New System.Drawing.Size(128, 20)
        Me.dtpfec_dia.TabIndex = 8
        Me.dtpfec_dia.Value = New Date(2019, 3, 29, 0, 0, 0, 0)
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(570, 34)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(69, 20)
        Me.txtserie.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(348, 198)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 16)
        Me.Label18.TabIndex = 219
        Me.Label18.Text = "F. Pago"
        '
        'dtpfec_pago
        '
        Me.dtpfec_pago.Checked = False
        Me.dtpfec_pago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_pago.Location = New System.Drawing.Point(327, 217)
        Me.dtpfec_pago.Name = "dtpfec_pago"
        Me.dtpfec_pago.ShowCheckBox = True
        Me.dtpfec_pago.Size = New System.Drawing.Size(98, 20)
        Me.dtpfec_pago.TabIndex = 19
        Me.dtpfec_pago.Value = New Date(2019, 3, 29, 0, 0, 0, 0)
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(660, 33)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(94, 20)
        Me.txtnumero.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(194, 198)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 16)
        Me.Label17.TabIndex = 217
        Me.Label17.Text = "Tasa Interés"
        '
        'txtporcentaje
        '
        Me.txtporcentaje.Location = New System.Drawing.Point(170, 217)
        Me.txtporcentaje.Name = "txtporcentaje"
        Me.txtporcentaje.Size = New System.Drawing.Size(135, 20)
        Me.txtporcentaje.TabIndex = 18
        '
        'lblt_doc
        '
        Me.lblt_doc.BackColor = System.Drawing.Color.Gainsboro
        Me.lblt_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblt_doc.Location = New System.Drawing.Point(289, 34)
        Me.lblt_doc.Name = "lblt_doc"
        Me.lblt_doc.ReadOnly = True
        Me.lblt_doc.Size = New System.Drawing.Size(267, 20)
        Me.lblt_doc.TabIndex = 191
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 198)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 16)
        Me.Label16.TabIndex = 215
        Me.Label16.Text = "Comisión Retención"
        '
        'txtreten
        '
        Me.txtreten.Location = New System.Drawing.Point(12, 217)
        Me.txtreten.Name = "txtreten"
        Me.txtreten.Size = New System.Drawing.Size(135, 20)
        Me.txtreten.TabIndex = 17
        '
        'dtpf_gene
        '
        Me.dtpf_gene.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpf_gene.Location = New System.Drawing.Point(771, 34)
        Me.dtpf_gene.Name = "dtpf_gene"
        Me.dtpf_gene.Size = New System.Drawing.Size(104, 20)
        Me.dtpf_gene.TabIndex = 5
        Me.dtpf_gene.Value = New Date(2019, 3, 29, 0, 0, 0, 0)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(738, 151)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 16)
        Me.Label15.TabIndex = 213
        Me.Label15.Text = "F. Banco"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(585, 151)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 16)
        Me.Label14.TabIndex = 212
        Me.Label14.Text = "Extracto Banc."
        '
        'txtt_doc
        '
        Me.txtt_doc.Location = New System.Drawing.Point(245, 34)
        Me.txtt_doc.Name = "txtt_doc"
        Me.txtt_doc.Size = New System.Drawing.Size(43, 20)
        Me.txtt_doc.TabIndex = 2
        '
        'dtpfec_vigencia
        '
        Me.dtpfec_vigencia.Checked = False
        Me.dtpfec_vigencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_vigencia.Location = New System.Drawing.Point(720, 170)
        Me.dtpfec_vigencia.Name = "dtpfec_vigencia"
        Me.dtpfec_vigencia.ShowCheckBox = True
        Me.dtpfec_vigencia.Size = New System.Drawing.Size(98, 20)
        Me.dtpfec_vigencia.TabIndex = 16
        Me.dtpfec_vigencia.Value = New Date(2019, 3, 29, 0, 0, 0, 0)
        '
        'cmbcobranza
        '
        Me.cmbcobranza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcobranza.FormattingEnabled = True
        Me.cmbcobranza.Items.AddRange(New Object() {"CA - CANCELADO", "  - NO CANCELADO", "LA - LETRAS EN CARTERA ACEPTADO", "LL - LETRAS COBRANZA LIBRE", "LE - LETRAS COBRANZA GARANTIA", "LP - LETRAS PROTESTADA", "LR - LETRAS RENOVADA", "AE - AVANCE ENCUESTA", "PP - PAGO PARCIAL"})
        Me.cmbcobranza.Location = New System.Drawing.Point(303, 169)
        Me.cmbcobranza.Name = "cmbcobranza"
        Me.cmbcobranza.Size = New System.Drawing.Size(241, 21)
        Me.cmbcobranza.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(388, 151)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 16)
        Me.Label13.TabIndex = 209
        Me.Label13.Text = "Cobranza"
        '
        'cmbtipo1
        '
        Me.cmbtipo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipo1.FormattingEnabled = True
        Me.cmbtipo1.Items.AddRange(New Object() {"COBRADO", "PENDIENTE"})
        Me.cmbtipo1.Location = New System.Drawing.Point(559, 169)
        Me.cmbtipo1.Name = "cmbtipo1"
        Me.cmbtipo1.Size = New System.Drawing.Size(150, 21)
        Me.cmbtipo1.TabIndex = 15
        '
        'lvlcco_cod
        '
        Me.lvlcco_cod.BackColor = System.Drawing.Color.Gainsboro
        Me.lvlcco_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvlcco_cod.Location = New System.Drawing.Point(53, 170)
        Me.lvlcco_cod.Name = "lvlcco_cod"
        Me.lvlcco_cod.ReadOnly = True
        Me.lvlcco_cod.Size = New System.Drawing.Size(235, 20)
        Me.lvlcco_cod.TabIndex = 207
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(97, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 16)
        Me.Label11.TabIndex = 206
        Me.Label11.Text = "Centro Costo"
        '
        'txtcco_cod
        '
        Me.txtcco_cod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcco_cod.Location = New System.Drawing.Point(12, 170)
        Me.txtcco_cod.Name = "txtcco_cod"
        Me.txtcco_cod.Size = New System.Drawing.Size(40, 20)
        Me.txtcco_cod.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(617, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 204
        Me.Label8.Text = "Proveedor"
        '
        'lblproveedor
        '
        Me.lblproveedor.BackColor = System.Drawing.Color.Gainsboro
        Me.lblproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblproveedor.Location = New System.Drawing.Point(505, 124)
        Me.lblproveedor.Name = "lblproveedor"
        Me.lblproveedor.ReadOnly = True
        Me.lblproveedor.Size = New System.Drawing.Size(396, 20)
        Me.lblproveedor.TabIndex = 203
        '
        'txtproveedor
        '
        Me.txtproveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtproveedor.Location = New System.Drawing.Point(401, 124)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(103, 20)
        Me.txtproveedor.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(153, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 201
        Me.Label7.Text = "Concepto"
        '
        'txtobserva
        '
        Me.txtobserva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobserva.Location = New System.Drawing.Point(12, 124)
        Me.txtobserva.Name = "txtobserva"
        Me.txtobserva.Size = New System.Drawing.Size(373, 20)
        Me.txtobserva.TabIndex = 11
        '
        'cmbest1
        '
        Me.cmbest1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbest1.FormattingEnabled = True
        Me.cmbest1.Items.AddRange(New Object() {"HABILITADO", "ANULADO", "REFERENCIADO", "TRANSFERIDO"})
        Me.cmbest1.Location = New System.Drawing.Point(771, 78)
        Me.cmbest1.Name = "cmbest1"
        Me.cmbest1.Size = New System.Drawing.Size(104, 21)
        Me.cmbest1.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(796, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 198
        Me.Label6.Text = "Estado"
        '
        'lblmon
        '
        Me.lblmon.BackColor = System.Drawing.Color.Gainsboro
        Me.lblmon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmon.Location = New System.Drawing.Point(557, 79)
        Me.lblmon.Name = "lblmon"
        Me.lblmon.ReadOnly = True
        Me.lblmon.Size = New System.Drawing.Size(197, 20)
        Me.lblmon.TabIndex = 197
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(304, 79)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(71, 20)
        Me.txtcantidad.TabIndex = 7
        '
        'lblcbco
        '
        Me.lblcbco.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcbco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcbco.Location = New System.Drawing.Point(53, 79)
        Me.lblcbco.Name = "lblcbco"
        Me.lblcbco.ReadOnly = True
        Me.lblcbco.Size = New System.Drawing.Size(235, 20)
        Me.lblcbco.TabIndex = 194
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(678, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 193
        Me.Label4.Text = "Numero"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(585, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Serie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(364, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Tipo Documento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Operación"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(777, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "F. Generación"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(604, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 16)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Moneda"
        '
        'txtmon
        '
        Me.txtmon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmon.Location = New System.Drawing.Point(522, 79)
        Me.txtmon.Name = "txtmon"
        Me.txtmon.Size = New System.Drawing.Size(34, 20)
        Me.txtmon.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(389, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Diferido"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(116, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Banco"
        '
        'txtcbco_cod
        '
        Me.txtcbco_cod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcbco_cod.Location = New System.Drawing.Point(12, 79)
        Me.txtcbco_cod.Name = "txtcbco_cod"
        Me.txtcbco_cod.Size = New System.Drawing.Size(40, 20)
        Me.txtcbco_cod.TabIndex = 6
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbimprimir, Me.ToolStripButton2, Me.ToolStripButton1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(936, 25)
        Me.tsbForm.TabIndex = 22
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
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Tag = "exportar"
        Me.ToolStripButton2.Text = "Exportar Texto"
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
        Me.GroupBox1.Controls.Add(Me.btndocu)
        Me.GroupBox1.Controls.Add(Me.dgvt_doc)
        Me.GroupBox1.Controls.Add(Me.btnborrar)
        Me.GroupBox1.Controls.Add(Me.btnmodificar)
        Me.GroupBox1.Controls.Add(Me.btnagregar)
        Me.GroupBox1.Controls.Add(Me.lstValor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 343)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(916, 270)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'btndocu
        '
        Me.btndocu.Location = New System.Drawing.Point(805, 142)
        Me.btndocu.Name = "btndocu"
        Me.btndocu.Size = New System.Drawing.Size(105, 35)
        Me.btndocu.TabIndex = 30
        Me.btndocu.Text = "Agregar Documento"
        Me.btndocu.UseVisualStyleBackColor = True
        '
        'dgvt_doc
        '
        Me.dgvt_doc.AllowUserToAddRows = False
        Me.dgvt_doc.AllowUserToDeleteRows = False
        Me.dgvt_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.T_DOC_REF, Me.SERIE_DOC_REF, Me.NRO_DOC, Me.Afecto, Me.Cuenta, Me.Cta_des, Me.Codigo, Me.Proveedor, Me.Signo, Me.Fecha, Me.T_cambio, Me.Mon, Me.Moneda, Me.T_Soles, Me.T_Dolares, Me.O_Compra})
        Me.dgvt_doc.Location = New System.Drawing.Point(6, 19)
        Me.dgvt_doc.Name = "dgvt_doc"
        Me.dgvt_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc.Size = New System.Drawing.Size(793, 245)
        Me.dgvt_doc.TabIndex = 31
        '
        'T_DOC_REF
        '
        Me.T_DOC_REF.HeaderText = "Tipo Doc."
        Me.T_DOC_REF.Name = "T_DOC_REF"
        Me.T_DOC_REF.Width = 79
        '
        'SERIE_DOC_REF
        '
        Me.SERIE_DOC_REF.HeaderText = "Serie Doc"
        Me.SERIE_DOC_REF.Name = "SERIE_DOC_REF"
        Me.SERIE_DOC_REF.Width = 79
        '
        'NRO_DOC
        '
        Me.NRO_DOC.HeaderText = "Nro Doc."
        Me.NRO_DOC.Name = "NRO_DOC"
        Me.NRO_DOC.Width = 75
        '
        'Afecto
        '
        Me.Afecto.HeaderText = "Afecto"
        Me.Afecto.Name = "Afecto"
        Me.Afecto.Width = 63
        '
        'Cuenta
        '
        Me.Cuenta.HeaderText = "Cuenta"
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Width = 66
        '
        'Cta_des
        '
        Me.Cta_des.HeaderText = "Cta Des"
        Me.Cta_des.Name = "Cta_des"
        Me.Cta_des.Width = 70
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Visible = False
        Me.Codigo.Width = 65
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.Width = 81
        '
        'Signo
        '
        Me.Signo.HeaderText = "Signo"
        Me.Signo.Name = "Signo"
        Me.Signo.Width = 59
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 62
        '
        'T_cambio
        '
        Me.T_cambio.HeaderText = "T. cambio"
        Me.T_cambio.Name = "T_cambio"
        Me.T_cambio.Width = 79
        '
        'Mon
        '
        Me.Mon.HeaderText = "Mon"
        Me.Mon.Name = "Mon"
        Me.Mon.Width = 53
        '
        'Moneda
        '
        Me.Moneda.HeaderText = "Moneda"
        Me.Moneda.Name = "Moneda"
        Me.Moneda.Width = 71
        '
        'T_Soles
        '
        Me.T_Soles.HeaderText = "T. Soles"
        Me.T_Soles.Name = "T_Soles"
        Me.T_Soles.Width = 71
        '
        'T_Dolares
        '
        Me.T_Dolares.HeaderText = "T. Dolares"
        Me.T_Dolares.Name = "T_Dolares"
        Me.T_Dolares.Width = 81
        '
        'O_Compra
        '
        Me.O_Compra.HeaderText = "O/C"
        Me.O_Compra.Name = "O_Compra"
        Me.O_Compra.Width = 52
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(805, 100)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(105, 35)
        Me.btnborrar.TabIndex = 29
        Me.btnborrar.Text = "Borrar Registro"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(805, 59)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(105, 35)
        Me.btnmodificar.TabIndex = 28
        Me.btnmodificar.Text = "Modificar Registro"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(805, 18)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(105, 35)
        Me.btnagregar.TabIndex = 27
        Me.btnagregar.Text = "Agregar Registro"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'lstValor
        '
        Me.lstValor.FormattingEnabled = True
        Me.lstValor.Location = New System.Drawing.Point(333, 48)
        Me.lstValor.Name = "lstValor"
        Me.lstValor.Size = New System.Drawing.Size(251, 147)
        Me.lstValor.TabIndex = 34
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblSoles)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.lbldolares)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.txtpagoparcial)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.txtregcontable)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 274)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(916, 67)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        '
        'lblSoles
        '
        Me.lblSoles.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSoles.Location = New System.Drawing.Point(157, 35)
        Me.lblSoles.Name = "lblSoles"
        Me.lblSoles.ReadOnly = True
        Me.lblSoles.Size = New System.Drawing.Size(95, 20)
        Me.lblSoles.TabIndex = 204
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(166, 15)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(77, 16)
        Me.Label22.TabIndex = 203
        Me.Label22.Text = "Total Soles"
        '
        'lbldolares
        '
        Me.lbldolares.BackColor = System.Drawing.Color.Gainsboro
        Me.lbldolares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldolares.Location = New System.Drawing.Point(17, 34)
        Me.lbldolares.Name = "lbldolares"
        Me.lbldolares.ReadOnly = True
        Me.lbldolares.Size = New System.Drawing.Size(95, 20)
        Me.lbldolares.TabIndex = 202
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(18, 15)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(90, 16)
        Me.Label21.TabIndex = 201
        Me.Label21.Text = "Total Dolares"
        '
        'txtpagoparcial
        '
        Me.txtpagoparcial.Location = New System.Drawing.Point(434, 34)
        Me.txtpagoparcial.Name = "txtpagoparcial"
        Me.txtpagoparcial.Size = New System.Drawing.Size(95, 20)
        Me.txtpagoparcial.TabIndex = 21
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(440, 15)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(86, 16)
        Me.Label20.TabIndex = 199
        Me.Label20.Text = "Pago Parcial"
        '
        'txtregcontable
        '
        Me.txtregcontable.Location = New System.Drawing.Point(297, 35)
        Me.txtregcontable.Name = "txtregcontable"
        Me.txtregcontable.Size = New System.Drawing.Size(95, 20)
        Me.txtregcontable.TabIndex = 20
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(298, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(94, 16)
        Me.Label19.TabIndex = 197
        Me.Label19.Text = "Reg. Contable"
        '
        'ELPAGO_DOCUMENTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 647)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "ELPAGO_DOCUMENTO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagos Proveedores/Clientes"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtmon As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtcbco_cod As TextBox
    Friend WithEvents dtpf_gene As DateTimePicker
    Friend WithEvents txtt_doc As TextBox
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btndocu As Button
    Friend WithEvents dgvt_doc As DataGridView
    Friend WithEvents btnborrar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents lstValor As ListBox
    Friend WithEvents Label18 As Label
    Friend WithEvents dtpfec_pago As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents txtporcentaje As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtreten As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents dtpfec_vigencia As DateTimePicker
    Friend WithEvents cmbcobranza As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbtipo1 As ComboBox
    Friend WithEvents lvlcco_cod As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtcco_cod As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblproveedor As TextBox
    Friend WithEvents txtproveedor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtobserva As TextBox
    Friend WithEvents cmbest1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblmon As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents lblcbco As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtserie As TextBox
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents lblt_doc As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblSoles As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents lbldolares As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtpagoparcial As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtregcontable As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents dtpfec_dia As DateTimePicker
    Friend WithEvents cmbt_ope As ComboBox
    Friend WithEvents T_DOC_REF As DataGridViewTextBoxColumn
    Friend WithEvents SERIE_DOC_REF As DataGridViewTextBoxColumn
    Friend WithEvents NRO_DOC As DataGridViewTextBoxColumn
    Friend WithEvents Afecto As DataGridViewTextBoxColumn
    Friend WithEvents Cuenta As DataGridViewTextBoxColumn
    Friend WithEvents Cta_des As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents Signo As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents T_cambio As DataGridViewTextBoxColumn
    Friend WithEvents Mon As DataGridViewTextBoxColumn
    Friend WithEvents Moneda As DataGridViewTextBoxColumn
    Friend WithEvents T_Soles As DataGridViewTextBoxColumn
    Friend WithEvents T_Dolares As DataGridViewTextBoxColumn
    Friend WithEvents O_Compra As DataGridViewTextBoxColumn
End Class
