Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormBUSQUEDA
    Private BONONOCTURNOBL As New BONONOCTURNOBL
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private GUIADESPACHOBL As New GUIADESPACHOBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private ELTBINICIALCBBL As New ELTBINICIALCBBL
    Private ARTICULOBL As New ARTICULOBL
    Private ART_UPDATEBL As New ART_UPDATEBL
    Private ELVACACIONESBL As New ELVACACIONESBL
    Private ELTBCONCEPTOSBL As New ELTBCONCEPTOSBL
    Private ELTBCUENTA_OPEBL As New ELTBCUENTA_OPEBL
    Private ELPROGRAMACIONBL As New ELPROGRAMACIONBL
    Private ELTBLINESBL As New ELTBLINESBL
    Private CCOSTOBL As New CCOSTOBL
    Private ELTBPROCBL As New ELTBPROCBL
    Private ELTBCLIENTEBL As New ELTBCLIENTEBL
    Private ELORDEN_PROGRAMBL As New ELORDEN_PROGRAMBL
    Private ELPAGO_DOCUMENTOBL As New ELPAGO_DOCUMENTOBL
    Private ELTBREGISTRO_NROBL As New ELTBREGISTRO_NROBL
    Private ELPERIODOBL As New ELPERIODOBL
    Private PERBL As New PERBL
    Private ELPRODUCCIONBL As New ELPRODUCCIONBL
    Private ELETIQUETABL As New ELETIQUETABL
    Private ELCERTIFICABL As New ELCERTIFICABL
    Private ELDOCUMENTOBL As New ELDOCUMENTOBL
    Private T_MEDIDABL As New T_MEDIDABL
    Private PROVISIONESBL As New PROVISIONESBL
    Private NOTADEBITOBL As New NOTADEBITOBL
    Private ELTBGRUPOBL As New ELTBGRUPOBL
    Private NOTACREDITOBL As New NOTACREDITOBL
    Private ORDENCOMPRABL As New ORDENCOMPRABL
    Private ELDECLARACIONDUABL As New ELDECLARACIONDUABL
    Private ELTBCTA_FACTURACIONBL As New ELTBCTA_FACTURACIONBL
    Private ELTBLINEABL As New ELTBLINEABL
    Private T_MOVINVBL As New T_MOVINVBL
    Private ELCUENTA_ARTBL As New ELCUENTA_ARTBL
    Private LETRASBL As New LETRASBL
    Private FACTURACIONBL As New FACTURACIONBL
    Private ELTBCAPACITACIONBL As New ELTBCAPACITACIONBL
    Private ELTBDOCEXPBL As New ELTBDOCEXPBL
    Private ELTBMTIEMBL As New ELTBMTIEMBL
    Private ELALBARANBL As New ELALBARANBL
    Private ELTBDETDOCOPBL As New ELTBDETDOCOPBL
    Private gdtMainData As DataTable
    Public medida As String
    Private Sub btnsalir_Click(sender As Object, e As EventArgs)
        Dispose()
    End Sub
    Private Function mes(ByVal cmb As String) As String
        If cmb = "Enero" Then
            Return "01"
        ElseIf cmb = "Febrero" Then
            Return "02"
        ElseIf cmb = "Marzo" Then
            Return "03"
        ElseIf cmb = "Abril" Then
            Return "04"
        ElseIf cmb = "Mayo" Then
            Return "05"
        ElseIf cmb = "Junio" Then
            Return "06"
        ElseIf cmb = "Julio" Then
            Return "07"
        ElseIf cmb = "Agosto" Then
            Return "08"
        ElseIf cmb = "Septiembre" Then
            Return "09"
        ElseIf cmb = "Octubre" Then
            Return "10"
        ElseIf cmb = "Noviembre" Then
            Return "11"
        ElseIf cmb = "Diciembre" Then
            Return "12"
        End If

    End Function
    Private Sub FormBUSQUEDA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cursor.Current = Cursors.WaitCursor
        Dim dt As DataTable
        If sBusAlm = "1" Or sBusAlm = "7" Or sBusAlm = "105" Then
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
        ElseIf sBusAlm = "2" Or sBusAlm = "5" Or sBusAlm = "6" Or sBusAlm = "8" Or sBusAlm = "10" Or sBusAlm = "11" Or sBusAlm = "12" Or sBusAlm = "16" Or
            sBusAlm = "106" Then
            If gsCode13 = "E17" Then
                dt = ARTICULOBL.getArticuloAntE17()
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
            Else
                dt = ARTICULOBL.getArticuloAnterior1()
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

        ElseIf sBusAlm = "3" Then
            chkestado.Visible = True
            dt = ARTICULOBL.getArticuloAnterior1()
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
        ElseIf sBusAlm = "ACT" Then
            chkestado.Visible = True
            dt = ARTICULOBL.getArticuloActivo()
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
        ElseIf sBusAlm = "35" Then
            dt = ARTICULOBL.getArticuloAnterior1()
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
        ElseIf sBusAlm = "4" Or sBusAlm = "13" Or sBusAlm = "14" Or sBusAlm = "15" Or sBusAlm = "17" Or sBusAlm = "21" Or sBusAlm = "22" Or
            sBusAlm = "25" Or sBusAlm = "38" Or sBusAlm = "39" Or sBusAlm = "53" Or sBusAlm = "235" Then
            dt = REQUERIMIENTOBL.SelectProv()
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
        ElseIf sBusAlm = "18" Or sBusAlm = "19" Or sBusAlm = "23" Or sBusAlm = "24" Or sBusAlm = "41" Then
            dt = REQUERIMIENTOBL.SelectVend()
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
        ElseIf sBusAlm = "9" Or sBusAlm = "225" Then
            dt = REQUERIMIENTOBL.SelectAct()
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
        ElseIf sBusAlm = "20" Or sBusAlm = "30" Or sBusAlm = "33" Or sBusAlm = "34" Or sBusAlm = "240" Then
            dt = REQUERIMIENTOBL.SelectPerUsu()
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
        ElseIf sBusAlm = "27" Or sBusAlm = "28" Then
            dt = ELTBLINESBL.SelectAllLines()
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
        ElseIf sBusAlm = "32" Or sBusAlm = "222" Then
            dt = ELTBLINESBL.SelectLines()
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
        ElseIf sBusAlm = "29" Then
            dt = CCOSTOBL.SelectAllLines()
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
        ElseIf sBusAlm = "31" Then
            dt = ELTBPROCBL.SelectAllLines()
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
        ElseIf sBusAlm = "36" Or sBusAlm = "63" Or sBusAlm = "95" Then
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
        ElseIf sBusAlm = "63-O" Then
            dt = PERBL.SelPerAllObr()
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
            dt = ARTICULOBL.getArticuloCliente(gCliente)
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
        ElseIf sBusAlm = "40" Then
            dt = T_MEDIDABL.SelMedidaAll()
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
        ElseIf sBusAlm = "42" Then
            dt = T_MEDIDABL.SelectMedida()
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
        ElseIf sBusAlm = "227" Then
            dt = T_MEDIDABL.SelectMedida()
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
        ElseIf sBusAlm = "43" Or sBusAlm = "44" Then
            dt = ELTBCLIENTEBL.SelectUbigeo()
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
            dt = ELTBCLIENTEBL.SelectCIIU()
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
        ElseIf sBusAlm = "46" Then
            dt = ELTBCTA_FACTURACIONBL.SelectArticulo()
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
        ElseIf sBusAlm = "47" Or sBusAlm = "117" Then
            dt = ELTBCTA_FACTURACIONBL.SelectCtas(medida)
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
        ElseIf sBusAlm = "48" Then
            dt = REQUERIMIENTOBL.SelectPerUsu()
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
        ElseIf sBusAlm = "49" Then
            dt = ELTBREGISTRO_NROBL.SelectPrefBanco()
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
        ElseIf sBusAlm = "BANCO" Then
            dt = ELTBREGISTRO_NROBL.SelectBanco()
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

        ElseIf sBusAlm = "50" Then
            dt = ELTBCLIENTEBL.SelectPais()
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
        ElseIf sBusAlm = "51" Then
            dt = T_MEDIDABL.SelMedidaAllNew()
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
            'ElseIf sBusAlm = "42" Then
        ElseIf sBusAlm = "52" Then
            dt = NOTADEBITOBL.SelectMov_Mot("08")
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
        ElseIf sBusAlm = "54" Then
            dt = ELTBCUENTA_OPEBL.SelectCta(FormELTBCUENTA_OPE.cmbaño.SelectedItem)
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
        ElseIf sBusAlm = "55" Then
            dt = ELTBCTA_FACTURACIONBL.SelectCtasLineaEvanse()
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
        ElseIf sBusAlm = "56" Then
            dt = ARTICULOBL.getArticuloAnterior1()
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
        ElseIf sBusAlm = "59" Then
            dt = T_MOVINVBL.Select_TMOVINV()
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
        ElseIf sBusAlm = "61" Then
            dt = T_MOVINVBL.Select_TMOVINV()
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
        ElseIf sBusAlm = "62" Then
            dt = T_MEDIDABL.SelectNomMedida()
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
        ElseIf sBusAlm = "64" Then
            dt = NOTACREDITOBL.SelectMov_Mot("07")
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
            For i = 0 To dgvbusqueda.Rows.Count - 1  ' count++
                If dgvbusqueda.Rows(i).Cells("COD1").Value = "02" Or dgvbusqueda.Rows(i).Cells("COD1").Value = "03" Or
                    dgvbusqueda.Rows(i).Cells("COD1").Value = "13" Then
                    dgvbusqueda.Rows(i).DefaultCellStyle.ForeColor = Color.Green
                End If
            Next
        ElseIf sBusAlm = "65" Then
            dt = GUIADESPACHOBL.SelectT_TranspTractor(Cerrar)
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
        ElseIf sBusAlm = "66" Then
            dt = ELTBCLIENTEBL.SelectUbigeoNaci()
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
        ElseIf sBusAlm = "67" Then
            dt = PERBL.SelectCodEdu()
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
        ElseIf sBusAlm = "68" Then
            dt = ELTBCLIENTEBL.SelectUbigeo()
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
        ElseIf sBusAlm = "69" Then
            dt = PERBL.SelectCargoOcupacion()
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
        ElseIf sBusAlm = "70" Then
            dt = PERBL.SelectCargo()
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
        ElseIf sBusAlm = "71" Then
            dt = PERBL.SelectLinea(ccoCod)
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
        ElseIf sBusAlm = "72" Then
            dt = PERBL.SelectContrato()
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
        ElseIf sBusAlm = "73" Then
            dt = PERBL.SelectBcoCTS()
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
        ElseIf sBusAlm = "74" Then
            dt = ELTBCONCEPTOSBL.Select_Concepto()
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
        ElseIf sBusAlm = "75" Then
            dt = ELTBCONCEPTOSBL.Select_TipoConcepto()
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
        ElseIf sBusAlm = "76" Then
            dt = ELTBCUENTA_OPEBL.SelectCta(DateTime.Now.Year)
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
        ElseIf sBusAlm = "79" Then
            dt = PERBL.SelectPerCPTO()
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
        ElseIf sBusAlm = "77" Then
            dt = ELVACACIONESBL.SelectPeriodo(DateTime.Now.Year)
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
        ElseIf sBusAlm = "78" Then
            dt = ELVACACIONESBL.SelectSuspension()
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
        ElseIf sBusAlm = "80" Then
            dt = PERBL.SelPerViaAll()
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
        ElseIf sBusAlm = "81" Then
            dt = PERBL.SelPerZonaAll()
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
        ElseIf sBusAlm = "82" Then
            dt = GUIADESPACHOBL.SelectT_Transp()
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
        ElseIf sBusAlm = "83" Then
            dt = GUIADESPACHOBL.SelectT_TranspChofer(gsCode7)
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
            dt = T_MEDIDABL.SelectMedida1(medida)
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
            dt = ELPERIODOBL.SelectPrdoAct()
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
            dt = ELPERIODOBL.SelectPrdoActAll()
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
        ElseIf sBusAlm = "87" Then
            dt = ELCERTIFICABL.SelGuiaAll()
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
        ElseIf sBusAlm = "88" Then
            dt = ELCERTIFICABL.SelEasyPeelAll()
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
        ElseIf sBusAlm = "89" Then
            dt = ELCERTIFICABL.SeltapaplastAll()
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
        ElseIf sBusAlm = "90" Then
            dt = ELCERTIFICABL.SelTapaTeleAll()
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
        ElseIf sBusAlm = "91" Then
            dt = ELCERTIFICABL.SelTapaTeleAll()
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
        ElseIf sBusAlm = "92" Then
            dt = ELPROGRAMACIONBL.SelectArea()
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
        ElseIf sBusAlm = "93" Then
            dt = ART_UPDATEBL.SelectAllopcion(gLinea)
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "94" Then
            dt = ART_UPDATEBL.SelectLineaAll()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "107" Then
            dt = PROVISIONESBL.SelectBS_SS()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "96" Then
            dt = ELDOCUMENTOBL.SelectTipodoc()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "97" Then
            dt = ELDOCUMENTOBL.SelectMoneda()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "98" Then
            dt = ELDOCUMENTOBL.SelectProveedor()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "98-C" Then
            dt = ELDOCUMENTOBL.SelectCliente()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "99" Then
            dt = ELETIQUETABL.SelectArticulo(gArt)
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "100" Then
            dt = ELETIQUETABL.SelectUnidadm()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "101" Then
            dt = ELPAGO_DOCUMENTOBL.SelectCentroCosto()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "102" Then
            dt = PROVISIONESBL.SelectT_DOC()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "103" Then
            dt = PROVISIONESBL.SelectT_OPE(sAño)
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "104" Then
            dt = PROVISIONESBL.Select_MON()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "108" Then
            dt = ELORDEN_PROGRAMBL.SelectOrdenesProdu(gsCode7)
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "109" Then
            dt = ELORDEN_PROGRAMBL.SelectLineaProd(gsCode11)
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "110" Then
            dt = ELORDEN_PROGRAMBL.SelectProcesoArt()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "111" Then
            dt = ELDOCUMENTOBL.SelectTipoCuenta(gsCode7)
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "112" Then
            dt = ELCUENTA_ARTBL.SelectArticuloCuenta()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "113" Then
            dt = ELETIQUETABL.SelectArticulotwo()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "114" Then
            dt = ARTICULOBL.getArticuloCliente(gCliente)
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
        ElseIf sBusAlm = "115" Then
            dt = ELETIQUETABL.SelectArticuloPro()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "116" Then
            dt = REQUERIMIENTOBL.SelectFamilia
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "118" Then
            dt = ELETIQUETABL.SelectActivoPro()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)                      
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "119" Then
            dt = ELETIQUETABL.SelectUserPro()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)                      
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "220" Then
            'Dim sMes As String = mes(FormReporteOrdenC.cmbmes.SelectedItem)
            dt = ELETIQUETABL.SelectArtMes(Format(FormReporteOrdenC.dtpfecini.Value, "yyyymm"), Format(FormReporteOrdenC.dtpfecfin.Value, "yyyymm"))
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)                      
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "221" Then
            'Dim sMes As String = mes(FormReporteOrdenC.cmbmes.SelectedItem)
            dt = ARTICULOBL.SelectDescripcion1(gsCode7)
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)                      
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "223" Then
            'Dim sMes As String = mes(FormReporteOrdenC.cmbmes.SelectedItem)
            dt = ARTICULOBL.SelectArt1(gsCode7)
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)                      
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "224" Then
            dt = ELDECLARACIONDUABL.SelectFacturasG()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)                      
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "226" Then
            dt = LETRASBL.SelectF_PAGO()
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
        ElseIf sBusAlm = "228" Then
            dt = REQUERIMIENTOBL.SelectPer()
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
        ElseIf sBusAlm = "229" Then
            dt = ELTBLINESBL.SelectLines1()
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
        ElseIf sBusAlm = "230" Then
            dt = ARTICULOBL.getListSubLinea1(gsCode7)
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
        ElseIf sBusAlm = "231" Then
            dt = PROVISIONESBL.SelectT_OPE_DETRA()
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
        ElseIf sBusAlm = "232" Then
            dt = PROVISIONESBL.SelectELTBDETRA()
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
        ElseIf sBusAlm = "233" Then
            dt = ELDECLARACIONDUABL.SelectArticulo(gsCode7)
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
        ElseIf sBusAlm = "234" Then
            dt = ELTBGRUPOBL.SearhGroup(gsCode11)
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
        ElseIf sBusAlm = "236" Then
            dt = FACTURACIONBL.SelectMoneda
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
        ElseIf sBusAlm = "237" Then
            dt = ELCERTIFICABL.SelGuiaTwo()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            lblRecNo.Text = dgvbusqueda.Rows.Count
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "238" Then
            cmbestado.Visible = True
            cmbestado.SelectedIndex = 1
            dt = ORDENCOMPRABL.SearchNro("P")
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
        ElseIf sBusAlm = "239" Then
            cmbestado.Visible = True
            cmbestado.SelectedIndex = 1
            dt = ELTBGRUPOBL.SearhCCO()
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
        ElseIf sBusAlm = "241" Then
            dt = ARTICULOBL.getArtLineaSub(gsCode2)
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
        ElseIf sBusAlm = "242" Then
            dt = ELTBLINEABL.getLinea(gsCode2)
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
        ElseIf sBusAlm = "243" Then
            dt = ELPRODUCCIONBL.SelProd(gsCode7)
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
        ElseIf sBusAlm = "244" Then
            dt = ARTICULOBL.getArtMant()
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
        ElseIf sBusAlm = "245" Then
            dt = ELPAGO_DOCUMENTOBL.SelectCentroCosto1()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "246" Then
            dt = ARTICULOBL.getArticuloAnterior4()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "247" Then
            dt = ARTICULOBL.getArticuloAnterior5()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "248" Then
            dt = ARTICULOBL.getArticuloAnterior5()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            'get columns of DGV
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                'MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            'limpiar busqueda
            lblRecNo.Text = dgvbusqueda.Rows.Count
            'dgv color
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "120" Then
            dt = ARTICULOBL.getArticuloAnterior6()
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
        ElseIf sBusAlm = "121" Then
            dt = ELTBCAPACITACIONBL.getCapacitacion1()
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
        ElseIf sBusAlm = "122" Then
            dt = ARTICULOBL.getArticuloAnterior8()
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
        ElseIf sBusAlm = "123" Then
            '    dt = CCOSTOBL.()
            dt = ELTBMTIEMBL.SelectAllLines()
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
        ElseIf sBusAlm = "249" Then
            dt = ARTICULOBL.getListSubLin()
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
        ElseIf sBusAlm = "250" Then
            dt = ARTICULOBL.getArticuloAnterior7()
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
        ElseIf sBusAlm = "251" Then
            dt = ELTBDOCEXPBL.SelPais()
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
        ElseIf sBusAlm = "252" Then
            dt = ELTBDOCEXPBL.SelConv()
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
        ElseIf sBusAlm = "253" Then
            dt = ELALBARANBL.SelGuia()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            lblRecNo.Text = dgvbusqueda.Rows.Count
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "254" Then
            dt = ELDOCUMENTOBL.SelectTMOV()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            lblRecNo.Text = dgvbusqueda.Rows.Count
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "255" Then
            dt = ELDOCUMENTOBL.SelectChofer()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            lblRecNo.Text = dgvbusqueda.Rows.Count
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "ROTULOSGUIA" Then
            dt = ELETIQUETABL.BuscarRotulosGuia()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            lblRecNo.Text = dgvbusqueda.Rows.Count
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "256" Then
            dt = ARTICULOBL.CodCCNU()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            lblRecNo.Text = dgvbusqueda.Rows.Count
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "257" Then
            dt = ELTBINICIALCBBL.BuscarCB(gsCode11)
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            lblRecNo.Text = dgvbusqueda.Rows.Count
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "258" Then
            dt = ELVACACIONESBL.SelectPeriodo2(DateTime.Now.Year)
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
        ElseIf sBusAlm = "259" Then
            dt = ARTICULOBL.CodCCNU1()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            lblRecNo.Text = dgvbusqueda.Rows.Count
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "260" Then
            dt = ARTICULOBL.CodCCNU1()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            lblRecNo.Text = dgvbusqueda.Rows.Count
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "261" Then
            dt = ELTBDETDOCOPBL.BuscarOP(gsCode2, gsCode11)
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            lblRecNo.Text = dgvbusqueda.Rows.Count
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "TCSBS" Then
            dt = ELTBDETDOCOPBL.BuscarTCSBS(fechaTCSBS, operacionTCSBS)
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            lblRecNo.Text = dgvbusqueda.Rows.Count
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "ACTFLUJO" Then
            dt = ELTBDETDOCOPBL.BuscarActFLujo()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            lblRecNo.Text = dgvbusqueda.Rows.Count
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "ACTFLUJOCAJA" Then
            dt = ELTBDETDOCOPBL.BuscarActFLujoCaja(gLinea, gSubLinea)
            gLinea = Nothing
            gSubLinea = Nothing
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            lblRecNo.Text = dgvbusqueda.Rows.Count
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "CRONOGRAMARRHH" Then
            dt = BONONOCTURNOBL.BuscarCronogramaRRHH()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            lblRecNo.Text = dgvbusqueda.Rows.Count
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "CCOCOD_PER" Then
            dt = PERBL.BuscarCCOCOD()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            lblRecNo.Text = dgvbusqueda.Rows.Count
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        ElseIf sBusAlm = "CCO_COD" Then
            dt = ELPAGO_DOCUMENTOBL.BuscarCentroCosto()
            dgvbusqueda.DataSource = dt
            dgvbusqueda.Refresh()
            gdtMainData = dt
            tsbCamposSeek.Items.Clear()
            For Each col As DataGridViewColumn In dgvbusqueda.Columns
                tsbCamposSeek.Items.Add(col.Name)
            Next
            Cursor.Current = Cursors.Default
            lblRecNo.Text = dgvbusqueda.Rows.Count
            dgvbusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
            dgvbusqueda.EnableHeadersVisualStyles = False
        End If


        'If dgvbusqueda.Rows.Count > 0 Then
        '    tsbCamposSeek.SelectedIndex = 1
        '    Me.ActiveControl = tsTextSearch.Control
        '    'tsbMant.Items("tsTextSearch").Select()
        '    tsTextSearch.Select()
        'Else
        '    MsgBox("No hay data que cargar")
        '    Dispose()
        'End If

        If dgvbusqueda.Rows.Count > 0 Then
            If sBusAlm = "88" Or sBusAlm = "89" Or sBusAlm = "90" Or sBusAlm = "117" Or sBusAlm = "243" Then
                tsbCamposSeek.SelectedIndex = 0
                Me.ActiveControl = tsTextSearch.Control
            ElseIf sBusAlm = "238" Then
                tsbCamposSeek.SelectedIndex = 2
                Me.ActiveControl = tsTextSearch.Control
            ElseIf sBusAlm = "111" Then
                tsbCamposSeek.SelectedIndex = 0
                Me.ActiveControl = tsTextSearch.Control
            Else
                tsbCamposSeek.SelectedIndex = 1
                Me.ActiveControl = tsTextSearch.Control
            End If
        Else
            MsgBox("No hay data que cargar")
            Dispose()
        End If
    End Sub

    Private Sub dgvbusqueda_DoubleClick(sender As Object, e As EventArgs) Handles dgvbusqueda.DoubleClick
        If sBusAlm = "2" Or sBusAlm = "6" Or sBusAlm = "8" Or sBusAlm = "10" Or sBusAlm = "11" Or sBusAlm = "12" Or sBusAlm = "16" Or
            sBusAlm = "246" Or sBusAlm = "247" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", Mid(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value, 1, 2) & "00")
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", Mid(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value, 1, 4))
            gArt = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "1" Then
            FormMantGuiaAlmacen.txtproveedor.Text = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            FormMantGuiaAlmacen.cmbproveedor.SelectedValue = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "3" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", Mid(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value, 1, 2) & "00")
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", Mid(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value, 1, 4))
            gArt = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gLinea3 = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
        ElseIf sBusAlm = "ACT" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
        ElseIf sBusAlm = "35" Then
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            gArt = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "5" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", Mid(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value, 1, 2) & "00")
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", Mid(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value, 1, 4))
            gArt = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "4" Then
            FormMantRequerimiento.txtproveedor.Text = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            FormMantRequerimiento.cmbproveedor.SelectedValue = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "7" Then
            FormReque_Ok.txtproveedor.Text = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            FormReque_Ok.cmbproveedor.SelectedValue = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "13" Then
            FormReporteVenta.txtcliente1.Text = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "14" Then
            FormReporteVenta.txtcliente2.Text = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "15" Then
            FormEtiquetas.txtcliente1.Text = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "17" Then
            FormReporte_T_Env.txtcliente1.Text = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "18" Then
            FormReporteVenta.txtvend.Text = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "19" Then
            FormReporteVenta.txtvend1.Text = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "9" Then
            gCodAct = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "20" Then
            FormRepProdAll.txtuserrep.Text = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value)
        ElseIf sBusAlm = "21" Then
            FormReporteDespacho.txtcliente1.Text = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "22" Then
            FormReporteDespacho.txtcliente2.Text = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "23" Then
            FormReporteDespacho.txtvend.Text = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "24" Then
            FormReporteDespacho.txtvend1.Text = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "25" Then
            FormRptDespachoCli.txtcliente1.Text = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "26" Then
            FormRptDespachoCli.txtcliente2.Text = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "27" Or sBusAlm = "28" Then
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "29" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "30" Then
            FormRepProdAll.txtusuario2.Text = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value)
        ElseIf sBusAlm = "31" Or sBusAlm = "237" Or sBusAlm = "253" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
        ElseIf sBusAlm = "32" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "33" Then
            FormRPTConIng.txtuserrep.Text = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value)
        ElseIf sBusAlm = "34" Then
            FormRPTConIng.txtuserrep2.Text = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value)
        ElseIf sBusAlm = "36" Then
            gArt = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "37" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", Mid(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value, 1, 2) & "00")
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", Mid(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value, 1, 4))
            gArt = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "38" Then
            FormMantOrdenCompra.txtctct_cod.Text = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            FormMantOrdenCompra.cmbctct_cod.SelectedValue = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "39" Or sBusAlm = "87" Or sBusAlm = "227" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            'gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value)
            'gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            'ElseIf  Then
            '    gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "42" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
        ElseIf sBusAlm = "43" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            gArt = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value)
            gCodAct = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value)
        ElseIf sBusAlm = "44" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            gArt = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value)
        ElseIf sBusAlm = "45" Or sBusAlm = "88" Or sBusAlm = "89" Or sBusAlm = "90" Or sBusAlm = "117" Or sBusAlm = "226" Or sBusAlm = "40" Or
            sBusAlm = "48" Or sBusAlm = "49" Or sBusAlm = "47" Or sBusAlm = "61" Or sBusAlm = "62" Or sBusAlm = "241" Or sBusAlm = "254" Or sBusAlm = "255" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "46" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "50" Or sBusAlm = "52" Or sBusAlm = "53" Or sBusAlm = "63" Or sBusAlm = "64" Or sBusAlm = "67" Or
            sBusAlm = "79" Or sBusAlm = "80" Or sBusAlm = "54" Or sBusAlm = "55" Or sBusAlm = "69" Or sBusAlm = "70" Or sBusAlm = "71" Or
            sBusAlm = "73" Or sBusAlm = "74" Or sBusAlm = "76" Or sBusAlm = "75" Or sBusAlm = "77" Or sBusAlm = "78" Or sBusAlm = "81" Or
            sBusAlm = "82" Or sBusAlm = "84" Or sBusAlm = "92" Or sBusAlm = "94" Or sBusAlm = "95" Or sBusAlm = "96" Or sBusAlm = "97" Or
            sBusAlm = "98" Or sBusAlm = "98-C" Or sBusAlm = "99" Or sBusAlm = "100" Or sBusAlm = "101" Or sBusAlm = "102" Or sBusAlm = "103" Or sBusAlm = "104" Or
            sBusAlm = "105" Or sBusAlm = "106" Or sBusAlm = "107" Or sBusAlm = "111" Or sBusAlm = "109" Or sBusAlm = "110" Or sBusAlm = "113" Or 'Then 
            sBusAlm = "114" Or sBusAlm = "115" Or sBusAlm = "116" Or sBusAlm = "118" Or sBusAlm = "119" Or sBusAlm = "220" Or sBusAlm = "221" Or
            sBusAlm = "222" Or sBusAlm = "223" Or sBusAlm = "225" Or sBusAlm = "228" Or sBusAlm = "229" Or sBusAlm = "230" Or sBusAlm = "231" Or
            sBusAlm = "232" Or sBusAlm = "233" Or sBusAlm = "234" Or sBusAlm = "235" Or sBusAlm = "236" Or sBusAlm = "238" Or sBusAlm = "239" Or
            sBusAlm = "242" Or sBusAlm = "243" Or sBusAlm = "244" Or sBusAlm = "245" Or sBusAlm = "249" Or sBusAlm = "250" Or sBusAlm = "251" Or
            sBusAlm = "252" Or sBusAlm = "41" Or sBusAlm = "256" Or sBusAlm = "257" Or sBusAlm = "258" Or sBusAlm = "259" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
        ElseIf sBusAlm = "63-O" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
        ElseIf sBusAlm = "51" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
        ElseIf sBusAlm = "56" Or sBusAlm = "72" Or sBusAlm = "83" Or sBusAlm = "85" Or sBusAlm = "86" Or sBusAlm = "95" Or sBusAlm = "112" Or sBusAlm = "224" Or sBusAlm = "123" Then

            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            gArt = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value)
        ElseIf sBusAlm = "BANCO" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
        ElseIf sBusAlm = "59" Or sBusAlm = "65" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            gArt = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value)
            gsCode3 = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value)
            gsCode4 = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(4).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(4).Value)
        ElseIf sBusAlm = "66" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            gArt = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value)
            gsCode3 = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value)
        ElseIf sBusAlm = "68" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            gArt = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value)
        ElseIf sBusAlm = "93" Then
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "240" Or sBusAlm = "261" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value)
        ElseIf sBusAlm = "120" Or sBusAlm = "121" Or sBusAlm = "122" Then
            'gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", Mid(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value, 1, 2) & "00")
            'gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", Mid(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value, 1, 4))
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            gArt = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
        ElseIf sBusAlm = "TCSBS" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells("TC").Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells("TC").Value)
        ElseIf sBusAlm = "ACTFLUJO" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
        ElseIf sBusAlm = "ACTFLUJOCAJA" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
        ElseIf sBusAlm = "CRONOGRAMARRHH" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gLinea2 = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            gLinea3 = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(4).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(4).Value)
        ElseIf sBusAlm = "CCOCOD_PER" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
        ElseIf sBusAlm = "CCO_COD" Then
            gLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gSubLinea = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
        ElseIf sBusAlm = "ROTULOSGUIA" Then
            ReDim gsRptArgs(6)
            gsRptArgs(0) = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(0).Value)
            gsRptArgs(1) = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(1).Value)
            gsRptArgs(2) = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(2).Value)
            gsRptArgs(3) = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(3).Value)
            gsRptArgs(4) = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(4).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(4).Value)
            gsRptArgs(5) = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(5).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(5).Value)
            gsRptArgs(6) = IIf(IsDBNull(dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(10).Value), "", dgvbusqueda.Rows(dgvbusqueda.CurrentRow.Index).Cells(10).Value)
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTETIQUETA_GUIAS.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If
        sBusAlm = "0"
        Me.Dispose()
    End Sub
    Private Sub tsTextSearch_TextChanged(sender As Object, e As EventArgs) Handles tsTextSearch.TextChanged
        If sBusAlm = "117" Then
            If tsbCamposSeek.Text = "COD" Then

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
                Dim dataRows() As DataRow = gdtMainData.Select(sCampo & " Like '" & sCode & "%'")

                For Each ldrRow As DataRow In dataRows
                    dtNew.ImportRow(ldrRow)
                Next
                dgvbusqueda.DataSource = dtNew

                lblRecNo.Text = dgvbusqueda.Rows.Count

                Cursor.Current = Cursors.Default
            ElseIf tsbCamposSeek.Text = "NOM" Then

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
                Dim dataRows() As DataRow = gdtMainData.Select(sCampo & " Like '%" & sCode & "%'")

                For Each ldrRow As DataRow In dataRows
                    dtNew.ImportRow(ldrRow)
                Next
                dgvbusqueda.DataSource = dtNew

                lblRecNo.Text = dgvbusqueda.Rows.Count

                Cursor.Current = Cursors.Default
            Else
                If tsbCamposSeek.Text = "" Then
                    MsgBox("Debe ingresar campo de busqueda")
                    Exit Sub
                End If

            End If

        Else
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
            Dim dataRows() As DataRow = gdtMainData.Select(sCampo & " Like '%" & sCode & "%'")

            For Each ldrRow As DataRow In dataRows
                dtNew.ImportRow(ldrRow)
            Next
            dgvbusqueda.DataSource = dtNew

            lblRecNo.Text = dgvbusqueda.Rows.Count

            Cursor.Current = Cursors.Default
        End If


    End Sub

    Private Sub FormBUSQUEDA_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
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

    Private Sub cmbestado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbestado.SelectedIndexChanged
        Dim dt As DataTable

        If cmbestado.Text = "Pendiente" Then
            dt = ORDENCOMPRABL.SearchNro("P")
        ElseIf cmbestado.Text = "Despachado" Then
            dt = ORDENCOMPRABL.SearchNro("D")
        ElseIf cmbestado.Text = "Cerrado" Then
            dt = ORDENCOMPRABL.SearchNro("C")
        ElseIf cmbestado.Text = "Todo" Then
            dt = ORDENCOMPRABL.SearchNro("T")
        End If

        dgvbusqueda.DataSource = dt
        dgvbusqueda.Refresh()
    End Sub

    Private Sub chkestado_CheckedChanged(sender As Object, e As EventArgs) Handles chkestado.CheckedChanged
        Dim dt As DataTable
        If chkestado.Enabled = True Then
            dt = ARTICULOBL.getArticuloAnterior2()
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
        Else
            dt = ARTICULOBL.getArticuloAnterior1()
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
        tsbCamposSeek.SelectedIndex = 1
        Me.ActiveControl = tsTextSearch.Control

    End Sub
End Class