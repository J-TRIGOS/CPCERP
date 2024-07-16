Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBPRECIOSARTBL
    Private ELTBPRECIOSARTDAL As New ELTBPRECIOSARTDAL
    Public Function SelectAll(ByVal sCode As String) As DataTable
        Return ELTBPRECIOSARTDAL.SelectAll(sCode)
    End Function
    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return ELTBPRECIOSARTDAL.SelectRow(sCode)
    End Function
End Class
