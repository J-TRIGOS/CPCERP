Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRptRegistroCobranza
    Private CTCTBL As New CTCTBL
    Private Sub FormRptRegistroCobranza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbaño.SelectedItem = sAño
        cmbaño2.SelectedItem = sAño
        cmbmes1.SelectedItem = "Enero"
        cmbmes2.SelectedIndex = Month(Date.Today)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dispose()
    End Sub

    Private Sub FormRptRegistroCobranza_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If cmbmes1.SelectedIndex <= 0 Then
            MsgBox("Debe Seleccionar un mes")
            Exit Sub
        End If
        If cmbmes2.SelectedIndex <= 0 Then
            MsgBox("Debe Seleccionar un mes")
            Exit Sub
        End If
        ReDim gsRptArgs(6)
        gsRptArgs(0) = ""
        gsRptArgs(1) = txtcliente1.Text
        gsRptArgs(2) = txtcliente2.Text
        gsRptArgs(3) = cmbaño.SelectedItem
        gsRptArgs(4) = cmbaño2.SelectedItem
        If cmbmes1.SelectedIndex = 1 Then
            gsRptArgs(5) = "01"
        ElseIf cmbmes1.SelectedIndex = 2 Then
            gsRptArgs(5) = "02"
        ElseIf cmbmes1.SelectedIndex = 3 Then
            gsRptArgs(5) = "03"
        ElseIf cmbmes1.SelectedIndex = 4 Then
            gsRptArgs(5) = "04"
        ElseIf cmbmes1.SelectedIndex = 5 Then
            gsRptArgs(5) = "05"
        ElseIf cmbmes1.SelectedIndex = 6 Then
            gsRptArgs(5) = "06"
        ElseIf cmbmes1.SelectedIndex = 7 Then
            gsRptArgs(5) = "07"
        ElseIf cmbmes1.SelectedIndex = 8 Then
            gsRptArgs(5) = "08"
        ElseIf cmbmes1.SelectedIndex = 9 Then
            gsRptArgs(5) = "09"
        ElseIf cmbmes1.SelectedIndex = 10 Then
            gsRptArgs(5) = "10"
        ElseIf cmbmes1.SelectedIndex = 11 Then
            gsRptArgs(5) = "11"
        ElseIf cmbmes1.SelectedIndex = 12 Then
            gsRptArgs(5) = "12"
        End If
        If cmbmes2.SelectedIndex = 1 Then
            gsRptArgs(6) = "01"
        ElseIf cmbmes2.SelectedIndex = 2 Then
            gsRptArgs(6) = "02"
        ElseIf cmbmes2.SelectedIndex = 3 Then
            gsRptArgs(6) = "03"
        ElseIf cmbmes2.SelectedIndex = 4 Then
            gsRptArgs(6) = "04"
        ElseIf cmbmes2.SelectedIndex = 5 Then
            gsRptArgs(6) = "05"
        ElseIf cmbmes2.SelectedIndex = 6 Then
            gsRptArgs(6) = "06"
        ElseIf cmbmes2.SelectedIndex = 7 Then
            gsRptArgs(6) = "07"
        ElseIf cmbmes2.SelectedIndex = 8 Then
            gsRptArgs(6) = "08"
        ElseIf cmbmes2.SelectedIndex = 9 Then
            gsRptArgs(6) = "09"
        ElseIf cmbmes2.SelectedIndex = 10 Then
            gsRptArgs(6) = "10"
        ElseIf cmbmes2.SelectedIndex = 11 Then
            gsRptArgs(6) = "11"
        ElseIf cmbmes2.SelectedIndex = 12 Then
            gsRptArgs(6) = "12"
        End If

        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_REGISTRO_COMPRASAÑO.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "53"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente1.Text = gLinea
            txtnomprov.Text = gSubLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sBusAlm = "53"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente2.Text = gLinea
            txtnomprov2.Text = gSubLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub txtcliente1_LostFocus(sender As Object, e As EventArgs) Handles txtcliente1.LostFocus
        txtnomprov.Text = CTCTBL.SelectCTCT(txtcliente1.Text)

    End Sub

    Private Sub txtcliente2_LostFocus(sender As Object, e As EventArgs) Handles txtcliente2.LostFocus
        txtnomprov2.Text = CTCTBL.SelectCTCT(txtcliente2.Text)
    End Sub
End Class