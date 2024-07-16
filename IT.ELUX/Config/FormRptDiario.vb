Imports System.ComponentModel

Public Class FormRptDiario
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRptDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbaño.SelectedItem = sAño
        cmbaño2.SelectedItem = sAño
        cmbmes1.SelectedIndex = Month(Date.Today) - 1
        cmbmes2.SelectedIndex = Month(Date.Today) - 1
    End Sub

    Private Sub FormRptDiario_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(3)
        gsRptArgs(0) = cmbaño.Text
        If cmbmes1.SelectedIndex = 0 Then
            gsRptArgs(1) = "01"
        ElseIf cmbmes1.SelectedIndex = 1 Then
            gsRptArgs(1) = "02"
        ElseIf cmbmes1.SelectedIndex = 2 Then
            gsRptArgs(1) = "03"
        ElseIf cmbmes1.SelectedIndex = 3 Then
            gsRptArgs(1) = "04"
        ElseIf cmbmes1.SelectedIndex = 4 Then
            gsRptArgs(1) = "05"
        ElseIf cmbmes1.SelectedIndex = 5 Then
            gsRptArgs(1) = "06"
        ElseIf cmbmes1.SelectedIndex = 6 Then
            gsRptArgs(1) = "07"
        ElseIf cmbmes1.SelectedIndex = 7 Then
            gsRptArgs(1) = "08"
        ElseIf cmbmes1.SelectedIndex = 8 Then
            gsRptArgs(1) = "09"
        ElseIf cmbmes1.SelectedIndex = 9 Then
            gsRptArgs(1) = "10"
        ElseIf cmbmes1.SelectedIndex = 10 Then
            gsRptArgs(1) = "11"
        ElseIf cmbmes1.SelectedIndex = 11 Then
            gsRptArgs(1) = "12"
        End If
        gsRptArgs(2) = cmbaño2.Text
        If cmbmes2.SelectedIndex = 0 Then
            gsRptArgs(3) = "01"
        ElseIf cmbmes2.SelectedIndex = 1 Then
            gsRptArgs(3) = "02"
        ElseIf cmbmes2.SelectedIndex = 2 Then
            gsRptArgs(3) = "03"
        ElseIf cmbmes2.SelectedIndex = 3 Then
            gsRptArgs(3) = "04"
        ElseIf cmbmes2.SelectedIndex = 4 Then
            gsRptArgs(3) = "05"
        ElseIf cmbmes2.SelectedIndex = 5 Then
            gsRptArgs(3) = "06"
        ElseIf cmbmes2.SelectedIndex = 6 Then
            gsRptArgs(3) = "07"
        ElseIf cmbmes2.SelectedIndex = 7 Then
            gsRptArgs(3) = "08"
        ElseIf cmbmes2.SelectedIndex = 8 Then
            gsRptArgs(3) = "09"
        ElseIf cmbmes2.SelectedIndex = 9 Then
            gsRptArgs(3) = "10"
        ElseIf cmbmes2.SelectedIndex = 10 Then
            gsRptArgs(3) = "11"
        ElseIf cmbmes2.SelectedIndex = 11 Then
            gsRptArgs(3) = "12"
        End If
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_DIARIO_MOVCT.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class