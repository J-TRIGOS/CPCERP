Imports IT.ELUX.BE
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.DAL

Public Class CTSBL
    Dim CTSDAL As New CTSDAL
    Public Function ActualizarTablaCTS(ByVal PRDO As String) As String
        Dim RESULTADO
        RESULTADO = CTSDAL.SaveRow(PRDO)
        Return RESULTADO
    End Function

    Public Function ObtenerPagoCts(ByVal periodoGratiCTS As String, ByVal periodoIni As String, ByVal periodoFin As String, ByVal FechaFin As String, ByVal tipoCambio As String) As DataTable
        Dim DtPagodtPagoCts As New DataTable
        DtPagodtPagoCts = CTSDAL.ObtenerPagoCts(periodoGratiCTS, periodoIni, periodoFin, FechaFin, tipoCambio)
        Return DtPagodtPagoCts
    End Function

    Public Function ObtenerMesGrati(ByVal periodoCTS As String) As DataTable
        Dim DtPagodtPagoCts As New DataTable
        DtPagodtPagoCts = CTSDAL.ObtenerMesGrati(periodoCTS)
        Return DtPagodtPagoCts
    End Function

    Public Function ObtenerMesIniCTS(ByVal periodoCTS As String) As DataTable
        Dim DtPagodtPagoCts As New DataTable
        DtPagodtPagoCts = CTSDAL.ObtenerMesIniCTS(periodoCTS)
        Return DtPagodtPagoCts
    End Function

    Public Function ObtenerMesFinCTS(ByVal periodoCTS As String) As DataTable
        Dim DtPagodtPagoCts As New DataTable
        DtPagodtPagoCts = CTSDAL.ObtenerMesFinCTS(periodoCTS)
        Return DtPagodtPagoCts
    End Function


    Public Sub ActualizarDatosCts(ByVal periodoCTS As String, ByVal per_cod As String, ByVal fam As String, ByVal grati As String, ByVal he As String, ByVal bono As String, ByVal dia As String, ByVal mes As String, ByVal noc As String, ByVal tc As String)
        Dim resultado As String
        resultado = CTSDAL.SaveRowCTS(periodoCTS, per_cod, fam, grati, he, bono, dia, mes, noc, tc)
    End Sub
End Class
