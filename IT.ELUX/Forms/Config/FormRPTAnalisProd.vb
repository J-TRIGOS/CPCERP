Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRPTAnalisProd
    Private ELTBLINESBL As New ELTBLINESBL
    Private Sub FormRPTAnalisProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Analisis Produccion"
        cmbaño.SelectedItem = sAño
        cmbmes1.SelectedItem = "Enero"
        cmbmes2.SelectedIndex = Month(Date.Today)
        cmbaño1.SelectedItem = sAño
        cmbmes3.SelectedItem = "Enero"
        cmbmes4.SelectedIndex = Month(Date.Today)
        Me.Text = "Control Ingresos"
        Dim dtFecha As Date = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        'Dim dtFecha3 As Date = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        dtpini.Value = dtFecha
        'dtpfec3.Value = dtFecha

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRPTAnalisProd_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub txtsublinea1_Validated(sender As Object, e As EventArgs) Handles txtsublinea1.Validated
        If txtsublinea1.TextLength > 0 Then
            TextBox2.Text = ELTBLINESBL.SelectDescri(txtsublinea1.Text)
        End If

    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(4)
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
        gsRptArgs(3) = txtsublinea1.Text
        gsRptArgs(4) = txtsublinea2.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_PROD_DETALLE.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
    Private Sub txtsublinea2_Validated(sender As Object, e As EventArgs) Handles txtsublinea2.Validated
        If txtsublinea2.TextLength > 0 Then
            TextBox3.Text = ELTBLINESBL.SelectDescri(txtsublinea2.Text)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "27"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtsublinea1.Text = gSubLinea
            txtsublinea1.Select()
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "28"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtsublinea2.Text = gSubLinea
            txtsublinea2.Select()
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ReDim gsRptArgs(4)
        gsRptArgs(0) = cmbaño1.SelectedItem
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
        gsRptArgs(3) = txtsublinea3.Text
        gsRptArgs(4) = txtsublinea4.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_PROD_RESUANUAL.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dispose()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sBusAlm = "27"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtsublinea3.Text = gSubLinea
            txtsublinea3.Select()
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "27"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtsublinea4.Text = gSubLinea
            txtsublinea4.Select()
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dispose()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        sBusAlm = "27"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtsublinea5.Text = gSubLinea
            txtsublinea5.Select()
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        sBusAlm = "27"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtsublinea6.Text = gSubLinea
            txtsublinea6.Select()
            gSubLinea = Nothing
        Else
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ReDim gsRptArgs(3)

        gsRptArgs(0) = txtsublinea5.Text
        gsRptArgs(1) = txtsublinea6.Text
        gsRptArgs(2) = Format(dtpini.Value, "yyyy/MM/dd")
        gsRptArgs(3) = Format(dtpfin.Value, "yyyy/MM/dd")
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_PROD_RESUDIARIO.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub txtsublinea5_Validated(sender As Object, e As EventArgs) Handles txtsublinea5.Validated
        If txtsublinea5.TextLength > 0 Then
            TextBox7.Text = ELTBLINESBL.SelectDescri(txtsublinea5.Text)
        End If
    End Sub


    Private Sub txtsublinea6_Validated(sender As Object, e As EventArgs) Handles txtsublinea6.Validated
        If txtsublinea6.TextLength > 0 Then
            TextBox4.Text = ELTBLINESBL.SelectDescri(txtsublinea6.Text)
        End If
    End Sub


    Private Sub txtsublinea3_Validated(sender As Object, e As EventArgs) Handles txtsublinea3.Validated
        If txtsublinea3.TextLength > 0 Then
            TextBox5.Text = ELTBLINESBL.SelectDescri(txtsublinea3.Text)
        End If
    End Sub
    Private Sub txtsublinea4_Validated(sender As Object, e As EventArgs) Handles txtsublinea4.Validated
        If txtsublinea4.TextLength > 0 Then
            TextBox1.Text = ELTBLINESBL.SelectDescri(txtsublinea4.Text)
        End If
    End Sub
End Class