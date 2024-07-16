<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptOrdenProgam
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
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtc_costo = New System.Windows.Forms.TextBox()
        Me.cmbc_costo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbmes1 = New System.Windows.Forms.ComboBox()
        Me.lvccosto = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.npdDia = New System.Windows.Forms.NumericUpDown()
        Me.chkdia = New System.Windows.Forms.CheckBox()
        Me.cmbturno = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkturno = New System.Windows.Forms.CheckBox()
        Me.chkprueba = New System.Windows.Forms.CheckBox()
        CType(Me.npdDia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(382, 88)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 86
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(382, 130)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 87
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(423, 185)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 23)
        Me.Button4.TabIndex = 80
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'txtc_costo
        '
        Me.txtc_costo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtc_costo.Location = New System.Drawing.Point(100, 185)
        Me.txtc_costo.MaxLength = 3
        Me.txtc_costo.Name = "txtc_costo"
        Me.txtc_costo.Size = New System.Drawing.Size(40, 20)
        Me.txtc_costo.TabIndex = 78
        Me.txtc_costo.Visible = False
        '
        'cmbc_costo
        '
        Me.cmbc_costo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbc_costo.FormattingEnabled = True
        Me.cmbc_costo.Location = New System.Drawing.Point(146, 184)
        Me.cmbc_costo.Name = "cmbc_costo"
        Me.cmbc_costo.Size = New System.Drawing.Size(271, 21)
        Me.cmbc_costo.TabIndex = 79
        Me.cmbc_costo.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Centro Costo :"
        Me.Label4.Visible = False
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño.Location = New System.Drawing.Point(45, 29)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(74, 21)
        Me.cmbaño.TabIndex = 88
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(129, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Mes :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Año :"
        '
        'cmbmes1
        '
        Me.cmbmes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes1.FormattingEnabled = True
        Me.cmbmes1.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes1.Location = New System.Drawing.Point(173, 29)
        Me.cmbmes1.Name = "cmbmes1"
        Me.cmbmes1.Size = New System.Drawing.Size(105, 21)
        Me.cmbmes1.TabIndex = 89
        '
        'lvccosto
        '
        Me.lvccosto.CheckBoxes = True
        Me.lvccosto.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvccosto.FullRowSelect = True
        Me.lvccosto.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvccosto.Location = New System.Drawing.Point(12, 88)
        Me.lvccosto.Name = "lvccosto"
        Me.lvccosto.Size = New System.Drawing.Size(364, 248)
        Me.lvccosto.TabIndex = 92
        Me.lvccosto.UseCompatibleStateImageBehavior = False
        Me.lvccosto.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 276
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Centro de Costo"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(301, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Dia :"
        '
        'npdDia
        '
        Me.npdDia.Location = New System.Drawing.Point(340, 30)
        Me.npdDia.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.npdDia.Name = "npdDia"
        Me.npdDia.Size = New System.Drawing.Size(52, 20)
        Me.npdDia.TabIndex = 95
        '
        'chkdia
        '
        Me.chkdia.AutoSize = True
        Me.chkdia.Checked = True
        Me.chkdia.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkdia.Location = New System.Drawing.Point(398, 33)
        Me.chkdia.Name = "chkdia"
        Me.chkdia.Size = New System.Drawing.Size(42, 17)
        Me.chkdia.TabIndex = 96
        Me.chkdia.Text = "Dia"
        Me.chkdia.UseVisualStyleBackColor = True
        '
        'cmbturno
        '
        Me.cmbturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbturno.FormattingEnabled = True
        Me.cmbturno.Items.AddRange(New Object() {"Dia", "Noche"})
        Me.cmbturno.Location = New System.Drawing.Point(55, 56)
        Me.cmbturno.Name = "cmbturno"
        Me.cmbturno.Size = New System.Drawing.Size(105, 21)
        Me.cmbturno.TabIndex = 97
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "Turno :"
        '
        'chkturno
        '
        Me.chkturno.AutoSize = True
        Me.chkturno.Checked = True
        Me.chkturno.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkturno.Location = New System.Drawing.Point(173, 59)
        Me.chkturno.Name = "chkturno"
        Me.chkturno.Size = New System.Drawing.Size(54, 17)
        Me.chkturno.TabIndex = 99
        Me.chkturno.Text = "Turno"
        Me.chkturno.UseVisualStyleBackColor = True
        '
        'chkprueba
        '
        Me.chkprueba.AutoSize = True
        Me.chkprueba.Location = New System.Drawing.Point(233, 60)
        Me.chkprueba.Name = "chkprueba"
        Me.chkprueba.Size = New System.Drawing.Size(60, 17)
        Me.chkprueba.TabIndex = 100
        Me.chkprueba.Text = "Prueba"
        Me.chkprueba.UseVisualStyleBackColor = True
        '
        'FormRptOrdenProgam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 348)
        Me.Controls.Add(Me.chkprueba)
        Me.Controls.Add(Me.chkturno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbturno)
        Me.Controls.Add(Me.chkdia)
        Me.Controls.Add(Me.npdDia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lvccosto)
        Me.Controls.Add(Me.cmbaño)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbmes1)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtc_costo)
        Me.Controls.Add(Me.cmbc_costo)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRptOrdenProgam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptOrdenProgam"
        CType(Me.npdDia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnreporte As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txtc_costo As TextBox
    Friend WithEvents cmbc_costo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbaño As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbmes1 As ComboBox
    Friend WithEvents lvccosto As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents npdDia As NumericUpDown
    Friend WithEvents chkdia As CheckBox
    Friend WithEvents cmbturno As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chkturno As CheckBox
    Friend WithEvents chkprueba As CheckBox
End Class
