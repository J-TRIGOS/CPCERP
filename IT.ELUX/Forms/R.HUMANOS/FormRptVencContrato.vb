Imports System.ComponentModel

Public Class FormRptVencContrato
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRptVencContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Vencimiento Contratos"
        cmbaño.Text = sAño
        cmbmes1.SelectedIndex = Month(Date.Today)
        If gsUser = "JMONTES" Or gsUser = "JFLORES" Then
            Cmbt_per1.Text = "OBREROS"
            Cmbt_per2.Text = "OBREROS"
            Cmbt_per1.Enabled = False
            Cmbt_per2.Enabled = False
        End If
    End Sub

    Private Sub FormRptVencContrato_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        If chknew.Checked Then
            ReDim gsRptArgs(3)
            'gsRptArgs(0) = cmbaño.SelectedItem
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

            If cmbmes1.SelectedIndex = 1 Then
                gsRptArgs(2) = cmbaño.Text & "01"
            ElseIf cmbmes1.SelectedIndex = 2 Then
                gsRptArgs(2) = cmbaño.Text & "02"
            ElseIf cmbmes1.SelectedIndex = 3 Then
                gsRptArgs(2) = cmbaño.Text & "03"
            ElseIf cmbmes1.SelectedIndex = 4 Then
                gsRptArgs(2) = cmbaño.Text & "04"
            ElseIf cmbmes1.SelectedIndex = 5 Then
                gsRptArgs(2) = cmbaño.Text & "05"
            ElseIf cmbmes1.SelectedIndex = 6 Then
                gsRptArgs(2) = cmbaño.Text & "06"
            ElseIf cmbmes1.SelectedIndex = 7 Then
                gsRptArgs(2) = cmbaño.Text & "07"
            ElseIf cmbmes1.SelectedIndex = 8 Then
                gsRptArgs(2) = cmbaño.Text & "08"
            ElseIf cmbmes1.SelectedIndex = 9 Then
                gsRptArgs(2) = cmbaño.Text & "09"
            ElseIf cmbmes1.SelectedIndex = 10 Then
                gsRptArgs(2) = cmbaño.Text & "10"
            ElseIf cmbmes1.SelectedIndex = 11 Then
                gsRptArgs(2) = cmbaño.Text & "11"
            ElseIf cmbmes1.SelectedIndex = 12 Then
                gsRptArgs(2) = cmbaño.Text & "12"
            End If
            gsRptArgs(3) = "1"
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_VCMTO_CONTRATO.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        Else
            ReDim gsRptArgs(3)
            'gsRptArgs(0) = cmbaño.SelectedItem
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

            If cmbmes1.SelectedIndex = 1 Then
                gsRptArgs(2) = cmbaño.Text & "01"
            ElseIf cmbmes1.SelectedIndex = 2 Then
                gsRptArgs(2) = cmbaño.Text & "02"
            ElseIf cmbmes1.SelectedIndex = 3 Then
                gsRptArgs(2) = cmbaño.Text & "03"
            ElseIf cmbmes1.SelectedIndex = 4 Then
                gsRptArgs(2) = cmbaño.Text & "04"
            ElseIf cmbmes1.SelectedIndex = 5 Then
                gsRptArgs(2) = cmbaño.Text & "05"
            ElseIf cmbmes1.SelectedIndex = 6 Then
                gsRptArgs(2) = cmbaño.Text & "06"
            ElseIf cmbmes1.SelectedIndex = 7 Then
                gsRptArgs(2) = cmbaño.Text & "07"
            ElseIf cmbmes1.SelectedIndex = 8 Then
                gsRptArgs(2) = cmbaño.Text & "08"
            ElseIf cmbmes1.SelectedIndex = 9 Then
                gsRptArgs(2) = cmbaño.Text & "09"
            ElseIf cmbmes1.SelectedIndex = 10 Then
                gsRptArgs(2) = cmbaño.Text & "10"
            ElseIf cmbmes1.SelectedIndex = 11 Then
                gsRptArgs(2) = cmbaño.Text & "11"
            ElseIf cmbmes1.SelectedIndex = 12 Then
                gsRptArgs(2) = cmbaño.Text & "12"
            End If
            gsRptArgs(3) = ""
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_VCMTO_CONTRATO.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If

    End Sub
End Class