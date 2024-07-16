Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELCAJABANCOBL
    Private ELCAJABANCODAL As New ELCAJABANCODAL

    'Public Function SelectAll(ByVal anho As String, ByVal mes As String) As DataTable
    '    Return ELORDEN_MANTDAL.SelectAll(anho, mes)
    'End Function
    Public Function SelectDataSaldos(ByVal sANHO As String, ByVal sMES As String) As DataTable
        Return ELCAJABANCODAL.SelectDataSaldos(sANHO, sMES)
    End Function
    Public Function SelectDataInicial(ByVal sANHO As String, ByVal sMES As String, ByVal sBCO As String, ByVal sMON As String) As DataTable
        Return ELCAJABANCODAL.SelectDataInicial(sANHO, sMES, sBCO, sMON)
    End Function
    Public Function SaveRow(ByVal ELCAJABANCOBE As ELCAJABANCOBE, ByVal flagaccion As String) As String
        Return ELCAJABANCODAL.SaveRow(ELCAJABANCOBE, flagaccion)
    End Function
End Class
