Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBARTSTOCKBL
    Private ELTBARTSTOCKDAL As New ELTBARTSTOCKDAL
    Public Function SaveRow(ByVal ELTBARTSTOCKBE As ELTBARTSTOCKBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String) As String
        Return ELTBARTSTOCKDAL.SaveRow(ELTBARTSTOCKBE, ELMVLOGSBE, flagAccion)
    End Function
End Class
