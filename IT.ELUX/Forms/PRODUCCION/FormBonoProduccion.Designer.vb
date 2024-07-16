<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBonoProduccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBonoProduccion))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbimprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.DatFechaPro = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgvDatosPersonal = New System.Windows.Forms.DataGridView()
        Me.COD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPLEADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDPRO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODART = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODPROCESO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIDHORA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIPROD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORAINI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORAFIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODJOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INDPRO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmbCC = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsbForm.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvDatosPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.ToolStripSeparator1, Me.tsbimprimir, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(1371, 25)
        Me.tsbForm.TabIndex = 114
        Me.tsbForm.Text = "Grabar"
        '
        'tsbGrabar
        '
        Me.tsbGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGrabar.Image = CType(resources.GetObject("tsbGrabar.Image"), System.Drawing.Image)
        Me.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabar.Name = "tsbGrabar"
        Me.tsbGrabar.Size = New System.Drawing.Size(23, 22)
        Me.tsbGrabar.Tag = "save"
        Me.tsbGrabar.Text = "Grabar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbimprimir
        '
        Me.tsbimprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbimprimir.Image = CType(resources.GetObject("tsbimprimir.Image"), System.Drawing.Image)
        Me.tsbimprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbimprimir.Name = "tsbimprimir"
        Me.tsbimprimir.Size = New System.Drawing.Size(23, 22)
        Me.tsbimprimir.Tag = "Print"
        Me.tsbimprimir.Text = "Imprimir"
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(23, 22)
        Me.tsbSalir.Tag = "exit"
        Me.tsbSalir.Text = "Salir"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.BtnBuscar)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.BtnBorrar)
        Me.Panel1.Controls.Add(Me.DatFechaPro)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DgvDatosPersonal)
        Me.Panel1.Controls.Add(Me.CmbCC)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1347, 425)
        Me.Panel1.TabIndex = 115
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(614, 12)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(119, 17)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Actualizar Procesos"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(111, 7)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 11
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Empleado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Borrar Datos Fila"
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackgroundImage = Global.IT.ELUX.My.Resources.Resources.descarga1
        Me.BtnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBorrar.Location = New System.Drawing.Point(105, 62)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(25, 26)
        Me.BtnBorrar.TabIndex = 8
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'DatFechaPro
        '
        Me.DatFechaPro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatFechaPro.Location = New System.Drawing.Point(111, 36)
        Me.DatFechaPro.Name = "DatFechaPro"
        Me.DatFechaPro.Size = New System.Drawing.Size(97, 20)
        Me.DatFechaPro.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha"
        '
        'DgvDatosPersonal
        '
        Me.DgvDatosPersonal.AllowUserToAddRows = False
        Me.DgvDatosPersonal.AllowUserToDeleteRows = False
        Me.DgvDatosPersonal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvDatosPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDatosPersonal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COD, Me.EMPLEADO, Me.ORDPRO, Me.CODART, Me.DESCRIPCION, Me.CANTIDAD, Me.CODPROCESO, Me.UNIDHORA, Me.UNIPROD, Me.HORAINI, Me.HORAFIN, Me.PRODJOR, Me.INDPRO})
        Me.DgvDatosPersonal.Location = New System.Drawing.Point(14, 125)
        Me.DgvDatosPersonal.Name = "DgvDatosPersonal"
        Me.DgvDatosPersonal.Size = New System.Drawing.Size(1330, 297)
        Me.DgvDatosPersonal.TabIndex = 5
        '
        'COD
        '
        Me.COD.DataPropertyName = "COD"
        Me.COD.HeaderText = "CODIGO"
        Me.COD.Name = "COD"
        Me.COD.ReadOnly = True
        Me.COD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'EMPLEADO
        '
        Me.EMPLEADO.DataPropertyName = "EMPLEADO"
        Me.EMPLEADO.HeaderText = "EMPLEADO"
        Me.EMPLEADO.Name = "EMPLEADO"
        Me.EMPLEADO.ReadOnly = True
        Me.EMPLEADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ORDPRO
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ORDPRO.DefaultCellStyle = DataGridViewCellStyle1
        Me.ORDPRO.HeaderText = "ORD. PRO"
        Me.ORDPRO.Name = "ORDPRO"
        Me.ORDPRO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CODART
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CODART.DefaultCellStyle = DataGridViewCellStyle2
        Me.CODART.HeaderText = "COD. ART."
        Me.CODART.Name = "CODART"
        Me.CODART.ReadOnly = True
        Me.CODART.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.HeaderText = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.ReadOnly = True
        Me.DESCRIPCION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DESCRIPCION.Visible = False
        '
        'CANTIDAD
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CANTIDAD.DefaultCellStyle = DataGridViewCellStyle3
        Me.CANTIDAD.HeaderText = "CANTIDAD"
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.ReadOnly = True
        Me.CANTIDAD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CODPROCESO
        '
        Me.CODPROCESO.HeaderText = "PROCESO/OPERACION"
        Me.CODPROCESO.Name = "CODPROCESO"
        Me.CODPROCESO.ReadOnly = True
        Me.CODPROCESO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'UNIDHORA
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.UNIDHORA.DefaultCellStyle = DataGridViewCellStyle4
        Me.UNIDHORA.HeaderText = "UNID X HORA"
        Me.UNIDHORA.Name = "UNIDHORA"
        Me.UNIDHORA.ReadOnly = True
        Me.UNIDHORA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'UNIPROD
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.UNIPROD.DefaultCellStyle = DataGridViewCellStyle5
        Me.UNIPROD.HeaderText = "PROD. OBRERO"
        Me.UNIPROD.Name = "UNIPROD"
        '
        'HORAINI
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.HORAINI.DefaultCellStyle = DataGridViewCellStyle6
        Me.HORAINI.HeaderText = "HORA INI"
        Me.HORAINI.Name = "HORAINI"
        '
        'HORAFIN
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.HORAFIN.DefaultCellStyle = DataGridViewCellStyle7
        Me.HORAFIN.HeaderText = "HORA FIN"
        Me.HORAFIN.Name = "HORAFIN"
        '
        'PRODJOR
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PRODJOR.DefaultCellStyle = DataGridViewCellStyle8
        Me.PRODJOR.HeaderText = "PROD X JORNAL"
        Me.PRODJOR.Name = "PRODJOR"
        Me.PRODJOR.ReadOnly = True
        '
        'INDPRO
        '
        Me.INDPRO.HeaderText = "IND. PROD."
        Me.INDPRO.Name = "INDPRO"
        Me.INDPRO.ReadOnly = True
        '
        'CmbCC
        '
        Me.CmbCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCC.FormattingEnabled = True
        Me.CmbCC.Location = New System.Drawing.Point(614, 34)
        Me.CmbCC.Name = "CmbCC"
        Me.CmbCC.Size = New System.Drawing.Size(443, 21)
        Me.CmbCC.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(541, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Operaciones"
        '
        'FormBonoProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 462)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tsbForm)
        Me.Name = "FormBonoProduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBonoProduccion"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvDatosPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbimprimir As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CmbCC As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DatFechaPro As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents DgvDatosPersonal As DataGridView
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents COD As DataGridViewTextBoxColumn
    Friend WithEvents EMPLEADO As DataGridViewTextBoxColumn
    Friend WithEvents ORDPRO As DataGridViewTextBoxColumn
    Friend WithEvents CODART As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents CODPROCESO As DataGridViewTextBoxColumn
    Friend WithEvents UNIDHORA As DataGridViewTextBoxColumn
    Friend WithEvents UNIPROD As DataGridViewTextBoxColumn
    Friend WithEvents HORAINI As DataGridViewTextBoxColumn
    Friend WithEvents HORAFIN As DataGridViewTextBoxColumn
    Friend WithEvents PRODJOR As DataGridViewTextBoxColumn
    Friend WithEvents INDPRO As DataGridViewTextBoxColumn
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
