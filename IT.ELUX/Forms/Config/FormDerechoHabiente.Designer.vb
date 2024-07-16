<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDerechoHabiente
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.txtape1 = New System.Windows.Forms.TextBox()
        Me.txtape2 = New System.Windows.Forms.TextBox()
        Me.txtnom1 = New System.Windows.Forms.TextBox()
        Me.txtnom2 = New System.Windows.Forms.TextBox()
        Me.dtpfec_nac = New System.Windows.Forms.DateTimePicker()
        Me.cmbx_tdoc = New System.Windows.Forms.ComboBox()
        Me.txtle = New System.Windows.Forms.TextBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.cmbvinculo_cod = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fec. Nac."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "T. Doc."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Doc. Identidad"
        '
        'txtcod
        '
        Me.txtcod.Location = New System.Drawing.Point(105, 28)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.ReadOnly = True
        Me.txtcod.Size = New System.Drawing.Size(57, 20)
        Me.txtcod.TabIndex = 50
        '
        'txtape1
        '
        Me.txtape1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtape1.Location = New System.Drawing.Point(105, 54)
        Me.txtape1.Name = "txtape1"
        Me.txtape1.Size = New System.Drawing.Size(185, 20)
        Me.txtape1.TabIndex = 1
        '
        'txtape2
        '
        Me.txtape2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtape2.Location = New System.Drawing.Point(105, 80)
        Me.txtape2.Name = "txtape2"
        Me.txtape2.Size = New System.Drawing.Size(185, 20)
        Me.txtape2.TabIndex = 2
        '
        'txtnom1
        '
        Me.txtnom1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnom1.Location = New System.Drawing.Point(105, 106)
        Me.txtnom1.Name = "txtnom1"
        Me.txtnom1.Size = New System.Drawing.Size(185, 20)
        Me.txtnom1.TabIndex = 3
        '
        'txtnom2
        '
        Me.txtnom2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnom2.Location = New System.Drawing.Point(105, 132)
        Me.txtnom2.Name = "txtnom2"
        Me.txtnom2.Size = New System.Drawing.Size(185, 20)
        Me.txtnom2.TabIndex = 4
        '
        'dtpfec_nac
        '
        Me.dtpfec_nac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_nac.Location = New System.Drawing.Point(105, 158)
        Me.dtpfec_nac.Name = "dtpfec_nac"
        Me.dtpfec_nac.Size = New System.Drawing.Size(113, 20)
        Me.dtpfec_nac.TabIndex = 5
        '
        'cmbx_tdoc
        '
        Me.cmbx_tdoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbx_tdoc.FormattingEnabled = True
        Me.cmbx_tdoc.Items.AddRange(New Object() {"", "DNI", "PARTIDA DE NACIMIENTO", "PASAPORTE", "CARNET DE EXTRANJERIA"})
        Me.cmbx_tdoc.Location = New System.Drawing.Point(105, 184)
        Me.cmbx_tdoc.Name = "cmbx_tdoc"
        Me.cmbx_tdoc.Size = New System.Drawing.Size(185, 21)
        Me.cmbx_tdoc.TabIndex = 6
        '
        'txtle
        '
        Me.txtle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtle.Location = New System.Drawing.Point(105, 211)
        Me.txtle.MaxLength = 8
        Me.txtle.Name = "txtle"
        Me.txtle.Size = New System.Drawing.Size(105, 20)
        Me.txtle.TabIndex = 7
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(160, 274)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 40)
        Me.btnsalir.TabIndex = 10
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(79, 274)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 40)
        Me.btnagregar.TabIndex = 9
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'cmbvinculo_cod
        '
        Me.cmbvinculo_cod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbvinculo_cod.FormattingEnabled = True
        Me.cmbvinculo_cod.Items.AddRange(New Object() {"", "CONYUGE", "CONCUBINO (A)", "GESTANTE", "HIJO MENOR DE EDAD", "HIJO MAYOR DISCAPACITADO PERM.", "HIJO MAYOR DE EDAD"})
        Me.cmbvinculo_cod.Location = New System.Drawing.Point(105, 237)
        Me.cmbvinculo_cod.Name = "cmbvinculo_cod"
        Me.cmbvinculo_cod.Size = New System.Drawing.Size(185, 21)
        Me.cmbvinculo_cod.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(46, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Vinculo"
        '
        'FormDerechoHabiente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 316)
        Me.Controls.Add(Me.cmbvinculo_cod)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.txtle)
        Me.Controls.Add(Me.cmbx_tdoc)
        Me.Controls.Add(Me.dtpfec_nac)
        Me.Controls.Add(Me.txtnom2)
        Me.Controls.Add(Me.txtnom1)
        Me.Controls.Add(Me.txtape2)
        Me.Controls.Add(Me.txtape1)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormDerechoHabiente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDerechoHabiente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcod As TextBox
    Friend WithEvents txtape1 As TextBox
    Friend WithEvents txtape2 As TextBox
    Friend WithEvents txtnom1 As TextBox
    Friend WithEvents txtnom2 As TextBox
    Friend WithEvents dtpfec_nac As DateTimePicker
    Friend WithEvents cmbx_tdoc As ComboBox
    Friend WithEvents txtle As TextBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents cmbvinculo_cod As ComboBox
    Friend WithEvents Label9 As Label
End Class
