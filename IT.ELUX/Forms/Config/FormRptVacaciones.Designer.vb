<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptVacaciones
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
        Me.txtprdo1 = New System.Windows.Forms.TextBox()
        Me.txtprdo2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtper1 = New System.Windows.Forms.TextBox()
        Me.txtnomper1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Periodo"
        '
        'txtprdo1
        '
        Me.txtprdo1.Location = New System.Drawing.Point(78, 33)
        Me.txtprdo1.Name = "txtprdo1"
        Me.txtprdo1.Size = New System.Drawing.Size(69, 20)
        Me.txtprdo1.TabIndex = 1
        '
        'txtprdo2
        '
        Me.txtprdo2.Location = New System.Drawing.Point(261, 33)
        Me.txtprdo2.Name = "txtprdo2"
        Me.txtprdo2.Size = New System.Drawing.Size(81, 20)
        Me.txtprdo2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Periodo"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(246, 103)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 27
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(165, 103)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 26
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Personal"
        '
        'txtper1
        '
        Me.txtper1.Location = New System.Drawing.Point(78, 63)
        Me.txtper1.MaxLength = 8
        Me.txtper1.Name = "txtper1"
        Me.txtper1.Size = New System.Drawing.Size(61, 20)
        Me.txtper1.TabIndex = 81
        '
        'txtnomper1
        '
        Me.txtnomper1.Location = New System.Drawing.Point(145, 63)
        Me.txtnomper1.Name = "txtnomper1"
        Me.txtnomper1.ReadOnly = True
        Me.txtnomper1.Size = New System.Drawing.Size(312, 20)
        Me.txtnomper1.TabIndex = 82
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(463, 62)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 23)
        Me.Button5.TabIndex = 83
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'FormRptVacaciones
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 151)
        Me.Controls.Add(Me.txtper1)
        Me.Controls.Add(Me.txtnomper1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtprdo2)
        Me.Controls.Add(Me.txtprdo1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRptVacaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptVacaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtprdo1 As TextBox
    Friend WithEvents txtprdo2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnreporte As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtper1 As TextBox
    Friend WithEvents txtnomper1 As TextBox
    Friend WithEvents Button5 As Button
End Class
