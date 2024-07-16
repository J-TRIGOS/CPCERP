<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRPTGUIASDESPACHO
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtsalida = New System.Windows.Forms.RadioButton()
        Me.rbtentrada = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbt_mov = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbdestino = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtuserrep = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmbctct_cod = New System.Windows.Forms.ComboBox()
        Me.txtcodart = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpfecini = New System.Windows.Forms.DateTimePicker()
        Me.dtpfecfin = New System.Windows.Forms.DateTimePicker()
        Me.cmbSer_doc = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnro_doc = New System.Windows.Forms.TextBox()
        Me.txtt_doc = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.rbtsalida)
        Me.GroupBox1.Controls.Add(Me.rbtentrada)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmbt_mov)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbdestino)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.txtuserrep)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.cmbctct_cod)
        Me.GroupBox1.Controls.Add(Me.txtcodart)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpfecini)
        Me.GroupBox1.Controls.Add(Me.dtpfecfin)
        Me.GroupBox1.Controls.Add(Me.cmbSer_doc)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtnro_doc)
        Me.GroupBox1.Controls.Add(Me.txtt_doc)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 365)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'rbtsalida
        '
        Me.rbtsalida.AutoSize = True
        Me.rbtsalida.Checked = True
        Me.rbtsalida.Location = New System.Drawing.Point(175, 301)
        Me.rbtsalida.Name = "rbtsalida"
        Me.rbtsalida.Size = New System.Drawing.Size(54, 17)
        Me.rbtsalida.TabIndex = 116
        Me.rbtsalida.TabStop = True
        Me.rbtsalida.Text = "Salida"
        Me.rbtsalida.UseVisualStyleBackColor = True
        Me.rbtsalida.Visible = False
        '
        'rbtentrada
        '
        Me.rbtentrada.AutoSize = True
        Me.rbtentrada.Location = New System.Drawing.Point(65, 301)
        Me.rbtentrada.Name = "rbtentrada"
        Me.rbtentrada.Size = New System.Drawing.Size(62, 17)
        Me.rbtentrada.TabIndex = 115
        Me.rbtentrada.Text = "Entrada"
        Me.rbtentrada.UseVisualStyleBackColor = True
        Me.rbtentrada.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 114
        Me.Label10.Text = "T.Movim"
        '
        'cmbt_mov
        '
        Me.cmbt_mov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbt_mov.FormattingEnabled = True
        Me.cmbt_mov.Items.AddRange(New Object() {"", "S31-SALIDA POR TRASLADO ENTRE ESTABLECIMIENTO", "S32-SALIDA POR COMPRA", "E25-ENTRADA POR MANTENIMIENTO"})
        Me.cmbt_mov.Location = New System.Drawing.Point(103, 162)
        Me.cmbt_mov.Name = "cmbt_mov"
        Me.cmbt_mov.Size = New System.Drawing.Size(224, 21)
        Me.cmbt_mov.TabIndex = 113
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = "Destino"
        '
        'cmbdestino
        '
        Me.cmbdestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdestino.FormattingEnabled = True
        Me.cmbdestino.Items.AddRange(New Object() {"", "0001-TORRES", "0002-ELOY", "0003-LURIN"})
        Me.cmbdestino.Location = New System.Drawing.Point(103, 188)
        Me.cmbdestino.Name = "cmbdestino"
        Me.cmbdestino.Size = New System.Drawing.Size(151, 21)
        Me.cmbdestino.TabIndex = 111
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(257, 265)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 23)
        Me.Button3.TabIndex = 108
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtuserrep
        '
        Me.txtuserrep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtuserrep.Location = New System.Drawing.Point(103, 267)
        Me.txtuserrep.Name = "txtuserrep"
        Me.txtuserrep.Size = New System.Drawing.Size(151, 20)
        Me.txtuserrep.TabIndex = 107
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(257, 238)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 23)
        Me.Button2.TabIndex = 106
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmbctct_cod
        '
        Me.cmbctct_cod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbctct_cod.FormattingEnabled = True
        Me.cmbctct_cod.Location = New System.Drawing.Point(103, 240)
        Me.cmbctct_cod.Name = "cmbctct_cod"
        Me.cmbctct_cod.Size = New System.Drawing.Size(151, 21)
        Me.cmbctct_cod.TabIndex = 19
        '
        'txtcodart
        '
        Me.txtcodart.Location = New System.Drawing.Point(103, 214)
        Me.txtcodart.Name = "txtcodart"
        Me.txtcodart.Size = New System.Drawing.Size(151, 20)
        Me.txtcodart.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Usuario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cliente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Codigo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha Inicio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fecha Fin"
        '
        'dtpfecini
        '
        Me.dtpfecini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecini.Location = New System.Drawing.Point(103, 28)
        Me.dtpfecini.Name = "dtpfecini"
        Me.dtpfecini.Size = New System.Drawing.Size(126, 20)
        Me.dtpfecini.TabIndex = 10
        '
        'dtpfecfin
        '
        Me.dtpfecfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecfin.Location = New System.Drawing.Point(103, 58)
        Me.dtpfecfin.Name = "dtpfecfin"
        Me.dtpfecfin.Size = New System.Drawing.Size(126, 20)
        Me.dtpfecfin.TabIndex = 11
        '
        'cmbSer_doc
        '
        Me.cmbSer_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSer_doc.FormattingEnabled = True
        Me.cmbSer_doc.Items.AddRange(New Object() {"", "001 - TORRES", "003 - ELOY", "004 - LURIN"})
        Me.cmbSer_doc.Location = New System.Drawing.Point(103, 112)
        Me.cmbSer_doc.Name = "cmbSer_doc"
        Me.cmbSer_doc.Size = New System.Drawing.Size(151, 21)
        Me.cmbSer_doc.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(130, 324)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Numero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Origen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo"
        Me.Label1.Visible = False
        '
        'txtnro_doc
        '
        Me.txtnro_doc.Location = New System.Drawing.Point(103, 138)
        Me.txtnro_doc.Name = "txtnro_doc"
        Me.txtnro_doc.Size = New System.Drawing.Size(151, 20)
        Me.txtnro_doc.TabIndex = 2
        '
        'txtt_doc
        '
        Me.txtt_doc.Location = New System.Drawing.Point(103, 86)
        Me.txtt_doc.Name = "txtt_doc"
        Me.txtt_doc.ReadOnly = True
        Me.txtt_doc.Size = New System.Drawing.Size(151, 20)
        Me.txtt_doc.TabIndex = 0
        Me.txtt_doc.Text = "09"
        Me.txtt_doc.Visible = False
        '
        'FormRPTGUIASDESPACHO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 383)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormRPTGUIASDESPACHO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRPTGUIASDESPACHO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnro_doc As TextBox
    Friend WithEvents txtt_doc As TextBox
    Friend WithEvents cmbSer_doc As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpfecini As DateTimePicker
    Friend WithEvents dtpfecfin As DateTimePicker
    Friend WithEvents txtcodart As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents cmbctct_cod As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents txtuserrep As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbdestino As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbt_mov As ComboBox
    Friend WithEvents rbtsalida As RadioButton
    Friend WithEvents rbtentrada As RadioButton
End Class
