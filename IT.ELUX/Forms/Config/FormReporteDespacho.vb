Imports System.ComponentModel

Public Class FormReporteDespacho
    Private Sub FormReporteDespacho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Despacho Pendiente"
        Dim dtFecha As Date = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        dtpfec1.Value = dtFecha
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "21"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sBusAlm = "22"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sBusAlm = "23"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sBusAlm = "24"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormReporteDespacho_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(7)
        gsRptArgs(0) = Format(dtpfec1.Value, "yyyy/MM/dd")
        gsRptArgs(1) = Format(dtpfec2.Value, "yyyy/MM/dd")
        gsRptArgs(2) = txtcliente1.Text
        gsRptArgs(3) = txtcliente2.Text
        gsRptArgs(4) = txtvend.Text
        gsRptArgs(5) = txtvend1.Text
        gsRptArgs(6) = txtformato1.Text
        gsRptArgs(7) = txtformato2.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPFECDESPACHO.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "51"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtformato1.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "51"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtformato2.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

End Class