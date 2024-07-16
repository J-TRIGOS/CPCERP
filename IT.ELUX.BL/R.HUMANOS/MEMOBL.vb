Imports IT.ELUX.BE
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.DAL

Public Class MEMOBL

    Dim MEMODAL As New MEMODAL

    Public Function CalcularNroMemo(ByVal MES As String, ByVal ANHO As String) As DataTable
        Return MEMODAL.CalcularNroMemo(MES, ANHO)
    End Function

    Public Function InsertRowMemo(ByVal MEMOBE As MEMOBE, ByVal flagaccion As String) As String
        Return MEMODAL.InsertRowMemo(MEMOBE, flagaccion)
    End Function

    Public Function BuscarListadoMEmo(ByVal ANHO As String, ByVal MES As String) As DataTable
        Return MEMODAL.BuscarListadoMEmo(ANHO, MES)
    End Function
End Class
