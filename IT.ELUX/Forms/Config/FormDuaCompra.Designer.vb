<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDuaCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDuaCompra))
        Me.txtnguia = New System.Windows.Forms.TextBox()
        Me.txtnroguia = New System.Windows.Forms.Label()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.txtanho = New System.Windows.Forms.TextBox()
        Me.txtmon = New System.Windows.Forms.TextBox()
        Me.txtnro = New System.Windows.Forms.TextBox()
        Me.txtmarit = New System.Windows.Forms.TextBox()
        Me.txt6 = New System.Windows.Forms.TextBox()
        Me.txt01 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdesprincipal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsericom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxNuevo = New System.Windows.Forms.CheckBox()
        Me.cmbcomponente = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtcodigopri = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtpfechactual = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnimprimir = New System.Windows.Forms.Button()
        Me.tsbForm.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtnguia
        '
        Me.txtnguia.BackColor = System.Drawing.Color.White
        Me.txtnguia.Location = New System.Drawing.Point(95, 30)
        Me.txtnguia.MaxLength = 7
        Me.txtnguia.Name = "txtnguia"
        Me.txtnguia.Size = New System.Drawing.Size(90, 20)
        Me.txtnguia.TabIndex = 1
        '
        'txtnroguia
        '
        Me.txtnroguia.AutoSize = True
        Me.txtnroguia.Location = New System.Drawing.Point(12, 35)
        Me.txtnroguia.Name = "txtnroguia"
        Me.txtnroguia.Size = New System.Drawing.Size(66, 13)
        Me.txtnroguia.TabIndex = 151
        Me.txtnroguia.Text = "Nro. Factura"
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbimprimir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(644, 25)
        Me.tsbForm.TabIndex = 152
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
        'tsbimprimir
        '
        Me.tsbimprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbimprimir.Image = CType(resources.GetObject("tsbimprimir.Image"), System.Drawing.Image)
        Me.tsbimprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbimprimir.Name = "tsbimprimir"
        Me.tsbimprimir.Size = New System.Drawing.Size(23, 22)
        Me.tsbimprimir.Tag = "Print"
        Me.tsbimprimir.Text = "Imprimir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "Numero"
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(96, 32)
        Me.txtserie.MaxLength = 3
        Me.txtserie.Name = "txtserie"
        Me.txtserie.ReadOnly = True
        Me.txtserie.Size = New System.Drawing.Size(32, 20)
        Me.txtserie.TabIndex = 154
        Me.txtserie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtanho
        '
        Me.txtanho.Location = New System.Drawing.Point(129, 32)
        Me.txtanho.MaxLength = 7
        Me.txtanho.Name = "txtanho"
        Me.txtanho.ReadOnly = True
        Me.txtanho.Size = New System.Drawing.Size(47, 20)
        Me.txtanho.TabIndex = 155
        Me.txtanho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmon
        '
        Me.txtmon.Location = New System.Drawing.Point(323, 32)
        Me.txtmon.MaxLength = 2
        Me.txtmon.Name = "txtmon"
        Me.txtmon.Size = New System.Drawing.Size(26, 20)
        Me.txtmon.TabIndex = 156
        Me.txtmon.Text = "00"
        Me.txtmon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnro
        '
        Me.txtnro.Location = New System.Drawing.Point(204, 32)
        Me.txtnro.MaxLength = 7
        Me.txtnro.Name = "txtnro"
        Me.txtnro.ReadOnly = True
        Me.txtnro.Size = New System.Drawing.Size(70, 20)
        Me.txtnro.TabIndex = 157
        Me.txtnro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmarit
        '
        Me.txtmarit.Location = New System.Drawing.Point(177, 32)
        Me.txtmarit.MaxLength = 2
        Me.txtmarit.Name = "txtmarit"
        Me.txtmarit.ReadOnly = True
        Me.txtmarit.Size = New System.Drawing.Size(26, 20)
        Me.txtmarit.TabIndex = 158
        Me.txtmarit.Text = "10"
        Me.txtmarit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt6
        '
        Me.txt6.Location = New System.Drawing.Point(302, 32)
        Me.txt6.MaxLength = 1
        Me.txt6.Name = "txt6"
        Me.txt6.Size = New System.Drawing.Size(20, 20)
        Me.txt6.TabIndex = 159
        Me.txt6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt01
        '
        Me.txt01.Location = New System.Drawing.Point(275, 32)
        Me.txt01.MaxLength = 2
        Me.txt01.Name = "txt01"
        Me.txt01.Size = New System.Drawing.Size(26, 20)
        Me.txt01.TabIndex = 160
        Me.txt01.Text = "01"
        Me.txt01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Fecha"
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.Gainsboro
        Me.txtFecha.Location = New System.Drawing.Point(95, 64)
        Me.txtFecha.MaxLength = 7
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(90, 20)
        Me.txtFecha.TabIndex = 162
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 163
        Me.Label3.Text = "Art. Principal"
        '
        'txtdesprincipal
        '
        Me.txtdesprincipal.BackColor = System.Drawing.Color.Gainsboro
        Me.txtdesprincipal.Location = New System.Drawing.Point(96, 120)
        Me.txtdesprincipal.MaxLength = 7
        Me.txtdesprincipal.Name = "txtdesprincipal"
        Me.txtdesprincipal.ReadOnly = True
        Me.txtdesprincipal.Size = New System.Drawing.Size(494, 20)
        Me.txtdesprincipal.TabIndex = 164
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Serie"
        '
        'txtsericom
        '
        Me.txtsericom.BackColor = System.Drawing.Color.Gainsboro
        Me.txtsericom.Location = New System.Drawing.Point(97, 61)
        Me.txtsericom.MaxLength = 7
        Me.txtsericom.Name = "txtsericom"
        Me.txtsericom.ReadOnly = True
        Me.txtsericom.Size = New System.Drawing.Size(61, 20)
        Me.txtsericom.TabIndex = 166
        Me.txtsericom.Text = "0001"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 167
        Me.Label5.Text = "Art. Componente"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxNuevo)
        Me.GroupBox1.Controls.Add(Me.cmbcomponente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtserie)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt01)
        Me.GroupBox1.Controls.Add(Me.txtsericom)
        Me.GroupBox1.Controls.Add(Me.txtanho)
        Me.GroupBox1.Controls.Add(Me.txtnro)
        Me.GroupBox1.Controls.Add(Me.txt6)
        Me.GroupBox1.Controls.Add(Me.txtmarit)
        Me.GroupBox1.Controls.Add(Me.txtmon)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 188)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(620, 122)
        Me.GroupBox1.TabIndex = 169
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dam de Importación"
        '
        'cbxNuevo
        '
        Me.cbxNuevo.AutoSize = True
        Me.cbxNuevo.Checked = True
        Me.cbxNuevo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxNuevo.Location = New System.Drawing.Point(373, 34)
        Me.cbxNuevo.Name = "cbxNuevo"
        Me.cbxNuevo.Size = New System.Drawing.Size(64, 17)
        Me.cbxNuevo.TabIndex = 168
        Me.cbxNuevo.Text = "NUEVO"
        Me.cbxNuevo.UseVisualStyleBackColor = True
        '
        'cmbcomponente
        '
        Me.cmbcomponente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcomponente.FormattingEnabled = True
        Me.cmbcomponente.Items.AddRange(New Object() {"05020322 - BARNIZ PRIMER 31S68ED", "05020324 - ORGANOSOL 31S99EC"})
        Me.cmbcomponente.Location = New System.Drawing.Point(97, 90)
        Me.cmbcomponente.Name = "cmbcomponente"
        Me.cmbcomponente.Size = New System.Drawing.Size(402, 21)
        Me.cmbcomponente.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtcodigopri)
        Me.GroupBox2.Controls.Add(Me.txtdesprincipal)
        Me.GroupBox2.Controls.Add(Me.txtnroguia)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtnguia)
        Me.GroupBox2.Controls.Add(Me.txtFecha)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(620, 154)
        Me.GroupBox2.TabIndex = 170
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Factura de Venta Local"
        '
        'txtcodigopri
        '
        Me.txtcodigopri.BackColor = System.Drawing.Color.White
        Me.txtcodigopri.Location = New System.Drawing.Point(96, 99)
        Me.txtcodigopri.MaxLength = 7
        Me.txtcodigopri.Name = "txtcodigopri"
        Me.txtcodigopri.Size = New System.Drawing.Size(90, 20)
        Me.txtcodigopri.TabIndex = 165
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtpfechactual)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 318)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(617, 49)
        Me.GroupBox3.TabIndex = 171
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fecha del Reporte"
        '
        'dtpfechactual
        '
        Me.dtpfechactual.Location = New System.Drawing.Point(93, 18)
        Me.dtpfechactual.Name = "dtpfechactual"
        Me.dtpfechactual.Size = New System.Drawing.Size(200, 20)
        Me.dtpfechactual.TabIndex = 155
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 154
        Me.Label6.Text = "Fecha"
        '
        'btnimprimir
        '
        Me.btnimprimir.Location = New System.Drawing.Point(238, 377)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(133, 28)
        Me.btnimprimir.TabIndex = 3
        Me.btnimprimir.Text = "Imprimir Reporte"
        Me.btnimprimir.UseVisualStyleBackColor = True
        '
        'FormDuaCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 415)
        Me.Controls.Add(Me.btnimprimir)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tsbForm)
        Me.Name = "FormDuaCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresión Declaración Jurada"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnguia As TextBox
    Friend WithEvents txtnroguia As Label
    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtserie As TextBox
    Friend WithEvents txtanho As TextBox
    Friend WithEvents txtmon As TextBox
    Friend WithEvents txtnro As TextBox
    Friend WithEvents txtmarit As TextBox
    Friend WithEvents txt6 As TextBox
    Friend WithEvents txt01 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdesprincipal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtsericom As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtpfechactual As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents btnimprimir As Button
    Friend WithEvents txtcodigopri As TextBox
    Friend WithEvents cmbcomponente As ComboBox
    Friend WithEvents cbxNuevo As CheckBox
End Class
