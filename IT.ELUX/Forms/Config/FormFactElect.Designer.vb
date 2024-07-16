<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFactElect
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
        Me.txttexto = New System.Windows.Forms.TextBox()
        Me.btngenerar = New System.Windows.Forms.Button()
        Me.btnregresar = New System.Windows.Forms.Button()
        Me.btnGenerarFE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txttexto
        '
        Me.txttexto.Location = New System.Drawing.Point(12, 12)
        Me.txttexto.MaxLength = 32767000
        Me.txttexto.Multiline = True
        Me.txttexto.Name = "txttexto"
        Me.txttexto.Size = New System.Drawing.Size(614, 295)
        Me.txttexto.TabIndex = 0
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(23, 313)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(75, 23)
        Me.btngenerar.TabIndex = 1
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseVisualStyleBackColor = True
        '
        'btnregresar
        '
        Me.btnregresar.Location = New System.Drawing.Point(551, 313)
        Me.btnregresar.Name = "btnregresar"
        Me.btnregresar.Size = New System.Drawing.Size(75, 23)
        Me.btnregresar.TabIndex = 2
        Me.btnregresar.Text = "Regresar"
        Me.btnregresar.UseVisualStyleBackColor = True
        '
        'btnGenerarFE
        '
        Me.btnGenerarFE.Location = New System.Drawing.Point(470, 313)
        Me.btnGenerarFE.Name = "btnGenerarFE"
        Me.btnGenerarFE.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerarFE.TabIndex = 3
        Me.btnGenerarFE.Text = "Generar"
        Me.btnGenerarFE.UseVisualStyleBackColor = True
        '
        'FormFactElect
        '
        Me.AcceptButton = Me.btngenerar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 348)
        Me.Controls.Add(Me.btnGenerarFE)
        Me.Controls.Add(Me.btnregresar)
        Me.Controls.Add(Me.btngenerar)
        Me.Controls.Add(Me.txttexto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormFactElect"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormFactElect"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txttexto As TextBox
    Friend WithEvents btngenerar As Button
    Friend WithEvents btnregresar As Button
    Friend WithEvents btnGenerarFE As Button
End Class
