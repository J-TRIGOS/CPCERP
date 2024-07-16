Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBTURNOBL
    Private ELTBTURNODAL As New ELTBTURNODAL
    Public Function SelectRow(ByVal sCode As String, ByVal sMes As String) As DataTable
        Return ELTBTURNODAL.SelectRow(sCode, sMes)
    End Function
    Public Function SelectRowGrid(ByVal sCode As String, ByVal sMes As String) As DataTable
        Return ELTBTURNODAL.SelectRowGrid(sCode, sMes)
    End Function
    Public Function SelectAllS(ByVal Anho As String, ByVal Mes As String) As DataTable
        Return ELTBTURNODAL.SelectAllS(Anho, Mes)
    End Function
    Public Function SelectIndice(ByVal Mes As String) As String
        Return ELTBTURNODAL.SelectIndice(Mes)
    End Function
    Public Function SaveRow(ByVal ELTBTURNOBE As ELTBTURNOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String, ByVal dgtareo As DataGridView) As String
        Return ELTBTURNODAL.SaveRow(ELTBTURNOBE, ELMVLOGSBE, flagAccion, dgtareo)
    End Function
End Class
