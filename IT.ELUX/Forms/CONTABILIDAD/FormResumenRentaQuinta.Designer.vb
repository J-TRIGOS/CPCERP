<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormResumenRentaQuinta
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
        Me.cmbaño2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbmes1 = New System.Windows.Forms.ComboBox()
        Me.cmbmes2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbTipTra = New System.Windows.Forms.ComboBox()
        Me.BtnReporte = New System.Windows.Forms.Button()
        Me.ChkUtilidad = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cmbaño2
        '
        Me.cmbaño2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño2.FormattingEnabled = True
        Me.cmbaño2.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño2.Location = New System.Drawing.Point(250, 20)
        Me.cmbaño2.Name = "cmbaño2"
        Me.cmbaño2.Size = New System.Drawing.Size(87, 21)
        Me.cmbaño2.TabIndex = 161
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(197, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 162
        Me.Label1.Text = "Año2 :"
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño.Location = New System.Drawing.Point(78, 20)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(92, 21)
        Me.cmbaño.TabIndex = 155
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(196, 51)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 13)
        Me.Label16.TabIndex = 160
        Me.Label16.Text = "Mes2 :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(24, 51)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 13)
        Me.Label17.TabIndex = 158
        Me.Label17.Text = "Mes1 :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(25, 23)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(38, 13)
        Me.Label22.TabIndex = 159
        Me.Label22.Text = "Año1 :"
        '
        'cmbmes1
        '
        Me.cmbmes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes1.FormattingEnabled = True
        Me.cmbmes1.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes1.Location = New System.Drawing.Point(78, 48)
        Me.cmbmes1.Name = "cmbmes1"
        Me.cmbmes1.Size = New System.Drawing.Size(92, 21)
        Me.cmbmes1.TabIndex = 156
        '
        'cmbmes2
        '
        Me.cmbmes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes2.FormattingEnabled = True
        Me.cmbmes2.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes2.Location = New System.Drawing.Point(250, 48)
        Me.cmbmes2.Name = "cmbmes2"
        Me.cmbmes2.Size = New System.Drawing.Size(87, 21)
        Me.cmbmes2.TabIndex = 157
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 163
        Me.Label2.Text = "Tipo Trabajador"
        '
        'CmbTipTra
        '
        Me.CmbTipTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipTra.FormattingEnabled = True
        Me.CmbTipTra.Items.AddRange(New Object() {"TODOS", "EMPLEADOS", "OBREROS"})
        Me.CmbTipTra.Location = New System.Drawing.Point(113, 83)
        Me.CmbTipTra.Name = "CmbTipTra"
        Me.CmbTipTra.Size = New System.Drawing.Size(136, 21)
        Me.CmbTipTra.TabIndex = 164
        '
        'BtnReporte
        '
        Me.BtnReporte.Location = New System.Drawing.Point(28, 115)
        Me.BtnReporte.Name = "BtnReporte"
        Me.BtnReporte.Size = New System.Drawing.Size(75, 23)
        Me.BtnReporte.TabIndex = 165
        Me.BtnReporte.Text = "REPORTE"
        Me.BtnReporte.UseVisualStyleBackColor = True
        '
        'ChkUtilidad
        '
        Me.ChkUtilidad.AutoSize = True
        Me.ChkUtilidad.Location = New System.Drawing.Point(357, 20)
        Me.ChkUtilidad.Name = "ChkUtilidad"
        Me.ChkUtilidad.Size = New System.Drawing.Size(105, 17)
        Me.ChkUtilidad.TabIndex = 166
        Me.ChkUtilidad.Text = "Util. Año Anterior"
        Me.ChkUtilidad.UseVisualStyleBackColor = True
        '
        'FormResumenRentaQuinta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 184)
        Me.Controls.Add(Me.ChkUtilidad)
        Me.Controls.Add(Me.BtnReporte)
        Me.Controls.Add(Me.CmbTipTra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbaño2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbaño)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cmbmes1)
        Me.Controls.Add(Me.cmbmes2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormResumenRentaQuinta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormResumenRentaQuinta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbaño2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbaño As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cmbmes1 As ComboBox
    Friend WithEvents cmbmes2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbTipTra As ComboBox
    Friend WithEvents BtnReporte As Button
    Friend WithEvents ChkUtilidad As CheckBox
End Class
