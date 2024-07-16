<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMantELTBCLIENTE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantELTBCLIENTE))
        Me.TabCorreo = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.txtser_cod = New System.Windows.Forms.TextBox()
        Me.lblser_cod = New System.Windows.Forms.TextBox()
        Me.lblciudad = New System.Windows.Forms.TextBox()
        Me.lblprovincia = New System.Windows.Forms.TextBox()
        Me.lbldistrito = New System.Windows.Forms.TextBox()
        Me.lblubigeo = New System.Windows.Forms.TextBox()
        Me.lblpais = New System.Windows.Forms.TextBox()
        Me.lblcodigo = New System.Windows.Forms.TextBox()
        Me.txt_codfpago = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbCondPago = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_ubigeo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkprotocolo = New System.Windows.Forms.CheckBox()
        Me.chkproveedor = New System.Windows.Forms.CheckBox()
        Me.chkextranjero = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbnego_cop = New System.Windows.Forms.ComboBox()
        Me.txtpais = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtvend_resp = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbvendedor = New System.Windows.Forms.ComboBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txttelef = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdir = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblsdas = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtruc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnborrardir = New System.Windows.Forms.Button()
        Me.btnmodificardir = New System.Windows.Forms.Button()
        Me.btnagregardir = New System.Windows.Forms.Button()
        Me.dgvt_dir = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnborrarcor = New System.Windows.Forms.Button()
        Me.btnmodificarcor = New System.Windows.Forms.Button()
        Me.btnagregarcor = New System.Windows.Forms.Button()
        Me.dgvt_cor = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnimprimir = New System.Windows.Forms.Button()
        Me.btnborrartel = New System.Windows.Forms.Button()
        Me.btnmodificartel = New System.Windows.Forms.Button()
        Me.btnagregartel = New System.Windows.Forms.Button()
        Me.dgvt_tel = New System.Windows.Forms.DataGridView()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCierre = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.chkcierre = New System.Windows.Forms.CheckBox()
        Me.chkpercepcion = New System.Windows.Forms.CheckBox()
        Me.chkretenedor = New System.Windows.Forms.CheckBox()
        Me.TabCorreo.SuspendLayout()
        Me.General.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvt_dir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvt_cor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvt_tel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsbForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabCorreo
        '
        Me.TabCorreo.Controls.Add(Me.General)
        Me.TabCorreo.Controls.Add(Me.TabPage1)
        Me.TabCorreo.Controls.Add(Me.TabPage2)
        Me.TabCorreo.Controls.Add(Me.TabPage3)
        Me.TabCorreo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabCorreo.ItemSize = New System.Drawing.Size(91, 20)
        Me.TabCorreo.Location = New System.Drawing.Point(10, 38)
        Me.TabCorreo.Name = "TabCorreo"
        Me.TabCorreo.SelectedIndex = 0
        Me.TabCorreo.Size = New System.Drawing.Size(723, 378)
        Me.TabCorreo.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabCorreo.TabIndex = 13
        '
        'General
        '
        Me.General.AccessibleDescription = ""
        Me.General.AccessibleName = ""
        Me.General.BackColor = System.Drawing.Color.White
        Me.General.Controls.Add(Me.txtser_cod)
        Me.General.Controls.Add(Me.lblser_cod)
        Me.General.Controls.Add(Me.lblciudad)
        Me.General.Controls.Add(Me.lblprovincia)
        Me.General.Controls.Add(Me.lbldistrito)
        Me.General.Controls.Add(Me.lblubigeo)
        Me.General.Controls.Add(Me.lblpais)
        Me.General.Controls.Add(Me.lblcodigo)
        Me.General.Controls.Add(Me.txt_codfpago)
        Me.General.Controls.Add(Me.Label11)
        Me.General.Controls.Add(Me.cmbCondPago)
        Me.General.Controls.Add(Me.Label12)
        Me.General.Controls.Add(Me.btn_ubigeo)
        Me.General.Controls.Add(Me.GroupBox1)
        Me.General.Controls.Add(Me.Label10)
        Me.General.Controls.Add(Me.cmbnego_cop)
        Me.General.Controls.Add(Me.txtpais)
        Me.General.Controls.Add(Me.Label9)
        Me.General.Controls.Add(Me.txtvend_resp)
        Me.General.Controls.Add(Me.Label8)
        Me.General.Controls.Add(Me.cmbvendedor)
        Me.General.Controls.Add(Me.txtDNI)
        Me.General.Controls.Add(Me.txttelef)
        Me.General.Controls.Add(Me.Label6)
        Me.General.Controls.Add(Me.Label4)
        Me.General.Controls.Add(Me.Label3)
        Me.General.Controls.Add(Me.txtnom)
        Me.General.Controls.Add(Me.Label2)
        Me.General.Controls.Add(Me.txtdir)
        Me.General.Controls.Add(Me.Label7)
        Me.General.Controls.Add(Me.lblsdas)
        Me.General.Controls.Add(Me.Label5)
        Me.General.Controls.Add(Me.txtruc)
        Me.General.Controls.Add(Me.Label1)
        Me.General.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.General.Location = New System.Drawing.Point(4, 24)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(10)
        Me.General.Size = New System.Drawing.Size(715, 350)
        Me.General.TabIndex = 0
        Me.General.Text = "Datos Generales"
        '
        'txtser_cod
        '
        Me.txtser_cod.BackColor = System.Drawing.SystemColors.Window
        Me.txtser_cod.Location = New System.Drawing.Point(117, 158)
        Me.txtser_cod.MaxLength = 5
        Me.txtser_cod.Name = "txtser_cod"
        Me.txtser_cod.Size = New System.Drawing.Size(60, 21)
        Me.txtser_cod.TabIndex = 5
        '
        'lblser_cod
        '
        Me.lblser_cod.BackColor = System.Drawing.Color.Gainsboro
        Me.lblser_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblser_cod.Location = New System.Drawing.Point(178, 158)
        Me.lblser_cod.Name = "lblser_cod"
        Me.lblser_cod.ReadOnly = True
        Me.lblser_cod.Size = New System.Drawing.Size(359, 21)
        Me.lblser_cod.TabIndex = 198
        '
        'lblciudad
        '
        Me.lblciudad.BackColor = System.Drawing.Color.Gainsboro
        Me.lblciudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblciudad.Location = New System.Drawing.Point(117, 129)
        Me.lblciudad.Name = "lblciudad"
        Me.lblciudad.ReadOnly = True
        Me.lblciudad.Size = New System.Drawing.Size(107, 21)
        Me.lblciudad.TabIndex = 197
        '
        'lblprovincia
        '
        Me.lblprovincia.BackColor = System.Drawing.Color.Gainsboro
        Me.lblprovincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblprovincia.Location = New System.Drawing.Point(339, 100)
        Me.lblprovincia.Name = "lblprovincia"
        Me.lblprovincia.ReadOnly = True
        Me.lblprovincia.Size = New System.Drawing.Size(152, 21)
        Me.lblprovincia.TabIndex = 196
        '
        'lbldistrito
        '
        Me.lbldistrito.BackColor = System.Drawing.Color.Gainsboro
        Me.lbldistrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldistrito.Location = New System.Drawing.Point(183, 100)
        Me.lbldistrito.Name = "lbldistrito"
        Me.lbldistrito.ReadOnly = True
        Me.lbldistrito.Size = New System.Drawing.Size(155, 21)
        Me.lbldistrito.TabIndex = 195
        '
        'lblubigeo
        '
        Me.lblubigeo.BackColor = System.Drawing.SystemColors.Window
        Me.lblubigeo.Location = New System.Drawing.Point(117, 100)
        Me.lblubigeo.MaxLength = 8
        Me.lblubigeo.Name = "lblubigeo"
        Me.lblubigeo.Size = New System.Drawing.Size(65, 21)
        Me.lblubigeo.TabIndex = 4
        '
        'lblpais
        '
        Me.lblpais.BackColor = System.Drawing.Color.Gainsboro
        Me.lblpais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblpais.Location = New System.Drawing.Point(381, 129)
        Me.lblpais.Name = "lblpais"
        Me.lblpais.ReadOnly = True
        Me.lblpais.Size = New System.Drawing.Size(156, 21)
        Me.lblpais.TabIndex = 193
        '
        'lblcodigo
        '
        Me.lblcodigo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodigo.Location = New System.Drawing.Point(421, 18)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.ReadOnly = True
        Me.lblcodigo.Size = New System.Drawing.Size(116, 21)
        Me.lblcodigo.TabIndex = 192
        '
        'txt_codfpago
        '
        Me.txt_codfpago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_codfpago.Location = New System.Drawing.Point(319, 217)
        Me.txt_codfpago.MaxLength = 10
        Me.txt_codfpago.Name = "txt_codfpago"
        Me.txt_codfpago.Size = New System.Drawing.Size(61, 21)
        Me.txt_codfpago.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(237, 215)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 23)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Condicion Pago"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCondPago
        '
        Me.cmbCondPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondPago.FormattingEnabled = True
        Me.cmbCondPago.Location = New System.Drawing.Point(381, 217)
        Me.cmbCondPago.Name = "cmbCondPago"
        Me.cmbCondPago.Size = New System.Drawing.Size(252, 21)
        Me.cmbCondPago.TabIndex = 47
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(371, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 23)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Codigo"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_ubigeo
        '
        Me.btn_ubigeo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ubigeo.Location = New System.Drawing.Point(491, 99)
        Me.btn_ubigeo.Name = "btn_ubigeo"
        Me.btn_ubigeo.Size = New System.Drawing.Size(46, 23)
        Me.btn_ubigeo.TabIndex = 4
        Me.btn_ubigeo.Text = "..."
        Me.btn_ubigeo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkpercepcion)
        Me.GroupBox1.Controls.Add(Me.chkretenedor)
        Me.GroupBox1.Controls.Add(Me.chkprotocolo)
        Me.GroupBox1.Controls.Add(Me.chkproveedor)
        Me.GroupBox1.Controls.Add(Me.chkextranjero)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 277)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(663, 61)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar"
        '
        'chkprotocolo
        '
        Me.chkprotocolo.AutoSize = True
        Me.chkprotocolo.Location = New System.Drawing.Point(125, 26)
        Me.chkprotocolo.Name = "chkprotocolo"
        Me.chkprotocolo.Size = New System.Drawing.Size(124, 17)
        Me.chkprotocolo.TabIndex = 13
        Me.chkprotocolo.Text = "Protocolo de Calidad"
        Me.chkprotocolo.UseVisualStyleBackColor = True
        '
        'chkproveedor
        '
        Me.chkproveedor.AutoSize = True
        Me.chkproveedor.Location = New System.Drawing.Point(266, 26)
        Me.chkproveedor.Name = "chkproveedor"
        Me.chkproveedor.Size = New System.Drawing.Size(76, 17)
        Me.chkproveedor.TabIndex = 14
        Me.chkproveedor.Text = "Proveedor"
        Me.chkproveedor.UseVisualStyleBackColor = True
        '
        'chkextranjero
        '
        Me.chkextranjero.AutoSize = True
        Me.chkextranjero.Location = New System.Drawing.Point(42, 26)
        Me.chkextranjero.Name = "chkextranjero"
        Me.chkextranjero.Size = New System.Drawing.Size(77, 17)
        Me.chkextranjero.TabIndex = 12
        Me.chkextranjero.Text = "Extranjero"
        Me.chkextranjero.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 241)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 23)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Categorizar"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbnego_cop
        '
        Me.cmbnego_cop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbnego_cop.FormattingEnabled = True
        Me.cmbnego_cop.Items.AddRange(New Object() {"EXCELENTE", "BUENO", "REGULAR"})
        Me.cmbnego_cop.Location = New System.Drawing.Point(117, 245)
        Me.cmbnego_cop.Name = "cmbnego_cop"
        Me.cmbnego_cop.Size = New System.Drawing.Size(107, 21)
        Me.cmbnego_cop.TabIndex = 11
        '
        'txtpais
        '
        Me.txtpais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpais.Enabled = False
        Me.txtpais.Location = New System.Drawing.Point(319, 129)
        Me.txtpais.MaxLength = 5
        Me.txtpais.Name = "txtpais"
        Me.txtpais.Size = New System.Drawing.Size(61, 21)
        Me.txtpais.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(237, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 23)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Nacionalidad"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtvend_resp
        '
        Me.txtvend_resp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtvend_resp.Location = New System.Drawing.Point(319, 186)
        Me.txtvend_resp.MaxLength = 10
        Me.txtvend_resp.Name = "txtvend_resp"
        Me.txtvend_resp.Size = New System.Drawing.Size(61, 21)
        Me.txtvend_resp.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(237, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 23)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Vendedor"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbvendedor
        '
        Me.cmbvendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbvendedor.FormattingEnabled = True
        Me.cmbvendedor.Location = New System.Drawing.Point(381, 186)
        Me.cmbvendedor.Name = "cmbvendedor"
        Me.cmbvendedor.Size = New System.Drawing.Size(252, 21)
        Me.cmbvendedor.TabIndex = 9
        '
        'txtDNI
        '
        Me.txtDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDNI.Location = New System.Drawing.Point(117, 217)
        Me.txtDNI.MaxLength = 10
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(107, 21)
        Me.txtDNI.TabIndex = 7
        '
        'txttelef
        '
        Me.txttelef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttelef.Location = New System.Drawing.Point(117, 188)
        Me.txttelef.MaxLength = 20
        Me.txttelef.Name = "txttelef"
        Me.txttelef.Size = New System.Drawing.Size(107, 21)
        Me.txttelef.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 23)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Telefono"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 23)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Actividad/Servicio"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Ciudad"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnom
        '
        Me.txtnom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnom.Location = New System.Drawing.Point(117, 44)
        Me.txtnom.MaxLength = 100
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(420, 21)
        Me.txtnom.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Ruc"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdir
        '
        Me.txtdir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdir.Location = New System.Drawing.Point(117, 72)
        Me.txtdir.MaxLength = 100
        Me.txtdir.Name = "txtdir"
        Me.txtdir.Size = New System.Drawing.Size(420, 21)
        Me.txtdir.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 23)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Direccion Principal"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblsdas
        '
        Me.lblsdas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsdas.Location = New System.Drawing.Point(20, 100)
        Me.lblsdas.Name = "lblsdas"
        Me.lblsdas.Size = New System.Drawing.Size(59, 23)
        Me.lblsdas.TabIndex = 17
        Me.lblsdas.Text = "Ubigeo"
        Me.lblsdas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 23)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "DNI"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtruc
        '
        Me.txtruc.Location = New System.Drawing.Point(117, 17)
        Me.txtruc.MaxLength = 20
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(107, 21)
        Me.txtruc.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnborrardir)
        Me.TabPage1.Controls.Add(Me.btnmodificardir)
        Me.TabPage1.Controls.Add(Me.btnagregardir)
        Me.TabPage1.Controls.Add(Me.dgvt_dir)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(715, 350)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Direcciones"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnborrardir
        '
        Me.btnborrardir.Location = New System.Drawing.Point(222, 309)
        Me.btnborrardir.Name = "btnborrardir"
        Me.btnborrardir.Size = New System.Drawing.Size(81, 23)
        Me.btnborrardir.TabIndex = 35
        Me.btnborrardir.Text = "Borrar"
        Me.btnborrardir.UseVisualStyleBackColor = True
        '
        'btnmodificardir
        '
        Me.btnmodificardir.Location = New System.Drawing.Point(121, 309)
        Me.btnmodificardir.Name = "btnmodificardir"
        Me.btnmodificardir.Size = New System.Drawing.Size(81, 23)
        Me.btnmodificardir.TabIndex = 34
        Me.btnmodificardir.Text = "Modificar"
        Me.btnmodificardir.UseVisualStyleBackColor = True
        '
        'btnagregardir
        '
        Me.btnagregardir.Location = New System.Drawing.Point(21, 309)
        Me.btnagregardir.Name = "btnagregardir"
        Me.btnagregardir.Size = New System.Drawing.Size(81, 23)
        Me.btnagregardir.TabIndex = 33
        Me.btnagregardir.Text = "Agregar"
        Me.btnagregardir.UseVisualStyleBackColor = True
        '
        'dgvt_dir
        '
        Me.dgvt_dir.AllowUserToAddRows = False
        Me.dgvt_dir.AllowUserToDeleteRows = False
        Me.dgvt_dir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_dir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_dir.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvt_dir.Location = New System.Drawing.Point(21, 17)
        Me.dgvt_dir.Name = "dgvt_dir"
        Me.dgvt_dir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_dir.Size = New System.Drawing.Size(671, 267)
        Me.dgvt_dir.TabIndex = 32
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnborrarcor)
        Me.TabPage2.Controls.Add(Me.btnmodificarcor)
        Me.TabPage2.Controls.Add(Me.btnagregarcor)
        Me.TabPage2.Controls.Add(Me.dgvt_cor)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(715, 350)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Correos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnborrarcor
        '
        Me.btnborrarcor.Location = New System.Drawing.Point(222, 309)
        Me.btnborrarcor.Name = "btnborrarcor"
        Me.btnborrarcor.Size = New System.Drawing.Size(81, 23)
        Me.btnborrarcor.TabIndex = 38
        Me.btnborrarcor.Text = "Borrar"
        Me.btnborrarcor.UseVisualStyleBackColor = True
        '
        'btnmodificarcor
        '
        Me.btnmodificarcor.Location = New System.Drawing.Point(121, 309)
        Me.btnmodificarcor.Name = "btnmodificarcor"
        Me.btnmodificarcor.Size = New System.Drawing.Size(81, 23)
        Me.btnmodificarcor.TabIndex = 37
        Me.btnmodificarcor.Text = "Modificar"
        Me.btnmodificarcor.UseVisualStyleBackColor = True
        '
        'btnagregarcor
        '
        Me.btnagregarcor.Location = New System.Drawing.Point(21, 309)
        Me.btnagregarcor.Name = "btnagregarcor"
        Me.btnagregarcor.Size = New System.Drawing.Size(81, 23)
        Me.btnagregarcor.TabIndex = 36
        Me.btnagregarcor.Text = "Agregar"
        Me.btnagregarcor.UseVisualStyleBackColor = True
        '
        'dgvt_cor
        '
        Me.dgvt_cor.AllowUserToAddRows = False
        Me.dgvt_cor.AllowUserToDeleteRows = False
        Me.dgvt_cor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_cor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_cor.Location = New System.Drawing.Point(21, 17)
        Me.dgvt_cor.Name = "dgvt_cor"
        Me.dgvt_cor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_cor.Size = New System.Drawing.Size(671, 267)
        Me.dgvt_cor.TabIndex = 33
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnimprimir)
        Me.TabPage3.Controls.Add(Me.btnborrartel)
        Me.TabPage3.Controls.Add(Me.btnmodificartel)
        Me.TabPage3.Controls.Add(Me.btnagregartel)
        Me.TabPage3.Controls.Add(Me.dgvt_tel)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(715, 350)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Cobranzas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnimprimir
        '
        Me.btnimprimir.Location = New System.Drawing.Point(323, 309)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(81, 23)
        Me.btnimprimir.TabIndex = 39
        Me.btnimprimir.Text = "Imprimir"
        Me.btnimprimir.UseVisualStyleBackColor = True
        '
        'btnborrartel
        '
        Me.btnborrartel.Location = New System.Drawing.Point(222, 309)
        Me.btnborrartel.Name = "btnborrartel"
        Me.btnborrartel.Size = New System.Drawing.Size(81, 23)
        Me.btnborrartel.TabIndex = 38
        Me.btnborrartel.Text = "Borrar"
        Me.btnborrartel.UseVisualStyleBackColor = True
        '
        'btnmodificartel
        '
        Me.btnmodificartel.Location = New System.Drawing.Point(121, 309)
        Me.btnmodificartel.Name = "btnmodificartel"
        Me.btnmodificartel.Size = New System.Drawing.Size(81, 23)
        Me.btnmodificartel.TabIndex = 37
        Me.btnmodificartel.Text = "Modificar"
        Me.btnmodificartel.UseVisualStyleBackColor = True
        '
        'btnagregartel
        '
        Me.btnagregartel.Location = New System.Drawing.Point(21, 309)
        Me.btnagregartel.Name = "btnagregartel"
        Me.btnagregartel.Size = New System.Drawing.Size(81, 23)
        Me.btnagregartel.TabIndex = 36
        Me.btnagregartel.Text = "Agregar"
        Me.btnagregartel.UseVisualStyleBackColor = True
        '
        'dgvt_tel
        '
        Me.dgvt_tel.AllowUserToAddRows = False
        Me.dgvt_tel.AllowUserToDeleteRows = False
        Me.dgvt_tel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_tel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_tel.Location = New System.Drawing.Point(21, 17)
        Me.dgvt_tel.Name = "dgvt_tel"
        Me.dgvt_tel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_tel.Size = New System.Drawing.Size(671, 267)
        Me.dgvt_tel.TabIndex = 33
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbCierre, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(747, 25)
        Me.tsbForm.TabIndex = 14
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
        'tsbCierre
        '
        Me.tsbCierre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCierre.Enabled = False
        Me.tsbCierre.Image = CType(resources.GetObject("tsbCierre.Image"), System.Drawing.Image)
        Me.tsbCierre.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCierre.Name = "tsbCierre"
        Me.tsbCierre.Size = New System.Drawing.Size(23, 22)
        Me.tsbCierre.Tag = "bcliente"
        Me.tsbCierre.Text = "Cierre"
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
        'chkcierre
        '
        Me.chkcierre.AutoSize = True
        Me.chkcierre.Enabled = False
        Me.chkcierre.Location = New System.Drawing.Point(559, 8)
        Me.chkcierre.Name = "chkcierre"
        Me.chkcierre.Size = New System.Drawing.Size(98, 17)
        Me.chkcierre.TabIndex = 15
        Me.chkcierre.Text = "Cliente Cerrado"
        Me.chkcierre.UseVisualStyleBackColor = True
        '
        'chkpercepcion
        '
        Me.chkpercepcion.AutoSize = True
        Me.chkpercepcion.Location = New System.Drawing.Point(510, 26)
        Me.chkpercepcion.Name = "chkpercepcion"
        Me.chkpercepcion.Size = New System.Drawing.Size(116, 17)
        Me.chkpercepcion.TabIndex = 18
        Me.chkpercepcion.Text = "Agente Percepcion"
        Me.chkpercepcion.UseVisualStyleBackColor = True
        '
        'chkretenedor
        '
        Me.chkretenedor.AutoSize = True
        Me.chkretenedor.Location = New System.Drawing.Point(357, 26)
        Me.chkretenedor.Name = "chkretenedor"
        Me.chkretenedor.Size = New System.Drawing.Size(115, 17)
        Me.chkretenedor.TabIndex = 17
        Me.chkretenedor.Text = "Agente Retenedor"
        Me.chkretenedor.UseVisualStyleBackColor = True
        '
        'FormMantELTBCLIENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 420)
        Me.Controls.Add(Me.chkcierre)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.TabCorreo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormMantELTBCLIENTE"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Cliente"
        Me.TabCorreo.ResumeLayout(False)
        Me.General.ResumeLayout(False)
        Me.General.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvt_dir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvt_cor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvt_tel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabCorreo As TabControl
    Friend WithEvents General As TabPage
    Friend WithEvents txttelef As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdir As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblsdas As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtruc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbnego_cop As ComboBox
    Friend WithEvents txtpais As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtvend_resp As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbvendedor As ComboBox
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents dgvt_dir As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkprotocolo As CheckBox
    Friend WithEvents chkproveedor As CheckBox
    Friend WithEvents chkextranjero As CheckBox
    Friend WithEvents btnborrardir As Button
    Friend WithEvents btnmodificardir As Button
    Friend WithEvents btnagregardir As Button
    Friend WithEvents btnborrarcor As Button
    Friend WithEvents btnmodificarcor As Button
    Friend WithEvents btnagregarcor As Button
    Friend WithEvents dgvt_cor As DataGridView
    Friend WithEvents dgvt_tel As DataGridView
    Friend WithEvents btnborrartel As Button
    Friend WithEvents btnmodificartel As Button
    Friend WithEvents btnagregartel As Button
    Friend WithEvents btn_ubigeo As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_codfpago As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbCondPago As ComboBox
    Friend WithEvents tsbCierre As ToolStripButton
    Friend WithEvents btnimprimir As Button
    Friend WithEvents chkcierre As CheckBox
    Friend WithEvents lblciudad As TextBox
    Friend WithEvents lblprovincia As TextBox
    Friend WithEvents lbldistrito As TextBox
    Friend WithEvents lblubigeo As TextBox
    Friend WithEvents lblpais As TextBox
    Friend WithEvents lblcodigo As TextBox
    Friend WithEvents txtser_cod As TextBox
    Friend WithEvents lblser_cod As TextBox
    Friend WithEvents chkpercepcion As CheckBox
    Friend WithEvents chkretenedor As CheckBox
End Class
