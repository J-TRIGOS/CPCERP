Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormRPTBINDCARD
    Private ARTICULOBL As New ARTICULOBL
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "106"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtarticulo1.Text = gLinea
            txtnomart1.Text = gSubLinea
            txtunidad.Text = ARTICULOBL.SelectUniMed(txtarticulo1.Text)
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub txtarticulo1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtarticulo1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "106"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtarticulo1.Text = gLinea
                txtnomart1.Text = gSubLinea
                txtunidad.Text = ARTICULOBL.SelectUniMed(txtarticulo1.Text)
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtarticulo1_LostFocus(sender As Object, e As EventArgs) Handles txtarticulo1.LostFocus
        If txtarticulo1.TextLength > 0 Then
            txtnomart1.Text = ARTICULOBL.SelectArt2(txtarticulo1.Text)
            txtunidad.Text = ARTICULOBL.SelectUniMed(txtarticulo1.Text)
        Else
            txtarticulo1.Text = ""
            txtnomart1.Text = ""
            'txtunidad.Text = ""
        End If
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(3)
        gsRptArgs(0) = txtarticulo1.Text
        gsRptArgs(1) = npdcantidad.Value
        gsRptArgs(2) = txtnro.Text
        gsRptArgs(3) = txtnbulto.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_BINCARD.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub FormRPTBINDCARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class