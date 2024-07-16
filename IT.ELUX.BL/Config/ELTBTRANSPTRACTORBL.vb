Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELTBTRANSPTRACTORBL
    Private ELTBTRANSPTRACTORDAL As New ELTBTRANSPTRACTORDAL

    Public Function SelectAll() As DataTable
        Return ELTBTRANSPTRACTORDAL.SelectAll()
    End Function

    Public Function SelectMaxTransp(ByVal sCode As String) As String
        Return ELTBTRANSPTRACTORDAL.SelectMaxTransp(sCode)
    End Function

    Public Function SaveRow(ByVal ELTBTRANSPTRACTORBE As ELTBTRANSPTRACTORBE, ByVal flagAccion As String) As String
        Return ELTBTRANSPTRACTORDAL.SaveRow(ELTBTRANSPTRACTORBE, flagAccion)
    End Function

    Public Function SelectRow(ByVal sCode As String, ByVal sCode_cho As String) As DataTable
        Return ELTBTRANSPTRACTORDAL.SelectRow(sCode, sCode_cho)
    End Function

    Public Function SelectT_Transp() As DataTable
        Return ELTBTRANSPTRACTORDAL.SelectT_Transp()
    End Function
End Class
