<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRPTKardex_Consumo_Costo
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbmes1 = New System.Windows.Forms.ComboBox()
        Me.cmbmes2 = New System.Windows.Forms.ComboBox()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.txtarticulo2 = New System.Windows.Forms.TextBox()
        Me.txtarticulo1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbtipo2 = New System.Windows.Forms.ComboBox()
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtc_costo2 = New System.Windows.Forms.TextBox()
        Me.txtc_costo = New System.Windows.Forms.TextBox()
        Me.cmbc_costo2 = New System.Windows.Forms.ComboBox()
        Me.cmbc_costo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbarticulo = New System.Windows.Forms.RadioButton()
        Me.rdbccosto = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(256, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Mes2 :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 136
        Me.Label5.Text = "Mes1 :"
        '
        'cmbmes1
        '
        Me.cmbmes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes1.FormattingEnabled = True
        Me.cmbmes1.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes1.Location = New System.Drawing.Point(98, 116)
        Me.cmbmes1.Name = "cmbmes1"
        Me.cmbmes1.Size = New System.Drawing.Size(152, 21)
        Me.cmbmes1.TabIndex = 134
        '
        'cmbmes2
        '
        Me.cmbmes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes2.FormattingEnabled = True
        Me.cmbmes2.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes2.Location = New System.Drawing.Point(300, 116)
        Me.cmbmes2.Name = "cmbmes2"
        Me.cmbmes2.Size = New System.Drawing.Size(154, 21)
        Me.cmbmes2.TabIndex = 135
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño.Location = New System.Drawing.Point(98, 89)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(121, 21)
        Me.cmbaño.TabIndex = 130
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Año1 :"
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(155, 253)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 143
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(251, 253)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 144
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(369, 143)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(35, 23)
        Me.Button7.TabIndex = 149
        Me.Button7.Text = "..."
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(203, 141)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(35, 23)
        Me.Button8.TabIndex = 148
        Me.Button8.Text = "..."
        Me.Button8.UseVisualStyleBackColor = True
        '
        'txtarticulo2
        '
        Me.txtarticulo2.Location = New System.Drawing.Point(244, 143)
        Me.txtarticulo2.Name = "txtarticulo2"
        Me.txtarticulo2.Size = New System.Drawing.Size(119, 20)
        Me.txtarticulo2.TabIndex = 146
        '
        'txtarticulo1
        '
        Me.txtarticulo1.Location = New System.Drawing.Point(98, 143)
        Me.txtarticulo1.Name = "txtarticulo1"
        Me.txtarticulo1.Size = New System.Drawing.Size(99, 20)
        Me.txtarticulo1.TabIndex = 145
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "Articulo"
        '
        'cmbtipo2
        '
        Me.cmbtipo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipo2.FormattingEnabled = True
        Me.cmbtipo2.Items.AddRange(New Object() {"", "EMB- ENVASES Y EMBALAJES", "SUM-SUMINISTROS", "MPR-MATERIA PRIMA", "MER-MERCADERIA", "REP-REPUESTOS", "PP-PRODUCTOS EN PROCESO", "PT-PRODUCTOS TERMINADOS"})
        Me.cmbtipo2.Location = New System.Drawing.Point(251, 169)
        Me.cmbtipo2.Name = "cmbtipo2"
        Me.cmbtipo2.Size = New System.Drawing.Size(189, 21)
        Me.cmbtipo2.TabIndex = 151
        '
        'cmbtipo
        '
        Me.cmbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"", "EMB- ENVASES Y EMBALAJES", "SUM-SUMINISTROS", "MPR-MATERIA PRIMA", "MER-MERCADERIA", "REP-REPUESTOS", "PP-PRODUCTOS EN PROCESO", "PT-PRODUCTOS TERMINADOS"})
        Me.cmbtipo.Location = New System.Drawing.Point(98, 169)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(147, 21)
        Me.cmbtipo.TabIndex = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "Tipo Articulo"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(421, 222)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 23)
        Me.Button3.TabIndex = 158
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(421, 196)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 23)
        Me.Button4.TabIndex = 157
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtc_costo2
        '
        Me.txtc_costo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtc_costo2.Location = New System.Drawing.Point(97, 222)
        Me.txtc_costo2.MaxLength = 3
        Me.txtc_costo2.Name = "txtc_costo2"
        Me.txtc_costo2.Size = New System.Drawing.Size(40, 20)
        Me.txtc_costo2.TabIndex = 154
        '
        'txtc_costo
        '
        Me.txtc_costo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtc_costo.Location = New System.Drawing.Point(98, 196)
        Me.txtc_costo.MaxLength = 3
        Me.txtc_costo.Name = "txtc_costo"
        Me.txtc_costo.Size = New System.Drawing.Size(40, 20)
        Me.txtc_costo.TabIndex = 153
        '
        'cmbc_costo2
        '
        Me.cmbc_costo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbc_costo2.FormattingEnabled = True
        Me.cmbc_costo2.Location = New System.Drawing.Point(143, 222)
        Me.cmbc_costo2.Name = "cmbc_costo2"
        Me.cmbc_costo2.Size = New System.Drawing.Size(272, 21)
        Me.cmbc_costo2.TabIndex = 156
        '
        'cmbc_costo
        '
        Me.cmbc_costo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbc_costo.FormattingEnabled = True
        Me.cmbc_costo.Location = New System.Drawing.Point(144, 195)
        Me.cmbc_costo.Name = "cmbc_costo"
        Me.cmbc_costo.Size = New System.Drawing.Size(271, 21)
        Me.cmbc_costo.TabIndex = 155
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 160
        Me.Label3.Text = "Centro Costo2 :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 159
        Me.Label7.Text = "Centro Costo1 :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbarticulo)
        Me.GroupBox1.Controls.Add(Me.rdbccosto)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 56)
        Me.GroupBox1.TabIndex = 161
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agrupado"
        '
        'rdbarticulo
        '
        Me.rdbarticulo.AutoSize = True
        Me.rdbarticulo.Location = New System.Drawing.Point(234, 23)
        Me.rdbarticulo.Name = "rdbarticulo"
        Me.rdbarticulo.Size = New System.Drawing.Size(60, 17)
        Me.rdbarticulo.TabIndex = 1
        Me.rdbarticulo.TabStop = True
        Me.rdbarticulo.Text = "Articulo"
        Me.rdbarticulo.UseVisualStyleBackColor = True
        '
        'rdbccosto
        '
        Me.rdbccosto.AutoSize = True
        Me.rdbccosto.Location = New System.Drawing.Point(72, 23)
        Me.rdbccosto.Name = "rdbccosto"
        Me.rdbccosto.Size = New System.Drawing.Size(101, 17)
        Me.rdbccosto.TabIndex = 0
        Me.rdbccosto.TabStop = True
        Me.rdbccosto.Text = "Centro de Costo"
        Me.rdbccosto.UseVisualStyleBackColor = True
        '
        'FormRPTKardex_Consumo_Costo
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 301)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtc_costo2)
        Me.Controls.Add(Me.txtc_costo)
        Me.Controls.Add(Me.cmbc_costo2)
        Me.Controls.Add(Me.cmbc_costo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbtipo2)
        Me.Controls.Add(Me.cmbtipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.txtarticulo2)
        Me.Controls.Add(Me.txtarticulo1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbmes1)
        Me.Controls.Add(Me.cmbmes2)
        Me.Controls.Add(Me.cmbaño)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRPTKardex_Consumo_Costo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRPTKardex_Consumo_Costo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbmes1 As ComboBox
    Friend WithEvents cmbmes2 As ComboBox
    Friend WithEvents cmbaño As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnreporte As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents txtarticulo2 As TextBox
    Friend WithEvents txtarticulo1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbtipo2 As ComboBox
    Friend WithEvents cmbtipo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txtc_costo2 As TextBox
    Friend WithEvents txtc_costo As TextBox
    Friend WithEvents cmbc_costo2 As ComboBox
    Friend WithEvents cmbc_costo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbarticulo As RadioButton
    Friend WithEvents rdbccosto As RadioButton
End Class
