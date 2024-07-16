<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransportista
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
        Me.crear_chofer = New System.Windows.Forms.Button()
        Me.lblchofer = New System.Windows.Forms.Label()
        Me.txtchofer = New System.Windows.Forms.TextBox()
        Me.lblcod = New System.Windows.Forms.Label()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.lbl_codigo_nombre = New System.Windows.Forms.Label()
        Me.txtbrevete = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.crear_vehi = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtplaca = New System.Windows.Forms.TextBox()
        Me.txttipounidad = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcertifi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtconfi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcostoflete = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_transdoc = New System.Windows.Forms.ComboBox()
        Me.txtNrodoc2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.crear_chofer)
        Me.GroupBox1.Controls.Add(Me.lblchofer)
        Me.GroupBox1.Controls.Add(Me.txtchofer)
        Me.GroupBox1.Controls.Add(Me.lblcod)
        Me.GroupBox1.Controls.Add(Me.txtcod)
        Me.GroupBox1.Controls.Add(Me.lbl_codigo_nombre)
        Me.GroupBox1.Controls.Add(Me.txtbrevete)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(628, 104)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'crear_chofer
        '
        Me.crear_chofer.Location = New System.Drawing.Point(455, 40)
        Me.crear_chofer.Name = "crear_chofer"
        Me.crear_chofer.Size = New System.Drawing.Size(74, 22)
        Me.crear_chofer.TabIndex = 113
        Me.crear_chofer.Text = "Crear "
        Me.crear_chofer.UseVisualStyleBackColor = True
        '
        'lblchofer
        '
        Me.lblchofer.BackColor = System.Drawing.Color.Gainsboro
        Me.lblchofer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblchofer.Location = New System.Drawing.Point(160, 41)
        Me.lblchofer.Name = "lblchofer"
        Me.lblchofer.Size = New System.Drawing.Size(295, 20)
        Me.lblchofer.TabIndex = 112
        Me.lblchofer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtchofer
        '
        Me.txtchofer.Location = New System.Drawing.Point(107, 41)
        Me.txtchofer.Name = "txtchofer"
        Me.txtchofer.Size = New System.Drawing.Size(52, 20)
        Me.txtchofer.TabIndex = 111
        '
        'lblcod
        '
        Me.lblcod.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcod.Location = New System.Drawing.Point(160, 13)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(369, 20)
        Me.lblcod.TabIndex = 110
        Me.lblcod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcod
        '
        Me.txtcod.Location = New System.Drawing.Point(107, 13)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(52, 20)
        Me.txtcod.TabIndex = 108
        '
        'lbl_codigo_nombre
        '
        Me.lbl_codigo_nombre.AutoSize = True
        Me.lbl_codigo_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo_nombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_codigo_nombre.Location = New System.Drawing.Point(211, 18)
        Me.lbl_codigo_nombre.Name = "lbl_codigo_nombre"
        Me.lbl_codigo_nombre.Size = New System.Drawing.Size(0, 13)
        Me.lbl_codigo_nombre.TabIndex = 32
        '
        'txtbrevete
        '
        Me.txtbrevete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbrevete.Location = New System.Drawing.Point(107, 67)
        Me.txtbrevete.Name = "txtbrevete"
        Me.txtbrevete.ReadOnly = True
        Me.txtbrevete.Size = New System.Drawing.Size(112, 20)
        Me.txtbrevete.TabIndex = 43
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(7, 70)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(44, 13)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "Brevete"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Nombre del Chofer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Transportista"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.crear_vehi)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtplaca)
        Me.GroupBox2.Controls.Add(Me.txttipounidad)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtcertifi)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtconfi)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtmarca)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(628, 98)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'crear_vehi
        '
        Me.crear_vehi.Location = New System.Drawing.Point(281, 19)
        Me.crear_vehi.Name = "crear_vehi"
        Me.crear_vehi.Size = New System.Drawing.Size(74, 22)
        Me.crear_vehi.TabIndex = 114
        Me.crear_vehi.Text = "Crear "
        Me.crear_vehi.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(251, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 111
        Me.Label11.Text = "F9"
        '
        'txtplaca
        '
        Me.txtplaca.Location = New System.Drawing.Point(109, 19)
        Me.txtplaca.Name = "txtplaca"
        Me.txtplaca.Size = New System.Drawing.Size(139, 20)
        Me.txtplaca.TabIndex = 110
        '
        'txttipounidad
        '
        Me.txttipounidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttipounidad.Location = New System.Drawing.Point(109, 71)
        Me.txttipounidad.MaxLength = 20
        Me.txttipounidad.Name = "txttipounidad"
        Me.txttipounidad.Size = New System.Drawing.Size(83, 20)
        Me.txttipounidad.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Tipo Unidad"
        '
        'txtcertifi
        '
        Me.txtcertifi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcertifi.Location = New System.Drawing.Point(453, 45)
        Me.txtcertifi.MaxLength = 50
        Me.txtcertifi.Name = "txtcertifi"
        Me.txtcertifi.Size = New System.Drawing.Size(167, 20)
        Me.txtcertifi.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(383, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Certificado"
        '
        'txtconfi
        '
        Me.txtconfi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtconfi.Location = New System.Drawing.Point(453, 16)
        Me.txtconfi.MaxLength = 50
        Me.txtconfi.Name = "txtconfi"
        Me.txtconfi.Size = New System.Drawing.Size(167, 20)
        Me.txtconfi.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(370, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Configuracion"
        '
        'txtmarca
        '
        Me.txtmarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmarca.Location = New System.Drawing.Point(109, 44)
        Me.txtmarca.MaxLength = 100
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(246, 20)
        Me.txtmarca.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Placa"
        '
        'txtcostoflete
        '
        Me.txtcostoflete.Location = New System.Drawing.Point(121, 263)
        Me.txtcostoflete.Name = "txtcostoflete"
        Me.txtcostoflete.Size = New System.Drawing.Size(83, 20)
        Me.txtcostoflete.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Costo de Flete"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(466, 282)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 44
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(554, 282)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 45
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Serie"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(148, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Numero"
        '
        'cmb_transdoc
        '
        Me.cmb_transdoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_transdoc.FormattingEnabled = True
        Me.cmb_transdoc.Items.AddRange(New Object() {"001", "002", "003", "004", "005", "006"})
        Me.cmb_transdoc.Location = New System.Drawing.Point(13, 28)
        Me.cmb_transdoc.Name = "cmb_transdoc"
        Me.cmb_transdoc.Size = New System.Drawing.Size(62, 21)
        Me.cmb_transdoc.TabIndex = 51
        '
        'txtNrodoc2
        '
        Me.txtNrodoc2.Location = New System.Drawing.Point(119, 29)
        Me.txtNrodoc2.MaxLength = 7
        Me.txtNrodoc2.Name = "txtNrodoc2"
        Me.txtNrodoc2.Size = New System.Drawing.Size(112, 20)
        Me.txtNrodoc2.TabIndex = 109
        '
        'FormTransportista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 311)
        Me.Controls.Add(Me.txtNrodoc2)
        Me.Controls.Add(Me.cmb_transdoc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtcostoflete)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormTransportista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos del Transportista"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_codigo_nombre As Label
    Friend WithEvents txtbrevete As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtcertifi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtconfi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtmarca As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcostoflete As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents txtcod As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_transdoc As ComboBox
    Friend WithEvents txtNrodoc2 As TextBox
    Friend WithEvents txttipounidad As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtplaca As TextBox
    Friend WithEvents lblcod As Label
    Friend WithEvents lblchofer As Label
    Friend WithEvents txtchofer As TextBox
    Friend WithEvents crear_chofer As Button
    Friend WithEvents crear_vehi As Button
End Class
