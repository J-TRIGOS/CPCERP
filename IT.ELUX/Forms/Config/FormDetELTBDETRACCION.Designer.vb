<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetELTBDETRACCION
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
        Me.txtt_doc = New System.Windows.Forms.TextBox()
        Me.txtser_doc = New System.Windows.Forms.TextBox()
        Me.txtnro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtctct = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnomctct = New System.Windows.Forms.TextBox()
        Me.npdporc = New System.Windows.Forms.NumericUpDown()
        Me.txtpago = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnomope = New System.Windows.Forms.TextBox()
        Me.txtnomserv = New System.Windows.Forms.TextBox()
        Me.txtt_ope = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtserv = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcta = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnregresar = New System.Windows.Forms.Button()
        CType(Me.npdporc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtt_doc
        '
        Me.txtt_doc.Location = New System.Drawing.Point(71, 31)
        Me.txtt_doc.Name = "txtt_doc"
        Me.txtt_doc.ReadOnly = True
        Me.txtt_doc.Size = New System.Drawing.Size(80, 20)
        Me.txtt_doc.TabIndex = 20
        '
        'txtser_doc
        '
        Me.txtser_doc.Location = New System.Drawing.Point(206, 31)
        Me.txtser_doc.Name = "txtser_doc"
        Me.txtser_doc.ReadOnly = True
        Me.txtser_doc.Size = New System.Drawing.Size(100, 20)
        Me.txtser_doc.TabIndex = 21
        '
        'txtnro
        '
        Me.txtnro.Location = New System.Drawing.Point(385, 31)
        Me.txtnro.Name = "txtnro"
        Me.txtnro.ReadOnly = True
        Me.txtnro.Size = New System.Drawing.Size(100, 20)
        Me.txtnro.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Serie"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(335, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Numero"
        '
        'txtctct
        '
        Me.txtctct.Location = New System.Drawing.Point(71, 68)
        Me.txtctct.Name = "txtctct"
        Me.txtctct.Size = New System.Drawing.Size(80, 20)
        Me.txtctct.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cliente"
        '
        'txtnomctct
        '
        Me.txtnomctct.Location = New System.Drawing.Point(157, 68)
        Me.txtnomctct.Name = "txtnomctct"
        Me.txtnomctct.ReadOnly = True
        Me.txtnomctct.Size = New System.Drawing.Size(321, 20)
        Me.txtnomctct.TabIndex = 2
        '
        'npdporc
        '
        Me.npdporc.DecimalPlaces = 3
        Me.npdporc.Location = New System.Drawing.Point(401, 103)
        Me.npdporc.Name = "npdporc"
        Me.npdporc.Size = New System.Drawing.Size(84, 20)
        Me.npdporc.TabIndex = 6
        '
        'txtpago
        '
        Me.txtpago.Location = New System.Drawing.Point(401, 155)
        Me.txtpago.Name = "txtpago"
        Me.txtpago.ReadOnly = True
        Me.txtpago.Size = New System.Drawing.Size(84, 20)
        Me.txtpago.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(337, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Pago"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(401, 129)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(84, 20)
        Me.txttotal.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(337, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(337, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Porcentaje"
        '
        'txtnomope
        '
        Me.txtnomope.Location = New System.Drawing.Point(157, 155)
        Me.txtnomope.Name = "txtnomope"
        Me.txtnomope.ReadOnly = True
        Me.txtnomope.Size = New System.Drawing.Size(171, 20)
        Me.txtnomope.TabIndex = 25
        '
        'txtnomserv
        '
        Me.txtnomserv.Location = New System.Drawing.Point(157, 129)
        Me.txtnomserv.Name = "txtnomserv"
        Me.txtnomserv.ReadOnly = True
        Me.txtnomserv.Size = New System.Drawing.Size(171, 20)
        Me.txtnomserv.TabIndex = 23
        '
        'txtt_ope
        '
        Me.txtt_ope.Location = New System.Drawing.Point(102, 155)
        Me.txtt_ope.MaxLength = 2
        Me.txtt_ope.Name = "txtt_ope"
        Me.txtt_ope.Size = New System.Drawing.Size(49, 20)
        Me.txtt_ope.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Tip. Operacion"
        '
        'txtserv
        '
        Me.txtserv.Location = New System.Drawing.Point(102, 129)
        Me.txtserv.MaxLength = 3
        Me.txtserv.Name = "txtserv"
        Me.txtserv.Size = New System.Drawing.Size(49, 20)
        Me.txtserv.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Servicio"
        '
        'txtcta
        '
        Me.txtcta.Location = New System.Drawing.Point(102, 103)
        Me.txtcta.Name = "txtcta"
        Me.txtcta.Size = New System.Drawing.Size(84, 20)
        Me.txtcta.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Cuenta"
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(341, 197)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 9
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnregresar
        '
        Me.btnregresar.Location = New System.Drawing.Point(422, 197)
        Me.btnregresar.Name = "btnregresar"
        Me.btnregresar.Size = New System.Drawing.Size(75, 23)
        Me.btnregresar.TabIndex = 10
        Me.btnregresar.Text = "Salir"
        Me.btnregresar.UseVisualStyleBackColor = True
        '
        'FormDetELTBDETRACCION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 232)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.btnregresar)
        Me.Controls.Add(Me.txtnomope)
        Me.Controls.Add(Me.txtnomserv)
        Me.Controls.Add(Me.txtt_ope)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtserv)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtcta)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.npdporc)
        Me.Controls.Add(Me.txtpago)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnomctct)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtctct)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnro)
        Me.Controls.Add(Me.txtser_doc)
        Me.Controls.Add(Me.txtt_doc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormDetELTBDETRACCION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDetELTBDETRACCION"
        CType(Me.npdporc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtt_doc As TextBox
    Friend WithEvents txtser_doc As TextBox
    Friend WithEvents txtnro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtctct As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnomctct As TextBox
    Friend WithEvents npdporc As NumericUpDown
    Friend WithEvents txtpago As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtnomope As TextBox
    Friend WithEvents txtnomserv As TextBox
    Friend WithEvents txtt_ope As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtserv As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtcta As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnregresar As Button
End Class
