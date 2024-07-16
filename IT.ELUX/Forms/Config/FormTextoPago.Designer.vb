<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTextoPago
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
        Me.Cmbt_per2 = New System.Windows.Forms.ComboBox()
        Me.Cmbt_per1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpfec_ini = New System.Windows.Forms.DateTimePicker()
        Me.txt_periodo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.cmbt_pago = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cmbt_per2
        '
        Me.Cmbt_per2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbt_per2.FormattingEnabled = True
        Me.Cmbt_per2.Items.AddRange(New Object() {"", "OBREROS", "EMPLEADOS"})
        Me.Cmbt_per2.Location = New System.Drawing.Point(216, 100)
        Me.Cmbt_per2.Name = "Cmbt_per2"
        Me.Cmbt_per2.Size = New System.Drawing.Size(89, 21)
        Me.Cmbt_per2.TabIndex = 41
        '
        'Cmbt_per1
        '
        Me.Cmbt_per1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbt_per1.FormattingEnabled = True
        Me.Cmbt_per1.Items.AddRange(New Object() {"", "OBREROS", "EMPLEADOS"})
        Me.Cmbt_per1.Location = New System.Drawing.Point(120, 100)
        Me.Cmbt_per1.Name = "Cmbt_per1"
        Me.Cmbt_per1.Size = New System.Drawing.Size(89, 21)
        Me.Cmbt_per1.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Tipo Personal"
        '
        'dtpfec_ini
        '
        Me.dtpfec_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ini.Location = New System.Drawing.Point(120, 43)
        Me.dtpfec_ini.Name = "dtpfec_ini"
        Me.dtpfec_ini.ShowCheckBox = True
        Me.dtpfec_ini.Size = New System.Drawing.Size(100, 20)
        Me.dtpfec_ini.TabIndex = 46
        '
        'txt_periodo
        '
        Me.txt_periodo.Location = New System.Drawing.Point(120, 18)
        Me.txt_periodo.Name = "txt_periodo"
        Me.txt_periodo.Size = New System.Drawing.Size(100, 20)
        Me.txt_periodo.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Periodo"
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(120, 133)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 42
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(213, 133)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(86, 36)
        Me.btnsalir.TabIndex = 43
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'cmbt_pago
        '
        Me.cmbt_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbt_pago.FormattingEnabled = True
        Me.cmbt_pago.Items.AddRange(New Object() {"", "MENSUAL", "GRATIFICACION", "QUINCENAL"})
        Me.cmbt_pago.Location = New System.Drawing.Point(120, 69)
        Me.cmbt_pago.Name = "cmbt_pago"
        Me.cmbt_pago.Size = New System.Drawing.Size(185, 21)
        Me.cmbt_pago.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Tipo Planilla"
        '
        'FormTextoPago
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 196)
        Me.Controls.Add(Me.Cmbt_per2)
        Me.Controls.Add(Me.Cmbt_per1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpfec_ini)
        Me.Controls.Add(Me.txt_periodo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.cmbt_pago)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormTextoPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTextoPago"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cmbt_per2 As ComboBox
    Friend WithEvents Cmbt_per1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpfec_ini As DateTimePicker
    Friend WithEvents txt_periodo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnreporte As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents cmbt_pago As ComboBox
    Friend WithEvents Label2 As Label
End Class
