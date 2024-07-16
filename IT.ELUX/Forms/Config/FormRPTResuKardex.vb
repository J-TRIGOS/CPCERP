Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRPTResuKardex
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
    Private Sub FormRPTResuKardex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Kardex Resumen Medidas"
        'Me.Text = "Control Ingresos"
        cmbaño.SelectedItem = sAño
        cmbmes1.SelectedItem = "Enero"
        cmbmes2.SelectedIndex = Month(Date.Today)
        bprimero = True
        Dim dtFecha As Date = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        Dim dt As DataTable
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo)
        'Dim dt1 As DataTable
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo2)
        dt = GUIAALMACENBL.SelectCCosto
        bprimero = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        sBusAlm = "62"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtmedida1.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        sBusAlm = "62"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtmedida2.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRPTResuKardex_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        If rdbpp.Checked = True Then
            ReDim gsRptArgs(4)
            gsRptArgs(0) = cmbaño.Text
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
            gsRptArgs(3) = txtmedida1.Text
            gsRptArgs(4) = txtmedida2.Text
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_KARDEX__PARTES_MEDIDA_RESU.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        ElseIf rdbsinpp.Checked = True Then
            ReDim gsRptArgs(6)
            gsRptArgs(0) = cmbaño.Text
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
            If cmbtipo1.SelectedIndex = 3 Then
                gsRptArgs(3) = "MPR"
            Else
                gsRptArgs(3) = Mid(cmbtipo1.Text, 1, 2)
            End If
            If cmbtipo2.SelectedIndex = 3 Then
                gsRptArgs(4) = "MPR"
            Else
                gsRptArgs(4) = Mid(cmbtipo2.Text, 1, 2)
            End If
            gsRptArgs(5) = txtmedida1.Text
            gsRptArgs(6) = txtmedida2.Text


            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_KARDEX_MEDIDA_RESU.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        ElseIf rdbppv.Checked = True Then
            ReDim gsRptArgs(8)
            gsRptArgs(0) = cmbaño.Text
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
            gsRptArgs(2) = txtarticulo1.Text
            gsRptArgs(3) = txtarticulo2.Text
            If cmbmes2.SelectedIndex = 1 Then
                gsRptArgs(4) = "01"
            ElseIf cmbmes2.SelectedIndex = 2 Then
                gsRptArgs(4) = "02"
            ElseIf cmbmes2.SelectedIndex = 3 Then
                gsRptArgs(4) = "03"
            ElseIf cmbmes2.SelectedIndex = 4 Then
                gsRptArgs(4) = "04"
            ElseIf cmbmes2.SelectedIndex = 5 Then
                gsRptArgs(4) = "05"
            ElseIf cmbmes2.SelectedIndex = 6 Then
                gsRptArgs(4) = "06"
            ElseIf cmbmes2.SelectedIndex = 7 Then
                gsRptArgs(4) = "07"
            ElseIf cmbmes2.SelectedIndex = 8 Then
                gsRptArgs(4) = "08"
            ElseIf cmbmes2.SelectedIndex = 9 Then
                gsRptArgs(4) = "09"
            ElseIf cmbmes2.SelectedIndex = 10 Then
                gsRptArgs(4) = "10"
            ElseIf cmbmes2.SelectedIndex = 11 Then
                gsRptArgs(4) = "11"
            ElseIf cmbmes2.SelectedIndex = 12 Then
                gsRptArgs(4) = "12"
            End If
            gsRptArgs(5) = txtc_costo.Text
            gsRptArgs(6) = txtc_costo2.Text
            If cmbtipo1.SelectedIndex = 3 Then
                gsRptArgs(7) = "MPR"
            Else
                gsRptArgs(7) = Mid(cmbtipo1.Text, 1, 2)
            End If
            If cmbtipo2.SelectedIndex = 3 Then
                gsRptArgs(8) = "MPR"
            Else
                gsRptArgs(8) = Mid(cmbtipo2.Text, 1, 2)
            End If
            'gsRptArgs(3) = Mid(cmbtipo1.Text, 1, 2)
            'gsRptArgs(4) = Mid(cmbtipo2.Text, 1, 2)
            'gsRptArgs(5) = txtmedida1.Text
            'gsRptArgs(6) = txtmedida2.Text


            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_KARDEX_CONSUMO_AHB_CCOSTO_RESU.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If

    End Sub

    Private Sub rdbsinpp_CheckedChanged(sender As Object, e As EventArgs) Handles rdbsinpp.CheckedChanged
        cmbtipo1.Enabled = True
        cmbtipo2.Enabled = True
        cmbtipo1.SelectedIndex = -1
        cmbtipo2.SelectedIndex = -1
        txtarticulo1.Enabled = False
        txtarticulo2.Enabled = False
        Button2.Enabled = False
        Button1.Enabled = False
        txtc_costo.Enabled = False
        txtc_costo2.Enabled = False
        cmbc_costo.Enabled = False
        cmbc_costo2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
    End Sub

    Private Sub rdbpp_CheckedChanged(sender As Object, e As EventArgs) Handles rdbpp.CheckedChanged
        cmbtipo1.Enabled = False
        cmbtipo2.Enabled = False
        txtarticulo1.Enabled = False
        txtarticulo2.Enabled = False
        Button2.Enabled = False
        Button1.Enabled = False
        txtc_costo.Enabled = False
        txtc_costo2.Enabled = False
        cmbc_costo.Enabled = False
        cmbc_costo2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
    End Sub

    Private Sub rdbppv_CheckedChanged(sender As Object, e As EventArgs) Handles rdbppv.CheckedChanged
        cmbtipo1.Enabled = True
        cmbtipo2.Enabled = True
        cmbtipo1.SelectedIndex = -1
        cmbtipo2.SelectedIndex = -1
        txtarticulo1.Enabled = True
        txtarticulo2.Enabled = True
        Button2.Enabled = True
        Button1.Enabled = True
        txtc_costo.Enabled = True
        txtc_costo2.Enabled = True
        cmbc_costo.Enabled = True
        cmbc_costo2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "12"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

End Class