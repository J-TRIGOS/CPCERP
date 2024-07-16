Imports IT.ELUX.BL

Public Class FormConsumoPersonal

    Private primero As Boolean
    Private primero2 As Boolean
    Dim REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private ARTICULOBL As New ARTICULOBL

    Private Sub FormConsumoPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Me.Text = "CONSUMO PERSONAL"
        dt = REQUERIMIENTOBL.SelectPer()
        GetCmb("cod", "nombre", dt, cmbdni)
        cmbdni.SelectedIndex = -1

        dt = REQUERIMIENTOBL.SelectCCosto()
        GetCmb("cod", "nom", dt, cmbCco)
        cmbdni.SelectedIndex = -1

        primero = True
        primero2 = True

        Me.Text = "Indice de Costos por Artículo"
        dt = ARTICULOBL.SelectDescripcion()
        GetCmb("lin_codigo", "lin_descri", dt, cmbLineas)

        primero = False
        primero2 = False
        Dim fechainicio As New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        dtpFecIni.Value = fechainicio

    End Sub

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "228"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtPersonal.Text = gLinea
            cmbdni.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub cmbdni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdni.SelectedIndexChanged
        If cmbdni.SelectedIndex = 0 Then
            Exit Sub
        End If
        txtPersonal.Text = cmbdni.SelectedValue
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        sBusAlm = "228"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtPersonal.Text = gLinea
            cmbdni.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub bntReporte_Click(sender As Object, e As EventArgs) Handles bntReporte.Click
        ReDim gsRptArgs(5)
        If txtPersonal.Text = "" Then
            MsgBox("Ingrese Codigo de Personal")
            Exit Sub
        End If
        gsRptArgs(0) = txtPersonal.Text
        gsRptArgs(1) = cmbCco.SelectedValue
        gsRptArgs(2) = cmbSublineas.SelectedValue
        gsRptArgs(3) = txtcodart.Text
        gsRptArgs(4) = dtpFecIni.Value.ToString("dd/MM/yyyy")
        gsRptArgs(5) = dtpFecFin.Value.ToString("dd/MM/yyyy")
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SOLMAT_X_USUARIO.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()

    End Sub

    Private Sub cmbSublineas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSublineas.SelectedIndexChanged
        'change subline
        If primero Then Exit Sub
        Dim sCode As String = cmbSublineas.SelectedValue
        Dim dt As New DataTable
        primero = True
        dt = ARTICULOBL.SelectAll(sCode)
        If dt.Rows.Count > 0 Then
            GetCmb("COD", "ARTICULO", dt, cmbArticulo)
        Else
            MsgBox("La Sublinea no tiene articulos")
            'For i = 0 To cmbart.Items.Count - 1
            cmbArticulo.DataSource = Nothing
            'Next
            'cmbart.Refresh()
        End If
        primero = False
    End Sub

    Private Sub cmbLineas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLineas.SelectedIndexChanged
        'change line
        If primero Then Exit Sub
        '    primero = True
        Dim sCode As String = Mid(cmbLineas.SelectedValue, 1, 2)
        Dim dt As New DataTable
        primero = True
        dt = ARTICULOBL.SelectDescripcion1(sCode)
        GetCmb("lin_codigo", "lin_descri", dt, cmbSublineas)
        primero = False
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        sBusAlm = "3"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            cmbLineas.SelectedValue = gLinea
            cmbSublineas.SelectedValue = gSubLinea
            cmbArticulo.SelectedValue = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub cmbArticulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbArticulo.SelectedIndexChanged
        If primero Then Exit Sub
        txtcodart.Text = cmbArticulo.SelectedValue
    End Sub

    Private Sub FormConsumoPersonal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub
End Class