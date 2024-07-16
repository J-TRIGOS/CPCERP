<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormELTBPROVVACA
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcontrato_prdo1 = New System.Windows.Forms.TextBox()
        Me.dtpfec_ini = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.dgvt_doc = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgvt_doc1 = New System.Windows.Forms.DataGridView()
        Me.dgvt_doc2 = New System.Windows.Forms.DataGridView()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvt_doc1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvt_doc2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Periodo"
        '
        'txtcontrato_prdo1
        '
        Me.txtcontrato_prdo1.Location = New System.Drawing.Point(102, 39)
        Me.txtcontrato_prdo1.Name = "txtcontrato_prdo1"
        Me.txtcontrato_prdo1.Size = New System.Drawing.Size(61, 20)
        Me.txtcontrato_prdo1.TabIndex = 81
        '
        'dtpfec_ini
        '
        Me.dtpfec_ini.Checked = False
        Me.dtpfec_ini.Enabled = False
        Me.dtpfec_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ini.Location = New System.Drawing.Point(212, 37)
        Me.dtpfec_ini.Name = "dtpfec_ini"
        Me.dtpfec_ini.ShowCheckBox = True
        Me.dtpfec_ini.Size = New System.Drawing.Size(98, 20)
        Me.dtpfec_ini.TabIndex = 85
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(169, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 23)
        Me.Button1.TabIndex = 82
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(182, 78)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 36)
        Me.Button10.TabIndex = 97
        Me.Button10.Text = "Salir"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'dgvt_doc
        '
        Me.dgvt_doc.AllowUserToAddRows = False
        Me.dgvt_doc.AllowUserToDeleteRows = False
        Me.dgvt_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc.Location = New System.Drawing.Point(381, 12)
        Me.dgvt_doc.Name = "dgvt_doc"
        Me.dgvt_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc.Size = New System.Drawing.Size(808, 208)
        Me.dgvt_doc.TabIndex = 98
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(101, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 36)
        Me.Button2.TabIndex = 99
        Me.Button2.Text = "Generar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dgvt_doc1
        '
        Me.dgvt_doc1.AllowUserToAddRows = False
        Me.dgvt_doc1.AllowUserToDeleteRows = False
        Me.dgvt_doc1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc1.Location = New System.Drawing.Point(366, 22)
        Me.dgvt_doc1.Name = "dgvt_doc1"
        Me.dgvt_doc1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc1.Size = New System.Drawing.Size(808, 208)
        Me.dgvt_doc1.TabIndex = 100
        '
        'dgvt_doc2
        '
        Me.dgvt_doc2.AllowUserToAddRows = False
        Me.dgvt_doc2.AllowUserToDeleteRows = False
        Me.dgvt_doc2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc2.Location = New System.Drawing.Point(366, 52)
        Me.dgvt_doc2.Name = "dgvt_doc2"
        Me.dgvt_doc2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc2.Size = New System.Drawing.Size(808, 208)
        Me.dgvt_doc2.TabIndex = 101
        '
        'FormELTBPROVVACA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 133)
        Me.Controls.Add(Me.dgvt_doc2)
        Me.Controls.Add(Me.dgvt_doc1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgvt_doc)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcontrato_prdo1)
        Me.Controls.Add(Me.dtpfec_ini)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormELTBPROVVACA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormELTBPROVVACA"
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvt_doc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvt_doc2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtcontrato_prdo1 As TextBox
    Friend WithEvents dtpfec_ini As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents dgvt_doc As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents dgvt_doc1 As DataGridView
    Friend WithEvents dgvt_doc2 As DataGridView
End Class
