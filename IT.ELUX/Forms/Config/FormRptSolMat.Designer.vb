<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptSolMat
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
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbestdoc = New System.Windows.Forms.ComboBox()
        Me.cmbest = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbc_costo = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtuserrep = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnomarticulo = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtarticulo1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpfec2
        '
        Me.dtpfec2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec2.Location = New System.Drawing.Point(111, 50)
        Me.dtpfec2.Name = "dtpfec2"
        Me.dtpfec2.Size = New System.Drawing.Size(121, 20)
        Me.dtpfec2.TabIndex = 2
        '
        'dtpfec1
        '
        Me.dtpfec1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec1.Location = New System.Drawing.Point(109, 24)
        Me.dtpfec1.Name = "dtpfec1"
        Me.dtpfec1.Size = New System.Drawing.Size(123, 20)
        Me.dtpfec1.TabIndex = 1
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(187, 222)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 4
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(91, 222)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 3
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Estado Documento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Estado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Fecha Fin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Fecha Inicio"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(238, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 34)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "En Blanco Salen Todos"
        '
        'cmbestdoc
        '
        Me.cmbestdoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestdoc.FormattingEnabled = True
        Me.cmbestdoc.Items.AddRange(New Object() {"", "Pendiente", "Desaprobado", "Aprobado", "Documentado", "Cerrado"})
        Me.cmbestdoc.Location = New System.Drawing.Point(111, 107)
        Me.cmbestdoc.Name = "cmbestdoc"
        Me.cmbestdoc.Size = New System.Drawing.Size(121, 21)
        Me.cmbestdoc.TabIndex = 28
        '
        'cmbest
        '
        Me.cmbest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbest.FormattingEnabled = True
        Me.cmbest.Items.AddRange(New Object() {"", "Habilitado", "Anulado"})
        Me.cmbest.Location = New System.Drawing.Point(111, 79)
        Me.cmbest.Name = "cmbest"
        Me.cmbest.Size = New System.Drawing.Size(121, 21)
        Me.cmbest.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Area"
        '
        'cmbc_costo
        '
        Me.cmbc_costo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmbc_costo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbc_costo.FormattingEnabled = True
        Me.cmbc_costo.Location = New System.Drawing.Point(109, 134)
        Me.cmbc_costo.Name = "cmbc_costo"
        Me.cmbc_costo.Size = New System.Drawing.Size(153, 21)
        Me.cmbc_costo.TabIndex = 33
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(236, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 23)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtuserrep
        '
        Me.txtuserrep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtuserrep.Location = New System.Drawing.Point(109, 161)
        Me.txtuserrep.Name = "txtuserrep"
        Me.txtuserrep.Size = New System.Drawing.Size(121, 20)
        Me.txtuserrep.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Usuario Reporte"
        '
        'txtnomarticulo
        '
        Me.txtnomarticulo.Location = New System.Drawing.Point(178, 187)
        Me.txtnomarticulo.Name = "txtnomarticulo"
        Me.txtnomarticulo.ReadOnly = True
        Me.txtnomarticulo.Size = New System.Drawing.Size(144, 20)
        Me.txtnomarticulo.TabIndex = 156
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(331, 185)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 23)
        Me.Button3.TabIndex = 155
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtarticulo1
        '
        Me.txtarticulo1.Location = New System.Drawing.Point(109, 187)
        Me.txtarticulo1.Name = "txtarticulo1"
        Me.txtarticulo1.Size = New System.Drawing.Size(63, 20)
        Me.txtarticulo1.TabIndex = 153
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 154
        Me.Label9.Text = "Articulo:"
        '
        'FormRptSolMat
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 279)
        Me.Controls.Add(Me.txtnomarticulo)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtarticulo1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtuserrep)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbc_costo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbestdoc)
        Me.Controls.Add(Me.cmbest)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.dtpfec2)
        Me.Controls.Add(Me.dtpfec1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormRptSolMat"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptSolMat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpfec2 As DateTimePicker
    Friend WithEvents dtpfec1 As DateTimePicker
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnreporte As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbestdoc As ComboBox
    Friend WithEvents cmbest As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbc_costo As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtuserrep As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnomarticulo As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents txtarticulo1 As TextBox
    Friend WithEvents Label9 As Label
End Class
