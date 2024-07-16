Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormRptStockFecha
    Private T_MOVINVBL As New T_MOVINVBL
    Private ELTBLINESBL As New ELTBLINESBL
    Private ELETIQUETABL As New ELETIQUETABL
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dispose()
    End Sub

    Private Sub FormRptStockFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtFecha As Date = DateSerial(Year(Date.Today), 1, 1)
        dtpini.Value = dtFecha
        dtpini2.Value = dtFecha
        cmbalmacen.SelectedIndex = 0
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        Dim año As String = dtpini.Value.Year.ToString
        Dim año1 As String = dtpfin.Value.Year.ToString
        Dim fec As String = dtpini.Value.Year.ToString & "/" & dtpini.Value.Month.ToString.PadLeft(2, "0") & "/" & dtpini.Value.Day.ToString.PadLeft(2, "0")
        Dim fec1 As String = dtpfin.Value.Year.ToString & "/" & dtpfin.Value.Month.ToString.PadLeft(2, "0") & "/" & dtpfin.Value.Day.ToString.PadLeft(2, "0")
        Dim almacen As String = Mid(cmbalmacen.Text, 1, 4)
        Cursor.Current = Cursors.WaitCursor
        gsRptArgs = {}
        If chkcontabilidad.Checked = True Then
            gsError = T_MOVINVBL.ReporteKardex1("kardex-conta", año, año1, fec, fec1, almacen, txtsublinea.Text)
        Else
            gsError = T_MOVINVBL.ReporteKardex1("kardex-todos", año, año1, fec, fec1, almacen, txtsublinea.Text)
        End If

        If gsError = "OK" Then
            If chkcontabilidad.Checked = True Then
                ReDim gsRptArgs(3)
                gsRptArgs(0) = Format(dtpini.Value, "yyyy/MM/dd")
                gsRptArgs(1) = Format(dtpfin.Value, "yyyy/MM/dd")
                If cmbstk.SelectedIndex = 1 Or cmbstk.SelectedIndex = 0 Then
                    gsRptArgs(2) = 0
                ElseIf cmbstk.SelectedIndex = -1 Or cmbstk.SelectedIndex = 2 Then
                    gsRptArgs(2) = 1
                End If
                If cmblinea.SelectedIndex = -1 Or cmblinea.SelectedIndex = 0 Then
                    gsRptArgs(3) = ""
                ElseIf cmblinea.SelectedIndex = 1 Then
                    gsRptArgs(3) = "1"
                ElseIf cmblinea.SelectedIndex = 2 Then
                    gsRptArgs(3) = "2"
                ElseIf cmblinea.SelectedIndex = 3 Then
                    gsRptArgs(3) = "3"
                End If
                If gsUser = "CHOYOS" Or gsUser = "COSTOS" Or gsUser = "JTRIGOS" Or gsUser = "SISTEMA" Then
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STKFISFEC1_ES.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                Else
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STKFISFEC1.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                End If

            Else
                ReDim gsRptArgs(3)
                gsRptArgs(0) = almacen
                gsRptArgs(1) = Format(dtpini.Value, "yyyy/MM/dd")
                gsRptArgs(2) = Format(dtpfin.Value, "yyyy/MM/dd")
                If cmbstk.SelectedIndex = 1 Or cmbstk.SelectedIndex = 0 Then
                    gsRptArgs(3) = 0
                ElseIf cmbstk.SelectedIndex = -1 Or cmbstk.SelectedIndex = 2 Then
                    gsRptArgs(3) = 1
                End If
                'If chkcontabilidad.Checked = True Then
                '    gsRptArgs(4) = 1
                'Else
                '    gsRptArgs(4) = 0
                'End If
                If txtsublinea.Text = "0201" Then
                    If gsUser = "CHOYOS" Or gsUser = "COSTOS" Or gsUser = "JTRIGOS" Or gsUser = "SISTEMA" Then
                        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STKFISFEC2_ES.rpt"
                        gsRptPath = gsPathRpt
                        FormReportes.ShowDialog()
                    Else
                        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STKFISFEC2.rpt"
                        gsRptPath = gsPathRpt
                        FormReportes.ShowDialog()
                    End If

                Else
                    If gsUser = "CHOYOS" Or gsUser = "COSTOS" Or gsUser = "JTRIGOS" Or gsUser = "SISTEMA" Then
                        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STKFISFEC_ES.rpt"
                        gsRptPath = gsPathRpt
                        FormReportes.ShowDialog()
                    Else
                        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STKFISFEC.rpt"
                        gsRptPath = gsPathRpt
                        FormReportes.ShowDialog()
                    End If

                End If

            End If

        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txtsublinea_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsublinea.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "221"
            Dim frm As New FormBUSQUEDA
            gsCode7 = txtlinea.Text
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtsublinea.Text = Trim(gLinea)
                txtnomsublinea.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtlinea_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlinea.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "222"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtlinea.Text = Trim(gLinea)
                txtnomlinea.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtsublinea_LostFocus(sender As Object, e As EventArgs) Handles txtsublinea.LostFocus
        If txtsublinea.TextLength = 4 Then
            txtnomsublinea.Text = ELTBLINESBL.SelectDescri(txtsublinea.Text)
        Else
            txtnomsublinea.Text = ""
        End If
    End Sub

    Private Sub txtlinea_LostFocus(sender As Object, e As EventArgs) Handles txtlinea.LostFocus
        If txtlinea.TextLength = 2 Then
            txtnomlinea.Text = ELTBLINESBL.SelectDescri(txtlinea.Text & "00")
        Else
            txtnomlinea.Text = ""
        End If
    End Sub

    Private Sub chkcontabilidad_CheckedChanged(sender As Object, e As EventArgs) Handles chkcontabilidad.CheckedChanged
        If chkcontabilidad.Checked Then
            txtlinea.Enabled = False
            txtlinea.Text = ""
            txtnomlinea.Text = ""
            txtsublinea.Enabled = False
            txtsublinea.Text = ""
            txtnomsublinea.Text = ""
            cmblinea.Enabled = True
            cmblinea.SelectedIndex = -1
        Else
            txtlinea.Enabled = True
            txtlinea.Text = ""
            txtnomlinea.Text = ""
            txtsublinea.Enabled = True
            txtsublinea.Text = ""
            txtnomsublinea.Text = ""
            cmblinea.Enabled = False
            cmblinea.SelectedIndex = -1
        End If
    End Sub

    Private Sub FormRptStockFecha_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cursor.Current = Cursors.WaitCursor
        gsRptArgs = {}
        ReDim gsRptArgs(4)
        gsRptArgs(0) = Format(dtpini2.Value, "yyyyMM")
        gsRptArgs(1) = Format(dtpfin2.Value, "yyyyMM")
        gsRptArgs(2) = txtsublinea2.Text
        gsRptArgs(3) = txtcodart.Text
        gsRptArgs(4) = txtfam_Cod.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STKFISFEC3.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
    Private Sub txtcodart_LostFocus(sender As Object, e As EventArgs) Handles txtcodart.LostFocus
        If (txtcodart.Text = "") Then
            lbldescripcion.Text = ""
            txtfam_Cod.Text = ""
            lblfam_cod.Text = ""
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectArticuloCOD(txtcodart.Text)
            If dt.Rows.Count > 0 Then
                txtcodart.Text = dt.Rows(0).Item(0).ToString
                lbldescripcion.Text = dt.Rows(0).Item(1).ToString
                BuscarFamilia(txtcodart.Text)
                Label5.Text = txtfam_Cod.Text
            Else
                txtcodart.Text = ""
                lbldescripcion.Text = ""
            End If
        End If
    End Sub
    Private Sub txtcodart_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodart.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "56"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtcodart.Text = gLinea
                lbldescripcion.Text = gSubLinea
                BuscarFamilia(gLinea)
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
            e.Handled = True

        End If
        gLinea = Nothing
        gSubLinea = Nothing
    End Sub
    Sub BuscarFamilia(ByVal articulo As String)
        Dim dt As DataTable
        dt = ELETIQUETABL.BuscarFamArt(articulo)
        If dt.Rows.Count > 0 Then
            txtfam_Cod.Text = dt.Rows(0).Item(0).ToString
            lblfam_cod.Text = dt.Rows(0).Item(1).ToString
            Label5.Text = txtfam_Cod.Text
        Else
            txtfam_Cod.Text = ""
            lblfam_cod.Text = ""
        End If
    End Sub
    Private Sub txtfam_Cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtfam_Cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "116"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtfam_Cod.Text = gLinea
                lblfam_cod.Text = gSubLinea
            Else
                gLinea = ""
                gSubLinea = ""
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub
    Private Sub txtfam_Cod_LostFocus(sender As Object, e As EventArgs) Handles txtfam_Cod.LostFocus
        If (txtfam_Cod.Text = "") Then
            lblfam_cod.Text = ""
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectFamiliaCOD(txtfam_Cod.Text)
            If dt.Rows.Count > 0 Then
                txtfam_Cod.Text = dt.Rows(0).Item(0).ToString
                lblfam_cod.Text = dt.Rows(0).Item(1).ToString
            Else
                txtfam_Cod.Text = ""
                lblfam_cod.Text = ""
            End If
        End If
    End Sub
End Class