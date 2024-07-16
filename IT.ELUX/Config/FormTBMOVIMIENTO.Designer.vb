<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTBMOVIMIENTO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTBMOVIMIENTO))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.dtpcom_fech = New System.Windows.Forms.DateTimePicker()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtvolumen = New System.Windows.Forms.NumericUpDown()
        Me.lblseq = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtctct_reg = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtimpto = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtx_prov = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtt_cmb = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtruc = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtcomp_cpto = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtimpor_me = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtimpor = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_moneda = New System.Windows.Forms.ComboBox()
        Me.cmbsigno = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcta_cod = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcomp_nro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_t_doc_cod = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_tipope = New System.Windows.Forms.ComboBox()
        Me.cmb_mes = New System.Windows.Forms.ComboBox()
        Me.cmb_año = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtser_nro = New System.Windows.Forms.TextBox()
        Me.txtnro_reg = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1.SuspendLayout()
        Me.General.SuspendLayout()
        CType(Me.txtvolumen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtimpor_me, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtimpor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsbForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(13, 46)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 402)
        Me.TabControl1.TabIndex = 10
        '
        'General
        '
        Me.General.BackColor = System.Drawing.Color.White
        Me.General.Controls.Add(Me.dtpcom_fech)
        Me.General.Controls.Add(Me.dtpfecha)
        Me.General.Controls.Add(Me.txtvolumen)
        Me.General.Controls.Add(Me.lblseq)
        Me.General.Controls.Add(Me.Label22)
        Me.General.Controls.Add(Me.Label21)
        Me.General.Controls.Add(Me.txtctct_reg)
        Me.General.Controls.Add(Me.Label20)
        Me.General.Controls.Add(Me.txtimpto)
        Me.General.Controls.Add(Me.Label19)
        Me.General.Controls.Add(Me.txtx_prov)
        Me.General.Controls.Add(Me.Label18)
        Me.General.Controls.Add(Me.txtt_cmb)
        Me.General.Controls.Add(Me.Label17)
        Me.General.Controls.Add(Me.txtruc)
        Me.General.Controls.Add(Me.Label16)
        Me.General.Controls.Add(Me.Label15)
        Me.General.Controls.Add(Me.txtcomp_cpto)
        Me.General.Controls.Add(Me.Label14)
        Me.General.Controls.Add(Me.Label13)
        Me.General.Controls.Add(Me.Label12)
        Me.General.Controls.Add(Me.txtimpor_me)
        Me.General.Controls.Add(Me.Label11)
        Me.General.Controls.Add(Me.txtimpor)
        Me.General.Controls.Add(Me.Label10)
        Me.General.Controls.Add(Me.cmb_moneda)
        Me.General.Controls.Add(Me.cmbsigno)
        Me.General.Controls.Add(Me.Label9)
        Me.General.Controls.Add(Me.txtcta_cod)
        Me.General.Controls.Add(Me.Label8)
        Me.General.Controls.Add(Me.txtcomp_nro)
        Me.General.Controls.Add(Me.Label4)
        Me.General.Controls.Add(Me.cmb_t_doc_cod)
        Me.General.Controls.Add(Me.Label3)
        Me.General.Controls.Add(Me.cmb_tipope)
        Me.General.Controls.Add(Me.cmb_mes)
        Me.General.Controls.Add(Me.cmb_año)
        Me.General.Controls.Add(Me.Label2)
        Me.General.Controls.Add(Me.txtser_nro)
        Me.General.Controls.Add(Me.txtnro_reg)
        Me.General.Controls.Add(Me.Label7)
        Me.General.Controls.Add(Me.Label6)
        Me.General.Controls.Add(Me.Label5)
        Me.General.Controls.Add(Me.Label1)
        Me.General.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(768, 376)
        Me.General.TabIndex = 0
        Me.General.Text = "GENERAL"
        '
        'dtpcom_fech
        '
        Me.dtpcom_fech.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpcom_fech.Location = New System.Drawing.Point(508, 96)
        Me.dtpcom_fech.Name = "dtpcom_fech"
        Me.dtpcom_fech.Size = New System.Drawing.Size(101, 21)
        Me.dtpcom_fech.TabIndex = 127
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(508, 36)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(101, 21)
        Me.dtpfecha.TabIndex = 126
        '
        'txtvolumen
        '
        Me.txtvolumen.DecimalPlaces = 5
        Me.txtvolumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvolumen.Location = New System.Drawing.Point(508, 277)
        Me.txtvolumen.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtvolumen.Name = "txtvolumen"
        Me.txtvolumen.Size = New System.Drawing.Size(101, 20)
        Me.txtvolumen.TabIndex = 125
        Me.txtvolumen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblseq
        '
        Me.lblseq.BackColor = System.Drawing.Color.Gainsboro
        Me.lblseq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblseq.Location = New System.Drawing.Point(508, 11)
        Me.lblseq.Name = "lblseq"
        Me.lblseq.Size = New System.Drawing.Size(50, 21)
        Me.lblseq.TabIndex = 124
        Me.lblseq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(410, 11)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(78, 23)
        Me.Label22.TabIndex = 123
        Me.Label22.Text = "Secuencia"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(410, 273)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(78, 23)
        Me.Label21.TabIndex = 121
        Me.Label21.Text = "Volumen"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtctct_reg
        '
        Me.txtctct_reg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtctct_reg.Location = New System.Drawing.Point(508, 244)
        Me.txtctct_reg.MaxLength = 20
        Me.txtctct_reg.Name = "txtctct_reg"
        Me.txtctct_reg.Size = New System.Drawing.Size(101, 21)
        Me.txtctct_reg.TabIndex = 120
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(410, 242)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(78, 23)
        Me.Label20.TabIndex = 119
        Me.Label20.Text = "Ctct_Reg"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtimpto
        '
        Me.txtimpto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtimpto.Location = New System.Drawing.Point(508, 213)
        Me.txtimpto.MaxLength = 2
        Me.txtimpto.Name = "txtimpto"
        Me.txtimpto.Size = New System.Drawing.Size(41, 21)
        Me.txtimpto.TabIndex = 118
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(410, 211)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 23)
        Me.Label19.TabIndex = 117
        Me.Label19.Text = "Impto"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtx_prov
        '
        Me.txtx_prov.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtx_prov.Location = New System.Drawing.Point(508, 184)
        Me.txtx_prov.MaxLength = 1
        Me.txtx_prov.Name = "txtx_prov"
        Me.txtx_prov.Size = New System.Drawing.Size(32, 21)
        Me.txtx_prov.TabIndex = 116
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(410, 182)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 23)
        Me.Label18.TabIndex = 115
        Me.Label18.Text = "X_prov"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtt_cmb
        '
        Me.txtt_cmb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtt_cmb.Location = New System.Drawing.Point(508, 156)
        Me.txtt_cmb.MaxLength = 100
        Me.txtt_cmb.Name = "txtt_cmb"
        Me.txtt_cmb.Size = New System.Drawing.Size(101, 21)
        Me.txtt_cmb.TabIndex = 114
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(410, 153)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 23)
        Me.Label17.TabIndex = 113
        Me.Label17.Text = "T.C"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtruc
        '
        Me.txtruc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtruc.Location = New System.Drawing.Point(508, 126)
        Me.txtruc.MaxLength = 100
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(101, 21)
        Me.txtruc.TabIndex = 112
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(410, 124)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 23)
        Me.Label16.TabIndex = 111
        Me.Label16.Text = "RUC"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(410, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 23)
        Me.Label15.TabIndex = 109
        Me.Label15.Text = "Compra Fecha"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcomp_cpto
        '
        Me.txtcomp_cpto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcomp_cpto.Location = New System.Drawing.Point(508, 64)
        Me.txtcomp_cpto.MaxLength = 100
        Me.txtcomp_cpto.Name = "txtcomp_cpto"
        Me.txtcomp_cpto.Size = New System.Drawing.Size(235, 21)
        Me.txtcomp_cpto.TabIndex = 108
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(410, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 23)
        Me.Label14.TabIndex = 107
        Me.Label14.Text = "Comp_cpto"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(410, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 23)
        Me.Label13.TabIndex = 105
        Me.Label13.Text = "Fecha"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(29, 333)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 23)
        Me.Label12.TabIndex = 104
        Me.Label12.Text = "Importe $"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtimpor_me
        '
        Me.txtimpor_me.DecimalPlaces = 5
        Me.txtimpor_me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimpor_me.Location = New System.Drawing.Point(122, 336)
        Me.txtimpor_me.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtimpor_me.Name = "txtimpor_me"
        Me.txtimpor_me.Size = New System.Drawing.Size(114, 20)
        Me.txtimpor_me.TabIndex = 103
        Me.txtimpor_me.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(29, 306)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 23)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "Importe S/."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtimpor
        '
        Me.txtimpor.DecimalPlaces = 5
        Me.txtimpor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimpor.Location = New System.Drawing.Point(122, 306)
        Me.txtimpor.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtimpor.Name = "txtimpor"
        Me.txtimpor.Size = New System.Drawing.Size(114, 20)
        Me.txtimpor.TabIndex = 101
        Me.txtimpor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 276)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 23)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "Moneda"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_moneda
        '
        Me.cmb_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_moneda.FormattingEnabled = True
        Me.cmb_moneda.Location = New System.Drawing.Point(122, 276)
        Me.cmb_moneda.Name = "cmb_moneda"
        Me.cmb_moneda.Size = New System.Drawing.Size(145, 21)
        Me.cmb_moneda.TabIndex = 99
        '
        'cmbsigno
        '
        Me.cmbsigno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsigno.FormattingEnabled = True
        Me.cmbsigno.Items.AddRange(New Object() {"+", "-"})
        Me.cmbsigno.Location = New System.Drawing.Point(122, 246)
        Me.cmbsigno.Name = "cmbsigno"
        Me.cmbsigno.Size = New System.Drawing.Size(59, 21)
        Me.cmbsigno.TabIndex = 98
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 246)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 23)
        Me.Label9.TabIndex = 97
        Me.Label9.Text = "Signo"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcta_cod
        '
        Me.txtcta_cod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcta_cod.Location = New System.Drawing.Point(122, 217)
        Me.txtcta_cod.MaxLength = 100
        Me.txtcta_cod.Name = "txtcta_cod"
        Me.txtcta_cod.Size = New System.Drawing.Size(95, 21)
        Me.txtcta_cod.TabIndex = 96
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 23)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Cta cod"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcomp_nro
        '
        Me.txtcomp_nro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcomp_nro.Location = New System.Drawing.Point(122, 188)
        Me.txtcomp_nro.MaxLength = 100
        Me.txtcomp_nro.Name = "txtcomp_nro"
        Me.txtcomp_nro.Size = New System.Drawing.Size(95, 21)
        Me.txtcomp_nro.TabIndex = 94
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "N° Ser"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_t_doc_cod
        '
        Me.cmb_t_doc_cod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_t_doc_cod.FormattingEnabled = True
        Me.cmb_t_doc_cod.Location = New System.Drawing.Point(122, 129)
        Me.cmb_t_doc_cod.Name = "cmb_t_doc_cod"
        Me.cmb_t_doc_cod.Size = New System.Drawing.Size(145, 21)
        Me.cmb_t_doc_cod.TabIndex = 92
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 23)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Año"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_tipope
        '
        Me.cmb_tipope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipope.FormattingEnabled = True
        Me.cmb_tipope.Location = New System.Drawing.Point(122, 69)
        Me.cmb_tipope.Name = "cmb_tipope"
        Me.cmb_tipope.Size = New System.Drawing.Size(212, 21)
        Me.cmb_tipope.TabIndex = 90
        '
        'cmb_mes
        '
        Me.cmb_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mes.FormattingEnabled = True
        Me.cmb_mes.Items.AddRange(New Object() {"01 - ENERO", "02 - FEBRERO", "03 - MARZO", "04 - ABRIL", "05 - MAYO", "06 - JUNIO", "07 - JULIO", "08 - AGOSTO", "09 - SETIEMBRE", "10 - OCTUBRE", "11 - NOVIEMBRE", "12 - DICIEMBRE"})
        Me.cmb_mes.Location = New System.Drawing.Point(122, 39)
        Me.cmb_mes.Name = "cmb_mes"
        Me.cmb_mes.Size = New System.Drawing.Size(145, 21)
        Me.cmb_mes.TabIndex = 89
        '
        'cmb_año
        '
        Me.cmb_año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_año.FormattingEnabled = True
        Me.cmb_año.Items.AddRange(New Object() {"2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmb_año.Location = New System.Drawing.Point(122, 11)
        Me.cmb_año.Name = "cmb_año"
        Me.cmb_año.Size = New System.Drawing.Size(59, 21)
        Me.cmb_año.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Mes"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtser_nro
        '
        Me.txtser_nro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtser_nro.Location = New System.Drawing.Point(122, 159)
        Me.txtser_nro.MaxLength = 100
        Me.txtser_nro.Name = "txtser_nro"
        Me.txtser_nro.Size = New System.Drawing.Size(95, 21)
        Me.txtser_nro.TabIndex = 4
        '
        'txtnro_reg
        '
        Me.txtnro_reg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnro_reg.Location = New System.Drawing.Point(122, 99)
        Me.txtnro_reg.MaxLength = 30
        Me.txtnro_reg.Name = "txtnro_reg"
        Me.txtnro_reg.Size = New System.Drawing.Size(114, 21)
        Me.txtnro_reg.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 23)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "N° Reg"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 23)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Tipo Documento"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 23)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Comp Nro"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo Operacion"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbBorrar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(800, 25)
        Me.tsbForm.TabIndex = 11
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
        'FormTBMOVIMIENTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormTBMOVIMIENTO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimiento Cuenta"
        Me.TabControl1.ResumeLayout(False)
        Me.General.ResumeLayout(False)
        Me.General.PerformLayout()
        CType(Me.txtvolumen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtimpor_me, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtimpor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents General As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents txtser_nro As TextBox
    Friend WithEvents txtnro_reg As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_año As ComboBox
    Friend WithEvents cmb_mes As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmb_moneda As ComboBox
    Friend WithEvents cmbsigno As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtcta_cod As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcomp_nro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_t_doc_cod As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_tipope As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtimpor_me As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents txtimpor As NumericUpDown
    Friend WithEvents txtctct_reg As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtimpto As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtx_prov As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtt_cmb As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtruc As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtcomp_cpto As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbBorrar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblseq As Label
    Friend WithEvents txtvolumen As NumericUpDown
    Friend WithEvents dtpcom_fech As DateTimePicker
    Friend WithEvents dtpfecha As DateTimePicker
End Class
