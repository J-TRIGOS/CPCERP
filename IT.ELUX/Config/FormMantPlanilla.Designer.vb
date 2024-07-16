<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMantPlanilla
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
        Me.txt_periodo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbt_pago = New System.Windows.Forms.ComboBox()
        Me.dtpfec_ini = New System.Windows.Forms.DateTimePicker()
        Me.btngrati = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.chkperiodo = New System.Windows.Forms.CheckBox()
        Me.btnquinta = New System.Windows.Forms.Button()
        Me.dgvt_doc = New System.Windows.Forms.DataGridView()
        Me.btnctsessalud = New System.Windows.Forms.Button()
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Periodo"
        '
        'txt_periodo
        '
        Me.txt_periodo.Location = New System.Drawing.Point(107, 12)
        Me.txt_periodo.Name = "txt_periodo"
        Me.txt_periodo.Size = New System.Drawing.Size(100, 20)
        Me.txt_periodo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo Planilla"
        '
        'cmbt_pago
        '
        Me.cmbt_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbt_pago.FormattingEnabled = True
        Me.cmbt_pago.Items.AddRange(New Object() {"", "MENSUAL", "GRATIFICACION", "GRATIFICACION 2"})
        Me.cmbt_pago.Location = New System.Drawing.Point(107, 59)
        Me.cmbt_pago.Name = "cmbt_pago"
        Me.cmbt_pago.Size = New System.Drawing.Size(180, 21)
        Me.cmbt_pago.TabIndex = 3
        '
        'dtpfec_ini
        '
        Me.dtpfec_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ini.Location = New System.Drawing.Point(107, 37)
        Me.dtpfec_ini.Name = "dtpfec_ini"
        Me.dtpfec_ini.ShowCheckBox = True
        Me.dtpfec_ini.Size = New System.Drawing.Size(100, 20)
        Me.dtpfec_ini.TabIndex = 2
        '
        'btngrati
        '
        Me.btngrati.Location = New System.Drawing.Point(37, 89)
        Me.btngrati.Name = "btngrati"
        Me.btngrati.Size = New System.Drawing.Size(93, 36)
        Me.btngrati.TabIndex = 4
        Me.btngrati.Text = "Genera Planilla"
        Me.btngrati.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(235, 89)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(86, 36)
        Me.btnsalir.TabIndex = 5
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'chkperiodo
        '
        Me.chkperiodo.AutoSize = True
        Me.chkperiodo.Location = New System.Drawing.Point(213, 14)
        Me.chkperiodo.Name = "chkperiodo"
        Me.chkperiodo.Size = New System.Drawing.Size(116, 17)
        Me.chkperiodo.TabIndex = 6
        Me.chkperiodo.Text = "Todos los Periodos"
        Me.chkperiodo.UseVisualStyleBackColor = True
        '
        'btnquinta
        '
        Me.btnquinta.Location = New System.Drawing.Point(136, 89)
        Me.btnquinta.Name = "btnquinta"
        Me.btnquinta.Size = New System.Drawing.Size(93, 36)
        Me.btnquinta.TabIndex = 7
        Me.btnquinta.Text = "Genera Quinta"
        Me.btnquinta.UseVisualStyleBackColor = True
        '
        'dgvt_doc
        '
        Me.dgvt_doc.AllowUserToAddRows = False
        Me.dgvt_doc.AllowUserToDeleteRows = False
        Me.dgvt_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvt_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt_doc.Location = New System.Drawing.Point(12, 143)
        Me.dgvt_doc.Name = "dgvt_doc"
        Me.dgvt_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvt_doc.Size = New System.Drawing.Size(808, 208)
        Me.dgvt_doc.TabIndex = 32
        '
        'btnctsessalud
        '
        Me.btnctsessalud.Location = New System.Drawing.Point(227, 34)
        Me.btnctsessalud.Name = "btnctsessalud"
        Me.btnctsessalud.Size = New System.Drawing.Size(94, 23)
        Me.btnctsessalud.TabIndex = 33
        Me.btnctsessalud.Text = "CTS/ESSALUD"
        Me.btnctsessalud.UseVisualStyleBackColor = True
        Me.btnctsessalud.Visible = False
        '
        'FormMantPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 135)
        Me.Controls.Add(Me.btnctsessalud)
        Me.Controls.Add(Me.dgvt_doc)
        Me.Controls.Add(Me.btnquinta)
        Me.Controls.Add(Me.chkperiodo)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btngrati)
        Me.Controls.Add(Me.dtpfec_ini)
        Me.Controls.Add(Me.cmbt_pago)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_periodo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormMantPlanilla"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMantPlanilla"
        CType(Me.dgvt_doc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_periodo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbt_pago As ComboBox
    Friend WithEvents dtpfec_ini As DateTimePicker
    Friend WithEvents btngrati As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents chkperiodo As CheckBox
    Friend WithEvents btnquinta As Button
    Friend WithEvents dgvt_doc As DataGridView
    Friend WithEvents btnctsessalud As Button
End Class
