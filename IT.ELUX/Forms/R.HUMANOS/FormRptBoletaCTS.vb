Imports IT.ELUX.BL
Imports System.ComponentModel
Imports System.IO

Public Class FormRptBoletaCTS
    Private ELPERIODOBL As New ELPERIODOBL
    Private PERBL As New PERBL
    Private CTSBL As New CTSBL

    Private Sub FormRptBoletaCTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Boleta de Pago CTS"
        Me.dtpfec_ini.Enabled = False
        Cmbt_per1.SelectedIndex = 0
    End Sub

    Private Sub txt_periodo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_periodo.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "85"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txt_periodo.Text = gLinea
                dtpfec_ini.Value = gArt
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Cmbt_per1.SelectedIndex = 0 Then
            sBusAlm = "3721"
        Else
            sBusAlm = "3720"
        End If
        'sBusAlm = "37"
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

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        Dim periodoCTS = txt_periodo.Text
        Dim periodoGratiCTS
        Dim periodoIni
        Dim periodoFin
        Dim FechaFin
        Dim tipoTrab
        If Cmbt_per1.SelectedIndex = 0 Then
            tipoTrab = "21"
        Else
            tipoTrab = "20"
        End If
        ReDim gsRptArgs(2)
        gsRptArgs(0) = periodoCTS
        gsRptArgs(1) = tipoTrab
        gsRptArgs(2) = txtper1.Text

        Dim valor = MsgBox("Desea recalcular CTS?", vbYesNo)


        If valor = 7 Then
            If txtper1.Text = "" Then
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_BOLETA_CTS_ALL.rpt"
                gsRptPath = gsPathRpt
                FormReportes.Show()
            Else
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_BOLETA_CTS_PER.rpt"
                gsRptPath = gsPathRpt
                FormReportes.Show()
            End If
            Exit Sub
        End If

        If Not IsNumeric(Txt_TC.Text) Then
            MsgBox("Ingrese TC Numerico")
            Exit Sub
        End If

        Dim Resultado = CTSBL.ActualizarTablaCTS(periodoCTS)
        If Resultado = "OK" Then

        End If
        Dim dtDato As New DataTable

        Try
            dtDato = CTSBL.ObtenerMesGrati(periodoCTS)
            periodoGratiCTS = dtDato.Rows(0).Item(0)
            dtDato.Dispose()

            dtDato = CTSBL.ObtenerMesIniCTS(periodoCTS)
            periodoIni = dtDato.Rows(0).Item(0)
            periodoIni = periodoIni.ToString.Substring(0, 4) + "/" + periodoIni.ToString.Substring(4, 2)

            dtDato.Dispose()

            dtDato = CTSBL.ObtenerMesFinCTS(periodoCTS)
            periodoFin = dtDato.Rows(0).Item(0)
            periodoFin = periodoFin.ToString.Substring(0, 4) + "/" + periodoFin.ToString.Substring(4, 2)
            FechaFin = dtDato.Rows(0).Item(1)
            dtDato.Dispose()
            Dim tipoCambio = Txt_TC.Text
            Dim dtPagoCts As New DataTable
            dtPagoCts = CTSBL.ObtenerPagoCts(periodoGratiCTS, periodoIni, periodoFin, FechaFin, tipoCambio)
            For i = 0 To dtPagoCts.Rows.Count - 1
                Dim per_cod = dtPagoCts.Rows(i).Item(0)
                Dim fam = dtPagoCts.Rows(i).Item(5)
                Dim grati = dtPagoCts.Rows(i).Item(7)
                Dim he = dtPagoCts.Rows(i).Item(9)
                Dim bono = dtPagoCts.Rows(i).Item(11)
                Dim mes = dtPagoCts.Rows(i).Item(15)
                Dim dia = dtPagoCts.Rows(i).Item(16)
                Dim noc = dtPagoCts.Rows(i).Item(10)
                Dim tc = Txt_TC.Text
                CTSBL.ActualizarDatosCts(periodoCTS, per_cod, fam, grati, he, bono, dia, mes, noc, tc)
            Next

            If txtper1.Text = "" Then
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_BOLETA_CTS_ALL.rpt"
                gsRptPath = gsPathRpt
                FormReportes.Show()
            Else
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_BOLETA_CTS_PER.rpt"
                gsRptPath = gsPathRpt
                FormReportes.Show()
            End If
        Catch ex As Exception

        End Try


    End Sub

End Class