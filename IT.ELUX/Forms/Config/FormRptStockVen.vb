Public Class FormRptStockVen
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(0)

        If CheckBox1.Checked Then
            gsRptArgs(0) = "0218"
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_EL_TBARTSTOCK_T_ENVART.rpt"
        Else
            gsRptArgs(0) = txtvend.Text

            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_EL_TBARTSTOCK_T_ENVVEN.rpt"
        End If
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sBusAlm = "41"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtvend.Text = gLinea
            txtnom_ven.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub FormRptStockVen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Stock Vendedor"
    End Sub

    Private Sub txtvend_LostFocus(sender As Object, e As EventArgs) Handles txtvend.LostFocus
        If txtvend.Text = "" Then
            txtnom_ven.Text = ""
        End If
    End Sub
End Class