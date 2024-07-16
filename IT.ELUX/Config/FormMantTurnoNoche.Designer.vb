<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMantTurnoNoche
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantTurnoNoche))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtper = New System.Windows.Forms.TextBox()
        Me.dptfecha = New System.Windows.Forms.DateTimePicker()
        Me.dtpfecfin = New System.Windows.Forms.DateTimePicker()
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.txtnomper = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblindice = New System.Windows.Forms.Label()
        Me.dgvdatos = New System.Windows.Forms.DataGridView()
        Me.COD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FEC_INICIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FEC_FIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.indice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.tsbForm.SuspendLayout()
        CType(Me.dgvdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "F. Inicio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(158, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "F. Fin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Estado"
        '
        'txtper
        '
        Me.txtper.Location = New System.Drawing.Point(52, 16)
        Me.txtper.MaxLength = 8
        Me.txtper.Name = "txtper"
        Me.txtper.Size = New System.Drawing.Size(68, 20)
        Me.txtper.TabIndex = 4
        '
        'dptfecha
        '
        Me.dptfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dptfecha.Location = New System.Drawing.Point(52, 42)
        Me.dptfecha.Name = "dptfecha"
        Me.dptfecha.Size = New System.Drawing.Size(100, 20)
        Me.dptfecha.TabIndex = 5
        '
        'dtpfecfin
        '
        Me.dtpfecfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecfin.Location = New System.Drawing.Point(194, 45)
        Me.dtpfecfin.Name = "dtpfecfin"
        Me.dtpfecfin.Size = New System.Drawing.Size(100, 20)
        Me.dtpfecfin.TabIndex = 6
        '
        'cmbestado
        '
        Me.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"", "Habilitado", "Anulado"})
        Me.cmbestado.Location = New System.Drawing.Point(52, 68)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(100, 21)
        Me.cmbestado.TabIndex = 7
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbBorrar, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(529, 25)
        Me.tsbForm.TabIndex = 14
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
        'tsbBorrar
        '
        Me.tsbBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbBorrar.Image = CType(resources.GetObject("tsbBorrar.Image"), System.Drawing.Image)
        Me.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBorrar.Name = "tsbBorrar"
        Me.tsbBorrar.Size = New System.Drawing.Size(23, 22)
        Me.tsbBorrar.Tag = "delete"
        Me.tsbBorrar.Text = "Borrar"
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
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(295, 70)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(60, 23)
        Me.btnagregar.TabIndex = 33
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'txtnomper
        '
        Me.txtnomper.Location = New System.Drawing.Point(126, 16)
        Me.txtnomper.MaxLength = 8
        Me.txtnomper.Name = "txtnomper"
        Me.txtnomper.ReadOnly = True
        Me.txtnomper.Size = New System.Drawing.Size(277, 20)
        Me.txtnomper.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(400, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(300, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Indice"
        '
        'lblindice
        '
        Me.lblindice.BackColor = System.Drawing.Color.Gainsboro
        Me.lblindice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblindice.Location = New System.Drawing.Point(342, 45)
        Me.lblindice.Name = "lblindice"
        Me.lblindice.Size = New System.Drawing.Size(52, 20)
        Me.lblindice.TabIndex = 50
        Me.lblindice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvdatos
        '
        Me.dgvdatos.AllowUserToAddRows = False
        Me.dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COD, Me.FEC_INICIO, Me.FEC_FIN, Me.estado, Me.indice})
        Me.dgvdatos.Location = New System.Drawing.Point(9, 100)
        Me.dgvdatos.Name = "dgvdatos"
        Me.dgvdatos.ReadOnly = True
        Me.dgvdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdatos.Size = New System.Drawing.Size(450, 229)
        Me.dgvdatos.TabIndex = 54
        '
        'COD
        '
        Me.COD.HeaderText = "Documentos"
        Me.COD.Name = "COD"
        Me.COD.ReadOnly = True
        '
        'FEC_INICIO
        '
        Me.FEC_INICIO.HeaderText = "Fecha Inicio"
        Me.FEC_INICIO.Name = "FEC_INICIO"
        Me.FEC_INICIO.ReadOnly = True
        '
        'FEC_FIN
        '
        Me.FEC_FIN.HeaderText = "Fecha Fin"
        Me.FEC_FIN.Name = "FEC_FIN"
        Me.FEC_FIN.ReadOnly = True
        '
        'estado
        '
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        Me.estado.Width = 80
        '
        'indice
        '
        Me.indice.HeaderText = "indice"
        Me.indice.Name = "indice"
        Me.indice.ReadOnly = True
        Me.indice.Visible = False
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(361, 71)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(92, 23)
        Me.btnborrar.TabIndex = 55
        Me.btnborrar.Text = "Borrar Datos"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(409, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(500, 364)
        Me.TabControl1.TabIndex = 56
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnnuevo)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.dgvdatos)
        Me.TabPage1.Controls.Add(Me.btnborrar)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtper)
        Me.TabPage1.Controls.Add(Me.lblindice)
        Me.TabPage1.Controls.Add(Me.dptfecha)
        Me.TabPage1.Controls.Add(Me.txtnomper)
        Me.TabPage1.Controls.Add(Me.dtpfecfin)
        Me.TabPage1.Controls.Add(Me.btnagregar)
        Me.TabPage1.Controls.Add(Me.cmbestado)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(492, 338)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Persona"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(229, 71)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(60, 23)
        Me.btnnuevo.TabIndex = 56
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'FormMantTurnoNoche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 413)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.tsbForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormMantTurnoNoche"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMantTurnoNoche"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        CType(Me.dgvdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtper As TextBox
    Friend WithEvents dptfecha As DateTimePicker
    Friend WithEvents dtpfecfin As DateTimePicker
    Friend WithEvents cmbestado As ComboBox
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents btnagregar As Button
    Friend WithEvents txtnomper As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblindice As Label
    Friend WithEvents dgvdatos As DataGridView
    Friend WithEvents btnborrar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnnuevo As Button
    Friend WithEvents COD As DataGridViewTextBoxColumn
    Friend WithEvents FEC_INICIO As DataGridViewTextBoxColumn
    Friend WithEvents FEC_FIN As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents indice As DataGridViewTextBoxColumn
    Friend WithEvents tsbBorrar As ToolStripButton
End Class
