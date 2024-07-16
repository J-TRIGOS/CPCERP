Public Class FormRptRegVentas
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
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

    Private Sub FormRptRegVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Registro de Ventas"
        cmbaño.SelectedItem = sAño
        cmbaño2.SelectedItem = sAño
        cmbaño3.SelectedItem = sAño
        cmbmes1.SelectedIndex = Month(Date.Today)
        cmbmes2.SelectedIndex = Month(Date.Today)
        cmbmes3.SelectedIndex = Month(Date.Today)
        cmbmes4.SelectedIndex = Month(Date.Today)
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        If cmbmoneda.SelectedIndex = -1 Or cmbmoneda.SelectedIndex = 0 Then
            ReDim gsRptArgs(7)
            gsRptArgs(0) = cmbaño.SelectedItem
            gsRptArgs(1) = cmbaño2.SelectedItem
            If cmbmes1.SelectedIndex = 1 Then
                gsRptArgs(2) = "01"
            ElseIf cmbmes1.SelectedIndex = 2 Then
                gsRptArgs(2) = "02"
            ElseIf cmbmes1.SelectedIndex = 3 Then
                gsRptArgs(2) = "03"
            ElseIf cmbmes1.SelectedIndex = 4 Then
                gsRptArgs(2) = "04"
            ElseIf cmbmes1.SelectedIndex = 5 Then
                gsRptArgs(2) = "05"
            ElseIf cmbmes1.SelectedIndex = 6 Then
                gsRptArgs(2) = "06"
            ElseIf cmbmes1.SelectedIndex = 7 Then
                gsRptArgs(2) = "07"
            ElseIf cmbmes1.SelectedIndex = 8 Then
                gsRptArgs(2) = "08"
            ElseIf cmbmes1.SelectedIndex = 9 Then
                gsRptArgs(2) = "09"
            ElseIf cmbmes1.SelectedIndex = 10 Then
                gsRptArgs(2) = "10"
            ElseIf cmbmes1.SelectedIndex = 11 Then
                gsRptArgs(2) = "11"
            ElseIf cmbmes1.SelectedIndex = 12 Then
                gsRptArgs(2) = "12"
            End If
            If cmbmes2.SelectedIndex = 1 Then
                gsRptArgs(3) = "01"
            ElseIf cmbmes2.SelectedIndex = 2 Then
                gsRptArgs(3) = "02"
            ElseIf cmbmes2.SelectedIndex = 3 Then
                gsRptArgs(3) = "03"
            ElseIf cmbmes2.SelectedIndex = 4 Then
                gsRptArgs(3) = "04"
            ElseIf cmbmes2.SelectedIndex = 5 Then
                gsRptArgs(3) = "05"
            ElseIf cmbmes2.SelectedIndex = 6 Then
                gsRptArgs(3) = "06"
            ElseIf cmbmes2.SelectedIndex = 7 Then
                gsRptArgs(3) = "07"
            ElseIf cmbmes2.SelectedIndex = 8 Then
                gsRptArgs(3) = "08"
            ElseIf cmbmes2.SelectedIndex = 9 Then
                gsRptArgs(3) = "09"
            ElseIf cmbmes2.SelectedIndex = 10 Then
                gsRptArgs(3) = "10"
            ElseIf cmbmes2.SelectedIndex = 11 Then
                gsRptArgs(3) = "11"
            ElseIf cmbmes2.SelectedIndex = 12 Then
                gsRptArgs(3) = "12"
            End If
            gsRptArgs(4) = txtcliente1.Text
            gsRptArgs(5) = txtcliente2.Text
            If cmbtipo1.SelectedIndex = 1 Then
                gsRptArgs(6) = "NAC"
            ElseIf cmbtipo1.SelectedIndex = 2 Then
                gsRptArgs(6) = "EXP"
            Else
                gsRptArgs(6) = ""
            End If
            If cmbtipo2.SelectedIndex = 1 Then
                gsRptArgs(7) = "NAC"
            ElseIf cmbtipo2.SelectedIndex = 2 Then
                gsRptArgs(7) = "EXP"
            Else
                gsRptArgs(7) = ""
            End If
            'gsRptArgs(7) = txtcliente2.Text

            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_REG_VENTAS.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        Else
            ReDim gsRptArgs(8)
            gsRptArgs(0) = cmbaño.SelectedItem
            gsRptArgs(1) = cmbaño2.SelectedItem
            If cmbmes1.SelectedIndex = 1 Then
                gsRptArgs(2) = "01"
            ElseIf cmbmes1.SelectedIndex = 2 Then
                gsRptArgs(2) = "02"
            ElseIf cmbmes1.SelectedIndex = 3 Then
                gsRptArgs(2) = "03"
            ElseIf cmbmes1.SelectedIndex = 4 Then
                gsRptArgs(2) = "04"
            ElseIf cmbmes1.SelectedIndex = 5 Then
                gsRptArgs(2) = "05"
            ElseIf cmbmes1.SelectedIndex = 6 Then
                gsRptArgs(2) = "06"
            ElseIf cmbmes1.SelectedIndex = 7 Then
                gsRptArgs(2) = "07"
            ElseIf cmbmes1.SelectedIndex = 8 Then
                gsRptArgs(2) = "08"
            ElseIf cmbmes1.SelectedIndex = 9 Then
                gsRptArgs(2) = "09"
            ElseIf cmbmes1.SelectedIndex = 10 Then
                gsRptArgs(2) = "10"
            ElseIf cmbmes1.SelectedIndex = 11 Then
                gsRptArgs(2) = "11"
            ElseIf cmbmes1.SelectedIndex = 12 Then
                gsRptArgs(2) = "12"
            End If
            If cmbmes2.SelectedIndex = 1 Then
                gsRptArgs(3) = "01"
            ElseIf cmbmes2.SelectedIndex = 2 Then
                gsRptArgs(3) = "02"
            ElseIf cmbmes2.SelectedIndex = 3 Then
                gsRptArgs(3) = "03"
            ElseIf cmbmes2.SelectedIndex = 4 Then
                gsRptArgs(3) = "04"
            ElseIf cmbmes2.SelectedIndex = 5 Then
                gsRptArgs(3) = "05"
            ElseIf cmbmes2.SelectedIndex = 6 Then
                gsRptArgs(3) = "06"
            ElseIf cmbmes2.SelectedIndex = 7 Then
                gsRptArgs(3) = "07"
            ElseIf cmbmes2.SelectedIndex = 8 Then
                gsRptArgs(3) = "08"
            ElseIf cmbmes2.SelectedIndex = 9 Then
                gsRptArgs(3) = "09"
            ElseIf cmbmes2.SelectedIndex = 10 Then
                gsRptArgs(3) = "10"
            ElseIf cmbmes2.SelectedIndex = 11 Then
                gsRptArgs(3) = "11"
            ElseIf cmbmes2.SelectedIndex = 12 Then
                gsRptArgs(3) = "12"
            End If
            gsRptArgs(4) = txtcliente1.Text
            gsRptArgs(5) = txtcliente2.Text
            If cmbtipo1.SelectedIndex = 1 Then
                gsRptArgs(6) = "NAC"
            ElseIf cmbtipo1.SelectedIndex = 2 Then
                gsRptArgs(6) = "EXP"
            Else
                gsRptArgs(6) = ""
            End If
            If cmbtipo2.SelectedIndex = 1 Then
                gsRptArgs(7) = "NAC"
            ElseIf cmbtipo2.SelectedIndex = 2 Then
                gsRptArgs(7) = "EXP"
            Else
                gsRptArgs(7) = ""
            End If
            If cmbmoneda.SelectedIndex = 1 Then
                gsRptArgs(8) = "00"
            Else
                gsRptArgs(8) = "01"
            End If
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_REG_VENTAS_MONEDA.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dispose()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ReDim gsRptArgs(6)
        gsRptArgs(0) = txtcliente1.Text
        gsRptArgs(1) = txtcliente2.Text
        gsRptArgs(2) = cmbaño.SelectedItem

        If cmbmes3.SelectedIndex = 1 Then
            gsRptArgs(3) = "01"
        ElseIf cmbmes3.SelectedIndex = 2 Then
            gsRptArgs(3) = "02"
        ElseIf cmbmes3.SelectedIndex = 3 Then
            gsRptArgs(3) = "03"
        ElseIf cmbmes3.SelectedIndex = 4 Then
            gsRptArgs(3) = "04"
        ElseIf cmbmes3.SelectedIndex = 5 Then
            gsRptArgs(3) = "05"
        ElseIf cmbmes3.SelectedIndex = 6 Then
            gsRptArgs(3) = "06"
        ElseIf cmbmes3.SelectedIndex = 7 Then
            gsRptArgs(3) = "07"
        ElseIf cmbmes3.SelectedIndex = 8 Then
            gsRptArgs(3) = "08"
        ElseIf cmbmes3.SelectedIndex = 9 Then
            gsRptArgs(3) = "09"
        ElseIf cmbmes3.SelectedIndex = 10 Then
            gsRptArgs(3) = "10"
        ElseIf cmbmes3.SelectedIndex = 11 Then
            gsRptArgs(3) = "11"
        ElseIf cmbmes3.SelectedIndex = 12 Then
            gsRptArgs(3) = "12"
        End If
        If cmbmes4.SelectedIndex = 1 Then
            gsRptArgs(4) = "01"
        ElseIf cmbmes4.SelectedIndex = 2 Then
            gsRptArgs(4) = "02"
        ElseIf cmbmes4.SelectedIndex = 3 Then
            gsRptArgs(4) = "03"
        ElseIf cmbmes4.SelectedIndex = 4 Then
            gsRptArgs(4) = "04"
        ElseIf cmbmes4.SelectedIndex = 5 Then
            gsRptArgs(4) = "05"
        ElseIf cmbmes4.SelectedIndex = 6 Then
            gsRptArgs(4) = "06"
        ElseIf cmbmes4.SelectedIndex = 7 Then
            gsRptArgs(4) = "07"
        ElseIf cmbmes4.SelectedIndex = 8 Then
            gsRptArgs(4) = "08"
        ElseIf cmbmes4.SelectedIndex = 9 Then
            gsRptArgs(4) = "09"
        ElseIf cmbmes4.SelectedIndex = 10 Then
            gsRptArgs(4) = "10"
        ElseIf cmbmes4.SelectedIndex = 11 Then
            gsRptArgs(4) = "11"
        ElseIf cmbmes4.SelectedIndex = 12 Then
            gsRptArgs(4) = "12"
        End If
        gsRptArgs(5) = txtnum1.Text
        gsRptArgs(6) = txtnum2.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_LETRA_FACTURA.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class