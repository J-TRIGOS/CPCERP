
Imports IT.ELUX.DAL.Seguridad

Public Class SistemaBL
    Private oSistemaDAL As New SistemaDAL

    Public Function getSistemaByUsuCod(ByVal sUsuCod) As DataTable
        Return oSistemaDAL.SelectSistemaByUsuCod(sUsuCod)
    End Function
    Public Function getMenuByUsuCod(ByVal sUsuCod, ByVal sSisCod) As DataTable
        Return oSistemaDAL.SelectMenuByUsuCod(sUsuCod, sSisCod)
    End Function
    Public Function getSubMenuByUsuCod(ByVal sUsuCod, ByVal sSisCod, ByVal sPrnCod) As DataTable
        Return oSistemaDAL.SelectSubMenuByUsuCod(sUsuCod, sSisCod, sPrnCod)
    End Function
End Class
