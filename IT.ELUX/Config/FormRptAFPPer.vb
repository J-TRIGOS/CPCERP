Imports System.ComponentModel

Public Class FormRptAFPPer
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRptAFPPer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbaño.SelectedItem = sAño
        cmbmes1.SelectedIndex = Month(Date.Today)
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        If chkact.Checked Then
            ReDim gsRptArgs(2)
            gsRptArgs(0) = "1"
            gsRptArgs(1) = cmbaño.SelectedItem
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
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_CONSULTAAFP.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        Else
            ReDim gsRptArgs(2)
            gsRptArgs(0) = ""
            gsRptArgs(1) = cmbaño.SelectedItem
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
            'gsRptArgs = {}
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_CONSULTAAFP.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If

    End Sub

    Private Sub FormRptAFPPer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class