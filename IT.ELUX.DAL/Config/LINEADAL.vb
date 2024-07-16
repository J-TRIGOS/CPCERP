Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class LINEADAL
    Inherits BaseDatosORACLE
    Private Sub InsertRow(ByVal LINEABE As LINEABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ARTICULO_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = LINEABE.cod
        cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = LINEABE.nom
        cmd.Parameters.Add("@situacion", OracleDbType.Char).Value = LINEABE.situacion
        cmd.Parameters.Add("@ccosto_cod", OracleDbType.Char).Value = LINEABE.ccosto_cod
        cmd.Parameters.Add("@linea_ccosto_codigo", OracleDbType.Char).Value = LINEABE.linea_ccosto_codigo
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el articulo: " + LINEABE.cod
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRow(ByVal LINEABE As LINEABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE)
        'realiza registro del catalogo
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ARTICULO_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("cod", OracleDbType.Char).Value = LINEABE.cod
        cmd.Parameters.Add("nom", OracleDbType.Varchar2).Value = LINEABE.nom
        cmd.Parameters.Add("situacion", OracleDbType.Varchar2).Value = LINEABE.situacion
        cmd.Parameters.Add("ccosto_cod", OracleDbType.Char).Value = LINEABE.ccosto_cod
        cmd.Parameters.Add("linea_ccosto_codigo", OracleDbType.Varchar2).Value = LINEABE.linea_ccosto_codigo
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Modifico el articulo: " + LINEABE.cod + " " + LINEABE.nom
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Function SaveRow(ByVal LINEABE As LINEABE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try
            'N:Nuevo   M:Modificar   E:Eliminar 

            If flagAccion = "N" Then
                InsertRow(LINEABE, cn, sqlTrans, ELMVLOGSBE)
            End If

            If flagAccion = "M" Then
                UpdateRow(LINEABE, cn, sqlTrans, ELMVLOGSBE)
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
            If resultado = "OK" Then
                cn.Dispose()
            End If
            sqlTrans = Nothing
        End Try
        Return resultado
    End Function
End Class
