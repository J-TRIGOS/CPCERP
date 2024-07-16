Public Class FormResumenRentaQuinta
    Private Sub FormResumenRentaQuinta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbaño.SelectedItem = sAño
        cmbaño2.SelectedItem = sAño
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        Dim anho1 As String = cmbaño.SelectedItem
        Dim anho2 As String = cmbaño2.SelectedItem
        If cmbmes1.SelectedIndex < 1 And cmbmes2.SelectedIndex < 1 Then
            MsgBox("Seleccione el mes")
            Exit Sub
        End If

        If CmbTipTra.SelectedIndex < 0 Then
            MsgBox("Seleccione el Tipo Trabajdor")
            Exit Sub
        End If
        ReDim gsRptArgs(3)


        Select Case CmbTipTra.SelectedIndex
            Case 0
                gsRptArgs(2) = "20"
                gsRptArgs(3) = "21"
            Case 1
                gsRptArgs(2) = "21"
                gsRptArgs(3) = "21"
            Case 2
                gsRptArgs(2) = "20"
                gsRptArgs(3) = "20"
        End Select

        Select Case cmbmes1.SelectedIndex
            Case 1
                gsRptArgs(0) = anho1 + "/01"
            Case 2
                gsRptArgs(0) = anho1 + "/02"
            Case 3
                gsRptArgs(0) = anho1 + "/03"
            Case 4
                gsRptArgs(0) = anho1 + "/04"
            Case 5
                gsRptArgs(0) = anho1 + "/05"
            Case 6
                gsRptArgs(0) = anho1 + "/06"
            Case 7
                gsRptArgs(0) = anho1 + "/07"
            Case 8
                gsRptArgs(0) = anho1 + "/08"
            Case 9
                gsRptArgs(0) = anho1 + "/09"
            Case 10
                gsRptArgs(0) = anho1 + "/10"
            Case 11
                gsRptArgs(0) = anho1 + "/11"
            Case 12
                gsRptArgs(0) = anho1 + "/12"
        End Select
        Select Case cmbmes2.SelectedIndex
            Case 1
                gsRptArgs(1) = anho2 + "/01"
            Case 2
                gsRptArgs(1) = anho2 + "/02"
            Case 3
                gsRptArgs(1) = anho2 + "/03"
            Case 4
                gsRptArgs(1) = anho2 + "/04"
            Case 5
                gsRptArgs(1) = anho2 + "/05"
            Case 6
                gsRptArgs(1) = anho2 + "/06"
            Case 7
                gsRptArgs(1) = anho2 + "/07"
            Case 8
                gsRptArgs(1) = anho2 + "/08"
            Case 9
                gsRptArgs(1) = anho2 + "/09"
            Case 10
                gsRptArgs(1) = anho2 + "/10"
            Case 11
                gsRptArgs(1) = anho2 + "/11"
            Case 12
                gsRptArgs(1) = anho2 + "/12"
        End Select

        If ChkUtilidad.Checked = True Then
            reporteQuintaUtilidad()
        Else
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\SP_RPT02_RESUMEN_RENTA_QUINTA.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If
    End Sub

    Public Sub reporteQuintaUtilidad()
        ReDim gsRptArgs(6)

        gsRptArgs(0) = sAño
        Select Case cmbmes1.SelectedIndex
            Case 1
                gsRptArgs(1) = "01"
            Case 2
                gsRptArgs(1) = "02"
            Case 3
                gsRptArgs(1) = "03"
            Case 4
                gsRptArgs(1) = "04"
            Case 5
                gsRptArgs(1) = "05"
            Case 6
                gsRptArgs(1) = "06"
            Case 7
                gsRptArgs(1) = "07"
            Case 8
                gsRptArgs(1) = "08"
            Case 9
                gsRptArgs(1) = "09"
            Case 10
                gsRptArgs(1) = "10"
            Case 11
                gsRptArgs(1) = "11"
            Case 12
                gsRptArgs(1) = "12"
        End Select
        Select Case cmbmes2.SelectedIndex
            Case 1
                gsRptArgs(2) = "01"
            Case 2
                gsRptArgs(2) = "02"
            Case 3
                gsRptArgs(2) = "03"
            Case 4
                gsRptArgs(2) = "04"
            Case 5
                gsRptArgs(2) = "05"
            Case 6
                gsRptArgs(2) = "06"
            Case 7
                gsRptArgs(2) = "07"
            Case 8
                gsRptArgs(2) = "08"
            Case 9
                gsRptArgs(2) = "09"
            Case 10
                gsRptArgs(2) = "10"
            Case 11
                gsRptArgs(2) = "11"
            Case 12
                gsRptArgs(2) = "12"
        End Select

        Select Case CmbTipTra.SelectedIndex
            Case 0
                gsRptArgs(3) = "20"
                gsRptArgs(4) = "21"
            Case 1
                gsRptArgs(3) = "21"
                gsRptArgs(4) = "21"
            Case 2
                gsRptArgs(3) = "20"
                gsRptArgs(4) = "20"
        End Select
        gsRptArgs(5) = Nothing
        gsRptArgs(6) = Nothing

        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\SP_RPT02_RESUMEN_RENTA_QUINTA_UTILIDAD.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub
End Class