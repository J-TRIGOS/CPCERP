<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetRecepComp
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
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnduplicar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnumero1 = New System.Windows.Forms.TextBox()
        Me.txtserie1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbt_doc = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(106, 67)
        Me.txtnumero.MaxLength = 8
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(100, 20)
        Me.txtnumero.TabIndex = 14
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(106, 41)
        Me.txtserie.MaxLength = 4
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(100, 20)
        Me.txtserie.TabIndex = 13
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(124, 145)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(90, 35)
        Me.btnsalir.TabIndex = 12
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnduplicar
        '
        Me.btnduplicar.Location = New System.Drawing.Point(28, 145)
        Me.btnduplicar.Name = "btnduplicar"
        Me.btnduplicar.Size = New System.Drawing.Size(90, 35)
        Me.btnduplicar.TabIndex = 11
        Me.btnduplicar.Text = "Duplicar"
        Me.btnduplicar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Numero Factura"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Serie Factura"
        '
        'txtnumero1
        '
        Me.txtnumero1.Location = New System.Drawing.Point(106, 119)
        Me.txtnumero1.MaxLength = 8
        Me.txtnumero1.Name = "txtnumero1"
        Me.txtnumero1.Size = New System.Drawing.Size(100, 20)
        Me.txtnumero1.TabIndex = 19
        '
        'txtserie1
        '
        Me.txtserie1.Location = New System.Drawing.Point(106, 93)
        Me.txtserie1.MaxLength = 4
        Me.txtserie1.Name = "txtserie1"
        Me.txtserie1.Size = New System.Drawing.Size(100, 20)
        Me.txtserie1.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Numero Guia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Serie Guia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Tipo Factura"
        '
        'cmbt_doc
        '
        Me.cmbt_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbt_doc.FormattingEnabled = True
        Me.cmbt_doc.Items.AddRange(New Object() {"FACTURA", "BOLETA", "NOTA DE CREDITO", "NOTA DE DEBITO"})
        Me.cmbt_doc.Location = New System.Drawing.Point(106, 12)
        Me.cmbt_doc.Name = "cmbt_doc"
        Me.cmbt_doc.Size = New System.Drawing.Size(133, 21)
        Me.cmbt_doc.TabIndex = 93
        '
        'FormDetRecepComp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 192)
        Me.Controls.Add(Me.cmbt_doc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnumero1)
        Me.Controls.Add(Me.txtserie1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.txtserie)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnduplicar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormDetRecepComp"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDetRecepComp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents txtserie As TextBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnduplicar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnumero1 As TextBox
    Friend WithEvents txtserie1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbt_doc As ComboBox
End Class
