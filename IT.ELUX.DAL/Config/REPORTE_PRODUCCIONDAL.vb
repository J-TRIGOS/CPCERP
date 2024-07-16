Imports IT.ELUX.BE
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class REPORTE_PRODUCCIONDAL
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNomArt As String
    Private Sub InsertRow(ByVal REPORTE_PRODUCCIONBE As REPORTE_PRODUCCIONBE, ByVal DETALLE_DOCUMENTOBE As DETALLE_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                           ByVal scodcat As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PRODUCCION_INSERT1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_PRODUCCIONBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_PRODUCCIONBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_PRODUCCIONBE.NRO_DOC_REF)
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.ART_COD
        cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.LOTE
        cmd.Parameters.Add("@lote1", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.LOTE1
        cmd.Parameters.Add("@lote2", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.LOTE2
        cmd.Parameters.Add("@lote3", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.LOTE3
        cmd.Parameters.Add("@lote4", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.LOTE4
        cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.UNIDAD
        cmd.Parameters.Add("@linea", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.LINEA
        cmd.Parameters.Add("@nro_orden", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.NRO_ORDEN
        cmd.Parameters.Add("@art_venta", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.ART_VENTA
        cmd.Parameters.Add("@art_venta1", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.ART_VENTA1
        cmd.Parameters.Add("@art_venta2", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.ART_VENTA2
        cmd.Parameters.Add("@art_venta3", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.ART_VENTA3
        cmd.Parameters.Add("@observa1", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.OBSERVA1
        cmd.Parameters.Add("@observa2", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.OBSERVA2
        cmd.Parameters.Add("@x_entrega", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.X_ENTREGA
        cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = REPORTE_PRODUCCIONBE.CANTIDAD
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.EST
        cmd.Parameters.Add("@est1", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.EST1
        cmd.Parameters.Add("@est2", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.EST2
        cmd.Parameters.Add("@usuario_rp", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.USUARIO_RP
        cmd.Parameters.Add("@usuario_vp", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.USUARIO_VB
        cmd.Parameters.Add("@usuario_ob", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.USUARIO_OB
        cmd.Parameters.Add("@vp", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.VB
        cmd.Parameters.Add("@ob", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.OB
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = REPORTE_PRODUCCIONBE.FEC_GENE
        cmd.Parameters.Add("@fec_dia1", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.FEC_DIA1
        cmd.Parameters.Add("@fec_termino", OracleDbType.Date).Value = REPORTE_PRODUCCIONBE.FEC_TERMINO
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = REPORTE_PRODUCCIONBE.FEC_ANU
        cmd.Parameters.Add("@turno", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.TURNO
        cmd.Parameters.Add("@HORA_GENE", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.HORA_GENE
        cmd.Parameters.Add("@HORA_TERMINO", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.HORA_TERMINO
        cmd.Parameters.Add("@DIF_HORA", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.DIF_HORA
        cmd.Parameters.Add("@UND_H", OracleDbType.Double).Value = REPORTE_PRODUCCIONBE.UND_H
        cmd.Parameters.Add("@NUM_DIF", OracleDbType.Double).Value = REPORTE_PRODUCCIONBE.NUM_DIF
        cmd.Parameters.Add("@nrodia", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.nrodia
        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.anho
        cmd.Parameters.Add("@OP", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.op
        cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.CCO_COD
        cmd.Parameters.Add("@SER_ORDEN", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.SER_ORDEN
        cmd.ExecuteNonQuery()
        cmd.Dispose()


        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Reporte de Produccion: " + REPORTE_PRODUCCIONBE.T_DOC_REF + "-" + REPORTE_PRODUCCIONBE.SER_DOC_REF + "-" + REPORTE_PRODUCCIONBE.NRO_DOC_REF + "-" + REPORTE_PRODUCCIONBE.ART_COD.ToString + "-" + REPORTE_PRODUCCIONBE.CANTIDAD.ToString
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UPDCNT(ByVal REPORTE_PRODUCCIONBE As REPORTE_PRODUCCIONBE, ByVal DETALLE_DOCUMENTOBE As DETALLE_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                           ByVal scodcat As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'If REPORTE_PRODUCCIONBE.SER_ORDEN <> "" Then
        'Actualizar cantidad en eltbproduccion
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBPRODUCCION_UPDCNT"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("NRO_ORDEN", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.NRO_ORDEN
            cmd.Parameters.Add("CANTIDAD", OracleDbType.Double).Value = REPORTE_PRODUCCIONBE.CANTIDAD
            cmd.Parameters.Add("SER_ORDEN", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.SER_ORDEN
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        'End If
    End Sub

    Private Sub UpdateRow(ByVal REPORTE_PRODUCCIONBE As REPORTE_PRODUCCIONBE, ByVal DETALLE_DOCUMENTOBE As DETALLE_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal scodcat As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PRODUCCION_UPDATE"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_PRODUCCIONBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_PRODUCCIONBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_PRODUCCIONBE.NRO_DOC_REF)
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.ART_COD
        cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.LOTE
        cmd.Parameters.Add("@lote1", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.LOTE1
        cmd.Parameters.Add("@lote2", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.LOTE2
        cmd.Parameters.Add("@lote3", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.LOTE3
        cmd.Parameters.Add("@lote4", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.LOTE4
        cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.UNIDAD
        cmd.Parameters.Add("@linea", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.LINEA
        cmd.Parameters.Add("@nro_orden", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.NRO_ORDEN
        cmd.Parameters.Add("@art_venta", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.ART_VENTA
        cmd.Parameters.Add("@art_venta1", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.ART_VENTA1
        cmd.Parameters.Add("@art_venta2", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.ART_VENTA2
        cmd.Parameters.Add("@art_venta3", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.ART_VENTA3
        cmd.Parameters.Add("@observa2", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.OBSERVA2
        cmd.Parameters.Add("@x_entrega", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.X_ENTREGA
        cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = REPORTE_PRODUCCIONBE.CANTIDAD
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.EST
        cmd.Parameters.Add("@est1", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.EST1
        cmd.Parameters.Add("@est2", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.EST2
        cmd.Parameters.Add("@usuario_rp", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.USUARIO_RP
        cmd.Parameters.Add("@usuario_vp", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.USUARIO_VB
        cmd.Parameters.Add("@vp", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.VB
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = REPORTE_PRODUCCIONBE.FEC_GENE
        cmd.Parameters.Add("@fec_dia1", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.FEC_DIA1
        cmd.Parameters.Add("@fec_termino", OracleDbType.Date).Value = REPORTE_PRODUCCIONBE.FEC_TERMINO
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = REPORTE_PRODUCCIONBE.FEC_ANU
        cmd.Parameters.Add("@turno", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.TURNO
        cmd.Parameters.Add("@HORA_GENE", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.HORA_GENE
        cmd.Parameters.Add("@HORA_TERMINO", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.HORA_TERMINO
        cmd.Parameters.Add("@DIF_HORA", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.DIF_HORA
        cmd.Parameters.Add("@UND_H", OracleDbType.Double).Value = REPORTE_PRODUCCIONBE.UND_H
        cmd.Parameters.Add("@NUM_DIF", OracleDbType.Double).Value = REPORTE_PRODUCCIONBE.NUM_DIF
        cmd.Parameters.Add("@nrodia", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.nrodia
        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.anho
        cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.CCO_COD
        cmd.Parameters.Add("@SER_ORDEN", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.SER_ORDEN
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se modifico el Reporte de Produccion: " + REPORTE_PRODUCCIONBE.T_DOC_REF + "-" + REPORTE_PRODUCCIONBE.SER_DOC_REF + "-" + REPORTE_PRODUCCIONBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UPDORDPROG(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal sTDOC As String, ByVal sSDOC As String, ByVal sNDOC As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBORDEN_DET_PROGRAMUPD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(sTDOC)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(sSDOC)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(sNDOC)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub UpdateRow1(ByVal REPORTE_PRODUCCIONBE As REPORTE_PRODUCCIONBE, ByVal DETALLE_DOCUMENTOBE As DETALLE_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal scodcat As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PRODUCCION_UPDATE1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_PRODUCCIONBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_PRODUCCIONBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_PRODUCCIONBE.NRO_DOC_REF)
        cmd.Parameters.Add("@observa1", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.OBSERVA1
        cmd.Parameters.Add("@est1", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.EST1
        cmd.Parameters.Add("@usuario_ob", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.USUARIO_OB
        cmd.Parameters.Add("@ob", OracleDbType.Varchar2).Value = REPORTE_PRODUCCIONBE.OB

        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "6"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Observo el Reporte de Produccion: " + REPORTE_PRODUCCIONBE.T_DOC_REF + "-" + REPORTE_PRODUCCIONBE.SER_DOC_REF + "-" + REPORTE_PRODUCCIONBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    'Metodo para anular 
    Private Sub UpdateRowAnularGuia(ByVal REPORTE_PRODUCCIONBE As REPORTE_PRODUCCIONBE, ByVal DETALLE_DOCUMENTOBE As DETALLE_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                                    ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal scodcat As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDATEROW_ANULAR"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_PRODUCCIONBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_PRODUCCIONBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_PRODUCCIONBE.NRO_DOC_REF)
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
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Anulo el Reporte de Produccion: " + REPORTE_PRODUCCIONBE.T_DOC_REF + "-" + REPORTE_PRODUCCIONBE.SER_DOC_REF + "-" + REPORTE_PRODUCCIONBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRowApro(ByVal REPORTE_PRODUCCIONBE As REPORTE_PRODUCCIONBE, ByVal DETALLE_DOCUMENTOBE As DETALLE_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                                    ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal scodcat As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PRODUCCION_UPDATEAPRO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_PRODUCCIONBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_PRODUCCIONBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_PRODUCCIONBE.NRO_DOC_REF)
        cmd.Parameters.Add("pusuario_vb", OracleDbType.Varchar2).Value = Trim(REPORTE_PRODUCCIONBE.USUARIO_VB)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Aprobo el Reporte de Produccion: " + REPORTE_PRODUCCIONBE.T_DOC_REF + "-" + REPORTE_PRODUCCIONBE.SER_DOC_REF + "-" + REPORTE_PRODUCCIONBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRowDpro(ByVal REPORTE_PRODUCCIONBE As REPORTE_PRODUCCIONBE, ByVal DETALLE_DOCUMENTOBE As DETALLE_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                                    ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal scodcat As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PRODUCCION_UPDATEDPRO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_PRODUCCIONBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_PRODUCCIONBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(REPORTE_PRODUCCIONBE.NRO_DOC_REF)
        cmd.Parameters.Add("pusuario_ob", OracleDbType.Varchar2).Value = Trim(REPORTE_PRODUCCIONBE.USUARIO_OB)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Observo el Reporte de Produccion: " + REPORTE_PRODUCCIONBE.T_DOC_REF + "-" + REPORTE_PRODUCCIONBE.SER_DOC_REF + "-" + REPORTE_PRODUCCIONBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Function SaveRow(ByVal REPORTE_PRODUCCIONBE As REPORTE_PRODUCCIONBE, ByVal DETALLE_DOCUMENTOBE As DETALLE_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String,
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
                InsertRow(REPORTE_PRODUCCIONBE, DETALLE_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, scodcat)
                'grabar acceso a los menues
            End If

            If flagAccion = "UPDCNT" Then
                UPDCNT(REPORTE_PRODUCCIONBE, DETALLE_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, scodcat)
                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                UpdateRow(REPORTE_PRODUCCIONBE, DETALLE_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, scodcat)
            End If
            If flagAccion = "M1" Then
                UpdateRow1(REPORTE_PRODUCCIONBE, DETALLE_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, scodcat)
            End If
            If flagAccion = "A" Then
                UpdateRowAnularGuia(REPORTE_PRODUCCIONBE, DETALLE_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, scodcat)
            End If

            If flagAccion = "AC" Then
                UpdateRowApro(REPORTE_PRODUCCIONBE, DETALLE_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, scodcat)
            End If

            If flagAccion = "DE" Then
                UpdateRowDpro(REPORTE_PRODUCCIONBE, DETALLE_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, scodcat)
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
            '    If flagAccion <> "AC" And flagAccion <> "DE" Then
            '        cn.Dispose()
            '    End If

            'End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function

    Public Function SaveRow1(ByVal sTDOC As String, ByVal sSDOC As String, ByVal sNDOC As String) As String
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
            UPDORDPROG(cn, sqlTrans, sTDOC, sSDOC, sNDOC)

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
            '    If flagAccion <> "AC" And flagAccion <> "DE" Then
            '        cn.Dispose()
            '    End If
            'End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Public Function SelectActivos(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DETALLE_DOCU_PD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
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

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DETALLE_DOCU_PD_3", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
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

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DETALLE_DOCU_PD_ALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
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

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DETALLE_DOCU_PD_A", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function


    Public Function SelectAllFal(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DETALLE_DOCU_PD_F", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAllRein(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DETALLE_DOCU_PD_R", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
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
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PRODUCCION_SelectRow", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
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
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PRODUCCION_SELECTNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode)),
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

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DETALLE_DOCU_PD_3_F", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectActivos1R(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DETALLE_DOCU_PD_3_R", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
