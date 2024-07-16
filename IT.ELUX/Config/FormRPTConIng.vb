Imports System.ComponentModel

Public Class FormRPTConIng
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRPTConIng_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Control Ingresos"
        Dim dtFecha As Date = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        'Dim dtFecha3 As Date = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        dtpfec1.Value = dtFecha
        dtpfec3.Value = dtFecha
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(3)
        gsRptArgs(0) = Format(dtpfec1.Value, "yyyy/MM/dd")
        gsRptArgs(1) = Format(dtpfec2.Value, "yyyy/MM/dd")
        If cmbtdoc.SelectedIndex = -1 Or cmbtdoc.SelectedIndex = 0 Then
            gsRptArgs(2) = ""
        ElseIf cmbtdoc.SelectedIndex = 1 Then
            gsRptArgs(2) = "01"
        ElseIf cmbtdoc.SelectedIndex = 2 Then
            gsRptArgs(2) = "09"
        ElseIf cmbtdoc.SelectedIndex = 3 Then
            gsRptArgs(2) = "SALM"
        End If
        gsRptArgs(3) = txtuserrep.Text

        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_CON_ING_DOC.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub FormRPTConIng_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "33"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "34"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ReDim gsRptArgs(3)
        gsRptArgs(0) = Format(dtpfec3.Value, "yyyy/MM/dd")
        gsRptArgs(1) = Format(dtpfec4.Value, "yyyy/MM/dd")
        If cmbtdoc.SelectedIndex = -1 Or cmbtdoc2.SelectedIndex = 0 Then
            gsRptArgs(2) = ""
        ElseIf cmbtdoc2.SelectedIndex = 1 Then
            gsRptArgs(2) = "01"
        ElseIf cmbtdoc.SelectedIndex = 2 Then
            gsRptArgs(2) = "09"
        ElseIf cmbtdoc2.SelectedIndex = 3 Then
            gsRptArgs(2) = "SALM"
        End If
        gsRptArgs(3) = txtuserrep2.Text

        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_CON_ING_DOC_CON.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class