Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class COSTEOBL
    Private COSTEODAL As New COSTEODAL

    Public Function ObtenerPeriodo(ByVal mes As String, ByVal anho As String) As DataTable
        Return COSTEODAL.ObtenerPeriodo(mes, anho)
    End Function

    Public Function LimpiarCosteo(ByVal mes As String, ByVal anho As String) As DataTable
        Return COSTEODAL.LimpiarCosteo(mes, anho)
    End Function

    Public Function ProcesarCosteo(ByVal centroCod As String, ByVal mes As String, ByVal anho As String, ByVal prdo As String) As String
        Return COSTEODAL.ProcesarCosteo(centroCod, mes, anho, prdo)
    End Function
End Class
