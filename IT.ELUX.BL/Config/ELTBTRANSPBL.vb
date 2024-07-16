
Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELTBTRANSPBL
    Private ELTBTRANSPDAL As New ELTBTRANSPDAL

    Public Function SelectAll() As DataTable
        Return ELTBTRANSPDAL.SelectAll()
    End Function

    Public Function SelectMaxTransp() As String
        Return ELTBTRANSPDAL.SelectMaxTransp()
    End Function

    Public Function SaveRow(ByVal ELTBTRANSPBE As ELTBTRANSPBE, ByVal flagAccion As String) As String
        Return ELTBTRANSPDAL.SaveRow(ELTBTRANSPBE, flagAccion)
    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return ELTBTRANSPDAL.SelectRow(sCode)
    End Function

End Class

