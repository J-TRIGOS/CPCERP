﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptBalanceComp
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
        Me.cmbaño = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbmes1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbmes2 = New System.Windows.Forms.ComboBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbaño
        '
        Me.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbaño.Location = New System.Drawing.Point(64, 46)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(121, 21)
        Me.cmbaño.TabIndex = 85
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Mes1 :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Año :"
        '
        'cmbmes1
        '
        Me.cmbmes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes1.FormattingEnabled = True
        Me.cmbmes1.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes1.Location = New System.Drawing.Point(64, 74)
        Me.cmbmes1.Name = "cmbmes1"
        Me.cmbmes1.Size = New System.Drawing.Size(152, 21)
        Me.cmbmes1.TabIndex = 86
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(225, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Mes2 :"
        '
        'cmbmes2
        '
        Me.cmbmes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes2.FormattingEnabled = True
        Me.cmbmes2.Items.AddRange(New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbmes2.Location = New System.Drawing.Point(270, 74)
        Me.cmbmes2.Name = "cmbmes2"
        Me.cmbmes2.Size = New System.Drawing.Size(180, 21)
        Me.cmbmes2.TabIndex = 89
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(228, 126)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 149
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(132, 126)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(75, 36)
        Me.btnreporte.TabIndex = 148
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'FormRptBalanceComp
        '
        Me.AcceptButton = Me.btnreporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 191)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbmes2)
        Me.Controls.Add(Me.cmbaño)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbmes1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRptBalanceComp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRptBalanceComp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbaño As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbmes1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbmes2 As ComboBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnreporte As Button
End Class
