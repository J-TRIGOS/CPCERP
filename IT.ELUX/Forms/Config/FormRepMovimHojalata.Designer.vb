<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRepMovimHojalata
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
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtespesmax = New System.Windows.Forms.NumericUpDown()
        Me.txtempmax = New System.Windows.Forms.NumericUpDown()
        Me.txtlargmax = New System.Windows.Forms.NumericUpDown()
        Me.txtanchomax = New System.Windows.Forms.NumericUpDown()
        Me.txtespesmin = New System.Windows.Forms.NumericUpDown()
        Me.txtempmin = New System.Windows.Forms.NumericUpDown()
        Me.txtlargmin = New System.Windows.Forms.NumericUpDown()
        Me.txtanchomin = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        CType(Me.txtespesmax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtempmax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtlargmax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtanchomax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtespesmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtempmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtlargmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtanchomin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(104, 198)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 29
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(90, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Mínimo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(190, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Máximo"
        '
        'txtespesmax
        '
        Me.txtespesmax.DecimalPlaces = 2
        Me.txtespesmax.Location = New System.Drawing.Point(182, 161)
        Me.txtespesmax.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtespesmax.Name = "txtespesmax"
        Me.txtespesmax.Size = New System.Drawing.Size(64, 20)
        Me.txtespesmax.TabIndex = 26
        '
        'txtempmax
        '
        Me.txtempmax.DecimalPlaces = 2
        Me.txtempmax.Location = New System.Drawing.Point(182, 130)
        Me.txtempmax.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtempmax.Name = "txtempmax"
        Me.txtempmax.Size = New System.Drawing.Size(64, 20)
        Me.txtempmax.TabIndex = 25
        '
        'txtlargmax
        '
        Me.txtlargmax.DecimalPlaces = 2
        Me.txtlargmax.Location = New System.Drawing.Point(182, 99)
        Me.txtlargmax.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtlargmax.Name = "txtlargmax"
        Me.txtlargmax.Size = New System.Drawing.Size(64, 20)
        Me.txtlargmax.TabIndex = 24
        '
        'txtanchomax
        '
        Me.txtanchomax.DecimalPlaces = 2
        Me.txtanchomax.Location = New System.Drawing.Point(182, 71)
        Me.txtanchomax.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtanchomax.Name = "txtanchomax"
        Me.txtanchomax.Size = New System.Drawing.Size(64, 20)
        Me.txtanchomax.TabIndex = 23
        '
        'txtespesmin
        '
        Me.txtespesmin.DecimalPlaces = 2
        Me.txtespesmin.Location = New System.Drawing.Point(80, 161)
        Me.txtespesmin.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtespesmin.Name = "txtespesmin"
        Me.txtespesmin.Size = New System.Drawing.Size(64, 20)
        Me.txtespesmin.TabIndex = 22
        '
        'txtempmin
        '
        Me.txtempmin.DecimalPlaces = 2
        Me.txtempmin.Location = New System.Drawing.Point(80, 130)
        Me.txtempmin.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtempmin.Name = "txtempmin"
        Me.txtempmin.Size = New System.Drawing.Size(64, 20)
        Me.txtempmin.TabIndex = 21
        '
        'txtlargmin
        '
        Me.txtlargmin.DecimalPlaces = 2
        Me.txtlargmin.Location = New System.Drawing.Point(80, 99)
        Me.txtlargmin.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtlargmin.Name = "txtlargmin"
        Me.txtlargmin.Size = New System.Drawing.Size(64, 20)
        Me.txtlargmin.TabIndex = 20
        '
        'txtanchomin
        '
        Me.txtanchomin.DecimalPlaces = 2
        Me.txtanchomin.Location = New System.Drawing.Point(80, 71)
        Me.txtanchomin.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtanchomin.Name = "txtanchomin"
        Me.txtanchomin.Size = New System.Drawing.Size(64, 20)
        Me.txtanchomin.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Espesor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Temple"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Largo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Ancho"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Año"
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño.Location = New System.Drawing.Point(80, 12)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(121, 21)
        Me.cmbaño.TabIndex = 95
        '
        'FormRepMovimHojalata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 227)
        Me.Controls.Add(Me.cmbaño)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtespesmax)
        Me.Controls.Add(Me.txtempmax)
        Me.Controls.Add(Me.txtlargmax)
        Me.Controls.Add(Me.txtanchomax)
        Me.Controls.Add(Me.txtespesmin)
        Me.Controls.Add(Me.txtempmin)
        Me.Controls.Add(Me.txtlargmin)
        Me.Controls.Add(Me.txtanchomin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRepMovimHojalata"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRepMovimHojalata"
        CType(Me.txtespesmax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtempmax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtlargmax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtanchomax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtespesmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtempmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtlargmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtanchomin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnImprimir As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtespesmax As NumericUpDown
    Friend WithEvents txtempmax As NumericUpDown
    Friend WithEvents txtlargmax As NumericUpDown
    Friend WithEvents txtanchomax As NumericUpDown
    Friend WithEvents txtespesmin As NumericUpDown
    Friend WithEvents txtempmin As NumericUpDown
    Friend WithEvents txtlargmin As NumericUpDown
    Friend WithEvents txtanchomin As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbaño As ComboBox
End Class
