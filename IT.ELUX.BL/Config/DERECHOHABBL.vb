Imports IT.ELUX.DAL
Public Class DERECHOHABBL
    Private DERECHOHABDAL As New DERECHOHABDAL

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return DERECHOHABDAL.SelectRow(sCode)
    End Function
End Class
