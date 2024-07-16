<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormELSUBSIDIOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormELSUBSIDIOS))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.LblDias = New System.Windows.Forms.Label()
        Me.Btn_Calculo = New System.Windows.Forms.Button()
        Me.txtndoc = New System.Windows.Forms.TextBox()
        Me.txtsdoc = New System.Windows.Forms.TextBox()
        Me.cmb_motivo1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_motivo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtminutos1 = New System.Windows.Forms.TextBox()
        Me.txtminutos = New System.Windows.Forms.TextBox()
        Me.txtsubsidio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblper_cod = New System.Windows.Forms.Label()
        Me.txtper_cod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpfec_fin = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpfec_ini = New System.Windows.Forms.DateTimePicker()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.DgvPagos = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.General.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tsbForm.SuspendLayout()
        CType(Me.DgvPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 30)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(723, 378)
        Me.TabControl1.TabIndex = 21
        '
        'General
        '
        Me.General.BackColor = System.Drawing.Color.White
        Me.General.Controls.Add(Me.LblDias)
        Me.General.Controls.Add(Me.Btn_Calculo)
        Me.General.Controls.Add(Me.txtndoc)
        Me.General.Controls.Add(Me.txtsdoc)
        Me.General.Controls.Add(Me.cmb_motivo1)
        Me.General.Controls.Add(Me.Label9)
        Me.General.Controls.Add(Me.Label8)
        Me.General.Controls.Add(Me.cmb_motivo)
        Me.General.Controls.Add(Me.GroupBox2)
        Me.General.Controls.Add(Me.txtsubsidio)
        Me.General.Controls.Add(Me.Label7)
        Me.General.Controls.Add(Me.txtdescripcion)
        Me.General.Controls.Add(Me.Label6)
        Me.General.Controls.Add(Me.lblper_cod)
        Me.General.Controls.Add(Me.txtper_cod)
        Me.General.Controls.Add(Me.Label1)
        Me.General.Controls.Add(Me.GroupBox1)
        Me.General.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(715, 352)
        Me.General.TabIndex = 0
        Me.General.Text = "General"
        '
        'LblDias
        '
        Me.LblDias.AutoSize = True
        Me.LblDias.Location = New System.Drawing.Point(377, 84)
        Me.LblDias.Name = "LblDias"
        Me.LblDias.Size = New System.Drawing.Size(0, 13)
        Me.LblDias.TabIndex = 140
        '
        'Btn_Calculo
        '
        Me.Btn_Calculo.Location = New System.Drawing.Point(590, 19)
        Me.Btn_Calculo.Name = "Btn_Calculo"
        Me.Btn_Calculo.Size = New System.Drawing.Size(107, 32)
        Me.Btn_Calculo.TabIndex = 139
        Me.Btn_Calculo.Text = "CALCULO"
        Me.Btn_Calculo.UseVisualStyleBackColor = True
        '
        'txtndoc
        '
        Me.txtndoc.Location = New System.Drawing.Point(540, 153)
        Me.txtndoc.Name = "txtndoc"
        Me.txtndoc.ReadOnly = True
        Me.txtndoc.Size = New System.Drawing.Size(100, 21)
        Me.txtndoc.TabIndex = 138
        Me.txtndoc.Visible = False
        '
        'txtsdoc
        '
        Me.txtsdoc.Location = New System.Drawing.Point(472, 154)
        Me.txtsdoc.Name = "txtsdoc"
        Me.txtsdoc.ReadOnly = True
        Me.txtsdoc.Size = New System.Drawing.Size(62, 21)
        Me.txtsdoc.TabIndex = 137
        Me.txtsdoc.Visible = False
        '
        'cmb_motivo1
        '
        Me.cmb_motivo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_motivo1.FormattingEnabled = True
        Me.cmb_motivo1.Items.AddRange(New Object() {"DESCANSO MEDICO", "SUBSIDIO POR ACCIDENTE LABORAL", "SUBSIDIO POR ENFERMEDAD", "SUBSIDIO POR MATERNIDAD", "SUBSIDIO POR ACCIDENTE COMUN"})
        Me.cmb_motivo1.Location = New System.Drawing.Point(98, 300)
        Me.cmb_motivo1.Name = "cmb_motivo1"
        Me.cmb_motivo1.Size = New System.Drawing.Size(225, 21)
        Me.cmb_motivo1.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 305)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 134
        Me.Label9.Text = "Contingencia"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 133
        Me.Label8.Text = "Motivo"
        '
        'cmb_motivo
        '
        Me.cmb_motivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_motivo.FormattingEnabled = True
        Me.cmb_motivo.Items.AddRange(New Object() {"DESCANSO MEDICO", "SUBSIDIO"})
        Me.cmb_motivo.Location = New System.Drawing.Point(98, 261)
        Me.cmb_motivo.Name = "cmb_motivo"
        Me.cmb_motivo.Size = New System.Drawing.Size(155, 21)
        Me.cmb_motivo.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtminutos1)
        Me.GroupBox2.Controls.Add(Me.txtminutos)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 189)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(227, 61)
        Me.GroupBox2.TabIndex = 131
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Minutos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(123, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Costo emp"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Dscto"
        '
        'txtminutos1
        '
        Me.txtminutos1.Location = New System.Drawing.Point(112, 34)
        Me.txtminutos1.MaxLength = 10
        Me.txtminutos1.Name = "txtminutos1"
        Me.txtminutos1.Size = New System.Drawing.Size(77, 21)
        Me.txtminutos1.TabIndex = 8
        '
        'txtminutos
        '
        Me.txtminutos.Location = New System.Drawing.Point(11, 34)
        Me.txtminutos.MaxLength = 4
        Me.txtminutos.Name = "txtminutos"
        Me.txtminutos.Size = New System.Drawing.Size(77, 21)
        Me.txtminutos.TabIndex = 7
        '
        'txtsubsidio
        '
        Me.txtsubsidio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsubsidio.Location = New System.Drawing.Point(98, 153)
        Me.txtsubsidio.Name = "txtsubsidio"
        Me.txtsubsidio.Size = New System.Drawing.Size(155, 21)
        Me.txtsubsidio.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 129
        Me.Label7.Text = "Subsidio"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcion.Location = New System.Drawing.Point(98, 119)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(473, 21)
        Me.txtdescripcion.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 127
        Me.Label6.Text = "Descripción"
        '
        'lblper_cod
        '
        Me.lblper_cod.BackColor = System.Drawing.Color.Gainsboro
        Me.lblper_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblper_cod.Location = New System.Drawing.Point(189, 26)
        Me.lblper_cod.Name = "lblper_cod"
        Me.lblper_cod.Size = New System.Drawing.Size(382, 21)
        Me.lblper_cod.TabIndex = 126
        Me.lblper_cod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtper_cod
        '
        Me.txtper_cod.Location = New System.Drawing.Point(98, 26)
        Me.txtper_cod.MaxLength = 8
        Me.txtper_cod.Name = "txtper_cod"
        Me.txtper_cod.Size = New System.Drawing.Size(90, 21)
        Me.txtper_cod.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Personal"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpfec_fin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpfec_ini)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 45)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(175, 22)
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
        Me.dtpfec_fin.Location = New System.Drawing.Point(202, 17)
        Me.dtpfec_fin.Name = "dtpfec_fin"
        Me.dtpfec_fin.Size = New System.Drawing.Size(95, 21)
        Me.dtpfec_fin.TabIndex = 4
        Me.dtpfec_fin.Value = New Date(2019, 1, 9, 0, 0, 0, 0)
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
        Me.dtpfec_ini.TabIndex = 3
        Me.dtpfec_ini.Value = New Date(2019, 1, 9, 0, 0, 0, 0)
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbBorrar, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(740, 25)
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
        'DgvPagos
        '
        Me.DgvPagos.AllowUserToAddRows = False
        Me.DgvPagos.AllowUserToDeleteRows = False
        Me.DgvPagos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPagos.Location = New System.Drawing.Point(12, 410)
        Me.DgvPagos.Name = "DgvPagos"
        Me.DgvPagos.ReadOnly = True
        Me.DgvPagos.Size = New System.Drawing.Size(723, 275)
        Me.DgvPagos.TabIndex = 23
        '
        'FormELSUBSIDIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 690)
        Me.Controls.Add(Me.DgvPagos)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormELSUBSIDIOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subsidios del Personal"
        Me.TabControl1.ResumeLayout(False)
        Me.General.ResumeLayout(False)
        Me.General.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        CType(Me.DgvPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents General As TabPage
    Friend WithEvents cmb_motivo1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb_motivo As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtminutos1 As TextBox
    Friend WithEvents txtminutos As TextBox
    Friend WithEvents txtsubsidio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblper_cod As Label
    Friend WithEvents txtper_cod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpfec_fin As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpfec_ini As DateTimePicker
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents txtndoc As TextBox
    Friend WithEvents txtsdoc As TextBox
    Friend WithEvents tsbBorrar As ToolStripButton
    Friend WithEvents Btn_Calculo As Button
    Friend WithEvents DgvPagos As DataGridView
    Friend WithEvents LblDias As Label
End Class
