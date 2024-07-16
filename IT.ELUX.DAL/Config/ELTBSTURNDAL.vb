Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBSTURNDAL
    Inherits BaseDatosORACLE

    Public sSerie As String
    Public sNumero1 As String

    Public Function SelectSer(ByVal sAño As String, ByVal sMes As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBTURNO_SELECTSER ", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sAño)),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sMes))})
            While dr.Read
                sSerie = dr.GetString(0)
            End While
        End Using
        Return sSerie

    End Function

    Public Function SelectCCosto() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_CCOSTO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
        End
    End Function

    Function listcco_cod(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_LISTCCO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function listgrupo() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBGRUPO_SEARH", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SaveRow(ByVal ELTBSTURNBE As ELTBSTURNBE, ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction
        Try
            'N:Nuevo   M:Modificar   E:Eliminar
            If flagAccion = "N" Then
                InsertRow(ELTBSTURNBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "M" Then
                UpdateRow(ELTBSTURNBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "A" Then
                AnularRow(ELTBSTURNBE, cn, sqlTrans, dg)
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
    Private Sub InsertRow(ByVal ELTBSTURNBE As ELTBSTURNBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBTURNO_INSERT"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTURNBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTURNBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTURNBE.NRO_DOC_REF)
        cmd.Parameters.Add("@fec_ini", OracleDbType.Date).Value = ELTBSTURNBE.F_INI
        cmd.Parameters.Add("@fec_fin", OracleDbType.Date).Value = ELTBSTURNBE.F_FIN
        cmd.Parameters.Add("@tipo", OracleDbType.Varchar2).Value = ELTBSTURNBE.TIPO
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELTBSTURNBE.EST
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = ELTBSTURNBE.CCO_COD
        cmd.Parameters.Add("@sem_anho", OracleDbType.Varchar2).Value = ELTBSTURNBE.SEM_ANHO
        cmd.Parameters.Add("@f_gene", OracleDbType.Date).Value = ELTBSTURNBE.F_GENE
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = ELTBSTURNBE.USUARIO_RP
        cmd.Parameters.Add("@titulo", OracleDbType.Varchar2).Value = ELTBSTURNBE.TITULO
        cmd.Parameters.Add("@obseva", OracleDbType.Varchar2).Value = ELTBSTURNBE.OBSERVA

        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETTURNO_INSERT"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBSTURNBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells("Codigo").Value)), "", RTrim(row.Cells("Codigo").Value))
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBSTURNBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBSTURNBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBSTURNBE.NRO_DOC_REF
            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELTBSTURNBE.PER_COD
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBSTURNBE.USUARIO_RP
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Programa de Turno: " + ELTBSTURNBE.T_DOC_REF + "-" + ELTBSTURNBE.SER_DOC_REF + "-" + ELTBSTURNBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Public Function SelectRow(ByVal sNum As String, ByVal sFini As String, ByVal sTurn As String, ByVal sCcos As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBTURN_SELECTNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sNum)),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@pFEC_INI", Trim(sFini)),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@pTIPO", Trim(sTurn)),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@pCCO_COD", Trim(sCcos))})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectNroSem(ByVal sFec As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBTURN_NROSEM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec", sFec)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function
    Function SelectVeri(ByVal sVer As String, ByVal sNum As String, ByVal sSer As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        sNumero1 = Nothing
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBTURN_SELECTVER", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pCODIGO", Trim(sVer)),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sSer)),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sNum))})
            While dr.Read
                sNumero1 = dr.GetString(0)
            End While
        End Using
        Return sNumero1
    End Function
    Private Sub UpdateRow(ByVal ELTBSTURNBE As ELTBSTURNBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETTURNO_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = Trim(ELTBSTURNBE.T_DOC_REF)
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(ELTBSTURNBE.SER_DOC_REF)
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(ELTBSTURNBE.NRO_DOC_REF)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBTURNO_UPDATE"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTURNBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTURNBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTURNBE.NRO_DOC_REF)
        cmd.Parameters.Add("@fec_ini", OracleDbType.Date).Value = ELTBSTURNBE.F_INI
        cmd.Parameters.Add("@fec_fin", OracleDbType.Date).Value = ELTBSTURNBE.F_FIN
        cmd.Parameters.Add("@tipo", OracleDbType.Varchar2).Value = ELTBSTURNBE.TIPO
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELTBSTURNBE.EST
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = ELTBSTURNBE.CCO_COD
        cmd.Parameters.Add("@sem_anho", OracleDbType.Varchar2).Value = ELTBSTURNBE.SEM_ANHO
        cmd.Parameters.Add("@f_gene", OracleDbType.Date).Value = ELTBSTURNBE.F_GENE
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = ELTBSTURNBE.USUARIO_RP
        cmd.Parameters.Add("@titulo", OracleDbType.Varchar2).Value = ELTBSTURNBE.TITULO
        cmd.Parameters.Add("@obseva", OracleDbType.Varchar2).Value = ELTBSTURNBE.OBSERVA
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETTURNO_INSERT"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            ELTBSTURNBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells("Codigo").Value)), "", RTrim(row.Cells("Codigo").Value))

            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBSTURNBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBSTURNBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBSTURNBE.NRO_DOC_REF
            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELTBSTURNBE.PER_COD
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBSTURNBE.USUARIO_RP
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el Programa de Turno: " + ELTBSTURNBE.T_DOC_REF + "-" + ELTBSTURNBE.SER_DOC_REF + "-" + ELTBSTURNBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Function SearhDetTurn(ByVal sNro As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBTURNO_SEARH_DET", {New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO", sNro)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    'Function SearhDocuTurn(ByVal sCCO As String) As DataTable
    '    Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
    '    Dim dt As New DataTable
    '    Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBTURNO_SEARH", {New Oracle.ManagedDataAccess.Client.OracleParameter("@CCO", sCCO)})
    '        If dr.HasRows Then
    '            dt.Load(dr)
    '        End If
    '    End Using
    '    Return dt
    'End Function
    Function SearhDocuTurn(ByVal sTipo As String, ByVal sSer As String, ByVal sNro As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBTURNO_SEARH", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Tipo", sTipo),
                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@Ser", sSer),
                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@Nro", sNro)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAll(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBTURN_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRow(ByVal sSDoc As String, ByVal sNDoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBTURN_SELECTNRO1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", sSDoc),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", sNDoc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Private Sub AnularRow(ByVal ELTBSTURNBE As ELTBSTURNBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBTURN_UPDATEROW_ANU"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTURNBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTURNBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTURNBE.NRO_DOC_REF)
        cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = "A"
        cmd.ExecuteNonQuery()
        cmd.Dispose()


        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "5"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBSTURNBE.USUARIO_RP
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Anulo el Programa de turno: " + ELTBSTURNBE.T_DOC_REF + "-" + ELTBSTURNBE.SER_DOC_REF + "-" + ELTBSTURNBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
End Class
