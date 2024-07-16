Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class DETBINDCARDBL

    Private DETBINDCARDDAL As New DETBINDCARDDAL

    Public Function SaveRow(ByVal DetBindCard As DETBINDCARDBE, ByVal flagaccion As String, ByVal lote As String) As String
        Return DETBINDCARDDAL.SaveRow(DetBindCard, flagaccion, lote)
    End Function

    Public Function BuscarDetalleBindCard(ByVal serie As String, ByVal numero As String, ByVal codart As String) As DataTable
        Return DETBINDCARDDAL.BuscarDetalleBindCard(serie, numero, codart)
    End Function

    Public Function VerificarKardex(ByVal tipo As String, ByVal serie As String, ByVal numero As String, ByVal codart As String, ByVal cantidad As Double, ByVal almacen As String) As DataTable
        Return DETBINDCARDDAL.VerificarKardex(tipo, serie, numero, codart, cantidad, almacen)
    End Function
End Class
