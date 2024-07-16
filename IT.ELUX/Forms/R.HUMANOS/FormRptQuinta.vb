Imports IT.ELUX.BL
Public Class FormRptQuinta
    Private PERBL As New PERBL
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sBusAlm = "37"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtper1.Text = gLinea
            txtnomper1.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "37"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtper2.Text = gLinea
            txtnomper2.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub
    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(7)
        gsRptArgs(0) = txtper1.Text
        gsRptArgs(1) = txtper2.Text
        If Cmbt_per1.SelectedIndex = 1 Then
            gsRptArgs(2) = "20"
        ElseIf Cmbt_per1.SelectedIndex = 2 Then
            gsRptArgs(2) = "21"
        Else
            gsRptArgs(2) = ""
        End If
        If Cmbt_per2.SelectedIndex = 1 Then
            gsRptArgs(3) = "20"
        ElseIf Cmbt_per2.SelectedIndex = 2 Then
            gsRptArgs(3) = "21"
        Else
            gsRptArgs(3) = ""
        End If
        gsRptArgs(4) = cmbaño.Text
        gsRptArgs(5) = cmbaño1.Text
        If cmbmes.SelectedIndex = 1 Then
            gsRptArgs(6) = "01"
        ElseIf cmbmes.SelectedIndex = 2 Then
            gsRptArgs(6) = "02"
        ElseIf cmbmes.SelectedIndex = 3 Then
            gsRptArgs(6) = "03"
        ElseIf cmbmes.SelectedIndex = 4 Then
            gsRptArgs(6) = "04"
        ElseIf cmbmes.SelectedIndex = 5 Then
            gsRptArgs(6) = "05"
        ElseIf cmbmes.SelectedIndex = 6 Then
            gsRptArgs(6) = "06"
        ElseIf cmbmes.SelectedIndex = 7 Then
            gsRptArgs(6) = "07"
        ElseIf cmbmes.SelectedIndex = 8 Then
            gsRptArgs(6) = "08"
        ElseIf cmbmes.SelectedIndex = 9 Then
            gsRptArgs(6) = "09"
        ElseIf cmbmes.SelectedIndex = 10 Then
            gsRptArgs(6) = "10"
        ElseIf cmbmes.SelectedIndex = 11 Then
            gsRptArgs(6) = "11"
        ElseIf cmbmes.SelectedIndex = 12 Then
            gsRptArgs(6) = "12"
        End If
        If cmbmes1.SelectedIndex = 1 Then
            gsRptArgs(7) = "01"
        ElseIf cmbmes1.SelectedIndex = 2 Then
            gsRptArgs(7) = "02"
        ElseIf cmbmes1.SelectedIndex = 3 Then
            gsRptArgs(7) = "03"
        ElseIf cmbmes1.SelectedIndex = 4 Then
            gsRptArgs(7) = "04"
        ElseIf cmbmes1.SelectedIndex = 5 Then
            gsRptArgs(7) = "05"
        ElseIf cmbmes1.SelectedIndex = 6 Then
            gsRptArgs(7) = "06"
        ElseIf cmbmes1.SelectedIndex = 7 Then
            gsRptArgs(7) = "07"
        ElseIf cmbmes1.SelectedIndex = 8 Then
            gsRptArgs(7) = "08"
        ElseIf cmbmes1.SelectedIndex = 9 Then
            gsRptArgs(7) = "09"
        ElseIf cmbmes1.SelectedIndex = 10 Then
            gsRptArgs(7) = "10"
        ElseIf cmbmes1.SelectedIndex = 11 Then
            gsRptArgs(7) = "11"
        ElseIf cmbmes1.SelectedIndex = 12 Then
            gsRptArgs(7) = "12"
        End If
        'gsRptArgs(3) = txtmedida1.Text
        'gsRptArgs(4) = txtmedida2.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTQUINTA.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub FormRptQuinta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Renta de Quinta"
        cmbaño.Text = sAño
        cmbaño1.Text = sAño
        cmbmes.SelectedIndex = 1
        cmbmes1.SelectedIndex = Month(Date.Today)
        If gsUser = "JMONTES" Then
            Cmbt_per1.Text = "OBREROS"
            Cmbt_per2.Text = "OBREROS"
            Cmbt_per1.Enabled = False
            Cmbt_per2.Enabled = False
        End If

    End Sub
    Private Sub txtper1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtper1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtper1.Text = gLinea
                txtnomper1.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub
    Private Sub txtper1_LostFocus(sender As Object, e As EventArgs) Handles txtper1.LostFocus
        If txtper1.Text = "" Then
            txtnomper1.Text = ""
            Exit Sub
        End If
        txtnomper1.Text = PERBL.SelectApeNom(txtper1.Text)
        If txtper1.Text Is Nothing Then
            MsgBox("Personal no existe", MsgBoxStyle.Exclamation)
            txtper1.Text = ""
        End If
    End Sub
    Private Sub txtper2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtper2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtper2.Text = gLinea
                txtnomper2.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub
    Private Sub txtper2_LostFocus(sender As Object, e As EventArgs) Handles txtper2.LostFocus
        If txtper2.Text = "" Then
            txtnomper2.Text = ""
            Exit Sub
        End If
        txtnomper2.Text = PERBL.SelectApeNom(txtper2.Text)
        If txtper2.Text Is Nothing Then
            MsgBox("Personal no existe", MsgBoxStyle.Exclamation)
            txtper2.Text = ""
        End If
    End Sub
End Class