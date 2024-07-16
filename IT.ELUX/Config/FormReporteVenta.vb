Imports System.ComponentModel

Public Class FormReporteVenta
    Private Sub bloquear_venta(ByVal est As Boolean)
        txtnro1.Enabled = est
        txtnro2.Enabled = est
        txtoc1.Enabled = est
        txtoc2.Enabled = est
        'txtcliente1.Enabled = est
        'txtcliente2.Enabled = est
        cboest.Enabled = est
        cboest2.Enabled = est
        dtpfec1.Enabled = est
        dtpfec2.Enabled = est
        txtarticulo1.Enabled = est
        txtarticulo2.Enabled = est
    End Sub
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Dispose()
    End Sub

    Private Sub FormReporteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If gnOpcion3 = "0" Then
            Me.Text = "Compras Cliente"
            Dim dtFecha As Date = DateSerial(Year(Date.Today), 1, 1)
            dtpfec1.Value = dtFecha
        ElseIf gnOpcion3 = "1" Then
            Me.Text = "Reporte Stock Envases"
            bloquear_venta(False)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "13"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sBusAlm = "14"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "11"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtarticulo1.Text = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "12"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtarticulo2.Text = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click

        If gnOpcion3 = "0" Then
            Dim est As String
            Dim est1 As String
            ReDim gsRptArgs(17)
            gsRptArgs(0) = Format(dtpfec1.Value, "yyyy/MM/dd")
            gsRptArgs(1) = Format(dtpfec2.Value, "yyyy/MM/dd")
            If cboest.SelectedIndex = 0 Then
                est = "P"
            ElseIf cboest.SelectedIndex = 1 Then
                est = "C"
            ElseIf cboest.SelectedIndex = 1 Then
                est = "D"
            End If
            If cboest2.SelectedIndex = 0 Then
                est1 = "P"
            ElseIf cboest2.SelectedIndex = 1 Then
                est1 = "C"
            ElseIf cboest2.SelectedIndex = 1 Then
                est1 = "D"
            End If
            gsRptArgs(2) = txtoc1.Text
            gsRptArgs(3) = txtoc2.Text
            gsRptArgs(4) = txtnro1.Text
            gsRptArgs(5) = txtnro2.Text
            gsRptArgs(6) = txtcliente1.Text
            gsRptArgs(7) = txtcliente2.Text
            gsRptArgs(8) = txtarticulo1.Text
            gsRptArgs(9) = txtarticulo2.Text
            gsRptArgs(10) = est
            gsRptArgs(11) = est1
            gsRptArgs(12) = txtvend.Text
            gsRptArgs(13) = txtvend1.Text
            If cmblinea1.SelectedIndex = -1 Then
                gsRptArgs(14) = ""
            ElseIf cmblinea1.SelectedIndex = 1 Then
                gsRptArgs(14) = "0100"
            ElseIf cmblinea1.SelectedIndex = 2 Then
                gsRptArgs(14) = "0200"
            End If
            If cmblinea2.SelectedIndex = -1 Then
                gsRptArgs(15) = ""
            ElseIf cmblinea2.SelectedIndex = 1 Then
                gsRptArgs(15) = "0100"
            ElseIf cmblinea2.SelectedIndex = 2 Then
                gsRptArgs(15) = "0200"
            End If
            gsRptArgs(16) = cmbtven1.Text
            gsRptArgs(17) = cmbtven2.Text
            If rdbvistaprod.Checked = True Then
                gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_VWDETORDENPROD.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Else
                gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_VWDETORDEN.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            End If

            'ElseIf gnOpcion3 = "1" Then
            '    gsRptArgs = {}
            '    gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_EL_TBARTSTOCK_T_ENV.rpt"
            '    gsRptPath = gsPathRpt
            '    FormReportes.ShowDialog()
        End If

    End Sub

    Private Sub FormReporteVenta_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sBusAlm = "18"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sBusAlm = "19"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
    End Sub

    Private Sub txtcliente1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "13"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
        End If
    End Sub

    Private Sub txtcliente2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "14"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
        End If
    End Sub

    Private Sub txtarticulo1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtarticulo1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "11"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
                txtarticulo1.Text = gArt
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
        End If
    End Sub

    Private Sub txtarticulo2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtarticulo2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "12"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
                txtarticulo2.Text = gArt
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
        End If
    End Sub

    Private Sub txtvend_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvend.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "18"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
        End If
    End Sub

    Private Sub txtvend1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvend1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "19"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
        End If
    End Sub
End Class