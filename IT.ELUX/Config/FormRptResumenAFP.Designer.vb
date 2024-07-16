<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptResumenAFP
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
        Me.chkperiodo = New System.Windows.Forms.CheckBox()
        Me.dtpfec_ini = New System.Windows.Forms.DateTimePicker()
        Me.txt_periodo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnsalir2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txt_periodo1 = New System.Windows.Forms.TextBox()
        Me.btnreporte1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnsalir1 = New System.Windows.Forms.Button()
        Me.dtpfec_ini1 = New System.Windows.Forms.DateTimePicker()
        Me.chkperiodo1 = New System.Windows.Forms.CheckBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txt_periodo2 = New System.Windows.Forms.TextBox()
        Me.btnreporte2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dtpfec_ini2 = New System.Windows.Forms.DateTimePicker()
        Me.chkperiodo2 = New System.Windows.Forms.CheckBox()
        Me.btnsalir2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkperiodo
        '
        Me.chkperiodo.AutoSize = True
        Me.chkperiodo.Location = New System.Drawing.Point(236, 42)
        Me.chkperiodo.Name = "chkperiodo"
        Me.chkperiodo.Size = New System.Drawing.Size(116, 17)
        Me.chkperiodo.TabIndex = 40
        Me.chkperiodo.Text = "Todos los Periodos"
        Me.chkperiodo.UseVisualStyleBackColor = True
        '
        'dtpfec_ini
        '
        Me.dtpfec_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ini.Location = New System.Drawing.Point(130, 65)
        Me.dtpfec_ini.Name = "dtpfec_ini"
        Me.dtpfec_ini.ShowCheckBox = True
        Me.dtpfec_ini.Size = New System.Drawing.Size(100, 20)
        Me.dtpfec_ini.TabIndex = 39
        '
        'txt_periodo
        '
        Me.txt_periodo.Location = New System.Drawing.Point(130, 40)
        Me.txt_periodo.Name = "txt_periodo"
        Me.txt_periodo.Size = New System.Drawing.Size(100, 20)
        Me.txt_periodo.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Periodo"
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(130, 91)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 41
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(223, 91)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(86, 36)
        Me.btnsalir.TabIndex = 42
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnsalir2
        '
        Me.btnsalir2.Controls.Add(Me.TabPage1)
        Me.btnsalir2.Controls.Add(Me.TabPage2)
        Me.btnsalir2.Controls.Add(Me.TabPage3)
        Me.btnsalir2.Location = New System.Drawing.Point(12, 12)
        Me.btnsalir2.Name = "btnsalir2"
        Me.btnsalir2.SelectedIndex = 0
        Me.btnsalir2.Size = New System.Drawing.Size(416, 195)
        Me.btnsalir2.TabIndex = 43
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_periodo)
        Me.TabPage1.Controls.Add(Me.btnreporte)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnsalir)
        Me.TabPage1.Controls.Add(Me.dtpfec_ini)
        Me.TabPage1.Controls.Add(Me.chkperiodo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(408, 169)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "RESUMEN AFP"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txt_periodo1)
        Me.TabPage2.Controls.Add(Me.btnreporte1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.btnsalir1)
        Me.TabPage2.Controls.Add(Me.dtpfec_ini1)
        Me.TabPage2.Controls.Add(Me.chkperiodo1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(408, 169)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "HOJA DE TRABAJO AFP"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txt_periodo1
        '
        Me.txt_periodo1.Location = New System.Drawing.Point(130, 40)
        Me.txt_periodo1.Name = "txt_periodo1"
        Me.txt_periodo1.Size = New System.Drawing.Size(100, 20)
        Me.txt_periodo1.TabIndex = 43
        '
        'btnreporte1
        '
        Me.btnreporte1.Location = New System.Drawing.Point(130, 91)
        Me.btnreporte1.Name = "btnreporte1"
        Me.btnreporte1.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte1.TabIndex = 47
        Me.btnreporte1.Text = "Reporte"
        Me.btnreporte1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Periodo"
        '
        'btnsalir1
        '
        Me.btnsalir1.Location = New System.Drawing.Point(223, 91)
        Me.btnsalir1.Name = "btnsalir1"
        Me.btnsalir1.Size = New System.Drawing.Size(86, 36)
        Me.btnsalir1.TabIndex = 48
        Me.btnsalir1.Text = "Salir"
        Me.btnsalir1.UseVisualStyleBackColor = True
        '
        'dtpfec_ini1
        '
        Me.dtpfec_ini1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ini1.Location = New System.Drawing.Point(130, 65)
        Me.dtpfec_ini1.Name = "dtpfec_ini1"
        Me.dtpfec_ini1.ShowCheckBox = True
        Me.dtpfec_ini1.Size = New System.Drawing.Size(100, 20)
        Me.dtpfec_ini1.TabIndex = 45
        '
        'chkperiodo1
        '
        Me.chkperiodo1.AutoSize = True
        Me.chkperiodo1.Location = New System.Drawing.Point(236, 42)
        Me.chkperiodo1.Name = "chkperiodo1"
        Me.chkperiodo1.Size = New System.Drawing.Size(116, 17)
        Me.chkperiodo1.TabIndex = 46
        Me.chkperiodo1.Text = "Todos los Periodos"
        Me.chkperiodo1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txt_periodo2)
        Me.TabPage3.Controls.Add(Me.btnreporte2)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.dtpfec_ini2)
        Me.TabPage3.Controls.Add(Me.chkperiodo2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(408, 169)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TEXTO DE AFP"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txt_periodo2
        '
        Me.txt_periodo2.Location = New System.Drawing.Point(130, 40)
        Me.txt_periodo2.Name = "txt_periodo2"
        Me.txt_periodo2.Size = New System.Drawing.Size(100, 20)
        Me.txt_periodo2.TabIndex = 43
        '
        'btnreporte2
        '
        Me.btnreporte2.Location = New System.Drawing.Point(130, 91)
        Me.btnreporte2.Name = "btnreporte2"
        Me.btnreporte2.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte2.TabIndex = 47
        Me.btnreporte2.Text = "Reporte"
        Me.btnreporte2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Periodo"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(223, 91)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 36)
        Me.Button4.TabIndex = 48
        Me.Button4.Text = "Salir"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'dtpfec_ini2
        '
        Me.dtpfec_ini2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfec_ini2.Location = New System.Drawing.Point(130, 65)
        Me.dtpfec_ini2.Name = "dtpfec_ini2"
        Me.dtpfec_ini2.ShowCheckBox = True
        Me.dtpfec_ini2.Size = New System.Drawing.Size(100, 20)
        Me.dtpfec_ini2.TabIndex = 45
        '
        'chkperiodo2
        '
        Me.chkperiodo2.AutoSize = True
        Me.chkperiodo2.Location = New System.Drawing.Point(236, 42)
        Me.chkperiodo2.Name = "chkperiodo2"
        Me.chkperiodo2.Size = New System.Drawing.Size(116, 17)
        Me.chkperiodo2.TabIndex = 46
        Me.chkperiodo2.Text = "Todos los Periodos"
        Me.chkperiodo2.UseVisualStyleBackColor = True
        '
        'FormRptResumenAFP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 217)
        Me.Controls.Add(Me.btnsalir2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRptResumenAFP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen de AFP"
        Me.btnsalir2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chkperiodo As CheckBox
    Friend WithEvents dtpfec_ini As DateTimePicker
    Friend WithEvents txt_periodo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnreporte As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnsalir2 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_periodo1 As TextBox
    Friend WithEvents btnreporte1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnsalir1 As Button
    Friend WithEvents dtpfec_ini1 As DateTimePicker
    Friend WithEvents chkperiodo1 As CheckBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txt_periodo2 As TextBox
    Friend WithEvents btnreporte2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents dtpfec_ini2 As DateTimePicker
    Friend WithEvents chkperiodo2 As CheckBox
End Class
