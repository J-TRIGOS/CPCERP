<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFiltroProgramacion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbanho = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbmes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_serie = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnro = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtnomccosto = New System.Windows.Forms.TextBox()
        Me.txtcodccosto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.cmbturno = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnbusccosto = New System.Windows.Forms.Button()
        Me.btnbuslinea = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnbuslinea)
        Me.GroupBox1.Controls.Add(Me.btnbusccosto)
        Me.GroupBox1.Controls.Add(Me.cmbturno)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtnomccosto)
        Me.GroupBox1.Controls.Add(Me.txtcodccosto)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_serie)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtnro)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(794, 123)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmbanho)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmbmes)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(298, 48)
        Me.GroupBox2.TabIndex = 231
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fecha Generacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 220
        Me.Label4.Text = "Año"
        '
        'cmbanho
        '
        Me.cmbanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbanho.FormattingEnabled = True
        Me.cmbanho.Items.AddRange(New Object() {"", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2022", "2023", "2024", "2025"})
        Me.cmbanho.Location = New System.Drawing.Point(38, 19)
        Me.cmbanho.Name = "cmbanho"
        Me.cmbanho.Size = New System.Drawing.Size(80, 21)
        Me.cmbanho.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(124, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 221
        Me.Label6.Text = "Mes"
        '
        'cmbmes
        '
        Me.cmbmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes.FormattingEnabled = True
        Me.cmbmes.Items.AddRange(New Object() {"", "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SETIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cmbmes.Location = New System.Drawing.Point(155, 19)
        Me.cmbmes.Name = "cmbmes"
        Me.cmbmes.Size = New System.Drawing.Size(109, 21)
        Me.cmbmes.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 216
        Me.Label2.Text = "Numero"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 202
        Me.Label5.Text = "Serie"
        '
        'txt_serie
        '
        Me.txt_serie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_serie.Location = New System.Drawing.Point(61, 23)
        Me.txt_serie.MaxLength = 5
        Me.txt_serie.Name = "txt_serie"
        Me.txt_serie.Size = New System.Drawing.Size(62, 20)
        Me.txt_serie.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(159, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 197
        '
        'txtnro
        '
        Me.txtnro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnro.Location = New System.Drawing.Point(173, 22)
        Me.txtnro.MaxLength = 20
        Me.txtnro.Name = "txtnro"
        Me.txtnro.Size = New System.Drawing.Size(80, 20)
        Me.txtnro.TabIndex = 2
        '
        'btnbuscar
        '
        Me.btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.Location = New System.Drawing.Point(611, 74)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(105, 26)
        Me.btnbuscar.TabIndex = 8
        Me.btnbuscar.Text = "Filtrar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'txtnomccosto
        '
        Me.txtnomccosto.BackColor = System.Drawing.Color.Gainsboro
        Me.txtnomccosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnomccosto.Location = New System.Drawing.Point(491, 22)
        Me.txtnomccosto.Name = "txtnomccosto"
        Me.txtnomccosto.ReadOnly = True
        Me.txtnomccosto.Size = New System.Drawing.Size(257, 20)
        Me.txtnomccosto.TabIndex = 233
        '
        'txtcodccosto
        '
        Me.txtcodccosto.AllowDrop = True
        Me.txtcodccosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodccosto.Location = New System.Drawing.Point(383, 22)
        Me.txtcodccosto.MaxLength = 20
        Me.txtcodccosto.Name = "txtcodccosto"
        Me.txtcodccosto.Size = New System.Drawing.Size(102, 20)
        Me.txtcodccosto.TabIndex = 232
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(323, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 234
        Me.Label1.Text = "C. Costo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(323, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 237
        Me.Label7.Text = "Linea"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(491, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(257, 20)
        Me.TextBox1.TabIndex = 236
        '
        'TextBox2
        '
        Me.TextBox2.AllowDrop = True
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Location = New System.Drawing.Point(383, 48)
        Me.TextBox2.MaxLength = 20
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(102, 20)
        Me.TextBox2.TabIndex = 235
        '
        'cmbturno
        '
        Me.cmbturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbturno.FormattingEnabled = True
        Me.cmbturno.Items.AddRange(New Object() {"8:00 a.m. - 5:15 p.m.", "8:00 p.m. - 5:15 a.m."})
        Me.cmbturno.Location = New System.Drawing.Point(383, 74)
        Me.cmbturno.Name = "cmbturno"
        Me.cmbturno.Size = New System.Drawing.Size(119, 21)
        Me.cmbturno.TabIndex = 238
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(323, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 23)
        Me.Label8.TabIndex = 239
        Me.Label8.Text = "Turno"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnbusccosto
        '
        Me.btnbusccosto.Location = New System.Drawing.Point(753, 20)
        Me.btnbusccosto.Name = "btnbusccosto"
        Me.btnbusccosto.Size = New System.Drawing.Size(34, 23)
        Me.btnbusccosto.TabIndex = 240
        Me.btnbusccosto.Text = "..."
        Me.btnbusccosto.UseVisualStyleBackColor = True
        '
        'btnbuslinea
        '
        Me.btnbuslinea.Location = New System.Drawing.Point(753, 45)
        Me.btnbuslinea.Name = "btnbuslinea"
        Me.btnbuslinea.Size = New System.Drawing.Size(34, 23)
        Me.btnbuslinea.TabIndex = 241
        Me.btnbuslinea.Text = "..."
        Me.btnbuslinea.UseVisualStyleBackColor = True
        '
        'FormFiltroProgramacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 142)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormFiltroProgramacion"
        Me.Text = "FormFiltroProgramacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbanho As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbmes As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_serie As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnro As TextBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnomccosto As TextBox
    Friend WithEvents txtcodccosto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents cmbturno As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnbuslinea As Button
    Friend WithEvents btnbusccosto As Button
End Class
