Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBORDENPROGRAMABL
    Private ELTBORDENPROGRAMADAL As New ELTBORDENPROGRAMADAL

    Public Function SelectNro(ByVal sTipo As String, ByVal sSer As String, ByVal sNum As String, ByVal sArt As String) As DataTable
        Return ELTBORDENPROGRAMADAL.SelectNro(sTipo, sSer, sNum, sArt)
    End Function

    Public Function SaveRow(ByVal ELTBORDENPROGRAMABE As ELTBORDENPROGRAMABE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String) As String
        Return ELTBORDENPROGRAMADAL.SaveRow(ELTBORDENPROGRAMABE, ELMVLOGSBE, flagAccion)
    End Function

    Public Function SelectSearch(ByVal sForm As String) As DataTable
        Return ELTBORDENPROGRAMADAL.SelectSearch(sForm)
    End Function

    Public Function getListcmb1() As DataTable
        Return ELTBORDENPROGRAMADAL.getListcmb1()
    End Function

End Class
