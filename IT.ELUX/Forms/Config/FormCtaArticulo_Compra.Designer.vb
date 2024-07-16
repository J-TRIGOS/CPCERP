<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCtaArticulo_Compra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCtaArticulo_Compra))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.lblformato = New System.Windows.Forms.TextBox()
        Me.lbl_ctanom = New System.Windows.Forms.TextBox()
        Me.lblnom = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkestado = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcta_cod = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbanho = New System.Windows.Forms.ComboBox()
        Me.txtart_cod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1.SuspendLayout()
        Me.General.SuspendLayout()
        Me.tsbForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 34)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(662, 270)
        Me.TabControl1.TabIndex = 18
        '
        'General
        '
        Me.General.BackColor = System.Drawing.Color.White
        Me.General.Controls.Add(Me.lblformato)
        Me.General.Controls.Add(Me.lbl_ctanom)
        Me.General.Controls.Add(Me.lblnom)
        Me.General.Controls.Add(Me.Label7)
        Me.General.Controls.Add(Me.chkestado)
        Me.General.Controls.Add(Me.Label5)
        Me.General.Controls.Add(Me.txtcta_cod)
        Me.General.Controls.Add(Me.Label3)
        Me.General.Controls.Add(Me.cmbanho)
        Me.General.Controls.Add(Me.txtart_cod)
        Me.General.Controls.Add(Me.Label2)
        Me.General.Controls.Add(Me.Label1)
        Me.General.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(654, 244)
        Me.General.TabIndex = 0
        Me.General.Text = "GENERAL"
        '
        'lblformato
        '
        Me.lblformato.BackColor = System.Drawing.Color.Gainsboro
        Me.lblformato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblformato.Location = New System.Drawing.Point(82, 107)
        Me.lblformato.Name = "lblformato"
        Me.lblformato.ReadOnly = True
        Me.lblformato.Size = New System.Drawing.Size(108, 21)
        Me.lblformato.TabIndex = 194
        '
        'lbl_ctanom
        '
        Me.lbl_ctanom.BackColor = System.Drawing.Color.Gainsboro
        Me.lbl_ctanom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ctanom.Location = New System.Drawing.Point(191, 141)
        Me.lbl_ctanom.Name = "lbl_ctanom"
        Me.lbl_ctanom.ReadOnly = True
        Me.lbl_ctanom.Size = New System.Drawing.Size(211, 21)
        Me.lbl_ctanom.TabIndex = 193
        '
        'lblnom
        '
        Me.lblnom.BackColor = System.Drawing.Color.Gainsboro
        Me.lblnom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnom.Location = New System.Drawing.Point(191, 74)
        Me.lblnom.MaxLength = 200
        Me.lblnom.Name = "lblnom"
        Me.lblnom.ReadOnly = True
        Me.lblnom.Size = New System.Drawing.Size(424, 21)
        Me.lblnom.TabIndex = 192
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 23)
        Me.Label7.TabIndex = 155
        Me.Label7.Text = "Formato"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkestado
        '
        Me.chkestado.AutoSize = True
        Me.chkestado.Checked = True
        Me.chkestado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkestado.Location = New System.Drawing.Point(82, 182)
        Me.chkestado.Name = "chkestado"
        Me.chkestado.Size = New System.Drawing.Size(15, 14)
        Me.chkestado.TabIndex = 4
        Me.chkestado.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 23)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Estado"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcta_cod
        '
        Me.txtcta_cod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcta_cod.Location = New System.Drawing.Point(82, 141)
        Me.txtcta_cod.MaxLength = 15
        Me.txtcta_cod.Name = "txtcta_cod"
        Me.txtcta_cod.Size = New System.Drawing.Size(108, 21)
        Me.txtcta_cod.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cuenta"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbanho
        '
        Me.cmbanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbanho.FormattingEnabled = True
        Me.cmbanho.Items.AddRange(New Object() {"2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036"})
        Me.cmbanho.Location = New System.Drawing.Point(82, 42)
        Me.cmbanho.Name = "cmbanho"
        Me.cmbanho.Size = New System.Drawing.Size(62, 21)
        Me.cmbanho.TabIndex = 1
        '
        'txtart_cod
        '
        Me.txtart_cod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtart_cod.Location = New System.Drawing.Point(82, 74)
        Me.txtart_cod.MaxLength = 10
        Me.txtart_cod.Name = "txtart_cod"
        Me.txtart_cod.Size = New System.Drawing.Size(108, 21)
        Me.txtart_cod.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Articulo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Año"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbBorrar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(688, 25)
        Me.tsbForm.TabIndex = 19
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
        'tsbBorrar
        '
        Me.tsbBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbBorrar.Image = CType(resources.GetObject("tsbBorrar.Image"), System.Drawing.Image)
        Me.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBorrar.Name = "tsbBorrar"
        Me.tsbBorrar.Size = New System.Drawing.Size(23, 22)
        Me.tsbBorrar.Tag = "delete"
        Me.tsbBorrar.Text = "Borrar"
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
        'FormCtaArticulo_Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 334)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormCtaArticulo_Compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuenta de Articulo Compra"
        Me.TabControl1.ResumeLayout(False)
        Me.General.ResumeLayout(False)
        Me.General.PerformLayout()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents General As TabPage
    Friend WithEvents txtcta_cod As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbanho As ComboBox
    Friend WithEvents txtart_cod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbBorrar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents Label7 As Label
    Friend WithEvents chkestado As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblformato As TextBox
    Friend WithEvents lbl_ctanom As TextBox
    Friend WithEvents lblnom As TextBox
End Class
