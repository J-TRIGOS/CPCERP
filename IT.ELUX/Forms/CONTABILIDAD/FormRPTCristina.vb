Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRPTCristina
    Private GUIAALMACENBL As New GUIAALMACENBL
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
    Private Sub FormRPTCristina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Reporte Pres."
        cmbaño.SelectedItem = sAño
        bprimero = True
        Dim dt As DataTable
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo)
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
    Private Sub cmbc_costo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbc_costo.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo.Text = cmbc_costo.SelectedValue
    End Sub
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRPTCristina_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        Dim igv As String = ""
        If chkigv.Checked Then
            igv = "1"
        End If
        If chktotal.Checked Then
            Dim s As String = ""
            If cmbmoneda.Text = "Soles" Then
                s = "S"
            End If
            ReDim gsRptArgs(3)
            gsRptArgs(0) = cmbaño.SelectedItem
            gsRptArgs(1) = txtc_costo.Text
            gsRptArgs(2) = s
            gsRptArgs(3) = igv
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPT_PRESCRI2.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        Else
            Dim s As String = ""
            If cmbmoneda.Text = "Soles" Then
                s = "S"
            End If
            ReDim gsRptArgs(3)
            gsRptArgs(0) = cmbaño.SelectedItem
            gsRptArgs(1) = txtc_costo.Text
            gsRptArgs(2) = s
            gsRptArgs(3) = igv
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPT_PRESCRI.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If

    End Sub
End Class