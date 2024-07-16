Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormReporteInventario
    Private ARTICULOBL As New ARTICULOBL
    Private REPORTE_INVENTARIOBL As New REPORTE_INVENTARIOBL
    Private primero As Boolean
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1

    End Function
    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim Mes As String = ""
        If cmbMes.Text = "ENERO" Then
            Mes = "01"
        ElseIf cmbMes.Text = "FEBRERO" Then
            Mes = "02"
        ElseIf cmbMes.Text = "MARZO" Then
            Mes = "03"
        ElseIf cmbMes.Text = "ABRIL" Then
            Mes = "04"
        ElseIf cmbMes.Text = "MAYO" Then
            Mes = "05"
        ElseIf cmbMes.Text = "JUNIO" Then
            Mes = "06"
        ElseIf cmbMes.Text = "JULIO" Then
            Mes = "07"
        ElseIf cmbMes.Text = "AGOSTO" Then
            Mes = "08"
        ElseIf cmbMes.Text = "SEPTIEMBRE" Then
            Mes = "09"
        ElseIf cmbMes.Text = "OCTUBRE" Then
            Mes = "10"
        ElseIf cmbMes.Text = "NOVIEMBRE" Then
            Mes = "11"
        ElseIf cmbMes.Text = "DICIEMBRE" Then
            Mes = "12"
        End If

        '    If chkUltMov.Checked = True Then
        '
        '        Dim resultado = REPORTE_INVENTARIOBL.registrar(txtSubLin1.Text, TextBox1.Text, cmbAnho.Text, Mes, dtpFecFin.Text, "1")
        '        If resultado = "OK" Then
        '            ReDim gsRptArgs(0)
        '            gsRptArgs(0) = txtSubLin1.Text
        '            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTETIQUETA_ALM_T.rpt"
        '            gsRptPath = gsPathRpt
        '            FormReportes.ShowDialog()
        '        End If
        '    Else
        Dim resultado = REPORTE_INVENTARIOBL.registrar(txtLinea.Text, txtSubLin1.Text, TextBox1.Text, cmbAnho.Text, Mes, "", "0")
        If resultado = "OK" Then
            ReDim gsRptArgs(2)
            gsRptArgs(0) = txtLinea.Text
            gsRptArgs(1) = txtSubLin1.Text
            gsRptArgs(2) = TextBox1.Text
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTETIQUETA_ALM_T.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If
        '    End If


    End Sub

    Private Sub FormReporteInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        primero = True

        Dim dtFecha As Date
        dtFecha = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        dtpFecIni.Value = dtFecha

        Dim dt As New DataTable
        dt = ARTICULOBL.SelectDescripcion()
        GetCmb("lin_codigo", "lin_descri", dt, cmbLineas)

        For number As Integer = 2022 To (Date.Now.Year)
            cmbAnho.Items.Add(number)
        Next
        cmbAnho.SelectedIndex = 0

        cmbMes.SelectedIndex = (Date.Now.Month) - 1
        primero = False
    End Sub

    Private Sub cmbLineas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLineas.SelectedIndexChanged
        If primero Then Exit Sub
        Dim sCode As String = Mid(cmbLineas.SelectedValue, 1, 2)
        Dim dt As New DataTable
        primero = True
        txtSubLin1.Text = ""
        dt = ARTICULOBL.SelectDescripcion1(sCode)
        GetCmb("lin_codigo", "lin_descri", dt, cmbSublineas)
        txtLinea.Text = cmbLineas.SelectedValue


        'TextBox2.Text = cmbLineas.SelectedValue
        primero = False
    End Sub

    Private Sub cmbSublineas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSublineas.SelectedIndexChanged
        If primero Then Exit Sub
        Dim sCode As String = cmbSublineas.SelectedValue
        Dim dt As New DataTable
        primero = True
        dt = ARTICULOBL.SelectAll(sCode)
        If dt.Rows.Count > 0 Then
            txtSubLin1.Text = cmbSublineas.SelectedValue
        ElseIf txtLinea.Text = Nothing Then
            MsgBox("La Sublinea no tiene articulos")
        End If
        primero = False
    End Sub

    Private Sub FormReporteInventario_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dispose()
    End Sub

    Private Sub txtLinea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLinea.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtLinea_LostFocus(sender As Object, e As EventArgs) Handles txtLinea.LostFocus
        If txtLinea.TextLength >= 2 Then
            If txtLinea.TextLength = 1 Then
                txtLinea.Text = txtLinea.Text & "000"
            ElseIf txtLinea.TextLength = 2 Then
                txtLinea.Text = txtLinea.Text & "00"
            ElseIf txtLinea.TextLength = 3 Then
                txtLinea.Text = txtLinea.Text & "0"
            End If
            cmbLineas.SelectedValue = txtLinea.Text 'ELTBLINESBL.SelectDescri(TextBox2.Text & "00")
        Else
            If cmbLineas.Text = "" Then
                txtLinea.Text = ""
            End If
        End If
    End Sub

    Private Sub txtSubLin1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubLin1.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSubLin1_LostFocus(sender As Object, e As EventArgs) Handles txtSubLin1.LostFocus
        If txtSubLin1.TextLength = 4 Then
            txtLinea.Text = txtSubLin1.Text.Substring(0, 2).Trim() + "00"
            cmbSublineas.SelectedValue = txtSubLin1.Text
            If cmbSublineas.Text = "" Then
                txtLinea.Text = ""
                cmbLineas.SelectedIndex = -1
                txtSubLin1.Text = ""
                cmbSublineas.SelectedIndex = -1
            End If
        Else
            cmbSublineas.SelectedValue = -1
            txtSubLin1.Text = ""
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedIndex = 0 Then
            TextBox1.Text = "0001"
        ElseIf ComboBox3.SelectedIndex = 1 Then
            TextBox1.Text = "0002"
        ElseIf ComboBox3.SelectedIndex = 2 Then
            TextBox1.Text = "0003"
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = "0001" Then
            ComboBox3.SelectedIndex = 0
        ElseIf TextBox1.Text = "0002" Then
            ComboBox3.SelectedIndex = 1
        ElseIf TextBox1.Text = "0003" Then
            ComboBox3.SelectedIndex = 2
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dispose()
    End Sub


End Class