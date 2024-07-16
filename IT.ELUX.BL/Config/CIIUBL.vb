Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class CIIUBL
    Private CIIUDAL As New CIIUDAL
    Public Function SelectAll() As DataTable
        Return CIIUDAL.SelectAll()
    End Function


#Region "GRABAR"
    Public Function SaveRow(ByVal CIIUBE As CIIUBE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE) As String
        Return CIIUDAL.SaveRow(CIIUBE, flagAccion, ELMVLOGSBE)
    End Function
#End Region

End Class
