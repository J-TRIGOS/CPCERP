<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRPTMerma
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpfec2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpfec1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtnomart = New System.Windows.Forms.TextBox()
        Me.txtcodart = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.lvccosto = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtSubLin2 = New System.Windows.Forms.TextBox()
        Me.cmbSublineas2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSubLin1 = New System.Windows.Forms.TextBox()
        Me.txtLinea = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbSublineas = New System.Windows.Forms.ComboBox()
        Me.cmbLineas = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbArticulo = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtArtCod = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.radSi = New System.Windows.Forms.RadioButton()
        Me.radNo = New System.Windows.Forms.RadioButton()
        Me.radTodos = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(650, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 120
        Me.Label6.Text = "Año :"
        '
        'dtpfec2
        '
        Me.dtpfec2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec2.Location = New System.Drawing.Point(677, 269)
        Me.dtpfec2.Name = "dtpfec2"
        Me.dtpfec2.Size = New System.Drawing.Size(100, 20)
        Me.dtpfec2.TabIndex = 119
        '
        'dtpfec1
        '
        Me.dtpfec1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec1.Location = New System.Drawing.Point(485, 269)
        Me.dtpfec1.Name = "dtpfec1"
        Me.dtpfec1.ShowCheckBox = True
        Me.dtpfec1.Size = New System.Drawing.Size(109, 20)
        Me.dtpfec1.TabIndex = 118
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(600, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "Fecha Inicio :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(795, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 22)
        Me.Button1.TabIndex = 116
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtnomart
        '
        Me.txtnomart.Location = New System.Drawing.Point(550, 295)
        Me.txtnomart.Name = "txtnomart"
        Me.txtnomart.ReadOnly = True
        Me.txtnomart.Size = New System.Drawing.Size(239, 20)
        Me.txtnomart.TabIndex = 115
        '
        'txtcodart
        '
        Me.txtcodart.Location = New System.Drawing.Point(485, 295)
        Me.txtcodart.MaxLength = 8
        Me.txtcodart.Name = "txtcodart"
        Me.txtcodart.Size = New System.Drawing.Size(56, 20)
        Me.txtcodart.TabIndex = 114
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(432, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Articulo :"
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(485, 321)
        Me.txtnumero.MaxLength = 9
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(100, 20)
        Me.txtnumero.TabIndex = 112
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(429, 324)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Número :"
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(550, 356)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 109
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(677, 356)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 110
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'lvccosto
        '
        Me.lvccosto.CheckBoxes = True
        Me.lvccosto.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvccosto.FullRowSelect = True
        Me.lvccosto.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvccosto.HideSelection = False
        Me.lvccosto.Location = New System.Drawing.Point(7, 258)
        Me.lvccosto.Name = "lvccosto"
        Me.lvccosto.Size = New System.Drawing.Size(396, 148)
        Me.lvccosto.TabIndex = 108
        Me.lvccosto.UseCompatibleStateImageBehavior = False
        Me.lvccosto.View = System.Windows.Forms.View.Details
        Me.lvccosto.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 276
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño.Location = New System.Drawing.Point(688, 233)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(65, 21)
        Me.cmbaño.TabIndex = 106
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(409, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Fecha Inicio :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radTodos)
        Me.GroupBox1.Controls.Add(Me.radNo)
        Me.GroupBox1.Controls.Add(Me.radSi)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.txtSubLin2)
        Me.GroupBox1.Controls.Add(Me.cmbSublineas2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtSubLin1)
        Me.GroupBox1.Controls.Add(Me.txtLinea)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtpFecFin)
        Me.GroupBox1.Controls.Add(Me.dtpFecIni)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbSublineas)
        Me.GroupBox1.Controls.Add(Me.cmbLineas)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmbArticulo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtArtCod)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(746, 195)
        Me.GroupBox1.TabIndex = 121
        Me.GroupBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(452, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "sin SOLM"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(517, 158)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 34
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtSubLin2
        '
        Me.txtSubLin2.Location = New System.Drawing.Point(106, 85)
        Me.txtSubLin2.MaxLength = 4
        Me.txtSubLin2.Name = "txtSubLin2"
        Me.txtSubLin2.Size = New System.Drawing.Size(84, 21)
        Me.txtSubLin2.TabIndex = 33
        '
        'cmbSublineas2
        '
        Me.cmbSublineas2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSublineas2.Enabled = False
        Me.cmbSublineas2.FormattingEnabled = True
        Me.cmbSublineas2.Location = New System.Drawing.Point(197, 85)
        Me.cmbSublineas2.Name = "cmbSublineas2"
        Me.cmbSublineas2.Size = New System.Drawing.Size(389, 21)
        Me.cmbSublineas2.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Sublinea 2"
        '
        'txtSubLin1
        '
        Me.txtSubLin1.Location = New System.Drawing.Point(106, 58)
        Me.txtSubLin1.MaxLength = 4
        Me.txtSubLin1.Name = "txtSubLin1"
        Me.txtSubLin1.Size = New System.Drawing.Size(84, 21)
        Me.txtSubLin1.TabIndex = 30
        '
        'txtLinea
        '
        Me.txtLinea.Location = New System.Drawing.Point(106, 27)
        Me.txtLinea.MaxLength = 4
        Me.txtLinea.Name = "txtLinea"
        Me.txtLinea.Size = New System.Drawing.Size(84, 21)
        Me.txtLinea.TabIndex = 29
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(688, 114)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(32, 23)
        Me.btnbuscar.TabIndex = 28
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(644, 154)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(79, 23)
        Me.btnCancelar.TabIndex = 24
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(547, 154)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(81, 23)
        Me.btnAceptar.TabIndex = 23
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Linea / Sublin :"
        '
        'dtpFecFin
        '
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(288, 159)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(98, 21)
        Me.dtpFecFin.TabIndex = 15
        '
        'dtpFecIni
        '
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIni.Location = New System.Drawing.Point(105, 160)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(98, 21)
        Me.dtpFecIni.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(215, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Fecha Final :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Fecha Inicial :"
        '
        'cmbSublineas
        '
        Me.cmbSublineas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSublineas.FormattingEnabled = True
        Me.cmbSublineas.Location = New System.Drawing.Point(197, 58)
        Me.cmbSublineas.Name = "cmbSublineas"
        Me.cmbSublineas.Size = New System.Drawing.Size(389, 21)
        Me.cmbSublineas.TabIndex = 11
        '
        'cmbLineas
        '
        Me.cmbLineas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLineas.FormattingEnabled = True
        Me.cmbLineas.Location = New System.Drawing.Point(197, 27)
        Me.cmbLineas.Name = "cmbLineas"
        Me.cmbLineas.Size = New System.Drawing.Size(389, 21)
        Me.cmbLineas.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Sublinea 1"
        '
        'cmbArticulo
        '
        Me.cmbArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbArticulo.FormattingEnabled = True
        Me.cmbArticulo.Location = New System.Drawing.Point(196, 114)
        Me.cmbArticulo.Name = "cmbArticulo"
        Me.cmbArticulo.Size = New System.Drawing.Size(486, 21)
        Me.cmbArticulo.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Codigo"
        '
        'txtArtCod
        '
        Me.txtArtCod.Location = New System.Drawing.Point(106, 115)
        Me.txtArtCod.MaxLength = 8
        Me.txtArtCod.Name = "txtArtCod"
        Me.txtArtCod.Size = New System.Drawing.Size(84, 21)
        Me.txtArtCod.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 142)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "OP Verificada"
        '
        'radSi
        '
        Me.radSi.AutoSize = True
        Me.radSi.Location = New System.Drawing.Point(106, 137)
        Me.radSi.Name = "radSi"
        Me.radSi.Size = New System.Drawing.Size(35, 17)
        Me.radSi.TabIndex = 38
        Me.radSi.TabStop = True
        Me.radSi.Text = "SI"
        Me.radSi.UseVisualStyleBackColor = True
        '
        'radNo
        '
        Me.radNo.AutoSize = True
        Me.radNo.Location = New System.Drawing.Point(147, 137)
        Me.radNo.Name = "radNo"
        Me.radNo.Size = New System.Drawing.Size(40, 17)
        Me.radNo.TabIndex = 39
        Me.radNo.TabStop = True
        Me.radNo.Text = "NO"
        Me.radNo.UseVisualStyleBackColor = True
        '
        'radTodos
        '
        Me.radTodos.AutoSize = True
        Me.radTodos.Location = New System.Drawing.Point(193, 137)
        Me.radTodos.Name = "radTodos"
        Me.radTodos.Size = New System.Drawing.Size(54, 17)
        Me.radTodos.TabIndex = 40
        Me.radTodos.TabStop = True
        Me.radTodos.Text = "Todos"
        Me.radTodos.UseVisualStyleBackColor = True
        '
        'FormRPTMerma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 213)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpfec2)
        Me.Controls.Add(Me.dtpfec1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtnomart)
        Me.Controls.Add(Me.txtcodart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.lvccosto)
        Me.Controls.Add(Me.cmbaño)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRPTMerma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRPTMerma"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents dtpfec2 As DateTimePicker
    Friend WithEvents dtpfec1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtnomart As TextBox
    Friend WithEvents txtcodart As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnreporte As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents lvccosto As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents cmbaño As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpFecFin As DateTimePicker
    Friend WithEvents dtpFecIni As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbSublineas As ComboBox
    Friend WithEvents cmbLineas As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbArticulo As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtArtCod As TextBox
    Friend WithEvents txtSubLin1 As TextBox
    Friend WithEvents txtLinea As TextBox
    Friend WithEvents txtSubLin2 As TextBox
    Friend WithEvents cmbSublineas2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents radTodos As RadioButton
    Friend WithEvents radNo As RadioButton
    Friend WithEvents radSi As RadioButton
End Class
