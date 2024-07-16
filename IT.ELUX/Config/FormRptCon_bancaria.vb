Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRptCon_bancaria
    Private Sub FormRptCon_bancaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbCodBanco.SelectedIndex = 0
        cmbCtaCont.SelectedIndex = 0
    End Sub

    Private Sub FormRptCon_bancaria_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        If txtAño.Text = "" Then
            MsgBox("Ingresar el AÑO")
            txtAño.Focus()
            Exit Sub
        End If
        If txtMesIni.Text = "" Then
            MsgBox("Ingresar Mes de inicio")
            txtAño.Focus()
            Exit Sub
        End If
        If txtMesFin.Text = "" Then
            MsgBox("Ingresar Mes de fin")
            txtMesFin.Focus()
            Exit Sub
        End If
        ReDim gsRptArgs(6)
        gsRptArgs(0) = txtAño.Text
        gsRptArgs(1) = txtMesIni.Text
        gsRptArgs(2) = txtMesFin.Text
        If cmbCodBanco.SelectedIndex = 0 Then
            gsRptArgs(3) = 1
        ElseIf cmbCodBanco.SelectedIndex = 1 Then
            gsRptArgs(3) = 2
        End If
        If cmbCtaCont.SelectedIndex = 0 Then
            gsRptArgs(4) = 1041101
        ElseIf cmbCtaCont.SelectedIndex = 1 Then
            gsRptArgs(4) = 1041102
        ElseIf cmbCtaCont.SelectedIndex = 2 Then
            gsRptArgs(4) = 1042101
        End If
        If cmbEst1.SelectedIndex = 0 Then
            gsRptArgs(5) = "C"
        ElseIf cmbEst1.SelectedIndex = 1 Then
            gsRptArgs(5) = "P"
        Else
            gsRptArgs(5) = ""
        End If
        If cmbEst2.SelectedIndex = 0 Then
            gsRptArgs(6) = "C"
        ElseIf cmbEst2.SelectedIndex = 1 Then
            gsRptArgs(6) = "P"
        Else
            gsRptArgs(6) = ""
        End If
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_CONCILIA_BANCO.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class