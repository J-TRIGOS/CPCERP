<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetalleIngresos
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
        Me.lblper_cod = New System.Windows.Forms.Label()
        Me.txtper_cod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvPagos = New System.Windows.Forms.DataGridView()
        Me.Btn_Calculo = New System.Windows.Forms.Button()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        CType(Me.DgvPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblper_cod
        '
        Me.lblper_cod.BackColor = System.Drawing.Color.Gainsboro
        Me.lblper_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblper_cod.Location = New System.Drawing.Point(170, 19)
        Me.lblper_cod.Name = "lblper_cod"
        Me.lblper_cod.Size = New System.Drawing.Size(382, 21)
        Me.lblper_cod.TabIndex = 142
        Me.lblper_cod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtper_cod
        '
        Me.txtper_cod.Location = New System.Drawing.Point(79, 19)
        Me.txtper_cod.MaxLength = 8
        Me.txtper_cod.Name = "txtper_cod"
        Me.txtper_cod.Size = New System.Drawing.Size(90, 20)
        Me.txtper_cod.TabIndex = 140
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Personal"
        '
        'DgvPagos
        '
        Me.DgvPagos.AllowUserToAddRows = False
        Me.DgvPagos.AllowUserToDeleteRows = False
        Me.DgvPagos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPagos.Location = New System.Drawing.Point(12, 45)
        Me.DgvPagos.Name = "DgvPagos"
        Me.DgvPagos.ReadOnly = True
        Me.DgvPagos.Size = New System.Drawing.Size(945, 270)
        Me.DgvPagos.TabIndex = 144
        '
        'Btn_Calculo
        '
        Me.Btn_Calculo.Location = New System.Drawing.Point(558, 19)
        Me.Btn_Calculo.Name = "Btn_Calculo"
        Me.Btn_Calculo.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Calculo.TabIndex = 145
        Me.Btn_Calculo.Text = "Calcular"
        Me.Btn_Calculo.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Location = New System.Drawing.Point(639, 18)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Exportar.TabIndex = 146
        Me.btn_Exportar.Text = "Exportar"
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'FormDetalleIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 327)
        Me.Controls.Add(Me.btn_Exportar)
        Me.Controls.Add(Me.Btn_Calculo)
        Me.Controls.Add(Me.DgvPagos)
        Me.Controls.Add(Me.lblper_cod)
        Me.Controls.Add(Me.txtper_cod)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormDetalleIngresos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDetalleIngresos"
        CType(Me.DgvPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblper_cod As Label
    Friend WithEvents txtper_cod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvPagos As DataGridView
    Friend WithEvents Btn_Calculo As Button
    Friend WithEvents btn_Exportar As Button
End Class
