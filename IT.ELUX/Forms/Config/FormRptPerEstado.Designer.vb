<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptPerEstado
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
        Me.txtc_costo = New System.Windows.Forms.TextBox()
        Me.txtnom_ccosto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnomlinea = New System.Windows.Forms.TextBox()
        Me.txtlinea = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnomper = New System.Windows.Forms.TextBox()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.cmbsit = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "C. Costo"
        '
        'txtc_costo
        '
        Me.txtc_costo.Location = New System.Drawing.Point(78, 49)
        Me.txtc_costo.MaxLength = 3
        Me.txtc_costo.Name = "txtc_costo"
        Me.txtc_costo.Size = New System.Drawing.Size(39, 20)
        Me.txtc_costo.TabIndex = 2
        '
        'txtnom_ccosto
        '
        Me.txtnom_ccosto.Location = New System.Drawing.Point(123, 49)
        Me.txtnom_ccosto.Name = "txtnom_ccosto"
        Me.txtnom_ccosto.ReadOnly = True
        Me.txtnom_ccosto.Size = New System.Drawing.Size(229, 20)
        Me.txtnom_ccosto.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Situacion"
        '
        'txtnomlinea
        '
        Me.txtnomlinea.Location = New System.Drawing.Point(123, 75)
        Me.txtnomlinea.Name = "txtnomlinea"
        Me.txtnomlinea.ReadOnly = True
        Me.txtnomlinea.Size = New System.Drawing.Size(229, 20)
        Me.txtnomlinea.TabIndex = 13
        '
        'txtlinea
        '
        Me.txtlinea.Location = New System.Drawing.Point(78, 75)
        Me.txtlinea.MaxLength = 3
        Me.txtlinea.Name = "txtlinea"
        Me.txtlinea.Size = New System.Drawing.Size(39, 20)
        Me.txtlinea.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Área"
        '
        'txtnomper
        '
        Me.txtnomper.Location = New System.Drawing.Point(150, 23)
        Me.txtnomper.Name = "txtnomper"
        Me.txtnomper.ReadOnly = True
        Me.txtnomper.Size = New System.Drawing.Size(202, 20)
        Me.txtnomper.TabIndex = 11
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(78, 23)
        Me.txtdni.MaxLength = 8
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(66, 20)
        Me.txtdni.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Persona"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(106, 128)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 36)
        Me.Button9.TabIndex = 5
        Me.Button9.Text = "Reporte"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(201, 128)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 36)
        Me.Button10.TabIndex = 6
        Me.Button10.Text = "Salir"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'cmbsit
        '
        Me.cmbsit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsit.FormattingEnabled = True
        Me.cmbsit.Items.AddRange(New Object() {"", "Activo", "Inactivo"})
        Me.cmbsit.Location = New System.Drawing.Point(78, 101)
        Me.cmbsit.Name = "cmbsit"
        Me.cmbsit.Size = New System.Drawing.Size(161, 21)
        Me.cmbsit.TabIndex = 3
        '
        'FormRptPerEstado
        '
        Me.AcceptButton = Me.Button9
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 178)
        Me.Controls.Add(Me.cmbsit)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.txtnomper)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnomlinea)
        Me.Controls.Add(Me.txtlinea)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnom_ccosto)
        Me.Controls.Add(Me.txtc_costo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRptPerEstado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptPerEstado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtc_costo As TextBox
    Friend WithEvents txtnom_ccosto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnomlinea As TextBox
    Friend WithEvents txtlinea As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnomper As TextBox
    Friend WithEvents txtdni As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents cmbsit As ComboBox
End Class
