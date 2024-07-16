Imports IT.ELUX.BL
Imports IT.ELUX.BE
Public Class FormPrestamoPer
    Dim PRESTAMOBL As New PRESTAMOBL
    Dim PRESTAMOBE As New PRESTAMOBE
    Dim DETPRESTAMOBE As New DETPRESTAMOBE

    Private Sub FormPrestamoPer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' dtpFec1.Visible = True
        Me.Text = "Registro Prestamo/Adelantos Personal"
        txtt_doc.Text = "PRE"
        btnNuevo.Visible = True
        npdmonto.DecimalPlaces = 2
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                cmbEstado.SelectedIndex = 0
                modifica = 0
                dtpfecha.Value = Today
                txtt_doc.Select()
                btnagregar.Enabled = True
                cmb_serdoc.Text = sAño
                cmb_serdoc.Enabled = False
                dtpFec1.Value = dtpfecha.Value
                Dim mes = dtpfecha.Value.ToString("MM")
                Dim anho = dtpfecha.Value.ToString("yyyy")
                Dim dtCC As New DataTable
                dtCC = PRESTAMOBL.ListadoCC(mes, anho)
                GetCmb("COD", "NUM", dtCC, cmbPrdoPago)
                cmbPrdoPago.SelectedIndex = 0
            Case 1
                modifica = 1
                flagAccion = "M"
                txtt_doc.Enabled = False
                dtpfecha.Enabled = False
                txtper_cod.Enabled = False
                txtnumero.Enabled = False
                dtpFec1.Enabled = False
                txtObs.Enabled = False
                cmbEstado.Enabled = False
                cmb_serdoc.Enabled = False
                btnBuscarPersonal.Enabled = False
                npdcuotas.Enabled = False
                npdmonto.Enabled = False
                'btnagregar.Enabled = False
                GetData(sTDoc, sSDoc, sNDoc, SPerDoc)
        End Select
    End Sub

    Private Sub GetData(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String, ByVal SPerDoc As String)
        Try
            Dim dtDatosPrestamo As New DataTable
            dtDatosPrestamo = PRESTAMOBL.GetData(sTDoc, sSDoc, sNDoc, SPerDoc)
            If dtDatosPrestamo.Rows.Count > 0 Then
                txtt_doc.Text = dtDatosPrestamo.Rows(0).Item("TIPO")
                txtnt_doc.Text = dtDatosPrestamo.Rows(0).Item("DOCU")
                cmb_serdoc.Text = dtDatosPrestamo.Rows(0).Item("SERIE")
                txtnumero.Text = dtDatosPrestamo.Rows(0).Item("NRO")
                txtper_cod.Text = dtDatosPrestamo.Rows(0).Item("CODIGO")
                txtper_nom.Text = dtDatosPrestamo.Rows(0).Item("EMPLEADO")
                dtpFec1.Value = dtDatosPrestamo.Rows(0).Item("FECHA1RA")
                npdmonto.Value = dtDatosPrestamo.Rows(0).Item("MONTO")
                npdcuotas.Value = dtDatosPrestamo.Rows(0).Item("CUOTAS")
                txtObs.Text = dtDatosPrestamo.Rows(0).Item("OBS").ToString
                dtpfecha.Value = dtDatosPrestamo.Rows(0).Item("FECHA")
                lblNN.Text = dtDatosPrestamo.Rows(0).Item("NN").ToString
                Select Case dtDatosPrestamo.Rows(0).Item("ESTADO")
                    Case "P"
                        cmbEstado.SelectedIndex = 0
                    Case "C"
                        cmbEstado.SelectedIndex = 1
                        btnagregar.Enabled = False
                        Button1.Visible = False
                    Case Else
                        cmbEstado.SelectedIndex = 0
                End Select
                Dim dtDetDatosPrestamo As New DataTable
                dtDetDatosPrestamo = PRESTAMOBL.GetDetData(sTDoc, sSDoc, sNDoc, SPerDoc)
                'dgvt_doc2.DataSource = dtDetDatosPrestamo
                dgvt_doc.Rows.Add(dtDatosPrestamo.Rows.Count)
                Try
                    For i = 0 To dgvt_doc.Rows.Count - 1
                        dgvt_doc.Rows(i).Cells("CUOTA").Value = dtDetDatosPrestamo.Rows(i).Item("CUOTA")
                        dgvt_doc.Rows(i).Cells("TIPO").Value = dtDetDatosPrestamo.Rows(i).Item("TIPO")
                        dgvt_doc.Rows(i).Cells("SERIE").Value = dtDetDatosPrestamo.Rows(i).Item("SERIE")
                        dgvt_doc.Rows(i).Cells("NUMERO").Value = dtDetDatosPrestamo.Rows(i).Item("NUMERO")
                        dgvt_doc.Rows(i).Cells("FECVENC").Value = dtDetDatosPrestamo.Rows(i).Item("FECVENC")
                        dgvt_doc.Rows(i).Cells("MONTO").Value = dtDetDatosPrestamo.Rows(i).Item("MONTO")
                        dgvt_doc.Rows(i).Cells("PRDO").Value = dtDetDatosPrestamo.Rows(i).Item("PRDO")
                        dgvt_doc.Rows(i).Cells("PRDOPAGO").Value = dtDetDatosPrestamo.Rows(i).Item("PRDOPAGO")
                        dgvt_doc.Rows(i).Cells("ESTADO").Value = dtDetDatosPrestamo.Rows(i).Item("ESTADO")
                        dgvt_doc.Rows(i).Cells("TPAGO").Value = dtDetDatosPrestamo.Rows(i).Item("TPAGO")
                    Next
                Catch ex As Exception

                End Try

            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Try
            Dim sFunc = e.ClickedItem.Tag.ToString()
            If Mid(sFunc, 5, 4) = "func" Then
                sFunc = Mid(sFunc, 10)
            End If
            Select Case sFunc
                Case "save"
                    SaveData()
                    Exit Sub
                Case "exit"
                    Dispose()
                    Exit Sub
                Case "Print"
                    ImprimirReportePrestamo()
                    Exit Sub
            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ImprimirReportePrestamo()

        ReDim gsRptArgs(6)
        gsRptArgs(0) = txtt_doc.Text
        gsRptArgs(1) = cmb_serdoc.Text
        gsRptArgs(2) = txtnumero.Text
        gsRptArgs(3) = txtper_cod.Text
        gsRptArgs(4) = ""
        gsRptArgs(5) = ""
        gsRptArgs(6) = cmb_serdoc.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_REPORTE_PRESTAMOS.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub SaveData()

        With PRESTAMOBE
            .TIPO_DOC = txtt_doc.Text
            .SER_DOC = cmb_serdoc.Text
            .NUM_DOC = txtnumero.Text
            .PER_COD = txtper_cod.Text
            .FEC_GENE = dtpfecha.Value.ToString("dd/MM/yyyy")
            .FECHA1RA = dtpFec1.Value.ToString("dd/MM/yyyy")
            .CUOTA = npdcuotas.Value
            .MONTO = npdmonto.Value
            Select Case cmbEstado.SelectedIndex
                Case 0, -1
                    .EST = "P"
                Case 1
                    .EST = "C"

            End Select
            .USUARIO = gsUser
            .OBS = txtObs.Text
        End With

        gsError = PRESTAMOBL.SaveRow(PRESTAMOBE, flagAccion, dgvt_doc)
        If gsError = "OK" Then
            MsgBox("Prestamo Registrado")
            btnNuevo.PerformClick()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub txtt_doc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtt_doc.KeyDown
        If e.KeyCode = Keys.F9 Then
            sBusAlm = "DOCPRESTAMO"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtt_doc.Text = gLinea
                txtnt_doc.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
                Dim tipo = txtt_doc.Text.ToUpper
                Dim serie = cmb_serdoc.Text
                Dim dtTipoDoc As New DataTable
                dtTipoDoc = PRESTAMOBL.VerificarNumero(tipo, serie)
                Dim numero = dtTipoDoc.Rows(0).ItemArray(0)
                txtnumero.Text = numero
                txtnumero.Text = txtnumero.Text.PadLeft(9, "0")
                If txtt_doc.Text = "ADEL" Then
                    npdcuotas.Value = 1
                End If
                txtper_cod.Select()
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtt_doc_Leave(sender As Object, e As EventArgs) Handles txtt_doc.Leave
        Try
            Dim tipo = txtt_doc.Text.ToUpper
            Dim serie = cmb_serdoc.Text
            Dim dtTipoDoc As New DataTable
            dtTipoDoc = PRESTAMOBL.BuscarNomDocumento(tipo)
            If dtTipoDoc.Rows.Count > 0 Then
                txtnt_doc.Text = dtTipoDoc.Rows(0).Item(0)
                txtt_doc.Text = tipo
                dtTipoDoc = PRESTAMOBL.VerificarNumero(tipo, serie)
                Dim numero = dtTipoDoc.Rows(0).ItemArray(0)
                txtnumero.Text = numero
                txtnumero.Text = txtnumero.Text.PadLeft(9, "0")
                txtper_cod.Select()
                If txtt_doc.Text = "ADEL" Then
                    npdcuotas.Value = 1
                End If
            Else
                MsgBox("Verificar Tipo Documento")
                txtt_doc.Select()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnBuscarPersonal_Click(sender As Object, e As EventArgs) Handles btnBuscarPersonal.Click

        sBusAlm = "37"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtper_cod.Text = gLinea
            txtper_nom.Text = gSubLinea
            txtObs.Select()
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Dim CUOTAS = npdcuotas.Value
        Dim RESTO
        If dgvt_doc.Rows.Count > 0 Then
            For i = 0 To dgvt_doc.Rows.Count - 1
                dgvt_doc.Rows.Remove(dgvt_doc.Rows(0))
            Next
        End If

        Try
            For i = 0 To CUOTAS - 1
                dgvt_doc.Rows.Add(i + 1)
                dgvt_doc.Rows(i).Cells(1).Value = i + 1
                dgvt_doc.Rows(i).Cells("TIPO").Value = txtt_doc.Text
                dgvt_doc.Rows(i).Cells("SERIE").Value = cmb_serdoc.Text
                dgvt_doc.Rows(i).Cells("NUMERO").Value = txtnumero.Text & "-" & i + 1
                dgvt_doc.Rows(i).Cells("FECVENC").Value = dtpFec1.Value.AddMonths(i + 1).AddDays(-dtpFec1.Value.Day).ToString("dd/MM/yyyy")
                If i = CUOTAS - 1 Then
                    RESTO = npdmonto.Value - (npdcuotas.Value * Math.Round(npdmonto.Value / npdcuotas.Value, 2))
                Else
                    RESTO = 0
                End If
                dgvt_doc.Rows(i).Cells("MONTO").Value = Math.Round(npdmonto.Value / npdcuotas.Value, 2) + RESTO

                Dim dtPeriodo As New DataTable
                dtPeriodo = PRESTAMOBL.BuscarPeriodo(dgvt_doc.Rows(i).Cells("FECVENC").Value)
                If dtPeriodo.Rows.Count > 0 Then
                    dgvt_doc.Rows(i).Cells("PRDO").Value = dtPeriodo.Rows(0).ItemArray(0)
                Else
                    dgvt_doc.Rows(i).Cells("PRDO").Value = ""
                End If
                dgvt_doc.Rows(i).Cells("ESTADO").Value = "PENDIENTE"
                dgvt_doc.Rows(i).Cells("TPAGO").Value = "PLANILLA"
            Next
            For i = 0 To dgvt_doc.Columns.Count - 1
                dgvt_doc.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim frm As New FormModDetPrestamo

        If dgvt_doc.CurrentRow.Cells("ESTADO").Value = "PAGADO" Then
            MsgBox("CUOTA PAGADA, NO SE PUEDE MODIFICAR")
            Exit Sub
        End If

        If dgvt_doc.Rows.Count > 0 Then
            gsCode5 = dgvt_doc.CurrentRow.Index
            flagAccion1 = "M"
            frm.btnAgregar.Enabled = False
            frm.txtCuota.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CUOTA").Value
            frm.txtPeriodoPago.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("PRDO").Value
            frm.dtpFecha.Value = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("FECVENC").Value
            frm.txtMonto.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("MONTO").Value
            frm.cmbEstado.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ESTADO").Value
            Select Case dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("TPAGO").Value
                Case "PLANILLA"
                    frm.cmbTpago.SelectedIndex = 0
                Case "GRATIFICACION"
                    frm.cmbTpago.SelectedIndex = 1
                Case "LIQUIDACION"
                    frm.cmbTpago.SelectedIndex = 2
            End Select
        End If
        frm.ShowDialog()


    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtt_doc.Text = "PRE"
        txtnt_doc.Text = "DOCUMENTO PRESTAMO PERSONAL"
        txtt_doc.Enabled = True
        cmb_serdoc.Text = Today.Year
        cmb_serdoc.Enabled = True
        dtpfecha.Value = Today
        dtpfecha.Enabled = True
        Try
            Dim tipo = txtt_doc.Text.ToUpper
            Dim serie = cmb_serdoc.Text
            Dim dtTipoDoc As New DataTable
            dtTipoDoc = PRESTAMOBL.BuscarNomDocumento(tipo)
            If dtTipoDoc.Rows.Count > 0 Then
                txtnt_doc.Text = dtTipoDoc.Rows(0).Item(0)
                txtt_doc.Text = tipo
                dtTipoDoc = PRESTAMOBL.VerificarNumero(tipo, serie)
                Dim numero = dtTipoDoc.Rows(0).ItemArray(0)
                txtnumero.Text = numero
                txtnumero.Text = txtnumero.Text.PadLeft(9, "0")
                txtper_cod.Select()
                If txtt_doc.Text = "ADEL" Then
                    npdcuotas.Value = 1
                End If
            Else
                MsgBox("Verificar Tipo Documento")
                txtt_doc.Select()
            End If
        Catch ex As Exception

        End Try
        cmbEstado.SelectedIndex = 0
        cmbEstado.Enabled = True
        txtper_cod.Text = ""
        txtper_cod.Enabled = True
        btnBuscarPersonal.Enabled = True
        txtper_nom.Text = ""
        txtper_nom.Enabled = True
        npdcuotas.Value = 0
        npdcuotas.Enabled = True
        npdmonto.Value = 0
        npdmonto.Enabled = True
        dtpFec1.Value = Today
        dtpFec1.Enabled = True
        txtObs.Text = ""
        txtObs.Enabled = True
        btnagregar.Enabled = True
        dgvt_doc.Rows.Clear()

        flagAccion = "N"
    End Sub

    Private Sub btnCuota_Click(sender As Object, e As EventArgs) Handles btnCuota.Click
        If cmbEstado.Text = "PAGADO" Then
            MsgBox("PRESTAMO PAGADO")
            Exit Sub
        End If

        Dim frm As New FormModDetPrestamo
        If dgvt_doc.Rows.Count > 0 Then
            gsCode5 = dgvt_doc.CurrentRow.Index
            flagAccion1 = "M"
            frm.btnActualizar.Enabled = False
            frm.txtCuota.Text = dgvt_doc.Rows.Count + 1
            frm.dtpFecha.Value = dgvt_doc.Rows(dgvt_doc.Rows.Count - 1).Cells("FECVENC").Value
            frm.txtPeriodoPago.Text = dgvt_doc.Rows(dgvt_doc.Rows.Count - 1).Cells("PRDO").Value

        End If
        frm.ShowDialog()
    End Sub

    Private Sub FormPrestamoPer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

    Private Sub dtpfecha_LostFocus(sender As Object, e As EventArgs) Handles dtpfecha.LostFocus
        dtpFec1.Value = dtpfecha.Value
        Dim mes = dtpfecha.Value.ToString("MM")
        Dim anho = dtpfecha.Value.ToString("yyyy")
        Dim dtCC As New DataTable
        dtCC = PRESTAMOBL.ListadoCC(mes, anho)
        GetCmb("COD", "NUM", dtCC, cmbPrdoPago)
        cmbPrdoPago.SelectedIndex = 0
    End Sub

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

    Private Sub cmb_serdoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_serdoc.SelectedIndexChanged
        Try
            Dim tipo = txtt_doc.Text.ToUpper
            Dim serie = cmb_serdoc.Text
            Dim dtTipoDoc As New DataTable
            dtTipoDoc = PRESTAMOBL.BuscarNomDocumento(tipo)
            If dtTipoDoc.Rows.Count > 0 Then
                txtnt_doc.Text = dtTipoDoc.Rows(0).Item(0)
                txtt_doc.Text = tipo
                dtTipoDoc = PRESTAMOBL.VerificarNumero(tipo, serie)
                Dim numero = dtTipoDoc.Rows(0).ItemArray(0)
                txtnumero.Text = numero
                txtnumero.Text = txtnumero.Text.PadLeft(9, "0")
                txtper_cod.Select()
                If txtt_doc.Text = "ADEL" Then
                    npdcuotas.Value = 1
                End If
            Else
                MsgBox("Verificar Tipo Documento")
                txtt_doc.Select()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtpfecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpfecha.ValueChanged
        dtpFec1.Value = dtpfecha.Value
        Dim mes = dtpfecha.Value.ToString("MM")
        Dim anho = dtpfecha.Value.ToString("yyyy")
        Dim dtCC As New DataTable
        dtCC = PRESTAMOBL.ListadoCC(mes, anho)
        GetCmb("COD", "NUM", dtCC, cmbPrdoPago)
        cmbPrdoPago.SelectedIndex = 0
    End Sub

    Private Sub cmbPrdoPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPrdoPago.SelectedIndexChanged
        Dim i = cmbPrdoPago.SelectedIndex
        Dim mes = dtpfecha.Value.ToString("MM")
        Dim anho = dtpfecha.Value.ToString("yyyy")
        Dim dtCC As New DataTable
        If i <> -1 Then
            dtCC = PRESTAMOBL.ListadoCC(mes, anho)
            dtpFec1.Value = dtCC.Rows(i).Item(2)
        End If

    End Sub

    Dim PERBL As New PERBL

    Private Sub btnBoleta_Click(sender As Object, e As EventArgs) Handles btnBoleta.Click

        Dim fila = dgvt_doc.CurrentRow.Index
        Dim prdo As String
        For i = fila To fila
            prdo = dgvt_doc.Rows(i).Cells("PRDO").Value
        Next
        If prdo = "" Then
            MsgBox("PERIODO SIN PLANILLA DE PAGO")
            Exit Sub
        End If

        ReDim gsRptArgs(3)
        gsRptArgs(0) = prdo
        gsRptArgs(1) = lblNN.Text
        gsRptArgs(2) = txtper_cod.Text
        gsRptArgs(3) = "MEN"

        PERBL.ActualizarSPBoleta(prdo)

        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_BOLETA_PAGOX.rpt"
        gsRptPath = gsPathRpt
        FormReportes.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If dgvt_doc.Rows.Count > 0 Then
        '    Button1.Visible = True
        'Else
        '    Button1.Visible = False
        'End If

        If MessageBox.Show("Desea eliminar los prestamos",
                   Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        Dim c As Integer = 0

        'dgvt_doc.Rows.Clear()
        ' Dim c1 As Integer = 0
        Do
            For i = 0 To dgvt_doc.Rows.Count - 1
                If dgvt_doc.Rows(i).Cells("ESTADO").Value = "CANCELADO" Then
                    c = c + 1
                End If
            Next
            For i = c To dgvt_doc.Rows.Count - 1
                If i < dgvt_doc.Rows.Count Then
                    dgvt_doc.Rows.RemoveAt(c + i)
                End If
            Next
        Loop While c <= dgvt_doc.Rows.Count - 1

    End Sub
End Class

