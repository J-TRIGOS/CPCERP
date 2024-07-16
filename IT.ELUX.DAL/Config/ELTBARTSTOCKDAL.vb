Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBARTSTOCKDAL
    Inherits BaseDatosORACLE

    'Metodo para Modificar 
    Private Sub UpdateRow(ByVal ELTBARTSTOCKBE As ELTBARTSTOCKBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBARTSTOCK_UPDFIS"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@ART_CODIGO", OracleDbType.Varchar2).Value = ELTBARTSTOCKBE.ART_CODIGO
        cmd.Parameters.Add("@ART_STKFISICO1", OracleDbType.Double).Value = ELTBARTSTOCKBE.ART_STKFISICO1
        cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = ELTBARTSTOCKBE.ART_CODALM
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el Stock Articulo: " + BOLETABE.T_DOC_REF + "-" + BOLETABE.SER_DOC_REF + "-" + BOLETABE.NRO_DOC_REF
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()

    End Sub
    Public Function SaveRow(ByVal ELTBARTSTOCKBE As ELTBARTSTOCKBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                           ByVal flagAccion As String) As String
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

            If flagAccion = "M" Then
                UpdateRow(ELTBARTSTOCKBE, ELMVLOGSBE, cn, sqlTrans)
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
