Public Class FormRPTFLUJOEFECTIVO
    Private Sub FormRPTFLUJOEFECTIVO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Flujo Efectivo"
        cmbaño.SelectedItem = sAño
        cmbaño1.SelectedItem = sAño
        cmbaño2.SelectedItem = sAño
        cmbaño3.SelectedItem = sAño
        cmbmes1.SelectedItem = "Enero"
        cmbmes2.SelectedIndex = Month(Date.Today)
        cmbmes3.SelectedItem = "Enero"
        cmbmes4.SelectedIndex = Month(Date.Today)
        cmbmes5.SelectedItem = "Enero"
        cmbmes6.SelectedIndex = Month(Date.Today)
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(0)
        gsRptArgs(0) = cmbaño.SelectedItem
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_FLUJO_EFCTVO.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReDim gsRptArgs(2)
        gsRptArgs(0) = cmbaño1.Text
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
        If cmbmes2.SelectedIndex = 1 Then
            gsRptArgs(2) = "01"
        ElseIf cmbmes2.SelectedIndex = 2 Then
            gsRptArgs(2) = "02"
        ElseIf cmbmes2.SelectedIndex = 3 Then
            gsRptArgs(2) = "03"
        ElseIf cmbmes2.SelectedIndex = 4 Then
            gsRptArgs(2) = "04"
        ElseIf cmbmes2.SelectedIndex = 5 Then
            gsRptArgs(2) = "05"
        ElseIf cmbmes2.SelectedIndex = 6 Then
            gsRptArgs(2) = "06"
        ElseIf cmbmes2.SelectedIndex = 7 Then
            gsRptArgs(2) = "07"
        ElseIf cmbmes2.SelectedIndex = 8 Then
            gsRptArgs(2) = "08"
        ElseIf cmbmes2.SelectedIndex = 9 Then
            gsRptArgs(2) = "09"
        ElseIf cmbmes2.SelectedIndex = 10 Then
            gsRptArgs(2) = "10"
        ElseIf cmbmes2.SelectedIndex = 11 Then
            gsRptArgs(2) = "11"
        ElseIf cmbmes2.SelectedIndex = 12 Then
            gsRptArgs(2) = "12"
        End If
        'gsRptArgs(2) = txtcliente1.Text
        'gsRptArgs(3) = txtcliente2.Text

        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_FLUJO_EFECTIVO.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ReDim gsRptArgs(2)
        gsRptArgs(0) = cmbaño2.Text
        If cmbmes3.SelectedIndex = 1 Then
            gsRptArgs(1) = "01"
        ElseIf cmbmes3.SelectedIndex = 2 Then
            gsRptArgs(1) = "02"
        ElseIf cmbmes3.SelectedIndex = 3 Then
            gsRptArgs(1) = "03"
        ElseIf cmbmes3.SelectedIndex = 4 Then
            gsRptArgs(1) = "04"
        ElseIf cmbmes3.SelectedIndex = 5 Then
            gsRptArgs(1) = "05"
        ElseIf cmbmes3.SelectedIndex = 6 Then
            gsRptArgs(1) = "06"
        ElseIf cmbmes3.SelectedIndex = 7 Then
            gsRptArgs(1) = "07"
        ElseIf cmbmes3.SelectedIndex = 8 Then
            gsRptArgs(1) = "08"
        ElseIf cmbmes3.SelectedIndex = 9 Then
            gsRptArgs(1) = "09"
        ElseIf cmbmes3.SelectedIndex = 10 Then
            gsRptArgs(1) = "10"
        ElseIf cmbmes3.SelectedIndex = 11 Then
            gsRptArgs(1) = "11"
        ElseIf cmbmes3.SelectedIndex = 12 Then
            gsRptArgs(1) = "12"
        End If
        If cmbmes4.SelectedIndex = 1 Then
            gsRptArgs(2) = "01"
        ElseIf cmbmes4.SelectedIndex = 2 Then
            gsRptArgs(2) = "02"
        ElseIf cmbmes4.SelectedIndex = 3 Then
            gsRptArgs(2) = "03"
        ElseIf cmbmes4.SelectedIndex = 4 Then
            gsRptArgs(2) = "04"
        ElseIf cmbmes4.SelectedIndex = 5 Then
            gsRptArgs(2) = "05"
        ElseIf cmbmes4.SelectedIndex = 6 Then
            gsRptArgs(2) = "06"
        ElseIf cmbmes4.SelectedIndex = 7 Then
            gsRptArgs(2) = "07"
        ElseIf cmbmes4.SelectedIndex = 8 Then
            gsRptArgs(2) = "08"
        ElseIf cmbmes4.SelectedIndex = 9 Then
            gsRptArgs(2) = "09"
        ElseIf cmbmes4.SelectedIndex = 10 Then
            gsRptArgs(2) = "10"
        ElseIf cmbmes4.SelectedIndex = 11 Then
            gsRptArgs(2) = "11"
        ElseIf cmbmes4.SelectedIndex = 12 Then
            gsRptArgs(2) = "12"
        End If
        'gsRptArgs(2) = txtcliente1.Text
        'gsRptArgs(3) = txtcliente2.Text

        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_FLUJO_EFECTIVOVER.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dispose()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ReDim gsRptArgs(2)
        gsRptArgs(0) = cmbaño3.SelectedItem
        If cmbmes5.SelectedIndex = 1 Then
            gsRptArgs(1) = "01"
        ElseIf cmbmes5.SelectedIndex = 2 Then
            gsRptArgs(1) = "02"
        ElseIf cmbmes5.SelectedIndex = 3 Then
            gsRptArgs(1) = "03"
        ElseIf cmbmes5.SelectedIndex = 4 Then
            gsRptArgs(1) = "04"
        ElseIf cmbmes5.SelectedIndex = 5 Then
            gsRptArgs(1) = "05"
        ElseIf cmbmes5.SelectedIndex = 6 Then
            gsRptArgs(1) = "06"
        ElseIf cmbmes5.SelectedIndex = 7 Then
            gsRptArgs(1) = "07"
        ElseIf cmbmes5.SelectedIndex = 8 Then
            gsRptArgs(1) = "08"
        ElseIf cmbmes5.SelectedIndex = 9 Then
            gsRptArgs(1) = "09"
        ElseIf cmbmes5.SelectedIndex = 10 Then
            gsRptArgs(1) = "10"
        ElseIf cmbmes5.SelectedIndex = 11 Then
            gsRptArgs(1) = "11"
        ElseIf cmbmes5.SelectedIndex = 12 Then
            gsRptArgs(1) = "12"
        End If
        If cmbmes6.SelectedIndex = 1 Then
            gsRptArgs(2) = "01"
        ElseIf cmbmes6.SelectedIndex = 2 Then
            gsRptArgs(2) = "02"
        ElseIf cmbmes6.SelectedIndex = 3 Then
            gsRptArgs(2) = "03"
        ElseIf cmbmes6.SelectedIndex = 4 Then
            gsRptArgs(2) = "04"
        ElseIf cmbmes6.SelectedIndex = 5 Then
            gsRptArgs(2) = "05"
        ElseIf cmbmes6.SelectedIndex = 6 Then
            gsRptArgs(2) = "06"
        ElseIf cmbmes6.SelectedIndex = 7 Then
            gsRptArgs(2) = "07"
        ElseIf cmbmes6.SelectedIndex = 8 Then
            gsRptArgs(2) = "08"
        ElseIf cmbmes6.SelectedIndex = 9 Then
            gsRptArgs(2) = "09"
        ElseIf cmbmes6.SelectedIndex = 10 Then
            gsRptArgs(2) = "10"
        ElseIf cmbmes6.SelectedIndex = 11 Then
            gsRptArgs(2) = "11"
        ElseIf cmbmes6.SelectedIndex = 12 Then
            gsRptArgs(2) = "12"
        End If
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_FLUJO_EFCTVODET.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class