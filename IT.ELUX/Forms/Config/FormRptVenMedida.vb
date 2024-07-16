Imports System.ComponentModel

Public Class FormRptVenMedida
    Private Sub FormRptVenMedida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Resumen Cliente Medida"
        cmbaño.SelectedItem = sAño
        cmbmes1.SelectedItem = "Enero"
        cmbmes2.SelectedIndex = Month(Date.Today)
    End Sub

    Private Sub FormRptVenMedida_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "39"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente1.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sBusAlm = "39"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente2.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "42"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtuni1.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "42"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtuni1.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(9)
        gsRptArgs(0) = txtcliente1.Text
        gsRptArgs(1) = txtcliente2.Text
        gsRptArgs(2) = txtuni1.Text
        gsRptArgs(3) = txtuni2.Text
        gsRptArgs(4) = cmbaño.SelectedItem
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
        gsRptArgs(7) = cmbtipo.Text
        gsRptArgs(8) = cmbtipo2.Text
        If cmbmoneda.SelectedIndex = 1 Then
            gsRptArgs(9) = "00"
        Else
            gsRptArgs(9) = "01"
        End If
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_VENTAS_RESU_MEDIDA.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()

    End Sub
End Class