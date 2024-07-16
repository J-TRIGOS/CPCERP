<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMantDetFCRecepComp
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbt_doc = New System.Windows.Forms.ComboBox()
        Me.cmbser_doc_ref1 = New System.Windows.Forms.ComboBox()
        Me.npdcantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtnro_doc_ref1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnom_proveedor = New System.Windows.Forms.TextBox()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpfec_gene = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnom_art = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnro_docu1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnro_docu = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtser_docu1 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtser_docu = New System.Windows.Forms.TextBox()
        Me.txtcodart = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnregresar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.npdcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cmbt_doc)
        Me.GroupBox1.Controls.Add(Me.cmbser_doc_ref1)
        Me.GroupBox1.Controls.Add(Me.npdcantidad)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtnro_doc_ref1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtnom_proveedor)
        Me.GroupBox1.Controls.Add(Me.txtproveedor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpfec_gene)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtnom_art)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtnro_docu1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtnro_docu)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtser_docu1)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtser_docu)
        Me.GroupBox1.Controls.Add(Me.txtcodart)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(579, 221)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(156, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 13)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Tipo"
        '
        'cmbt_doc
        '
        Me.cmbt_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbt_doc.FormattingEnabled = True
        Me.cmbt_doc.Items.AddRange(New Object() {"FACTURA", "BOLETA", "NOTA DE CREDITO", "NOTA DE DEBITO"})
        Me.cmbt_doc.Location = New System.Drawing.Point(83, 28)
        Me.cmbt_doc.Name = "cmbt_doc"
        Me.cmbt_doc.Size = New System.Drawing.Size(196, 21)
        Me.cmbt_doc.TabIndex = 92
        '
        'cmbser_doc_ref1
        '
        Me.cmbser_doc_ref1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbser_doc_ref1.FormattingEnabled = True
        Me.cmbser_doc_ref1.Items.AddRange(New Object() {"001", "002", "003", "004"})
        Me.cmbser_doc_ref1.Location = New System.Drawing.Point(83, 112)
        Me.cmbser_doc_ref1.Name = "cmbser_doc_ref1"
        Me.cmbser_doc_ref1.Size = New System.Drawing.Size(88, 21)
        Me.cmbser_doc_ref1.TabIndex = 5
        '
        'npdcantidad
        '
        Me.npdcantidad.DecimalPlaces = 3
        Me.npdcantidad.Location = New System.Drawing.Point(70, 195)
        Me.npdcantidad.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.npdcantidad.Name = "npdcantidad"
        Me.npdcantidad.Size = New System.Drawing.Size(120, 20)
        Me.npdcantidad.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 197)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "Cantidad :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(211, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Numero"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(112, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "Serie"
        '
        'txtnro_doc_ref1
        '
        Me.txtnro_doc_ref1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnro_doc_ref1.Location = New System.Drawing.Point(177, 113)
        Me.txtnro_doc_ref1.MaxLength = 7
        Me.txtnro_doc_ref1.Name = "txtnro_doc_ref1"
        Me.txtnro_doc_ref1.ReadOnly = True
        Me.txtnro_doc_ref1.Size = New System.Drawing.Size(120, 20)
        Me.txtnro_doc_ref1.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(-1, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "Orden Compra :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(546, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "F9"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(546, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "F9"
        '
        'txtnom_proveedor
        '
        Me.txtnom_proveedor.Location = New System.Drawing.Point(159, 139)
        Me.txtnom_proveedor.Name = "txtnom_proveedor"
        Me.txtnom_proveedor.ReadOnly = True
        Me.txtnom_proveedor.Size = New System.Drawing.Size(378, 20)
        Me.txtnom_proveedor.TabIndex = 9
        '
        'txtproveedor
        '
        Me.txtproveedor.Location = New System.Drawing.Point(69, 139)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(84, 20)
        Me.txtproveedor.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Proveedor :"
        '
        'dtpfec_gene
        '
        Me.dtpfec_gene.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_gene.Location = New System.Drawing.Point(303, 113)
        Me.dtpfec_gene.Name = "dtpfec_gene"
        Me.dtpfec_gene.Size = New System.Drawing.Size(84, 20)
        Me.dtpfec_gene.TabIndex = 7
        Me.dtpfec_gene.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(301, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Fecha Llegada :"
        Me.Label2.Visible = False
        '
        'txtnom_art
        '
        Me.txtnom_art.Location = New System.Drawing.Point(159, 165)
        Me.txtnom_art.Name = "txtnom_art"
        Me.txtnom_art.ReadOnly = True
        Me.txtnom_art.Size = New System.Drawing.Size(378, 20)
        Me.txtnom_art.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(194, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Numero"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(95, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Serie"
        '
        'txtnro_docu1
        '
        Me.txtnro_docu1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnro_docu1.Location = New System.Drawing.Point(159, 74)
        Me.txtnro_docu1.MaxLength = 15
        Me.txtnro_docu1.Name = "txtnro_docu1"
        Me.txtnro_docu1.Size = New System.Drawing.Size(120, 20)
        Me.txtnro_docu1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(408, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Numero"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(309, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Serie"
        '
        'txtnro_docu
        '
        Me.txtnro_docu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnro_docu.Location = New System.Drawing.Point(374, 28)
        Me.txtnro_docu.MaxLength = 15
        Me.txtnro_docu.Name = "txtnro_docu"
        Me.txtnro_docu.Size = New System.Drawing.Size(120, 20)
        Me.txtnro_docu.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(25, 77)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 13)
        Me.Label21.TabIndex = 71
        Me.Label21.Text = "Guia"
        '
        'txtser_docu1
        '
        Me.txtser_docu1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtser_docu1.Location = New System.Drawing.Point(60, 74)
        Me.txtser_docu1.MaxLength = 7
        Me.txtser_docu1.Name = "txtser_docu1"
        Me.txtser_docu1.Size = New System.Drawing.Size(93, 20)
        Me.txtser_docu1.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(-3, 35)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 13)
        Me.Label20.TabIndex = 69
        Me.Label20.Text = "Documento :"
        '
        'txtser_docu
        '
        Me.txtser_docu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtser_docu.Location = New System.Drawing.Point(287, 28)
        Me.txtser_docu.MaxLength = 7
        Me.txtser_docu.Name = "txtser_docu"
        Me.txtser_docu.Size = New System.Drawing.Size(81, 20)
        Me.txtser_docu.TabIndex = 1
        '
        'txtcodart
        '
        Me.txtcodart.Location = New System.Drawing.Point(69, 165)
        Me.txtcodart.Name = "txtcodart"
        Me.txtcodart.Size = New System.Drawing.Size(84, 20)
        Me.txtcodart.TabIndex = 10
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(17, 168)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 13)
        Me.Label22.TabIndex = 63
        Me.Label22.Text = "Articulo :"
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(412, 239)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 13
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnregresar
        '
        Me.btnregresar.Location = New System.Drawing.Point(502, 239)
        Me.btnregresar.Name = "btnregresar"
        Me.btnregresar.Size = New System.Drawing.Size(75, 23)
        Me.btnregresar.TabIndex = 14
        Me.btnregresar.Text = "Salir"
        Me.btnregresar.UseVisualStyleBackColor = True
        '
        'FormMantDetFCRecepComp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 274)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.btnregresar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormMantDetFCRecepComp"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMantDetFCRecepComp"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.npdcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtnro_docu1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnro_docu As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtser_docu1 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtser_docu As TextBox
    Friend WithEvents txtcodart As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtnom_art As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpfec_gene As DateTimePicker
    Friend WithEvents txtnom_proveedor As TextBox
    Friend WithEvents txtproveedor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnregresar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtnro_doc_ref1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents npdcantidad As NumericUpDown
    Friend WithEvents cmbser_doc_ref1 As ComboBox
    Friend WithEvents cmbt_doc As ComboBox
    Friend WithEvents Label13 As Label
End Class
