<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNewArt
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
        Me.cmbmedida = New System.Windows.Forms.ComboBox()
        Me.cmbunidadmedida = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbmedida2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbcodalmacen = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbcentrocosto = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtdescriproc = New System.Windows.Forms.TextBox()
        Me.txtcodproc = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbreqsolm1 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbart = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbtipocomp = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.npdcantcomp = New System.Windows.Forms.NumericUpDown()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtdescriproc1 = New System.Windows.Forms.TextBox()
        Me.txtcodproc1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbmedida3 = New System.Windows.Forms.ComboBox()
        Me.cmbunidadmedida1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbmedida4 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbcodalmacen1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbcentrocosto1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbreqsolm = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.npdcantcomp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbmedida
        '
        Me.cmbmedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmedida.FormattingEnabled = True
        Me.cmbmedida.Items.AddRange(New Object() {"1 SI", "0 NO"})
        Me.cmbmedida.Location = New System.Drawing.Point(377, 35)
        Me.cmbmedida.Name = "cmbmedida"
        Me.cmbmedida.Size = New System.Drawing.Size(191, 21)
        Me.cmbmedida.TabIndex = 88
        Me.cmbmedida.Visible = False
        '
        'cmbunidadmedida
        '
        Me.cmbunidadmedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbunidadmedida.FormattingEnabled = True
        Me.cmbunidadmedida.Location = New System.Drawing.Point(377, 62)
        Me.cmbunidadmedida.Name = "cmbunidadmedida"
        Me.cmbunidadmedida.Size = New System.Drawing.Size(189, 21)
        Me.cmbunidadmedida.TabIndex = 86
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(326, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 87
        Me.Label9.Text = "U/M :"
        '
        'cmbmedida2
        '
        Me.cmbmedida2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmedida2.FormattingEnabled = True
        Me.cmbmedida2.Location = New System.Drawing.Point(377, 35)
        Me.cmbmedida2.Name = "cmbmedida2"
        Me.cmbmedida2.Size = New System.Drawing.Size(191, 21)
        Me.cmbmedida2.TabIndex = 85
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(320, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Formato :"
        '
        'cmbcodalmacen
        '
        Me.cmbcodalmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcodalmacen.FormattingEnabled = True
        Me.cmbcodalmacen.ItemHeight = 13
        Me.cmbcodalmacen.Location = New System.Drawing.Point(120, 62)
        Me.cmbcodalmacen.Name = "cmbcodalmacen"
        Me.cmbcodalmacen.Size = New System.Drawing.Size(191, 21)
        Me.cmbcodalmacen.TabIndex = 83
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Codigo Almacen :"
        '
        'cmbcentrocosto
        '
        Me.cmbcentrocosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcentrocosto.FormattingEnabled = True
        Me.cmbcentrocosto.ItemHeight = 13
        Me.cmbcentrocosto.Location = New System.Drawing.Point(120, 35)
        Me.cmbcentrocosto.Name = "cmbcentrocosto"
        Me.cmbcentrocosto.Size = New System.Drawing.Size(191, 21)
        Me.cmbcentrocosto.TabIndex = 81
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Centro Costo :"
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(192, 223)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnaceptar.TabIndex = 89
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(354, 223)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 90
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(521, 90)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 23)
        Me.Button2.TabIndex = 94
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtdescriproc
        '
        Me.txtdescriproc.Enabled = False
        Me.txtdescriproc.Location = New System.Drawing.Point(178, 92)
        Me.txtdescriproc.Name = "txtdescriproc"
        Me.txtdescriproc.ReadOnly = True
        Me.txtdescriproc.Size = New System.Drawing.Size(337, 20)
        Me.txtdescriproc.TabIndex = 93
        '
        'txtcodproc
        '
        Me.txtcodproc.Location = New System.Drawing.Point(120, 92)
        Me.txtcodproc.MaxLength = 4
        Me.txtcodproc.Name = "txtcodproc"
        Me.txtcodproc.Size = New System.Drawing.Size(52, 20)
        Me.txtcodproc.TabIndex = 92
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(52, 92)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(52, 13)
        Me.Label28.TabIndex = 91
        Me.Label28.Text = "Proceso :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbreqsolm1)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.cmbart)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtdescripcion)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.cmbtipocomp)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.npdcantcomp)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtdescriproc1)
        Me.Panel1.Controls.Add(Me.txtcodproc1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbmedida3)
        Me.Panel1.Controls.Add(Me.cmbunidadmedida1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbmedida4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbcodalmacen1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cmbcentrocosto1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(14, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(595, 205)
        Me.Panel1.TabIndex = 95
        '
        'cmbreqsolm1
        '
        Me.cmbreqsolm1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbreqsolm1.FormattingEnabled = True
        Me.cmbreqsolm1.Items.AddRange(New Object() {"SI", "NO"})
        Me.cmbreqsolm1.Location = New System.Drawing.Point(129, 169)
        Me.cmbreqsolm1.Name = "cmbreqsolm1"
        Me.cmbreqsolm1.Size = New System.Drawing.Size(121, 21)
        Me.cmbreqsolm1.TabIndex = 117
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(51, 172)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 116
        Me.Label13.Text = "Req. Solm :"
        '
        'cmbart
        '
        Me.cmbart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbart.FormattingEnabled = True
        Me.cmbart.Location = New System.Drawing.Point(129, 8)
        Me.cmbart.Name = "cmbart"
        Me.cmbart.Size = New System.Drawing.Size(395, 21)
        Me.cmbart.TabIndex = 115
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(64, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 114
        Me.Label11.Text = "Codigo :"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(129, 32)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(395, 20)
        Me.txtdescripcion.TabIndex = 113
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(41, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "Descripcion :"
        '
        'cmbtipocomp
        '
        Me.cmbtipocomp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipocomp.FormattingEnabled = True
        Me.cmbtipocomp.Items.AddRange(New Object() {"01 Componente", "02 Insumo"})
        Me.cmbtipocomp.Location = New System.Drawing.Point(129, 60)
        Me.cmbtipocomp.Name = "cmbtipocomp"
        Me.cmbtipocomp.Size = New System.Drawing.Size(163, 21)
        Me.cmbtipocomp.TabIndex = 111
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(78, 63)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(34, 13)
        Me.Label21.TabIndex = 110
        Me.Label21.Text = "Tipo :"
        '
        'npdcantcomp
        '
        Me.npdcantcomp.DecimalPlaces = 5
        Me.npdcantcomp.Location = New System.Drawing.Point(398, 60)
        Me.npdcantcomp.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.npdcantcomp.Name = "npdcantcomp"
        Me.npdcantcomp.Size = New System.Drawing.Size(120, 20)
        Me.npdcantcomp.TabIndex = 109
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(338, 63)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 13)
        Me.Label23.TabIndex = 108
        Me.Label23.Text = "Factor :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(530, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 23)
        Me.Button1.TabIndex = 107
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtdescriproc1
        '
        Me.txtdescriproc1.Location = New System.Drawing.Point(187, 143)
        Me.txtdescriproc1.Name = "txtdescriproc1"
        Me.txtdescriproc1.ReadOnly = True
        Me.txtdescriproc1.Size = New System.Drawing.Size(337, 20)
        Me.txtdescriproc1.TabIndex = 106
        '
        'txtcodproc1
        '
        Me.txtcodproc1.Location = New System.Drawing.Point(129, 143)
        Me.txtcodproc1.MaxLength = 4
        Me.txtcodproc1.Name = "txtcodproc1"
        Me.txtcodproc1.Size = New System.Drawing.Size(52, 20)
        Me.txtcodproc1.TabIndex = 105
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Proceso :"
        '
        'cmbmedida3
        '
        Me.cmbmedida3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmedida3.FormattingEnabled = True
        Me.cmbmedida3.Items.AddRange(New Object() {"1 SI", "0 NO"})
        Me.cmbmedida3.Location = New System.Drawing.Point(386, 89)
        Me.cmbmedida3.Name = "cmbmedida3"
        Me.cmbmedida3.Size = New System.Drawing.Size(191, 21)
        Me.cmbmedida3.TabIndex = 103
        Me.cmbmedida3.Visible = False
        '
        'cmbunidadmedida1
        '
        Me.cmbunidadmedida1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbunidadmedida1.FormattingEnabled = True
        Me.cmbunidadmedida1.Location = New System.Drawing.Point(386, 116)
        Me.cmbunidadmedida1.Name = "cmbunidadmedida1"
        Me.cmbunidadmedida1.Size = New System.Drawing.Size(189, 21)
        Me.cmbunidadmedida1.TabIndex = 101
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(335, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "U/M :"
        '
        'cmbmedida4
        '
        Me.cmbmedida4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmedida4.FormattingEnabled = True
        Me.cmbmedida4.Location = New System.Drawing.Point(386, 89)
        Me.cmbmedida4.Name = "cmbmedida4"
        Me.cmbmedida4.Size = New System.Drawing.Size(191, 21)
        Me.cmbmedida4.TabIndex = 100
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(329, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Formato :"
        '
        'cmbcodalmacen1
        '
        Me.cmbcodalmacen1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcodalmacen1.FormattingEnabled = True
        Me.cmbcodalmacen1.ItemHeight = 13
        Me.cmbcodalmacen1.Location = New System.Drawing.Point(129, 116)
        Me.cmbcodalmacen1.Name = "cmbcodalmacen1"
        Me.cmbcodalmacen1.Size = New System.Drawing.Size(191, 21)
        Me.cmbcodalmacen1.TabIndex = 98
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Codigo Almacen :"
        '
        'cmbcentrocosto1
        '
        Me.cmbcentrocosto1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcentrocosto1.FormattingEnabled = True
        Me.cmbcentrocosto1.ItemHeight = 13
        Me.cmbcentrocosto1.Location = New System.Drawing.Point(129, 89)
        Me.cmbcentrocosto1.Name = "cmbcentrocosto1"
        Me.cmbcentrocosto1.Size = New System.Drawing.Size(191, 21)
        Me.cmbcentrocosto1.TabIndex = 96
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Centro Costo :"
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(273, 223)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(75, 23)
        Me.btnborrar.TabIndex = 96
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(42, 123)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 97
        Me.Label12.Text = "Req. Solm :"
        '
        'cmbreqsolm
        '
        Me.cmbreqsolm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbreqsolm.FormattingEnabled = True
        Me.cmbreqsolm.Items.AddRange(New Object() {"SI", "NO"})
        Me.cmbreqsolm.Location = New System.Drawing.Point(120, 120)
        Me.cmbreqsolm.Name = "cmbreqsolm"
        Me.cmbreqsolm.Size = New System.Drawing.Size(121, 21)
        Me.cmbreqsolm.TabIndex = 98
        '
        'FormNewArt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 255)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtdescriproc)
        Me.Controls.Add(Me.txtcodproc)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.cmbmedida)
        Me.Controls.Add(Me.cmbunidadmedida)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbmedida2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbcodalmacen)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbcentrocosto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbreqsolm)
        Me.Controls.Add(Me.Label12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormNewArt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormNewArt"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.npdcantcomp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbmedida As ComboBox
    Friend WithEvents cmbunidadmedida As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbmedida2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbcodalmacen As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbcentrocosto As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnaceptar As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtdescriproc As TextBox
    Friend WithEvents txtcodproc As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents txtdescriproc1 As TextBox
    Friend WithEvents txtcodproc1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbmedida3 As ComboBox
    Friend WithEvents cmbunidadmedida1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbmedida4 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbcodalmacen1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbcentrocosto1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbtipocomp As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents npdcantcomp As NumericUpDown
    Friend WithEvents Label23 As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbart As ComboBox
    Friend WithEvents btnborrar As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbreqsolm As ComboBox
    Friend WithEvents cmbreqsolm1 As ComboBox
    Friend WithEvents Label13 As Label
End Class
