<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormELPAGO_DETDOCUMENTO
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
        Me.lblt_doc = New System.Windows.Forms.TextBox()
        Me.txtt_doc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcuenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cuenta = New System.Windows.Forms.Label()
        Me.cmbafecto = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbldestino = New System.Windows.Forms.TextBox()
        Me.lblsigno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblmon = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtmon = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_caja = New System.Windows.Forms.TextBox()
        Me.txt_ActCaja = New System.Windows.Forms.TextBox()
        Me.txt_flujo = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_actFlujo = New System.Windows.Forms.TextBox()
        Me.chkReparar = New System.Windows.Forms.CheckBox()
        Me.txt_proveedor = New System.Windows.Forms.TextBox()
        Me.txt_codproveedor = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbltcambio = New System.Windows.Forms.TextBox()
        Me.dtpcom_fech = New System.Windows.Forms.DateTimePicker()
        Me.dgvt_docdet = New System.Windows.Forms.DataGridView()
        Me.T_DOC_REF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIE_DOC_REF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRO_DOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Afecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.estcom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtsoles = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdolar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txt_nomcco = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_ccocod = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvt_docdet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblt_doc
        '
        Me.lblt_doc.BackColor = System.Drawing.Color.Gainsboro
        Me.lblt_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblt_doc.Location = New System.Drawing.Point(159, 31)
        Me.lblt_doc.Name = "lblt_doc"
        Me.lblt_doc.ReadOnly = True
        Me.lblt_doc.Size = New System.Drawing.Size(197, 20)
        Me.lblt_doc.TabIndex = 193
        '
        'txtt_doc
        '
        Me.txtt_doc.Location = New System.Drawing.Point(115, 31)
        Me.txtt_doc.Name = "txtt_doc"
        Me.txtt_doc.Size = New System.Drawing.Size(43, 20)
        Me.txtt_doc.TabIndex = 150
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 194
        Me.Label2.Text = "Tipo Doc."
        '
        'txtserie
        '
        Me.txtserie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtserie.Location = New System.Drawing.Point(115, 63)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(90, 20)
        Me.txtserie.TabIndex = 151
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(115, 96)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(90, 20)
        Me.txtnumero.TabIndex = 152
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 198
        Me.Label4.Text = "Numero"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 197
        Me.Label3.Text = "Serie"
        '
        'txtcuenta
        '
        Me.txtcuenta.Location = New System.Drawing.Point(115, 217)
        Me.txtcuenta.Name = "txtcuenta"
        Me.txtcuenta.Size = New System.Drawing.Size(90, 20)
        Me.txtcuenta.TabIndex = 154
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(514, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 202
        Me.Label1.Text = "Signo"
        '
        'Cuenta
        '
        Me.Cuenta.AutoSize = True
        Me.Cuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cuenta.Location = New System.Drawing.Point(16, 221)
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Size = New System.Drawing.Size(50, 16)
        Me.Cuenta.TabIndex = 201
        Me.Cuenta.Text = "Cuenta"
        '
        'cmbafecto
        '
        Me.cmbafecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbafecto.FormattingEnabled = True
        Me.cmbafecto.Items.AddRange(New Object() {"SI", "NO"})
        Me.cmbafecto.Location = New System.Drawing.Point(115, 184)
        Me.cmbafecto.Name = "cmbafecto"
        Me.cmbafecto.Size = New System.Drawing.Size(56, 21)
        Me.cmbafecto.TabIndex = 153
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 16)
        Me.Label6.TabIndex = 204
        Me.Label6.Text = "Afecto"
        '
        'lbldestino
        '
        Me.lbldestino.BackColor = System.Drawing.SystemColors.Window
        Me.lbldestino.Location = New System.Drawing.Point(206, 217)
        Me.lbldestino.Name = "lbldestino"
        Me.lbldestino.Size = New System.Drawing.Size(150, 20)
        Me.lbldestino.TabIndex = 205
        '
        'lblsigno
        '
        Me.lblsigno.BackColor = System.Drawing.SystemColors.Window
        Me.lblsigno.Location = New System.Drawing.Point(613, 100)
        Me.lblsigno.Name = "lblsigno"
        Me.lblsigno.Size = New System.Drawing.Size(45, 20)
        Me.lblsigno.TabIndex = 157
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(245, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 207
        Me.Label5.Text = "Cta destino"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 16)
        Me.Label7.TabIndex = 209
        Me.Label7.Text = "F. Generación"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 16)
        Me.Label8.TabIndex = 211
        Me.Label8.Text = "T. Cambio"
        '
        'lblmon
        '
        Me.lblmon.BackColor = System.Drawing.Color.Gainsboro
        Me.lblmon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmon.Location = New System.Drawing.Point(150, 314)
        Me.lblmon.Name = "lblmon"
        Me.lblmon.ReadOnly = True
        Me.lblmon.Size = New System.Drawing.Size(197, 20)
        Me.lblmon.TabIndex = 214
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 318)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 16)
        Me.Label12.TabIndex = 213
        Me.Label12.Text = "Moneda"
        '
        'txtmon
        '
        Me.txtmon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmon.Location = New System.Drawing.Point(115, 314)
        Me.txtmon.Name = "txtmon"
        Me.txtmon.Size = New System.Drawing.Size(34, 20)
        Me.txtmon.TabIndex = 156
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_nomcco)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txt_ccocod)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_caja)
        Me.GroupBox1.Controls.Add(Me.txt_ActCaja)
        Me.GroupBox1.Controls.Add(Me.txt_flujo)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.txt_actFlujo)
        Me.GroupBox1.Controls.Add(Me.chkReparar)
        Me.GroupBox1.Controls.Add(Me.txt_proveedor)
        Me.GroupBox1.Controls.Add(Me.txt_codproveedor)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lbltcambio)
        Me.GroupBox1.Controls.Add(Me.dtpcom_fech)
        Me.GroupBox1.Controls.Add(Me.dgvt_docdet)
        Me.GroupBox1.Controls.Add(Me.txtsoles)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtdolar)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.txtserie)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbafecto)
        Me.GroupBox1.Controls.Add(Me.lblt_doc)
        Me.GroupBox1.Controls.Add(Me.txtt_doc)
        Me.GroupBox1.Controls.Add(Me.lblmon)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtnumero)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblsigno)
        Me.GroupBox1.Controls.Add(Me.txtmon)
        Me.GroupBox1.Controls.Add(Me.lbldestino)
        Me.GroupBox1.Controls.Add(Me.Cuenta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtcuenta)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(718, 409)
        Me.GroupBox1.TabIndex = 215
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Datos"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(623, 174)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 13)
        Me.Label14.TabIndex = 234
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(596, 174)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 13)
        Me.Label13.TabIndex = 233
        Me.Label13.Visible = False
        '
        'txt_caja
        '
        Me.txt_caja.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_caja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_caja.Location = New System.Drawing.Point(424, 229)
        Me.txt_caja.Name = "txt_caja"
        Me.txt_caja.ReadOnly = True
        Me.txt_caja.Size = New System.Drawing.Size(288, 20)
        Me.txt_caja.TabIndex = 232
        '
        'txt_ActCaja
        '
        Me.txt_ActCaja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ActCaja.Location = New System.Drawing.Point(383, 229)
        Me.txt_ActCaja.Name = "txt_ActCaja"
        Me.txt_ActCaja.Size = New System.Drawing.Size(40, 20)
        Me.txt_ActCaja.TabIndex = 231
        '
        'txt_flujo
        '
        Me.txt_flujo.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_flujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_flujo.Location = New System.Drawing.Point(424, 203)
        Me.txt_flujo.Name = "txt_flujo"
        Me.txt_flujo.ReadOnly = True
        Me.txt_flujo.Size = New System.Drawing.Size(288, 20)
        Me.txt_flujo.TabIndex = 230
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(389, 184)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 16)
        Me.Label24.TabIndex = 229
        Me.Label24.Text = "Activ. Flujo"
        '
        'txt_actFlujo
        '
        Me.txt_actFlujo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_actFlujo.Location = New System.Drawing.Point(383, 203)
        Me.txt_actFlujo.Name = "txt_actFlujo"
        Me.txt_actFlujo.Size = New System.Drawing.Size(40, 20)
        Me.txt_actFlujo.TabIndex = 228
        '
        'chkReparar
        '
        Me.chkReparar.AutoSize = True
        Me.chkReparar.Location = New System.Drawing.Point(517, 127)
        Me.chkReparar.Name = "chkReparar"
        Me.chkReparar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkReparar.Size = New System.Drawing.Size(64, 17)
        Me.chkReparar.TabIndex = 227
        Me.chkReparar.Text = "Reparar"
        Me.chkReparar.UseVisualStyleBackColor = True
        '
        'txt_proveedor
        '
        Me.txt_proveedor.Location = New System.Drawing.Point(114, 153)
        Me.txt_proveedor.Name = "txt_proveedor"
        Me.txt_proveedor.Size = New System.Drawing.Size(326, 20)
        Me.txt_proveedor.TabIndex = 225
        '
        'txt_codproveedor
        '
        Me.txt_codproveedor.Location = New System.Drawing.Point(114, 127)
        Me.txt_codproveedor.Name = "txt_codproveedor"
        Me.txt_codproveedor.Size = New System.Drawing.Size(90, 20)
        Me.txt_codproveedor.TabIndex = 223
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 224
        Me.Label11.Text = "Proveedor"
        '
        'lbltcambio
        '
        Me.lbltcambio.Location = New System.Drawing.Point(114, 284)
        Me.lbltcambio.Name = "lbltcambio"
        Me.lbltcambio.Size = New System.Drawing.Size(100, 20)
        Me.lbltcambio.TabIndex = 222
        '
        'dtpcom_fech
        '
        Me.dtpcom_fech.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpcom_fech.Location = New System.Drawing.Point(114, 248)
        Me.dtpcom_fech.Name = "dtpcom_fech"
        Me.dtpcom_fech.Size = New System.Drawing.Size(105, 20)
        Me.dtpcom_fech.TabIndex = 155
        '
        'dgvt_docdet
        '
        Me.dgvt_docdet.AllowUserToAddRows = False
        Me.dgvt_docdet.AllowUserToDeleteRows = False
        Me.dgvt_docdet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_docdet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_docdet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.T_DOC_REF, Me.SERIE_DOC_REF, Me.NRO_DOC, Me.Afecto, Me.cuenta2, Me.Cta_des, Me.Codigo, Me.Proveedor, Me.Signo, Me.Fecha, Me.T_cambio, Me.Mon, Me.Moneda, Me.T_Soles, Me.T_Dolares, Me.O_Compra, Me.estcom})
        Me.dgvt_docdet.Location = New System.Drawing.Point(442, 298)
        Me.dgvt_docdet.Name = "dgvt_docdet"
        Me.dgvt_docdet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_docdet.Size = New System.Drawing.Size(154, 111)
        Me.dgvt_docdet.TabIndex = 221
        Me.dgvt_docdet.Visible = False
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
        'cuenta2
        '
        Me.cuenta2.HeaderText = "Cuenta"
        Me.cuenta2.Name = "cuenta2"
        Me.cuenta2.Width = 66
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
        'estcom
        '
        Me.estcom.HeaderText = "estcom"
        Me.estcom.Name = "estcom"
        Me.estcom.Visible = False
        Me.estcom.Width = 66
        '
        'txtsoles
        '
        Me.txtsoles.Location = New System.Drawing.Point(613, 31)
        Me.txtsoles.Name = "txtsoles"
        Me.txtsoles.Size = New System.Drawing.Size(90, 20)
        Me.txtsoles.TabIndex = 217
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(514, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 16)
        Me.Label9.TabIndex = 219
        Me.Label9.Text = "T. Soles"
        '
        'txtdolar
        '
        Me.txtdolar.Location = New System.Drawing.Point(613, 64)
        Me.txtdolar.Name = "txtdolar"
        Me.txtdolar.Size = New System.Drawing.Size(90, 20)
        Me.txtdolar.TabIndex = 218
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(514, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 16)
        Me.Label10.TabIndex = 220
        Me.Label10.Text = "T. Dolares"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(340, 377)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 216
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(228, 377)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 215
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txt_nomcco
        '
        Me.txt_nomcco.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_nomcco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nomcco.Location = New System.Drawing.Point(424, 271)
        Me.txt_nomcco.Name = "txt_nomcco"
        Me.txt_nomcco.ReadOnly = True
        Me.txt_nomcco.Size = New System.Drawing.Size(288, 20)
        Me.txt_nomcco.TabIndex = 237
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(389, 252)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 16)
        Me.Label15.TabIndex = 236
        Me.Label15.Text = "Centro de Costo"
        '
        'txt_ccocod
        '
        Me.txt_ccocod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ccocod.Location = New System.Drawing.Point(383, 271)
        Me.txt_ccocod.Name = "txt_ccocod"
        Me.txt_ccocod.Size = New System.Drawing.Size(40, 20)
        Me.txt_ccocod.TabIndex = 235
        '
        'FormELPAGO_DETDOCUMENTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 431)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormELPAGO_DETDOCUMENTO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Pago Documento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvt_docdet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblt_doc As TextBox
    Friend WithEvents txtt_doc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtserie As TextBox
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcuenta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Cuenta As Label
    Friend WithEvents cmbafecto As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lbldestino As TextBox
    Friend WithEvents lblsigno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblmon As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtmon As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents txtsoles As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtdolar As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvt_docdet As DataGridView
    Friend WithEvents dtpcom_fech As DateTimePicker
    Friend WithEvents lbltcambio As TextBox
    Friend WithEvents txt_codproveedor As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_proveedor As TextBox
    Friend WithEvents chkReparar As CheckBox
    Friend WithEvents txt_caja As TextBox
    Friend WithEvents txt_ActCaja As TextBox
    Friend WithEvents txt_flujo As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txt_actFlujo As TextBox
    Friend WithEvents T_DOC_REF As DataGridViewTextBoxColumn
    Friend WithEvents SERIE_DOC_REF As DataGridViewTextBoxColumn
    Friend WithEvents NRO_DOC As DataGridViewTextBoxColumn
    Friend WithEvents Afecto As DataGridViewTextBoxColumn
    Friend WithEvents cuenta2 As DataGridViewTextBoxColumn
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
    Friend WithEvents estcom As DataGridViewTextBoxColumn
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_nomcco As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_ccocod As TextBox
End Class
