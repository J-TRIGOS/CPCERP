Imports IT.ELUX.BL
Imports IT.ELUX.BE
Imports System.ComponentModel

Public Class FormRepMovimHojalata
    Dim T_MOVINVBL As New T_MOVINVBL
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim sOK As String = T_MOVINVBL.ReporteConsumos("consumos", cmbaño.Text, CDbl(txtanchomin.Text), CDbl(txtanchomax.TextAlign), CDbl(txtlargmin.Text), CDbl(txtlargmax.Text), txtempmin.Text, txtempmax.Text, CDbl(txtespesmin.Text), CDbl(txtespesmax.Text))
        If sOK = "OK" Then

        Else
            FormMain.LblError.Text = sOK
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
            Exit Sub
        End If
        ReDim gsRptArgs(8)
        gsRptArgs(0) = cmbaño.Text
        gsRptArgs(1) = CDbl(txtanchomin.Text)
        gsRptArgs(2) = CDbl(txtanchomax.Text)
        gsRptArgs(3) = CDbl(txtlargmin.Text)
        gsRptArgs(4) = CDbl(txtlargmax.Text)
        gsRptArgs(5) = CDbl(txtempmin.Text)
        gsRptArgs(6) = CDbl(txtempmax.Text)
        gsRptArgs(7) = txtespesmin.Text
        gsRptArgs(8) = txtespesmax.Text

        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPT_ARTSTKHOJA.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub FormRepMovimHojalata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Movimiento Hojalata"
    End Sub

    Private Sub FormRepMovimHojalata_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
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
        If cmbaño.SelectedIndex = -1 Then
            MsgBox("Debe Elegir un año de busqueda ", MsgBoxStyle.Exclamation)
            txtespesmin.Focus()
            Return False
        End If
        Return True
    End Function
End Class