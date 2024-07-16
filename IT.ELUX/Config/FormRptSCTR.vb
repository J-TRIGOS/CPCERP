Public Class FormRptSCTR
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        Cursor.Current = Cursors.WaitCursor
        ReDim gsRptArgs(2)
        gsRptArgs(0) = txtprdo1.Text
        If cmbsit1.Text = "Empleado" Then
            gsRptArgs(1) = "21"
        ElseIf cmbsit1.Text = "Obrero" Then
            gsRptArgs(1) = "20"
        End If
        If cmbsit2.Text = "Empleado" Then
            gsRptArgs(2) = "21"
        ElseIf cmbsit2.Text = "Obrero" Then
            gsRptArgs(2) = "20"
        End If
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SCTR.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub FormRptSCTR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If gsUser = "JMONTES" Or gsUser = "JFLORES" Then
            cmbsit1.Text = "Obrero"
            cmbsit2.Text = "Obrero"
            cmbsit1.Enabled = False
            cmbsit2.Enabled = False
        End If
    End Sub

    Private Sub txtprdo1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprdo1.KeyDown

        If e.KeyValue = Keys.F9 Then
                sBusAlm = "86"
                Dim frm As New FormBUSQUEDA
                frm.ShowDialog()
                If gLinea <> Nothing And gSubLinea <> Nothing Then
                    txtprdo1.Text = gLinea

                gLinea = Nothing
                    gSubLinea = Nothing
                    gArt = Nothing
                Else
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gArt = Nothing
                End If
                e.Handled = True
            End If

    End Sub
End Class