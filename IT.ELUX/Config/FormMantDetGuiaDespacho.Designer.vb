<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMantDetGuiaDespacho
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.npduprecio_dventa = New System.Windows.Forms.NumericUpDown()
        Me.npduprecio_venta = New System.Windows.Forms.NumericUpDown()
        Me.npdtcamb = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtigv_dimpor = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtigvimpor = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtigv = New System.Windows.Forms.TextBox()
        Me.txttcomprad = New System.Windows.Forms.TextBox()
        Me.txttcompras = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txttprecio_dventa = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txttprecio_venta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtdscto_dimpor = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtdscto_impor = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtdscto = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.npdpeso = New System.Windows.Forms.NumericUpDown()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtpfec_ent = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtnro_docu1 = New System.Windows.Forms.TextBox()
        Me.txtserie_soli = New System.Windows.Forms.TextBox()
        Me.txtstk = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.npdstk = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtcodart = New System.Windows.Forms.TextBox()
        Me.cmbart = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbsublinea = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmblinea = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtobservacion = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbuni = New System.Windows.Forms.ComboBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.npdcantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnregresar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.npduprecio_dventa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npduprecio_venta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdtcamb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.npdpeso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdstk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.npduprecio_dventa)
        Me.GroupBox2.Controls.Add(Me.npduprecio_venta)
        Me.GroupBox2.Controls.Add(Me.npdtcamb)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtigv_dimpor)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtigvimpor)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtigv)
        Me.GroupBox2.Controls.Add(Me.txttcomprad)
        Me.GroupBox2.Controls.Add(Me.txttcompras)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txttprecio_dventa)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txttprecio_venta)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtdscto_dimpor)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtdscto_impor)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtdscto)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(12, 225)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(665, 138)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Valores de Venta"
        '
        'npduprecio_dventa
        '
        Me.npduprecio_dventa.DecimalPlaces = 5
        Me.npduprecio_dventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.npduprecio_dventa.Location = New System.Drawing.Point(105, 76)
        Me.npduprecio_dventa.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.npduprecio_dventa.Name = "npduprecio_dventa"
        Me.npduprecio_dventa.Size = New System.Drawing.Size(127, 20)
        Me.npduprecio_dventa.TabIndex = 15
        Me.npduprecio_dventa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'npduprecio_venta
        '
        Me.npduprecio_venta.DecimalPlaces = 5
        Me.npduprecio_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.npduprecio_venta.Location = New System.Drawing.Point(105, 50)
        Me.npduprecio_venta.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.npduprecio_venta.Name = "npduprecio_venta"
        Me.npduprecio_venta.Size = New System.Drawing.Size(128, 20)
        Me.npduprecio_venta.TabIndex = 14
        Me.npduprecio_venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'npdtcamb
        '
        Me.npdtcamb.DecimalPlaces = 3
        Me.npdtcamb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.npdtcamb.Location = New System.Drawing.Point(105, 22)
        Me.npdtcamb.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.npdtcamb.Name = "npdtcamb"
        Me.npdtcamb.Size = New System.Drawing.Size(127, 20)
        Me.npdtcamb.TabIndex = 13
        Me.npdtcamb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(467, 102)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 13)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "IGV Dolares"
        '
        'txtigv_dimpor
        '
        Me.txtigv_dimpor.Enabled = False
        Me.txtigv_dimpor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtigv_dimpor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtigv_dimpor.Location = New System.Drawing.Point(545, 96)
        Me.txtigv_dimpor.Name = "txtigv_dimpor"
        Me.txtigv_dimpor.Size = New System.Drawing.Size(102, 20)
        Me.txtigv_dimpor.TabIndex = 66
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(251, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "IGV Soles"
        '
        'txtigvimpor
        '
        Me.txtigvimpor.Enabled = False
        Me.txtigvimpor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtigvimpor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtigvimpor.Location = New System.Drawing.Point(344, 101)
        Me.txtigvimpor.Name = "txtigvimpor"
        Me.txtigvimpor.Size = New System.Drawing.Size(102, 20)
        Me.txtigvimpor.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(3, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Porc. IGV"
        '
        'txtigv
        '
        Me.txtigv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtigv.Location = New System.Drawing.Point(106, 103)
        Me.txtigv.Name = "txtigv"
        Me.txtigv.Size = New System.Drawing.Size(127, 20)
        Me.txtigv.TabIndex = 16
        '
        'txttcomprad
        '
        Me.txttcomprad.Enabled = False
        Me.txttcomprad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttcomprad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txttcomprad.Location = New System.Drawing.Point(545, 68)
        Me.txttcomprad.Name = "txttcomprad"
        Me.txttcomprad.Size = New System.Drawing.Size(102, 20)
        Me.txttcomprad.TabIndex = 64
        '
        'txttcompras
        '
        Me.txttcompras.Enabled = False
        Me.txttcompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttcompras.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txttcompras.Location = New System.Drawing.Point(545, 42)
        Me.txttcompras.Name = "txttcompras"
        Me.txttcompras.Size = New System.Drawing.Size(102, 20)
        Me.txttcompras.TabIndex = 63
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(249, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Total Venta ($/.)"
        '
        'txttprecio_dventa
        '
        Me.txttprecio_dventa.Enabled = False
        Me.txttprecio_dventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttprecio_dventa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txttprecio_dventa.Location = New System.Drawing.Point(344, 72)
        Me.txttprecio_dventa.Name = "txttprecio_dventa"
        Me.txttprecio_dventa.Size = New System.Drawing.Size(102, 20)
        Me.txttprecio_dventa.TabIndex = 61
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(249, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Total Venta (S/.)"
        '
        'txttprecio_venta
        '
        Me.txttprecio_venta.Enabled = False
        Me.txttprecio_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttprecio_venta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txttprecio_venta.Location = New System.Drawing.Point(344, 46)
        Me.txttprecio_venta.Name = "txttprecio_venta"
        Me.txttprecio_venta.Size = New System.Drawing.Size(102, 20)
        Me.txttprecio_venta.TabIndex = 60
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(3, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Precio Unitario ($/.)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(3, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Precio Unitario (S/.)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(3, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tipo de cambio"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(467, 98)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 13)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Dcto. Dolares"
        Me.Label16.Visible = False
        '
        'txtdscto_dimpor
        '
        Me.txtdscto_dimpor.Enabled = False
        Me.txtdscto_dimpor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtdscto_dimpor.Location = New System.Drawing.Point(546, 94)
        Me.txtdscto_dimpor.Name = "txtdscto_dimpor"
        Me.txtdscto_dimpor.Size = New System.Drawing.Size(102, 20)
        Me.txtdscto_dimpor.TabIndex = 65
        Me.txtdscto_dimpor.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(249, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Dcto. Soles"
        Me.Label14.Visible = False
        '
        'txtdscto_impor
        '
        Me.txtdscto_impor.Enabled = False
        Me.txtdscto_impor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtdscto_impor.Location = New System.Drawing.Point(343, 101)
        Me.txtdscto_impor.Name = "txtdscto_impor"
        Me.txtdscto_impor.Size = New System.Drawing.Size(102, 20)
        Me.txtdscto_impor.TabIndex = 62
        Me.txtdscto_impor.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(2, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Porc. de Descto"
        Me.Label11.Visible = False
        '
        'txtdscto
        '
        Me.txtdscto.Location = New System.Drawing.Point(105, 103)
        Me.txtdscto.Name = "txtdscto"
        Me.txtdscto.Size = New System.Drawing.Size(127, 20)
        Me.txtdscto.TabIndex = 12
        Me.txtdscto.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.npdpeso)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.dtpfec_ent)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtnro_docu1)
        Me.GroupBox1.Controls.Add(Me.txtserie_soli)
        Me.GroupBox1.Controls.Add(Me.txtstk)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.npdstk)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtcodart)
        Me.GroupBox1.Controls.Add(Me.cmbart)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.cmbsublinea)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmblinea)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtobservacion)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.cmbuni)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.npdcantidad)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(665, 209)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selección Articulo"
        '
        'npdpeso
        '
        Me.npdpeso.DecimalPlaces = 3
        Me.npdpeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.npdpeso.ForeColor = System.Drawing.SystemColors.ControlText
        Me.npdpeso.Location = New System.Drawing.Point(416, 104)
        Me.npdpeso.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.npdpeso.Name = "npdpeso"
        Me.npdpeso.Size = New System.Drawing.Size(82, 20)
        Me.npdpeso.TabIndex = 74
        Me.npdpeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(379, 106)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(31, 13)
        Me.Label21.TabIndex = 73
        Me.Label21.Text = "Peso"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(470, 137)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 13)
        Me.Label20.TabIndex = 72
        Me.Label20.Text = "Fec. Ent"
        '
        'dtpfec_ent
        '
        Me.dtpfec_ent.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ent.Location = New System.Drawing.Point(528, 134)
        Me.dtpfec_ent.Name = "dtpfec_ent"
        Me.dtpfec_ent.Size = New System.Drawing.Size(85, 20)
        Me.dtpfec_ent.TabIndex = 11
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(234, 137)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 13)
        Me.Label18.TabIndex = 70
        Me.Label18.Text = "Numero Solicitud"
        '
        'txtnro_docu1
        '
        Me.txtnro_docu1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnro_docu1.Location = New System.Drawing.Point(327, 134)
        Me.txtnro_docu1.MaxLength = 7
        Me.txtnro_docu1.Name = "txtnro_docu1"
        Me.txtnro_docu1.Size = New System.Drawing.Size(120, 20)
        Me.txtnro_docu1.TabIndex = 10
        '
        'txtserie_soli
        '
        Me.txtserie_soli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtserie_soli.Location = New System.Drawing.Point(89, 131)
        Me.txtserie_soli.Name = "txtserie_soli"
        Me.txtserie_soli.Size = New System.Drawing.Size(120, 20)
        Me.txtserie_soli.TabIndex = 9
        '
        'txtstk
        '
        Me.txtstk.Location = New System.Drawing.Point(545, 102)
        Me.txtstk.Name = "txtstk"
        Me.txtstk.ReadOnly = True
        Me.txtstk.Size = New System.Drawing.Size(103, 20)
        Me.txtstk.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(9, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Serie Solicitud"
        '
        'npdstk
        '
        Me.npdstk.DecimalPlaces = 3
        Me.npdstk.Enabled = False
        Me.npdstk.Location = New System.Drawing.Point(545, 102)
        Me.npdstk.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.npdstk.Name = "npdstk"
        Me.npdstk.Size = New System.Drawing.Size(103, 20)
        Me.npdstk.TabIndex = 66
        Me.npdstk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(504, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Stock"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(562, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 23)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtcodart
        '
        Me.txtcodart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcodart.Location = New System.Drawing.Point(80, 74)
        Me.txtcodart.Name = "txtcodart"
        Me.txtcodart.Size = New System.Drawing.Size(84, 20)
        Me.txtcodart.TabIndex = 3
        '
        'cmbart
        '
        Me.cmbart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbart.FormattingEnabled = True
        Me.cmbart.Location = New System.Drawing.Point(170, 74)
        Me.cmbart.Name = "cmbart"
        Me.cmbart.Size = New System.Drawing.Size(386, 21)
        Me.cmbart.TabIndex = 4
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(9, 77)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(46, 13)
        Me.Label22.TabIndex = 63
        Me.Label22.Text = "Codigo :"
        '
        'cmbsublinea
        '
        Me.cmbsublinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsublinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsublinea.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbsublinea.FormattingEnabled = True
        Me.cmbsublinea.Location = New System.Drawing.Point(80, 47)
        Me.cmbsublinea.Name = "cmbsublinea"
        Me.cmbsublinea.Size = New System.Drawing.Size(568, 21)
        Me.cmbsublinea.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Sub Linea"
        '
        'cmblinea
        '
        Me.cmblinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmblinea.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmblinea.FormattingEnabled = True
        Me.cmblinea.Location = New System.Drawing.Point(80, 20)
        Me.cmblinea.Name = "cmblinea"
        Me.cmblinea.Size = New System.Drawing.Size(568, 21)
        Me.cmblinea.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(9, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 13)
        Me.Label17.TabIndex = 61
        Me.Label17.Text = "Linea"
        '
        'txtobservacion
        '
        Me.txtobservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtobservacion.Location = New System.Drawing.Point(80, 157)
        Me.txtobservacion.Multiline = True
        Me.txtobservacion.Name = "txtobservacion"
        Me.txtobservacion.Size = New System.Drawing.Size(568, 46)
        Me.txtobservacion.TabIndex = 12
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(7, 159)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 13)
        Me.Label19.TabIndex = 57
        Me.Label19.Text = "Observacion"
        '
        'cmbuni
        '
        Me.cmbuni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbuni.Enabled = False
        Me.cmbuni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbuni.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbuni.FormattingEnabled = True
        Me.cmbuni.Location = New System.Drawing.Point(80, 102)
        Me.cmbuni.Name = "cmbuni"
        Me.cmbuni.Size = New System.Drawing.Size(129, 21)
        Me.cmbuni.TabIndex = 7
        '
        'btnbuscar
        '
        Me.btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnbuscar.Location = New System.Drawing.Point(602, 73)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(46, 23)
        Me.btnbuscar.TabIndex = 56
        Me.btnbuscar.Text = "Todos"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'npdcantidad
        '
        Me.npdcantidad.DecimalPlaces = 3
        Me.npdcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.npdcantidad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.npdcantidad.Location = New System.Drawing.Point(272, 102)
        Me.npdcantidad.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.npdcantidad.Name = "npdcantidad"
        Me.npdcantidad.Size = New System.Drawing.Size(101, 20)
        Me.npdcantidad.TabIndex = 8
        Me.npdcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Unidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(217, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad"
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(467, 369)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 20
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnregresar
        '
        Me.btnregresar.Location = New System.Drawing.Point(558, 369)
        Me.btnregresar.Name = "btnregresar"
        Me.btnregresar.Size = New System.Drawing.Size(75, 23)
        Me.btnregresar.TabIndex = 21
        Me.btnregresar.Text = "Salir"
        Me.btnregresar.UseVisualStyleBackColor = True
        '
        'FormMantDetGuiaDespacho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 404)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.btnregresar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormMantDetGuiaDespacho"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMantDetGuiaDespacho"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.npduprecio_dventa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npduprecio_venta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdtcamb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.npdpeso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdstk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents npduprecio_dventa As NumericUpDown
    Friend WithEvents npduprecio_venta As NumericUpDown
    Friend WithEvents npdtcamb As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents txtigv_dimpor As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtigvimpor As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtigv As TextBox
    Friend WithEvents txttcomprad As TextBox
    Friend WithEvents txttcompras As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txttprecio_dventa As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txttprecio_venta As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtdscto_dimpor As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtdscto_impor As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtdscto As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtstk As TextBox
    Friend WithEvents npdstk As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtcodart As TextBox
    Friend WithEvents cmbart As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cmbsublinea As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmblinea As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtobservacion As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents cmbuni As ComboBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents npdcantidad As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnregresar As Button
    Friend WithEvents txtserie_soli As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnro_docu1 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents dtpfec_ent As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents npdpeso As NumericUpDown
End Class
