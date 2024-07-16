Imports IT.ELUX.DAL

Public Class AsientoPlaBL
    Private oAsientoPlaDAL As New AsientoPlaDAL

    Public Function Procesar(ByVal sAnio As String, ByVal sMesNumero As String, ByVal sPeriodoCodigo As String, ByVal sPagoTipo As String) As String
        Return oAsientoPlaDAL.demo(sAnio, sMesNumero, sPeriodoCodigo, sPagoTipo)
    End Function

    Public Function Procesar2(ByVal sAnio As String, ByVal sMesNumero As String, ByVal sPagoTipo As String) As String
        Return oAsientoPlaDAL.demo2(sAnio, sMesNumero, sPagoTipo)
    End Function
End Class
