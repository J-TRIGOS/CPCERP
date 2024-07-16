<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormELTBSINTOMASCOVID
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormELTBSINTOMASCOVID))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfec_gene = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtndoc = New System.Windows.Forms.TextBox()
        Me.txtsdoc = New System.Windows.Forms.TextBox()
        Me.txttdoc = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtarea = New System.Windows.Forms.TextBox()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.txtdir = New System.Windows.Forms.TextBox()
        Me.txtnomper = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtobs = New System.Windows.Forms.TextBox()
        Me.cmbs5 = New System.Windows.Forms.ComboBox()
        Me.cmbs4 = New System.Windows.Forms.ComboBox()
        Me.cmbs3 = New System.Windows.Forms.ComboBox()
        Me.cmbs2 = New System.Windows.Forms.ComboBox()
        Me.cmbs1 = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tsbForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbestado)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpfec_gene)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtndoc)
        Me.GroupBox1.Controls.Add(Me.txtsdoc)
        Me.GroupBox1.Controls.Add(Me.txttdoc)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.txtdni)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(605, 93)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar Datos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(474, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 190
        Me.Label4.Text = "Estado"
        '
        'cmbestado
        '
        Me.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"Activo", "Anulado"})
        Me.cmbestado.Location = New System.Drawing.Point(441, 41)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(107, 21)
        Me.cmbestado.TabIndex = 189
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(360, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 188
        Me.Label2.Text = "Fecha"
        '
        'dtpfec_gene
        '
        Me.dtpfec_gene.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_gene.Location = New System.Drawing.Point(331, 41)
        Me.dtpfec_gene.Name = "dtpfec_gene"
        Me.dtpfec_gene.Size = New System.Drawing.Size(100, 20)
        Me.dtpfec_gene.TabIndex = 187
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(240, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 13)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Numero"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(145, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Serie"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Tipo"
        '
        'txtndoc
        '
        Me.txtndoc.Location = New System.Drawing.Point(220, 41)
        Me.txtndoc.Name = "txtndoc"
        Me.txtndoc.ReadOnly = True
        Me.txtndoc.Size = New System.Drawing.Size(100, 20)
        Me.txtndoc.TabIndex = 6
        '
        'txtsdoc
        '
        Me.txtsdoc.Location = New System.Drawing.Point(126, 40)
        Me.txtsdoc.Name = "txtsdoc"
        Me.txtsdoc.ReadOnly = True
        Me.txtsdoc.Size = New System.Drawing.Size(73, 20)
        Me.txtsdoc.TabIndex = 5
        '
        'txttdoc
        '
        Me.txttdoc.Location = New System.Drawing.Point(42, 40)
        Me.txttdoc.Name = "txttdoc"
        Me.txttdoc.ReadOnly = True
        Me.txttdoc.Size = New System.Drawing.Size(54, 20)
        Me.txttdoc.TabIndex = 4
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(149, 64)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 3
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(41, 66)
        Me.txtdni.MaxLength = 8
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(100, 20)
        Me.txtdni.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DNI:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtarea)
        Me.GroupBox2.Controls.Add(Me.txtnum)
        Me.GroupBox2.Controls.Add(Me.txtdir)
        Me.GroupBox2.Controls.Add(Me.txtnomper)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(605, 107)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Empleado"
        '
        'txtarea
        '
        Me.txtarea.Location = New System.Drawing.Point(140, 45)
        Me.txtarea.Name = "txtarea"
        Me.txtarea.ReadOnly = True
        Me.txtarea.Size = New System.Drawing.Size(254, 20)
        Me.txtarea.TabIndex = 13
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(493, 45)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.ReadOnly = True
        Me.txtnum.Size = New System.Drawing.Size(93, 20)
        Me.txtnum.TabIndex = 12
        '
        'txtdir
        '
        Me.txtdir.Location = New System.Drawing.Point(140, 72)
        Me.txtdir.Name = "txtdir"
        Me.txtdir.ReadOnly = True
        Me.txtdir.Size = New System.Drawing.Size(446, 20)
        Me.txtdir.TabIndex = 11
        '
        'txtnomper
        '
        Me.txtnomper.Location = New System.Drawing.Point(140, 19)
        Me.txtnomper.Name = "txtnomper"
        Me.txtnomper.ReadOnly = True
        Me.txtnomper.Size = New System.Drawing.Size(446, 20)
        Me.txtnomper.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(400, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Número (celular):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(79, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Dirección:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Apellidos y Nombres:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Área de Trabajo:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtobs)
        Me.GroupBox3.Controls.Add(Me.cmbs5)
        Me.GroupBox3.Controls.Add(Me.cmbs4)
        Me.GroupBox3.Controls.Add(Me.cmbs3)
        Me.GroupBox3.Controls.Add(Me.cmbs2)
        Me.GroupBox3.Controls.Add(Me.cmbs1)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 257)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(605, 215)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sintomas"
        '
        'txtobs
        '
        Me.txtobs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobs.Location = New System.Drawing.Point(51, 155)
        Me.txtobs.Multiline = True
        Me.txtobs.Name = "txtobs"
        Me.txtobs.Size = New System.Drawing.Size(535, 48)
        Me.txtobs.TabIndex = 11
        '
        'cmbs5
        '
        Me.cmbs5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbs5.FormattingEnabled = True
        Me.cmbs5.Items.AddRange(New Object() {"SI", "NO"})
        Me.cmbs5.Location = New System.Drawing.Point(465, 118)
        Me.cmbs5.Name = "cmbs5"
        Me.cmbs5.Size = New System.Drawing.Size(121, 21)
        Me.cmbs5.TabIndex = 10
        '
        'cmbs4
        '
        Me.cmbs4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbs4.FormattingEnabled = True
        Me.cmbs4.Items.AddRange(New Object() {"SI", "NO"})
        Me.cmbs4.Location = New System.Drawing.Point(465, 93)
        Me.cmbs4.Name = "cmbs4"
        Me.cmbs4.Size = New System.Drawing.Size(121, 21)
        Me.cmbs4.TabIndex = 9
        '
        'cmbs3
        '
        Me.cmbs3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbs3.FormattingEnabled = True
        Me.cmbs3.Items.AddRange(New Object() {"SI", "NO"})
        Me.cmbs3.Location = New System.Drawing.Point(465, 68)
        Me.cmbs3.Name = "cmbs3"
        Me.cmbs3.Size = New System.Drawing.Size(121, 21)
        Me.cmbs3.TabIndex = 8
        '
        'cmbs2
        '
        Me.cmbs2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbs2.FormattingEnabled = True
        Me.cmbs2.Items.AddRange(New Object() {"SI", "NO"})
        Me.cmbs2.Location = New System.Drawing.Point(465, 43)
        Me.cmbs2.Name = "cmbs2"
        Me.cmbs2.Size = New System.Drawing.Size(121, 21)
        Me.cmbs2.TabIndex = 7
        '
        'cmbs1
        '
        Me.cmbs1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbs1.FormattingEnabled = True
        Me.cmbs1.Items.AddRange(New Object() {"SI", "NO"})
        Me.cmbs1.Location = New System.Drawing.Point(465, 18)
        Me.cmbs1.Name = "cmbs1"
        Me.cmbs1.Size = New System.Drawing.Size(121, 21)
        Me.cmbs1.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(48, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "(detalla cuál o cuáles) ."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(37, 121)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(182, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "5. Esta tomando alguna medicación ."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(37, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(324, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "4. Contacto con persona(s) con un caso confirmado de COVID-19 ."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(37, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(218, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "3. Expectoración o flema amarilla o verdosa ."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(37, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(216, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "2. Tos, estornudos o dificultad para respirar ."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(37, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "1. Sensación de alza térmica o fiebre ."
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbimprimir, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(629, 25)
        Me.tsbForm.TabIndex = 46
        Me.tsbForm.Text = "Grabar"
        '
        'tsbGrabar
        '
        Me.tsbGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGrabar.Image = CType(resources.GetObject("tsbGrabar.Image"), System.Drawing.Image)
        Me.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabar.Name = "tsbGrabar"
        Me.tsbGrabar.Size = New System.Drawing.Size(23, 22)
        Me.tsbGrabar.Tag = "save"
        Me.tsbGrabar.Text = "Grabar"
        '
        'tsbimprimir
        '
        Me.tsbimprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbimprimir.Image = CType(resources.GetObject("tsbimprimir.Image"), System.Drawing.Image)
        Me.tsbimprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbimprimir.Name = "tsbimprimir"
        Me.tsbimprimir.Size = New System.Drawing.Size(23, 22)
        Me.tsbimprimir.Tag = "Print"
        Me.tsbimprimir.Text = "Imprimir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Tag = "anular"
        Me.ToolStripButton1.Text = "Anular Documento"
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(23, 22)
        Me.tsbSalir.Tag = "exit"
        Me.tsbSalir.Text = "Salir"
        '
        'FormELTBSINTOMASCOVID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 484)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormELTBSINTOMASCOVID"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormELTBSINTOMASCOVID"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents txtdni As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtarea As TextBox
    Friend WithEvents txtnum As TextBox
    Friend WithEvents txtdir As TextBox
    Friend WithEvents txtnomper As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtobs As TextBox
    Friend WithEvents cmbs5 As ComboBox
    Friend WithEvents cmbs4 As ComboBox
    Friend WithEvents cmbs3 As ComboBox
    Friend WithEvents cmbs2 As ComboBox
    Friend WithEvents cmbs1 As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtndoc As TextBox
    Friend WithEvents txtsdoc As TextBox
    Friend WithEvents txttdoc As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpfec_gene As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbestado As ComboBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
