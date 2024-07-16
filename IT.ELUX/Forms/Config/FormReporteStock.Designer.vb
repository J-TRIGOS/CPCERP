<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteStock
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtanchomin = New System.Windows.Forms.NumericUpDown()
        Me.txtlargmin = New System.Windows.Forms.NumericUpDown()
        Me.txtempmin = New System.Windows.Forms.NumericUpDown()
        Me.txtespesmin = New System.Windows.Forms.NumericUpDown()
        Me.txtanchomax = New System.Windows.Forms.NumericUpDown()
        Me.txtlargmax = New System.Windows.Forms.NumericUpDown()
        Me.txtempmax = New System.Windows.Forms.NumericUpDown()
        Me.txtespesmax = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        CType(Me.txtanchomin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtlargmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtempmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtespesmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtanchomax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtlargmax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtempmax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtespesmax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ancho"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Largo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Temple"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Espesor"
        '
        'txtanchomin
        '
        Me.txtanchomin.DecimalPlaces = 2
        Me.txtanchomin.Location = New System.Drawing.Point(127, 65)
        Me.txtanchomin.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtanchomin.Name = "txtanchomin"
        Me.txtanchomin.Size = New System.Drawing.Size(64, 20)
        Me.txtanchomin.TabIndex = 4
        '
        'txtlargmin
        '
        Me.txtlargmin.DecimalPlaces = 2
        Me.txtlargmin.Location = New System.Drawing.Point(127, 93)
        Me.txtlargmin.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtlargmin.Name = "txtlargmin"
        Me.txtlargmin.Size = New System.Drawing.Size(64, 20)
        Me.txtlargmin.TabIndex = 5
        '
        'txtempmin
        '
        Me.txtempmin.DecimalPlaces = 2
        Me.txtempmin.Location = New System.Drawing.Point(127, 124)
        Me.txtempmin.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtempmin.Name = "txtempmin"
        Me.txtempmin.Size = New System.Drawing.Size(64, 20)
        Me.txtempmin.TabIndex = 6
        '
        'txtespesmin
        '
        Me.txtespesmin.DecimalPlaces = 2
        Me.txtespesmin.Location = New System.Drawing.Point(127, 155)
        Me.txtespesmin.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtespesmin.Name = "txtespesmin"
        Me.txtespesmin.Size = New System.Drawing.Size(64, 20)
        Me.txtespesmin.TabIndex = 7
        '
        'txtanchomax
        '
        Me.txtanchomax.DecimalPlaces = 2
        Me.txtanchomax.Location = New System.Drawing.Point(229, 65)
        Me.txtanchomax.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtanchomax.Name = "txtanchomax"
        Me.txtanchomax.Size = New System.Drawing.Size(64, 20)
        Me.txtanchomax.TabIndex = 8
        '
        'txtlargmax
        '
        Me.txtlargmax.DecimalPlaces = 2
        Me.txtlargmax.Location = New System.Drawing.Point(229, 93)
        Me.txtlargmax.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtlargmax.Name = "txtlargmax"
        Me.txtlargmax.Size = New System.Drawing.Size(64, 20)
        Me.txtlargmax.TabIndex = 9
        '
        'txtempmax
        '
        Me.txtempmax.DecimalPlaces = 2
        Me.txtempmax.Location = New System.Drawing.Point(229, 124)
        Me.txtempmax.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtempmax.Name = "txtempmax"
        Me.txtempmax.Size = New System.Drawing.Size(64, 20)
        Me.txtempmax.TabIndex = 10
        '
        'txtespesmax
        '
        Me.txtespesmax.DecimalPlaces = 2
        Me.txtespesmax.Location = New System.Drawing.Point(229, 155)
        Me.txtespesmax.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtespesmax.Name = "txtespesmax"
        Me.txtespesmax.Size = New System.Drawing.Size(64, 20)
        Me.txtespesmax.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(237, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Máximo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(137, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Mínimo"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(171, 200)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 14
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'FormReporteStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 247)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtespesmax)
        Me.Controls.Add(Me.txtempmax)
        Me.Controls.Add(Me.txtlargmax)
        Me.Controls.Add(Me.txtanchomax)
        Me.Controls.Add(Me.txtespesmin)
        Me.Controls.Add(Me.txtempmin)
        Me.Controls.Add(Me.txtlargmin)
        Me.Controls.Add(Me.txtanchomin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormReporteStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Stock Articulos"
        CType(Me.txtanchomin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtlargmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtempmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtespesmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtanchomax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtlargmax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtempmax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtespesmax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtanchomin As NumericUpDown
    Friend WithEvents txtlargmin As NumericUpDown
    Friend WithEvents txtempmin As NumericUpDown
    Friend WithEvents txtespesmin As NumericUpDown
    Friend WithEvents txtanchomax As NumericUpDown
    Friend WithEvents txtlargmax As NumericUpDown
    Friend WithEvents txtempmax As NumericUpDown
    Friend WithEvents txtespesmax As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnImprimir As Button
End Class
