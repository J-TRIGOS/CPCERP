﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMantDetGuiaAlmacen
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
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnregresar = New System.Windows.Forms.Button()
        Me.cmbNroArt = New System.Windows.Forms.GroupBox()
        Me.cmbNroDoc = New System.Windows.Forms.ComboBox()
        Me.cmbSerDocArt = New System.Windows.Forms.ComboBox()
        Me.txtndoc = New System.Windows.Forms.TextBox()
        Me.txtsdoc = New System.Windows.Forms.TextBox()
        Me.txttdoc = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodart = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.cmbuni = New System.Windows.Forms.ComboBox()
        Me.cmbart = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbsublinea = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmblinea = New System.Windows.Forms.ComboBox()
        Me.txtobservacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.npdcantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtlote = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbltmov = New System.Windows.Forms.Label()
        Me.cmbNroArt.SuspendLayout()
        CType(Me.npdcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(385, 297)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 14
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnregresar
        '
        Me.btnregresar.Location = New System.Drawing.Point(466, 297)
        Me.btnregresar.Name = "btnregresar"
        Me.btnregresar.Size = New System.Drawing.Size(75, 23)
        Me.btnregresar.TabIndex = 13
        Me.btnregresar.Text = "Salir"
        Me.btnregresar.UseVisualStyleBackColor = True
        '
        'cmbNroArt
        '
        Me.cmbNroArt.Controls.Add(Me.cmbNroDoc)
        Me.cmbNroArt.Controls.Add(Me.cmbSerDocArt)
        Me.cmbNroArt.Controls.Add(Me.txtndoc)
        Me.cmbNroArt.Controls.Add(Me.txtsdoc)
        Me.cmbNroArt.Controls.Add(Me.txttdoc)
        Me.cmbNroArt.Controls.Add(Me.Label12)
        Me.cmbNroArt.Controls.Add(Me.Label11)
        Me.cmbNroArt.Controls.Add(Me.Label10)
        Me.cmbNroArt.Controls.Add(Me.DateTimePicker1)
        Me.cmbNroArt.Controls.Add(Me.Label1)
        Me.cmbNroArt.Controls.Add(Me.txtcodart)
        Me.cmbNroArt.Controls.Add(Me.btnbuscar)
        Me.cmbNroArt.Controls.Add(Me.cmbuni)
        Me.cmbNroArt.Controls.Add(Me.cmbart)
        Me.cmbNroArt.Controls.Add(Me.Label22)
        Me.cmbNroArt.Controls.Add(Me.txtstock)
        Me.cmbNroArt.Controls.Add(Me.Label8)
        Me.cmbNroArt.Controls.Add(Me.cmbsublinea)
        Me.cmbNroArt.Controls.Add(Me.Label7)
        Me.cmbNroArt.Controls.Add(Me.cmblinea)
        Me.cmbNroArt.Controls.Add(Me.txtobservacion)
        Me.cmbNroArt.Controls.Add(Me.Label6)
        Me.cmbNroArt.Controls.Add(Me.npdcantidad)
        Me.cmbNroArt.Controls.Add(Me.Label5)
        Me.cmbNroArt.Controls.Add(Me.txtlote)
        Me.cmbNroArt.Controls.Add(Me.Label4)
        Me.cmbNroArt.Controls.Add(Me.Label2)
        Me.cmbNroArt.Controls.Add(Me.Label3)
        Me.cmbNroArt.Location = New System.Drawing.Point(12, 12)
        Me.cmbNroArt.Name = "cmbNroArt"
        Me.cmbNroArt.Size = New System.Drawing.Size(606, 279)
        Me.cmbNroArt.TabIndex = 11
        Me.cmbNroArt.TabStop = False
        '
        'cmbNroDoc
        '
        Me.cmbNroDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNroDoc.FormattingEnabled = True
        Me.cmbNroDoc.Location = New System.Drawing.Point(395, 151)
        Me.cmbNroDoc.Name = "cmbNroDoc"
        Me.cmbNroDoc.Size = New System.Drawing.Size(123, 21)
        Me.cmbNroDoc.TabIndex = 38
        Me.cmbNroDoc.Visible = False
        '
        'cmbSerDocArt
        '
        Me.cmbSerDocArt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSerDocArt.FormattingEnabled = True
        Me.cmbSerDocArt.Location = New System.Drawing.Point(513, 127)
        Me.cmbSerDocArt.Name = "cmbSerDocArt"
        Me.cmbSerDocArt.Size = New System.Drawing.Size(66, 21)
        Me.cmbSerDocArt.TabIndex = 37
        Me.cmbSerDocArt.Visible = False
        '
        'txtndoc
        '
        Me.txtndoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtndoc.Location = New System.Drawing.Point(396, 152)
        Me.txtndoc.Name = "txtndoc"
        Me.txtndoc.Size = New System.Drawing.Size(122, 20)
        Me.txtndoc.TabIndex = 36
        '
        'txtsdoc
        '
        Me.txtsdoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsdoc.Location = New System.Drawing.Point(513, 127)
        Me.txtsdoc.Name = "txtsdoc"
        Me.txtsdoc.Size = New System.Drawing.Size(66, 20)
        Me.txtsdoc.TabIndex = 35
        '
        'txttdoc
        '
        Me.txttdoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttdoc.Location = New System.Drawing.Point(395, 127)
        Me.txttdoc.Name = "txttdoc"
        Me.txttdoc.Size = New System.Drawing.Size(53, 20)
        Me.txttdoc.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(349, 155)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "N. Doc"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(467, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "S. Doc"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(349, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "T. Doc"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(241, 129)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowCheckBox = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(102, 20)
        Me.DateTimePicker1.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(157, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Fecha Llegada"
        '
        'txtcodart
        '
        Me.txtcodart.Location = New System.Drawing.Point(70, 67)
        Me.txtcodart.Name = "txtcodart"
        Me.txtcodart.Size = New System.Drawing.Size(84, 20)
        Me.txtcodart.TabIndex = 28
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(553, 68)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(32, 23)
        Me.btnbuscar.TabIndex = 27
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'cmbuni
        '
        Me.cmbuni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbuni.Enabled = False
        Me.cmbuni.FormattingEnabled = True
        Me.cmbuni.Location = New System.Drawing.Point(70, 100)
        Me.cmbuni.Name = "cmbuni"
        Me.cmbuni.Size = New System.Drawing.Size(162, 21)
        Me.cmbuni.TabIndex = 26
        '
        'cmbart
        '
        Me.cmbart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbart.FormattingEnabled = True
        Me.cmbart.Location = New System.Drawing.Point(160, 67)
        Me.cmbart.Name = "cmbart"
        Me.cmbart.Size = New System.Drawing.Size(386, 21)
        Me.cmbart.TabIndex = 25
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(7, 70)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(46, 13)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "Codigo :"
        '
        'txtstock
        '
        Me.txtstock.Enabled = False
        Me.txtstock.Location = New System.Drawing.Point(70, 127)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(76, 20)
        Me.txtstock.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Stock"
        '
        'cmbsublinea
        '
        Me.cmbsublinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsublinea.FormattingEnabled = True
        Me.cmbsublinea.Location = New System.Drawing.Point(70, 40)
        Me.cmbsublinea.Name = "cmbsublinea"
        Me.cmbsublinea.Size = New System.Drawing.Size(515, 21)
        Me.cmbsublinea.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Sub Linea"
        '
        'cmblinea
        '
        Me.cmblinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblinea.FormattingEnabled = True
        Me.cmblinea.Location = New System.Drawing.Point(70, 13)
        Me.cmblinea.Name = "cmblinea"
        Me.cmblinea.Size = New System.Drawing.Size(515, 21)
        Me.cmblinea.TabIndex = 1
        '
        'txtobservacion
        '
        Me.txtobservacion.Enabled = False
        Me.txtobservacion.Location = New System.Drawing.Point(12, 181)
        Me.txtobservacion.Multiline = True
        Me.txtobservacion.Name = "txtobservacion"
        Me.txtobservacion.Size = New System.Drawing.Size(579, 80)
        Me.txtobservacion.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Observacion"
        '
        'npdcantidad
        '
        Me.npdcantidad.DecimalPlaces = 3
        Me.npdcantidad.Location = New System.Drawing.Point(293, 103)
        Me.npdcantidad.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.npdcantidad.Name = "npdcantidad"
        Me.npdcantidad.Size = New System.Drawing.Size(106, 20)
        Me.npdcantidad.TabIndex = 10
        Me.npdcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Linea"
        '
        'txtlote
        '
        Me.txtlote.Location = New System.Drawing.Point(439, 102)
        Me.txtlote.Name = "txtlote"
        Me.txtlote.Size = New System.Drawing.Size(146, 20)
        Me.txtlote.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(405, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Lote"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Unidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(238, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(568, 307)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Stock"
        Me.Label9.Visible = False
        '
        'lbltmov
        '
        Me.lbltmov.AutoSize = True
        Me.lbltmov.Location = New System.Drawing.Point(294, 307)
        Me.lbltmov.Name = "lbltmov"
        Me.lbltmov.Size = New System.Drawing.Size(45, 13)
        Me.lbltmov.TabIndex = 19
        Me.lbltmov.Text = "Label13"
        Me.lbltmov.Visible = False
        '
        'FormMantDetGuiaAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 333)
        Me.Controls.Add(Me.lbltmov)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.btnregresar)
        Me.Controls.Add(Me.cmbNroArt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormMantDetGuiaAlmacen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMantDetGuiaAlmacen"
        Me.cmbNroArt.ResumeLayout(False)
        Me.cmbNroArt.PerformLayout()
        CType(Me.npdcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnagregar As Button
    Friend WithEvents btnregresar As Button
    Friend WithEvents cmbNroArt As GroupBox
    Friend WithEvents txtobservacion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents npdcantidad As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents txtlote As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbsublinea As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmblinea As ComboBox
    Friend WithEvents txtstock As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbart As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cmbuni As ComboBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents txtcodart As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtndoc As TextBox
    Friend WithEvents txtsdoc As TextBox
    Friend WithEvents txttdoc As TextBox
    Friend WithEvents lbltmov As Label
    Friend WithEvents cmbNroDoc As ComboBox
    Friend WithEvents cmbSerDocArt As ComboBox
End Class
