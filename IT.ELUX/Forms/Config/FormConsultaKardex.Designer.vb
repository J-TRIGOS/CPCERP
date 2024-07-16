<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultaKardex
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodart = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblsituacion = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnasignar = New System.Windows.Forms.Button()
        Me.lbldescripcion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción"
        '
        'txtcodart
        '
        Me.txtcodart.Location = New System.Drawing.Point(121, 32)
        Me.txtcodart.Name = "txtcodart"
        Me.txtcodart.Size = New System.Drawing.Size(100, 20)
        Me.txtcodart.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Situación"
        '
        'lblsituacion
        '
        Me.lblsituacion.BackColor = System.Drawing.Color.Gainsboro
        Me.lblsituacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblsituacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsituacion.Location = New System.Drawing.Point(121, 94)
        Me.lblsituacion.Name = "lblsituacion"
        Me.lblsituacion.Size = New System.Drawing.Size(251, 21)
        Me.lblsituacion.TabIndex = 42
        Me.lblsituacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(221, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 22)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnasignar
        '
        Me.btnasignar.Location = New System.Drawing.Point(372, 93)
        Me.btnasignar.Name = "btnasignar"
        Me.btnasignar.Size = New System.Drawing.Size(92, 23)
        Me.btnasignar.TabIndex = 44
        Me.btnasignar.Text = "Asignar Kardex"
        Me.btnasignar.UseVisualStyleBackColor = True
        '
        'lbldescripcion
        '
        Me.lbldescripcion.Location = New System.Drawing.Point(121, 65)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.ReadOnly = True
        Me.lbldescripcion.Size = New System.Drawing.Size(343, 20)
        Me.lbldescripcion.TabIndex = 45
        '
        'FormConsultaKardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 155)
        Me.Controls.Add(Me.lbldescripcion)
        Me.Controls.Add(Me.btnasignar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblsituacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcodart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormConsultaKardex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Kardex por Articulo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcodart As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblsituacion As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnasignar As Button
    Friend WithEvents lbldescripcion As TextBox
End Class
