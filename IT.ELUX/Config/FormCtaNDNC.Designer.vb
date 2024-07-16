<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCtaNDNC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCtaNDNC))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttipo = New System.Windows.Forms.TextBox()
        Me.txtser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmon = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnomtip = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_bruta = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.btntodos = New System.Windows.Forms.Button()
        Me.btn_br = New System.Windows.Forms.Button()
        Me.txtmonnom = New System.Windows.Forms.TextBox()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.txtcodcli = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnomcli = New System.Windows.Forms.TextBox()
        Me.txtnom_cli = New System.Windows.Forms.TextBox()
        Me.txtcod_cli = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpfec_ven = New System.Windows.Forms.DateTimePicker()
        Me.tsbForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo"
        '
        'txttipo
        '
        Me.txttipo.Location = New System.Drawing.Point(90, 44)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.ReadOnly = True
        Me.txttipo.Size = New System.Drawing.Size(100, 20)
        Me.txttipo.TabIndex = 10
        '
        'txtser
        '
        Me.txtser.Location = New System.Drawing.Point(90, 70)
        Me.txtser.Name = "txtser"
        Me.txtser.ReadOnly = True
        Me.txtser.Size = New System.Drawing.Size(100, 20)
        Me.txtser.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Serie"
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(246, 70)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.ReadOnly = True
        Me.txtnum.Size = New System.Drawing.Size(100, 20)
        Me.txtnum.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Numero"
        '
        'txtmon
        '
        Me.txtmon.Location = New System.Drawing.Point(429, 70)
        Me.txtmon.Name = "txtmon"
        Me.txtmon.ReadOnly = True
        Me.txtmon.Size = New System.Drawing.Size(35, 20)
        Me.txtmon.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(377, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Moneda"
        '
        'txtnomtip
        '
        Me.txtnomtip.Location = New System.Drawing.Point(196, 44)
        Me.txtnomtip.Name = "txtnomtip"
        Me.txtnomtip.ReadOnly = True
        Me.txtnomtip.Size = New System.Drawing.Size(400, 20)
        Me.txtnomtip.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cuenta"
        '
        'txt_bruta
        '
        Me.txt_bruta.Location = New System.Drawing.Point(90, 96)
        Me.txt_bruta.Name = "txt_bruta"
        Me.txt_bruta.Size = New System.Drawing.Size(100, 20)
        Me.txt_bruta.TabIndex = 1
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(196, 96)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(316, 20)
        Me.TextBox6.TabIndex = 2
        '
        'btntodos
        '
        Me.btntodos.Location = New System.Drawing.Point(551, 94)
        Me.btntodos.Name = "btntodos"
        Me.btntodos.Size = New System.Drawing.Size(45, 23)
        Me.btntodos.TabIndex = 4
        Me.btntodos.Tag = "1"
        Me.btntodos.Text = "Todos"
        Me.btntodos.UseVisualStyleBackColor = True
        '
        'btn_br
        '
        Me.btn_br.Location = New System.Drawing.Point(518, 94)
        Me.btn_br.Name = "btn_br"
        Me.btn_br.Size = New System.Drawing.Size(34, 23)
        Me.btn_br.TabIndex = 3
        Me.btn_br.Tag = "1"
        Me.btn_br.Text = "..."
        Me.btn_br.UseVisualStyleBackColor = True
        '
        'txtmonnom
        '
        Me.txtmonnom.Location = New System.Drawing.Point(470, 70)
        Me.txtmonnom.Name = "txtmonnom"
        Me.txtmonnom.ReadOnly = True
        Me.txtmonnom.Size = New System.Drawing.Size(126, 20)
        Me.txtmonnom.TabIndex = 15
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(634, 25)
        Me.tsbForm.TabIndex = 26
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'txtcodcli
        '
        Me.txtcodcli.Location = New System.Drawing.Point(90, 96)
        Me.txtcodcli.Name = "txtcodcli"
        Me.txtcodcli.ReadOnly = True
        Me.txtcodcli.Size = New System.Drawing.Size(100, 20)
        Me.txtcodcli.TabIndex = 16
        Me.txtcodcli.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Cliente"
        Me.Label6.Visible = False
        '
        'txtnomcli
        '
        Me.txtnomcli.Location = New System.Drawing.Point(196, 96)
        Me.txtnomcli.Name = "txtnomcli"
        Me.txtnomcli.ReadOnly = True
        Me.txtnomcli.Size = New System.Drawing.Size(400, 20)
        Me.txtnomcli.TabIndex = 17
        Me.txtnomcli.Visible = False
        '
        'txtnom_cli
        '
        Me.txtnom_cli.Location = New System.Drawing.Point(196, 122)
        Me.txtnom_cli.Name = "txtnom_cli"
        Me.txtnom_cli.ReadOnly = True
        Me.txtnom_cli.Size = New System.Drawing.Size(316, 20)
        Me.txtnom_cli.TabIndex = 29
        '
        'txtcod_cli
        '
        Me.txtcod_cli.Location = New System.Drawing.Point(90, 122)
        Me.txtcod_cli.Name = "txtcod_cli"
        Me.txtcod_cli.ReadOnly = True
        Me.txtcod_cli.Size = New System.Drawing.Size(100, 20)
        Me.txtcod_cli.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Cliente"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Fecha"
        '
        'dtpfec_ven
        '
        Me.dtpfec_ven.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ven.Location = New System.Drawing.Point(90, 148)
        Me.dtpfec_ven.Name = "dtpfec_ven"
        Me.dtpfec_ven.Size = New System.Drawing.Size(111, 20)
        Me.dtpfec_ven.TabIndex = 34
        '
        'FormCtaNDNC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 179)
        Me.ControlBox = False
        Me.Controls.Add(Me.dtpfec_ven)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtnom_cli)
        Me.Controls.Add(Me.txtcod_cli)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.txtmonnom)
        Me.Controls.Add(Me.btntodos)
        Me.Controls.Add(Me.btn_br)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.txt_bruta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnomtip)
        Me.Controls.Add(Me.txtmon)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnomcli)
        Me.Controls.Add(Me.txtcodcli)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormCtaNDNC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCtaNDNC"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txttipo As TextBox
    Friend WithEvents txtser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtmon As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnomtip As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_bruta As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents btntodos As Button
    Friend WithEvents btn_br As Button
    Friend WithEvents txtmonnom As TextBox
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents txtcodcli As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtnomcli As TextBox
    Friend WithEvents txtnom_cli As TextBox
    Friend WithEvents txtcod_cli As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpfec_ven As DateTimePicker
End Class
