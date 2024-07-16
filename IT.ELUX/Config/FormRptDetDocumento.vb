Imports System.ComponentModel

Public Class FormRptDetDocumento
    Private Sub FormRptDetDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Registro de Detalle"
        cmbaño.SelectedItem = sAño
        cmbmes1.SelectedIndex = Month(Date.Today)
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRptDetDocumento_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        If cmbope1.SelectedIndex = -1 Then
            MsgBox("Seleccione una opcion de operacion")
            Exit Sub
        End If
        ReDim gsRptArgs(6)
        gsRptArgs(0) = txttdoc.Text
        gsRptArgs(1) = txtsdoc.Text
        gsRptArgs(2) = txtndoc.Text
        If chkfecha.Checked = True Then
            If cmbmes1.SelectedIndex = 1 Then
                gsRptArgs(3) = cmbaño.Text & "01"
            ElseIf cmbmes1.SelectedIndex = 2 Then
                gsRptArgs(3) = cmbaño.Text & "02"
            ElseIf cmbmes1.SelectedIndex = 3 Then
                gsRptArgs(3) = cmbaño.Text & "03"
            ElseIf cmbmes1.SelectedIndex = 4 Then
                gsRptArgs(3) = cmbaño.Text & "04"
            ElseIf cmbmes1.SelectedIndex = 5 Then
                gsRptArgs(3) = cmbaño.Text & "05"
            ElseIf cmbmes1.SelectedIndex = 6 Then
                gsRptArgs(3) = cmbaño.Text & "06"
            ElseIf cmbmes1.SelectedIndex = 7 Then
                gsRptArgs(3) = cmbaño.Text & "07"
            ElseIf cmbmes1.SelectedIndex = 8 Then
                gsRptArgs(3) = cmbaño.Text & "08"
            ElseIf cmbmes1.SelectedIndex = 9 Then
                gsRptArgs(3) = cmbaño.Text & "09"
            ElseIf cmbmes1.SelectedIndex = 10 Then
                gsRptArgs(3) = cmbaño.Text & "10"
            ElseIf cmbmes1.SelectedIndex = 11 Then
                gsRptArgs(3) = cmbaño.Text & "11"
            ElseIf cmbmes1.SelectedIndex = 12 Then
                gsRptArgs(3) = cmbaño.Text & "12"
            End If
        Else
            gsRptArgs(3) = ""
        End If

        gsRptArgs(4) = txtregnro.Text
        gsRptArgs(5) = txtcliente1.Text
        gsRptArgs(6) = cmbope1.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTDETDOC_ASIENTO.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub chkfecha_CheckedChanged(sender As Object, e As EventArgs) Handles chkfecha.CheckedChanged
        If chkfecha.Checked = True Then
            cmbaño.Enabled = True
            cmbmes1.Enabled = True
        Else
            cmbaño.SelectedIndex = -1
            cmbmes1.SelectedIndex = -1
            cmbaño.Enabled = False
            cmbmes1.Enabled = False

        End If
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
End Class