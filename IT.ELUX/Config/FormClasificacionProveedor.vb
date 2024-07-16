Imports System.ComponentModel

Public Class FormClasificacionProveedor
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Dispose()
    End Sub

    Private Sub FormClasificacionProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Clasificacion Proveedor"
    End Sub

    Private Sub FormClasificacionProveedor_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(0)
        gsRptArgs(0) = txtaño1.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_CLASIFICACION_PROV.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class