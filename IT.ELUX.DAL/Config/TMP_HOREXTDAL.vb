Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class TMP_HOREXTDAL
    Inherits BaseDatosORACLE
    Public Function ReportePrograma(ByVal TMP_HOREXTBE As TMP_HOREXTBE, ByVal flagAccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()    
        sqlTrans = cn.BeginTransaction
        Try
            If flagAccion = "ESOP" Then
                LimpiarHoraExt(cn, sqlTrans)
            End If
            If flagAccion = "SOP" Then
                SeguimientoHOREXT(TMP_HOREXTBE, cn, sqlTrans)
            End If
            If flagAccion = "C0" Then
                CreacionHor0(TMP_HOREXTBE, cn, sqlTrans)
            End If
            If flagAccion = "C1" Then
                CreacionHor1(TMP_HOREXTBE, cn, sqlTrans)
            End If
            sqlTrans.Commit()
            resultado = "OK"

        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans.Rollback()
            resultado = ex.Message
        Catch ex As Exception
            sqlTrans.Rollback()
            resultado = ex.Message
        Finally
            '   cn.Dispose()
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function

    Public Sub LimpiarHoraExt(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "DELETE FROM TMP_HOREXT"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Sub SeguimientoHOREXT(ByVal TMP_HOREXTBE As TMP_HOREXTBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_RPTHORASEXT_PRDO1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = Trim(TMP_HOREXTBE.anho)
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = Trim(TMP_HOREXTBE.cco_cod)
        'cmd.Parameters.Add("@prdo_cod", OracleDbType.Varchar2).Value = Trim(TMP_HOREXTBE.prdo_cod)
        'cmd.Parameters.Add("@prdo_cod1", OracleDbType.Varchar2).Value = Trim(TMP_HOREXTBE.prdo_cod1)
        cmd.Parameters.Add("@tipo", OracleDbType.Varchar2).Value = Trim(TMP_HOREXTBE.tipo)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Sub CreacionHor0(ByVal TMP_HOREXTBE As TMP_HOREXTBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_RPTHORASEXT_PRDOMES"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = Trim(TMP_HOREXTBE.anho)
        cmd.Parameters.Add("@mes", OracleDbType.Varchar2).Value = Trim(TMP_HOREXTBE.mes)
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = Trim(TMP_HOREXTBE.cco_cod)
        cmd.Parameters.Add("@tipo", OracleDbType.Varchar2).Value = Trim(TMP_HOREXTBE.tipo)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Sub CreacionHor1(ByVal TMP_HOREXTBE As TMP_HOREXTBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_RPTHORASEXT_PRDO1HT"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = Trim(TMP_HOREXTBE.anho)
        cmd.Parameters.Add("@mes", OracleDbType.Varchar2).Value = Trim(TMP_HOREXTBE.mes)
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = Trim(TMP_HOREXTBE.cco_cod)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
End Class
