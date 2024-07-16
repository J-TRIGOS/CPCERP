<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExplosion
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormExplosion))
        Me.tvwExplosion = New System.Windows.Forms.TreeView()
        Me.imgExplosion = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'tvwExplosion
        '
        Me.tvwExplosion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvwExplosion.ImageIndex = 0
        Me.tvwExplosion.ImageList = Me.imgExplosion
        Me.tvwExplosion.Location = New System.Drawing.Point(12, 12)
        Me.tvwExplosion.Name = "tvwExplosion"
        Me.tvwExplosion.SelectedImageIndex = 0
        Me.tvwExplosion.Size = New System.Drawing.Size(694, 437)
        Me.tvwExplosion.TabIndex = 1
        '
        'imgExplosion
        '
        Me.imgExplosion.ImageStream = CType(resources.GetObject("imgExplosion.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgExplosion.TransparentColor = System.Drawing.Color.Transparent
        Me.imgExplosion.Images.SetKeyName(0, "can.ico")
        Me.imgExplosion.Images.SetKeyName(1, "componentes2.ico")
        Me.imgExplosion.Images.SetKeyName(2, "insumos.ico")
        '
        'FormExplosion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 461)
        Me.Controls.Add(Me.tvwExplosion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormExplosion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Explosión de materiales"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tvwExplosion As TreeView
    Friend WithEvents imgExplosion As ImageList
End Class
