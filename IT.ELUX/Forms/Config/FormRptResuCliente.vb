Imports System.ComponentModel

Public Class FormRptResuCliente
    Private Sub FormRptResuCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If sOp = "1" Then
        Me.Text = "Res. Cantidad Vendedor - Cliente"
        'Else
        '    Me.Text = "Ventas por Vendedor"
        'End If
        cmbaño.SelectedItem = sAño
        cmbmes1.SelectedItem = "Enero"
        cmbmes2.SelectedIndex = Month(Date.Today)
    End Sub

    Private Sub FormRptResuCliente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
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
            txtcliente1.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
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

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click

        ReDim gsRptArgs(8)
        gsRptArgs(0) = txtcliente1.Text
            gsRptArgs(1) = txtcliente2.Text
            gsRptArgs(2) = cmbaño.SelectedItem
            If cmbmes1.SelectedIndex = 1 Then
                gsRptArgs(3) = "01"
            ElseIf cmbmes1.SelectedIndex = 2 Then
                gsRptArgs(3) = "02"
            ElseIf cmbmes1.SelectedIndex = 3 Then
                gsRptArgs(3) = "03"
            ElseIf cmbmes1.SelectedIndex = 4 Then
                gsRptArgs(3) = "04"
            ElseIf cmbmes1.SelectedIndex = 5 Then
                gsRptArgs(3) = "05"
            ElseIf cmbmes1.SelectedIndex = 6 Then
                gsRptArgs(3) = "06"
            ElseIf cmbmes1.SelectedIndex = 7 Then
                gsRptArgs(3) = "07"
            ElseIf cmbmes1.SelectedIndex = 8 Then
                gsRptArgs(3) = "08"
            ElseIf cmbmes1.SelectedIndex = 9 Then
                gsRptArgs(3) = "09"
            ElseIf cmbmes1.SelectedIndex = 10 Then
                gsRptArgs(3) = "10"
            ElseIf cmbmes1.SelectedIndex = 11 Then
                gsRptArgs(3) = "11"
            ElseIf cmbmes1.SelectedIndex = 12 Then
                gsRptArgs(3) = "12"
            End If
            If cmbmes2.SelectedIndex = 1 Then
                gsRptArgs(4) = "01"
            ElseIf cmbmes2.SelectedIndex = 2 Then
                gsRptArgs(4) = "02"
            ElseIf cmbmes2.SelectedIndex = 3 Then
                gsRptArgs(4) = "03"
            ElseIf cmbmes2.SelectedIndex = 4 Then
                gsRptArgs(4) = "04"
            ElseIf cmbmes2.SelectedIndex = 5 Then
                gsRptArgs(4) = "05"
            ElseIf cmbmes2.SelectedIndex = 6 Then
                gsRptArgs(4) = "06"
            ElseIf cmbmes2.SelectedIndex = 7 Then
                gsRptArgs(4) = "07"
            ElseIf cmbmes2.SelectedIndex = 8 Then
                gsRptArgs(4) = "08"
            ElseIf cmbmes2.SelectedIndex = 9 Then
                gsRptArgs(4) = "09"
            ElseIf cmbmes2.SelectedIndex = 10 Then
                gsRptArgs(4) = "10"
            ElseIf cmbmes2.SelectedIndex = 11 Then
                gsRptArgs(4) = "11"
            ElseIf cmbmes2.SelectedIndex = 12 Then
                gsRptArgs(4) = "12"
            End If

        If cmbt_venta1.SelectedIndex = 1 Then
            gsRptArgs(5) = "EXPORTACION"
        ElseIf cmbt_venta1.SelectedIndex = 2 Then
            gsRptArgs(5) = "NACIONAL"
        Else
            gsRptArgs(5) = ""
        End If
        If cmbt_venta2.SelectedIndex = 1 Then
            gsRptArgs(6) = "EXPORTACION"
        ElseIf cmbt_venta2.SelectedIndex = 2 Then
            gsRptArgs(6) = "NACIONAL"
        Else
            gsRptArgs(6) = ""
        End If
        gsRptArgs(7) = txtvend.Text
        gsRptArgs(8) = txtvend1.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_VENTAS_RESU_CLIENTE.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()


    End Sub
End Class