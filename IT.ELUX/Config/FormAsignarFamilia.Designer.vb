<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAsignarFamilia
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
        Me.lbldescripcion = New System.Windows.Forms.TextBox()
        Me.txtcodart = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtfam_Cod = New System.Windows.Forms.TextBox()
        Me.lblfam_cod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbldescripcion
        '
        Me.lbldescripcion.BackColor = System.Drawing.Color.Gainsboro
        Me.lbldescripcion.Location = New System.Drawing.Point(154, 41)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.ReadOnly = True
        Me.lbldescripcion.Size = New System.Drawing.Size(366, 20)
        Me.lbldescripcion.TabIndex = 50
        '
        'txtcodart
        '
        Me.txtcodart.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodart.Location = New System.Drawing.Point(67, 41)
        Me.txtcodart.MaxLength = 8
        Me.txtcodart.Name = "txtcodart"
        Me.txtcodart.Size = New System.Drawing.Size(86, 20)
        Me.txtcodart.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Articulo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Familia"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(239, 119)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtfam_Cod
        '
        Me.txtfam_Cod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfam_Cod.Location = New System.Drawing.Point(67, 78)
        Me.txtfam_Cod.MaxLength = 3
        Me.txtfam_Cod.Name = "txtfam_Cod"
        Me.txtfam_Cod.Size = New System.Drawing.Size(33, 20)
        Me.txtfam_Cod.TabIndex = 2
        '
        'lblfam_cod
        '
        Me.lblfam_cod.BackColor = System.Drawing.Color.Gainsboro
        Me.lblfam_cod.Location = New System.Drawing.Point(101, 78)
        Me.lblfam_cod.Name = "lblfam_cod"
        Me.lblfam_cod.ReadOnly = True
        Me.lblfam_cod.Size = New System.Drawing.Size(173, 20)
        Me.lblfam_cod.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(523, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "F9"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(277, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 15)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "F9"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(329, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Label5"
        Me.Label5.Visible = False
        '
        'FormAsignarFamilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 153)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblfam_cod)
        Me.Controls.Add(Me.txtfam_Cod)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbldescripcion)
        Me.Controls.Add(Me.txtcodart)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormAsignarFamilia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignar Familia de Artículo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbldescripcion As TextBox
    Friend WithEvents txtcodart As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtfam_Cod As TextBox
    Friend WithEvents lblfam_cod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
