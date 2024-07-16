<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMantELTBCLIENTE_dir
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
        Me.btncancelardir = New System.Windows.Forms.Button()
        Me.btnaceptardir = New System.Windows.Forms.Button()
        Me.btn_ubigeo = New System.Windows.Forms.Button()
        Me.lblsdas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdirdir = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkcontadir = New System.Windows.Forms.CheckBox()
        Me.lblseqdir = New System.Windows.Forms.TextBox()
        Me.lblubigeodir = New System.Windows.Forms.TextBox()
        Me.lbldistritodir = New System.Windows.Forms.TextBox()
        Me.lblprovinciadir = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btncancelardir
        '
        Me.btncancelardir.Location = New System.Drawing.Point(288, 98)
        Me.btncancelardir.Name = "btncancelardir"
        Me.btncancelardir.Size = New System.Drawing.Size(81, 23)
        Me.btncancelardir.TabIndex = 4
        Me.btncancelardir.Text = "Cancelar"
        Me.btncancelardir.UseVisualStyleBackColor = True
        '
        'btnaceptardir
        '
        Me.btnaceptardir.Location = New System.Drawing.Point(174, 98)
        Me.btnaceptardir.Name = "btnaceptardir"
        Me.btnaceptardir.Size = New System.Drawing.Size(81, 23)
        Me.btnaceptardir.TabIndex = 3
        Me.btnaceptardir.Text = "Aceptar"
        Me.btnaceptardir.UseVisualStyleBackColor = True
        '
        'btn_ubigeo
        '
        Me.btn_ubigeo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ubigeo.Location = New System.Drawing.Point(412, 63)
        Me.btn_ubigeo.Name = "btn_ubigeo"
        Me.btn_ubigeo.Size = New System.Drawing.Size(46, 22)
        Me.btn_ubigeo.TabIndex = 2
        Me.btn_ubigeo.Text = "..."
        Me.btn_ubigeo.UseVisualStyleBackColor = True
        '
        'lblsdas
        '
        Me.lblsdas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsdas.Location = New System.Drawing.Point(13, 64)
        Me.lblsdas.Name = "lblsdas"
        Me.lblsdas.Size = New System.Drawing.Size(59, 23)
        Me.lblsdas.TabIndex = 63
        Me.lblsdas.Text = "Ubigeo"
        Me.lblsdas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 23)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Direccion"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdirdir
        '
        Me.txtdirdir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdirdir.Location = New System.Drawing.Point(83, 35)
        Me.txtdirdir.MaxLength = 100
        Me.txtdirdir.Name = "txtdirdir"
        Me.txtdirdir.Size = New System.Drawing.Size(376, 20)
        Me.txtdirdir.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Codigo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkcontadir
        '
        Me.chkcontadir.AutoSize = True
        Me.chkcontadir.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkcontadir.Location = New System.Drawing.Point(12, 98)
        Me.chkcontadir.Name = "chkcontadir"
        Me.chkcontadir.Size = New System.Drawing.Size(84, 17)
        Me.chkcontadir.TabIndex = 72
        Me.chkcontadir.Text = "Contabilidad"
        Me.chkcontadir.UseVisualStyleBackColor = True
        Me.chkcontadir.Visible = False
        '
        'lblseqdir
        '
        Me.lblseqdir.BackColor = System.Drawing.Color.Gainsboro
        Me.lblseqdir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblseqdir.Location = New System.Drawing.Point(83, 9)
        Me.lblseqdir.Name = "lblseqdir"
        Me.lblseqdir.ReadOnly = True
        Me.lblseqdir.Size = New System.Drawing.Size(61, 20)
        Me.lblseqdir.TabIndex = 193
        '
        'lblubigeodir
        '
        Me.lblubigeodir.BackColor = System.Drawing.SystemColors.Window
        Me.lblubigeodir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblubigeodir.Location = New System.Drawing.Point(83, 64)
        Me.lblubigeodir.MaxLength = 8
        Me.lblubigeodir.Name = "lblubigeodir"
        Me.lblubigeodir.Size = New System.Drawing.Size(61, 20)
        Me.lblubigeodir.TabIndex = 194
        '
        'lbldistritodir
        '
        Me.lbldistritodir.BackColor = System.Drawing.Color.Gainsboro
        Me.lbldistritodir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldistritodir.Location = New System.Drawing.Point(145, 64)
        Me.lbldistritodir.Name = "lbldistritodir"
        Me.lbldistritodir.ReadOnly = True
        Me.lbldistritodir.Size = New System.Drawing.Size(133, 20)
        Me.lbldistritodir.TabIndex = 195
        '
        'lblprovinciadir
        '
        Me.lblprovinciadir.BackColor = System.Drawing.Color.Gainsboro
        Me.lblprovinciadir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblprovinciadir.Location = New System.Drawing.Point(279, 64)
        Me.lblprovinciadir.Name = "lblprovinciadir"
        Me.lblprovinciadir.ReadOnly = True
        Me.lblprovinciadir.Size = New System.Drawing.Size(133, 20)
        Me.lblprovinciadir.TabIndex = 196
        '
        'FormMantELTBCLIENTE_dir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 132)
        Me.Controls.Add(Me.lblprovinciadir)
        Me.Controls.Add(Me.lbldistritodir)
        Me.Controls.Add(Me.lblubigeodir)
        Me.Controls.Add(Me.lblseqdir)
        Me.Controls.Add(Me.chkcontadir)
        Me.Controls.Add(Me.btncancelardir)
        Me.Controls.Add(Me.btnaceptardir)
        Me.Controls.Add(Me.btn_ubigeo)
        Me.Controls.Add(Me.lblsdas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdirdir)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormMantELTBCLIENTE_dir"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Direccion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncancelardir As Button
    Friend WithEvents btnaceptardir As Button
    Friend WithEvents btn_ubigeo As Button
    Friend WithEvents lblsdas As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdirdir As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkcontadir As CheckBox
    Friend WithEvents lblseqdir As TextBox
    Friend WithEvents lblubigeodir As TextBox
    Friend WithEvents lbldistritodir As TextBox
    Friend WithEvents lblprovinciadir As TextBox
End Class
