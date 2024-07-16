Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class CTS_BL
    Private CTS_DAL As New CTS_DAL
    Public Function SelectRowAll(ByVal sANHO As String, ByVal sMES As String) As DataTable
        Return CTS_DAL.SelectRowAll(sANHO, sMES)
    End Function
    Public Function SelectRow(ByVal sANHO As String, ByVal sMES As String, ByVal sPER_COD As String) As DataTable
        Return CTS_DAL.SelectRow(sANHO, sMES, sPER_COD)
    End Function
    Public Function SaveRow(ByVal CTSBE As CTSBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String, ByVal pFVA As String) As String
        Return CTS_DAL.SaveRow(CTSBE, ELMVLOGSBE, flagAccion, pFVA)
    End Function
End Class
