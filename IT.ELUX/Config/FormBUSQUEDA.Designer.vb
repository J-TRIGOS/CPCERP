<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBUSQUEDA
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
        Me.dgvbusqueda = New System.Windows.Forms.DataGridView()
        Me.tsbMant = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tsbCamposSeek = New System.Windows.Forms.ToolStripComboBox()
        Me.tsTextSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tstLblInfo = New System.Windows.Forms.ToolStripLabel()
        Me.lblRecNo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.chkestado = New System.Windows.Forms.CheckBox()
        CType(Me.dgvbusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsbMant.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvbusqueda
        '
        Me.dgvbusqueda.AllowUserToAddRows = False
        Me.dgvbusqueda.AllowUserToDeleteRows = False
        Me.dgvbusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvbusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbusqueda.Location = New System.Drawing.Point(12, 51)
        Me.dgvbusqueda.Name = "dgvbusqueda"
        Me.dgvbusqueda.ReadOnly = True
        Me.dgvbusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvbusqueda.Size = New System.Drawing.Size(700, 220)
        Me.dgvbusqueda.TabIndex = 2
        '
        'tsbMant
        '
        Me.tsbMant.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.ToolStripLabel1, Me.tsbCamposSeek, Me.tsTextSearch, Me.ToolStripSeparator4, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.tstLblInfo})
        Me.tsbMant.Location = New System.Drawing.Point(0, 0)
        Me.tsbMant.Name = "tsbMant"
        Me.tsbMant.Size = New System.Drawing.Size(724, 25)
        Me.tsbMant.TabIndex = 0
        Me.tsbMant.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(130, 22)
        Me.ToolStripLabel1.Text = "Busqueda por campo :"
        '
        'tsbCamposSeek
        '
        Me.tsbCamposSeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tsbCamposSeek.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbCamposSeek.Name = "tsbCamposSeek"
        Me.tsbCamposSeek.Size = New System.Drawing.Size(121, 25)
        '
        'tsTextSearch
        '
        Me.tsTextSearch.BackColor = System.Drawing.SystemColors.Info
        Me.tsTextSearch.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsTextSearch.Name = "tsTextSearch"
        Me.tsTextSearch.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(139, 22)
        Me.ToolStripLabel2.Text = "                                            "
        '
        'tstLblInfo
        '
        Me.tstLblInfo.AutoSize = False
        Me.tstLblInfo.BackColor = System.Drawing.Color.Silver
        Me.tstLblInfo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tstLblInfo.Name = "tstLblInfo"
        Me.tstLblInfo.Size = New System.Drawing.Size(90, 22)
        '
        'lblRecNo
        '
        Me.lblRecNo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRecNo.Location = New System.Drawing.Point(664, 35)
        Me.lblRecNo.Name = "lblRecNo"
        Me.lblRecNo.Size = New System.Drawing.Size(48, 13)
        Me.lblRecNo.TabIndex = 14
        Me.lblRecNo.Text = "0"
        Me.lblRecNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(609, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Registros :"
        '
        'cmbestado
        '
        Me.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"Todo", "Pendiente", "Despachado", "Cerrado"})
        Me.cmbestado.Location = New System.Drawing.Point(489, 2)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(121, 21)
        Me.cmbestado.TabIndex = 15
        Me.cmbestado.Visible = False
        '
        'chkestado
        '
        Me.chkestado.AutoSize = True
        Me.chkestado.Location = New System.Drawing.Point(491, 4)
        Me.chkestado.Name = "chkestado"
        Me.chkestado.Size = New System.Drawing.Size(56, 17)
        Me.chkestado.TabIndex = 16
        Me.chkestado.Text = "Todos"
        Me.chkestado.UseVisualStyleBackColor = True
        Me.chkestado.Visible = False
        '
        'FormBUSQUEDA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 283)
        Me.Controls.Add(Me.chkestado)
        Me.Controls.Add(Me.cmbestado)
        Me.Controls.Add(Me.lblRecNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tsbMant)
        Me.Controls.Add(Me.dgvbusqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormBUSQUEDA"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBUSQUEDA"
        CType(Me.dgvbusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsbMant.ResumeLayout(False)
        Me.tsbMant.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvbusqueda As DataGridView
    Friend WithEvents tsbMant As ToolStrip
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents tsbCamposSeek As ToolStripComboBox
    Friend WithEvents tsTextSearch As ToolStripTextBox
    Friend WithEvents tstLblInfo As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents lblRecNo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbestado As ComboBox
    Friend WithEvents chkestado As CheckBox
End Class
