<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCargarDias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCargarDias))
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.npdtot_dias = New System.Windows.Forms.NumericUpDown()
        Me.npdhoras = New System.Windows.Forms.NumericUpDown()
        Me.npdminutos = New System.Windows.Forms.NumericUpDown()
        Me.dgvt_doc = New System.Windows.Forms.DataGridView()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbemp = New System.Windows.Forms.ComboBox()
        Me.btncargar = New System.Windows.Forms.Button()
        CType(Me.npdtot_dias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdhoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdminutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsbForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(332, 41)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(51, 23)
        Me.btnbuscar.TabIndex = 0
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'npdtot_dias
        '
        Me.npdtot_dias.Location = New System.Drawing.Point(12, 41)
        Me.npdtot_dias.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npdtot_dias.Name = "npdtot_dias"
        Me.npdtot_dias.Size = New System.Drawing.Size(120, 20)
        Me.npdtot_dias.TabIndex = 1
        '
        'npdhoras
        '
        Me.npdhoras.Location = New System.Drawing.Point(138, 41)
        Me.npdhoras.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npdhoras.Name = "npdhoras"
        Me.npdhoras.Size = New System.Drawing.Size(94, 20)
        Me.npdhoras.TabIndex = 2
        '
        'npdminutos
        '
        Me.npdminutos.Location = New System.Drawing.Point(238, 41)
        Me.npdminutos.Name = "npdminutos"
        Me.npdminutos.Size = New System.Drawing.Size(88, 20)
        Me.npdminutos.TabIndex = 3
        '
        'dgvt_doc
        '
        Me.dgvt_doc.AllowUserToAddRows = False
        Me.dgvt_doc.AllowUserToDeleteRows = False
        Me.dgvt_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc.Location = New System.Drawing.Point(12, 83)
        Me.dgvt_doc.Name = "dgvt_doc"
        Me.dgvt_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc.Size = New System.Drawing.Size(581, 243)
        Me.dgvt_doc.TabIndex = 32
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(605, 25)
        Me.tsbForm.TabIndex = 33
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(384, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Borrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Dias"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Horas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(254, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Minutos"
        '
        'cmbemp
        '
        Me.cmbemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbemp.FormattingEnabled = True
        Me.cmbemp.Items.AddRange(New Object() {"", "EMPLEADO", "OBREROS"})
        Me.cmbemp.Location = New System.Drawing.Point(441, 43)
        Me.cmbemp.Name = "cmbemp"
        Me.cmbemp.Size = New System.Drawing.Size(87, 21)
        Me.cmbemp.TabIndex = 38
        '
        'btncargar
        '
        Me.btncargar.Enabled = False
        Me.btncargar.Location = New System.Drawing.Point(530, 43)
        Me.btncargar.Name = "btncargar"
        Me.btncargar.Size = New System.Drawing.Size(63, 23)
        Me.btncargar.TabIndex = 39
        Me.btncargar.Text = "Cargar"
        Me.btncargar.UseVisualStyleBackColor = True
        '
        'FormCargarDias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 341)
        Me.Controls.Add(Me.btncargar)
        Me.Controls.Add(Me.cmbemp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.dgvt_doc)
        Me.Controls.Add(Me.npdminutos)
        Me.Controls.Add(Me.npdhoras)
        Me.Controls.Add(Me.npdtot_dias)
        Me.Controls.Add(Me.btnbuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormCargarDias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCargarDias"
        CType(Me.npdtot_dias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdhoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdminutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnbuscar As Button
    Friend WithEvents npdtot_dias As NumericUpDown
    Friend WithEvents npdhoras As NumericUpDown
    Friend WithEvents npdminutos As NumericUpDown
    Friend WithEvents dgvt_doc As DataGridView
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbemp As ComboBox
    Friend WithEvents btncargar As Button
End Class
