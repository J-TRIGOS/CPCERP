<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMantELTBPROVEEDORES_tel
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
        Me.chkcontatel = New System.Windows.Forms.CheckBox()
        Me.lblcor_cod = New System.Windows.Forms.Label()
        Me.txtcontacto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chkcontatel
        '
        Me.chkcontatel.AutoSize = True
        Me.chkcontatel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkcontatel.Location = New System.Drawing.Point(18, 102)
        Me.chkcontatel.Name = "chkcontatel"
        Me.chkcontatel.Size = New System.Drawing.Size(84, 17)
        Me.chkcontatel.TabIndex = 80
        Me.chkcontatel.Text = "Contabilidad"
        Me.chkcontatel.UseVisualStyleBackColor = True
        '
        'lblcor_cod
        '
        Me.lblcor_cod.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcor_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcor_cod.Location = New System.Drawing.Point(89, 9)
        Me.lblcor_cod.Name = "lblcor_cod"
        Me.lblcor_cod.Size = New System.Drawing.Size(37, 20)
        Me.lblcor_cod.TabIndex = 79
        Me.lblcor_cod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcontacto
        '
        Me.txtcontacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcontacto.Location = New System.Drawing.Point(89, 65)
        Me.txtcontacto.MaxLength = 100
        Me.txtcontacto.Name = "txtcontacto"
        Me.txtcontacto.Size = New System.Drawing.Size(270, 20)
        Me.txtcontacto.TabIndex = 73
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 23)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Contacto"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(237, 131)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(81, 23)
        Me.btncancelar.TabIndex = 75
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(123, 130)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(81, 23)
        Me.btnaceptar.TabIndex = 74
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 23)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Telefono"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnom
        '
        Me.txtnom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnom.Location = New System.Drawing.Point(89, 37)
        Me.txtnom.MaxLength = 100
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(122, 20)
        Me.txtnom.TabIndex = 72
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 23)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Codigo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormMantELTBPROVEEDORES_tel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 166)
        Me.Controls.Add(Me.chkcontatel)
        Me.Controls.Add(Me.lblcor_cod)
        Me.Controls.Add(Me.txtcontacto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnom)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormMantELTBPROVEEDORES_tel"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Telefono"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkcontatel As CheckBox
    Friend WithEvents lblcor_cod As Label
    Friend WithEvents txtcontacto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnaceptar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtnom As TextBox
    Friend WithEvents Label7 As Label
End Class
