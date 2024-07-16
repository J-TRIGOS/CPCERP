<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDirDep
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
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnro_dpto = New System.Windows.Forms.TextBox()
        Me.txtnro_via = New System.Windows.Forms.TextBox()
        Me.txtnom_via = New System.Windows.Forms.TextBox()
        Me.txttip_via_cod = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtint_via = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtmza_via = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtlote_via = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtkilom_via = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtblock_via = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtetapa_via = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txttip_zona_cod = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtnom_zona = New System.Windows.Forms.TextBox()
        Me.txtref_zona = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtubigeo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtcod
        '
        Me.txtcod.Location = New System.Drawing.Point(109, 22)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.ReadOnly = True
        Me.txtcod.Size = New System.Drawing.Size(57, 20)
        Me.txtcod.TabIndex = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Codigo"
        '
        'txtnro_dpto
        '
        Me.txtnro_dpto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnro_dpto.Location = New System.Drawing.Point(109, 100)
        Me.txtnro_dpto.Name = "txtnro_dpto"
        Me.txtnro_dpto.Size = New System.Drawing.Size(185, 20)
        Me.txtnro_dpto.TabIndex = 4
        '
        'txtnro_via
        '
        Me.txtnro_via.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnro_via.Location = New System.Drawing.Point(109, 74)
        Me.txtnro_via.Name = "txtnro_via"
        Me.txtnro_via.Size = New System.Drawing.Size(185, 20)
        Me.txtnro_via.TabIndex = 3
        '
        'txtnom_via
        '
        Me.txtnom_via.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnom_via.Location = New System.Drawing.Point(155, 48)
        Me.txtnom_via.Name = "txtnom_via"
        Me.txtnom_via.ReadOnly = True
        Me.txtnom_via.Size = New System.Drawing.Size(139, 20)
        Me.txtnom_via.TabIndex = 2
        '
        'txttip_via_cod
        '
        Me.txttip_via_cod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttip_via_cod.Location = New System.Drawing.Point(109, 48)
        Me.txttip_via_cod.Name = "txttip_via_cod"
        Me.txttip_via_cod.Size = New System.Drawing.Size(40, 20)
        Me.txttip_via_cod.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Nro. Dpto."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Nro. Via"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Via"
        '
        'txtint_via
        '
        Me.txtint_via.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtint_via.Location = New System.Drawing.Point(109, 126)
        Me.txtint_via.Name = "txtint_via"
        Me.txtint_via.Size = New System.Drawing.Size(185, 20)
        Me.txtint_via.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Int Via"
        '
        'txtmza_via
        '
        Me.txtmza_via.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmza_via.Location = New System.Drawing.Point(109, 152)
        Me.txtmza_via.Name = "txtmza_via"
        Me.txtmza_via.Size = New System.Drawing.Size(185, 20)
        Me.txtmza_via.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Mza. Via"
        '
        'txtlote_via
        '
        Me.txtlote_via.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlote_via.Location = New System.Drawing.Point(109, 178)
        Me.txtlote_via.Name = "txtlote_via"
        Me.txtlote_via.Size = New System.Drawing.Size(185, 20)
        Me.txtlote_via.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Lote. Via"
        '
        'txtkilom_via
        '
        Me.txtkilom_via.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtkilom_via.Location = New System.Drawing.Point(109, 204)
        Me.txtkilom_via.Name = "txtkilom_via"
        Me.txtkilom_via.Size = New System.Drawing.Size(185, 20)
        Me.txtkilom_via.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Kilom. Via"
        '
        'txtblock_via
        '
        Me.txtblock_via.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtblock_via.Location = New System.Drawing.Point(109, 230)
        Me.txtblock_via.Name = "txtblock_via"
        Me.txtblock_via.Size = New System.Drawing.Size(185, 20)
        Me.txtblock_via.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(44, 233)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Bloq. Via"
        '
        'txtetapa_via
        '
        Me.txtetapa_via.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtetapa_via.Location = New System.Drawing.Point(109, 256)
        Me.txtetapa_via.Name = "txtetapa_via"
        Me.txtetapa_via.Size = New System.Drawing.Size(185, 20)
        Me.txtetapa_via.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(40, 259)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Etapa Via"
        '
        'txttip_zona_cod
        '
        Me.txttip_zona_cod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttip_zona_cod.Location = New System.Drawing.Point(109, 282)
        Me.txttip_zona_cod.Name = "txttip_zona_cod"
        Me.txttip_zona_cod.Size = New System.Drawing.Size(40, 20)
        Me.txttip_zona_cod.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 285)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Tip. Zona Cod."
        '
        'txtnom_zona
        '
        Me.txtnom_zona.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnom_zona.Location = New System.Drawing.Point(155, 282)
        Me.txtnom_zona.Name = "txtnom_zona"
        Me.txtnom_zona.ReadOnly = True
        Me.txtnom_zona.Size = New System.Drawing.Size(139, 20)
        Me.txtnom_zona.TabIndex = 12
        '
        'txtref_zona
        '
        Me.txtref_zona.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtref_zona.Location = New System.Drawing.Point(109, 308)
        Me.txtref_zona.Name = "txtref_zona"
        Me.txtref_zona.Size = New System.Drawing.Size(185, 20)
        Me.txtref_zona.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Ref. Zona"
        '
        'txtubigeo
        '
        Me.txtubigeo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtubigeo.Location = New System.Drawing.Point(109, 334)
        Me.txtubigeo.Name = "txtubigeo"
        Me.txtubigeo.Size = New System.Drawing.Size(185, 20)
        Me.txtubigeo.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(40, 337)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Ubigeo"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(171, 369)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 40)
        Me.btnsalir.TabIndex = 16
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(74, 369)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 40)
        Me.btnagregar.TabIndex = 15
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'FormDirDep
        '
        Me.AcceptButton = Me.btnagregar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 423)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.txtubigeo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtref_zona)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnom_zona)
        Me.Controls.Add(Me.txttip_zona_cod)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtetapa_via)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtblock_via)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtkilom_via)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtlote_via)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtmza_via)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtint_via)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnro_dpto)
        Me.Controls.Add(Me.txtnro_via)
        Me.Controls.Add(Me.txtnom_via)
        Me.Controls.Add(Me.txttip_via_cod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormDirDep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDirDep"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnro_dpto As TextBox
    Friend WithEvents txtnro_via As TextBox
    Friend WithEvents txtnom_via As TextBox
    Friend WithEvents txttip_via_cod As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtint_via As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtmza_via As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtlote_via As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtkilom_via As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtblock_via As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtetapa_via As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txttip_zona_cod As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtnom_zona As TextBox
    Friend WithEvents txtref_zona As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtubigeo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnagregar As Button
End Class
