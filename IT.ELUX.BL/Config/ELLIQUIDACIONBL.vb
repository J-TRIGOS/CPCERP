Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELLIQUIDACIONBL
    Private ELLIQUIDACIONDAL As New ELLIQUIDACIONDAL
#Region "Lectura de Datos"

    Public Function SelPerAll(ByVal var As String) As DataTable
        Return ELLIQUIDACIONDAL.SelPerAll(var)
    End Function
#End Region
    Public Function SaveRow(ByVal LIQUIDACIONBE As ELLIQUIDACIONBE, ByVal flagaccion As String) As String
        Return ELLIQUIDACIONDAL.SaveRow(LIQUIDACIONBE, flagaccion)
    End Function
    Public Function SelectRow(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As DataTable
        Return ELLIQUIDACIONDAL.SelectRow(sTdoc, sSdoc, sNdoc)
    End Function
    Public Function VerificarRepetido(ByVal anho As String, ByVal mes As String, ByVal per_cod As String) As Boolean
        Return ELLIQUIDACIONDAL.VerificarRepetido(anho, mes, per_cod)
    End Function
    Public Function SelectAll(ByVal Anho As String, ByVal Mes As String) As DataTable
        Return ELLIQUIDACIONDAL.SelectAll(Anho, Mes)
    End Function
End Class
