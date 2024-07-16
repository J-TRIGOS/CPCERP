
Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class FORMA_ENTBL
    Private FORMA_ENTDAL As New FORMA_ENTDAL

    Public Function SelectAll() As DataTable
        Return FORMA_ENTDAL.SelectAll()
    End Function

    Public Function SaveRow(ByVal FORMA_ENTBE As FORMA_ENTBE, ByVal flagAccion As String) As String
        Return FORMA_ENTDAL.SaveRow(FORMA_ENTBE, flagAccion)
    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return FORMA_ENTDAL.SelectRow(sCode)
    End Function

    Public Function VerificarRepetido(ByVal Code As String) As Boolean
        Return FORMA_ENTDAL.VerificarRepetido(Code)
    End Function
End Class

