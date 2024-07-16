<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistroVacunas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistroVacunas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.txt_empleado = New System.Windows.Forms.TextBox()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmb_dosis = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_laboratorio = New System.Windows.Forms.ComboBox()
        Me.dgvListadoVac = New System.Windows.Forms.DataGridView()
        Me.datFecVac = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_lugar = New System.Windows.Forms.TextBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.tsbForm.SuspendLayout()
        CType(Me.dgvListadoVac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empleado:"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(73, 43)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(85, 20)
        Me.txt_codigo.TabIndex = 1
        '
        'txt_empleado
        '
        Me.txt_empleado.Enabled = False
        Me.txt_empleado.Location = New System.Drawing.Point(164, 43)
        Me.txt_empleado.Name = "txt_empleado"
        Me.txt_empleado.Size = New System.Drawing.Size(403, 20)
        Me.txt_empleado.TabIndex = 2
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbimprimir, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(606, 25)
        Me.tsbForm.TabIndex = 114
        Me.tsbForm.Text = "Grabar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cmb_dosis
        '
        Me.cmb_dosis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_dosis.FormattingEnabled = True
        Me.cmb_dosis.Items.AddRange(New Object() {"1° DOSIS", "2° DOSIS", "3° DOSIS", "4° DOSIS", "5° DOSIS"})
        Me.cmb_dosis.Location = New System.Drawing.Point(73, 69)
        Me.cmb_dosis.Name = "cmb_dosis"
        Me.cmb_dosis.Size = New System.Drawing.Size(121, 21)
        Me.cmb_dosis.TabIndex = 115
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "Dosis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "Laboratorio"
        '
        'cmb_laboratorio
        '
        Me.cmb_laboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_laboratorio.FormattingEnabled = True
        Me.cmb_laboratorio.Items.AddRange(New Object() {"ASTRAZENECA", "PFIZER", "SINOPHARM"})
        Me.cmb_laboratorio.Location = New System.Drawing.Point(73, 96)
        Me.cmb_laboratorio.Name = "cmb_laboratorio"
        Me.cmb_laboratorio.Size = New System.Drawing.Size(121, 21)
        Me.cmb_laboratorio.TabIndex = 118
        '
        'dgvListadoVac
        '
        Me.dgvListadoVac.AllowUserToAddRows = False
        Me.dgvListadoVac.AllowUserToDeleteRows = False
        Me.dgvListadoVac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoVac.Location = New System.Drawing.Point(43, 180)
        Me.dgvListadoVac.Name = "dgvListadoVac"
        Me.dgvListadoVac.ReadOnly = True
        Me.dgvListadoVac.Size = New System.Drawing.Size(551, 133)
        Me.dgvListadoVac.TabIndex = 119
        '
        'datFecVac
        '
        Me.datFecVac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datFecVac.Location = New System.Drawing.Point(274, 69)
        Me.datFecVac.Name = "datFecVac"
        Me.datFecVac.Size = New System.Drawing.Size(79, 20)
        Me.datFecVac.TabIndex = 120
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(231, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "Lugar"
        '
        'txt_lugar
        '
        Me.txt_lugar.Location = New System.Drawing.Point(73, 124)
        Me.txt_lugar.Multiline = True
        Me.txt_lugar.Name = "txt_lugar"
        Me.txt_lugar.Size = New System.Drawing.Size(280, 50)
        Me.txt_lugar.TabIndex = 123
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Image = Global.IT.ELUX.My.Resources.Resources.Delete_Ico
        Me.btn_eliminar.Location = New System.Drawing.Point(8, 180)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(29, 23)
        Me.btn_eliminar.TabIndex = 124
        Me.btn_eliminar.UseVisualStyleBackColor = True
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
        'FormRegistroVacunas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 325)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.txt_lugar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.datFecVac)
        Me.Controls.Add(Me.dgvListadoVac)
        Me.Controls.Add(Me.cmb_laboratorio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_dosis)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.txt_empleado)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormRegistroVacunas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRegistroVacunas"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        CType(Me.dgvListadoVac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents txt_empleado As TextBox
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents cmb_dosis As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_laboratorio As ComboBox
    Friend WithEvents dgvListadoVac As DataGridView
    Friend WithEvents datFecVac As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_lugar As TextBox
    Friend WithEvents btn_eliminar As Button
End Class
