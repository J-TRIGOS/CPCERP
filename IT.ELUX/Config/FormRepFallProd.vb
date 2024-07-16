Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormRepFallProd
    Private ELTBLINESBL As New ELTBLINESBL
    Private ARTICULOBL As New ARTICULOBL
    Private bPrimero As Boolean = True

#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
#End Region

    Private Sub FormRepFallProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtFecha As Date
        bPrimero = True
        dtFecha = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        Me.Text = "Reporte Produccion Fallados"
        Dim dt As DataTable = ARTICULOBL.getListcmb13()
        GetCmb("cod", "nom", dt, cmbc_costo)
        dtpfecini.Value = dtFecha
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "20"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "11"
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

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        sBusAlm = "27"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtsublinea.Text = gSubLinea
            txtsublinea.Select()
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        sBusAlm = "27"
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

    Private Sub txtsublinea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsublinea.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub
    Private Sub txtsublinea2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsublinea2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub
    Private Sub txtsublinea_LostFocus(sender As Object, e As EventArgs) Handles txtsublinea.LostFocus
        If txtsublinea.TextLength = 4 Then
            txtnomsublinea.Text = ELTBLINESBL.SelectDescri(txtsublinea.Text)
        Else
            txtnomsublinea.Text = ""
        End If
    End Sub

    Private Sub txtsublinea2_LostFocus(sender As Object, e As EventArgs) Handles txtsublinea2.LostFocus
        If txtsublinea2.TextLength = 4 Then
            txtnomsublinea2.Text = ELTBLINESBL.SelectDescri(txtsublinea2.Text)
        Else
            txtnomsublinea2.Text = ""
        End If
    End Sub
    Private Sub txtc_costo_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo.LostFocus
        If txtc_costo.Text = "" Then
            cmbc_costo.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo.SelectedValue = txtc_costo.Text
        If cmbc_costo.SelectedValue Is Nothing Then
            MsgBox("La linea no existe", MsgBoxStyle.Exclamation)
            txtc_costo.Text = ""
            txtc_costo.Select()
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRepFallProd_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        gsRptArgs = {}
        ReDim gsRptArgs(9)
        gsRptArgs(0) = Format(dtpfecini.Value, "yyyy/MM/dd")
        gsRptArgs(1) = Format(dtpfecfin.Value, "yyyy/MM/dd")
        If cmbest.SelectedIndex <> -1 Then
            gsRptArgs(2) = cmbest.SelectedText
        Else
            gsRptArgs(2) = ""
        End If
        If cmbestdoc.SelectedIndex = 1 Then
            gsRptArgs(3) = "0"
        ElseIf cmbestdoc.SelectedIndex = 2 Then
            gsRptArgs(3) = "1"
        ElseIf cmbestdoc.SelectedIndex = 3 Then
            gsRptArgs(3) = "2"
        ElseIf cmbestdoc.SelectedIndex = 4 Then
            gsRptArgs(3) = "3"
        End If
        gsRptArgs(4) = txtuserrep.Text
        gsRptArgs(5) = txtarticulo1.Text
        'If txtsublinea.TextLength = "4" Then
        gsRptArgs(6) = txtsublinea.Text
        gsRptArgs(7) = txtlote.Text
        gsRptArgs(8) = txtfardo.Text
        gsRptArgs(9) = txtsublinea2.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTFALLPRO_PD.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class