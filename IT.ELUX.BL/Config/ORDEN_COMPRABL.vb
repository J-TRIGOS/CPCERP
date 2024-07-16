Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ORDEN_COMPRABL
    Private ORDEN_COMPRADAL As New ORDEN_COMPRADAL
#Region "SQL"
    Public Function SelectAllProd(ByVal sAño As String, ByVal sMes As String) As DataTable
        Return ORDEN_COMPRADAL.SelectAllProd(sAño, sMes)
    End Function

    Public Function SelectAllServ(ByVal sAño As String, ByVal sMes As String) As DataTable
        Return ORDEN_COMPRADAL.SelectAllServ(sAño, sMes)
    End Function
#End Region

End Class
