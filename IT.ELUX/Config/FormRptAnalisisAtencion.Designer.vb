<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptAnalisisAtencion
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
        Me.dtpfin = New System.Windows.Forms.DateTimePicker()
        Me.dtpini = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtarticulo1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtcliente1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnomcliente = New System.Windows.Forms.TextBox()
        Me.txtnomarticulo = New System.Windows.Forms.TextBox()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpfin
        '
        Me.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfin.Location = New System.Drawing.Point(309, 28)
        Me.dtpfin.Name = "dtpfin"
        Me.dtpfin.Size = New System.Drawing.Size(94, 20)
        Me.dtpfin.TabIndex = 93
        '
        'dtpini
        '
        Me.dtpini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpini.Location = New System.Drawing.Point(100, 28)
        Me.dtpini.Name = "dtpini"
        Me.dtpini.Size = New System.Drawing.Size(94, 20)
        Me.dtpini.TabIndex = 92
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(243, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "Fecha Fin :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 91
        Me.Label11.Text = "Fecha Inicio:"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(119, 132)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 36)
        Me.Button9.TabIndex = 94
        Me.Button9.Text = "Reporte"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(214, 132)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 36)
        Me.Button10.TabIndex = 95
        Me.Button10.Text = "Salir"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(368, 78)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 23)
        Me.Button3.TabIndex = 150
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtarticulo1
        '
        Me.txtarticulo1.Location = New System.Drawing.Point(100, 80)
        Me.txtarticulo1.Name = "txtarticulo1"
        Me.txtarticulo1.Size = New System.Drawing.Size(65, 20)
        Me.txtarticulo1.TabIndex = 148
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 149
        Me.Label7.Text = "Articulo:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(368, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 23)
        Me.Button1.TabIndex = 147
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtcliente1
        '
        Me.txtcliente1.Location = New System.Drawing.Point(100, 54)
        Me.txtcliente1.Name = "txtcliente1"
        Me.txtcliente1.Size = New System.Drawing.Size(94, 20)
        Me.txtcliente1.TabIndex = 145
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = "Cliente:"
        '
        'txtnomcliente
        '
        Me.txtnomcliente.Location = New System.Drawing.Point(200, 54)
        Me.txtnomcliente.Name = "txtnomcliente"
        Me.txtnomcliente.ReadOnly = True
        Me.txtnomcliente.Size = New System.Drawing.Size(162, 20)
        Me.txtnomcliente.TabIndex = 151
        '
        'txtnomarticulo
        '
        Me.txtnomarticulo.Location = New System.Drawing.Point(171, 80)
        Me.txtnomarticulo.Name = "txtnomarticulo"
        Me.txtnomarticulo.ReadOnly = True
        Me.txtnomarticulo.Size = New System.Drawing.Size(191, 20)
        Me.txtnomarticulo.TabIndex = 152
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(100, 106)
        Me.txtnumero.MaxLength = 8
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(65, 20)
        Me.txtnumero.TabIndex = 153
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 154
        Me.Label1.Text = "Numero O/T:"
        '
        'FormRptAnalisisAtencion
        '
        Me.AcceptButton = Me.Button9
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 177)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnomarticulo)
        Me.Controls.Add(Me.txtnomcliente)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtarticulo1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtcliente1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.dtpfin)
        Me.Controls.Add(Me.dtpini)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRptAnalisisAtencion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptAnalisisAtencion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpfin As DateTimePicker
    Friend WithEvents dtpini As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtarticulo1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtcliente1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnomcliente As TextBox
    Friend WithEvents txtnomarticulo As TextBox
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents Label1 As Label
End Class
