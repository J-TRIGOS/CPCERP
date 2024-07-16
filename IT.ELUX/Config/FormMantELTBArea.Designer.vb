<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMantELTBArea
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantELTBArea))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.cmbccosto = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.dgvCaracteristica = New System.Windows.Forms.DataGridView()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcco_cod = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.dgvarea = New System.Windows.Forms.DataGridView()
        Me.btnborrar1 = New System.Windows.Forms.Button()
        Me.btnagregar1 = New System.Windows.Forms.Button()
        Me.tsbForm.SuspendLayout()
        CType(Me.dgvCaracteristica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvarea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Centro de Costo"
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(559, 25)
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
        'cmbccosto
        '
        Me.cmbccosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbccosto.FormattingEnabled = True
        Me.cmbccosto.Location = New System.Drawing.Point(166, 33)
        Me.cmbccosto.Name = "cmbccosto"
        Me.cmbccosto.Size = New System.Drawing.Size(224, 21)
        Me.cmbccosto.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Codigo Area"
        Me.Label2.Visible = False
        '
        'txtcod
        '
        Me.txtcod.Enabled = False
        Me.txtcod.Location = New System.Drawing.Point(108, 60)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(52, 20)
        Me.txtcod.TabIndex = 3
        Me.txtcod.Visible = False
        '
        'dgvCaracteristica
        '
        Me.dgvCaracteristica.AllowUserToAddRows = False
        Me.dgvCaracteristica.AllowUserToDeleteRows = False
        Me.dgvCaracteristica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCaracteristica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCaracteristica.Location = New System.Drawing.Point(583, 12)
        Me.dgvCaracteristica.Name = "dgvCaracteristica"
        Me.dgvCaracteristica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCaracteristica.Size = New System.Drawing.Size(509, 221)
        Me.dgvCaracteristica.TabIndex = 16
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(1098, 56)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(75, 23)
        Me.btnborrar.TabIndex = 18
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(1098, 27)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 17
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'txtdescripcion
        '
        Me.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcion.Location = New System.Drawing.Point(166, 60)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(341, 20)
        Me.txtdescripcion.TabIndex = 4
        Me.txtdescripcion.Visible = False
        '
        'cmbestado
        '
        Me.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.cmbestado.Location = New System.Drawing.Point(108, 86)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(224, 21)
        Me.cmbestado.TabIndex = 5
        Me.cmbestado.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Estado"
        Me.Label4.Visible = False
        '
        'txtcco_cod
        '
        Me.txtcco_cod.Location = New System.Drawing.Point(108, 33)
        Me.txtcco_cod.Name = "txtcco_cod"
        Me.txtcco_cod.Size = New System.Drawing.Size(52, 20)
        Me.txtcco_cod.TabIndex = 1
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(396, 31)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(32, 23)
        Me.btnbuscar.TabIndex = 29
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'dgvarea
        '
        Me.dgvarea.AllowUserToAddRows = False
        Me.dgvarea.AllowUserToDeleteRows = False
        Me.dgvarea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvarea.Location = New System.Drawing.Point(12, 120)
        Me.dgvarea.Name = "dgvarea"
        Me.dgvarea.ReadOnly = True
        Me.dgvarea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvarea.Size = New System.Drawing.Size(531, 221)
        Me.dgvarea.TabIndex = 30
        '
        'btnborrar1
        '
        Me.btnborrar1.Location = New System.Drawing.Point(484, 86)
        Me.btnborrar1.Name = "btnborrar1"
        Me.btnborrar1.Size = New System.Drawing.Size(59, 23)
        Me.btnborrar1.TabIndex = 32
        Me.btnborrar1.Text = "Borrar"
        Me.btnborrar1.UseVisualStyleBackColor = True
        '
        'btnagregar1
        '
        Me.btnagregar1.Location = New System.Drawing.Point(419, 86)
        Me.btnagregar1.Name = "btnagregar1"
        Me.btnagregar1.Size = New System.Drawing.Size(59, 23)
        Me.btnagregar1.TabIndex = 33
        Me.btnagregar1.Text = "Agregar"
        Me.btnagregar1.UseVisualStyleBackColor = True
        '
        'FormMantELTBArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 353)
        Me.Controls.Add(Me.btnagregar1)
        Me.Controls.Add(Me.btnborrar1)
        Me.Controls.Add(Me.dgvarea)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.txtcco_cod)
        Me.Controls.Add(Me.cmbestado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.dgvCaracteristica)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbccosto)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormMantELTBArea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMantArea"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        CType(Me.dgvCaracteristica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvarea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents cmbccosto As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcod As TextBox
    Friend WithEvents dgvCaracteristica As DataGridView
    Friend WithEvents btnborrar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents cmbestado As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcco_cod As TextBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents dgvarea As DataGridView
    Friend WithEvents btnborrar1 As Button
    Friend WithEvents btnagregar1 As Button
End Class
