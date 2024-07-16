<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRPTFCVentas_Sunat
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
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbmes1 = New System.Windows.Forms.ComboBox()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(47, 76)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 96
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(141, 76)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 97
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Mes1 :"
        '
        'cmbmes1
        '
        Me.cmbmes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes1.FormattingEnabled = True
        Me.cmbmes1.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes1.Location = New System.Drawing.Point(64, 39)
        Me.cmbmes1.Name = "cmbmes1"
        Me.cmbmes1.Size = New System.Drawing.Size(152, 21)
        Me.cmbmes1.TabIndex = 94
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño.Location = New System.Drawing.Point(64, 12)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(121, 21)
        Me.cmbaño.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Año:"
        '
        'FormRPTFCVentas_Sunat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 136)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbmes1)
        Me.Controls.Add(Me.cmbaño)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRPTFCVentas_Sunat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRPTFCVentas_Sunat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnreporte As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbmes1 As ComboBox
    Friend WithEvents cmbaño As ComboBox
    Friend WithEvents Label1 As Label
End Class
