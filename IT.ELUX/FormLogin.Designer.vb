<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.UcLogin1 = New itDLL.ucLogin()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UcLogin1
        '
        Me.UcLogin1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UcLogin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcLogin1.Location = New System.Drawing.Point(0, 0)
        Me.UcLogin1.Name = "UcLogin1"
        Me.UcLogin1.Password = Nothing
        Me.UcLogin1.Size = New System.Drawing.Size(272, 304)
        Me.UcLogin1.TabIndex = 0
        Me.UcLogin1.User = Nothing
        '
        'lblVersion
        '
        Me.lblVersion.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblVersion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(167, 282)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(93, 13)
        Me.lblVersion.TabIndex = 1
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 304)
        Me.Controls.Add(Me.UcLogin1)
        Me.Controls.Add(Me.lblVersion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLogin"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcLogin1 As itDLL.ucLogin
    Friend WithEvents lblVersion As Label
End Class
