Public Class FormRptDetEssalud
    Private Sub cmbaño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbaño.SelectedIndexChanged

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(0)
        If cmbmes1.SelectedIndex = 1 Then
            gsRptArgs(0) = cmbaño.Text + "01"
        ElseIf cmbmes1.SelectedIndex = 2 Then
            gsRptArgs(0) = cmbaño.Text + "02"
        ElseIf cmbmes1.SelectedIndex = 3 Then
            gsRptArgs(0) = cmbaño.Text + "03"
        ElseIf cmbmes1.SelectedIndex = 4 Then
            gsRptArgs(0) = cmbaño.Text + "04"
        ElseIf cmbmes1.SelectedIndex = 5 Then
            gsRptArgs(0) = cmbaño.Text + "05"
        ElseIf cmbmes1.SelectedIndex = 6 Then
            gsRptArgs(0) = cmbaño.Text + "06"
        ElseIf cmbmes1.SelectedIndex = 7 Then
            gsRptArgs(0) = cmbaño.Text + "07"
        ElseIf cmbmes1.SelectedIndex = 8 Then
            gsRptArgs(0) = cmbaño.Text + "08"
        ElseIf cmbmes1.SelectedIndex = 9 Then
            gsRptArgs(0) = cmbaño.Text + "09"
        ElseIf cmbmes1.SelectedIndex = 10 Then
            gsRptArgs(0) = cmbaño.Text + "10"
        ElseIf cmbmes1.SelectedIndex = 11 Then
            gsRptArgs(0) = cmbaño.Text + "11"
        ElseIf cmbmes1.SelectedIndex = 12 Then
            gsRptArgs(0) = cmbaño.Text + "12"
        End If

        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_DET_ESSALUD_SCTR_LIQ.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub cmbmes1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmes1.SelectedIndexChanged

    End Sub

    Private Sub FormRptDetEssalud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbaño.SelectedItem = sAño
        cmbmes1.SelectedIndex = Month(Date.Today)
    End Sub
End Class