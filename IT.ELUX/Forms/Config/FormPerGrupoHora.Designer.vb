﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPerGrupoHora
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tsbMant = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbccosto = New System.Windows.Forms.ToolStripComboBox()
        Me.tsbCamposSeek = New System.Windows.Forms.ToolStripComboBox()
        Me.tsTextSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tstLblInfo = New System.Windows.Forms.ToolStripLabel()
        Me.dgvbusqueda = New System.Windows.Forms.DataGridView()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbcosto = New System.Windows.Forms.ComboBox()
        Me.tsbMant.SuspendLayout()
        CType(Me.dgvbusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsbMant
        '
        Me.tsbMant.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.ToolStripLabel1, Me.cmbccosto, Me.tsbCamposSeek, Me.tsTextSearch, Me.ToolStripSeparator4, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.tstLblInfo})
        Me.tsbMant.Location = New System.Drawing.Point(0, 0)
        Me.tsbMant.Name = "tsbMant"
        Me.tsbMant.Size = New System.Drawing.Size(736, 25)
        Me.tsbMant.TabIndex = 2
        Me.tsbMant.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(130, 22)
        Me.ToolStripLabel1.Text = "Busqueda por campo :"
        '
        'cmbccosto
        '
        Me.cmbccosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbccosto.DropDownWidth = 150
        Me.cmbccosto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbccosto.Name = "cmbccosto"
        Me.cmbccosto.Size = New System.Drawing.Size(200, 25)
        '
        'tsbCamposSeek
        '
        Me.tsbCamposSeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tsbCamposSeek.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbCamposSeek.Name = "tsbCamposSeek"
        Me.tsbCamposSeek.Size = New System.Drawing.Size(121, 25)
        '
        'tsTextSearch
        '
        Me.tsTextSearch.BackColor = System.Drawing.SystemColors.Info
        Me.tsTextSearch.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsTextSearch.Name = "tsTextSearch"
        Me.tsTextSearch.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(139, 15)
        Me.ToolStripLabel2.Text = "                                            "
        '
        'tstLblInfo
        '
        Me.tstLblInfo.AutoSize = False
        Me.tstLblInfo.BackColor = System.Drawing.Color.Silver
        Me.tstLblInfo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tstLblInfo.Name = "tstLblInfo"
        Me.tstLblInfo.Size = New System.Drawing.Size(90, 22)
        '
        'dgvbusqueda
        '
        Me.dgvbusqueda.AllowUserToAddRows = False
        Me.dgvbusqueda.AllowUserToDeleteRows = False
        Me.dgvbusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvbusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbusqueda.Location = New System.Drawing.Point(12, 67)
        Me.dgvbusqueda.Name = "dgvbusqueda"
        Me.dgvbusqueda.ReadOnly = True
        Me.dgvbusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvbusqueda.Size = New System.Drawing.Size(712, 220)
        Me.dgvbusqueda.TabIndex = 11
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(627, 38)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 10
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(490, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Pasar Todos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbcosto
        '
        Me.cmbcosto.FormattingEnabled = True
        Me.cmbcosto.Location = New System.Drawing.Point(549, 84)
        Me.cmbcosto.Name = "cmbcosto"
        Me.cmbcosto.Size = New System.Drawing.Size(121, 21)
        Me.cmbcosto.TabIndex = 19
        '
        'FormPerGrupoHora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 306)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvbusqueda)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.tsbMant)
        Me.Controls.Add(Me.cmbcosto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "FormPerGrupoHora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPerGrupoHora"
        Me.tsbMant.ResumeLayout(False)
        Me.tsbMant.PerformLayout()
        CType(Me.dgvbusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsbMant As ToolStrip
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents tsbCamposSeek As ToolStripComboBox
    Friend WithEvents tsTextSearch As ToolStripTextBox
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents tstLblInfo As ToolStripLabel
    Friend WithEvents dgvbusqueda As DataGridView
    Friend WithEvents btnsalir As Button
    Friend WithEvents cmbccosto As ToolStripComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbcosto As ComboBox
End Class
