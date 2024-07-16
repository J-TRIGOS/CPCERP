<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptListAFP
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
        Me.dtpfec_ini5 = New System.Windows.Forms.DateTimePicker()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.txtcontrato_prdo5 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtpfec_ini5
        '
        Me.dtpfec_ini5.Checked = False
        Me.dtpfec_ini5.Enabled = False
        Me.dtpfec_ini5.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ini5.Location = New System.Drawing.Point(202, 36)
        Me.dtpfec_ini5.Name = "dtpfec_ini5"
        Me.dtpfec_ini5.ShowCheckBox = True
        Me.dtpfec_ini5.Size = New System.Drawing.Size(98, 20)
        Me.dtpfec_ini5.TabIndex = 147
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(159, 36)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(32, 23)
        Me.Button12.TabIndex = 146
        Me.Button12.Text = "..."
        Me.Button12.UseVisualStyleBackColor = True
        '
        'txtcontrato_prdo5
        '
        Me.txtcontrato_prdo5.Location = New System.Drawing.Point(93, 38)
        Me.txtcontrato_prdo5.Name = "txtcontrato_prdo5"
        Me.txtcontrato_prdo5.Size = New System.Drawing.Size(61, 20)
        Me.txtcontrato_prdo5.TabIndex = 145
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(28, 41)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 13)
        Me.Label23.TabIndex = 144
        Me.Label23.Text = "Periodo 1:"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(79, 86)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 36)
        Me.Button9.TabIndex = 150
        Me.Button9.Text = "Reporte"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(173, 86)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 36)
        Me.Button10.TabIndex = 151
        Me.Button10.Text = "Salir"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'FormRptListAFP
        '
        Me.AcceptButton = Me.Button9
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 150)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.dtpfec_ini5)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.txtcontrato_prdo5)
        Me.Controls.Add(Me.Label23)
        Me.Name = "FormRptListAFP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptListAFP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpfec_ini5 As DateTimePicker
    Friend WithEvents Button12 As Button
    Friend WithEvents txtcontrato_prdo5 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
End Class
