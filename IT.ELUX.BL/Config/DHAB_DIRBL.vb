Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class DHAB_DIRBL
    Private DHAB_DIRDAL As New DHAB_DIRDAL
    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return DHAB_DIRDAL.SelectRow(sCode)

    End Function
End Class
