Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect


Public Class BONONOCTURNODAL

    Inherits BaseDatosORACLE

    Public Function BuscarDatosBono(ByVal prdo As String, ByVal fecIni As String, ByVal fecFin As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_REGISTRO_BONO_NOCTURNO", {New Oracle.ManagedDataAccess.Client.OracleParameter("PRDO", prdo),
                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("FECINI", fecIni),
                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("FECFIN", fecFin)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ListadoBono(ByVal prdo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LISTADO_BONO_NOCTURNO", {New Oracle.ManagedDataAccess.Client.OracleParameter("PRDO", prdo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarCronogramaRRHH() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LISTADO_CRONOGRAMARRHH", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

End Class
