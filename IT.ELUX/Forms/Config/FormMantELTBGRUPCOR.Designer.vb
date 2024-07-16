<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMantELTBGRUPCOR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantELTBGRUPCOR))
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.tbcValores = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lstValor = New System.Windows.Forms.ListBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.cmbcodest = New System.Windows.Forms.ComboBox()
        Me.txtdescri = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsbForm.SuspendLayout()
        Me.tbcValores.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.General.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(415, 25)
        Me.tsbForm.TabIndex = 17
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
        'tbcValores
        '
        Me.tbcValores.Controls.Add(Me.TabPage1)
        Me.tbcValores.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcValores.Location = New System.Drawing.Point(16, 198)
        Me.tbcValores.Name = "tbcValores"
        Me.tbcValores.SelectedIndex = 0
        Me.tbcValores.Size = New System.Drawing.Size(375, 328)
        Me.tbcValores.TabIndex = 23
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lstValor)
        Me.TabPage1.Controls.Add(Me.btnBorrar)
        Me.TabPage1.Controls.Add(Me.btnAgregar)
        Me.TabPage1.Controls.Add(Me.txtValor)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(367, 302)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Valores"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lstValor
        '
        Me.lstValor.FormattingEnabled = True
        Me.lstValor.Location = New System.Drawing.Point(22, 70)
        Me.lstValor.Name = "lstValor"
        Me.lstValor.Size = New System.Drawing.Size(251, 212)
        Me.lstValor.TabIndex = 9
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(279, 70)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 8
        Me.btnBorrar.Text = "Eliminar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(279, 28)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtValor
        '
        Me.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValor.Location = New System.Drawing.Point(81, 30)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(183, 21)
        Me.txtValor.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 23)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Valor :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 31)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(379, 151)
        Me.TabControl1.TabIndex = 24
        '
        'General
        '
        Me.General.Controls.Add(Me.cmbcodest)
        Me.General.Controls.Add(Me.txtdescri)
        Me.General.Controls.Add(Me.txtcodigo)
        Me.General.Controls.Add(Me.Label3)
        Me.General.Controls.Add(Me.Label2)
        Me.General.Controls.Add(Me.Label1)
        Me.General.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(371, 125)
        Me.General.TabIndex = 0
        Me.General.Text = "General"
        Me.General.UseVisualStyleBackColor = True
        '
        'cmbcodest
        '
        Me.cmbcodest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcodest.FormattingEnabled = True
        Me.cmbcodest.Items.AddRange(New Object() {"Inactivo", "Activo"})
        Me.cmbcodest.Location = New System.Drawing.Point(107, 86)
        Me.cmbcodest.Name = "cmbcodest"
        Me.cmbcodest.Size = New System.Drawing.Size(121, 21)
        Me.cmbcodest.TabIndex = 8
        '
        'txtdescri
        '
        Me.txtdescri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescri.Location = New System.Drawing.Point(107, 59)
        Me.txtdescri.Name = "txtdescri"
        Me.txtdescri.Size = New System.Drawing.Size(234, 21)
        Me.txtdescri.TabIndex = 7
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(107, 30)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(35, 21)
        Me.txtcodigo.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Estado :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descripcion :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormMantELTBGRUPCOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 543)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.tbcValores)
        Me.Controls.Add(Me.tsbForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormMantELTBGRUPCOR"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMantELTBGRUPCOR"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.tbcValores.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.General.ResumeLayout(False)
        Me.General.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents tbcValores As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lstValor As ListBox
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents General As TabPage
    Friend WithEvents cmbcodest As ComboBox
    Friend WithEvents txtdescri As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
