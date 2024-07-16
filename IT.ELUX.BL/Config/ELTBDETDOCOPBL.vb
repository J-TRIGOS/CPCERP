Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBDETDOCOPBL
    Private ELTBDETDOCOPDAL As New ELTBDETDOCOPDAL
    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sART As String) As DataTable
        Return ELTBDETDOCOPDAL.SelectRow(sT_doc, sS_doc, sN_doc, sART)
    End Function
    Public Function BuscarOP(ByVal anho As String, ByVal articulo As String) As DataTable
        Return ELTBDETDOCOPDAL.BuscarOP(anho, articulo)
    End Function
    Public Function SaveRow(ByVal ELTBDETDOCOPBE As ELTBDETDOCOPBE, ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Return ELTBDETDOCOPDAL.SaveRow(ELTBDETDOCOPBE, flagAccion, dg)
    End Function

    Public Function BuscarTCSBS(ByVal fecha As String, ByVal operacion As String) As DataTable
        Return ELTBDETDOCOPDAL.BuscarTCSBS(fecha, operacion)
    End Function

    Public Function BuscarActFLujo() As DataTable
        Return ELTBDETDOCOPDAL.BuscarActFLujo()
    End Function

    Public Function BuscarActFLujoCaja(ByVal cod As String, ByVal ope As String) As DataTable
        Return ELTBDETDOCOPDAL.BuscarActFLujoCaja(cod, ope)
    End Function
End Class
