Imports IT.ELUX.BL
Public Class FormFlujoProyectado

    Dim mesACT = "MES"
    Dim mesANT = "MES"
    Dim anho = 0
    Dim prdo = 0
    Dim diaACT = "DIA"
    Dim diaANT = "DIA"
    Dim FLUJOPROYECTADOBL As New FLUJOPROYECTADOBL

    Private Sub FormFlujoProyectado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Flujo Proyectado"
        getCmbAño(cmbAnho)
        getCmbMes(cmbMes)
        Select Case Today.Year
            Case 2019
                cmbAnho.SelectedIndex = 0
            Case 2020
                cmbAnho.SelectedIndex = 1
            Case 2021
                cmbAnho.SelectedIndex = 2
            Case 2022
                cmbAnho.SelectedIndex = 3
            Case 2023
                cmbAnho.SelectedIndex = 4
            Case 2024
                cmbAnho.SelectedIndex = 5
            Case 2025
                cmbAnho.SelectedIndex = 5
        End Select
        'cmbMes.SelectedIndex = Today.Month - 1
        cmbMes.SelectedIndex = 0
        cmbMes.Enabled = False
        anho = cmbAnho.SelectedItem
        Dim dtCuentas As New DataTable
        'dtCuentas = FLUJOPROYECTADOBL.CalcularMontos(anho)
    End Sub

    Private Function getCmbAño(ByVal cmb As ComboBox)
        cmb.Items.Clear()
        cmb.Items.Add("2019")
        cmb.Items.Add("2020")
        cmb.Items.Add("2021")
        cmb.Items.Add("2022")
        cmb.Items.Add("2023")
        cmb.Items.Add("2024")
        cmb.Items.Add("2025")
    End Function

    Private Function getCmbMes(ByVal cmb As ComboBox)
        cmb.Items.Clear()
        cmb.Items.Add("Enero")
        cmb.Items.Add("Febrero")
        cmb.Items.Add("Marzo")
        cmb.Items.Add("Abril")
        cmb.Items.Add("Mayo")
        cmb.Items.Add("Junio")
        cmb.Items.Add("Julio")
        cmb.Items.Add("Agosto")
        cmb.Items.Add("Septiembre")
        cmb.Items.Add("Octubre")
        cmb.Items.Add("Noviembre")
        cmb.Items.Add("Diciembre")
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not chkFlujo.Checked = True Then
            calcularFlujoAnual()
        Else
            calcularFlujoMensual()
        End If
    End Sub

    Sub calcularFlujoAnual()
        For i = 0 To 11
            mesACT = obtenerMesAct(i)
            mesANT = obtenermesAnt(i)
            anho = cmbAnho.SelectedItem

            Dim dtPeriodo = FLUJOPROYECTADOBL.buscarPeriodo(mesACT.Substring(3, 2), anho)
            If dtPeriodo.Rows.Count > 0 Then
                prdo = dtPeriodo.Rows(0).Item(0)
            Else
                prdo = 0
            End If

            Dim resultado As String = FLUJOPROYECTADOBL.FlujoProyectadoAnual(anho, mesACT, mesANT, prdo, i)
        Next

        ReDim gsRptArgs(0)
            gsRptArgs(0) = anho
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT_FLUJOPROYECTADO_ANUAL.rpt"
            gsRptPath = gsPathRpt
        FormReportes.Show()
    End Sub
    Sub calcularFlujoMensual()
        Dim anho = cmbAnho.SelectedItem
        Dim mes = cmbMes.SelectedIndex + 1
        Dim dias = System.DateTime.DaysInMonth(anho, mes)
        Dim mesAct = obtenerMesAct(mes - 1)
        Dim resultado As String = ""

        Dim dtPeriodo = FLUJOPROYECTADOBL.buscarPeriodo(mesACT.Substring(3, 2), anho)
        If dtPeriodo.Rows.Count > 0 Then
            prdo = dtPeriodo.Rows(0).Item(0)
        Else
            prdo = 0
        End If

        For i = 1 To dias
            diaACT = obtenerDiaAct(i)
            diaANT = obtenerDiaAnt(i, mes)
            resultado = FLUJOPROYECTADOBL.FlujoProyectadoMensual(anho, mes, i, diaACT, diaANT, prdo, dias)
        Next
        Dim rpt As New FormReportes
        Dim rpt1 As New FormReportes
        If resultado = "OK" Then
            ReDim gsRptArgs(2)
            gsRptArgs(0) = anho
            gsRptArgs(1) = mes
            gsRptArgs(2) = dias
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT_FLUJOPROYECTADO_MENSUAL-1Q.rpt"
            gsRptPath = gsPathRpt
            rpt.Show()
            Dim gsRptArgs1(2)
            gsRptArgs1(0) = anho
            gsRptArgs1(1) = mes
            gsRptArgs1(2) = dias
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT_FLUJOPROYECTADO_MENSUAL-2Q.rpt"
            gsRptPath = gsPathRpt
            rpt1.Show()
            MsgBox(resultado)
        End If
    End Sub

    Private Function obtenerDiaAct(ByVal index As Integer) As String
        Dim dia = ""
        Select Case index
            Case 1
                dia = "DIA01"
            Case 2
                dia = "DIA02"
            Case 3
                dia = "DIA03"
            Case 4
                dia = "DIA04"
            Case 5
                dia = "DIA05"
            Case 6
                dia = "DIA06"
            Case 7
                dia = "DIA07"
            Case 8
                dia = "DIA08"
            Case 9
                dia = "DIA09"
            Case 10
                dia = "DIA10"
            Case 11
                dia = "DIA11"
            Case 12
                dia = "DIA12"
            Case 13
                dia = "DIA13"
            Case 14
                dia = "DIA14"
            Case 15
                dia = "DIA15"
            Case 16
                dia = "DIA16"
            Case 17
                dia = "DIA17"
            Case 18
                dia = "DIA18"
            Case 19
                dia = "DIA19"
            Case 20
                dia = "DIA20"
            Case 21
                dia = "DIA21"
            Case 22
                dia = "DIA22"
            Case 23
                dia = "DIA23"
            Case 24
                dia = "DIA24"
            Case 25
                dia = "DIA25"
            Case 26
                dia = "DIA26"
            Case 27
                dia = "DIA27"
            Case 28
                dia = "DIA28"
            Case 29
                dia = "DIA29"
            Case 30
                dia = "DIA30"
            Case 31
                dia = "DIA31"
        End Select
        Return dia
    End Function

    Private Function obtenerDiaAnt(ByVal index As Integer, ByVal mes As String) As String
        Dim dia = ""
        Select Case index
            Case 1
                If mes = 5 Or mes = 7 Or mes = 10 Or mes = 12 Then
                    dia = "DIA30"
                Else
                    If mes = 1 Or mes = 2 Or mes = 4 Or mes = 6 Or mes = 8 Or mes = 9 Or mes = 11 Then
                        dia = "DIA31"
                    Else
                        If DateTime.IsLeapYear(anho) = True And mes = 3 Then
                            dia = "DIA29"
                        Else
                            dia = "DIA28"
                        End If
                    End If
                End If
            Case 2
                dia = "DIA01"
            Case 3
                dia = "DIA02"
            Case 4
                dia = "DIA03"
            Case 5
                dia = "DIA04"
            Case 6
                dia = "DIA05"
            Case 7
                dia = "DIA06"
            Case 8
                dia = "DIA07"
            Case 9
                dia = "DIA08"
            Case 10
                dia = "DIA09"
            Case 11
                dia = "DIA10"
            Case 12
                dia = "DIA11"
            Case 13
                dia = "DIA12"
            Case 14
                dia = "DIA13"
            Case 15
                dia = "DIA14"
            Case 16
                dia = "DIA15"
            Case 17
                dia = "DIA16"
            Case 18
                dia = "DIA17"
            Case 19
                dia = "DIA18"
            Case 20
                dia = "DIA19"
            Case 21
                dia = "DIA20"
            Case 22
                dia = "DIA21"
            Case 23
                dia = "DIA22"
            Case 24
                dia = "DIA23"
            Case 25
                dia = "DIA24"
            Case 26
                dia = "DIA25"
            Case 27
                dia = "DIA26"
            Case 28
                dia = "DIA27"
            Case 29
                dia = "DIA28"
            Case 30
                dia = "DIA29"
            Case 31
                dia = "DIA30"
        End Select
        Return dia
    End Function

    Private Function obtenerMesAct(ByVal index As Integer) As String
        Dim mes = ""
        Select Case index
            Case 0
                mes = "MES01"
            Case 1
                mes = "MES02"
            Case 2
                mes = "MES03"
            Case 3
                mes = "MES04"
            Case 4
                mes = "MES05"
            Case 5
                mes = "MES06"
            Case 6
                mes = "MES07"
            Case 7
                mes = "MES08"
            Case 8
                mes = "MES09"
            Case 9
                mes = "MES10"
            Case 10
                mes = "MES11"
            Case 11
                mes = "MES12"
        End Select
        Return mes
    End Function

    Private Function obtenermesAnt(ByVal index As Integer) As String
        Dim mes = ""
        Select Case index
            Case 0
                mes = "MES12"
            Case 1
                mes = "MES01"
            Case 2
                mes = "MES02"
            Case 3
                mes = "MES03"
            Case 4
                mes = "MES04"
            Case 5
                mes = "MES05"
            Case 6
                mes = "MES06"
            Case 7
                mes = "MES07"
            Case 8
                mes = "MES08"
            Case 9
                mes = "MES09"
            Case 10
                mes = "MES10"
            Case 11
                mes = "MES11"
        End Select
        Return mes
    End Function

    Private Sub chkFlujo_CheckedChanged(sender As Object, e As EventArgs) Handles chkFlujo.CheckedChanged
        If chkFlujo.Checked = True Then
            cmbMes.Enabled = True
        Else
            cmbMes.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        anho = cmbAnho.SelectedItem
        Dim mes = cmbMes.SelectedIndex + 1
        Dim dias = System.DateTime.DaysInMonth(anho, mes)
        Dim rpt As New FormReportes
        Dim rpt1 As New FormReportes
        If chkFlujo.Checked = True Then
            ReDim gsRptArgs(2)
            gsRptArgs(0) = anho
            gsRptArgs(1) = mes
            gsRptArgs(2) = dias
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT_FLUJOPROYECTADO_MENSUAL-1Q.rpt"
            gsRptPath = gsPathRpt
            rpt.Show()
            Dim gsRptArgs1(2)
            gsRptArgs1(0) = anho
            gsRptArgs1(1) = mes
            gsRptArgs1(2) = dias
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT_FLUJOPROYECTADO_MENSUAL-2Q.rpt"
            gsRptPath = gsPathRpt
            rpt1.Show()
        Else
            ReDim gsRptArgs(0)
            gsRptArgs(0) = anho
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT_FLUJOPROYECTADO_ANUAL.rpt"
            gsRptPath = gsPathRpt
            FormReportes.Show()
        End If

    End Sub
End Class