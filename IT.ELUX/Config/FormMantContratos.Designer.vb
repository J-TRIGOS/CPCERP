<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMantContratos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantContratos))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.btnCambiar = New System.Windows.Forms.Button()
        Me.lblindice = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkactivar = New System.Windows.Forms.CheckBox()
        Me.txtdias = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.dgvdatos = New System.Windows.Forms.DataGridView()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F_INI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F_FIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Indice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpfecha_fin = New System.Windows.Forms.DateTimePicker()
        Me.dtpfecha_ini = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1.SuspendLayout()
        Me.General.SuspendLayout()
        CType(Me.dgvdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsbForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 36)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(612, 416)
        Me.TabControl1.TabIndex = 28
        '
        'General
        '
        Me.General.BackColor = System.Drawing.Color.White
        Me.General.Controls.Add(Me.btnCambiar)
        Me.General.Controls.Add(Me.lblindice)
        Me.General.Controls.Add(Me.lbl2)
        Me.General.Controls.Add(Me.Label3)
        Me.General.Controls.Add(Me.chkactivar)
        Me.General.Controls.Add(Me.txtdias)
        Me.General.Controls.Add(Me.btnBorrar)
        Me.General.Controls.Add(Me.btnbuscar)
        Me.General.Controls.Add(Me.dgvdatos)
        Me.General.Controls.Add(Me.Label2)
        Me.General.Controls.Add(Me.Label1)
        Me.General.Controls.Add(Me.dtpfecha_fin)
        Me.General.Controls.Add(Me.dtpfecha_ini)
        Me.General.Controls.Add(Me.Label10)
        Me.General.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(604, 390)
        Me.General.TabIndex = 0
        Me.General.Text = "GENERAL"
        '
        'btnCambiar
        '
        Me.btnCambiar.Location = New System.Drawing.Point(437, 42)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.Size = New System.Drawing.Size(93, 23)
        Me.btnCambiar.TabIndex = 133
        Me.btnCambiar.Text = "Cambiar Fecha"
        Me.btnCambiar.UseVisualStyleBackColor = True
        '
        'lblindice
        '
        Me.lblindice.AutoSize = True
        Me.lblindice.Location = New System.Drawing.Point(479, 50)
        Me.lblindice.Name = "lblindice"
        Me.lblindice.Size = New System.Drawing.Size(0, 13)
        Me.lblindice.TabIndex = 132
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.lbl2.Location = New System.Drawing.Point(463, 369)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(113, 13)
        Me.lbl2.TabIndex = 130
        Me.lbl2.Text = "   Contrato Vigente     "
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 23)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Nro dias"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkactivar
        '
        Me.chkactivar.AutoSize = True
        Me.chkactivar.Location = New System.Drawing.Point(94, 45)
        Me.chkactivar.Name = "chkactivar"
        Me.chkactivar.Size = New System.Drawing.Size(60, 17)
        Me.chkactivar.TabIndex = 127
        Me.chkactivar.Text = "Activar"
        Me.chkactivar.UseVisualStyleBackColor = True
        '
        'txtdias
        '
        Me.txtdias.Location = New System.Drawing.Point(160, 42)
        Me.txtdias.MaxLength = 3
        Me.txtdias.Name = "txtdias"
        Me.txtdias.Size = New System.Drawing.Size(46, 21)
        Me.txtdias.TabIndex = 128
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(28, 364)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(95, 23)
        Me.btnBorrar.TabIndex = 126
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(93, 12)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(114, 23)
        Me.btnbuscar.TabIndex = 125
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'dgvdatos
        '
        Me.dgvdatos.AllowUserToAddRows = False
        Me.dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DNI, Me.NOMBRE, Me.F_INI, Me.F_FIN, Me.Indice})
        Me.dgvdatos.Location = New System.Drawing.Point(29, 77)
        Me.dgvdatos.Name = "dgvdatos"
        Me.dgvdatos.ReadOnly = True
        Me.dgvdatos.Size = New System.Drawing.Size(547, 285)
        Me.dgvdatos.TabIndex = 124
        '
        'DNI
        '
        Me.DNI.HeaderText = "Documento"
        Me.DNI.Name = "DNI"
        Me.DNI.ReadOnly = True
        Me.DNI.Width = 80
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "Nombres y Apellidos"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        Me.NOMBRE.Width = 220
        '
        'F_INI
        '
        Me.F_INI.HeaderText = "Fecha Inicio"
        Me.F_INI.Name = "F_INI"
        Me.F_INI.ReadOnly = True
        '
        'F_FIN
        '
        Me.F_FIN.HeaderText = "Fecha Fin"
        Me.F_FIN.Name = "F_FIN"
        Me.F_FIN.ReadOnly = True
        '
        'Indice
        '
        Me.Indice.HeaderText = "Indice"
        Me.Indice.Name = "Indice"
        Me.Indice.ReadOnly = True
        Me.Indice.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(249, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 23)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Fecha Fin"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(249, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 23)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Fecha Inicio"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpfecha_fin
        '
        Me.dtpfecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_fin.Location = New System.Drawing.Point(327, 43)
        Me.dtpfecha_fin.Name = "dtpfecha_fin"
        Me.dtpfecha_fin.Size = New System.Drawing.Size(95, 21)
        Me.dtpfecha_fin.TabIndex = 119
        Me.dtpfecha_fin.Value = New Date(2021, 10, 2, 0, 0, 0, 0)
        '
        'dtpfecha_ini
        '
        Me.dtpfecha_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_ini.Location = New System.Drawing.Point(327, 14)
        Me.dtpfecha_ini.Name = "dtpfecha_ini"
        Me.dtpfecha_ini.Size = New System.Drawing.Size(95, 21)
        Me.dtpfecha_ini.TabIndex = 118
        Me.dtpfecha_ini.Value = New Date(2021, 10, 2, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 23)
        Me.Label10.TabIndex = 116
        Me.Label10.Text = "Personal"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbBorrar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(644, 25)
        Me.tsbForm.TabIndex = 29
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
        'tsbBorrar
        '
        Me.tsbBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBorrar.Name = "tsbBorrar"
        Me.tsbBorrar.Size = New System.Drawing.Size(23, 22)
        Me.tsbBorrar.Tag = "delete"
        Me.tsbBorrar.Text = "Borrar"
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
        'FormMantContratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 454)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormMantContratos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Periodo de Contratos"
        Me.TabControl1.ResumeLayout(False)
        Me.General.ResumeLayout(False)
        Me.General.PerformLayout()
        CType(Me.dgvdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents General As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbBorrar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpfecha_fin As DateTimePicker
    Friend WithEvents dtpfecha_ini As DateTimePicker
    Friend WithEvents dgvdatos As DataGridView
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents txtdias As TextBox
    Friend WithEvents chkactivar As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DNI As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents F_INI As DataGridViewTextBoxColumn
    Friend WithEvents F_FIN As DataGridViewTextBoxColumn
    Friend WithEvents Indice As DataGridViewTextBoxColumn
    Friend WithEvents lbl2 As Label
    Friend WithEvents lblindice As Label
    Friend WithEvents btnCambiar As Button
End Class
