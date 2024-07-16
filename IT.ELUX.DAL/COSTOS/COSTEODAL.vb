Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class COSTEODAL
    Inherits BaseDatosORACLE

    Function ObtenerPeriodo(ByVal mes As String, ByVal anha As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PERIODO_COSTEO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@MMES", mes),
                                                                            New Oracle.ManagedDataAccess.Client.OracleParameter("@MANHO", anha)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function LimpiarCosteo(ByVal mes As String, ByVal anho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BORRAR_ELTBCOSTEO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@MMES", mes),
                                                                            New Oracle.ManagedDataAccess.Client.OracleParameter("@MANHO", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function ProcesarCosteo(ByVal centroCod As String, ByVal mes As String, ByVal anho As String, ByVal prdo As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction
        Try
            InsertRow(centroCod, mes, anho, prdo, cn, sqlTrans)
            sqlTrans.Commit()
            resultado = "OK"
        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans.Rollback()
            resultado = ex.Message
        Catch ex As Exception
            sqlTrans.Rollback()
            resultado = ex.Message
        Finally
            sqlTrans = Nothing
        End Try
        Return resultado
    End Function

    Private Sub InsertRow(ByVal centroCod As String, ByVal mes As String, ByVal anho As String, ByVal prdo As String,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PROCESAR_COSTEO_OP"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@CENTROCOD", OracleDbType.NVarchar2).Value = centroCod
        cmd.Parameters.Add("@MMES", OracleDbType.NVarchar2).Value = mes
        cmd.Parameters.Add("@MANHO", OracleDbType.NVarchar2).Value = anho
        cmd.Parameters.Add("@MPRDO", OracleDbType.NVarchar2).Value = prdo
        cmd.Parameters.Add("@NUMOP", OracleDbType.NVarchar2).Value = ""
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

End Class
