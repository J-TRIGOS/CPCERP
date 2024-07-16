<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOpcionStock
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbno = New System.Windows.Forms.RadioButton()
        Me.rdbsi = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.rbdTotal = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbalmacen = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbdTotal)
        Me.GroupBox1.Controls.Add(Me.rdbno)
        Me.GroupBox1.Controls.Add(Me.rdbsi)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(199, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'rdbno
        '
        Me.rdbno.AutoSize = True
        Me.rdbno.Location = New System.Drawing.Point(35, 46)
        Me.rdbno.Name = "rdbno"
        Me.rdbno.Size = New System.Drawing.Size(114, 17)
        Me.rdbno.TabIndex = 1
        Me.rdbno.TabStop = True
        Me.rdbno.Text = "Todos los Articulos"
        Me.rdbno.UseVisualStyleBackColor = True
        '
        'rdbsi
        '
        Me.rdbsi.AutoSize = True
        Me.rdbsi.Location = New System.Drawing.Point(35, 23)
        Me.rdbsi.Name = "rdbsi"
        Me.rdbsi.Size = New System.Drawing.Size(98, 17)
        Me.rdbsi.TabIndex = 0
        Me.rdbsi.TabStop = True
        Me.rdbsi.Text = "Solo con Stock"
        Me.rdbsi.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(46, 156)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(127, 156)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'rbdTotal
        '
        Me.rbdTotal.AutoSize = True
        Me.rbdTotal.Location = New System.Drawing.Point(35, 69)
        Me.rbdTotal.Name = "rbdTotal"
        Me.rbdTotal.Size = New System.Drawing.Size(80, 17)
        Me.rbdTotal.TabIndex = 8
        Me.rbdTotal.TabStop = True
        Me.rbdTotal.Text = "Stock Total"
        Me.rbdTotal.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Almacen"
        Me.Label6.Visible = False
        '
        'cmbalmacen
        '
        Me.cmbalmacen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbalmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbalmacen.Items.AddRange(New Object() {"Todos", "0001-GALERA 108 PANAMA", "0002-FALLADO PANAMA"})
        Me.cmbalmacen.Location = New System.Drawing.Point(101, 129)
        Me.cmbalmacen.Name = "cmbalmacen"
        Me.cmbalmacen.Size = New System.Drawing.Size(101, 21)
        Me.cmbalmacen.TabIndex = 8
        Me.cmbalmacen.Visible = False
        '
        'FormOpcionStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 189)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbalmacen)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormOpcionStock"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormOpcionStock"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents rdbno As RadioButton
    Friend WithEvents rdbsi As RadioButton
    Friend WithEvents rbdTotal As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbalmacen As ComboBox
End Class
