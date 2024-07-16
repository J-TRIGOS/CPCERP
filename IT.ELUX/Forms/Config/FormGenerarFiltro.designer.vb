<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGenerarFiltro
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbañoven = New System.Windows.Forms.ComboBox()
        Me.cmbmesven = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbanho = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbmes = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_reg_nro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblruc = New System.Windows.Forms.TextBox()
        Me.lbl_tipo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_serie = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_tipo = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtruc = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtobserva1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtobserva1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_reg_nro)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblruc)
        Me.GroupBox1.Controls.Add(Me.lbl_tipo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_serie)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtnro)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_tipo)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.txtruc)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(794, 147)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbañoven)
        Me.GroupBox3.Controls.Add(Me.cmbmesven)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(322, 82)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(331, 48)
        Me.GroupBox3.TabIndex = 232
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fecha Vencimiento"
        '
        'cmbañoven
        '
        Me.cmbañoven.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbañoven.FormattingEnabled = True
        Me.cmbañoven.Items.AddRange(New Object() {"", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2022", "2023", "2024", "2025"})
        Me.cmbañoven.Location = New System.Drawing.Point(45, 19)
        Me.cmbañoven.Name = "cmbañoven"
        Me.cmbañoven.Size = New System.Drawing.Size(80, 21)
        Me.cmbañoven.TabIndex = 227
        '
        'cmbmesven
        '
        Me.cmbmesven.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmesven.FormattingEnabled = True
        Me.cmbmesven.Items.AddRange(New Object() {"", "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SETIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cmbmesven.Location = New System.Drawing.Point(196, 19)
        Me.cmbmesven.Name = "cmbmesven"
        Me.cmbmesven.Size = New System.Drawing.Size(109, 21)
        Me.cmbmesven.TabIndex = 228
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(160, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 230
        Me.Label8.Text = "Mes"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 229
        Me.Label11.Text = "Año"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmbanho)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmbmes)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(298, 48)
        Me.GroupBox2.TabIndex = 231
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fecha Generacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 220
        Me.Label4.Text = "Año"
        '
        'cmbanho
        '
        Me.cmbanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbanho.FormattingEnabled = True
        Me.cmbanho.Items.AddRange(New Object() {"", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025"})
        Me.cmbanho.Location = New System.Drawing.Point(38, 19)
        Me.cmbanho.Name = "cmbanho"
        Me.cmbanho.Size = New System.Drawing.Size(80, 21)
        Me.cmbanho.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(124, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 221
        Me.Label6.Text = "Mes"
        '
        'cmbmes
        '
        Me.cmbmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes.FormattingEnabled = True
        Me.cmbmes.Items.AddRange(New Object() {"", "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SETIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cmbmes.Location = New System.Drawing.Point(155, 19)
        Me.cmbmes.Name = "cmbmes"
        Me.cmbmes.Size = New System.Drawing.Size(109, 21)
        Me.cmbmes.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(513, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 226
        Me.Label9.Text = "Reg Nro"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(598, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 225
        '
        'txt_reg_nro
        '
        Me.txt_reg_nro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_reg_nro.Location = New System.Drawing.Point(561, 19)
        Me.txt_reg_nro.MaxLength = 20
        Me.txt_reg_nro.Name = "txt_reg_nro"
        Me.txt_reg_nro.Size = New System.Drawing.Size(80, 20)
        Me.txt_reg_nro.TabIndex = 224
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(387, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 216
        Me.Label2.Text = "Numero"
        '
        'lblruc
        '
        Me.lblruc.BackColor = System.Drawing.Color.Gainsboro
        Me.lblruc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lblruc.Location = New System.Drawing.Point(162, 50)
        Me.lblruc.Name = "lblruc"
        Me.lblruc.ReadOnly = True
        Me.lblruc.Size = New System.Drawing.Size(624, 20)
        Me.lblruc.TabIndex = 215
        '
        'lbl_tipo
        '
        Me.lbl_tipo.BackColor = System.Drawing.Color.Gainsboro
        Me.lbl_tipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lbl_tipo.Location = New System.Drawing.Point(107, 18)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.ReadOnly = True
        Me.lbl_tipo.Size = New System.Drawing.Size(177, 20)
        Me.lbl_tipo.TabIndex = 213
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 206
        Me.Label7.Text = "Ruc"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(287, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 202
        Me.Label5.Text = "Serie"
        '
        'txt_serie
        '
        Me.txt_serie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_serie.Location = New System.Drawing.Point(322, 20)
        Me.txt_serie.MaxLength = 5
        Me.txt_serie.Name = "txt_serie"
        Me.txt_serie.Size = New System.Drawing.Size(62, 20)
        Me.txt_serie.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(465, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 197
        '
        'txtnro
        '
        Me.txtnro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnro.Location = New System.Drawing.Point(431, 19)
        Me.txtnro.MaxLength = 20
        Me.txtnro.Name = "txtnro"
        Me.txtnro.Size = New System.Drawing.Size(80, 20)
        Me.txtnro.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 194
        Me.Label1.Text = "Tipo"
        '
        'txt_tipo
        '
        Me.txt_tipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_tipo.Location = New System.Drawing.Point(59, 18)
        Me.txt_tipo.MaxLength = 6
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(47, 20)
        Me.txt_tipo.TabIndex = 1
        '
        'btnbuscar
        '
        Me.btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.Location = New System.Drawing.Point(683, 82)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(105, 26)
        Me.btnbuscar.TabIndex = 8
        Me.btnbuscar.Text = "Filtrar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'txtruc
        '
        Me.txtruc.AllowDrop = True
        Me.txtruc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtruc.Location = New System.Drawing.Point(59, 50)
        Me.txtruc.MaxLength = 20
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(102, 20)
        Me.txtruc.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(644, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 233
        Me.Label12.Text = "Nro. Opera."
        '
        'txtobserva1
        '
        Me.txtobserva1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobserva1.Location = New System.Drawing.Point(709, 21)
        Me.txtobserva1.Name = "txtobserva1"
        Me.txtobserva1.Size = New System.Drawing.Size(77, 20)
        Me.txtobserva1.TabIndex = 234
        '
        'FormGenerarFiltro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 171)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormGenerarFiltro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Filtro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbmes As ComboBox
    Friend WithEvents cmbanho As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblruc As TextBox
    Friend WithEvents lbl_tipo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_serie As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_tipo As TextBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents txtruc As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_reg_nro As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbmesven As ComboBox
    Friend WithEvents cmbañoven As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtobserva1 As TextBox
End Class
