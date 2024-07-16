Imports System.ComponentModel

Public Class FormRPTPRESTAMOPER
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRPTPRESTAMOPER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Prestamo Personal"
        cmbaño.Text = sAño
        cmbaño2.Text = sAño
        cmbmes1.SelectedIndex = 1
        cmbmes2.SelectedIndex = Month(Date.Today)
        If gsUser = "JMONTES" Or gsUser = "JFLORES" Then
            Cmbt_per1.Text = "OBREROS"
            Cmbt_per1.Enabled = False
        End If
    End Sub

    Private Sub FormRPTPRESTAMOPER_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(6)
        'gsRptArgs(0) = cmbaño.SelectedItem
        gsRptArgs(0) = cmbaño.Text
        gsRptArgs(1) = txtper1.Text
        gsRptArgs(2) = txtper2.Text
        gsRptArgs(3) = cmbaño2.Text
        If Cmbt_per1.SelectedIndex = 1 Then
            gsRptArgs(4) = "20"
        ElseIf Cmbt_per1.SelectedIndex = 2 Then
            gsRptArgs(4) = "21"
        Else
            gsRptArgs(4) = ""
        End If
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
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_PRESTAMO_PER.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
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
End Class