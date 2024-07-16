Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBLETRAS_MONTOBL
    Private ELTBLETRAS_MONTODAL As New ELTBLETRAS_MONTODAL
#Region "Lectura de Datos"

    Public Function SelPerAll(ByVal var As String) As DataTable
        Return ELTBLETRAS_MONTODAL.SelPerAll(var)
    End Function
#End Region
    Public Function SaveRow(ByVal ELTBLETRAS_MONTOBE As ELTBLETRAS_MONTOBE, ByVal flagaccion As String) As String
        Return ELTBLETRAS_MONTODAL.SaveRow(ELTBLETRAS_MONTOBE, flagaccion)
    End Function
    Public Function SelectMaxLibro() As String
        Return ELTBLETRAS_MONTODAL.SelectMaxLibro()
    End Function
    Public Function SelectRow(ByVal sTdoc As String) As DataTable
        Return ELTBLETRAS_MONTODAL.SelectRow(sTdoc)
    End Function
    Public Function VerificarRepetido(ByVal cod As String) As Boolean
        Return ELTBLETRAS_MONTODAL.VerificarRepetido(cod)
    End Function
    Public Function SelectAll() As DataTable
        Return ELTBLETRAS_MONTODAL.SelectAll()
    End Function
End Class
