Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class CTCTBL
    Private CTCTDAL As New CTCTDAL
#Region "SQL"

    Public Function SelectEmail(ByVal sCode As String) As String
        Return CTCTDAL.SelectEmail(sCode)
    End Function

    Public Function SelectVendedor(ByVal sCode As String) As String
        Return CTCTDAL.SelectVendedor(sCode)
    End Function

    Public Function SelectObsPago(ByVal sCode As String) As String
        Return CTCTDAL.SelectObsPago(sCode)
    End Function

    Public Function SelectCTCT(ByVal sCode As String) As String
        Return CTCTDAL.SelectCTCT(sCode)
    End Function

    Public Function SelectDepart() As DataTable
        Return CTCTDAL.SelectDepart()
    End Function

    Public Function SelectProv(ByVal cod As String) As DataTable
        Return CTCTDAL.SelectProv(cod)
    End Function

    Public Function SelectDist(ByVal cod As String) As DataTable
        Return CTCTDAL.SelectDist(cod)
    End Function
#End Region
End Class
