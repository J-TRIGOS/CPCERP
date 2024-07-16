Imports IT.ELUX.BE
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELFALLADOSDAL
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNomArt As String
    Private Sub InsertRow(ByVal ELFALLADOSBE As ELFALLADOSBE, ByVal DETALLE_DOCUMENTOBE As DETALLE_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                           ByVal scodcat As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBFALLPRO_INSERT"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELFALLADOSBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELFALLADOSBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELFALLADOSBE.NRO_DOC_REF)
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELFALLADOSBE.ART_COD
        cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = ELFALLADOSBE.LOTE
        cmd.Parameters.Add("@lote1", OracleDbType.Varchar2).Value = ELFALLADOSBE.LOTE1
        cmd.Parameters.Add("@lote2", OracleDbType.Varchar2).Value = ELFALLADOSBE.LOTE2
        cmd.Parameters.Add("@lote3", OracleDbType.Varchar2).Value = ELFALLADOSBE.LOTE3
        cmd.Parameters.Add("@lote4", OracleDbType.Varchar2).Value = ELFALLADOSBE.LOTE4
        cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = ELFALLADOSBE.UNIDAD
        cmd.Parameters.Add("@linea", OracleDbType.Varchar2).Value = ELFALLADOSBE.LINEA
        cmd.Parameters.Add("@nro_orden", OracleDbType.Varchar2).Value = ELFALLADOSBE.NRO_ORDEN
        cmd.Parameters.Add("@art_venta", OracleDbType.Varchar2).Value = ELFALLADOSBE.ART_VENTA
        cmd.Parameters.Add("@art_venta1", OracleDbType.Varchar2).Value = ELFALLADOSBE.ART_VENTA1
        cmd.Parameters.Add("@art_venta2", OracleDbType.Varchar2).Value = ELFALLADOSBE.ART_VENTA2
        cmd.Parameters.Add("@art_venta3", OracleDbType.Varchar2).Value = ELFALLADOSBE.ART_VENTA3
        cmd.Parameters.Add("@observa1", OracleDbType.Varchar2).Value = ELFALLADOSBE.OBSERVA1
        cmd.Parameters.Add("@observa2", OracleDbType.Varchar2).Value = ELFALLADOSBE.OBSERVA2
        cmd.Parameters.Add("@x_entrega", OracleDbType.Varchar2).Value = ELFALLADOSBE.X_ENTREGA
        cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = ELFALLADOSBE.CANTIDAD
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELFALLADOSBE.EST
        cmd.Parameters.Add("@est1", OracleDbType.Varchar2).Value = ELFALLADOSBE.EST1
        cmd.Parameters.Add("@est2", OracleDbType.Varchar2).Value = ELFALLADOSBE.EST2
        cmd.Parameters.Add("@usuario_rp", OracleDbType.Varchar2).Value = ELFALLADOSBE.USUARIO_RP
        cmd.Parameters.Add("@usuario_vp", OracleDbType.Varchar2).Value = ELFALLADOSBE.USUARIO_VB
        cmd.Parameters.Add("@usuario_ob", OracleDbType.Varchar2).Value = ELFALLADOSBE.USUARIO_OB
        cmd.Parameters.Add("@vp", OracleDbType.Varchar2).Value = ELFALLADOSBE.VB
        cmd.Parameters.Add("@ob", OracleDbType.Varchar2).Value = ELFALLADOSBE.OB
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELFALLADOSBE.FEC_GENE
        cmd.Parameters.Add("@fec_dia1", OracleDbType.Varchar2).Value = ELFALLADOSBE.FEC_DIA1
        cmd.Parameters.Add("@fec_termino", OracleDbType.Date).Value = ELFALLADOSBE.FEC_TERMINO
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = ELFALLADOSBE.FEC_ANU
        cmd.Parameters.Add("@turno", OracleDbType.Varchar2).Value = ELFALLADOSBE.TURNO
        cmd.Parameters.Add("@HORA_GENE", OracleDbType.Varchar2).Value = ELFALLADOSBE.HORA_GENE
        cmd.Parameters.Add("@HORA_TERMINO", OracleDbType.Varchar2).Value = ELFALLADOSBE.HORA_TERMINO
        cmd.Parameters.Add("@DIF_HORA", OracleDbType.Varchar2).Value = ELFALLADOSBE.DIF_HORA
        cmd.Parameters.Add("@UND_H", OracleDbType.Double).Value = ELFALLADOSBE.UND_H
        cmd.Parameters.Add("@NUM_DIF", OracleDbType.Double).Value = ELFALLADOSBE.NUM_DIF
        cmd.Parameters.Add("@nrodia", OracleDbType.Varchar2).Value = ELFALLADOSBE.nrodia
        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELFALLADOSBE.anho
        cmd.Parameters.Add("@OP", OracleDbType.Varchar2).Value = ELFALLADOSBE.op
        cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = ELFALLADOSBE.CCO_COD
        cmd.Parameters.Add("@SER_ORDEN", OracleDbType.Varchar2).Value = ELFALLADOSBE.SER_ORDEN
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Reporte de Produccion: " + ELFALLADOSBE.T_DOC_REF + "-" + ELFALLADOSBE.SER_DOC_REF + "-" + ELFALLADOSBE.NRO_DOC_REF + "-" + ELFALLADOSBE.ART_COD.ToString + "-" + ELFALLADOSBE.CANTIDAD.ToString
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRow(ByVal ELFALLADOSBE As ELFALLADOSBE, ByVal DETALLE_DOCUMENTOBE As DETALLE_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal scodcat As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBFALLPRO_UPDATE"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELFALLADOSBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELFALLADOSBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELFALLADOSBE.NRO_DOC_REF)
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELFALLADOSBE.ART_COD
        cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = ELFALLADOSBE.LOTE
        cmd.Parameters.Add("@lote1", OracleDbType.Varchar2).Value = ELFALLADOSBE.LOTE1
        cmd.Parameters.Add("@lote2", OracleDbType.Varchar2).Value = ELFALLADOSBE.LOTE2
        cmd.Parameters.Add("@lote3", OracleDbType.Varchar2).Value = ELFALLADOSBE.LOTE3
        cmd.Parameters.Add("@lote4", OracleDbType.Varchar2).Value = ELFALLADOSBE.LOTE4
        cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = ELFALLADOSBE.UNIDAD
        cmd.Parameters.Add("@linea", OracleDbType.Varchar2).Value = ELFALLADOSBE.LINEA
        cmd.Parameters.Add("@nro_orden", OracleDbType.Varchar2).Value = ELFALLADOSBE.NRO_ORDEN
        cmd.Parameters.Add("@art_venta", OracleDbType.Varchar2).Value = ELFALLADOSBE.ART_VENTA
        cmd.Parameters.Add("@art_venta1", OracleDbType.Varchar2).Value = ELFALLADOSBE.ART_VENTA1
        cmd.Parameters.Add("@art_venta2", OracleDbType.Varchar2).Value = ELFALLADOSBE.ART_VENTA2
        cmd.Parameters.Add("@art_venta3", OracleDbType.Varchar2).Value = ELFALLADOSBE.ART_VENTA3
        cmd.Parameters.Add("@observa2", OracleDbType.Varchar2).Value = ELFALLADOSBE.OBSERVA2
        cmd.Parameters.Add("@x_entrega", OracleDbType.Varchar2).Value = ELFALLADOSBE.X_ENTREGA
        cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = ELFALLADOSBE.CANTIDAD
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELFALLADOSBE.EST
        cmd.Parameters.Add("@est1", OracleDbType.Varchar2).Value = ELFALLADOSBE.EST1
        cmd.Parameters.Add("@est2", OracleDbType.Varchar2).Value = ELFALLADOSBE.EST2
        cmd.Parameters.Add("@usuario_rp", OracleDbType.Varchar2).Value = ELFALLADOSBE.USUARIO_RP
        cmd.Parameters.Add("@usuario_vp", OracleDbType.Varchar2).Value = ELFALLADOSBE.USUARIO_VB
        cmd.Parameters.Add("@vp", OracleDbType.Varchar2).Value = ELFALLADOSBE.VB
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELFALLADOSBE.FEC_GENE
        cmd.Parameters.Add("@fec_dia1", OracleDbType.Varchar2).Value = ELFALLADOSBE.FEC_DIA1
        cmd.Parameters.Add("@fec_termino", OracleDbType.Date).Value = ELFALLADOSBE.FEC_TERMINO
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = ELFALLADOSBE.FEC_ANU
        cmd.Parameters.Add("@turno", OracleDbType.Varchar2).Value = ELFALLADOSBE.TURNO
        cmd.Parameters.Add("@HORA_GENE", OracleDbType.Varchar2).Value = ELFALLADOSBE.HORA_GENE
        cmd.Parameters.Add("@HORA_TERMINO", OracleDbType.Varchar2).Value = ELFALLADOSBE.HORA_TERMINO
        cmd.Parameters.Add("@DIF_HORA", OracleDbType.Varchar2).Value = ELFALLADOSBE.DIF_HORA
        cmd.Parameters.Add("@UND_H", OracleDbType.Double).Value = ELFALLADOSBE.UND_H
        cmd.Parameters.Add("@NUM_DIF", OracleDbType.Double).Value = ELFALLADOSBE.NUM_DIF
        cmd.Parameters.Add("@nrodia", OracleDbType.Varchar2).Value = ELFALLADOSBE.nrodia
        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELFALLADOSBE.anho
        cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = ELFALLADOSBE.CCO_COD
        cmd.Parameters.Add("@SER_ORDEN", OracleDbType.Varchar2).Value = ELFALLADOSBE.SER_ORDEN
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se modifico el Reporte de Produccion: " + ELFALLADOSBE.T_DOC_REF + "-" + ELFALLADOSBE.SER_DOC_REF + "-" + ELFALLADOSBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub UpdateRow1(ByVal ELFALLADOSBE As ELFALLADOSBE, ByVal DETALLE_DOCUMENTOBE As DETALLE_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal scodcat As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBFALLPRO_UPDATE1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELFALLADOSBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELFALLADOSBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELFALLADOSBE.NRO_DOC_REF)
        cmd.Parameters.Add("@observa1", OracleDbType.Varchar2).Value = ELFALLADOSBE.OBSERVA1
        cmd.Parameters.Add("@est1", OracleDbType.Varchar2).Value = ELFALLADOSBE.EST1
        cmd.Parameters.Add("@usuario_ob", OracleDbType.Varchar2).Value = ELFALLADOSBE.USUARIO_OB
        cmd.Parameters.Add("@ob", OracleDbType.Varchar2).Value = ELFALLADOSBE.OB

        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "6"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Observo el Reporte de Produccion: " + ELFALLADOSBE.T_DOC_REF + "-" + ELFALLADOSBE.SER_DOC_REF + "-" + ELFALLADOSBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    'Metodo para anular 
    Private Sub UpdateRowAnularGuia(ByVal ELFALLADOSBE As ELFALLADOSBE, ByVal DETALLE_DOCUMENTOBE As DETALLE_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                                    ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal scodcat As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBFALPRO_UPDATEROW_ANULAR"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(ELFALLADOSBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELFALLADOSBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELFALLADOSBE.NRO_DOC_REF)
        cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = "A"
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "5"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Anulo el Reporte de Produccion: " + ELFALLADOSBE.T_DOC_REF + "-" + ELFALLADOSBE.SER_DOC_REF + "-" + ELFALLADOSBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRowApro(ByVal ELFALLADOSBE As ELFALLADOSBE, ByVal DETALLE_DOCUMENTOBE As DETALLE_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                                    ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal scodcat As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBFALLPRO_UPDATEAPRO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(ELFALLADOSBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELFALLADOSBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELFALLADOSBE.NRO_DOC_REF)
        cmd.Parameters.Add("pusuario_vb", OracleDbType.Varchar2).Value = Trim(ELFALLADOSBE.USUARIO_VB)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Aprobo el Reporte de Produccion: " + ELFALLADOSBE.T_DOC_REF + "-" + ELFALLADOSBE.SER_DOC_REF + "-" + ELFALLADOSBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRowDpro(ByVal ELFALLADOSBE As ELFALLADOSBE, ByVal DETALLE_DOCUMENTOBE As DETALLE_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                                    ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal scodcat As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBFALLPRO_UPDATEDPRO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(ELFALLADOSBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELFALLADOSBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELFALLADOSBE.NRO_DOC_REF)
        cmd.Parameters.Add("pusuario_ob", OracleDbType.Varchar2).Value = Trim(ELFALLADOSBE.USUARIO_OB)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Observo el Reporte de Produccion: " + ELFALLADOSBE.T_DOC_REF + "-" + ELFALLADOSBE.SER_DOC_REF + "-" + ELFALLADOSBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Function SaveRow(ByVal ELFALLADOSBE As ELFALLADOSBE, ByVal DETALLE_DOCUMENTOBE As DETALLE_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String,
                             ByVal scodcat As String) As String
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
                InsertRow(ELFALLADOSBE, DETALLE_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, scodcat)
                'grabar acceso a los menues
            End If
            If flagAccion = "M" Then
                UpdateRow(ELFALLADOSBE, DETALLE_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, scodcat)
            End If
            If flagAccion = "M1" Then
                UpdateRow1(ELFALLADOSBE, DETALLE_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, scodcat)
            End If
            If flagAccion = "A" Then
                UpdateRowAnularGuia(ELFALLADOSBE, DETALLE_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, scodcat)
            End If
            If flagAccion = "AC" Then
                UpdateRowApro(ELFALLADOSBE, DETALLE_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, scodcat)
            End If

            If flagAccion = "DE" Then
                UpdateRowDpro(ELFALLADOSBE, DETALLE_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, scodcat)
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
    Public Function SelectActivos(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBFALLPRO_DOCU_PD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectActivos1(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBFALLPRO_DOCU_PD_3", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAll(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBFALLPRO_DOCU_PD_ALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAllAp(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBFALLPRO_DOCU_PD_A", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SelectRow", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRow1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBFALLPRO_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectNro(ByVal sCode As String, ByVal sSer As String) As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBFALLPRO_SELECTNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode)),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sSer))})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero
    End Function

    Public Function SelectNrodia(ByVal sCode As String, ByVal Mes As String, ByVal dia As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PRODUCCION_NRODIA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@opcion", sCode),
                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", Mes),
                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@dia", dia)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function
    Public Function SelectActivos1F(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBFALLPRO_DOCU_PD_3_F", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
