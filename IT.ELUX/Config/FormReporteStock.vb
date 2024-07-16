Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormReporteStock
    Private ARTICULOBL As New ARTICULOBL
    Private dtExplComponente, dt2 As DataTable

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If OkData() = False Then
            Exit Sub
        Else
            'ORDEN_PRODUCCION
            ReDim gsRptArgs(7)
            gsRptArgs(0) = CDbl(txtanchomin.Text)
            gsRptArgs(1) = CDbl(txtanchomax.Text)
            gsRptArgs(2) = CDbl(txtlargmin.Text)
            gsRptArgs(3) = CDbl(txtlargmax.Text)
            gsRptArgs(4) = CDbl(txtempmin.Text)
            gsRptArgs(5) = CDbl(txtempmax.Text)
            gsRptArgs(6) = txtespesmin.Text
            gsRptArgs(7) = txtespesmax.Text

            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\01\RPT01_REPORTE_ARTICULO_MAX.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If
    End Sub

    Private Sub FormReporteStock_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub FormReporteStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function OkData() As Boolean

        If CDbl(txtanchomin.Text) > CDbl(txtanchomax.Text) Then
            MsgBox("El Ancho minimo no puedo ser mayor al maximo ", MsgBoxStyle.Exclamation)
            txtanchomin.Focus()
            Return False
        End If

        If CDbl(txtlargmin.Text) > CDbl(txtlargmax.Text) Then
            MsgBox("El Largo minimo no puedo ser mayor al maximo ", MsgBoxStyle.Exclamation)
            txtlargmin.Focus()
            Return False
        End If

        If CDbl(txtempmin.Text) > CDbl(txtempmax.Text) Then
            MsgBox("El Temple minimo no puedo ser mayor al maximo ", MsgBoxStyle.Exclamation)
            txtempmin.Focus()
            Return False
        End If

        If CDbl(txtespesmin.Text) > CDbl(txtespesmax.Text) Then
            MsgBox("El Espesor minimo no puedo ser mayor al maximo ", MsgBoxStyle.Exclamation)
            txtespesmin.Focus()
            Return False
        End If

        Return True
    End Function
End Class