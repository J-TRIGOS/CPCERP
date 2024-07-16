<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPerHoraOM
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvbusqueda = New System.Windows.Forms.DataGridView()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.tsbMant = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbccosto = New System.Windows.Forms.ToolStripComboBox()
        Me.tsbCamposSeek = New System.Windows.Forms.ToolStripComboBox()
        Me.tsTextSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tstLblInfo = New System.Windows.Forms.ToolStripLabel()
        Me.cmbcosto = New System.Windows.Forms.ComboBox()
        Me.chkcerrado = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Intervencion = New System.Windows.Forms.Label()
        Me.cmbIntervencion = New System.Windows.Forms.ComboBox()
        Me.txtobs = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtdifhora = New System.Windows.Forms.TextBox()
        Me.dtphoratermino = New System.Windows.Forms.DateTimePicker()
        Me.dtphoragene = New System.Windows.Forms.DateTimePicker()
        Me.dtpfec_termino = New System.Windows.Forms.DateTimePicker()
        Me.dtpfec_inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.dgvbusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsbMant.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(472, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Pasar Todos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvbusqueda
        '
        Me.dgvbusqueda.AllowUserToAddRows = False
        Me.dgvbusqueda.AllowUserToDeleteRows = False
        Me.dgvbusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvbusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbusqueda.Location = New System.Drawing.Point(6, 40)
        Me.dgvbusqueda.Name = "dgvbusqueda"
        Me.dgvbusqueda.ReadOnly = True
        Me.dgvbusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvbusqueda.Size = New System.Drawing.Size(712, 224)
        Me.dgvbusqueda.TabIndex = 22
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(609, 11)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 21
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'tsbMant
        '
        Me.tsbMant.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.ToolStripLabel1, Me.cmbccosto, Me.tsbCamposSeek, Me.tsTextSearch, Me.ToolStripSeparator4, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.tstLblInfo})
        Me.tsbMant.Location = New System.Drawing.Point(0, 0)
        Me.tsbMant.Name = "tsbMant"
        Me.tsbMant.Size = New System.Drawing.Size(733, 25)
        Me.tsbMant.TabIndex = 20
        Me.tsbMant.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(130, 22)
        Me.ToolStripLabel1.Text = "Busqueda por campo :"
        '
        'cmbccosto
        '
        Me.cmbccosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbccosto.DropDownWidth = 150
        Me.cmbccosto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbccosto.Name = "cmbccosto"
        Me.cmbccosto.Size = New System.Drawing.Size(200, 25)
        '
        'tsbCamposSeek
        '
        Me.tsbCamposSeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tsbCamposSeek.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbCamposSeek.Name = "tsbCamposSeek"
        Me.tsbCamposSeek.Size = New System.Drawing.Size(121, 25)
        '
        'tsTextSearch
        '
        Me.tsTextSearch.BackColor = System.Drawing.SystemColors.Info
        Me.tsTextSearch.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsTextSearch.Name = "tsTextSearch"
        Me.tsTextSearch.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(139, 22)
        Me.ToolStripLabel2.Text = "                                            "
        '
        'tstLblInfo
        '
        Me.tstLblInfo.AutoSize = False
        Me.tstLblInfo.BackColor = System.Drawing.Color.Silver
        Me.tstLblInfo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tstLblInfo.Name = "tstLblInfo"
        Me.tstLblInfo.Size = New System.Drawing.Size(90, 22)
        '
        'cmbcosto
        '
        Me.cmbcosto.FormattingEnabled = True
        Me.cmbcosto.Location = New System.Drawing.Point(563, 82)
        Me.cmbcosto.Name = "cmbcosto"
        Me.cmbcosto.Size = New System.Drawing.Size(121, 21)
        Me.cmbcosto.TabIndex = 24
        '
        'chkcerrado
        '
        Me.chkcerrado.AutoSize = True
        Me.chkcerrado.Location = New System.Drawing.Point(364, 13)
        Me.chkcerrado.Name = "chkcerrado"
        Me.chkcerrado.Size = New System.Drawing.Size(100, 17)
        Me.chkcerrado.TabIndex = 25
        Me.chkcerrado.Text = "Ver Terminados"
        Me.chkcerrado.UseVisualStyleBackColor = True
        Me.chkcerrado.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvbusqueda)
        Me.GroupBox1.Controls.Add(Me.chkcerrado)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmbcosto)
        Me.GroupBox1.Controls.Add(Me.btnsalir)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(724, 271)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Intervencion)
        Me.GroupBox2.Controls.Add(Me.cmbIntervencion)
        Me.GroupBox2.Controls.Add(Me.txtobs)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.txtdifhora)
        Me.GroupBox2.Controls.Add(Me.dtphoratermino)
        Me.GroupBox2.Controls.Add(Me.dtphoragene)
        Me.GroupBox2.Controls.Add(Me.dtpfec_termino)
        Me.GroupBox2.Controls.Add(Me.dtpfec_inicio)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 300)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(724, 150)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingresar a OM"
        Me.GroupBox2.Visible = False
        '
        'Intervencion
        '
        Me.Intervencion.AutoSize = True
        Me.Intervencion.Location = New System.Drawing.Point(480, 44)
        Me.Intervencion.Name = "Intervencion"
        Me.Intervencion.Size = New System.Drawing.Size(69, 13)
        Me.Intervencion.TabIndex = 273
        Me.Intervencion.Text = "Intervencion:"
        Me.Intervencion.Visible = False
        '
        'cmbIntervencion
        '
        Me.cmbIntervencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIntervencion.FormattingEnabled = True
        Me.cmbIntervencion.Items.AddRange(New Object() {"CORRECTIVO", "PREVENTIVO", "REGULACION"})
        Me.cmbIntervencion.Location = New System.Drawing.Point(555, 38)
        Me.cmbIntervencion.Name = "cmbIntervencion"
        Me.cmbIntervencion.Size = New System.Drawing.Size(127, 21)
        Me.cmbIntervencion.TabIndex = 272
        Me.cmbIntervencion.Visible = False
        '
        'txtobs
        '
        Me.txtobs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobs.Location = New System.Drawing.Point(111, 66)
        Me.txtobs.Multiline = True
        Me.txtobs.Name = "txtobs"
        Me.txtobs.Size = New System.Drawing.Size(573, 24)
        Me.txtobs.TabIndex = 270
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 26)
        Me.Label10.TabIndex = 271
        Me.Label10.Text = "Descripcion " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Trabajo:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 266
        Me.Label11.Text = "Fecha Termino:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(331, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(81, 13)
        Me.Label25.TabIndex = 268
        Me.Label25.Text = "Diferencia Hora"
        Me.Label25.Visible = False
        '
        'txtdifhora
        '
        Me.txtdifhora.Enabled = False
        Me.txtdifhora.Location = New System.Drawing.Point(324, 39)
        Me.txtdifhora.Name = "txtdifhora"
        Me.txtdifhora.ReadOnly = True
        Me.txtdifhora.Size = New System.Drawing.Size(100, 20)
        Me.txtdifhora.TabIndex = 267
        Me.txtdifhora.Visible = False
        '
        'dtphoratermino
        '
        Me.dtphoratermino.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtphoratermino.Location = New System.Drawing.Point(216, 40)
        Me.dtphoratermino.Name = "dtphoratermino"
        Me.dtphoratermino.ShowUpDown = True
        Me.dtphoratermino.Size = New System.Drawing.Size(96, 20)
        Me.dtphoratermino.TabIndex = 264
        '
        'dtphoragene
        '
        Me.dtphoragene.CustomFormat = ""
        Me.dtphoragene.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtphoragene.Location = New System.Drawing.Point(216, 16)
        Me.dtphoragene.Name = "dtphoragene"
        Me.dtphoragene.ShowUpDown = True
        Me.dtphoragene.Size = New System.Drawing.Size(96, 20)
        Me.dtphoragene.TabIndex = 263
        '
        'dtpfec_termino
        '
        Me.dtpfec_termino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_termino.Location = New System.Drawing.Point(111, 40)
        Me.dtpfec_termino.Name = "dtpfec_termino"
        Me.dtpfec_termino.Size = New System.Drawing.Size(100, 20)
        Me.dtpfec_termino.TabIndex = 262
        '
        'dtpfec_inicio
        '
        Me.dtpfec_inicio.Enabled = False
        Me.dtpfec_inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_inicio.Location = New System.Drawing.Point(111, 16)
        Me.dtpfec_inicio.Name = "dtpfec_inicio"
        Me.dtpfec_inicio.Size = New System.Drawing.Size(100, 20)
        Me.dtpfec_inicio.TabIndex = 261
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 265
        Me.Label12.Text = "Fecha Inicio:"
        '
        'FormPerHoraOM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 300)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tsbMant)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormPerHoraOM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormPerHoraOM"
        CType(Me.dgvbusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsbMant.ResumeLayout(False)
        Me.tsbMant.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents dgvbusqueda As DataGridView
    Friend WithEvents btnsalir As Button
    Friend WithEvents tsbMant As ToolStrip
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cmbccosto As ToolStripComboBox
    Friend WithEvents tsbCamposSeek As ToolStripComboBox
    Friend WithEvents tsTextSearch As ToolStripTextBox
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents tstLblInfo As ToolStripLabel
    Friend WithEvents cmbcosto As ComboBox
    Friend WithEvents chkcerrado As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtdifhora As TextBox
    Friend WithEvents dtphoratermino As DateTimePicker
    Friend WithEvents dtphoragene As DateTimePicker
    Friend WithEvents dtpfec_termino As DateTimePicker
    Friend WithEvents dtpfec_inicio As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents txtobs As TextBox
    Public WithEvents Label10 As Label
    Friend WithEvents Intervencion As Label
    Friend WithEvents cmbIntervencion As ComboBox
End Class
