Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRptSolMat
    Private ARTICULOBL As New ARTICULOBL
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

    Private Sub FormRptSolMat_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub FormRptSolMat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Reporte Solicitud Materiales"
        Dim dtFecha As Date = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        dtpfec1.Value = dtFecha
        Dim dt As DataTable = ARTICULOBL.getListcmb13()
        GetCmb("cod", "nom", dt, cmbc_costo)
        cmbest.SelectedIndex = 1
        cmbestdoc.SelectedIndex = 3
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        gsRptArgs = {}
        ReDim gsRptArgs(6)
        gsRptArgs(0) = Format(dtpfec1.Value, "yyyy/MM/dd")
        gsRptArgs(1) = Format(dtpfec2.Value, "yyyy/MM/dd")
        If cmbest.SelectedIndex <> -1 Then
            If cmbest.SelectedIndex = 1 Then
                gsRptArgs(2) = "H"
            ElseIf cmbest.SelectedIndex = 2 Then
                gsRptArgs(2) = "A"
            ElseIf cmbest.SelectedIndex = 0 Then
                gsRptArgs(2) = ""
            End If
        Else
            gsRptArgs(2) = ""
        End If
        If cmbestdoc.SelectedIndex <> -1 Then
            If cmbestdoc.SelectedIndex = 1 Then
                gsRptArgs(3) = "0"
            ElseIf cmbestdoc.SelectedIndex = 2 Then
                gsRptArgs(3) = "1"
            ElseIf cmbestdoc.SelectedIndex = 3 Then
                gsRptArgs(3) = "2"
            ElseIf cmbestdoc.SelectedIndex = 4 Then
                gsRptArgs(3) = "3"
            ElseIf cmbestdoc.SelectedIndex = 5 Then
                gsRptArgs(3) = "CER"
            End If
        Else
            gsRptArgs(3) = ""
        End If

        If cmbc_costo.SelectedIndex <> -1 Then
            gsRptArgs(4) = cmbc_costo.SelectedValue
        Else
            gsRptArgs(4) = ""
        End If
        gsRptArgs(5) = txtuserrep.Text
        gsRptArgs(6) = txtarticulo1.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SOLMATERIALES_RP.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "48"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtuserrep.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "106"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtarticulo1.Text = gLinea
            txtnomarticulo.Text = ARTICULOBL.SelectArt2(txtarticulo1.Text)
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub
    Private Sub txtarticulo1_LostFocus(sender As Object, e As EventArgs) Handles txtarticulo1.LostFocus
        If txtarticulo1.TextLength > 0 Then
            txtnomarticulo.Text = ARTICULOBL.SelectArt2(txtarticulo1.Text)
            'txtunidad.Text = ARTICULOBL.SelectUniMed(txtcodart.Text)
        Else
            txtarticulo1.Text = ""
            txtnomarticulo.Text = ""
            'txtunidad.Text = ""
        End If
    End Sub
End Class