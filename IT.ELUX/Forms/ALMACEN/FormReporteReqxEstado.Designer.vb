<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteReqxEstado
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
        Me.dtpFecDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCentro = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.txt_nomPer = New System.Windows.Forms.TextBox()
        Me.txt_perCod = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbSublineas = New System.Windows.Forms.ComboBox()
        Me.cmbLineas = New System.Windows.Forms.ComboBox()
        Me.cmbArticulo = New System.Windows.Forms.ComboBox()
        Me.txtcodart = New System.Windows.Forms.TextBox()
        Me.txt_codAct = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnBusAct = New System.Windows.Forms.Button()
        Me.txt_nomAct = New System.Windows.Forms.TextBox()
        Me.btnBusPer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde: "
        '
        'dtpFecDesde
        '
        Me.dtpFecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDesde.Location = New System.Drawing.Point(98, 13)
        Me.dtpFecDesde.Name = "dtpFecDesde"
        Me.dtpFecDesde.Size = New System.Drawing.Size(95, 20)
        Me.dtpFecDesde.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta: "
        '
        'dtpFecHasta
        '
        Me.dtpFecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecHasta.Location = New System.Drawing.Point(267, 12)
        Me.dtpFecHasta.Name = "dtpFecHasta"
        Me.dtpFecHasta.Size = New System.Drawing.Size(95, 20)
        Me.dtpFecHasta.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Linea"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Sub Linea"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Articulo"
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Pendiente", "Anulados"})
        Me.cmbEstado.Location = New System.Drawing.Point(378, 180)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(121, 21)
        Me.cmbEstado.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(303, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Estado Doc.:"
        '
        'cmbCentro
        '
        Me.cmbCentro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCentro.FormattingEnabled = True
        Me.cmbCentro.Items.AddRange(New Object() {"", "Pendiente", "Anulados"})
        Me.cmbCentro.Location = New System.Drawing.Point(100, 180)
        Me.cmbCentro.Name = "cmbCentro"
        Me.cmbCentro.Size = New System.Drawing.Size(197, 21)
        Me.cmbCentro.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Centro Costo:"
        '
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(277, 219)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(75, 23)
        Me.btnReporte.TabIndex = 22
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'txt_nomPer
        '
        Me.txt_nomPer.Enabled = False
        Me.txt_nomPer.Location = New System.Drawing.Point(148, 154)
        Me.txt_nomPer.Name = "txt_nomPer"
        Me.txt_nomPer.Size = New System.Drawing.Size(339, 20)
        Me.txt_nomPer.TabIndex = 25
        '
        'txt_perCod
        '
        Me.txt_perCod.Location = New System.Drawing.Point(98, 154)
        Me.txt_perCod.Name = "txt_perCod"
        Me.txt_perCod.Size = New System.Drawing.Size(44, 20)
        Me.txt_perCod.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Solicitante"
        '
        'cmbSublineas
        '
        Me.cmbSublineas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSublineas.FormattingEnabled = True
        Me.cmbSublineas.Location = New System.Drawing.Point(98, 70)
        Me.cmbSublineas.Name = "cmbSublineas"
        Me.cmbSublineas.Size = New System.Drawing.Size(389, 21)
        Me.cmbSublineas.TabIndex = 29
        '
        'cmbLineas
        '
        Me.cmbLineas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLineas.FormattingEnabled = True
        Me.cmbLineas.Location = New System.Drawing.Point(98, 39)
        Me.cmbLineas.Name = "cmbLineas"
        Me.cmbLineas.Size = New System.Drawing.Size(389, 21)
        Me.cmbLineas.TabIndex = 28
        '
        'cmbArticulo
        '
        Me.cmbArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbArticulo.FormattingEnabled = True
        Me.cmbArticulo.Location = New System.Drawing.Point(188, 100)
        Me.cmbArticulo.Name = "cmbArticulo"
        Me.cmbArticulo.Size = New System.Drawing.Size(486, 21)
        Me.cmbArticulo.TabIndex = 27
        '
        'txtcodart
        '
        Me.txtcodart.Location = New System.Drawing.Point(98, 101)
        Me.txtcodart.MaxLength = 8
        Me.txtcodart.Name = "txtcodart"
        Me.txtcodart.Size = New System.Drawing.Size(84, 20)
        Me.txtcodart.TabIndex = 26
        '
        'txt_codAct
        '
        Me.txt_codAct.Location = New System.Drawing.Point(98, 128)
        Me.txt_codAct.MaxLength = 8
        Me.txt_codAct.Name = "txt_codAct"
        Me.txt_codAct.Size = New System.Drawing.Size(84, 20)
        Me.txt_codAct.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(46, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Activo"
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(680, 98)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(32, 23)
        Me.btnbuscar.TabIndex = 33
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnBusAct
        '
        Me.btnBusAct.Location = New System.Drawing.Point(680, 125)
        Me.btnBusAct.Name = "btnBusAct"
        Me.btnBusAct.Size = New System.Drawing.Size(32, 23)
        Me.btnBusAct.TabIndex = 34
        Me.btnBusAct.Text = "..."
        Me.btnBusAct.UseVisualStyleBackColor = True
        '
        'txt_nomAct
        '
        Me.txt_nomAct.Enabled = False
        Me.txt_nomAct.Location = New System.Drawing.Point(188, 128)
        Me.txt_nomAct.Name = "txt_nomAct"
        Me.txt_nomAct.Size = New System.Drawing.Size(486, 20)
        Me.txt_nomAct.TabIndex = 35
        '
        'btnBusPer
        '
        Me.btnBusPer.Location = New System.Drawing.Point(493, 151)
        Me.btnBusPer.Name = "btnBusPer"
        Me.btnBusPer.Size = New System.Drawing.Size(32, 23)
        Me.btnBusPer.TabIndex = 36
        Me.btnBusPer.Text = "..."
        Me.btnBusPer.UseVisualStyleBackColor = True
        '
        'FormReporteReqxEstado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 258)
        Me.Controls.Add(Me.btnBusPer)
        Me.Controls.Add(Me.txt_nomAct)
        Me.Controls.Add(Me.btnBusAct)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.txt_codAct)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbSublineas)
        Me.Controls.Add(Me.cmbLineas)
        Me.Controls.Add(Me.cmbArticulo)
        Me.Controls.Add(Me.txtcodart)
        Me.Controls.Add(Me.txt_nomPer)
        Me.Controls.Add(Me.txt_perCod)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.cmbCentro)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpFecHasta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecDesde)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormReporteReqxEstado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormReporteReqxEstado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFecDesde As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFecHasta As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbCentro As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnReporte As Button
    Friend WithEvents txt_nomPer As TextBox
    Friend WithEvents txt_perCod As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbSublineas As ComboBox
    Friend WithEvents cmbLineas As ComboBox
    Friend WithEvents cmbArticulo As ComboBox
    Friend WithEvents txtcodart As TextBox
    Friend WithEvents txt_codAct As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnBusAct As Button
    Friend WithEvents txt_nomAct As TextBox
    Friend WithEvents btnBusPer As Button
End Class
