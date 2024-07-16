Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormReporteReqxEstado

    Private primero As Boolean
    Private primero2 As Boolean
    Private ARTICULOBL As New ARTICULOBL
    Private ELTBLINESBL As New ELTBLINESBL


    Private Sub FormReporteReqxEstado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Reporte de Requerimientos x Estado"
        primero = True
        primero2 = True

        dtpFecDesde.Value = "01/01/" + Year(Date.Now).ToString

        Dim dt As New DataTable
        dt = ARTICULOBL.SelectDescripcion()
        GetCmb("lin_codigo", "lin_descri", dt, cmbLineas)
        ' GetCmb("lin_codigo", "lin_descri", dt, cmbLineas)

        Dim dtCC As New DataTable
        dtCC = ARTICULOBL.ListadoCC()
        GetCmb("COD", "NOM", dtCC, cmbCentro)
        primero = False
        primero2 = False
        cmbEstado.SelectedIndex = 0

    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        ReDim gsRptArgs(8)
        gsRptArgs(0) = dtpFecDesde.Value.ToString("dd/MM/yyyy")
        gsRptArgs(1) = dtpFecHasta.Value.ToString("dd/MM/yyyy")
        Select Case cmbLineas.SelectedIndex
            Case -1
                gsRptArgs(2) = ""
            Case Else
                gsRptArgs(2) = cmbLineas.Text.Substring(0, 2)
        End Select

        Select Case cmbSublineas.SelectedIndex
            Case -1
                gsRptArgs(3) = ""
            Case Else
                gsRptArgs(3) = cmbSublineas.Text.Substring(0, 4)
        End Select

        gsRptArgs(4) = txtcodart.Text

        Select Case cmbCentro.SelectedIndex
            Case -1
                gsRptArgs(5) = ""
            Case Else
                gsRptArgs(5) = cmbCentro.Text.Substring(0, 3)
        End Select

        Select Case txt_codAct.Text
            Case ""
                gsRptArgs(6) = "T"
            Case Else
                gsRptArgs(6) = txt_codAct.Text
        End Select

        gsRptArgs(7) = txt_perCod.Text

        Select Case cmbEstado.SelectedIndex
            Case 0
                gsRptArgs(8) = "P"
            Case 1
                gsRptArgs(8) = "A"
        End Select

        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_LISTADO_REQ_X_MES.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

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

    Private Sub cmbSublineas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSublineas.SelectedIndexChanged
        'change subline
        If primero Then Exit Sub

        Dim sCode As String = cmbSublineas.SelectedValue
        Dim dt As New DataTable

        primero = True
        dt = ARTICULOBL.SelectAll(sCode)
        If dt.Rows.Count > 0 Then
            GetCmb("COD", "art_descri", dt, cmbArticulo)

        Else
            MsgBox("La Sublinea no tiene articulos")
            'For i = 0 To cmbart.Items.Count - 1
            cmbArticulo.DataSource = Nothing
            'Next
            'cmbart.Refresh()
        End If

        primero = False
    End Sub

    Private Sub cmbArticulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbArticulo.SelectedIndexChanged
        If primero Then Exit Sub
        txtcodart.Text = cmbArticulo.SelectedValue
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        sBusAlm = "3"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            cmbLineas.SelectedValue = gLinea
            cmbSublineas.SelectedValue = gSubLinea
            cmbArticulo.SelectedValue = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub txtcodart_Validated(sender As Object, e As EventArgs) Handles txtcodart.Validated
        If primero2 Then Exit Sub
        'buscar articulo

        cmbLineas.SelectedValue = Mid(txtcodart.Text, 1, 2) + "00"

        If cmbLineas.SelectedValue = "" Then
            Exit Sub
        End If

        cmbSublineas.SelectedValue = Mid(txtcodart.Text, 1, 4)

        If cmbSublineas.SelectedValue = "" Then
            Exit Sub
        End If

        cmbArticulo.SelectedValue = txtcodart.Text
        ' cmbLineas_SelectedIndexChanged(Nothing, Nothing)
        gsCode = gsCode
        '
        'cmbSublineas_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub FormReporteReqxEstado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

    Private Sub btnBusAct_Click(sender As Object, e As EventArgs) Handles btnBusAct.Click
        sBusAlm = "ACT"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txt_codAct.Text = gLinea
            txt_nomAct.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub btnBusPer_Click(sender As Object, e As EventArgs) Handles btnBusPer.Click
        sBusAlm = "228"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txt_perCod.Text = gLinea
            txt_nomPer.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub txt_codAct_Leave(sender As Object, e As EventArgs) Handles txt_codAct.Leave
        If txt_codAct.Text = "" Then
            txt_nomAct.Text = ""
        End If
    End Sub

    Private Sub cmbCentro_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbCentro.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            cmbCentro.SelectedIndex = -1
        End If
    End Sub

    Private Sub txtcodart_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodart.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            cmbArticulo.SelectedIndex = -1
        End If
    End Sub

    Private Sub txt_perCod_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_perCod.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            txt_nomPer.Text = ""
        End If
    End Sub
End Class