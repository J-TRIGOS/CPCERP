<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRptFecKardex
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.drpAnho = New System.Windows.Forms.ComboBox()
        Me.drpMes = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbAlmacen = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkInventario = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbSublineas = New System.Windows.Forms.ComboBox()
        Me.cmbLineas = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha"
        Me.Label1.Visible = False
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(200, 168)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(109, 20)
        Me.dtpfecha.TabIndex = 1
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(189, 194)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 161
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(280, 194)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(86, 36)
        Me.btnsalir.TabIndex = 162
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.Enabled = False
        Me.chk_todos.Location = New System.Drawing.Point(16, 4)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(127, 17)
        Me.chk_todos.TabIndex = 163
        Me.chk_todos.Text = "Todos los Almacenes"
        Me.chk_todos.UseVisualStyleBackColor = True
        Me.chk_todos.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "Año:"
        '
        'drpAnho
        '
        Me.drpAnho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpAnho.FormattingEnabled = True
        Me.drpAnho.Location = New System.Drawing.Point(48, 54)
        Me.drpAnho.Name = "drpAnho"
        Me.drpAnho.Size = New System.Drawing.Size(60, 21)
        Me.drpAnho.TabIndex = 165
        '
        'drpMes
        '
        Me.drpMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpMes.FormattingEnabled = True
        Me.drpMes.Location = New System.Drawing.Point(146, 54)
        Me.drpMes.Name = "drpMes"
        Me.drpMes.Size = New System.Drawing.Size(97, 21)
        Me.drpMes.TabIndex = 167
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(111, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 166
        Me.Label3.Text = "Mes:"
        '
        'cmbtipo
        '
        Me.cmbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipo.Enabled = False
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"Stock Meses", "Ajuste Para Kardex"})
        Me.cmbtipo.Location = New System.Drawing.Point(49, 27)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(209, 21)
        Me.cmbtipo.TabIndex = 168
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 169
        Me.Label4.Text = "Tipo:"
        Me.Label4.Visible = False
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Items.AddRange(New Object() {"Todos", "0001-GALERA 108 PANAMA", "0002-FALLADO PANAMA"})
        Me.cmbAlmacen.Location = New System.Drawing.Point(280, 54)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Size = New System.Drawing.Size(212, 21)
        Me.cmbAlmacen.TabIndex = 171
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(247, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 170
        Me.Label5.Text = "Alm:"
        '
        'chkInventario
        '
        Me.chkInventario.AutoSize = True
        Me.chkInventario.Location = New System.Drawing.Point(280, 27)
        Me.chkInventario.Name = "chkInventario"
        Me.chkInventario.Size = New System.Drawing.Size(73, 17)
        Me.chkInventario.TabIndex = 172
        Me.chkInventario.Text = "Inventario"
        Me.chkInventario.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 176
        Me.Label6.Text = "Linea / Sublin :"
        '
        'cmbSublineas
        '
        Me.cmbSublineas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSublineas.FormattingEnabled = True
        Me.cmbSublineas.Location = New System.Drawing.Point(103, 127)
        Me.cmbSublineas.Name = "cmbSublineas"
        Me.cmbSublineas.Size = New System.Drawing.Size(389, 21)
        Me.cmbSublineas.TabIndex = 175
        '
        'cmbLineas
        '
        Me.cmbLineas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLineas.FormattingEnabled = True
        Me.cmbLineas.Location = New System.Drawing.Point(103, 96)
        Me.cmbLineas.Name = "cmbLineas"
        Me.cmbLineas.Size = New System.Drawing.Size(389, 21)
        Me.cmbLineas.TabIndex = 173
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 174
        Me.Label7.Text = "Sublinea"
        '
        'FormRptFecKardex
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 256)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbSublineas)
        Me.Controls.Add(Me.cmbLineas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chkInventario)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbtipo)
        Me.Controls.Add(Me.drpMes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.drpAnho)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chk_todos)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRptFecKardex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptFecKardex"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents btnreporte As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents chk_todos As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents drpAnho As ComboBox
    Friend WithEvents drpMes As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbtipo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbAlmacen As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkInventario As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbSublineas As ComboBox
    Friend WithEvents cmbLineas As ComboBox
    Friend WithEvents Label7 As Label
End Class
