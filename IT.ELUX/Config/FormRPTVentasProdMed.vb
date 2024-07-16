Public Class FormRPTVentasProdMed
    Private Sub FormRPTVentasProdMed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Resumen Ventas Anual Cliente"
        cmbaño.SelectedItem = sAño
        cmbmes1.SelectedItem = "Enero"
        cmbmes2.SelectedIndex = Month(Date.Today)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "227"
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
        sBusAlm = "227"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtuni2.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(6)
        gsRptArgs(0) = cmbaño.SelectedItem
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
        gsRptArgs(3) = txtcliente1.Text
        gsRptArgs(4) = txtcliente2.Text
        gsRptArgs(5) = txtuni1.Text
        gsRptArgs(6) = txtuni2.Text

        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_VENTAS_ANUAL_CLIENTE_PROD_MED.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRPTVentasProdMed_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dispose()
    End Sub
End Class