<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRPTAnalisProd
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.txtsublinea2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbmes1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbmes2 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtsublinea1 = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmbaño1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtsublinea4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbmes3 = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.cmbmes4 = New System.Windows.Forms.ComboBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtsublinea3 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dtpfin = New System.Windows.Forms.DateTimePicker()
        Me.dtpini = New System.Windows.Forms.DateTimePicker()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.txtsublinea6 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtsublinea5 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 14)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(474, 215)
        Me.TabControl1.TabIndex = 64
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmbaño)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.btnreporte)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.btnsalir)
        Me.TabPage1.Controls.Add(Me.txtsublinea2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.cmbmes1)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.cmbmes2)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.txtsublinea1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(466, 189)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detallado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño.Location = New System.Drawing.Point(85, 21)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(121, 21)
        Me.cmbaño.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(247, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Mes2 :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Mes1 :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(415, 100)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(147, 128)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 8
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(134, 102)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(275, 20)
        Me.TextBox3.TabIndex = 60
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(241, 128)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 46
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'txtsublinea2
        '
        Me.txtsublinea2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsublinea2.Location = New System.Drawing.Point(85, 102)
        Me.txtsublinea2.MaxLength = 4
        Me.txtsublinea2.Name = "txtsublinea2"
        Me.txtsublinea2.Size = New System.Drawing.Size(43, 20)
        Me.txtsublinea2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Año :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Sub Linea2 :"
        '
        'cmbmes1
        '
        Me.cmbmes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes1.FormattingEnabled = True
        Me.cmbmes1.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes1.Location = New System.Drawing.Point(85, 49)
        Me.cmbmes1.Name = "cmbmes1"
        Me.cmbmes1.Size = New System.Drawing.Size(152, 21)
        Me.cmbmes1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(415, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbmes2
        '
        Me.cmbmes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes2.FormattingEnabled = True
        Me.cmbmes2.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes2.Location = New System.Drawing.Point(293, 49)
        Me.cmbmes2.Name = "cmbmes2"
        Me.cmbmes2.Size = New System.Drawing.Size(154, 21)
        Me.cmbmes2.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(134, 76)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(275, 20)
        Me.TextBox2.TabIndex = 56
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(7, 76)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(67, 13)
        Me.Label25.TabIndex = 52
        Me.Label25.Text = "Sub Linea1 :"
        '
        'txtsublinea1
        '
        Me.txtsublinea1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsublinea1.Location = New System.Drawing.Point(85, 76)
        Me.txtsublinea1.MaxLength = 4
        Me.txtsublinea1.Name = "txtsublinea1"
        Me.txtsublinea1.Size = New System.Drawing.Size(43, 20)
        Me.txtsublinea1.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmbaño1)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.txtsublinea4)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.cmbmes3)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.cmbmes4)
        Me.TabPage2.Controls.Add(Me.TextBox5)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txtsublinea3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(466, 189)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Anual"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmbaño1
        '
        Me.cmbaño1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño1.FormattingEnabled = True
        Me.cmbaño1.Items.AddRange(New Object() {"2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño1.Location = New System.Drawing.Point(85, 21)
        Me.cmbaño1.Name = "cmbaño1"
        Me.cmbaño1.Size = New System.Drawing.Size(121, 21)
        Me.cmbaño1.TabIndex = 63
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(247, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Mes2 :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Mes1 :"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(415, 100)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 23)
        Me.Button3.TabIndex = 69
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(147, 128)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 36)
        Me.Button4.TabIndex = 70
        Me.Button4.Text = "Reporte"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(134, 102)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(275, 20)
        Me.TextBox1.TabIndex = 77
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(241, 128)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 36)
        Me.Button5.TabIndex = 72
        Me.Button5.Text = "Salir"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtsublinea4
        '
        Me.txtsublinea4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsublinea4.Location = New System.Drawing.Point(85, 102)
        Me.txtsublinea4.Name = "txtsublinea4"
        Me.txtsublinea4.Size = New System.Drawing.Size(43, 20)
        Me.txtsublinea4.TabIndex = 68
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Año :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Sub Linea2 :"
        '
        'cmbmes3
        '
        Me.cmbmes3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes3.FormattingEnabled = True
        Me.cmbmes3.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes3.Location = New System.Drawing.Point(85, 49)
        Me.cmbmes3.Name = "cmbmes3"
        Me.cmbmes3.Size = New System.Drawing.Size(152, 21)
        Me.cmbmes3.TabIndex = 64
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(415, 74)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(32, 23)
        Me.Button6.TabIndex = 67
        Me.Button6.Text = "..."
        Me.Button6.UseVisualStyleBackColor = True
        '
        'cmbmes4
        '
        Me.cmbmes4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes4.FormattingEnabled = True
        Me.cmbmes4.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes4.Location = New System.Drawing.Point(293, 49)
        Me.cmbmes4.Name = "cmbmes4"
        Me.cmbmes4.Size = New System.Drawing.Size(154, 21)
        Me.cmbmes4.TabIndex = 65
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(134, 76)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(275, 20)
        Me.TextBox5.TabIndex = 75
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Sub Linea1 :"
        '
        'txtsublinea3
        '
        Me.txtsublinea3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsublinea3.Location = New System.Drawing.Point(85, 76)
        Me.txtsublinea3.Name = "txtsublinea3"
        Me.txtsublinea3.Size = New System.Drawing.Size(43, 20)
        Me.txtsublinea3.TabIndex = 66
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dtpfin)
        Me.TabPage3.Controls.Add(Me.dtpini)
        Me.TabPage3.Controls.Add(Me.Button9)
        Me.TabPage3.Controls.Add(Me.Button10)
        Me.TabPage3.Controls.Add(Me.Button7)
        Me.TabPage3.Controls.Add(Me.TextBox4)
        Me.TabPage3.Controls.Add(Me.txtsublinea6)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Button8)
        Me.TabPage3.Controls.Add(Me.TextBox7)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.txtsublinea5)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(466, 189)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Diario"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dtpfin
        '
        Me.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfin.Location = New System.Drawing.Point(300, 30)
        Me.dtpfin.Name = "dtpfin"
        Me.dtpfin.Size = New System.Drawing.Size(94, 20)
        Me.dtpfin.TabIndex = 89
        '
        'dtpini
        '
        Me.dtpini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpini.Location = New System.Drawing.Point(91, 30)
        Me.dtpini.Name = "dtpini"
        Me.dtpini.Size = New System.Drawing.Size(94, 20)
        Me.dtpini.TabIndex = 88
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(142, 121)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 36)
        Me.Button9.TabIndex = 86
        Me.Button9.Text = "Reporte"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(237, 121)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 36)
        Me.Button10.TabIndex = 87
        Me.Button10.Text = "Salir"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(421, 84)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(32, 23)
        Me.Button7.TabIndex = 81
        Me.Button7.Text = "..."
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(140, 86)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(275, 20)
        Me.TextBox4.TabIndex = 85
        '
        'txtsublinea6
        '
        Me.txtsublinea6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsublinea6.Location = New System.Drawing.Point(91, 86)
        Me.txtsublinea6.Name = "txtsublinea6"
        Me.txtsublinea6.Size = New System.Drawing.Size(43, 20)
        Me.txtsublinea6.TabIndex = 80
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "Sub Linea2 :"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(421, 58)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(32, 23)
        Me.Button8.TabIndex = 79
        Me.Button8.Text = "..."
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(140, 60)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(275, 20)
        Me.TextBox7.TabIndex = 83
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 82
        Me.Label13.Text = "Sub Linea1 :"
        '
        'txtsublinea5
        '
        Me.txtsublinea5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsublinea5.Location = New System.Drawing.Point(91, 60)
        Me.txtsublinea5.Name = "txtsublinea5"
        Me.txtsublinea5.Size = New System.Drawing.Size(43, 20)
        Me.txtsublinea5.TabIndex = 78
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(234, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Fecha Fin :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Fecha Inicio:"
        '
        'FormRPTAnalisProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 242)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormRPTAnalisProd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRPTAnalisProd"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents cmbaño As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnreporte As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents txtsublinea2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbmes1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbmes2 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtsublinea1 As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmbaño1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents txtsublinea4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbmes3 As ComboBox
    Friend WithEvents Button6 As Button
    Friend WithEvents cmbmes4 As ComboBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtsublinea3 As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents txtsublinea6 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtsublinea5 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpfin As DateTimePicker
    Friend WithEvents dtpini As DateTimePicker
End Class
