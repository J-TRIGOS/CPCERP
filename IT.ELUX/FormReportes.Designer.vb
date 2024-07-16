<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportes
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
        Me.crpReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crpReport
        '
        Me.crpReport.ActiveViewIndex = -1
        Me.crpReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crpReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.crpReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crpReport.Location = New System.Drawing.Point(0, 0)
        Me.crpReport.Name = "crpReport"
        Me.crpReport.Size = New System.Drawing.Size(1030, 565)
        Me.crpReport.TabIndex = 0
        '
        'FormReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 565)
        Me.Controls.Add(Me.crpReport)
        Me.KeyPreview = True
        Me.Name = "FormReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormReportes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crpReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
