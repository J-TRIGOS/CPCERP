Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormRptComprasArt
    Private ARTICULOBL As New ARTICULOBL
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
        sBusAlm = "106"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtarticulo1.Text = gLinea
            txtnomart1.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "106"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtarticulo2.Text = gLinea
            txtnomart2.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If

    End Sub

    Private Sub FormRptComprasArt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Resumen Compras por Articulo Cliente"
        cmbaño.SelectedItem = sAño
        cmbaño1.SelectedItem = sAño
        cmbmes1.SelectedItem = "Enero"
        cmbmes2.SelectedIndex = Month(Date.Today)
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(6)
        If cmbmes1.SelectedIndex = 1 Then
            gsRptArgs(0) = cmbaño.Text & "01"
        ElseIf cmbmes1.SelectedIndex = 2 Then
            gsRptArgs(0) = cmbaño.Text & "02"
        ElseIf cmbmes1.SelectedIndex = 3 Then
            gsRptArgs(0) = cmbaño.Text & "03"
        ElseIf cmbmes1.SelectedIndex = 4 Then
            gsRptArgs(0) = cmbaño.Text & "04"
        ElseIf cmbmes1.SelectedIndex = 5 Then
            gsRptArgs(0) = cmbaño.Text & "05"
        ElseIf cmbmes1.SelectedIndex = 6 Then
            gsRptArgs(0) = cmbaño.Text & "06"
        ElseIf cmbmes1.SelectedIndex = 7 Then
            gsRptArgs(0) = cmbaño.Text & "07"
        ElseIf cmbmes1.SelectedIndex = 8 Then
            gsRptArgs(0) = cmbaño.Text & "08"
        ElseIf cmbmes1.SelectedIndex = 9 Then
            gsRptArgs(0) = cmbaño.Text & "09"
        ElseIf cmbmes1.SelectedIndex = 10 Then
            gsRptArgs(0) = cmbaño.Text & "10"
        ElseIf cmbmes1.SelectedIndex = 11 Then
            gsRptArgs(0) = cmbaño.Text & "11"
        ElseIf cmbmes1.SelectedIndex = 12 Then
            gsRptArgs(0) = cmbaño.Text & "12"
        End If
        If cmbmes2.SelectedIndex = 1 Then
            gsRptArgs(1) = cmbaño1.Text & "01"
        ElseIf cmbmes2.SelectedIndex = 2 Then
            gsRptArgs(1) = cmbaño1.Text & "02"
        ElseIf cmbmes2.SelectedIndex = 3 Then
            gsRptArgs(1) = cmbaño1.Text & "03"
        ElseIf cmbmes2.SelectedIndex = 4 Then
            gsRptArgs(1) = cmbaño1.Text & "04"
        ElseIf cmbmes2.SelectedIndex = 5 Then
            gsRptArgs(1) = cmbaño1.Text & "05"
        ElseIf cmbmes2.SelectedIndex = 6 Then
            gsRptArgs(1) = cmbaño1.Text & "06"
        ElseIf cmbmes2.SelectedIndex = 7 Then
            gsRptArgs(1) = cmbaño1.Text & "07"
        ElseIf cmbmes2.SelectedIndex = 8 Then
            gsRptArgs(1) = cmbaño1.Text & "08"
        ElseIf cmbmes2.SelectedIndex = 9 Then
            gsRptArgs(1) = cmbaño1.Text & "09"
        ElseIf cmbmes2.SelectedIndex = 10 Then
            gsRptArgs(1) = cmbaño1.Text & "10"
        ElseIf cmbmes2.SelectedIndex = 11 Then
            gsRptArgs(1) = cmbaño1.Text & "11"
        ElseIf cmbmes2.SelectedIndex = 12 Then
            gsRptArgs(1) = cmbaño1.Text & "12"
        End If
        gsRptArgs(2) = txtarticulo1.Text
        gsRptArgs(3) = txtarticulo2.Text
        gsRptArgs(4) = txtcliente1.Text
        gsRptArgs(5) = txtcliente2.Text
        If txtactivo1.Text = "" Then
            gsRptArgs(6) = "1"
        Else
            gsRptArgs(6) = txtactivo1.Text
        End If
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPT_COMPRASART.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub FormRptComprasArt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'sBusAlm = "225"
        'Dim frm As New FormBUSQUEDA
        'frm.ShowDialog()
        ''MsgBox(IsDBNull(gLinea.Length))
        'If gLinea <> Nothing And gSubLinea <> Nothing Then
        '    'cmbactivo.SelectedValue = gCodAct
        '    txtactivo1.Text = gLinea
        '    txtnomactivo.Text = ARTICULOBL.SelectAct1(txtactivo1.Text)
        '    gLinea = Nothing
        '    gSubLinea = Nothing
        'Else
        '    gLinea = Nothing
        '    gSubLinea = Nothing
        'End If
        If sFecha >= Format(CDate("2020/12/30"), "yyyy/MM/dd") Then
            'If txtArticulo.Visible = True Then
            sBusAlm = "120"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gArt <> Nothing And gSubLinea <> Nothing Then
                'txtactivo1.Text = gArt
                txtactivo1.Text = gArt
                txtnomactivo.Text = ARTICULOBL.SelectNom(Trim(gArt))
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gSubLinea = Nothing
                gArt = Nothing
            End If
            'End If
        End If
    End Sub

    Private Sub txtarticulo1_LostFocus(sender As Object, e As EventArgs) Handles txtarticulo1.LostFocus
        If txtarticulo1.TextLength > 0 Then
            txtnomart1.Text = ARTICULOBL.SelectArt2(txtarticulo1.Text)
        Else
            txtarticulo1.Text = ""
            txtnomart1.Text = ""
            'txtunidad.Text = ""
        End If
    End Sub

    Private Sub txtarticulo2_LostFocus(sender As Object, e As EventArgs) Handles txtarticulo2.LostFocus
        If txtarticulo2.TextLength > 0 Then
            txtnomart2.Text = ARTICULOBL.SelectArt2(txtarticulo2.Text)
        Else
            txtarticulo2.Text = ""
            txtnomart2.Text = ""
            'txtunidad.Text = ""
        End If
    End Sub

    Private Sub txtactivo1_LostFocus(sender As Object, e As EventArgs) Handles txtactivo1.LostFocus
        If txtactivo1.TextLength > 0 Then
            txtnomactivo.Text = ARTICULOBL.SelectAct1(txtactivo1.Text)
        Else
            txtactivo1.Text = ""
            txtactivo1.Text = ""
            'txtunidad.Text = ""
        End If

    End Sub

    Private Sub txtactivo1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtactivo1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "225"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtactivo1.Text = gLinea
                txtnomactivo.Text = ARTICULOBL.SelectAct1(txtactivo1.Text)
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtarticulo1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtarticulo1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "106"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtarticulo1.Text = gLinea
                txtnomart1.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If

    End Sub

    Private Sub txtarticulo2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtarticulo2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "106"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtarticulo2.Text = gLinea
                txtnomart2.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If

    End Sub


End Class