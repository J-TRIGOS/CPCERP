<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistroAsistencia
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
        Me.components = New System.ComponentModel.Container()
        Me.lblTienda = New System.Windows.Forms.Label()
        Me.lblReloj = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMarcar = New System.Windows.Forms.Button()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.radEntrada = New System.Windows.Forms.RadioButton()
        Me.radRefrigerio = New System.Windows.Forms.RadioButton()
        Me.radSalida = New System.Windows.Forms.RadioButton()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTienda
        '
        Me.lblTienda.AutoSize = True
        Me.lblTienda.Location = New System.Drawing.Point(12, 15)
        Me.lblTienda.Name = "lblTienda"
        Me.lblTienda.Size = New System.Drawing.Size(0, 13)
        Me.lblTienda.TabIndex = 11
        Me.lblTienda.Visible = False
        '
        'lblReloj
        '
        Me.lblReloj.AutoSize = True
        Me.lblReloj.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblReloj.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReloj.ForeColor = System.Drawing.Color.White
        Me.lblReloj.Location = New System.Drawing.Point(130, 15)
        Me.lblReloj.Name = "lblReloj"
        Me.lblReloj.Size = New System.Drawing.Size(174, 46)
        Me.lblReloj.TabIndex = 9
        Me.lblReloj.Text = "00:00:00"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radSalida)
        Me.GroupBox2.Controls.Add(Me.radRefrigerio)
        Me.GroupBox2.Controls.Add(Me.radEntrada)
        Me.GroupBox2.Controls.Add(Me.btnMarcar)
        Me.GroupBox2.Controls.Add(Me.txtDni)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 100)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingresar Datos..."
        '
        'btnMarcar
        '
        Me.btnMarcar.BackColor = System.Drawing.Color.PowderBlue
        Me.btnMarcar.Location = New System.Drawing.Point(237, 61)
        Me.btnMarcar.Name = "btnMarcar"
        Me.btnMarcar.Size = New System.Drawing.Size(84, 33)
        Me.btnMarcar.TabIndex = 2
        Me.btnMarcar.Text = "Marcar"
        Me.btnMarcar.UseVisualStyleBackColor = False
        '
        'txtDni
        '
        Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.Location = New System.Drawing.Point(90, 66)
        Me.txtDni.MaxLength = 9
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(141, 22)
        Me.txtDni.TabIndex = 1
        Me.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNI :"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'radEntrada
        '
        Me.radEntrada.AutoSize = True
        Me.radEntrada.Location = New System.Drawing.Point(6, 22)
        Me.radEntrada.Name = "radEntrada"
        Me.radEntrada.Size = New System.Drawing.Size(83, 21)
        Me.radEntrada.TabIndex = 3
        Me.radEntrada.TabStop = True
        Me.radEntrada.Text = "Entrada"
        Me.radEntrada.UseVisualStyleBackColor = True
        '
        'radRefrigerio
        '
        Me.radRefrigerio.AutoSize = True
        Me.radRefrigerio.Location = New System.Drawing.Point(143, 22)
        Me.radRefrigerio.Name = "radRefrigerio"
        Me.radRefrigerio.Size = New System.Drawing.Size(98, 21)
        Me.radRefrigerio.TabIndex = 4
        Me.radRefrigerio.TabStop = True
        Me.radRefrigerio.Text = "Refrigerio"
        Me.radRefrigerio.UseVisualStyleBackColor = True
        '
        'radSalida
        '
        Me.radSalida.AutoSize = True
        Me.radSalida.Location = New System.Drawing.Point(289, 22)
        Me.radSalida.Name = "radSalida"
        Me.radSalida.Size = New System.Drawing.Size(71, 21)
        Me.radSalida.TabIndex = 5
        Me.radSalida.TabStop = True
        Me.radSalida.Text = "Salida"
        Me.radSalida.UseVisualStyleBackColor = True
        '
        'FormRegistroAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 213)
        Me.Controls.Add(Me.lblTienda)
        Me.Controls.Add(Me.lblReloj)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FormRegistroAsistencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRegistroAsistencia"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTienda As Label
    Friend WithEvents lblReloj As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnMarcar As Button
    Friend WithEvents txtDni As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents radSalida As RadioButton
    Friend WithEvents radRefrigerio As RadioButton
    Friend WithEvents radEntrada As RadioButton
End Class
