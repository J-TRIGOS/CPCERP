<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDocuProvCon
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbfactComp = New System.Windows.Forms.RadioButton()
        Me.rdbfactrecp = New System.Windows.Forms.RadioButton()
        Me.cmbaf = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkmarcar = New System.Windows.Forms.CheckBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnpasar = New System.Windows.Forms.Button()
        Me.rdbrdoc = New System.Windows.Forms.RadioButton()
        Me.rdboreq = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.txt_num = New System.Windows.Forms.TextBox()
        Me.txtser_doc = New System.Windows.Forms.TextBox()
        Me.txtt_doc = New System.Windows.Forms.TextBox()
        Me.chknum = New System.Windows.Forms.CheckBox()
        Me.chkser = New System.Windows.Forms.CheckBox()
        Me.chktipo = New System.Windows.Forms.CheckBox()
        Me.lvbusqueda1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvbusqueda2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbfactComp)
        Me.GroupBox1.Controls.Add(Me.rdbfactrecp)
        Me.GroupBox1.Controls.Add(Me.cmbaf)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.chkmarcar)
        Me.GroupBox1.Controls.Add(Me.btnsalir)
        Me.GroupBox1.Controls.Add(Me.btnpasar)
        Me.GroupBox1.Controls.Add(Me.rdbrdoc)
        Me.GroupBox1.Controls.Add(Me.rdboreq)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.dtpfecha)
        Me.GroupBox1.Controls.Add(Me.txt_num)
        Me.GroupBox1.Controls.Add(Me.txtser_doc)
        Me.GroupBox1.Controls.Add(Me.txtt_doc)
        Me.GroupBox1.Controls.Add(Me.chknum)
        Me.GroupBox1.Controls.Add(Me.chkser)
        Me.GroupBox1.Controls.Add(Me.chktipo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(661, 107)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda"
        '
        'rdbfactComp
        '
        Me.rdbfactComp.AutoSize = True
        Me.rdbfactComp.Location = New System.Drawing.Point(118, 68)
        Me.rdbfactComp.Name = "rdbfactComp"
        Me.rdbfactComp.Size = New System.Drawing.Size(88, 17)
        Me.rdbfactComp.TabIndex = 15
        Me.rdbfactComp.Text = "Fact. Compra"
        Me.rdbfactComp.UseVisualStyleBackColor = True
        '
        'rdbfactrecp
        '
        Me.rdbfactrecp.AutoSize = True
        Me.rdbfactrecp.Checked = True
        Me.rdbfactrecp.Location = New System.Drawing.Point(324, 68)
        Me.rdbfactrecp.Name = "rdbfactrecp"
        Me.rdbfactrecp.Size = New System.Drawing.Size(87, 17)
        Me.rdbfactrecp.TabIndex = 14
        Me.rdbfactrecp.TabStop = True
        Me.rdbfactrecp.Text = "Fact. Recep."
        Me.rdbfactrecp.UseVisualStyleBackColor = True
        '
        'cmbaf
        '
        Me.cmbaf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaf.FormattingEnabled = True
        Me.cmbaf.Items.AddRange(New Object() {"A", "I"})
        Me.cmbaf.Location = New System.Drawing.Point(419, 67)
        Me.cmbaf.Name = "cmbaf"
        Me.cmbaf.Size = New System.Drawing.Size(62, 21)
        Me.cmbaf.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(630, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "0"
        Me.Label2.Visible = False
        '
        'chkmarcar
        '
        Me.chkmarcar.AutoSize = True
        Me.chkmarcar.Location = New System.Drawing.Point(6, 90)
        Me.chkmarcar.Name = "chkmarcar"
        Me.chkmarcar.Size = New System.Drawing.Size(92, 17)
        Me.chkmarcar.TabIndex = 11
        Me.chkmarcar.Text = "Marcar Todos"
        Me.chkmarcar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(568, 65)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 10
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnpasar
        '
        Me.btnpasar.Location = New System.Drawing.Point(487, 65)
        Me.btnpasar.Name = "btnpasar"
        Me.btnpasar.Size = New System.Drawing.Size(75, 23)
        Me.btnpasar.TabIndex = 9
        Me.btnpasar.Text = "Pasar"
        Me.btnpasar.UseVisualStyleBackColor = True
        Me.btnpasar.Visible = False
        '
        'rdbrdoc
        '
        Me.rdbrdoc.AutoSize = True
        Me.rdbrdoc.Location = New System.Drawing.Point(6, 68)
        Me.rdbrdoc.Name = "rdbrdoc"
        Me.rdbrdoc.Size = New System.Drawing.Size(106, 17)
        Me.rdbrdoc.TabIndex = 8
        Me.rdbrdoc.Text = "Rec. Documento"
        Me.rdbrdoc.UseVisualStyleBackColor = True
        '
        'rdboreq
        '
        Me.rdboreq.AutoSize = True
        Me.rdboreq.Location = New System.Drawing.Point(214, 68)
        Me.rdboreq.Name = "rdboreq"
        Me.rdboreq.Size = New System.Drawing.Size(93, 17)
        Me.rdboreq.TabIndex = 7
        Me.rdboreq.Text = "Orden Compra"
        Me.rdboreq.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(475, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha"
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(588, 39)
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
        Me.dtpfecha.Location = New System.Drawing.Point(478, 42)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.ShowCheckBox = True
        Me.dtpfecha.Size = New System.Drawing.Size(104, 20)
        Me.dtpfecha.TabIndex = 4
        '
        'txt_num
        '
        Me.txt_num.Location = New System.Drawing.Point(324, 42)
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(144, 20)
        Me.txt_num.TabIndex = 3
        '
        'txtser_doc
        '
        Me.txtser_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtser_doc.Location = New System.Drawing.Point(171, 42)
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
        Me.chknum.Location = New System.Drawing.Point(324, 19)
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
        Me.chkser.Location = New System.Drawing.Point(171, 19)
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
        'lvbusqueda1
        '
        Me.lvbusqueda1.CheckBoxes = True
        Me.lvbusqueda1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvbusqueda1.FullRowSelect = True
        Me.lvbusqueda1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvbusqueda1.Location = New System.Drawing.Point(12, 125)
        Me.lvbusqueda1.Name = "lvbusqueda1"
        Me.lvbusqueda1.Size = New System.Drawing.Size(668, 176)
        Me.lvbusqueda1.TabIndex = 7
        Me.lvbusqueda1.UseCompatibleStateImageBehavior = False
        Me.lvbusqueda1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Tipo"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Serie"
        Me.ColumnHeader2.Width = 50
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Numero"
        Me.ColumnHeader3.Width = 70
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Ruc"
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Proveedor"
        Me.ColumnHeader5.Width = 280
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "F. Generacion"
        Me.ColumnHeader6.Width = 80
        '
        'lvbusqueda2
        '
        Me.lvbusqueda2.CheckBoxes = True
        Me.lvbusqueda2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.lvbusqueda2.FullRowSelect = True
        Me.lvbusqueda2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvbusqueda2.Location = New System.Drawing.Point(12, 125)
        Me.lvbusqueda2.Name = "lvbusqueda2"
        Me.lvbusqueda2.Size = New System.Drawing.Size(668, 176)
        Me.lvbusqueda2.TabIndex = 8
        Me.lvbusqueda2.UseCompatibleStateImageBehavior = False
        Me.lvbusqueda2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Tipo"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Serie"
        Me.ColumnHeader8.Width = 50
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Numero"
        Me.ColumnHeader9.Width = 70
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Ruc"
        Me.ColumnHeader10.Width = 80
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Proveedor"
        Me.ColumnHeader11.Width = 280
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "F. Generacion"
        Me.ColumnHeader12.Width = 80
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Numero"
        '
        'FormDocuProvCon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 313)
        Me.Controls.Add(Me.lvbusqueda2)
        Me.Controls.Add(Me.lvbusqueda1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormDocuProvCon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDocuProvCon"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

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
    Friend WithEvents lvbusqueda1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents rdbrdoc As RadioButton
    Friend WithEvents rdboreq As RadioButton
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnpasar As Button
    Friend WithEvents chkmarcar As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbaf As ComboBox
    Friend WithEvents rdbfactrecp As RadioButton
    Friend WithEvents lvbusqueda2 As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents rdbfactComp As RadioButton
End Class
