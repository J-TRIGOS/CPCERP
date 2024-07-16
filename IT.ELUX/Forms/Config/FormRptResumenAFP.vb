Imports IT.ELUX.BL
Public Class FormRptResumenAFP
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

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        If txt_periodo.Text = "" Then
            MsgBox("No ah Seleccionado el periodo de generacion")
            txt_periodo.Focus()
            Exit Sub
        End If
        ReDim gsRptArgs(0)
        gsRptArgs(0) = txt_periodo.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RESUMEN_AFP.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub FormRptResumenAFP_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dispose()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub txt_periodo1_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_periodo1.KeyDown
        If chkperiodo.Checked = True Then
            If e.KeyValue = Keys.F9 Then
                sBusAlm = "86"
                Dim frm As New FormBUSQUEDA
                frm.ShowDialog()
                If gLinea <> Nothing And gSubLinea <> Nothing Then
                    txt_periodo1.Text = gLinea
                    dtpfec_ini1.Value = gArt
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
                    txt_periodo1.Text = gLinea
                    dtpfec_ini1.Value = gArt
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
    Private Sub btnreporte1_Click(sender As Object, e As EventArgs) Handles btnreporte1.Click
        If txt_periodo1.Text = "" Then
            MsgBox("No ah Seleccionado el periodo de generacion")
            txt_periodo.Focus()
            Exit Sub
        End If
        ReDim gsRptArgs(0)
        gsRptArgs(0) = txt_periodo1.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_HOJA_TRAB_AFP.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub btnreporte2_Click(sender As Object, e As EventArgs) Handles btnreporte2.Click
        If txt_periodo2.Text = "" Then
            MsgBox("No ah Seleccionado el periodo de generacion")
            txt_periodo.Focus()
            Exit Sub
        End If
        ReDim gsRptArgs(0)
        gsRptArgs(0) = txt_periodo2.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_TEXTO_AFP.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub btnsalir1_Click(sender As Object, e As EventArgs) Handles btnsalir1.Click
        Dispose()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dispose()
    End Sub

    Private Sub txt_periodo2_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_periodo2.KeyDown
        If chkperiodo.Checked = True Then
            If e.KeyValue = Keys.F9 Then
                sBusAlm = "86"
                Dim frm As New FormBUSQUEDA
                frm.ShowDialog()
                If gLinea <> Nothing And gSubLinea <> Nothing Then
                    txt_periodo2.Text = gLinea
                    dtpfec_ini2.Value = gArt
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
                    txt_periodo2.Text = gLinea
                    dtpfec_ini2.Value = gArt
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
End Class