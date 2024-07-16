<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCptoPer
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
        Me.npdmonto = New System.Windows.Forms.NumericUpDown()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txtnomcpto = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txtcpto_cod = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        CType(Me.npdmonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'npdmonto
        '
        Me.npdmonto.DecimalPlaces = 2
        Me.npdmonto.Location = New System.Drawing.Point(79, 102)
        Me.npdmonto.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npdmonto.Name = "npdmonto"
        Me.npdmonto.Size = New System.Drawing.Size(120, 20)
        Me.npdmonto.TabIndex = 2
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(20, 104)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(37, 13)
        Me.Label55.TabIndex = 7
        Me.Label55.Text = "Monto"
        '
        'txtnomcpto
        '
        Me.txtnomcpto.Location = New System.Drawing.Point(148, 76)
        Me.txtnomcpto.Name = "txtnomcpto"
        Me.txtnomcpto.ReadOnly = True
        Me.txtnomcpto.Size = New System.Drawing.Size(260, 20)
        Me.txtnomcpto.TabIndex = 13
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(20, 79)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(53, 13)
        Me.Label54.TabIndex = 5
        Me.Label54.Text = "Concepto"
        '
        'txtcpto_cod
        '
        Me.txtcpto_cod.Location = New System.Drawing.Point(79, 76)
        Me.txtcpto_cod.Name = "txtcpto_cod"
        Me.txtcpto_cod.Size = New System.Drawing.Size(63, 20)
        Me.txtcpto_cod.TabIndex = 1
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(20, 53)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(44, 13)
        Me.Label53.TabIndex = 3
        Me.Label53.Text = "Nombre"
        '
        'txtnom
        '
        Me.txtnom.Location = New System.Drawing.Point(79, 50)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.ReadOnly = True
        Me.txtnom.Size = New System.Drawing.Size(329, 20)
        Me.txtnom.TabIndex = 11
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(20, 27)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(26, 13)
        Me.Label52.TabIndex = 1
        Me.Label52.Text = "DNI"
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(79, 24)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.ReadOnly = True
        Me.txtdni.Size = New System.Drawing.Size(120, 20)
        Me.txtdni.TabIndex = 10
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(218, 128)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 40)
        Me.btnsalir.TabIndex = 36
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(137, 128)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 40)
        Me.btnagregar.TabIndex = 3
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'FormCptoPer
        '
        Me.AcceptButton = Me.btnagregar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 180)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.txtnomcpto)
        Me.Controls.Add(Me.txtnom)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.txtcpto_cod)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.npdmonto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormCptoPer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCptoPer"
        CType(Me.npdmonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents npdmonto As NumericUpDown
    Friend WithEvents Label55 As Label
    Friend WithEvents txtnomcpto As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents txtcpto_cod As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents txtnom As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents txtdni As TextBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnagregar As Button
End Class
