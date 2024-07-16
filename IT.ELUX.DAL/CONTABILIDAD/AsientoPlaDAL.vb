
Imports IT.ELUX.Connect
Imports Oracle.ManagedDataAccess.Client
Public Class AsientoPlaDAL
    Inherits BaseDatosORACLE

    Public Function demo(ByVal sAnio As String, ByVal sMesNumero As String, ByVal sPeriodoCodigo As String, ByVal sPagoTipo As String) As String

        Dim oOracleConnection As New OracleConnection
        Dim oOracleCommand As New OracleCommand

        Try
            '//CONEXION APERTURA
            oOracleConnection = ConnectionBegin()
            '//COMMAND PARA LLAMAR SP
            oOracleCommand.CommandText = "LOGI.ASIENTO_PLANILLA"
            oOracleCommand.Connection = oOracleConnection
            oOracleCommand.CommandType = CommandType.StoredProcedure
            oOracleCommand.Parameters.Add("@ANHO1", OracleDbType.Varchar2).Value = sAnio
            oOracleCommand.Parameters.Add("@MES1", OracleDbType.Varchar2).Value = sMesNumero
            oOracleCommand.Parameters.Add("@PRDO1", OracleDbType.Varchar2).Value = sPeriodoCodigo
            oOracleCommand.Parameters.Add("@PAG1", OracleDbType.Varchar2).Value = sPagoTipo
            oOracleCommand.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            oOracleCommand.Dispose()
        End Try

    End Function

    Public Function demo2(ByVal sAnio As String, ByVal sMesNumero As String, ByVal sPagoTipo As String) As String

        Dim oOracleConnection As New OracleConnection
        Dim oOracleCommand As New OracleCommand

        Try
            '//CONEXION APERTURA
            oOracleConnection = ConnectionBegin()
            '//COMMAND PARA LLAMAR SP
            oOracleCommand.CommandText = "LOGI.ASIENTO_DESTINO_PLANILLA"
            oOracleCommand.Connection = oOracleConnection
            oOracleCommand.CommandType = CommandType.StoredProcedure
            oOracleCommand.Parameters.Add("@ANHO1", OracleDbType.Varchar2).Value = sAnio
            oOracleCommand.Parameters.Add("@MES1", OracleDbType.Varchar2).Value = sMesNumero
            oOracleCommand.Parameters.Add("@PAG1", OracleDbType.Varchar2).Value = sPagoTipo
            oOracleCommand.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            oOracleCommand.Dispose()
        End Try

    End Function

End Class
