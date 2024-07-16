<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptDetRecep
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
        Me.dtpfecha1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpfecha2 = New System.Windows.Forms.DateTimePicker()
        Me.txtnro_orden = New System.Windows.Forms.TextBox()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.txtfactura = New System.Windows.Forms.TextBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtnomprov = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbser = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbest = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro. Orden"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Proveedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Factura"
        '
        'dtpfecha1
        '
        Me.dtpfecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha1.Location = New System.Drawing.Point(91, 34)
        Me.dtpfecha1.Name = "dtpfecha1"
        Me.dtpfecha1.Size = New System.Drawing.Size(104, 20)
        Me.dtpfecha1.TabIndex = 1
        '
        'dtpfecha2
        '
        Me.dtpfecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha2.Location = New System.Drawing.Point(213, 34)
        Me.dtpfecha2.Name = "dtpfecha2"
        Me.dtpfecha2.Size = New System.Drawing.Size(104, 20)
        Me.dtpfecha2.TabIndex = 2
        '
        'txtnro_orden
        '
        Me.txtnro_orden.Location = New System.Drawing.Point(91, 60)
        Me.txtnro_orden.Name = "txtnro_orden"
        Me.txtnro_orden.Size = New System.Drawing.Size(100, 20)
        Me.txtnro_orden.TabIndex = 3
        '
        'txtproveedor
        '
        Me.txtproveedor.Location = New System.Drawing.Point(91, 91)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(61, 20)
        Me.txtproveedor.TabIndex = 4
        '
        'txtfactura
        '
        Me.txtfactura.Location = New System.Drawing.Point(91, 122)
        Me.txtfactura.Name = "txtfactura"
        Me.txtfactura.Size = New System.Drawing.Size(100, 20)
        Me.txtfactura.TabIndex = 5
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(226, 155)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 8
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(130, 155)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 7
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(382, 89)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 23)
        Me.Button4.TabIndex = 149
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtnomprov
        '
        Me.txtnomprov.Location = New System.Drawing.Point(158, 91)
        Me.txtnomprov.Name = "txtnomprov"
        Me.txtnomprov.ReadOnly = True
        Me.txtnomprov.Size = New System.Drawing.Size(218, 20)
        Me.txtnomprov.TabIndex = 152
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(209, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 153
        Me.Label5.Text = "Ser. Orden"
        '
        'cmbser
        '
        Me.cmbser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbser.FormattingEnabled = True
        Me.cmbser.Items.AddRange(New Object() {"", "001", "002", "003", "004", "RECEP"})
        Me.cmbser.Location = New System.Drawing.Point(277, 59)
        Me.cmbser.Name = "cmbser"
        Me.cmbser.Size = New System.Drawing.Size(99, 21)
        Me.cmbser.TabIndex = 154
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(204, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "Est. Recep."
        '
        'cmbest
        '
        Me.cmbest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbest.FormattingEnabled = True
        Me.cmbest.Items.AddRange(New Object() {"", "APROBADO", "DESAPROBADO"})
        Me.cmbest.Location = New System.Drawing.Point(277, 123)
        Me.cmbest.Name = "cmbest"
        Me.cmbest.Size = New System.Drawing.Size(99, 21)
        Me.cmbest.TabIndex = 6
        '
        'FormRptDetRecep
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 205)
        Me.Controls.Add(Me.cmbest)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbser)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnomprov)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtfactura)
        Me.Controls.Add(Me.txtproveedor)
        Me.Controls.Add(Me.txtnro_orden)
        Me.Controls.Add(Me.dtpfecha2)
        Me.Controls.Add(Me.dtpfecha1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRptDetRecep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptDetRecep"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpfecha1 As DateTimePicker
    Friend WithEvents dtpfecha2 As DateTimePicker
    Friend WithEvents txtnro_orden As TextBox
    Friend WithEvents txtproveedor As TextBox
    Friend WithEvents txtfactura As TextBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnreporte As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txtnomprov As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbser As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbest As ComboBox
End Class
