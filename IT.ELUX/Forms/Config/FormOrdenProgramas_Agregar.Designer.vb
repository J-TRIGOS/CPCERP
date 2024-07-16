<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrdenProgramas_Agregar
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
        Me.lbldes_art = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblcod_art = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbllin_prod = New System.Windows.Forms.TextBox()
        Me.txtprc_prod = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbldes_art
        '
        Me.lbldes_art.BackColor = System.Drawing.Color.Gainsboro
        Me.lbldes_art.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldes_art.Location = New System.Drawing.Point(161, 31)
        Me.lbldes_art.Name = "lbldes_art"
        Me.lbldes_art.ReadOnly = True
        Me.lbldes_art.Size = New System.Drawing.Size(358, 20)
        Me.lbldes_art.TabIndex = 196
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 197
        Me.Label1.Text = "Artículo"
        '
        'lblcod_art
        '
        Me.lblcod_art.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcod_art.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcod_art.Location = New System.Drawing.Point(68, 31)
        Me.lblcod_art.Name = "lblcod_art"
        Me.lblcod_art.ReadOnly = True
        Me.lblcod_art.Size = New System.Drawing.Size(92, 20)
        Me.lblcod_art.TabIndex = 198
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 199
        Me.Label2.Text = "Proceso"
        '
        'lbllin_prod
        '
        Me.lbllin_prod.BackColor = System.Drawing.Color.Gainsboro
        Me.lbllin_prod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbllin_prod.Location = New System.Drawing.Point(131, 66)
        Me.lbllin_prod.Name = "lbllin_prod"
        Me.lbllin_prod.ReadOnly = True
        Me.lbllin_prod.Size = New System.Drawing.Size(388, 20)
        Me.lbllin_prod.TabIndex = 201
        '
        'txtprc_prod
        '
        Me.txtprc_prod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtprc_prod.Location = New System.Drawing.Point(68, 66)
        Me.txtprc_prod.MaxLength = 15
        Me.txtprc_prod.Name = "txtprc_prod"
        Me.txtprc_prod.Size = New System.Drawing.Size(62, 20)
        Me.txtprc_prod.TabIndex = 200
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(253, 107)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 202
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(343, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 203
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lbldes_art)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.lblcod_art)
        Me.GroupBox1.Controls.Add(Me.lbllin_prod)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtprc_prod)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 146)
        Me.GroupBox1.TabIndex = 204
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese el Proceso"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(111, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 23)
        Me.Button1.TabIndex = 204
        Me.Button1.Text = "Nuevo Proceso"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(537, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(28, 23)
        Me.Button3.TabIndex = 205
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FormOrdenProgramas_Agregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 169)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormOrdenProgramas_Agregar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Duracion de Articulos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbldes_art As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblcod_art As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbllin_prod As TextBox
    Friend WithEvents txtprc_prod As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
