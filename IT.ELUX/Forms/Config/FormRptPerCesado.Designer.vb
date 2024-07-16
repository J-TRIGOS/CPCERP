<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptPerCesado
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
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtdni2 = New System.Windows.Forms.TextBox()
        Me.txtnomape2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkest = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Año"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(153, 103)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 10
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(72, 103)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 9
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño.Location = New System.Drawing.Point(70, 28)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(81, 21)
        Me.cmbaño.TabIndex = 116
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(280, 66)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(35, 23)
        Me.Button6.TabIndex = 126
        Me.Button6.Text = "..."
        Me.Button6.UseVisualStyleBackColor = True
        '
        'txtdni2
        '
        Me.txtdni2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdni2.Location = New System.Drawing.Point(70, 67)
        Me.txtdni2.Name = "txtdni2"
        Me.txtdni2.Size = New System.Drawing.Size(58, 20)
        Me.txtdni2.TabIndex = 123
        '
        'txtnomape2
        '
        Me.txtnomape2.Location = New System.Drawing.Point(134, 67)
        Me.txtnomape2.MaxLength = 2
        Me.txtnomape2.Name = "txtnomape2"
        Me.txtnomape2.ReadOnly = True
        Me.txtnomape2.Size = New System.Drawing.Size(140, 20)
        Me.txtnomape2.TabIndex = 125
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 124
        Me.Label9.Text = "Persona"
        '
        'chkest
        '
        Me.chkest.AutoSize = True
        Me.chkest.Checked = True
        Me.chkest.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkest.Location = New System.Drawing.Point(172, 30)
        Me.chkest.Name = "chkest"
        Me.chkest.Size = New System.Drawing.Size(35, 17)
        Me.chkest.TabIndex = 11
        Me.chkest.Text = "Si"
        Me.chkest.UseVisualStyleBackColor = True
        '
        'FormRptPerCesado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 153)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.txtdni2)
        Me.Controls.Add(Me.txtnomape2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbaño)
        Me.Controls.Add(Me.chkest)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRptPerCesado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptPerCesado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnreporte As Button
    Friend WithEvents cmbaño As ComboBox
    Friend WithEvents Button6 As Button
    Friend WithEvents txtdni2 As TextBox
    Friend WithEvents txtnomape2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents chkest As CheckBox
End Class
