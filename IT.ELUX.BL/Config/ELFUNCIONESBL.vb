Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELFUNCIONESBL
    Private ELFUNCIONESDAL As New ELFUNCIONESDAL
    Public Function SelectNomColumn(ByVal sNom As String) As DataTable

        Return ELFUNCIONESDAL.SelectNomColumn(sNom)

    End Function
End Class
