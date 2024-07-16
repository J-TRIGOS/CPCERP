Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRptListAFP
    Private ELPERIODOBL As New ELPERIODOBL
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dispose()
    End Sub

    Private Sub FormRptListAFP_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
    Private Sub txtcontrato_prdo5_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontrato_prdo5.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "86"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
                txtcontrato_prdo5.Text = gLinea
                dtpfec_ini5.Value = gArt
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
    Private Sub txtcontrato_prdo5_LostFocus(sender As Object, e As EventArgs) Handles txtcontrato_prdo5.LostFocus
        If txtcontrato_prdo5.TextLength = 0 Then
            dtpfec_ini5.Checked = False
        Else
            If ELPERIODOBL.SelectFecPRd(txtcontrato_prdo5.Text) = "0" Then
                MsgBox("El periodo no existe")
            Else
                dtpfec_ini5.Text = ELPERIODOBL.SelectFecPRd(txtcontrato_prdo5.Text)
                dtpfec_ini5.Checked = True
            End If
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ReDim gsRptArgs(0)
        gsRptArgs(0) = txtcontrato_prdo5.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPT_LISTAFP.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class