<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEtiquetasCaja
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
        Me.txtlotetapa = New System.Windows.Forms.TextBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.txtlotenvase = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpfec = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcantop = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtarticulo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtund = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.rd2 = New System.Windows.Forms.RadioButton()
        Me.rd1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblcliente = New System.Windows.Forms.TextBox()
        Me.lblarticulo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblund = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtlotetapa
        '
        Me.txtlotetapa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlotetapa.Location = New System.Drawing.Point(149, 27)
        Me.txtlotetapa.MaxLength = 50
        Me.txtlotetapa.Name = "txtlotetapa"
        Me.txtlotetapa.Size = New System.Drawing.Size(221, 20)
        Me.txtlotetapa.TabIndex = 1
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(308, 326)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 196
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(180, 326)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 195
        Me.btnreporte.Text = "Imprimir "
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'txtlotenvase
        '
        Me.txtlotenvase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlotenvase.Location = New System.Drawing.Point(98, 183)
        Me.txtlotenvase.Name = "txtlotenvase"
        Me.txtlotenvase.Size = New System.Drawing.Size(278, 20)
        Me.txtlotenvase.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 191
        Me.Label4.Text = "Lote Envase"
        '
        'dtpfec
        '
        Me.dtpfec.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec.Location = New System.Drawing.Point(98, 152)
        Me.dtpfec.Name = "dtpfec"
        Me.dtpfec.Size = New System.Drawing.Size(92, 20)
        Me.dtpfec.TabIndex = 4
        Me.dtpfec.Value = New Date(2019, 2, 13, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 190
        Me.Label5.Text = "Fecha Prod."
        '
        'txtcantop
        '
        Me.txtcantop.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcantop.Location = New System.Drawing.Point(98, 221)
        Me.txtcantop.Name = "txtcantop"
        Me.txtcantop.Size = New System.Drawing.Size(66, 20)
        Me.txtcantop.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "Cantidad Op."
        '
        'txtarticulo
        '
        Me.txtarticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtarticulo.Location = New System.Drawing.Point(98, 119)
        Me.txtarticulo.Name = "txtarticulo"
        Me.txtarticulo.Size = New System.Drawing.Size(90, 20)
        Me.txtarticulo.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 186
        Me.Label6.Text = "Articulo"
        '
        'txtcliente
        '
        Me.txtcliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcliente.Location = New System.Drawing.Point(98, 88)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(90, 20)
        Me.txtcliente.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 184
        Me.Label3.Text = "Cliente"
        '
        'txtund
        '
        Me.txtund.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtund.Location = New System.Drawing.Point(98, 253)
        Me.txtund.Name = "txtund"
        Me.txtund.Size = New System.Drawing.Size(66, 20)
        Me.txtund.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 294)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 204
        Me.Label1.Text = "Ud. Totales"
        '
        'txttotal
        '
        Me.txttotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttotal.Location = New System.Drawing.Point(98, 287)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(66, 20)
        Me.txttotal.TabIndex = 8
        '
        'rd2
        '
        Me.rd2.AutoSize = True
        Me.rd2.Location = New System.Drawing.Point(9, 40)
        Me.rd2.Name = "rd2"
        Me.rd2.Size = New System.Drawing.Size(130, 17)
        Me.rd2.TabIndex = 101
        Me.rd2.Text = "LOTE DEL PEEL OFF"
        Me.rd2.UseVisualStyleBackColor = True
        '
        'rd1
        '
        Me.rd1.AutoSize = True
        Me.rd1.Checked = True
        Me.rd1.Location = New System.Drawing.Point(9, 17)
        Me.rd1.Name = "rd1"
        Me.rd1.Size = New System.Drawing.Size(102, 17)
        Me.rd1.TabIndex = 100
        Me.rd1.TabStop = True
        Me.rd1.Text = "LOTE DE TAPA"
        Me.rd1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtlotetapa)
        Me.GroupBox1.Controls.Add(Me.rd1)
        Me.GroupBox1.Controls.Add(Me.rd2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 63)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lblcliente
        '
        Me.lblcliente.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcliente.Location = New System.Drawing.Point(189, 88)
        Me.lblcliente.Name = "lblcliente"
        Me.lblcliente.ReadOnly = True
        Me.lblcliente.Size = New System.Drawing.Size(324, 20)
        Me.lblcliente.TabIndex = 219
        '
        'lblarticulo
        '
        Me.lblarticulo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblarticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblarticulo.Location = New System.Drawing.Point(189, 119)
        Me.lblarticulo.Name = "lblarticulo"
        Me.lblarticulo.ReadOnly = True
        Me.lblarticulo.Size = New System.Drawing.Size(324, 20)
        Me.lblarticulo.TabIndex = 220
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 259)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 221
        Me.Label11.Text = "Medida"
        '
        'lblund
        '
        Me.lblund.BackColor = System.Drawing.Color.Gainsboro
        Me.lblund.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblund.Location = New System.Drawing.Point(165, 253)
        Me.lblund.Name = "lblund"
        Me.lblund.ReadOnly = True
        Me.lblund.Size = New System.Drawing.Size(211, 20)
        Me.lblund.TabIndex = 222
        '
        'FormEtiquetasCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 372)
        Me.Controls.Add(Me.lblund)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblarticulo)
        Me.Controls.Add(Me.lblcliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtund)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.txtlotenvase)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpfec)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcantop)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtarticulo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcliente)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FormEtiquetasCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir Etiquetas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtlotetapa As TextBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnreporte As Button
    Friend WithEvents txtlotenvase As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpfec As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcantop As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtarticulo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtund As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents rd2 As RadioButton
    Friend WithEvents rd1 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblcliente As TextBox
    Friend WithEvents lblarticulo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblund As TextBox
End Class
