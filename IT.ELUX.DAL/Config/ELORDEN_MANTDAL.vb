Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELORDEN_MANTDAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE

    Public Function SelectAll(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBMANT_SELALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
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
        Using dr As OracleDataReader = Me.GetDataReader("SP_ORDEN_MANT_LASTCOD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Public Function SelectLineaMantSelect(ByVal sTdoc As String, ByVal sSer As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDE_MANT_LPRO_SELECT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sTdoc", sTdoc),
                                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@sSer", sSer)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function list1(ByVal var As String) As DataTable

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ORDEN_MANT_SEARCH", {New Oracle.ManagedDataAccess.Client.OracleParameter("@var", Trim(var))})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRow(ByVal sTdoc As String, ByVal sSDoc As String, ByVal sNDoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDE_MANT_ASELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sTDoc", sTdoc),
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

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDE_MANT_SELECTROW_DET", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sTDoc", sTdoc),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@sSDoc", sSDoc),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@sNDoc", sNDoc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SaveRow(ByVal ELORDEN_MANTBE As ELORDEN_MANTBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String, ByVal dg As DataGridView, ByVal ELORDEN_DET_MANTBE As ELORDEN_DET_MANTBE) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction


        cn = ConnectionBegin()

        sqlTrans = cn.BeginTransaction

        Try
            'N:Nuevo   M:Modificar   E:Eliminar 

            If flagAccion = "N" Then
                InsertRow(ELORDEN_MANTBE, ELMVLOGSBE, cn, sqlTrans, dg, ELORDEN_DET_MANTBE)
            End If
            If flagAccion = "A" Then
                UpdateRowa(ELORDEN_MANTBE, ELMVLOGSBE, cn, sqlTrans, dg, ELORDEN_DET_MANTBE)
            End If
            If flagAccion = "M" Then
                UpdateRow(ELORDEN_MANTBE, ELMVLOGSBE, cn, sqlTrans, dg, ELORDEN_DET_MANTBE)
            End If
            ' If flagAccion = "C" Then
            '     UpdateRowCerrar(ELORDEN_PROGRAMBE, ELMVLOGSBE, cn, sqlTrans, dg, ELORDEN_DET_PROGRAMBE)
            ' End If
            '
            ' If flagAccion = "R" Then
            '     UpdateRowRetornar(ELORDEN_PROGRAMBE, ELMVLOGSBE, cn, sqlTrans, dg, ELORDEN_DET_PROGRAMBE)
            ' End If
            '
            ' If flagAccion = "E" Then
            '     'DeleteRow(ELORDEN_PROGRAMBE, cn, sqlTrans)
            ' End If

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
    Private Sub UpdateRowa(ByVal ELORDEN_MANTBE As ELORDEN_MANTBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView, ByVal ELORDEN_DET_MANTBE As ELORDEN_DET_MANTBE)
        Dim cont As Integer = 0

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ORDEN_MANT_UPD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.t_doc_ref
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.ser_doc_ref
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.nro_doc_ref
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = "A"
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'ELIMINAR DETALLE PROGRAMA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ORDEN_MANT_DEL_DETALLE"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.t_doc_ref
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.ser_doc_ref
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.nro_doc_ref
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBMANT_UPDEST"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELORDEN_DET_MANTBE.t_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELORDEN_DET_MANTBE.ser_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELORDEN_DET_MANTBE.nro_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELORDEN_DET_MANTBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))


            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.t_doc_ref1
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.ser_doc_ref1
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.nro_doc_ref1
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.ART_COD
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = "0" 'ELORDEN_DET_MANTBE.EST
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next


    End Sub
    Private Sub InsertRow(ByVal ELORDEN_MANTBE As ELORDEN_MANTBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                      ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView, ByVal ELORDEN_DET_MANTBE As ELORDEN_DET_MANTBE)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0
        Dim cont As Integer = 0
        Dim fechafin, fechafindos As Date
        fechafin = ELORDEN_MANTBE.fec_ini
        fechafindos = ELORDEN_MANTBE.fec_ini

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ORDEN_MANT_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.t_doc_ref
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.ser_doc_ref
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.nro_doc_ref
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.cco_cod
        cmd.Parameters.Add("@cod_area", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.cod_area
        cmd.Parameters.Add("@grup_trab", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.cod_grupo
        cmd.Parameters.Add("@turno", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.turno
        cmd.Parameters.Add("@fecha_gen", OracleDbType.Date).Value = ELORDEN_MANTBE.fec_gene
        cmd.Parameters.Add("@fecha_ini", OracleDbType.Date).Value = ELORDEN_MANTBE.fec_ini
        cmd.Parameters.Add("@fecha_fin", OracleDbType.Date).Value = ELORDEN_MANTBE.fec_fin
        cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.estado
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ORDEN_MANT_INSDET"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELORDEN_DET_MANTBE.T_DOC_REF = ELORDEN_MANTBE.t_doc_ref
            ELORDEN_DET_MANTBE.SER_DOC_REF = ELORDEN_MANTBE.ser_doc_ref
            ELORDEN_DET_MANTBE.NRO_DOC_REF = ELORDEN_MANTBE.nro_doc_ref
            ELORDEN_DET_MANTBE.t_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELORDEN_DET_MANTBE.ser_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELORDEN_DET_MANTBE.nro_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELORDEN_DET_MANTBE.SEQ = cont
            ELORDEN_DET_MANTBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells("FECHA").Value)), "", RTrim(row.Cells("FECHA").Value))
            If IIf(IsDBNull(RTrim(row.Cells("PRIORIDAD").Value)), "", RTrim(row.Cells("PRIORIDAD").Value)) = "NORMAL" Then
                ELORDEN_DET_MANTBE.prioridad = "0"
            ElseIf IIf(IsDBNull(RTrim(row.Cells("PRIORIDAD").Value)), "", RTrim(row.Cells("PRIORIDAD").Value)) = "URGENTE" Then
                ELORDEN_DET_MANTBE.prioridad = "1"
            End If
            ELORDEN_DET_MANTBE.asunto = IIf(IsDBNull(RTrim(row.Cells("ASUNTO").Value)), "", RTrim(row.Cells("ASUNTO").Value))
            ELORDEN_DET_MANTBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            If IIf(IsDBNull(RTrim(row.Cells("ESTADO").Value)), "", RTrim(row.Cells("ESTADO").Value)) = "PENDIENTE" Then
                ELORDEN_DET_MANTBE.EST = "0"
            ElseIf IIf(IsDBNull(RTrim(row.Cells("ESTADO").Value)), "", RTrim(row.Cells("ESTADO").Value)) = "ANULADO" Then
                ELORDEN_DET_MANTBE.EST = "1"
            ElseIf IIf(IsDBNull(RTrim(row.Cells("ESTADO").Value)), "", RTrim(row.Cells("ESTADO").Value)) = "CERRADO" Then
                ELORDEN_DET_MANTBE.EST = "2"
            ElseIf IIf(IsDBNull(RTrim(row.Cells("ESTADO").Value)), "", RTrim(row.Cells("ESTADO").Value)) = "EN CURSO" Then
                ELORDEN_DET_MANTBE.EST = "3"
            ElseIf IIf(IsDBNull(RTrim(row.Cells("ESTADO").Value)), "", RTrim(row.Cells("ESTADO").Value)) = "FINALIZADO" Then
                ELORDEN_DET_MANTBE.EST = "4"
            End If

            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.NRO_DOC_REF1
            cmd.Parameters.Add("@seq", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.SEQ
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELORDEN_DET_MANTBE.FEC_GENE
            cmd.Parameters.Add("@prioridad", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.prioridad
            cmd.Parameters.Add("@asunto", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.asunto
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.ART_COD
            cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.EST
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBMANT_UPDEST"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.t_doc_ref1
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.ser_doc_ref1
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.nro_doc_ref1
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.ART_COD
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = "3" 'ELORDEN_DET_MANTBE.EST
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next


        '       'AUDITORIA
        '       cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        '       cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        '       cmd.Connection = sqlCon
        '       cmd.Transaction = sqlTrans
        '       cmd.CommandType = CommandType.StoredProcedure
        '       cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        '       cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu  'cod usu
        '       cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo turno"
        '       cmd.ExecuteNonQuery()
        '       cmd.Dispose()
    End Sub
    Public Function SaveRow1(ByVal ELTBMANTENIMIENTOBE As ELTBMANTENIMIENTOBE, ByVal ELORDEN_MANTBE As ELORDEN_MANTBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String) As String
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
                UPDEST3(ELTBMANTENIMIENTOBE, ELORDEN_MANTBE, ELMVLOGSBE, cn, sqlTrans)
            End If
            'If flagAccion = "M1" Then
            '    UPDEST4(ELPRODUCCIONBE, ELMVLOGSBE, cn, sqlTrans)
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
            sqlTrans = Nothing
        End Try
        Return resultado
    End Function
    Private Sub UPDEST3(ByVal ELTBMANTENIMIENTOBE As ELTBMANTENIMIENTOBE, ByVal ELORDEN_MANTBE As ELORDEN_MANTBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                      ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBMANT_UPDEST"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.NRO_DOC_REF
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.ART_COD
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.EST
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'ELIMINAR DETALLE PROGRAMA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBMANT_DELDET"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.t_doc_ref
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.ser_doc_ref
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.nro_doc_ref
        cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.NRO_DOC_REF
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELTBMANTENIMIENTOBE.ART_COD

        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRow(ByVal ELORDEN_MANTBE As ELORDEN_MANTBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                      ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView, ByVal ELORDEN_DET_MANTBE As ELORDEN_DET_MANTBE)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ORDEN_MANT_UPDATE"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.t_doc_ref
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.ser_doc_ref
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.nro_doc_ref
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.cco_cod
        cmd.Parameters.Add("@cod_area", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.cod_area
        cmd.Parameters.Add("@grup_trab", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.cod_grupo
        cmd.Parameters.Add("@turno", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.turno
        cmd.Parameters.Add("@fecha_gen", OracleDbType.Date).Value = ELORDEN_MANTBE.fec_gene
        cmd.Parameters.Add("@fecha_ini", OracleDbType.Date).Value = ELORDEN_MANTBE.fec_ini
        cmd.Parameters.Add("@fecha_fin", OracleDbType.Date).Value = ELORDEN_MANTBE.fec_fin
        cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.estado
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'ELIMINAR DETALLE PROGRAMA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ORDEN_MANT_DEL_DETALLE"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.t_doc_ref
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.ser_doc_ref
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_MANTBE.nro_doc_ref
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        'ELIMINAR DETALLE PROGRAMA

        Dim cont As Integer = 0
        Dim fechafin, fechafindos As Date
        fechafin = ELORDEN_MANTBE.fec_ini
        fechafindos = ELORDEN_MANTBE.fec_ini
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ORDEN_MANT_INSDET"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELORDEN_DET_MANTBE.T_DOC_REF = ELORDEN_MANTBE.t_doc_ref
            ELORDEN_DET_MANTBE.SER_DOC_REF = ELORDEN_MANTBE.ser_doc_ref
            ELORDEN_DET_MANTBE.NRO_DOC_REF = ELORDEN_MANTBE.nro_doc_ref
            ELORDEN_DET_MANTBE.t_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELORDEN_DET_MANTBE.ser_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELORDEN_DET_MANTBE.nro_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELORDEN_DET_MANTBE.SEQ = cont
            ELORDEN_DET_MANTBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells("FECHA").Value)), "", RTrim(row.Cells("FECHA").Value))
            If IIf(IsDBNull(RTrim(row.Cells("PRIORIDAD").Value)), "", RTrim(row.Cells("PRIORIDAD").Value)) = "NORMAL" Then
                ELORDEN_DET_MANTBE.prioridad = "0"
            ElseIf IIf(IsDBNull(RTrim(row.Cells("PRIORIDAD").Value)), "", RTrim(row.Cells("PRIORIDAD").Value)) = "URGENTE" Then
                ELORDEN_DET_MANTBE.prioridad = "1"
            End If
            ELORDEN_DET_MANTBE.asunto = IIf(IsDBNull(RTrim(row.Cells("ASUNTO").Value)), "", RTrim(row.Cells("ASUNTO").Value))
            ELORDEN_DET_MANTBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            If IIf(IsDBNull(RTrim(row.Cells("ESTADO").Value)), "", RTrim(row.Cells("ESTADO").Value)) = "PENDIENTE" Then
                ELORDEN_DET_MANTBE.EST = "0"
            ElseIf IIf(IsDBNull(RTrim(row.Cells("ESTADO").Value)), "", RTrim(row.Cells("ESTADO").Value)) = "EN CURSO" Then
                ELORDEN_DET_MANTBE.EST = "1"
            ElseIf IIf(IsDBNull(RTrim(row.Cells("ESTADO").Value)), "", RTrim(row.Cells("ESTADO").Value)) = "ANULADO" Then
                ELORDEN_DET_MANTBE.EST = "2"
            ElseIf IIf(IsDBNull(RTrim(row.Cells("ESTADO").Value)), "", RTrim(row.Cells("ESTADO").Value)) = "CERRADO" Then
                ELORDEN_DET_MANTBE.EST = "3"
            End If

            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.t_doc_ref1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.ser_doc_ref1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.nro_doc_ref1
            cmd.Parameters.Add("@seq", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.SEQ
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELORDEN_DET_MANTBE.FEC_GENE
            cmd.Parameters.Add("@prioridad", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.prioridad
            cmd.Parameters.Add("@asunto", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.asunto
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.ART_COD
            cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.EST
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBMANT_UPDEST"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.t_doc_ref1
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.ser_doc_ref1
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.nro_doc_ref1
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.ART_COD
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = "3" 'ELORDEN_DET_MANTBE.EST
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            '  If ELORDEN_MANTBE.estado <> "3" Then
            '      cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            '      cmd.CommandText = "--- --- ---SP_ORDEN_PRODUCCION_UPDESTP"
            '      cmd.Connection = sqlCon
            '      cmd.Transaction = sqlTrans
            '      cmd.CommandType = CommandType.StoredProcedure
            '   cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.nro_doc_ref1
            '   cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.ART_COD
            '   cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.ser_doc_ref1
            '   cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = "I"
            '   cmd.ExecuteNonQuery()
            '      cmd.Dispose()
            '  Else
            '      cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            '      cmd.CommandText = "--- --- ---SP_ORDEN_PRODUCCION_UPDESTP1"
            '      cmd.Connection = sqlCon
            '      cmd.Transaction = sqlTrans
            '      cmd.CommandType = CommandType.StoredProcedure
            '   cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.nro_doc_ref1
            '   cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.ART_COD
            '   cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELORDEN_DET_MANTBE.ser_doc_ref1
            '   cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = "P"
            '   cmd.ExecuteNonQuery()
            '      cmd.Dispose()
            '  End If
        Next
    End Sub
End Class
