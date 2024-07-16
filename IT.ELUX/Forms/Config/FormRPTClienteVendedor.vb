Imports System.ComponentModel

Public Class FormRPTClienteVendedor
    Private Sub FormRPTClienteVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Cliente-Vendedor"
    End Sub

    Private Sub FormRPTClienteVendedor_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click

        ReDim gsRptArgs(0)

        gsRptArgs(0) = txtvend.Text

        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTCTCTVEND.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sBusAlm = "41"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtvend.Text = gLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub



    Private Sub txtvend_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvend.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "41"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtvend.Text = gLinea
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
        End If

    End Sub

End Class