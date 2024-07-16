Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormFiltroProgramacion
    Private ARTICULOBL As New ARTICULOBL
    Private ELETIQUETABL As New ELETIQUETABL
    Private ELTBTAREOBL As New ELTBTAREOBL
    Private ELPAGO_DOCUMENTOBL As New ELPAGO_DOCUMENTOBL
    Private ELDOCUMENTOBL As New ELDOCUMENTOBL
    Private PROVISIONESBL As New PROVISIONESBL

    Private Sub FormFiltroProgramacion_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub txtcodccosto_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "29"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtcodccosto.Text = gLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub

    Private Sub btnbusccosto_Click(sender As Object, e As EventArgs) Handles btnbusccosto.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If (gLinea <> Nothing) Then
            txtcodccosto.Text = gLinea
        End If
    End Sub

    Private Sub FormFiltroProgramacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class