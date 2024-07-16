<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsumoPersonal
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
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbdni = New System.Windows.Forms.ComboBox()
        Me.txtPersonal = New System.Windows.Forms.TextBox()
        Me.cmbCco = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bntReporte = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbSublineas = New System.Windows.Forms.ComboBox()
        Me.cmbLineas = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbArticulo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcodart = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'dtpFecIni
        '
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIni.Location = New System.Drawing.Point(33, 44)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(84, 20)
        Me.dtpFecIni.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha Inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Final"
        '
        'dtpFecFin
        '
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(137, 44)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(84, 20)
        Me.dtpFecFin.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Personal"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(568, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 23)
        Me.Button1.TabIndex = 104
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbdni
        '
        Me.cmbdni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdni.FormattingEnabled = True
        Me.cmbdni.Location = New System.Drawing.Point(186, 78)
        Me.cmbdni.Name = "cmbdni"
        Me.cmbdni.Size = New System.Drawing.Size(376, 21)
        Me.cmbdni.TabIndex = 103
        '
        'txtPersonal
        '
        Me.txtPersonal.Location = New System.Drawing.Point(96, 78)
        Me.txtPersonal.Name = "txtPersonal"
        Me.txtPersonal.Size = New System.Drawing.Size(84, 20)
        Me.txtPersonal.TabIndex = 102
        '
        'cmbCco
        '
        Me.cmbCco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCco.FormattingEnabled = True
        Me.cmbCco.Location = New System.Drawing.Point(96, 198)
        Me.cmbCco.Name = "cmbCco"
        Me.cmbCco.Size = New System.Drawing.Size(164, 21)
        Me.cmbCco.TabIndex = 107
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "C. Costo"
        '
        'bntReporte
        '
        Me.bntReporte.Location = New System.Drawing.Point(320, 234)
        Me.bntReporte.Name = "bntReporte"
        Me.bntReporte.Size = New System.Drawing.Size(75, 23)
        Me.bntReporte.TabIndex = 108
        Me.bntReporte.Text = "Reporte"
        Me.bntReporte.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(678, 171)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(32, 23)
        Me.btnbuscar.TabIndex = 116
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Linea / Sublin :"
        '
        'cmbSublineas
        '
        Me.cmbSublineas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSublineas.FormattingEnabled = True
        Me.cmbSublineas.Location = New System.Drawing.Point(96, 141)
        Me.cmbSublineas.Name = "cmbSublineas"
        Me.cmbSublineas.Size = New System.Drawing.Size(389, 21)
        Me.cmbSublineas.TabIndex = 114
        '
        'cmbLineas
        '
        Me.cmbLineas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLineas.FormattingEnabled = True
        Me.cmbLineas.Location = New System.Drawing.Point(96, 110)
        Me.cmbLineas.Name = "cmbLineas"
        Me.cmbLineas.Size = New System.Drawing.Size(389, 21)
        Me.cmbLineas.TabIndex = 112
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Sublinea"
        '
        'cmbArticulo
        '
        Me.cmbArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbArticulo.FormattingEnabled = True
        Me.cmbArticulo.Location = New System.Drawing.Point(186, 171)
        Me.cmbArticulo.Name = "cmbArticulo"
        Me.cmbArticulo.Size = New System.Drawing.Size(486, 21)
        Me.cmbArticulo.TabIndex = 111
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "Codigo"
        '
        'txtcodart
        '
        Me.txtcodart.Location = New System.Drawing.Point(96, 172)
        Me.txtcodart.MaxLength = 8
        Me.txtcodart.Name = "txtcodart"
        Me.txtcodart.Size = New System.Drawing.Size(84, 20)
        Me.txtcodart.TabIndex = 109
        '
        'FormConsumoPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 277)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbSublineas)
        Me.Controls.Add(Me.cmbLineas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbArticulo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtcodart)
        Me.Controls.Add(Me.bntReporte)
        Me.Controls.Add(Me.cmbCco)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbdni)
        Me.Controls.Add(Me.txtPersonal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecFin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFecIni)
        Me.Name = "FormConsumoPersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormConsumoPersonal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpFecIni As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFecFin As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbdni As ComboBox
    Friend WithEvents txtPersonal As TextBox
    Friend WithEvents cmbCco As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents bntReporte As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbSublineas As ComboBox
    Friend WithEvents cmbLineas As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbArticulo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcodart As TextBox
End Class
