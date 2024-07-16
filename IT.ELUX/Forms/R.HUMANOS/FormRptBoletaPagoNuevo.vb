Imports IT.ELUX.BL
Imports System.ComponentModel
Imports System.IO

Public Class FormRptBoletaPagoNuevo
    Private ELPERIODOBL As New ELPERIODOBL
    Private PERBL As New PERBL

    Private Sub FormRptBoletaPagoNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Boleta de Pago PLANILLA"
        Me.dtpfec_ini.Enabled = False
        Cmbt_per1.SelectedIndex = 0
        If gsUser = "JFLORES" Then
            Cmbt_per1.SelectedIndex = 1
            Cmbt_per1.Enabled = False
        End If
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Cmbt_per1.SelectedIndex = 0 Then
            sBusAlm = "3721"
        Else
            sBusAlm = "3720"
        End If
        'sBusAlm = "37"
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

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(3)

        gsRptArgs(0) = txt_periodo.Text
        If Cmbt_per1.SelectedIndex = 0 Then
            gsRptArgs(1) = "21"
        Else
            gsRptArgs(1) = "20"
        End If

        If txtper1.Text = "" Then
            gsRptArgs(2) = "ALL"
        Else
            gsRptArgs(2) = txtper1.Text
        End If

        If Cmbt_pla.SelectedIndex = 0 Then
            gsRptArgs(3) = "MEN"
        Else
            gsRptArgs(3) = "GRA"
        End If

        Dim dtPlanilla As New DataTable

        If gsRptArgs(3) = "MEN" Then
            dtPlanilla = PERBL.ActualizarBoletas(txt_periodo.Text)
        Else
            dtPlanilla = PERBL.ActualizarBoletasGra(txt_periodo.Text)
        End If

        Dim resultado As String = PERBL.ActualizarSPBoleta(txt_periodo.Text)


        If Cmbt_pla.SelectedIndex = 2 Then
            gsRptArgs(0) = cmbAnho.SelectedItem
            gsRptArgs(3) = 0
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_BOLETA_UTILIDADES.rpt"
            gsRptPath = gsPathRpt
            FormReportes.Show()
        Else
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_BOLETA_PAGOX.rpt"
            gsRptPath = gsPathRpt
            FormReportes.Show()
        End If

    End Sub

    Private Sub FormRptBoletaPagoNuevo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Cmbt_pla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbt_pla.SelectedIndexChanged
        If Cmbt_pla.SelectedIndex = 2 Then
            cmbAnho.Visible = True
        Else
            cmbAnho.Visible = False
        End If
    End Sub
End Class