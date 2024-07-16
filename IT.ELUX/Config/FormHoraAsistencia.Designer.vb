<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHoraAsistencia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmbdni = New System.Windows.Forms.ComboBox()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpfec1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpfec2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.txtlinea_cod = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnom_linea = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkmen = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(451, 18)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(39, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cmbdni
        '
        Me.cmbdni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdni.FormattingEnabled = True
        Me.cmbdni.ItemHeight = 13
        Me.cmbdni.Location = New System.Drawing.Point(162, 18)
        Me.cmbdni.Name = "cmbdni"
        Me.cmbdni.Size = New System.Drawing.Size(283, 21)
        Me.cmbdni.TabIndex = 2
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(79, 18)
        Me.txtdni.MaxLength = 8
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(77, 20)
        Me.txtdni.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 178
        Me.Label2.Text = "Personal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 182
        Me.Label5.Text = "Fecha Inicial"
        '
        'dtpfec1
        '
        Me.dtpfec1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec1.Location = New System.Drawing.Point(79, 71)
        Me.dtpfec1.Name = "dtpfec1"
        Me.dtpfec1.Size = New System.Drawing.Size(132, 20)
        Me.dtpfec1.TabIndex = 6
        '
        'dtpfec2
        '
        Me.dtpfec2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec2.Location = New System.Drawing.Point(288, 71)
        Me.dtpfec2.Name = "dtpfec2"
        Me.dtpfec2.Size = New System.Drawing.Size(157, 20)
        Me.dtpfec2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 183
        Me.Label1.Text = "Fecha Final"
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(153, 119)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 8
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(254, 119)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 185
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'txtlinea_cod
        '
        Me.txtlinea_cod.Location = New System.Drawing.Point(79, 45)
        Me.txtlinea_cod.MaxLength = 8
        Me.txtlinea_cod.Name = "txtlinea_cod"
        Me.txtlinea_cod.Size = New System.Drawing.Size(77, 20)
        Me.txtlinea_cod.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 187
        Me.Label3.Text = "Area"
        '
        'txtnom_linea
        '
        Me.txtnom_linea.Location = New System.Drawing.Point(162, 45)
        Me.txtnom_linea.MaxLength = 8
        Me.txtnom_linea.Name = "txtnom_linea"
        Me.txtnom_linea.ReadOnly = True
        Me.txtnom_linea.Size = New System.Drawing.Size(283, 20)
        Me.txtnom_linea.TabIndex = 188
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(451, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkmen
        '
        Me.chkmen.AutoSize = True
        Me.chkmen.Location = New System.Drawing.Point(9, 97)
        Me.chkmen.Name = "chkmen"
        Me.chkmen.Size = New System.Drawing.Size(99, 17)
        Me.chkmen.TabIndex = 189
        Me.chkmen.Text = "Mensual Todos"
        Me.chkmen.UseVisualStyleBackColor = True
        '
        'FormHoraAsistencia
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 163)
        Me.Controls.Add(Me.chkmen)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtnom_linea)
        Me.Controls.Add(Me.txtlinea_cod)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpfec1)
        Me.Controls.Add(Me.dtpfec2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.cmbdni)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormHoraAsistencia"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormHoraAsistencia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents cmbdni As ComboBox
    Friend WithEvents txtdni As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpfec1 As DateTimePicker
    Friend WithEvents dtpfec2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btnreporte As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents txtlinea_cod As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnom_linea As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents chkmen As CheckBox
End Class
