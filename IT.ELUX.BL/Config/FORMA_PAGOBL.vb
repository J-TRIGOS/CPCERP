
Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class FORMA_PAGOBL
    Private FORMA_PAGODAL As New FORMA_PAGODAL

    Public Function SelectAll() As DataTable
        Return FORMA_PAGODAL.SelectAll()
    End Function

    Public Function SaveRow(ByVal FORMA_PAGOBE As FORMA_PAGOBE, ByVal flagAccion As String) As String
        Return FORMA_PAGODAL.SaveRow(FORMA_PAGOBE, flagAccion)
    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return FORMA_PAGODAL.SelectRow(sCode)
    End Function

    Public Function SelNro() As Int32
        Return FORMA_PAGODAL.SelNro()
    End Function

    Public Function VerificarRepetido(ByVal Code As String) As Boolean
        Return FORMA_PAGODAL.VerificarRepetido(Code)
    End Function
End Class

