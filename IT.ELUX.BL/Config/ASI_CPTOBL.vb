Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ASI_CPTOBL
    Private ASI_CPTODAL As New ASI_CPTODAL
    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return ASI_CPTODAL.SelectRow(sCode)
    End Function

End Class
