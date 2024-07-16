Imports System.ComponentModel

Public Class FormReporte_T_Env
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormReporte_T_Env_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Reporte Envases"

    End Sub

    Private Sub FormReporte_T_Env_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "17"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        gsRptArgs = {}
        ReDim gsRptArgs(0)
        gsRptArgs(0) = txtcliente1.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_EL_TBARTSTOCK_T_ENV.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class