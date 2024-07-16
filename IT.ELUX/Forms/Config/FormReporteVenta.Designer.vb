<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteVenta
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
        Me.txtnro1 = New System.Windows.Forms.TextBox()
        Me.txtoc1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcliente1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnro2 = New System.Windows.Forms.TextBox()
        Me.txtoc2 = New System.Windows.Forms.TextBox()
        Me.txtcliente2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboest = New System.Windows.Forms.ComboBox()
        Me.cboest2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpfec1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpfec2 = New System.Windows.Forms.DateTimePicker()
        Me.txtarticulo2 = New System.Windows.Forms.TextBox()
        Me.txtarticulo1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtvend1 = New System.Windows.Forms.TextBox()
        Me.txtvend = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmblinea2 = New System.Windows.Forms.ComboBox()
        Me.cmblinea1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbvistaprod = New System.Windows.Forms.RadioButton()
        Me.rdbvistaventa = New System.Windows.Forms.RadioButton()
        Me.cmbtven2 = New System.Windows.Forms.ComboBox()
        Me.cmbtven1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero de Documento"
        '
        'txtnro1
        '
        Me.txtnro1.Location = New System.Drawing.Point(126, 20)
        Me.txtnro1.Name = "txtnro1"
        Me.txtnro1.Size = New System.Drawing.Size(147, 20)
        Me.txtnro1.TabIndex = 1
        '
        'txtoc1
        '
        Me.txtoc1.Location = New System.Drawing.Point(126, 46)
        Me.txtoc1.Name = "txtoc1"
        Me.txtoc1.Size = New System.Drawing.Size(147, 20)
        Me.txtoc1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Numero de O/C"
        '
        'txtcliente1
        '
        Me.txtcliente1.Location = New System.Drawing.Point(126, 72)
        Me.txtcliente1.Name = "txtcliente1"
        Me.txtcliente1.Size = New System.Drawing.Size(147, 20)
        Me.txtcliente1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cliente"
        '
        'txtnro2
        '
        Me.txtnro2.Location = New System.Drawing.Point(329, 20)
        Me.txtnro2.Name = "txtnro2"
        Me.txtnro2.Size = New System.Drawing.Size(147, 20)
        Me.txtnro2.TabIndex = 2
        '
        'txtoc2
        '
        Me.txtoc2.Location = New System.Drawing.Point(329, 46)
        Me.txtoc2.Name = "txtoc2"
        Me.txtoc2.Size = New System.Drawing.Size(147, 20)
        Me.txtoc2.TabIndex = 4
        '
        'txtcliente2
        '
        Me.txtcliente2.Location = New System.Drawing.Point(329, 72)
        Me.txtcliente2.Name = "txtcliente2"
        Me.txtcliente2.Size = New System.Drawing.Size(147, 20)
        Me.txtcliente2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(279, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Estado"
        '
        'cboest
        '
        Me.cboest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboest.FormattingEnabled = True
        Me.cboest.Items.AddRange(New Object() {"Pendiente", "Cerrado", "Despachado"})
        Me.cboest.Location = New System.Drawing.Point(126, 98)
        Me.cboest.Name = "cboest"
        Me.cboest.Size = New System.Drawing.Size(147, 21)
        Me.cboest.TabIndex = 6
        '
        'cboest2
        '
        Me.cboest2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboest2.FormattingEnabled = True
        Me.cboest2.Items.AddRange(New Object() {"Pendiente", "Cerrado", "Despachado"})
        Me.cboest2.Location = New System.Drawing.Point(329, 98)
        Me.cboest2.Name = "cboest2"
        Me.cboest2.Size = New System.Drawing.Size(147, 21)
        Me.cboest2.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(83, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Fecha"
        '
        'dtpfec1
        '
        Me.dtpfec1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec1.Location = New System.Drawing.Point(126, 125)
        Me.dtpfec1.Name = "dtpfec1"
        Me.dtpfec1.Size = New System.Drawing.Size(147, 20)
        Me.dtpfec1.TabIndex = 8
        '
        'dtpfec2
        '
        Me.dtpfec2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec2.Location = New System.Drawing.Point(329, 125)
        Me.dtpfec2.Name = "dtpfec2"
        Me.dtpfec2.Size = New System.Drawing.Size(147, 20)
        Me.dtpfec2.TabIndex = 9
        '
        'txtarticulo2
        '
        Me.txtarticulo2.Location = New System.Drawing.Point(329, 151)
        Me.txtarticulo2.Name = "txtarticulo2"
        Me.txtarticulo2.Size = New System.Drawing.Size(147, 20)
        Me.txtarticulo2.TabIndex = 11
        '
        'txtarticulo1
        '
        Me.txtarticulo1.Location = New System.Drawing.Point(126, 151)
        Me.txtarticulo1.Name = "txtarticulo1"
        Me.txtarticulo1.Size = New System.Drawing.Size(147, 20)
        Me.txtarticulo1.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(78, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Articulo"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(279, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(218, 260)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 20
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(312, 260)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 21
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(482, 150)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 23)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(482, 69)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 23)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(279, 175)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(35, 23)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtvend1
        '
        Me.txtvend1.Location = New System.Drawing.Point(329, 177)
        Me.txtvend1.Name = "txtvend1"
        Me.txtvend1.Size = New System.Drawing.Size(147, 20)
        Me.txtvend1.TabIndex = 25
        '
        'txtvend
        '
        Me.txtvend.Location = New System.Drawing.Point(126, 177)
        Me.txtvend.Name = "txtvend"
        Me.txtvend.Size = New System.Drawing.Size(147, 20)
        Me.txtvend.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(67, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Vendedor"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(482, 177)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(35, 23)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "..."
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(87, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Linea"
        '
        'cmblinea2
        '
        Me.cmblinea2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblinea2.FormattingEnabled = True
        Me.cmblinea2.Items.AddRange(New Object() {"", "0100- Fibra Carton", "0200- Hojalata"})
        Me.cmblinea2.Location = New System.Drawing.Point(329, 206)
        Me.cmblinea2.Name = "cmblinea2"
        Me.cmblinea2.Size = New System.Drawing.Size(147, 21)
        Me.cmblinea2.TabIndex = 33
        '
        'cmblinea1
        '
        Me.cmblinea1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblinea1.FormattingEnabled = True
        Me.cmblinea1.Items.AddRange(New Object() {"", "0100- Fibra Carton", "0200- Hojalata"})
        Me.cmblinea1.Location = New System.Drawing.Point(126, 206)
        Me.cmblinea1.Name = "cmblinea1"
        Me.cmblinea1.Size = New System.Drawing.Size(147, 21)
        Me.cmblinea1.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbvistaprod)
        Me.GroupBox1.Controls.Add(Me.rdbvistaventa)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 257)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(168, 44)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'rdbvistaprod
        '
        Me.rdbvistaprod.AutoSize = True
        Me.rdbvistaprod.Location = New System.Drawing.Point(78, 20)
        Me.rdbvistaprod.Name = "rdbvistaprod"
        Me.rdbvistaprod.Size = New System.Drawing.Size(57, 17)
        Me.rdbvistaprod.TabIndex = 1
        Me.rdbvistaprod.Text = "Vista 2"
        Me.rdbvistaprod.UseVisualStyleBackColor = True
        '
        'rdbvistaventa
        '
        Me.rdbvistaventa.AutoSize = True
        Me.rdbvistaventa.Checked = True
        Me.rdbvistaventa.Location = New System.Drawing.Point(7, 20)
        Me.rdbvistaventa.Name = "rdbvistaventa"
        Me.rdbvistaventa.Size = New System.Drawing.Size(57, 17)
        Me.rdbvistaventa.TabIndex = 0
        Me.rdbvistaventa.TabStop = True
        Me.rdbvistaventa.Text = "Vista 1"
        Me.rdbvistaventa.UseVisualStyleBackColor = True
        '
        'cmbtven2
        '
        Me.cmbtven2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtven2.FormattingEnabled = True
        Me.cmbtven2.Items.AddRange(New Object() {"", "NACIONAL", "EXPORTACION"})
        Me.cmbtven2.Location = New System.Drawing.Point(329, 233)
        Me.cmbtven2.Name = "cmbtven2"
        Me.cmbtven2.Size = New System.Drawing.Size(147, 21)
        Me.cmbtven2.TabIndex = 37
        '
        'cmbtven1
        '
        Me.cmbtven1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtven1.FormattingEnabled = True
        Me.cmbtven1.Items.AddRange(New Object() {"", "NACIONAL", "EXPORTACION"})
        Me.cmbtven1.Location = New System.Drawing.Point(126, 233)
        Me.cmbtven1.Name = "cmbtven1"
        Me.cmbtven1.Size = New System.Drawing.Size(147, 21)
        Me.cmbtven1.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(61, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Tipo Venta"
        '
        'FormReporteVenta
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 308)
        Me.Controls.Add(Me.cmbtven2)
        Me.Controls.Add(Me.cmbtven1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmblinea2)
        Me.Controls.Add(Me.cmblinea1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtvend1)
        Me.Controls.Add(Me.txtvend)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtarticulo2)
        Me.Controls.Add(Me.txtarticulo1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpfec2)
        Me.Controls.Add(Me.dtpfec1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboest2)
        Me.Controls.Add(Me.cboest)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtcliente2)
        Me.Controls.Add(Me.txtoc2)
        Me.Controls.Add(Me.txtnro2)
        Me.Controls.Add(Me.txtcliente1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtoc1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnro1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormReporteVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormReporteVenta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtnro1 As TextBox
    Friend WithEvents txtoc1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcliente1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnro2 As TextBox
    Friend WithEvents txtoc2 As TextBox
    Friend WithEvents txtcliente2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cboest As ComboBox
    Friend WithEvents cboest2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpfec1 As DateTimePicker
    Friend WithEvents dtpfec2 As DateTimePicker
    Friend WithEvents txtarticulo2 As TextBox
    Friend WithEvents txtarticulo1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnreporte As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents txtvend1 As TextBox
    Friend WithEvents txtvend As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents cmblinea2 As ComboBox
    Friend WithEvents cmblinea1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbvistaprod As RadioButton
    Friend WithEvents rdbvistaventa As RadioButton
    Friend WithEvents cmbtven2 As ComboBox
    Friend WithEvents cmbtven1 As ComboBox
    Friend WithEvents Label9 As Label
End Class
