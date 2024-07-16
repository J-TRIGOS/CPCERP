<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRPTBINDCARD
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
        Me.txtnomart1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtarticulo1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnro = New System.Windows.Forms.TextBox()
        Me.npdcantidad = New System.Windows.Forms.NumericUpDown()
        Me.txtnbulto = New System.Windows.Forms.TextBox()
        Me.txtunidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.npdcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnomart1
        '
        Me.txtnomart1.Location = New System.Drawing.Point(141, 53)
        Me.txtnomart1.MaxLength = 8
        Me.txtnomart1.Name = "txtnomart1"
        Me.txtnomart1.ReadOnly = True
        Me.txtnomart1.Size = New System.Drawing.Size(274, 20)
        Me.txtnomart1.TabIndex = 158
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(421, 51)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 23)
        Me.Button3.TabIndex = 157
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtarticulo1
        '
        Me.txtarticulo1.Location = New System.Drawing.Point(73, 53)
        Me.txtarticulo1.MaxLength = 8
        Me.txtarticulo1.Name = "txtarticulo1"
        Me.txtarticulo1.Size = New System.Drawing.Size(64, 20)
        Me.txtarticulo1.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 156
        Me.Label7.Text = "Articulo:"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(242, 131)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 160
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(146, 131)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 159
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 161
        Me.Label1.Text = "Cantidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = "Nro. Doc.:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(211, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 163
        Me.Label3.Text = "Nro. Bulto:"
        '
        'txtnro
        '
        Me.txtnro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnro.Location = New System.Drawing.Point(73, 25)
        Me.txtnro.MaxLength = 8
        Me.txtnro.Name = "txtnro"
        Me.txtnro.Size = New System.Drawing.Size(71, 20)
        Me.txtnro.TabIndex = 1
        '
        'npdcantidad
        '
        Me.npdcantidad.DecimalPlaces = 2
        Me.npdcantidad.Location = New System.Drawing.Point(73, 105)
        Me.npdcantidad.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npdcantidad.Name = "npdcantidad"
        Me.npdcantidad.Size = New System.Drawing.Size(108, 20)
        Me.npdcantidad.TabIndex = 3
        '
        'txtnbulto
        '
        Me.txtnbulto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnbulto.Location = New System.Drawing.Point(274, 106)
        Me.txtnbulto.MaxLength = 8
        Me.txtnbulto.Name = "txtnbulto"
        Me.txtnbulto.Size = New System.Drawing.Size(93, 20)
        Me.txtnbulto.TabIndex = 4
        '
        'txtunidad
        '
        Me.txtunidad.Location = New System.Drawing.Point(73, 79)
        Me.txtunidad.MaxLength = 8
        Me.txtunidad.Name = "txtunidad"
        Me.txtunidad.ReadOnly = True
        Me.txtunidad.Size = New System.Drawing.Size(108, 20)
        Me.txtunidad.TabIndex = 164
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Unidad:"
        '
        'FormRPTBINDCARD
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 178)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtunidad)
        Me.Controls.Add(Me.txtnbulto)
        Me.Controls.Add(Me.npdcantidad)
        Me.Controls.Add(Me.txtnro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.txtnomart1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtarticulo1)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRPTBINDCARD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRPTBINDCARD"
        CType(Me.npdcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnomart1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents txtarticulo1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnreporte As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnro As TextBox
    Friend WithEvents npdcantidad As NumericUpDown
    Friend WithEvents txtnbulto As TextBox
    Friend WithEvents txtunidad As TextBox
    Friend WithEvents Label4 As Label
End Class
