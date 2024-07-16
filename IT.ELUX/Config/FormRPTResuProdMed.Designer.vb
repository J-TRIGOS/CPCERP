<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRPTResuProdMed
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
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbmes1 = New System.Windows.Forms.ComboBox()
        Me.cmbmes2 = New System.Windows.Forms.ComboBox()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txtsublinea2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtsublinea1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño.Location = New System.Drawing.Point(94, 16)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(121, 21)
        Me.cmbaño.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(256, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Mes2 :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Mes1 :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Año :"
        '
        'cmbmes1
        '
        Me.cmbmes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes1.FormattingEnabled = True
        Me.cmbmes1.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes1.Location = New System.Drawing.Point(94, 44)
        Me.cmbmes1.Name = "cmbmes1"
        Me.cmbmes1.Size = New System.Drawing.Size(152, 21)
        Me.cmbmes1.TabIndex = 64
        '
        'cmbmes2
        '
        Me.cmbmes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes2.FormattingEnabled = True
        Me.cmbmes2.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes2.Location = New System.Drawing.Point(296, 45)
        Me.cmbmes2.Name = "cmbmes2"
        Me.cmbmes2.Size = New System.Drawing.Size(154, 21)
        Me.cmbmes2.TabIndex = 65
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(140, 138)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 77
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(234, 138)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 78
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(424, 95)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 23)
        Me.Button2.TabIndex = 82
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(143, 97)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(275, 20)
        Me.TextBox3.TabIndex = 86
        '
        'txtsublinea2
        '
        Me.txtsublinea2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsublinea2.Location = New System.Drawing.Point(94, 97)
        Me.txtsublinea2.MaxLength = 4
        Me.txtsublinea2.Name = "txtsublinea2"
        Me.txtsublinea2.Size = New System.Drawing.Size(43, 20)
        Me.txtsublinea2.TabIndex = 81
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Sub Linea2 :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(424, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 23)
        Me.Button1.TabIndex = 80
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(143, 71)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(275, 20)
        Me.TextBox2.TabIndex = 84
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(16, 71)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(67, 13)
        Me.Label25.TabIndex = 83
        Me.Label25.Text = "Sub Linea1 :"
        '
        'txtsublinea1
        '
        Me.txtsublinea1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsublinea1.Location = New System.Drawing.Point(94, 71)
        Me.txtsublinea1.MaxLength = 4
        Me.txtsublinea1.Name = "txtsublinea1"
        Me.txtsublinea1.Size = New System.Drawing.Size(43, 20)
        Me.txtsublinea1.TabIndex = 79
        '
        'FormRPTResuProdMed
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 186)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtsublinea2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtsublinea1)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.cmbaño)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbmes1)
        Me.Controls.Add(Me.cmbmes2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormRPTResuProdMed"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRPTResuProdMed"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbaño As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbmes1 As ComboBox
    Friend WithEvents cmbmes2 As ComboBox
    Friend WithEvents btnreporte As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtsublinea2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtsublinea1 As TextBox
End Class
