Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRptRemuAfp
    Private ELPERIODOBL As New ELPERIODOBL
    Private Sub FormRptRemuAfp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Remuneraciones por AFP"
        Me.dtpfec_ini.Enabled = False
    End Sub
    Private Sub cmbt_pago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbt_pago.SelectedIndexChanged

    End Sub
    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(1)
        gsRptArgs(0) = txt_periodo.Text
        If cmbt_pago.SelectedIndex = 1 Then
            gsRptArgs(1) = "MEN"
        ElseIf cmbt_pago.SelectedIndex = 2 Then
            gsRptArgs(1) = "GRA"
        Else
            gsRptArgs(1) = ""
        End If
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_REMU_AFP.rpt"
        gsRptPath = gsPathRpt
        FormReportes.Show()
    End Sub
    Private Sub txt_periodo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_periodo.KeyDown
        If chkperiodo.Checked = True Then
            If e.KeyValue = Keys.F9 Then
                sBusAlm = "86"
                Dim frm As New FormBUSQUEDA
                frm.ShowDialog()
                If gLinea <> Nothing And gSubLinea <> Nothing Then
                    txt_periodo.Text = gLinea
                    dtpfec_ini.Value = gArt
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gArt = Nothing
                Else
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gArt = Nothing
                End If
                e.Handled = True
            End If
        Else
            If e.KeyValue = Keys.F9 Then
                sBusAlm = "85"
                Dim frm As New FormBUSQUEDA
                frm.ShowDialog()
                If gLinea <> Nothing And gSubLinea <> Nothing Then
                    txt_periodo.Text = gLinea
                    dtpfec_ini.Value = gArt
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gArt = Nothing
                Else
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gArt = Nothing
                End If
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub
End Class