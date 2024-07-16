<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProcesarHora
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
        Me.chkprocesar = New System.Windows.Forms.CheckBox()
        Me.btnprocesar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.dgvtiemper = New System.Windows.Forms.DataGridView()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtlinea = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_periodo = New System.Windows.Forms.TextBox()
        Me.dtpfec_ini = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvtiemper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkprocesar
        '
        Me.chkprocesar.AutoSize = True
        Me.chkprocesar.Location = New System.Drawing.Point(72, 27)
        Me.chkprocesar.Name = "chkprocesar"
        Me.chkprocesar.Size = New System.Drawing.Size(87, 17)
        Me.chkprocesar.TabIndex = 0
        Me.chkprocesar.Text = "Dia Domingo"
        Me.chkprocesar.UseVisualStyleBackColor = True
        Me.chkprocesar.Visible = False
        '
        'btnprocesar
        '
        Me.btnprocesar.Location = New System.Drawing.Point(32, 99)
        Me.btnprocesar.Name = "btnprocesar"
        Me.btnprocesar.Size = New System.Drawing.Size(75, 23)
        Me.btnprocesar.TabIndex = 3
        Me.btnprocesar.Text = "Procesar"
        Me.btnprocesar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(113, 99)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 4
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'dgvtiemper
        '
        Me.dgvtiemper.AllowUserToAddRows = False
        Me.dgvtiemper.AllowUserToDeleteRows = False
        Me.dgvtiemper.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvtiemper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtiemper.Location = New System.Drawing.Point(12, 105)
        Me.dgvtiemper.Name = "dgvtiemper"
        Me.dgvtiemper.ReadOnly = True
        Me.dgvtiemper.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvtiemper.Size = New System.Drawing.Size(536, 189)
        Me.dgvtiemper.TabIndex = 40
        Me.dgvtiemper.Visible = False
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(12, 1)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(99, 20)
        Me.dtpfecha.TabIndex = 41
        Me.dtpfecha.Visible = False
        '
        'txtlinea
        '
        Me.txtlinea.Location = New System.Drawing.Point(183, 4)
        Me.txtlinea.Name = "txtlinea"
        Me.txtlinea.Size = New System.Drawing.Size(100, 20)
        Me.txtlinea.TabIndex = 42
        Me.txtlinea.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Periodo"
        '
        'txt_periodo
        '
        Me.txt_periodo.Location = New System.Drawing.Point(59, 47)
        Me.txt_periodo.MaxLength = 4
        Me.txt_periodo.Name = "txt_periodo"
        Me.txt_periodo.Size = New System.Drawing.Size(100, 20)
        Me.txt_periodo.TabIndex = 1
        '
        'dtpfec_ini
        '
        Me.dtpfec_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ini.Location = New System.Drawing.Point(59, 73)
        Me.dtpfec_ini.Name = "dtpfec_ini"
        Me.dtpfec_ini.ShowCheckBox = True
        Me.dtpfec_ini.Size = New System.Drawing.Size(100, 20)
        Me.dtpfec_ini.TabIndex = 2
        '
        'FormProcesarHora
        '
        Me.AcceptButton = Me.btnprocesar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(213, 126)
        Me.Controls.Add(Me.dtpfec_ini)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnprocesar)
        Me.Controls.Add(Me.txt_periodo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtlinea)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.dgvtiemper)
        Me.Controls.Add(Me.chkprocesar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormProcesarHora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormProcesarHora"
        CType(Me.dgvtiemper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkprocesar As CheckBox
    Friend WithEvents btnprocesar As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents dgvtiemper As DataGridView
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents txtlinea As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_periodo As TextBox
    Friend WithEvents dtpfec_ini As DateTimePicker
End Class
