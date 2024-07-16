Imports System.ComponentModel
Imports IT.ELUX.BL

Public Class FormRptFecKardex
    Dim T_MOVINVBL As New T_MOVINVBL
    Dim m As String
    Private primero As Boolean
    Private primero2 As Boolean
    Private ARTICULOBL As New ARTICULOBL
    Private ELTBLINESBL As New ELTBLINESBL
    Private Function getCmbAño(ByVal cmb As ComboBox)
        cmb.Items.Clear()
        cmb.Items.Add("2022")
        cmb.Items.Add("2023")
        cmb.Items.Add("2024")
        cmb.Items.Add("2025")
        cmb.Items.Add("2026")
        cmb.Items.Add("2027")
        cmb.Items.Add("2028")
        cmb.Items.Add("2029")
        cmb.Items.Add("2030")
    End Function
    Private Function getCmbMes(ByVal cmb As ComboBox)
        cmb.Items.Add("Enero")
        cmb.Items.Add("Febrero")
        cmb.Items.Add("Marzo")
        cmb.Items.Add("Abril")
        cmb.Items.Add("Mayo")
        cmb.Items.Add("Junio")
        cmb.Items.Add("Julio")
        cmb.Items.Add("Agosto")
        cmb.Items.Add("Septiembre")
        cmb.Items.Add("Octubre")
        cmb.Items.Add("Noviembre")
        cmb.Items.Add("Diciembre")
    End Function

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRptFecKardex_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub FormRptFecKardex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        primero = True
        primero2 = True

        Dim dt As New DataTable
        dt = ARTICULOBL.SelectDescripcion()
        GetCmb("lin_codigo", "lin_descri", dt, cmbLineas)
        ' GetCmb("lin_codigo", "lin_descri", dt, cmbLineas)

        primero = False
        primero2 = False
        cmbAlmacen.SelectedIndex = 1

        cmbtipo.SelectedIndex = 0
        drpMes.Enabled = False
        drpAnho.Enabled = False
        getCmbAño(drpAnho)
        getCmbMes(drpMes)
        drpAnho.Text = Today.Year.ToString
        drpMes.SelectedIndex = Today.Month - 1
        '-----------------------
        'dtpfecha.Enabled = False
        drpAnho.Enabled = True
        drpMes.Enabled = True
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click

        If chk_todos.Checked = True Then
            m = "1"
        Else
            m = "2"
        End If
        If chkInventario.Checked Then
            Cursor.Current = Cursors.WaitCursor
            ReDim gsRptArgs(5)
            gsRptArgs(0) = dtpfecha.Value.ToString("dd/MM/yyyy")
            If cmbAlmacen.SelectedIndex = 1 Then
                gsRptArgs(1) = "0001"
            Else
                'MsgBox("Seleccione una Opcion diferente de almacen")
                'Exit Sub
                gsRptArgs(1) = ""
            End If
            Dim mes = ""
            Dim anho = drpAnho.Text
            Select Case drpMes.SelectedIndex
                Case 0
                    mes = "01"
                Case 1
                    mes = "02"
                Case 2
                    mes = "03"
                Case 3
                    mes = "04"
                Case 4
                    mes = "05"
                Case 5
                    mes = "06"
                Case 6
                    mes = "07"
                Case 7
                    mes = "08"
                Case 8
                    mes = "09"
                Case 9
                    mes = "10"
                Case 10
                    mes = "11"
                Case 11
                    mes = "12"
            End Select
            gsRptArgs(2) = mes
            gsRptArgs(3) = anho
            If cmbLineas.SelectedIndex = -1 Then
                gsRptArgs(4) = ""
            Else
                gsRptArgs(4) = cmbLineas.Text.Substring(0, 2)
            End If

            If cmbSublineas.SelectedIndex = -1 Then
                gsRptArgs(5) = ""
            Else
                gsRptArgs(5) = cmbSublineas.Text.Substring(0, 4)
            End If


            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPT_INVENTARIOS.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        Else
            If cmbtipo.SelectedIndex = 0 Then
                reporteTodos()
                Exit Sub
            End If

            If gsCode = "0" Then
                Cursor.Current = Cursors.WaitCursor
                Dim sOK As String = T_MOVINVBL.ReporteKardex("fisico1", dtpfecha.Value, gsCode2, gsCode3, "")
                Cursor.Current = Cursors.Default
                ReDim gsRptArgs(0)
                gsRptArgs(0) = dtpfecha.Value.ToString("dd/MM/yyyy")
                If sOK = "OK" Then
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTDIFKARSTKFISICO2.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                Else
                    MsgBox(sOK)
                End If
            ElseIf gsCode = "1" Then
                Cursor.Current = Cursors.WaitCursor
                'If cmbsublinea.SelectedIndex <> -1 Then
                gsRptArgs = {}
                Dim sOK As String = T_MOVINVBL.ReporteKardex("valorizado", dtpfecha.Value, gsCode2, gsCode3, "")
                'Cursor.Current = Cursors.Default

                If sOK = "OK" Then
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTDIFKARSTKFISICOVAL.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                Else
                    MsgBox(sOK)
                End If
            End If
        End If


    End Sub

    Private Sub chk_todos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos.CheckedChanged
        If chk_todos.Checked Then
            dtpfecha.Enabled = False
            drpAnho.Enabled = True
            drpMes.Enabled = True
        Else
            dtpfecha.Enabled = True
            drpAnho.Enabled = False
            drpMes.Enabled = False
        End If
    End Sub

    Private Sub reporteTodos()
        Cursor.Current = Cursors.WaitCursor
        Dim mes = ""
        Dim anho = drpAnho.Text
        Dim almacen = ""
        Dim nomAlm = ""
        Dim linea = ""
        Dim sublinea = ""

        If cmbLineas.SelectedIndex = -1 Then
            linea = ""
        Else
            linea = cmbLineas.Text.ToString.Substring(0, 2)
        End If

        If cmbSublineas.SelectedIndex = -1 Then
            sublinea = ""
        Else
            sublinea = cmbSublineas.Text.ToString.Substring(0, 4)
        End If
        Select Case cmbAlmacen.SelectedIndex
            Case 0
                almacen = ""
                nomAlm = "TODOS"
            Case 1
                almacen = "0001"
                nomAlm = "GALERA 108 PANAMA"
            Case 2
                almacen = "0002"
                nomAlm = "FALLADO PANAMA"
        End Select

        Select Case drpMes.SelectedIndex
            Case 0
                mes = "01"
            Case 1
                mes = "02"
            Case 2
                mes = "03"
            Case 3
                mes = "04"
            Case 4
                mes = "05"
            Case 5
                mes = "06"
            Case 6
                mes = "07"
            Case 7
                mes = "08"
            Case 8
                mes = "09"
            Case 9
                mes = "10"
            Case 10
                mes = "11"
            Case 11
                mes = "12"
        End Select

        If chkInventario.Checked = True Then
            estInventario = 1
        Else
            estInventario = 0
        End If

        Dim dtFechaCorte As New DataTable
        dtFechaCorte = T_MOVINVBL.BuscarFechaCorte(mes, anho, sublinea, almacen, linea)
        If dtFechaCorte.Rows.Count > 0 Then
            For i = 0 To dtFechaCorte.Rows.Count - 1
                Dim fecha = dtFechaCorte.Rows(i).Item(0)
                Dim slinea = dtFechaCorte.Rows(i).Item(1)
                Dim codalm = dtFechaCorte.Rows(i).Item(2)
                'Dim artcod = dtFechaCorte.Rows(i).Item(3)
                Dim resp = "-"
                resp = T_MOVINVBL.ReporteKardex("TODOS", fecha, slinea, codalm, estInventario)
            Next
        Else
            MsgBox("No hay fecha de Corte para periodo " & mes & anho)
            Exit Sub
        End If
        Dim sOK As String = "OK"
        'gsRptArgs = {}

        Cursor.Current = Cursors.Default
        ReDim gsRptArgs(5)
        gsRptArgs(0) = mes
        gsRptArgs(1) = anho
        gsRptArgs(2) = almacen
        gsRptArgs(3) = nomAlm
        If cmbSublineas.SelectedIndex = -1 Then
            gsRptArgs(4) = ""
        Else
            gsRptArgs(4) = cmbSublineas.Text.ToString.Substring(0, 4)
        End If
        If cmbLineas.SelectedIndex = -1 Then
            gsRptArgs(5) = ""
        Else
            gsRptArgs(5) = cmbLineas.Text.ToString.Substring(0, 2)
        End If
        If sOK = "OK" Then
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTDIFKARSTKFISICO2_TODOS.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        Else
            MsgBox(sOK)
        End If
    End Sub

    Private Sub cmbtipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtipo.SelectedIndexChanged
        If cmbtipo.SelectedIndex = 0 Then
            dtpfecha.Enabled = True
            drpAnho.Enabled = True
            drpMes.Enabled = True
        Else
            dtpfecha.Enabled = True
            drpAnho.Enabled = False
            drpMes.Enabled = False
        End If
    End Sub

    Private Sub cmbLineas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLineas.SelectedIndexChanged
        'change line
        If primero Then Exit Sub

        '    primero = True
        Dim sCode As String = Mid(cmbLineas.SelectedValue, 1, 2)
        Dim dt As New DataTable

        primero = True
        dt = ARTICULOBL.SelectDescripcion1(sCode)
        GetCmb("lin_codigo", "lin_descri", dt, cmbSublineas)
        primero = False
    End Sub

    Private Sub cmbSublineas_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbSublineas.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            cmbSublineas.SelectedIndex = -1
        End If
    End Sub

    Private Sub cmbLineas_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbLineas.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            cmbLineas.SelectedIndex = -1
        End If
    End Sub
End Class