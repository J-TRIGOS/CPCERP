<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptDetDocumento
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbmes1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttdoc = New System.Windows.Forms.TextBox()
        Me.txtsdoc = New System.Windows.Forms.TextBox()
        Me.txtndoc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtregnro = New System.Windows.Forms.TextBox()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.chkfecha = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtcliente1 = New System.Windows.Forms.TextBox()
        Me.cmbope1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "Año :"
        '
        'cmbmes1
        '
        Me.cmbmes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes1.FormattingEnabled = True
        Me.cmbmes1.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes1.Location = New System.Drawing.Point(248, 28)
        Me.cmbmes1.Name = "cmbmes1"
        Me.cmbmes1.Size = New System.Drawing.Size(106, 21)
        Me.cmbmes1.TabIndex = 116
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(200, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Mes1 :"
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño.Location = New System.Drawing.Point(87, 28)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(100, 21)
        Me.cmbaño.TabIndex = 115
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Tipo :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(202, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Serie :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Numero :"
        '
        'txttdoc
        '
        Me.txttdoc.Location = New System.Drawing.Point(87, 55)
        Me.txttdoc.Name = "txttdoc"
        Me.txttdoc.Size = New System.Drawing.Size(100, 20)
        Me.txttdoc.TabIndex = 124
        '
        'txtsdoc
        '
        Me.txtsdoc.Location = New System.Drawing.Point(248, 55)
        Me.txtsdoc.Name = "txtsdoc"
        Me.txtsdoc.Size = New System.Drawing.Size(100, 20)
        Me.txtsdoc.TabIndex = 125
        '
        'txtndoc
        '
        Me.txtndoc.Location = New System.Drawing.Point(86, 82)
        Me.txtndoc.Name = "txtndoc"
        Me.txtndoc.Size = New System.Drawing.Size(100, 20)
        Me.txtndoc.TabIndex = 126
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(190, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "Registro :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Proveedor :"
        '
        'txtregnro
        '
        Me.txtregnro.Location = New System.Drawing.Point(248, 82)
        Me.txtregnro.Name = "txtregnro"
        Me.txtregnro.Size = New System.Drawing.Size(100, 20)
        Me.txtregnro.TabIndex = 130
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(130, 144)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 131
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(224, 144)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 132
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'chkfecha
        '
        Me.chkfecha.AutoSize = True
        Me.chkfecha.Checked = True
        Me.chkfecha.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkfecha.Location = New System.Drawing.Point(360, 32)
        Me.chkfecha.Name = "chkfecha"
        Me.chkfecha.Size = New System.Drawing.Size(56, 17)
        Me.chkfecha.TabIndex = 133
        Me.chkfecha.Text = "Fecha"
        Me.chkfecha.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(180, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 23)
        Me.Button1.TabIndex = 136
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtcliente1
        '
        Me.txtcliente1.Location = New System.Drawing.Point(86, 108)
        Me.txtcliente1.Name = "txtcliente1"
        Me.txtcliente1.Size = New System.Drawing.Size(88, 20)
        Me.txtcliente1.TabIndex = 134
        '
        'cmbope1
        '
        Me.cmbope1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbope1.FormattingEnabled = True
        Me.cmbope1.Items.AddRange(New Object() {"001", "007", "010", "013"})
        Me.cmbope1.Location = New System.Drawing.Point(293, 108)
        Me.cmbope1.Name = "cmbope1"
        Me.cmbope1.Size = New System.Drawing.Size(65, 21)
        Me.cmbope1.TabIndex = 138
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Tipo Ope.1 :"
        '
        'FormRptDetDocumento
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 192)
        Me.Controls.Add(Me.cmbope1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtcliente1)
        Me.Controls.Add(Me.chkfecha)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.txtregnro)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtndoc)
        Me.Controls.Add(Me.txtsdoc)
        Me.Controls.Add(Me.txttdoc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbmes1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbaño)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRptDetDocumento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptDetDocumento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents cmbmes1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbaño As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txttdoc As TextBox
    Friend WithEvents txtsdoc As TextBox
    Friend WithEvents txtndoc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtregnro As TextBox
    Friend WithEvents btnreporte As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents chkfecha As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtcliente1 As TextBox
    Friend WithEvents cmbope1 As ComboBox
    Friend WithEvents Label2 As Label
End Class
