Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBINICIALCBBL
    Private ELTBINICIALCBDAL As New ELTBINICIALCBDAL
    Public Function BuscarCB(ByVal sCode As String) As DataTable
        Return ELTBINICIALCBDAL.BuscarCB(sCode)
    End Function
    Public Function SelectAll(ByVal anho As String) As DataTable
        Return ELTBINICIALCBDAL.SelectAll(anho)
    End Function
    Public Function SelectRow(ByVal sANHO As String, ByVal sCode As String) As DataTable
        Return ELTBINICIALCBDAL.SelectRow(sANHO, sCode)
    End Function
    Public Function SaveRow(ByVal ELTBINICIALCBBE As ELTBINICIALCBBE, ByVal flagAccion As String,
                            ByVal ELMVLOGSBE As ELMVLOGSBE) As String
        Return ELTBINICIALCBDAL.SaveRow(ELTBINICIALCBBE, flagAccion, ELMVLOGSBE)
    End Function
End Class
