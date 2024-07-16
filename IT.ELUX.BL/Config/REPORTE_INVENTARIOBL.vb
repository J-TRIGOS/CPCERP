Imports IT.ELUX.DAL
Public Class REPORTE_INVENTARIOBL


    Private REPORTE_INVENTARIODAL As New REPORTE_INVENTARIODAL
    Public Function registrar(ByVal linea As String, ByVal sSlin As String, ByVal sAlm As String, ByVal sAnho As String, ByVal sMes As String, ByVal sFec As String, ByVal sMov As String) As String
        Return REPORTE_INVENTARIODAL.registrar(linea, sSlin, sAlm, sAnho, sMes, sFec, sMov)
    End Function
End Class
