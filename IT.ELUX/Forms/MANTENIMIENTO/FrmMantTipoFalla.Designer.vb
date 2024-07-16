<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantTipoFalla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantTipoFalla))
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.TSBtnSave = New System.Windows.Forms.ToolStripButton()
        Me.TSBtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.TSBtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdescri = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TSBtnNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 54)
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBtnNew, Me.TSBtnSave, Me.TSBtnEdit, Me.TSBtnDelete, Me.tsbimprimir, Me.tsbSalir, Me.ToolStripSeparator1})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(380, 54)
        Me.ToolStrip.TabIndex = 53
        Me.ToolStrip.Text = "Grabar"
        '
        'TSBtnSave
        '
        Me.TSBtnSave.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSBtnSave.Image = CType(resources.GetObject("TSBtnSave.Image"), System.Drawing.Image)
        Me.TSBtnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBtnSave.Name = "TSBtnSave"
        Me.TSBtnSave.Size = New System.Drawing.Size(46, 51)
        Me.TSBtnSave.Tag = "save"
        Me.TSBtnSave.Text = "&Grabar"
        Me.TSBtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TSBtnEdit
        '
        Me.TSBtnEdit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSBtnEdit.Image = CType(resources.GetObject("TSBtnEdit.Image"), System.Drawing.Image)
        Me.TSBtnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBtnEdit.Name = "TSBtnEdit"
        Me.TSBtnEdit.Size = New System.Drawing.Size(60, 51)
        Me.TSBtnEdit.Text = "&Modificar"
        Me.TSBtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TSBtnDelete
        '
        Me.TSBtnDelete.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSBtnDelete.Image = CType(resources.GetObject("TSBtnDelete.Image"), System.Drawing.Image)
        Me.TSBtnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBtnDelete.Name = "TSBtnDelete"
        Me.TSBtnDelete.Size = New System.Drawing.Size(45, 51)
        Me.TSBtnDelete.Text = "Anular"
        Me.TSBtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbimprimir
        '
        Me.tsbimprimir.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbimprimir.Image = CType(resources.GetObject("tsbimprimir.Image"), System.Drawing.Image)
        Me.tsbimprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbimprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbimprimir.Name = "tsbimprimir"
        Me.tsbimprimir.Size = New System.Drawing.Size(53, 51)
        Me.tsbimprimir.Tag = "Print"
        Me.tsbimprimir.Text = "&Imprimir"
        Me.tsbimprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbimprimir.Visible = False
        '
        'tsbSalir
        '
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(36, 51)
        Me.tsbSalir.Tag = "exit"
        Me.tsbSalir.Text = "Salir"
        Me.tsbSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbestado)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtdescri)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 113)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'cmbestado
        '
        Me.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Location = New System.Drawing.Point(100, 80)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(164, 21)
        Me.cmbestado.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Estado :"
        '
        'txtdescri
        '
        Me.txtdescri.Location = New System.Drawing.Point(100, 48)
        Me.txtdescri.Name = "txtdescri"
        Me.txtdescri.Size = New System.Drawing.Size(164, 22)
        Me.txtdescri.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Descripción :"
        '
        'txtcodigo
        '
        Me.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigo.Location = New System.Drawing.Point(99, 20)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(166, 22)
        Me.txtcodigo.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo :"
        '
        'TSBtnNew
        '
        Me.TSBtnNew.Image = CType(resources.GetObject("TSBtnNew.Image"), System.Drawing.Image)
        Me.TSBtnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBtnNew.Name = "TSBtnNew"
        Me.TSBtnNew.Size = New System.Drawing.Size(46, 51)
        Me.TSBtnNew.Text = "&Nuevo"
        Me.TSBtnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TSBtnNew.Visible = False
        '
        'FrmMantTipoFalla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 178)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "FrmMantTipoFalla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:: (0500) Mantenimiento Tipo de Falla ::."
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents TSBtnSave As ToolStripButton
    Friend WithEvents TSBtnEdit As ToolStripButton
    Friend WithEvents TSBtnDelete As ToolStripButton
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdescri As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbestado As ComboBox
    Friend WithEvents TSBtnNew As ToolStripButton
End Class
