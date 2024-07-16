<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMantELTBTAREO
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
        Me.btninsertar = New System.Windows.Forms.Button()
        Me.btncargararch = New System.Windows.Forms.Button()
        Me.dgvdatos = New System.Windows.Forms.DataGridView()
        Me.COD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblindice = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dpthora = New System.Windows.Forms.DateTimePicker()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dptfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblper = New System.Windows.Forms.Label()
        Me.txtper = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btninsertar
        '
        Me.btninsertar.Location = New System.Drawing.Point(20, 409)
        Me.btninsertar.Name = "btninsertar"
        Me.btninsertar.Size = New System.Drawing.Size(92, 23)
        Me.btninsertar.TabIndex = 9
        Me.btninsertar.Text = "Insertar Datos"
        Me.btninsertar.UseVisualStyleBackColor = True
        '
        'btncargararch
        '
        Me.btncargararch.Location = New System.Drawing.Point(7, 21)
        Me.btncargararch.Name = "btncargararch"
        Me.btncargararch.Size = New System.Drawing.Size(229, 23)
        Me.btncargararch.TabIndex = 6
        Me.btncargararch.Text = "Abrir Archivo"
        Me.btncargararch.UseVisualStyleBackColor = True
        '
        'dgvdatos
        '
        Me.dgvdatos.AllowUserToAddRows = False
        Me.dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COD, Me.FECHA})
        Me.dgvdatos.Location = New System.Drawing.Point(21, 179)
        Me.dgvdatos.Name = "dgvdatos"
        Me.dgvdatos.ReadOnly = True
        Me.dgvdatos.Size = New System.Drawing.Size(515, 229)
        Me.dgvdatos.TabIndex = 5
        '
        'COD
        '
        Me.COD.HeaderText = "Documentos"
        Me.COD.Name = "COD"
        Me.COD.ReadOnly = True
        '
        'FECHA
        '
        Me.FECHA.HeaderText = "Fecha y Hora"
        Me.FECHA.Name = "FECHA"
        Me.FECHA.ReadOnly = True
        Me.FECHA.Width = 200
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = """Excel Worksheets|*.DAT"""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblindice)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dpthora)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.dptfecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblper)
        Me.GroupBox1.Controls.Add(Me.txtper)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 96)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Manualmente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(204, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Indice"
        '
        'lblindice
        '
        Me.lblindice.BackColor = System.Drawing.Color.Gainsboro
        Me.lblindice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblindice.Location = New System.Drawing.Point(89, 67)
        Me.lblindice.Name = "lblindice"
        Me.lblindice.Size = New System.Drawing.Size(52, 20)
        Me.lblindice.TabIndex = 47
        Me.lblindice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(204, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Hora"
        '
        'dpthora
        '
        Me.dpthora.Checked = False
        Me.dpthora.CustomFormat = ""
        Me.dpthora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dpthora.Location = New System.Drawing.Point(246, 43)
        Me.dpthora.Name = "dpthora"
        Me.dpthora.ShowUpDown = True
        Me.dpthora.Size = New System.Drawing.Size(95, 20)
        Me.dpthora.TabIndex = 45
        Me.dpthora.Value = New Date(2018, 11, 30, 14, 14, 0, 0)
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(434, 45)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 22)
        Me.btnAgregar.TabIndex = 44
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dptfecha
        '
        Me.dptfecha.Checked = False
        Me.dptfecha.CustomFormat = ""
        Me.dptfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dptfecha.Location = New System.Drawing.Point(89, 43)
        Me.dptfecha.Name = "dptfecha"
        Me.dptfecha.Size = New System.Drawing.Size(95, 20)
        Me.dptfecha.TabIndex = 43
        Me.dptfecha.Value = New Date(2018, 11, 29, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Fecha"
        '
        'lblper
        '
        Me.lblper.BackColor = System.Drawing.Color.Gainsboro
        Me.lblper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblper.Location = New System.Drawing.Point(185, 19)
        Me.lblper.Name = "lblper"
        Me.lblper.Size = New System.Drawing.Size(324, 20)
        Me.lblper.TabIndex = 40
        Me.lblper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtper
        '
        Me.txtper.Location = New System.Drawing.Point(89, 19)
        Me.txtper.Name = "txtper"
        Me.txtper.Size = New System.Drawing.Size(95, 20)
        Me.txtper.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnborrar)
        Me.GroupBox2.Controls.Add(Me.btncargararch)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(515, 58)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Agregar con archivo"
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(445, 21)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(64, 23)
        Me.btnborrar.TabIndex = 7
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = True
        Me.btnborrar.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(417, 412)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 43
        '
        'FormMantELTBTAREO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 441)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btninsertar)
        Me.Controls.Add(Me.dgvdatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormMantELTBTAREO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro De Asistencia"
        CType(Me.dgvdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btninsertar As Button
    Friend WithEvents btncargararch As Button
    Friend WithEvents dgvdatos As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtper As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblper As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dptfecha As DateTimePicker
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dpthora As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblindice As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents COD As DataGridViewTextBoxColumn
    Friend WithEvents FECHA As DataGridViewTextBoxColumn
    Friend WithEvents btnborrar As Button
End Class
