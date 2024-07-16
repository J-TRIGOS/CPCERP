Public Class FormRptLibroMayor
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dispose()
    End Sub

    Private Sub FormRptLibroMayor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbaño.SelectedItem = sAño
        cmbaño2.SelectedItem = sAño

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If cmbmes1.SelectedIndex < 1 And cmbmes2.SelectedIndex < 1 Then
            MsgBox("Seleccione el mes")
            Exit Sub
        End If
        If chkacum.Checked = True Then
            ReDim gsRptArgs(7)
            gsRptArgs(0) = cmbaño.SelectedItem
            gsRptArgs(1) = cmbaño2.SelectedItem
            If cmbmes1.SelectedIndex = 1 Then
                gsRptArgs(2) = "01"
            ElseIf cmbmes1.SelectedIndex = 2 Then
                gsRptArgs(2) = "02"
            ElseIf cmbmes1.SelectedIndex = 3 Then
                gsRptArgs(2) = "03"
            ElseIf cmbmes1.SelectedIndex = 4 Then
                gsRptArgs(2) = "04"
            ElseIf cmbmes1.SelectedIndex = 5 Then
                gsRptArgs(2) = "05"
            ElseIf cmbmes1.SelectedIndex = 6 Then
                gsRptArgs(2) = "06"
            ElseIf cmbmes1.SelectedIndex = 7 Then
                gsRptArgs(2) = "07"
            ElseIf cmbmes1.SelectedIndex = 8 Then
                gsRptArgs(2) = "08"
            ElseIf cmbmes1.SelectedIndex = 9 Then
                gsRptArgs(2) = "09"
            ElseIf cmbmes1.SelectedIndex = 10 Then
                gsRptArgs(2) = "10"
            ElseIf cmbmes1.SelectedIndex = 11 Then
                gsRptArgs(2) = "11"
            ElseIf cmbmes1.SelectedIndex = 12 Then
                gsRptArgs(2) = "12"
            Else
                gsRptArgs(2) = "00"
            End If
            If cmbmes2.SelectedIndex = 1 Then
                gsRptArgs(3) = "01"
            ElseIf cmbmes2.SelectedIndex = 2 Then
                gsRptArgs(3) = "02"
            ElseIf cmbmes2.SelectedIndex = 3 Then
                gsRptArgs(3) = "03"
            ElseIf cmbmes2.SelectedIndex = 4 Then
                gsRptArgs(3) = "04"
            ElseIf cmbmes2.SelectedIndex = 5 Then
                gsRptArgs(3) = "05"
            ElseIf cmbmes2.SelectedIndex = 6 Then
                gsRptArgs(3) = "06"
            ElseIf cmbmes2.SelectedIndex = 7 Then
                gsRptArgs(3) = "07"
            ElseIf cmbmes2.SelectedIndex = 8 Then
                gsRptArgs(3) = "08"
            ElseIf cmbmes2.SelectedIndex = 9 Then
                gsRptArgs(3) = "09"
            ElseIf cmbmes2.SelectedIndex = 10 Then
                gsRptArgs(3) = "10"
            ElseIf cmbmes2.SelectedIndex = 11 Then
                gsRptArgs(3) = "11"
            ElseIf cmbmes2.SelectedIndex = 12 Then
                gsRptArgs(3) = "12"
            Else
                gsRptArgs(3) = "00"
            End If
            gsRptArgs(4) = txtcta.Text
            gsRptArgs(5) = txtcta2.Text
            gsRptArgs(6) = txttope.Text
            gsRptArgs(7) = txttope2.Text
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_LIBRO_MAYOR_SINACUM.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        Else
            ReDim gsRptArgs(7)
            gsRptArgs(0) = cmbaño.SelectedItem
            gsRptArgs(1) = cmbaño2.SelectedItem
            If cmbmes1.SelectedIndex = 1 Then
                gsRptArgs(2) = "01"
            ElseIf cmbmes1.SelectedIndex = 2 Then
                gsRptArgs(2) = "02"
            ElseIf cmbmes1.SelectedIndex = 3 Then
                gsRptArgs(2) = "03"
            ElseIf cmbmes1.SelectedIndex = 4 Then
                gsRptArgs(2) = "04"
            ElseIf cmbmes1.SelectedIndex = 5 Then
                gsRptArgs(2) = "05"
            ElseIf cmbmes1.SelectedIndex = 6 Then
                gsRptArgs(2) = "06"
            ElseIf cmbmes1.SelectedIndex = 7 Then
                gsRptArgs(2) = "07"
            ElseIf cmbmes1.SelectedIndex = 8 Then
                gsRptArgs(2) = "08"
            ElseIf cmbmes1.SelectedIndex = 9 Then
                gsRptArgs(2) = "09"
            ElseIf cmbmes1.SelectedIndex = 10 Then
                gsRptArgs(2) = "10"
            ElseIf cmbmes1.SelectedIndex = 11 Then
                gsRptArgs(2) = "11"
            ElseIf cmbmes1.SelectedIndex = 12 Then
                gsRptArgs(2) = "12"
            Else
                gsRptArgs(2) = "00"
            End If
            If cmbmes2.SelectedIndex = 1 Then
                gsRptArgs(3) = "01"
            ElseIf cmbmes2.SelectedIndex = 2 Then
                gsRptArgs(3) = "02"
            ElseIf cmbmes2.SelectedIndex = 3 Then
                gsRptArgs(3) = "03"
            ElseIf cmbmes2.SelectedIndex = 4 Then
                gsRptArgs(3) = "04"
            ElseIf cmbmes2.SelectedIndex = 5 Then
                gsRptArgs(3) = "05"
            ElseIf cmbmes2.SelectedIndex = 6 Then
                gsRptArgs(3) = "06"
            ElseIf cmbmes2.SelectedIndex = 7 Then
                gsRptArgs(3) = "07"
            ElseIf cmbmes2.SelectedIndex = 8 Then
                gsRptArgs(3) = "08"
            ElseIf cmbmes2.SelectedIndex = 9 Then
                gsRptArgs(3) = "09"
            ElseIf cmbmes2.SelectedIndex = 10 Then
                gsRptArgs(3) = "10"
            ElseIf cmbmes2.SelectedIndex = 11 Then
                gsRptArgs(3) = "11"
            ElseIf cmbmes2.SelectedIndex = 12 Then
                gsRptArgs(3) = "12"
            Else
                gsRptArgs(3) = "00"
            End If
            gsRptArgs(4) = txtcta.Text
            gsRptArgs(5) = txtcta2.Text
            gsRptArgs(6) = txttope.Text
            gsRptArgs(7) = txttope2.Text
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_LIBRO_MAYOR.rpt"
            gsRptPath = gsPathRpt




            FormReportes.ShowDialog()
        End If

    End Sub
End Class