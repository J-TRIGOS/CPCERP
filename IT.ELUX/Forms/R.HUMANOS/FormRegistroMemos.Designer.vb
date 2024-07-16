<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegistroMemos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistroMemos))
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_codEmp = New System.Windows.Forms.TextBox()
        Me.txt_nomEmp = New System.Windows.Forms.TextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTipMem = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.datFecMem = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_MotSanc = New System.Windows.Forms.TextBox()
        Me.txt_CodSanc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.datFecIniSus = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_diasSusp = New System.Windows.Forms.TextBox()
        Me.datFecFalta = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.datFecFinSus = New System.Windows.Forms.DateTimePicker()
        Me.tsbForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbimprimir, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(697, 25)
        Me.tsbForm.TabIndex = 115
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Empleado:"
        '
        'txt_codEmp
        '
        Me.txt_codEmp.Location = New System.Drawing.Point(89, 36)
        Me.txt_codEmp.Name = "txt_codEmp"
        Me.txt_codEmp.Size = New System.Drawing.Size(65, 20)
        Me.txt_codEmp.TabIndex = 117
        Me.txt_codEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_nomEmp
        '
        Me.txt_nomEmp.Enabled = False
        Me.txt_nomEmp.Location = New System.Drawing.Point(160, 36)
        Me.txt_nomEmp.Name = "txt_nomEmp"
        Me.txt_nomEmp.Size = New System.Drawing.Size(319, 20)
        Me.txt_nomEmp.TabIndex = 118
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Tipo Memo."
        '
        'cmbTipMem
        '
        Me.cmbTipMem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipMem.FormattingEnabled = True
        Me.cmbTipMem.Items.AddRange(New Object() {"MEMORÁNDUM DE SUSPENSIÓN", "MEMORÁNDUM DE LLAMADA DE ATENCIÓN"})
        Me.cmbTipMem.Location = New System.Drawing.Point(89, 62)
        Me.cmbTipMem.Name = "cmbTipMem"
        Me.cmbTipMem.Size = New System.Drawing.Size(264, 21)
        Me.cmbTipMem.TabIndex = 120
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(501, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Fecha Memo:"
        '
        'datFecMem
        '
        Me.datFecMem.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datFecMem.Location = New System.Drawing.Point(579, 36)
        Me.datFecMem.Name = "datFecMem"
        Me.datFecMem.Size = New System.Drawing.Size(97, 20)
        Me.datFecMem.TabIndex = 119
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Cod. Sanción"
        '
        'txt_MotSanc
        '
        Me.txt_MotSanc.Location = New System.Drawing.Point(89, 115)
        Me.txt_MotSanc.Multiline = True
        Me.txt_MotSanc.Name = "txt_MotSanc"
        Me.txt_MotSanc.Size = New System.Drawing.Size(366, 58)
        Me.txt_MotSanc.TabIndex = 122
        '
        'txt_CodSanc
        '
        Me.txt_CodSanc.Location = New System.Drawing.Point(89, 89)
        Me.txt_CodSanc.Name = "txt_CodSanc"
        Me.txt_CodSanc.Size = New System.Drawing.Size(52, 20)
        Me.txt_CodSanc.TabIndex = 121
        Me.txt_CodSanc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "Mot. Sanción"
        '
        'datFecIniSus
        '
        Me.datFecIniSus.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datFecIniSus.Location = New System.Drawing.Point(283, 179)
        Me.datFecIniSus.Name = "datFecIniSus"
        Me.datFecIniSus.Size = New System.Drawing.Size(97, 20)
        Me.datFecIniSus.TabIndex = 127
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(191, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 128
        Me.Label6.Text = "Fec. Inicio Susp."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(394, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 129
        Me.Label7.Text = "Dias Susp.:"
        '
        'txt_diasSusp
        '
        Me.txt_diasSusp.Location = New System.Drawing.Point(461, 179)
        Me.txt_diasSusp.Name = "txt_diasSusp"
        Me.txt_diasSusp.Size = New System.Drawing.Size(31, 20)
        Me.txt_diasSusp.TabIndex = 130
        Me.txt_diasSusp.Text = "0"
        Me.txt_diasSusp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'datFecFalta
        '
        Me.datFecFalta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datFecFalta.Location = New System.Drawing.Point(88, 179)
        Me.datFecFalta.Name = "datFecFalta"
        Me.datFecFalta.Size = New System.Drawing.Size(97, 20)
        Me.datFecFalta.TabIndex = 131
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 132
        Me.Label8.Text = "Fec. Falta:"
        '
        'datFecFinSus
        '
        Me.datFecFinSus.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datFecFinSus.Location = New System.Drawing.Point(347, 118)
        Me.datFecFinSus.Name = "datFecFinSus"
        Me.datFecFinSus.Size = New System.Drawing.Size(98, 20)
        Me.datFecFinSus.TabIndex = 133
        Me.datFecFinSus.Visible = False
        '
        'FormRegistroMemos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 233)
        Me.Controls.Add(Me.datFecFalta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_diasSusp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.datFecIniSus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_CodSanc)
        Me.Controls.Add(Me.txt_MotSanc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.datFecMem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbTipMem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nomEmp)
        Me.Controls.Add(Me.txt_codEmp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.datFecFinSus)
        Me.Name = "FormRegistroMemos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_codEmp As TextBox
    Friend WithEvents txt_nomEmp As TextBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbTipMem As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents datFecMem As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_MotSanc As TextBox
    Friend WithEvents txt_CodSanc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents datFecIniSus As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_diasSusp As TextBox
    Friend WithEvents datFecFalta As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents datFecFinSus As DateTimePicker
End Class
