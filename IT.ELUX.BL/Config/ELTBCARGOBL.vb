Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBCARGOBL
    Private ELTBCARGODAL As New ELTBCARGODAL
    Public Function SelectAll() As DataTable
        Return ELTBCARGODAL.SelectAll()
    End Function
    Public Function SelectRow(ByVal sCod As String) As DataTable
        Return ELTBCARGODAL.SelectRow(sCod)
    End Function
    Public Function SaveRow(ByVal ELTBCARGOBE As ELTBCARGOBE, ByVal flagAccion As String) As String
        Return ELTBCARGODAL.SaveRow(ELTBCARGOBE, flagAccion)
    End Function
    Public Function SelectNro() As String
        Return ELTBCARGODAL.SelectNro()
    End Function
End Class
