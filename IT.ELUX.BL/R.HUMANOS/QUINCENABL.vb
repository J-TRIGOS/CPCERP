Imports IT.ELUX.BE
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.DAL

Public Class QUINCENABL

    Dim QUINCENADAL As New QUINCENADAL
    Public Function ListadoPersonalQUincena(ByVal anho As String, ByVal mes As String, ByVal nn As String) As DataTable
        Return QUINCENADAL.ListadoPersonalQUincena(anho, mes, nn)
    End Function

    Public Function SaveRow(ByVal flagAccion As String, ByVal anho As String, ByVal mes As String, ByVal dg As DataGridView) As String
        Return QUINCENADAL.SaveRow(flagAccion, anho, mes, dg)
    End Function
End Class
