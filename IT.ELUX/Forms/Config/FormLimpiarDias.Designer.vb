<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLimpiarDias
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
        Me.rdbtodo = New System.Windows.Forms.RadioButton()
        Me.rdbobreros = New System.Windows.Forms.RadioButton()
        Me.rdbempleados = New System.Windows.Forms.RadioButton()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.rdbcpto = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbcpto)
        Me.GroupBox1.Controls.Add(Me.rdbtodo)
        Me.GroupBox1.Controls.Add(Me.rdbobreros)
        Me.GroupBox1.Controls.Add(Me.rdbempleados)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(194, 134)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'rdbtodo
        '
        Me.rdbtodo.AutoSize = True
        Me.rdbtodo.Location = New System.Drawing.Point(27, 65)
        Me.rdbtodo.Name = "rdbtodo"
        Me.rdbtodo.Size = New System.Drawing.Size(115, 17)
        Me.rdbtodo.TabIndex = 2
        Me.rdbtodo.TabStop = True
        Me.rdbtodo.Text = "Limpiar Dias Todos"
        Me.rdbtodo.UseVisualStyleBackColor = True
        '
        'rdbobreros
        '
        Me.rdbobreros.AutoSize = True
        Me.rdbobreros.Location = New System.Drawing.Point(27, 42)
        Me.rdbobreros.Name = "rdbobreros"
        Me.rdbobreros.Size = New System.Drawing.Size(122, 17)
        Me.rdbobreros.TabIndex = 1
        Me.rdbobreros.TabStop = True
        Me.rdbobreros.Text = "Limpiar Dias Obreros"
        Me.rdbobreros.UseVisualStyleBackColor = True
        '
        'rdbempleados
        '
        Me.rdbempleados.AutoSize = True
        Me.rdbempleados.Location = New System.Drawing.Point(27, 19)
        Me.rdbempleados.Name = "rdbempleados"
        Me.rdbempleados.Size = New System.Drawing.Size(134, 17)
        Me.rdbempleados.TabIndex = 0
        Me.rdbempleados.TabStop = True
        Me.rdbempleados.Text = "Limpiar DiasEmpleados"
        Me.rdbempleados.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(80, 152)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpiar.TabIndex = 1
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'rdbcpto
        '
        Me.rdbcpto.AutoSize = True
        Me.rdbcpto.Location = New System.Drawing.Point(27, 88)
        Me.rdbcpto.Name = "rdbcpto"
        Me.rdbcpto.Size = New System.Drawing.Size(112, 17)
        Me.rdbcpto.TabIndex = 3
        Me.rdbcpto.TabStop = True
        Me.rdbcpto.Text = "Limpiar Conceptos"
        Me.rdbcpto.UseVisualStyleBackColor = True
        '
        'FormLimpiarDias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 187)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormLimpiarDias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLimpiarDias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbobreros As RadioButton
    Friend WithEvents rdbempleados As RadioButton
    Friend WithEvents rdbtodo As RadioButton
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents rdbcpto As RadioButton
End Class
