Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRptSintomaCovidRH
    Private PERBL As New PERBL
    Private bprimero As Boolean
    Private Sub FormRptSintomaCovidRH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Resumen Cliente Medida"
        cmbaño.SelectedItem = sAño
        cmbmes1.SelectedItem = "Enero"
        cmbmes2.SelectedIndex = Month(Date.Today)
    End Sub

    Private Sub FormRptSintomaCovidRH_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
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

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(6)
        gsRptArgs(0) = RTrim("SINC")
        gsRptArgs(1) = RTrim(cmbaño.Text)
        gsRptArgs(2) = RTrim(txtnro.Text)
        gsRptArgs(3) = txtper1.Text
        gsRptArgs(4) = RTrim(cmbaño.Text)
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
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_ELTBSINTOMAS_COVID.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
        Exit Sub
    End Sub
End Class