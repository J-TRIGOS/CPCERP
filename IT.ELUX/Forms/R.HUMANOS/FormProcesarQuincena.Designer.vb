<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProcesarQuincena
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
        Me.dgvQuincena = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbAnho = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.COD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPLEADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECING = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUINC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BASICO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvQuincena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvQuincena
        '
        Me.dgvQuincena.AllowUserToAddRows = False
        Me.dgvQuincena.AllowUserToDeleteRows = False
        Me.dgvQuincena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuincena.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COD, Me.EMPLEADO, Me.FECING, Me.DIAS, Me.QUINC, Me.PRDO, Me.BASICO, Me.MONTO})
        Me.dgvQuincena.Location = New System.Drawing.Point(12, 45)
        Me.dgvQuincena.Name = "dgvQuincena"
        Me.dgvQuincena.Size = New System.Drawing.Size(675, 570)
        Me.dgvQuincena.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Año:"
        '
        'cmbAnho
        '
        Me.cmbAnho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnho.FormattingEnabled = True
        Me.cmbAnho.Items.AddRange(New Object() {"2022", "2023", "2024", "2025", "2026"})
        Me.cmbAnho.Location = New System.Drawing.Point(47, 18)
        Me.cmbAnho.Name = "cmbAnho"
        Me.cmbAnho.Size = New System.Drawing.Size(62, 21)
        Me.cmbAnho.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mes:"
        '
        'cmbMes
        '
        Me.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbMes.Location = New System.Drawing.Point(160, 18)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(115, 21)
        Me.cmbMes.TabIndex = 4
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(295, 16)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesar.TabIndex = 5
        Me.btnProcesar.Text = "Generar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(376, 16)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabar.TabIndex = 6
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'COD
        '
        Me.COD.HeaderText = "Código"
        Me.COD.Name = "COD"
        Me.COD.ReadOnly = True
        '
        'EMPLEADO
        '
        Me.EMPLEADO.HeaderText = "Empleado"
        Me.EMPLEADO.Name = "EMPLEADO"
        Me.EMPLEADO.ReadOnly = True
        '
        'FECING
        '
        Me.FECING.HeaderText = "Fec. Ingreso"
        Me.FECING.Name = "FECING"
        Me.FECING.ReadOnly = True
        '
        'DIAS
        '
        Me.DIAS.HeaderText = "Días"
        Me.DIAS.Name = "DIAS"
        '
        'QUINC
        '
        Me.QUINC.HeaderText = "Quincena"
        Me.QUINC.Name = "QUINC"
        Me.QUINC.ReadOnly = True
        Me.QUINC.Visible = False
        '
        'PRDO
        '
        Me.PRDO.HeaderText = "PRDO"
        Me.PRDO.Name = "PRDO"
        Me.PRDO.ReadOnly = True
        Me.PRDO.Visible = False
        '
        'BASICO
        '
        Me.BASICO.HeaderText = "Básico"
        Me.BASICO.Name = "BASICO"
        Me.BASICO.ReadOnly = True
        '
        'MONTO
        '
        Me.MONTO.HeaderText = "Monto"
        Me.MONTO.Name = "MONTO"
        Me.MONTO.ReadOnly = True
        '
        'FormProcesarQuincena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 627)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.cmbMes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbAnho)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvQuincena)
        Me.Name = "FormProcesarQuincena"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormProcesarQuincena"
        CType(Me.dgvQuincena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvQuincena As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbAnho As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbMes As ComboBox
    Friend WithEvents btnProcesar As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents COD As DataGridViewTextBoxColumn
    Friend WithEvents EMPLEADO As DataGridViewTextBoxColumn
    Friend WithEvents FECING As DataGridViewTextBoxColumn
    Friend WithEvents DIAS As DataGridViewTextBoxColumn
    Friend WithEvents QUINC As DataGridViewTextBoxColumn
    Friend WithEvents PRDO As DataGridViewTextBoxColumn
    Friend WithEvents BASICO As DataGridViewTextBoxColumn
    Friend WithEvents MONTO As DataGridViewTextBoxColumn
End Class
