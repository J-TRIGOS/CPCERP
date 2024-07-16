Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect

Public Class DETBINDCARDDAL

    Inherits BaseDatosORACLE
    Public Function SaveRow(ByVal DetBindCard As DETBINDCARDBE, ByVal flagaccion As String, ByVal lote As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction

        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction

        Try
            If flagaccion = "N" Then
                InsertRow(DetBindCard, cn, sqlTrans, lote)
                sqlTrans.Commit()
                resultado = "OK"
            End If
            If flagaccion = "M" Then

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

    Private Sub InsertRow(ByVal DetBindCard As DETBINDCARDBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                    ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal lote As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_REGISTRO_DET_BINDCARD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("mNRO_DOC_REF", OracleDbType.Varchar2).Value = DetBindCard.NRO_DOC_REF
        cmd.Parameters.Add("mART_COD", OracleDbType.Varchar2).Value = DetBindCard.ART_COD
        cmd.Parameters.Add("mDESC_ART", OracleDbType.Varchar2).Value = DetBindCard.DESC_ART
        cmd.Parameters.Add("mITEM", OracleDbType.NVarchar2).Value = DetBindCard.ITEM
        cmd.Parameters.Add("mFEC_CONSUMO", OracleDbType.NVarchar2).Value = DetBindCard.FEC_CONSUMO
        cmd.Parameters.Add("mNRO_DOC_OP", OracleDbType.Varchar2).Value = DetBindCard.NRO_DOC_OP
        cmd.Parameters.Add("mSERIE_REF", OracleDbType.Varchar2).Value = DetBindCard.SERIE_REF
        cmd.Parameters.Add("mDESCRIPCION", OracleDbType.Varchar2).Value = DetBindCard.DESCRIPCION
        cmd.Parameters.Add("mCONSUMO", OracleDbType.Double).Value = DetBindCard.CONSUMO
        cmd.Parameters.Add("mREINGRESO", OracleDbType.Varchar2).Value = DetBindCard.REINGRESO
        cmd.Parameters.Add("mMAQUINA", OracleDbType.Varchar2).Value = DetBindCard.MAQUINA
        cmd.Parameters.Add("mRENDIMIENTO", OracleDbType.NVarchar2).Value = DetBindCard.RENDIMIENTO
        cmd.Parameters.Add("mOPERARIO", OracleDbType.Varchar2).Value = DetBindCard.OPERARIO
        cmd.Parameters.Add("mMERMA", OracleDbType.Varchar2).Value = DetBindCard.MERMA
        cmd.Parameters.Add("mCCOCOD", OracleDbType.Varchar2).Value = DetBindCard.CCOCOD
        cmd.Parameters.Add("mCODARTOP", OracleDbType.Varchar2).Value = DetBindCard.CODARTOP
        cmd.Parameters.Add("mNOMARTOP", OracleDbType.Varchar2).Value = DetBindCard.NOMARTOP
        cmd.Parameters.Add("mCODTRA", OracleDbType.Varchar2).Value = DetBindCard.CODTRA
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ACT_ESBC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("mNRO_DOC_REF", OracleDbType.Varchar2).Value = DetBindCard.NRO_DOC_REF
        cmd.Parameters.Add("mART_COD", OracleDbType.Varchar2).Value = DetBindCard.ART_COD
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        If DetBindCard.ART_COD.Substring(0, 4) = "0502" Or DetBindCard.ART_COD.Substring(0, 4) = "0542" Or DetBindCard.ART_COD.Substring(0, 4) = "0532" Or DetBindCard.ART_COD.Substring(0, 4) = "0521" _
        Or DetBindCard.ART_COD.Substring(0, 4) = "0588" Or DetBindCard.ART_COD.Substring(0, 4) = "0599" Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ACTUALIZAR_BINDCAR_LOTE"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("mNRO_DOC_REF", OracleDbType.Varchar2).Value = DetBindCard.NRO_DOC_REF
            cmd.Parameters.Add("mART_COD", OracleDbType.Varchar2).Value = DetBindCard.ART_COD
            cmd.Parameters.Add("mSERIE_REF", OracleDbType.Varchar2).Value = DetBindCard.SERIE_REF
            cmd.Parameters.Add("mLOTE", OracleDbType.Varchar2).Value = lote
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

    End Sub


    Public Function BuscarDetalleBindCard(ByVal serie As String, ByVal numero As String, ByVal codart As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OBTENER_DET_BINDCARD", {New Oracle.ManagedDataAccess.Client.OracleParameter("SERIE", serie),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("NUMERO", numero),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("CODIGO", codart)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function VerificarKardex(ByVal tipo As String, ByVal serie As String, ByVal numero As String, ByVal codart As String, ByVal cantidad As Double, ByVal almacen As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_VERIFICAR_KARDEX_BINDCARD", {New Oracle.ManagedDataAccess.Client.OracleParameter("TIPO", tipo),
                                                                                         New Oracle.ManagedDataAccess.Client.OracleParameter("SERIE", serie),
                                                                                         New Oracle.ManagedDataAccess.Client.OracleParameter("NUMERO", numero),
                                                                                         New Oracle.ManagedDataAccess.Client.OracleParameter("CODIGO", codart),
                                                                                         New Oracle.ManagedDataAccess.Client.OracleParameter("CANTIOAD", cantidad),
                                                                                         New Oracle.ManagedDataAccess.Client.OracleParameter("ALMACEN", almacen)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

End Class
