Imports IT.ELUX.DAL
Public Class FLUJOPROYECTADOBL
    Dim FLUJOPROYECTADODAL As New FLUJOPROYECTADODAL
    Dim FLUJOPROYECTADOMENSUALDAL As New FLUJOPROYECTADOMENSUALDAL

    Public Function FlujoProyectadoAnual(ByVal anho As String, ByVal mesACT As String, ByVal mesANT As String, ByVal prdo As String, ByVal i As Integer) As String
        Return FLUJOPROYECTADODAL.FlujoProyectadoAnual(anho, mesACT, mesANT, prdo, i)
    End Function

    Public Function buscarPeriodo(ByVal mes As String, ByVal anho As String) As DataTable
        Return FLUJOPROYECTADODAL.buscarPeriodo(mes, anho)
    End Function

    Public Function CalcularMontos(ByVal anho As String) As DataTable
        Return FLUJOPROYECTADODAL.CalcularMontos(anho)
    End Function

    Public Function FlujoProyectadoMensual(ByVal anho As String, ByVal mes As String, ByVal i As Integer, ByVal diaACT As String, ByVal diaANT As String, ByVal prdo As String, ByVal dias As Integer) As String
        Return FLUJOPROYECTADOMENSUALDAL.FlujoProyectadoMensual(anho, mes, i, diaACT, diaANT, prdo, dias)
    End Function
End Class
