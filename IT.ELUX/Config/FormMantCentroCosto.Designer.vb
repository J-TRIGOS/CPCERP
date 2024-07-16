<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMantCentroCosto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantCentroCosto))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbest = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.cmbuninego = New System.Windows.Forms.ComboBox()
        Me.cmbclasificacion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1.SuspendLayout()
        Me.General.SuspendLayout()
        Me.tsbForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'txtcod
        '
        Me.txtcod.Enabled = False
        Me.txtcod.Location = New System.Drawing.Point(114, 34)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(95, 21)
        Me.txtcod.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'txtnom
        '
        Me.txtnom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnom.Location = New System.Drawing.Point(114, 62)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(231, 21)
        Me.txtnom.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Unidad Negocio"
        '
        'cmbest
        '
        Me.cmbest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbest.FormattingEnabled = True
        Me.cmbest.Items.AddRange(New Object() {"Habilitado", "Anulado"})
        Me.cmbest.Location = New System.Drawing.Point(114, 118)
        Me.cmbest.Name = "cmbest"
        Me.cmbest.Size = New System.Drawing.Size(154, 21)
        Me.cmbest.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Estado"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(403, 188)
        Me.TabControl1.TabIndex = 15
        '
        'General
        '
        Me.General.Controls.Add(Me.cmbuninego)
        Me.General.Controls.Add(Me.cmbclasificacion)
        Me.General.Controls.Add(Me.Label3)
        Me.General.Controls.Add(Me.cmbest)
        Me.General.Controls.Add(Me.Label1)
        Me.General.Controls.Add(Me.Label5)
        Me.General.Controls.Add(Me.txtcod)
        Me.General.Controls.Add(Me.Label2)
        Me.General.Controls.Add(Me.Label4)
        Me.General.Controls.Add(Me.txtnom)
        Me.General.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(395, 162)
        Me.General.TabIndex = 0
        Me.General.Text = "General"
        Me.General.UseVisualStyleBackColor = True
        '
        'cmbuninego
        '
        Me.cmbuninego.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbuninego.FormattingEnabled = True
        Me.cmbuninego.Items.AddRange(New Object() {"HOJALATA", "COMUN A TODOS"})
        Me.cmbuninego.Location = New System.Drawing.Point(114, 91)
        Me.cmbuninego.Name = "cmbuninego"
        Me.cmbuninego.Size = New System.Drawing.Size(231, 21)
        Me.cmbuninego.TabIndex = 4
        '
        'cmbclasificacion
        '
        Me.cmbclasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbclasificacion.FormattingEnabled = True
        Me.cmbclasificacion.Location = New System.Drawing.Point(114, 7)
        Me.cmbclasificacion.Name = "cmbclasificacion"
        Me.cmbclasificacion.Size = New System.Drawing.Size(231, 21)
        Me.cmbclasificacion.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Clasificacion"
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(430, 25)
        Me.tsbForm.TabIndex = 16
        Me.tsbForm.Text = "Grabar"
        '
        'tsbGrabar
        '
        Me.tsbGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGrabar.Image = CType(resources.GetObject("tsbGrabar.Image"), System.Drawing.Image)
        Me.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabar.Name = "tsbGrabar"
        Me.tsbGrabar.Size = New System.Drawing.Size(23, 22)
        Me.tsbGrabar.Tag = "save"
        Me.tsbGrabar.Text = "Grabar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(23, 22)
        Me.tsbSalir.Tag = "exit"
        Me.tsbSalir.Text = "Salir"
        '
        'FormMantCentroCosto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 241)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormMantCentroCosto"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCentroCosto"
        Me.TabControl1.ResumeLayout(False)
        Me.General.ResumeLayout(False)
        Me.General.PerformLayout()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtcod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbest As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents General As TabPage
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents cmbclasificacion As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbuninego As ComboBox
End Class
