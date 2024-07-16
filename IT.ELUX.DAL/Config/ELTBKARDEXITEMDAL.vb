Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBKARDEXITEMDAL
    Inherits BaseDatosORACLE
    Public Function SelectRow(ByVal sCode As String, ByVal sPRDO As String, ByVal sTipo As String, ByVal sNro As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TEMP_KARDEXITEM_SEL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@sPRDO", sPRDO),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@sTipo", sTipo),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@sNro", sNro)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SaveRow(ByVal ELTBKARDEXITEMBE As ELTBKARDEXITEMBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
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

            If flagAccion = "N" Then
                InsertRow(ELTBKARDEXITEMBE, ELMVLOGSBE, cn, sqlTrans)
            End If
            If flagAccion = "M" Then
                UpdateRow(ELTBKARDEXITEMBE, ELMVLOGSBE, cn, sqlTrans)
            End If
            If flagAccion = "E" Then
                DeleteRow(ELTBKARDEXITEMBE, ELMVLOGSBE, cn, sqlTrans)
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
            'If resultado = "OK" Then
            '    cn.Dispose()
            'End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function

    Private Sub InsertRow(ByVal ELTBKARDEXITEMBE As ELTBKARDEXITEMBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TEMP_KARDEXITEM_INS"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.T_DOC_REF
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.SER_DOC_REF
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.NRO_DOC_REF
        cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.ART_COD
        cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBKARDEXITEMBE.FEC_GENE
        cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.TIPO
        cmd.Parameters.Add("@T_MOVINV", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.T_MOVINV
        cmd.Parameters.Add("@UPRECIO_COMPRA", OracleDbType.Double).Value = ELTBKARDEXITEMBE.UPRECIO_COMPRA
        cmd.Parameters.Add("@PERIODO", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.PERIODO
        cmd.Parameters.Add("@CANTIDAD", OracleDbType.Double).Value = ELTBKARDEXITEMBE.CANTIDAD
        cmd.Parameters.Add("@X_FEC", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.X_FEC
        cmd.Parameters.Add("@X_SUP", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.X_SUP
        cmd.Parameters.Add("@X_CANT", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.X_CANT
        cmd.Parameters.Add("@X_PRECIO", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.X_PRECIO
        cmd.Parameters.Add("@X_MOV", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.X_MOV
        cmd.Parameters.Add("@FORMA", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.FORMA
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + FACTURACIONBE.T_DOC_REF + "-" + FACTURACIONBE.SER_DOC_REF + "-" + FACTURACIONBE.NRO_DOC_REF
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub UpdateRow(ByVal ELTBKARDEXITEMBE As ELTBKARDEXITEMBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TEMP_KARDEXITEM_UPD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.NRO_DOC_REF
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.ART_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBKARDEXITEMBE.FEC_GENE
        cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.TIPO
        cmd.Parameters.Add("@T_MOVINV", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.T_MOVINV
        cmd.Parameters.Add("@UPRECIO_COMPRA", OracleDbType.Double).Value = ELTBKARDEXITEMBE.UPRECIO_COMPRA
        cmd.Parameters.Add("@PERIODO", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.PERIODO
        cmd.Parameters.Add("@CANTIDAD", OracleDbType.Double).Value = ELTBKARDEXITEMBE.CANTIDAD
        cmd.Parameters.Add("@X_FEC", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.X_FEC
        cmd.Parameters.Add("@X_SUP", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.X_SUP
        cmd.Parameters.Add("@X_CANT", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.X_CANT
        cmd.Parameters.Add("@X_PRECIO", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.X_PRECIO
        cmd.Parameters.Add("@X_MOV", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.X_MOV
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + FACTURACIONBE.T_DOC_REF + "-" + FACTURACIONBE.SER_DOC_REF + "-" + FACTURACIONBE.NRO_DOC_REF
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub

    Private Sub DeleteRow(ByVal ELTBKARDEXITEMBE As ELTBKARDEXITEMBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TEMP_KARDEXITEM_DEL"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.NRO_DOC_REF
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.ART_COD
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.TIPO
        cmd.Parameters.Add("@PERIODO", OracleDbType.Varchar2).Value = ELTBKARDEXITEMBE.PERIODO
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + FACTURACIONBE.T_DOC_REF + "-" + FACTURACIONBE.SER_DOC_REF + "-" + FACTURACIONBE.NRO_DOC_REF
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub

    Public Function VerificarDatos(ByVal ELTBKARDEXITEMBE As ELTBKARDEXITEMBE) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_VERIFICAR_CANT_KARDEXCONT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ANHO", ELTBKARDEXITEMBE.PERIODO),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER", ELTBKARDEXITEMBE.SER_DOC_REF),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO", ELTBKARDEXITEMBE.NRO_DOC_REF),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@ARTCOD", ELTBKARDEXITEMBE.ART_COD),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@TIPO", ELTBKARDEXITEMBE.TIPO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

End Class
