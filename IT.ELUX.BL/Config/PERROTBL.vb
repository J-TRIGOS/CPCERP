Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class PERROTBL
    Private PERROTDAL As New PERROTDAL
#Region "Lectura de Datos"

    Public Function SelPerAll(ByVal var As String) As DataTable
        Return PERROTDAL.SelPerAll(var)
    End Function
#End Region
    Public Function SaveRow(ByVal PERBE As PERBE, ByVal flagaccion As String, ByVal dgvdatos As DataGridView) As String
        Return PERROTDAL.SaveRow(PERBE, flagaccion, dgvdatos)
    End Function
    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return PERROTDAL.SelectRow(sCode)
    End Function
End Class
