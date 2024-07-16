<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMantActaEntrega
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
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblnom = New System.Windows.Forms.Label()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvt_doc = New System.Windows.Forms.DataGridView()
        Me.txtn_bolsas = New System.Windows.Forms.TextBox()
        Me.cmbarticulo = New System.Windows.Forms.ComboBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.dgvtacta = New System.Windows.Forms.DataGridView()
        Me.cmbTpaquete = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnborrar = New System.Windows.Forms.Button()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvtacta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(205, 283)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 33
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(301, 283)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 114
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "Articulo"
        '
        'lblnom
        '
        Me.lblnom.BackColor = System.Drawing.Color.Gainsboro
        Me.lblnom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnom.Location = New System.Drawing.Point(196, 17)
        Me.lblnom.Name = "lblnom"
        Me.lblnom.Size = New System.Drawing.Size(333, 21)
        Me.lblnom.TabIndex = 119
        Me.lblnom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnagregar
        '
        Me.btnagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.Location = New System.Drawing.Point(29, 86)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(97, 23)
        Me.btnagregar.TabIndex = 121
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(231, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(405, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "Numero"
        '
        'dgvt_doc
        '
        Me.dgvt_doc.AllowUserToAddRows = False
        Me.dgvt_doc.AllowUserToDeleteRows = False
        Me.dgvt_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgvt_doc.Location = New System.Drawing.Point(28, 120)
        Me.dgvt_doc.Name = "dgvt_doc"
        Me.dgvt_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc.Size = New System.Drawing.Size(252, 103)
        Me.dgvt_doc.TabIndex = 32
        Me.dgvt_doc.Visible = False
        '
        'txtn_bolsas
        '
        Me.txtn_bolsas.Location = New System.Drawing.Point(456, 48)
        Me.txtn_bolsas.MaxLength = 15
        Me.txtn_bolsas.Name = "txtn_bolsas"
        Me.txtn_bolsas.Size = New System.Drawing.Size(73, 20)
        Me.txtn_bolsas.TabIndex = 126
        '
        'cmbarticulo
        '
        Me.cmbarticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbarticulo.FormattingEnabled = True
        Me.cmbarticulo.Location = New System.Drawing.Point(105, 17)
        Me.cmbarticulo.Name = "cmbarticulo"
        Me.cmbarticulo.Size = New System.Drawing.Size(90, 21)
        Me.cmbarticulo.TabIndex = 127
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(289, 48)
        Me.txtcantidad.MaxLength = 15
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(73, 20)
        Me.txtcantidad.TabIndex = 128
        '
        'dgvtacta
        '
        Me.dgvtacta.AllowUserToAddRows = False
        Me.dgvtacta.AllowUserToDeleteRows = False
        Me.dgvtacta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvtacta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtacta.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgvtacta.Location = New System.Drawing.Point(28, 120)
        Me.dgvtacta.Name = "dgvtacta"
        Me.dgvtacta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvtacta.Size = New System.Drawing.Size(594, 152)
        Me.dgvtacta.TabIndex = 129
        '
        'cmbTpaquete
        '
        Me.cmbTpaquete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTpaquete.FormattingEnabled = True
        Me.cmbTpaquete.Items.AddRange(New Object() {"BOLSAS", "CAJAS", "PARIHUELAS", "PAQUETE"})
        Me.cmbTpaquete.Location = New System.Drawing.Point(105, 48)
        Me.cmbTpaquete.Name = "cmbTpaquete"
        Me.cmbTpaquete.Size = New System.Drawing.Size(90, 21)
        Me.cmbTpaquete.TabIndex = 130
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 131
        Me.Label2.Text = "T. Paquete"
        '
        'btnborrar
        '
        Me.btnborrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnborrar.Location = New System.Drawing.Point(140, 86)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(97, 23)
        Me.btnborrar.TabIndex = 132
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'FormMantActaEntrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 311)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbTpaquete)
        Me.Controls.Add(Me.dgvtacta)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.cmbarticulo)
        Me.Controls.Add(Me.txtn_bolsas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.lblnom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.dgvt_doc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormMantActaEntrega"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Acta de Entrega"
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvtacta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnguardar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblnom As Label
    Friend WithEvents btnagregar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvt_doc As DataGridView
    Friend WithEvents txtn_bolsas As TextBox
    Friend WithEvents cmbarticulo As ComboBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents dgvtacta As DataGridView
    Friend WithEvents cmbTpaquete As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnborrar As Button
End Class
