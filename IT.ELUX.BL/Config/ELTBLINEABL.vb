Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBLINEABL
    Private ELTBLINEADAL As New ELTBLINEADAL
    Public Function SelectAll() As DataTable
        Return ELTBLINEADAL.SelectAll()
    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return ELTBLINEADAL.SelectRow(sCode)
    End Function

    Public Function LastCodigo() As String
        Return ELTBLINEADAL.LastCodigo()
    End Function

    Public Function SaveRow(ByVal ELTBLINEABE As ELTBLINEABE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE) As String
        Return ELTBLINEADAL.SaveRow(ELTBLINEABE, flagAccion, ELMVLOGSBE)
    End Function

    Public Function getLinea(ByVal sCode As String) As DataTable
        Return ELTBLINEADAL.getLinea(sCode)
    End Function
End Class
