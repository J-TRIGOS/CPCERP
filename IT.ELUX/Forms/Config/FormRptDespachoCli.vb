Imports System.ComponentModel

Public Class FormRptDespachoCli
    Private Sub FormRptDespachoCli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Despacho por Fecha"
        Dim dtFecha As Date = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        dtpfec1.Value = dtFecha
    End Sub

    Private Sub FormRptDespachoCli_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "25"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sBusAlm = "26"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        gsRptArgs = {}
        ReDim gsRptArgs(5)
        gsRptArgs(0) = Format(dtpfec1.Value, "yyyy/MM/dd")
        gsRptArgs(1) = Format(dtpfec2.Value, "yyyy/MM/dd")
        gsRptArgs(2) = txtcliente1.Text
        gsRptArgs(3) = txtcliente2.Text
        gsRptArgs(4) = txtarticulo1.Text
        gsRptArgs(5) = txtarticulo2.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_DESPACHO_CLI.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "11"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtarticulo1.Text = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "12"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtarticulo2.Text = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub
End Class