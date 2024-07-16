Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormRptExpArtCos
    Private ELTBLINESBL As New ELTBLINESBL
    Private ELETIQUETABL As New ELETIQUETABL
    Private Sub FormRptExpArtCos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Reporte Explosion Articulos"
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click

        ReDim gsRptArgs(4)
        gsRptArgs(0) = txtcomp1.Text
        'gsRptArgs(1) = txtraiz1.Text
        ' gsRptArgs(2) = txtraiz2.Text
        gsRptArgs(1) = txtcomp2.Text
        gsRptArgs(2) = txtart1.Text
        gsRptArgs(3) = txtart2.Text
        gsRptArgs(4) = txtsublinea.Text
        'gsRptArgs(0) = Mid(cmbsublinea.Text, 1, 4)
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_ART_COMPO2.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub txtart1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtart1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "106"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtart1.Text = gLinea
                txtnomart1.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
        End If

    End Sub

    Private Sub txtart2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtart2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "106"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtart2.Text = gLinea
                txtnomart2.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
        End If
    End Sub

    Private Sub txtcomp1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcomp1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "106"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtcomp1.Text = gLinea
                txtnomcomp1.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
        End If
    End Sub


    Private Sub txtcomp2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcomp2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "106"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtcomp2.Text = gLinea
                txtnomcomp2.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
        End If
    End Sub

    'Private Sub txtraiz1_KeyDown(sender As Object, e As KeyEventArgs)
    '    If e.KeyValue = Keys.F9 Then
    '        sBusAlm = "106"
    '        Dim frm As New FormBUSQUEDA
    '        frm.ShowDialog()
    '        If gLinea <> Nothing Then
    '            txtraiz1.Text = gLinea
    '            txtnomraiz1.Text = gSubLinea
    '            gLinea = Nothing
    '            gSubLinea = Nothing
    '            gArt = Nothing
    '        Else
    '            gLinea = Nothing
    '            gSubLinea = Nothing
    '            gArt = Nothing
    '        End If
    '    End If
    'End Sub

    'Private Sub txtraiz2_KeyDown(sender As Object, e As KeyEventArgs)
    '    If e.KeyValue = Keys.F9 Then
    '        sBusAlm = "106"
    '        Dim frm As New FormBUSQUEDA
    '        frm.ShowDialog()
    '        If gLinea <> Nothing Then
    '            txtraiz2.Text = gLinea
    '            txtnomraiz2.Text = gSubLinea
    '            gLinea = Nothing
    '            gSubLinea = Nothing
    '            gArt = Nothing
    '        Else
    '            gLinea = Nothing
    '            gSubLinea = Nothing
    '            gArt = Nothing
    '        End If
    '    End If
    'End Sub

    Private Sub txtsublinea_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsublinea.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "27"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gSubLinea <> Nothing Then
                txtsublinea.Text = gSubLinea
                txtsublinea.Select()
                txtnomsublinea.Text = ELTBLINESBL.SelectDescri(txtsublinea.Text)
                gSubLinea = Nothing
            Else
                gSubLinea = Nothing
            End If
        End If
    End Sub
    Private Sub txtsublinea_LostFocus(sender As Object, e As EventArgs) Handles txtsublinea.LostFocus
        If txtsublinea.TextLength = 4 Then
            txtnomsublinea.Text = ELTBLINESBL.SelectDescri(txtsublinea.Text)
        Else
            txtnomsublinea.Text = ""
        End If
    End Sub

    Private Sub txtart1_LostFocus(sender As Object, e As EventArgs) Handles txtart1.LostFocus
        If txtart1.TextLength < 8 And txtart1.TextLength <> 0 Then
            'txtnomart1.Text = ""
            'MsgBox("Este no es un articulo valido")
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectArticuloCOD(txtart1.Text)
            If dt.Rows.Count > 0 Then
                'txtart1.Text = dt.Rows(0).Item(0).ToString
                txtnomart1.Text = dt.Rows(0).Item(1).ToString
            Else
                txtart1.Text = ""
                txtnomart1.Text = ""
                'MsgBox("Este no es un articulo valido")
            End If
        End If
    End Sub

    Private Sub txtart2_LostFocus(sender As Object, e As EventArgs) Handles txtart2.LostFocus
        If txtart2.TextLength < 8 And txtart2.TextLength <> 0 Then
            txtnomart2.Text = ""
            'MsgBox("Este no es un articulo valido")
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectArticuloCOD(txtart2.Text)
            If dt.Rows.Count > 0 Then
                'txtart2.Text = dt.Rows(0).Item(0).ToString
                txtnomart2.Text = dt.Rows(0).Item(1).ToString
            Else
                txtart2.Text = ""
                txtnomart2.Text = ""
                ' MsgBox("Este no es un articulo valido")
            End If
        End If
    End Sub

    Private Sub txtcomp1_LostFocus(sender As Object, e As EventArgs) Handles txtcomp1.LostFocus
        If txtcomp1.TextLength < 8 And txtcomp1.TextLength <> 0 Then
            txtnomcomp1.Text = ""
            'MsgBox("Este no es un articulo valido")
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectArticuloCOD(txtcomp1.Text)
            If dt.Rows.Count > 0 Then
                'txtcomp1.Text = dt.Rows(0).Item(0).ToString
                txtnomcomp1.Text = dt.Rows(0).Item(1).ToString
            Else
                txtart1.Text = ""
                txtnomcomp1.Text = ""
                'MsgBox("Este no es un articulo valido")
            End If
        End If
    End Sub

    Private Sub txtcomp2_LostFocus(sender As Object, e As EventArgs) Handles txtcomp2.LostFocus
        If txtcomp2.TextLength < 8 And txtcomp2.TextLength <> 0 Then
            txtnomcomp2.Text = ""
            'MsgBox("Este no es un articulo valido")
        Else
            Dim dt As DataTable
            dt = ELETIQUETABL.SelectArticuloCOD(txtcomp2.Text)
            If dt.Rows.Count > 0 Then
                'txtcomp2.Text = dt.Rows(0).Item(0).ToString
                txtnomcomp2.Text = dt.Rows(0).Item(1).ToString
            Else
                txtcomp2.Text = ""
                txtnomcomp2.Text = ""
                'MsgBox("Este no es un articulo valido")
            End If
        End If
    End Sub

    'Private Sub txtraiz1_LostFocus(sender As Object, e As EventArgs)
    '    If txtraiz1.TextLength < 8 And txtraiz1.TextLength <> 0 Then
    '        txtnomraiz1.Text = ""
    '        'MsgBox("Este no es un articulo valido")
    '    Else
    '        Dim dt As DataTable
    '        dt = ELETIQUETABL.SelectArticuloCOD(txtraiz1.Text)
    '        If dt.Rows.Count > 0 Then
    '            'txtcomp2.Text = dt.Rows(0).Item(0).ToString
    '            txtnomraiz1.Text = dt.Rows(0).Item(1).ToString
    '        Else
    '            txtraiz1.Text = ""
    '            txtnomraiz1.Text = ""
    '            'MsgBox("Este no es un articulo valido")
    '        End If
    '    End If
    'End Sub

    'Private Sub txtraiz2_LostFocus(sender As Object, e As EventArgs)
    '    If txtraiz2.TextLength < 8 And txtraiz2.TextLength <> 0 Then
    '        txtnomraiz2.Text = ""
    '        'MsgBox("Este no es un articulo valido")
    '    Else
    '        Dim dt As DataTable
    '        dt = ELETIQUETABL.SelectArticuloCOD(txtraiz2.Text)
    '        If dt.Rows.Count > 0 Then
    '            'txtcomp2.Text = dt.Rows(0).Item(0).ToString
    '            txtnomraiz2.Text = dt.Rows(0).Item(1).ToString
    '        Else
    '            txtraiz2.Text = ""
    '            txtnomraiz2.Text = ""
    '            'MsgBox("Este no es un articulo valido")
    '        End If
    '    End If
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gsRptArgs = {}
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_ART_COMPNEXP.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class