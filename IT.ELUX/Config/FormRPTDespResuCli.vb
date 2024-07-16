Public Class FormRPTDespResuCli

    Private Sub FormRPTDespResuCli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Resumen Despacho Cliente"
        cmbaño.SelectedItem = sAño
        cmbmes1.SelectedItem = "Enero"
        cmbmes2.SelectedIndex = Month(Date.Today)
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        sBusAlm = "12"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtarticulo2.Text = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        sBusAlm = "12"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtarticulo1.Text = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "42"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtuni1.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "42"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtuni2.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRPTDespResuCli_InputLanguageChanged(sender As Object, e As InputLanguageChangedEventArgs) Handles Me.InputLanguageChanged
        Dispose()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sBusAlm = "41"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtvend.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sBusAlm = "41"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtvend1.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "39"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente1.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sBusAlm = "39"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente2.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(10)
        gsRptArgs(0) = txtcliente1.Text
        gsRptArgs(1) = txtcliente2.Text
        gsRptArgs(2) = cmbaño.SelectedItem
        If cmbmes1.SelectedIndex = 1 Then
            gsRptArgs(3) = "01"
        ElseIf cmbmes1.SelectedIndex = 2 Then
            gsRptArgs(3) = "02"
        ElseIf cmbmes1.SelectedIndex = 3 Then
            gsRptArgs(3) = "03"
        ElseIf cmbmes1.SelectedIndex = 4 Then
            gsRptArgs(3) = "04"
        ElseIf cmbmes1.SelectedIndex = 5 Then
            gsRptArgs(3) = "05"
        ElseIf cmbmes1.SelectedIndex = 6 Then
            gsRptArgs(3) = "06"
        ElseIf cmbmes1.SelectedIndex = 7 Then
            gsRptArgs(3) = "07"
        ElseIf cmbmes1.SelectedIndex = 8 Then
            gsRptArgs(3) = "08"
        ElseIf cmbmes1.SelectedIndex = 9 Then
            gsRptArgs(3) = "09"
        ElseIf cmbmes1.SelectedIndex = 10 Then
            gsRptArgs(3) = "10"
        ElseIf cmbmes1.SelectedIndex = 11 Then
            gsRptArgs(3) = "11"
        ElseIf cmbmes1.SelectedIndex = 12 Then
            gsRptArgs(3) = "12"
        End If
        If cmbmes2.SelectedIndex = 1 Then
            gsRptArgs(4) = "01"
        ElseIf cmbmes2.SelectedIndex = 2 Then
            gsRptArgs(4) = "02"
        ElseIf cmbmes2.SelectedIndex = 3 Then
            gsRptArgs(4) = "03"
        ElseIf cmbmes2.SelectedIndex = 4 Then
            gsRptArgs(4) = "04"
        ElseIf cmbmes2.SelectedIndex = 5 Then
            gsRptArgs(4) = "05"
        ElseIf cmbmes2.SelectedIndex = 6 Then
            gsRptArgs(4) = "06"
        ElseIf cmbmes2.SelectedIndex = 7 Then
            gsRptArgs(4) = "07"
        ElseIf cmbmes2.SelectedIndex = 8 Then
            gsRptArgs(4) = "08"
        ElseIf cmbmes2.SelectedIndex = 9 Then
            gsRptArgs(4) = "09"
        ElseIf cmbmes2.SelectedIndex = 10 Then
            gsRptArgs(4) = "10"
        ElseIf cmbmes2.SelectedIndex = 11 Then
            gsRptArgs(4) = "11"
        ElseIf cmbmes2.SelectedIndex = 12 Then
            gsRptArgs(4) = "12"
        End If
        gsRptArgs(5) = txtarticulo1.Text
        gsRptArgs(6) = txtarticulo2.Text
        gsRptArgs(7) = txtuni1.Text
        gsRptArgs(8) = txtuni2.Text
        gsRptArgs(9) = txtvend.Text
        gsRptArgs(10) = txtvend1.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_DESP_RESU_CLIENTE.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub FormRPTDespResuCli_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dispose()
    End Sub
End Class