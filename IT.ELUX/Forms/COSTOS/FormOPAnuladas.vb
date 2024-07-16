Public Class FormOPAnuladas
    Private Sub FormOPAnuladas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "OP's Anuladas con Movimiento"
        cmbMes.SelectedIndex = 0
        cmbMes.SelectedIndex = 0
        cmbAnho.Text = Today.Year
        Select Case Today.Month
            Case 1
                cmbMes.SelectedIndex = 1
            Case 2
                cmbMes.SelectedIndex = 2
            Case 3
                cmbMes.SelectedIndex = 3
            Case 4
                cmbMes.SelectedIndex = 4
            Case 5
                cmbMes.SelectedIndex = 5
            Case 6
                cmbMes.SelectedIndex = 6
            Case 7
                cmbMes.SelectedIndex = 7
            Case 8
                cmbMes.SelectedIndex = 8
            Case 9
                cmbMes.SelectedIndex = 9
            Case 10
                cmbMes.SelectedIndex = 10
            Case 11
                cmbMes.SelectedIndex = 11
            Case 12
                cmbMes.SelectedIndex = 12
        End Select
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim mes
        Dim estado
        Select Case cmbEstado.SelectedIndex
            Case 0
                estado = "A"
        End Select
        Select Case cmbMes.SelectedIndex
            Case 1
                mes = "01"
            Case 2
                mes = "02"
            Case 3
                mes = "03"
            Case 4
                mes = "04"
            Case 5
                mes = "05"
            Case 6
                mes = "06"
            Case 7
                mes = "07"
            Case 8
                mes = "08"
            Case 9
                mes = "09"
            Case 10
                mes = "10"
            Case 11
                mes = "11"
            Case 12
                mes = "12"
            Case Else
                mes = ""
        End Select
        ReDim gsRptArgs(7)
        gsRptArgs(0) = ""
        gsRptArgs(1) = mes
        gsRptArgs(2) = cmbAnho.Text
        gsRptArgs(3) = ""
        gsRptArgs(4) = ""
        gsRptArgs(5) = ""
        gsRptArgs(6) = ""
        gsRptArgs(7) = estado
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTSEGPROD_NUEVO.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class