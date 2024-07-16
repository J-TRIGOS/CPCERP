Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class KARDEXBCBL

    Dim KARDEXBCDAL As New KARDEXBCDAL

    Public Function SaveRow(ByVal KARDEXBCBE As KARDEXBINDCARDBE, ByVal flagaccion As String) As String
        Return KARDEXBCDAL.SaveRow(KARDEXBCBE, flagaccion)
    End Function

End Class
