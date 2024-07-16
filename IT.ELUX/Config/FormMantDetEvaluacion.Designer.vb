<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMantDetEvaluacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantDetEvaluacion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rpta3 = New System.Windows.Forms.TextBox()
        Me.rpta2 = New System.Windows.Forms.TextBox()
        Me.txtrpta1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkM = New System.Windows.Forms.RadioButton()
        Me.chkR = New System.Windows.Forms.RadioButton()
        Me.chkB = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkS = New System.Windows.Forms.RadioButton()
        Me.chkN = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.sgcia = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkSi = New System.Windows.Forms.RadioButton()
        Me.chkNo = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmtro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.npdNoEva = New System.Windows.Forms.NumericUpDown()
        Me.npdNoCap = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tsbForm.SuspendLayout()
        CType(Me.npdNoEva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdNoCap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rpta3)
        Me.GroupBox1.Controls.Add(Me.rpta2)
        Me.GroupBox1.Controls.Add(Me.txtrpta1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(620, 178)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Preguntas"
        '
        'rpta3
        '
        Me.rpta3.Location = New System.Drawing.Point(95, 123)
        Me.rpta3.Multiline = True
        Me.rpta3.Name = "rpta3"
        Me.rpta3.Size = New System.Drawing.Size(506, 45)
        Me.rpta3.TabIndex = 248
        '
        'rpta2
        '
        Me.rpta2.Location = New System.Drawing.Point(95, 72)
        Me.rpta2.Multiline = True
        Me.rpta2.Name = "rpta2"
        Me.rpta2.Size = New System.Drawing.Size(506, 45)
        Me.rpta2.TabIndex = 247
        '
        'txtrpta1
        '
        Me.txtrpta1.Location = New System.Drawing.Point(95, 19)
        Me.txtrpta1.Multiline = True
        Me.txtrpta1.Name = "txtrpta1"
        Me.txtrpta1.Size = New System.Drawing.Size(506, 46)
        Me.txtrpta1.TabIndex = 246
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(16, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Respuesta 3 :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Respuesta 2 :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Respuesta 1 :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(14, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 13)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "¿Como evaluaría la presente capacitación?"
        '
        'chkM
        '
        Me.chkM.AutoSize = True
        Me.chkM.Location = New System.Drawing.Point(36, 46)
        Me.chkM.Name = "chkM"
        Me.chkM.Size = New System.Drawing.Size(48, 17)
        Me.chkM.TabIndex = 74
        Me.chkM.TabStop = True
        Me.chkM.Text = "Malo"
        Me.chkM.UseVisualStyleBackColor = True
        '
        'chkR
        '
        Me.chkR.AutoSize = True
        Me.chkR.Location = New System.Drawing.Point(92, 46)
        Me.chkR.Name = "chkR"
        Me.chkR.Size = New System.Drawing.Size(62, 17)
        Me.chkR.TabIndex = 75
        Me.chkR.TabStop = True
        Me.chkR.Text = "Regular"
        Me.chkR.UseVisualStyleBackColor = True
        '
        'chkB
        '
        Me.chkB.AutoSize = True
        Me.chkB.Location = New System.Drawing.Point(161, 46)
        Me.chkB.Name = "chkB"
        Me.chkB.Size = New System.Drawing.Size(56, 17)
        Me.chkB.TabIndex = 76
        Me.chkB.TabStop = True
        Me.chkB.Text = "Bueno"
        Me.chkB.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(15, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 13)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Ha entendido la capacitación"
        '
        'chkS
        '
        Me.chkS.AutoSize = True
        Me.chkS.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkS.Location = New System.Drawing.Point(44, 46)
        Me.chkS.Name = "chkS"
        Me.chkS.Size = New System.Drawing.Size(34, 17)
        Me.chkS.TabIndex = 78
        Me.chkS.TabStop = True
        Me.chkS.Text = "Si"
        Me.chkS.UseVisualStyleBackColor = True
        '
        'chkN
        '
        Me.chkN.AutoSize = True
        Me.chkN.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkN.Location = New System.Drawing.Point(84, 46)
        Me.chkN.Name = "chkN"
        Me.chkN.Size = New System.Drawing.Size(39, 17)
        Me.chkN.TabIndex = 79
        Me.chkN.TabStop = True
        Me.chkN.Text = "No"
        Me.chkN.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.sgcia)
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 206)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(620, 163)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Evaluación del capacitado"
        '
        'sgcia
        '
        Me.sgcia.Location = New System.Drawing.Point(95, 105)
        Me.sgcia.Multiline = True
        Me.sgcia.Name = "sgcia"
        Me.sgcia.Size = New System.Drawing.Size(506, 45)
        Me.sgcia.TabIndex = 249
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.chkB)
        Me.GroupBox7.Controls.Add(Me.chkR)
        Me.GroupBox7.Controls.Add(Me.chkM)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 15)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(249, 75)
        Me.GroupBox7.TabIndex = 85
        Me.GroupBox7.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.chkS)
        Me.GroupBox6.Controls.Add(Me.chkN)
        Me.GroupBox6.Location = New System.Drawing.Point(262, 15)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(173, 75)
        Me.GroupBox6.TabIndex = 84
        Me.GroupBox6.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkSi)
        Me.GroupBox5.Controls.Add(Me.chkNo)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Location = New System.Drawing.Point(442, 15)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(171, 75)
        Me.GroupBox5.TabIndex = 83
        Me.GroupBox5.TabStop = False
        '
        'chkSi
        '
        Me.chkSi.AutoSize = True
        Me.chkSi.Location = New System.Drawing.Point(40, 47)
        Me.chkSi.Name = "chkSi"
        Me.chkSi.Size = New System.Drawing.Size(34, 17)
        Me.chkSi.TabIndex = 81
        Me.chkSi.Text = "Si"
        Me.chkSi.UseVisualStyleBackColor = True
        '
        'chkNo
        '
        Me.chkNo.AutoSize = True
        Me.chkNo.Location = New System.Drawing.Point(80, 47)
        Me.chkNo.Name = "chkNo"
        Me.chkNo.Size = New System.Drawing.Size(39, 17)
        Me.chkNo.TabIndex = 82
        Me.chkNo.Text = "No"
        Me.chkNo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(7, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 13)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Desea capacitarse nuevamente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(19, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Surgerencia :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmtro)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 375)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(620, 87)
        Me.GroupBox3.TabIndex = 73
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Solo para ser llenado por el responsable de la evaluación"
        '
        'cmtro
        '
        Me.cmtro.Location = New System.Drawing.Point(93, 25)
        Me.cmtro.Multiline = True
        Me.cmtro.Name = "cmtro"
        Me.cmtro.Size = New System.Drawing.Size(506, 45)
        Me.cmtro.TabIndex = 250
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(16, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Comentarios :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.npdNoCap)
        Me.GroupBox4.Controls.Add(Me.npdNoEva)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 468)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(620, 66)
        Me.GroupBox4.TabIndex = 74
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Nota"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(333, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 13)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "Nota para el capacitador :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(50, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 13)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Nota de la evaluación :"
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbimprimir, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(630, 25)
        Me.tsbForm.TabIndex = 245
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
        Me.tsbimprimir.Visible = False
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
        Me.ToolStripButton1.Visible = False
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
        'npdNoEva
        '
        Me.npdNoEva.Location = New System.Drawing.Point(173, 24)
        Me.npdNoEva.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.npdNoEva.Name = "npdNoEva"
        Me.npdNoEva.Size = New System.Drawing.Size(86, 20)
        Me.npdNoEva.TabIndex = 77
        '
        'npdNoCap
        '
        Me.npdNoCap.Location = New System.Drawing.Point(469, 24)
        Me.npdNoCap.Name = "npdNoCap"
        Me.npdNoCap.Size = New System.Drawing.Size(98, 20)
        Me.npdNoCap.TabIndex = 78
        '
        'FormMantDetEvaluacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 541)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormMantDetEvaluacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMantDetEvaluacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        CType(Me.npdNoEva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdNoCap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents chkM As RadioButton
    Friend WithEvents chkR As RadioButton
    Friend WithEvents chkB As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents chkS As RadioButton
    Friend WithEvents chkN As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chkNo As RadioButton
    Friend WithEvents chkSi As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents rpta3 As TextBox
    Friend WithEvents rpta2 As TextBox
    Friend WithEvents txtrpta1 As TextBox
    Friend WithEvents sgcia As TextBox
    Friend WithEvents cmtro As TextBox
    Friend WithEvents npdNoCap As NumericUpDown
    Friend WithEvents npdNoEva As NumericUpDown
End Class
