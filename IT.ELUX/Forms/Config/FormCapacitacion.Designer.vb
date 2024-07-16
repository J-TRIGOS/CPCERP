<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCapacitacion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cmbReporte = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfecfin = New System.Windows.Forms.DateTimePicker()
        Me.cmbnn = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmbc_costo = New System.Windows.Forms.ComboBox()
        Me.txtc_costo = New System.Windows.Forms.TextBox()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.cmbEst = New System.Windows.Forms.ComboBox()
        Me.txtPerNom = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtactivo = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtArticulo = New System.Windows.Forms.TextBox()
        Me.txtTema = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtNomTema = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPer = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpfecini = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Centro de Costo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.cmbReporte)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpfecfin)
        Me.GroupBox1.Controls.Add(Me.cmbnn)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.cmbc_costo)
        Me.GroupBox1.Controls.Add(Me.txtc_costo)
        Me.GroupBox1.Controls.Add(Me.cmbTipo)
        Me.GroupBox1.Controls.Add(Me.cmbEst)
        Me.GroupBox1.Controls.Add(Me.txtPerNom)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.txtactivo)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.txtArticulo)
        Me.GroupBox1.Controls.Add(Me.txtTema)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.txtNomTema)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtPer)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpfecini)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 339)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(167, 293)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(80, 17)
        Me.CheckBox1.TabIndex = 127
        Me.CheckBox1.Text = "Capacitado"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'cmbReporte
        '
        Me.cmbReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReporte.FormattingEnabled = True
        Me.cmbReporte.Items.AddRange(New Object() {"PRODUCCION", "R.R.H.H"})
        Me.cmbReporte.Location = New System.Drawing.Point(122, 265)
        Me.cmbReporte.Name = "cmbReporte"
        Me.cmbReporte.Size = New System.Drawing.Size(219, 21)
        Me.cmbReporte.TabIndex = 125
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Reporte :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Hasta"
        '
        'dtpfecfin
        '
        Me.dtpfecfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecfin.Location = New System.Drawing.Point(282, 39)
        Me.dtpfecfin.Name = "dtpfecfin"
        Me.dtpfecfin.Size = New System.Drawing.Size(96, 20)
        Me.dtpfecfin.TabIndex = 123
        '
        'cmbnn
        '
        Me.cmbnn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbnn.FormattingEnabled = True
        Me.cmbnn.Items.AddRange(New Object() {"", "EMPLEADO", "OBRERO"})
        Me.cmbnn.Location = New System.Drawing.Point(122, 237)
        Me.cmbnn.Name = "cmbnn"
        Me.cmbnn.Size = New System.Drawing.Size(219, 21)
        Me.cmbnn.TabIndex = 121
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 240)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(93, 13)
        Me.Label25.TabIndex = 122
        Me.Label25.Text = "Tipo de Personal :"
        '
        'cmbc_costo
        '
        Me.cmbc_costo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmbc_costo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbc_costo.FormattingEnabled = True
        Me.cmbc_costo.Location = New System.Drawing.Point(167, 150)
        Me.cmbc_costo.Name = "cmbc_costo"
        Me.cmbc_costo.Size = New System.Drawing.Size(174, 21)
        Me.cmbc_costo.TabIndex = 120
        '
        'txtc_costo
        '
        Me.txtc_costo.BackColor = System.Drawing.SystemColors.Window
        Me.txtc_costo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtc_costo.Location = New System.Drawing.Point(121, 151)
        Me.txtc_costo.Name = "txtc_costo"
        Me.txtc_costo.Size = New System.Drawing.Size(44, 20)
        Me.txtc_costo.TabIndex = 119
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"INDUCCION", "CAPACITACION", "CHARLA", "ENTRENAMIENTO", "SIMULACRO DE EMERGENCIA"})
        Me.cmbTipo.Location = New System.Drawing.Point(122, 209)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(219, 21)
        Me.cmbTipo.TabIndex = 118
        '
        'cmbEst
        '
        Me.cmbEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEst.FormattingEnabled = True
        Me.cmbEst.Items.AddRange(New Object() {"Proceso", "Anulado", "Finalizado"})
        Me.cmbEst.Location = New System.Drawing.Point(122, 180)
        Me.cmbEst.Name = "cmbEst"
        Me.cmbEst.Size = New System.Drawing.Size(219, 21)
        Me.cmbEst.TabIndex = 78
        '
        'txtPerNom
        '
        Me.txtPerNom.Location = New System.Drawing.Point(181, 123)
        Me.txtPerNom.Name = "txtPerNom"
        Me.txtPerNom.ReadOnly = True
        Me.txtPerNom.Size = New System.Drawing.Size(160, 20)
        Me.txtPerNom.TabIndex = 77
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(343, 122)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(35, 23)
        Me.Button5.TabIndex = 76
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtactivo
        '
        Me.txtactivo.Location = New System.Drawing.Point(121, 95)
        Me.txtactivo.Name = "txtactivo"
        Me.txtactivo.Size = New System.Drawing.Size(58, 20)
        Me.txtactivo.TabIndex = 75
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(343, 94)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 23)
        Me.Button4.TabIndex = 74
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtArticulo
        '
        Me.txtArticulo.Location = New System.Drawing.Point(181, 95)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.ReadOnly = True
        Me.txtArticulo.Size = New System.Drawing.Size(160, 20)
        Me.txtArticulo.TabIndex = 73
        '
        'txtTema
        '
        Me.txtTema.Location = New System.Drawing.Point(121, 67)
        Me.txtTema.Name = "txtTema"
        Me.txtTema.Size = New System.Drawing.Size(38, 20)
        Me.txtTema.TabIndex = 72
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(343, 66)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 23)
        Me.Button3.TabIndex = 71
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtNomTema
        '
        Me.txtNomTema.Location = New System.Drawing.Point(161, 67)
        Me.txtNomTema.Name = "txtNomTema"
        Me.txtNomTema.ReadOnly = True
        Me.txtNomTema.Size = New System.Drawing.Size(180, 20)
        Me.txtNomTema.TabIndex = 70
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Tipo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Est:"
        '
        'txtPer
        '
        Me.txtPer.Location = New System.Drawing.Point(121, 123)
        Me.txtPer.Name = "txtPer"
        Me.txtPer.Size = New System.Drawing.Size(58, 20)
        Me.txtPer.TabIndex = 63
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Capacitado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Activo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Tema:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Fecha:"
        '
        'dtpfecini
        '
        Me.dtpfecini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecini.Location = New System.Drawing.Point(122, 40)
        Me.dtpfecini.Name = "dtpfecini"
        Me.dtpfecini.Size = New System.Drawing.Size(96, 20)
        Me.dtpfecini.TabIndex = 56
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(168, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormCapacitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 353)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormCapacitacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCapacitacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtTema As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents txtNomTema As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPer As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpfecini As DateTimePicker
    Friend WithEvents txtactivo As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents txtArticulo As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents txtPerNom As TextBox
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents cmbEst As ComboBox
    Friend WithEvents cmbc_costo As ComboBox
    Friend WithEvents txtc_costo As TextBox
    Friend WithEvents cmbnn As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpfecfin As DateTimePicker
    Friend WithEvents cmbReporte As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
