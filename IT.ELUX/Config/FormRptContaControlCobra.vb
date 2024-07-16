Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRptContaControlCobra
    Private PROVISIONESBL As New PROVISIONESBL
    Private Sub FormRptContaControlCobra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Control Cobranzas"
        Dim dtFecha As Date = DateSerial(Year(Date.Today), 1, 1)
        dtpfec1.Value = dtFecha
        dtpfec3.Value = dtFecha
        cmbaño.SelectedItem = sAño
        cmbmes1.SelectedItem = "Enero"
        cmbmes2.SelectedIndex = Month(Date.Today)
    End Sub

    Private Sub FormRptContaControlCobra_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "235"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente1.Text = gLinea
            txtnomcliente1.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sBusAlm = "235"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente2.Text = gLinea
            txtnomcliente2.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sBusAlm = "235"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente3.Text = gLinea
            txtnomcliente3.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sBusAlm = "235"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente4.Text = gLinea
            txtnomcliente4.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub
    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(10)
        gsRptArgs(0) = Format(dtpfec1.Value, "yyyy/MM/dd")
        gsRptArgs(1) = Format(dtpfec2.Value, "yyyy/MM/dd")
        If cmbtipo1.SelectedIndex = 1 Then
            gsRptArgs(2) = "01"
        ElseIf cmbtipo1.SelectedIndex = 2 Then
            gsRptArgs(2) = "03"
        ElseIf cmbtipo1.SelectedIndex = 3 Then
            gsRptArgs(2) = "07"
        ElseIf cmbtipo1.SelectedIndex = 4 Then
            gsRptArgs(2) = "08"
        ElseIf cmbtipo1.SelectedIndex = 5 Then
            gsRptArgs(2) = "80"
        Else
            gsRptArgs(2) = ""
        End If
        If cmbtipo1.SelectedIndex = 1 Then
            gsRptArgs(3) = "01"
        ElseIf cmbtipo1.SelectedIndex = 2 Then
            gsRptArgs(3) = "03"
        ElseIf cmbtipo1.SelectedIndex = 3 Then
            gsRptArgs(3) = "07"
        ElseIf cmbtipo1.SelectedIndex = 4 Then
            gsRptArgs(3) = "08"
        ElseIf cmbtipo1.SelectedIndex = 5 Then
            gsRptArgs(3) = "80"
        Else
            gsRptArgs(3) = ""
        End If
        gsRptArgs(4) = txtcliente1.Text
        gsRptArgs(5) = txtcliente2.Text

        If cmbt_venta1.SelectedIndex = -1 Or cmbt_venta1.SelectedIndex = 0 Then
            gsRptArgs(6) = ""
        ElseIf cmbt_venta1.SelectedIndex = 1 Then
            gsRptArgs(6) = "E"
        ElseIf cmbt_venta1.SelectedIndex = 2 Then
            gsRptArgs(6) = "N"
        End If
        If cmbt_venta2.SelectedIndex = -1 Or cmbt_venta2.SelectedIndex = 0 Then
            gsRptArgs(7) = ""
        ElseIf cmbt_venta2.SelectedIndex = 1 Then
            gsRptArgs(7) = "E"
        ElseIf cmbt_venta2.SelectedIndex = 2 Then
            gsRptArgs(7) = "N"
        End If
        If cmbestado1.SelectedIndex = 1 Then
            gsRptArgs(8) = "C"
        ElseIf cmbestado1.SelectedIndex = 2 Then
            gsRptArgs(8) = "P"
        ElseIf cmbestado1.SelectedIndex = 3 Then
            gsRptArgs(8) = "O"
        Else
            gsRptArgs(8) = ""
        End If
        If cmbestado2.SelectedIndex = 1 Then
            gsRptArgs(9) = "C"
        ElseIf cmbestado2.SelectedIndex = 2 Then
            gsRptArgs(9) = "P"
        ElseIf cmbestado2.SelectedIndex = 3 Then
            gsRptArgs(9) = "O"
        Else
            gsRptArgs(9) = ""
        End If
        If chknego.Checked Then
            gsRptArgs(10) = "1"
        Else
            gsRptArgs(10) = "0"
        End If
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_CONTROL_COBRANZAS.rpt"
        gsRptPath = gsPathRpt
        FormReportes.Show()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dispose()
    End Sub
    Private Sub txtcliente1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "235"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtcliente1.Text = gLinea
                txtnomcliente1.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtcliente2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "235"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtcliente2.Text = gLinea
                txtnomcliente2.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtcliente3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente3.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "235"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtcliente3.Text = gLinea
                txtnomcliente3.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtcliente4_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente4.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "235"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtcliente4.Text = gLinea
                txtnomcliente4.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtcliente1_LostFocus(sender As Object, e As EventArgs) Handles txtcliente1.LostFocus
        If txtcliente1.TextLength > 0 Then
            Dim prov As String = PROVISIONESBL.SelectT_Prov(txtcliente1.Text)
            If prov.Length > 0 Then
                txtnomcliente1.Text = prov
            Else
                txtnomcliente1.Text = ""
            End If
        Else
            txtcliente1.Text = ""
            txtnomcliente1.Text = ""
        End If
    End Sub

    Private Sub txtcliente2_LostFocus(sender As Object, e As EventArgs) Handles txtcliente2.LostFocus
        If txtcliente2.TextLength > 0 Then
            Dim prov As String = PROVISIONESBL.SelectT_Prov(txtcliente2.Text)
            If prov.Length > 0 Then
                txtnomcliente2.Text = prov
            Else
                txtnomcliente2.Text = ""
            End If
        Else
            txtcliente2.Text = ""
            txtnomcliente2.Text = ""
        End If
    End Sub

    Private Sub txtcliente3_LostFocus(sender As Object, e As EventArgs) Handles txtcliente3.LostFocus
        If txtcliente3.TextLength > 0 Then
            Dim prov As String = PROVISIONESBL.SelectT_Prov(txtcliente3.Text)
            If prov.Length > 0 Then
                txtnomcliente3.Text = prov
            Else
                txtnomcliente3.Text = ""
            End If
        Else
            txtcliente3.Text = ""
            txtnomcliente3.Text = ""
        End If
    End Sub

    Private Sub txtcliente4_LostFocus(sender As Object, e As EventArgs) Handles txtcliente4.LostFocus
        If txtcliente4.TextLength > 0 Then
            Dim prov As String = PROVISIONESBL.SelectT_Prov(txtcliente4.Text)
            If prov.Length > 0 Then
                txtnomcliente4.Text = prov
            Else
                txtnomcliente4.Text = ""
            End If
        Else
            txtcliente4.Text = ""
            txtnomcliente4.Text = ""
        End If
    End Sub

    Private Sub btnreporte2_Click(sender As Object, e As EventArgs) Handles btnreporte2.Click
        ReDim gsRptArgs(10)
        gsRptArgs(0) = Format(dtpfec3.Value, "yyyy/MM/dd")
        gsRptArgs(1) = Format(dtpfec4.Value, "yyyy/MM/dd")
        If cmbtipo3.SelectedIndex = 1 Then
            gsRptArgs(2) = "01"
        ElseIf cmbtipo3.SelectedIndex = 2 Then
            gsRptArgs(2) = "03"
        ElseIf cmbtipo3.SelectedIndex = 3 Then
            gsRptArgs(2) = "07"
        ElseIf cmbtipo3.SelectedIndex = 4 Then
            gsRptArgs(2) = "08"
        ElseIf cmbtipo3.SelectedIndex = 5 Then
            gsRptArgs(2) = "80"
        Else
            gsRptArgs(2) = ""
        End If
        If cmbtipo4.SelectedIndex = 1 Then
            gsRptArgs(3) = "01"
        ElseIf cmbtipo4.SelectedIndex = 2 Then
            gsRptArgs(3) = "03"
        ElseIf cmbtipo4.SelectedIndex = 3 Then
            gsRptArgs(3) = "07"
        ElseIf cmbtipo4.SelectedIndex = 4 Then
            gsRptArgs(3) = "08"
        ElseIf cmbtipo4.SelectedIndex = 5 Then
            gsRptArgs(3) = "80"
        Else
            gsRptArgs(3) = ""
        End If
        gsRptArgs(4) = txtcliente3.Text
        gsRptArgs(5) = txtcliente4.Text
        If cmbestado3.SelectedIndex = 1 Then
            gsRptArgs(6) = "C"
        ElseIf cmbestado3.SelectedIndex = 2 Then
            gsRptArgs(6) = "P"
        Else
            gsRptArgs(6) = ""
        End If
        If cmbestado4.SelectedIndex = 1 Then
            gsRptArgs(7) = "C"
        ElseIf cmbestado4.SelectedIndex = 2 Then
            gsRptArgs(7) = "P"
        Else
            gsRptArgs(7) = ""
        End If
        If cmbt_venta3.SelectedIndex = -1 Or cmbt_venta3.SelectedIndex = 0 Then
            gsRptArgs(8) = ""
        ElseIf cmbt_venta3.SelectedIndex = 1 Then
            gsRptArgs(8) = "E"
        ElseIf cmbt_venta3.SelectedIndex = 2 Then
            gsRptArgs(8) = "N"
        End If
        If cmbt_venta4.SelectedIndex = -1 Or cmbt_venta4.SelectedIndex = 0 Then
            gsRptArgs(9) = ""
        ElseIf cmbt_venta4.SelectedIndex = 1 Then
            gsRptArgs(9) = "E"
        ElseIf cmbt_venta4.SelectedIndex = 2 Then
            gsRptArgs(9) = "N"
        End If
        If chknego.Checked Then
            gsRptArgs(10) = "1"
        Else
            gsRptArgs(10) = "0"
        End If
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_ESTADO_CUENTA_CLIENTE.rpt"
        gsRptPath = gsPathRpt
        FormReportes.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dispose()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        sBusAlm = "235"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente5.Text = gLinea
            txtnomcliente5.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        sBusAlm = "235"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente6.Text = gLinea
            txtnomcliente6.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReDim gsRptArgs(9)
        If cmbtipo1.SelectedIndex = 1 Then
            gsRptArgs(0) = "01"
        ElseIf cmbtipo1.SelectedIndex = 2 Then
            gsRptArgs(0) = "03"
        ElseIf cmbtipo1.SelectedIndex = 3 Then
            gsRptArgs(0) = "07"
        ElseIf cmbtipo1.SelectedIndex = 4 Then
            gsRptArgs(0) = "08"
        ElseIf cmbtipo1.SelectedIndex = 5 Then
            gsRptArgs(0) = "80"
        Else
            gsRptArgs(0) = ""
        End If
        gsRptArgs(1) = txtserie.Text
        gsRptArgs(2) = txtnro_doc_ref.Text
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
        gsRptArgs(5) = cmbaño.SelectedItem
        gsRptArgs(6) = txtcliente5.Text
        gsRptArgs(7) = txtcliente6.Text
        If chkest1.Checked Then
            gsRptArgs(8) = "1"
        Else
            gsRptArgs(8) = ""
        End If
        If cmbest1.SelectedIndex = 1 Then
            gsRptArgs(9) = "P"
        ElseIf cmbest1.SelectedIndex = 2 Then
            gsRptArgs(9) = "C"
        Else
            gsRptArgs(9) = ""
        End If
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTPROG_DOCUPAGO.rpt"
        gsRptPath = gsPathRpt
        FormReportes.Show()
    End Sub

    Private Sub txtcliente5_LostFocus(sender As Object, e As EventArgs) Handles txtcliente5.LostFocus
        If txtcliente5.TextLength > 0 Then
            Dim prov As String = PROVISIONESBL.SelectT_Prov(txtcliente5.Text)
            If prov.Length > 0 Then
                txtnomcliente5.Text = prov
            Else
                txtnomcliente5.Text = ""
            End If
        Else
            txtcliente5.Text = ""
            txtnomcliente5.Text = ""
        End If
    End Sub

    Private Sub txtcliente6_LostFocus(sender As Object, e As EventArgs) Handles txtcliente6.LostFocus
        If txtcliente6.TextLength > 0 Then
            Dim prov As String = PROVISIONESBL.SelectT_Prov(txtcliente6.Text)
            If prov.Length > 0 Then
                txtnomcliente6.Text = prov
            Else
                txtnomcliente6.Text = ""
            End If
        Else
            txtcliente6.Text = ""
            txtnomcliente6.Text = ""
        End If
    End Sub

    Private Sub txtcliente5_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente5.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "235"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtcliente5.Text = gLinea
                txtnomcliente5.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing

            End If

        End If
        If e.KeyValue = Keys.Enter Then
            txtcliente6.Focus()
        End If
    End Sub

    Private Sub txtcliente6_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente6.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "235"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtcliente6.Text = gLinea
                txtnomcliente6.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If

        End If
        If e.KeyValue = Keys.Enter Then
            cmbttipo.Focus()
        End If
    End Sub
    Private Sub txtserie_KeyDown(sender As Object, e As KeyEventArgs) Handles txtserie.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtnro_doc_ref.Focus()
        End If
    End Sub
    Private Sub txtnro_doc_ref_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnro_doc_ref.KeyDown
        If e.KeyValue = Keys.Enter Then
            Button2.Focus()
        End If
    End Sub
    Private Sub cmbttipo_Enter(sender As Object, e As EventArgs) Handles cmbttipo.Enter
        cmbttipo.FlatStyle = FlatStyle.Popup
    End Sub

    Private Sub cmbttipo_Leave(sender As Object, e As EventArgs) Handles cmbttipo.Leave
        cmbttipo.FlatStyle = FlatStyle.Standard
    End Sub
    Private Sub txtcliente5_Enter(sender As Object, e As EventArgs) Handles txtcliente5.Enter
        txtcliente5.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtcliente5_Leave(sender As Object, e As EventArgs) Handles txtcliente5.Leave
        txtcliente5.BorderStyle = BorderStyle.Fixed3D
    End Sub
    Private Sub txtcliente6_Enter(sender As Object, e As EventArgs) Handles txtcliente6.Enter
        txtcliente6.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtcliente6_Leave(sender As Object, e As EventArgs) Handles txtcliente6.Leave
        txtcliente6.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub cmbttipo_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbttipo.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtserie.Focus()
        End If
    End Sub
End Class