<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRPTPRESTAMOPER
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtnomper2 = New System.Windows.Forms.TextBox()
        Me.txtnomper1 = New System.Windows.Forms.TextBox()
        Me.txtper2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtper1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cmbt_per1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.cmbaño2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbmes1 = New System.Windows.Forms.ComboBox()
        Me.cmbmes2 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(488, 117)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 23)
        Me.Button2.TabIndex = 102
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(488, 91)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 23)
        Me.Button5.TabIndex = 101
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtnomper2
        '
        Me.txtnomper2.Location = New System.Drawing.Point(170, 120)
        Me.txtnomper2.Name = "txtnomper2"
        Me.txtnomper2.ReadOnly = True
        Me.txtnomper2.Size = New System.Drawing.Size(312, 20)
        Me.txtnomper2.TabIndex = 100
        '
        'txtnomper1
        '
        Me.txtnomper1.Location = New System.Drawing.Point(170, 93)
        Me.txtnomper1.Name = "txtnomper1"
        Me.txtnomper1.ReadOnly = True
        Me.txtnomper1.Size = New System.Drawing.Size(312, 20)
        Me.txtnomper1.TabIndex = 99
        '
        'txtper2
        '
        Me.txtper2.Location = New System.Drawing.Point(103, 120)
        Me.txtper2.Name = "txtper2"
        Me.txtper2.Size = New System.Drawing.Size(61, 20)
        Me.txtper2.TabIndex = 93
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Personal 2"
        '
        'txtper1
        '
        Me.txtper1.Location = New System.Drawing.Point(103, 93)
        Me.txtper1.MaxLength = 8
        Me.txtper1.Name = "txtper1"
        Me.txtper1.Size = New System.Drawing.Size(61, 20)
        Me.txtper1.TabIndex = 92
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Personal 1"
        '
        'Cmbt_per1
        '
        Me.Cmbt_per1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbt_per1.FormattingEnabled = True
        Me.Cmbt_per1.Items.AddRange(New Object() {"", "OBREROS", "EMPLEADOS"})
        Me.Cmbt_per1.Location = New System.Drawing.Point(103, 62)
        Me.Cmbt_per1.Name = "Cmbt_per1"
        Me.Cmbt_per1.Size = New System.Drawing.Size(89, 21)
        Me.Cmbt_per1.TabIndex = 90
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Tipo Personal"
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(186, 160)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 94
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(279, 160)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(86, 36)
        Me.btnsalir.TabIndex = 95
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Año"
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño.Location = New System.Drawing.Point(103, 12)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(88, 21)
        Me.cmbaño.TabIndex = 103
        '
        'cmbaño2
        '
        Me.cmbaño2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño2.FormattingEnabled = True
        Me.cmbaño2.Items.AddRange(New Object() {"2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño2.Location = New System.Drawing.Point(200, 12)
        Me.cmbaño2.Name = "cmbaño2"
        Me.cmbaño2.Size = New System.Drawing.Size(88, 21)
        Me.cmbaño2.TabIndex = 106
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Mes"
        '
        'cmbmes1
        '
        Me.cmbmes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes1.FormattingEnabled = True
        Me.cmbmes1.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes1.Location = New System.Drawing.Point(103, 37)
        Me.cmbmes1.Name = "cmbmes1"
        Me.cmbmes1.Size = New System.Drawing.Size(89, 21)
        Me.cmbmes1.TabIndex = 109
        '
        'cmbmes2
        '
        Me.cmbmes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes2.FormattingEnabled = True
        Me.cmbmes2.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes2.Location = New System.Drawing.Point(200, 37)
        Me.cmbmes2.Name = "cmbmes2"
        Me.cmbmes2.Size = New System.Drawing.Size(89, 21)
        Me.cmbmes2.TabIndex = 110
        '
        'FormRPTPRESTAMOPER
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 207)
        Me.Controls.Add(Me.cmbmes2)
        Me.Controls.Add(Me.cmbmes1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbaño2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbaño)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtnomper2)
        Me.Controls.Add(Me.txtnomper1)
        Me.Controls.Add(Me.txtper2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtper1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Cmbt_per1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btnsalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRPTPRESTAMOPER"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRPTPRESTAMOPER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents txtnomper2 As TextBox
    Friend WithEvents txtnomper1 As TextBox
    Friend WithEvents txtper2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtper1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Cmbt_per1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnreporte As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbaño As ComboBox
    Friend WithEvents cmbaño2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbmes1 As ComboBox
    Friend WithEvents cmbmes2 As ComboBox
End Class
