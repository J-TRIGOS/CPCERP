<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMantELTBTRANSPTRACTOR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantELTBTRANSPTRACTOR))
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.lblcho_cod = New System.Windows.Forms.Label()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.txtconfig_vehi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.txtcertificado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtobservacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.txtplaca = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblsdas = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtctct_cod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsbForm.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.General.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbBorrar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(526, 25)
        Me.tsbForm.TabIndex = 11
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(502, 378)
        Me.TabControl1.TabIndex = 12
        '
        'General
        '
        Me.General.BackColor = System.Drawing.Color.White
        Me.General.Controls.Add(Me.lblcho_cod)
        Me.General.Controls.Add(Me.lblcodigo)
        Me.General.Controls.Add(Me.txtconfig_vehi)
        Me.General.Controls.Add(Me.Label6)
        Me.General.Controls.Add(Me.cmbtipo)
        Me.General.Controls.Add(Me.txtcertificado)
        Me.General.Controls.Add(Me.Label4)
        Me.General.Controls.Add(Me.txtobservacion)
        Me.General.Controls.Add(Me.Label3)
        Me.General.Controls.Add(Me.Label2)
        Me.General.Controls.Add(Me.txtmarca)
        Me.General.Controls.Add(Me.txtplaca)
        Me.General.Controls.Add(Me.Label7)
        Me.General.Controls.Add(Me.lblsdas)
        Me.General.Controls.Add(Me.Label5)
        Me.General.Controls.Add(Me.txtctct_cod)
        Me.General.Controls.Add(Me.Label1)
        Me.General.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(494, 352)
        Me.General.TabIndex = 0
        Me.General.Text = "GENERAL"
        '
        'lblcho_cod
        '
        Me.lblcho_cod.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcho_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcho_cod.Location = New System.Drawing.Point(122, 72)
        Me.lblcho_cod.Name = "lblcho_cod"
        Me.lblcho_cod.Size = New System.Drawing.Size(53, 21)
        Me.lblcho_cod.TabIndex = 42
        Me.lblcho_cod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcodigo
        '
        Me.lblcodigo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodigo.Location = New System.Drawing.Point(176, 36)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(270, 21)
        Me.lblcodigo.TabIndex = 41
        Me.lblcodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtconfig_vehi
        '
        Me.txtconfig_vehi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtconfig_vehi.Location = New System.Drawing.Point(125, 256)
        Me.txtconfig_vehi.MaxLength = 10
        Me.txtconfig_vehi.Name = "txtconfig_vehi"
        Me.txtconfig_vehi.Size = New System.Drawing.Size(85, 21)
        Me.txtconfig_vehi.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 23)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Configuracion"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbtipo
        '
        Me.cmbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"CAMION", "TRACTO"})
        Me.cmbtipo.Location = New System.Drawing.Point(125, 291)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(85, 21)
        Me.cmbtipo.TabIndex = 26
        '
        'txtcertificado
        '
        Me.txtcertificado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcertificado.Location = New System.Drawing.Point(123, 221)
        Me.txtcertificado.MaxLength = 50
        Me.txtcertificado.Name = "txtcertificado"
        Me.txtcertificado.Size = New System.Drawing.Size(153, 21)
        Me.txtcertificado.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Certificado"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtobservacion
        '
        Me.txtobservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobservacion.Location = New System.Drawing.Point(123, 186)
        Me.txtobservacion.MaxLength = 100
        Me.txtobservacion.Name = "txtobservacion"
        Me.txtobservacion.Size = New System.Drawing.Size(292, 21)
        Me.txtobservacion.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Observación"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Transportista"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtmarca
        '
        Me.txtmarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmarca.Location = New System.Drawing.Point(123, 148)
        Me.txtmarca.MaxLength = 100
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(292, 21)
        Me.txtmarca.TabIndex = 3
        '
        'txtplaca
        '
        Me.txtplaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtplaca.Location = New System.Drawing.Point(123, 109)
        Me.txtplaca.MaxLength = 30
        Me.txtplaca.Name = "txtplaca"
        Me.txtplaca.Size = New System.Drawing.Size(106, 21)
        Me.txtplaca.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 23)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Placa"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblsdas
        '
        Me.lblsdas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsdas.Location = New System.Drawing.Point(32, 148)
        Me.lblsdas.Name = "lblsdas"
        Me.lblsdas.Size = New System.Drawing.Size(59, 23)
        Me.lblsdas.TabIndex = 17
        Me.lblsdas.Text = "Marca"
        Me.lblsdas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 23)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Tipo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtctct_cod
        '
        Me.txtctct_cod.Location = New System.Drawing.Point(122, 36)
        Me.txtctct_cod.MaxLength = 3
        Me.txtctct_cod.Name = "txtctct_cod"
        Me.txtctct_cod.Size = New System.Drawing.Size(53, 21)
        Me.txtctct_cod.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormMantELTBTRANSPTRACTOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 420)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.tsbForm)
        Me.Name = "FormMantELTBTRANSPTRACTOR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tractor Transportista"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.General.ResumeLayout(False)
        Me.General.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbBorrar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents General As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmarca As TextBox
    Friend WithEvents txtplaca As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblsdas As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtctct_cod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcertificado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtobservacion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbtipo As ComboBox
    Friend WithEvents txtconfig_vehi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblcodigo As Label
    Friend WithEvents lblcho_cod As Label
End Class
