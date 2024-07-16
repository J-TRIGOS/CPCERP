Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBCOSTARTBL
    Private ELTBCOSTARTDAL As New ELTBCOSTARTDAL
    Public Function SelectMPSP(ByVal sAño As String, ByVal sMes As String) As DataTable
        Return ELTBCOSTARTDAL.SelectMPSP(sAño, sMes)
    End Function
    Public Function SelectCMP(ByVal sAño As String, ByVal sMes As String, ByVal sTip As String) As Double
        Return ELTBCOSTARTDAL.SelectCMP(sAño, sMes, sTip)
    End Function
    Public Function SelectMPCP(ByVal sAño As String, ByVal sMes As String) As DataTable
        Return ELTBCOSTARTDAL.SelectMPCP(sAño, sMes)
    End Function
    Public Function SaveRow(ByVal ELTBCOSTARTBE As ELTBCOSTARTBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                           ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Return ELTBCOSTARTDAL.SaveRow(ELTBCOSTARTBE, ELMVLOGSBE, flagAccion, dg)
    End Function
End Class
