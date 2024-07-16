<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFiltroOrdenesCompra
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
        Me.txtnomart1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnomart = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtartcod = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbanho = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbmes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblruc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_serie = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnro = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtruc = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnomart1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtnomart)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtartcod)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblruc)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_serie)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtnro)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.txtruc)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 162)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda"
        '
        'txtnomart1
        '
        Me.txtnomart1.AllowDrop = True
        Me.txtnomart1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnomart1.Location = New System.Drawing.Point(82, 131)
        Me.txtnomart1.MaxLength = 20
        Me.txtnomart1.Name = "txtnomart1"
        Me.txtnomart1.Size = New System.Drawing.Size(396, 20)
        Me.txtnomart1.TabIndex = 238
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(734, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 21)
        Me.Button2.TabIndex = 237
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(730, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 21)
        Me.Button1.TabIndex = 236
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 235
        Me.Label8.Text = "Nom. Articulo"
        '
        'txtnomart
        '
        Me.txtnomart.BackColor = System.Drawing.Color.Gainsboro
        Me.txtnomart.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnomart.Location = New System.Drawing.Point(162, 65)
        Me.txtnomart.Name = "txtnomart"
        Me.txtnomart.ReadOnly = True
        Me.txtnomart.Size = New System.Drawing.Size(566, 20)
        Me.txtnomart.TabIndex = 234
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 233
        Me.Label1.Text = "Articulo"
        '
        'txtartcod
        '
        Me.txtartcod.AllowDrop = True
        Me.txtartcod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtartcod.Location = New System.Drawing.Point(59, 65)
        Me.txtartcod.MaxLength = 20
        Me.txtartcod.Name = "txtartcod"
        Me.txtartcod.Size = New System.Drawing.Size(102, 20)
        Me.txtartcod.TabIndex = 232
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmbanho)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmbmes)
        Me.GroupBox2.Location = New System.Drawing.Point(276, 11)
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
        Me.cmbanho.Items.AddRange(New Object() {"", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025"})
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
        Me.Label2.Location = New System.Drawing.Point(127, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 216
        Me.Label2.Text = "Numero"
        '
        'lblruc
        '
        Me.lblruc.BackColor = System.Drawing.Color.Gainsboro
        Me.lblruc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lblruc.Location = New System.Drawing.Point(162, 97)
        Me.lblruc.Name = "lblruc"
        Me.lblruc.ReadOnly = True
        Me.lblruc.Size = New System.Drawing.Size(566, 20)
        Me.lblruc.TabIndex = 215
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 206
        Me.Label7.Text = "Ruc"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 202
        Me.Label5.Text = "Serie"
        '
        'txt_serie
        '
        Me.txt_serie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_serie.Location = New System.Drawing.Point(59, 24)
        Me.txt_serie.MaxLength = 5
        Me.txt_serie.Name = "txt_serie"
        Me.txt_serie.Size = New System.Drawing.Size(62, 20)
        Me.txt_serie.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(157, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 197
        '
        'txtnro
        '
        Me.txtnro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnro.Location = New System.Drawing.Point(171, 23)
        Me.txtnro.MaxLength = 20
        Me.txtnro.Name = "txtnro"
        Me.txtnro.Size = New System.Drawing.Size(80, 20)
        Me.txtnro.TabIndex = 2
        '
        'btnbuscar
        '
        Me.btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.Location = New System.Drawing.Point(652, 20)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(105, 26)
        Me.btnbuscar.TabIndex = 8
        Me.btnbuscar.Text = "Filtrar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'txtruc
        '
        Me.txtruc.AllowDrop = True
        Me.txtruc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtruc.Location = New System.Drawing.Point(59, 97)
        Me.txtruc.MaxLength = 20
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(102, 20)
        Me.txtruc.TabIndex = 4
        '
        'FormFiltroOrdenesCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 186)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormFiltroOrdenesCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormFiltroOrdenesCompra"
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
    Friend WithEvents lblruc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_serie As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnro As TextBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents txtruc As TextBox
    Friend WithEvents txtnomart As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtartcod As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnomart1 As TextBox
End Class
