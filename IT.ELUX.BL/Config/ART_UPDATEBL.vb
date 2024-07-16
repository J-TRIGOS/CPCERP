Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ART_UPDATEBL
    Private ART_UPDATEDAL As New ART_UPDATEDAL

    Public Function SaveRow(ByVal ART_UPDATEBE As ART_UPDATEBE, ByVal flagAccion As String) As String
        Return ART_UPDATEDAL.SaveRow(ART_UPDATEBE, flagAccion)
    End Function

    Public Function SelectAll() As DataTable
        Return ART_UPDATEDAL.SelectAll()
    End Function

    Public Function SelectRow(ByVal sTdoc As String) As DataTable
        Return ART_UPDATEDAL.SelectRow(sTdoc)
    End Function

    Public Function SelectLineaAll() As DataTable
        Return ART_UPDATEDAL.SelectAll()
    End Function

    Public Function SelectAllopcion(ByVal opcion As String) As DataTable
        Return ART_UPDATEDAL.SelectAllopcion(opcion)
    End Function

End Class
