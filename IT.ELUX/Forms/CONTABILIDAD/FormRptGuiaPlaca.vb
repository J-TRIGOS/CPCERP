Public Class FormRptGuiaPlaca
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(3)
        If cmbmes1.SelectedIndex = 0 Then
            gsRptArgs(0) = cmbaño.Text + "01"
        ElseIf cmbmes1.SelectedIndex = 1 Then
            gsRptArgs(0) = cmbaño.Text + "02"
        ElseIf cmbmes1.SelectedIndex = 2 Then
            gsRptArgs(0) = cmbaño.Text + "03"
        ElseIf cmbmes1.SelectedIndex = 3 Then
            gsRptArgs(0) = cmbaño.Text + "04"
        ElseIf cmbmes1.SelectedIndex = 4 Then
            gsRptArgs(0) = cmbaño.Text + "05"
        ElseIf cmbmes1.SelectedIndex = 5 Then
            gsRptArgs(0) = cmbaño.Text + "06"
        ElseIf cmbmes1.SelectedIndex = 6 Then
            gsRptArgs(0) = cmbaño.Text + "07"
        ElseIf cmbmes1.SelectedIndex = 7 Then
            gsRptArgs(0) = cmbaño.Text + "08"
        ElseIf cmbmes1.SelectedIndex = 8 Then
            gsRptArgs(0) = cmbaño.Text + "09"
        ElseIf cmbmes1.SelectedIndex = 9 Then
            gsRptArgs(0) = cmbaño.Text + "10"
        ElseIf cmbmes1.SelectedIndex = 10 Then
            gsRptArgs(0) = cmbaño.Text + "11"
        ElseIf cmbmes1.SelectedIndex = 11 Then
            gsRptArgs(0) = cmbaño.Text + "12"
        End If
        If cmbmes2.SelectedIndex = 0 Then
            gsRptArgs(1) = cmbaño2.Text + "01"
        ElseIf cmbmes2.SelectedIndex = 1 Then
            gsRptArgs(1) = cmbaño2.Text + "02"
        ElseIf cmbmes2.SelectedIndex = 2 Then
            gsRptArgs(1) = cmbaño2.Text + "03"
        ElseIf cmbmes2.SelectedIndex = 3 Then
            gsRptArgs(1) = cmbaño2.Text + "04"
        ElseIf cmbmes2.SelectedIndex = 4 Then
            gsRptArgs(1) = cmbaño2.Text + "05"
        ElseIf cmbmes2.SelectedIndex = 5 Then
            gsRptArgs(1) = cmbaño2.Text + "06"
        ElseIf cmbmes2.SelectedIndex = 6 Then
            gsRptArgs(1) = cmbaño2.Text + "07"
        ElseIf cmbmes2.SelectedIndex = 7 Then
            gsRptArgs(1) = cmbaño2.Text + "08"
        ElseIf cmbmes2.SelectedIndex = 8 Then
            gsRptArgs(1) = cmbaño2.Text + "09"
        ElseIf cmbmes2.SelectedIndex = 9 Then
            gsRptArgs(1) = cmbaño2.Text + "10"
        ElseIf cmbmes2.SelectedIndex = 10 Then
            gsRptArgs(1) = cmbaño2.Text + "11"
        ElseIf cmbmes2.SelectedIndex = 11 Then
            gsRptArgs(1) = cmbaño2.Text + "12"
        End If
        gsRptArgs(2) = txtplaca.Text
        gsRptArgs(3) = txtt_mov.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPPLACAGUIA.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub FormRptGuiaPlaca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbaño.SelectedItem = sAño
        cmbaño2.SelectedItem = sAño
        cmbmes1.SelectedIndex = 0
        cmbmes2.SelectedIndex = Month(Date.Today) - 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "254"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> "" Then
            txtt_mov.Text = gLinea
            gLinea = Nothing
            'gSubLinea = Nothing
        Else
            gLinea = Nothing
            'gSubLinea = Nothing
        End If
        sBusAlm = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "255"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> "" Then
            txtplaca.Text = gLinea
            gLinea = Nothing
            'gSubLinea = Nothing
        Else
            gLinea = Nothing
            'gSubLinea = Nothing
        End If
        sBusAlm = ""
    End Sub
End Class