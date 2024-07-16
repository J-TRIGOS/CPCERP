<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLibroDiario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLibroDiario))
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkpago = New System.Windows.Forms.CheckBox()
        Me.btnDupRegistro = New System.Windows.Forms.Button()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmbTipReg = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Txt_fechareg = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btn_Proveedor = New System.Windows.Forms.Button()
        Me.Btn_BuscarCC = New System.Windows.Forms.Button()
        Me.Btn_BuscarPago = New System.Windows.Forms.Button()
        Me.DgvDetLibro = New System.Windows.Forms.DataGridView()
        Me.Documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Afecto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ccosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtaDes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Signo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TSoles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TDolares = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mon = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Comp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECVEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reparar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CODPROVEEDOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REPARAR2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODART = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Txt_RegContable = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Txt_Soles = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Txt_Dolares = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Txt_NAsiento = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Txt_Tcambio2 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Txt_NomProveedor = New System.Windows.Forms.TextBox()
        Me.Txt_CodProveedor = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Txt_NomCosto = New System.Windows.Forms.TextBox()
        Me.Txt_CodCosto = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CmbMoneda = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DatVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txt_NomFpago = New System.Windows.Forms.TextBox()
        Me.Txt_CodFpago = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CmbCobranza = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_Concepto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmbTDocumento = New System.Windows.Forms.ComboBox()
        Me.CmbTOperacion = New System.Windows.Forms.ComboBox()
        Me.CmbBanco = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DatFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmbEstado = New System.Windows.Forms.ComboBox()
        Me.Txt_Tcambio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_numero = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_serie = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsbForm.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvDetLibro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbimprimir, Me.tsbBorrar, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(1354, 25)
        Me.tsbForm.TabIndex = 113
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
        'tsbBorrar
        '
        Me.tsbBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbBorrar.Image = Global.IT.ELUX.My.Resources.Resources.Delete_Ico
        Me.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBorrar.Name = "tsbBorrar"
        Me.tsbBorrar.Size = New System.Drawing.Size(23, 22)
        Me.tsbBorrar.Tag = "Delete"
        Me.tsbBorrar.Text = "ToolStripButton1"
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkpago)
        Me.Panel1.Controls.Add(Me.btnDupRegistro)
        Me.Panel1.Controls.Add(Me.lblEstado)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.cmbTipReg)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Txt_fechareg)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Txt_usuario)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Btn_Proveedor)
        Me.Panel1.Controls.Add(Me.Btn_BuscarCC)
        Me.Panel1.Controls.Add(Me.Btn_BuscarPago)
        Me.Panel1.Controls.Add(Me.DgvDetLibro)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Txt_NAsiento)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Txt_Tcambio2)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Txt_NomProveedor)
        Me.Panel1.Controls.Add(Me.Txt_CodProveedor)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Txt_NomCosto)
        Me.Panel1.Controls.Add(Me.Txt_CodCosto)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.CmbMoneda)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.DatVencimiento)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Txt_NomFpago)
        Me.Panel1.Controls.Add(Me.Txt_CodFpago)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.CmbCobranza)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Txt_Concepto)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.CmbTDocumento)
        Me.Panel1.Controls.Add(Me.CmbTOperacion)
        Me.Panel1.Controls.Add(Me.CmbBanco)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.DatFecha)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.CmbEstado)
        Me.Panel1.Controls.Add(Me.Txt_Tcambio)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Txt_numero)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Txt_serie)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1341, 539)
        Me.Panel1.TabIndex = 114
        '
        'chkpago
        '
        Me.chkpago.AutoSize = True
        Me.chkpago.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkpago.Location = New System.Drawing.Point(731, 202)
        Me.chkpago.Name = "chkpago"
        Me.chkpago.Size = New System.Drawing.Size(112, 17)
        Me.chkpago.TabIndex = 125
        Me.chkpago.Text = "Previsión de Pago"
        Me.chkpago.UseVisualStyleBackColor = True
        '
        'btnDupRegistro
        '
        Me.btnDupRegistro.Location = New System.Drawing.Point(958, 23)
        Me.btnDupRegistro.Name = "btnDupRegistro"
        Me.btnDupRegistro.Size = New System.Drawing.Size(99, 23)
        Me.btnDupRegistro.TabIndex = 124
        Me.btnDupRegistro.Text = "Duplicar Registro"
        Me.btnDupRegistro.UseVisualStyleBackColor = True
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(906, 52)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(0, 13)
        Me.lblEstado.TabIndex = 123
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(818, 53)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(81, 13)
        Me.Label24.TabIndex = 122
        Me.Label24.Text = "Estado Mov CT"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1135, 244)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 23)
        Me.Button2.TabIndex = 121
        Me.Button2.Text = "Procesar Registros"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmbTipReg
        '
        Me.cmbTipReg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipReg.FormattingEnabled = True
        Me.cmbTipReg.Items.AddRange(New Object() {"", "APERTURA", "CIERRE", "COSTO", "MOVIMIENTO"})
        Me.cmbTipReg.Location = New System.Drawing.Point(14, 25)
        Me.cmbTipReg.Name = "cmbTipReg"
        Me.cmbTipReg.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipReg.TabIndex = 120
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(11, 9)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 13)
        Me.Label23.TabIndex = 119
        Me.Label23.Text = "Tipo Operación"
        '
        'Txt_fechareg
        '
        Me.Txt_fechareg.Location = New System.Drawing.Point(972, 246)
        Me.Txt_fechareg.Name = "Txt_fechareg"
        Me.Txt_fechareg.Size = New System.Drawing.Size(157, 20)
        Me.Txt_fechareg.TabIndex = 118
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(887, 249)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(79, 13)
        Me.Label22.TabIndex = 117
        Me.Label22.Text = "Fecha Registro"
        '
        'Txt_usuario
        '
        Me.Txt_usuario.Location = New System.Drawing.Point(750, 246)
        Me.Txt_usuario.Name = "Txt_usuario"
        Me.Txt_usuario.Size = New System.Drawing.Size(111, 20)
        Me.Txt_usuario.TabIndex = 116
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(672, 249)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 13)
        Me.Label21.TabIndex = 115
        Me.Label21.Text = "Usuario Reg."
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(8, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Btn_Proveedor
        '
        Me.Btn_Proveedor.Location = New System.Drawing.Point(468, 198)
        Me.Btn_Proveedor.Name = "Btn_Proveedor"
        Me.Btn_Proveedor.Size = New System.Drawing.Size(23, 23)
        Me.Btn_Proveedor.TabIndex = 62
        Me.Btn_Proveedor.UseVisualStyleBackColor = True
        '
        'Btn_BuscarCC
        '
        Me.Btn_BuscarCC.Location = New System.Drawing.Point(439, 154)
        Me.Btn_BuscarCC.Name = "Btn_BuscarCC"
        Me.Btn_BuscarCC.Size = New System.Drawing.Size(23, 23)
        Me.Btn_BuscarCC.TabIndex = 61
        Me.Btn_BuscarCC.UseVisualStyleBackColor = True
        '
        'Btn_BuscarPago
        '
        Me.Btn_BuscarPago.Location = New System.Drawing.Point(439, 110)
        Me.Btn_BuscarPago.Name = "Btn_BuscarPago"
        Me.Btn_BuscarPago.Size = New System.Drawing.Size(23, 23)
        Me.Btn_BuscarPago.TabIndex = 60
        Me.Btn_BuscarPago.UseVisualStyleBackColor = True
        '
        'DgvDetLibro
        '
        Me.DgvDetLibro.AllowUserToAddRows = False
        Me.DgvDetLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetLibro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Documento, Me.NomDoc, Me.Afecto, Me.Serie, Me.Nro, Me.Ccosto, Me.Cuenta, Me.CtaDes, Me.Proveedor, Me.Signo, Me.Fecha, Me.TCambio, Me.TSoles, Me.TDolares, Me.Mon, Me.Comp, Me.Obs, Me.FECVEN, Me.Reparar, Me.CODPROVEEDOR, Me.REPARAR2, Me.CODART})
        Me.DgvDetLibro.Location = New System.Drawing.Point(29, 276)
        Me.DgvDetLibro.Name = "DgvDetLibro"
        Me.DgvDetLibro.Size = New System.Drawing.Size(1301, 260)
        Me.DgvDetLibro.TabIndex = 59
        '
        'Documento
        '
        Me.Documento.HeaderText = "Documento"
        Me.Documento.Name = "Documento"
        '
        'NomDoc
        '
        Me.NomDoc.HeaderText = ""
        Me.NomDoc.Name = "NomDoc"
        '
        'Afecto
        '
        Me.Afecto.HeaderText = "Afecto"
        Me.Afecto.Items.AddRange(New Object() {"", "Afecto", "Inafecto"})
        Me.Afecto.Name = "Afecto"
        '
        'Serie
        '
        Me.Serie.HeaderText = "Serie"
        Me.Serie.Name = "Serie"
        '
        'Nro
        '
        Me.Nro.HeaderText = "Nro"
        Me.Nro.Name = "Nro"
        '
        'Ccosto
        '
        Me.Ccosto.HeaderText = "C. Costo"
        Me.Ccosto.Name = "Ccosto"
        '
        'Cuenta
        '
        Me.Cuenta.HeaderText = "Cuenta"
        Me.Cuenta.Name = "Cuenta"
        '
        'CtaDes
        '
        Me.CtaDes.HeaderText = "Cta. Des."
        Me.CtaDes.Name = "CtaDes"
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Cli/Prov"
        Me.Proveedor.Name = "Proveedor"
        '
        'Signo
        '
        Me.Signo.HeaderText = "Sig"
        Me.Signo.Items.AddRange(New Object() {"", "+", "-"})
        Me.Signo.Name = "Signo"
        Me.Signo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Signo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        '
        'TCambio
        '
        Me.TCambio.HeaderText = "T.Cambio"
        Me.TCambio.Name = "TCambio"
        '
        'TSoles
        '
        Me.TSoles.HeaderText = "T. Soles"
        Me.TSoles.Name = "TSoles"
        '
        'TDolares
        '
        Me.TDolares.HeaderText = "T.Dolares"
        Me.TDolares.Name = "TDolares"
        '
        'Mon
        '
        Me.Mon.HeaderText = "Mon"
        Me.Mon.Items.AddRange(New Object() {"", "SOLES", "DOLARES"})
        Me.Mon.Name = "Mon"
        Me.Mon.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Mon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Comp
        '
        Me.Comp.HeaderText = "Comp."
        Me.Comp.Name = "Comp"
        '
        'Obs
        '
        Me.Obs.HeaderText = "Obs"
        Me.Obs.Name = "Obs"
        '
        'FECVEN
        '
        Me.FECVEN.HeaderText = "Fec. Venc."
        Me.FECVEN.Name = "FECVEN"
        '
        'Reparar
        '
        Me.Reparar.FalseValue = "N"
        Me.Reparar.HeaderText = "Reparar"
        Me.Reparar.Name = "Reparar"
        Me.Reparar.TrueValue = "S"
        '
        'CODPROVEEDOR
        '
        Me.CODPROVEEDOR.HeaderText = "CODPROVEEDOR"
        Me.CODPROVEEDOR.Name = "CODPROVEEDOR"
        Me.CODPROVEEDOR.Visible = False
        '
        'REPARAR2
        '
        Me.REPARAR2.HeaderText = "REPARAR2"
        Me.REPARAR2.Name = "REPARAR2"
        Me.REPARAR2.Visible = False
        '
        'CODART
        '
        Me.CODART.HeaderText = "Art. Cod."
        Me.CODART.Name = "CODART"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Controls.Add(Me.Txt_RegContable)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Txt_Soles)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Txt_Dolares)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Location = New System.Drawing.Point(14, 236)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(645, 34)
        Me.Panel2.TabIndex = 58
        '
        'Txt_RegContable
        '
        Me.Txt_RegContable.Location = New System.Drawing.Point(525, 7)
        Me.Txt_RegContable.Name = "Txt_RegContable"
        Me.Txt_RegContable.ReadOnly = True
        Me.Txt_RegContable.Size = New System.Drawing.Size(100, 20)
        Me.Txt_RegContable.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(431, 10)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 13)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Reg. Contable"
        '
        'Txt_Soles
        '
        Me.Txt_Soles.Location = New System.Drawing.Point(310, 7)
        Me.Txt_Soles.Name = "Txt_Soles"
        Me.Txt_Soles.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Soles.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(221, 10)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Total Soles"
        '
        'Txt_Dolares
        '
        Me.Txt_Dolares.Location = New System.Drawing.Point(96, 7)
        Me.Txt_Dolares.Name = "Txt_Dolares"
        Me.Txt_Dolares.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Dolares.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(7, 10)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Total Dólares"
        '
        'Txt_NAsiento
        '
        Me.Txt_NAsiento.Location = New System.Drawing.Point(590, 200)
        Me.Txt_NAsiento.Name = "Txt_NAsiento"
        Me.Txt_NAsiento.Size = New System.Drawing.Size(125, 20)
        Me.Txt_NAsiento.TabIndex = 57
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(587, 184)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 13)
        Me.Label17.TabIndex = 56
        Me.Label17.Text = "N. Asiento"
        '
        'Txt_Tcambio2
        '
        Me.Txt_Tcambio2.Location = New System.Drawing.Point(514, 200)
        Me.Txt_Tcambio2.Name = "Txt_Tcambio2"
        Me.Txt_Tcambio2.Size = New System.Drawing.Size(56, 20)
        Me.Txt_Tcambio2.TabIndex = 55
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(511, 184)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 13)
        Me.Label16.TabIndex = 54
        Me.Label16.Text = "T. Cambio"
        '
        'Txt_NomProveedor
        '
        Me.Txt_NomProveedor.Enabled = False
        Me.Txt_NomProveedor.Location = New System.Drawing.Point(110, 200)
        Me.Txt_NomProveedor.Name = "Txt_NomProveedor"
        Me.Txt_NomProveedor.Size = New System.Drawing.Size(352, 20)
        Me.Txt_NomProveedor.TabIndex = 53
        '
        'Txt_CodProveedor
        '
        Me.Txt_CodProveedor.Location = New System.Drawing.Point(14, 200)
        Me.Txt_CodProveedor.Name = "Txt_CodProveedor"
        Me.Txt_CodProveedor.Size = New System.Drawing.Size(90, 20)
        Me.Txt_CodProveedor.TabIndex = 52
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 184)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 13)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Proveedor/Cliente"
        '
        'Txt_NomCosto
        '
        Me.Txt_NomCosto.Enabled = False
        Me.Txt_NomCosto.Location = New System.Drawing.Point(225, 156)
        Me.Txt_NomCosto.Name = "Txt_NomCosto"
        Me.Txt_NomCosto.Size = New System.Drawing.Size(208, 20)
        Me.Txt_NomCosto.TabIndex = 50
        '
        'Txt_CodCosto
        '
        Me.Txt_CodCosto.Location = New System.Drawing.Point(170, 156)
        Me.Txt_CodCosto.Name = "Txt_CodCosto"
        Me.Txt_CodCosto.Size = New System.Drawing.Size(49, 20)
        Me.Txt_CodCosto.TabIndex = 49
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(167, 140)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "C. Costo"
        '
        'CmbMoneda
        '
        Me.CmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMoneda.FormattingEnabled = True
        Me.CmbMoneda.Location = New System.Drawing.Point(14, 156)
        Me.CmbMoneda.Name = "CmbMoneda"
        Me.CmbMoneda.Size = New System.Drawing.Size(144, 21)
        Me.CmbMoneda.TabIndex = 47
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 140)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Moneda"
        '
        'DatVencimiento
        '
        Me.DatVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatVencimiento.Location = New System.Drawing.Point(499, 113)
        Me.DatVencimiento.Name = "DatVencimiento"
        Me.DatVencimiento.Size = New System.Drawing.Size(96, 20)
        Me.DatVencimiento.TabIndex = 45
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(496, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 13)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Fecha Vencimiento"
        '
        'Txt_NomFpago
        '
        Me.Txt_NomFpago.Enabled = False
        Me.Txt_NomFpago.Location = New System.Drawing.Point(225, 112)
        Me.Txt_NomFpago.Name = "Txt_NomFpago"
        Me.Txt_NomFpago.Size = New System.Drawing.Size(208, 20)
        Me.Txt_NomFpago.TabIndex = 43
        '
        'Txt_CodFpago
        '
        Me.Txt_CodFpago.Location = New System.Drawing.Point(170, 112)
        Me.Txt_CodFpago.Name = "Txt_CodFpago"
        Me.Txt_CodFpago.Size = New System.Drawing.Size(49, 20)
        Me.Txt_CodFpago.TabIndex = 42
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(167, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Forma de Pago"
        '
        'CmbCobranza
        '
        Me.CmbCobranza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCobranza.FormattingEnabled = True
        Me.CmbCobranza.Items.AddRange(New Object() {"CANCELADO", "NO CANCELADO"})
        Me.CmbCobranza.Location = New System.Drawing.Point(14, 112)
        Me.CmbCobranza.Name = "CmbCobranza"
        Me.CmbCobranza.Size = New System.Drawing.Size(144, 21)
        Me.CmbCobranza.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Cobranza"
        '
        'Txt_Concepto
        '
        Me.Txt_Concepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Concepto.Location = New System.Drawing.Point(259, 68)
        Me.Txt_Concepto.Name = "Txt_Concepto"
        Me.Txt_Concepto.Size = New System.Drawing.Size(474, 20)
        Me.Txt_Concepto.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(256, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Concepto"
        '
        'CmbTDocumento
        '
        Me.CmbTDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTDocumento.FormattingEnabled = True
        Me.CmbTDocumento.Location = New System.Drawing.Point(269, 25)
        Me.CmbTDocumento.Name = "CmbTDocumento"
        Me.CmbTDocumento.Size = New System.Drawing.Size(210, 21)
        Me.CmbTDocumento.TabIndex = 36
        '
        'CmbTOperacion
        '
        Me.CmbTOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTOperacion.FormattingEnabled = True
        Me.CmbTOperacion.Items.AddRange(New Object() {"", "LIBRO DIARIO", "LIQUIDACION"})
        Me.CmbTOperacion.Location = New System.Drawing.Point(141, 25)
        Me.CmbTOperacion.Name = "CmbTOperacion"
        Me.CmbTOperacion.Size = New System.Drawing.Size(121, 21)
        Me.CmbTOperacion.TabIndex = 35
        '
        'CmbBanco
        '
        Me.CmbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBanco.FormattingEnabled = True
        Me.CmbBanco.Location = New System.Drawing.Point(14, 68)
        Me.CmbBanco.Name = "CmbBanco"
        Me.CmbBanco.Size = New System.Drawing.Size(198, 21)
        Me.CmbBanco.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Banco"
        '
        'DatFecha
        '
        Me.DatFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatFecha.Location = New System.Drawing.Point(654, 25)
        Me.DatFecha.Name = "DatFecha"
        Me.DatFecha.Size = New System.Drawing.Size(96, 20)
        Me.DatFecha.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(815, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Estado"
        '
        'CmbEstado
        '
        Me.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEstado.FormattingEnabled = True
        Me.CmbEstado.Items.AddRange(New Object() {"", "HABILITADO", "ANULADO", "REFERENCIADO", "TRANSFERIDO"})
        Me.CmbEstado.Location = New System.Drawing.Point(818, 25)
        Me.CmbEstado.Name = "CmbEstado"
        Me.CmbEstado.Size = New System.Drawing.Size(121, 21)
        Me.CmbEstado.TabIndex = 30
        '
        'Txt_Tcambio
        '
        Me.Txt_Tcambio.Location = New System.Drawing.Point(756, 25)
        Me.Txt_Tcambio.Name = "Txt_Tcambio"
        Me.Txt_Tcambio.Size = New System.Drawing.Size(56, 20)
        Me.Txt_Tcambio.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(753, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "T. Cambio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(651, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Fecha"
        '
        'Txt_numero
        '
        Me.Txt_numero.Location = New System.Drawing.Point(547, 25)
        Me.Txt_numero.Name = "Txt_numero"
        Me.Txt_numero.Size = New System.Drawing.Size(101, 20)
        Me.Txt_numero.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(544, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Número"
        '
        'Txt_serie
        '
        Me.Txt_serie.Location = New System.Drawing.Point(485, 25)
        Me.Txt_serie.Name = "Txt_serie"
        Me.Txt_serie.Size = New System.Drawing.Size(56, 20)
        Me.Txt_serie.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(482, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Serie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Tipo Documento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Tipo Operación"
        '
        'FormLibroDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 579)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tsbForm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLibroDiario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLibroDiario"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvDetLibro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DatFecha As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents CmbEstado As ComboBox
    Friend WithEvents Txt_Tcambio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_numero As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_serie As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CmbBanco As ComboBox
    Friend WithEvents CmbCobranza As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Txt_Concepto As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CmbTDocumento As ComboBox
    Friend WithEvents CmbTOperacion As ComboBox
    Friend WithEvents Txt_NomFpago As TextBox
    Friend WithEvents Txt_CodFpago As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DatVencimiento As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents CmbMoneda As ComboBox
    Friend WithEvents Txt_NomCosto As TextBox
    Friend WithEvents Txt_CodCosto As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Txt_NomProveedor As TextBox
    Friend WithEvents Txt_CodProveedor As TextBox
    Friend WithEvents Label15 As Label

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Friend WithEvents Txt_Tcambio2 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Txt_NAsiento As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DgvDetLibro As DataGridView
    Friend WithEvents Txt_Dolares As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Txt_RegContable As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Txt_Soles As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Btn_BuscarPago As Button
    Friend WithEvents Btn_BuscarCC As Button
    Friend WithEvents Btn_Proveedor As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Txt_fechareg As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Txt_usuario As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents tsbBorrar As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents cmbTipReg As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents lblEstado As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents btnDupRegistro As Button
    Friend WithEvents chkpago As CheckBox
    Friend WithEvents Documento As DataGridViewTextBoxColumn
    Friend WithEvents NomDoc As DataGridViewTextBoxColumn
    Friend WithEvents Afecto As DataGridViewComboBoxColumn
    Friend WithEvents Serie As DataGridViewTextBoxColumn
    Friend WithEvents Nro As DataGridViewTextBoxColumn
    Friend WithEvents Ccosto As DataGridViewTextBoxColumn
    Friend WithEvents Cuenta As DataGridViewTextBoxColumn
    Friend WithEvents CtaDes As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents Signo As DataGridViewComboBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents TCambio As DataGridViewTextBoxColumn
    Friend WithEvents TSoles As DataGridViewTextBoxColumn
    Friend WithEvents TDolares As DataGridViewTextBoxColumn
    Friend WithEvents Mon As DataGridViewComboBoxColumn
    Friend WithEvents Comp As DataGridViewTextBoxColumn
    Friend WithEvents Obs As DataGridViewTextBoxColumn
    Friend WithEvents FECVEN As DataGridViewTextBoxColumn
    Friend WithEvents Reparar As DataGridViewCheckBoxColumn
    Friend WithEvents CODPROVEEDOR As DataGridViewTextBoxColumn
    Friend WithEvents REPARAR2 As DataGridViewTextBoxColumn
    Friend WithEvents CODART As DataGridViewTextBoxColumn
End Class
