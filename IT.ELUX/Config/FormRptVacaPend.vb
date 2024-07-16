
Public Class FormRptVacaPend
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'If cmbt_pago.SelectedIndex <> 0 Then
        ReDim gsRptArgs(1)
        gsRptArgs(0) = cmbaño2.Text
        If Cmbt_per1.SelectedIndex = 1 Then
            gsRptArgs(1) = "20"
        ElseIf Cmbt_per1.SelectedIndex = 2 Then
            gsRptArgs(1) = "21"
        Else
            gsRptArgs(1) = ""
        End If
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_VACACIONES_PEND.rpt"
        gsRptPath = gsPathRpt
        FormReportes.Show()
    End Sub

    Private Sub FormRptVacaPend_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Vacaciones Pendientes"
        cmbaño2.SelectedItem = sAño
        If gsUser = "JMONTES" Or gsUser = "JFLORES" Then
            Cmbt_per1.Text = "OBREROS"
            Cmbt_per1.Enabled = False
        End If
    End Sub
End Class