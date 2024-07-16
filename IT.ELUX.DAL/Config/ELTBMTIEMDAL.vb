Imports IT.ELUX.BE
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBMTIEMDAL
    Inherits BaseDatosORACLE

    Public Function LastCodigo(ByVal sCode As String, ByVal sSer As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBMTIEM_SELECTNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sCode", sCode),
                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@sSer", sSer)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function
    Public Function SelectAll(ByVal sFec As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        ''''
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBMTIEM_SELALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pFEC_GENE", sFec)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAllLines() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBMTIEM_SELECT", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectNom(ByVal sCode As String, ByVal sSer As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBMTIEM_SELNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode),
                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sSer)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Try
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function SelectNroOm(ByVal sSer As String, ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBMTIEM_SELECTROWOM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sSer", sSer),
                                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("sCod", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function


    Public Function SelectRows(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBMTIEM_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRow(ByVal sCOD As String, ByVal sSER As String, ByVal sNRO As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBMTIEM_SELECTROWS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", sCOD),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER", sSER),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO", sNRO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRowDet(ByVal sCOD As String, ByVal sSER As String, ByVal sNRO As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDETMTIEM_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", sCOD),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@SER", sSER),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO", sNRO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectActi() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBACTIMANT_ACTI", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SaveRow(ByVal ELTBMTIEMBE As ELTBMTIEMBE, ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        ' Dim correlativo As String

        'cn = _Conexion.Conexion
        cn = ConnectionBegin()
        ' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try
            'N:Nuevo   M:Modificar   E:Eliminar 
            If flagAccion = "N" Then
                InsertRow(ELTBMTIEMBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "M" Then
                UpdateRow(ELTBMTIEMBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "A" Then
                AnularRow(ELTBMTIEMBE, cn, sqlTrans, dg)
            End If
            '    If flagAccion = "MRH" Then
            '        UpdateRowRH(ELTBMTIEMBE, cn, sqlTrans, dg)
            '    End If
            '    If flagAccion = "MJF" Then
            '        UpdateRowJF(ELTBMTIEMBE, cn, sqlTrans, dg)
            '    End If
            '    If flagAccion = "HE" Then
            '        UpdEstHEJ(ELTBMTIEMBE, cn, sqlTrans, dg) 
            '    End If
            '    If flagAccion = "HEJP" Then
            '        UpdEstHEJP(ELTBMTIEMBE, cn, sqlTrans, dg) 
            '    End If
            '    If flagAccion = "HERH" Then
            '        UpdEstHERH(ELTBMTIEMBE, cn, sqlTrans, dg) 
            '    End If
            '    If flagAccion = "HEPROG" Then
            '        InsPrograma(ELTBMTIEMBE, cn, sqlTrans, dg)
            '    End If
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
            '    If flagAccion <> "HE" And flagAccion <> "HEJP" And flagAccion <> "HERH" And flagAccion <> "HEPROG" And
            '        flagAccion <> "MJF" And flagAccion <> "MRH" Then
            '        cn.Dispose()
            '    End If
            '
            'End If
            sqlTrans = Nothing
        End Try
        Return resultado
    End Function

    Private Sub InsertRow(ByVal ELTBMTIEMBE As ELTBMTIEMBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                           ByVal dg As DataGridView)
        Dim HO As Integer = 0
        Dim MI As Integer = 0
        Dim SE As Integer = 0

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBMTIEM_INSERT"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMTIEMBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMTIEMBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMTIEMBE.NRO_DOC_REF)
        cmd.Parameters.Add("@ser_om", OracleDbType.Varchar2).Value = ELTBMTIEMBE.SER_OM
        cmd.Parameters.Add("@nro_om", OracleDbType.Varchar2).Value = ELTBMTIEMBE.NRO_OM
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELTBMTIEMBE.PER_COD
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = ELTBMTIEMBE.CCO_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBMTIEMBE.FEC_GENE
        cmd.Parameters.Add("@usuario_rp", OracleDbType.Varchar2).Value = ELTBMTIEMBE.USUARIO_RP
        cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = ELTBMTIEMBE.OBSERVACION
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = ELTBMTIEMBE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELTBMTIEMBE.EST
        cmd.Parameters.Add("@linea", OracleDbType.Varchar2).Value = ELTBMTIEMBE.LINEA
        cmd.Parameters.Add("@observa_tec", OracleDbType.Varchar2).Value = ELTBMTIEMBE.OBSERVACION_TECNICO

        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETMTIEM_INSERT"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBMTIEMBE.T_DOC_REF = Trim(ELTBMTIEMBE.T_DOC_REF)
            ELTBMTIEMBE.SER_DOC_REF = Trim(ELTBMTIEMBE.SER_DOC_REF)
            ELTBMTIEMBE.NRO_DOC_REF = Trim(ELTBMTIEMBE.NRO_DOC_REF)
            ELTBMTIEMBE.T_DOC_REF1 = Trim(ELTBMTIEMBE.T_DOC_REF)
            ELTBMTIEMBE.SER_DOC_REF1 = Trim(ELTBMTIEMBE.SER_DOC_REF)
            ELTBMTIEMBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells("Codigo").Value)), "", RTrim(row.Cells("Codigo").Value))
            ELTBMTIEMBE.HORA_GENE = IIf(IsDBNull(RTrim(row.Cells("Hora_Inicio").Value)), "", RTrim(row.Cells("Hora_Inicio").Value))
            ELTBMTIEMBE.HORA_TERMINO = IIf(IsDBNull(RTrim(row.Cells("Hora_Final").Value)), "", RTrim(row.Cells("Hora_Final").Value))
            ELTBMTIEMBE.COD_REALIZAR = IIf(IsDBNull(RTrim(row.Cells("Cod_Realizar").Value)), "", RTrim(row.Cells("Cod_Realizar").Value))
            ELTBMTIEMBE.USUARIO_RP = IIf(IsDBNull(RTrim(row.Cells("USUARIO_RP").Value)), "", RTrim(row.Cells("USUARIO_RP").Value))
            ELTBMTIEMBE.FEC_INICIO = IIf(IsDBNull(RTrim(row.Cells("FEC_INICIO").Value)), "", RTrim(row.Cells("FEC_INICIO").Value))
            ELTBMTIEMBE.FEC_TERMINO = IIf(IsDBNull(RTrim(row.Cells("FEC_TERMINO").Value)), "", RTrim(row.Cells("FEC_TERMINO").Value))
            'HO = DateDiff(DateInterval.Hour, IIf(IsDBNull(RTrim(row.Cells("Hora_Inicio").Value)), "", RTrim(row.Cells("Hora_Inicio").Value)), IIf(IsDBNull(RTrim(row.Cells("Hora_Final").Value)), "", RTrim(row.Cells("Hora_Final").Value)))
            'MI = DateDiff(DateInterval.Minute, IIf(IsDBNull(RTrim(row.Cells("Hora_Inicio").Value)), "", RTrim(row.Cells("Hora_Inicio").Value)), IIf(IsDBNull(RTrim(row.Cells("Hora_Final").Value)), "", RTrim(row.Cells("Hora_Final").Value)))
            'SE = DateDiff(DateInterval.Second, IIf(IsDBNull(RTrim(row.Cells("Hora_Inicio").Value)), "", RTrim(row.Cells("Hora_Inicio").Value)), IIf(IsDBNull(RTrim(row.Cells("Hora_Final").Value)), "", RTrim(row.Cells("Hora_Final").Value)))
            'MI = MI Mod 60
            'SE = SE Mod 60
            'ELTBMTIEMBE.DIF_HORA = HO.ToString.PadLeft(2, "0") & ":" & MI.ToString.PadLeft(2, "0") & ":" & SE.ToString.PadLeft(2, "0")
            ELTBMTIEMBE.DIF_HORA = IIf(IsDBNull(RTrim(row.Cells("Num_Hora").Value)), "", RTrim(row.Cells("Num_Hora").Value))
            ELTBMTIEMBE.NUM = IIf(IsDBNull(RTrim(row.Cells("Dif_Hora").Value)), "", RTrim(row.Cells("Dif_Hora").Value))
            ELTBMTIEMBE.COD_LINEA = IIf(IsDBNull(RTrim(row.Cells("COD_LINEA").Value)), "", RTrim(row.Cells("COD_LINEA").Value))
            ELTBMTIEMBE.FEC_GENE = ELTBMTIEMBE.FEC_GENE
            ELTBMTIEMBE.EST = ELTBMTIEMBE.EST
            ELTBMTIEMBE.EST1 = "0"
            ELTBMTIEMBE.NRO_DOC_REF1 = ELTBMTIEMBE.NRO_DOC_REF & "-" & cont
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBMTIEMBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBMTIEMBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBMTIEMBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBMTIEMBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBMTIEMBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBMTIEMBE.NRO_DOC_REF1
            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELTBMTIEMBE.PER_COD
            cmd.Parameters.Add("@hora_gene", OracleDbType.Varchar2).Value = ELTBMTIEMBE.HORA_GENE
            cmd.Parameters.Add("@hora_termino", OracleDbType.Varchar2).Value = ELTBMTIEMBE.HORA_TERMINO
            cmd.Parameters.Add("@cod_realizar", OracleDbType.Varchar2).Value = ELTBMTIEMBE.COD_REALIZAR
            'cmd.Parameters.Add("@usuario_ob", OracleDbType.Varchar2).Value = ELTBMTIEMBE.USUARIO_OB
            cmd.Parameters.Add("@usuario_rp", OracleDbType.Varchar2).Value = ELTBMTIEMBE.USUARIO_RP
            'cmd.Parameters.Add("@usuario_vb", OracleDbType.Date).Value = ELTBMTIEMBE.USUARIO_VB
            cmd.Parameters.Add("@dif_hora", OracleDbType.Varchar2).Value = ELTBMTIEMBE.DIF_HORA
            cmd.Parameters.Add("@FEC_INICIO", OracleDbType.Date).Value = ELTBMTIEMBE.FEC_INICIO
            cmd.Parameters.Add("@FEC_TERMINO", OracleDbType.Date).Value = ELTBMTIEMBE.FEC_TERMINO
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBMTIEMBE.FEC_GENE
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELTBMTIEMBE.EST
            cmd.Parameters.Add("@est1", OracleDbType.Varchar2).Value = ELTBMTIEMBE.EST1
            cmd.Parameters.Add("@NUM", OracleDbType.Double).Value = ELTBMTIEMBE.NUM
            cmd.Parameters.Add("@cod_linea", OracleDbType.Varchar2).Value = ELTBMTIEMBE.COD_LINEA

            cmd.ExecuteNonQuery()
            cmd.Dispose()
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
    Private Sub UpdateRow(ByVal ELTBMTIEMBE As ELTBMTIEMBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                           ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBMTIEM_UPDATE"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMTIEMBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMTIEMBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMTIEMBE.NRO_DOC_REF)
        cmd.Parameters.Add("@ser_om", OracleDbType.Varchar2).Value = ELTBMTIEMBE.SER_OM
        cmd.Parameters.Add("@nro_om", OracleDbType.Varchar2).Value = ELTBMTIEMBE.NRO_OM
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELTBMTIEMBE.PER_COD
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = ELTBMTIEMBE.CCO_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBMTIEMBE.FEC_GENE
        cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = ELTBMTIEMBE.OBSERVACION
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELTBMTIEMBE.EST
        cmd.Parameters.Add("@linea", OracleDbType.Varchar2).Value = ELTBMTIEMBE.LINEA
        cmd.Parameters.Add("@observa_tec", OracleDbType.Varchar2).Value = ELTBMTIEMBE.OBSERVACION_TECNICO

        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETMTIEM_DEL"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBMTIEMBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBMTIEMBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBMTIEMBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETMTIEM_INSERT"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBMTIEMBE.T_DOC_REF = Trim(ELTBMTIEMBE.T_DOC_REF)
            ELTBMTIEMBE.SER_DOC_REF = Trim(ELTBMTIEMBE.SER_DOC_REF)
            ELTBMTIEMBE.NRO_DOC_REF = Trim(ELTBMTIEMBE.NRO_DOC_REF)
            ELTBMTIEMBE.T_DOC_REF1 = Trim(ELTBMTIEMBE.T_DOC_REF)
            ELTBMTIEMBE.SER_DOC_REF1 = Trim(ELTBMTIEMBE.SER_DOC_REF)
            ELTBMTIEMBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells("Codigo").Value)), "", RTrim(row.Cells("Codigo").Value))
            ELTBMTIEMBE.HORA_GENE = IIf(IsDBNull(RTrim(row.Cells("Hora_Inicio").Value)), "", RTrim(row.Cells("Hora_Inicio").Value))
            ELTBMTIEMBE.HORA_TERMINO = IIf(IsDBNull(RTrim(row.Cells("Hora_Final").Value)), "", RTrim(row.Cells("Hora_Final").Value))
            ELTBMTIEMBE.COD_REALIZAR = IIf(IsDBNull(RTrim(row.Cells("Cod_Realizar").Value)), "", RTrim(row.Cells("Cod_Realizar").Value))
            ELTBMTIEMBE.USUARIO_RP = IIf(IsDBNull(RTrim(row.Cells("USUARIO_RP").Value)), "", RTrim(row.Cells("USUARIO_RP").Value))
            ELTBMTIEMBE.FEC_INICIO = IIf(IsDBNull(RTrim(row.Cells("FEC_INICIO").Value)), "", RTrim(row.Cells("FEC_INICIO").Value))
            ELTBMTIEMBE.FEC_TERMINO = IIf(IsDBNull(RTrim(row.Cells("FEC_TERMINO").Value)), "", RTrim(row.Cells("FEC_TERMINO").Value))
            ELTBMTIEMBE.DIF_HORA = IIf(IsDBNull(RTrim(row.Cells("Num_Hora").Value)), "", RTrim(row.Cells("Num_Hora").Value))
            ELTBMTIEMBE.NUM = IIf(IsDBNull(RTrim(row.Cells("Dif_Hora").Value)), "", RTrim(row.Cells("Dif_Hora").Value))
            ELTBMTIEMBE.COD_LINEA = IIf(IsDBNull(RTrim(row.Cells("COD_LINEA").Value)), "", RTrim(row.Cells("COD_LINEA").Value))
            ELTBMTIEMBE.FEC_GENE = ELTBMTIEMBE.FEC_GENE
            ELTBMTIEMBE.EST = ELTBMTIEMBE.EST
            ELTBMTIEMBE.EST1 = "0"
            ELTBMTIEMBE.NRO_DOC_REF1 = ELTBMTIEMBE.NRO_DOC_REF & "-" & cont

            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBMTIEMBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBMTIEMBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBMTIEMBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBMTIEMBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBMTIEMBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBMTIEMBE.NRO_DOC_REF1
            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELTBMTIEMBE.PER_COD
            cmd.Parameters.Add("@hora_gene", OracleDbType.Varchar2).Value = ELTBMTIEMBE.HORA_GENE
            cmd.Parameters.Add("@hora_termino", OracleDbType.Varchar2).Value = ELTBMTIEMBE.HORA_TERMINO
            cmd.Parameters.Add("@cod_realizar", OracleDbType.Varchar2).Value = ELTBMTIEMBE.COD_REALIZAR
            cmd.Parameters.Add("@usuario_rp", OracleDbType.Varchar2).Value = ELTBMTIEMBE.USUARIO_RP
            cmd.Parameters.Add("@dif_hora", OracleDbType.Varchar2).Value = ELTBMTIEMBE.DIF_HORA
            cmd.Parameters.Add("@FEC_INICIO", OracleDbType.Date).Value = ELTBMTIEMBE.FEC_INICIO
            cmd.Parameters.Add("@FEC_TERMINO", OracleDbType.Date).Value = ELTBMTIEMBE.FEC_TERMINO
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBMTIEMBE.FEC_GENE
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELTBMTIEMBE.EST
            cmd.Parameters.Add("@est1", OracleDbType.Varchar2).Value = ELTBMTIEMBE.EST1
            cmd.Parameters.Add("@NUM", OracleDbType.Double).Value = ELTBMTIEMBE.NUM
            cmd.Parameters.Add("@cod_linea", OracleDbType.Varchar2).Value = ELTBMTIEMBE.COD_LINEA

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next


        ''      cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        ''      cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        ''      cmd.Connection = sqlCon
        ''      cmd.Transaction = sqlTrans
        ''      cmd.CommandType = CommandType.StoredProcedure
        ''      cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        ''      cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        ''      cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se modifico el Reporte de Horas: " + ELTBMTIEMBE.T_DOC_REF + "-" + ELTBMTIEMBE.SER_DOC_REF + "-" + ELTBMTIEMBE.NRO_DOC_REF
        ''      cmd.ExecuteNonQuery()
        ''      cmd.Dispose()
    End Sub
    Private Sub AnularRow(ByVal ELTBMTIEMBE As ELTBMTIEMBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim HO As Integer = 0
        Dim MI As Integer = 0
        Dim SE As Integer = 0

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBMTIEM_UPDANU"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMTIEMBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMTIEMBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMTIEMBE.NRO_DOC_REF)
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
End Class
