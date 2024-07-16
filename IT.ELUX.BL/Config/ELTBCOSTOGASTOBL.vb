Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBCOSTOGASTOBL
    Private ELTBCOSTOGASTODAL As New ELTBCOSTOGASTODAL
    Public Function SelectAll() As DataTable

        Return ELTBCOSTOGASTODAL.SelectAll()

    End Function
    Public Function SelectRow(ByVal sCode As String) As DataTable

        Return ELTBCOSTOGASTODAL.SelectRow(sCode)

    End Function
    Public Function LastCodigo() As String

        Return ELTBCOSTOGASTODAL.LastCodigo()

    End Function
    Public Function SaveRow(ByVal ELTBCOSTOGASTOBE As ELTBCOSTOGASTOBE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE) As String

        Return ELTBCOSTOGASTODAL.SaveRow(ELTBCOSTOGASTOBE, flagAccion, ELMVLOGSBE)

    End Function

End Class
