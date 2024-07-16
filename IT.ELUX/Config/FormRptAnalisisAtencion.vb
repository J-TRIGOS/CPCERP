Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormRptAnalisisAtencion
    Private PROVISIONESBL As New PROVISIONESBL
    Private ARTICULOBL As New ARTICULOBL
    Private Sub FormRptAnalisisAtencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Analisis Atencion"
        Dim dtFecha As Date = DateSerial(Year(Date.Today), 1, 1)
        dtpini.Value = dtFecha
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dispose()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ReDim gsRptArgs(7)
        gsRptArgs(0) = Format(dtpini.Value, "yyyy/MM/dd")
        gsRptArgs(1) = Format(dtpfin.Value, "yyyy/MM/dd")
        gsRptArgs(2) = txtcliente1.Text
        gsRptArgs(3) = txtcliente1.Text
        gsRptArgs(4) = txtarticulo1.Text
        gsRptArgs(5) = txtarticulo1.Text
        gsRptArgs(6) = txtnumero.Text
        gsRptArgs(7) = txtnumero.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_DESP_OT_CLI.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtcliente1.Text.Length > 0 Then
            sBusAlm = "37"
            gCliente = txtcliente1.Text
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtarticulo1.Text = gArt
                txtnomarticulo.Text = ARTICULOBL.SelectArt2(txtarticulo1.Text)
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
            gCliente = ""
        Else
            sBusAlm = "106"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtarticulo1.Text = gLinea
                txtnomarticulo.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "39"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente1.Text = gLinea
            txtnomcliente.Text = PROVISIONESBL.SelectT_Prov(txtcliente1.Text)
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub txtcliente1_LostFocus(sender As Object, e As EventArgs) Handles txtcliente1.LostFocus
        If txtcliente1.TextLength > 0 Then
            Dim prov As String = PROVISIONESBL.SelectT_Prov(txtcliente1.Text)
            If prov.Length > 0 Then
                txtnomcliente.Text = prov
            Else
                txtnomcliente.Text = ""
            End If
        Else
            txtcliente1.Text = ""
            txtnomcliente.Text = ""
        End If
    End Sub

    Private Sub txtarticulo1_LostFocus(sender As Object, e As EventArgs) Handles txtarticulo1.LostFocus
        If txtarticulo1.TextLength > 0 Then
            txtnomarticulo.Text = ARTICULOBL.SelectArt2(txtarticulo1.Text)
            'txtunidad.Text = ARTICULOBL.SelectUniMed(txtcodart.Text)
        Else
            txtarticulo1.Text = ""
            txtnomarticulo.Text = ""
            'txtunidad.Text = ""
        End If
    End Sub


End Class