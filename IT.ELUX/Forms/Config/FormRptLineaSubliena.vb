Imports IT.ELUX.BL
Public Class FormRptLineaSubliena
    Dim ARTICULOBL As New ARTICULOBL
    Private bFirst As Boolean
#Region "Cargar Combos"

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

    Private Sub FormRptLineaSubliena_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Reporte Linea y Sublineas"
        Dim dt As DataTable
        bFirst = False
        dt = ARTICULOBL.SelectDescripcion()
        GetCmb("LIN_CODIGO", "LIN_DESCRI", dt, cmblinea)
        cmbalmacen.SelectedIndex = 0
    End Sub

    Private Sub cmblinea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmblinea.SelectedIndexChanged
        If Not bFirst Then
            If cmblinea.SelectedIndex <> -1 Then
                On Error Resume Next
                Dim dt2 As DataTable
                dt2 = ARTICULOBL.SelectDescripcion1(cmblinea.SelectedValue.ToString)
                GetCmb("LIN_CODIGO", "LIN_DESCRI", dt2, cmbsublinea)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        If gsUser = "JTUCNO" Or gsUser = "BROJAS" Then
            gsRptArgs = {}
            'ReDim gsRptArgs()
            'gsRptArgs(0) = cmbsublinea.SelectedValue
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ART_SEL_SUBLINEA2.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        ElseIf Mid(cmbalmacen.Text, 1, 4) = "0003" Then
            If chking.Checked Then
                gsRptArgs = {}
                ReDim gsRptArgs(0)
                gsRptArgs(0) = cmbsublinea.SelectedValue
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ART_SEL_SUBLINEADIG.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Else
                gsRptArgs = {}
                ReDim gsRptArgs(0)
                gsRptArgs(0) = cmbsublinea.SelectedValue
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ART_SEL_SUBLINEA.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            End If

        Else
            If chking.Checked Then
                gsRptArgs = {}
                ReDim gsRptArgs(0)
                gsRptArgs(0) = cmbsublinea.SelectedValue
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ART_SEL_SUBLINEA1DI.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Else
                gsRptArgs = {}
                ReDim gsRptArgs(0)
                gsRptArgs(0) = cmbsublinea.SelectedValue
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ART_SEL_SUBLINEA1.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            End If

        End If

    End Sub
End Class