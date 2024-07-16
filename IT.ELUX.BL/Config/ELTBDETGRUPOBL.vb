Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBDETGRUPOBL

    Private ELTBDETGRUPODAL As New ELTBDETGRUPODAL
    Public Function SelectRow(ByVal sCode As String) As DataTable

        Return ELTBDETGRUPODAL.SelectRow(sCode)

    End Function
End Class
