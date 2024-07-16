Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELARTLINEASTOKBL
    Private ELARTLINEASTOKDAL As New ELARTLINEASTOKDAL
    Public Function Reporteartlineastok(ByVal flagAccion As String, ByVal sLinea As String, ByVal sAlm As String, ByVal sSol As String, ByVal sAño As String) As String
        'Verifica el kardex
        Return ELARTLINEASTOKDAL.Reporteartlineastok(flagAccion, sLinea, sAlm, sSol, sAño)
    End Function
End Class
