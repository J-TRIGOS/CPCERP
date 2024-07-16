Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect

Public Class BINDCARDDAL2
    Inherits BaseDatosORACLE

    Public Function SaveRow(ByVal BindCard As BINDCARDBE, ByVal flagaccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction

        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction

        Try
            If flagaccion = "N" Then
                InsertRow(BindCard, cn, sqlTrans)
                sqlTrans.Commit()
                resultado = "OK"
            End If
            If flagaccion = "M" Then
                UpdateRow(BindCard, cn, sqlTrans)
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

    Private Sub InsertRow(ByVal BindCard As BINDCARDBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                      ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_REGISTRO_BINDCARD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("SERIE_DOC", OracleDbType.Varchar2).Value = BindCard.SER_DOC_REF
        cmd.Parameters.Add("NRO_DOC", OracleDbType.Varchar2).Value = BindCard.NRO_DOC_REF
        cmd.Parameters.Add("CODIGO", OracleDbType.Varchar2).Value = BindCard.ART_COD
        cmd.Parameters.Add("DESCRI", OracleDbType.Varchar2).Value = BindCard.DESC_ART
        cmd.Parameters.Add("CANT", OracleDbType.Int16).Value = BindCard.CANTIDAD
        cmd.Parameters.Add("MED", OracleDbType.Varchar2).Value = BindCard.MEDIDA
        cmd.Parameters.Add("USU", OracleDbType.Varchar2).Value = BindCard.USUARIO
        cmd.Parameters.Add("FECHA", OracleDbType.Varchar2).Value = BindCard.FEC_GENE
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub UpdateRow(ByVal BindCard As BINDCARDBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                      ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ACTUALIZAR_BINDCARD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("SER", OracleDbType.Varchar2).Value = BindCard.SER_DOC_REF
        cmd.Parameters.Add("NUM", OracleDbType.Varchar2).Value = BindCard.NRO_DOC_REF
        cmd.Parameters.Add("COD", OracleDbType.Varchar2).Value = BindCard.ART_COD
        cmd.Parameters.Add("ESTADO", OracleDbType.Varchar2).Value = BindCard.EST
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Public Function VerificarRegistro(ByVal BindCard As BINDCARDBE) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_VERIFICAR_BINDCARD", {New Oracle.ManagedDataAccess.Client.OracleParameter("SERIE", BindCard.SER_DOC_REF),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("NUMERO", BindCard.NRO_DOC_REF),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("CODIGO", BindCard.ART_COD)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelBindCard(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SELECT_BINDCARD", {New Oracle.ManagedDataAccess.Client.OracleParameter("ANHO", anho),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("MES", mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Sub ActualizarBindCard(ByVal bindcard As BINDCARDBE)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ACTUALIZAR_BINDCARD", {New Oracle.ManagedDataAccess.Client.OracleParameter("SER", bindcard.SER_DOC_REF),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("NUM", bindcard.NRO_DOC_REF),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("COD", bindcard.ART_COD),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("ESTADO", bindcard.EST)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
    End Sub

    Public Function BuscarCentroCosto(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BUSCAR_CCPERSONAL", {New Oracle.ManagedDataAccess.Client.OracleParameter("CODIGO", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

End Class
