Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELDESPACHOBL

    Private ELDESPACHODAL As New ELDESPACHODAL


#Region "SQL"

    Public Function SelectAll() As DataTable

        Return ELDESPACHODAL.SelectAll()

    End Function

#End Region


End Class
