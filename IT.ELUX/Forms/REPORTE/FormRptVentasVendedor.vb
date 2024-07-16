Imports System.ComponentModel

Public Class FormRptVentasVendedor
    Private Sub FormRptVentasVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Ventas Vendedor"
        cmbaño.SelectedItem = sAño
        cmbmes1.SelectedItem = "Enero"
        cmbmes2.SelectedIndex = Month(Date.Today)
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRptVentasVendedor_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
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
        ReDim gsRptArgs(8)
        gsRptArgs(0) = txtcliente1.Text
        gsRptArgs(1) = txtcliente2.Text
        gsRptArgs(2) = txtvend.Text
        gsRptArgs(3) = txtvend1.Text
        gsRptArgs(4) = txtuni1.Text
        gsRptArgs(5) = txtuni2.Text
        gsRptArgs(6) = cmbaño.SelectedItem
        If cmbmes1.SelectedIndex = 1 Then
            gsRptArgs(7) = "01"
        ElseIf cmbmes1.SelectedIndex = 2 Then
            gsRptArgs(7) = "02"
        ElseIf cmbmes1.SelectedIndex = 3 Then
            gsRptArgs(7) = "03"
        ElseIf cmbmes1.SelectedIndex = 4 Then
            gsRptArgs(7) = "04"
        ElseIf cmbmes1.SelectedIndex = 5 Then
            gsRptArgs(7) = "05"
        ElseIf cmbmes1.SelectedIndex = 6 Then
            gsRptArgs(7) = "06"
        ElseIf cmbmes1.SelectedIndex = 7 Then
            gsRptArgs(7) = "07"
        ElseIf cmbmes1.SelectedIndex = 8 Then
            gsRptArgs(7) = "08"
        ElseIf cmbmes1.SelectedIndex = 9 Then
            gsRptArgs(7) = "09"
        ElseIf cmbmes1.SelectedIndex = 10 Then
            gsRptArgs(7) = "10"
        ElseIf cmbmes1.SelectedIndex = 11 Then
            gsRptArgs(7) = "11"
        ElseIf cmbmes1.SelectedIndex = 12 Then
            gsRptArgs(7) = "12"
        End If
        If cmbmes2.SelectedIndex = 1 Then
            gsRptArgs(8) = "01"
        ElseIf cmbmes2.SelectedIndex = 2 Then
            gsRptArgs(8) = "02"
        ElseIf cmbmes2.SelectedIndex = 3 Then
            gsRptArgs(8) = "03"
        ElseIf cmbmes2.SelectedIndex = 4 Then
            gsRptArgs(8) = "04"
        ElseIf cmbmes2.SelectedIndex = 5 Then
            gsRptArgs(8) = "05"
        ElseIf cmbmes2.SelectedIndex = 6 Then
            gsRptArgs(8) = "06"
        ElseIf cmbmes2.SelectedIndex = 7 Then
            gsRptArgs(8) = "07"
        ElseIf cmbmes2.SelectedIndex = 8 Then
            gsRptArgs(8) = "08"
        ElseIf cmbmes2.SelectedIndex = 9 Then
            gsRptArgs(8) = "09"
        ElseIf cmbmes2.SelectedIndex = 10 Then
            gsRptArgs(8) = "10"
        ElseIf cmbmes2.SelectedIndex = 11 Then
            gsRptArgs(8) = "11"
        ElseIf cmbmes2.SelectedIndex = 12 Then
            gsRptArgs(8) = "12"
        End If
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_VENTAS_ANUAL.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()


    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        sBusAlm = "41"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtvend.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        sBusAlm = "41"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtvend1.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub
End Class