<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormELVACACIONES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormELVACACIONES))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.chkactivar2 = New System.Windows.Forms.CheckBox()
        Me.chkactivar = New System.Windows.Forms.CheckBox()
        Me.txtobservacion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblsusp_cod = New System.Windows.Forms.Label()
        Me.txtsusp_cod = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpgose_fin = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpgose_ini = New System.Windows.Forms.DateTimePicker()
        Me.txtdias = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblprdo_cod = New System.Windows.Forms.Label()
        Me.txtprdo_cod = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpvaca_fin = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpvaca_ini = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblfecha_ing = New System.Windows.Forms.Label()
        Me.lblper_cod = New System.Windows.Forms.Label()
        Me.txtper_cod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1.SuspendLayout()
        Me.General.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tsbForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(11, 38)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(723, 378)
        Me.TabControl1.TabIndex = 18
        '
        'General
        '
        Me.General.BackColor = System.Drawing.Color.White
        Me.General.Controls.Add(Me.chkactivar2)
        Me.General.Controls.Add(Me.chkactivar)
        Me.General.Controls.Add(Me.txtobservacion)
        Me.General.Controls.Add(Me.Label12)
        Me.General.Controls.Add(Me.lblsusp_cod)
        Me.General.Controls.Add(Me.txtsusp_cod)
        Me.General.Controls.Add(Me.Label11)
        Me.General.Controls.Add(Me.GroupBox2)
        Me.General.Controls.Add(Me.txtdias)
        Me.General.Controls.Add(Me.Label7)
        Me.General.Controls.Add(Me.lblprdo_cod)
        Me.General.Controls.Add(Me.txtprdo_cod)
        Me.General.Controls.Add(Me.GroupBox1)
        Me.General.Controls.Add(Me.Label6)
        Me.General.Controls.Add(Me.lblfecha_ing)
        Me.General.Controls.Add(Me.lblper_cod)
        Me.General.Controls.Add(Me.txtper_cod)
        Me.General.Controls.Add(Me.Label1)
        Me.General.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(715, 352)
        Me.General.TabIndex = 0
        Me.General.Text = "GENERAL"
        '
        'chkactivar2
        '
        Me.chkactivar2.AutoSize = True
        Me.chkactivar2.Location = New System.Drawing.Point(17, 301)
        Me.chkactivar2.Name = "chkactivar2"
        Me.chkactivar2.Size = New System.Drawing.Size(60, 17)
        Me.chkactivar2.TabIndex = 57
        Me.chkactivar2.Text = "Activar"
        Me.chkactivar2.UseVisualStyleBackColor = True
        '
        'chkactivar
        '
        Me.chkactivar.AutoSize = True
        Me.chkactivar.Location = New System.Drawing.Point(17, 235)
        Me.chkactivar.Name = "chkactivar"
        Me.chkactivar.Size = New System.Drawing.Size(60, 17)
        Me.chkactivar.TabIndex = 56
        Me.chkactivar.Text = "Activar"
        Me.chkactivar.UseVisualStyleBackColor = True
        '
        'txtobservacion
        '
        Me.txtobservacion.Location = New System.Drawing.Point(98, 150)
        Me.txtobservacion.MaxLength = 100
        Me.txtobservacion.Multiline = True
        Me.txtobservacion.Name = "txtobservacion"
        Me.txtobservacion.Size = New System.Drawing.Size(499, 45)
        Me.txtobservacion.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 156)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Observaciones"
        '
        'lblsusp_cod
        '
        Me.lblsusp_cod.BackColor = System.Drawing.Color.Gainsboro
        Me.lblsusp_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblsusp_cod.Location = New System.Drawing.Point(154, 117)
        Me.lblsusp_cod.Name = "lblsusp_cod"
        Me.lblsusp_cod.Size = New System.Drawing.Size(197, 21)
        Me.lblsusp_cod.TabIndex = 54
        Me.lblsusp_cod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtsusp_cod
        '
        Me.txtsusp_cod.Location = New System.Drawing.Point(98, 117)
        Me.txtsusp_cod.MaxLength = 2
        Me.txtsusp_cod.Name = "txtsusp_cod"
        Me.txtsusp_cod.Size = New System.Drawing.Size(55, 21)
        Me.txtsusp_cod.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Tipo Suspensión"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.dtpgose_fin)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.dtpgose_ini)
        Me.GroupBox2.Location = New System.Drawing.Point(98, 278)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 45)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Periodo Gose"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(171, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Fin"
        '
        'dtpgose_fin
        '
        Me.dtpgose_fin.Checked = False
        Me.dtpgose_fin.CustomFormat = ""
        Me.dtpgose_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpgose_fin.Location = New System.Drawing.Point(198, 18)
        Me.dtpgose_fin.Name = "dtpgose_fin"
        Me.dtpgose_fin.Size = New System.Drawing.Size(95, 21)
        Me.dtpgose_fin.TabIndex = 9
        Me.dtpgose_fin.Value = New Date(2018, 12, 17, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Inicio"
        '
        'dtpgose_ini
        '
        Me.dtpgose_ini.Checked = False
        Me.dtpgose_ini.CustomFormat = ""
        Me.dtpgose_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpgose_ini.Location = New System.Drawing.Point(44, 19)
        Me.dtpgose_ini.Name = "dtpgose_ini"
        Me.dtpgose_ini.Size = New System.Drawing.Size(95, 21)
        Me.dtpgose_ini.TabIndex = 8
        Me.dtpgose_ini.Value = New Date(2018, 12, 17, 0, 0, 0, 0)
        '
        'txtdias
        '
        Me.txtdias.Location = New System.Drawing.Point(98, 86)
        Me.txtdias.MaxLength = 4
        Me.txtdias.Name = "txtdias"
        Me.txtdias.Size = New System.Drawing.Size(55, 21)
        Me.txtdias.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Dias"
        '
        'lblprdo_cod
        '
        Me.lblprdo_cod.BackColor = System.Drawing.Color.Gainsboro
        Me.lblprdo_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblprdo_cod.Location = New System.Drawing.Point(154, 55)
        Me.lblprdo_cod.Name = "lblprdo_cod"
        Me.lblprdo_cod.Size = New System.Drawing.Size(197, 21)
        Me.lblprdo_cod.TabIndex = 49
        Me.lblprdo_cod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtprdo_cod
        '
        Me.txtprdo_cod.Location = New System.Drawing.Point(98, 55)
        Me.txtprdo_cod.MaxLength = 3
        Me.txtprdo_cod.Name = "txtprdo_cod"
        Me.txtprdo_cod.Size = New System.Drawing.Size(55, 21)
        Me.txtprdo_cod.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpvaca_fin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpvaca_ini)
        Me.GroupBox1.Location = New System.Drawing.Point(98, 213)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 45)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Periodo Vacacional"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(171, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Fin"
        '
        'dtpvaca_fin
        '
        Me.dtpvaca_fin.Checked = False
        Me.dtpvaca_fin.CustomFormat = ""
        Me.dtpvaca_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpvaca_fin.Location = New System.Drawing.Point(198, 18)
        Me.dtpvaca_fin.Name = "dtpvaca_fin"
        Me.dtpvaca_fin.Size = New System.Drawing.Size(95, 21)
        Me.dtpvaca_fin.TabIndex = 7
        Me.dtpvaca_fin.Value = New Date(2018, 12, 17, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Inicio"
        '
        'dtpvaca_ini
        '
        Me.dtpvaca_ini.Checked = False
        Me.dtpvaca_ini.CustomFormat = ""
        Me.dtpvaca_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpvaca_ini.Location = New System.Drawing.Point(44, 19)
        Me.dtpvaca_ini.Name = "dtpvaca_ini"
        Me.dtpvaca_ini.Size = New System.Drawing.Size(95, 21)
        Me.dtpvaca_ini.TabIndex = 6
        Me.dtpvaca_ini.Value = New Date(2018, 12, 17, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Periódo Pago"
        '
        'lblfecha_ing
        '
        Me.lblfecha_ing.BackColor = System.Drawing.Color.Gainsboro
        Me.lblfecha_ing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblfecha_ing.Location = New System.Drawing.Point(503, 24)
        Me.lblfecha_ing.Name = "lblfecha_ing"
        Me.lblfecha_ing.Size = New System.Drawing.Size(94, 21)
        Me.lblfecha_ing.TabIndex = 44
        Me.lblfecha_ing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblper_cod
        '
        Me.lblper_cod.BackColor = System.Drawing.Color.Gainsboro
        Me.lblper_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblper_cod.Location = New System.Drawing.Point(194, 24)
        Me.lblper_cod.Name = "lblper_cod"
        Me.lblper_cod.Size = New System.Drawing.Size(308, 21)
        Me.lblper_cod.TabIndex = 43
        Me.lblper_cod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtper_cod
        '
        Me.txtper_cod.Location = New System.Drawing.Point(98, 24)
        Me.txtper_cod.MaxLength = 8
        Me.txtper_cod.Name = "txtper_cod"
        Me.txtper_cod.Size = New System.Drawing.Size(95, 21)
        Me.txtper_cod.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Personal"
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbBorrar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(747, 25)
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
        'FormELVACACIONES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 420)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormELVACACIONES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vacaciones del Personal"
        Me.TabControl1.ResumeLayout(False)
        Me.General.ResumeLayout(False)
        Me.General.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents General As TabPage
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbBorrar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents lblper_cod As Label
    Friend WithEvents txtper_cod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblfecha_ing As Label
    Friend WithEvents txtobservacion As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lblsusp_cod As Label
    Friend WithEvents txtsusp_cod As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpgose_fin As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpgose_ini As DateTimePicker
    Friend WithEvents txtdias As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblprdo_cod As Label
    Friend WithEvents txtprdo_cod As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpvaca_fin As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpvaca_ini As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents chkactivar As CheckBox
    Friend WithEvents chkactivar2 As CheckBox
End Class
