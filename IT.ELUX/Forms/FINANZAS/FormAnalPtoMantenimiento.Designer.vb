<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAnalPtoMantenimiento
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
        Me.btnreporte_activos = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.cmbc_costo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmbmes2 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.txtc_costo2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtc_costo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbc_costo2 = New System.Windows.Forms.ComboBox()
        Me.cmbmes1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbRequerimiento = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnreporte_activos
        '
        Me.btnreporte_activos.Location = New System.Drawing.Point(264, 156)
        Me.btnreporte_activos.Name = "btnreporte_activos"
        Me.btnreporte_activos.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte_activos.TabIndex = 124
        Me.btnreporte_activos.Text = "Reporte Activos"
        Me.btnreporte_activos.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(183, 154)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 36)
        Me.Button2.TabIndex = 123
        Me.Button2.Text = "Reporte DET"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(380, 154)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 36)
        Me.btn_salir.TabIndex = 122
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(99, 154)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 121
        Me.btnreporte.Text = "Reporte AP"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'cmbc_costo
        '
        Me.cmbc_costo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbc_costo.FormattingEnabled = True
        Me.cmbc_costo.Location = New System.Drawing.Point(146, 61)
        Me.cmbc_costo.Name = "cmbc_costo"
        Me.cmbc_costo.Size = New System.Drawing.Size(271, 21)
        Me.cmbc_costo.TabIndex = 106
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(272, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "Mes :"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(423, 88)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 23)
        Me.Button3.TabIndex = 110
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cmbmes2
        '
        Me.cmbmes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes2.FormattingEnabled = True
        Me.cmbmes2.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes2.Location = New System.Drawing.Point(311, 34)
        Me.cmbmes2.Name = "cmbmes2"
        Me.cmbmes2.Size = New System.Drawing.Size(106, 21)
        Me.cmbmes2.TabIndex = 119
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(423, 62)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 23)
        Me.Button4.TabIndex = 107
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño.Location = New System.Drawing.Point(99, 6)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(121, 21)
        Me.cmbaño.TabIndex = 115
        '
        'txtc_costo2
        '
        Me.txtc_costo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtc_costo2.Location = New System.Drawing.Point(99, 88)
        Me.txtc_costo2.MaxLength = 3
        Me.txtc_costo2.Name = "txtc_costo2"
        Me.txtc_costo2.Size = New System.Drawing.Size(40, 20)
        Me.txtc_costo2.TabIndex = 108
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Mes :"
        '
        'txtc_costo
        '
        Me.txtc_costo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtc_costo.Location = New System.Drawing.Point(100, 62)
        Me.txtc_costo.MaxLength = 3
        Me.txtc_costo.Name = "txtc_costo"
        Me.txtc_costo.Size = New System.Drawing.Size(40, 20)
        Me.txtc_costo.TabIndex = 105
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Año :"
        '
        'cmbc_costo2
        '
        Me.cmbc_costo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbc_costo2.FormattingEnabled = True
        Me.cmbc_costo2.Location = New System.Drawing.Point(145, 88)
        Me.cmbc_costo2.Name = "cmbc_costo2"
        Me.cmbc_costo2.Size = New System.Drawing.Size(272, 21)
        Me.cmbc_costo2.TabIndex = 109
        '
        'cmbmes1
        '
        Me.cmbmes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes1.FormattingEnabled = True
        Me.cmbmes1.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes1.Location = New System.Drawing.Point(99, 34)
        Me.cmbmes1.Name = "cmbmes1"
        Me.cmbmes1.Size = New System.Drawing.Size(106, 21)
        Me.cmbmes1.TabIndex = 116
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "Centro Costo2 :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Tipo Req."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "Centro Costo1 :"
        '
        'cmbRequerimiento
        '
        Me.cmbRequerimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRequerimiento.FormattingEnabled = True
        Me.cmbRequerimiento.Items.AddRange(New Object() {"", "OTROS", "CORRECTIVO", "PREVENTIVO", "MEJORA", "PROYECTO"})
        Me.cmbRequerimiento.Location = New System.Drawing.Point(99, 115)
        Me.cmbRequerimiento.Name = "cmbRequerimiento"
        Me.cmbRequerimiento.Size = New System.Drawing.Size(272, 21)
        Me.cmbRequerimiento.TabIndex = 113
        '
        'FormAnalPtoMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 208)
        Me.Controls.Add(Me.btnreporte_activos)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.cmbc_costo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cmbmes2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.cmbaño)
        Me.Controls.Add(Me.txtc_costo2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtc_costo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbc_costo2)
        Me.Controls.Add(Me.cmbmes1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbRequerimiento)
        Me.Name = "FormAnalPtoMantenimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAnalPtoMantenimiento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnreporte_activos As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents btnreporte As Button
    Friend WithEvents cmbc_costo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents cmbmes2 As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents cmbaño As ComboBox
    Friend WithEvents txtc_costo2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtc_costo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbc_costo2 As ComboBox
    Friend WithEvents cmbmes1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbRequerimiento As ComboBox
End Class
