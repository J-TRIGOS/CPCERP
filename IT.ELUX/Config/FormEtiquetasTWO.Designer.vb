<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEtiquetasTWO
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
        Me.lblarticulo = New System.Windows.Forms.TextBox()
        Me.txtarticulo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtlotenvase = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfardo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfec = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbcalidad = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbturno = New System.Windows.Forms.ComboBox()
        Me.txtembalador = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.cmb4 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb3 = New System.Windows.Forms.ComboBox()
        Me.cmb1 = New System.Windows.Forms.ComboBox()
        Me.cmb2 = New System.Windows.Forms.ComboBox()
        Me.txtetiquetas = New System.Windows.Forms.NumericUpDown()
        Me.txtcant = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chknros = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtetiquetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblarticulo
        '
        Me.lblarticulo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblarticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblarticulo.Location = New System.Drawing.Point(172, 22)
        Me.lblarticulo.Name = "lblarticulo"
        Me.lblarticulo.ReadOnly = True
        Me.lblarticulo.Size = New System.Drawing.Size(365, 20)
        Me.lblarticulo.TabIndex = 223
        '
        'txtarticulo
        '
        Me.txtarticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtarticulo.Location = New System.Drawing.Point(81, 22)
        Me.txtarticulo.Name = "txtarticulo"
        Me.txtarticulo.Size = New System.Drawing.Size(90, 20)
        Me.txtarticulo.TabIndex = 221
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 222
        Me.Label6.Text = "Articulo"
        '
        'txtlotenvase
        '
        Me.txtlotenvase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlotenvase.Location = New System.Drawing.Point(443, 53)
        Me.txtlotenvase.Multiline = True
        Me.txtlotenvase.Name = "txtlotenvase"
        Me.txtlotenvase.Size = New System.Drawing.Size(121, 21)
        Me.txtlotenvase.TabIndex = 224
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 225
        Me.Label4.Text = "Lote "
        '
        'txtfardo
        '
        Me.txtfardo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfardo.Location = New System.Drawing.Point(81, 118)
        Me.txtfardo.Name = "txtfardo"
        Me.txtfardo.Size = New System.Drawing.Size(132, 20)
        Me.txtfardo.TabIndex = 226
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 227
        Me.Label1.Text = "Fardo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 229
        Me.Label2.Text = "Cantidad"
        '
        'dtpfec
        '
        Me.dtpfec.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec.Location = New System.Drawing.Point(81, 149)
        Me.dtpfec.Name = "dtpfec"
        Me.dtpfec.Size = New System.Drawing.Size(102, 20)
        Me.dtpfec.TabIndex = 230
        Me.dtpfec.Value = New Date(2019, 2, 13, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 231
        Me.Label5.Text = "Fecha "
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(304, 325)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 233
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(185, 325)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 232
        Me.btnreporte.Text = "Imprimir "
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chknros)
        Me.GroupBox1.Controls.Add(Me.cmbcalidad)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmbturno)
        Me.GroupBox1.Controls.Add(Me.txtembalador)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt5)
        Me.GroupBox1.Controls.Add(Me.cmb4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmb3)
        Me.GroupBox1.Controls.Add(Me.cmb1)
        Me.GroupBox1.Controls.Add(Me.cmb2)
        Me.GroupBox1.Controls.Add(Me.txtetiquetas)
        Me.GroupBox1.Controls.Add(Me.txtcant)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblarticulo)
        Me.GroupBox1.Controls.Add(Me.btnsalir)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnreporte)
        Me.GroupBox1.Controls.Add(Me.txtarticulo)
        Me.GroupBox1.Controls.Add(Me.dtpfec)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtlotenvase)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtfardo)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(570, 370)
        Me.GroupBox1.TabIndex = 234
        Me.GroupBox1.TabStop = False
        '
        'cmbcalidad
        '
        Me.cmbcalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcalidad.FormattingEnabled = True
        Me.cmbcalidad.Items.AddRange(New Object() {"11STD", "21REG", "22MAL"})
        Me.cmbcalidad.Location = New System.Drawing.Point(81, 86)
        Me.cmbcalidad.Name = "cmbcalidad"
        Me.cmbcalidad.Size = New System.Drawing.Size(67, 21)
        Me.cmbcalidad.TabIndex = 250
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 249
        Me.Label11.Text = "Calidad"
        '
        'cmbturno
        '
        Me.cmbturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbturno.FormattingEnabled = True
        Me.cmbturno.Items.AddRange(New Object() {"DIA ", "NOCHE"})
        Me.cmbturno.Location = New System.Drawing.Point(81, 245)
        Me.cmbturno.Name = "cmbturno"
        Me.cmbturno.Size = New System.Drawing.Size(79, 21)
        Me.cmbturno.TabIndex = 248
        '
        'txtembalador
        '
        Me.txtembalador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtembalador.Location = New System.Drawing.Point(81, 279)
        Me.txtembalador.Name = "txtembalador"
        Me.txtembalador.Size = New System.Drawing.Size(132, 20)
        Me.txtembalador.TabIndex = 247
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 282)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 246
        Me.Label10.Text = "Embalador"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 245
        Me.Label9.Text = "Turno"
        '
        'txt5
        '
        Me.txt5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt5.Location = New System.Drawing.Point(372, 53)
        Me.txt5.MaxLength = 6
        Me.txt5.Multiline = True
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(70, 21)
        Me.txt5.TabIndex = 244
        '
        'cmb4
        '
        Me.cmb4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb4.FormattingEnabled = True
        Me.cmb4.Items.AddRange(New Object() {"Linea", "1", "2", "3", "4", "5"})
        Me.cmb4.Location = New System.Drawing.Point(304, 53)
        Me.cmb4.Name = "cmb4"
        Me.cmb4.Size = New System.Drawing.Size(67, 21)
        Me.cmb4.TabIndex = 243
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(221, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 242
        Me.Label8.Text = "-"
        '
        'cmb3
        '
        Me.cmb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb3.FormattingEnabled = True
        Me.cmb3.Items.AddRange(New Object() {"Cant Pqt.", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmb3.Location = New System.Drawing.Point(236, 53)
        Me.cmb3.Name = "cmb3"
        Me.cmb3.Size = New System.Drawing.Size(67, 21)
        Me.cmb3.TabIndex = 241
        '
        'cmb1
        '
        Me.cmb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb1.FormattingEnabled = True
        Me.cmb1.Items.AddRange(New Object() {"Cant fardos", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10"})
        Me.cmb1.Location = New System.Drawing.Point(81, 53)
        Me.cmb1.Name = "cmb1"
        Me.cmb1.Size = New System.Drawing.Size(67, 21)
        Me.cmb1.TabIndex = 240
        '
        'cmb2
        '
        Me.cmb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb2.FormattingEnabled = True
        Me.cmb2.Items.AddRange(New Object() {"Mes", "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SETIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cmb2.Location = New System.Drawing.Point(149, 53)
        Me.cmb2.Name = "cmb2"
        Me.cmb2.Size = New System.Drawing.Size(67, 21)
        Me.cmb2.TabIndex = 239
        '
        'txtetiquetas
        '
        Me.txtetiquetas.Location = New System.Drawing.Point(81, 212)
        Me.txtetiquetas.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.txtetiquetas.Name = "txtetiquetas"
        Me.txtetiquetas.Size = New System.Drawing.Size(79, 20)
        Me.txtetiquetas.TabIndex = 238
        '
        'txtcant
        '
        Me.txtcant.Location = New System.Drawing.Point(81, 181)
        Me.txtcant.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtcant.Name = "txtcant"
        Me.txtcant.Size = New System.Drawing.Size(79, 20)
        Me.txtcant.TabIndex = 237
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 235
        Me.Label7.Text = "Nro Etiquetas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(543, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 234
        Me.Label3.Text = "F9"
        '
        'chknros
        '
        Me.chknros.AutoSize = True
        Me.chknros.Checked = True
        Me.chknros.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chknros.Location = New System.Drawing.Point(443, 282)
        Me.chknros.Name = "chknros"
        Me.chknros.Size = New System.Drawing.Size(106, 17)
        Me.chknros.TabIndex = 251
        Me.chknros.Text = "Mostrar Numeros"
        Me.chknros.UseVisualStyleBackColor = True
        '
        'FormEtiquetasTWO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 380)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormEtiquetasTWO"
        Me.Text = "FormEtiquetasTWO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtetiquetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblarticulo As TextBox
    Friend WithEvents txtarticulo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtlotenvase As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtfardo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpfec As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnreporte As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtetiquetas As NumericUpDown
    Friend WithEvents txtcant As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents txt5 As TextBox
    Friend WithEvents cmb4 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb3 As ComboBox
    Friend WithEvents cmb1 As ComboBox
    Friend WithEvents cmb2 As ComboBox
    Friend WithEvents cmbturno As ComboBox
    Friend WithEvents txtembalador As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbcalidad As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents chknros As CheckBox
End Class
