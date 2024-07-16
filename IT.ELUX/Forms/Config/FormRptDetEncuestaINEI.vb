Public Class FormRptDetEncuestaINEI
    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(0)
        If gsCode10 = "1" Then 'detallado
            gsRptArgs(0) = cmbaño.Text
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTENCUESTADETINEI.rpt"
        ElseIf gsCode10 = "2" Then 'resumen
            gsRptArgs(0) = cmbaño.Text
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ESTADISTICO_PER.rpt"
        End If

        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub FormRptDetEncuestaINEI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub
End Class