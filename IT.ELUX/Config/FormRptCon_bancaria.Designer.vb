<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptCon_bancaria
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
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.txtMesIni = New System.Windows.Forms.TextBox()
        Me.cmbCodBanco = New System.Windows.Forms.ComboBox()
        Me.cmbCtaCont = New System.Windows.Forms.ComboBox()
        Me.cmbEst1 = New System.Windows.Forms.ComboBox()
        Me.txtMesFin = New System.Windows.Forms.TextBox()
        Me.cmbEst2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(170, 22)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(121, 20)
        Me.txtAño.TabIndex = 0
        '
        'txtMesIni
        '
        Me.txtMesIni.Location = New System.Drawing.Point(170, 48)
        Me.txtMesIni.Name = "txtMesIni"
        Me.txtMesIni.Size = New System.Drawing.Size(121, 20)
        Me.txtMesIni.TabIndex = 2
        '
        'cmbCodBanco
        '
        Me.cmbCodBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCodBanco.FormattingEnabled = True
        Me.cmbCodBanco.Items.AddRange(New Object() {"SOLES", "DOLARES"})
        Me.cmbCodBanco.Location = New System.Drawing.Point(170, 100)
        Me.cmbCodBanco.Name = "cmbCodBanco"
        Me.cmbCodBanco.Size = New System.Drawing.Size(121, 21)
        Me.cmbCodBanco.TabIndex = 4
        '
        'cmbCtaCont
        '
        Me.cmbCtaCont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCtaCont.FormattingEnabled = True
        Me.cmbCtaCont.Items.AddRange(New Object() {"BC.SOLES", "BC.DOLARES", "BN.SOLES"})
        Me.cmbCtaCont.Location = New System.Drawing.Point(170, 127)
        Me.cmbCtaCont.Name = "cmbCtaCont"
        Me.cmbCtaCont.Size = New System.Drawing.Size(121, 21)
        Me.cmbCtaCont.TabIndex = 5
        '
        'cmbEst1
        '
        Me.cmbEst1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEst1.FormattingEnabled = True
        Me.cmbEst1.Items.AddRange(New Object() {"CANCELADO", "PENDIENTE"})
        Me.cmbEst1.Location = New System.Drawing.Point(170, 154)
        Me.cmbEst1.Name = "cmbEst1"
        Me.cmbEst1.Size = New System.Drawing.Size(121, 21)
        Me.cmbEst1.TabIndex = 6
        '
        'txtMesFin
        '
        Me.txtMesFin.Location = New System.Drawing.Point(170, 74)
        Me.txtMesFin.Name = "txtMesFin"
        Me.txtMesFin.Size = New System.Drawing.Size(121, 20)
        Me.txtMesFin.TabIndex = 3
        '
        'cmbEst2
        '
        Me.cmbEst2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEst2.FormattingEnabled = True
        Me.cmbEst2.Items.AddRange(New Object() {"CANCELADO", "PENDIENTE"})
        Me.cmbEst2.Location = New System.Drawing.Point(170, 181)
        Me.cmbEst2.Name = "cmbEst2"
        Me.cmbEst2.Size = New System.Drawing.Size(121, 21)
        Me.cmbEst2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Año"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Mes Inicio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Mes Fin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Codigo Banco"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "CTA Contable"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Est1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(70, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Est 2"
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(93, 215)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 15
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(186, 215)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(86, 36)
        Me.btnsalir.TabIndex = 16
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'FormRptCon_bancaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(370, 273)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbEst2)
        Me.Controls.Add(Me.cmbEst1)
        Me.Controls.Add(Me.cmbCtaCont)
        Me.Controls.Add(Me.cmbCodBanco)
        Me.Controls.Add(Me.txtMesIni)
        Me.Controls.Add(Me.txtMesFin)
        Me.Controls.Add(Me.txtAño)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "FormRptCon_bancaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conciliacion Bancaria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAño As TextBox
    Friend WithEvents txtMesIni As TextBox
    Friend WithEvents cmbCodBanco As ComboBox
    Friend WithEvents cmbCtaCont As ComboBox
    Friend WithEvents cmbEst1 As ComboBox
    Friend WithEvents txtMesFin As TextBox
    Friend WithEvents cmbEst2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnreporte As Button
    Friend WithEvents btnsalir As Button
End Class
