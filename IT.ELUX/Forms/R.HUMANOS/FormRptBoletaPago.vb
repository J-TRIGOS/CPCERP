Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRptBoletaPago
    Private ELPERIODOBL As New ELPERIODOBL
    Private PERBL As New PERBL
    Private Sub FormBoletaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Boleta de Pago"
        Me.dtpfec_ini.Enabled = False
        Me.dtpfec_fin.Enabled = False
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
        'If cmbt_pago.SelectedIndex <> 0 Then
        ReDim gsRptArgs(6)
        gsRptArgs(0) = txt_periodo.Text
        If cmbt_pago.SelectedIndex = 1 Then
            gsRptArgs(1) = "MEN"
        ElseIf cmbt_pago.SelectedIndex = 2 Then
            gsRptArgs(1) = "GRA"
        Else
            gsRptArgs(1) = ""
        End If
        gsRptArgs(2) = txtper1.Text
        gsRptArgs(3) = txtper2.Text
        If Cmbt_per1.SelectedIndex = 1 Then
            gsRptArgs(4) = "20"
        ElseIf Cmbt_per1.SelectedIndex = 2 Then
            gsRptArgs(4) = "21"
        Else
            gsRptArgs(4) = ""
        End If
        If Cmbt_per2.SelectedIndex = 1 Then
            gsRptArgs(5) = "20"
        ElseIf Cmbt_per2.SelectedIndex = 2 Then
            gsRptArgs(5) = "21"
        Else
            gsRptArgs(5) = ""
        End If
        gsRptArgs(6) = txt_periodo.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_BOLETA_PAGOX.rpt"
        ' gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_BOLETA_PAGO_PRUEBA.rpt"

        gsRptPath = gsPathRpt
        FormReportes.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sBusAlm = "37"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtper1.Text = gLinea
            txtnomper1.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "37"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtper2.Text = gLinea
            txtnomper2.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub
    Private Sub Cmbt_per_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbt_per1.SelectedIndexChanged

    End Sub
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub
    Private Sub txtper1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtper1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtper1.Text = gLinea
                txtnomper1.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub
    Private Sub txtper1_LostFocus(sender As Object, e As EventArgs) Handles txtper1.LostFocus
        If txtper1.Text = "" Then
            txtnomper1.Text = ""
            Exit Sub
        End If
        txtnomper1.Text = PERBL.SelectApeNom(txtper1.Text)
        If txtper1.Text Is Nothing Then
            MsgBox("Personal no existe", MsgBoxStyle.Exclamation)
            txtper1.Text = ""
        End If
    End Sub
    Private Sub txtper2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtper2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtper2.Text = gLinea
                txtnomper2.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub
    Private Sub txtper2_LostFocus(sender As Object, e As EventArgs) Handles txtper2.LostFocus
        If txtper2.Text = "" Then
            txtnomper2.Text = ""
            Exit Sub
        End If
        txtnomper2.Text = PERBL.SelectApeNom(txtper2.Text)
        If txtper2.Text Is Nothing Then
            MsgBox("Personal no existe", MsgBoxStyle.Exclamation)
            txtper2.Text = ""
        End If
    End Sub

    Private Sub FormRptBoletaPago_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class