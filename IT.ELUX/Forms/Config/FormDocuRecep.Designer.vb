<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDocuRecep
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkmarcar = New System.Windows.Forms.CheckBox()
        Me.lvbusqueda = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnpasar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.cmbmes = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkfecha = New System.Windows.Forms.CheckBox()
        Me.lblaño = New System.Windows.Forms.Label()
        Me.lblruc = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txt_num = New System.Windows.Forms.TextBox()
        Me.txtser_doc = New System.Windows.Forms.TextBox()
        Me.txtt_doc = New System.Windows.Forms.TextBox()
        Me.chknum = New System.Windows.Forms.CheckBox()
        Me.chkser = New System.Windows.Forms.CheckBox()
        Me.chktipo = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(546, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "0"
        Me.Label2.Visible = False
        '
        'chkmarcar
        '
        Me.chkmarcar.AutoSize = True
        Me.chkmarcar.Location = New System.Drawing.Point(12, 107)
        Me.chkmarcar.Name = "chkmarcar"
        Me.chkmarcar.Size = New System.Drawing.Size(92, 17)
        Me.chkmarcar.TabIndex = 16
        Me.chkmarcar.Text = "Marcar Todos"
        Me.chkmarcar.UseVisualStyleBackColor = True
        '
        'lvbusqueda
        '
        Me.lvbusqueda.CheckBoxes = True
        Me.lvbusqueda.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader11, Me.ColumnHeader10, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader15, Me.ColumnHeader1})
        Me.lvbusqueda.FullRowSelect = True
        Me.lvbusqueda.Location = New System.Drawing.Point(18, 130)
        Me.lvbusqueda.Name = "lvbusqueda"
        Me.lvbusqueda.Size = New System.Drawing.Size(758, 176)
        Me.lvbusqueda.TabIndex = 15
        Me.lvbusqueda.UseCompatibleStateImageBehavior = False
        Me.lvbusqueda.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Tipo"
        Me.ColumnHeader9.Width = 52
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Serie"
        Me.ColumnHeader11.Width = 52
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Documento"
        Me.ColumnHeader10.Width = 100
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Fecha"
        Me.ColumnHeader12.Width = 80
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "RUC"
        Me.ColumnHeader13.Width = 85
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Raz. Social"
        Me.ColumnHeader15.Width = 250
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Monto"
        Me.ColumnHeader1.Width = 180
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(689, 101)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 14
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnpasar
        '
        Me.btnpasar.Location = New System.Drawing.Point(608, 101)
        Me.btnpasar.Name = "btnpasar"
        Me.btnpasar.Size = New System.Drawing.Size(75, 23)
        Me.btnpasar.TabIndex = 13
        Me.btnpasar.Text = "Pasar"
        Me.btnpasar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbaño)
        Me.GroupBox1.Controls.Add(Me.cmbmes)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.chkfecha)
        Me.GroupBox1.Controls.Add(Me.lblaño)
        Me.GroupBox1.Controls.Add(Me.lblruc)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.txt_num)
        Me.GroupBox1.Controls.Add(Me.txtser_doc)
        Me.GroupBox1.Controls.Add(Me.txtt_doc)
        Me.GroupBox1.Controls.Add(Me.chknum)
        Me.GroupBox1.Controls.Add(Me.chkser)
        Me.GroupBox1.Controls.Add(Me.chktipo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(758, 79)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda"
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.Enabled = False
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño.Location = New System.Drawing.Point(407, 42)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(60, 21)
        Me.cmbaño.TabIndex = 119
        '
        'cmbmes
        '
        Me.cmbmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes.Enabled = False
        Me.cmbmes.FormattingEnabled = True
        Me.cmbmes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes.Location = New System.Drawing.Point(504, 41)
        Me.cmbmes.Name = "cmbmes"
        Me.cmbmes.Size = New System.Drawing.Size(106, 21)
        Me.cmbmes.TabIndex = 120
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(475, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 118
        Me.Label8.Text = "Mes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(373, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Año"
        '
        'chkfecha
        '
        Me.chkfecha.AutoSize = True
        Me.chkfecha.Location = New System.Drawing.Point(376, 19)
        Me.chkfecha.Name = "chkfecha"
        Me.chkfecha.Size = New System.Drawing.Size(56, 17)
        Me.chkfecha.TabIndex = 14
        Me.chkfecha.Text = "Fecha"
        Me.chkfecha.UseVisualStyleBackColor = True
        '
        'lblaño
        '
        Me.lblaño.AutoSize = True
        Me.lblaño.Location = New System.Drawing.Point(713, 48)
        Me.lblaño.Name = "lblaño"
        Me.lblaño.Size = New System.Drawing.Size(39, 13)
        Me.lblaño.TabIndex = 13
        Me.lblaño.Text = "Label4"
        Me.lblaño.Visible = False
        '
        'lblruc
        '
        Me.lblruc.AutoSize = True
        Me.lblruc.Location = New System.Drawing.Point(713, 33)
        Me.lblruc.Name = "lblruc"
        Me.lblruc.Size = New System.Drawing.Size(39, 13)
        Me.lblruc.TabIndex = 12
        Me.lblruc.Text = "Label3"
        Me.lblruc.Visible = False
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(625, 39)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(55, 23)
        Me.btnbuscar.TabIndex = 2
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'txt_num
        '
        Me.txt_num.Location = New System.Drawing.Point(223, 41)
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(144, 20)
        Me.txt_num.TabIndex = 1
        '
        'txtser_doc
        '
        Me.txtser_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtser_doc.Location = New System.Drawing.Point(111, 41)
        Me.txtser_doc.Name = "txtser_doc"
        Me.txtser_doc.Size = New System.Drawing.Size(106, 20)
        Me.txtser_doc.TabIndex = 10
        '
        'txtt_doc
        '
        Me.txtt_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtt_doc.Location = New System.Drawing.Point(18, 42)
        Me.txtt_doc.Name = "txtt_doc"
        Me.txtt_doc.Size = New System.Drawing.Size(87, 20)
        Me.txtt_doc.TabIndex = 9
        '
        'chknum
        '
        Me.chknum.AutoSize = True
        Me.chknum.Enabled = False
        Me.chknum.Location = New System.Drawing.Point(223, 19)
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
        Me.chkser.Location = New System.Drawing.Point(111, 18)
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
        Me.chktipo.Location = New System.Drawing.Point(18, 19)
        Me.chktipo.Name = "chktipo"
        Me.chktipo.Size = New System.Drawing.Size(47, 17)
        Me.chktipo.TabIndex = 0
        Me.chktipo.Text = "Tipo"
        Me.chktipo.UseVisualStyleBackColor = True
        '
        'FormDocuRecep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 320)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkmarcar)
        Me.Controls.Add(Me.lvbusqueda)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnpasar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormDocuRecep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDocuRecep"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents chkmarcar As CheckBox
    Friend WithEvents lvbusqueda As ListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnpasar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents txt_num As TextBox
    Friend WithEvents txtser_doc As TextBox
    Friend WithEvents txtt_doc As TextBox
    Friend WithEvents chknum As CheckBox
    Friend WithEvents chkser As CheckBox
    Friend WithEvents chktipo As CheckBox
    Friend WithEvents lblaño As Label
    Friend WithEvents lblruc As Label
    Friend WithEvents chkfecha As CheckBox
    Friend WithEvents cmbaño As ComboBox
    Friend WithEvents cmbmes As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
