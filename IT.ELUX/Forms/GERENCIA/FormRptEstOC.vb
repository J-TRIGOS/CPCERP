Public Class FormRptEstOC
    Private Sub FormRptEstOC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Estado de Ordenes de Compra"
        Dim mes = Today.ToString("MM")
        cmbAnho.Text = Today.ToString("yyyy")
        Select Case mes
            Case "01"
                cmbMes.SelectedIndex = 0
            Case "02"
                cmbMes.SelectedIndex = 1
            Case "03"
                cmbMes.SelectedIndex = 2
            Case "04"
                cmbMes.SelectedIndex = 3
            Case "05"
                cmbMes.SelectedIndex = 4
            Case "06"
                cmbMes.SelectedIndex = 5
            Case "07"
                cmbMes.SelectedIndex = 6
            Case "08"
                cmbMes.SelectedIndex = 7
            Case "09"
                cmbMes.SelectedIndex = 8
            Case "10"
                cmbMes.SelectedIndex = 9
            Case "11"
                cmbMes.SelectedIndex = 10
            Case "12"
                cmbMes.SelectedIndex = 11
        End Select
    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        sBusAlm = "98"

        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If (gLinea <> Nothing And gSubLinea <> Nothing) Then
            txt_ctctcod.Text = gLinea
            txt_ctctnom.Text = gSubLinea
        End If
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        gsRptArgs = {}
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(4)
        Select Case cmbMes.SelectedIndex
            Case 0
                gsRptArgs(0) = "01"
            Case 1
                gsRptArgs(0) = "02"
            Case 2
                gsRptArgs(0) = "03"
            Case 3
                gsRptArgs(0) = "04"
            Case 4
                gsRptArgs(0) = "05"
            Case 5
                gsRptArgs(0) = "06"
            Case 6
                gsRptArgs(0) = "07"
            Case 7
                gsRptArgs(0) = "08"
            Case 8
                gsRptArgs(0) = "09"
            Case 9
                gsRptArgs(0) = "10"
            Case 10
                gsRptArgs(0) = "11"
            Case 11
                gsRptArgs(0) = "12"
        End Select

        gsRptArgs(1) = cmbAnho.Text
        gsRptArgs(2) = ""
        gsRptArgs(3) = txt_ctctcod.Text
        Select Case cmbEstado.SelectedIndex
            Case 0
                gsRptArgs(4) = ""
            Case 1
                gsRptArgs(4) = "A"
            Case 2
                gsRptArgs(4) = "P"
            Case 3
                gsRptArgs(4) = "D"
        End Select
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_APROBACION_OC.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class