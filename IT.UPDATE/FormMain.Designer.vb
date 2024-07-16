<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblUpdate = New System.Windows.Forms.Label()
        Me.prb2 = New System.Windows.Forms.ProgressBar()
        Me.prb1 = New System.Windows.Forms.ProgressBar()
        Me.tmrClose = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.lblNew = New System.Windows.Forms.Label()
        Me.pcbMain = New System.Windows.Forms.PictureBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lstFiles = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pcbMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(12, 208)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(99, 16)
        Me.lblVersion.TabIndex = 0
        Me.lblVersion.Text = "Versión Actual :"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblUpdate)
        Me.Panel1.Controls.Add(Me.prb2)
        Me.Panel1.Controls.Add(Me.prb1)
        Me.Panel1.Location = New System.Drawing.Point(15, 252)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 111)
        Me.Panel1.TabIndex = 2
        '
        'lblUpdate
        '
        Me.lblUpdate.AutoSize = True
        Me.lblUpdate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdate.ForeColor = System.Drawing.Color.Blue
        Me.lblUpdate.Location = New System.Drawing.Point(12, 85)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(184, 16)
        Me.lblUpdate.TabIndex = 4
        Me.lblUpdate.Text = "Esperando inicio de proceso ..."
        '
        'prb2
        '
        Me.prb2.Location = New System.Drawing.Point(15, 42)
        Me.prb2.Name = "prb2"
        Me.prb2.Size = New System.Drawing.Size(269, 22)
        Me.prb2.TabIndex = 1
        '
        'prb1
        '
        Me.prb1.ForeColor = System.Drawing.Color.Red
        Me.prb1.Location = New System.Drawing.Point(15, 14)
        Me.prb1.Name = "prb1"
        Me.prb1.Size = New System.Drawing.Size(269, 22)
        Me.prb1.TabIndex = 0
        '
        'tmrClose
        '
        Me.tmrClose.Interval = 1000
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNew.Location = New System.Drawing.Point(12, 231)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(97, 16)
        Me.lblNew.TabIndex = 4
        Me.lblNew.Text = "Nueva versión :"
        '
        'pcbMain
        '
        Me.pcbMain.BackColor = System.Drawing.Color.White
        Me.pcbMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.pcbMain.Image = Global.IT.UPDATE.My.Resources.Resources.Centralpack_logo
        Me.pcbMain.Location = New System.Drawing.Point(0, 0)
        Me.pcbMain.Name = "pcbMain"
        Me.pcbMain.Size = New System.Drawing.Size(343, 150)
        Me.pcbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbMain.TabIndex = 5
        Me.pcbMain.TabStop = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Image = Global.IT.UPDATE.My.Resources.Resources.update21
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(70, 156)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(187, 41)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Actualizar sistema"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'lstFiles
        '
        Me.lstFiles.FormattingEnabled = True
        Me.lstFiles.Location = New System.Drawing.Point(439, 207)
        Me.lstFiles.Name = "lstFiles"
        Me.lstFiles.Size = New System.Drawing.Size(20, 17)
        Me.lstFiles.TabIndex = 3
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(343, 376)
        Me.Controls.Add(Me.pcbMain)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.lstFiles)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblVersion)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CENTRALPACK CORP"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pcbMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVersion As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents prb2 As ProgressBar
    Friend WithEvents prb1 As ProgressBar
    Friend WithEvents lblUpdate As Label
    Friend WithEvents tmrClose As Timer
    Friend WithEvents tmrUpdate As Timer
    Friend WithEvents lblNew As Label
    Friend WithEvents pcbMain As PictureBox
    Friend WithEvents lstFiles As ListBox
End Class
