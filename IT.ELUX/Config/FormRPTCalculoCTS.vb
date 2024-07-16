Public Class FormRPTCalculoCTS
    Private Sub FormRPTCalculoCTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If gsUser = "JMONTES" Or gsUser = "JFLORES" Then
            cmbsit1.Text = "Obrero"
            cmbsit2.Text = "Obrero"
            cmbsit1.Enabled = False
            cmbsit2.Enabled = False
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        If txtprdo1.Text > 162 Then
            ReDim gsRptArgs(6)
            gsRptArgs(0) = txtprdo1.Text
            If cmbmes1.SelectedIndex = 1 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "01"
            ElseIf cmbmes1.SelectedIndex = 2 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "02"
            ElseIf cmbmes1.SelectedIndex = 3 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "03"
            ElseIf cmbmes1.SelectedIndex = 4 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "04"
            ElseIf cmbmes1.SelectedIndex = 5 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "05"
            ElseIf cmbmes1.SelectedIndex = 6 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "06"
            ElseIf cmbmes1.SelectedIndex = 7 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "07"
            ElseIf cmbmes1.SelectedIndex = 8 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "08"
            ElseIf cmbmes1.SelectedIndex = 9 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "09"
            ElseIf cmbmes1.SelectedIndex = 10 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "10"
            ElseIf cmbmes1.SelectedIndex = 11 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "11"
            ElseIf cmbmes1.SelectedIndex = 12 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "12"
            End If
            If cmbmes2.SelectedIndex = 1 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "01"
            ElseIf cmbmes2.SelectedIndex = 2 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "02"
            ElseIf cmbmes2.SelectedIndex = 3 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "03"
            ElseIf cmbmes2.SelectedIndex = 4 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "04"
            ElseIf cmbmes2.SelectedIndex = 5 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "05"
            ElseIf cmbmes2.SelectedIndex = 6 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "06"
            ElseIf cmbmes2.SelectedIndex = 7 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "07"
            ElseIf cmbmes2.SelectedIndex = 8 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "08"
            ElseIf cmbmes2.SelectedIndex = 9 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "09"
            ElseIf cmbmes2.SelectedIndex = 10 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "10"
            ElseIf cmbmes2.SelectedIndex = 11 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "11"
            ElseIf cmbmes2.SelectedIndex = 12 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "12"
            End If
            gsRptArgs(3) = dtpfec1.Value.ToString("yyyy/MM/dd")
            If npdt_cmb.Value > 0 Then
                gsRptArgs(4) = npdt_cmb.Text
            End If

            If cmbsit1.Text = "Empleado" Then
                gsRptArgs(5) = "21"
            ElseIf cmbsit1.Text = "Obrero" Then
                gsRptArgs(5) = "20"
            End If
            If cmbsit2.Text = "Empleado" Then
                gsRptArgs(6) = "21"
            ElseIf cmbsit2.Text = "Obrero" Then
                gsRptArgs(6) = "20"
            End If


            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPT_CALCULOCTS.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        Else
            ReDim gsRptArgs(6)
            gsRptArgs(0) = txtprdo1.Text
            If cmbmes1.SelectedIndex = 1 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "01"
            ElseIf cmbmes1.SelectedIndex = 2 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "02"
            ElseIf cmbmes1.SelectedIndex = 3 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "03"
            ElseIf cmbmes1.SelectedIndex = 4 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "04"
            ElseIf cmbmes1.SelectedIndex = 5 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "05"
            ElseIf cmbmes1.SelectedIndex = 6 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "06"
            ElseIf cmbmes1.SelectedIndex = 7 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "07"
            ElseIf cmbmes1.SelectedIndex = 8 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "08"
            ElseIf cmbmes1.SelectedIndex = 9 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "09"
            ElseIf cmbmes1.SelectedIndex = 10 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "10"
            ElseIf cmbmes1.SelectedIndex = 11 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "11"
            ElseIf cmbmes1.SelectedIndex = 12 Then
                gsRptArgs(1) = cmbaño.Text & "/" & "12"
            End If
            If cmbmes2.SelectedIndex = 1 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "01"
            ElseIf cmbmes2.SelectedIndex = 2 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "02"
            ElseIf cmbmes2.SelectedIndex = 3 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "03"
            ElseIf cmbmes2.SelectedIndex = 4 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "04"
            ElseIf cmbmes2.SelectedIndex = 5 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "05"
            ElseIf cmbmes2.SelectedIndex = 6 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "06"
            ElseIf cmbmes2.SelectedIndex = 7 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "07"
            ElseIf cmbmes2.SelectedIndex = 8 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "08"
            ElseIf cmbmes2.SelectedIndex = 9 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "09"
            ElseIf cmbmes2.SelectedIndex = 10 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "10"
            ElseIf cmbmes2.SelectedIndex = 11 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "11"
            ElseIf cmbmes2.SelectedIndex = 12 Then
                gsRptArgs(2) = cmbaño2.Text & "/" & "12"
            End If
            'MsgBox(dtpfec1.Value.ToString("yyyy/MM/dd"))
            gsRptArgs(3) = dtpfec1.Value.ToString("yyyy/MM/dd")
            If npdt_cmb.Value > 0 Then
                gsRptArgs(4) = npdt_cmb.Text
                'Else
                '    gsRptArgs(4) = Nothing
            End If

            If cmbsit1.Text = "Empleado" Then
                gsRptArgs(5) = "21"
            ElseIf cmbsit1.Text = "Obrero" Then
                gsRptArgs(5) = "20"
            End If
            If cmbsit2.Text = "Empleado" Then
                gsRptArgs(6) = "21"
            ElseIf cmbsit2.Text = "Obrero" Then
                gsRptArgs(6) = "20"
            End If


            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPT_CALCULOCTS1.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()

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