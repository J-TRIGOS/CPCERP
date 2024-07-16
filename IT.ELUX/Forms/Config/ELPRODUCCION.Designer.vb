<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ELPRODUCCION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ELPRODUCCION))
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpfec_entre = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblart_des = New System.Windows.Forms.TextBox()
        Me.lblcod_art = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblnro_doc_ref = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblstc_actual = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblpendiente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_atend = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblpedido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbunidad = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chk3 = New System.Windows.Forms.CheckBox()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.chk2 = New System.Windows.Forms.CheckBox()
        Me.cmbarticulos = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtdemasia = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbdemasia = New System.Windows.Forms.TextBox()
        Me.chknivel = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkPedido = New System.Windows.Forms.CheckBox()
        Me.chkPorstock = New System.Windows.Forms.CheckBox()
        Me.tvwExplosion = New System.Windows.Forms.TreeView()
        Me.tsbForm.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbimprimir, Me.ToolStripButton1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(1101, 25)
        Me.tsbForm.TabIndex = 23
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpfec_entre)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblart_des)
        Me.GroupBox2.Controls.Add(Me.lblcod_art)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblnro_doc_ref)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(593, 89)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Generales OT"
        '
        'dtpfec_entre
        '
        Me.dtpfec_entre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_entre.Location = New System.Drawing.Point(462, 24)
        Me.dtpfec_entre.Name = "dtpfec_entre"
        Me.dtpfec_entre.Size = New System.Drawing.Size(115, 20)
        Me.dtpfec_entre.TabIndex = 226
        Me.dtpfec_entre.Value = New Date(2019, 2, 22, 14, 52, 36, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(330, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 15)
        Me.Label1.TabIndex = 225
        Me.Label1.Text = "OT (Fecha Entrega)"
        '
        'lblart_des
        '
        Me.lblart_des.BackColor = System.Drawing.Color.Gainsboro
        Me.lblart_des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblart_des.Location = New System.Drawing.Point(218, 57)
        Me.lblart_des.Name = "lblart_des"
        Me.lblart_des.ReadOnly = True
        Me.lblart_des.Size = New System.Drawing.Size(359, 20)
        Me.lblart_des.TabIndex = 224
        '
        'lblcod_art
        '
        Me.lblcod_art.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcod_art.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcod_art.Location = New System.Drawing.Point(97, 57)
        Me.lblcod_art.Name = "lblcod_art"
        Me.lblcod_art.ReadOnly = True
        Me.lblcod_art.Size = New System.Drawing.Size(120, 20)
        Me.lblcod_art.TabIndex = 223
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 15)
        Me.Label8.TabIndex = 222
        Me.Label8.Text = "OT (Articulo)"
        '
        'lblnro_doc_ref
        '
        Me.lblnro_doc_ref.BackColor = System.Drawing.Color.Gainsboro
        Me.lblnro_doc_ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnro_doc_ref.Location = New System.Drawing.Point(97, 24)
        Me.lblnro_doc_ref.Name = "lblnro_doc_ref"
        Me.lblnro_doc_ref.ReadOnly = True
        Me.lblnro_doc_ref.Size = New System.Drawing.Size(120, 20)
        Me.lblnro_doc_ref.TabIndex = 191
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "OT (Ventas)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblstc_actual)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblpendiente)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbl_atend)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblpedido)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(593, 100)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cantidades"
        '
        'lblstc_actual
        '
        Me.lblstc_actual.BackColor = System.Drawing.Color.Gainsboro
        Me.lblstc_actual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblstc_actual.Location = New System.Drawing.Point(457, 59)
        Me.lblstc_actual.Name = "lblstc_actual"
        Me.lblstc_actual.ReadOnly = True
        Me.lblstc_actual.Size = New System.Drawing.Size(120, 20)
        Me.lblstc_actual.TabIndex = 227
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(321, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 15)
        Me.Label3.TabIndex = 226
        Me.Label3.Text = "Almacen (Stock Actual)"
        '
        'lblpendiente
        '
        Me.lblpendiente.BackColor = System.Drawing.Color.Gainsboro
        Me.lblpendiente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblpendiente.Location = New System.Drawing.Point(457, 26)
        Me.lblpendiente.Name = "lblpendiente"
        Me.lblpendiente.ReadOnly = True
        Me.lblpendiente.Size = New System.Drawing.Size(120, 20)
        Me.lblpendiente.TabIndex = 225
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(362, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 15)
        Me.Label6.TabIndex = 224
        Me.Label6.Text = "OT (Pendiente)"
        '
        'lbl_atend
        '
        Me.lbl_atend.BackColor = System.Drawing.Color.Gainsboro
        Me.lbl_atend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_atend.Location = New System.Drawing.Point(97, 59)
        Me.lbl_atend.Name = "lbl_atend"
        Me.lbl_atend.ReadOnly = True
        Me.lbl_atend.Size = New System.Drawing.Size(120, 20)
        Me.lbl_atend.TabIndex = 223
        Me.lbl_atend.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 222
        Me.Label4.Text = "OT (Atendido)"
        '
        'lblpedido
        '
        Me.lblpedido.BackColor = System.Drawing.Color.Gainsboro
        Me.lblpedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblpedido.Location = New System.Drawing.Point(97, 26)
        Me.lblpedido.Name = "lblpedido"
        Me.lblpedido.ReadOnly = True
        Me.lblpedido.Size = New System.Drawing.Size(120, 20)
        Me.lblpedido.TabIndex = 191
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "OT (Pedido)"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbunidad)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtdescripcion)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.chk3)
        Me.GroupBox3.Controls.Add(Me.chk1)
        Me.GroupBox3.Controls.Add(Me.chk2)
        Me.GroupBox3.Controls.Add(Me.cmbarticulos)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 237)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(593, 146)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Generales OP Temporal [TB0]"
        '
        'cmbunidad
        '
        Me.cmbunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbunidad.FormattingEnabled = True
        Me.cmbunidad.Location = New System.Drawing.Point(97, 115)
        Me.cmbunidad.Name = "cmbunidad"
        Me.cmbunidad.Size = New System.Drawing.Size(121, 21)
        Me.cmbunidad.TabIndex = 235
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 15)
        Me.Label9.TabIndex = 234
        Me.Label9.Text = "Unidad Med."
        '
        'txtdescripcion
        '
        Me.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcion.Location = New System.Drawing.Point(97, 89)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(416, 20)
        Me.txtdescripcion.TabIndex = 233
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 15)
        Me.Label7.TabIndex = 232
        Me.Label7.Text = "Descripcion"
        '
        'chk3
        '
        Me.chk3.AutoSize = True
        Me.chk3.Location = New System.Drawing.Point(414, 63)
        Me.chk3.Name = "chk3"
        Me.chk3.Size = New System.Drawing.Size(99, 17)
        Me.chk3.TabIndex = 231
        Me.chk3.Text = "X stock sin  OT"
        Me.chk3.UseVisualStyleBackColor = True
        '
        'chk1
        '
        Me.chk1.AutoSize = True
        Me.chk1.Location = New System.Drawing.Point(15, 63)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(92, 17)
        Me.chk1.TabIndex = 230
        Me.chk1.Text = "X stock  + OT"
        Me.chk1.UseVisualStyleBackColor = True
        '
        'chk2
        '
        Me.chk2.AutoSize = True
        Me.chk2.Location = New System.Drawing.Point(187, 63)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(137, 17)
        Me.chk2.TabIndex = 229
        Me.chk2.Text = "X stock Esplosion + OT"
        Me.chk2.UseVisualStyleBackColor = True
        '
        'cmbarticulos
        '
        Me.cmbarticulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbarticulos.FormattingEnabled = True
        Me.cmbarticulos.Location = New System.Drawing.Point(97, 30)
        Me.cmbarticulos.Name = "cmbarticulos"
        Me.cmbarticulos.Size = New System.Drawing.Size(121, 21)
        Me.cmbarticulos.TabIndex = 228
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 15)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "Codigo"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txttotal)
        Me.GroupBox4.Controls.Add(Me.txtdemasia)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.cmbdemasia)
        Me.GroupBox4.Controls.Add(Me.chknivel)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.txtcantidad)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.chkPedido)
        Me.GroupBox4.Controls.Add(Me.chkPorstock)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 387)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(593, 125)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cantidad de OP Temporal [TB0]"
        '
        'txttotal
        '
        Me.txttotal.BackColor = System.Drawing.Color.Gainsboro
        Me.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttotal.Location = New System.Drawing.Point(127, 98)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(91, 20)
        Me.txttotal.TabIndex = 245
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtdemasia
        '
        Me.txtdemasia.BackColor = System.Drawing.Color.Gainsboro
        Me.txtdemasia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdemasia.Location = New System.Drawing.Point(127, 77)
        Me.txtdemasia.Name = "txtdemasia"
        Me.txtdemasia.ReadOnly = True
        Me.txtdemasia.Size = New System.Drawing.Size(91, 20)
        Me.txtdemasia.TabIndex = 244
        Me.txtdemasia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(14, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 15)
        Me.Label14.TabIndex = 241
        Me.Label14.Text = "Total a Generar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 15)
        Me.Label10.TabIndex = 240
        Me.Label10.Text = "Demasia  %"
        '
        'cmbdemasia
        '
        Me.cmbdemasia.Location = New System.Drawing.Point(443, 23)
        Me.cmbdemasia.Name = "cmbdemasia"
        Me.cmbdemasia.Size = New System.Drawing.Size(55, 20)
        Me.cmbdemasia.TabIndex = 239
        Me.cmbdemasia.Text = "7"
        Me.cmbdemasia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chknivel
        '
        Me.chknivel.AutoSize = True
        Me.chknivel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chknivel.Location = New System.Drawing.Point(349, 98)
        Me.chknivel.Name = "chknivel"
        Me.chknivel.Size = New System.Drawing.Size(149, 17)
        Me.chknivel.TabIndex = 238
        Me.chknivel.Text = "Considerar solo el nivel (0)"
        Me.chknivel.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(366, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 15)
        Me.Label13.TabIndex = 236
        Me.Label13.Text = "% Demasia"
        '
        'txtcantidad
        '
        Me.txtcantidad.Enabled = False
        Me.txtcantidad.Location = New System.Drawing.Point(127, 56)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(91, 20)
        Me.txtcantidad.TabIndex = 233
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 15)
        Me.Label12.TabIndex = 232
        Me.Label12.Text = "Cantidad Generar"
        '
        'chkPedido
        '
        Me.chkPedido.AutoSize = True
        Me.chkPedido.Checked = True
        Me.chkPedido.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPedido.Location = New System.Drawing.Point(16, 26)
        Me.chkPedido.Name = "chkPedido"
        Me.chkPedido.Size = New System.Drawing.Size(71, 17)
        Me.chkPedido.TabIndex = 230
        Me.chkPedido.Text = "El Pedido"
        Me.chkPedido.UseVisualStyleBackColor = True
        '
        'chkPorstock
        '
        Me.chkPorstock.AutoSize = True
        Me.chkPorstock.Location = New System.Drawing.Point(187, 26)
        Me.chkPorstock.Name = "chkPorstock"
        Me.chkPorstock.Size = New System.Drawing.Size(73, 17)
        Me.chkPorstock.TabIndex = 229
        Me.chkPorstock.Text = "Por Stock"
        Me.chkPorstock.UseVisualStyleBackColor = True
        '
        'tvwExplosion
        '
        Me.tvwExplosion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvwExplosion.Location = New System.Drawing.Point(603, 47)
        Me.tvwExplosion.Name = "tvwExplosion"
        Me.tvwExplosion.Size = New System.Drawing.Size(490, 465)
        Me.tvwExplosion.TabIndex = 28
        '
        'ELPRODUCCION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 524)
        Me.Controls.Add(Me.tvwExplosion)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.tsbForm)
        Me.Name = "ELPRODUCCION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de Producción"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblnro_doc_ref As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblart_des As TextBox
    Friend WithEvents lblcod_art As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpfec_entre As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_atend As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblpedido As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblstc_actual As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblpendiente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbunidad As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents cmbarticulos As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chknivel As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents chkPedido As CheckBox
    Friend WithEvents chkPorstock As CheckBox
    Friend WithEvents tvwExplosion As TreeView
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbdemasia As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtdemasia As TextBox
End Class
