<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptSCTR
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
        Me.txtprdo1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.cmbsit2 = New System.Windows.Forms.ComboBox()
        Me.cmbsit1 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtprdo1
        '
        Me.txtprdo1.Location = New System.Drawing.Point(105, 22)
        Me.txtprdo1.MaxLength = 3
        Me.txtprdo1.Name = "txtprdo1"
        Me.txtprdo1.Size = New System.Drawing.Size(69, 20)
        Me.txtprdo1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Periodo"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(146, 111)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 29
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(65, 111)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 28
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'cmbsit2
        '
        Me.cmbsit2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsit2.FormattingEnabled = True
        Me.cmbsit2.Items.AddRange(New Object() {"", "Empleado", "Obrero"})
        Me.cmbsit2.Location = New System.Drawing.Point(105, 74)
        Me.cmbsit2.Name = "cmbsit2"
        Me.cmbsit2.Size = New System.Drawing.Size(127, 21)
        Me.cmbsit2.TabIndex = 135
        '
        'cmbsit1
        '
        Me.cmbsit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsit1.FormattingEnabled = True
        Me.cmbsit1.Items.AddRange(New Object() {"", "Empleado", "Obrero"})
        Me.cmbsit1.Location = New System.Drawing.Point(105, 48)
        Me.cmbsit1.Name = "cmbsit1"
        Me.cmbsit1.Size = New System.Drawing.Size(127, 21)
        Me.cmbsit1.TabIndex = 134
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(32, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 133
        Me.Label13.Text = "Situacion 2:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(32, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 132
        Me.Label14.Text = "Situacion 1:"
        '
        'FormRptSCTR
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 159)
        Me.Controls.Add(Me.cmbsit2)
        Me.Controls.Add(Me.cmbsit1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.txtprdo1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRptSCTR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptSCTR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtprdo1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnreporte As Button
    Friend WithEvents cmbsit2 As ComboBox
    Friend WithEvents cmbsit1 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
