Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class BusquedaPersonal
    Private ELTBCONCEPTOSBL As New ELTBCONCEPTOSBL
    Private ELCONTRATOBL As New ELCONTRATOBL
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private CONTABILIDADBL As New CONTABILIDADBL
    Private PRESTAMOBL As New PRESTAMOBL
    Private PERBL As New PERBL
    Private gdtMainData As DataTable
    Private opcion As String
    Private valor As Boolean
    Private PRODUCCIONBL As New PRODUCCIONBL
    Private VACUNABL As New VACUNABL

    Private Sub BusquedaPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor


        If sOp = "0802070000" Then
            btnPasar.Visible = True
        Else
            btnPasar.Visible = False
        End If
        Dim dt As DataTable
        If sBusAlm = "1" Or sBusAlm = "7" Then
            dt = GUIAALMACENBL.SelectProv()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "36" Or sBusAlm = "81" Or sBusAlm = "82" Then

            If FormMantContratos.chkactivar.Checked Then
                dt = ELCONTRATOBL.SelPerAll(FormMantContratos.txtdias.Text)
            Else
                dt = ELCONTRATOBL.SelPerAll("0")
            End If
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "37" Then
            dt = VACUNABL.BuscarPersonalActivo()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "3720" Or sBusAlm = "3721" Then
            dt = PERBL.SelPerAllContratoNuevo(sBusAlm)
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False

        ElseIf sBusAlm = "3711" Then
            dt = VACUNABL.BuscarPersonalActivo()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "38" Then 'Busqueda Forma de Pago
            Me.Text = "Busqueda Forma de Pago"
            dt = CONTABILIDADBL.BuscarFormaPago()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "39" Then 'Busqueda CENTRO COSTO
            Me.Text = "Busqueda Centro Costo"
            dt = CONTABILIDADBL.BuscarCC()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "40" Then 'Busqueda PROVEEDOR
            Me.Text = "Busqueda Cliente/Proveedor"
            dt = CONTABILIDADBL.BuscarProveedor()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "41" Then 'Busqueda Tipo Documento
            Me.Text = "Busqueda Tipo Documento"
            dt = CONTABILIDADBL.SelectT_DOC()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "42" Then 'Busqueda Centro Costo
            Me.Text = "Busqueda Centro Costo"
            dt = CONTABILIDADBL.SelectCC()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "43" Then 'Busqueda Cuenta Destino
            Me.Text = "Busqueda Cuentas"
            dt = CONTABILIDADBL.SelectCuentas()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "44" Then 'Busqueda Cliente/Proveedor
            Me.Text = "Busqueda Cliente/Proveedor"
            dt = CONTABILIDADBL.BuscarProveedor()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "45" Then
            Me.Text = "Busqueda Documentos"
            dt = CONTABILIDADBL.BuscarDocumentosLD(sTDoc, lsNrodOC, ldANHO)
            dgvbusqueda.DataSource = dt
            If dt.Rows.Count = 0 Then
                MsgBox("Verificar Nro. Documento")
                Exit Sub
            End If
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False


        ElseIf sBusAlm = "040106" Then
            Me.Text = "Busqueda Orden Produccion"
            Me.Size = New Size(1294, 521)
            Me.StartPosition = FormStartPosition.CenterScreen


            dt = PRODUCCIONBL.BuscarOrdenProduccion()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "040106OPE" Then
            Me.Text = "Busqueda Operación"
            dt = PRODUCCIONBL.BuscarOperacionxProceso(codProcesoBP)
            If dt.Rows.Count = 0 Then
                MsgBox("Articulo no Cuenta con Operaciones")
                Exit Sub
            End If
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "BUSCAROP" Then
            Me.Text = "Busqueda Orden Produccion"
            dt = PRODUCCIONBL.BuscarListadoOP()
            If dt.Rows.Count = 0 Then
                MsgBox("Articulo no Cuenta con Operaciones")
                Exit Sub
            End If
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False

        ElseIf sBusAlm = "080302" Then
            Me.Text = "Busqueda Sanciones"
            dt = PRODUCCIONBL.BuscarSanciones()
            If dt.Rows.Count = 0 Then
                MsgBox("Articulo no Cuenta con Operaciones")
                Exit Sub
            End If
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "PRDOPRESTAMO" Then
            Me.Text = "Busqueda Periodo"
            dt = PRESTAMOBL.NuevoPeriodo(gLinea, gSubLinea)
            If dt.Rows.Count = 0 Then
                MsgBox("Articulo no Cuenta con Operaciones")
                Exit Sub
            End If
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "84" Then
            dt = PERBL.SelPerAll()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "DOCPRESTAMO" Then
            dt = PERBL.SelDocPrestamo()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "85" Then
            If sOp = "0" Or sOp = "1" Then
                opcion = ""
            ElseIf sOp = "2" Then
                opcion = "21"
            ElseIf sOp = "3" Then
                opcion = "20"
            End If
            dt = PERBL.SelPerAllActivosTemp(opcion)
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "86" Then
            dt = PERBL.SelPerAll()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        End If

        If dgvbusqueda.Rows.Count > 0 Then
            tsbCamposSeek.SelectedIndex = 1
            Me.ActiveControl = tsTextSearch.Control
        Else           '
        End If

        If sBusAlm = "040106" Then
            tsbCamposSeek.SelectedIndex = 0
            Me.ActiveControl = tsTextSearch.Control
        End If
    End Sub
    Private Sub dgvbusqueda_DoubleClick(sender As Object, e As EventArgs) Handles dgvbusqueda.DoubleClick
        If sBusAlm = "2" Or sBusAlm = "6" Or sBusAlm = "8" Or sBusAlm = "10" Or sBusAlm = "11" Or sBusAlm = "12" Or sBusAlm = "16" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", Mid(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value, 1, 2) & "00")
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", Mid(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value, 1, 4))
            gArt = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "1" Then
            FormMantGuiaAlmacen.txtproveedor.Text = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            FormMantGuiaAlmacen.cmbproveedor.SelectedValue = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "36" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)

            If FormMantContratos.dgvdatos.Rows.Count > 0 Then

                For i = 0 To FormMantContratos.dgvdatos.Rows.Count - 1

                    If FormMantContratos.dgvdatos.Rows(i).Cells(0).Value = dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value Then
                        MsgBox("Esta persona ya se encuentra listada, favor elija otra")
                        Exit Sub
                    End If
                Next

            End If

            Dim FechaDias As Date = DateTime.Now.AddDays(CInt(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value)).ToString("dd/MM/yyyy")
            Dim FechaInid As Date = DateTime.Now.ToString("dd/MM/yyyy")
            If DateTime.Compare(FechaInid, FechaDias) >= 0 Then
                FormMantContratos.dgvdatos.Rows.Add(gLinea, gSubLinea, FormMantContratos.dtpfecha_ini.Value.ToShortDateString, FormMantContratos.dtpfecha_fin.Value.ToShortDateString)
            Else
                If MessageBox.Show("Este Usuario todavia tiene contrato, agregar de todos modos? ", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                      MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                Else
                    FormMantContratos.dgvdatos.Rows.Add(gLinea, gSubLinea, FormMantContratos.dtpfecha_ini.Value.ToShortDateString, FormMantContratos.dtpfecha_fin.Value.ToShortDateString)
                End If
            End If

        ElseIf sBusAlm = "81" Then
            If OkData() = False Then
                Exit Sub
            Else
                gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
                gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
                FormELPROGRAMACION.dgvDatos.Rows.Add(gLinea, gSubLinea, FormELPROGRAMACION.dtpprogra_ini.Value.ToShortDateString, FormELPROGRAMACION.txtminutos.Text,
                                                     FormELPROGRAMACION.txtmin1.Text, FormELPROGRAMACION.txtmin2.Text,
                                                     FormELPROGRAMACION.txttiempo_dscto.Text, FormELPROGRAMACION.txtt_dscto1.Text,
                                                     FormELPROGRAMACION.txtt_dscto2.Text, FormELPROGRAMACION.txtdscto.Text,
                                                     FormELPROGRAMACION.txtobservacion.Text,
                                                     FormELPROGRAMACION.txtprdo_cod.Text, FormELPROGRAMACION.lblprdo_cod.Text,
                                                     FormELPROGRAMACION.txtlinea_cod.Text, FormELPROGRAMACION.lbllinea_cod.Text)
            End If
        ElseIf sBusAlm = "82" Then

            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            FormELPROGRAMACION.dgvDatos.Rows.Add(gLinea, gSubLinea, FormELPROGRAMACION.dtpprogra_ini.Value.ToShortDateString, FormELPROGRAMACION.txtminutos.Text,
                                                 FormELPROGRAMACION.txtmin1.Text, FormELPROGRAMACION.txtmin2.Text,
                                                 FormELPROGRAMACION.txttiempo_dscto.Text, FormELPROGRAMACION.txtt_dscto1.Text,
                                                 FormELPROGRAMACION.txtt_dscto2.Text, FormELPROGRAMACION.txtdscto.Text,
                                                 FormELPROGRAMACION.txtobservacion.Text,
                                                 FormELPROGRAMACION.txtprdo_cod.Text, FormELPROGRAMACION.lblprdo_cod.Text,
                                                 FormELPROGRAMACION.txtlinea_cod.Text, FormELPROGRAMACION.lbllinea_cod.Text)
            Me.Dispose()
        ElseIf sBusAlm = "37" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            Dispose()
        ElseIf sBusAlm = "3711" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            Dispose()
        ElseIf sBusAlm = "3720" Or sBusAlm = "3721" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            Dispose()
        ElseIf sBusAlm = "38" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            Dispose()
        ElseIf sBusAlm = "39" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            Dispose()
        ElseIf sBusAlm = "40" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            Dispose()
        ElseIf sBusAlm = "41" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            Dispose()
        ElseIf sBusAlm = "42" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            Dispose()
        ElseIf sBusAlm = "43" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            gLinea2 = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value)
            Dispose()
        ElseIf sBusAlm = "44" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            Dispose()
        ElseIf sBusAlm = "45" Then
            ldTDoc = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            ldSERIE = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            ldNUMERO = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value)
            ldCUENTA = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value)
            ldCUENTADEST = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(4).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(4).Value)
            ldFECHA = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(5).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(5).Value)
            ldPROVEEDOR = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(6).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(6).Value)
            ldRegContable = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(7).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(7).Value)
            ldSIGNO = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(8).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(8).Value)
            ldTCAMB = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(9).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(9).Value)
            If ldTCAMB = 0 Then
                estadoTC = 0
            End If
            ldIMPORTE = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(10).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(10).Value)
            ldDIMPORTE = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(11).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(11).Value)
            ldMONEDA = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(12).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(12).Value)
            ldNomProveedor = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(13).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(13).Value)
            Dispose()

        ElseIf sBusAlm = "040106" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            gLinea2 = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value)
            gLinea3 = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(4).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(4).Value)
            Dispose()
        ElseIf sBusAlm = "080302" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            Dispose()
        ElseIf sBusAlm = "PRDOPRESTAMO" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            gLinea2 = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value)
            Dispose()
        ElseIf sBusAlm = "040106OPE" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value)
            Dispose()
        ElseIf sBusAlm = "DOCPRESTAMO" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            Dispose()
        ElseIf sBusAlm = "BUSCAROP" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value)
            gLinea2 = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value)
            Dispose()
        ElseIf sBusAlm = "84" Then
            Dim comboCell As DataGridViewComboBoxCell
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)

            If FormROTACION.dgvdatos.Rows.Count > 0 Then

                For i = 0 To FormROTACION.dgvdatos.Rows.Count - 1

                    If FormROTACION.dgvdatos.Rows(i).Cells(0).Value = dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value Then
                        MsgBox("Esta persona ya se encuentra listada, favor elija otra")
                        Exit Sub
                    End If
                Next

            End If

            FormROTACION.dgvdatos.Rows.Add(gLinea, gSubLinea, "")
            comboCell = New DataGridViewComboBoxCell
            comboCell.Items.Add("")
            comboCell.Items.Add("DIURNO")
            comboCell.Items.Add("NOCTURNO")
            Dim indice As Integer
            indice = FormROTACION.dgvdatos.Rows.Count - 1
            FormROTACION.dgvdatos.Rows(indice).Cells(2) = comboCell
            FormROTACION.dgvdatos.Rows(indice).Cells(2).Value = FormROTACION.cmbturno.SelectedItem
        ElseIf sBusAlm = "85" Then
            If FormCargarDias.dgvt_doc.Rows.Count > 0 Then
                For i = 0 To FormCargarDias.dgvt_doc.Rows.Count - 1
                    If FormCargarDias.dgvt_doc.Rows(i).Cells(0).Value = dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value Then
                        MsgBox("Esta persona ya se encuentra listada, favor elija otra")
                        Exit Sub
                    End If
                Next
            End If
            FormCargarDias.dgvt_doc.Rows.Add(IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells("COD").Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells("COD").Value),
                                             IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells("NOM").Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells("NOM").Value),
                                             gArt, gsCode, gsCode2)
        End If

    End Sub

    Private Sub btnPasar_Click(sender As Object, e As EventArgs) Handles btnPasar.Click

        Dim Valores(2000) As String
        Dim Valores2(2000) As String
        Dim cont As Integer = 0

        For Each row As DataGridViewRow In dgvbusqueda.Rows
            Valores(cont) = RTrim(row.Cells("COD").Value)
            cont = cont + 1
        Next
        cont = 0
        For Each rowa As DataGridViewRow In FormELPROGRAMACION.dgvDatos.Rows
            Valores2(cont) = RTrim(rowa.Cells("PER_COD").Value)
            cont = cont + 1
        Next

        Dim contador As Integer = 0

        If FormELPROGRAMACION.dgvDatos.Rows.Count > 0 Then

            For x = 0 To dgvbusqueda.Rows.Count - 1
                contador = 0
                For j = 0 To FormELPROGRAMACION.dgvDatos.Rows.Count - 1
                    If Valores(x) = Valores2(j) Then
                        contador = contador + 1
                    End If
                Next
                If contador = 0 Then
                    FormELPROGRAMACION.dgvDatos.Rows.Add(dgvbusqueda.Rows(x).Cells("COD").Value, dgvbusqueda.Rows(x).Cells("NOM").Value, FormELPROGRAMACION.dtpprogra_ini.Value.ToShortDateString, FormELPROGRAMACION.txtminutos.Text,
                                                     FormELPROGRAMACION.txtmin1.Text, FormELPROGRAMACION.txtmin2.Text,
                                                     FormELPROGRAMACION.txttiempo_dscto.Text, FormELPROGRAMACION.txtt_dscto1.Text,
                                                     FormELPROGRAMACION.txtt_dscto2.Text, FormELPROGRAMACION.txtdscto.Text,
                                                     FormELPROGRAMACION.txtobservacion.Text,
                                                     FormELPROGRAMACION.txtprdo_cod.Text, FormELPROGRAMACION.lblprdo_cod.Text,
                                                     FormELPROGRAMACION.txtlinea_cod.Text, FormELPROGRAMACION.lbllinea_cod.Text)

                End If
            Next
        Else
            Dim i As Integer = 0
            For Each row As DataGridViewRow In dgvbusqueda.Rows
                FormELPROGRAMACION.dgvDatos.Rows.Add(dgvbusqueda.Rows(i).Cells("COD").Value, dgvbusqueda.Rows(i).Cells("NOM").Value, FormELPROGRAMACION.dtpprogra_ini.Value.ToShortDateString, FormELPROGRAMACION.txtminutos.Text,
                                                     FormELPROGRAMACION.txtmin1.Text, FormELPROGRAMACION.txtmin2.Text,
                                                     FormELPROGRAMACION.txttiempo_dscto.Text, FormELPROGRAMACION.txtt_dscto1.Text,
                                                     FormELPROGRAMACION.txtt_dscto2.Text, FormELPROGRAMACION.txtdscto.Text,
                                                     FormELPROGRAMACION.txtobservacion.Text,
                                                     FormELPROGRAMACION.txtprdo_cod.Text, FormELPROGRAMACION.lblprdo_cod.Text,
                                                     FormELPROGRAMACION.txtlinea_cod.Text, FormELPROGRAMACION.lbllinea_cod.Text)
                i = i + 1
            Next
        End If

    End Sub

    Private Function OkData() As Boolean

        If FormELPROGRAMACION.txtlinea_cod.Text = "" Then
            MsgBox("Ingrese el area ", MsgBoxStyle.Exclamation)
            FormELPROGRAMACION.txtlinea_cod.Focus()
            Return False
        End If
        Return True

    End Function


    Private Sub tsTextSearch_TextChanged(sender As Object, e As EventArgs) Handles tsTextSearch.TextChanged

        If tsbCamposSeek.Text = "" Then
            MsgBox("Debe ingresar campo de busqueda")
            Exit Sub
        End If

        Dim sCode As String = tsTextSearch.Text

        If sCode.Trim = "" Then
            dgvbusqueda.DataSource = gdtMainData
            lblRecNo.Text = dgvbusqueda.Rows.Count
            Exit Sub
        End If

        Cursor.Current = Cursors.WaitCursor

        Dim dtNew As DataTable

        ' copy table structure
        dtNew = gdtMainData.Clone()

        'obtener nombre de campo
        Dim sCampo As String = tsbCamposSeek.Text

        'buscar valor del txt en dt
        Dim dataRows() As DataRow = gdtMainData.Select(sCampo & " LIKE '%" & sCode & "%'")

        For Each ldrRow As DataRow In dataRows
            dtNew.ImportRow(ldrRow)
        Next
        dgvbusqueda.DataSource = dtNew

        lblRecNo.Text = dgvbusqueda.Rows.Count

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub tsTextSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles tsTextSearch.KeyDown
        If e.KeyValue = Keys.Down Then
            dgvbusqueda.Select()
            e.Handled = True
        End If
        If e.KeyValue = Keys.Enter Then
            dgvbusqueda_DoubleClick(sender, e)
            e.Handled = True
        End If
    End Sub
    Private Sub dgvbusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvbusqueda.KeyDown
        If e.KeyValue = Keys.Enter Then
            dgvbusqueda_DoubleClick(sender, e)
            e.Handled = True
        End If
    End Sub

    Private Sub BusquedaPersonal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()

    End Sub

End Class