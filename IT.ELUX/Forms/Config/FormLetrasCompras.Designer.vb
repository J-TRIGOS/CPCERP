<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLetrasCompras
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvt_doc = New System.Windows.Forms.DataGridView()
        Me.txtt_doc = New System.Windows.Forms.TextBox()
        Me.txtnro_doc = New System.Windows.Forms.TextBox()
        Me.txtnum_doc = New System.Windows.Forms.TextBox()
        Me.npdmonto = New System.Windows.Forms.NumericUpDown()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtser_doc = New System.Windows.Forms.TextBox()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtt_cmb = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.npdmontod = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtmoneda = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdmonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npdmontod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Serie"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Numero"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(401, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Num. Doc."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(401, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Monto S."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(401, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Fec. Letra"
        '
        'dgvt_doc
        '
        Me.dgvt_doc.AllowUserToAddRows = False
        Me.dgvt_doc.AllowUserToDeleteRows = False
        Me.dgvt_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc.Location = New System.Drawing.Point(12, 155)
        Me.dgvt_doc.Name = "dgvt_doc"
        Me.dgvt_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc.Size = New System.Drawing.Size(566, 208)
        Me.dgvt_doc.TabIndex = 42
        '
        'txtt_doc
        '
        Me.txtt_doc.Location = New System.Drawing.Point(77, 18)
        Me.txtt_doc.Name = "txtt_doc"
        Me.txtt_doc.ReadOnly = True
        Me.txtt_doc.Size = New System.Drawing.Size(118, 20)
        Me.txtt_doc.TabIndex = 100
        '
        'txtnro_doc
        '
        Me.txtnro_doc.Location = New System.Drawing.Point(77, 70)
        Me.txtnro_doc.Name = "txtnro_doc"
        Me.txtnro_doc.ReadOnly = True
        Me.txtnro_doc.Size = New System.Drawing.Size(118, 20)
        Me.txtnro_doc.TabIndex = 102
        '
        'txtnum_doc
        '
        Me.txtnum_doc.Enabled = False
        Me.txtnum_doc.Location = New System.Drawing.Point(465, 38)
        Me.txtnum_doc.Name = "txtnum_doc"
        Me.txtnum_doc.Size = New System.Drawing.Size(89, 20)
        Me.txtnum_doc.TabIndex = 51
        '
        'npdmonto
        '
        Me.npdmonto.DecimalPlaces = 2
        Me.npdmonto.Enabled = False
        Me.npdmonto.Location = New System.Drawing.Point(457, 67)
        Me.npdmonto.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npdmonto.Name = "npdmonto"
        Me.npdmonto.Size = New System.Drawing.Size(107, 20)
        Me.npdmonto.TabIndex = 52
        '
        'dtpfecha
        '
        Me.dtpfecha.Enabled = False
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(465, 15)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(89, 20)
        Me.dtpfecha.TabIndex = 50
        '
        'txtser_doc
        '
        Me.txtser_doc.Location = New System.Drawing.Point(77, 44)
        Me.txtser_doc.Name = "txtser_doc"
        Me.txtser_doc.ReadOnly = True
        Me.txtser_doc.Size = New System.Drawing.Size(118, 20)
        Me.txtser_doc.TabIndex = 101
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(101, 126)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(81, 23)
        Me.btnagregar.TabIndex = 45
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(188, 126)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(81, 23)
        Me.btnmodificar.TabIndex = 46
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(275, 126)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(81, 23)
        Me.btnborrar.TabIndex = 47
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(362, 126)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(81, 23)
        Me.btnsalir.TabIndex = 48
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(12, 126)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(81, 23)
        Me.btnnuevo.TabIndex = 44
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'txtproveedor
        '
        Me.txtproveedor.Location = New System.Drawing.Point(77, 96)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.ReadOnly = True
        Me.txtproveedor.Size = New System.Drawing.Size(118, 20)
        Me.txtproveedor.TabIndex = 103
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Prov."
        '
        'txtt_cmb
        '
        Me.txtt_cmb.Location = New System.Drawing.Point(262, 18)
        Me.txtt_cmb.Name = "txtt_cmb"
        Me.txtt_cmb.ReadOnly = True
        Me.txtt_cmb.Size = New System.Drawing.Size(118, 20)
        Me.txtt_cmb.TabIndex = 104
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(201, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "T. Cambio"
        '
        'npdmontod
        '
        Me.npdmontod.DecimalPlaces = 2
        Me.npdmontod.Enabled = False
        Me.npdmontod.Location = New System.Drawing.Point(457, 93)
        Me.npdmontod.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.npdmontod.Name = "npdmontod"
        Me.npdmontod.Size = New System.Drawing.Size(107, 20)
        Me.npdmontod.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(401, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Monto D."
        '
        'txtmoneda
        '
        Me.txtmoneda.Location = New System.Drawing.Point(262, 44)
        Me.txtmoneda.Name = "txtmoneda"
        Me.txtmoneda.ReadOnly = True
        Me.txtmoneda.Size = New System.Drawing.Size(118, 20)
        Me.txtmoneda.TabIndex = 105
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(201, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Moneda"
        '
        'FormLetrasCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 375)
        Me.Controls.Add(Me.txtmoneda)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.npdmontod)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtt_cmb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtproveedor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.npdmonto)
        Me.Controls.Add(Me.txtnum_doc)
        Me.Controls.Add(Me.txtnro_doc)
        Me.Controls.Add(Me.txtser_doc)
        Me.Controls.Add(Me.txtt_doc)
        Me.Controls.Add(Me.dgvt_doc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormLetrasCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLetrasCompras"
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdmonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npdmontod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvt_doc As DataGridView
    Friend WithEvents txtt_doc As TextBox
    Friend WithEvents txtnro_doc As TextBox
    Friend WithEvents txtnum_doc As TextBox
    Friend WithEvents npdmonto As NumericUpDown
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents txtser_doc As TextBox
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnborrar As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents txtproveedor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtt_cmb As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents npdmontod As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents txtmoneda As TextBox
    Friend WithEvents Label10 As Label
End Class
