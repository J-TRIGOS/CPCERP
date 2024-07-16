Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELARTLINEASTOKDAL
    Inherits BaseDatosORACLE
    Public Function Reporteartlineastok(ByVal flagAccion As String, ByVal sLinea As String,
                           ByVal sAlm As String, ByVal sSol As String, ByVal sAño As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction
        Try
            ''If flagAccion = "Programa" Then
            ''    Programa(cn, sqlTrans, sAño, sMes, sDia, sTurn, sCCO)
            ''End If
            ''If flagAccion = "EL" Then
            ''    ProgramaLimpiar(cn, sqlTrans)
            ''End If
            If flagAccion = "ESOP" Then
                artlineastok(cn, sqlTrans)
                'artlineastok1(cn, sqlTrans, sLinea, sAlm, sSol, sAño)
            End If
            ''If flagAccion = "SOP" Then
            ''    SeguimientoOp(cn, sqlTrans, sAño, sMes, sCCO, sDia, sTurn, sfec)
            ''End If

            If flagAccion = "SOP1" Then
                artlineastok1(cn, sqlTrans, sLinea, sAlm, sSol, sAño)
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
    Public Sub artlineastok(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                      ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "DELETE FROM TMP_ARTLINEASTOK"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Sub artlineastok1(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                      ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sLinea As String,
                       ByVal sAlm As String, ByVal sSol As String, ByVal sAño As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_RPTARTLINEA_STK"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sLinea", OracleDbType.Varchar2).Value = Trim(sLinea)
        cmd.Parameters.Add("@sAlm", OracleDbType.Varchar2).Value = Trim(sAlm)
        cmd.Parameters.Add("@sSol", OracleDbType.Varchar2).Value = Trim(sSol)
        cmd.Parameters.Add("@sAño", OracleDbType.Varchar2).Value = Trim(sAño)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
End Class
