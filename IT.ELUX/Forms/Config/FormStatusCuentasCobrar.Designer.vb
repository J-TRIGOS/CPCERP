<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStatusCuentasCobrar
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpfec2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpfec1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtvend = New System.Windows.Forms.TextBox()
        Me.txtvend1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtcliente1 = New System.Windows.Forms.TextBox()
        Me.txtcliente2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbestado1 = New System.Windows.Forms.ComboBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.cmbestado2 = New System.Windows.Forms.ComboBox()
        Me.cmbtipo2 = New System.Windows.Forms.ComboBox()
        Me.cmbtipo1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbop2 = New System.Windows.Forms.RadioButton()
        Me.rdbop1 = New System.Windows.Forms.RadioButton()
        Me.cmbvencido = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbcargoso = New System.Windows.Forms.ComboBox()
        Me.lblcargoso = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbDepart = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbProv = New System.Windows.Forms.ComboBox()
        Me.cmbDist = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(209, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Fecha Final"
        '
        'dtpfec2
        '
        Me.dtpfec2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec2.Location = New System.Drawing.Point(277, 61)
        Me.dtpfec2.Name = "dtpfec2"
        Me.dtpfec2.Size = New System.Drawing.Size(87, 20)
        Me.dtpfec2.TabIndex = 2
        '
        'dtpfec1
        '
        Me.dtpfec1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec1.Location = New System.Drawing.Point(100, 61)
        Me.dtpfec1.Name = "dtpfec1"
        Me.dtpfec1.Size = New System.Drawing.Size(95, 20)
        Me.dtpfec1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Fecha Inicial"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Vendedor"
        '
        'txtvend
        '
        Me.txtvend.Location = New System.Drawing.Point(100, 87)
        Me.txtvend.MaxLength = 8
        Me.txtvend.Name = "txtvend"
        Me.txtvend.Size = New System.Drawing.Size(124, 20)
        Me.txtvend.TabIndex = 3
        '
        'txtvend1
        '
        Me.txtvend1.Location = New System.Drawing.Point(272, 87)
        Me.txtvend1.MaxLength = 8
        Me.txtvend1.Name = "txtvend1"
        Me.txtvend1.Size = New System.Drawing.Size(147, 20)
        Me.txtvend1.TabIndex = 4
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(230, 85)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(35, 23)
        Me.Button5.TabIndex = 82
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(425, 85)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(35, 23)
        Me.Button6.TabIndex = 83
        Me.Button6.Text = "..."
        Me.Button6.UseVisualStyleBackColor = True
        '
        'txtcliente1
        '
        Me.txtcliente1.Location = New System.Drawing.Point(100, 114)
        Me.txtcliente1.Name = "txtcliente1"
        Me.txtcliente1.Size = New System.Drawing.Size(124, 20)
        Me.txtcliente1.TabIndex = 5
        '
        'txtcliente2
        '
        Me.txtcliente2.Location = New System.Drawing.Point(272, 114)
        Me.txtcliente2.Name = "txtcliente2"
        Me.txtcliente2.Size = New System.Drawing.Size(147, 20)
        Me.txtcliente2.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(230, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 23)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(425, 111)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 23)
        Me.Button4.TabIndex = 88
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Tip. Docu."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Estado"
        '
        'cmbestado1
        '
        Me.cmbestado1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestado1.FormattingEnabled = True
        Me.cmbestado1.Items.AddRange(New Object() {"", "COBRADO", "CLIENTE", "CARTERA", "BANCO", "RENOVAD"})
        Me.cmbestado1.Location = New System.Drawing.Point(100, 166)
        Me.cmbestado1.Name = "cmbestado1"
        Me.cmbestado1.Size = New System.Drawing.Size(121, 21)
        Me.cmbestado1.TabIndex = 9
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(240, 295)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 98
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(146, 295)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 11
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'cmbestado2
        '
        Me.cmbestado2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestado2.FormattingEnabled = True
        Me.cmbestado2.Items.AddRange(New Object() {"", "COBRADO", "CLIENTE", "CARTERA", "BANCO", "RENOVAD"})
        Me.cmbestado2.Location = New System.Drawing.Point(230, 166)
        Me.cmbestado2.Name = "cmbestado2"
        Me.cmbestado2.Size = New System.Drawing.Size(121, 21)
        Me.cmbestado2.TabIndex = 10
        '
        'cmbtipo2
        '
        Me.cmbtipo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipo2.FormattingEnabled = True
        Me.cmbtipo2.Items.AddRange(New Object() {"", "Letras", "Facturas", "Notas de Credito"})
        Me.cmbtipo2.Location = New System.Drawing.Point(230, 140)
        Me.cmbtipo2.Name = "cmbtipo2"
        Me.cmbtipo2.Size = New System.Drawing.Size(121, 21)
        Me.cmbtipo2.TabIndex = 8
        '
        'cmbtipo1
        '
        Me.cmbtipo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipo1.FormattingEnabled = True
        Me.cmbtipo1.Items.AddRange(New Object() {"", "Letras", "Facturas", "Notas de Credito"})
        Me.cmbtipo1.Location = New System.Drawing.Point(100, 140)
        Me.cmbtipo1.Name = "cmbtipo1"
        Me.cmbtipo1.Size = New System.Drawing.Size(121, 21)
        Me.cmbtipo1.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbop2)
        Me.GroupBox1.Controls.Add(Me.rdbop1)
        Me.GroupBox1.Location = New System.Drawing.Point(50, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 47)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        '
        'rdbop2
        '
        Me.rdbop2.AutoSize = True
        Me.rdbop2.Location = New System.Drawing.Point(185, 19)
        Me.rdbop2.Name = "rdbop2"
        Me.rdbop2.Size = New System.Drawing.Size(100, 17)
        Me.rdbop2.TabIndex = 1
        Me.rdbop2.TabStop = True
        Me.rdbop2.Text = "Fecha Creacion"
        Me.rdbop2.UseVisualStyleBackColor = True
        '
        'rdbop1
        '
        Me.rdbop1.AutoSize = True
        Me.rdbop1.Checked = True
        Me.rdbop1.Location = New System.Drawing.Point(31, 19)
        Me.rdbop1.Name = "rdbop1"
        Me.rdbop1.Size = New System.Drawing.Size(116, 17)
        Me.rdbop1.TabIndex = 0
        Me.rdbop1.TabStop = True
        Me.rdbop1.Text = "Fecha Vencimiento"
        Me.rdbop1.UseVisualStyleBackColor = True
        '
        'cmbvencido
        '
        Me.cmbvencido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbvencido.FormattingEnabled = True
        Me.cmbvencido.Items.AddRange(New Object() {"", "VENCIDO", "NO VENCIDO"})
        Me.cmbvencido.Location = New System.Drawing.Point(100, 193)
        Me.cmbvencido.Name = "cmbvencido"
        Me.cmbvencido.Size = New System.Drawing.Size(121, 21)
        Me.cmbvencido.TabIndex = 100
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Estado Venc."
        '
        'cmbcargoso
        '
        Me.cmbcargoso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcargoso.FormattingEnabled = True
        Me.cmbcargoso.Items.AddRange(New Object() {"NO", "SI"})
        Me.cmbcargoso.Location = New System.Drawing.Point(324, 193)
        Me.cmbcargoso.Name = "cmbcargoso"
        Me.cmbcargoso.Size = New System.Drawing.Size(69, 21)
        Me.cmbcargoso.TabIndex = 103
        Me.cmbcargoso.Visible = False
        '
        'lblcargoso
        '
        Me.lblcargoso.AutoSize = True
        Me.lblcargoso.Location = New System.Drawing.Point(227, 196)
        Me.lblcargoso.Name = "lblcargoso"
        Me.lblcargoso.Size = New System.Drawing.Size(91, 13)
        Me.lblcargoso.TabIndex = 104
        Me.lblcargoso.Text = "Redondo Y Adela"
        Me.lblcargoso.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "Departamento"
        '
        'cmbDepart
        '
        Me.cmbDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepart.FormattingEnabled = True
        Me.cmbDepart.Location = New System.Drawing.Point(100, 220)
        Me.cmbDepart.Name = "cmbDepart"
        Me.cmbDepart.Size = New System.Drawing.Size(121, 21)
        Me.cmbDepart.TabIndex = 106
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(232, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "Provincia"
        '
        'cmbProv
        '
        Me.cmbProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProv.FormattingEnabled = True
        Me.cmbProv.Location = New System.Drawing.Point(289, 220)
        Me.cmbProv.Name = "cmbProv"
        Me.cmbProv.Size = New System.Drawing.Size(170, 21)
        Me.cmbProv.TabIndex = 108
        '
        'cmbDist
        '
        Me.cmbDist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDist.FormattingEnabled = True
        Me.cmbDist.Location = New System.Drawing.Point(100, 248)
        Me.cmbDist.Name = "cmbDist"
        Me.cmbDist.Size = New System.Drawing.Size(192, 21)
        Me.cmbDist.TabIndex = 109
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(55, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 110
        Me.Label10.Text = "Distrito"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(298, 248)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(20, 23)
        Me.btnLimpiar.TabIndex = 111
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'FormStatusCuentasCobrar
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 343)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbDist)
        Me.Controls.Add(Me.cmbProv)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbDepart)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblcargoso)
        Me.Controls.Add(Me.cmbcargoso)
        Me.Controls.Add(Me.cmbvencido)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbtipo2)
        Me.Controls.Add(Me.cmbtipo1)
        Me.Controls.Add(Me.cmbestado2)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.cmbestado1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtcliente2)
        Me.Controls.Add(Me.txtcliente1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtvend1)
        Me.Controls.Add(Me.txtvend)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpfec1)
        Me.Controls.Add(Me.dtpfec2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormStatusCuentasCobrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormStatusCuentasCobrar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpfec2 As DateTimePicker
    Friend WithEvents dtpfec1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtvend As TextBox
    Friend WithEvents txtvend1 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents txtcliente1 As TextBox
    Friend WithEvents txtcliente2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbestado1 As ComboBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnreporte As Button
    Friend WithEvents cmbestado2 As ComboBox
    Friend WithEvents cmbtipo2 As ComboBox
    Friend WithEvents cmbtipo1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbop1 As RadioButton
    Friend WithEvents rdbop2 As RadioButton
    Friend WithEvents cmbvencido As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbcargoso As ComboBox
    Friend WithEvents lblcargoso As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbDepart As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbProv As ComboBox
    Friend WithEvents cmbDist As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnLimpiar As Button
End Class
