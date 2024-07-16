<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Stock_Precio
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
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btndiametro = New System.Windows.Forms.Button()
        Me.dtpfecha2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpfecha1 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.npdaltmax = New System.Windows.Forms.NumericUpDown()
        Me.npdaltmin = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnreporte1 = New System.Windows.Forms.Button()
        Me.dtp2fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.dtp2fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnaltura = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtalchomax = New System.Windows.Forms.NumericUpDown()
        Me.txtlargmax = New System.Windows.Forms.NumericUpDown()
        Me.txtalturamax = New System.Windows.Forms.NumericUpDown()
        Me.txtanchomin = New System.Windows.Forms.NumericUpDown()
        Me.txtlargmin = New System.Windows.Forms.NumericUpDown()
        Me.txtalturamin = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.npdaltmax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdaltmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.txtalchomax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtlargmax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtalturamax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtanchomin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtlargmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtalturamin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(344, 232)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.btnreporte)
        Me.TabPage1.Controls.Add(Me.btndiametro)
        Me.TabPage1.Controls.Add(Me.dtpfecha2)
        Me.TabPage1.Controls.Add(Me.dtpfecha1)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.npdaltmax)
        Me.TabPage1.Controls.Add(Me.npdaltmin)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(336, 206)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Diametro"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(156, 156)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 23)
        Me.btnreporte.TabIndex = 37
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btndiametro
        '
        Me.btndiametro.Location = New System.Drawing.Point(57, 156)
        Me.btndiametro.Name = "btndiametro"
        Me.btndiametro.Size = New System.Drawing.Size(75, 23)
        Me.btndiametro.TabIndex = 36
        Me.btndiametro.Text = "Imprimir"
        Me.btndiametro.UseVisualStyleBackColor = True
        '
        'dtpfecha2
        '
        Me.dtpfecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha2.Location = New System.Drawing.Point(187, 54)
        Me.dtpfecha2.Name = "dtpfecha2"
        Me.dtpfecha2.Size = New System.Drawing.Size(83, 20)
        Me.dtpfecha2.TabIndex = 35
        '
        'dtpfecha1
        '
        Me.dtpfecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha1.Location = New System.Drawing.Point(85, 54)
        Me.dtpfecha1.Name = "dtpfecha1"
        Me.dtpfecha1.Size = New System.Drawing.Size(83, 20)
        Me.dtpfecha1.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(116, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Mínimo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(216, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Máximo"
        '
        'npdaltmax
        '
        Me.npdaltmax.DecimalPlaces = 2
        Me.npdaltmax.Location = New System.Drawing.Point(187, 89)
        Me.npdaltmax.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.npdaltmax.Name = "npdaltmax"
        Me.npdaltmax.Size = New System.Drawing.Size(83, 20)
        Me.npdaltmax.TabIndex = 30
        '
        'npdaltmin
        '
        Me.npdaltmin.DecimalPlaces = 2
        Me.npdaltmin.Location = New System.Drawing.Point(85, 89)
        Me.npdaltmin.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.npdaltmin.Name = "npdaltmin"
        Me.npdaltmin.Size = New System.Drawing.Size(83, 20)
        Me.npdaltmin.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Altura"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnreporte1)
        Me.TabPage2.Controls.Add(Me.dtp2fecha2)
        Me.TabPage2.Controls.Add(Me.dtp2fecha1)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.btnaltura)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtalchomax)
        Me.TabPage2.Controls.Add(Me.txtlargmax)
        Me.TabPage2.Controls.Add(Me.txtalturamax)
        Me.TabPage2.Controls.Add(Me.txtanchomin)
        Me.TabPage2.Controls.Add(Me.txtlargmin)
        Me.TabPage2.Controls.Add(Me.txtalturamin)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(336, 212)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Forma"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnreporte1
        '
        Me.btnreporte1.Location = New System.Drawing.Point(167, 183)
        Me.btnreporte1.Name = "btnreporte1"
        Me.btnreporte1.Size = New System.Drawing.Size(75, 23)
        Me.btnreporte1.TabIndex = 39
        Me.btnreporte1.Text = "Reporte"
        Me.btnreporte1.UseVisualStyleBackColor = True
        '
        'dtp2fecha2
        '
        Me.dtp2fecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2fecha2.Location = New System.Drawing.Point(209, 53)
        Me.dtp2fecha2.Name = "dtp2fecha2"
        Me.dtp2fecha2.Size = New System.Drawing.Size(83, 20)
        Me.dtp2fecha2.TabIndex = 38
        '
        'dtp2fecha1
        '
        Me.dtp2fecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2fecha1.Location = New System.Drawing.Point(107, 53)
        Me.dtp2fecha1.Name = "dtp2fecha1"
        Me.dtp2fecha1.Size = New System.Drawing.Size(83, 20)
        Me.dtp2fecha1.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(51, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Fecha"
        '
        'btnaltura
        '
        Me.btnaltura.Location = New System.Drawing.Point(86, 183)
        Me.btnaltura.Name = "btnaltura"
        Me.btnaltura.Size = New System.Drawing.Size(75, 23)
        Me.btnaltura.TabIndex = 28
        Me.btnaltura.Text = "Imprimir"
        Me.btnaltura.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(119, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Mínimo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(219, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Máximo"
        '
        'txtalchomax
        '
        Me.txtalchomax.DecimalPlaces = 2
        Me.txtalchomax.Location = New System.Drawing.Point(209, 140)
        Me.txtalchomax.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtalchomax.Name = "txtalchomax"
        Me.txtalchomax.Size = New System.Drawing.Size(64, 20)
        Me.txtalchomax.TabIndex = 24
        '
        'txtlargmax
        '
        Me.txtlargmax.DecimalPlaces = 2
        Me.txtlargmax.Location = New System.Drawing.Point(209, 109)
        Me.txtlargmax.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtlargmax.Name = "txtlargmax"
        Me.txtlargmax.Size = New System.Drawing.Size(64, 20)
        Me.txtlargmax.TabIndex = 23
        '
        'txtalturamax
        '
        Me.txtalturamax.DecimalPlaces = 2
        Me.txtalturamax.Location = New System.Drawing.Point(209, 81)
        Me.txtalturamax.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtalturamax.Name = "txtalturamax"
        Me.txtalturamax.Size = New System.Drawing.Size(64, 20)
        Me.txtalturamax.TabIndex = 22
        '
        'txtanchomin
        '
        Me.txtanchomin.DecimalPlaces = 2
        Me.txtanchomin.Location = New System.Drawing.Point(107, 140)
        Me.txtanchomin.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtanchomin.Name = "txtanchomin"
        Me.txtanchomin.Size = New System.Drawing.Size(64, 20)
        Me.txtanchomin.TabIndex = 20
        '
        'txtlargmin
        '
        Me.txtlargmin.DecimalPlaces = 2
        Me.txtlargmin.Location = New System.Drawing.Point(107, 109)
        Me.txtlargmin.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtlargmin.Name = "txtlargmin"
        Me.txtlargmin.Size = New System.Drawing.Size(64, 20)
        Me.txtlargmin.TabIndex = 19
        '
        'txtalturamin
        '
        Me.txtalturamin.DecimalPlaces = 2
        Me.txtalturamin.Location = New System.Drawing.Point(107, 81)
        Me.txtalturamin.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtalturamin.Name = "txtalturamin"
        Me.txtalturamin.Size = New System.Drawing.Size(64, 20)
        Me.txtalturamin.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Altura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Largo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Ancho"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Diametro"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(85, 124)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(185, 21)
        Me.ComboBox1.TabIndex = 39
        '
        'Form_Stock_Precio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 276)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_Stock_Precio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Precios"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.npdaltmax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdaltmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.txtalchomax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtlargmax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtalturamax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtanchomin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtlargmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtalturamin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtalchomax As NumericUpDown
    Friend WithEvents txtlargmax As NumericUpDown
    Friend WithEvents txtalturamax As NumericUpDown
    Friend WithEvents txtanchomin As NumericUpDown
    Friend WithEvents txtlargmin As NumericUpDown
    Friend WithEvents txtalturamin As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpfecha2 As DateTimePicker
    Friend WithEvents dtpfecha1 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents npdaltmax As NumericUpDown
    Friend WithEvents npdaltmin As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents btndiametro As Button
    Friend WithEvents btnaltura As Button
    Friend WithEvents dtp2fecha2 As DateTimePicker
    Friend WithEvents dtp2fecha1 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents btnreporte As Button
    Friend WithEvents btnreporte1 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
