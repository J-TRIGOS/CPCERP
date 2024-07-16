<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMantELTBPROVEEDORES_dir
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
        Me.chkcontadir = New System.Windows.Forms.CheckBox()
        Me.lblprovinciadir = New System.Windows.Forms.Label()
        Me.lbldistritodir = New System.Windows.Forms.Label()
        Me.lblseqdir = New System.Windows.Forms.Label()
        Me.btncancelardir = New System.Windows.Forms.Button()
        Me.btnaceptardir = New System.Windows.Forms.Button()
        Me.btn_ubigeo = New System.Windows.Forms.Button()
        Me.lblsdas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdirdir = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblubigeodir = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'chkcontadir
        '
        Me.chkcontadir.AutoSize = True
        Me.chkcontadir.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkcontadir.Location = New System.Drawing.Point(11, 98)
        Me.chkcontadir.Name = "chkcontadir"
        Me.chkcontadir.Size = New System.Drawing.Size(84, 17)
        Me.chkcontadir.TabIndex = 84
        Me.chkcontadir.Text = "Contabilidad"
        Me.chkcontadir.UseVisualStyleBackColor = True
        '
        'lblprovinciadir
        '
        Me.lblprovinciadir.BackColor = System.Drawing.Color.Gainsboro
        Me.lblprovinciadir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblprovinciadir.Location = New System.Drawing.Point(278, 64)
        Me.lblprovinciadir.Name = "lblprovinciadir"
        Me.lblprovinciadir.Size = New System.Drawing.Size(133, 20)
        Me.lblprovinciadir.TabIndex = 83
        Me.lblprovinciadir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbldistritodir
        '
        Me.lbldistritodir.BackColor = System.Drawing.Color.Gainsboro
        Me.lbldistritodir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldistritodir.Location = New System.Drawing.Point(144, 64)
        Me.lbldistritodir.Name = "lbldistritodir"
        Me.lbldistritodir.Size = New System.Drawing.Size(133, 20)
        Me.lbldistritodir.TabIndex = 82
        Me.lbldistritodir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblseqdir
        '
        Me.lblseqdir.BackColor = System.Drawing.Color.Gainsboro
        Me.lblseqdir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblseqdir.Location = New System.Drawing.Point(82, 9)
        Me.lblseqdir.Name = "lblseqdir"
        Me.lblseqdir.Size = New System.Drawing.Size(37, 20)
        Me.lblseqdir.TabIndex = 80
        Me.lblseqdir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btncancelardir
        '
        Me.btncancelardir.Location = New System.Drawing.Point(301, 131)
        Me.btncancelardir.Name = "btncancelardir"
        Me.btncancelardir.Size = New System.Drawing.Size(81, 23)
        Me.btncancelardir.TabIndex = 76
        Me.btncancelardir.Text = "Cancelar"
        Me.btncancelardir.UseVisualStyleBackColor = True
        '
        'btnaceptardir
        '
        Me.btnaceptardir.Location = New System.Drawing.Point(187, 131)
        Me.btnaceptardir.Name = "btnaceptardir"
        Me.btnaceptardir.Size = New System.Drawing.Size(81, 23)
        Me.btnaceptardir.TabIndex = 75
        Me.btnaceptardir.Text = "Aceptar"
        Me.btnaceptardir.UseVisualStyleBackColor = True
        '
        'btn_ubigeo
        '
        Me.btn_ubigeo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ubigeo.Location = New System.Drawing.Point(411, 63)
        Me.btn_ubigeo.Name = "btn_ubigeo"
        Me.btn_ubigeo.Size = New System.Drawing.Size(46, 22)
        Me.btn_ubigeo.TabIndex = 74
        Me.btn_ubigeo.Text = "..."
        Me.btn_ubigeo.UseVisualStyleBackColor = True
        '
        'lblsdas
        '
        Me.lblsdas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsdas.Location = New System.Drawing.Point(12, 64)
        Me.lblsdas.Name = "lblsdas"
        Me.lblsdas.Size = New System.Drawing.Size(59, 23)
        Me.lblsdas.TabIndex = 79
        Me.lblsdas.Text = "Ubigeo"
        Me.lblsdas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 23)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Direccion"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdirdir
        '
        Me.txtdirdir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdirdir.Location = New System.Drawing.Point(82, 35)
        Me.txtdirdir.MaxLength = 100
        Me.txtdirdir.Name = "txtdirdir"
        Me.txtdirdir.Size = New System.Drawing.Size(376, 20)
        Me.txtdirdir.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Codigo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblubigeodir
        '
        Me.lblubigeodir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lblubigeodir.Location = New System.Drawing.Point(82, 64)
        Me.lblubigeodir.MaxLength = 100
        Me.lblubigeodir.Name = "lblubigeodir"
        Me.lblubigeodir.Size = New System.Drawing.Size(61, 20)
        Me.lblubigeodir.TabIndex = 85
        '
        'FormMantELTBPROVEEDORES_dir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 166)
        Me.Controls.Add(Me.lblubigeodir)
        Me.Controls.Add(Me.chkcontadir)
        Me.Controls.Add(Me.lblprovinciadir)
        Me.Controls.Add(Me.lbldistritodir)
        Me.Controls.Add(Me.lblseqdir)
        Me.Controls.Add(Me.btncancelardir)
        Me.Controls.Add(Me.btnaceptardir)
        Me.Controls.Add(Me.btn_ubigeo)
        Me.Controls.Add(Me.lblsdas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdirdir)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormMantELTBPROVEEDORES_dir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Direccion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkcontadir As CheckBox
    Friend WithEvents lblprovinciadir As Label
    Friend WithEvents lbldistritodir As Label
    Friend WithEvents lblseqdir As Label
    Friend WithEvents btncancelardir As Button
    Friend WithEvents btnaceptardir As Button
    Friend WithEvents btn_ubigeo As Button
    Friend WithEvents lblsdas As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdirdir As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblubigeodir As TextBox
End Class
