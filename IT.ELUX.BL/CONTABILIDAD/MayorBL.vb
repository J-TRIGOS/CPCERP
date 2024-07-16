

Imports IT.ELUX.DAL

Public Class MayorBL
    Private oMayorDAL As New MayorDAL

    Public Function Procesar(ByVal sAnio As String, ByVal sMesNumero As String) As String
        Return oMayorDAL.demo(sAnio, sMesNumero)
    End Function

End Class
