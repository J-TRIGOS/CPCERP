Imports System.ComponentModel

Public Class FormRPTAnaliticoLT
    Private Sub FormRPTAnaliticoLT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Cajas y Bancos / Analitico de Letras"
        cmbaño.SelectedItem = sAño
        cmbaño1.SelectedItem = sAño
        cmbaño2.SelectedItem = sAño
        cmbmes1.SelectedItem = "Enero"
        cmbmes2.SelectedIndex = Month(Date.Today)
        cmbmes3.SelectedItem = "Enero"
        cmbmes4.SelectedIndex = Month(Date.Today)
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(7)
        gsRptArgs(0) = cmbaño.Text
        gsRptArgs(1) = cmbaño1.Text
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
        gsRptArgs(4) = txtpv_w_cta_cod.Text
        gsRptArgs(5) = txtpv_w_cta_cod2.Text
        gsRptArgs(6) = txtt_ope1.Text
        gsRptArgs(7) = txtt_ope2.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTANALITICO_LT.rpt"
        gsRptPath = gsPathRpt
        FormReportes.Show()
    End Sub

    Private Sub FormRPTAnaliticoLT_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReDim gsRptArgs(2)
        gsRptArgs(0) = cmbaño2.Text
        If cmbmes3.SelectedIndex = 1 Then
            gsRptArgs(1) = "01"
        ElseIf cmbmes3.SelectedIndex = 2 Then
            gsRptArgs(1) = "02"
        ElseIf cmbmes3.SelectedIndex = 3 Then
            gsRptArgs(1) = "03"
        ElseIf cmbmes3.SelectedIndex = 4 Then
            gsRptArgs(1) = "04"
        ElseIf cmbmes3.SelectedIndex = 5 Then
            gsRptArgs(1) = "05"
        ElseIf cmbmes3.SelectedIndex = 6 Then
            gsRptArgs(1) = "06"
        ElseIf cmbmes3.SelectedIndex = 7 Then
            gsRptArgs(1) = "07"
        ElseIf cmbmes3.SelectedIndex = 8 Then
            gsRptArgs(1) = "08"
        ElseIf cmbmes3.SelectedIndex = 9 Then
            gsRptArgs(1) = "09"
        ElseIf cmbmes3.SelectedIndex = 10 Then
            gsRptArgs(1) = "10"
        ElseIf cmbmes3.SelectedIndex = 11 Then
            gsRptArgs(1) = "11"
        ElseIf cmbmes3.SelectedIndex = 12 Then
            gsRptArgs(1) = "12"
        End If
        If cmbmes4.SelectedIndex = 1 Then
            gsRptArgs(2) = "01"
        ElseIf cmbmes4.SelectedIndex = 2 Then
            gsRptArgs(2) = "02"
        ElseIf cmbmes4.SelectedIndex = 3 Then
            gsRptArgs(2) = "03"
        ElseIf cmbmes4.SelectedIndex = 4 Then
            gsRptArgs(2) = "04"
        ElseIf cmbmes4.SelectedIndex = 5 Then
            gsRptArgs(2) = "05"
        ElseIf cmbmes4.SelectedIndex = 6 Then
            gsRptArgs(2) = "06"
        ElseIf cmbmes4.SelectedIndex = 7 Then
            gsRptArgs(2) = "07"
        ElseIf cmbmes4.SelectedIndex = 8 Then
            gsRptArgs(2) = "08"
        ElseIf cmbmes4.SelectedIndex = 9 Then
            gsRptArgs(2) = "09"
        ElseIf cmbmes4.SelectedIndex = 10 Then
            gsRptArgs(2) = "10"
        ElseIf cmbmes4.SelectedIndex = 11 Then
            gsRptArgs(2) = "11"
        ElseIf cmbmes4.SelectedIndex = 12 Then
            gsRptArgs(2) = "12"
        End If
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_LIB_CAJA_BANCOS.rpt"
        gsRptPath = gsPathRpt
        FormReportes.Show()
    End Sub
End Class