<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormELTBCUENTA_OPE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormELTBCUENTA_OPE))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblcodiniletraD = New System.Windows.Forms.Label()
        Me.lblcodiniletraS = New System.Windows.Forms.Label()
        Me.lblcodiniD = New System.Windows.Forms.Label()
        Me.lblcodiniS = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcodiniletraD = New System.Windows.Forms.TextBox()
        Me.cmbsigno = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcodiniletraS = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcodiniD = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcodiniS = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcodimpto = New System.Windows.Forms.TextBox()
        Me.cmb_codimpto = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkinafecto = New System.Windows.Forms.CheckBox()
        Me.chkafecto = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_t_doc_cod = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_tipope = New System.Windows.Forms.TextBox()
        Me.cmb_tipope = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.TabControl1.SuspendLayout()
        Me.General.SuspendLayout()
        Me.tsbForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(9, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(507, 378)
        Me.TabControl1.TabIndex = 26
        '
        'General
        '
        Me.General.BackColor = System.Drawing.Color.White
        Me.General.Controls.Add(Me.cmbaño)
        Me.General.Controls.Add(Me.Label10)
        Me.General.Controls.Add(Me.lblcodiniletraD)
        Me.General.Controls.Add(Me.lblcodiniletraS)
        Me.General.Controls.Add(Me.lblcodiniD)
        Me.General.Controls.Add(Me.lblcodiniS)
        Me.General.Controls.Add(Me.Label9)
        Me.General.Controls.Add(Me.txtcodiniletraD)
        Me.General.Controls.Add(Me.cmbsigno)
        Me.General.Controls.Add(Me.Label8)
        Me.General.Controls.Add(Me.txtcodiniletraS)
        Me.General.Controls.Add(Me.Label7)
        Me.General.Controls.Add(Me.txtcodiniD)
        Me.General.Controls.Add(Me.Label5)
        Me.General.Controls.Add(Me.txtcodiniS)
        Me.General.Controls.Add(Me.Label4)
        Me.General.Controls.Add(Me.txtcodimpto)
        Me.General.Controls.Add(Me.cmb_codimpto)
        Me.General.Controls.Add(Me.Label3)
        Me.General.Controls.Add(Me.chkinafecto)
        Me.General.Controls.Add(Me.chkafecto)
        Me.General.Controls.Add(Me.Label2)
        Me.General.Controls.Add(Me.cmb_t_doc_cod)
        Me.General.Controls.Add(Me.Label6)
        Me.General.Controls.Add(Me.txt_tipope)
        Me.General.Controls.Add(Me.cmb_tipope)
        Me.General.Controls.Add(Me.Label1)
        Me.General.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(499, 352)
        Me.General.TabIndex = 0
        Me.General.Text = "GENERAL"
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028"})
        Me.cmbaño.Location = New System.Drawing.Point(125, 19)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(66, 21)
        Me.cmbaño.TabIndex = 117
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 23)
        Me.Label10.TabIndex = 116
        Me.Label10.Text = "Año"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcodiniletraD
        '
        Me.lblcodiniletraD.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcodiniletraD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodiniletraD.Location = New System.Drawing.Point(208, 262)
        Me.lblcodiniletraD.Name = "lblcodiniletraD"
        Me.lblcodiniletraD.Size = New System.Drawing.Size(235, 21)
        Me.lblcodiniletraD.TabIndex = 115
        Me.lblcodiniletraD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcodiniletraS
        '
        Me.lblcodiniletraS.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcodiniletraS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodiniletraS.Location = New System.Drawing.Point(208, 231)
        Me.lblcodiniletraS.Name = "lblcodiniletraS"
        Me.lblcodiniletraS.Size = New System.Drawing.Size(235, 21)
        Me.lblcodiniletraS.TabIndex = 114
        Me.lblcodiniletraS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcodiniD
        '
        Me.lblcodiniD.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcodiniD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodiniD.Location = New System.Drawing.Point(208, 200)
        Me.lblcodiniD.Name = "lblcodiniD"
        Me.lblcodiniD.Size = New System.Drawing.Size(235, 21)
        Me.lblcodiniD.TabIndex = 113
        Me.lblcodiniD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcodiniS
        '
        Me.lblcodiniS.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcodiniS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodiniS.Location = New System.Drawing.Point(208, 170)
        Me.lblcodiniS.Name = "lblcodiniS"
        Me.lblcodiniS.Size = New System.Drawing.Size(235, 21)
        Me.lblcodiniS.TabIndex = 112
        Me.lblcodiniS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 23)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "Cta Inicial Letra $"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcodiniletraD
        '
        Me.txtcodiniletraD.Location = New System.Drawing.Point(125, 262)
        Me.txtcodiniletraD.MaxLength = 15
        Me.txtcodiniletraD.Name = "txtcodiniletraD"
        Me.txtcodiniletraD.Size = New System.Drawing.Size(82, 21)
        Me.txtcodiniletraD.TabIndex = 110
        Me.txtcodiniletraD.Tag = "4"
        '
        'cmbsigno
        '
        Me.cmbsigno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsigno.FormattingEnabled = True
        Me.cmbsigno.Items.AddRange(New Object() {"+", "-"})
        Me.cmbsigno.Location = New System.Drawing.Point(125, 293)
        Me.cmbsigno.Name = "cmbsigno"
        Me.cmbsigno.Size = New System.Drawing.Size(66, 21)
        Me.cmbsigno.TabIndex = 108
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 290)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 23)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "Signo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcodiniletraS
        '
        Me.txtcodiniletraS.Location = New System.Drawing.Point(125, 231)
        Me.txtcodiniletraS.MaxLength = 15
        Me.txtcodiniletraS.Name = "txtcodiniletraS"
        Me.txtcodiniletraS.Size = New System.Drawing.Size(82, 21)
        Me.txtcodiniletraS.TabIndex = 106
        Me.txtcodiniletraS.Tag = "3"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 23)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Cta Inicial Letra S/"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcodiniD
        '
        Me.txtcodiniD.Location = New System.Drawing.Point(125, 200)
        Me.txtcodiniD.MaxLength = 15
        Me.txtcodiniD.Name = "txtcodiniD"
        Me.txtcodiniD.Size = New System.Drawing.Size(82, 21)
        Me.txtcodiniD.TabIndex = 104
        Me.txtcodiniD.Tag = "2"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 23)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Cta Inicial $"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcodiniS
        '
        Me.txtcodiniS.Location = New System.Drawing.Point(125, 170)
        Me.txtcodiniS.MaxLength = 15
        Me.txtcodiniS.Name = "txtcodiniS"
        Me.txtcodiniS.Size = New System.Drawing.Size(82, 21)
        Me.txtcodiniS.TabIndex = 102
        Me.txtcodiniS.Tag = "1"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 23)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Cta Inicial S/."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcodimpto
        '
        Me.txtcodimpto.Location = New System.Drawing.Point(125, 137)
        Me.txtcodimpto.MaxLength = 2
        Me.txtcodimpto.Name = "txtcodimpto"
        Me.txtcodimpto.Size = New System.Drawing.Size(45, 21)
        Me.txtcodimpto.TabIndex = 100
        '
        'cmb_codimpto
        '
        Me.cmb_codimpto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_codimpto.FormattingEnabled = True
        Me.cmb_codimpto.Location = New System.Drawing.Point(171, 137)
        Me.cmb_codimpto.Name = "cmb_codimpto"
        Me.cmb_codimpto.Size = New System.Drawing.Size(212, 21)
        Me.cmb_codimpto.TabIndex = 98
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 23)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Cod Importe"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkinafecto
        '
        Me.chkinafecto.AutoSize = True
        Me.chkinafecto.Location = New System.Drawing.Point(200, 113)
        Me.chkinafecto.Name = "chkinafecto"
        Me.chkinafecto.Size = New System.Drawing.Size(77, 17)
        Me.chkinafecto.TabIndex = 97
        Me.chkinafecto.Text = "INAFECTO"
        Me.chkinafecto.UseVisualStyleBackColor = True
        '
        'chkafecto
        '
        Me.chkafecto.AutoSize = True
        Me.chkafecto.Location = New System.Drawing.Point(125, 113)
        Me.chkafecto.Name = "chkafecto"
        Me.chkafecto.Size = New System.Drawing.Size(66, 17)
        Me.chkafecto.TabIndex = 96
        Me.chkafecto.Text = "AFECTO"
        Me.chkafecto.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Status"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_t_doc_cod
        '
        Me.cmb_t_doc_cod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_t_doc_cod.FormattingEnabled = True
        Me.cmb_t_doc_cod.Location = New System.Drawing.Point(125, 82)
        Me.cmb_t_doc_cod.Name = "cmb_t_doc_cod"
        Me.cmb_t_doc_cod.Size = New System.Drawing.Size(145, 21)
        Me.cmb_t_doc_cod.TabIndex = 94
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 23)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "T. Documento"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_tipope
        '
        Me.txt_tipope.Location = New System.Drawing.Point(125, 51)
        Me.txt_tipope.MaxLength = 3
        Me.txt_tipope.Name = "txt_tipope"
        Me.txt_tipope.Size = New System.Drawing.Size(45, 21)
        Me.txt_tipope.TabIndex = 92
        '
        'cmb_tipope
        '
        Me.cmb_tipope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipope.FormattingEnabled = True
        Me.cmb_tipope.Location = New System.Drawing.Point(171, 51)
        Me.cmb_tipope.Name = "cmb_tipope"
        Me.cmb_tipope.Size = New System.Drawing.Size(212, 21)
        Me.cmb_tipope.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 23)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "T. Operacion"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbBorrar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(551, 25)
        Me.tsbForm.TabIndex = 27
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
        'FormELTBCUENTA_OPE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 420)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormELTBCUENTA_OPE"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas Prefijadas por Tipo Operaciones"
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
    Friend WithEvents txt_tipope As TextBox
    Friend WithEvents cmb_tipope As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbBorrar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents cmb_t_doc_cod As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbsigno As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcodiniletraS As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcodiniD As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcodiniS As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcodimpto As TextBox
    Friend WithEvents cmb_codimpto As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkinafecto As CheckBox
    Friend WithEvents chkafecto As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcodiniletraD As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblcodiniletraD As Label
    Friend WithEvents lblcodiniletraS As Label
    Friend WithEvents lblcodiniD As Label
    Friend WithEvents lblcodiniS As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents cmbaño As ComboBox
    Friend WithEvents Label10 As Label
End Class
