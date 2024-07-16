<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptVidaLey
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
        Me.cmbsit1 = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtprdo1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbsit1
        '
        Me.cmbsit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsit1.FormattingEnabled = True
        Me.cmbsit1.Items.AddRange(New Object() {"", "Empleado", "Obrero"})
        Me.cmbsit1.Location = New System.Drawing.Point(107, 53)
        Me.cmbsit1.Name = "cmbsit1"
        Me.cmbsit1.Size = New System.Drawing.Size(127, 21)
        Me.cmbsit1.TabIndex = 138
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(34, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 137
        Me.Label14.Text = "Situacion 1:"
        '
        'txtprdo1
        '
        Me.txtprdo1.Location = New System.Drawing.Point(107, 27)
        Me.txtprdo1.Name = "txtprdo1"
        Me.txtprdo1.Size = New System.Drawing.Size(69, 20)
        Me.txtprdo1.TabIndex = 136
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Periodo"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(145, 90)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 140
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(64, 90)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 139
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'FormRptVidaLey
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 141)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.cmbsit1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtprdo1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRptVidaLey"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptVidaLey"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbsit1 As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtprdo1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnreporte As Button
End Class
