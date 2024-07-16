<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMantELTBCLIENTE_tel
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
        Me.txtcontacto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblcor_cod = New System.Windows.Forms.Label()
        Me.chkcontatel = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtobservacion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.npdlineacredito = New System.Windows.Forms.TextBox()
        Me.npdlineadol = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtcontacto
        '
        Me.txtcontacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcontacto.Location = New System.Drawing.Point(91, 65)
        Me.txtcontacto.MaxLength = 100
        Me.txtcontacto.Name = "txtcontacto"
        Me.txtcontacto.Size = New System.Drawing.Size(270, 20)
        Me.txtcontacto.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 23)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Contacto"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(227, 210)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(81, 23)
        Me.btncancelar.TabIndex = 4
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(113, 209)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(81, 23)
        Me.btnaceptar.TabIndex = 3
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 23)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Telefono"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnom
        '
        Me.txtnom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnom.Location = New System.Drawing.Point(91, 37)
        Me.txtnom.MaxLength = 100
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(122, 20)
        Me.txtnom.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 23)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Codigo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcor_cod
        '
        Me.lblcor_cod.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcor_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcor_cod.Location = New System.Drawing.Point(91, 9)
        Me.lblcor_cod.Name = "lblcor_cod"
        Me.lblcor_cod.Size = New System.Drawing.Size(37, 20)
        Me.lblcor_cod.TabIndex = 70
        Me.lblcor_cod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkcontatel
        '
        Me.chkcontatel.AutoSize = True
        Me.chkcontatel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkcontatel.Checked = True
        Me.chkcontatel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkcontatel.Location = New System.Drawing.Point(19, 187)
        Me.chkcontatel.Name = "chkcontatel"
        Me.chkcontatel.Size = New System.Drawing.Size(71, 17)
        Me.chkcontatel.TabIndex = 71
        Me.chkcontatel.Text = "Cobranza"
        Me.chkcontatel.UseVisualStyleBackColor = True
        Me.chkcontatel.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Observacion"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtobservacion
        '
        Me.txtobservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobservacion.Location = New System.Drawing.Point(91, 99)
        Me.txtobservacion.MaxLength = 100
        Me.txtobservacion.Multiline = True
        Me.txtobservacion.Name = "txtobservacion"
        Me.txtobservacion.Size = New System.Drawing.Size(270, 49)
        Me.txtobservacion.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "L. Credito S/."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'npdlineacredito
        '
        Me.npdlineacredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.npdlineacredito.Location = New System.Drawing.Point(91, 154)
        Me.npdlineacredito.MaxLength = 100
        Me.npdlineacredito.Name = "npdlineacredito"
        Me.npdlineacredito.Size = New System.Drawing.Size(77, 20)
        Me.npdlineacredito.TabIndex = 75
        '
        'npdlineadol
        '
        Me.npdlineadol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.npdlineadol.Location = New System.Drawing.Point(284, 154)
        Me.npdlineadol.MaxLength = 100
        Me.npdlineadol.Name = "npdlineadol"
        Me.npdlineadol.Size = New System.Drawing.Size(77, 20)
        Me.npdlineadol.TabIndex = 77
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(211, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "L. Credito $"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'formMantELTBCLIENTE_tel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 245)
        Me.Controls.Add(Me.npdlineadol)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.npdlineacredito)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtobservacion)
        Me.Controls.Add(Me.Label1)
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
        Me.Name = "formMantELTBCLIENTE_tel"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Telefono"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcontacto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnaceptar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtnom As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblcor_cod As Label
    Friend WithEvents chkcontatel As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtobservacion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents npdlineacredito As TextBox
    Friend WithEvents npdlineadol As TextBox
    Friend WithEvents Label4 As Label
End Class
