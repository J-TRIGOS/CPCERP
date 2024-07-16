Imports System.ComponentModel
Imports IT.ELUX.BL


Public Class FormMovim

    Private primero As Boolean
    Private primero2 As Boolean
    Private ARTICULOBL As New ARTICULOBL
    Private ELTBLINESBL As New ELTBLINESBL


    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

    Private Sub FormMovim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        primero = True
        primero2 = True

        dtpFecIni.Value = "01/01/" + Year(Date.Now).ToString

        Dim dt As New DataTable
        dt = ARTICULOBL.SelectDescripcion()
        GetCmb("lin_codigo", "lin_descri", dt, cmbLineas)
        ' GetCmb("lin_codigo", "lin_descri", dt, cmbLineas)

        primero = False
        primero2 = False
        cmbalmacen.SelectedIndex = 0
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

    Private Sub cmbSublineas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSublineas.SelectedIndexChanged
        'change subline
        If primero Then Exit Sub

        Dim sCode As String = cmbSublineas.SelectedValue
        Dim dt As New DataTable

        primero = True
        dt = ARTICULOBL.SelectAll(sCode)
        If dt.Rows.Count > 0 Then
            GetCmb("COD", "art_descri", dt, cmbArticulo)

        Else
            MsgBox("La Sublinea no tiene articulos")
            'For i = 0 To cmbart.Items.Count - 1
            cmbArticulo.DataSource = Nothing
            'Next
            'cmbart.Refresh()
        End If

        primero = False
    End Sub

    Private Sub cmbArticulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbArticulo.SelectedIndexChanged
        If primero Then Exit Sub
        txtcodart.Text = cmbArticulo.SelectedValue
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If cmbArticulo.SelectedIndex = -1 And cmbSublineas.SelectedIndex = -1 Then
            MsgBox("Seleccione un articulo, para procesar")
            Exit Sub
        End If
        'reporte
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_MOVIM_CODART.rpt"

        Dim dDate1 As Date = Nothing
        Dim dDate2 As Date = Nothing


        dDate1 = dtpFecIni.Value
        dDate2 = dtpFecFin.Value

        ReDim gsRptArgs(4)
        gsRptArgs(0) = Mid(dtpFecFin.Value, 7, 4)

        gsRptArgs(1) = txtcodart.Text

        gsRptArgs(2) = dDate1
        gsRptArgs(3) = dDate2
        gsRptArgs(4) = Mid(cmbalmacen.Text, 1, 4)


        gsRptPath = gsPathRpt
        FormReportes.Show()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dispose()
    End Sub

    Private Sub txtcodart_LostFocus(sender As Object, e As EventArgs) Handles txtcodart.LostFocus


    End Sub

    Private Sub txtcodart_Validated(sender As Object, e As EventArgs) Handles txtcodart.Validated
        If primero2 Then Exit Sub
        'buscar articulo

        cmbLineas.SelectedValue = Mid(txtcodart.Text, 1, 2) + "00"

        If cmbLineas.SelectedValue = "" Then
            Exit Sub
        End If

        cmbSublineas.SelectedValue = Mid(txtcodart.Text, 1, 4)

        If cmbSublineas.SelectedValue = "" Then
            Exit Sub
        End If

        cmbArticulo.SelectedValue = txtcodart.Text
        ' cmbLineas_SelectedIndexChanged(Nothing, Nothing)
        gsCode = gsCode
        '
        'cmbSublineas_SelectedIndexChanged(Nothing, Nothing)
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

    Private Sub FormMovim_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub


End Class