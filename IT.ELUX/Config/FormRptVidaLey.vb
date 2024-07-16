Public Class FormRptVidaLey
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click

        Cursor.Current = Cursors.WaitCursor
            ReDim gsRptArgs(1)
            gsRptArgs(0) = txtprdo1.Text
            If cmbsit1.Text = "Empleado" Then
                gsRptArgs(1) = "21"
            ElseIf cmbsit1.Text = "Obrero" Then
                gsRptArgs(1) = "20"
            End If
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_VIDA_LEY.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()

    End Sub

    Private Sub FormRptVidaLey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If gsUser = "JMONTES" Or gsUser = "JFLORES" Then
            cmbsit1.Text = "Obrero"
            cmbsit1.Enabled = False
        End If
    End Sub
End Class