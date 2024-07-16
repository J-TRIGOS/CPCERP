<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistroBonoNocturno
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
        Me.txt_prdo = New System.Windows.Forms.TextBox()
        Me.txt_nomprdo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.datFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.datFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.btn_procesar = New System.Windows.Forms.Button()
        Me.dgv_nocturno = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_bono = New System.Windows.Forms.Label()
        CType(Me.dgv_nocturno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Periodo: "
        '
        'txt_prdo
        '
        Me.txt_prdo.Location = New System.Drawing.Point(85, 21)
        Me.txt_prdo.Name = "txt_prdo"
        Me.txt_prdo.Size = New System.Drawing.Size(33, 20)
        Me.txt_prdo.TabIndex = 1
        Me.txt_prdo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_nomprdo
        '
        Me.txt_nomprdo.Enabled = False
        Me.txt_nomprdo.Location = New System.Drawing.Point(124, 21)
        Me.txt_nomprdo.Name = "txt_nomprdo"
        Me.txt_nomprdo.Size = New System.Drawing.Size(52, 20)
        Me.txt_nomprdo.TabIndex = 2
        Me.txt_nomprdo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Desde"
        '
        'datFechaIni
        '
        Me.datFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datFechaIni.Location = New System.Drawing.Point(85, 47)
        Me.datFechaIni.Name = "datFechaIni"
        Me.datFechaIni.Size = New System.Drawing.Size(91, 20)
        Me.datFechaIni.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hasta"
        '
        'datFechaFin
        '
        Me.datFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datFechaFin.Location = New System.Drawing.Point(225, 47)
        Me.datFechaFin.Name = "datFechaFin"
        Me.datFechaFin.Size = New System.Drawing.Size(93, 20)
        Me.datFechaFin.TabIndex = 6
        '
        'btn_procesar
        '
        Me.btn_procesar.Location = New System.Drawing.Point(225, 19)
        Me.btn_procesar.Name = "btn_procesar"
        Me.btn_procesar.Size = New System.Drawing.Size(101, 23)
        Me.btn_procesar.TabIndex = 7
        Me.btn_procesar.Text = "Procesar Periodo"
        Me.btn_procesar.UseVisualStyleBackColor = True
        '
        'dgv_nocturno
        '
        Me.dgv_nocturno.AllowUserToAddRows = False
        Me.dgv_nocturno.AllowUserToDeleteRows = False
        Me.dgv_nocturno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_nocturno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_nocturno.Location = New System.Drawing.Point(12, 84)
        Me.dgv_nocturno.Name = "dgv_nocturno"
        Me.dgv_nocturno.ReadOnly = True
        Me.dgv_nocturno.Size = New System.Drawing.Size(689, 652)
        Me.dgv_nocturno.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(526, 743)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total Bono: "
        '
        'lbl_bono
        '
        Me.lbl_bono.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_bono.AutoSize = True
        Me.lbl_bono.Location = New System.Drawing.Point(597, 743)
        Me.lbl_bono.Name = "lbl_bono"
        Me.lbl_bono.Size = New System.Drawing.Size(0, 13)
        Me.lbl_bono.TabIndex = 10
        '
        'FormRegistroBonoNocturno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 764)
        Me.Controls.Add(Me.lbl_bono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgv_nocturno)
        Me.Controls.Add(Me.btn_procesar)
        Me.Controls.Add(Me.datFechaFin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.datFechaIni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nomprdo)
        Me.Controls.Add(Me.txt_prdo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormRegistroBonoNocturno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRegistroBonoNocturno"
        CType(Me.dgv_nocturno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_prdo As TextBox
    Friend WithEvents txt_nomprdo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents datFechaIni As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents datFechaFin As DateTimePicker
    Friend WithEvents btn_procesar As Button
    Friend WithEvents dgv_nocturno As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_bono As Label
End Class
