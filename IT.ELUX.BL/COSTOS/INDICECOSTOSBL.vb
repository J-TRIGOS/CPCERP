Imports IT.ELUX.DAL

Public Class INDICECOSTOSBL

    Private INDICECOSTOSDAL As New INDICECOSTOSDAL
    Public Function registrarArticulo(ByVal codigo As String, ByVal art As String, ByVal anho As String) As String
        Return INDICECOSTOSDAL.registrarArticulo(codigo, art, anho)
    End Function

    Public Function RegistrarIndiceCostos(ByVal i As String, ByVal mesAct As String, ByVal mesAnt As String, ByVal codigo As String, ByVal anho As String) As String
        Return INDICECOSTOSDAL.RegistrarIndiceCostos(i, mesAct, mesAnt, codigo, anho)
    End Function

    Public Function ObtenerIndiceCostos(ByVal codigo As String, ByVal anho As String) As DataTable
        Return INDICECOSTOSDAL.ObtenerIndiceCostos(codigo, anho)
    End Function


End Class
