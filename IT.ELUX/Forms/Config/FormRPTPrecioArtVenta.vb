Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRPTPrecioArtVenta
    Dim ARTICULOBL As New ARTICULOBL
    Dim CTCTBL As New CTCTBL
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        ElseIf (txtart2.TextLength > 1 Or txtart2.TextLength < 7) And txtart2.TextLength <> 0 Then
            MsgBox("El articulo tiene menos de 8 digitos")
            txtart2.Select()
        ElseIf txtart2.TextLength = 0 Then
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub txtart1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtart1.KeyDown
        If e.KeyValue = Keys.F9 Then
            'sBusAlm = "37"
            sBusAlm = "35"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gSubLinea <> Nothing And gArt <> Nothing Then
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

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(5)
        gsRptArgs(0) = txtcliente1.Text
        gsRptArgs(1) = txtcliente2.Text
        gsRptArgs(2) = txtart1.Text
        gsRptArgs(3) = txtart2.Text
        If chktodos.Checked Then
            gsRptArgs(4) = "0"
        Else
            gsRptArgs(4) = ""
        End If
        gsRptArgs(5) = cmbaño.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_PRECIO_ARTICULOS_VENTAS.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "53"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtcliente1.Text = gLinea
            txtcliente1.Select()
            TextBox1.Text = gSubLinea
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sBusAlm = "53"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtcliente2.Text = gLinea
            txtcliente2.Select()
            TextBox4.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub txtcliente1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "53"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtcliente1.Text = gLinea
                txtcliente1.Select()
                TextBox1.Text = gSubLinea
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtcliente2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "53"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtcliente2.Text = gLinea
                txtcliente2.Select()
                TextBox4.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtcliente1_LostFocus(sender As Object, e As EventArgs) Handles txtcliente1.LostFocus
        If txtcliente1.Text = "" Then
            TextBox1.Clear()
        Else
            TextBox1.Text = CTCTBL.SelectCTCT(txtcliente1.Text)
        End If
    End Sub

    Private Sub txtcliente2_LostFocus(sender As Object, e As EventArgs) Handles txtcliente2.LostFocus
        If txtcliente2.Text = "" Then
            TextBox4.Clear()
        Else
            TextBox4.Text = CTCTBL.SelectCTCT(txtcliente2.Text)
        End If

    End Sub

    Private Sub FormRPTPrecioArtVenta_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub FormRPTPrecioArtVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Precio Venta Articulo"
    End Sub
End Class