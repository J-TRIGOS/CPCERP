<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptRemuPla
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
        Me.cmbsit2 = New System.Windows.Forms.ComboBox()
        Me.cmbsit1 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtnomper2 = New System.Windows.Forms.TextBox()
        Me.txtdni2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtnomper = New System.Windows.Forms.TextBox()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmbtipo2 = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpfec_ini4 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.cmbc_costo3 = New System.Windows.Forms.ComboBox()
        Me.txtcontrato_prdo4 = New System.Windows.Forms.TextBox()
        Me.cmbc_costo4 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtc_costo3 = New System.Windows.Forms.TextBox()
        Me.dtpfec_ini3 = New System.Windows.Forms.DateTimePicker()
        Me.txtc_costo4 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.txtcontrato_prdo3 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbsit2
        '
        Me.cmbsit2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsit2.FormattingEnabled = True
        Me.cmbsit2.Items.AddRange(New Object() {"", "Empleado", "Obrero"})
        Me.cmbsit2.Location = New System.Drawing.Point(122, 223)
        Me.cmbsit2.Name = "cmbsit2"
        Me.cmbsit2.Size = New System.Drawing.Size(127, 21)
        Me.cmbsit2.TabIndex = 159
        '
        'cmbsit1
        '
        Me.cmbsit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsit1.FormattingEnabled = True
        Me.cmbsit1.Items.AddRange(New Object() {"", "Empleado", "Obrero"})
        Me.cmbsit1.Location = New System.Drawing.Point(122, 197)
        Me.cmbsit1.Name = "cmbsit1"
        Me.cmbsit1.Size = New System.Drawing.Size(127, 21)
        Me.cmbsit1.TabIndex = 158
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(49, 226)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 157
        Me.Label13.Text = "Situacion 2:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(49, 200)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 156
        Me.Label14.Text = "Situacion 1:"
        '
        'txtnomper2
        '
        Me.txtnomper2.Location = New System.Drawing.Point(194, 171)
        Me.txtnomper2.Name = "txtnomper2"
        Me.txtnomper2.ReadOnly = True
        Me.txtnomper2.Size = New System.Drawing.Size(202, 20)
        Me.txtnomper2.TabIndex = 155
        '
        'txtdni2
        '
        Me.txtdni2.Location = New System.Drawing.Point(122, 171)
        Me.txtdni2.MaxLength = 8
        Me.txtdni2.Name = "txtdni2"
        Me.txtdni2.Size = New System.Drawing.Size(66, 20)
        Me.txtdni2.TabIndex = 153
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(54, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 154
        Me.Label12.Text = "Persona 2:"
        '
        'txtnomper
        '
        Me.txtnomper.Location = New System.Drawing.Point(193, 145)
        Me.txtnomper.Name = "txtnomper"
        Me.txtnomper.ReadOnly = True
        Me.txtnomper.Size = New System.Drawing.Size(202, 20)
        Me.txtnomper.TabIndex = 152
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(122, 145)
        Me.txtdni.MaxLength = 8
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(66, 20)
        Me.txtdni.TabIndex = 150
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(54, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 151
        Me.Label11.Text = "Persona 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "Codigo Pago"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(122, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 36)
        Me.Button2.TabIndex = 148
        Me.Button2.Text = "Reporte"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmbtipo2
        '
        Me.cmbtipo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipo2.FormattingEnabled = True
        Me.cmbtipo2.Items.AddRange(New Object() {"", "MEN-MENSUAL", "GRA-GRATIFICACION"})
        Me.cmbtipo2.Location = New System.Drawing.Point(122, 12)
        Me.cmbtipo2.Name = "cmbtipo2"
        Me.cmbtipo2.Size = New System.Drawing.Size(127, 21)
        Me.cmbtipo2.TabIndex = 133
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(216, 257)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 36)
        Me.Button5.TabIndex = 149
        Me.Button5.Text = "Salir"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 138
        Me.Label7.Text = "Centro Costo1 :"
        '
        'dtpfec_ini4
        '
        Me.dtpfec_ini4.Checked = False
        Me.dtpfec_ini4.Enabled = False
        Me.dtpfec_ini4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ini4.Location = New System.Drawing.Point(231, 117)
        Me.dtpfec_ini4.Name = "dtpfec_ini4"
        Me.dtpfec_ini4.ShowCheckBox = True
        Me.dtpfec_ini4.Size = New System.Drawing.Size(98, 20)
        Me.dtpfec_ini4.TabIndex = 147
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 139
        Me.Label8.Text = "Centro Costo2 :"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(188, 117)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(32, 23)
        Me.Button7.TabIndex = 146
        Me.Button7.Text = "..."
        Me.Button7.UseVisualStyleBackColor = True
        '
        'cmbc_costo3
        '
        Me.cmbc_costo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbc_costo3.FormattingEnabled = True
        Me.cmbc_costo3.Location = New System.Drawing.Point(168, 39)
        Me.cmbc_costo3.Name = "cmbc_costo3"
        Me.cmbc_costo3.Size = New System.Drawing.Size(271, 21)
        Me.cmbc_costo3.TabIndex = 135
        '
        'txtcontrato_prdo4
        '
        Me.txtcontrato_prdo4.Location = New System.Drawing.Point(122, 119)
        Me.txtcontrato_prdo4.Name = "txtcontrato_prdo4"
        Me.txtcontrato_prdo4.Size = New System.Drawing.Size(61, 20)
        Me.txtcontrato_prdo4.TabIndex = 145
        '
        'cmbc_costo4
        '
        Me.cmbc_costo4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbc_costo4.FormattingEnabled = True
        Me.cmbc_costo4.Location = New System.Drawing.Point(167, 66)
        Me.cmbc_costo4.Name = "cmbc_costo4"
        Me.cmbc_costo4.Size = New System.Drawing.Size(272, 21)
        Me.cmbc_costo4.TabIndex = 137
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(57, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 144
        Me.Label9.Text = "Periodo 2:"
        '
        'txtc_costo3
        '
        Me.txtc_costo3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtc_costo3.Location = New System.Drawing.Point(122, 40)
        Me.txtc_costo3.MaxLength = 3
        Me.txtc_costo3.Name = "txtc_costo3"
        Me.txtc_costo3.Size = New System.Drawing.Size(40, 20)
        Me.txtc_costo3.TabIndex = 134
        '
        'dtpfec_ini3
        '
        Me.dtpfec_ini3.Checked = False
        Me.dtpfec_ini3.Enabled = False
        Me.dtpfec_ini3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ini3.Location = New System.Drawing.Point(231, 91)
        Me.dtpfec_ini3.Name = "dtpfec_ini3"
        Me.dtpfec_ini3.ShowCheckBox = True
        Me.dtpfec_ini3.Size = New System.Drawing.Size(98, 20)
        Me.dtpfec_ini3.TabIndex = 143
        '
        'txtc_costo4
        '
        Me.txtc_costo4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtc_costo4.Location = New System.Drawing.Point(122, 66)
        Me.txtc_costo4.MaxLength = 3
        Me.txtc_costo4.Name = "txtc_costo4"
        Me.txtc_costo4.Size = New System.Drawing.Size(40, 20)
        Me.txtc_costo4.TabIndex = 136
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(188, 91)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(32, 23)
        Me.Button8.TabIndex = 142
        Me.Button8.Text = "..."
        Me.Button8.UseVisualStyleBackColor = True
        '
        'txtcontrato_prdo3
        '
        Me.txtcontrato_prdo3.Location = New System.Drawing.Point(122, 93)
        Me.txtcontrato_prdo3.Name = "txtcontrato_prdo3"
        Me.txtcontrato_prdo3.Size = New System.Drawing.Size(61, 20)
        Me.txtcontrato_prdo3.TabIndex = 141
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(57, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 140
        Me.Label10.Text = "Periodo 1:"
        '
        'FormRptRemuPla
        '
        Me.AcceptButton = Me.Button2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 305)
        Me.Controls.Add(Me.cmbsit2)
        Me.Controls.Add(Me.cmbsit1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtnomper2)
        Me.Controls.Add(Me.txtdni2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtnomper)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmbtipo2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpfec_ini4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.cmbc_costo3)
        Me.Controls.Add(Me.txtcontrato_prdo4)
        Me.Controls.Add(Me.cmbc_costo4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtc_costo3)
        Me.Controls.Add(Me.dtpfec_ini3)
        Me.Controls.Add(Me.txtc_costo4)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.txtcontrato_prdo3)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRptRemuPla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptRemuPla"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbsit2 As ComboBox
    Friend WithEvents cmbsit1 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtnomper2 As TextBox
    Friend WithEvents txtdni2 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtnomper As TextBox
    Friend WithEvents txtdni As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents cmbtipo2 As ComboBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpfec_ini4 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents cmbc_costo3 As ComboBox
    Friend WithEvents txtcontrato_prdo4 As TextBox
    Friend WithEvents cmbc_costo4 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtc_costo3 As TextBox
    Friend WithEvents dtpfec_ini3 As DateTimePicker
    Friend WithEvents txtc_costo4 As TextBox
    Friend WithEvents Button8 As Button
    Friend WithEvents txtcontrato_prdo3 As TextBox
    Friend WithEvents Label10 As Label
End Class
