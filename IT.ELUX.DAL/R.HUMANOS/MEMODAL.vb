Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class MEMODAL
    Inherits BaseDatosORACLE

    Public Function CalcularNroMemo(ByVal MES As String, ByVal ANHO As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BUSCAR_NROMEMO", {New Oracle.ManagedDataAccess.Client.OracleParameter("MMES", MES),
                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("MANHO", ANHO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarListadoMEmo(ByVal ANHO As String, ByVal MES As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LISTADO_MEMO", {New Oracle.ManagedDataAccess.Client.OracleParameter("MMES", MES),
                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("MANHO", ANHO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function InsertRowMemo(ByVal MEMOBE As MEMOBE, ByVal flagaccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction
        Try
            If flagaccion = "N" Then
                InsertRowMemo(MEMOBE, cn, sqlTrans)
                sqlTrans.Commit()
                resultado = "OK"
            End If
            If flagaccion = "M" Then
                resultado = "OK"
            End If
            'If flagaccion = "E" Then
            '    DeleteRow(LibroDiario, mes, anho, cn, sqlTrans)
            '    sqlTrans.Commit()
            '    resultado = "OK"
            'End If

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

    Private Sub InsertRowMemo(ByVal MEMOBE As MEMOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                              ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_REGISTRO_MEMO"
        cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@MNRO_DOC", OracleDbType.Varchar2).Value = MEMOBE.NRO_DOC
        cmd.Parameters.Add("@MMES", OracleDbType.Varchar2).Value = MEMOBE.MES
        cmd.Parameters.Add("@MANHO", OracleDbType.Varchar2).Value = MEMOBE.ANHO
        cmd.Parameters.Add("@MPER_COD", OracleDbType.Varchar2).Value = MEMOBE.PER_COD
        cmd.Parameters.Add("@MNOM_EMP", OracleDbType.Varchar2).Value = MEMOBE.NOM_EMP
        cmd.Parameters.Add("@MFEC_GENE", OracleDbType.Varchar2).Value = MEMOBE.FEC_GENE
        cmd.Parameters.Add("@MTIPO_MEMO", OracleDbType.Varchar2).Value = MEMOBE.TIPO_MEMO
        cmd.Parameters.Add("@MMOT_MEMO", OracleDbType.Varchar2).Value = MEMOBE.MOT_MEMO
        cmd.Parameters.Add("@MFEC_INISUS", OracleDbType.Varchar2).Value = MEMOBE.FEC_INISUS
        cmd.Parameters.Add("@MDIA_SUSP", OracleDbType.Varchar2).Value = MEMOBE.DIA_SUSP
        cmd.Parameters.Add("@MFEC_FALTA", OracleDbType.Varchar2).Value = MEMOBE.FEC_FALTA
        cmd.Parameters.Add("@MCOD_SANCION", OracleDbType.Varchar2).Value = MEMOBE.COD_SANCION
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
End Class
