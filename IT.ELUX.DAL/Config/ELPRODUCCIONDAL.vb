Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELPRODUCCIONDAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String

    Function list1(ByVal provee As String, ByVal ser_doc As String, ByVal nro_doc As String, ByVal tipomon As String,
                          ByVal cliente As String, ByVal var1 As String, ByVal gen_desde As Date, ByVal gen_hasta As Date) As DataTable

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PAGO_DOCUMENTO_SEARCH", {New Oracle.ManagedDataAccess.Client.OracleParameter("@PROVEE", Trim(provee)), New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC", Trim(ser_doc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC", Trim(nro_doc)), New Oracle.ManagedDataAccess.Client.OracleParameter("@TIPOMON", Trim(tipomon)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@CLIENTE", Trim(cliente)), New Oracle.ManagedDataAccess.Client.OracleParameter("@VAR1", Trim(var1)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@GEN_DESDE", gen_desde), New Oracle.ManagedDataAccess.Client.OracleParameter("@GEN_HASTA", gen_hasta)})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Public Function SelPerAll(ByVal var As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_ROT_All", {New Oracle.ManagedDataAccess.Client.OracleParameter("@var", var)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function


    Public Function SelectMaxLibro() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LIB_CONT_LASTCOD", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function
    Public Function SelFact(ByVal art_cod As String) As Double
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTFACTOR_CMP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@var", art_cod)})
            While dr.Read
                sNumero = dr.GetDouble(0)
            End While
        End Using
        Return sNumero
    End Function
    Public Function SelFact1(ByVal art_cod As String, ByVal art_cod1 As String) As Double
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTFACTOR_CMP1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@var", art_cod),
                                                                              New Oracle.ManagedDataAccess.Client.OracleParameter("@var", art_cod1)})
            While dr.Read
                sNumero = dr.GetDouble(0)
            End While
        End Using
        Return sNumero
    End Function
    Public Function SelectComponente(ByVal serie As String, ByVal nro As String, ByVal cod_art As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDEN_PRODUCCION_VER_COMPO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@serie", serie),
                                                                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@nro", nro),
                                                                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@cod_art", cod_art)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectValidarRepetido(ByVal serie As String, ByVal articulo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDEN_PRODUCCION_VALIDAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@serie", serie),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@articulo", articulo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectArticuOrden(ByVal cod_art As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDEN_PRODUCCION_SEL_ARTI", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod_art", cod_art)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectComponenteNiv2(ByVal cod_art As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDEN_PRODUCCION_VER_COMPO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sAnho", cod_art)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectMaxTransp() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ORDEN_PRODUCCION_LASTCOD", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function
    Public Function SelectStockArt(ByVal cod_art As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ORDEN_PRODUCCION_STOCK", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod_art", cod_art)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Public Function SelectAll(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDEN_PRODUCCION_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRow(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String, ByVal sArt As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDEN_PRODUCCION_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sNdoc", sNdoc),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@sTdoc", sArt),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@sSdoc", sTdoc),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@sNdoc", sSdoc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelProd(ByVal sanho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBPRODUCCION_PEN", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", sanho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelProdNro(ByVal NRO As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBPRODUCCION_PENNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO", NRO)})
            While dr.Read
                sUnid = dr.GetString(0)
            End While
        End Using
        Return sUnid

    End Function

    Public Function ProdDatos(ByVal sSer As String, ByVal sNro As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBPRODUCCION_SEARCH", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sSer),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sNro)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function OrdProg(ByVal sSer As String, ByVal sNro As String, ByVal sART As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBORDENPROGRAM_SEARCH", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sSer),
                                                                                                                       New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sNro),
                                                                                                                       New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sART)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function LineaMant(ByVal sSer As String, ByVal sNro As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("ELTBMANTENIMIENTOSEA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sSer),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sNro)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function LineaProd(ByVal sSer As String, ByVal sNro As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("ELTBORDEN_DET_PROGRAM_SEA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sSer),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sNro)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ProdHor(ByVal sSer As String, ByVal sNro As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBORDEN_DET_PROGRAM_HOR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sSer),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sNro)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelNRO(ByVal sCod As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDEN_PROGRAMNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCod)})
            While dr.Read
                sUnid = dr.GetString(0)
            End While
        End Using
        Return sUnid
    End Function

    Public Function SelNumVal(ByVal sCod As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDEN_PROGRAMNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCod)})
            While dr.Read
                sUnid = dr.GetString(0)
            End While
        End Using
        Return sUnid
    End Function
    Public Function SelectArtOp(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELARTOP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SaveRow(ByVal ELPRODUCCIONBE As ELPRODUCCIONBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String) As String
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
                ''correlativo = LastCodigo()
                InsertRow(ELPRODUCCIONBE, ELMVLOGSBE, cn, sqlTrans)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELPRODUCCIONBE, cn, sqlTrans)
            End If

            If flagAccion = "AD" Then
                UpdateRowActualizar(ELPRODUCCIONBE, cn, sqlTrans)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELPRODUCCIONBE, cn, sqlTrans)
            End If

            If flagAccion = "AO" Then
                UPDEST(ELPRODUCCIONBE, cn, sqlTrans)
            End If

            If flagAccion = "ORD" Then
                UPDNDOC(ELPRODUCCIONBE, cn, sqlTrans)
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
            If resultado = "OK" And flagAccion <> "E" Then
                'cn.Dispose()
            End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function

    Public Function SaveRow1(ByVal ELPRODUCCIONBE As ELPRODUCCIONBE, ByVal flagAccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction
        Try
            'N:Nuevo   M:Modificar   E:Eliminar 
            UPDROW(ELPRODUCCIONBE, cn, sqlTrans)
            sqlTrans.Commit()
            resultado = "OK"
        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans.Rollback()
            resultado = ex.Message
        Catch ex As Exception
            sqlTrans.Rollback()
            resultado = ex.Message
        Finally
            If resultado = "OK" And flagAccion <> "E" Then
                'cn.Dispose()
            End If
            sqlTrans = Nothing
        End Try
        Return resultado
    End Function

    Public Function SaveRow2(ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal flagAccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction
        Try
            'N:Nuevo   M:Modificar   E:Eliminar 
            UPDROW1(DET_DOCUMENTOBE, cn, sqlTrans)
            sqlTrans.Commit()
            resultado = "OK"
        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans.Rollback()
            resultado = ex.Message
        Catch ex As Exception
            sqlTrans.Rollback()
            resultado = ex.Message
        Finally
            If resultado = "OK" And flagAccion <> "E" Then
                'cn.Dispose()
            End If
            sqlTrans = Nothing
        End Try
        Return resultado
    End Function
    Public Function SaveRow3(ByVal ELPRODUCCIONBE As ELPRODUCCIONBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE,
                             ByVal dgv As DataGridView, ByVal flagAccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction
        Try
            'N:Nuevo   M:Modificar   E:Eliminar 
            INSDET(ELPRODUCCIONBE, DET_DOCUMENTOBE, dgv, cn, sqlTrans)
            sqlTrans.Commit()
            resultado = "OK"
        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans.Rollback()
            resultado = ex.Message
        Catch ex As Exception
            sqlTrans.Rollback()
            resultado = ex.Message
        Finally
            If resultado = "OK" And flagAccion <> "E" Then
                'cn.Dispose()
            End If
            sqlTrans = Nothing
        End Try
        Return resultado
    End Function
    Private Sub DeleteRow(ByVal ELPRODUCCIONBE As ELPRODUCCIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim cont As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ORDEN_PRODUCCION_ANULAR"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.nro_doc_ref
        'cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.nro_doc_ref1
        cmd.Parameters.Add("@cod_art", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.cod_art

        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Private Sub InsertRow(ByVal ELPRODUCCIONBE As ELPRODUCCIONBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ORDEN_PRODUCCION_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.t_doc_ref
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.ser_doc_ref
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.nro_doc_ref
        cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.t_doc_ref1
        cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.ser_doc_ref1
        cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.nro_doc_ref1
        cmd.Parameters.Add("@cod_art", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.cod_art
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.usuario
        cmd.Parameters.Add("@ot_pedido", OracleDbType.Double).Value = ELPRODUCCIONBE.ot_pedido
        cmd.Parameters.Add("@ot_pendiente", OracleDbType.Double).Value = ELPRODUCCIONBE.ot_pendiente
        cmd.Parameters.Add("@ot_atendido", OracleDbType.Double).Value = ELPRODUCCIONBE.ot_atendido
        cmd.Parameters.Add("@Stock_actual", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.Stoc_actual
        cmd.Parameters.Add("@cod_art_expl", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.cod_art_expl
        cmd.Parameters.Add("@opc_stock", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.opc_stock
        cmd.Parameters.Add("@descripcion", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.descripcion
        cmd.Parameters.Add("@unidad_med", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.unidad_med
        cmd.Parameters.Add("@opc_temporal", OracleDbType.Double).Value = ELPRODUCCIONBE.opc_temporal
        cmd.Parameters.Add("@demasia", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.demasia
        cmd.Parameters.Add("@cant_generar", OracleDbType.Double).Value = ELPRODUCCIONBE.cant_generar
        cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = ELPRODUCCIONBE.fec_ent
        cmd.Parameters.Add("@cant_consumo", OracleDbType.Double).Value = ELPRODUCCIONBE.cant_consumo
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AUDITORIA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu  'cod usu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo la produccion"
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRow(ByVal ELPRODUCCIONBE As ELPRODUCCIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim cont As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ORDEN_PRODUCCION_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.ser_doc_ref
        cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.nro_doc_ref
        cmd.Parameters.Add("@cod_art", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.cod_art
        cmd.Parameters.Add("@demasia", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.demasia
        cmd.Parameters.Add("@cant_generar", OracleDbType.Double).Value = ELPRODUCCIONBE.cant_generar
        'cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELPRODUCCIONBE.fec_gene
        cmd.Parameters.Add("@cant_consumo", OracleDbType.Double).Value = ELPRODUCCIONBE.ot_pedido
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AUDITORIA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELPRODUCCIONBE.usuario
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el contrato de: " + ELPRODUCCIONBE.nro_doc_ref
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub


    Private Sub UPDROW(ByVal ELPRODUCCIONBE As ELPRODUCCIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim cont As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ORDEN_PRODUCCION_UPDEST1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.t_doc_ref
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.ser_doc_ref
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.nro_doc_ref
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.cod_art
        cmd.Parameters.Add("@ndoc", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.sdoc
        cmd.Parameters.Add("@sdoc", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.ndoc
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELCONTRATOBE.codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el contrato de: " + ELCONTRATOBE.dni
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub UPDROW1(ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim cont As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCUMENTO_UPD82"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELCONTRATOBE.codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el contrato de: " + ELCONTRATOBE.dni
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub

    Private Sub INSDET(ByVal ELPRODUCCIONBE As ELPRODUCCIONBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE,
                       ByVal dgv As DataGridView, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        'For Each row As DataGridViewRow In dgv.Rows
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
            Dim cont As Integer = 0
            'DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            'DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            'DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            'If DET_DOCUMENTOBE.SER_DOC_REF <> "" Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELTBDETPRODUCCION_INS"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = "82"
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF
                cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.t_doc_ref
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.ser_doc_ref
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.nro_doc_ref
                cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
                cmd.ExecuteNonQuery()
                cmd.Dispose()
        'End If
        'Next


        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELCONTRATOBE.codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el contrato de: " + ELCONTRATOBE.dni
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub UpdateRowActualizar(ByVal ELPRODUCCIONBE As ELPRODUCCIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim cont As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ORDEN_PRODUCCION_UPD_DET"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.nro_doc_ref1
        cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.ser_doc_ref1
        cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.t_doc_ref1
        cmd.Parameters.Add("@cod_art", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.cod_art
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELCONTRATOBE.codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el contrato de: " + ELCONTRATOBE.dni
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub UPDNDOC(ByVal ELPRODUCCIONBE As ELPRODUCCIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cont As Integer = 0
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBPROD_UPDNDOC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Trim(ELPRODUCCIONBE.nro_doc_ref)
        cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = Trim(ELPRODUCCIONBE.ser_doc_ref)
        cmd.Parameters.Add("@NDOC", OracleDbType.Varchar2).Value = Trim(ELPRODUCCIONBE.ndoc)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELCONTRATOBE.codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el contrato de: " + ELCONTRATOBE.dni
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub UPDEST(ByVal ELPRODUCCIONBE As ELPRODUCCIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cont As Integer = 0
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBPROD_UPDEST"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELPRODUCCIONBE.nro_doc_ref)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELPRODUCCIONBE.ser_doc_ref)
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELPRODUCCIONBE.t_doc_ref)
        cmd.Parameters.Add("@cod_art", OracleDbType.Varchar2).Value = Trim(ELPRODUCCIONBE.cod_art)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELCONTRATOBE.codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el contrato de: " + ELCONTRATOBE.dni
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Public Function SelFec(ByVal cod As String, ByVal nro As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDEN_PRODUCCION_VALIDAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod),
                                                                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@nro", nro)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function VerificarRepetido(ByVal cod As String, ByVal nro As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDEN_PRODUCCION_VALIDAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod),
                                                                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@nro", nro)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function VerificarCerrado(ByVal cod As String, ByVal nro As String, ByVal ser As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDEN_PRODUCCION_CERRADO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod),
                                                                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@nro", nro),
                                                                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@ser", ser)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectNroAnu(ByVal sTip As String, ByVal sSer As String, ByVal sNro As String) As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PRODUCCION_SELNRO_EST", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sTip)),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sSer)),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@pNRO_DOC_REF", Trim(sNro))})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero

    End Function
End Class
