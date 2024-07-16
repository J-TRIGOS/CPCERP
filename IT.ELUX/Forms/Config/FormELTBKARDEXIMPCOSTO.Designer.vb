<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormELTBKARDEXIMPCOSTO
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
        Me.dgvt_doc2 = New System.Windows.Forms.DataGridView()
        Me.btngenerar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.lblcosto_comun = New System.Windows.Forms.Label()
        Me.lblcosto_total = New System.Windows.Forms.Label()
        Me.lblcantidad_hoja = New System.Windows.Forms.Label()
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtajuste = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btngrabar = New System.Windows.Forms.Button()
        CType(Me.dgvt_doc2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvt_doc2
        '
        Me.dgvt_doc2.AllowUserToAddRows = False
        Me.dgvt_doc2.AllowUserToDeleteRows = False
        Me.dgvt_doc2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc2.Location = New System.Drawing.Point(23, 71)
        Me.dgvt_doc2.Name = "dgvt_doc2"
        Me.dgvt_doc2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc2.Size = New System.Drawing.Size(801, 230)
        Me.dgvt_doc2.TabIndex = 37
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(321, 22)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(75, 23)
        Me.btngenerar.TabIndex = 38
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Ajuste"
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(624, 22)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 23)
        Me.btnreporte.TabIndex = 41
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(705, 22)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 42
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'lblcosto_comun
        '
        Me.lblcosto_comun.AutoSize = True
        Me.lblcosto_comun.Location = New System.Drawing.Point(225, 9)
        Me.lblcosto_comun.Name = "lblcosto_comun"
        Me.lblcosto_comun.Size = New System.Drawing.Size(39, 13)
        Me.lblcosto_comun.TabIndex = 44
        Me.lblcosto_comun.Text = "Label2"
        Me.lblcosto_comun.Visible = False
        '
        'lblcosto_total
        '
        Me.lblcosto_total.AutoSize = True
        Me.lblcosto_total.Location = New System.Drawing.Point(225, 32)
        Me.lblcosto_total.Name = "lblcosto_total"
        Me.lblcosto_total.Size = New System.Drawing.Size(39, 13)
        Me.lblcosto_total.TabIndex = 45
        Me.lblcosto_total.Text = "Label2"
        Me.lblcosto_total.Visible = False
        '
        'lblcantidad_hoja
        '
        Me.lblcantidad_hoja.AutoSize = True
        Me.lblcantidad_hoja.Location = New System.Drawing.Point(225, 52)
        Me.lblcantidad_hoja.Name = "lblcantidad_hoja"
        Me.lblcantidad_hoja.Size = New System.Drawing.Size(39, 13)
        Me.lblcantidad_hoja.TabIndex = 46
        Me.lblcantidad_hoja.Text = "Label2"
        Me.lblcantidad_hoja.Visible = False
        '
        'cmbtipo
        '
        Me.cmbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"Cantidad", "Peso"})
        Me.cmbtipo.Location = New System.Drawing.Point(65, 44)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(120, 21)
        Me.cmbtipo.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Tipo"
        '
        'txtajuste
        '
        Me.txtajuste.Location = New System.Drawing.Point(65, 11)
        Me.txtajuste.MaxLength = 1000000
        Me.txtajuste.Name = "txtajuste"
        Me.txtajuste.Size = New System.Drawing.Size(120, 20)
        Me.txtajuste.TabIndex = 49
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(402, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 23)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Limpiar y Recargar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btngrabar
        '
        Me.btngrabar.Location = New System.Drawing.Point(543, 22)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(75, 23)
        Me.btngrabar.TabIndex = 51
        Me.btngrabar.Text = "Grabar"
        Me.btngrabar.UseVisualStyleBackColor = True
        '
        'FormELTBKARDEXIMPCOSTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 313)
        Me.Controls.Add(Me.btngrabar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtajuste)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbtipo)
        Me.Controls.Add(Me.lblcantidad_hoja)
        Me.Controls.Add(Me.lblcosto_total)
        Me.Controls.Add(Me.lblcosto_comun)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btngenerar)
        Me.Controls.Add(Me.dgvt_doc2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormELTBKARDEXIMPCOSTO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormELTBKARDEXIMPCOSTO"
        CType(Me.dgvt_doc2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvt_doc2 As DataGridView
    Friend WithEvents btngenerar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnreporte As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents lblcosto_comun As Label
    Friend WithEvents lblcosto_total As Label
    Friend WithEvents lblcantidad_hoja As Label
    Friend WithEvents cmbtipo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtajuste As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btngrabar As Button
End Class
