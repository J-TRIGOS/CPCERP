Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormRptFacturasAdelantadas
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private ARTICULOBL As New ARTICULOBL
    Private bprimero As Boolean
#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
#End Region
    Private Sub FormRptFacturasAdelantadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Facturas Adelantadas"
        cmbaño.SelectedItem = sAño
        cmbaño2.SelectedItem = sAño
        cmbaño3.SelectedItem = sAño
        cmbaño4.SelectedItem = sAño
        cmbaño5.SelectedItem = sAño
        cmbaño6.SelectedItem = sAño
        cmbmes1.SelectedItem = "Enero"
        cmbmes2.SelectedIndex = Month(Date.Today)
        cmbmes3.SelectedItem = "Enero"
        cmbmes4.SelectedIndex = Month(Date.Today)
        cmbmes5.SelectedItem = "Enero"
        cmbmes6.SelectedIndex = Month(Date.Today)
        bprimero = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtcliente1.Text = "" Then
            sBusAlm = "42"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtuni1.Text = gLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        Else
            sBusAlm = "84"
            Dim frm As New FormBUSQUEDA
            frm.medida = txtcliente1.Text
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtuni1.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtcliente2.Text = "" Then
            sBusAlm = "42"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtuni2.Text = gLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        Else
            sBusAlm = "84"
            Dim frm As New FormBUSQUEDA
            frm.medida = txtcliente2.Text
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtuni2.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "235"
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

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        sBusAlm = "39"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente3.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
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


    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ReDim gsRptArgs(3)
        If cmbmes3.SelectedIndex = 1 Then
            gsRptArgs(0) = cmbaño3.Text & "/01"
        ElseIf cmbmes3.SelectedIndex = 2 Then
            gsRptArgs(0) = cmbaño3.Text & "/02"
        ElseIf cmbmes3.SelectedIndex = 3 Then
            gsRptArgs(0) = cmbaño3.Text & "/03"
        ElseIf cmbmes3.SelectedIndex = 4 Then
            gsRptArgs(0) = cmbaño3.Text & "/04"
        ElseIf cmbmes3.SelectedIndex = 5 Then
            gsRptArgs(0) = cmbaño3.Text & "/05"
        ElseIf cmbmes3.SelectedIndex = 6 Then
            gsRptArgs(0) = cmbaño3.Text & "/06"
        ElseIf cmbmes3.SelectedIndex = 7 Then
            gsRptArgs(0) = cmbaño3.Text & "/07"
        ElseIf cmbmes3.SelectedIndex = 8 Then
            gsRptArgs(0) = cmbaño3.Text & "/08"
        ElseIf cmbmes3.SelectedIndex = 9 Then
            gsRptArgs(0) = cmbaño3.Text & "/09"
        ElseIf cmbmes3.SelectedIndex = 10 Then
            gsRptArgs(0) = cmbaño3.Text & "/10"
        ElseIf cmbmes3.SelectedIndex = 11 Then
            gsRptArgs(0) = cmbaño3.Text & "/11"
        ElseIf cmbmes3.SelectedIndex = 12 Then
            gsRptArgs(0) = cmbaño3.Text & "/12"
        End If
        If cmbmes4.SelectedIndex = 1 Then
            gsRptArgs(1) = cmbaño4.Text & "/01"
        ElseIf cmbmes4.SelectedIndex = 2 Then
            gsRptArgs(1) = cmbaño4.Text & "/02"
        ElseIf cmbmes4.SelectedIndex = 3 Then
            gsRptArgs(1) = cmbaño4.Text & "/03"
        ElseIf cmbmes4.SelectedIndex = 4 Then
            gsRptArgs(1) = cmbaño4.Text & "/04"
        ElseIf cmbmes4.SelectedIndex = 5 Then
            gsRptArgs(1) = cmbaño4.Text & "/05"
        ElseIf cmbmes4.SelectedIndex = 6 Then
            gsRptArgs(1) = cmbaño4.Text & "/06"
        ElseIf cmbmes4.SelectedIndex = 7 Then
            gsRptArgs(1) = cmbaño4.Text & "/07"
        ElseIf cmbmes4.SelectedIndex = 8 Then
            gsRptArgs(1) = cmbaño4.Text & "/08"
        ElseIf cmbmes4.SelectedIndex = 9 Then
            gsRptArgs(1) = cmbaño4.Text & "/09"
        ElseIf cmbmes4.SelectedIndex = 10 Then
            gsRptArgs(1) = cmbaño4.Text & "/10"
        ElseIf cmbmes4.SelectedIndex = 11 Then
            gsRptArgs(1) = cmbaño4.Text & "/11"
        ElseIf cmbmes4.SelectedIndex = 12 Then
            gsRptArgs(1) = cmbaño4.Text & "/12"
        End If
        gsRptArgs(2) = txtcliente3.Text
        gsRptArgs(3) = txtcliente4.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_FACT_ADELA_PEND.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()

    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(9)
        Cursor.Current = Cursors.WaitCursor
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
            gsRptArgs(1) = cmbaño2.Text & "01"
        ElseIf cmbmes2.SelectedIndex = 2 Then
            gsRptArgs(1) = cmbaño2.Text & "02"
        ElseIf cmbmes2.SelectedIndex = 3 Then
            gsRptArgs(1) = cmbaño2.Text & "03"
        ElseIf cmbmes2.SelectedIndex = 4 Then
            gsRptArgs(1) = cmbaño2.Text & "04"
        ElseIf cmbmes2.SelectedIndex = 5 Then
            gsRptArgs(1) = cmbaño2.Text & "05"
        ElseIf cmbmes2.SelectedIndex = 6 Then
            gsRptArgs(1) = cmbaño2.Text & "06"
        ElseIf cmbmes2.SelectedIndex = 7 Then
            gsRptArgs(1) = cmbaño2.Text & "07"
        ElseIf cmbmes2.SelectedIndex = 8 Then
            gsRptArgs(1) = cmbaño2.Text & "08"
        ElseIf cmbmes2.SelectedIndex = 9 Then
            gsRptArgs(1) = cmbaño2.Text & "09"
        ElseIf cmbmes2.SelectedIndex = 10 Then
            gsRptArgs(1) = cmbaño2.Text & "10"
        ElseIf cmbmes2.SelectedIndex = 11 Then
            gsRptArgs(1) = cmbaño2.Text & "11"
        ElseIf cmbmes2.SelectedIndex = 12 Then
            gsRptArgs(1) = cmbaño2.Text & "12"
        End If
        gsRptArgs(2) = txtcliente1.Text
        gsRptArgs(3) = txtcliente2.Text
        gsRptArgs(4) = txtnumero1.Text
        gsRptArgs(5) = txtnumero2.Text
        gsRptArgs(6) = txtuni1.Text
        gsRptArgs(7) = txtuni2.Text
        If cmbt_env1.SelectedIndex = 0 Then
            gsRptArgs(8) = "PUB"
        ElseIf cmbt_env1.SelectedIndex = 1 Then
            gsRptArgs(8) = "IND"
        ElseIf cmbt_env1.SelectedIndex = 2 Then
            gsRptArgs(8) = "TWO"
        ElseIf cmbt_env1.SelectedIndex = 3 Then
            gsRptArgs(8) = "CAR"
        Else
            gsRptArgs(8) = ""
        End If
        If cmbt_env2.SelectedIndex = 0 Then
            gsRptArgs(9) = "PUB"
        ElseIf cmbt_env2.SelectedIndex = 1 Then
            gsRptArgs(9) = "IND"
        ElseIf cmbt_env2.SelectedIndex = 2 Then
            gsRptArgs(9) = "TWO"
        ElseIf cmbt_env2.SelectedIndex = 3 Then
            gsRptArgs(9) = "CAR"
        Else
            gsRptArgs(9) = ""
        End If

        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_FACT_ADELA.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormRptFacturasAdelantadas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        sBusAlm = "39"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente5.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        sBusAlm = "39"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtcliente6.Text = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Dispose()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ReDim gsRptArgs(3)
        If cmbmes5.SelectedIndex = 1 Then
            gsRptArgs(0) = cmbaño5.Text & "/01"
        ElseIf cmbmes5.SelectedIndex = 2 Then
            gsRptArgs(0) = cmbaño5.Text & "/02"
        ElseIf cmbmes5.SelectedIndex = 3 Then
            gsRptArgs(0) = cmbaño5.Text & "/03"
        ElseIf cmbmes5.SelectedIndex = 4 Then
            gsRptArgs(0) = cmbaño5.Text & "/04"
        ElseIf cmbmes5.SelectedIndex = 5 Then
            gsRptArgs(0) = cmbaño5.Text & "/05"
        ElseIf cmbmes5.SelectedIndex = 6 Then
            gsRptArgs(0) = cmbaño5.Text & "/06"
        ElseIf cmbmes5.SelectedIndex = 7 Then
            gsRptArgs(0) = cmbaño5.Text & "/07"
        ElseIf cmbmes5.SelectedIndex = 8 Then
            gsRptArgs(0) = cmbaño5.Text & "/08"
        ElseIf cmbmes5.SelectedIndex = 9 Then
            gsRptArgs(0) = cmbaño5.Text & "/09"
        ElseIf cmbmes5.SelectedIndex = 10 Then
            gsRptArgs(0) = cmbaño5.Text & "/10"
        ElseIf cmbmes5.SelectedIndex = 11 Then
            gsRptArgs(0) = cmbaño5.Text & "/11"
        ElseIf cmbmes5.SelectedIndex = 12 Then
            gsRptArgs(0) = cmbaño5.Text & "/12"
        End If
        If cmbmes6.SelectedIndex = 1 Then
            gsRptArgs(1) = cmbaño6.Text & "/01"
        ElseIf cmbmes6.SelectedIndex = 2 Then
            gsRptArgs(1) = cmbaño6.Text & "/02"
        ElseIf cmbmes6.SelectedIndex = 3 Then
            gsRptArgs(1) = cmbaño6.Text & "/03"
        ElseIf cmbmes6.SelectedIndex = 4 Then
            gsRptArgs(1) = cmbaño6.Text & "/04"
        ElseIf cmbmes6.SelectedIndex = 5 Then
            gsRptArgs(1) = cmbaño6.Text & "/05"
        ElseIf cmbmes6.SelectedIndex = 6 Then
            gsRptArgs(1) = cmbaño6.Text & "/06"
        ElseIf cmbmes6.SelectedIndex = 7 Then
            gsRptArgs(1) = cmbaño6.Text & "/07"
        ElseIf cmbmes6.SelectedIndex = 8 Then
            gsRptArgs(1) = cmbaño6.Text & "/08"
        ElseIf cmbmes6.SelectedIndex = 9 Then
            gsRptArgs(1) = cmbaño6.Text & "/09"
        ElseIf cmbmes6.SelectedIndex = 10 Then
            gsRptArgs(1) = cmbaño6.Text & "/10"
        ElseIf cmbmes6.SelectedIndex = 11 Then
            gsRptArgs(1) = cmbaño6.Text & "/11"
        ElseIf cmbmes6.SelectedIndex = 12 Then
            gsRptArgs(1) = cmbaño6.Text & "/12"
        End If
        gsRptArgs(2) = txtcliente5.Text
        gsRptArgs(3) = txtcliente6.Text


        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_FACT_ADELA_PEND_ART.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class