<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormELLIQUIDACION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormELLIQUIDACION))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.cmb_mes = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblprdo = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtprdo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtdias = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtsubsidio = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtcomision = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtmeses = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txthextras = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtgrati = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtvacaciones = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtinteres = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcts = New System.Windows.Forms.TextBox()
        Me.lblper_cod = New System.Windows.Forms.Label()
        Me.txtper_cod = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_año = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.TabControl1.Location = New System.Drawing.Point(12, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(723, 378)
        Me.TabControl1.TabIndex = 21
        '
        'General
        '
        Me.General.BackColor = System.Drawing.Color.White
        Me.General.Controls.Add(Me.cmb_mes)
        Me.General.Controls.Add(Me.Label16)
        Me.General.Controls.Add(Me.lblprdo)
        Me.General.Controls.Add(Me.Label10)
        Me.General.Controls.Add(Me.txtprdo)
        Me.General.Controls.Add(Me.Label12)
        Me.General.Controls.Add(Me.txtdias)
        Me.General.Controls.Add(Me.Label13)
        Me.General.Controls.Add(Me.txtsubsidio)
        Me.General.Controls.Add(Me.Label14)
        Me.General.Controls.Add(Me.txtcomision)
        Me.General.Controls.Add(Me.Label15)
        Me.General.Controls.Add(Me.txtmeses)
        Me.General.Controls.Add(Me.Label9)
        Me.General.Controls.Add(Me.txthextras)
        Me.General.Controls.Add(Me.Label8)
        Me.General.Controls.Add(Me.txtgrati)
        Me.General.Controls.Add(Me.Label7)
        Me.General.Controls.Add(Me.txtvacaciones)
        Me.General.Controls.Add(Me.Label5)
        Me.General.Controls.Add(Me.txtinteres)
        Me.General.Controls.Add(Me.Label2)
        Me.General.Controls.Add(Me.txtmonto)
        Me.General.Controls.Add(Me.Label4)
        Me.General.Controls.Add(Me.txtcts)
        Me.General.Controls.Add(Me.lblper_cod)
        Me.General.Controls.Add(Me.txtper_cod)
        Me.General.Controls.Add(Me.Label3)
        Me.General.Controls.Add(Me.cmb_año)
        Me.General.Controls.Add(Me.Label6)
        Me.General.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(715, 352)
        Me.General.TabIndex = 0
        Me.General.Text = "GENERAL"
        '
        'cmb_mes
        '
        Me.cmb_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mes.FormattingEnabled = True
        Me.cmb_mes.Items.AddRange(New Object() {"01 - ENERO", "02 - FEBRERO", "03 - MARZO", "04 - ABRIL", "05 - MAYO", "06 - JUNIO", "07 - JULIO", "08 - AGOSTO", "09 - SETIEMBRE", "10 - OCTUBRE", "11 - NOVIEMBRE", "12 - DICIEMBRE"})
        Me.cmb_mes.Location = New System.Drawing.Point(88, 88)
        Me.cmb_mes.Name = "cmb_mes"
        Me.cmb_mes.Size = New System.Drawing.Size(145, 21)
        Me.cmb_mes.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 92)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 13)
        Me.Label16.TabIndex = 158
        Me.Label16.Text = "Mes"
        '
        'lblprdo
        '
        Me.lblprdo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblprdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblprdo.Location = New System.Drawing.Point(414, 252)
        Me.lblprdo.Name = "lblprdo"
        Me.lblprdo.Size = New System.Drawing.Size(157, 21)
        Me.lblprdo.TabIndex = 156
        Me.lblprdo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(284, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 155
        Me.Label10.Text = "Per. Pago"
        '
        'txtprdo
        '
        Me.txtprdo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtprdo.Location = New System.Drawing.Point(355, 252)
        Me.txtprdo.MaxLength = 4
        Me.txtprdo.Name = "txtprdo"
        Me.txtprdo.Size = New System.Drawing.Size(58, 21)
        Me.txtprdo.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(283, 224)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 13)
        Me.Label12.TabIndex = 151
        Me.Label12.Text = "Dias"
        '
        'txtdias
        '
        Me.txtdias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdias.Location = New System.Drawing.Point(355, 218)
        Me.txtdias.MaxLength = 2
        Me.txtdias.Name = "txtdias"
        Me.txtdias.Size = New System.Drawing.Size(95, 21)
        Me.txtdias.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(281, 158)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 149
        Me.Label13.Text = "Subsidio"
        '
        'txtsubsidio
        '
        Me.txtsubsidio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsubsidio.Location = New System.Drawing.Point(355, 154)
        Me.txtsubsidio.MaxLength = 10
        Me.txtsubsidio.Name = "txtsubsidio"
        Me.txtsubsidio.Size = New System.Drawing.Size(95, 21)
        Me.txtsubsidio.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(281, 126)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 147
        Me.Label14.Text = "Comisión"
        '
        'txtcomision
        '
        Me.txtcomision.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcomision.Location = New System.Drawing.Point(355, 122)
        Me.txtcomision.MaxLength = 10
        Me.txtcomision.Name = "txtcomision"
        Me.txtcomision.Size = New System.Drawing.Size(95, 21)
        Me.txtcomision.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(284, 191)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 13)
        Me.Label15.TabIndex = 145
        Me.Label15.Text = "Meses"
        '
        'txtmeses
        '
        Me.txtmeses.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmeses.Location = New System.Drawing.Point(355, 185)
        Me.txtmeses.MaxLength = 2
        Me.txtmeses.Name = "txtmeses"
        Me.txtmeses.Size = New System.Drawing.Size(95, 21)
        Me.txtmeses.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 288)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 143
        Me.Label9.Text = "H. Extras"
        '
        'txthextras
        '
        Me.txthextras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txthextras.Location = New System.Drawing.Point(87, 285)
        Me.txthextras.MaxLength = 10
        Me.txthextras.Name = "txthextras"
        Me.txthextras.Size = New System.Drawing.Size(95, 21)
        Me.txthextras.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 141
        Me.Label8.Text = "Gratificacion"
        '
        'txtgrati
        '
        Me.txtgrati.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtgrati.Location = New System.Drawing.Point(88, 252)
        Me.txtgrati.MaxLength = 10
        Me.txtgrati.Name = "txtgrati"
        Me.txtgrati.Size = New System.Drawing.Size(95, 21)
        Me.txtgrati.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 139
        Me.Label7.Text = "Vacaciones"
        '
        'txtvacaciones
        '
        Me.txtvacaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtvacaciones.Location = New System.Drawing.Point(88, 217)
        Me.txtvacaciones.MaxLength = 10
        Me.txtvacaciones.Name = "txtvacaciones"
        Me.txtvacaciones.Size = New System.Drawing.Size(95, 21)
        Me.txtvacaciones.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "Interes"
        '
        'txtinteres
        '
        Me.txtinteres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtinteres.Location = New System.Drawing.Point(88, 153)
        Me.txtinteres.MaxLength = 10
        Me.txtinteres.Name = "txtinteres"
        Me.txtinteres.Size = New System.Drawing.Size(95, 21)
        Me.txtinteres.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 135
        Me.Label2.Text = "Devengue"
        '
        'txtmonto
        '
        Me.txtmonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmonto.Location = New System.Drawing.Point(88, 121)
        Me.txtmonto.MaxLength = 10
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(95, 21)
        Me.txtmonto.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Cts"
        '
        'txtcts
        '
        Me.txtcts.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcts.Location = New System.Drawing.Point(88, 184)
        Me.txtcts.MaxLength = 10
        Me.txtcts.Name = "txtcts"
        Me.txtcts.Size = New System.Drawing.Size(95, 21)
        Me.txtcts.TabIndex = 6
        '
        'lblper_cod
        '
        Me.lblper_cod.BackColor = System.Drawing.Color.Gainsboro
        Me.lblper_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblper_cod.Location = New System.Drawing.Point(184, 25)
        Me.lblper_cod.Name = "lblper_cod"
        Me.lblper_cod.Size = New System.Drawing.Size(387, 21)
        Me.lblper_cod.TabIndex = 129
        Me.lblper_cod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtper_cod
        '
        Me.txtper_cod.Location = New System.Drawing.Point(88, 25)
        Me.txtper_cod.MaxLength = 8
        Me.txtper_cod.Name = "txtper_cod"
        Me.txtper_cod.Size = New System.Drawing.Size(95, 21)
        Me.txtper_cod.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "Personal"
        '
        'cmb_año
        '
        Me.cmb_año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_año.FormattingEnabled = True
        Me.cmb_año.Items.AddRange(New Object() {"2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028"})
        Me.cmb_año.Location = New System.Drawing.Point(88, 57)
        Me.cmb_año.Name = "cmb_año"
        Me.cmb_año.Size = New System.Drawing.Size(73, 21)
        Me.cmb_año.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Año"
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbBorrar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(747, 25)
        Me.tsbForm.TabIndex = 22
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
        'FormELLIQUIDACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 420)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormELLIQUIDACION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CTServicio - Liquidaciones"
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
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcts As TextBox
    Friend WithEvents lblper_cod As Label
    Friend WithEvents txtper_cod As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_año As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbBorrar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtinteres As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmonto As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txthextras As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtgrati As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtvacaciones As TextBox
    Friend WithEvents lblprdo As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtprdo As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtdias As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtsubsidio As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtcomision As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtmeses As TextBox
    Friend WithEvents cmb_mes As ComboBox
    Friend WithEvents Label16 As Label
End Class
