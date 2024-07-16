<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDocuRefTurn
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
        Me.dgvbusqueda = New System.Windows.Forms.DataGridView()
        Me.tsbMant = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbccosto = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmbcosto = New System.Windows.Forms.ComboBox()
        Me.lvbusqueda1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader29 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader30 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader31 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader32 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Turno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader34 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader35 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnpasar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.txt_num = New System.Windows.Forms.TextBox()
        Me.txtser_doc = New System.Windows.Forms.TextBox()
        Me.txtt_doc = New System.Windows.Forms.TextBox()
        Me.chknum = New System.Windows.Forms.CheckBox()
        Me.chkser = New System.Windows.Forms.CheckBox()
        Me.chktipo = New System.Windows.Forms.CheckBox()
        Me.lvbusqueda = New System.Windows.Forms.ListView()
        Me.codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chkmarcar = New System.Windows.Forms.CheckBox()
        CType(Me.dgvbusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsbMant.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvbusqueda
        '
        Me.dgvbusqueda.AllowUserToAddRows = False
        Me.dgvbusqueda.AllowUserToDeleteRows = False
        Me.dgvbusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvbusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbusqueda.Location = New System.Drawing.Point(31, 349)
        Me.dgvbusqueda.Name = "dgvbusqueda"
        Me.dgvbusqueda.ReadOnly = True
        Me.dgvbusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvbusqueda.Size = New System.Drawing.Size(381, 190)
        Me.dgvbusqueda.TabIndex = 19
        '
        'tsbMant
        '
        Me.tsbMant.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.ToolStripLabel1, Me.cmbccosto, Me.ToolStripSeparator4, Me.ToolStripSeparator1})
        Me.tsbMant.Location = New System.Drawing.Point(0, 0)
        Me.tsbMant.Name = "tsbMant"
        Me.tsbMant.Size = New System.Drawing.Size(723, 25)
        Me.tsbMant.TabIndex = 18
        Me.tsbMant.Text = "ToolStrip1"
        Me.tsbMant.Visible = False
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
        'cmbcosto
        '
        Me.cmbcosto.FormattingEnabled = True
        Me.cmbcosto.Location = New System.Drawing.Point(281, 389)
        Me.cmbcosto.Name = "cmbcosto"
        Me.cmbcosto.Size = New System.Drawing.Size(10, 21)
        Me.cmbcosto.TabIndex = 20
        '
        'lvbusqueda1
        '
        Me.lvbusqueda1.CheckBoxes = True
        Me.lvbusqueda1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader28, Me.ColumnHeader29, Me.ColumnHeader30, Me.ColumnHeader31, Me.ColumnHeader32, Me.Turno, Me.ColumnHeader34, Me.ColumnHeader35})
        Me.lvbusqueda1.FullRowSelect = True
        Me.lvbusqueda1.Location = New System.Drawing.Point(7, 136)
        Me.lvbusqueda1.MultiSelect = False
        Me.lvbusqueda1.Name = "lvbusqueda1"
        Me.lvbusqueda1.Size = New System.Drawing.Size(708, 176)
        Me.lvbusqueda1.TabIndex = 27
        Me.lvbusqueda1.UseCompatibleStateImageBehavior = False
        Me.lvbusqueda1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "Tipo"
        Me.ColumnHeader28.Width = 80
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "Serie"
        Me.ColumnHeader29.Width = 50
        '
        'ColumnHeader30
        '
        Me.ColumnHeader30.Text = "Documento"
        Me.ColumnHeader30.Width = 100
        '
        'ColumnHeader31
        '
        Me.ColumnHeader31.Text = "Fec.inicio"
        Me.ColumnHeader31.Width = 80
        '
        'ColumnHeader32
        '
        Me.ColumnHeader32.Text = "fec.fin"
        Me.ColumnHeader32.Width = 80
        '
        'Turno
        '
        Me.Turno.Text = "Turno"
        '
        'ColumnHeader34
        '
        Me.ColumnHeader34.Text = "C.Costo"
        Me.ColumnHeader34.Width = 100
        '
        'ColumnHeader35
        '
        Me.ColumnHeader35.Text = "Estado"
        Me.ColumnHeader35.Width = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(692, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "0"
        Me.Label2.Visible = False
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(601, 107)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 24
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnpasar
        '
        Me.btnpasar.Location = New System.Drawing.Point(520, 107)
        Me.btnpasar.Name = "btnpasar"
        Me.btnpasar.Size = New System.Drawing.Size(75, 23)
        Me.btnpasar.TabIndex = 23
        Me.btnpasar.Text = "Pasar"
        Me.btnpasar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.dtpfecha)
        Me.GroupBox1.Controls.Add(Me.txt_num)
        Me.GroupBox1.Controls.Add(Me.txtser_doc)
        Me.GroupBox1.Controls.Add(Me.txtt_doc)
        Me.GroupBox1.Controls.Add(Me.chknum)
        Me.GroupBox1.Controls.Add(Me.chkser)
        Me.GroupBox1.Controls.Add(Me.chktipo)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(711, 77)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(533, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha"
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(646, 39)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(55, 23)
        Me.btnbuscar.TabIndex = 5
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'dtpfecha
        '
        Me.dtpfecha.Checked = False
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(536, 42)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.ShowCheckBox = True
        Me.dtpfecha.Size = New System.Drawing.Size(104, 20)
        Me.dtpfecha.TabIndex = 4
        '
        'txt_num
        '
        Me.txt_num.Location = New System.Drawing.Point(357, 42)
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(144, 20)
        Me.txt_num.TabIndex = 3
        '
        'txtser_doc
        '
        Me.txtser_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtser_doc.Location = New System.Drawing.Point(177, 42)
        Me.txtser_doc.Name = "txtser_doc"
        Me.txtser_doc.Size = New System.Drawing.Size(122, 20)
        Me.txtser_doc.TabIndex = 2
        '
        'txtt_doc
        '
        Me.txtt_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtt_doc.Location = New System.Drawing.Point(6, 42)
        Me.txtt_doc.Name = "txtt_doc"
        Me.txtt_doc.Size = New System.Drawing.Size(118, 20)
        Me.txtt_doc.TabIndex = 1
        '
        'chknum
        '
        Me.chknum.AutoSize = True
        Me.chknum.Enabled = False
        Me.chknum.Location = New System.Drawing.Point(357, 19)
        Me.chknum.Name = "chknum"
        Me.chknum.Size = New System.Drawing.Size(63, 17)
        Me.chknum.TabIndex = 2
        Me.chknum.Text = "Numero"
        Me.chknum.UseVisualStyleBackColor = True
        '
        'chkser
        '
        Me.chkser.AutoSize = True
        Me.chkser.Enabled = False
        Me.chkser.Location = New System.Drawing.Point(177, 19)
        Me.chkser.Name = "chkser"
        Me.chkser.Size = New System.Drawing.Size(50, 17)
        Me.chkser.TabIndex = 1
        Me.chkser.Text = "Serie"
        Me.chkser.UseVisualStyleBackColor = True
        '
        'chktipo
        '
        Me.chktipo.AutoSize = True
        Me.chktipo.Enabled = False
        Me.chktipo.Location = New System.Drawing.Point(6, 19)
        Me.chktipo.Name = "chktipo"
        Me.chktipo.Size = New System.Drawing.Size(47, 17)
        Me.chktipo.TabIndex = 0
        Me.chktipo.Text = "Tipo"
        Me.chktipo.UseVisualStyleBackColor = True
        '
        'lvbusqueda
        '
        Me.lvbusqueda.CheckBoxes = True
        Me.lvbusqueda.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codigo, Me.nombre})
        Me.lvbusqueda.Location = New System.Drawing.Point(7, 136)
        Me.lvbusqueda.Name = "lvbusqueda"
        Me.lvbusqueda.Size = New System.Drawing.Size(708, 176)
        Me.lvbusqueda.TabIndex = 21
        Me.lvbusqueda.UseCompatibleStateImageBehavior = False
        Me.lvbusqueda.View = System.Windows.Forms.View.Details
        '
        'codigo
        '
        Me.codigo.Text = "codigo"
        '
        'nombre
        '
        Me.nombre.Text = "nombre"
        '
        'chkmarcar
        '
        Me.chkmarcar.AutoSize = True
        Me.chkmarcar.Location = New System.Drawing.Point(13, 111)
        Me.chkmarcar.Name = "chkmarcar"
        Me.chkmarcar.Size = New System.Drawing.Size(92, 17)
        Me.chkmarcar.TabIndex = 28
        Me.chkmarcar.Text = "Marcar Todos"
        Me.chkmarcar.UseVisualStyleBackColor = True
        '
        'FormDocuRefTurn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(723, 326)
        Me.Controls.Add(Me.chkmarcar)
        Me.Controls.Add(Me.lvbusqueda1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnpasar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lvbusqueda)
        Me.Controls.Add(Me.dgvbusqueda)
        Me.Controls.Add(Me.tsbMant)
        Me.Controls.Add(Me.cmbcosto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormDocuRefTurn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDocuRefTurn"
        CType(Me.dgvbusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsbMant.ResumeLayout(False)
        Me.tsbMant.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvbusqueda As DataGridView
    Friend WithEvents tsbMant As ToolStrip
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cmbccosto As ToolStripComboBox
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmbcosto As ComboBox
    Friend WithEvents lvbusqueda1 As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnpasar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnbuscar As Button
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents txt_num As TextBox
    Friend WithEvents txtser_doc As TextBox
    Friend WithEvents txtt_doc As TextBox
    Friend WithEvents chknum As CheckBox
    Friend WithEvents chkser As CheckBox
    Friend WithEvents chktipo As CheckBox
    Friend WithEvents lvbusqueda As ListView
    Friend WithEvents ColumnHeader28 As ColumnHeader
    Friend WithEvents ColumnHeader29 As ColumnHeader
    Friend WithEvents ColumnHeader30 As ColumnHeader
    Friend WithEvents ColumnHeader31 As ColumnHeader
    Friend WithEvents ColumnHeader32 As ColumnHeader
    Friend WithEvents Turno As ColumnHeader
    Friend WithEvents ColumnHeader34 As ColumnHeader
    Friend WithEvents ColumnHeader35 As ColumnHeader
    Private WithEvents codigo As ColumnHeader
    Friend WithEvents nombre As ColumnHeader
    Friend WithEvents chkmarcar As CheckBox
End Class
