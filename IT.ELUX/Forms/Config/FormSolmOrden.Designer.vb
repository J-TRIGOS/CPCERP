<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSolmOrden
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
        Me.lvbusqueda = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btngenerar = New System.Windows.Forms.Button()
        Me.chkmarcar = New System.Windows.Forms.CheckBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.lbltdoc = New System.Windows.Forms.Label()
        Me.lblsdoc = New System.Windows.Forms.Label()
        Me.lblndoc = New System.Windows.Forms.Label()
        Me.btnproc = New System.Windows.Forms.Button()
        Me.dgvt_doc = New System.Windows.Forms.DataGridView()
        Me.dgvsolm = New System.Windows.Forms.DataGridView()
        Me.btn_reporte = New System.Windows.Forms.Button()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvsolm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvbusqueda
        '
        Me.lvbusqueda.CheckBoxes = True
        Me.lvbusqueda.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader9, Me.ColumnHeader8, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lvbusqueda.FullRowSelect = True
        Me.lvbusqueda.Location = New System.Drawing.Point(15, 56)
        Me.lvbusqueda.Name = "lvbusqueda"
        Me.lvbusqueda.Size = New System.Drawing.Size(774, 194)
        Me.lvbusqueda.TabIndex = 0
        Me.lvbusqueda.UseCompatibleStateImageBehavior = False
        Me.lvbusqueda.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Articulo"
        Me.ColumnHeader2.Width = 603
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cantidad"
        Me.ColumnHeader3.Width = 65
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Orden_Program"
        Me.ColumnHeader4.Width = 0
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Centro Costo"
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Solm"
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Proc"
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "SER_DOC_REF1"
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "NRO_DOC_REF1"
        Me.ColumnHeader8.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "SSOLM"
        Me.ColumnHeader10.Width = 0
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "NSOLM"
        Me.ColumnHeader11.Width = 0
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(633, 12)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(75, 38)
        Me.btngenerar.TabIndex = 1
        Me.btngenerar.Text = "Sol. Materiales"
        Me.btngenerar.UseVisualStyleBackColor = True
        '
        'chkmarcar
        '
        Me.chkmarcar.AutoSize = True
        Me.chkmarcar.Location = New System.Drawing.Point(15, 33)
        Me.chkmarcar.Name = "chkmarcar"
        Me.chkmarcar.Size = New System.Drawing.Size(92, 17)
        Me.chkmarcar.TabIndex = 2
        Me.chkmarcar.Text = "Marcar Todos"
        Me.chkmarcar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(714, 12)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 38)
        Me.btnsalir.TabIndex = 4
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'lbltdoc
        '
        Me.lbltdoc.AutoSize = True
        Me.lbltdoc.Location = New System.Drawing.Point(333, 21)
        Me.lbltdoc.Name = "lbltdoc"
        Me.lbltdoc.Size = New System.Drawing.Size(0, 13)
        Me.lbltdoc.TabIndex = 5
        '
        'lblsdoc
        '
        Me.lblsdoc.AutoSize = True
        Me.lblsdoc.Location = New System.Drawing.Point(378, 21)
        Me.lblsdoc.Name = "lblsdoc"
        Me.lblsdoc.Size = New System.Drawing.Size(0, 13)
        Me.lblsdoc.TabIndex = 6
        '
        'lblndoc
        '
        Me.lblndoc.AutoSize = True
        Me.lblndoc.Location = New System.Drawing.Point(423, 21)
        Me.lblndoc.Name = "lblndoc"
        Me.lblndoc.Size = New System.Drawing.Size(0, 13)
        Me.lblndoc.TabIndex = 7
        '
        'btnproc
        '
        Me.btnproc.Location = New System.Drawing.Point(557, 12)
        Me.btnproc.Name = "btnproc"
        Me.btnproc.Size = New System.Drawing.Size(70, 38)
        Me.btnproc.TabIndex = 265
        Me.btnproc.Text = "Reporte Tiempo"
        Me.btnproc.UseVisualStyleBackColor = True
        '
        'dgvt_doc
        '
        Me.dgvt_doc.AllowUserToAddRows = False
        Me.dgvt_doc.AllowUserToDeleteRows = False
        Me.dgvt_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc.Location = New System.Drawing.Point(15, 56)
        Me.dgvt_doc.Name = "dgvt_doc"
        Me.dgvt_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc.Size = New System.Drawing.Size(234, 194)
        Me.dgvt_doc.TabIndex = 266
        '
        'dgvsolm
        '
        Me.dgvsolm.AllowUserToAddRows = False
        Me.dgvsolm.AllowUserToDeleteRows = False
        Me.dgvsolm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvsolm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsolm.Location = New System.Drawing.Point(287, 56)
        Me.dgvsolm.Name = "dgvsolm"
        Me.dgvsolm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvsolm.Size = New System.Drawing.Size(234, 194)
        Me.dgvsolm.TabIndex = 267
        '
        'btn_reporte
        '
        Me.btn_reporte.Location = New System.Drawing.Point(481, 12)
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Size = New System.Drawing.Size(70, 39)
        Me.btn_reporte.TabIndex = 268
        Me.btn_reporte.Text = "Reporte"
        Me.btn_reporte.UseVisualStyleBackColor = True
        '
        'FormSolmOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 265)
        Me.Controls.Add(Me.btn_reporte)
        Me.Controls.Add(Me.btnproc)
        Me.Controls.Add(Me.lblndoc)
        Me.Controls.Add(Me.lblsdoc)
        Me.Controls.Add(Me.lbltdoc)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.chkmarcar)
        Me.Controls.Add(Me.btngenerar)
        Me.Controls.Add(Me.lvbusqueda)
        Me.Controls.Add(Me.dgvt_doc)
        Me.Controls.Add(Me.dgvsolm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormSolmOrden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSolmOrden"
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvsolm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvbusqueda As ListView
    Friend WithEvents btngenerar As Button
    Friend WithEvents chkmarcar As CheckBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents btnsalir As Button
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents lbltdoc As Label
    Friend WithEvents lblsdoc As Label
    Friend WithEvents lblndoc As Label
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents btnproc As Button
    Friend WithEvents dgvt_doc As DataGridView
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents dgvsolm As DataGridView
    Friend WithEvents btn_reporte As Button
End Class
