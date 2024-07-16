Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormRPTAnaliticoLT

    Dim ELCAJABANCOBL As New ELCAJABANCOBL
    Private Sub FormRPTAnaliticoLT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Cajas y Bancos / Analitico de Letras"
        cmbaño.SelectedItem = sAño
        cmbaño1.SelectedItem = sAño
        cmbaño2.SelectedItem = sAño
        cmbmes1.SelectedItem = "Enero"
        cmbmes2.SelectedIndex = Month(Date.Today)
        cmbmes3.SelectedItem = "Enero"
        cmbmes4.SelectedIndex = Month(Date.Today)
        cmbAnhoS.SelectedItem = sAño
    End Sub
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub
    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(7)
        gsRptArgs(0) = cmbaño.Text
        gsRptArgs(1) = cmbaño1.Text
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
        gsRptArgs(4) = txtpv_w_cta_cod.Text
        gsRptArgs(5) = txtpv_w_cta_cod2.Text
        gsRptArgs(6) = txtt_ope1.Text
        gsRptArgs(7) = txtt_ope2.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTANALITICO_LT.rpt"
        gsRptPath = gsPathRpt
        FormReportes.Show()
    End Sub

    Private Sub FormRPTAnaliticoLT_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReDim gsRptArgs(2)
        gsRptArgs(0) = cmbaño2.Text
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
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_LIB_CAJA_BANCOS_P.rpt"
        gsRptPath = gsPathRpt
        FormReportes.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMesS.SelectedIndexChanged
        If cmbMesS.SelectedIndex = 1 Then
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
            cmbBanco.SelectedIndex = -1
            cmbMoneda.SelectedIndex = -1
            txtMonto.Text = Nothing
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim ELCAJABANCOBE As New ELCAJABANCOBE
        Dim EST As String
        ELCAJABANCOBE.anho = cmbAnhoS.Text
        If cmbMesS.SelectedIndex = 0 Then
            Exit Sub
        ElseIf cmbMesS.SelectedIndex = 1 Then
            If cmbBanco.Text = "CTA CTE 191-0328940-0-25" Then
                ELCAJABANCOBE.banco = "1"
            ElseIf cmbBanco.Text = "CTA CTE 191-0728461-1-01" Then
                ELCAJABANCOBE.banco = "2"
            ElseIf cmbBanco.Text = "CTA CTE 000395870" Then
                ELCAJABANCOBE.banco = "3"
            Else
                MessageBox.Show("Banco no Valido")
                Exit Sub
            End If
            If cmbMoneda.SelectedIndex = 0 Then
                ELCAJABANCOBE.moneda = "00"
            ElseIf cmbMoneda.SelectedIndex = 1 Then
                ELCAJABANCOBE.moneda = "01"
            Else
                MessageBox.Show("Ingresar moneda")
                Exit Sub
            End If
            If txtMonto.Text = "" Then
                MessageBox.Show("Ingresar monto")
                Exit Sub
            End If
            ELCAJABANCOBE.monto = txtMonto.Text
            ELCAJABANCOBE.mes = "01"
        ElseIf cmbMesS.SelectedIndex = 2 Then
            ELCAJABANCOBE.mes = "01"
            ELCAJABANCOBE.mes1 = "02"
        ElseIf cmbMesS.SelectedIndex = 3 Then
            ELCAJABANCOBE.mes = "02"
            ELCAJABANCOBE.mes1 = "03"
        ElseIf cmbMesS.SelectedIndex = 4 Then
            ELCAJABANCOBE.mes = "03"
            ELCAJABANCOBE.mes1 = "04"
        ElseIf cmbMesS.SelectedIndex = 5 Then
            ELCAJABANCOBE.mes = "04"
            ELCAJABANCOBE.mes1 = "05"
        ElseIf cmbMesS.SelectedIndex = 6 Then
            ELCAJABANCOBE.mes = "05"
            ELCAJABANCOBE.mes1 = "06"
        ElseIf cmbMesS.SelectedIndex = 7 Then
            ELCAJABANCOBE.mes = "06"
            ELCAJABANCOBE.mes1 = "07"
        ElseIf cmbMesS.SelectedIndex = 8 Then
            ELCAJABANCOBE.mes = "07"
            ELCAJABANCOBE.mes1 = "08"
        ElseIf cmbMesS.SelectedIndex = 9 Then
            ELCAJABANCOBE.mes = "08"
            ELCAJABANCOBE.mes1 = "09"
        ElseIf cmbMesS.SelectedIndex = 10 Then
            ELCAJABANCOBE.mes = "09"
            ELCAJABANCOBE.mes1 = "10"
        ElseIf cmbMesS.SelectedIndex = 11 Then
            ELCAJABANCOBE.mes = "10"
            ELCAJABANCOBE.mes1 = "11"
        ElseIf cmbMesS.SelectedIndex = 12 Then
            ELCAJABANCOBE.mes = "11"
            ELCAJABANCOBE.mes1 = "12"
        End If
        Dim DataSaldo As DataTable
        Dim tnom As String = "0"
        Dim tmes As String = "0"
        If cmbMesS.SelectedIndex = 1 Then
            DataSaldo = ELCAJABANCOBL.SelectDataInicial(ELCAJABANCOBE.anho, ELCAJABANCOBE.mes, ELCAJABANCOBE.banco, ELCAJABANCOBE.moneda)
            For Each row In DataSaldo.Rows
                tnom = IIf(IsDBNull(row("NRO")), "", row("NRO"))
            Next
            EST = "N1"
            If tnom <> "0" Then
                If MessageBox.Show("Inicial Existente, Desea continuar", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                Else
                    EST = "M1"
                End If
            End If

            gsError = ELCAJABANCOBL.SaveRow(ELCAJABANCOBE, EST)
        Else
            EST = "N"
            DataSaldo = ELCAJABANCOBL.SelectDataSaldos(ELCAJABANCOBE.anho, ELCAJABANCOBE.mes)
            For Each row In DataSaldo.Rows
                tnom = IIf(IsDBNull(row("NRO")), "", row("NRO"))
            Next
            DataSaldo = ELCAJABANCOBL.SelectDataSaldos(ELCAJABANCOBE.anho, ELCAJABANCOBE.mes1)
            For Each row In DataSaldo.Rows
                tmes = IIf(IsDBNull(row("NRO")), "", row("NRO"))
            Next
            If tnom = "0" Then
                MessageBox.Show("No se encontraron saldo del mes anterios")
                Exit Sub
            ElseIf tmes <> "0" Then
                If MessageBox.Show("Saldo del mes ya existente, Desea continuar", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                Else
                    EST = "M"
                End If
            ElseIf tnom <> "4" Then
                MessageBox.Show("Saldo de bancos incompletos")
                Exit Sub
            End If
            gsError = ELCAJABANCOBL.SaveRow(ELCAJABANCOBE, EST)
        End If

        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            'Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dispose()
    End Sub

    Private Sub cmbBanco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBanco.SelectedIndexChanged
        If cmbBanco.Text = "CTA CTE 191-0328940-0-25" Then
            cmbMoneda.SelectedIndex = 0
            cmbMoneda.Enabled = False
        ElseIf cmbBanco.Text = "CTA CTE 191-0728461-1-01" Then
            cmbMoneda.SelectedIndex = 0
            cmbMoneda.Enabled = True
        ElseIf cmbBanco.Text = "CTA CTE 000395870" Then
            cmbMoneda.SelectedIndex = 0
            cmbMoneda.Enabled = False
        End If
    End Sub
End Class