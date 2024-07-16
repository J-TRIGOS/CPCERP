Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRptProdCCO_COD
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
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRptProdCCO_COD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bprimero = True
        Me.Text = "Reporte Costo de articulo produccion por C.Costo"
        cmbaño.SelectedItem = sAño
        Dim dt As DataTable
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo)
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo2)
        bprimero = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtc_costo.Text = gLinea
            cmbc_costo.SelectedValue = gLinea
            txtc_costo.Select()
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtc_costo2.Text = gLinea
            cmbc_costo2.SelectedValue = gLinea
            txtc_costo2.Select()
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub
    Private Sub txtc_costo_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo.LostFocus
        If txtc_costo.Text = "" Then
            cmbc_costo.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo.SelectedValue = txtc_costo.Text
        If cmbc_costo.SelectedValue Is Nothing Then
            MsgBox("Centro de costo no existe", MsgBoxStyle.Exclamation)
            txtc_costo.Text = ""
        End If
    End Sub

    Private Sub txtc_costo2_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo2.LostFocus
        If txtc_costo2.Text = "" Then
            cmbc_costo2.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo2.SelectedValue = txtc_costo2.Text
        If cmbc_costo2.SelectedValue Is Nothing Then
            MsgBox("Centro de costo no existe", MsgBoxStyle.Exclamation)
            txtc_costo2.Text = ""
        End If
    End Sub

    Private Sub cmbc_costo2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo2.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbc_costo2.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo2.Text = cmbc_costo2.SelectedValue
    End Sub

    Private Sub cmbc_costo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbc_costo.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo.Text = cmbc_costo.SelectedValue
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(3)
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
        gsRptArgs(2) = txtc_costo.Text
        gsRptArgs(3) = txtc_costo2.Text
        If cmbmes1.SelectedIndex = -1 Or cmbmes1.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar Mes")
        Else
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_COSTO_ART_PROD_CCOSTO.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If

    End Sub
End Class