<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUbicacionMant
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUbicacionMant))
        Me.tsbForm = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.tabUbicacion = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvPisos = New System.Windows.Forms.DataGridView()
        Me.txt_obser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_codPiso = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbAlmacen = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ubicacion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbUbiAlmacen = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbUbiPiso = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_codUbica = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvUbicacion = New System.Windows.Forms.DataGridView()
        Me.tsbForm.SuspendLayout()
        Me.tabUbicacion.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvPisos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsbForm
        '
        Me.tsbForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbSalir})
        Me.tsbForm.Location = New System.Drawing.Point(0, 0)
        Me.tsbForm.Name = "tsbForm"
        Me.tsbForm.Size = New System.Drawing.Size(757, 25)
        Me.tsbForm.TabIndex = 23
        Me.tsbForm.Text = "Grabar"
        '
        'tsbGrabar
        '
        Me.tsbGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGrabar.Image = CType(resources.GetObject("tsbGrabar.Image"), System.Drawing.Image)
        Me.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabar.Name = "tsbGrabar"
        Me.tsbGrabar.Size = New System.Drawing.Size(23, 22)
        Me.tsbGrabar.Tag = "save"
        Me.tsbGrabar.Text = "Grabar"
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(23, 22)
        Me.tsbSalir.Tag = "exit"
        Me.tsbSalir.Text = "Salir"
        '
        'tabUbicacion
        '
        Me.tabUbicacion.Controls.Add(Me.TabPage2)
        Me.tabUbicacion.Controls.Add(Me.TabPage1)
        Me.tabUbicacion.Location = New System.Drawing.Point(12, 28)
        Me.tabUbicacion.Name = "tabUbicacion"
        Me.tabUbicacion.SelectedIndex = 0
        Me.tabUbicacion.Size = New System.Drawing.Size(734, 303)
        Me.tabUbicacion.TabIndex = 24
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvUbicacion)
        Me.TabPage1.Controls.Add(Me.txt_codUbica)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.cmbUbiPiso)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txt_ubicacion)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.cmbUbiAlmacen)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(726, 277)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ubicación"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvPisos)
        Me.TabPage2.Controls.Add(Me.txt_obser)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txt_codPiso)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.cmbAlmacen)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(726, 277)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Piso"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvPisos
        '
        Me.dgvPisos.AllowUserToAddRows = False
        Me.dgvPisos.AllowUserToDeleteRows = False
        Me.dgvPisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPisos.Location = New System.Drawing.Point(9, 104)
        Me.dgvPisos.Name = "dgvPisos"
        Me.dgvPisos.ReadOnly = True
        Me.dgvPisos.Size = New System.Drawing.Size(711, 167)
        Me.dgvPisos.TabIndex = 6
        '
        'txt_obser
        '
        Me.txt_obser.Location = New System.Drawing.Point(83, 78)
        Me.txt_obser.Name = "txt_obser"
        Me.txt_obser.Size = New System.Drawing.Size(267, 20)
        Me.txt_obser.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DESCRIP.:"
        '
        'txt_codPiso
        '
        Me.txt_codPiso.Enabled = False
        Me.txt_codPiso.Location = New System.Drawing.Point(83, 52)
        Me.txt_codPiso.Name = "txt_codPiso"
        Me.txt_codPiso.Size = New System.Drawing.Size(46, 20)
        Me.txt_codPiso.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "COD. PISO:"
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Items.AddRange(New Object() {"0001 - LAS TORRES", "0002 - ELOY URETA", "0003 - LURIN"})
        Me.cmbAlmacen.Location = New System.Drawing.Point(83, 25)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Size = New System.Drawing.Size(176, 21)
        Me.cmbAlmacen.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ALMACEN:"
        '
        'txt_ubicacion
        '
        Me.txt_ubicacion.Location = New System.Drawing.Point(85, 88)
        Me.txt_ubicacion.Name = "txt_ubicacion"
        Me.txt_ubicacion.Size = New System.Drawing.Size(267, 20)
        Me.txt_ubicacion.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "DESCRIP.:"
        '
        'cmbUbiAlmacen
        '
        Me.cmbUbiAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUbiAlmacen.FormattingEnabled = True
        Me.cmbUbiAlmacen.Items.AddRange(New Object() {"0001 - LAS TORRES", "0002 - ELOY URETA", "0003 - LURIN"})
        Me.cmbUbiAlmacen.Location = New System.Drawing.Point(85, 6)
        Me.cmbUbiAlmacen.Name = "cmbUbiAlmacen"
        Me.cmbUbiAlmacen.Size = New System.Drawing.Size(176, 21)
        Me.cmbUbiAlmacen.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ALMACEN:"
        '
        'cmbUbiPiso
        '
        Me.cmbUbiPiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUbiPiso.FormattingEnabled = True
        Me.cmbUbiPiso.Location = New System.Drawing.Point(85, 33)
        Me.cmbUbiPiso.Name = "cmbUbiPiso"
        Me.cmbUbiPiso.Size = New System.Drawing.Size(176, 21)
        Me.cmbUbiPiso.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "PISO:"
        '
        'txt_codUbica
        '
        Me.txt_codUbica.Enabled = False
        Me.txt_codUbica.Location = New System.Drawing.Point(85, 60)
        Me.txt_codUbica.Name = "txt_codUbica"
        Me.txt_codUbica.Size = New System.Drawing.Size(46, 20)
        Me.txt_codUbica.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "COD. UBIC.:"
        '
        'dgvUbicacion
        '
        Me.dgvUbicacion.AllowUserToAddRows = False
        Me.dgvUbicacion.AllowUserToDeleteRows = False
        Me.dgvUbicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUbicacion.Location = New System.Drawing.Point(11, 114)
        Me.dgvUbicacion.Name = "dgvUbicacion"
        Me.dgvUbicacion.ReadOnly = True
        Me.dgvUbicacion.Size = New System.Drawing.Size(709, 150)
        Me.dgvUbicacion.TabIndex = 16
        '
        'FormUbicacionMant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 343)
        Me.Controls.Add(Me.tabUbicacion)
        Me.Controls.Add(Me.tsbForm)
        Me.Name = "FormUbicacionMant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUbicacionMant"
        Me.tsbForm.ResumeLayout(False)
        Me.tsbForm.PerformLayout()
        Me.tabUbicacion.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvPisos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsbForm As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents tabUbicacion As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmbAlmacen As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_codPiso As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_obser As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvPisos As DataGridView
    Friend WithEvents txt_codUbica As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbUbiPiso As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_ubicacion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbUbiAlmacen As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvUbicacion As DataGridView
End Class
