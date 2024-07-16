Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRPTLetrasCambio
    Private PROVISIONESBL As New PROVISIONESBL
    Private FACTURACIONBL As New FACTURACIONBL
    Private Sub FormRPTLetrasCambio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Letras Cambio"
        cmbaño.SelectedItem = sAño
        cmbaño2.SelectedItem = sAño
        cmbmes1.SelectedItem = "Enero"
        cmbmes2.SelectedIndex = Month(Date.Today)
        cmbaño3.SelectedItem = sAño
        cmbaño4.SelectedItem = sAño
        cmbmes3.SelectedItem = "Enero"
        cmbmes4.SelectedIndex = Month(Date.Today)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "235"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente1.Text = gLinea
            txtnomcli1.Text = gSubLinea
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
            txtnomcli2.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub FormRPTLetrasCambio_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        If rdbletra.Checked Then
            ReDim gsRptArgs(5)
            If cmbmes1.SelectedIndex = 1 Then
                gsRptArgs(0) = cmbaño.Text & "/01"
            ElseIf cmbmes1.SelectedIndex = 2 Then
                gsRptArgs(0) = cmbaño.Text & "/02"
            ElseIf cmbmes1.SelectedIndex = 3 Then
                gsRptArgs(0) = cmbaño.Text & "/03"
            ElseIf cmbmes1.SelectedIndex = 4 Then
                gsRptArgs(0) = cmbaño.Text & "/04"
            ElseIf cmbmes1.SelectedIndex = 5 Then
                gsRptArgs(0) = cmbaño.Text & "/05"
            ElseIf cmbmes1.SelectedIndex = 6 Then
                gsRptArgs(0) = cmbaño.Text & "/06"
            ElseIf cmbmes1.SelectedIndex = 7 Then
                gsRptArgs(0) = cmbaño.Text & "/07"
            ElseIf cmbmes1.SelectedIndex = 8 Then
                gsRptArgs(0) = cmbaño.Text & "/08"
            ElseIf cmbmes1.SelectedIndex = 9 Then
                gsRptArgs(0) = cmbaño.Text & "/09"
            ElseIf cmbmes1.SelectedIndex = 10 Then
                gsRptArgs(0) = cmbaño.Text & "/10"
            ElseIf cmbmes1.SelectedIndex = 11 Then
                gsRptArgs(0) = cmbaño.Text & "/11"
            ElseIf cmbmes1.SelectedIndex = 12 Then
                gsRptArgs(0) = cmbaño.Text & "/12"
            End If
            If cmbmes2.SelectedIndex = 1 Then
                gsRptArgs(1) = cmbaño2.Text & "/01"
            ElseIf cmbmes2.SelectedIndex = 2 Then
                gsRptArgs(1) = cmbaño2.Text & "/02"
            ElseIf cmbmes2.SelectedIndex = 3 Then
                gsRptArgs(1) = cmbaño2.Text & "/03"
            ElseIf cmbmes2.SelectedIndex = 4 Then
                gsRptArgs(1) = cmbaño2.Text & "/04"
            ElseIf cmbmes2.SelectedIndex = 5 Then
                gsRptArgs(1) = cmbaño2.Text & "/05"
            ElseIf cmbmes2.SelectedIndex = 6 Then
                gsRptArgs(1) = cmbaño2.Text & "/06"
            ElseIf cmbmes2.SelectedIndex = 7 Then
                gsRptArgs(1) = cmbaño2.Text & "/07"
            ElseIf cmbmes2.SelectedIndex = 8 Then
                gsRptArgs(1) = cmbaño2.Text & "/08"
            ElseIf cmbmes2.SelectedIndex = 9 Then
                gsRptArgs(1) = cmbaño2.Text & "/09"
            ElseIf cmbmes2.SelectedIndex = 10 Then
                gsRptArgs(1) = cmbaño2.Text & "/10"
            ElseIf cmbmes2.SelectedIndex = 11 Then
                gsRptArgs(1) = cmbaño2.Text & "/11"
            ElseIf cmbmes2.SelectedIndex = 12 Then
                gsRptArgs(1) = cmbaño2.Text & "/12"
            End If
            gsRptArgs(2) = txtcliente1.Text
            gsRptArgs(3) = txtcliente2.Text
            gsRptArgs(4) = txtnumero1.Text
            gsRptArgs(5) = txtnumero2.Text


            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_LETRAS_CAMBIO.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        Else
            ReDim gsRptArgs(5)
            If cmbmes1.SelectedIndex = 1 Then
                gsRptArgs(0) = cmbaño.Text & "/01"
            ElseIf cmbmes1.SelectedIndex = 2 Then
                gsRptArgs(0) = cmbaño.Text & "/02"
            ElseIf cmbmes1.SelectedIndex = 3 Then
                gsRptArgs(0) = cmbaño.Text & "/03"
            ElseIf cmbmes1.SelectedIndex = 4 Then
                gsRptArgs(0) = cmbaño.Text & "/04"
            ElseIf cmbmes1.SelectedIndex = 5 Then
                gsRptArgs(0) = cmbaño.Text & "/05"
            ElseIf cmbmes1.SelectedIndex = 6 Then
                gsRptArgs(0) = cmbaño.Text & "/06"
            ElseIf cmbmes1.SelectedIndex = 7 Then
                gsRptArgs(0) = cmbaño.Text & "/07"
            ElseIf cmbmes1.SelectedIndex = 8 Then
                gsRptArgs(0) = cmbaño.Text & "/08"
            ElseIf cmbmes1.SelectedIndex = 9 Then
                gsRptArgs(0) = cmbaño.Text & "/09"
            ElseIf cmbmes1.SelectedIndex = 10 Then
                gsRptArgs(0) = cmbaño.Text & "/10"
            ElseIf cmbmes1.SelectedIndex = 11 Then
                gsRptArgs(0) = cmbaño.Text & "/11"
            ElseIf cmbmes1.SelectedIndex = 12 Then
                gsRptArgs(0) = cmbaño.Text & "/12"
            End If
            If cmbmes2.SelectedIndex = 1 Then
                gsRptArgs(1) = cmbaño2.Text & "/01"
            ElseIf cmbmes2.SelectedIndex = 2 Then
                gsRptArgs(1) = cmbaño2.Text & "/02"
            ElseIf cmbmes2.SelectedIndex = 3 Then
                gsRptArgs(1) = cmbaño2.Text & "/03"
            ElseIf cmbmes2.SelectedIndex = 4 Then
                gsRptArgs(1) = cmbaño2.Text & "/04"
            ElseIf cmbmes2.SelectedIndex = 5 Then
                gsRptArgs(1) = cmbaño2.Text & "/05"
            ElseIf cmbmes2.SelectedIndex = 6 Then
                gsRptArgs(1) = cmbaño2.Text & "/06"
            ElseIf cmbmes2.SelectedIndex = 7 Then
                gsRptArgs(1) = cmbaño2.Text & "/07"
            ElseIf cmbmes2.SelectedIndex = 8 Then
                gsRptArgs(1) = cmbaño2.Text & "/08"
            ElseIf cmbmes2.SelectedIndex = 9 Then
                gsRptArgs(1) = cmbaño2.Text & "/09"
            ElseIf cmbmes2.SelectedIndex = 10 Then
                gsRptArgs(1) = cmbaño2.Text & "/10"
            ElseIf cmbmes2.SelectedIndex = 11 Then
                gsRptArgs(1) = cmbaño2.Text & "/11"
            ElseIf cmbmes2.SelectedIndex = 12 Then
                gsRptArgs(1) = cmbaño2.Text & "/12"
            End If
            gsRptArgs(2) = txtcliente1.Text
            gsRptArgs(3) = txtcliente2.Text
            gsRptArgs(4) = txtnumero1.Text
            gsRptArgs(5) = txtnumero2.Text


            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_LETRAS_CAMBIO_FC.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnreporte4_Click(sender As Object, e As EventArgs) Handles btnreporte4.Click
        Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "235"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente3.Text = gLinea
            txtnomcli3.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "39"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente4.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub txtcliente1_LostFocus(sender As Object, e As EventArgs) Handles txtcliente1.LostFocus
        If txtcliente1.TextLength > 0 Then
            Dim prov As String = PROVISIONESBL.SelectT_Prov(txtcliente1.Text)
            If prov.Length > 0 Then
                txtnomcli1.Text = prov
            Else
                txtnomcli1.Text = ""
            End If
        Else
            txtcliente1.Text = ""
            txtnomcli1.Text = ""
        End If
    End Sub

    Private Sub txtcliente2_LostFocus(sender As Object, e As EventArgs) Handles txtcliente2.LostFocus
        If txtcliente2.TextLength > 0 Then
            Dim prov As String = PROVISIONESBL.SelectT_Prov(txtcliente2.Text)
            If prov.Length > 0 Then
                txtnomcli2.Text = prov
            Else
                txtnomcli2.Text = ""
            End If
        Else
            txtcliente2.Text = ""
            txtnomcli2.Text = ""
        End If
    End Sub

    Private Sub txtcliente3_LostFocus(sender As Object, e As EventArgs) Handles txtcliente3.LostFocus
        If txtcliente3.TextLength > 0 Then
            Dim prov As String = PROVISIONESBL.SelectT_Prov(txtcliente3.Text)
            If prov.Length > 0 Then
                txtnomcli3.Text = prov
            Else
                txtnomcli3.Text = ""
            End If
        Else
            txtcliente3.Text = ""
            txtnomcli3.Text = ""
        End If
    End Sub

    Private Sub txtcliente4_LostFocus(sender As Object, e As EventArgs) Handles txtcliente4.LostFocus
        If txtcliente4.TextLength > 0 Then
            Dim prov As String = PROVISIONESBL.SelectT_Prov(txtcliente4.Text)
            If prov.Length > 0 Then
                txtnomcli4.Text = prov
            Else
                txtnomcli4.Text = ""
            End If
        Else
            txtcliente4.Text = ""
            txtnomcli4.Text = ""
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sBusAlm = "236"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtmon3.Text = gLinea
            txtnommon3.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sBusAlm = "236"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtmon4.Text = gLinea
            txtnommon4.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub txtmon3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmon3.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "236"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtmon3.Text = gLinea
                txtnommon3.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtmon4_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmon4.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "236"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtmon4.Text = gLinea
                txtnommon4.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtmon3_LostFocus(sender As Object, e As EventArgs) Handles txtmon3.LostFocus
        If txtmon3.TextLength = 2 Then
            Dim prov As String = FACTURACIONBL.SelNomMon(txtmon3.Text)
            If prov.Length > 0 Then
                txtnommon3.Text = prov
            Else
                txtnommon3.Text = ""
            End If
        Else
            txtmon3.Text = ""
            txtnommon3.Text = ""
        End If

    End Sub

    Private Sub txtmon4_LostFocus(sender As Object, e As EventArgs) Handles txtmon4.LostFocus
        If txtmon4.TextLength = 2 Then
            Dim prov As String = FACTURACIONBL.SelNomMon(txtmon4.Text)
            If prov.Length > 0 Then
                txtnommon4.Text = prov
            Else
                txtnommon4.Text = ""
            End If
        Else
            txtmon4.Text = ""
            txtnommon4.Text = ""
        End If
    End Sub

    Private Sub txtcliente2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente2.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "235"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtcliente2.Text = gLinea
                txtnomcli2.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtcliente1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcliente1.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "235"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtcliente1.Text = gLinea
                txtnomcli1.Text = gSubLinea
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
                txtnomcli3.Text = gSubLinea
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
                txtnomcli4.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub btnreporte3_Click(sender As Object, e As EventArgs) Handles btnreporte3.Click
        ReDim gsRptArgs(6)
        gsRptArgs(0) = cmbaño3.Text
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
        gsRptArgs(3) = txtcliente3.Text
        gsRptArgs(4) = txtcliente4.Text
        gsRptArgs(5) = txtmon3.Text
        gsRptArgs(6) = txtmon4.Text


        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_LETRAS_COMPRAS.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class