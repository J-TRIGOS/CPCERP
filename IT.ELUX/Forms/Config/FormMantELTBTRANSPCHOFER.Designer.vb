<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMantELTBTRANSPCHOFER
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantELTBTRANSPCHOFER))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.lbltransp = New System.Windows.Forms.TabPage()
        Me.lblcho_cod = New System.Windows.Forms.Label()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtobserva = New System.Windows.Forms.TextBox()
        Me.txtbrevete = New System.Windows.Forms.TextBox()
        Me.txtchofer = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtctct_cod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1.SuspendLayout()
        Me.lbltransp.SuspendLayout()
        Me.tsbForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.lbltransp)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(497, 284)
        Me.TabControl1.TabIndex = 9
        '
        'lbltransp
        '
        Me.lbltransp.BackColor = System.Drawing.Color.White
        Me.lbltransp.Controls.Add(Me.lblcho_cod)
        Me.lbltransp.Controls.Add(Me.lblcodigo)
        Me.lbltransp.Controls.Add(Me.Label2)
        Me.lbltransp.Controls.Add(Me.txtobserva)
        Me.lbltransp.Controls.Add(Me.txtbrevete)
        Me.lbltransp.Controls.Add(Me.txtchofer)
        Me.lbltransp.Controls.Add(Me.Label7)
        Me.lbltransp.Controls.Add(Me.Label6)
        Me.lbltransp.Controls.Add(Me.Label5)
        Me.lbltransp.Controls.Add(Me.txtctct_cod)
        Me.lbltransp.Controls.Add(Me.Label1)
        Me.lbltransp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltransp.Location = New System.Drawing.Point(4, 22)
        Me.lbltransp.Name = "lbltransp"
        Me.lbltransp.Padding = New System.Windows.Forms.Padding(3)
        Me.lbltransp.Size = New System.Drawing.Size(489, 258)
        Me.lbltransp.TabIndex = 0
        Me.lbltransp.Text = "GENERAL"
        '
        'lblcho_cod
        '
        Me.lblcho_cod.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcho_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcho_cod.Location = New System.Drawing.Point(122, 84)
        Me.lblcho_cod.Name = "lblcho_cod"
        Me.lblcho_cod.Size = New System.Drawing.Size(53, 21)
        Me.lblcho_cod.TabIndex = 41
        Me.lblcho_cod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcodigo
        '
        Me.lblcodigo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodigo.Location = New System.Drawing.Point(176, 53)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(270, 21)
        Me.lblcodigo.TabIndex = 40
        Me.lblcodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Transportista"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtobserva
        '
        Me.txtobserva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobserva.Location = New System.Drawing.Point(122, 190)
        Me.txtobserva.MaxLength = 100
        Me.txtobserva.Name = "txtobserva"
        Me.txtobserva.Size = New System.Drawing.Size(305, 21)
        Me.txtobserva.TabIndex = 4
        '
        'txtbrevete
        '
        Me.txtbrevete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbrevete.Location = New System.Drawing.Point(122, 155)
        Me.txtbrevete.MaxLength = 30
        Me.txtbrevete.Name = "txtbrevete"
        Me.txtbrevete.Size = New System.Drawing.Size(157, 21)
        Me.txtbrevete.TabIndex = 3
        '
        'txtchofer
        '
        Me.txtchofer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtchofer.Location = New System.Drawing.Point(122, 118)
        Me.txtchofer.MaxLength = 100
        Me.txtchofer.Name = "txtchofer"
        Me.txtchofer.Size = New System.Drawing.Size(324, 21)
        Me.txtchofer.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 23)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Chofer"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 23)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Brevete"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 23)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Observación"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtctct_cod
        '
        Me.txtctct_cod.Location = New System.Drawing.Point(122, 53)
        Me.txtctct_cod.MaxLength = 3
        Me.txtctct_cod.Name = "txtctct_cod"
        Me.txtctct_cod.Size = New System.Drawing.Size(53, 21)
        Me.txtctct_cod.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbBorrar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(532, 25)
        Me.tsbForm.TabIndex = 10
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
        'FormMantELTBTRANSPCHOFER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 348)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormMantELTBTRANSPCHOFER"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chofer del Transportista"
        Me.TabControl1.ResumeLayout(False)
        Me.lbltransp.ResumeLayout(False)
        Me.lbltransp.PerformLayout()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents lbltransp As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtctct_cod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbBorrar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtobserva As TextBox
    Friend WithEvents txtbrevete As TextBox
    Friend WithEvents txtchofer As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblcodigo As Label
    Friend WithEvents lblcho_cod As Label
End Class
