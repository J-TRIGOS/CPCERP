<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRptStockFecha
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
        Me.dtpfin = New System.Windows.Forms.DateTimePicker()
        Me.dtpini = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbalmacen = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsublinea = New System.Windows.Forms.TextBox()
        Me.txtnomsublinea = New System.Windows.Forms.TextBox()
        Me.txtnomlinea = New System.Windows.Forms.TextBox()
        Me.txtlinea = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbstk = New System.Windows.Forms.ComboBox()
        Me.chkcontabilidad = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmblinea = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lbldescripcion = New System.Windows.Forms.TextBox()
        Me.txtcodart = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblfam_cod = New System.Windows.Forms.TextBox()
        Me.txtfam_Cod = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpini2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpfin2 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtnomlinea2 = New System.Windows.Forms.TextBox()
        Me.txtsublinea2 = New System.Windows.Forms.TextBox()
        Me.txtlinea2 = New System.Windows.Forms.TextBox()
        Me.txtnomsublinea2 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpfin
        '
        Me.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfin.Location = New System.Drawing.Point(250, 18)
        Me.dtpfin.Name = "dtpfin"
        Me.dtpfin.Size = New System.Drawing.Size(94, 20)
        Me.dtpfin.TabIndex = 97
        '
        'dtpini
        '
        Me.dtpini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpini.Location = New System.Drawing.Point(82, 18)
        Me.dtpini.Name = "dtpini"
        Me.dtpini.Size = New System.Drawing.Size(94, 20)
        Me.dtpini.TabIndex = 96
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(184, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "Fecha Fin :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "Fecha Inicio:"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(74, 234)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 36)
        Me.Button9.TabIndex = 98
        Me.Button9.Text = "Reporte"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(169, 234)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 36)
        Me.Button10.TabIndex = 99
        Me.Button10.Text = "Salir"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Almacen:"
        '
        'cmbalmacen
        '
        Me.cmbalmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbalmacen.Items.AddRange(New Object() {"", "0001-Torres", "0002-Eloy Ureta", "0003-Lurin"})
        Me.cmbalmacen.Location = New System.Drawing.Point(82, 44)
        Me.cmbalmacen.Name = "cmbalmacen"
        Me.cmbalmacen.Size = New System.Drawing.Size(202, 21)
        Me.cmbalmacen.TabIndex = 101
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Sub Linea:"
        '
        'txtsublinea
        '
        Me.txtsublinea.Location = New System.Drawing.Point(82, 97)
        Me.txtsublinea.MaxLength = 4
        Me.txtsublinea.Name = "txtsublinea"
        Me.txtsublinea.Size = New System.Drawing.Size(49, 20)
        Me.txtsublinea.TabIndex = 103
        '
        'txtnomsublinea
        '
        Me.txtnomsublinea.Location = New System.Drawing.Point(137, 97)
        Me.txtnomsublinea.MaxLength = 4
        Me.txtnomsublinea.Name = "txtnomsublinea"
        Me.txtnomsublinea.ReadOnly = True
        Me.txtnomsublinea.Size = New System.Drawing.Size(208, 20)
        Me.txtnomsublinea.TabIndex = 104
        '
        'txtnomlinea
        '
        Me.txtnomlinea.Location = New System.Drawing.Point(136, 71)
        Me.txtnomlinea.MaxLength = 4
        Me.txtnomlinea.Name = "txtnomlinea"
        Me.txtnomlinea.ReadOnly = True
        Me.txtnomlinea.Size = New System.Drawing.Size(208, 20)
        Me.txtnomlinea.TabIndex = 107
        '
        'txtlinea
        '
        Me.txtlinea.Location = New System.Drawing.Point(81, 71)
        Me.txtlinea.MaxLength = 4
        Me.txtlinea.Name = "txtlinea"
        Me.txtlinea.Size = New System.Drawing.Size(49, 20)
        Me.txtlinea.TabIndex = 106
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Linea:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Stock 0:"
        '
        'cmbstk
        '
        Me.cmbstk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbstk.FormattingEnabled = True
        Me.cmbstk.Items.AddRange(New Object() {"", "NO", "SI"})
        Me.cmbstk.Location = New System.Drawing.Point(81, 132)
        Me.cmbstk.Name = "cmbstk"
        Me.cmbstk.Size = New System.Drawing.Size(121, 21)
        Me.cmbstk.TabIndex = 109
        '
        'chkcontabilidad
        '
        Me.chkcontabilidad.AutoSize = True
        Me.chkcontabilidad.Location = New System.Drawing.Point(218, 134)
        Me.chkcontabilidad.Name = "chkcontabilidad"
        Me.chkcontabilidad.Size = New System.Drawing.Size(84, 17)
        Me.chkcontabilidad.TabIndex = 110
        Me.chkcontabilidad.Text = "Contabilidad"
        Me.chkcontabilidad.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "Linea:"
        '
        'cmblinea
        '
        Me.cmblinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblinea.Enabled = False
        Me.cmblinea.FormattingEnabled = True
        Me.cmblinea.Items.AddRange(New Object() {"", "01-FIBRA", "02-P.T", "03-TWO"})
        Me.cmblinea.Location = New System.Drawing.Point(81, 165)
        Me.cmblinea.Name = "cmblinea"
        Me.cmblinea.Size = New System.Drawing.Size(121, 21)
        Me.cmblinea.TabIndex = 112
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(218, 192)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(58, 17)
        Me.CheckBox1.TabIndex = 113
        Me.CheckBox1.Text = "Familia"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"", "01-FIBRA", "02-P.T", "03-TWO"})
        Me.ComboBox1.Location = New System.Drawing.Point(82, 192)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 115
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "Familia:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(384, 317)
        Me.TabControl1.TabIndex = 116
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.dtpini)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.dtpfin)
        Me.TabPage1.Controls.Add(Me.cmblinea)
        Me.TabPage1.Controls.Add(Me.Button10)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Button9)
        Me.TabPage1.Controls.Add(Me.chkcontabilidad)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cmbstk)
        Me.TabPage1.Controls.Add(Me.cmbalmacen)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtnomlinea)
        Me.TabPage1.Controls.Add(Me.txtsublinea)
        Me.TabPage1.Controls.Add(Me.txtlinea)
        Me.TabPage1.Controls.Add(Me.txtnomsublinea)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(376, 291)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Almacen"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lbldescripcion)
        Me.TabPage2.Controls.Add(Me.txtcodart)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.lblfam_cod)
        Me.TabPage2.Controls.Add(Me.txtfam_Cod)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.dtpini2)
        Me.TabPage2.Controls.Add(Me.dtpfin2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.txtnomlinea2)
        Me.TabPage2.Controls.Add(Me.txtsublinea2)
        Me.TabPage2.Controls.Add(Me.txtlinea2)
        Me.TabPage2.Controls.Add(Me.txtnomsublinea2)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(376, 291)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Contabilidad"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lbldescripcion
        '
        Me.lbldescripcion.BackColor = System.Drawing.Color.Gainsboro
        Me.lbldescripcion.Location = New System.Drawing.Point(155, 124)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.ReadOnly = True
        Me.lbldescripcion.Size = New System.Drawing.Size(204, 20)
        Me.lbldescripcion.TabIndex = 156
        '
        'txtcodart
        '
        Me.txtcodart.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodart.Location = New System.Drawing.Point(81, 124)
        Me.txtcodart.MaxLength = 8
        Me.txtcodart.Name = "txtcodart"
        Me.txtcodart.Size = New System.Drawing.Size(68, 20)
        Me.txtcodart.TabIndex = 151
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 155
        Me.Label9.Text = "Articulo:"
        '
        'lblfam_cod
        '
        Me.lblfam_cod.BackColor = System.Drawing.Color.Gainsboro
        Me.lblfam_cod.Location = New System.Drawing.Point(115, 150)
        Me.lblfam_cod.Name = "lblfam_cod"
        Me.lblfam_cod.ReadOnly = True
        Me.lblfam_cod.Size = New System.Drawing.Size(244, 20)
        Me.lblfam_cod.TabIndex = 154
        '
        'txtfam_Cod
        '
        Me.txtfam_Cod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfam_Cod.Location = New System.Drawing.Point(81, 150)
        Me.txtfam_Cod.MaxLength = 3
        Me.txtfam_Cod.Name = "txtfam_Cod"
        Me.txtfam_Cod.Size = New System.Drawing.Size(33, 20)
        Me.txtfam_Cod.TabIndex = 152
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(37, 154)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 153
        Me.Label12.Text = "Familia"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Fecha Inicio:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(184, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 116
        Me.Label8.Text = "Fecha Fin :"
        '
        'dtpini2
        '
        Me.dtpini2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpini2.Location = New System.Drawing.Point(82, 41)
        Me.dtpini2.Name = "dtpini2"
        Me.dtpini2.Size = New System.Drawing.Size(94, 20)
        Me.dtpini2.TabIndex = 118
        '
        'dtpfin2
        '
        Me.dtpfin2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfin2.Location = New System.Drawing.Point(250, 41)
        Me.dtpfin2.Name = "dtpfin2"
        Me.dtpfin2.Size = New System.Drawing.Size(94, 20)
        Me.dtpfin2.TabIndex = 119
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(187, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 36)
        Me.Button1.TabIndex = 121
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(92, 206)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 36)
        Me.Button2.TabIndex = 120
        Me.Button2.Text = "Reporte"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(18, 101)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 124
        Me.Label15.Text = "Sub Linea:"
        '
        'txtnomlinea2
        '
        Me.txtnomlinea2.Location = New System.Drawing.Point(135, 72)
        Me.txtnomlinea2.MaxLength = 4
        Me.txtnomlinea2.Name = "txtnomlinea2"
        Me.txtnomlinea2.ReadOnly = True
        Me.txtnomlinea2.Size = New System.Drawing.Size(208, 20)
        Me.txtnomlinea2.TabIndex = 129
        '
        'txtsublinea2
        '
        Me.txtsublinea2.Location = New System.Drawing.Point(81, 98)
        Me.txtsublinea2.MaxLength = 4
        Me.txtsublinea2.Name = "txtsublinea2"
        Me.txtsublinea2.Size = New System.Drawing.Size(49, 20)
        Me.txtsublinea2.TabIndex = 125
        '
        'txtlinea2
        '
        Me.txtlinea2.Location = New System.Drawing.Point(80, 72)
        Me.txtlinea2.MaxLength = 4
        Me.txtlinea2.Name = "txtlinea2"
        Me.txtlinea2.Size = New System.Drawing.Size(49, 20)
        Me.txtlinea2.TabIndex = 128
        '
        'txtnomsublinea2
        '
        Me.txtnomsublinea2.Location = New System.Drawing.Point(136, 98)
        Me.txtnomsublinea2.MaxLength = 4
        Me.txtnomsublinea2.Name = "txtnomsublinea2"
        Me.txtnomsublinea2.ReadOnly = True
        Me.txtnomsublinea2.Size = New System.Drawing.Size(208, 20)
        Me.txtnomsublinea2.TabIndex = 126
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(40, 75)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 13)
        Me.Label16.TabIndex = 127
        Me.Label16.Text = "Linea:"
        '
        'FormRptStockFecha
        '
        Me.AcceptButton = Me.Button9
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 341)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRptStockFecha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptStockFecha"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtpfin As DateTimePicker
    Friend WithEvents dtpini As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbalmacen As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtsublinea As TextBox
    Friend WithEvents txtnomsublinea As TextBox
    Friend WithEvents txtnomlinea As TextBox
    Friend WithEvents txtlinea As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbstk As ComboBox
    Friend WithEvents chkcontabilidad As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmblinea As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpini2 As DateTimePicker
    Friend WithEvents dtpfin2 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txtnomlinea2 As TextBox
    Friend WithEvents txtsublinea2 As TextBox
    Friend WithEvents txtlinea2 As TextBox
    Friend WithEvents txtnomsublinea2 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtcodart As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblfam_cod As TextBox
    Friend WithEvents txtfam_Cod As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lbldescripcion As TextBox
End Class
