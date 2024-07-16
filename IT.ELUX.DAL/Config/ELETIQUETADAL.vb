Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELETIQUETADAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String

    Public Function SelectTipodocCOD(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_TDOC_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectMonCOD(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_MON_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectProveedorCOD(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_PROVEEDOR_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", codigo)})
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

    Public Function SelectAll(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTRL_DOCUMENTO_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectTipodoc() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_T_DOCUMENTO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectMoneda() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_MONEDA", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectProveedor() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_PROVEEDOR", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectArticulo(ByVal opcion As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_SARTICULO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@opcion", opcion)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectArticuloPro() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_SARTICULO_PRO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectArticulotwo() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_SARTICULO_TW", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectMaxTransp() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_RPTETIQUETA_LASTCOD", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function
    Public Function SelectMaxTranspTwo() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_RPTETIQUETA_LASTCOD_TWO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function
    Public Function SelectMaxTranspEns() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_RPTETIQUETA_LASTCOD_ENS", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Public Function SelectUnidadm() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_UNIDADM", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRow() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_RPTETIQUETA_SELECTROW", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRow_TWO(ByVal area As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_RPTETIQUETA_SELECTROW_TWO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@area", area)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectclienteCOD(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_CLIENTE_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectArticuloCOD(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_ARTICULO_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarFamArt(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_FAM_ART", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectfamiliaCOD(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_FAMILIA_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SaveRow(ByVal ELETIQUETABE As ELETIQUETABE, ByVal flagAccion As String) As String
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
                InsertRow(ELETIQUETABE, cn, sqlTrans)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELETIQUETABE, cn, sqlTrans)
            End If

            If flagAccion = "E" Then
                'DeleteRow(ELETIQUETABE, cn, sqlTrans)
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

    Private Sub DeleteRow(ByVal ELDOCUMENTOBE As ELDOCUMENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_LIB_CONT_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ELDOCUMENTOBE.cod
        cmd.ExecuteNonQuery()

    End Sub

    Private Sub InsertRow(ByVal ELETIQUETABE As ELETIQUETABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_RPTETIQUETA_INSERTROW_TWO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@articulo", OracleDbType.Varchar2).Value = ELETIQUETABE.articulo
        cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = ELETIQUETABE.cantidad
        cmd.Parameters.Add("@medida", OracleDbType.Varchar2).Value = ELETIQUETABE.medida
        cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = ELETIQUETABE.lote
        cmd.Parameters.Add("@fec_prod", OracleDbType.Date).Value = ELETIQUETABE.fecha_produ
        cmd.Parameters.Add("@lote_envase", OracleDbType.Varchar2).Value = ELETIQUETABE.lote_envase
        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELETIQUETABE.cod
        cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = ELETIQUETABE.estado
        cmd.Parameters.Add("@tipo", OracleDbType.Varchar2).Value = ELETIQUETABE.tipo
        cmd.Parameters.Add("@cliente", OracleDbType.Varchar2).Value = ELETIQUETABE.cliente
        cmd.Parameters.Add("@embalador", OracleDbType.Varchar2).Value = ELETIQUETABE.embalador
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = PERBE.COD  'cod usu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo turno"
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub UpdateRow(ByVal ELETIQUETABE As ELETIQUETABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CTRL_DOCUMENTO_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add("@t_ope", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.t_ope
        'cmd.Parameters.Add("@cbco_cod", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.cbco_cod
        'cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.t_doc_ref
        'cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.ser_doc_ref
        'cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.nro_doc_ref
        'cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELDOCUMENTOBE.fec_gene
        'cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.proveedor
        'cmd.Parameters.Add("@concepto", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.concepto
        'cmd.Parameters.Add("@fec_pago", OracleDbType.Date).Value = ELDOCUMENTOBE.fec_pago
        'cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.moneda
        'cmd.Parameters.Add("@tprecio_compra", OracleDbType.Double).Value = ELDOCUMENTOBE.tprecio_compra
        'cmd.Parameters.Add("@tprecio_dcompra", OracleDbType.Double).Value = ELDOCUMENTOBE.tprecio_dcompra
        'cmd.Parameters.Add("@t_cambio", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.t_cambio
        'cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.nro_doc_ref1
        'cmd.Parameters.Add("@tipo1", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.tipo1
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
    Public Function SelectActivoCOD(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_ACTIVO_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectUserCOD(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_USER_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectActivoPro() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_ACTIVO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectUserPro() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_USER", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectArtMes(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SEARCH2", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAllPacking(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PACKING_SELECTAll", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ANHO", anho),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarDatosRotulo(ByVal numero As String, ByVal art As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ROTULO_DATOSOC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@MNRO_REQ", numero),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("MART_COD", art)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SaveRowEtiqueta(ByVal GUIASROTULOBE As GUIASROTULOBE, ByVal flagAccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction
        Try
            If flagAccion = "N" Then
                InsertRowEtiqueta(GUIASROTULOBE, cn, sqlTrans)
            End If

            'If flagAccion = "M" Then
            '    UpdateRow(GUIASROTULOBE, cn, sqlTrans)
            'End If

            'If flagAccion = "E" Then
            '    'DeleteRow(ELETIQUETABE, cn, sqlTrans)
            'End If
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
            End If
            sqlTrans = Nothing
        End Try
        Return resultado
    End Function

    Private Sub InsertRowEtiqueta(ByVal GUIASROTULOBE As GUIASROTULOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        For i = 1 To GUIASROTULOBE.TOTBULTOS
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ROTULOGUIAS_INS"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add("@MTIP", OracleDbType.Varchar2).Value = GUIASROTULOBE.T_DOC_REF
            cmd.Parameters.Add("@MSER", OracleDbType.Varchar2).Value = GUIASROTULOBE.SER_DOC_REF
            cmd.Parameters.Add("@MNRO", OracleDbType.Varchar2).Value = GUIASROTULOBE.NRO_DOC_REF
            cmd.Parameters.Add("@MTIP1", OracleDbType.Varchar2).Value = GUIASROTULOBE.T_DOC_REF1
            cmd.Parameters.Add("@MSER1", OracleDbType.Varchar2).Value = GUIASROTULOBE.SER_DOC_REF1
            cmd.Parameters.Add("@MNRO1", OracleDbType.Varchar2).Value = GUIASROTULOBE.NRO_DOC_REF1
            cmd.Parameters.Add("@MCTCT", OracleDbType.Varchar2).Value = GUIASROTULOBE.CTCT_COD
            cmd.Parameters.Add("@MCANT_OC", OracleDbType.Double).Value = GUIASROTULOBE.CANT_OC
            cmd.Parameters.Add("@MFECING", OracleDbType.Varchar2).Value = GUIASROTULOBE.FEC_ING
            cmd.Parameters.Add("@MART_COD", OracleDbType.Varchar2).Value = GUIASROTULOBE.ART_COD
            cmd.Parameters.Add("@MCANT", OracleDbType.Double).Value = GUIASROTULOBE.CANTIDAD
            cmd.Parameters.Add("@MBULTO", OracleDbType.Double).Value = i
            cmd.Parameters.Add("@MTOTBULTO", OracleDbType.Double).Value = GUIASROTULOBE.TOTBULTOS
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

    End Sub

    Public Function VerificarRegistro(ByVal GUIASROTULOBE As GUIASROTULOBE) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_VERIFICAR_REGETIQ", {New Oracle.ManagedDataAccess.Client.OracleParameter("@MTIP", GUIASROTULOBE.T_DOC_REF),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@MSER", GUIASROTULOBE.SER_DOC_REF),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@MNRO", GUIASROTULOBE.NRO_DOC_REF),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@MTIP1", GUIASROTULOBE.T_DOC_REF1),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@MSER1", GUIASROTULOBE.SER_DOC_REF1),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@MNRO1", GUIASROTULOBE.NRO_DOC_REF1),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@MARTCOD", GUIASROTULOBE.ART_COD)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarRotulosGuia() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_LISTADO_ROTGUIAS", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class

