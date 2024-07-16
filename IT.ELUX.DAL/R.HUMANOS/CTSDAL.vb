Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect

Public Class CTSDAL

    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String

    Private Sub InsertRow(ByVal PRDO As String, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ACTUALIZAR_CTS_NUEVO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@PERIODO", OracleDbType.Varchar2).Value = PRDO
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Public Function SaveRow(ByVal PRDO As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction
        Try
            InsertRow(PRDO, cn, sqlTrans)

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

    Public Function ObtenerMesGrati(ByVal periodoCTS As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OBTENER_MES_GRATI_CTS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@PERIODOCTS", periodoCTS)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ObtenerMesIniCTS(ByVal periodoCTS As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OBTENER_MES_INI_GRATI_CTS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@PERIODOCTS", periodoCTS)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ObtenerMesFinCTS(ByVal periodoCTS As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OBTENER_MES_FIN_GRATI_CTS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@PERIODOCTS", periodoCTS)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ObtenerPagoCts(ByVal periodoGratiCTS As String, ByVal periodoIni As String, ByVal periodoFin As String, ByVal FechaFin As String, ByVal tcambio As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_RPTCALCULOCTS_ALTERNO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@PPRDO_COD", periodoGratiCTS),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@PFEC1", periodoIni),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@PFEC2", periodoFin),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@PFECHA_UTILIDAD", FechaFin),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_CMB", tcambio),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@pTTRAB1", ""),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@pTTRAB2", "")})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Private Sub InsertRowCTS(ByVal periodoCTS As String, ByVal per_cod As String, ByVal fam As String, ByVal grati As String, ByVal he As String,
                             ByVal bono As String, ByVal dia As String, ByVal mes As String, ByVal noc As String, ByVal tc As String, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                        ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ACTUALIZAR_DATOS_CTS_NUEVO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@PERIODOCTS", OracleDbType.Int16).Value = periodoCTS
        cmd.Parameters.Add("@CODIGO", OracleDbType.Varchar2).Value = per_cod
        cmd.Parameters.Add("@FAM", OracleDbType.Decimal).Value = fam
        cmd.Parameters.Add("@GRATI", OracleDbType.Decimal).Value = grati
        cmd.Parameters.Add("@HORASEXTRAS", OracleDbType.Decimal).Value = he
        cmd.Parameters.Add("@BONO", OracleDbType.Decimal).Value = bono
        cmd.Parameters.Add("@DIAS", OracleDbType.Decimal).Value = dia
        cmd.Parameters.Add("@NOCT", OracleDbType.Decimal).Value = noc
        cmd.Parameters.Add("@TCAMBIO", OracleDbType.Decimal).Value = tc
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Public Function SaveRowCTS(ByVal periodoCTS As String, ByVal per_cod As String, ByVal fam As String, ByVal grati As String, ByVal he As String,
                               ByVal bono As String, ByVal dia As String, ByVal mes As String, ByVal noc As String, ByVal tc As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction
        Try
            InsertRowCTS(periodoCTS, per_cod, fam, grati, he, bono, dia, mes, noc, tc, cn, sqlTrans)

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
End Class
