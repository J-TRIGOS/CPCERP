<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLetrasBanco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLetrasBanco))
        Me.cmbest1 = New System.Windows.Forms.ComboBox()
        Me.chkbinteres = New System.Windows.Forms.CheckBox()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgvt_doc = New System.Windows.Forms.DataGridView()
        Me.chkrecogido = New System.Windows.Forms.CheckBox()
        Me.tsbForm.SuspendLayout()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbest1
        '
        Me.cmbest1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbest1.FormattingEnabled = True
        Me.cmbest1.Items.AddRange(New Object() {"", "Tramitado", "No Tramitado"})
        Me.cmbest1.Location = New System.Drawing.Point(134, 38)
        Me.cmbest1.Name = "cmbest1"
        Me.cmbest1.Size = New System.Drawing.Size(114, 21)
        Me.cmbest1.TabIndex = 59
        '
        'chkbinteres
        '
        Me.chkbinteres.AutoSize = True
        Me.chkbinteres.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkbinteres.Location = New System.Drawing.Point(24, 40)
        Me.chkbinteres.Name = "chkbinteres"
        Me.chkbinteres.Size = New System.Drawing.Size(95, 17)
        Me.chkbinteres.TabIndex = 58
        Me.chkbinteres.Text = "Letra al Banco"
        Me.chkbinteres.UseVisualStyleBackColor = True
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(723, 25)
        Me.tsbForm.TabIndex = 60
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
        Me.Button1.Location = New System.Drawing.Point(636, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Docum."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(636, 94)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "Borrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dgvt_doc
        '
        Me.dgvt_doc.AllowUserToAddRows = False
        Me.dgvt_doc.AllowUserToDeleteRows = False
        Me.dgvt_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc.Location = New System.Drawing.Point(12, 65)
        Me.dgvt_doc.Name = "dgvt_doc"
        Me.dgvt_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc.Size = New System.Drawing.Size(618, 184)
        Me.dgvt_doc.TabIndex = 64
        '
        'chkrecogido
        '
        Me.chkrecogido.AutoSize = True
        Me.chkrecogido.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkrecogido.Location = New System.Drawing.Point(268, 40)
        Me.chkrecogido.Name = "chkrecogido"
        Me.chkrecogido.Size = New System.Drawing.Size(72, 17)
        Me.chkrecogido.TabIndex = 65
        Me.chkrecogido.Text = "Recogido"
        Me.chkrecogido.UseVisualStyleBackColor = True
        '
        'FormLetrasBanco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 261)
        Me.Controls.Add(Me.chkrecogido)
        Me.Controls.Add(Me.dgvt_doc)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.cmbest1)
        Me.Controls.Add(Me.chkbinteres)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormLetrasBanco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLetrasBanco"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbest1 As ComboBox
    Friend WithEvents chkbinteres As CheckBox
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents dgvt_doc As DataGridView
    Friend WithEvents chkrecogido As CheckBox
End Class
