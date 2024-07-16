Imports IT.ELUX.BE
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.DAL

Public Class BONONOCTURNOBL

    Dim BONONOCTURNODAL As New BONONOCTURNODAL

    Public Function BuscarDatosBono(ByVal prdo As String, ByVal fecIni As String, ByVal fecFin As String) As DataTable
        Return BONONOCTURNODAL.BuscarDatosBono(prdo, fecIni, fecFin)
    End Function

    Public Function ListadoBono(ByVal prdo As String) As DataTable
        Return BONONOCTURNODAL.ListadoBono(prdo)
    End Function

    Public Function BuscarCronogramaRRHH() As DataTable
        Return BONONOCTURNODAL.BuscarCronogramaRRHH()
    End Function

End Class
