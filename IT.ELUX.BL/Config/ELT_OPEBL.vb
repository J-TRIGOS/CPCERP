Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELT_OPEBL
    Private ELT_OPEDAL As New ELT_OPEDAL
#Region "Lectura de Datos"

    Public Function SelPerAll(ByVal var As String) As DataTable
        Return ELT_OPEDAL.SelPerAll(var)
    End Function
#End Region
    Public Function SaveRow(ByVal ELT_OPEBE As ELT_OPEBE, ByVal flagaccion As String) As String
        Return ELT_OPEDAL.SaveRow(ELT_OPEBE, flagaccion)
    End Function
    Public Function SelectMaxLibro() As String
        Return ELT_OPEDAL.SelectMaxLibro()
    End Function
    Public Function SelectRow(ByVal anho As String, ByVal cod As String) As DataTable
        Return ELT_OPEDAL.SelectRow(anho, cod)
    End Function
    Public Function SelectAll(ByVal anho As String) As DataTable
        Return ELT_OPEDAL.SelectAll(anho)
    End Function
    Public Function VerificarRepetido(ByVal Code As String, ByVal Code2 As String) As Boolean
        Return ELT_OPEDAL.VerificarRepetido(Code, Code2)
    End Function
End Class
