Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormELPROGRAMACION_cuadro


    Private nNode As Integer = 0
    Private ELPROGRAMACIONBL As New ELPROGRAMACIONBL
    Private ELTBTAREOBL As New ELTBTAREOBL
    Private Sub FormELPROGRAMACION_cuadro_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub txtprdo_cod_LostFocus(sender As Object, e As EventArgs) Handles txtprdo_cod.LostFocus
        If (txtprdo_cod.Text = "") Then
            lblprdo_cod.Text = ""
        Else
            Dim dt As DataTable
            dt = ELPROGRAMACIONBL.SelectPeriodoCOD(DateTime.Now.Year, txtprdo_cod.Text)
            If dt.Rows.Count > 0 Then
                txtprdo_cod.Text = dt.Rows(0).Item(0).ToString
                lblprdo_cod.Text = dt.Rows(0).Item(1).ToString
            Else
                txtprdo_cod.Text = ""
                lblprdo_cod.Text = ""
            End If
        End If
    End Sub
    Private Sub txtprdo_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprdo_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "77"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtprdo_cod.Text = gLinea
                lblprdo_cod.Text = gSubLinea
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub txtper_cod_LostFocus(sender As Object, e As EventArgs) Handles txtper_cod.LostFocus
        If (txtper_cod.Text = "") Then
            lblper_cod.Text = ""
        Else
            Dim dt As DataTable
            dt = ELTBTAREOBL.SelectPerCOD(txtper_cod.Text)
            If dt.Rows.Count > 0 Then
                txtper_cod.Text = dt.Rows(0).Item(0).ToString
                lblper_cod.Text = dt.Rows(0).Item(1).ToString
            Else
                txtper_cod.Text = ""
                lblper_cod.Text = ""
            End If
        End If
    End Sub

    Private Sub txtper_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtper_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "36"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtper_cod.Text = gLinea
                lblper_cod.Text = gSubLinea
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub txtlinea_cod_LostFocus(sender As Object, e As EventArgs) Handles txtlinea_cod.LostFocus
        If (txtlinea_cod.Text = "") Then
            lbllinea_cod.Text = ""
        Else
            Dim dt As DataTable
            dt = ELPROGRAMACIONBL.SelectAreaCOD(txtlinea_cod.Text)
            If dt.Rows.Count > 0 Then
                txtlinea_cod.Text = dt.Rows(0).Item(0).ToString
                lbllinea_cod.Text = dt.Rows(0).Item(1).ToString
            Else
                txtlinea_cod.Text = ""
                lbllinea_cod.Text = ""
            End If
        End If
    End Sub

    Private Sub txtlinea_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlinea_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "92"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtlinea_cod.Text = gLinea
                lbllinea_cod.Text = gSubLinea
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cancelar1_Click(sender As Object, e As EventArgs) Handles cancelar1.Click, cancelar2.Click, cancelar3.Click
        Me.Close()
    End Sub

    Private Sub Generar1_Click(sender As Object, e As EventArgs) Handles Generar1.Click
        If txtprdo_cod.Text = "" Then
            MsgBox("Ingrese el Periodo", MsgBoxStyle.Exclamation)
        Else
            ReDim gsRptArgs(1)
            gsRptArgs(0) = txtprdo_cod.Text
            gsRptArgs(1) = "PERIODO"
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELPROGRAMACIONRE.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If
    End Sub
    Private Sub Generar2_Click(sender As Object, e As EventArgs) Handles Generar2.Click
        If txtper_cod.Text = "" Then
            MsgBox("Ingrese el dni del Personal", MsgBoxStyle.Exclamation)
        Else
            ReDim gsRptArgs(1)
            gsRptArgs(0) = txtper_cod.Text
            gsRptArgs(1) = "PERSON"
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELPROGRAMACIONRE.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If
    End Sub
    Private Sub Generar3_Click(sender As Object, e As EventArgs) Handles Generar3.Click
        If txtlinea_cod.Text = "" Then
            MsgBox("Ingrese el Area", MsgBoxStyle.Exclamation)
        Else
            ReDim gsRptArgs(1)
            gsRptArgs(0) = txtlinea_cod.Text
            gsRptArgs(1) = "AREA"
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELPROGRAMACIONRE.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If
    End Sub

    Private Sub FormELPROGRAMACION_cuadro_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
End Class