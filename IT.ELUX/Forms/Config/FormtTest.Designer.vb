<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormtTest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbcentrocosto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodcco = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmbcentrocosto
        '
        Me.cmbcentrocosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcentrocosto.FormattingEnabled = True
        Me.cmbcentrocosto.Location = New System.Drawing.Point(249, 54)
        Me.cmbcentrocosto.Name = "cmbcentrocosto"
        Me.cmbcentrocosto.Size = New System.Drawing.Size(290, 21)
        Me.cmbcentrocosto.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'txtcodcco
        '
        Me.txtcodcco.Location = New System.Drawing.Point(114, 54)
        Me.txtcodcco.Name = "txtcodcco"
        Me.txtcodcco.Size = New System.Drawing.Size(118, 20)
        Me.txtcodcco.TabIndex = 3
        '
        'FormtTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 140)
        Me.Controls.Add(Me.cmbcentrocosto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcodcco)
        Me.Name = "FormtTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormtTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbcentrocosto As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcodcco As TextBox
End Class
