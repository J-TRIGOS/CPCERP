<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteOrdenC
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbpendie = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblusuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblart_des = New System.Windows.Forms.TextBox()
        Me.lbl_ccosto = New System.Windows.Forms.TextBox()
        Me.lblt_acti = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_ccosto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtt_acti = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtcodartdos = New System.Windows.Forms.TextBox()
        Me.dtpfecini = New System.Windows.Forms.DateTimePicker()
        Me.dtpfecfin = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpfecfin)
        Me.GroupBox1.Controls.Add(Me.dtpfecini)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmbpendie)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblusuario)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblart_des)
        Me.GroupBox1.Controls.Add(Me.lbl_ccosto)
        Me.GroupBox1.Controls.Add(Me.lblt_acti)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_ccosto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtusuario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtt_acti)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.txtcodartdos)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(783, 146)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(407, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 223
        Me.Label8.Text = "Estado"
        '
        'cmbpendie
        '
        Me.cmbpendie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbpendie.FormattingEnabled = True
        Me.cmbpendie.Items.AddRange(New Object() {"NADA", "PENDIENTE", "APROBADO", "RECHAZADO", "PROCESADO", "TODOS"})
        Me.cmbpendie.Location = New System.Drawing.Point(453, 91)
        Me.cmbpendie.Name = "cmbpendie"
        Me.cmbpendie.Size = New System.Drawing.Size(109, 21)
        Me.cmbpendie.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 220
        Me.Label4.Text = "Fecha"
        '
        'lblusuario
        '
        Me.lblusuario.BackColor = System.Drawing.Color.Gainsboro
        Me.lblusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lblusuario.Location = New System.Drawing.Point(444, 21)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.ReadOnly = True
        Me.lblusuario.Size = New System.Drawing.Size(332, 20)
        Me.lblusuario.TabIndex = 217
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(319, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 216
        Me.Label2.Text = "Usuario"
        '
        'lblart_des
        '
        Me.lblart_des.BackColor = System.Drawing.Color.Gainsboro
        Me.lblart_des.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lblart_des.Location = New System.Drawing.Point(444, 55)
        Me.lblart_des.Name = "lblart_des"
        Me.lblart_des.ReadOnly = True
        Me.lblart_des.Size = New System.Drawing.Size(332, 20)
        Me.lblart_des.TabIndex = 215
        '
        'lbl_ccosto
        '
        Me.lbl_ccosto.BackColor = System.Drawing.Color.Gainsboro
        Me.lbl_ccosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lbl_ccosto.Location = New System.Drawing.Point(123, 54)
        Me.lbl_ccosto.Name = "lbl_ccosto"
        Me.lbl_ccosto.ReadOnly = True
        Me.lbl_ccosto.Size = New System.Drawing.Size(177, 20)
        Me.lbl_ccosto.TabIndex = 214
        '
        'lblt_acti
        '
        Me.lblt_acti.BackColor = System.Drawing.Color.Gainsboro
        Me.lblt_acti.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lblt_acti.Location = New System.Drawing.Point(123, 20)
        Me.lblt_acti.Name = "lblt_acti"
        Me.lblt_acti.ReadOnly = True
        Me.lblt_acti.Size = New System.Drawing.Size(177, 20)
        Me.lblt_acti.TabIndex = 213
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(319, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 206
        Me.Label7.Text = "Articulo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 202
        Me.Label5.Text = "Centro Costo"
        '
        'txt_ccosto
        '
        Me.txt_ccosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ccosto.Location = New System.Drawing.Point(75, 54)
        Me.txt_ccosto.MaxLength = 5
        Me.txt_ccosto.Name = "txt_ccosto"
        Me.txt_ccosto.Size = New System.Drawing.Size(47, 20)
        Me.txt_ccosto.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(339, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 197
        '
        'txtusuario
        '
        Me.txtusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtusuario.Location = New System.Drawing.Point(363, 21)
        Me.txtusuario.MaxLength = 20
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(80, 20)
        Me.txtusuario.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 194
        Me.Label1.Text = "Activo"
        '
        'txtt_acti
        '
        Me.txtt_acti.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtt_acti.Location = New System.Drawing.Point(75, 20)
        Me.txtt_acti.MaxLength = 6
        Me.txtt_acti.Name = "txtt_acti"
        Me.txtt_acti.Size = New System.Drawing.Size(47, 20)
        Me.txtt_acti.TabIndex = 1
        '
        'btnbuscar
        '
        Me.btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.Location = New System.Drawing.Point(671, 92)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(105, 26)
        Me.btnbuscar.TabIndex = 8
        Me.btnbuscar.Text = "Generar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'txtcodartdos
        '
        Me.txtcodartdos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodartdos.Location = New System.Drawing.Point(363, 55)
        Me.txtcodartdos.MaxLength = 10
        Me.txtcodartdos.Name = "txtcodartdos"
        Me.txtcodartdos.Size = New System.Drawing.Size(80, 20)
        Me.txtcodartdos.TabIndex = 4
        '
        'dtpfecini
        '
        Me.dtpfecini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecini.Location = New System.Drawing.Point(73, 92)
        Me.dtpfecini.Name = "dtpfecini"
        Me.dtpfecini.Size = New System.Drawing.Size(111, 20)
        Me.dtpfecini.TabIndex = 224
        '
        'dtpfecfin
        '
        Me.dtpfecfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecfin.Location = New System.Drawing.Point(200, 92)
        Me.dtpfecfin.Name = "dtpfecfin"
        Me.dtpfecfin.Size = New System.Drawing.Size(111, 20)
        Me.dtpfecfin.TabIndex = 225
        '
        'FormReporteOrdenC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 164)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormReporteOrdenC"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Reporte"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_ccosto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtt_acti As TextBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents txtcodartdos As TextBox
    Friend WithEvents lblart_des As TextBox
    Friend WithEvents lbl_ccosto As TextBox
    Friend WithEvents lblt_acti As TextBox
    Friend WithEvents lblusuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbpendie As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpfecfin As DateTimePicker
    Friend WithEvents dtpfecini As DateTimePicker
End Class
