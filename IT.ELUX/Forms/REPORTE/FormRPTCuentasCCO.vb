Imports System.ComponentModel

Public Class FormRPTCuentasCCO
    Private Sub FormRPTCuentasCCO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbaño.SelectedItem = sAño
        cmbaño2.SelectedItem = sAño
        cmbmes1.SelectedItem = "Enero"
        cmbmes2.SelectedIndex = Month(Date.Today)
        cmbope1.SelectedIndex = 0
        cmbope2.SelectedIndex = 1
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRPTCuentasCCO_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(7)
        gsRptArgs(0) = cmbaño.SelectedItem
        gsRptArgs(1) = cmbaño2.SelectedItem
        If cmbmes1.SelectedIndex = 1 Then
            gsRptArgs(2) = "01"
        ElseIf cmbmes1.SelectedIndex = 2 Then
            gsRptArgs(2) = "02"
        ElseIf cmbmes1.SelectedIndex = 3 Then
            gsRptArgs(2) = "03"
        ElseIf cmbmes1.SelectedIndex = 4 Then
            gsRptArgs(2) = "04"
        ElseIf cmbmes1.SelectedIndex = 5 Then
            gsRptArgs(2) = "05"
        ElseIf cmbmes1.SelectedIndex = 6 Then
            gsRptArgs(2) = "06"
        ElseIf cmbmes1.SelectedIndex = 7 Then
            gsRptArgs(2) = "07"
        ElseIf cmbmes1.SelectedIndex = 8 Then
            gsRptArgs(2) = "08"
        ElseIf cmbmes1.SelectedIndex = 9 Then
            gsRptArgs(2) = "09"
        ElseIf cmbmes1.SelectedIndex = 10 Then
            gsRptArgs(2) = "10"
        ElseIf cmbmes1.SelectedIndex = 11 Then
            gsRptArgs(2) = "11"
        ElseIf cmbmes1.SelectedIndex = 12 Then
            gsRptArgs(2) = "12"
        End If
        If cmbmes2.SelectedIndex = 1 Then
            gsRptArgs(3) = "01"
        ElseIf cmbmes2.SelectedIndex = 2 Then
            gsRptArgs(3) = "02"
        ElseIf cmbmes2.SelectedIndex = 3 Then
            gsRptArgs(3) = "03"
        ElseIf cmbmes2.SelectedIndex = 4 Then
            gsRptArgs(3) = "04"
        ElseIf cmbmes2.SelectedIndex = 5 Then
            gsRptArgs(3) = "05"
        ElseIf cmbmes2.SelectedIndex = 6 Then
            gsRptArgs(3) = "06"
        ElseIf cmbmes2.SelectedIndex = 7 Then
            gsRptArgs(3) = "07"
        ElseIf cmbmes2.SelectedIndex = 8 Then
            gsRptArgs(3) = "08"
        ElseIf cmbmes2.SelectedIndex = 9 Then
            gsRptArgs(3) = "09"
        ElseIf cmbmes2.SelectedIndex = 10 Then
            gsRptArgs(3) = "10"
        ElseIf cmbmes2.SelectedIndex = 11 Then
            gsRptArgs(3) = "11"
        ElseIf cmbmes2.SelectedIndex = 12 Then
            gsRptArgs(3) = "12"
        End If
        gsRptArgs(4) = txtcta1.Text
        gsRptArgs(5) = txtcta2.Text
        gsRptArgs(6) = cmbope1.Text
        gsRptArgs(7) = cmbope2.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RESUMEN_GAS_VEN.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class