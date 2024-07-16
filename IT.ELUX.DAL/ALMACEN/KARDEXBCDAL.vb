Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect

Public Class KARDEXBCDAL

    Inherits BaseDatosORACLE

    Public Function SaveRow(ByVal KARDEXBCBE As KARDEXBINDCARDBE, ByVal flagaccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction

        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction

        Try
            If flagaccion = "N" Then
                InsertRow(KARDEXBCBE, cn, sqlTrans)
                sqlTrans.Commit()
                resultado = "OK"
            End If
            If flagaccion = "M" Then
                resultado = "OK"
            End If
            If flagaccion = "A" Then
                DeleteRow(KARDEXBCBE, cn, sqlTrans)
                sqlTrans.Commit()
                resultado = "OK"
            End If
        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans.Rollback()
            resultado = ex.Message
        Catch ex As Exception
            sqlTrans.Rollback()
            resultado = ex.Message
        Finally
            'If resultado = "OK" Then
            '    cn.Dispose()
            'End If
            sqlTrans = Nothing
        End Try

        Return resultado
    End Function

    Private Sub InsertRow(ByVal KARDEXBCBE As KARDEXBINDCARDBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_REGISTRO_KARDEX_BINDCARD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase ¿
        cmd.Parameters.Add("mMOV_T_DOC_REF", OracleDbType.Varchar2).Value = KARDEXBCBE.MOV_T_DOC_REF
        cmd.Parameters.Add("mMOV_SER_DOC_REF", OracleDbType.Varchar2).Value = KARDEXBCBE.MOV_SER_DOC_REF
        cmd.Parameters.Add("mMOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = KARDEXBCBE.MOV_NRO_DOC_REF
        cmd.Parameters.Add("mMOV_TIPO_TRANS", OracleDbType.Varchar2).Value = KARDEXBCBE.MOV_TIPO_TRANS
        cmd.Parameters.Add("mMOV_CODALM", OracleDbType.Varchar2).Value = KARDEXBCBE.MOV_CODALM
        cmd.Parameters.Add("mCANTIDAD", OracleDbType.Decimal).Value = KARDEXBCBE.CANTIDAD
        cmd.Parameters.Add("mMOV_FECEMI", OracleDbType.Varchar2).Value = KARDEXBCBE.MOV_FECEMI
        cmd.Parameters.Add("mMOV_CODART", OracleDbType.Varchar2).Value = KARDEXBCBE.MOV_CODART
        cmd.Parameters.Add("mMOV_CODUM", OracleDbType.Varchar2).Value = KARDEXBCBE.MOV_CODUM
        cmd.Parameters.Add("mMOV_CANTID", OracleDbType.Decimal).Value = KARDEXBCBE.MOV_CANTID
        cmd.Parameters.Add("mMOV_ESTADO", OracleDbType.Varchar2).Value = KARDEXBCBE.MOV_ESTADO
        cmd.Parameters.Add("mMOV_CODUSR", OracleDbType.Varchar2).Value = KARDEXBCBE.MOV_CODUSR
        cmd.Parameters.Add("mMOV_CODTRA", OracleDbType.Varchar2).Value = KARDEXBCBE.MOV_CODTRA
        cmd.Parameters.Add("mMOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = KARDEXBCBE.MOV_NRO_DOC_REF1
        cmd.Parameters.Add("mMOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = KARDEXBCBE.MOV_SER_DOC_REF1
        cmd.Parameters.Add("mMOV_T_DOC_REF1", OracleDbType.Varchar2).Value = KARDEXBCBE.MOV_T_DOC_REF1
        cmd.Parameters.Add("mNUMOP", OracleDbType.Varchar2).Value = KARDEXBCBE.NUMOP
        cmd.Parameters.Add("mCCO_COD", OracleDbType.Varchar2).Value = KARDEXBCBE.CCO_COD
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub DeleteRow(ByVal KARDEXBCBE As KARDEXBINDCARDBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DELETE_KARDEX_BINDCARD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase ¿

        cmd.Parameters.Add("SERIE", OracleDbType.Varchar2).Value = KARDEXBCBE.MOV_SER_DOC_REF1
        cmd.Parameters.Add("NUMERO", OracleDbType.Varchar2).Value = KARDEXBCBE.MOV_NRO_DOC_REF1
        cmd.Parameters.Add("ALMACEN", OracleDbType.Varchar2).Value = KARDEXBCBE.MOV_CODALM
        cmd.Parameters.Add("ARTICULO", OracleDbType.Varchar2).Value = KARDEXBCBE.MOV_CODART
        cmd.Parameters.Add("CANT", OracleDbType.Decimal).Value = KARDEXBCBE.MOV_CANTID
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

End Class
