Imports System.ComponentModel

Public Class FormRptPerCesado
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRptPerCesado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbaño.SelectedItem = sAño
    End Sub

    Private Sub FormRptPerCesado_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sBusAlm = "37"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtdni2.Text = gLinea
            txtnomape2.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub txtdni2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdni2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtdni2.Text = gLinea
                txtnomape2.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(1)
        If chkest.Checked Then
            gsRptArgs(0) = cmbaño.Text
        Else
            gsRptArgs(0) = ""
        End If
        gsRptArgs(1) = txtdni2.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTTRABAJADORES_CESADOS.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub txtdni2_LostFocus(sender As Object, e As EventArgs) Handles txtdni2.LostFocus
        If txtdni2.Text = "" Then
            txtnomape2.Text = ""
        End If
    End Sub
End Class