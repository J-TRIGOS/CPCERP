Public Class FormRptAfiliaAFP
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRptAfiliaAFP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Reporte Afiliacion AFP"
        cmbaño.SelectedItem = sAño
        cmbmes1.SelectedIndex = Month(Date.Today)
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(1)
        gsRptArgs(0) = cmbaño.Text
        If cmbmes1.SelectedIndex = 1 Then
            gsRptArgs(1) = "01"
        ElseIf cmbmes1.SelectedIndex = 2 Then
            gsRptArgs(1) = "02"
        ElseIf cmbmes1.SelectedIndex = 3 Then
            gsRptArgs(1) = "03"
        ElseIf cmbmes1.SelectedIndex = 4 Then
            gsRptArgs(1) = "04"
        ElseIf cmbmes1.SelectedIndex = 5 Then
            gsRptArgs(1) = "05"
        ElseIf cmbmes1.SelectedIndex = 6 Then
            gsRptArgs(1) = "06"
        ElseIf cmbmes1.SelectedIndex = 7 Then
            gsRptArgs(1) = "07"
        ElseIf cmbmes1.SelectedIndex = 8 Then
            gsRptArgs(1) = "08"
        ElseIf cmbmes1.SelectedIndex = 9 Then
            gsRptArgs(1) = "09"
        ElseIf cmbmes1.SelectedIndex = 10 Then
            gsRptArgs(1) = "10"
        ElseIf cmbmes1.SelectedIndex = 11 Then
            gsRptArgs(1) = "11"
        ElseIf cmbmes1.SelectedIndex = 12 Then
            gsRptArgs(1) = "12"
        End If
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_AFILIA_AFP.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class