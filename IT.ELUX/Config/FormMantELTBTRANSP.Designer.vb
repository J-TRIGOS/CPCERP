<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMantELTBTRANSP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantELTBTRANSP))
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.txtctct = New System.Windows.Forms.TextBox()
        Me.txtvehi = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.txtcertificado = New System.Windows.Forms.TextBox()
        Me.txttelf = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbrevete = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtruc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtplaca = New System.Windows.Forms.TextBox()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.txtdir = New System.Windows.Forms.TextBox()
        Me.g = New System.Windows.Forms.Label()
        Me.cmbcodest = New System.Windows.Forms.ComboBox()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsbForm.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.General.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(747, 25)
        Me.tsbForm.TabIndex = 7
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 38)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(723, 378)
        Me.TabControl1.TabIndex = 8
        '
        'General
        '
        Me.General.BackColor = System.Drawing.Color.White
        Me.General.Controls.Add(Me.Label12)
        Me.General.Controls.Add(Me.Label11)
        Me.General.Controls.Add(Me.cmbtipo)
        Me.General.Controls.Add(Me.txtctct)
        Me.General.Controls.Add(Me.txtvehi)
        Me.General.Controls.Add(Me.Label9)
        Me.General.Controls.Add(Me.Label10)
        Me.General.Controls.Add(Me.txtmarca)
        Me.General.Controls.Add(Me.txtcertificado)
        Me.General.Controls.Add(Me.txttelf)
        Me.General.Controls.Add(Me.Label8)
        Me.General.Controls.Add(Me.txtbrevete)
        Me.General.Controls.Add(Me.Label7)
        Me.General.Controls.Add(Me.Label6)
        Me.General.Controls.Add(Me.txtruc)
        Me.General.Controls.Add(Me.Label4)
        Me.General.Controls.Add(Me.Label5)
        Me.General.Controls.Add(Me.txtplaca)
        Me.General.Controls.Add(Me.txtcod)
        Me.General.Controls.Add(Me.txtdir)
        Me.General.Controls.Add(Me.g)
        Me.General.Controls.Add(Me.cmbcodest)
        Me.General.Controls.Add(Me.txtnom)
        Me.General.Controls.Add(Me.Label3)
        Me.General.Controls.Add(Me.Label2)
        Me.General.Controls.Add(Me.Label1)
        Me.General.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(715, 352)
        Me.General.TabIndex = 0
        Me.General.Text = "GENERAL"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(403, 235)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 23)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Tipo Unidad"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 237)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 23)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Estado"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbtipo
        '
        Me.cmbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"CAMION", "TRACTO"})
        Me.cmbtipo.Location = New System.Drawing.Point(471, 237)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(90, 21)
        Me.cmbtipo.TabIndex = 12
        '
        'txtctct
        '
        Me.txtctct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtctct.Location = New System.Drawing.Point(470, 205)
        Me.txtctct.MaxLength = 20
        Me.txtctct.Name = "txtctct"
        Me.txtctct.Size = New System.Drawing.Size(176, 21)
        Me.txtctct.TabIndex = 11
        '
        'txtvehi
        '
        Me.txtvehi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtvehi.Location = New System.Drawing.Point(84, 205)
        Me.txtvehi.MaxLength = 100
        Me.txtvehi.Name = "txtvehi"
        Me.txtvehi.Size = New System.Drawing.Size(296, 21)
        Me.txtvehi.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 23)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Vehiculo"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(403, 203)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 23)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Codigo"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtmarca
        '
        Me.txtmarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmarca.Location = New System.Drawing.Point(470, 174)
        Me.txtmarca.MaxLength = 100
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(239, 21)
        Me.txtmarca.TabIndex = 10
        '
        'txtcertificado
        '
        Me.txtcertificado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcertificado.Location = New System.Drawing.Point(470, 140)
        Me.txtcertificado.MaxLength = 50
        Me.txtcertificado.Name = "txtcertificado"
        Me.txtcertificado.Size = New System.Drawing.Size(176, 21)
        Me.txtcertificado.TabIndex = 9
        '
        'txttelf
        '
        Me.txttelf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttelf.Location = New System.Drawing.Point(84, 174)
        Me.txttelf.Name = "txttelf"
        Me.txttelf.Size = New System.Drawing.Size(91, 21)
        Me.txttelf.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 23)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Telefono"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbrevete
        '
        Me.txtbrevete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbrevete.Location = New System.Drawing.Point(470, 113)
        Me.txtbrevete.MaxLength = 12
        Me.txtbrevete.Name = "txtbrevete"
        Me.txtbrevete.Size = New System.Drawing.Size(91, 21)
        Me.txtbrevete.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(403, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 23)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Brevete"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(403, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 23)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Certificado"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtruc
        '
        Me.txtruc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtruc.Location = New System.Drawing.Point(84, 143)
        Me.txtruc.MaxLength = 20
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(119, 21)
        Me.txtruc.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 23)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Ruc"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(403, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 23)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Marca"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtplaca
        '
        Me.txtplaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtplaca.Location = New System.Drawing.Point(84, 113)
        Me.txtplaca.MaxLength = 10
        Me.txtplaca.Name = "txtplaca"
        Me.txtplaca.Size = New System.Drawing.Size(91, 21)
        Me.txtplaca.TabIndex = 3
        '
        'txtcod
        '
        Me.txtcod.Location = New System.Drawing.Point(84, 24)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.ReadOnly = True
        Me.txtcod.Size = New System.Drawing.Size(91, 21)
        Me.txtcod.TabIndex = 1
        '
        'txtdir
        '
        Me.txtdir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdir.Location = New System.Drawing.Point(84, 83)
        Me.txtdir.MaxLength = 50
        Me.txtdir.Name = "txtdir"
        Me.txtdir.Size = New System.Drawing.Size(296, 21)
        Me.txtdir.TabIndex = 2
        '
        'g
        '
        Me.g.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g.Location = New System.Drawing.Point(12, 83)
        Me.g.Name = "g"
        Me.g.Size = New System.Drawing.Size(62, 23)
        Me.g.TabIndex = 9
        Me.g.Text = "Direccion"
        Me.g.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbcodest
        '
        Me.cmbcodest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcodest.FormattingEnabled = True
        Me.cmbcodest.Items.AddRange(New Object() {"ACTIVO", "INACTIVO"})
        Me.cmbcodest.Location = New System.Drawing.Point(84, 237)
        Me.cmbcodest.Name = "cmbcodest"
        Me.cmbcodest.Size = New System.Drawing.Size(91, 21)
        Me.cmbcodest.TabIndex = 7
        '
        'txtnom
        '
        Me.txtnom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnom.Location = New System.Drawing.Point(84, 53)
        Me.txtnom.MaxLength = 100
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(296, 21)
        Me.txtnom.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Placa"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombres"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormMantELTBTRANSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 420)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.tsbForm)
        Me.Name = "FormMantELTBTRANSP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transportista"
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
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents General As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents txtplaca As TextBox
    Friend WithEvents txtcod As TextBox
    Friend WithEvents txtdir As TextBox
    Friend WithEvents g As Label
    Friend WithEvents cmbcodest As ComboBox
    Friend WithEvents txtnom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcertificado As TextBox
    Friend WithEvents txttelf As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtbrevete As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtruc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbtipo As ComboBox
    Friend WithEvents txtctct As TextBox
    Friend WithEvents txtvehi As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtmarca As TextBox
End Class
