<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRptVentas_Fact_Art
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.txtcliente1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbaño2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbmes1 = New System.Windows.Forms.ComboBox()
        Me.cmbmes2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbnum = New System.Windows.Forms.RadioButton()
        Me.rdbañomes = New System.Windows.Forms.RadioButton()
        Me.rdbaño = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbfacturas = New System.Windows.Forms.RadioButton()
        Me.rdbfacturasn = New System.Windows.Forms.RadioButton()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero:"
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(102, 75)
        Me.txtnumero.MaxLength = 7
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(100, 20)
        Me.txtnumero.TabIndex = 1
        '
        'txtcliente1
        '
        Me.txtcliente1.Location = New System.Drawing.Point(102, 101)
        Me.txtcliente1.MaxLength = 8
        Me.txtcliente1.Name = "txtcliente1"
        Me.txtcliente1.Size = New System.Drawing.Size(100, 20)
        Me.txtcliente1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(208, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 23)
        Me.Button1.TabIndex = 102
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(97, 278)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 110
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(191, 278)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 111
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.Enabled = False
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño.Location = New System.Drawing.Point(102, 127)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(121, 21)
        Me.cmbaño.TabIndex = 113
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Año1 :"
        '
        'cmbaño2
        '
        Me.cmbaño2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño2.Enabled = False
        Me.cmbaño2.FormattingEnabled = True
        Me.cmbaño2.Items.AddRange(New Object() {"2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño2.Location = New System.Drawing.Point(102, 154)
        Me.cmbaño2.Name = "cmbaño2"
        Me.cmbaño2.Size = New System.Drawing.Size(121, 21)
        Me.cmbaño2.TabIndex = 115
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "Año2 :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "Mes2 :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 120
        Me.Label6.Text = "Mes1 :"
        '
        'cmbmes1
        '
        Me.cmbmes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes1.Enabled = False
        Me.cmbmes1.FormattingEnabled = True
        Me.cmbmes1.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes1.Location = New System.Drawing.Point(102, 181)
        Me.cmbmes1.Name = "cmbmes1"
        Me.cmbmes1.Size = New System.Drawing.Size(152, 21)
        Me.cmbmes1.TabIndex = 118
        '
        'cmbmes2
        '
        Me.cmbmes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes2.Enabled = False
        Me.cmbmes2.FormattingEnabled = True
        Me.cmbmes2.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes2.Location = New System.Drawing.Point(102, 208)
        Me.cmbmes2.Name = "cmbmes2"
        Me.cmbmes2.Size = New System.Drawing.Size(152, 21)
        Me.cmbmes2.TabIndex = 119
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbnum)
        Me.GroupBox1.Controls.Add(Me.rdbañomes)
        Me.GroupBox1.Controls.Add(Me.rdbaño)
        Me.GroupBox1.Location = New System.Drawing.Point(260, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 98)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        '
        'rdbnum
        '
        Me.rdbnum.AutoSize = True
        Me.rdbnum.Checked = True
        Me.rdbnum.Location = New System.Drawing.Point(6, 19)
        Me.rdbnum.Name = "rdbnum"
        Me.rdbnum.Size = New System.Drawing.Size(86, 17)
        Me.rdbnum.TabIndex = 2
        Me.rdbnum.TabStop = True
        Me.rdbnum.Text = "Solo Numero"
        Me.rdbnum.UseVisualStyleBackColor = True
        '
        'rdbañomes
        '
        Me.rdbañomes.AutoSize = True
        Me.rdbañomes.Location = New System.Drawing.Point(6, 65)
        Me.rdbañomes.Name = "rdbañomes"
        Me.rdbañomes.Size = New System.Drawing.Size(75, 17)
        Me.rdbañomes.TabIndex = 1
        Me.rdbañomes.TabStop = True
        Me.rdbañomes.Text = "Año y Mes"
        Me.rdbañomes.UseVisualStyleBackColor = True
        '
        'rdbaño
        '
        Me.rdbaño.AutoSize = True
        Me.rdbaño.Location = New System.Drawing.Point(6, 42)
        Me.rdbaño.Name = "rdbaño"
        Me.rdbaño.Size = New System.Drawing.Size(44, 17)
        Me.rdbaño.TabIndex = 0
        Me.rdbaño.TabStop = True
        Me.rdbaño.Text = "Año"
        Me.rdbaño.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbfacturas)
        Me.GroupBox2.Controls.Add(Me.rdbfacturasn)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(296, 57)
        Me.GroupBox2.TabIndex = 123
        Me.GroupBox2.TabStop = False
        '
        'rdbfacturas
        '
        Me.rdbfacturas.AutoSize = True
        Me.rdbfacturas.Checked = True
        Me.rdbfacturas.Location = New System.Drawing.Point(28, 19)
        Me.rdbfacturas.Name = "rdbfacturas"
        Me.rdbfacturas.Size = New System.Drawing.Size(85, 17)
        Me.rdbfacturas.TabIndex = 2
        Me.rdbfacturas.TabStop = True
        Me.rdbfacturas.Text = "Solo Factura"
        Me.rdbfacturas.UseVisualStyleBackColor = True
        '
        'rdbfacturasn
        '
        Me.rdbfacturasn.AutoSize = True
        Me.rdbfacturasn.Location = New System.Drawing.Point(150, 19)
        Me.rdbfacturasn.Name = "rdbfacturasn"
        Me.rdbfacturasn.Size = New System.Drawing.Size(103, 17)
        Me.rdbfacturasn.TabIndex = 0
        Me.rdbfacturasn.Text = "Factura y Notas "
        Me.rdbfacturasn.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(143, 235)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(105, 20)
        Me.TextBox6.TabIndex = 110
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(102, 235)
        Me.TextBox7.MaxLength = 4
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(35, 20)
        Me.TextBox7.TabIndex = 107
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(254, 233)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 23)
        Me.Button4.TabIndex = 109
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(31, 238)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 108
        Me.Label14.Text = "Sub Linea:"
        '
        'FormRptVentas_Fact_Art
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 326)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbmes1)
        Me.Controls.Add(Me.cmbmes2)
        Me.Controls.Add(Me.cmbaño2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbaño)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtcliente1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRptVentas_Fact_Art"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptVentas_Fact_Art"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents txtcliente1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnreporte As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents cmbaño As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbaño2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbmes1 As ComboBox
    Friend WithEvents cmbmes2 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbañomes As RadioButton
    Friend WithEvents rdbaño As RadioButton
    Friend WithEvents rdbnum As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdbfacturas As RadioButton
    Friend WithEvents rdbfacturasn As RadioButton
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label14 As Label
End Class
