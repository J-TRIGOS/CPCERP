<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormELTBDETMTIEM
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
        Me.txtnomdni = New System.Windows.Forms.TextBox()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.txtact = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtdifhora = New System.Windows.Forms.TextBox()
        Me.dtphoratermino = New System.Windows.Forms.DateTimePicker()
        Me.dtphoragene = New System.Windows.Forms.DateTimePicker()
        Me.dtpfec_termino = New System.Windows.Forms.DateTimePicker()
        Me.dtpfec_inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbactividad = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtnomdni
        '
        Me.txtnomdni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnomdni.Location = New System.Drawing.Point(240, 35)
        Me.txtnomdni.Name = "txtnomdni"
        Me.txtnomdni.ReadOnly = True
        Me.txtnomdni.Size = New System.Drawing.Size(303, 20)
        Me.txtnomdni.TabIndex = 188
        '
        'txtdni
        '
        Me.txtdni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdni.Location = New System.Drawing.Point(135, 35)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.ReadOnly = True
        Me.txtdni.Size = New System.Drawing.Size(100, 20)
        Me.txtdni.TabIndex = 187
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 201
        Me.Label2.Text = "Personal  :"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(275, 158)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 195
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(177, 158)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnaceptar.TabIndex = 194
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'txtact
        '
        Me.txtact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtact.Location = New System.Drawing.Point(135, 104)
        Me.txtact.Name = "txtact"
        Me.txtact.Size = New System.Drawing.Size(408, 20)
        Me.txtact.TabIndex = 193
        Me.txtact.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 200
        Me.Label6.Text = "Actividad a Realizar:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(349, 63)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(81, 13)
        Me.Label25.TabIndex = 199
        Me.Label25.Text = "Diferencia Hora"
        '
        'txtdifhora
        '
        Me.txtdifhora.Location = New System.Drawing.Point(342, 80)
        Me.txtdifhora.Name = "txtdifhora"
        Me.txtdifhora.ReadOnly = True
        Me.txtdifhora.Size = New System.Drawing.Size(100, 20)
        Me.txtdifhora.TabIndex = 192
        '
        'dtphoratermino
        '
        Me.dtphoratermino.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtphoratermino.Location = New System.Drawing.Point(240, 85)
        Me.dtphoratermino.Name = "dtphoratermino"
        Me.dtphoratermino.ShowUpDown = True
        Me.dtphoratermino.Size = New System.Drawing.Size(96, 20)
        Me.dtphoratermino.TabIndex = 191
        '
        'dtphoragene
        '
        Me.dtphoragene.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtphoragene.Location = New System.Drawing.Point(240, 61)
        Me.dtphoragene.Name = "dtphoragene"
        Me.dtphoragene.ShowUpDown = True
        Me.dtphoragene.Size = New System.Drawing.Size(96, 20)
        Me.dtphoragene.TabIndex = 190
        '
        'dtpfec_termino
        '
        Me.dtpfec_termino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_termino.Location = New System.Drawing.Point(135, 85)
        Me.dtpfec_termino.Name = "dtpfec_termino"
        Me.dtpfec_termino.Size = New System.Drawing.Size(100, 20)
        Me.dtpfec_termino.TabIndex = 189
        '
        'dtpfec_inicio
        '
        Me.dtpfec_inicio.Enabled = False
        Me.dtpfec_inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_inicio.Location = New System.Drawing.Point(135, 61)
        Me.dtpfec_inicio.Name = "dtpfec_inicio"
        Me.dtpfec_inicio.Size = New System.Drawing.Size(100, 20)
        Me.dtpfec_inicio.TabIndex = 196
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(42, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 198
        Me.Label11.Text = "Fecha Termino  :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(55, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 197
        Me.Label10.Text = "Fecha Inicio  :"
        '
        'cmbactividad
        '
        Me.cmbactividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbactividad.FormattingEnabled = True
        Me.cmbactividad.Location = New System.Drawing.Point(135, 111)
        Me.cmbactividad.Name = "cmbactividad"
        Me.cmbactividad.Size = New System.Drawing.Size(408, 21)
        Me.cmbactividad.TabIndex = 249
        '
        'FormELTBDETMTIEM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 188)
        Me.Controls.Add(Me.cmbactividad)
        Me.Controls.Add(Me.txtnomdni)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.txtact)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtdifhora)
        Me.Controls.Add(Me.dtphoratermino)
        Me.Controls.Add(Me.dtphoragene)
        Me.Controls.Add(Me.dtpfec_termino)
        Me.Controls.Add(Me.dtpfec_inicio)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Name = "FormELTBDETMTIEM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormELTBDETMTIEM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnomdni As TextBox
    Friend WithEvents txtdni As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnaceptar As Button
    Friend WithEvents txtact As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtdifhora As TextBox
    Friend WithEvents dtphoratermino As DateTimePicker
    Friend WithEvents dtphoragene As DateTimePicker
    Friend WithEvents dtpfec_termino As DateTimePicker
    Friend WithEvents dtpfec_inicio As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbactividad As ComboBox
End Class
