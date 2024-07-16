<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegistroDetBindCard
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMovArt = New System.Windows.Forms.Button()
        Me.txt_kardex = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.datFecGene = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnRptBindCard = New System.Windows.Forms.Button()
        Me.btn_anular = New System.Windows.Forms.Button()
        Me.btn_procesar = New System.Windows.Forms.Button()
        Me.cmb_estado = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_articulo = New System.Windows.Forms.TextBox()
        Me.txt_codart = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_serie = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cantConsumo = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_nomartop = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_codartop = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbCentro = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnBuscarOP = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_merma = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_rendimiento = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_operario = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_maquina = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_reingreso = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_consumo = New System.Windows.Forms.TextBox()
        Me.txt_descr = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_ope = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.datFec = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgv_detbindcard = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_detbindcard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btnMovArt)
        Me.Panel1.Controls.Add(Me.txt_kardex)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.txtLote)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.datFecGene)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.btnRptBindCard)
        Me.Panel1.Controls.Add(Me.btn_anular)
        Me.Panel1.Controls.Add(Me.btn_procesar)
        Me.Panel1.Controls.Add(Me.cmb_estado)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.btn_actualizar)
        Me.Panel1.Controls.Add(Me.btn_registrar)
        Me.Panel1.Controls.Add(Me.txt_cantidad)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_articulo)
        Me.Panel1.Controls.Add(Me.txt_codart)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_numero)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_serie)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1220, 177)
        Me.Panel1.TabIndex = 0
        '
        'btnMovArt
        '
        Me.btnMovArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMovArt.Location = New System.Drawing.Point(1128, 29)
        Me.btnMovArt.Name = "btnMovArt"
        Me.btnMovArt.Size = New System.Drawing.Size(79, 45)
        Me.btnMovArt.TabIndex = 28
        Me.btnMovArt.Text = "Mov. Articulo"
        Me.btnMovArt.UseVisualStyleBackColor = True
        '
        'txt_kardex
        '
        Me.txt_kardex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kardex.Location = New System.Drawing.Point(644, 10)
        Me.txt_kardex.Name = "txt_kardex"
        Me.txt_kardex.Size = New System.Drawing.Size(100, 20)
        Me.txt_kardex.TabIndex = 27
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(592, 13)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 13)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "Kardex:"
        '
        'txtLote
        '
        Me.txtLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.Location = New System.Drawing.Point(363, 43)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(100, 20)
        Me.txtLote.TabIndex = 25
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(332, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 13)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Lote:"
        '
        'datFecGene
        '
        Me.datFecGene.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datFecGene.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datFecGene.Location = New System.Drawing.Point(890, 10)
        Me.datFecGene.Name = "datFecGene"
        Me.datFecGene.Size = New System.Drawing.Size(96, 20)
        Me.datFecGene.TabIndex = 20
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(833, 13)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 13)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Fec, Gen"
        '
        'btnRptBindCard
        '
        Me.btnRptBindCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRptBindCard.Location = New System.Drawing.Point(703, 32)
        Me.btnRptBindCard.Name = "btnRptBindCard"
        Me.btnRptBindCard.Size = New System.Drawing.Size(75, 45)
        Me.btnRptBindCard.TabIndex = 22
        Me.btnRptBindCard.Text = "Imprimir BindCard"
        Me.btnRptBindCard.UseVisualStyleBackColor = True
        '
        'btn_anular
        '
        Me.btn_anular.Enabled = False
        Me.btn_anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_anular.Location = New System.Drawing.Point(1027, 29)
        Me.btn_anular.Name = "btn_anular"
        Me.btn_anular.Size = New System.Drawing.Size(95, 45)
        Me.btn_anular.TabIndex = 21
        Me.btn_anular.Text = "Anular Kardex Bind Card"
        Me.btn_anular.UseVisualStyleBackColor = True
        '
        'btn_procesar
        '
        Me.btn_procesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_procesar.Location = New System.Drawing.Point(946, 29)
        Me.btn_procesar.Name = "btn_procesar"
        Me.btn_procesar.Size = New System.Drawing.Size(75, 45)
        Me.btn_procesar.TabIndex = 20
        Me.btn_procesar.Text = "Procesar Bind Card"
        Me.btn_procesar.UseVisualStyleBackColor = True
        '
        'cmb_estado
        '
        Me.cmb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_estado.FormattingEnabled = True
        Me.cmb_estado.Items.AddRange(New Object() {"", "GENERADO", "ATENDIDO", "PENDIENTE", "ANULADO"})
        Me.cmb_estado.Location = New System.Drawing.Point(540, 44)
        Me.cmb_estado.Name = "cmb_estado"
        Me.cmb_estado.Size = New System.Drawing.Size(160, 21)
        Me.cmb_estado.TabIndex = 19
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(488, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Estado: "
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizar.Location = New System.Drawing.Point(865, 30)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(75, 45)
        Me.btn_actualizar.TabIndex = 17
        Me.btn_actualizar.Text = "Actualizar Registros"
        Me.btn_actualizar.UseVisualStyleBackColor = True
        '
        'btn_registrar
        '
        Me.btn_registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrar.Location = New System.Drawing.Point(784, 31)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(75, 45)
        Me.btn_registrar.TabIndex = 16
        Me.btn_registrar.Text = "Registrar Consumo"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad.Location = New System.Drawing.Point(485, 10)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_cantidad.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(433, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cantidad: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Articulo:"
        '
        'txt_articulo
        '
        Me.txt_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_articulo.Location = New System.Drawing.Point(59, 44)
        Me.txt_articulo.Multiline = True
        Me.txt_articulo.Name = "txt_articulo"
        Me.txt_articulo.Size = New System.Drawing.Size(267, 39)
        Me.txt_articulo.TabIndex = 6
        '
        'txt_codart
        '
        Me.txt_codart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codart.Location = New System.Drawing.Point(326, 10)
        Me.txt_codart.Name = "txt_codart"
        Me.txt_codart.Size = New System.Drawing.Size(100, 20)
        Me.txt_codart.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(278, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cod. Art."
        '
        'txt_numero
        '
        Me.txt_numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero.Location = New System.Drawing.Point(173, 10)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(100, 20)
        Me.txt_numero.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Número: "
        '
        'txt_serie
        '
        Me.txt_serie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_serie.Location = New System.Drawing.Point(40, 10)
        Me.txt_serie.Name = "txt_serie"
        Me.txt_serie.Size = New System.Drawing.Size(79, 20)
        Me.txt_serie.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Serie: "
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.cantConsumo)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.txt_nomartop)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.txt_codartop)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.cmbCentro)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.btnBuscarOP)
        Me.Panel2.Controls.Add(Me.btn_buscar)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.txt_merma)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txt_rendimiento)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txt_operario)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txt_maquina)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txt_reingreso)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txt_consumo)
        Me.Panel2.Controls.Add(Me.txt_descr)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txt_ope)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.datFec)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(12, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1220, 263)
        Me.Panel2.TabIndex = 1
        '
        'cantConsumo
        '
        Me.cantConsumo.AutoSize = True
        Me.cantConsumo.Location = New System.Drawing.Point(97, 243)
        Me.cantConsumo.Name = "cantConsumo"
        Me.cantConsumo.Size = New System.Drawing.Size(0, 13)
        Me.cantConsumo.TabIndex = 27
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(11, 243)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 13)
        Me.Label22.TabIndex = 26
        Me.Label22.Text = "Cant. Cons."
        '
        'txt_nomartop
        '
        Me.txt_nomartop.Enabled = False
        Me.txt_nomartop.Location = New System.Drawing.Point(303, 60)
        Me.txt_nomartop.Name = "txt_nomartop"
        Me.txt_nomartop.Size = New System.Drawing.Size(488, 20)
        Me.txt_nomartop.TabIndex = 25
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(217, 63)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 13)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Art. OP"
        '
        'txt_codartop
        '
        Me.txt_codartop.Enabled = False
        Me.txt_codartop.Location = New System.Drawing.Point(97, 60)
        Me.txt_codartop.Name = "txt_codartop"
        Me.txt_codartop.Size = New System.Drawing.Size(100, 20)
        Me.txt_codartop.TabIndex = 23
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(11, 63)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 13)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Cod. Art. OP"
        '
        'cmbCentro
        '
        Me.cmbCentro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCentro.FormattingEnabled = True
        Me.cmbCentro.Location = New System.Drawing.Point(398, 34)
        Me.cmbCentro.Name = "cmbCentro"
        Me.cmbCentro.Size = New System.Drawing.Size(221, 21)
        Me.cmbCentro.TabIndex = 21
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(318, 37)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 13)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Centro Costo: "
        '
        'btnBuscarOP
        '
        Me.btnBuscarOP.Location = New System.Drawing.Point(203, 31)
        Me.btnBuscarOP.Name = "btnBuscarOP"
        Me.btnBuscarOP.Size = New System.Drawing.Size(67, 23)
        Me.btnBuscarOP.TabIndex = 19
        Me.btnBuscarOP.Text = "Buscar OP"
        Me.btnBuscarOP.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(363, 190)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(100, 23)
        Me.btn_buscar.TabIndex = 18
        Me.btn_buscar.Text = "Buscar Operario"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 115)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Merma: "
        '
        'txt_merma
        '
        Me.txt_merma.Location = New System.Drawing.Point(97, 112)
        Me.txt_merma.Name = "txt_merma"
        Me.txt_merma.Size = New System.Drawing.Size(100, 20)
        Me.txt_merma.TabIndex = 16
        Me.txt_merma.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 219)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Rendimiento:"
        '
        'txt_rendimiento
        '
        Me.txt_rendimiento.Location = New System.Drawing.Point(97, 216)
        Me.txt_rendimiento.Name = "txt_rendimiento"
        Me.txt_rendimiento.Size = New System.Drawing.Size(96, 20)
        Me.txt_rendimiento.TabIndex = 14
        Me.txt_rendimiento.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 193)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Operario: "
        '
        'txt_operario
        '
        Me.txt_operario.Enabled = False
        Me.txt_operario.Location = New System.Drawing.Point(97, 190)
        Me.txt_operario.Name = "txt_operario"
        Me.txt_operario.Size = New System.Drawing.Size(260, 20)
        Me.txt_operario.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 167)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Maquina: "
        '
        'txt_maquina
        '
        Me.txt_maquina.Location = New System.Drawing.Point(97, 164)
        Me.txt_maquina.Name = "txt_maquina"
        Me.txt_maquina.Size = New System.Drawing.Size(260, 20)
        Me.txt_maquina.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Reingreso:"
        '
        'txt_reingreso
        '
        Me.txt_reingreso.Location = New System.Drawing.Point(97, 138)
        Me.txt_reingreso.Name = "txt_reingreso"
        Me.txt_reingreso.Size = New System.Drawing.Size(260, 20)
        Me.txt_reingreso.TabIndex = 8
        Me.txt_reingreso.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Consumo:"
        '
        'txt_consumo
        '
        Me.txt_consumo.Location = New System.Drawing.Point(97, 82)
        Me.txt_consumo.Name = "txt_consumo"
        Me.txt_consumo.Size = New System.Drawing.Size(100, 20)
        Me.txt_consumo.TabIndex = 6
        Me.txt_consumo.Text = "0"
        '
        'txt_descr
        '
        Me.txt_descr.Location = New System.Drawing.Point(303, 86)
        Me.txt_descr.Name = "txt_descr"
        Me.txt_descr.Size = New System.Drawing.Size(260, 20)
        Me.txt_descr.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(217, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Observaciones"
        '
        'txt_ope
        '
        Me.txt_ope.Location = New System.Drawing.Point(97, 34)
        Me.txt_ope.Name = "txt_ope"
        Me.txt_ope.Size = New System.Drawing.Size(100, 20)
        Me.txt_ope.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "N° OP:"
        '
        'datFec
        '
        Me.datFec.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datFec.Location = New System.Drawing.Point(97, 8)
        Me.datFec.Name = "datFec"
        Me.datFec.Size = New System.Drawing.Size(96, 20)
        Me.datFec.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Fecha: "
        '
        'dgv_detbindcard
        '
        Me.dgv_detbindcard.AllowUserToAddRows = False
        Me.dgv_detbindcard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_detbindcard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detbindcard.Location = New System.Drawing.Point(12, 367)
        Me.dgv_detbindcard.Name = "dgv_detbindcard"
        Me.dgv_detbindcard.ReadOnly = True
        Me.dgv_detbindcard.Size = New System.Drawing.Size(1220, 298)
        Me.dgv_detbindcard.TabIndex = 2
        '
        'FormRegistroDetBindCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 677)
        Me.Controls.Add(Me.dgv_detbindcard)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormRegistroDetBindCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRegistroDetBindCard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgv_detbindcard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_articulo As TextBox
    Friend WithEvents txt_codart As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_serie As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents datFec As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_ope As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_descr As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_maquina As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_reingreso As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_consumo As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_operario As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_rendimiento As TextBox
    Friend WithEvents dgv_detbindcard As DataGridView
    Friend WithEvents btn_registrar As Button
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents cmb_estado As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_merma As TextBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_procesar As Button
    Friend WithEvents btn_anular As Button
    Friend WithEvents btnRptBindCard As Button
    Friend WithEvents btnBuscarOP As Button
    Friend WithEvents datFecGene As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents txtLote As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbCentro As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_nomartop As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_codartop As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_kardex As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents cantConsumo As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents btnMovArt As Button
End Class
