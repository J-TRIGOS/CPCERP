Imports IT.ELUX.BE
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class REPORTE_TRABAJODAL
    Inherits BaseDatosORACLE
    Public sNumero As String
    Public Function SelectNro(ByVal sTip As String, ByVal sSer As String) As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TRABAJO_SELECTNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sTip)),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sSer))})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero

    End Function
    Public Function SelectDia(ByVal sDni As String, ByVal sAct As String, ByVal sFec As String, ByVal sTur As String, ByVal sFac As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TRABAJO_SELECTDIA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sPER_COD", sDni),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@sACTIVIDAD", sAct),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@sFEC_DIA", sFec),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@sTURNO", sTur),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@sflagAccion", sFac)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAll(ByVal sFecAño As String, ByVal sFecMes As String, ByVal sUser As String) As DataTable
        Dim cmd As Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TRABAJO_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@USER", sUser)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAllHEJ(ByVal sFecAño As String, ByVal sFecMes As String, ByVal sUser As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBHORAMANT_SELECTALLHEJ", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                                         New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes),
                                                                                                                         New Oracle.ManagedDataAccess.Client.OracleParameter("@USER", sUser)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAllHEJP(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBHORAMANT_SELECTALLHEJP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRow(ByVal sCod As String, ByVal sSer As String, ByVal sNro As String) As DataTable
        Dim cmd As Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TRABAJO_SELECTROWS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sCod", sCod),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@sSer", sSer),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@sNro", sNro)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRowDet(ByVal sCod As String, ByVal sSer As String, ByVal sNro As String) As DataTable
        Dim cmd As Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TRABAJO_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sCod", sCod),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@sSer", sSer),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@sNro", sNro)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectActivos1(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBHORAMANT_SELECT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectUsuario(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_USERLINEA_DNI", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sCod", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function listcco_cod(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OM_LISTCCO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function listcco_cod_c(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OM_LISTCCO_C", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Public Function SelectRowOM(ByVal sSer As String, ByVal sNro As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TRABAJO_SELECTOM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sSer", sSer),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@sNro", sNro)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelPermiso(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBUSERPERMISO_EST", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode))})
            While dr.Read
                sNumero = dr.GetString(0)
            End While
        End Using
        Return sNumero
    End Function
    Public Function SaveRow(ByVal REPORTE_TRABAJOBE As REPORTE_TRABAJOBE, ByVal REPORTE_DETTRABAJOBE As REPORTE_DETTRABAJOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction

        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction

        Try
            If flagAccion = "N" Then
                InsertRow(REPORTE_TRABAJOBE, REPORTE_DETTRABAJOBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "M" Then
                UpdateRow(REPORTE_TRABAJOBE, REPORTE_DETTRABAJOBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "A" Then
                AnularRow(REPORTE_TRABAJOBE, REPORTE_DETTRABAJOBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            'If flagAccion = "AC" Then
            '    UpdateRowApro(REPORTE_TRABAJOBE, REPORTE_DETTRABAJOBE, ELMVLOGSBE, cn, sqlTrans)
            'End If
            'If flagAccion = "DE" Then
            '    UpdateRowDpro(REPORTE_TRABAJOBE, REPORTE_DETTRABAJOBE, ELMVLOGSBE, cn, sqlTrans)
            'End If

            If flagAccion = "HM" Then
                UpdEstHMJ(REPORTE_TRABAJOBE, REPORTE_DETTRABAJOBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "HMJP" Then
                UpdEstHMJP(REPORTE_TRABAJOBE, REPORTE_DETTRABAJOBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "DS" Then
                UpdEstDSJ(REPORTE_TRABAJOBE, REPORTE_DETTRABAJOBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "DSJP" Then
                UpdEstDSJP(REPORTE_TRABAJOBE, REPORTE_DETTRABAJOBE, ELMVLOGSBE, cn, sqlTrans, dg)
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
    Private Sub UpdEstDSJP(ByVal REPORTE_TRABAJOBE As REPORTE_TRABAJOBE, ByVal REPORTE_DETTRABAJOBE As REPORTE_DETTRABAJOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBHORAMANT_UPDATEHMJP"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.NRO_DOC_REF)
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = 1
        cmd.Parameters.Add("@jefe_planta", OracleDbType.Varchar2).Value = ELMVLOGSBE.log_codusu
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub UpdEstDSJ(ByVal REPORTE_TRABAJOBE As REPORTE_TRABAJOBE, ByVal REPORTE_DETTRABAJOBE As REPORTE_DETTRABAJOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBHORAMANT_UPDATEHEJ"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.NRO_DOC_REF)
        cmd.Parameters.Add("@usuario_vb", OracleDbType.Varchar2).Value = 1
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELMVLOGSBE.log_codusu
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdEstHMJ(ByVal REPORTE_TRABAJOBE As REPORTE_TRABAJOBE, ByVal REPORTE_DETTRABAJOBE As REPORTE_DETTRABAJOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBHORAMANT_UPDATEHEJ"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.NRO_DOC_REF)
        cmd.Parameters.Add("@usuario_vb", OracleDbType.Varchar2).Value = 2
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELMVLOGSBE.log_codusu
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        ''cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        ''cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        ''cmd.Connection = sqlCon
        ''cmd.Transaction = sqlTrans
        ''cmd.CommandType = CommandType.StoredProcedure
        ''cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "2"
        ''cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        ''cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Anulo el Reporte de Horas: " + ELTBDETSTIEMBE.T_DOC_REF + "-" + ELTBDETSTIEMBE.SER_DOC_REF + "-" + ELTBDETSTIEMBE.NRO_DOC_REF
        ''cmd.ExecuteNonQuery()
        ''cmd.Dispose()
    End Sub
    Private Sub UpdEstHMJP(ByVal REPORTE_TRABAJOBE As REPORTE_TRABAJOBE, ByVal REPORTE_DETTRABAJOBE As REPORTE_DETTRABAJOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBHORAMANT_UPDATEHMJP"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.NRO_DOC_REF)
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.EST)
        cmd.Parameters.Add("@jefe_planta", OracleDbType.Varchar2).Value = ELMVLOGSBE.log_codusu
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        ''cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        ''cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        ''cmd.Connection = sqlCon
        ''cmd.Transaction = sqlTrans
        ''cmd.CommandType = CommandType.StoredProcedure
        ''cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "2"
        ''cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        ''cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Anulo el Reporte de Horas: " + ELTBDETSTIEMBE.T_DOC_REF + "-" + ELTBDETSTIEMBE.SER_DOC_REF + "-" + ELTBDETSTIEMBE.NRO_DOC_REF
        ''cmd.ExecuteNonQuery()
        ''cmd.Dispose()
    End Sub
    Private Sub InsertRow(ByVal REPORTE_TRABAJOBE As REPORTE_TRABAJOBE, ByVal REPORTE_DETTRABAJOBE As REPORTE_DETTRABAJOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim HO As Integer = 0
        Dim MI As Integer = 0
        Dim SE As Integer = 0

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TRABAJO_INSERT" 'ELTBHORAMANT lpad 
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.NRO_DOC_REF)
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.EST)
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = REPORTE_TRABAJOBE.FEC_GENE
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.PER_COD)
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = REPORTE_TRABAJOBE.FEC_DIA
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = REPORTE_TRABAJOBE.CCO_COD
        cmd.Parameters.Add("@LINEA", OracleDbType.Varchar2).Value = REPORTE_TRABAJOBE.lINEA
        cmd.Parameters.Add("@turno", OracleDbType.Varchar2).Value = REPORTE_TRABAJOBE.TURNO
        cmd.Parameters.Add("@est1", OracleDbType.Varchar2).Value = 0
        cmd.Parameters.Add("@usuario_rp", OracleDbType.Varchar2).Value = REPORTE_TRABAJOBE.USUARIO_RP
        cmd.Parameters.Add("@usuario_vb", OracleDbType.Varchar2).Value = REPORTE_TRABAJOBE.USUARIO_VB
        cmd.Parameters.Add("@usuario_vbplanta", OracleDbType.Varchar2).Value = 0
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DETTRABAJO_INSERT"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            REPORTE_DETTRABAJOBE.T_DOC_REF = Trim(REPORTE_TRABAJOBE.T_DOC_REF)
            REPORTE_DETTRABAJOBE.SER_DOC_REF = Trim(REPORTE_TRABAJOBE.SER_DOC_REF)
            REPORTE_DETTRABAJOBE.NRO_DOC_REF = Trim(REPORTE_TRABAJOBE.NRO_DOC_REF)
            REPORTE_DETTRABAJOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("t_doc_ref").Value)), "", RTrim(row.Cells("t_doc_ref").Value))
            REPORTE_DETTRABAJOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("ser_doc_ref").Value)), "", RTrim(row.Cells("ser_doc_ref").Value))
            REPORTE_DETTRABAJOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("nro_doc_ref").Value)), "", RTrim(row.Cells("nro_doc_ref").Value))
            REPORTE_DETTRABAJOBE.SEQ = cont ' IIf(IsDBNull(RTrim(row.Cells("Nro").Value)), "", RTrim(row.Cells("Nro").Value))
            REPORTE_DETTRABAJOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells("CCO_COD").Value)), "", RTrim(row.Cells("CCO_COD").Value))
            REPORTE_DETTRABAJOBE.LINEA = IIf(IsDBNull(RTrim(row.Cells("LINEA").Value)), "", RTrim(row.Cells("LINEA").Value))
            REPORTE_DETTRABAJOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            REPORTE_DETTRABAJOBE.DESC_TRA = IIf(IsDBNull(RTrim(row.Cells("DESC_TRA").Value)), "", RTrim(row.Cells("DESC_TRA").Value))

            REPORTE_DETTRABAJOBE.HORA_INICIO = IIf(IsDBNull(RTrim(row.Cells("HORA_INICIO").Value)), "", RTrim(row.Cells("HORA_INICIO").Value))
            REPORTE_DETTRABAJOBE.HORA_FINAL = IIf(IsDBNull(RTrim(row.Cells("HORA_FINAL").Value)), "", RTrim(row.Cells("HORA_FINAL").Value))

            REPORTE_DETTRABAJOBE.NUM_HORA = IIf(IsDBNull(RTrim(row.Cells("NUM_HORA").Value)), "", RTrim(row.Cells("NUM_HORA").Value))
            'REPORTE_DETTRABAJOBE.NUM_HORA_1 = IIf(IsDBNull(RTrim(row.Cells("NUM_HORA").Value)), "", RTrim(row.Cells("NUM_HORA").Value))

            REPORTE_DETTRABAJOBE.FEC_INICIO = IIf(IsDBNull(RTrim(row.Cells("FEC_INICIO").Value)), "", RTrim(row.Cells("FEC_INICIO").Value))
            REPORTE_DETTRABAJOBE.FEC_TERMINO = IIf(IsDBNull(RTrim(row.Cells("FEC_TERMINO").Value)), "", RTrim(row.Cells("FEC_TERMINO").Value))
            REPORTE_DETTRABAJOBE.TIP_COD = IIf(IsDBNull(RTrim(row.Cells("TIP_COD").Value)), "", RTrim(row.Cells("TIP_COD").Value))
            REPORTE_DETTRABAJOBE.FINALIZAR = IIf(IsDBNull(RTrim(row.Cells("FINALIZAR").Value)), "", RTrim(row.Cells("FINALIZAR").Value))
            REPORTE_DETTRABAJOBE.INTERVENCION = IIf(IsDBNull(RTrim(row.Cells("INTERVENCION").Value)), "", RTrim(row.Cells("INTERVENCION").Value))

            ''    REPORTE_DETTRABAJOBE.HORA_INI = IIf(IsDBNull(RTrim(row.Cells("HORA_INICIO").Value)), "", RTrim(row.Cells("HORA_INICIO").Value))
            ''    REPORTE_DETTRABAJOBE.HORA_FIN = IIf(IsDBNull(RTrim(row.Cells("HORA_FINAL").Value)), "", RTrim(row.Cells("HORA_FINAL").Value))

            'Los parametros que va recibir son las propiedades de la clase 0
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.NRO_DOC_REF1
            cmd.Parameters.Add("@SEQ", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.SEQ
            cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.CCO_COD
            cmd.Parameters.Add("@LINEA", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.LINEA
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.ART_COD
            cmd.Parameters.Add("@DESC_TRA", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.DESC_TRA

            cmd.Parameters.Add("@HORA_INICIO", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.HORA_INICIO
            'cmd.Parameters.Add("@HORA_INICIO", OracleDbType.Date).Value = REPORTE_DETTRABAJOBE.HORA_INI
            cmd.Parameters.Add("@HORA_FINAL", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.HORA_FINAL
            'cmd.Parameters.Add("@HORA_FINAL", OracleDbType.Date).Value = REPORTE_DETTRABAJOBE.HORA_FIN

            cmd.Parameters.Add("@NUM_HORA", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.NUM_HORA
            cmd.Parameters.Add("@FEC_INICIO", OracleDbType.Date).Value = REPORTE_DETTRABAJOBE.FEC_INICIO
            cmd.Parameters.Add("@FEC_TERMINO", OracleDbType.Date).Value = REPORTE_DETTRABAJOBE.FEC_TERMINO
            cmd.Parameters.Add("@TIP_COD", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.TIP_COD

            If REPORTE_DETTRABAJOBE.INTERVENCION = "-1" Then
                cmd.Parameters.Add("@INTERVENCION", OracleDbType.Varchar2).Value = ""
            Else
                cmd.Parameters.Add("@INTERVENCION", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.INTERVENCION
            End If
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            If REPORTE_DETTRABAJOBE.FINALIZAR = "1" Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELTBMANTENIMIENTO_PROGCER"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_DETTRABAJOBE.T_DOC_REF1)
                cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_DETTRABAJOBE.SER_DOC_REF1)
                cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_DETTRABAJOBE.NRO_DOC_REF1)
                cmd.Parameters.Add("pART_COD", OracleDbType.Varchar2).Value = "4"
                cmd.Parameters.Add("pFEC_GENE", OracleDbType.Date).Value = Date.Now
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
        Next
        ''     cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        ''     cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        ''     cmd.Connection = sqlCon
        ''     cmd.Transaction = sqlTrans
        ''     cmd.CommandType = CommandType.StoredProcedure
        ''     cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        ''     cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        ''     cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Reporte de Horas: " + ELTBMTIEMBE.T_DOC_REF + "-" + ELTBMTIEMBE.SER_DOC_REF + "-" + ELTBMTIEMBE.NRO_DOC_REF
        ''     cmd.ExecuteNonQuery()
        ''     cmd.Dispose()
    End Sub
    Private Sub UpdateRow(ByVal REPORTE_TRABAJOBE As REPORTE_TRABAJOBE, ByVal REPORTE_DETTRABAJOBE As REPORTE_DETTRABAJOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TRABAJO_UPDATE"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.NRO_DOC_REF)
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.EST)
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = REPORTE_TRABAJOBE.FEC_GENE
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.PER_COD)
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = REPORTE_TRABAJOBE.FEC_DIA
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = REPORTE_TRABAJOBE.CCO_COD
        cmd.Parameters.Add("@LINEA", OracleDbType.Varchar2).Value = REPORTE_TRABAJOBE.lINEA
        cmd.Parameters.Add("@turno", OracleDbType.Varchar2).Value = REPORTE_TRABAJOBE.TURNO
        cmd.Parameters.Add("@est1", OracleDbType.Varchar2).Value = 0
        cmd.Parameters.Add("@usuario_vb", OracleDbType.Varchar2).Value = REPORTE_TRABAJOBE.USUARIO_VB
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DETTRABAJO_DEL"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.NRO_DOC_REF)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DETTRABAJO_INSERT"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            REPORTE_DETTRABAJOBE.T_DOC_REF = Trim(REPORTE_TRABAJOBE.T_DOC_REF)
            REPORTE_DETTRABAJOBE.SER_DOC_REF = Trim(REPORTE_TRABAJOBE.SER_DOC_REF)
            REPORTE_DETTRABAJOBE.NRO_DOC_REF = Trim(REPORTE_TRABAJOBE.NRO_DOC_REF)
            REPORTE_DETTRABAJOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("t_doc_ref").Value)), "", RTrim(row.Cells("t_doc_ref").Value))
            REPORTE_DETTRABAJOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("ser_doc_ref").Value)), "", RTrim(row.Cells("ser_doc_ref").Value))
            REPORTE_DETTRABAJOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("nro_doc_ref").Value)), "", RTrim(row.Cells("nro_doc_ref").Value))
            REPORTE_DETTRABAJOBE.SEQ = cont ' IIf(IsDBNull(RTrim(row.Cells("Nro").Value)), "", RTrim(row.Cells("Nro").Value))
            REPORTE_DETTRABAJOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells("CCO_COD").Value)), "", RTrim(row.Cells("CCO_COD").Value))
            REPORTE_DETTRABAJOBE.LINEA = IIf(IsDBNull(RTrim(row.Cells("LINEA").Value)), "", RTrim(row.Cells("LINEA").Value))
            REPORTE_DETTRABAJOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            REPORTE_DETTRABAJOBE.DESC_TRA = IIf(IsDBNull(RTrim(row.Cells("DESC_TRA").Value)), "", RTrim(row.Cells("DESC_TRA").Value))
            REPORTE_DETTRABAJOBE.HORA_INICIO = IIf(IsDBNull(RTrim(row.Cells("HORA_INICIO").Value)), "", RTrim(row.Cells("HORA_INICIO").Value))
            REPORTE_DETTRABAJOBE.HORA_FINAL = IIf(IsDBNull(RTrim(row.Cells("HORA_FINAL").Value)), "", RTrim(row.Cells("HORA_FINAL").Value))
            REPORTE_DETTRABAJOBE.NUM_HORA = IIf(IsDBNull(RTrim(row.Cells("NUM_HORA").Value)), "", RTrim(row.Cells("NUM_HORA").Value))
            REPORTE_DETTRABAJOBE.FEC_INICIO = IIf(IsDBNull(RTrim(row.Cells("FEC_INICIO").Value)), "", RTrim(row.Cells("FEC_INICIO").Value))
            REPORTE_DETTRABAJOBE.FEC_TERMINO = IIf(IsDBNull(RTrim(row.Cells("FEC_TERMINO").Value)), "", RTrim(row.Cells("FEC_TERMINO").Value))
            REPORTE_DETTRABAJOBE.TIP_COD = IIf(IsDBNull(RTrim(row.Cells("TIP_COD").Value)), "", RTrim(row.Cells("TIP_COD").Value))
            REPORTE_DETTRABAJOBE.FINALIZAR = IIf(IsDBNull(RTrim(row.Cells("FINALIZAR").Value)), "", RTrim(row.Cells("FINALIZAR").Value))
            REPORTE_DETTRABAJOBE.INTERVENCION = IIf(IsDBNull(RTrim(row.Cells("INTERVENCION").Value)), "", RTrim(row.Cells("INTERVENCION").Value))
            'Los parametros que va recibir son las propiedades de la clase 0
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.NRO_DOC_REF1
            cmd.Parameters.Add("@SEQ", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.SEQ
            cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.CCO_COD
            cmd.Parameters.Add("@LINEA", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.LINEA
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.ART_COD
            cmd.Parameters.Add("@DESC_TRA", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.DESC_TRA
            cmd.Parameters.Add("@HORA_INICIO", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.HORA_INICIO
            cmd.Parameters.Add("@HORA_FINAL", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.HORA_FINAL
            cmd.Parameters.Add("@NUM_HORA", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.NUM_HORA
            cmd.Parameters.Add("@FEC_INICIO", OracleDbType.Date).Value = REPORTE_DETTRABAJOBE.FEC_INICIO
            cmd.Parameters.Add("@FEC_TERMINO", OracleDbType.Date).Value = REPORTE_DETTRABAJOBE.FEC_TERMINO
            cmd.Parameters.Add("@TIP_COD", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.TIP_COD

            If REPORTE_DETTRABAJOBE.INTERVENCION = "-1" Then
                cmd.Parameters.Add("@INTERVENCION", OracleDbType.Varchar2).Value = Nothing
            Else
                cmd.Parameters.Add("@INTERVENCION", OracleDbType.Varchar2).Value = REPORTE_DETTRABAJOBE.INTERVENCION
            End If
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            If REPORTE_DETTRABAJOBE.FINALIZAR = "1" Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELTBMANTENIMIENTO_PROGCER"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_DETTRABAJOBE.T_DOC_REF1)
                cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_DETTRABAJOBE.SER_DOC_REF1)
                cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_DETTRABAJOBE.NRO_DOC_REF1)
                cmd.Parameters.Add("pART_COD", OracleDbType.Varchar2).Value = "4"
                cmd.Parameters.Add("pFEC_GENE", OracleDbType.Date).Value = Date.Now
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
        Next


        '  '    ''     cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        '  '    ''     cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        '  '    ''     cmd.Connection = sqlCon
        '  '    ''     cmd.Transaction = sqlTrans
        '  '    ''     cmd.CommandType = CommandType.StoredProcedure
        '  '    ''     cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        '  '    ''     cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        '  '    ''     cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Reporte de Horas: " + ELTBMTIEMBE.T_DOC_REF + "-" + ELTBMTIEMBE.SER_DOC_REF + "-" + ELTBMTIEMBE.NRO_DOC_REF
        '  '    ''     cmd.ExecuteNonQuery()
        '  '    ''     cmd.Dispose()
    End Sub
    Private Sub AnularRow(ByVal REPORTE_TRABAJOBE As REPORTE_TRABAJOBE, ByVal REPORTE_DETTRABAJOBE As REPORTE_DETTRABAJOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TRABAJO_UPDANU"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.NRO_DOC_REF)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        ''cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        ''cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        ''cmd.Connection = sqlCon
        ''cmd.Transaction = sqlTrans
        ''cmd.CommandType = CommandType.StoredProcedure
        ''cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "2"
        ''cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        ''cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Anulo el Reporte de Horas: " + ELTBDETSTIEMBE.T_DOC_REF + "-" + ELTBDETSTIEMBE.SER_DOC_REF + "-" + ELTBDETSTIEMBE.NRO_DOC_REF
        ''cmd.ExecuteNonQuery()
        ''cmd.Dispose()
    End Sub
    Private Sub UpdateRowApro(ByVal REPORTE_TRABAJOBE As REPORTE_TRABAJOBE, ByVal REPORTE_DETTRABAJOBE As REPORTE_DETTRABAJOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBHORAMANT_UPDATEAPRO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.NRO_DOC_REF)
        'cmd.Parameters.Add("pusuario_vb", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.USUARIO_VB)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        '   cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        '   cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        '   cmd.Connection = sqlCon
        '   cmd.Transaction = sqlTrans
        '   cmd.CommandType = CommandType.StoredProcedure
        '   cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        '   cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        '   cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Aprobo el Reporte de Produccion: " + REPORTE_TRABAJOBE.T_DOC_REF + "-" + REPORTE_TRABAJOBE.SER_DOC_REF + "-" + REPORTE_TRABAJOBE.NRO_DOC_REF
        '   cmd.ExecuteNonQuery()
        '   cmd.Dispose()
    End Sub
    Private Sub UpdateRowDpro(ByVal REPORTE_TRABAJOBE As REPORTE_TRABAJOBE, ByVal REPORTE_DETTRABAJOBE As REPORTE_DETTRABAJOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBHORAMANT_UPDATEAPRO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.NRO_DOC_REF)
        'cmd.Parameters.Add("pusuario_vb", OracleDbType.Varchar2).Value = Trim(REPORTE_TRABAJOBE.USUARIO_VB)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        '   cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        '   cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        '   cmd.Connection = sqlCon
        '   cmd.Transaction = sqlTrans
        '   cmd.CommandType = CommandType.StoredProcedure
        '   cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        '   cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        '   cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Aprobo el Reporte de Produccion: " + REPORTE_TRABAJOBE.T_DOC_REF + "-" + REPORTE_TRABAJOBE.SER_DOC_REF + "-" + REPORTE_TRABAJOBE.NRO_DOC_REF
        '   cmd.ExecuteNonQuery()
        '   cmd.Dispose()
    End Sub
End Class
