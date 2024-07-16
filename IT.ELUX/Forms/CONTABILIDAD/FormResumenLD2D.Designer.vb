<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormResumenLD2D
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.drpAnho = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.drpDesde = New System.Windows.Forms.ComboBox()
        Me.drpHasta = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvLD = New System.Windows.Forms.DataGridView()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.dgvLD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Año: "
        '
        'drpAnho
        '
        Me.drpAnho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpAnho.FormattingEnabled = True
        Me.drpAnho.Items.AddRange(New Object() {"2022", "2023", "2024", "2025", "2026"})
        Me.drpAnho.Location = New System.Drawing.Point(70, 19)
        Me.drpAnho.Name = "drpAnho"
        Me.drpAnho.Size = New System.Drawing.Size(70, 21)
        Me.drpAnho.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Desde:"
        '
        'drpDesde
        '
        Me.drpDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpDesde.FormattingEnabled = True
        Me.drpDesde.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.drpDesde.Location = New System.Drawing.Point(68, 51)
        Me.drpDesde.Name = "drpDesde"
        Me.drpDesde.Size = New System.Drawing.Size(94, 21)
        Me.drpDesde.TabIndex = 3
        '
        'drpHasta
        '
        Me.drpHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpHasta.FormattingEnabled = True
        Me.drpHasta.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.drpHasta.Location = New System.Drawing.Point(234, 51)
        Me.drpHasta.Name = "drpHasta"
        Me.drpHasta.Size = New System.Drawing.Size(94, 21)
        Me.drpHasta.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(187, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hasta:"
        '
        'dgvLD
        '
        Me.dgvLD.AllowUserToAddRows = False
        Me.dgvLD.AllowUserToDeleteRows = False
        Me.dgvLD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLD.Location = New System.Drawing.Point(12, 111)
        Me.dgvLD.Name = "dgvLD"
        Me.dgvLD.ReadOnly = True
        Me.dgvLD.Size = New System.Drawing.Size(429, 25)
        Me.dgvLD.TabIndex = 6
        Me.dgvLD.Visible = False
        '
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(150, 82)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(75, 23)
        Me.btnReporte.TabIndex = 7
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'FormResumenLD2D
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 148)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.dgvLD)
        Me.Controls.Add(Me.drpHasta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.drpDesde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.drpAnho)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormResumenLD2D"
        Me.Text = "FormResumenLD2D"
        CType(Me.dgvLD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents drpAnho As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents drpDesde As ComboBox
    Friend WithEvents drpHasta As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvLD As DataGridView
    Friend WithEvents btnReporte As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
