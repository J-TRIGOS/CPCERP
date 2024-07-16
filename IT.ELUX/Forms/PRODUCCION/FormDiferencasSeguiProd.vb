Public Class FormDiferencasSeguiProd
    Dim anho = 0
    Dim primero As Boolean
    Dim primero2 As Boolean

    Private Sub FormDiferencasSeguiProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        primero = True
        primero2 = True
        Me.Text = "Diferencias Consumo Ordenes de Producción"
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
        anho = cmbAnho.SelectedItem
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

    Private Function obtenerMesAct(ByVal index As Integer) As String
        Dim mes = ""
        Select Case index
            Case 0
                mes = "01"
            Case 1
                mes = "02"
            Case 2
                mes = "03"
            Case 3
                mes = "04"
            Case 4
                mes = "05"
            Case 5
                mes = "06"
            Case 6
                mes = "07"
            Case 7
                mes = "08"
            Case 8
                mes = "09"
            Case 9
                mes = "10"
            Case 10
                mes = "11"
            Case 11
                mes = "12"
        End Select
        Return mes
    End Function

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim mes = obtenerMesAct(cmbMes.SelectedIndex)
        Dim anho = cmbAnho.Text
        ReDim gsRptArgs(1)
        gsRptArgs(0) = mes
        gsRptArgs(1) = anho
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_PRODUCCION_ES.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class