<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRepReinAll
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmbser_orden = New System.Windows.Forms.ComboBox()
        Me.txtnro_orden = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtnomsublinea2 = New System.Windows.Forms.TextBox()
        Me.txtsublinea2 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbc_costo = New System.Windows.Forms.ComboBox()
        Me.txtc_costo = New System.Windows.Forms.TextBox()
        Me.txtfardo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtlote = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtnomsublinea = New System.Windows.Forms.TextBox()
        Me.txtsublinea = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtarticulo1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpfecini = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpfecfin = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbest = New System.Windows.Forms.ComboBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.cmbestdoc = New System.Windows.Forms.ComboBox()
        Me.txtuserrep = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(388, 409)
        Me.TabControl1.TabIndex = 33
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmbser_orden)
        Me.TabPage1.Controls.Add(Me.txtnro_orden)
        Me.TabPage1.Controls.Add(Me.Label43)
        Me.TabPage1.Controls.Add(Me.txtnomsublinea2)
        Me.TabPage1.Controls.Add(Me.txtsublinea2)
        Me.TabPage1.Controls.Add(Me.Button7)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.cmbc_costo)
        Me.TabPage1.Controls.Add(Me.txtc_costo)
        Me.TabPage1.Controls.Add(Me.txtfardo)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.txtlote)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.txtnomsublinea)
        Me.TabPage1.Controls.Add(Me.txtsublinea)
        Me.TabPage1.Controls.Add(Me.Button9)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtarticulo1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.dtpfecini)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.dtpfecfin)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.cmbest)
        Me.TabPage1.Controls.Add(Me.btnsalir)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.btnreporte)
        Me.TabPage1.Controls.Add(Me.cmbestdoc)
        Me.TabPage1.Controls.Add(Me.txtuserrep)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(380, 383)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Prod. Detallado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cmbser_orden
        '
        Me.cmbser_orden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbser_orden.FormattingEnabled = True
        Me.cmbser_orden.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025", "2026"})
        Me.cmbser_orden.Location = New System.Drawing.Point(228, 300)
        Me.cmbser_orden.Name = "cmbser_orden"
        Me.cmbser_orden.Size = New System.Drawing.Size(103, 21)
        Me.cmbser_orden.TabIndex = 53
        '
        'txtnro_orden
        '
        Me.txtnro_orden.Location = New System.Drawing.Point(131, 301)
        Me.txtnro_orden.MaxLength = 10
        Me.txtnro_orden.Name = "txtnro_orden"
        Me.txtnro_orden.Size = New System.Drawing.Size(91, 20)
        Me.txtnro_orden.TabIndex = 51
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(15, 306)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(59, 13)
        Me.Label43.TabIndex = 52
        Me.Label43.Text = "Nro. Orden"
        '
        'txtnomsublinea2
        '
        Me.txtnomsublinea2.Location = New System.Drawing.Point(173, 197)
        Me.txtnomsublinea2.Name = "txtnomsublinea2"
        Me.txtnomsublinea2.ReadOnly = True
        Me.txtnomsublinea2.Size = New System.Drawing.Size(105, 20)
        Me.txtnomsublinea2.TabIndex = 50
        '
        'txtsublinea2
        '
        Me.txtsublinea2.Location = New System.Drawing.Point(132, 197)
        Me.txtsublinea2.MaxLength = 4
        Me.txtsublinea2.Name = "txtsublinea2"
        Me.txtsublinea2.Size = New System.Drawing.Size(35, 20)
        Me.txtsublinea2.TabIndex = 47
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(284, 195)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(35, 23)
        Me.Button7.TabIndex = 49
        Me.Button7.Text = "..."
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Sub Linea2"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(337, 277)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(33, 17)
        Me.CheckBox1.TabIndex = 46
        Me.CheckBox1.Text = "X"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(15, 283)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(29, 13)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "Área"
        '
        'cmbc_costo
        '
        Me.cmbc_costo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmbc_costo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbc_costo.FormattingEnabled = True
        Me.cmbc_costo.Location = New System.Drawing.Point(178, 275)
        Me.cmbc_costo.Name = "cmbc_costo"
        Me.cmbc_costo.Size = New System.Drawing.Size(153, 21)
        Me.cmbc_costo.TabIndex = 44
        '
        'txtc_costo
        '
        Me.txtc_costo.BackColor = System.Drawing.SystemColors.Window
        Me.txtc_costo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtc_costo.Location = New System.Drawing.Point(131, 275)
        Me.txtc_costo.Name = "txtc_costo"
        Me.txtc_costo.Size = New System.Drawing.Size(44, 20)
        Me.txtc_costo.TabIndex = 43
        '
        'txtfardo
        '
        Me.txtfardo.Location = New System.Drawing.Point(132, 249)
        Me.txtfardo.MaxLength = 50
        Me.txtfardo.Name = "txtfardo"
        Me.txtfardo.Size = New System.Drawing.Size(91, 20)
        Me.txtfardo.TabIndex = 10
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 254)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 13)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Fardo"
        '
        'txtlote
        '
        Me.txtlote.Location = New System.Drawing.Point(132, 223)
        Me.txtlote.MaxLength = 50
        Me.txtlote.Name = "txtlote"
        Me.txtlote.Size = New System.Drawing.Size(91, 20)
        Me.txtlote.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 228)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Lote"
        '
        'txtnomsublinea
        '
        Me.txtnomsublinea.Location = New System.Drawing.Point(173, 171)
        Me.txtnomsublinea.Name = "txtnomsublinea"
        Me.txtnomsublinea.ReadOnly = True
        Me.txtnomsublinea.Size = New System.Drawing.Size(105, 20)
        Me.txtnomsublinea.TabIndex = 38
        '
        'txtsublinea
        '
        Me.txtsublinea.Location = New System.Drawing.Point(132, 171)
        Me.txtsublinea.MaxLength = 4
        Me.txtsublinea.Name = "txtsublinea"
        Me.txtsublinea.Size = New System.Drawing.Size(35, 20)
        Me.txtsublinea.TabIndex = 8
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(284, 169)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(35, 23)
        Me.Button9.TabIndex = 36
        Me.Button9.Text = "..."
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Sub Linea1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicio"
        '
        'txtarticulo1
        '
        Me.txtarticulo1.Location = New System.Drawing.Point(132, 145)
        Me.txtarticulo1.Name = "txtarticulo1"
        Me.txtarticulo1.Size = New System.Drawing.Size(121, 20)
        Me.txtarticulo1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Fin"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(259, 144)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 23)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Estado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Articulo Reporte"
        '
        'dtpfecini
        '
        Me.dtpfecini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecini.Location = New System.Drawing.Point(132, 7)
        Me.dtpfecini.Name = "dtpfecini"
        Me.dtpfecini.Size = New System.Drawing.Size(109, 20)
        Me.dtpfecini.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(259, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpfecfin
        '
        Me.dtpfecfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecfin.Location = New System.Drawing.Point(132, 37)
        Me.dtpfecfin.Name = "dtpfecfin"
        Me.dtpfecfin.Size = New System.Drawing.Size(109, 20)
        Me.dtpfecfin.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(259, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 34)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "En Blanco Salen Todos"
        '
        'cmbest
        '
        Me.cmbest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbest.FormattingEnabled = True
        Me.cmbest.Items.AddRange(New Object() {"", "Habilitado", "Anulado"})
        Me.cmbest.Location = New System.Drawing.Point(132, 63)
        Me.cmbest.Name = "cmbest"
        Me.cmbest.Size = New System.Drawing.Size(121, 21)
        Me.cmbest.TabIndex = 3
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(181, 340)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 25
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Estado Documento"
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(100, 340)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 24
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'cmbestdoc
        '
        Me.cmbestdoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestdoc.FormattingEnabled = True
        Me.cmbestdoc.Items.AddRange(New Object() {"", "Pendiente", "Desaprobado", "Aprobado", "Documentado"})
        Me.cmbestdoc.Location = New System.Drawing.Point(132, 91)
        Me.cmbestdoc.Name = "cmbestdoc"
        Me.cmbestdoc.Size = New System.Drawing.Size(121, 21)
        Me.cmbestdoc.TabIndex = 4
        '
        'txtuserrep
        '
        Me.txtuserrep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtuserrep.Location = New System.Drawing.Point(132, 119)
        Me.txtuserrep.Name = "txtuserrep"
        Me.txtuserrep.Size = New System.Drawing.Size(121, 20)
        Me.txtuserrep.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Usuario Reporte"
        '
        'FormRepReinAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 433)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRepReinAll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormReporteReingreso"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents cmbser_orden As ComboBox
    Friend WithEvents txtnro_orden As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents txtnomsublinea2 As TextBox
    Friend WithEvents txtsublinea2 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label23 As Label
    Friend WithEvents cmbc_costo As ComboBox
    Friend WithEvents txtc_costo As TextBox
    Friend WithEvents txtfardo As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtlote As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtnomsublinea As TextBox
    Friend WithEvents txtsublinea As TextBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtarticulo1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpfecini As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpfecfin As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbest As ComboBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnreporte As Button
    Friend WithEvents cmbestdoc As ComboBox
    Friend WithEvents txtuserrep As TextBox
    Friend WithEvents Label5 As Label
End Class
