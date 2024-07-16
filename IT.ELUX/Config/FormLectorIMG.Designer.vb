<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLectorIMG
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
        Me.pbximagen = New System.Windows.Forms.PictureBox()
        CType(Me.pbximagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbximagen
        '
        Me.pbximagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbximagen.Location = New System.Drawing.Point(0, 0)
        Me.pbximagen.Name = "pbximagen"
        Me.pbximagen.Size = New System.Drawing.Size(513, 658)
        Me.pbximagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbximagen.TabIndex = 56
        Me.pbximagen.TabStop = False
        '
        'FormLectorIMG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 658)
        Me.Controls.Add(Me.pbximagen)
        Me.Name = "FormLectorIMG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLectorIMG"
        CType(Me.pbximagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbximagen As PictureBox
End Class
