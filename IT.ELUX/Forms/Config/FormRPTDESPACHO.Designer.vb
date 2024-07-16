<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRPTDESPACHO
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpfecini = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodArt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomCliente = New System.Windows.Forms.TextBox()
        Me.txtNomArt = New System.Windows.Forms.TextBox()
        Me.btnArticulo = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Fecha"
        '
        'dtpfecini
        '
        Me.dtpfecini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecini.Location = New System.Drawing.Point(67, 28)
        Me.dtpfecini.Name = "dtpfecini"
        Me.dtpfecini.Size = New System.Drawing.Size(126, 20)
        Me.dtpfecini.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.btnArticulo)
        Me.GroupBox1.Controls.Add(Me.txtNomArt)
        Me.GroupBox1.Controls.Add(Me.txtNomCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCodArt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtcliente)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpfecini)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 181)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'btnCliente
        '
        Me.btnCliente.Location = New System.Drawing.Point(568, 78)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(39, 23)
        Me.btnCliente.TabIndex = 117
        Me.btnCliente.Text = "..."
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Articulo"
        '
        'txtCodArt
        '
        Me.txtCodArt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodArt.Location = New System.Drawing.Point(65, 108)
        Me.txtCodArt.Name = "txtCodArt"
        Me.txtCodArt.Size = New System.Drawing.Size(86, 20)
        Me.txtCodArt.TabIndex = 121
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "Cliente"
        '
        'txtcliente
        '
        Me.txtcliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcliente.Location = New System.Drawing.Point(65, 80)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(86, 20)
        Me.txtcliente.TabIndex = 119
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(277, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 117
        Me.Button1.Text = "Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Numero"
        '
        'txtNomCliente
        '
        Me.txtNomCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomCliente.Location = New System.Drawing.Point(158, 80)
        Me.txtNomCliente.Name = "txtNomCliente"
        Me.txtNomCliente.ReadOnly = True
        Me.txtNomCliente.Size = New System.Drawing.Size(407, 20)
        Me.txtNomCliente.TabIndex = 125
        '
        'txtNomArt
        '
        Me.txtNomArt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomArt.Location = New System.Drawing.Point(158, 108)
        Me.txtNomArt.Name = "txtNomArt"
        Me.txtNomArt.ReadOnly = True
        Me.txtNomArt.Size = New System.Drawing.Size(407, 20)
        Me.txtNomArt.TabIndex = 127
        '
        'btnArticulo
        '
        Me.btnArticulo.Location = New System.Drawing.Point(568, 107)
        Me.btnArticulo.Name = "btnArticulo"
        Me.btnArticulo.Size = New System.Drawing.Size(39, 23)
        Me.btnArticulo.TabIndex = 128
        Me.btnArticulo.Text = "..."
        Me.btnArticulo.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(67, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(86, 20)
        Me.TextBox1.TabIndex = 129
        '
        'FormRPTDESPACHO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 206)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormRPTDESPACHO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRPTDESPACHO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents dtpfecini As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtcliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodArt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCliente As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNomArt As TextBox
    Friend WithEvents txtNomCliente As TextBox
    Friend WithEvents btnArticulo As Button
    Friend WithEvents TextBox1 As TextBox
End Class
