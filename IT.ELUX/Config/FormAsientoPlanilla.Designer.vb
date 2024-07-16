<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAsientoPlanilla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAsientoPlanilla))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttdoc = New System.Windows.Forms.TextBox()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.txtndoc = New System.Windows.Forms.TextBox()
        Me.npdtcmb = New System.Windows.Forms.NumericUpDown()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbplan = New System.Windows.Forms.RadioButton()
        Me.rdbcts = New System.Windows.Forms.RadioButton()
        Me.rdbgra = New System.Windows.Forms.RadioButton()
        Me.rdbvaca = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpfec_ini9 = New System.Windows.Forms.DateTimePicker()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.txtcontrato_prdo9 = New System.Windows.Forms.TextBox()
        CType(Me.npdtcmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsbForm.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Serie"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "T. Camb."
        '
        'txttdoc
        '
        Me.txttdoc.Location = New System.Drawing.Point(106, 35)
        Me.txttdoc.Name = "txttdoc"
        Me.txttdoc.Size = New System.Drawing.Size(61, 20)
        Me.txttdoc.TabIndex = 1
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño.Location = New System.Drawing.Point(106, 63)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(61, 21)
        Me.cmbaño.TabIndex = 2
        '
        'txtndoc
        '
        Me.txtndoc.Location = New System.Drawing.Point(106, 91)
        Me.txtndoc.Name = "txtndoc"
        Me.txtndoc.Size = New System.Drawing.Size(115, 20)
        Me.txtndoc.TabIndex = 3
        '
        'npdtcmb
        '
        Me.npdtcmb.DecimalPlaces = 3
        Me.npdtcmb.Location = New System.Drawing.Point(106, 178)
        Me.npdtcmb.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.npdtcmb.Name = "npdtcmb"
        Me.npdtcmb.Size = New System.Drawing.Size(115, 20)
        Me.npdtcmb.TabIndex = 5
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(328, 25)
        Me.tsbForm.TabIndex = 66
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Fecha"
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(106, 118)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(103, 20)
        Me.dtpfecha.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbvaca)
        Me.GroupBox1.Controls.Add(Me.rdbgra)
        Me.GroupBox1.Controls.Add(Me.rdbcts)
        Me.GroupBox1.Controls.Add(Me.rdbplan)
        Me.GroupBox1.Location = New System.Drawing.Point(227, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(82, 110)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        '
        'rdbplan
        '
        Me.rdbplan.AutoSize = True
        Me.rdbplan.Checked = True
        Me.rdbplan.Location = New System.Drawing.Point(6, 17)
        Me.rdbplan.Name = "rdbplan"
        Me.rdbplan.Size = New System.Drawing.Size(49, 17)
        Me.rdbplan.TabIndex = 0
        Me.rdbplan.TabStop = True
        Me.rdbplan.Text = "Plan."
        Me.rdbplan.UseVisualStyleBackColor = True
        '
        'rdbcts
        '
        Me.rdbcts.AutoSize = True
        Me.rdbcts.Location = New System.Drawing.Point(6, 36)
        Me.rdbcts.Name = "rdbcts"
        Me.rdbcts.Size = New System.Drawing.Size(49, 17)
        Me.rdbcts.TabIndex = 1
        Me.rdbcts.TabStop = True
        Me.rdbcts.Text = "CTS."
        Me.rdbcts.UseVisualStyleBackColor = True
        '
        'rdbgra
        '
        Me.rdbgra.AutoSize = True
        Me.rdbgra.Location = New System.Drawing.Point(6, 59)
        Me.rdbgra.Name = "rdbgra"
        Me.rdbgra.Size = New System.Drawing.Size(45, 17)
        Me.rdbgra.TabIndex = 2
        Me.rdbgra.TabStop = True
        Me.rdbgra.Text = "Gra."
        Me.rdbgra.UseVisualStyleBackColor = True
        '
        'rdbvaca
        '
        Me.rdbvaca.AutoSize = True
        Me.rdbvaca.Location = New System.Drawing.Point(6, 82)
        Me.rdbvaca.Name = "rdbvaca"
        Me.rdbvaca.Size = New System.Drawing.Size(53, 17)
        Me.rdbvaca.TabIndex = 3
        Me.rdbvaca.TabStop = True
        Me.rdbvaca.Text = "Vaca."
        Me.rdbvaca.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Periodo"
        '
        'dtpfec_ini9
        '
        Me.dtpfec_ini9.Checked = False
        Me.dtpfec_ini9.Enabled = False
        Me.dtpfec_ini9.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ini9.Location = New System.Drawing.Point(211, 148)
        Me.dtpfec_ini9.Name = "dtpfec_ini9"
        Me.dtpfec_ini9.ShowCheckBox = True
        Me.dtpfec_ini9.Size = New System.Drawing.Size(98, 20)
        Me.dtpfec_ini9.TabIndex = 187
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(172, 146)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(32, 23)
        Me.Button19.TabIndex = 186
        Me.Button19.Text = "..."
        Me.Button19.UseVisualStyleBackColor = True
        '
        'txtcontrato_prdo9
        '
        Me.txtcontrato_prdo9.Location = New System.Drawing.Point(106, 148)
        Me.txtcontrato_prdo9.Name = "txtcontrato_prdo9"
        Me.txtcontrato_prdo9.Size = New System.Drawing.Size(61, 20)
        Me.txtcontrato_prdo9.TabIndex = 185
        '
        'FormAsientoPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 210)
        Me.Controls.Add(Me.dtpfec_ini9)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.txtcontrato_prdo9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.npdtcmb)
        Me.Controls.Add(Me.txtndoc)
        Me.Controls.Add(Me.cmbaño)
        Me.Controls.Add(Me.txttdoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormAsientoPlanilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAsientoPlanilla"
        CType(Me.npdtcmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txttdoc As TextBox
    Friend WithEvents cmbaño As ComboBox
    Friend WithEvents txtndoc As TextBox
    Friend WithEvents npdtcmb As NumericUpDown
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbvaca As RadioButton
    Friend WithEvents rdbgra As RadioButton
    Friend WithEvents rdbcts As RadioButton
    Friend WithEvents rdbplan As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpfec_ini9 As DateTimePicker
    Friend WithEvents Button19 As Button
    Friend WithEvents txtcontrato_prdo9 As TextBox
End Class
