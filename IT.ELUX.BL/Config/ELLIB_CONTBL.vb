Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELLIB_CONTBL
    Private ELLIB_CONTDAL As New ELLIB_CONTDAL
#Region "Lectura de Datos"

    Public Function SelPerAll(ByVal var As String) As DataTable
        Return ELLIB_CONTDAL.SelPerAll(var)
    End Function
#End Region
    Public Function SaveRow(ByVal ELLIB_CONTBE As ELLIB_CONTBE, ByVal flagaccion As String) As String
        Return ELLIB_CONTDAL.SaveRow(ELLIB_CONTBE, flagaccion)
    End Function
    Public Function SelectMaxLibro() As String
        Return ELLIB_CONTDAL.SelectMaxLibro()
    End Function
    Public Function SelectRow(ByVal sTdoc As String) As DataTable
        Return ELLIB_CONTDAL.SelectRow(sTdoc)
    End Function
    Public Function VerificarRepetido(ByVal cod As String) As Boolean
        Return ELLIB_CONTDAL.VerificarRepetido(cod)
    End Function
    Public Function SelectAll() As DataTable
        Return ELLIB_CONTDAL.SelectAll()
    End Function
End Class
