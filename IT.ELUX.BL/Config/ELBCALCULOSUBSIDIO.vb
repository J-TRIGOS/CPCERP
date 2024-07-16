Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELBCALCULOSUBSIDIO

    Private ELBCALCULOSUBSUDIODAL As New ELBCALCULOSUBSUDIODAL

    Public Function CalculoSubsidio(ByVal cod As String, ByVal periodo As String, ByVal fechaIni As String, ByVal fechaFin As String, ByVal ListaPeriodos As ELPERIODOS) As DataTable
        Return ELBCALCULOSUBSUDIODAL.CalculoSubsidio(cod, periodo, fechaIni, fechaFin, ListaPeriodos)
    End Function

    Public Function CalculoIngresos(ByVal cod As String, ByVal periodo As String, ByVal fechaIni As String, ByVal fechaFin As String, ByVal ListaPeriodos As ELPERIODOS) As DataTable
        Return ELBCALCULOSUBSUDIODAL.CalculoIngresos(cod, periodo, fechaIni, fechaFin, ListaPeriodos)
    End Function

    Public Function BuscarPeriodo(ByVal fecha As String) As DataTable
        Return ELBCALCULOSUBSUDIODAL.BuscarPeriodo(fecha)
    End Function

    Public Function CalculoPeriodos(ByVal periodo As String) As DataTable
        Return ELBCALCULOSUBSUDIODAL.CalculoPeriodos(periodo)
    End Function

    Public Function ListaPeriodos(ByVal periodo As String) As DataTable
        Return ELBCALCULOSUBSUDIODAL.ListaPeriodos(periodo)
    End Function
End Class
