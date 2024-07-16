<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRPTConIng
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
        Me.dtpfec2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpfec1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbtdoc = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtuserrep = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dtpfec3 = New System.Windows.Forms.DateTimePicker()
        Me.txtuserrep2 = New System.Windows.Forms.TextBox()
        Me.dtpfec4 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmbtdoc2 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpfec2
        '
        Me.dtpfec2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec2.Location = New System.Drawing.Point(128, 37)
        Me.dtpfec2.Name = "dtpfec2"
        Me.dtpfec2.Size = New System.Drawing.Size(157, 20)
        Me.dtpfec2.TabIndex = 33
        '
        'dtpfec1
        '
        Me.dtpfec1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec1.Location = New System.Drawing.Point(128, 11)
        Me.dtpfec1.Name = "dtpfec1"
        Me.dtpfec1.Size = New System.Drawing.Size(157, 20)
        Me.dtpfec1.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Fecha Inicial"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(183, 130)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 40
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(52, 130)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 39
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Fecha Final"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Tipo Documento"
        '
        'cmbtdoc
        '
        Me.cmbtdoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtdoc.FormattingEnabled = True
        Me.cmbtdoc.Items.AddRange(New Object() {"", "01 - Factura", "09 - Guia Despacho", "SALM - Vale Almacen"})
        Me.cmbtdoc.Location = New System.Drawing.Point(128, 63)
        Me.cmbtdoc.Name = "cmbtdoc"
        Me.cmbtdoc.Size = New System.Drawing.Size(157, 21)
        Me.cmbtdoc.TabIndex = 43
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(255, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 23)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtuserrep
        '
        Me.txtuserrep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtuserrep.Location = New System.Drawing.Point(128, 90)
        Me.txtuserrep.Name = "txtuserrep"
        Me.txtuserrep.Size = New System.Drawing.Size(121, 20)
        Me.txtuserrep.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Usuario Reporte"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(343, 210)
        Me.TabControl1.TabIndex = 47
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.dtpfec1)
        Me.TabPage1.Controls.Add(Me.txtuserrep)
        Me.TabPage1.Controls.Add(Me.dtpfec2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.btnreporte)
        Me.TabPage1.Controls.Add(Me.cmbtdoc)
        Me.TabPage1.Controls.Add(Me.btnsalir)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(335, 184)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detallado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.dtpfec3)
        Me.TabPage2.Controls.Add(Me.txtuserrep2)
        Me.TabPage2.Controls.Add(Me.dtpfec4)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.cmbtdoc2)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(335, 184)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consolidado"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Fecha Inicial"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(270, 93)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 23)
        Me.Button2.TabIndex = 57
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dtpfec3
        '
        Me.dtpfec3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec3.Location = New System.Drawing.Point(143, 15)
        Me.dtpfec3.Name = "dtpfec3"
        Me.dtpfec3.Size = New System.Drawing.Size(157, 20)
        Me.dtpfec3.TabIndex = 47
        '
        'txtuserrep2
        '
        Me.txtuserrep2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtuserrep2.Location = New System.Drawing.Point(143, 94)
        Me.txtuserrep2.Name = "txtuserrep2"
        Me.txtuserrep2.Size = New System.Drawing.Size(121, 20)
        Me.txtuserrep2.TabIndex = 55
        '
        'dtpfec4
        '
        Me.dtpfec4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec4.Location = New System.Drawing.Point(143, 41)
        Me.dtpfec4.Name = "dtpfec4"
        Me.dtpfec4.Size = New System.Drawing.Size(157, 20)
        Me.dtpfec4.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Usuario Reporte"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(67, 134)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 36)
        Me.Button3.TabIndex = 50
        Me.Button3.Text = "Reporte"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cmbtdoc2
        '
        Me.cmbtdoc2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtdoc2.FormattingEnabled = True
        Me.cmbtdoc2.Items.AddRange(New Object() {"", "01 - Factura", "09 - Guia Despacho", "SALM - Vale Almacen"})
        Me.cmbtdoc2.Location = New System.Drawing.Point(143, 67)
        Me.cmbtdoc2.Name = "cmbtdoc2"
        Me.cmbtdoc2.Size = New System.Drawing.Size(157, 21)
        Me.cmbtdoc2.TabIndex = 54
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(198, 134)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 36)
        Me.Button4.TabIndex = 51
        Me.Button4.Text = "Salir"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Tipo Documento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Fecha Final"
        '
        'FormRPTConIng
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 241)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormRPTConIng"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRPTConIng"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtpfec2 As DateTimePicker
    Friend WithEvents dtpfec1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnreporte As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbtdoc As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtuserrep As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents dtpfec3 As DateTimePicker
    Friend WithEvents txtuserrep2 As TextBox
    Friend WithEvents dtpfec4 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents cmbtdoc2 As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
