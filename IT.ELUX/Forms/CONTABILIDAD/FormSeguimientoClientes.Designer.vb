<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSeguimientoClientes
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbAnho = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDocClientes = New System.Windows.Forms.DataGridView()
        Me.PROCESAR = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDocClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbMes)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbAnho)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(326, 42)
        Me.Panel1.TabIndex = 0
        '
        'cmbMes
        '
        Me.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(191, 10)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(121, 21)
        Me.cmbMes.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mes: "
        '
        'cmbAnho
        '
        Me.cmbAnho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnho.FormattingEnabled = True
        Me.cmbAnho.Location = New System.Drawing.Point(61, 10)
        Me.cmbAnho.Name = "cmbAnho"
        Me.cmbAnho.Size = New System.Drawing.Size(50, 21)
        Me.cmbAnho.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Año: "
        '
        'dgvDocClientes
        '
        Me.dgvDocClientes.AllowUserToAddRows = False
        Me.dgvDocClientes.AllowUserToDeleteRows = False
        Me.dgvDocClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDocClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PROCESAR})
        Me.dgvDocClientes.Location = New System.Drawing.Point(12, 60)
        Me.dgvDocClientes.Name = "dgvDocClientes"
        Me.dgvDocClientes.ReadOnly = True
        Me.dgvDocClientes.Size = New System.Drawing.Size(1442, 511)
        Me.dgvDocClientes.TabIndex = 1
        '
        'PROCESAR
        '
        Me.PROCESAR.HeaderText = "PROCESAR"
        Me.PROCESAR.Name = "PROCESAR"
        Me.PROCESAR.ReadOnly = True
        Me.PROCESAR.Text = ""
        '
        'FormSeguimientoClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1466, 583)
        Me.Controls.Add(Me.dgvDocClientes)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormSeguimientoClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSeguimientoClientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDocClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvDocClientes As DataGridView
    Friend WithEvents cmbMes As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbAnho As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PROCESAR As DataGridViewButtonColumn
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
