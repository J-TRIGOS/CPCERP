Public Class FormReporteBindCard

    Private Sub FormReporteBindCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Reporte BindCard"


    End Sub

    'Private Sub txtnumero_LostFocus(sender As Object, e As EventArgs) Handles txtnumero.LostFocus
    '    If txtnumero.TextLength = 0 Then
    '        txtnumero.Text = ""
    '    Else
    '        txtnumero.Text = txtnumero.Text.PadLeft(9, "0")
    '    End If
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "106"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtcodart.Text = gLinea
            txtnomart.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub FormReporteBindCard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        ReDim gsRptArgs(2)
        gsRptArgs(0) = txtnumero.Text
        gsRptArgs(1) = txtcodart.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_REPORTE_BINDCARD.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
        Dispose()
    End Sub
End Class