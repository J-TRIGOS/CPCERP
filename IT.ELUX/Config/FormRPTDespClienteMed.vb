Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRPTDespClienteMed
    Dim ARTICULOBL As New ARTICULOBL
    Private Sub FormRPTDespClienteMed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Despacho Cliente Medida"
        Dim dtFecha As Date = DateSerial(Year(Date.Today), Month(Date.Today), 1)
        dtpfec1.Value = dtFecha
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

    Private Sub txtcliente1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "39"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtcliente1.Text = gLinea
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
        End If

    End Sub

    Private Sub txtcliente2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "39"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtcliente2.Text = gLinea
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "35"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtart1.Text = gArt
            txtart1.Select()
            TextBox2.Text = gSubLinea
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "35"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing And gArt <> Nothing Then
            txtart2.Text = gArt
            txtart2.Select()
            TextBox3.Text = gSubLinea
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRPTDespClienteMed_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub txtart1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtart1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "35"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gSubLinea <> Nothing Then
                txtart1.Text = gArt
                txtart1.Select()
                TextBox2.Text = gSubLinea
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gSubLinea = Nothing
                gArt = Nothing
            End If

        End If

    End Sub
    Private Sub txtart2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtart2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "35"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gSubLinea <> Nothing And gArt <> Nothing Then
                txtart2.Text = gArt
                txtart2.Select()
                TextBox3.Text = gSubLinea
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gSubLinea = Nothing
                gArt = Nothing
            End If
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sBusAlm = "61"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtt_movinv1.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sBusAlm = "61"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtt_movinv2.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        sBusAlm = "62"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtmedida1.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        sBusAlm = "62"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtmedida2.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub txtt_movinv1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtt_movinv1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "61"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtt_movinv1.Text = gLinea
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
        End If

    End Sub

    Private Sub txtt_movinv2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtt_movinv2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "61"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtt_movinv2.Text = gLinea
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtmedida1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmedida1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "62"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtmedida1.Text = gLinea
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtmedida2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmedida2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "62"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtmedida2.Text = gLinea
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtart1_LostFocus(sender As Object, e As EventArgs) Handles txtart1.LostFocus
        If txtart1.TextLength = "8" Then
            TextBox2.Text = ARTICULOBL.SelectArt2(txtart1.Text)
        ElseIf (txtart1.TextLength > "1" Or txtart1.TextLength < "7") And txtart1.TextLength <> 0 Then
            MsgBox("El articulo tiene menos de 8 digitos")
            txtart1.Select()
        ElseIf txtart1.TextLength = 0 Then
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub txtart2_LostFocus(sender As Object, e As EventArgs) Handles txtart2.LostFocus
        If txtart2.TextLength = "8" Then
            TextBox3.Text = ARTICULOBL.SelectArt2(txtart2.Text)
        ElseIf (txtart2.TextLength > "1" Or txtart2.TextLength < "7") And txtart2.TextLength <> 0 Then
            MsgBox("El articulo tiene menos de 8 digitos")
            txtart2.Select()
        ElseIf txtart2.TextLength = 0 Then
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(9)
        gsRptArgs(0) = Format(dtpfec1.Value, "yyyy/MM/dd")
        gsRptArgs(1) = Format(dtpfec2.Value, "yyyy/MM/dd")
        gsRptArgs(2) = txtt_movinv1.Text
        gsRptArgs(3) = txtt_movinv2.Text
        gsRptArgs(4) = txtart1.Text
        gsRptArgs(5) = txtart2.Text
        gsRptArgs(6) = txtcliente1.Text
        gsRptArgs(7) = txtcliente2.Text
        gsRptArgs(8) = txtmedida1.Text
        gsRptArgs(9) = txtmedida2.Text
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPDESP_CLIENTE_MED.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class