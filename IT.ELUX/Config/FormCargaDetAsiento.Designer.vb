<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCargaDetAsiento
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.btncargararch = New System.Windows.Forms.Button()
        Me.btninsertar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvdatos = New System.Windows.Forms.DataGridView()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIE1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMERO1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESTINO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPORTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONEDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SIGNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_CAMB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOLARES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROVEEDOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTCT_COD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ART_COD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.X_RET = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvdatos1 = New System.Windows.Forms.DataGridView()
        Me.TIPO0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIE0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMERO0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIE10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMERO10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUENTA0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESTINO0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPORTE0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONEDA0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SIGNO0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_CAMB0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOLARES0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROVEEDOR0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTCT_COD0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ART_COD0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.X_RET0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCO_COD0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvdatos1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.btnborrar)
        Me.GroupBox2.Controls.Add(Me.btncargararch)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(558, 58)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Agregar con archivo"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(251, 25)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(124, 17)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Con Centro de Costo"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(400, 21)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(64, 23)
        Me.btnborrar.TabIndex = 7
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = True
        Me.btnborrar.Visible = False
        '
        'btncargararch
        '
        Me.btncargararch.Location = New System.Drawing.Point(7, 21)
        Me.btncargararch.Name = "btncargararch"
        Me.btncargararch.Size = New System.Drawing.Size(229, 23)
        Me.btncargararch.TabIndex = 6
        Me.btncargararch.Text = "Abrir Archivo"
        Me.btncargararch.UseVisualStyleBackColor = True
        '
        'btninsertar
        '
        Me.btninsertar.Location = New System.Drawing.Point(12, 305)
        Me.btninsertar.Name = "btninsertar"
        Me.btninsertar.Size = New System.Drawing.Size(92, 23)
        Me.btninsertar.TabIndex = 14
        Me.btninsertar.Text = "Insertar Datos"
        Me.btninsertar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(448, 310)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 44
        '
        'dgvdatos
        '
        Me.dgvdatos.AllowUserToAddRows = False
        Me.dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TIPO, Me.SERIE, Me.NUMERO, Me.TIPO1, Me.SERIE1, Me.NUMERO1, Me.FECHA, Me.CUENTA, Me.DESTINO, Me.IMPORTE, Me.MONEDA, Me.SIGNO, Me.T_CAMB, Me.DOLARES, Me.PROVEEDOR, Me.CTCT_COD, Me.ART_COD, Me.X_RET, Me.STATUS})
        Me.dgvdatos.Location = New System.Drawing.Point(12, 75)
        Me.dgvdatos.Name = "dgvdatos"
        Me.dgvdatos.ReadOnly = True
        Me.dgvdatos.Size = New System.Drawing.Size(558, 229)
        Me.dgvdatos.TabIndex = 13
        '
        'TIPO
        '
        Me.TIPO.HeaderText = "TIPO"
        Me.TIPO.Name = "TIPO"
        Me.TIPO.ReadOnly = True
        Me.TIPO.Width = 50
        '
        'SERIE
        '
        Me.SERIE.HeaderText = "SERIE"
        Me.SERIE.Name = "SERIE"
        Me.SERIE.ReadOnly = True
        Me.SERIE.Width = 50
        '
        'NUMERO
        '
        Me.NUMERO.HeaderText = "NUMERO"
        Me.NUMERO.Name = "NUMERO"
        Me.NUMERO.ReadOnly = True
        Me.NUMERO.Width = 80
        '
        'TIPO1
        '
        Me.TIPO1.HeaderText = "TIPO1"
        Me.TIPO1.Name = "TIPO1"
        Me.TIPO1.ReadOnly = True
        Me.TIPO1.Width = 50
        '
        'SERIE1
        '
        Me.SERIE1.HeaderText = "SERIE1"
        Me.SERIE1.Name = "SERIE1"
        Me.SERIE1.ReadOnly = True
        Me.SERIE1.Width = 50
        '
        'NUMERO1
        '
        Me.NUMERO1.HeaderText = "NUMERO1"
        Me.NUMERO1.Name = "NUMERO1"
        Me.NUMERO1.ReadOnly = True
        Me.NUMERO1.Width = 80
        '
        'FECHA
        '
        Me.FECHA.HeaderText = "FECHA"
        Me.FECHA.Name = "FECHA"
        Me.FECHA.ReadOnly = True
        '
        'CUENTA
        '
        Me.CUENTA.HeaderText = "CUENTA"
        Me.CUENTA.Name = "CUENTA"
        Me.CUENTA.ReadOnly = True
        '
        'DESTINO
        '
        Me.DESTINO.HeaderText = "DESTINO"
        Me.DESTINO.Name = "DESTINO"
        Me.DESTINO.ReadOnly = True
        '
        'IMPORTE
        '
        Me.IMPORTE.HeaderText = "IMPORTE"
        Me.IMPORTE.Name = "IMPORTE"
        Me.IMPORTE.ReadOnly = True
        '
        'MONEDA
        '
        Me.MONEDA.HeaderText = "MONEDA"
        Me.MONEDA.Name = "MONEDA"
        Me.MONEDA.ReadOnly = True
        '
        'SIGNO
        '
        Me.SIGNO.HeaderText = "SIGNO"
        Me.SIGNO.Name = "SIGNO"
        Me.SIGNO.ReadOnly = True
        '
        'T_CAMB
        '
        Me.T_CAMB.HeaderText = "T_CAMB"
        Me.T_CAMB.Name = "T_CAMB"
        Me.T_CAMB.ReadOnly = True
        '
        'DOLARES
        '
        Me.DOLARES.HeaderText = "DOLARES"
        Me.DOLARES.Name = "DOLARES"
        Me.DOLARES.ReadOnly = True
        '
        'PROVEEDOR
        '
        Me.PROVEEDOR.HeaderText = "PROVEEDOR"
        Me.PROVEEDOR.Name = "PROVEEDOR"
        Me.PROVEEDOR.ReadOnly = True
        '
        'CTCT_COD
        '
        Me.CTCT_COD.HeaderText = "CTCT_COD"
        Me.CTCT_COD.Name = "CTCT_COD"
        Me.CTCT_COD.ReadOnly = True
        '
        'ART_COD
        '
        Me.ART_COD.HeaderText = "ART_COD"
        Me.ART_COD.Name = "ART_COD"
        Me.ART_COD.ReadOnly = True
        '
        'X_RET
        '
        Me.X_RET.HeaderText = "X_RET"
        Me.X_RET.Name = "X_RET"
        Me.X_RET.ReadOnly = True
        '
        'STATUS
        '
        Me.STATUS.HeaderText = "STATUS"
        Me.STATUS.Name = "STATUS"
        Me.STATUS.ReadOnly = True
        '
        'dgvdatos1
        '
        Me.dgvdatos1.AllowUserToAddRows = False
        Me.dgvdatos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdatos1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TIPO0, Me.SERIE0, Me.NUMERO0, Me.TIPO10, Me.SERIE10, Me.NUMERO10, Me.FECHA0, Me.CUENTA0, Me.DESTINO0, Me.IMPORTE0, Me.MONEDA0, Me.SIGNO0, Me.T_CAMB0, Me.DOLARES0, Me.PROVEEDOR0, Me.CTCT_COD0, Me.ART_COD0, Me.X_RET0, Me.STATUS0, Me.CCO_COD0})
        Me.dgvdatos1.Location = New System.Drawing.Point(12, 75)
        Me.dgvdatos1.Name = "dgvdatos1"
        Me.dgvdatos1.ReadOnly = True
        Me.dgvdatos1.Size = New System.Drawing.Size(558, 229)
        Me.dgvdatos1.TabIndex = 45
        Me.dgvdatos1.Visible = False
        '
        'TIPO0
        '
        Me.TIPO0.HeaderText = "TIPO"
        Me.TIPO0.Name = "TIPO0"
        Me.TIPO0.ReadOnly = True
        Me.TIPO0.Width = 50
        '
        'SERIE0
        '
        Me.SERIE0.HeaderText = "SERIE"
        Me.SERIE0.Name = "SERIE0"
        Me.SERIE0.ReadOnly = True
        Me.SERIE0.Width = 50
        '
        'NUMERO0
        '
        Me.NUMERO0.HeaderText = "NUMERO"
        Me.NUMERO0.Name = "NUMERO0"
        Me.NUMERO0.ReadOnly = True
        Me.NUMERO0.Width = 80
        '
        'TIPO10
        '
        Me.TIPO10.HeaderText = "TIPO1"
        Me.TIPO10.Name = "TIPO10"
        Me.TIPO10.ReadOnly = True
        Me.TIPO10.Width = 50
        '
        'SERIE10
        '
        Me.SERIE10.HeaderText = "SERIE1"
        Me.SERIE10.Name = "SERIE10"
        Me.SERIE10.ReadOnly = True
        Me.SERIE10.Width = 50
        '
        'NUMERO10
        '
        Me.NUMERO10.HeaderText = "NUMERO1"
        Me.NUMERO10.Name = "NUMERO10"
        Me.NUMERO10.ReadOnly = True
        Me.NUMERO10.Width = 80
        '
        'FECHA0
        '
        Me.FECHA0.HeaderText = "FECHA"
        Me.FECHA0.Name = "FECHA0"
        Me.FECHA0.ReadOnly = True
        '
        'CUENTA0
        '
        Me.CUENTA0.HeaderText = "CUENTA"
        Me.CUENTA0.Name = "CUENTA0"
        Me.CUENTA0.ReadOnly = True
        '
        'DESTINO0
        '
        Me.DESTINO0.HeaderText = "DESTINO"
        Me.DESTINO0.Name = "DESTINO0"
        Me.DESTINO0.ReadOnly = True
        '
        'IMPORTE0
        '
        Me.IMPORTE0.HeaderText = "IMPORTE"
        Me.IMPORTE0.Name = "IMPORTE0"
        Me.IMPORTE0.ReadOnly = True
        '
        'MONEDA0
        '
        Me.MONEDA0.HeaderText = "MONEDA"
        Me.MONEDA0.Name = "MONEDA0"
        Me.MONEDA0.ReadOnly = True
        '
        'SIGNO0
        '
        Me.SIGNO0.HeaderText = "SIGNO"
        Me.SIGNO0.Name = "SIGNO0"
        Me.SIGNO0.ReadOnly = True
        '
        'T_CAMB0
        '
        Me.T_CAMB0.HeaderText = "T_CAMB"
        Me.T_CAMB0.Name = "T_CAMB0"
        Me.T_CAMB0.ReadOnly = True
        '
        'DOLARES0
        '
        Me.DOLARES0.HeaderText = "DOLARES"
        Me.DOLARES0.Name = "DOLARES0"
        Me.DOLARES0.ReadOnly = True
        '
        'PROVEEDOR0
        '
        Me.PROVEEDOR0.HeaderText = "PROVEEDOR"
        Me.PROVEEDOR0.Name = "PROVEEDOR0"
        Me.PROVEEDOR0.ReadOnly = True
        '
        'CTCT_COD0
        '
        Me.CTCT_COD0.HeaderText = "CTCT_COD"
        Me.CTCT_COD0.Name = "CTCT_COD0"
        Me.CTCT_COD0.ReadOnly = True
        '
        'ART_COD0
        '
        Me.ART_COD0.HeaderText = "ART_COD"
        Me.ART_COD0.Name = "ART_COD0"
        Me.ART_COD0.ReadOnly = True
        '
        'X_RET0
        '
        Me.X_RET0.HeaderText = "X_RET"
        Me.X_RET0.Name = "X_RET0"
        Me.X_RET0.ReadOnly = True
        '
        'STATUS0
        '
        Me.STATUS0.HeaderText = "STATUS"
        Me.STATUS0.Name = "STATUS0"
        Me.STATUS0.ReadOnly = True
        '
        'CCO_COD0
        '
        Me.CCO_COD0.HeaderText = "CCO_COD"
        Me.CCO_COD0.Name = "CCO_COD0"
        Me.CCO_COD0.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(470, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 23)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Borrar Todo"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'FormCargaDetAsiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 342)
        Me.Controls.Add(Me.dgvdatos1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btninsertar)
        Me.Controls.Add(Me.dgvdatos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FormCargaDetAsiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCargaDetAsiento"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvdatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvdatos1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnborrar As Button
    Friend WithEvents btncargararch As Button
    Friend WithEvents btninsertar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvdatos As DataGridView
    Friend WithEvents dgvdatos1 As DataGridView
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TIPO As DataGridViewTextBoxColumn
    Friend WithEvents SERIE As DataGridViewTextBoxColumn
    Friend WithEvents NUMERO As DataGridViewTextBoxColumn
    Friend WithEvents TIPO1 As DataGridViewTextBoxColumn
    Friend WithEvents SERIE1 As DataGridViewTextBoxColumn
    Friend WithEvents NUMERO1 As DataGridViewTextBoxColumn
    Friend WithEvents FECHA As DataGridViewTextBoxColumn
    Friend WithEvents CUENTA As DataGridViewTextBoxColumn
    Friend WithEvents DESTINO As DataGridViewTextBoxColumn
    Friend WithEvents IMPORTE As DataGridViewTextBoxColumn
    Friend WithEvents MONEDA As DataGridViewTextBoxColumn
    Friend WithEvents SIGNO As DataGridViewTextBoxColumn
    Friend WithEvents T_CAMB As DataGridViewTextBoxColumn
    Friend WithEvents DOLARES As DataGridViewTextBoxColumn
    Friend WithEvents PROVEEDOR As DataGridViewTextBoxColumn
    Friend WithEvents CTCT_COD As DataGridViewTextBoxColumn
    Friend WithEvents ART_COD As DataGridViewTextBoxColumn
    Friend WithEvents X_RET As DataGridViewTextBoxColumn
    Friend WithEvents STATUS As DataGridViewTextBoxColumn
    Friend WithEvents TIPO0 As DataGridViewTextBoxColumn
    Friend WithEvents SERIE0 As DataGridViewTextBoxColumn
    Friend WithEvents NUMERO0 As DataGridViewTextBoxColumn
    Friend WithEvents TIPO10 As DataGridViewTextBoxColumn
    Friend WithEvents SERIE10 As DataGridViewTextBoxColumn
    Friend WithEvents NUMERO10 As DataGridViewTextBoxColumn
    Friend WithEvents FECHA0 As DataGridViewTextBoxColumn
    Friend WithEvents CUENTA0 As DataGridViewTextBoxColumn
    Friend WithEvents DESTINO0 As DataGridViewTextBoxColumn
    Friend WithEvents IMPORTE0 As DataGridViewTextBoxColumn
    Friend WithEvents MONEDA0 As DataGridViewTextBoxColumn
    Friend WithEvents SIGNO0 As DataGridViewTextBoxColumn
    Friend WithEvents T_CAMB0 As DataGridViewTextBoxColumn
    Friend WithEvents DOLARES0 As DataGridViewTextBoxColumn
    Friend WithEvents PROVEEDOR0 As DataGridViewTextBoxColumn
    Friend WithEvents CTCT_COD0 As DataGridViewTextBoxColumn
    Friend WithEvents ART_COD0 As DataGridViewTextBoxColumn
    Friend WithEvents X_RET0 As DataGridViewTextBoxColumn
    Friend WithEvents STATUS0 As DataGridViewTextBoxColumn
    Friend WithEvents CCO_COD0 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
