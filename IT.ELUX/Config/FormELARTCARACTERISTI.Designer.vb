<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormELARTCARACTERISTI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormELARTCARACTERISTI))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtdetalle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbaf = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcategoria = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcalidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcolor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdiametro = New System.Windows.Forms.TextBox()
        Me.txtcodart = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblart = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
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
        Me.TabControl1.Location = New System.Drawing.Point(12, 30)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(723, 252)
        Me.TabControl1.TabIndex = 20
        '
        'General
        '
        Me.General.BackColor = System.Drawing.Color.White
        Me.General.Controls.Add(Me.Label10)
        Me.General.Controls.Add(Me.txtdetalle)
        Me.General.Controls.Add(Me.Label5)
        Me.General.Controls.Add(Me.Label4)
        Me.General.Controls.Add(Me.cmbaf)
        Me.General.Controls.Add(Me.Label2)
        Me.General.Controls.Add(Me.txtcategoria)
        Me.General.Controls.Add(Me.Label3)
        Me.General.Controls.Add(Me.Label14)
        Me.General.Controls.Add(Me.Label13)
        Me.General.Controls.Add(Me.Label12)
        Me.General.Controls.Add(Me.Label11)
        Me.General.Controls.Add(Me.txtcantidad)
        Me.General.Controls.Add(Me.Label9)
        Me.General.Controls.Add(Me.txtcalidad)
        Me.General.Controls.Add(Me.Label7)
        Me.General.Controls.Add(Me.txtcolor)
        Me.General.Controls.Add(Me.Label8)
        Me.General.Controls.Add(Me.txtdiametro)
        Me.General.Controls.Add(Me.txtcodart)
        Me.General.Controls.Add(Me.Label6)
        Me.General.Controls.Add(Me.lblart)
        Me.General.Controls.Add(Me.Label1)
        Me.General.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(715, 226)
        Me.General.TabIndex = 0
        Me.General.Text = "GENERAL"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(668, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 14)
        Me.Label10.TabIndex = 143
        Me.Label10.Text = "F9"
        '
        'txtdetalle
        '
        Me.txtdetalle.Location = New System.Drawing.Point(98, 171)
        Me.txtdetalle.Name = "txtdetalle"
        Me.txtdetalle.Size = New System.Drawing.Size(223, 21)
        Me.txtdetalle.TabIndex = 142
        Me.txtdetalle.Text = "TAPA TWIST OFF"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 141
        Me.Label5.Text = "Detalle"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(411, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 140
        Me.Label4.Text = "A/F"
        '
        'cmbaf
        '
        Me.cmbaf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaf.FormattingEnabled = True
        Me.cmbaf.Items.AddRange(New Object() {"ANILLO" & Global.Microsoft.VisualBasic.ChrW(9), "FULL"})
        Me.cmbaf.Location = New System.Drawing.Point(459, 133)
        Me.cmbaf.Name = "cmbaf"
        Me.cmbaf.Size = New System.Drawing.Size(121, 21)
        Me.cmbaf.TabIndex = 139
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(231, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 14)
        Me.Label2.TabIndex = 138
        Me.Label2.Text = "F9"
        '
        'txtcategoria
        '
        Me.txtcategoria.Location = New System.Drawing.Point(98, 133)
        Me.txtcategoria.Name = "txtcategoria"
        Me.txtcategoria.Size = New System.Drawing.Size(130, 21)
        Me.txtcategoria.TabIndex = 137
        Me.txtcategoria.Tag = "cat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "Categoria"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(627, 99)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 14)
        Me.Label14.TabIndex = 135
        Me.Label14.Text = "F9"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(626, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 14)
        Me.Label13.TabIndex = 134
        Me.Label13.Text = "F9"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(231, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 14)
        Me.Label12.TabIndex = 133
        Me.Label12.Text = "F9"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(231, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 14)
        Me.Label11.TabIndex = 132
        Me.Label11.Text = "F9"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(459, 96)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(164, 21)
        Me.txtcantidad.TabIndex = 131
        Me.txtcantidad.Tag = "ca"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(389, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 130
        Me.Label9.Text = "Cantidad"
        '
        'txtcalidad
        '
        Me.txtcalidad.Location = New System.Drawing.Point(98, 96)
        Me.txtcalidad.Name = "txtcalidad"
        Me.txtcalidad.Size = New System.Drawing.Size(130, 21)
        Me.txtcalidad.TabIndex = 129
        Me.txtcalidad.Tag = "cal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "Calidad"
        '
        'txtcolor
        '
        Me.txtcolor.Location = New System.Drawing.Point(459, 60)
        Me.txtcolor.Name = "txtcolor"
        Me.txtcolor.Size = New System.Drawing.Size(164, 21)
        Me.txtcolor.TabIndex = 127
        Me.txtcolor.Tag = "co"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(403, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 126
        Me.Label8.Text = "Color"
        '
        'txtdiametro
        '
        Me.txtdiametro.Location = New System.Drawing.Point(98, 60)
        Me.txtdiametro.Name = "txtdiametro"
        Me.txtdiametro.Size = New System.Drawing.Size(130, 21)
        Me.txtdiametro.TabIndex = 125
        Me.txtdiametro.Tag = "di"
        '
        'txtcodart
        '
        Me.txtcodart.Location = New System.Drawing.Point(98, 27)
        Me.txtcodart.Name = "txtcodart"
        Me.txtcodart.Size = New System.Drawing.Size(95, 21)
        Me.txtcodart.TabIndex = 124
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Diámetro"
        '
        'lblart
        '
        Me.lblart.BackColor = System.Drawing.Color.Gainsboro
        Me.lblart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblart.Location = New System.Drawing.Point(194, 27)
        Me.lblart.Name = "lblart"
        Me.lblart.Size = New System.Drawing.Size(471, 21)
        Me.lblart.TabIndex = 44
        Me.lblart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Codigo"
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(747, 25)
        Me.tsbForm.TabIndex = 21
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
        'FormELARTCARACTERISTI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 295)
        Me.Controls.Add(Me.tsbForm)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormELARTCARACTERISTI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Caracteristicas Artículo"
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
    Friend WithEvents Label6 As Label
    Friend WithEvents lblart As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdetalle As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbaf As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcategoria As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtcalidad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcolor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtdiametro As TextBox
    Friend WithEvents txtcodart As TextBox
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents Label10 As Label
End Class
