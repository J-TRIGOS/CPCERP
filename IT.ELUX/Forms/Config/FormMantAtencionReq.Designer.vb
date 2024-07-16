<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMantAtencionReq
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantAtencionReq))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttipo = New System.Windows.Forms.TextBox()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.txtarticulo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnomart = New System.Windows.Forms.TextBox()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpfecent = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnomsol = New System.Windows.Forms.TextBox()
        Me.txtnoment = New System.Windows.Forms.TextBox()
        Me.txtsoli = New System.Windows.Forms.TextBox()
        Me.txtent = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tsbForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Serie"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(293, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Número"
        '
        'txttipo
        '
        Me.txttipo.Location = New System.Drawing.Point(67, 39)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.ReadOnly = True
        Me.txttipo.Size = New System.Drawing.Size(72, 20)
        Me.txttipo.TabIndex = 3
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(188, 39)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.ReadOnly = True
        Me.txtserie.Size = New System.Drawing.Size(94, 20)
        Me.txtserie.TabIndex = 4
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(343, 39)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.ReadOnly = True
        Me.txtnumero.Size = New System.Drawing.Size(100, 20)
        Me.txtnumero.TabIndex = 5
        '
        'txtarticulo
        '
        Me.txtarticulo.Location = New System.Drawing.Point(66, 74)
        Me.txtarticulo.Name = "txtarticulo"
        Me.txtarticulo.ReadOnly = True
        Me.txtarticulo.Size = New System.Drawing.Size(72, 20)
        Me.txtarticulo.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Articulo"
        '
        'txtnomart
        '
        Me.txtnomart.Location = New System.Drawing.Point(147, 74)
        Me.txtnomart.Name = "txtnomart"
        Me.txtnomart.ReadOnly = True
        Me.txtnomart.Size = New System.Drawing.Size(295, 20)
        Me.txtnomart.TabIndex = 8
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(486, 25)
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "F. Entrega"
        '
        'dtpfecent
        '
        Me.dtpfecent.Checked = False
        Me.dtpfecent.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecent.Location = New System.Drawing.Point(66, 112)
        Me.dtpfecent.Name = "dtpfecent"
        Me.dtpfecent.ShowCheckBox = True
        Me.dtpfecent.Size = New System.Drawing.Size(107, 20)
        Me.dtpfecent.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Solicitado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Entregado"
        '
        'txtnomsol
        '
        Me.txtnomsol.Location = New System.Drawing.Point(148, 147)
        Me.txtnomsol.Name = "txtnomsol"
        Me.txtnomsol.ReadOnly = True
        Me.txtnomsol.Size = New System.Drawing.Size(293, 20)
        Me.txtnomsol.TabIndex = 31
        '
        'txtnoment
        '
        Me.txtnoment.Location = New System.Drawing.Point(147, 177)
        Me.txtnoment.Name = "txtnoment"
        Me.txtnoment.ReadOnly = True
        Me.txtnoment.Size = New System.Drawing.Size(296, 20)
        Me.txtnoment.TabIndex = 32
        '
        'txtsoli
        '
        Me.txtsoli.Location = New System.Drawing.Point(66, 147)
        Me.txtsoli.MaxLength = 8
        Me.txtsoli.Name = "txtsoli"
        Me.txtsoli.Size = New System.Drawing.Size(72, 20)
        Me.txtsoli.TabIndex = 33
        '
        'txtent
        '
        Me.txtent.Location = New System.Drawing.Point(66, 177)
        Me.txtent.MaxLength = 8
        Me.txtent.Name = "txtent"
        Me.txtent.Size = New System.Drawing.Size(72, 20)
        Me.txtent.TabIndex = 34
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(447, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(447, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(26, 23)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormMantAtencionReq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 228)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtent)
        Me.Controls.Add(Me.txtsoli)
        Me.Controls.Add(Me.txtnoment)
        Me.Controls.Add(Me.txtnomsol)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpfecent)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.txtnomart)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtarticulo)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.txtserie)
        Me.Controls.Add(Me.txttipo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormMantAtencionReq"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMantAtencionReq"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txttipo As TextBox
    Friend WithEvents txtserie As TextBox
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents txtarticulo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnomart As TextBox
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpfecent As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtnomsol As TextBox
    Friend WithEvents txtnoment As TextBox
    Friend WithEvents txtsoli As TextBox
    Friend WithEvents txtent As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
