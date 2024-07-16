Imports IT.ELUX.BL
Public Class FormRptResumenSenati
    Private ELPERIODOBL As New ELPERIODOBL
    Private Sub FormRptResumenSenati_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If gsCode11 = "" Then
            Me.Text = "Resumen Senati"
            Me.dtpfec_ini.Enabled = False
        Else
            Me.Text = "Pago Vacaciones"
            Me.dtpfec_ini.Enabled = False
            Me.Label3.Visible = True
            Me.Cmbt_per1.Visible = True
            If gsUser = "JFLORES" Then
                Cmbt_per1.Enabled = False
                Cmbt_per1.SelectedIndex = 1
            Else
                Cmbt_per1.SelectedIndex = 2
            End If
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRptResumenSenati_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dispose()
    End Sub

    Private Sub txt_periodo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_periodo.KeyDown

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
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click

        If gsCode11 = "" Then
            ReDim gsRptArgs(0)
            gsRptArgs(0) = txt_periodo.Text
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_CONSULTASENATI.rpt"
            gsRptPath = gsPathRpt
            FormReportes.Show()
        Else
            ReDim gsRptArgs(1)
            gsRptArgs(0) = txt_periodo.Text
            If Cmbt_per1.SelectedIndex = 1 Then
                gsRptArgs(1) = "20"
            ElseIf Cmbt_per1.SelectedIndex = 2 Then
                gsRptArgs(1) = "21"
            Else
                gsRptArgs(1) = ""
            End If
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_PER_VACACIONESPAGO.rpt"
            gsRptPath = gsPathRpt
            FormReportes.Show()
        End If



    End Sub

    Private Sub txt_periodo_LostFocus(sender As Object, e As EventArgs) Handles txt_periodo.LostFocus
        If txt_periodo.TextLength = 0 Then
            dtpfec_ini.Checked = False
        Else
            If ELPERIODOBL.SelectFecPRd(txt_periodo.Text) = "0" Then
                MsgBox("El periodo no existe")
            Else
                dtpfec_ini.Text = ELPERIODOBL.SelectFecPRd(txt_periodo.Text)
                dtpfec_ini.Checked = True
            End If
        End If
    End Sub
End Class