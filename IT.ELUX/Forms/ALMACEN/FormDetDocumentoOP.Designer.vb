<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDetDocumentoOP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDetDocumentoOP))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnroop = New System.Windows.Forms.TextBox()
        Me.cmb_serop = New System.Windows.Forms.ComboBox()
        Me.dgvt_doc = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbltdoc = New System.Windows.Forms.Label()
        Me.lblsdoc = New System.Windows.Forms.Label()
        Me.lblndoc = New System.Windows.Forms.Label()
        Me.lblart = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.npdcantidad = New System.Windows.Forms.NumericUpDown()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.cmbarticulo = New System.Windows.Forms.ComboBox()
        Me.lblnom = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsbForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Serie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero"
        '
        'txtnroop
        '
        Me.txtnroop.Location = New System.Drawing.Point(216, 67)
        Me.txtnroop.MaxLength = 9
        Me.txtnroop.Name = "txtnroop"
        Me.txtnroop.ReadOnly = True
        Me.txtnroop.Size = New System.Drawing.Size(109, 20)
        Me.txtnroop.TabIndex = 2
        '
        'cmb_serop
        '
        Me.cmb_serop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_serop.FormattingEnabled = True
        Me.cmb_serop.Items.AddRange(New Object() {"2021", "2022", "2023", "2024", "2025", "2026"})
        Me.cmb_serop.Location = New System.Drawing.Point(59, 64)
        Me.cmb_serop.Name = "cmb_serop"
        Me.cmb_serop.Size = New System.Drawing.Size(78, 21)
        Me.cmb_serop.TabIndex = 3
        '
        'dgvt_doc
        '
        Me.dgvt_doc.AllowUserToAddRows = False
        Me.dgvt_doc.AllowUserToDeleteRows = False
        Me.dgvt_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc.Location = New System.Drawing.Point(23, 107)
        Me.dgvt_doc.Name = "dgvt_doc"
        Me.dgvt_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc.Size = New System.Drawing.Size(440, 185)
        Me.dgvt_doc.TabIndex = 32
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(469, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbltdoc
        '
        Me.lbltdoc.AutoSize = True
        Me.lbltdoc.Location = New System.Drawing.Point(486, 220)
        Me.lbltdoc.Name = "lbltdoc"
        Me.lbltdoc.Size = New System.Drawing.Size(39, 13)
        Me.lbltdoc.TabIndex = 36
        Me.lbltdoc.Text = "Label3"
        Me.lbltdoc.Visible = False
        '
        'lblsdoc
        '
        Me.lblsdoc.AutoSize = True
        Me.lblsdoc.Location = New System.Drawing.Point(486, 233)
        Me.lblsdoc.Name = "lblsdoc"
        Me.lblsdoc.Size = New System.Drawing.Size(39, 13)
        Me.lblsdoc.TabIndex = 37
        Me.lblsdoc.Text = "Label4"
        Me.lblsdoc.Visible = False
        '
        'lblndoc
        '
        Me.lblndoc.AutoSize = True
        Me.lblndoc.Location = New System.Drawing.Point(486, 246)
        Me.lblndoc.Name = "lblndoc"
        Me.lblndoc.Size = New System.Drawing.Size(39, 13)
        Me.lblndoc.TabIndex = 38
        Me.lblndoc.Text = "Label5"
        Me.lblndoc.Visible = False
        '
        'lblart
        '
        Me.lblart.AutoSize = True
        Me.lblart.Location = New System.Drawing.Point(486, 259)
        Me.lblart.Name = "lblart"
        Me.lblart.Size = New System.Drawing.Size(39, 13)
        Me.lblart.TabIndex = 39
        Me.lblart.Text = "Label6"
        Me.lblart.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(469, 136)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 40
        Me.Button4.Text = "Borrar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(384, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Cant."
        '
        'npdcantidad
        '
        Me.npdcantidad.DecimalPlaces = 3
        Me.npdcantidad.Location = New System.Drawing.Point(425, 67)
        Me.npdcantidad.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.npdcantidad.Name = "npdcantidad"
        Me.npdcantidad.Size = New System.Drawing.Size(120, 20)
        Me.npdcantidad.TabIndex = 42
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(575, 25)
        Me.tsbForm.TabIndex = 43
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
        'cmbarticulo
        '
        Me.cmbarticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbarticulo.FormattingEnabled = True
        Me.cmbarticulo.Location = New System.Drawing.Point(60, 34)
        Me.cmbarticulo.Name = "cmbarticulo"
        Me.cmbarticulo.Size = New System.Drawing.Size(90, 21)
        Me.cmbarticulo.TabIndex = 130
        '
        'lblnom
        '
        Me.lblnom.BackColor = System.Drawing.Color.Gainsboro
        Me.lblnom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnom.Location = New System.Drawing.Point(156, 34)
        Me.lblnom.Name = "lblnom"
        Me.lblnom.Size = New System.Drawing.Size(390, 21)
        Me.lblnom.TabIndex = 129
        Me.lblnom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Articulo"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(325, 65)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 23)
        Me.Button2.TabIndex = 131
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormDetDocumentoOP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 312)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmbarticulo)
        Me.Controls.Add(Me.lblnom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.npdcantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.lblart)
        Me.Controls.Add(Me.lblndoc)
        Me.Controls.Add(Me.lblsdoc)
        Me.Controls.Add(Me.lbltdoc)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvt_doc)
        Me.Controls.Add(Me.cmb_serop)
        Me.Controls.Add(Me.txtnroop)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormDetDocumentoOP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDetDocumentoOP"
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnroop As TextBox
    Friend WithEvents cmb_serop As ComboBox
    Friend WithEvents dgvt_doc As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents lbltdoc As Label
    Friend WithEvents lblsdoc As Label
    Friend WithEvents lblndoc As Label
    Friend WithEvents lblart As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents npdcantidad As NumericUpDown
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents cmbarticulo As ComboBox
    Friend WithEvents lblnom As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
End Class
