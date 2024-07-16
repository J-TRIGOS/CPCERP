Imports System.ComponentModel

Public Class FormStatusCuentasCobrar
    Private Sub FormStatusCuentasCobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Status Cuentas por Cobrar"
        Dim dtFecha As Date = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        dtpfec1.Value = dtFecha
        If gsUser = "OBEIZAGA" Then
            cmbcargoso.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormStatusCuentasCobrar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
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
            txtvend1.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
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


    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        If rdbop1.Checked = True Then
            'If gsUser = "OBEIZAGA" And cmbcargoso.SelectedIndex = 0 Then
            '    ReDim gsRptArgs(10)
            '    gsRptArgs(0) = txtvend.Text
            '    gsRptArgs(1) = txtvend1.Text
            '    gsRptArgs(2) = txtcliente1.Text
            '    gsRptArgs(3) = txtcliente2.Text
            '    If cmbtipo1.SelectedIndex = 1 Then
            '        gsRptArgs(4) = "80"
            '    ElseIf cmbtipo1.SelectedIndex = 2 Then
            '        gsRptArgs(4) = "01"
            '    ElseIf cmbtipo1.SelectedIndex = 3 Then
            '        gsRptArgs(4) = "07"
            '    Else
            '        gsRptArgs(4) = ""
            '    End If
            '    If cmbtipo2.SelectedIndex = 1 Then
            '        gsRptArgs(5) = "80"
            '    ElseIf cmbtipo2.SelectedIndex = 2 Then
            '        gsRptArgs(5) = "01"
            '    ElseIf cmbtipo2.SelectedIndex = 3 Then
            '        gsRptArgs(5) = "07"
            '    Else
            '        gsRptArgs(5) = ""
            '    End If
            '    gsRptArgs(6) = Format(dtpfec1.Value, "yyyy/MM/dd")
            '    gsRptArgs(7) = Format(dtpfec2.Value, "yyyy/MM/dd")
            '    gsRptArgs(8) = cmbestado1.Text
            '    gsRptArgs(9) = cmbestado2.Text
            '    gsRptArgs(10) = cmbvencido.SelectedIndex
            '    gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_CTAS_POR_COBRAR2.rpt"
            '    gsRptPath = gsPathRpt
            '    FormReportes.Show()
            '    'End If
            'Else
            ReDim gsRptArgs(10)
                gsRptArgs(0) = Format(dtpfec1.Value, "yyyy/MM/dd")
                gsRptArgs(1) = txtvend.Text
                gsRptArgs(2) = txtvend1.Text
                gsRptArgs(3) = txtcliente1.Text
                gsRptArgs(4) = txtcliente2.Text
                If cmbtipo1.SelectedIndex = 1 Then
                    gsRptArgs(5) = "80"
                ElseIf cmbtipo1.SelectedIndex = 2 Then
                    gsRptArgs(5) = "01"
                ElseIf cmbtipo1.SelectedIndex = 3 Then
                    gsRptArgs(5) = "07"
                Else
                    gsRptArgs(5) = ""
                End If
                If cmbtipo2.SelectedIndex = 1 Then
                    gsRptArgs(6) = "80"
                ElseIf cmbtipo2.SelectedIndex = 2 Then
                    gsRptArgs(6) = "01"
                ElseIf cmbtipo2.SelectedIndex = 3 Then
                    gsRptArgs(6) = "07"
                Else
                    gsRptArgs(6) = ""
                End If
                gsRptArgs(7) = Format(dtpfec2.Value, "yyyy/MM/dd")
                gsRptArgs(8) = cmbestado1.Text
                gsRptArgs(9) = cmbestado2.Text
                gsRptArgs(10) = cmbvencido.SelectedIndex
                gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_CTAS_POR_COBRAR.rpt"
                gsRptPath = gsPathRpt
                FormReportes.Show()
                'End If
                Else
            ReDim gsRptArgs(9)
            gsRptArgs(0) = Format(dtpfec1.Value, "yyyy/MM/dd")
            gsRptArgs(1) = txtvend.Text
            gsRptArgs(2) = txtvend1.Text
            gsRptArgs(3) = txtcliente1.Text
            gsRptArgs(4) = txtcliente2.Text
            If cmbtipo1.SelectedIndex = 1 Then
                gsRptArgs(5) = "80"
            ElseIf cmbtipo1.SelectedIndex = 2 Then
                gsRptArgs(5) = "01"
            ElseIf cmbtipo1.SelectedIndex = 3 Then
                gsRptArgs(5) = "07"
            Else
                gsRptArgs(5) = ""
            End If
            If cmbtipo2.SelectedIndex = 1 Then
                gsRptArgs(6) = "80"
            ElseIf cmbtipo2.SelectedIndex = 2 Then
                gsRptArgs(6) = "01"
            ElseIf cmbtipo2.SelectedIndex = 3 Then
                gsRptArgs(6) = "07"
            Else
                gsRptArgs(6) = ""
            End If
            gsRptArgs(7) = Format(dtpfec2.Value, "yyyy/MM/dd")
            gsRptArgs(8) = cmbestado1.Text
            gsRptArgs(9) = cmbestado2.Text
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_ESTADO_DOCUMENTOS.rpt"
            gsRptPath = gsPathRpt
            FormReportes.Show()
        End If

    End Sub


    Private Sub txtvend_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvend.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "41"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtvend.Text = gLinea
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
        End If
    End Sub
    Private Sub txtvend1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvend1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "41"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtvend1.Text = gLinea
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtcliente1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "39"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtcliente1.Text = gLinea
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
        End If
    End Sub


    Private Sub txtcliente2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "39"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtcliente2.Text = gLinea
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
        End If
    End Sub

    Private Sub cmbestado1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbestado1.SelectedIndexChanged

    End Sub
End Class