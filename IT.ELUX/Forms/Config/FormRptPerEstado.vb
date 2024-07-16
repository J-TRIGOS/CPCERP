Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRptPerEstado
    Private CCOSTOBL As New CCOSTOBL
    Private PERBL As New PERBL
    Private Sub FormRptPerEstado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbsit.SelectedIndex = 1
    End Sub

    Private Sub FormRptPerEstado_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub txtdni_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdni.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtdni.Text = gLinea
                txtnomper.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dispose()
    End Sub

    Private Sub txtc_costo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtc_costo.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "29"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtc_costo.Text = gLinea
                txtnom_ccosto.Text = CCOSTOBL.SelectNom(txtc_costo.Text)
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtlinea_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlinea.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "71"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtlinea.Text = gLinea
                txtnomlinea.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ReDim gsRptArgs(3)
        gsRptArgs(0) = txtdni.Text
        If cmbsit.SelectedIndex = 1 Then
            gsRptArgs(1) = "11"
        ElseIf cmbsit.SelectedIndex = 2 Then
            gsRptArgs(1) = "13"
        End If
        gsRptArgs(2) = txtlinea.Text
        gsRptArgs(3) = txtc_costo.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTPER_ESTADO.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub txtc_costo_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo.LostFocus
        If txtc_costo.TextLength > 2 Then
            txtnom_ccosto.Text = CCOSTOBL.SelectNom(txtc_costo.Text)
        Else
            txtnom_ccosto.Text = ""
        End If

    End Sub
End Class