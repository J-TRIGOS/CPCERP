Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormTextoPlame
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_periodo0.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "85"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txt_periodo0.Text = gLinea
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_procesar.Click
        If txt_periodo0.Text = "" Then
            MsgBox("No ah Seleccionado el periodo de generacion")
            txt_periodo0.Focus()
            Exit Sub
        End If
        If txt_AnhoMes0.Text = "" Then
            MsgBox("No ah Seleccionado el Año Mes")
            txt_AnhoMes0.Focus()
            Exit Sub
        End If

        ReDim gsRptArgs(1)
        gsRptArgs(0) = RTrim(txt_periodo0.Text)
        gsRptArgs(1) = RTrim(txt_AnhoMes0.Text)
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_PLAME_REM.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Dispose()
    End Sub

    Private Sub txt_periodo2_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_periodo2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "85"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txt_periodo2.Text = gLinea
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If txt_AnhoMes1.Text = "" Then
            MsgBox("No ah Seleccionado el Año Mes")
            txt_AnhoMes1.Focus()
            Exit Sub
        End If

        ReDim gsRptArgs(0)
        gsRptArgs(0) = RTrim(txt_AnhoMes1.Text)

        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_PLAME_SNL.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If txt_periodo2.Text = "" Then
            MsgBox("No ah Seleccionado el periodo de generacion")
            txt_periodo2.Focus()
            Exit Sub
        End If
        If txt_AnhoMes2.Text = "" Then
            MsgBox("No ah Seleccionado el Año Mes")
            txt_AnhoMes2.Focus()
            Exit Sub
        End If

        ReDim gsRptArgs(1)
        gsRptArgs(0) = RTrim(txt_periodo2.Text)
        gsRptArgs(1) = RTrim(txt_AnhoMes2.Text)
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_PLAME_JOR.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If txt_periodo3.Text = "" Then
            MsgBox("No ah Seleccionado el periodo de generacion")
            txt_periodo3.Focus()
            Exit Sub
        End If
        If txt_AnhoMes3.Text = "" Then
            MsgBox("No ah Seleccionado el Año Mes")
            txt_AnhoMes3.Focus()
            Exit Sub
        End If

        ReDim gsRptArgs(1)
        gsRptArgs(0) = RTrim(txt_periodo3.Text)
        gsRptArgs(1) = RTrim(txt_AnhoMes3.Text)
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_PLAME_TAS.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub txt_periodo3_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_periodo3.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "85"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txt_periodo3.Text = gLinea
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dispose()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dispose()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dispose()
    End Sub

    Private Sub FormTextoPlame_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tpago As String
        If txt_periodo4.Text = "" Then
            MsgBox("No ah Seleccionado el periodo de generacion")
            txt_periodo4.Focus()
            Exit Sub
        End If
        If txt_AnhoMes4.Text = "" Then
            MsgBox("No ah Seleccionado el Año Mes")
            txt_AnhoMes4.Focus()
            Exit Sub
        End If

        If cmbTipPago.SelectedIndex = 0 Then
            tpago = "MEN"
        Else
            tpago = "GRA"
        End If
        gsRptArgs = {}
        ReDim gsRptArgs(8)
        gsRptArgs(0) = RTrim(txt_periodo4.Text)
        gsRptArgs(1) = RTrim(tpago)
        gsRptArgs(2) = RTrim(txt_AnhoMes4.Text)
        gsRptArgs(3) = RTrim(txt_periodo4.Text)
        gsRptArgs(4) = RTrim(tpago)
        gsRptArgs(5) = RTrim(txt_AnhoMes4.Text)
        gsRptArgs(6) = RTrim(txt_periodo4.Text)
        gsRptArgs(7) = RTrim(tpago)
        gsRptArgs(8) = RTrim(txt_AnhoMes4.Text)
        ' gsRptArgs(5) = RTrim(txt_periodo4.Text)
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTRESUMEN_PLAME1.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dispose()
    End Sub

    Private Sub txt_periodo4_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_periodo4.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "85"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txt_periodo4.Text = gLinea
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

    Private Sub FormTextoPlame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTipPago.SelectedIndex = 0
    End Sub
End Class