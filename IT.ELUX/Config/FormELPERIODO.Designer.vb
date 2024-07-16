<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormELPERIODO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormELPERIODO))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.chkactivar = New System.Windows.Forms.CheckBox()
        Me.cmbproc = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpfec_pag = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbt_personal = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_mes = New System.Windows.Forms.ComboBox()
        Me.cmb_año = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpfec_fin = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpfec_ini = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblcod = New System.Windows.Forms.Label()
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
        Me.TabControl1.Location = New System.Drawing.Point(12, 38)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(723, 378)
        Me.TabControl1.TabIndex = 19
        '
        'General
        '
        Me.General.BackColor = System.Drawing.Color.White
        Me.General.Controls.Add(Me.chkactivar)
        Me.General.Controls.Add(Me.cmbproc)
        Me.General.Controls.Add(Me.Label10)
        Me.General.Controls.Add(Me.dtpfec_pag)
        Me.General.Controls.Add(Me.Label5)
        Me.General.Controls.Add(Me.cmbt_personal)
        Me.General.Controls.Add(Me.Label2)
        Me.General.Controls.Add(Me.cmb_mes)
        Me.General.Controls.Add(Me.cmb_año)
        Me.General.Controls.Add(Me.Label7)
        Me.General.Controls.Add(Me.GroupBox1)
        Me.General.Controls.Add(Me.Label6)
        Me.General.Controls.Add(Me.lblcod)
        Me.General.Controls.Add(Me.Label1)
        Me.General.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(715, 352)
        Me.General.TabIndex = 0
        Me.General.Text = "GENERAL"
        '
        'chkactivar
        '
        Me.chkactivar.AutoSize = True
        Me.chkactivar.Location = New System.Drawing.Point(16, 143)
        Me.chkactivar.Name = "chkactivar"
        Me.chkactivar.Size = New System.Drawing.Size(60, 17)
        Me.chkactivar.TabIndex = 3
        Me.chkactivar.Text = "Activar"
        Me.chkactivar.UseVisualStyleBackColor = True
        '
        'cmbproc
        '
        Me.cmbproc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbproc.FormattingEnabled = True
        Me.cmbproc.Items.AddRange(New Object() {"SI", "NO"})
        Me.cmbproc.Location = New System.Drawing.Point(98, 251)
        Me.cmbproc.Name = "cmbproc"
        Me.cmbproc.Size = New System.Drawing.Size(49, 21)
        Me.cmbproc.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 256)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 123
        Me.Label10.Text = "Procesado"
        '
        'dtpfec_pag
        '
        Me.dtpfec_pag.Checked = False
        Me.dtpfec_pag.CustomFormat = ""
        Me.dtpfec_pag.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_pag.Location = New System.Drawing.Point(98, 214)
        Me.dtpfec_pag.Name = "dtpfec_pag"
        Me.dtpfec_pag.Size = New System.Drawing.Size(95, 21)
        Me.dtpfec_pag.TabIndex = 6
        Me.dtpfec_pag.Value = New Date(2018, 12, 17, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "Fecha Pago"
        '
        'cmbt_personal
        '
        Me.cmbt_personal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbt_personal.FormattingEnabled = True
        Me.cmbt_personal.Items.AddRange(New Object() {"EMPLEADO", "OBRERO"})
        Me.cmbt_personal.Location = New System.Drawing.Point(98, 180)
        Me.cmbt_personal.Name = "cmbt_personal"
        Me.cmbt_personal.Size = New System.Drawing.Size(116, 21)
        Me.cmbt_personal.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Tipo Personal"
        '
        'cmb_mes
        '
        Me.cmb_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mes.FormattingEnabled = True
        Me.cmb_mes.Items.AddRange(New Object() {"01 - ENERO", "02 - FEBRERO", "03 - MARZO", "04 - ABRIL", "05 - MAYO", "06 - JUNIO", "07 - JULIO", "08 - AGOSTO", "09 - SETIEMBRE", "10 - OCTUBRE", "11 - NOVIEMBRE", "12 - DICIEMBRE"})
        Me.cmb_mes.Location = New System.Drawing.Point(98, 96)
        Me.cmb_mes.Name = "cmb_mes"
        Me.cmb_mes.Size = New System.Drawing.Size(145, 21)
        Me.cmb_mes.TabIndex = 2
        '
        'cmb_año
        '
        Me.cmb_año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_año.FormattingEnabled = True
        Me.cmb_año.Items.AddRange(New Object() {"2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028"})
        Me.cmb_año.Location = New System.Drawing.Point(98, 60)
        Me.cmb_año.Name = "cmb_año"
        Me.cmb_año.Size = New System.Drawing.Size(66, 21)
        Me.cmb_año.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Mes"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpfec_fin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpfec_ini)
        Me.GroupBox1.Location = New System.Drawing.Point(98, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 45)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(171, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Fin"
        '
        'dtpfec_fin
        '
        Me.dtpfec_fin.Checked = False
        Me.dtpfec_fin.CustomFormat = ""
        Me.dtpfec_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_fin.Location = New System.Drawing.Point(198, 18)
        Me.dtpfec_fin.Name = "dtpfec_fin"
        Me.dtpfec_fin.Size = New System.Drawing.Size(95, 21)
        Me.dtpfec_fin.TabIndex = 7
        Me.dtpfec_fin.Value = New Date(2018, 12, 17, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Inicio"
        '
        'dtpfec_ini
        '
        Me.dtpfec_ini.Checked = False
        Me.dtpfec_ini.CustomFormat = ""
        Me.dtpfec_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ini.Location = New System.Drawing.Point(50, 17)
        Me.dtpfec_ini.Name = "dtpfec_ini"
        Me.dtpfec_ini.Size = New System.Drawing.Size(95, 21)
        Me.dtpfec_ini.TabIndex = 6
        Me.dtpfec_ini.Value = New Date(2018, 12, 17, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Año"
        '
        'lblcod
        '
        Me.lblcod.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcod.Location = New System.Drawing.Point(98, 27)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(66, 21)
        Me.lblcod.TabIndex = 44
        Me.lblcod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Codigo"
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbBorrar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(747, 25)
        Me.tsbForm.TabIndex = 20
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
        'FormELPERIODO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 420)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormELPERIODO"
        Me.Text = "Actualizar Periodos"
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
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpfec_fin As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpfec_ini As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents lblcod As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbBorrar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents cmb_año As ComboBox
    Friend WithEvents cmbt_personal As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_mes As ComboBox
    Friend WithEvents cmbproc As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpfec_pag As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents chkactivar As CheckBox
End Class
