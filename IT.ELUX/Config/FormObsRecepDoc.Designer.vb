<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormObsRecepDoc
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
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.txtobserva = New System.Windows.Forms.TextBox()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtarticulo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbobserva = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Serie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Esp. Observacion"
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(101, 18)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.ReadOnly = True
        Me.txtserie.Size = New System.Drawing.Size(100, 20)
        Me.txtserie.TabIndex = 4
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(289, 18)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.ReadOnly = True
        Me.txtnumero.Size = New System.Drawing.Size(100, 20)
        Me.txtnumero.TabIndex = 5
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(101, 44)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.ReadOnly = True
        Me.txtfecha.Size = New System.Drawing.Size(100, 20)
        Me.txtfecha.TabIndex = 6
        '
        'txtobserva
        '
        Me.txtobserva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobserva.Location = New System.Drawing.Point(101, 163)
        Me.txtobserva.Name = "txtobserva"
        Me.txtobserva.Size = New System.Drawing.Size(282, 20)
        Me.txtobserva.TabIndex = 7
        '
        'txtproveedor
        '
        Me.txtproveedor.Location = New System.Drawing.Point(101, 73)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.ReadOnly = True
        Me.txtproveedor.Size = New System.Drawing.Size(282, 20)
        Me.txtproveedor.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Proveedor"
        '
        'txtarticulo
        '
        Me.txtarticulo.Location = New System.Drawing.Point(101, 99)
        Me.txtarticulo.Name = "txtarticulo"
        Me.txtarticulo.ReadOnly = True
        Me.txtarticulo.Size = New System.Drawing.Size(282, 20)
        Me.txtarticulo.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Articulo"
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(106, 208)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 12
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(244, 208)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 13
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(353, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Label7"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Observacion"
        '
        'cmbobserva
        '
        Me.cmbobserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbobserva.FormattingEnabled = True
        Me.cmbobserva.Items.AddRange(New Object() {"LA ORDEN NO TIENE FIRMA", "EL DOCUMENTO ES UNA COPIA", "NO TIENE GUIA DE REMISION", "RUC ERRONEO", "NUMERO DE FACTURA ERRONEO", "NUMERO DE ORDEN DE COMPRA ERRONEO", "FALTAN ARTICULOS", "NUMERO DE GUIA ERRONEO", "OTROS - ESPECIFICAR"})
        Me.cmbobserva.Location = New System.Drawing.Point(101, 133)
        Me.cmbobserva.Name = "cmbobserva"
        Me.cmbobserva.Size = New System.Drawing.Size(282, 21)
        Me.cmbobserva.TabIndex = 16
        '
        'FormObsRecepDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 260)
        Me.Controls.Add(Me.cmbobserva)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.txtarticulo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtproveedor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtobserva)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.txtserie)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormObsRecepDoc"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormObsRecepDoc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtserie As TextBox
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents txtobserva As TextBox
    Friend WithEvents txtproveedor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtarticulo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbobserva As ComboBox
End Class
