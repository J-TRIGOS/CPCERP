Imports System.ComponentModel

Public Class FormRptDetRecep
    Private Sub FormRptDetRecep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Reporte Detalle Recepcion"
        Dim dtFecha As Date = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        'Dim dtFecha3 As Date = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        dtpfecha1.Value = dtFecha
        Me.cmbser.SelectedIndex = 0
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sBusAlm = "53"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtproveedor.Text = gLinea
            txtnomprov.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(7)
        gsRptArgs(0) = cmbser.Text
        gsRptArgs(1) = txtnro_orden.Text
        gsRptArgs(2) = txtfactura.Text
        gsRptArgs(3) = ""
        gsRptArgs(4) = Format(dtpfecha1.Value, "yyyy/MM/dd")
        gsRptArgs(5) = Format(dtpfecha2.Value, "yyyy/MM/dd")
        gsRptArgs(6) = txtproveedor.Text
        If cmbest.SelectedIndex = 1 Then
            gsRptArgs(7) = "3"
        ElseIf cmbest.SelectedIndex = 2 Then
            gsRptArgs(7) = "1"
        Else
            gsRptArgs(7) = ""
        End If
        'gsRptArgs(7) = cmbest.SelectedIndex
        If gsCode = "" Then
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ELTBDETRECEPCOMP_SELROW.rpt"
        Else
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ELTBDETRECEPCOMP_SELROW1.rpt"
        End If
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub FormRptDetRecep_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub


End Class