<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMantELTBPROC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantELTBPROC))
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.npdtpases = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.npdunihora = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.dgvCaracteristica = New System.Windows.Forms.DataGridView()
        Me.cmbcodest = New System.Windows.Forms.ComboBox()
        Me.txtdescri = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbsec = New System.Windows.Forms.RadioButton()
        Me.rdbfrac = New System.Windows.Forms.RadioButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbForm.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.General.SuspendLayout()
        CType(Me.npdtpases, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdunihora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCaracteristica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(626, 25)
        Me.tsbForm.TabIndex = 10
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(10, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(604, 477)
        Me.TabControl1.TabIndex = 11
        '
        'General
        '
        Me.General.Controls.Add(Me.npdtpases)
        Me.General.Controls.Add(Me.Label6)
        Me.General.Controls.Add(Me.npdunihora)
        Me.General.Controls.Add(Me.Label5)
        Me.General.Controls.Add(Me.Label4)
        Me.General.Controls.Add(Me.btnborrar)
        Me.General.Controls.Add(Me.btnagregar)
        Me.General.Controls.Add(Me.dgvCaracteristica)
        Me.General.Controls.Add(Me.cmbcodest)
        Me.General.Controls.Add(Me.txtdescri)
        Me.General.Controls.Add(Me.txtcodigo)
        Me.General.Controls.Add(Me.Label3)
        Me.General.Controls.Add(Me.Label2)
        Me.General.Controls.Add(Me.Label1)
        Me.General.Controls.Add(Me.GroupBox1)
        Me.General.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(596, 451)
        Me.General.TabIndex = 0
        Me.General.Text = "General"
        Me.General.UseVisualStyleBackColor = True
        '
        'npdtpases
        '
        Me.npdtpases.Location = New System.Drawing.Point(441, 86)
        Me.npdtpases.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.npdtpases.Name = "npdtpases"
        Me.npdtpases.Size = New System.Drawing.Size(49, 21)
        Me.npdtpases.TabIndex = 21
        Me.npdtpases.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(369, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Total Pases:"
        '
        'npdunihora
        '
        Me.npdunihora.DecimalPlaces = 3
        Me.npdunihora.Location = New System.Drawing.Point(108, 115)
        Me.npdunihora.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.npdunihora.Name = "npdunihora"
        Me.npdunihora.Size = New System.Drawing.Size(120, 21)
        Me.npdunihora.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Unidades/H:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Caracterisitcas"
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(516, 196)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(75, 23)
        Me.btnborrar.TabIndex = 14
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(516, 167)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 12
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'dgvCaracteristica
        '
        Me.dgvCaracteristica.AllowDrop = True
        Me.dgvCaracteristica.AllowUserToAddRows = False
        Me.dgvCaracteristica.AllowUserToDeleteRows = False
        Me.dgvCaracteristica.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvCaracteristica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCaracteristica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCaracteristica.Location = New System.Drawing.Point(6, 172)
        Me.dgvCaracteristica.Name = "dgvCaracteristica"
        Me.dgvCaracteristica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCaracteristica.Size = New System.Drawing.Size(504, 273)
        Me.dgvCaracteristica.TabIndex = 11
        '
        'cmbcodest
        '
        Me.cmbcodest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcodest.FormattingEnabled = True
        Me.cmbcodest.Items.AddRange(New Object() {"0 Inactivo", "1 Activo"})
        Me.cmbcodest.Location = New System.Drawing.Point(107, 86)
        Me.cmbcodest.Name = "cmbcodest"
        Me.cmbcodest.Size = New System.Drawing.Size(121, 21)
        Me.cmbcodest.TabIndex = 8
        '
        'txtdescri
        '
        Me.txtdescri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescri.Location = New System.Drawing.Point(107, 59)
        Me.txtdescri.Name = "txtdescri"
        Me.txtdescri.Size = New System.Drawing.Size(383, 21)
        Me.txtdescri.TabIndex = 7
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(107, 30)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(35, 21)
        Me.txtcodigo.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Estado :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descripcion :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbsec)
        Me.GroupBox1.Controls.Add(Me.rdbfrac)
        Me.GroupBox1.Location = New System.Drawing.Point(234, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(122, 57)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'rdbsec
        '
        Me.rdbsec.AutoSize = True
        Me.rdbsec.Location = New System.Drawing.Point(20, 37)
        Me.rdbsec.Name = "rdbsec"
        Me.rdbsec.Size = New System.Drawing.Size(75, 17)
        Me.rdbsec.TabIndex = 1
        Me.rdbsec.TabStop = True
        Me.rdbsec.Text = "Secuencial"
        Me.rdbsec.UseVisualStyleBackColor = True
        '
        'rdbfrac
        '
        Me.rdbfrac.AutoSize = True
        Me.rdbfrac.Location = New System.Drawing.Point(20, 16)
        Me.rdbfrac.Name = "rdbfrac"
        Me.rdbfrac.Size = New System.Drawing.Size(83, 17)
        Me.rdbfrac.TabIndex = 0
        Me.rdbfrac.TabStop = True
        Me.rdbfrac.Text = "Fraccionado"
        Me.rdbfrac.UseVisualStyleBackColor = True
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
        'FormMantELTBPROC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 528)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.tsbForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormMantELTBPROC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormELTBProcesos"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.General.ResumeLayout(False)
        Me.General.PerformLayout()
        CType(Me.npdtpases, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdunihora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCaracteristica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents General As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents btnborrar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents dgvCaracteristica As DataGridView
    Friend WithEvents cmbcodest As ComboBox
    Friend WithEvents txtdescri As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents npdunihora As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbsec As RadioButton
    Friend WithEvents rdbfrac As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents npdtpases As NumericUpDown
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
