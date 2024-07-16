Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRPTResuProdMed
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private ARTICULOBL As New ARTICULOBL
    Private ELTBLINESBL As New ELTBLINESBL
    Private bprimero As Boolean
#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
#End Region
    Private Sub FormRPTResuProdMed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Resumen Produccion por Medida - Valorizado"
        cmbaño.SelectedItem = sAño
        cmbmes1.SelectedItem = "Enero"
        cmbmes2.SelectedIndex = Month(Date.Today)
    End Sub
    Private Sub FormRPTResuProdMed_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(4)
        gsRptArgs(0) = cmbaño.SelectedItem
        If cmbmes1.SelectedIndex = 1 Then
            gsRptArgs(1) = "01"
        ElseIf cmbmes1.SelectedIndex = 2 Then
            gsRptArgs(1) = "02"
        ElseIf cmbmes1.SelectedIndex = 3 Then
            gsRptArgs(1) = "03"
        ElseIf cmbmes1.SelectedIndex = 4 Then
            gsRptArgs(1) = "04"
        ElseIf cmbmes1.SelectedIndex = 5 Then
            gsRptArgs(1) = "05"
        ElseIf cmbmes1.SelectedIndex = 6 Then
            gsRptArgs(1) = "06"
        ElseIf cmbmes1.SelectedIndex = 7 Then
            gsRptArgs(1) = "07"
        ElseIf cmbmes1.SelectedIndex = 8 Then
            gsRptArgs(1) = "08"
        ElseIf cmbmes1.SelectedIndex = 9 Then
            gsRptArgs(1) = "09"
        ElseIf cmbmes1.SelectedIndex = 10 Then
            gsRptArgs(1) = "10"
        ElseIf cmbmes1.SelectedIndex = 11 Then
            gsRptArgs(1) = "11"
        ElseIf cmbmes1.SelectedIndex = 12 Then
            gsRptArgs(1) = "12"
        End If
        If cmbmes2.SelectedIndex = 1 Then
            gsRptArgs(2) = "01"
        ElseIf cmbmes2.SelectedIndex = 2 Then
            gsRptArgs(2) = "02"
        ElseIf cmbmes2.SelectedIndex = 3 Then
            gsRptArgs(2) = "03"
        ElseIf cmbmes2.SelectedIndex = 4 Then
            gsRptArgs(2) = "04"
        ElseIf cmbmes2.SelectedIndex = 5 Then
            gsRptArgs(2) = "05"
        ElseIf cmbmes2.SelectedIndex = 6 Then
            gsRptArgs(2) = "06"
        ElseIf cmbmes2.SelectedIndex = 7 Then
            gsRptArgs(2) = "07"
        ElseIf cmbmes2.SelectedIndex = 8 Then
            gsRptArgs(2) = "08"
        ElseIf cmbmes2.SelectedIndex = 9 Then
            gsRptArgs(2) = "09"
        ElseIf cmbmes2.SelectedIndex = 10 Then
            gsRptArgs(2) = "10"
        ElseIf cmbmes2.SelectedIndex = 11 Then
            gsRptArgs(2) = "11"
        ElseIf cmbmes2.SelectedIndex = 12 Then
            gsRptArgs(2) = "12"
        End If
        gsRptArgs(3) = txtsublinea1.Text
        gsRptArgs(4) = txtsublinea2.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RESU_PROD_MED.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub txtsublinea2_Validated(sender As Object, e As EventArgs) Handles txtsublinea2.Validated
        If txtsublinea2.TextLength > 0 Then
            TextBox3.Text = ELTBLINESBL.SelectDescri(txtsublinea2.Text)
        End If

    End Sub
    Private Sub txtsublinea1_Validated(sender As Object, e As EventArgs) Handles txtsublinea1.Validated
        If txtsublinea1.TextLength > 0 Then
            TextBox2.Text = ELTBLINESBL.SelectDescri(txtsublinea1.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "27"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtsublinea1.Text = gSubLinea
            txtsublinea1.Select()
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "28"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtsublinea2.Text = gSubLinea
            txtsublinea2.Select()
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub
End Class