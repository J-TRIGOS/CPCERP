Imports System.ComponentModel

Public Class FormRptInsumosVenta
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dispose()
    End Sub

    Private Sub FormRptInsumosVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbserie.SelectedIndex = 0
    End Sub

    Private Sub FormRptInsumosVenta_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub BtnDestino_Click(sender As Object, e As EventArgs) Handles BtnDestino.Click
        ReDim gsRptArgs(1)
        gsRptArgs(0) = cmbserie.Text
        gsRptArgs(1) = txtnumero.Text

        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTORDEN_PROGRAM.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub txtnumero_LostFocus(sender As Object, e As EventArgs) Handles txtnumero.LostFocus
        If txtnumero.TextLength <= 7 And txtnumero.TextLength > 0 Then
            txtnumero.Text = txtnumero.Text.PadLeft(7, "0")
        End If
    End Sub
End Class