Imports IT.ELUX.BL
Public Class FormRptNetoAPagar
    Private ELPERIODOBL As New ELPERIODOBL
    Private Sub FormNetoPagoMen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Neto a Pagar"
        Me.dtpfec_ini.Enabled = False
        If gsUser = "JMONTES" Or gsUser = "JFLORES" Then
            Cmbt_per1.Text = "OBREROS"
            Cmbt_per2.Text = "OBREROS"
            Cmbt_per1.Enabled = False
            Cmbt_per2.Enabled = False
        End If
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
    Private Sub cmbt_pago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbt_pago.SelectedIndexChanged

    End Sub
    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        If cmbt_pago.SelectedIndex <> 3 Then
            ReDim gsRptArgs(3)
            gsRptArgs(0) = txt_periodo.Text
            If cmbt_pago.SelectedIndex = 1 Then
                gsRptArgs(1) = "MEN"
            ElseIf cmbt_pago.SelectedIndex = 2 Then
                gsRptArgs(1) = "GRA"
            ElseIf cmbt_pago.SelectedIndex = 3 Then
                gsRptArgs(1) = ""
            Else
                gsRptArgs(1) = ""
            End If
            If Cmbt_per1.SelectedIndex = 1 Then
                gsRptArgs(2) = "20"
            ElseIf Cmbt_per1.SelectedIndex = 2 Then
                gsRptArgs(2) = "21"
            Else
                gsRptArgs(2) = ""
            End If
            If Cmbt_per2.SelectedIndex = 1 Then
                gsRptArgs(3) = "20"
            ElseIf Cmbt_per2.SelectedIndex = 2 Then
                gsRptArgs(3) = "21"
            Else
                gsRptArgs(3) = ""
            End If
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_NETO_APAGAR_MENSUAL.rpt"
            gsRptPath = gsPathRpt
            FormReportes.Show()
        Else
            ReDim gsRptArgs(1)
            If Cmbt_per1.SelectedIndex = 1 Then
                gsRptArgs(0) = "20"
            ElseIf Cmbt_per1.SelectedIndex = 2 Then
                gsRptArgs(0) = "21"
            Else
                gsRptArgs(0) = ""
            End If
            If Cmbt_per2.SelectedIndex = 1 Then
                gsRptArgs(1) = "20"
            ElseIf Cmbt_per2.SelectedIndex = 2 Then
                gsRptArgs(1) = "21"
            Else
                gsRptArgs(1) = ""
            End If
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_NETO_APAGAR_QUINCENAL.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If
    End Sub
    Private Sub Cmbt_per_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbt_per1.SelectedIndexChanged

    End Sub
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub
    Private Sub txt_periodo_TextChanged(sender As Object, e As EventArgs) Handles txt_periodo.TextChanged

    End Sub
End Class