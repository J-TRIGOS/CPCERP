Imports CrystalDecisions.CrystalReports.Engine
Imports itDLL

Public Class FormReportes

    Dim rpt As ReportDocument = New ReportDocument()
    Public gsPathReports = Application.StartupPath

    Private Sub crpReport_Load(sender As Object, e As EventArgs) Handles crpReport.Load
        Try
            gsPathReports = gsRptPath '"c:\app\report1_LUXparametros.rpt"

            Dim sPath = Application.StartupPath

            ViewReport(gsPathReports, gsRptArgs)
            'ViewReport(sPath & gsRptPath, gsRptArgs)

            Me.WindowState = FormWindowState.Maximized

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        gsPathReports = ""
        gsRptPath = ""
        gsPathRpt = ""

    End Sub

    Friend Sub ViewReport(ByVal sReportName As String, Optional sParam() As Object = Nothing)
        Dim rpt As New crystalDecision

        Cursor.Current = Cursors.WaitCursor
        'Declaring variablesables

        'Crystal Report's report document object
        Dim objReport As New _
            CrystalDecisions.CrystalReports.Engine.ReportDocument

        'object of table Log on info of Crystal report
        Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo

        'Parameter value object of crystal report 
        ' parameters used for adding the value to parameter.
        Dim paraValue As New CrystalDecisions.Shared.ParameterDiscreteValue


        Try
            objReport = rpt.crystalConnect(sReportName, "logi", "lvxserver", sParam)

            crpReport.ReportSource = objReport
            crpReport.Refresh()
            'Show the report
            'crpReport.Show()

        Catch ex As System.Exception
            Cursor.Current = Cursors.Default
            MsgBox(ex.Message)
        End Try
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub FormReportes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 27 Then
            'If (e.KeyCode = Keys.Escape) Then
            Me.Dispose()
        End If
    End Sub
End Class