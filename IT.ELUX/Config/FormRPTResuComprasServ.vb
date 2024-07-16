Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRPTResuComprasServ
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
    Private Sub FormRPTResuComprasServ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Resumen Compras Servicio Valorizado"
        bprimero = True
        cmbaño.SelectedItem = sAño
        cmbaño1.SelectedItem = sAño
        cmbmes1.SelectedItem = "Enero"
        cmbmes2.SelectedIndex = Month(Date.Today)
        Dim dt As DataTable
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo)
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo2)
        bprimero = False
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRPTResuComprasServ_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
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
    Private Sub cmbc_costo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbc_costo.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo.Text = cmbc_costo.SelectedValue
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
    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(7)
        If cmbmes1.SelectedIndex = 1 Then
            gsRptArgs(0) = cmbaño.Text & "01"
        ElseIf cmbmes1.SelectedIndex = 2 Then
            gsRptArgs(0) = cmbaño.Text & "02"
        ElseIf cmbmes1.SelectedIndex = 3 Then
            gsRptArgs(0) = cmbaño.Text & "03"
        ElseIf cmbmes1.SelectedIndex = 4 Then
            gsRptArgs(0) = cmbaño.Text & "04"
        ElseIf cmbmes1.SelectedIndex = 5 Then
            gsRptArgs(0) = cmbaño.Text & "05"
        ElseIf cmbmes1.SelectedIndex = 6 Then
            gsRptArgs(0) = cmbaño.Text & "06"
        ElseIf cmbmes1.SelectedIndex = 7 Then
            gsRptArgs(0) = cmbaño.Text & "07"
        ElseIf cmbmes1.SelectedIndex = 8 Then
            gsRptArgs(0) = cmbaño.Text & "08"
        ElseIf cmbmes1.SelectedIndex = 9 Then
            gsRptArgs(0) = cmbaño.Text & "09"
        ElseIf cmbmes1.SelectedIndex = 10 Then
            gsRptArgs(0) = cmbaño.Text & "10"
        ElseIf cmbmes1.SelectedIndex = 11 Then
            gsRptArgs(0) = cmbaño.Text & "11"
        ElseIf cmbmes1.SelectedIndex = 12 Then
            gsRptArgs(0) = cmbaño.Text & "12"
        End If
        If cmbmes2.SelectedIndex = 1 Then
            gsRptArgs(1) = cmbaño1.Text & "01"
        ElseIf cmbmes2.SelectedIndex = 2 Then
            gsRptArgs(1) = cmbaño1.Text & "02"
        ElseIf cmbmes2.SelectedIndex = 3 Then
            gsRptArgs(1) = cmbaño1.Text & "03"
        ElseIf cmbmes2.SelectedIndex = 4 Then
            gsRptArgs(1) = cmbaño1.Text & "04"
        ElseIf cmbmes2.SelectedIndex = 5 Then
            gsRptArgs(1) = cmbaño1.Text & "05"
        ElseIf cmbmes2.SelectedIndex = 6 Then
            gsRptArgs(1) = cmbaño1.Text & "06"
        ElseIf cmbmes2.SelectedIndex = 7 Then
            gsRptArgs(1) = cmbaño1.Text & "07"
        ElseIf cmbmes2.SelectedIndex = 8 Then
            gsRptArgs(1) = cmbaño1.Text & "08"
        ElseIf cmbmes2.SelectedIndex = 9 Then
            gsRptArgs(1) = cmbaño1.Text & "09"
        ElseIf cmbmes2.SelectedIndex = 10 Then
            gsRptArgs(1) = cmbaño1.Text & "10"
        ElseIf cmbmes2.SelectedIndex = 11 Then
            gsRptArgs(1) = cmbaño1.Text & "11"
        ElseIf cmbmes2.SelectedIndex = 12 Then
            gsRptArgs(1) = cmbaño1.Text & "12"
        End If
        gsRptArgs(2) = txtcliente1.Text
        gsRptArgs(3) = txtcliente2.Text
        gsRptArgs(4) = txtc_costo.Text
        gsRptArgs(5) = txtc_costo2.Text
        If cmbtaller.text = "SI" Then
            gsRptArgs(6) = "1"
            gsRptArgs(7) = "1"
        Else
            gsRptArgs(6) = ""
            gsRptArgs(7) = ""
        End If
        'gsRptArgs(5) = txtc_costo2.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RESU_COMPRAS_SERV.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class