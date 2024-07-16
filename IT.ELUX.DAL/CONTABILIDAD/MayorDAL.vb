Imports IT.ELUX.Connect
Imports Oracle.ManagedDataAccess.Client

Public Class MayorDAL
    Inherits BaseDatosORACLE

    Public Function demo(ByVal sAnio As String, ByVal sMesNumero As String) As String

        Dim oOracleConnection As New OracleConnection
        Dim oOracleCommand As New OracleCommand

        Try
            '//CONEXION APERTURA
            oOracleConnection = ConnectionBegin()
            '//COMMAND PARA LLAMAR SP
            oOracleCommand.CommandText = "LOGI.MAYORIZACION1"
            oOracleCommand.Connection = oOracleConnection
            oOracleCommand.CommandType = CommandType.StoredProcedure
            oOracleCommand.Parameters.Add("@AA1", OracleDbType.Varchar2).Value = sAnio
            oOracleCommand.Parameters.Add("@MM1", OracleDbType.Varchar2).Value = sMesNumero
            oOracleCommand.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            oOracleCommand.Dispose()
        End Try

    End Function

End Class
