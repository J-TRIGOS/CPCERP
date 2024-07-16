Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBMANTENIMIENTODAL
    Inherits BaseDatosORACLE
    Public sNumero As String
    Public sPrueba As String = Nothing
    Public Function SelectAll(ByVal sFec As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBMANTENIMIENTO_SELALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pFEC_GENE", sFec)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAllTo(ByVal sFec As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBMANTENIMIENTO_SELALLTO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pFEC_GENE", sFec)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBMANTENIMIENTO_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectTecnico(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBOMTECNICOS_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectPLano(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBOMPLANOS_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function Selectarea() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBMANTENIMIENTO_SELTAR", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectNro(ByVal sCode As String, ByVal sSer As String) As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBMANTENIMIENTO_SELECTNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode)),
                                                                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sSer))})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero

    End Function
    Public Function SelectCenCos(ByVal sCOD_USER As String) As String
        sPrueba = Nothing
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBMANTENIMIENTO_CCO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pCuser", Trim(sCOD_USER))})
            While dr.Read
                sPrueba = dr.GetString(0)
            End While
        End Using
        Return sPrueba
    End Function
    Public Function SelectNom(ByVal sCart As String) As String
        sPrueba = Nothing
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELECTNOM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pCart", Trim(sCart))})
            While dr.Read
                sPrueba = dr.GetString(0)
            End While
        End Using
        Return sPrueba
    End Function
    Function gArea(ByVal tlinea As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBSOLMAT_AREA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@TLINEA", Trim(tlinea))})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function list(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBCONTSEG_PER", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Public Function SaveRow(ByVal ELTBMANTENIMIENTOBE As ELTBMANTENIMIENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String, ByVal dgt As DataGridView, ByVal dgp As DataGridView) As String
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
                InsertRow(ELTBMANTENIMIENTOBE, ELMVLOGSBE, cn, sqlTrans)
                'grabar acceso a los menues
            End If
            If flagAccion = "M" Then
                UpdateRow(ELTBMANTENIMIENTOBE, ELMVLOGSBE, cn, sqlTrans, dgt, dgp)
            End If
            If flagAccion = "A" Then
                UpdateRowA(ELTBMANTENIMIENTOBE, cn, sqlTrans)
            End If
            If flagAccion = "AO" Then
                UPDEST(ELTBMANTENIMIENTOBE, cn, sqlTrans)
            End If
            If flagAccion = "C" Then
                UpdateRowCerrar(ELTBMANTENIMIENTOBE, cn, sqlTrans)
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
            If resultado = "OK" Then
                If flagAccion <> "AC" And flagAccion <> "DE" Then
                    cn.Dispose()
                End If

            End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Private Sub InsertRow(ByVal ELTBMANTENIMIENTOBE As ELTBMANTENIMIENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBMANTENIMIENTO_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.NRO_DOC_REF)
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBMANTENIMIENTOBE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = "0"   'ELTBMANTENIMIENTOBE.EST
        cmd.Parameters.Add("@cco_codori", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.CCO_CODORI
        cmd.Parameters.Add("@areaori", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.AREAORI
        cmd.Parameters.Add("@cco_coddes", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.CCO_CODDES
        cmd.Parameters.Add("@areades", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.AREADES
        cmd.Parameters.Add("@cod_tarea", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.COD_TAREA
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.ART_COD
        cmd.Parameters.Add("@prioridad", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.PRIORIDAD
        cmd.Parameters.Add("@asunsol", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.ASUNSOL
        cmd.Parameters.Add("@descsol", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.DESCSOL
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.USUARIO
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        ' cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        ' cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        ' cmd.Connection = sqlCon
        ' cmd.Transaction = sqlTrans
        ' cmd.CommandType = CommandType.StoredProcedure
        ' cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        ' cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        ' cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Servicio de Mantenimiento: " + ELTBMANTENIMIENTOBE.T_DOC_REF + "-" + ELTBMANTENIMIENTOBE.SER_DOC_REF + "-" + ELTBMANTENIMIENTOBE.NRO_DOC_REF + "-" + ELTBMANTENIMIENTOBE.ART_COD.ToString 
        ' cmd.ExecuteNonQuery()
        ' cmd.Dispose()
    End Sub
    Private Sub UpdateRow(ByVal ELTBMANTENIMIENTOBE As ELTBMANTENIMIENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dgt As DataGridView, ByVal dgp As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBMANTENIMIENTO_UPDATE"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.NRO_DOC_REF)
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBMANTENIMIENTOBE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = "3"
        cmd.Parameters.Add("@cco_codori", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.CCO_CODORI
        cmd.Parameters.Add("@areaori", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.AREAORI
        cmd.Parameters.Add("@cco_coddes", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.CCO_CODDES
        cmd.Parameters.Add("@areades", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.AREADES
        cmd.Parameters.Add("@cod_tarea", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.COD_TAREA
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.ART_COD
        cmd.Parameters.Add("@prioridad", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.PRIORIDAD
        cmd.Parameters.Add("@asunsol", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.ASUNSOL
        cmd.Parameters.Add("@descsol", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.DESCSOL
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.USUARIO
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBOMTECNICOS_DEL"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.NRO_DOC_REF)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        For Each row As DataGridViewRow In dgt.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBOMTECNICOS_INSERT"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.T_DOC_REF)
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.SER_DOC_REF)
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.NRO_DOC_REF)
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBMANTENIMIENTOBE.FEC_GENET
            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("PER_COD").Value)), "", RTrim(row.Cells("PER_COD").Value))
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("est").Value)), "", RTrim(row.Cells("est").Value))

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBOMELTBOMPLANOS_DEL"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.NRO_DOC_REF)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        For Each row As DataGridViewRow In dgp.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBOMPLANOS_INSERT"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.T_DOC_REF)
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.SER_DOC_REF)
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.NRO_DOC_REF)
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBMANTENIMIENTOBE.FEC_GENET
            cmd.Parameters.Add("@cod_pla", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("cod_pla").Value)), "", RTrim(row.Cells("cod_pla").Value))
            cmd.Parameters.Add("@linea", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("linea").Value)), "", RTrim(row.Cells("linea").Value))
            cmd.Parameters.Add("@exten", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("formato").Value)), "", RTrim(row.Cells("formato").Value))

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Servicio de Mantenimiento: " + ELTBMANTENIMIENTOBE.T_DOC_REF + "-" + ELTBMANTENIMIENTOBE.SER_DOC_REF + "-" + ELTBMANTENIMIENTOBE.NRO_DOC_REF + "-" + ELTBMANTENIMIENTOBE.ART_COD.ToString
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub UPDEST(ByVal ELTBMANTENIMIENTOBE As ELTBMANTENIMIENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                      ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cont As Integer = 0
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBMANTENIMIENTO_UPDEST"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.NRO_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.SER_DOC_REF)
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.T_DOC_REF)
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.ART_COD)
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = 1
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRowCerrar(ByVal ELTBMANTENIMIENTOBE As ELTBMANTENIMIENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                      ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBMANTENIMIENTO_UPDEST"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.NRO_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.NRO_DOC_REF)
        cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.ART_COD)
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = 2
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub UpdateRowA(ByVal ELTBMANTENIMIENTOBE As ELTBMANTENIMIENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                  ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBMANTENIMIENTO_UPDEST"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.NRO_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.NRO_DOC_REF)
        cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = Trim(ELTBMANTENIMIENTOBE.ART_COD)
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = 1
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
End Class
