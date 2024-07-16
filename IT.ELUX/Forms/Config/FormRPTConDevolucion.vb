Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormRPTConDevolucion
    Private PROVISIONESBL As New PROVISIONESBL
    Private ARTICULOBL As New ARTICULOBL
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRPTConDevolucion_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub FormRPTConDevolucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbaño.SelectedItem = sAño
        cmbmes1.SelectedItem = "Enero"
        cmbmes2.SelectedIndex = Month(Date.Today)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "235"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente.Text = gLinea
            txtnomcliente.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "106"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtcodart.Text = gLinea
            txtnomart.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub txtcodart_LostFocus(sender As Object, e As EventArgs) Handles txtcodart.LostFocus
        If txtcodart.TextLength > 0 Then
            txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
        Else
            txtcodart.Text = ""
            txtnomart.Text = ""
        End If
    End Sub

    Private Sub txtcliente_LostFocus(sender As Object, e As EventArgs) Handles txtcliente.LostFocus
        If txtcliente.TextLength > 0 Then
            Dim prov As String = PROVISIONESBL.SelectT_Prov(txtcliente.Text)
            If prov.Length > 0 Then
                txtnomcliente.Text = prov
            Else
                txtnomcliente.Text = ""
            End If
        Else
            txtcliente.Text = ""
            txtnomcliente.Text = ""
        End If
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(6)
        gsRptArgs(0) = cmb_serdoc.Text
        gsRptArgs(1) = txtnro.Text
        gsRptArgs(2) = txtcodart.Text
        gsRptArgs(3) = txtcliente.Text
        gsRptArgs(4) = cmbaño.Text
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
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTTMOV_DEVPROV.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class