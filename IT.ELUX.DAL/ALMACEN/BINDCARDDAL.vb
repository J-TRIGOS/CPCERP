Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class BINDCARDDAL

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
        cmd.Parameters.Add("CANT", OracleDbType.Double).Value = BindCard.CANTIDAD
        cmd.Parameters.Add("MED", OracleDbType.Varchar2).Value = BindCard.MEDIDA
        cmd.Parameters.Add("USU", OracleDbType.Varchar2).Value = BindCard.USUARIO
        cmd.Parameters.Add("FECHA", OracleDbType.Varchar2).Value = BindCard.FEC_GENE
        cmd.Parameters.Add("TGUIA", OracleDbType.Varchar2).Value = BindCard.TIPOGUIA
        cmd.Parameters.Add("SGUIA", OracleDbType.Varchar2).Value = BindCard.SERIEGUIA
        cmd.Parameters.Add("NGUIA", OracleDbType.Varchar2).Value = BindCard.NUMGUIA
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub


    Public Function VerificarGuia(ByVal BindCard As BINDCARDBE) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_VERIFICAR_GUIABC", {New Oracle.ManagedDataAccess.Client.OracleParameter("TIPO", "SOLM"),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("SERIE", BindCard.SER_DOC_REF),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("NUMERO", BindCard.NRO_DOC_REF),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("CODIGO", BindCard.ART_COD)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

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
        cmd.Parameters.Add("FECHA", OracleDbType.Varchar2).Value = BindCard.FEC_GENE
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ACT_ESBC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("mNRO_DOC_REF", OracleDbType.Varchar2).Value = BindCard.NRO_DOC_REF
        cmd.Parameters.Add("mART_COD", OracleDbType.Varchar2).Value = BindCard.ART_COD
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



    Public Function SelBindCard(ByVal anho As String, ByVal mes As String, ByVal est As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SELECT_BINDCARD", {New Oracle.ManagedDataAccess.Client.OracleParameter("ANHO", anho),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("MES", mes),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("ESTADO", est)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ListadoOPAtendido(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OP_ATENDIDO_ZERO", {New Oracle.ManagedDataAccess.Client.OracleParameter("ANHO", anho),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("MES", mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ListadoConsDifFecha(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_RPT_PRODUCCION_ES", {New Oracle.ManagedDataAccess.Client.OracleParameter("MMES", mes),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("MANHO", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ListadoReingresos(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_RPT_REIN_SALIDA", {New Oracle.ManagedDataAccess.Client.OracleParameter("MMES", mes),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("MANHO", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ListadoFecMaxima(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SEG_PROD_FECMAX", {New Oracle.ManagedDataAccess.Client.OracleParameter("ANHO", anho),
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

    Public Function VerificarEstBindCard(ByVal mes As String, ByVal anho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_VERIFICAR_ESTBINDCARD", {New Oracle.ManagedDataAccess.Client.OracleParameter("MMES", mes),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("MANHO", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectBindCardNro(ByVal NRO As String, ByVal mes As String, ByVal anho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SELECTBC_NRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("NNRO", NRO),
                                                                            New Oracle.ManagedDataAccess.Client.OracleParameter("MMES", mes),
                                                                            New Oracle.ManagedDataAccess.Client.OracleParameter("MANHO", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarDatosOP(ByVal numOP As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DATOS_NUMOP", {New Oracle.ManagedDataAccess.Client.OracleParameter("NUMOP", numOP)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function VerificarEstadoGuia(ByVal guia As String, ByVal articulo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_VERIFICAR_ESTGUIA", {New Oracle.ManagedDataAccess.Client.OracleParameter("GUIA", guia),
                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("ARTICULO", articulo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function VerificarUsuario(ByVal usuario As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_VERIFICAR_TIPOUSU", {New Oracle.ManagedDataAccess.Client.OracleParameter("USU", usuario)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function VerificarOPSubLinea(ByVal artOP As String, ByVal artCons As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_VERIFICAR_OPSUBLINEA", {New Oracle.ManagedDataAccess.Client.OracleParameter("ARTOP", artOP),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("ARTCONS", artCons)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
