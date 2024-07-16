<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBUSQSELECTMULT
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
        Me.txt_generic = New System.Windows.Forms.TextBox()
        Me.chkgeneric = New System.Windows.Forms.CheckBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txt_num = New System.Windows.Forms.TextBox()
        Me.txtser_doc = New System.Windows.Forms.TextBox()
        Me.txtt_doc = New System.Windows.Forms.TextBox()
        Me.chknum = New System.Windows.Forms.CheckBox()
        Me.chkser = New System.Windows.Forms.CheckBox()
        Me.chktipo = New System.Windows.Forms.CheckBox()
        Me.LstVBusq1 = New System.Windows.Forms.ListView()
        Me.chkmarcar = New System.Windows.Forms.CheckBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnquitar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnpasar = New System.Windows.Forms.Button()
        Me.LstVBusq2 = New System.Windows.Forms.ListView()
        Me.lblTdoc = New System.Windows.Forms.Label()
        Me.lblSdoc = New System.Windows.Forms.Label()
        Me.lblNdoc = New System.Windows.Forms.Label()
        Me.lblGen = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblGen)
        Me.GroupBox1.Controls.Add(Me.lblNdoc)
        Me.GroupBox1.Controls.Add(Me.lblSdoc)
        Me.GroupBox1.Controls.Add(Me.lblTdoc)
        Me.GroupBox1.Controls.Add(Me.txt_generic)
        Me.GroupBox1.Controls.Add(Me.chkgeneric)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.txt_num)
        Me.GroupBox1.Controls.Add(Me.txtser_doc)
        Me.GroupBox1.Controls.Add(Me.txtt_doc)
        Me.GroupBox1.Controls.Add(Me.chknum)
        Me.GroupBox1.Controls.Add(Me.chkser)
        Me.GroupBox1.Controls.Add(Me.chktipo)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(646, 58)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda"
        '
        'txt_generic
        '
        Me.txt_generic.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_generic.Location = New System.Drawing.Point(434, 33)
        Me.txt_generic.Name = "txt_generic"
        Me.txt_generic.Size = New System.Drawing.Size(116, 20)
        Me.txt_generic.TabIndex = 14
        Me.txt_generic.Visible = False
        '
        'chkgeneric
        '
        Me.chkgeneric.AutoSize = True
        Me.chkgeneric.Enabled = False
        Me.chkgeneric.Location = New System.Drawing.Point(447, 14)
        Me.chkgeneric.Name = "chkgeneric"
        Me.chkgeneric.Size = New System.Drawing.Size(15, 14)
        Me.chkgeneric.TabIndex = 13
        Me.chkgeneric.UseVisualStyleBackColor = True
        Me.chkgeneric.Visible = False
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(556, 30)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(55, 23)
        Me.btnbuscar.TabIndex = 12
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'txt_num
        '
        Me.txt_num.Location = New System.Drawing.Point(289, 33)
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(137, 20)
        Me.txt_num.TabIndex = 11
        '
        'txtser_doc
        '
        Me.txtser_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtser_doc.Location = New System.Drawing.Point(167, 33)
        Me.txtser_doc.Name = "txtser_doc"
        Me.txtser_doc.Size = New System.Drawing.Size(114, 20)
        Me.txtser_doc.TabIndex = 9
        '
        'txtt_doc
        '
        Me.txtt_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtt_doc.Location = New System.Drawing.Point(54, 33)
        Me.txtt_doc.Name = "txtt_doc"
        Me.txtt_doc.Size = New System.Drawing.Size(107, 20)
        Me.txtt_doc.TabIndex = 7
        '
        'chknum
        '
        Me.chknum.AutoSize = True
        Me.chknum.Enabled = False
        Me.chknum.Location = New System.Drawing.Point(306, 14)
        Me.chknum.Name = "chknum"
        Me.chknum.Size = New System.Drawing.Size(63, 17)
        Me.chknum.TabIndex = 10
        Me.chknum.Text = "Numero"
        Me.chknum.UseVisualStyleBackColor = True
        '
        'chkser
        '
        Me.chkser.AutoSize = True
        Me.chkser.Enabled = False
        Me.chkser.Location = New System.Drawing.Point(183, 14)
        Me.chkser.Name = "chkser"
        Me.chkser.Size = New System.Drawing.Size(50, 17)
        Me.chkser.TabIndex = 8
        Me.chkser.Text = "Serie"
        Me.chkser.UseVisualStyleBackColor = True
        '
        'chktipo
        '
        Me.chktipo.AutoSize = True
        Me.chktipo.Enabled = False
        Me.chktipo.Location = New System.Drawing.Point(67, 14)
        Me.chktipo.Name = "chktipo"
        Me.chktipo.Size = New System.Drawing.Size(47, 17)
        Me.chktipo.TabIndex = 6
        Me.chktipo.Text = "Tipo"
        Me.chktipo.UseVisualStyleBackColor = True
        '
        'LstVBusq1
        '
        Me.LstVBusq1.FullRowSelect = True
        Me.LstVBusq1.HideSelection = False
        Me.LstVBusq1.Location = New System.Drawing.Point(4, 89)
        Me.LstVBusq1.Name = "LstVBusq1"
        Me.LstVBusq1.Size = New System.Drawing.Size(290, 246)
        Me.LstVBusq1.TabIndex = 14
        Me.LstVBusq1.UseCompatibleStateImageBehavior = False
        Me.LstVBusq1.View = System.Windows.Forms.View.Details
        Me.LstVBusq1.Visible = False
        '
        'chkmarcar
        '
        Me.chkmarcar.AutoSize = True
        Me.chkmarcar.Location = New System.Drawing.Point(12, 66)
        Me.chkmarcar.Name = "chkmarcar"
        Me.chkmarcar.Size = New System.Drawing.Size(92, 17)
        Me.chkmarcar.TabIndex = 13
        Me.chkmarcar.Text = "Marcar Todos"
        Me.chkmarcar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(497, 64)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 17
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnquitar
        '
        Me.btnquitar.Location = New System.Drawing.Point(418, 64)
        Me.btnquitar.Name = "btnquitar"
        Me.btnquitar.Size = New System.Drawing.Size(75, 23)
        Me.btnquitar.TabIndex = 16
        Me.btnquitar.Text = "Quitar"
        Me.btnquitar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(573, 64)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 15
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnpasar
        '
        Me.btnpasar.Location = New System.Drawing.Point(337, 63)
        Me.btnpasar.Name = "btnpasar"
        Me.btnpasar.Size = New System.Drawing.Size(75, 23)
        Me.btnpasar.TabIndex = 14
        Me.btnpasar.Text = "Pasar"
        Me.btnpasar.UseVisualStyleBackColor = True
        '
        'LstVBusq2
        '
        Me.LstVBusq2.CheckBoxes = True
        Me.LstVBusq2.FullRowSelect = True
        Me.LstVBusq2.HideSelection = False
        Me.LstVBusq2.Location = New System.Drawing.Point(358, 89)
        Me.LstVBusq2.Name = "LstVBusq2"
        Me.LstVBusq2.Size = New System.Drawing.Size(290, 246)
        Me.LstVBusq2.TabIndex = 16
        Me.LstVBusq2.UseCompatibleStateImageBehavior = False
        Me.LstVBusq2.View = System.Windows.Forms.View.Details
        Me.LstVBusq2.Visible = False
        '
        'lblTdoc
        '
        Me.lblTdoc.AutoSize = True
        Me.lblTdoc.Location = New System.Drawing.Point(125, 15)
        Me.lblTdoc.Name = "lblTdoc"
        Me.lblTdoc.Size = New System.Drawing.Size(32, 13)
        Me.lblTdoc.TabIndex = 15
        Me.lblTdoc.Text = "Tdoc"
        Me.lblTdoc.Visible = False
        '
        'lblSdoc
        '
        Me.lblSdoc.AutoSize = True
        Me.lblSdoc.Location = New System.Drawing.Point(246, 14)
        Me.lblSdoc.Name = "lblSdoc"
        Me.lblSdoc.Size = New System.Drawing.Size(32, 13)
        Me.lblSdoc.TabIndex = 16
        Me.lblSdoc.Text = "Sdoc"
        Me.lblSdoc.Visible = False
        '
        'lblNdoc
        '
        Me.lblNdoc.AutoSize = True
        Me.lblNdoc.Location = New System.Drawing.Point(390, 14)
        Me.lblNdoc.Name = "lblNdoc"
        Me.lblNdoc.Size = New System.Drawing.Size(33, 13)
        Me.lblNdoc.TabIndex = 17
        Me.lblNdoc.Text = "Ndoc"
        Me.lblNdoc.Visible = False
        '
        'lblGen
        '
        Me.lblGen.AutoSize = True
        Me.lblGen.Location = New System.Drawing.Point(510, 13)
        Me.lblGen.Name = "lblGen"
        Me.lblGen.Size = New System.Drawing.Size(35, 13)
        Me.lblGen.TabIndex = 18
        Me.lblGen.Text = "NGen"
        Me.lblGen.Visible = False
        '
        'FormBUSQSELECTMULT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 345)
        Me.Controls.Add(Me.chkmarcar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.LstVBusq2)
        Me.Controls.Add(Me.btnquitar)
        Me.Controls.Add(Me.btnpasar)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.LstVBusq1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormBUSQSELECTMULT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents txt_num As TextBox
    Friend WithEvents txtser_doc As TextBox
    Friend WithEvents txtt_doc As TextBox
    Friend WithEvents chknum As CheckBox
    Friend WithEvents chkser As CheckBox
    Friend WithEvents chktipo As CheckBox
    Friend WithEvents LstVBusq1 As ListView
    Friend WithEvents chkmarcar As CheckBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnpasar As Button
    Friend WithEvents LstVBusq2 As ListView
    Friend WithEvents btnquitar As Button
    Friend WithEvents txt_generic As TextBox
    Friend WithEvents chkgeneric As CheckBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblGen As Label
    Friend WithEvents lblNdoc As Label
    Friend WithEvents lblSdoc As Label
    Friend WithEvents lblTdoc As Label
End Class
