<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptComprasArt
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbmes1 = New System.Windows.Forms.ComboBox()
        Me.cmbmes2 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtcliente2 = New System.Windows.Forms.TextBox()
        Me.txtcliente1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtarticulo2 = New System.Windows.Forms.TextBox()
        Me.txtarticulo1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.cmbaño1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtactivo1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnomart1 = New System.Windows.Forms.TextBox()
        Me.txtnomart2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnomactivo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño.Location = New System.Drawing.Point(80, 12)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(121, 21)
        Me.cmbaño.TabIndex = 80
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(238, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Mes2 :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Mes1 :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Año :"
        '
        'cmbmes1
        '
        Me.cmbmes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes1.FormattingEnabled = True
        Me.cmbmes1.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes1.Location = New System.Drawing.Point(80, 40)
        Me.cmbmes1.Name = "cmbmes1"
        Me.cmbmes1.Size = New System.Drawing.Size(152, 21)
        Me.cmbmes1.TabIndex = 81
        '
        'cmbmes2
        '
        Me.cmbmes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes2.FormattingEnabled = True
        Me.cmbmes2.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes2.Location = New System.Drawing.Point(283, 40)
        Me.cmbmes2.Name = "cmbmes2"
        Me.cmbmes2.Size = New System.Drawing.Size(180, 21)
        Me.cmbmes2.TabIndex = 82
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(433, 67)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 23)
        Me.Button4.TabIndex = 90
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(238, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 23)
        Me.Button1.TabIndex = 89
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtcliente2
        '
        Me.txtcliente2.Location = New System.Drawing.Point(280, 67)
        Me.txtcliente2.Name = "txtcliente2"
        Me.txtcliente2.Size = New System.Drawing.Size(147, 20)
        Me.txtcliente2.TabIndex = 87
        '
        'txtcliente1
        '
        Me.txtcliente1.Location = New System.Drawing.Point(85, 67)
        Me.txtcliente1.Name = "txtcliente1"
        Me.txtcliente1.Size = New System.Drawing.Size(147, 20)
        Me.txtcliente1.TabIndex = 86
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Proveedor:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(433, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 23)
        Me.Button2.TabIndex = 145
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(433, 91)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 23)
        Me.Button3.TabIndex = 144
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtarticulo2
        '
        Me.txtarticulo2.Location = New System.Drawing.Point(85, 120)
        Me.txtarticulo2.MaxLength = 8
        Me.txtarticulo2.Name = "txtarticulo2"
        Me.txtarticulo2.Size = New System.Drawing.Size(64, 20)
        Me.txtarticulo2.TabIndex = 142
        '
        'txtarticulo1
        '
        Me.txtarticulo1.Location = New System.Drawing.Point(85, 93)
        Me.txtarticulo1.MaxLength = 8
        Me.txtarticulo1.Name = "txtarticulo1"
        Me.txtarticulo1.Size = New System.Drawing.Size(64, 20)
        Me.txtarticulo1.TabIndex = 141
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 143
        Me.Label7.Text = "Articulo:"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(238, 184)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 147
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(142, 184)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 146
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'cmbaño1
        '
        Me.cmbaño1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño1.FormattingEnabled = True
        Me.cmbaño1.Items.AddRange(New Object() {"2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño1.Location = New System.Drawing.Point(283, 15)
        Me.cmbaño1.Name = "cmbaño1"
        Me.cmbaño1.Size = New System.Drawing.Size(121, 21)
        Me.cmbaño1.TabIndex = 148
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(238, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Año2 :"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(433, 147)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(35, 23)
        Me.Button6.TabIndex = 153
        Me.Button6.Text = "..."
        Me.Button6.UseVisualStyleBackColor = True
        '
        'txtactivo1
        '
        Me.txtactivo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtactivo1.Location = New System.Drawing.Point(85, 149)
        Me.txtactivo1.MaxLength = 8
        Me.txtactivo1.Name = "txtactivo1"
        Me.txtactivo1.Size = New System.Drawing.Size(64, 20)
        Me.txtactivo1.TabIndex = 150
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 152
        Me.Label6.Text = "Activo:"
        '
        'txtnomart1
        '
        Me.txtnomart1.Location = New System.Drawing.Point(153, 93)
        Me.txtnomart1.MaxLength = 8
        Me.txtnomart1.Name = "txtnomart1"
        Me.txtnomart1.ReadOnly = True
        Me.txtnomart1.Size = New System.Drawing.Size(274, 20)
        Me.txtnomart1.TabIndex = 154
        '
        'txtnomart2
        '
        Me.txtnomart2.Location = New System.Drawing.Point(153, 120)
        Me.txtnomart2.MaxLength = 8
        Me.txtnomart2.Name = "txtnomart2"
        Me.txtnomart2.ReadOnly = True
        Me.txtnomart2.Size = New System.Drawing.Size(274, 20)
        Me.txtnomart2.TabIndex = 155
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 156
        Me.Label8.Text = "Articulo2 :"
        '
        'txtnomactivo
        '
        Me.txtnomactivo.Location = New System.Drawing.Point(153, 149)
        Me.txtnomactivo.MaxLength = 8
        Me.txtnomactivo.Name = "txtnomactivo"
        Me.txtnomactivo.ReadOnly = True
        Me.txtnomactivo.Size = New System.Drawing.Size(274, 20)
        Me.txtnomactivo.TabIndex = 157
        '
        'FormRptComprasArt
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 232)
        Me.Controls.Add(Me.txtnomactivo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtnomart2)
        Me.Controls.Add(Me.txtnomart1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.txtactivo1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbaño1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtarticulo2)
        Me.Controls.Add(Me.txtarticulo1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtcliente2)
        Me.Controls.Add(Me.txtcliente1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbaño)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbmes1)
        Me.Controls.Add(Me.cmbmes2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRptComprasArt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptComprasArt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbaño As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbmes1 As ComboBox
    Friend WithEvents cmbmes2 As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtcliente2 As TextBox
    Friend WithEvents txtcliente1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtarticulo2 As TextBox
    Friend WithEvents txtarticulo1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnreporte As Button
    Friend WithEvents cmbaño1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents txtactivo1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtnomart1 As TextBox
    Friend WithEvents txtnomart2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnomactivo As TextBox
End Class
