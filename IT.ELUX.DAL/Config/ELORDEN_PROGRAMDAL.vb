Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELORDEN_PROGRAMDAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String
    Public Function SelPerAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_ROT_All", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAllOP(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDE_PROGRAM_SELECTALLOP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function VerificarRepetido(ByVal Code As String, ByVal Code2 As String, ByVal Code3 As String) As Boolean
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CTABANCO_VERIFICAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode", Code),
                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode2", Code2), New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode3", Code3)})
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function

    Public Function getListdgv1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sCod_art As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DET_DOCUMENTO_SELECT_ALM1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@Cod_art", sCod_art)})
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



    Public Function SelectAll(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDE_PROGRAM_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectMaxTransp(ByVal anho As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ORDEN_PROGRAMA_LASTCOD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Public Function SelectGroupDet(ByVal sCod As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ORDE_PROGRAM_SELGRUP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Public Function SelNroProd(ByVal sCod As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PRODUCCION_SELNROPRD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Public Function SelectProcesoCOD(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDE_PROGRAM_CODIGO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@codigo", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function list1(ByVal var As String) As DataTable

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ORDEN_PROGRAM_SEARCH", {New Oracle.ManagedDataAccess.Client.OracleParameter("@var", Trim(var))})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function listProdTot(ByVal ser As String, ByVal nro As String) As DataTable

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SEARCH_PRODTOT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@var", Trim(ser)),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@var", Trim(nro))})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function listSolmTot(ByVal ser As String, ByVal nro As String) As DataTable

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SEARCH_SOLMTOT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@var", Trim(ser)),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@var", Trim(nro))})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function listFallTot(ByVal ser As String, ByVal nro As String) As DataTable

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SEARCH_FALLTOT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@var", Trim(ser)),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@var", Trim(nro))})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function listReinTot(ByVal ser As String, ByVal nro As String) As DataTable

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SEARCH_REINTOT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@var", Trim(ser)),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@var", Trim(nro))})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function ListArt(ByVal codco As String, ByVal art_cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBORDEN_PROGRAM_UNIR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@var", Trim(codco)),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@var", Trim(art_cod))})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRow(ByVal sTdoc As String, ByVal sSDoc As String, ByVal sNDoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDE_PROGRAM_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sTDoc", sTdoc),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@sSDoc", sSDoc),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@sNDoc", sNDoc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRowDetalle(ByVal sTdoc As String, ByVal sSDoc As String, ByVal sNDoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDE_PROGRAM_SELECTROW_DET", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sTDoc", sTdoc),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@sSDoc", sSDoc),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@sNDoc", sNDoc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectLineaProduSelect(ByVal sTdoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDE_PROGRAM_LPRO_SELECT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sTdoc", sTdoc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectNro_Orden(ByVal sTdoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDE_PROGRAM_SELECT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sTdoc", sTdoc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectOrdenesProdu(ByVal ccosto As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDE_PROGRAM_ORDENES", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ccosto", ccosto)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectLineaProd(ByVal ccosto As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDE_PROGRAM_LPRODC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ccosto", ccosto)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectProcesoArt() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDE_PROGRAM_PROCS", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SaveRow(ByVal ELORDEN_PROGRAMBE As ELORDEN_PROGRAMBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String, ByVal dg As DataGridView, ByVal ELORDEN_DET_PROGRAMBE As ELORDEN_DET_PROGRAMBE) As String
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
                InsertRow(ELORDEN_PROGRAMBE, ELMVLOGSBE, cn, sqlTrans, dg, ELORDEN_DET_PROGRAMBE)
            End If
            If flagAccion = "AA" Then
                UpdateRowArticulo(ELORDEN_PROGRAMBE, ELMVLOGSBE, cn, sqlTrans, dg, ELORDEN_DET_PROGRAMBE)
            End If
            If flagAccion = "M" Then
                UpdateRow(ELORDEN_PROGRAMBE, ELMVLOGSBE, cn, sqlTrans, dg, ELORDEN_DET_PROGRAMBE)
            End If
            If flagAccion = "C" Then
                UpdateRowCerrar(ELORDEN_PROGRAMBE, ELMVLOGSBE, cn, sqlTrans, dg, ELORDEN_DET_PROGRAMBE)
            End If

            If flagAccion = "R" Then
                UpdateRowRetornar(ELORDEN_PROGRAMBE, ELMVLOGSBE, cn, sqlTrans, dg, ELORDEN_DET_PROGRAMBE)
            End If

            If flagAccion = "E" Then
                'DeleteRow(ELORDEN_PROGRAMBE, cn, sqlTrans)
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
            'If resultado = "OK" And flagAccion <> "E" Then
            '    cn.Dispose()
            'End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Public Function SaveRow1(ByVal ELPRODUCCIONBE As ELPRODUCCIONBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String) As String
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
                UPDEST3(ELPRODUCCIONBE, ELMVLOGSBE, cn, sqlTrans)
            End If
            If flagAccion = "M1" Then
                UPDEST4(ELPRODUCCIONBE, ELMVLOGSBE, cn, sqlTrans)
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
            sqlTrans = Nothing
        End Try
        Return resultado
    End Function
    Public Function ReportePrograma(ByVal flagAccion As String, ByVal sAño As String,
                           ByVal sMes As String, ByVal sDia As String, ByVal sTurn As String, ByVal sCCO As String,
                           ByVal sfec As String, ByVal numero As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction
        Try
            If flagAccion = "Programa" Then
                Programa(cn, sqlTrans, sAño, sMes, sDia, sTurn, sCCO)
            End If
            If flagAccion = "EL" Then
                ProgramaLimpiar(cn, sqlTrans)
            End If
            If flagAccion = "ESOP" Then
                LimpiarSeguimientoOp(cn, sqlTrans, numero, sAño)
            End If
            If flagAccion = "ESOP1" Then
                LimpiarSeguimientoOp1(cn, sqlTrans, sAño, sMes, sTurn, sCCO)
            End If
            If flagAccion = "SOP" Then
                SeguimientoOp(cn, sqlTrans, sAño, sMes, sCCO, sDia, sTurn, sfec)
            End If

            If flagAccion = "SOP1" Then
                SeguimientoOp1(cn, sqlTrans, sAño, sMes, sCCO, sDia, sTurn, sfec)
            End If
            If flagAccion = "SOP2" Then
                SeguimientoOp2(cn, sqlTrans, sAño, sMes, sCCO, sDia, sTurn, sfec)
            End If
            If flagAccion = "AOP1" Then
                ActOp1(cn, sqlTrans, sAño, sMes, sCCO, sDia, sTurn, sfec)
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
    Public Sub Programa(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sAño As String,
                           ByVal sMes As String, ByVal sDia As String, ByVal sTurn As String, ByVal sCCO As String)
        'Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "DELETE FROM ELTBORDEN_DET_PROGRAM"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.Text
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_RPTORDENPROGRAM_SELROW1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sAño", OracleDbType.Varchar2).Value = Trim(sAño)
        cmd.Parameters.Add("@sMes", OracleDbType.Varchar2).Value = Trim(sMes)
        cmd.Parameters.Add("@sCCO", OracleDbType.Varchar2).Value = Trim(sCCO)
        cmd.Parameters.Add("@sDia", OracleDbType.Varchar2).Value = Trim(sDia)
        cmd.Parameters.Add("@sTurn", OracleDbType.Varchar2).Value = Trim(sTurn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_MOVIM_DIFKARSTK"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("@ANNO", OracleDbType.Varchar2).Value = sAño
        'cmd.Parameters.Add("@SUBLIN", OracleDbType.Varchar2).Value = sSubLinea
        'cmd.Parameters.Add("@CODALM", OracleDbType.Varchar2).Value = sCodALm
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()

    End Sub
    Public Sub SeguimientoOp(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sAño As String,
                           ByVal sMes As String, ByVal sCCO As String, ByVal sDia As String, ByVal sTurn As String,
                           ByVal sfec As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_RPTORDENPROGRAM_SELROW4"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sNro", OracleDbType.Varchar2).Value = Trim(sAño)
        cmd.Parameters.Add("@fec1", OracleDbType.Varchar2).Value = Trim(sMes)
        cmd.Parameters.Add("@fec2", OracleDbType.Varchar2).Value = Trim(sDia)
        cmd.Parameters.Add("@sArt", OracleDbType.Varchar2).Value = Trim(sTurn)
        cmd.Parameters.Add("@sCCO", OracleDbType.Varchar2).Value = Trim(sCCO)
        cmd.Parameters.Add("@año", OracleDbType.Varchar2).Value = Trim(sfec)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Sub SeguimientoOp1(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sAño As String,
                           ByVal sMes As String, ByVal sCCO As String, ByVal sDia As String, ByVal sTurn As String,
                           ByVal sfec As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_RPTSEGPROD_ORDTMP"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sNro", OracleDbType.Varchar2).Value = Trim(sAño)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Sub SeguimientoOp2(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sAño As String,
                           ByVal sMes As String, ByVal sCCO As String, ByVal sDia As String, ByVal sTurn As String,
                           ByVal sfec As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_RPTSEGPROD_ORDTMPBC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sNro", OracleDbType.Varchar2).Value = Trim(sAño)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Sub ActOp1(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sAño As String,
                           ByVal sMes As String, ByVal sCCO As String, ByVal sDia As String, ByVal sTurn As String,
                           ByVal sfec As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_RPTSEGPROD_ACTRPD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sNro", OracleDbType.Varchar2).Value = Trim(sAño)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Public Sub LimpiarSeguimientoOp(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal numero As String, ByVal sAño As String)

        '76534
        If numero = "" Then
            Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "DELETE FROM TMP_RPTSEGPROG WHERE SER_DOC_REF=" & sAño
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "DELETE FROM TMP_RPTSEGENTES TO_CHAR(FEC_GENE,'YYYY')=" & sAño
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DEL_TMP_SEGPROD"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@NUMOPE", OracleDbType.Varchar2).Value = numero
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DEL_TMP_DETSEGPROD"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@NUMOPE", OracleDbType.Varchar2).Value = numero
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

    End Sub
    Public Sub LimpiarSeguimientoOp1(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sAño As String,
                           ByVal sMes As String, ByVal sTurn As String, ByVal sCCO As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        If sTurn <> "" And sCCO <> "" Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "DELETE FROM TMP_RPTSEGPROG WHERE ART_COD=" & sTurn & " AND NRO_DOC_REF=" &
            sCCO & " AND SUBSTR(FEC_GENE,'YYYYMM')=" & sAño & sMes
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "DELETE FROM TMP_RPTSEGENTES WHERE MESANHO=" & sAño & sMes & " AND NRO_RPD=" & sAño & "-" & sCCO
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf sTurn <> "" And sCCO = "" Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "DELETE FROM TMP_RPTSEGPROG WHERE ART_COD=" & sTurn & " AND NRO_DOC_REF=" &
            sCCO & " AND SUBSTR(FEC_GENE,'YYYYMM')=" & sAño & sMes
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "DELETE FROM TMP_RPTSEGENTES WHERE MESANHO=" & sAño & sMes & " AND NRO_RPD=" & sAño & "-" & sCCO
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If



    End Sub
    Public Sub LimpSegOp(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "DELETE FROM TMP_RPTSEGPROG"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "DELETE FROM TMP_RPTSEGENTES"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Sub ProgramaLimpiar(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "DELETE FROM TMP_RPTPROG"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UPDEST3(ByVal ELPRODUCCIONBE As ELPRODUCCIONBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBPRODUCCION_UPDEST"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@cod_art", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.cod_art
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.t_doc_ref
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.ser_doc_ref
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.nro_doc_ref
        cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = ELPRODUCCIONBE.estado
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UPDEST4(ByVal ELPRODUCCIONBE As ELPRODUCCIONBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBPRODUCCION_UPDEST1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub UpdateRowArticulo(ByVal ELORDEN_PROGRAMBE As ELORDEN_PROGRAMBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView, ByVal ELORDEN_DET_PROGRAMBE As ELORDEN_DET_PROGRAMBE)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ORDEN_PROGRAMA_UPDART"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@cod_art", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.cod_articulo
        cmd.Parameters.Add("@proceso", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.seq
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub InsertRow(ByVal ELORDEN_PROGRAMBE As ELORDEN_PROGRAMBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView, ByVal ELORDEN_DET_PROGRAMBE As ELORDEN_DET_PROGRAMBE)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0
        Dim cont As Integer = 0
        Dim fechafin, fechafindos As Date
        fechafin = ELORDEN_PROGRAMBE.fec_ini
        fechafindos = ELORDEN_PROGRAMBE.fec_ini

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ORDEN_PROGRAMA_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.t_doc_ref
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.ser_doc_ref
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.nro_doc_ref
        cmd.Parameters.Add("@c_costo", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.cco_cod
        cmd.Parameters.Add("@lin_produ", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.cod_area
        cmd.Parameters.Add("@grup_trab", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.cod_grupo
        cmd.Parameters.Add("@turno", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.turno
        cmd.Parameters.Add("@fecha_gen", OracleDbType.Date).Value = ELORDEN_PROGRAMBE.fec_gene
        cmd.Parameters.Add("@fecha_ini", OracleDbType.Date).Value = ELORDEN_PROGRAMBE.fec_ini
        cmd.Parameters.Add("@fecha_fin", OracleDbType.Date).Value = ELORDEN_PROGRAMBE.fec_fin
        cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.estado
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ORDEN_PROGRAMA_INSDET"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            ELORDEN_DET_PROGRAMBE.t_doc_ref = ELORDEN_PROGRAMBE.t_doc_ref
            ELORDEN_DET_PROGRAMBE.ser_doc_ref = ELORDEN_PROGRAMBE.ser_doc_ref
            ELORDEN_DET_PROGRAMBE.nro_doc_ref = ELORDEN_PROGRAMBE.nro_doc_ref
            ELORDEN_DET_PROGRAMBE.t_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELORDEN_DET_PROGRAMBE.ser_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELORDEN_DET_PROGRAMBE.nro_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELORDEN_DET_PROGRAMBE.seq = cont
            'ELORDEN_DET_PROGRAMBE.cod_cliente = IIf(IsDBNull(RTrim(row.Cells("COD_CLIENTE").Value)), "", RTrim(row.Cells("COD_CLIENTE").Value))
            'ELORDEN_DET_PROGRAMBE.o_produccion = IIf(IsDBNull(RTrim(row.Cells("ORDEN_PRODUCCION").Value)), "", RTrim(row.Cells("ORDEN_PRODUCCION").Value))
            ELORDEN_DET_PROGRAMBE.cod_articulo = IIf(IsDBNull(RTrim(row.Cells("COD_ARTICULO").Value)), "", RTrim(row.Cells("COD_ARTICULO").Value))
            ELORDEN_DET_PROGRAMBE.cantidad = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            ELORDEN_DET_PROGRAMBE.pendiente = IIf(IsDBNull(RTrim(row.Cells("PENDIENTE").Value)), "", RTrim(row.Cells("PENDIENTE").Value))
            ELORDEN_DET_PROGRAMBE.atentido = IIf(IsDBNull(RTrim(row.Cells("ATENDIDO").Value)), "", RTrim(row.Cells("ATENDIDO").Value))
            ELORDEN_DET_PROGRAMBE.duracion = IIf(IsDBNull(RTrim(row.Cells("DURACION").Value)), "", RTrim(row.Cells("DURACION").Value))
            'ELORDEN_DET_PROGRAMBE.fec_gen = CDate(IIf(IsDBNull(RTrim(row.Cells("Fecha_Ent").Value)), "", RTrim(row.Cells("Fecha_Ent").Value)))
            ELORDEN_DET_PROGRAMBE.fec_ini = IIf(IsDBNull(RTrim(row.Cells("FECHA_INI").Value)), "", RTrim(row.Cells("FECHA_INI").Value))
            ELORDEN_DET_PROGRAMBE.fec_fin = IIf(IsDBNull(RTrim(row.Cells("FECHA_FIN").Value)), "", RTrim(row.Cells("FECHA_FIN").Value))
            ELORDEN_DET_PROGRAMBE.estado = IIf(IsDBNull(RTrim(row.Cells("EST").Value)), "", RTrim(row.Cells("EST").Value))
            ELORDEN_DET_PROGRAMBE.num_dif = IIf(IsDBNull(RTrim(row.Cells("NUM_DIF").Value)), "", RTrim(row.Cells("NUM_DIF").Value))

            'fechafindos = fechafindos.AddMinutes(ELORDEN_DET_PROGRAMBE.duracion)
            ''Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.t_doc_ref
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.ser_doc_ref
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.nro_doc_ref
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.t_doc_ref1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.ser_doc_ref1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.nro_doc_ref1
            cmd.Parameters.Add("@seq", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.seq
            'cmd.Parameters.Add("@cod_cliente", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.cod_cliente
            'cmd.Parameters.Add("@o_produccion", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.o_produccion
            cmd.Parameters.Add("@cod_articulo", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.cod_articulo
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = ELORDEN_DET_PROGRAMBE.cantidad
            cmd.Parameters.Add("@pendiente", OracleDbType.Double).Value = ELORDEN_DET_PROGRAMBE.pendiente
            cmd.Parameters.Add("@atentido", OracleDbType.Double).Value = ELORDEN_DET_PROGRAMBE.atentido
            cmd.Parameters.Add("@duracion", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.duracion
            'cmd.Parameters.Add("@fec_gene", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("Fecha_Ent").Value)), "", RTrim(row.Cells("Fecha_Ent").Value))
            cmd.Parameters.Add("@fec_ini,", OracleDbType.Date).Value = ELORDEN_DET_PROGRAMBE.fec_ini
            cmd.Parameters.Add("@fec_fin", OracleDbType.Date).Value = ELORDEN_DET_PROGRAMBE.fec_fin
            cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.estado
            cmd.Parameters.Add("@num_dif", OracleDbType.Double).Value = ELORDEN_DET_PROGRAMBE.num_dif
            cmd.Parameters.Add("@dif_hora", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.dif_hora

            'fechafin = fechafin.AddMinutes(ELORDEN_DET_PROGRAMBE.duracion)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ORDEN_PRODUCCION_UPDESTP"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.nro_doc_ref1
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.cod_articulo
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.ser_doc_ref1
            'cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = "O"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next


        'AUDITORIA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu  'cod usu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo turno"
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRowRetornar(ByVal ELORDEN_PROGRAMBE As ELORDEN_PROGRAMBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView, ByVal ELORDEN_DET_PROGRAMBE As ELORDEN_DET_PROGRAMBE)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBORDEN_PROGRET"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(ELORDEN_DET_PROGRAMBE.t_doc_ref)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELORDEN_DET_PROGRAMBE.ser_doc_ref)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELORDEN_DET_PROGRAMBE.nro_doc_ref)
        cmd.Parameters.Add("pt_doc_ref1", OracleDbType.Varchar2).Value = "OPRD"
        cmd.Parameters.Add("pser_doc_ref1", OracleDbType.Varchar2).Value = Trim(ELORDEN_DET_PROGRAMBE.ser_doc_ref1)
        cmd.Parameters.Add("pnro_doc_ref1", OracleDbType.Varchar2).Value = Trim(ELORDEN_DET_PROGRAMBE.nro_doc_ref1)
        cmd.Parameters.Add("pART_COD", OracleDbType.Varchar2).Value = Trim(ELORDEN_DET_PROGRAMBE.cod_articulo)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "5"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Cerro un item de la OC: " + ORDENCOMPRABE.T_DOC_REF + "-" + ORDENCOMPRABE.SER_DOC_REF + "-" + ORDENCOMPRABE.NRO_DOC_REF + "-" + ORDENCOMPRABE.ART_COD1
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub UpdateRowCerrar(ByVal ELORDEN_PROGRAMBE As ELORDEN_PROGRAMBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView, ByVal ELORDEN_DET_PROGRAMBE As ELORDEN_DET_PROGRAMBE)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBORDEN_PROGCER"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = "OPRD"
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELORDEN_DET_PROGRAMBE.ser_doc_ref1)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELORDEN_DET_PROGRAMBE.nro_doc_ref1)
        cmd.Parameters.Add("pART_COD", OracleDbType.Varchar2).Value = Trim(ELORDEN_DET_PROGRAMBE.cod_articulo)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "5"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Cerro un item de la OC: " + ORDENCOMPRABE.T_DOC_REF + "-" + ORDENCOMPRABE.SER_DOC_REF + "-" + ORDENCOMPRABE.NRO_DOC_REF + "-" + ORDENCOMPRABE.ART_COD1
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub UpdateRow(ByVal ELORDEN_PROGRAMBE As ELORDEN_PROGRAMBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView, ByVal ELORDEN_DET_PROGRAMBE As ELORDEN_DET_PROGRAMBE)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ORDEN_PROGRAMA_UPDATE"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.t_doc_ref
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.ser_doc_ref
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.nro_doc_ref
        cmd.Parameters.Add("@c_costo", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.cco_cod
        cmd.Parameters.Add("@lin_produ", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.cod_area
        cmd.Parameters.Add("@grup_trab", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.cod_grupo
        cmd.Parameters.Add("@turno", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.turno
        cmd.Parameters.Add("@fecha_gen", OracleDbType.Date).Value = ELORDEN_PROGRAMBE.fec_gene
        cmd.Parameters.Add("@fecha_ini", OracleDbType.Date).Value = ELORDEN_PROGRAMBE.fec_ini
        cmd.Parameters.Add("@fecha_fin", OracleDbType.Date).Value = ELORDEN_PROGRAMBE.fec_fin
        cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.estado
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'ELIMINAR DETALLE PROGRAMA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ORDEN_PROGRAMA_DEL_DETALLE"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.t_doc_ref
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.ser_doc_ref
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.nro_doc_ref
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        'ELIMINAR DETALLE PROGRAMA

        Dim cont As Integer = 0
        Dim fechafin, fechafindos As Date
        fechafin = ELORDEN_PROGRAMBE.fec_ini
        fechafindos = ELORDEN_PROGRAMBE.fec_ini
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ORDEN_PROGRAMA_INSDET"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            ELORDEN_DET_PROGRAMBE.t_doc_ref = ELORDEN_PROGRAMBE.t_doc_ref
            ELORDEN_DET_PROGRAMBE.ser_doc_ref = ELORDEN_PROGRAMBE.ser_doc_ref
            ELORDEN_DET_PROGRAMBE.nro_doc_ref = ELORDEN_PROGRAMBE.nro_doc_ref
            ELORDEN_DET_PROGRAMBE.t_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELORDEN_DET_PROGRAMBE.ser_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELORDEN_DET_PROGRAMBE.nro_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELORDEN_DET_PROGRAMBE.seq = cont
            'ELORDEN_DET_PROGRAMBE.cod_cliente = IIf(IsDBNull(RTrim(row.Cells("COD_CLIENTE").Value)), "", RTrim(row.Cells("COD_CLIENTE").Value))
            'ELORDEN_DET_PROGRAMBE.o_produccion = IIf(IsDBNull(RTrim(row.Cells("ORDEN_PRODUCCION").Value)), "", RTrim(row.Cells("ORDEN_PRODUCCION").Value))
            ELORDEN_DET_PROGRAMBE.cod_articulo = IIf(IsDBNull(RTrim(row.Cells("COD_ARTICULO").Value)), "", RTrim(row.Cells("COD_ARTICULO").Value))
            ELORDEN_DET_PROGRAMBE.cantidad = Val(IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value)))
            ELORDEN_DET_PROGRAMBE.pendiente = Val(IIf(IsDBNull(RTrim(row.Cells("PENDIENTE").Value)), "", RTrim(row.Cells("PENDIENTE").Value)))
            ELORDEN_DET_PROGRAMBE.atentido = Val(IIf(IsDBNull(RTrim(row.Cells("ATENDIDO").Value)), "", RTrim(row.Cells("ATENDIDO").Value)))
            ELORDEN_DET_PROGRAMBE.duracion = IIf(IsDBNull(RTrim(row.Cells("DURACION").Value)), "", RTrim(row.Cells("DURACION").Value))
            'ELORDEN_DET_PROGRAMBE.fec_gen = CDate(IIf(IsDBNull(RTrim(row.Cells("Fecha_Ent").Value)), "", RTrim(row.Cells("Fecha_Ent").Value)))
            ELORDEN_DET_PROGRAMBE.fec_ini = IIf(IsDBNull(RTrim(row.Cells("FECHA_INI").Value)), "", RTrim(row.Cells("FECHA_INI").Value))
            ELORDEN_DET_PROGRAMBE.fec_fin = IIf(IsDBNull(RTrim(row.Cells("FECHA_FIN").Value)), "", RTrim(row.Cells("FECHA_FIN").Value))
            ELORDEN_DET_PROGRAMBE.estado = IIf(IsDBNull(RTrim(row.Cells("EST").Value)), "", RTrim(row.Cells("EST").Value))
            ELORDEN_DET_PROGRAMBE.num_dif = IIf(IsDBNull(RTrim(row.Cells("NUM_DIF").Value)), 0, RTrim(row.Cells("NUM_DIF").Value))

            'fechafindos = fechafindos.AddMinutes(ELORDEN_DET_PROGRAMBE.duracion)
            ''Los parametros que va recibir son las propiedades de la clase 
            If ELORDEN_DET_PROGRAMBE.estado <> "CANCELADO" Then
                cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.t_doc_ref
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.ser_doc_ref
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.nro_doc_ref
                cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.t_doc_ref1
                cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.ser_doc_ref1
                cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.nro_doc_ref1
                cmd.Parameters.Add("@seq", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.seq
                'cmd.Parameters.Add("@cod_cliente", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.cod_cliente
                'cmd.Parameters.Add("@o_produccion", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.o_produccion
                cmd.Parameters.Add("@cod_articulo", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.cod_articulo
                cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = ELORDEN_DET_PROGRAMBE.cantidad
                cmd.Parameters.Add("@pendiente", OracleDbType.Double).Value = ELORDEN_DET_PROGRAMBE.pendiente
                cmd.Parameters.Add("@atentido", OracleDbType.Double).Value = ELORDEN_DET_PROGRAMBE.atentido
                cmd.Parameters.Add("@duracion", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.duracion
                'cmd.Parameters.Add("@fec_gene", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("Fecha_Ent").Value)), "", RTrim(row.Cells("Fecha_Ent").Value))
                cmd.Parameters.Add("@fec_ini,", OracleDbType.Date).Value = ELORDEN_DET_PROGRAMBE.fec_ini
                cmd.Parameters.Add("@fec_fin", OracleDbType.Date).Value = ELORDEN_DET_PROGRAMBE.fec_fin
                cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.estado
                cmd.Parameters.Add("@num_dif", OracleDbType.Double).Value = ELORDEN_DET_PROGRAMBE.num_dif
                cmd.Parameters.Add("@dif_hora", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.dif_hora

                'fechafin = fechafin.AddMinutes(ELORDEN_DET_PROGRAMBE.duracion)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If


            If ELORDEN_PROGRAMBE.estado <> "3" Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ORDEN_PRODUCCION_UPDESTP"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.nro_doc_ref1
                cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.cod_articulo
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.ser_doc_ref1
                'cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = "O"
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Else
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ORDEN_PRODUCCION_UPDESTP1"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.nro_doc_ref1
                cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.cod_articulo
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_PROGRAMBE.ser_doc_ref1
                'cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = "O"
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
        Next

        ''ACTUALIZAR CABEZERA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ORDEN_PROGRAMA_UPDATE"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.t_doc_ref
        'cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.ser_doc_ref
        'cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.nro_doc_ref
        'cmd.Parameters.Add("@c_costo", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.cco_cod
        'cmd.Parameters.Add("@lin_produ", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.cod_area
        'cmd.Parameters.Add("@grup_trab", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.cod_grupo
        'cmd.Parameters.Add("@turno", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.turno
        'cmd.Parameters.Add("@fecha_gen", OracleDbType.Date).Value = ELORDEN_PROGRAMBE.fec_gene
        'cmd.Parameters.Add("@fecha_ini", OracleDbType.Date).Value = ELORDEN_PROGRAMBE.fec_ini
        'cmd.Parameters.Add("@fecha_fin", OracleDbType.Date).Value = fechafindos
        'cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = ELORDEN_PROGRAMBE.estado
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()

    End Sub
    Public Function VerificarRepetido(ByVal cod As String) As Boolean
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LIB_CONT_VERIFICAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod)})
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function
    Public Function ArtProd(ByVal cod As String) As Boolean
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_PROC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod)})
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function
    Public Function RPTSEGPRDORD(ByVal numOP As String) As DataTable
        If numOP = "" Then
            Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
            Dim dt As New DataTable

            Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_RPTSEGPROD_ORD1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@NNUMERO", ""),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("pCCO_COD", ""),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@MMES", ""),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@MANHO", ""),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@CODART", ""),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@CODARTCONSUMO", "")})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt
        Else
            Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
            Dim dt As New DataTable

            Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_RPTSEGPROD_ORD1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@NNUMERO", numOP),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("pCCO_COD", ""),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@MMES", ""),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@MANHO", ""),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@CODART", ""),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@CODARTCONSUMO", "")})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt
        End If

    End Function
End Class
