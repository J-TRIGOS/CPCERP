Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormReporteOrdenC

    Private ARTICULOBL As New ARTICULOBL
    Private ELETIQUETABL As New ELETIQUETABL
    Private ELTBTAREOBL As New ELTBTAREOBL
    Private ELPAGO_DOCUMENTOBL As New ELPAGO_DOCUMENTOBL

    Private Sub FormReporteOrdenC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'limpiar()
        'Me.Text = "Despacho Pendiente"
        Dim dtFecha As Date = DateSerial(Year(Date.Today), 1, 1)
        dtpfecini.Value = dtFecha
        cmbpendie.SelectedIndex = 5
    End Sub

    'Sub limpiar()
    '    cmbanho.SelectedItem = DateTime.Now.ToString("yyyy")
    '    cmbmes.SelectedIndex = DateTime.Now.Month - 1
    '    cmbpendie.SelectedIndex = 1
    'End Sub

    Private Sub txtt_acti_LostFocus(sender As Object, e As EventArgs) Handles txtt_acti.LostFocus
        If (txtt_acti.Text = "") Then
            lblt_acti.Text = ""
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectActivoCOD(txtt_acti.Text)
            If dt.Rows.Count > 0 Then
                txtt_acti.Text = dt.Rows(0).Item(0).ToString
                lblt_acti.Text = dt.Rows(0).Item(1).ToString
            Else
                txtt_acti.Text = ""
                lblt_acti.Text = ""
            End If
        End If
    End Sub

    Private Sub txt_ccosto_LostFocus(sender As Object, e As EventArgs) Handles txt_ccosto.LostFocus
        If (txt_ccosto.Text = "") Then
            lbl_ccosto.Text = ""
        Else
            Dim dt As DataTable
            dt = ELPAGO_DOCUMENTOBL.SelectCentroCostoCOD(txt_ccosto.Text)
            If dt.Rows.Count > 0 Then
                txt_ccosto.Text = dt.Rows(0).Item(0).ToString
                lbl_ccosto.Text = dt.Rows(0).Item(1).ToString
            Else
                txt_ccosto.Text = ""
                lbl_ccosto.Text = ""
            End If
        End If
    End Sub

    Private Sub txt_ccosto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ccosto.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "101"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txt_ccosto.Text = gLinea
                lbl_ccosto.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub

    Private Sub txtusuario_LostFocus(sender As Object, e As EventArgs) Handles txtusuario.LostFocus
        If (txtusuario.Text = "") Then
            lblusuario.Text = ""
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectUserCOD(txtusuario.Text)
            If dt.Rows.Count > 0 Then
                txtusuario.Text = dt.Rows(0).Item(0).ToString
                lblusuario.Text = dt.Rows(0).Item(1).ToString
            Else
                txtusuario.Text = ""
                lblusuario.Text = ""
            End If
        End If
    End Sub
    Private Sub txtusuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusuario.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "119"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtusuario.Text = gLinea
                lblusuario.Text = gSubLinea
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub txtcodartdos_LostFocus(sender As Object, e As EventArgs) Handles txtcodartdos.LostFocus
        If (txtcodartdos.Text = "") Then
            lblart_des.Text = ""
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectArticuloCOD(txtcodartdos.Text)
            If dt.Rows.Count > 0 Then
                txtcodartdos.Text = dt.Rows(0).Item(0).ToString
                lblart_des.Text = dt.Rows(0).Item(1).ToString
            Else
                txtcodartdos.Text = ""
                lblart_des.Text = ""
            End If
        End If
    End Sub

    Private Sub txtcodartdos_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodartdos.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "220"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtcodartdos.Text = gLinea
                gLinea = Nothing
                gSubLinea = Nothing
                'gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                'gArt = Nothing
            End If
            e.Handled = True
        End If

        If e.KeyValue = Keys.F10 Then
            sBusAlm = "106"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtcodartdos.Text = gLinea
                gLinea = Nothing
                gSubLinea = Nothing
                'gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                'gArt = Nothing
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub txtt_acti_KeyDown(sender As Object, e As KeyEventArgs) Handles txtt_acti.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "118"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtt_acti.Text = gLinea
                lblt_acti.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        ReDim gsRptArgs(6)
        gsRptArgs(0) = cmbpendie.SelectedIndex
        gsRptArgs(1) = txtt_acti.Text
        gsRptArgs(2) = txtusuario.Text
        gsRptArgs(3) = txt_ccosto.Text
        gsRptArgs(4) = txtcodartdos.Text
        gsRptArgs(5) = Format(dtpfecini.Value, "yyyy/MM/dd")
        gsRptArgs(6) = Format(dtpfecfin.Value, "yyyy/MM/dd")
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\01\RPT01_ORDEN_COMPRA.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub FormReporteOrdenC_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class