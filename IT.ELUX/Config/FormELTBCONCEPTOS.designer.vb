<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormELTBCONCEPTOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormELTBCONCEPTOS))
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.txtt_impres = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.txtt_cpto = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbsigno1 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblcta_hab = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtcta_hab = New System.Windows.Forms.TextBox()
        Me.txtporc = New System.Windows.Forms.TextBox()
        Me.lbl_cod_cpto = New System.Windows.Forms.Label()
        Me.txtcpto_cod = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblcod = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblcta_splan = New System.Windows.Forms.Label()
        Me.lblcta_ven = New System.Windows.Forms.Label()
        Me.lblcta_plan = New System.Windows.Forms.Label()
        Me.lblcta_adm = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcta_splan = New System.Windows.Forms.TextBox()
        Me.cmbsigno = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcta_ven = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcta_plan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcta_adm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_t_per_cod = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsbForm.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.General.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbBorrar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(747, 25)
        Me.tsbForm.TabIndex = 19
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(9, 35)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(723, 378)
        Me.TabControl1.TabIndex = 27
        '
        'General
        '
        Me.General.BackColor = System.Drawing.Color.White
        Me.General.Controls.Add(Me.txtt_impres)
        Me.General.Controls.Add(Me.Label18)
        Me.General.Controls.Add(Me.lbltipo)
        Me.General.Controls.Add(Me.txtt_cpto)
        Me.General.Controls.Add(Me.Label17)
        Me.General.Controls.Add(Me.cmbsigno1)
        Me.General.Controls.Add(Me.Label15)
        Me.General.Controls.Add(Me.lblcta_hab)
        Me.General.Controls.Add(Me.Label14)
        Me.General.Controls.Add(Me.txtcta_hab)
        Me.General.Controls.Add(Me.txtporc)
        Me.General.Controls.Add(Me.lbl_cod_cpto)
        Me.General.Controls.Add(Me.txtcpto_cod)
        Me.General.Controls.Add(Me.Label11)
        Me.General.Controls.Add(Me.lblcod)
        Me.General.Controls.Add(Me.Label10)
        Me.General.Controls.Add(Me.lblcta_splan)
        Me.General.Controls.Add(Me.lblcta_ven)
        Me.General.Controls.Add(Me.lblcta_plan)
        Me.General.Controls.Add(Me.lblcta_adm)
        Me.General.Controls.Add(Me.Label9)
        Me.General.Controls.Add(Me.txtcta_splan)
        Me.General.Controls.Add(Me.cmbsigno)
        Me.General.Controls.Add(Me.Label8)
        Me.General.Controls.Add(Me.txtcta_ven)
        Me.General.Controls.Add(Me.Label7)
        Me.General.Controls.Add(Me.txtcta_plan)
        Me.General.Controls.Add(Me.Label5)
        Me.General.Controls.Add(Me.txtcta_adm)
        Me.General.Controls.Add(Me.Label4)
        Me.General.Controls.Add(Me.txtmonto)
        Me.General.Controls.Add(Me.Label3)
        Me.General.Controls.Add(Me.Label2)
        Me.General.Controls.Add(Me.cmb_t_per_cod)
        Me.General.Controls.Add(Me.Label6)
        Me.General.Controls.Add(Me.txtnom)
        Me.General.Controls.Add(Me.Label1)
        Me.General.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(715, 352)
        Me.General.TabIndex = 0
        Me.General.Text = "GENERAL"
        '
        'txtt_impres
        '
        Me.txtt_impres.Location = New System.Drawing.Point(465, 50)
        Me.txtt_impres.MaxLength = 3
        Me.txtt_impres.Name = "txtt_impres"
        Me.txtt_impres.Size = New System.Drawing.Size(66, 21)
        Me.txtt_impres.TabIndex = 12
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(397, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 23)
        Me.Label18.TabIndex = 130
        Me.Label18.Text = "O. impres"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbltipo
        '
        Me.lbltipo.BackColor = System.Drawing.Color.Gainsboro
        Me.lbltipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltipo.Location = New System.Drawing.Point(509, 19)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(191, 21)
        Me.lbltipo.TabIndex = 129
        Me.lbltipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtt_cpto
        '
        Me.txtt_cpto.Location = New System.Drawing.Point(465, 19)
        Me.txtt_cpto.MaxLength = 5
        Me.txtt_cpto.Name = "txtt_cpto"
        Me.txtt_cpto.Size = New System.Drawing.Size(43, 21)
        Me.txtt_cpto.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(397, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 23)
        Me.Label17.TabIndex = 127
        Me.Label17.Text = "Tipo Cpto"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbsigno1
        '
        Me.cmbsigno1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsigno1.FormattingEnabled = True
        Me.cmbsigno1.Items.AddRange(New Object() {"+", "-"})
        Me.cmbsigno1.Location = New System.Drawing.Point(465, 106)
        Me.cmbsigno1.Name = "cmbsigno1"
        Me.cmbsigno1.Size = New System.Drawing.Size(66, 21)
        Me.cmbsigno1.TabIndex = 126
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(397, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 23)
        Me.Label15.TabIndex = 125
        Me.Label15.Text = "Signo 1"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcta_hab
        '
        Me.lblcta_hab.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcta_hab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcta_hab.Location = New System.Drawing.Point(194, 313)
        Me.lblcta_hab.Name = "lblcta_hab"
        Me.lblcta_hab.Size = New System.Drawing.Size(235, 21)
        Me.lblcta_hab.TabIndex = 124
        Me.lblcta_hab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(26, 311)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 23)
        Me.Label14.TabIndex = 123
        Me.Label14.Text = "Cta Haberes"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcta_hab
        '
        Me.txtcta_hab.Location = New System.Drawing.Point(111, 313)
        Me.txtcta_hab.MaxLength = 15
        Me.txtcta_hab.Name = "txtcta_hab"
        Me.txtcta_hab.Size = New System.Drawing.Size(82, 21)
        Me.txtcta_hab.TabIndex = 10
        Me.txtcta_hab.Tag = "5"
        '
        'txtporc
        '
        Me.txtporc.Location = New System.Drawing.Point(111, 134)
        Me.txtporc.MaxLength = 5
        Me.txtporc.Name = "txtporc"
        Me.txtporc.Size = New System.Drawing.Size(43, 21)
        Me.txtporc.TabIndex = 4
        '
        'lbl_cod_cpto
        '
        Me.lbl_cod_cpto.BackColor = System.Drawing.Color.Gainsboro
        Me.lbl_cod_cpto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_cod_cpto.Location = New System.Drawing.Point(155, 77)
        Me.lbl_cod_cpto.Name = "lbl_cod_cpto"
        Me.lbl_cod_cpto.Size = New System.Drawing.Size(191, 21)
        Me.lbl_cod_cpto.TabIndex = 120
        Me.lbl_cod_cpto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcpto_cod
        '
        Me.txtcpto_cod.Location = New System.Drawing.Point(111, 77)
        Me.txtcpto_cod.MaxLength = 5
        Me.txtcpto_cod.Name = "txtcpto_cod"
        Me.txtcpto_cod.Size = New System.Drawing.Size(43, 21)
        Me.txtcpto_cod.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(26, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 23)
        Me.Label11.TabIndex = 118
        Me.Label11.Text = "Cod Cpto"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcod
        '
        Me.lblcod.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcod.Location = New System.Drawing.Point(111, 17)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(43, 21)
        Me.lblcod.TabIndex = 117
        Me.lblcod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 23)
        Me.Label10.TabIndex = 116
        Me.Label10.Text = "Codigo"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcta_splan
        '
        Me.lblcta_splan.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcta_splan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcta_splan.Location = New System.Drawing.Point(194, 283)
        Me.lblcta_splan.Name = "lblcta_splan"
        Me.lblcta_splan.Size = New System.Drawing.Size(235, 21)
        Me.lblcta_splan.TabIndex = 115
        Me.lblcta_splan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcta_ven
        '
        Me.lblcta_ven.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcta_ven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcta_ven.Location = New System.Drawing.Point(194, 252)
        Me.lblcta_ven.Name = "lblcta_ven"
        Me.lblcta_ven.Size = New System.Drawing.Size(235, 21)
        Me.lblcta_ven.TabIndex = 114
        Me.lblcta_ven.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcta_plan
        '
        Me.lblcta_plan.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcta_plan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcta_plan.Location = New System.Drawing.Point(194, 221)
        Me.lblcta_plan.Name = "lblcta_plan"
        Me.lblcta_plan.Size = New System.Drawing.Size(235, 21)
        Me.lblcta_plan.TabIndex = 113
        Me.lblcta_plan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcta_adm
        '
        Me.lblcta_adm.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcta_adm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcta_adm.Location = New System.Drawing.Point(194, 191)
        Me.lblcta_adm.Name = "lblcta_adm"
        Me.lblcta_adm.Size = New System.Drawing.Size(235, 21)
        Me.lblcta_adm.TabIndex = 112
        Me.lblcta_adm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 23)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "Cta S. Planta "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcta_splan
        '
        Me.txtcta_splan.Location = New System.Drawing.Point(111, 283)
        Me.txtcta_splan.MaxLength = 15
        Me.txtcta_splan.Name = "txtcta_splan"
        Me.txtcta_splan.Size = New System.Drawing.Size(82, 21)
        Me.txtcta_splan.TabIndex = 9
        Me.txtcta_splan.Tag = "4"
        '
        'cmbsigno
        '
        Me.cmbsigno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsigno.FormattingEnabled = True
        Me.cmbsigno.Items.AddRange(New Object() {"+", "-"})
        Me.cmbsigno.Location = New System.Drawing.Point(465, 80)
        Me.cmbsigno.Name = "cmbsigno"
        Me.cmbsigno.Size = New System.Drawing.Size(66, 21)
        Me.cmbsigno.TabIndex = 108
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(397, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 23)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "Signo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcta_ven
        '
        Me.txtcta_ven.Location = New System.Drawing.Point(111, 252)
        Me.txtcta_ven.MaxLength = 15
        Me.txtcta_ven.Name = "txtcta_ven"
        Me.txtcta_ven.Size = New System.Drawing.Size(82, 21)
        Me.txtcta_ven.TabIndex = 8
        Me.txtcta_ven.Tag = "3"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 250)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 23)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Cta Ventas"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcta_plan
        '
        Me.txtcta_plan.Location = New System.Drawing.Point(111, 221)
        Me.txtcta_plan.MaxLength = 15
        Me.txtcta_plan.Name = "txtcta_plan"
        Me.txtcta_plan.Size = New System.Drawing.Size(82, 21)
        Me.txtcta_plan.TabIndex = 7
        Me.txtcta_plan.Tag = "2"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 23)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Cta Planta"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcta_adm
        '
        Me.txtcta_adm.Location = New System.Drawing.Point(111, 191)
        Me.txtcta_adm.MaxLength = 15
        Me.txtcta_adm.Name = "txtcta_adm"
        Me.txtcta_adm.Size = New System.Drawing.Size(82, 21)
        Me.txtcta_adm.TabIndex = 6
        Me.txtcta_adm.Tag = "1"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 23)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Cta Adm."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(111, 162)
        Me.txtmonto.MaxLength = 16
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(82, 21)
        Me.txtmonto.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 23)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Monto"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Porcentaje"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_t_per_cod
        '
        Me.cmb_t_per_cod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_t_per_cod.FormattingEnabled = True
        Me.cmb_t_per_cod.Items.AddRange(New Object() {"EMPLEADO", "OBRERO"})
        Me.cmb_t_per_cod.Location = New System.Drawing.Point(111, 106)
        Me.cmb_t_per_cod.Name = "cmb_t_per_cod"
        Me.cmb_t_per_cod.Size = New System.Drawing.Size(145, 21)
        Me.cmb_t_per_cod.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 23)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "T. Personal"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnom
        '
        Me.txtnom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnom.Location = New System.Drawing.Point(111, 48)
        Me.txtnom.MaxLength = 60
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(235, 21)
        Me.txtnom.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 23)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Concepto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormELCONCEPTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 420)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.tsbForm)
        Me.Name = "FormELCONCEPTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relación de Conceptos"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.General.ResumeLayout(False)
        Me.General.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbBorrar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents General As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents lblcta_splan As Label
    Friend WithEvents lblcta_ven As Label
    Friend WithEvents lblcta_plan As Label
    Friend WithEvents lblcta_adm As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtcta_splan As TextBox
    Friend WithEvents cmbsigno As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcta_ven As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcta_plan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcta_adm As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtmonto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblcod As Label
    Friend WithEvents lbl_cod_cpto As Label
    Friend WithEvents txtcpto_cod As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmb_t_per_cod As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtt_impres As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents lbltipo As Label
    Friend WithEvents txtt_cpto As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbsigno1 As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lblcta_hab As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtcta_hab As TextBox
    Friend WithEvents txtporc As TextBox
End Class
