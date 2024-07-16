Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELESPECI_TBL
    Private ELESPECI_TDAL As New ELESPECI_TDAL
#Region "Lectura de Datos"

    Public Function SelPerAll(ByVal var As String) As DataTable
        Return ELESPECI_TDAL.SelPerAll(var)
    End Function
#End Region
    Public Function SaveRow(ByVal ELESPECI_TBE As ELESPECI_TBE, ByVal flagaccion As String) As String
        Return ELESPECI_TDAL.SaveRow(ELESPECI_TBE, flagaccion)
    End Function
    Public Function SelectMaxLibro() As String
        Return ELESPECI_TDAL.SelectMaxLibro()
    End Function
    Public Function SelectRow(ByVal sTdoc As String) As DataTable
        Return ELESPECI_TDAL.SelectRow(sTdoc)
    End Function
    Public Function VerificarRepetido(ByVal cod As String) As Boolean
        Return ELESPECI_TDAL.VerificarRepetido(cod)
    End Function
    Public Function SelectAll() As DataTable
        Return ELESPECI_TDAL.SelectAll()
    End Function
    Public Function SelectArt4(ByVal sCode As String) As DataTable
        Return ELESPECI_TDAL.SelectArt4(sCode)
    End Function
    Public Function VerificarRepetido(ByVal Code As String, ByVal Code2 As String, ByVal Code3 As String) As Boolean
        Return ELESPECI_TDAL.VerificarRepetido(Code, Code2, Code3)
    End Function
End Class
