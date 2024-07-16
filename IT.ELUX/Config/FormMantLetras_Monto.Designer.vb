<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMantLetras_Monto
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_cliente = New System.Windows.Forms.TextBox()
        Me.lblproveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.lblmon = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl01 = New System.Windows.Forms.TextBox()
        Me.lbl02 = New System.Windows.Forms.TextBox()
        Me.lbl03 = New System.Windows.Forms.TextBox()
        Me.txtmon = New System.Windows.Forms.TextBox()
        Me.lblt_cambio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblmontos = New System.Windows.Forms.TextBox()
        Me.lblmontod = New System.Windows.Forms.TextBox()
        Me.txtmontos = New System.Windows.Forms.NumericUpDown()
        Me.txtmontod = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.txtmontos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmontod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 16)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Cliente"
        '
        'lbl_cliente
        '
        Me.lbl_cliente.BackColor = System.Drawing.Color.Gainsboro
        Me.lbl_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_cliente.Location = New System.Drawing.Point(187, 55)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.ReadOnly = True
        Me.lbl_cliente.Size = New System.Drawing.Size(344, 20)
        Me.lbl_cliente.TabIndex = 194
        '
        'lblproveedor
        '
        Me.lblproveedor.BackColor = System.Drawing.Color.Gainsboro
        Me.lblproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblproveedor.Location = New System.Drawing.Point(97, 55)
        Me.lblproveedor.Name = "lblproveedor"
        Me.lblproveedor.ReadOnly = True
        Me.lblproveedor.Size = New System.Drawing.Size(89, 20)
        Me.lblproveedor.TabIndex = 195
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 196
        Me.Label1.Text = "Moneda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 198
        Me.Label2.Text = "Monto S/."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 199
        Me.Label3.Text = "Monto $"
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(188, 240)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnaceptar.TabIndex = 203
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(306, 240)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 204
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'lblmon
        '
        Me.lblmon.BackColor = System.Drawing.Color.Gainsboro
        Me.lblmon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmon.Location = New System.Drawing.Point(130, 89)
        Me.lblmon.Name = "lblmon"
        Me.lblmon.ReadOnly = True
        Me.lblmon.Size = New System.Drawing.Size(106, 20)
        Me.lblmon.TabIndex = 206
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 207
        Me.Label5.Text = "Documento"
        '
        'lbl01
        '
        Me.lbl01.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl01.Location = New System.Drawing.Point(97, 23)
        Me.lbl01.Name = "lbl01"
        Me.lbl01.ReadOnly = True
        Me.lbl01.Size = New System.Drawing.Size(44, 20)
        Me.lbl01.TabIndex = 208
        '
        'lbl02
        '
        Me.lbl02.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl02.Location = New System.Drawing.Point(142, 23)
        Me.lbl02.Name = "lbl02"
        Me.lbl02.ReadOnly = True
        Me.lbl02.Size = New System.Drawing.Size(94, 20)
        Me.lbl02.TabIndex = 209
        '
        'lbl03
        '
        Me.lbl03.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl03.Location = New System.Drawing.Point(237, 23)
        Me.lbl03.Name = "lbl03"
        Me.lbl03.ReadOnly = True
        Me.lbl03.Size = New System.Drawing.Size(92, 20)
        Me.lbl03.TabIndex = 210
        '
        'txtmon
        '
        Me.txtmon.BackColor = System.Drawing.Color.Gainsboro
        Me.txtmon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmon.Location = New System.Drawing.Point(98, 89)
        Me.txtmon.Name = "txtmon"
        Me.txtmon.ReadOnly = True
        Me.txtmon.Size = New System.Drawing.Size(31, 20)
        Me.txtmon.TabIndex = 211
        '
        'lblt_cambio
        '
        Me.lblt_cambio.BackColor = System.Drawing.Color.Gainsboro
        Me.lblt_cambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblt_cambio.Location = New System.Drawing.Point(98, 123)
        Me.lblt_cambio.Name = "lblt_cambio"
        Me.lblt_cambio.ReadOnly = True
        Me.lblt_cambio.Size = New System.Drawing.Size(89, 20)
        Me.lblt_cambio.TabIndex = 212
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 213
        Me.Label4.Text = "T. Cambio"
        '
        'lblmontos
        '
        Me.lblmontos.BackColor = System.Drawing.Color.Gainsboro
        Me.lblmontos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmontos.Location = New System.Drawing.Point(188, 164)
        Me.lblmontos.Name = "lblmontos"
        Me.lblmontos.ReadOnly = True
        Me.lblmontos.Size = New System.Drawing.Size(89, 20)
        Me.lblmontos.TabIndex = 214
        '
        'lblmontod
        '
        Me.lblmontod.BackColor = System.Drawing.Color.Gainsboro
        Me.lblmontod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmontod.Location = New System.Drawing.Point(188, 200)
        Me.lblmontod.Name = "lblmontod"
        Me.lblmontod.ReadOnly = True
        Me.lblmontod.Size = New System.Drawing.Size(89, 20)
        Me.lblmontod.TabIndex = 215
        '
        'txtmontos
        '
        Me.txtmontos.DecimalPlaces = 2
        Me.txtmontos.Location = New System.Drawing.Point(97, 164)
        Me.txtmontos.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.txtmontos.Name = "txtmontos"
        Me.txtmontos.Size = New System.Drawing.Size(90, 20)
        Me.txtmontos.TabIndex = 216
        '
        'txtmontod
        '
        Me.txtmontod.DecimalPlaces = 2
        Me.txtmontod.Location = New System.Drawing.Point(97, 200)
        Me.txtmontod.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.txtmontod.Name = "txtmontod"
        Me.txtmontod.Size = New System.Drawing.Size(90, 20)
        Me.txtmontod.TabIndex = 217
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(195, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 218
        Me.Label6.Text = "Total Actual"
        '
        'FormMantLetras_Monto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 275)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtmontod)
        Me.Controls.Add(Me.txtmontos)
        Me.Controls.Add(Me.lblmontod)
        Me.Controls.Add(Me.lblmontos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblt_cambio)
        Me.Controls.Add(Me.txtmon)
        Me.Controls.Add(Me.lbl03)
        Me.Controls.Add(Me.lbl02)
        Me.Controls.Add(Me.lbl01)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblmon)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblproveedor)
        Me.Controls.Add(Me.lbl_cliente)
        Me.Controls.Add(Me.Label13)
        Me.Name = "FormMantLetras_Monto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso nuevo Monto Factura"
        CType(Me.txtmontos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmontod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_cliente As TextBox
    Friend WithEvents lblproveedor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnaceptar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents lblmon As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl01 As TextBox
    Friend WithEvents lbl02 As TextBox
    Friend WithEvents lbl03 As TextBox
    Friend WithEvents txtmon As TextBox
    Friend WithEvents lblt_cambio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblmontos As TextBox
    Friend WithEvents lblmontod As TextBox
    Friend WithEvents txtmontos As NumericUpDown
    Friend WithEvents txtmontod As NumericUpDown
    Friend WithEvents Label6 As Label
End Class
