Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class REQUERIMIENTODAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE

    Public sNumero As String
    Public sNumero1 As Double
    'Metodo para registrar un nuevo 
    Private Sub InsertRow(ByVal REQUERIMIENTOBE As REQUERIMIENTOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                          ByVal scodcat As String)
        Dim contenedor As String
        Dim contenedor1 As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_INSERTROW_REQ"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.T_DOC_REF '1
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.SER_DOC_REF '2
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.NRO_DOC_REF '3
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.ART_COD '4
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = REQUERIMIENTOBE.FEC_GENE '5
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.EST '6
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.MONEDA '7
        cmd.Parameters.Add("@tprecio_compra", OracleDbType.Double).Value = REQUERIMIENTOBE.TPRECIO_COMPRA '8
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = REQUERIMIENTOBE.FEC_ANU '9
        cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.SIGNO '10
        cmd.Parameters.Add("@tprecio_dcompra", OracleDbType.Double).Value = REQUERIMIENTOBE.TPRECIO_DCOMPRA '11
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.USUARIO '12
        cmd.Parameters.Add("@observa", OracleDbType.Char).Value = REQUERIMIENTOBE.OBSERVA '13
        cmd.Parameters.Add("@t_movinv", OracleDbType.Char).Value = REQUERIMIENTOBE.T_MOVINV '14
        cmd.Parameters.Add("@t_igv", OracleDbType.Double).Value = REQUERIMIENTOBE.T_IGV '15
        cmd.Parameters.Add("@t_igv_dolar", OracleDbType.Double).Value = REQUERIMIENTOBE.T_IGV_DOLAR '16
        cmd.Parameters.Add("@t_dcto", OracleDbType.Double).Value = REQUERIMIENTOBE.T_DCTO '17
        cmd.Parameters.Add("@t_dcto_dolar", OracleDbType.Double).Value = REQUERIMIENTOBE.T_DCTO_DOLAR '18
        cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.F_PAGO_ENT '19
        cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.FOR_ENT_COD '20
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.CCO_COD '21
        cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = REQUERIMIENTOBE.PROVEEDOR '22
        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.CTCT_COD '23
        cmd.Parameters.Add("@dir_cod", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.DIR_COD '24
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.PER_COD '25
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = REQUERIMIENTOBE.FEC_DIA '26

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INS_OREQ"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            DET_DOCUMENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
            DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))
            DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(3).Value))
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(4).Value)), "", RTrim(row.Cells(4).Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(5).Value)), "", RTrim(row.Cells(5).Value))
            DET_DOCUMENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells(6).Value)), "", RTrim(row.Cells(6).Value))
            'DET_DOCUMENTOBE.FEC_ENT = IIf(IsDBNull(RTrim(row.Cells(10).Value)), "", RTrim(row.Cells(10).Value))
            'DET_DOCUMENTOBE.FEC_LLEG = IIf(IsDBNull(RTrim(row.Cells(12).Value)), "", RTrim(row.Cells(12).Value))
            DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells(7).Value)), "", RTrim(row.Cells(7).Value))
            DET_DOCUMENTOBE.EST = IIf(IsDBNull(RTrim(row.Cells(43).Value)), "", RTrim(row.Cells(43).Value))
            DET_DOCUMENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells(15).Value)), "", RTrim(row.Cells(15).Value))
            DET_DOCUMENTOBE.OBSERVA = IIf(IsDBNull(RTrim(row.Cells(16).Value)), "", RTrim(row.Cells(16).Value))
            DET_DOCUMENTOBE.T_MOVINV = IIf(IsDBNull(RTrim(row.Cells(17).Value)), "", RTrim(row.Cells(17).Value))
            DET_DOCUMENTOBE.TPRECIO_COMPRA = Val(IIf(IsDBNull(RTrim(row.Cells(18).Value)), "", RTrim(row.Cells(18).Value)))
            DET_DOCUMENTOBE.TPRECIO_DCOMPRA = Val(IIf(IsDBNull(RTrim(row.Cells(19).Value)), "", RTrim(row.Cells(19).Value)))
            DET_DOCUMENTOBE.IGV = Val(IIf(IsDBNull(RTrim(row.Cells(20).Value)), "", RTrim(row.Cells(20).Value)))
            DET_DOCUMENTOBE.IGV_IMPOR = Val(IIf(IsDBNull(RTrim(row.Cells(21).Value)), "", RTrim(row.Cells(21).Value)))
            DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells(8).Value)), "", RTrim(row.Cells(8).Value))
            DET_DOCUMENTOBE.T_CAMB = Val(IIf(IsDBNull(RTrim(row.Cells(22).Value)), "", RTrim(row.Cells(22).Value)))
            DET_DOCUMENTOBE.UPRECIO_COMPRA = Val(IIf(IsDBNull(RTrim(row.Cells(23).Value)), "", RTrim(row.Cells(23).Value)))
            DET_DOCUMENTOBE.UPRECIO_DCOMPRA = Val(IIf(IsDBNull(RTrim(row.Cells(24).Value)), "", RTrim(row.Cells(24).Value)))
            DET_DOCUMENTOBE.IGV_DIMPOR = Val(IIf(IsDBNull(RTrim(row.Cells(25).Value)), "", RTrim(row.Cells(25).Value)))
            DET_DOCUMENTOBE.MONEDA = IIf(IsDBNull(RTrim(row.Cells(26).Value)), "", RTrim(row.Cells(26).Value))
            DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells(29).Value)), "", RTrim(row.Cells(29).Value))
            DET_DOCUMENTOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells(27).Value)), "", RTrim(row.Cells(27).Value))
            DET_DOCUMENTOBE.F_PAGO_ENT = IIf(IsDBNull(RTrim(row.Cells(30).Value)), "", RTrim(row.Cells(30).Value))
            DET_DOCUMENTOBE.FOR_ENT_COD = IIf(IsDBNull(RTrim(row.Cells(31).Value)), "", RTrim(row.Cells(31).Value))
            DET_DOCUMENTOBE.FEC_DIA = IIf(IsDBNull(RTrim(row.Cells(32).Value)), "", RTrim(row.Cells(32).Value))
            DET_DOCUMENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells(33).Value)), "", RTrim(row.Cells(33).Value))
            DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells(34).Value)), "", RTrim(row.Cells(34).Value))
            DET_DOCUMENTOBE.LOTE = IIf(IsDBNull(RTrim(row.Cells(36).Value)), "", RTrim(row.Cells(36).Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells(11).Value)), "", RTrim(row.Cells(11).Value))
            DET_DOCUMENTOBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells(37).Value)), "", RTrim(row.Cells(37).Value))
            DET_DOCUMENTOBE.USUARIO = IIf(IsDBNull(RTrim(row.Cells(28).Value)), "", RTrim(row.Cells(28).Value))
            DET_DOCUMENTOBE.ART_VENTA = IIf(IsDBNull(RTrim(row.Cells("art_venta").Value)), "", RTrim(row.Cells("art_venta").Value))

            contenedor = IIf(IsDBNull(RTrim(row.Cells(10).Value)), REQUERIMIENTOBE.FEC_ANU, RTrim(row.Cells(10).Value))
            If contenedor.Length > 5 Then
                DET_DOCUMENTOBE.FEC_ENT = IIf(IsDBNull(RTrim(row.Cells(10).Value)), REQUERIMIENTOBE.FEC_ANU, RTrim(row.Cells(10).Value))
            End If
            contenedor1 = IIf(IsDBNull(RTrim(row.Cells(12).Value)), REQUERIMIENTOBE.FEC_ANU, RTrim(row.Cells(12).Value))
            If contenedor1.Length > 5 Then
                DET_DOCUMENTOBE.FEC_LLEG = IIf(IsDBNull(RTrim(row.Cells(12).Value)), REQUERIMIENTOBE.FEC_ANU, RTrim(row.Cells(12).Value))
            End If

            'If REQUERIMIENTOBE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 Then
            'DET_DOCUMENTOBE.NRO_DOC_REF1 = REQUERIMIENTOBE.NRO_DOC_REF 
            'End If
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Mid(DET_DOCUMENTOBE.NRO_DOC_REF1, 1, 7) & "-" & cont
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CTCT_COD
            cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
            cmd.Parameters.Add("@fec_lleg", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_LLEG
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.EST
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO
            cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
            cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_MOVINV)
            cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = DET_DOCUMENTOBE.TPRECIO_COMPRA
            cmd.Parameters.Add("@TPRECIO_DCOMPRA", OracleDbType.Double).Value = DET_DOCUMENTOBE.TPRECIO_DCOMPRA
            cmd.Parameters.Add("@IGV", OracleDbType.Double).Value = DET_DOCUMENTOBE.IGV
            cmd.Parameters.Add("@IGV_IMPOR", OracleDbType.Double).Value = DET_DOCUMENTOBE.IGV_IMPOR
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
            cmd.Parameters.Add("@T_CAMB", OracleDbType.Double).Value = DET_DOCUMENTOBE.T_CAMB
            cmd.Parameters.Add("@UPRECIO_COMPRA", OracleDbType.Double).Value = DET_DOCUMENTOBE.UPRECIO_COMPRA
            cmd.Parameters.Add("@UPRECIO_DCOMPRA", OracleDbType.Double).Value = DET_DOCUMENTOBE.UPRECIO_DCOMPRA
            cmd.Parameters.Add("@IGV_DIMPOR", OracleDbType.Double).Value = DET_DOCUMENTOBE.IGV_DIMPOR
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.MONEDA
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = REQUERIMIENTOBE.FEC_GENE
            cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT
            cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.FOR_ENT_COD
            cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_DIA
            cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = DET_DOCUMENTOBE.PROVEEDOR
            cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CCO_COD
            cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE
            cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ACT_COD
            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO
            cmd.Parameters.Add("@NRO_DOCU1", OracleDbType.Varchar2).Value = "0"
            cmd.Parameters.Add("@ART_VENTA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_VENTA
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            'Actualiza el estado del requerimiento a procesado
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_UPDATEPREQ"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@T_DOC_REF  ", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = Mid(DET_DOCUMENTOBE.NRO_DOC_REF1, 1, 7)
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + REQUERIMIENTOBE.T_DOC_REF + "-" + REQUERIMIENTOBE.SER_DOC_REF + "-" + REQUERIMIENTOBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    'Metodo para Modificar 
    Private Sub UpdateRow(ByVal REQUERIMIENTOBE As REQUERIMIENTOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                          ByVal scodcat As String)
        Dim contenedor As String
        Dim contenedor1 As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDATEROW_REQ"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = RTrim(REQUERIMIENTOBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = RTrim(REQUERIMIENTOBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = RTrim(REQUERIMIENTOBE.NRO_DOC_REF)
        cmd.Parameters.Add("part_cod", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.ART_COD
        cmd.Parameters.Add("pfec_gene", OracleDbType.Date).Value = REQUERIMIENTOBE.FEC_GENE
        cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.EST
        cmd.Parameters.Add("pmoneda", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.MONEDA
        cmd.Parameters.Add("ptprecio_compra", OracleDbType.Double).Value = REQUERIMIENTOBE.TPRECIO_COMPRA
        cmd.Parameters.Add("pfec_anu", OracleDbType.Date).Value = REQUERIMIENTOBE.FEC_ANU
        cmd.Parameters.Add("psigno", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.SIGNO
        cmd.Parameters.Add("ptprecio_dcompra", OracleDbType.Double).Value = REQUERIMIENTOBE.TPRECIO_DCOMPRA
        cmd.Parameters.Add("pusuario", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.USUARIO
        cmd.Parameters.Add("pobserva", OracleDbType.Char).Value = REQUERIMIENTOBE.OBSERVA
        cmd.Parameters.Add("pt_movinv", OracleDbType.Char).Value = REQUERIMIENTOBE.T_MOVINV
        cmd.Parameters.Add("pt_igv", OracleDbType.Double).Value = REQUERIMIENTOBE.T_IGV
        cmd.Parameters.Add("pt_igv_dolar", OracleDbType.Double).Value = REQUERIMIENTOBE.T_IGV_DOLAR
        cmd.Parameters.Add("pt_dcto", OracleDbType.Double).Value = REQUERIMIENTOBE.T_DCTO
        cmd.Parameters.Add("pt_dcto_dolar", OracleDbType.Double).Value = REQUERIMIENTOBE.T_DCTO_DOLAR
        cmd.Parameters.Add("pf_pago_ent", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.F_PAGO_ENT
        cmd.Parameters.Add("pfor_ent_cod", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.FOR_ENT_COD
        cmd.Parameters.Add("pcco_cod", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.CCO_COD
        cmd.Parameters.Add("pproveedor", OracleDbType.Char).Value = REQUERIMIENTOBE.PROVEEDOR
        cmd.Parameters.Add("pctct_cod", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.CTCT_COD
        cmd.Parameters.Add("pdir_cod", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.DIR_COD
        cmd.Parameters.Add("pper_cod", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.PER_COD
        cmd.Parameters.Add("pfec_dia", OracleDbType.Date).Value = REQUERIMIENTOBE.FEC_DIA
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCUMENTO_DEL_ALM"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = Trim(REQUERIMIENTOBE.T_DOC_REF)
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(REQUERIMIENTOBE.SER_DOC_REF)
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(REQUERIMIENTOBE.NRO_DOC_REF)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INS_OREQ"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            DET_DOCUMENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
            DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))
            DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(3).Value))
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(4).Value)), "", RTrim(row.Cells(4).Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(5).Value)), "", RTrim(row.Cells(5).Value))
            DET_DOCUMENTOBE.CTCT_COD = REQUERIMIENTOBE.CTCT_COD 'IIf(IsDBNull(RTrim(row.Cells(6).Value)), "", RTrim(row.Cells(6).Value))
            'DET_DOCUMENTOBE.FEC_ENT = IIf(IsDBNull(RTrim(row.Cells(10).Value)), "", RTrim(row.Cells(10).Value))
            'DET_DOCUMENTOBE.FEC_LLEG = IIf(IsDBNull(RTrim(row.Cells(12).Value)), "", RTrim(row.Cells(12).Value))
            DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells(7).Value)), "", RTrim(row.Cells(7).Value))
            DET_DOCUMENTOBE.EST = IIf(IsDBNull(RTrim(row.Cells(43).Value)), "", RTrim(row.Cells(43).Value))
            DET_DOCUMENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells(15).Value)), "", RTrim(row.Cells(15).Value))
            DET_DOCUMENTOBE.OBSERVA = IIf(IsDBNull(RTrim(row.Cells(16).Value)), "", RTrim(row.Cells(16).Value))
            DET_DOCUMENTOBE.T_MOVINV = IIf(IsDBNull(RTrim(row.Cells(17).Value)), "", RTrim(row.Cells(17).Value))
            DET_DOCUMENTOBE.TPRECIO_COMPRA = Val(IIf(IsDBNull(RTrim(row.Cells(18).Value)), "", RTrim(row.Cells(18).Value)))
            DET_DOCUMENTOBE.TPRECIO_DCOMPRA = Val(IIf(IsDBNull(RTrim(row.Cells(19).Value)), "", RTrim(row.Cells(19).Value)))
            DET_DOCUMENTOBE.IGV = Val(IIf(IsDBNull(RTrim(row.Cells(20).Value)), "", RTrim(row.Cells(20).Value)))
            DET_DOCUMENTOBE.IGV_IMPOR = Val(IIf(IsDBNull(RTrim(row.Cells(21).Value)), "", RTrim(row.Cells(21).Value)))
            DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells(8).Value)), "", RTrim(row.Cells(8).Value))
            DET_DOCUMENTOBE.T_CAMB = Val(IIf(IsDBNull(RTrim(row.Cells(22).Value)), "", RTrim(row.Cells(22).Value)))
            DET_DOCUMENTOBE.UPRECIO_COMPRA = Val(IIf(IsDBNull(RTrim(row.Cells(23).Value)), "", RTrim(row.Cells(23).Value)))
            DET_DOCUMENTOBE.UPRECIO_DCOMPRA = Val(IIf(IsDBNull(RTrim(row.Cells(24).Value)), "", RTrim(row.Cells(24).Value)))
            DET_DOCUMENTOBE.IGV_DIMPOR = Val(IIf(IsDBNull(RTrim(row.Cells(25).Value)), "", RTrim(row.Cells(25).Value)))
            DET_DOCUMENTOBE.MONEDA = IIf(IsDBNull(RTrim(row.Cells(26).Value)), "", RTrim(row.Cells(26).Value))
            DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells(29).Value)), "", RTrim(row.Cells(29).Value))
            DET_DOCUMENTOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells(27).Value)), "", RTrim(row.Cells(27).Value))
            DET_DOCUMENTOBE.F_PAGO_ENT = REQUERIMIENTOBE.F_PAGO_ENT 'IIf(IsDBNull(RTrim(row.Cells(30).Value)), "", RTrim(row.Cells(30).Value))
            DET_DOCUMENTOBE.FOR_ENT_COD = IIf(IsDBNull(RTrim(row.Cells(31).Value)), "", RTrim(row.Cells(31).Value))
            DET_DOCUMENTOBE.FEC_DIA = RTrim(DateTime.Now)
            DET_DOCUMENTOBE.PROVEEDOR = REQUERIMIENTOBE.PROVEEDOR 'IIf(IsDBNull(RTrim(row.Cells(33).Value)), "", RTrim(row.Cells(33).Value))
            DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells(34).Value)), "", RTrim(row.Cells(34).Value))
            DET_DOCUMENTOBE.LOTE = IIf(IsDBNull(RTrim(row.Cells(36).Value)), "", RTrim(row.Cells(36).Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells(11).Value)), "", RTrim(row.Cells(11).Value))
            DET_DOCUMENTOBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells(37).Value)), "", RTrim(row.Cells(37).Value))
            DET_DOCUMENTOBE.USUARIO = IIf(IsDBNull(RTrim(row.Cells(28).Value)), "", RTrim(row.Cells(28).Value))
            DET_DOCUMENTOBE.ART_VENTA = IIf(IsDBNull(RTrim(row.Cells("art_venta").Value)), "", RTrim(row.Cells("art_venta").Value))

            contenedor = IIf(IsDBNull(RTrim(row.Cells(10).Value)), REQUERIMIENTOBE.FEC_ANU, RTrim(row.Cells(10).Value))
            If contenedor.Length > 5 Then
                DET_DOCUMENTOBE.FEC_ENT = IIf(IsDBNull(RTrim(row.Cells(10).Value)), REQUERIMIENTOBE.FEC_ANU, RTrim(row.Cells(10).Value))
            End If
            contenedor1 = IIf(IsDBNull(RTrim(row.Cells(12).Value)), REQUERIMIENTOBE.FEC_ANU, RTrim(row.Cells(12).Value))
            If contenedor1.Length > 5 Then
                DET_DOCUMENTOBE.FEC_LLEG = IIf(IsDBNull(RTrim(row.Cells(12).Value)), REQUERIMIENTOBE.FEC_ANU, RTrim(row.Cells(12).Value))
            End If

            'If REQUERIMIENTOBE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 Then
            '    DET_DOCUMENTOBE.NRO_DOC_REF1 = REQUERIMIENTOBE.NRO_DOC_REF & "-" & cont
            'End If
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Mid(DET_DOCUMENTOBE.NRO_DOC_REF1, 1, 7) & "-" & cont
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.CTCT_COD
            cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
            cmd.Parameters.Add("@fec_lleg", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_LLEG
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.EST
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO
            cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
            cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_MOVINV)
            cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = DET_DOCUMENTOBE.TPRECIO_COMPRA
            cmd.Parameters.Add("@TPRECIO_DCOMPRA", OracleDbType.Double).Value = DET_DOCUMENTOBE.TPRECIO_DCOMPRA
            cmd.Parameters.Add("@IGV", OracleDbType.Double).Value = DET_DOCUMENTOBE.IGV
            cmd.Parameters.Add("@IGV_IMPOR", OracleDbType.Double).Value = DET_DOCUMENTOBE.IGV_IMPOR
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
            cmd.Parameters.Add("@T_CAMB", OracleDbType.Double).Value = DET_DOCUMENTOBE.T_CAMB
            cmd.Parameters.Add("@UPRECIO_COMPRA", OracleDbType.Double).Value = DET_DOCUMENTOBE.UPRECIO_COMPRA
            cmd.Parameters.Add("@UPRECIO_DCOMPRA", OracleDbType.Double).Value = DET_DOCUMENTOBE.UPRECIO_DCOMPRA
            cmd.Parameters.Add("@IGV_DIMPOR", OracleDbType.Double).Value = DET_DOCUMENTOBE.IGV_DIMPOR
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.MONEDA
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = REQUERIMIENTOBE.FEC_GENE
            cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT
            cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.FOR_ENT_COD
            cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_DIA
            cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = DET_DOCUMENTOBE.PROVEEDOR
            cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CCO_COD
            cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE
            cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ACT_COD
            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO
            cmd.Parameters.Add("@NRO_DOCU1", OracleDbType.Varchar2).Value = "0"
            cmd.Parameters.Add("@ART_VENTA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_VENTA

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            If REQUERIMIENTOBE.EST = "A" Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_DET_DOCUMENTO_UPDREQAPR"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
                cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
                cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Mid(DET_DOCUMENTOBE.NRO_DOC_REF1, 1, 7)
                cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
            End If
        Next
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Actualizo el Documento: " + REQUERIMIENTOBE.T_DOC_REF + "-" + REQUERIMIENTOBE.SER_DOC_REF + "-" + REQUERIMIENTOBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub UpdateRowApro(ByVal REQUERIMIENTOBE As REQUERIMIENTOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                              ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                              ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                              ByVal scodcat As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCUMENTO_UPDATEAPRO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.T_DOC_REF
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.SER_DOC_REF
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.NRO_DOC_REF
        'cmd.Parameters.Add("pt_doc_ref1", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.ART_COD
        'cmd.Parameters.Add("pser_doc_ref1", OracleDbType.Date).Value = REQUERIMIENTOBE.FEC_GENE
        'cmd.Parameters.Add("pnro_doc_ref1", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.EST
        cmd.Parameters.Add("part_cod", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.ART_COD

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Aprobo el Documento: " + REQUERIMIENTOBE.T_DOC_REF + "-" + REQUERIMIENTOBE.SER_DOC_REF + "-" + REQUERIMIENTOBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub UpdateRowDpro(ByVal REQUERIMIENTOBE As REQUERIMIENTOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                              ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                              ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                              ByVal scodcat As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCUMENTO_UPDATEDPRO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.T_DOC_REF
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.SER_DOC_REF
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.NRO_DOC_REF
        'cmd.Parameters.Add("pt_doc_ref1", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.ART_COD
        'cmd.Parameters.Add("pser_doc_ref1", OracleDbType.Date).Value = REQUERIMIENTOBE.FEC_GENE
        'cmd.Parameters.Add("pnro_doc_ref1", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.EST
        cmd.Parameters.Add("part_cod", OracleDbType.Varchar2).Value = REQUERIMIENTOBE.ART_COD

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Desaprobo el Documento: " + REQUERIMIENTOBE.T_DOC_REF + "-" + REQUERIMIENTOBE.SER_DOC_REF + "-" + REQUERIMIENTOBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub UpdActReqMant(ByVal REQUERIMIENTOBE As REQUERIMIENTOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                          ByVal scodcat As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCUMENTO_UPDDTREQ"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF
        cmd.Parameters.Add("part_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
        cmd.Parameters.Add("pfec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
        cmd.Parameters.Add("psolicitud", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE
        cmd.Parameters.Add("pentrega", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LICENCIA
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Actualizo elReq. de Documento: " + REQUERIMIENTOBE.T_DOC_REF + "-" + REQUERIMIENTOBE.SER_DOC_REF + "-" + REQUERIMIENTOBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    'Funcion Principal que hara toda la logica para grabar la data
    Public Function SaveRow(ByVal REQUERIMIENTOBE As REQUERIMIENTOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal flagAccion As String, ByVal dg As DataGridView, ByVal scodcat As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try
            'N:Nuevo   M:Modificar   E:Eliminar 

            If flagAccion = "N" Then
                ''correlativo = LastCodigo()
                ''MonedaBE.mon_codigo = MonedaBE.mon_codigo
                InsertRow(REQUERIMIENTOBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat)

                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                UpdateRow(REQUERIMIENTOBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat)
            End If

            If flagAccion = "A" Then
                UpdateRowApro(REQUERIMIENTOBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat)
            End If

            If flagAccion = "D" Then
                UpdateRowDpro(REQUERIMIENTOBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat)
            End If

            If flagAccion = "AR" Then
                UpdateRowApro(REQUERIMIENTOBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat)
            End If

            If flagAccion = "DR" Then
                UpdateRowDpro(REQUERIMIENTOBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat)
            End If

            If flagAccion = "RM" Then
                UpdActReqMant(REQUERIMIENTOBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat)
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

            End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function

    'Funcion que me va permitir capturar la lista de registros en la tabla y que me va retornar
    'un Datatable
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

    Public Function sReqAprob(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sArt_cod As String,
                              ByVal sT_doc1 As String, ByVal sS_doc1 As String, ByVal sN_doc1 As String, ByVal sProv As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_REQAPROB", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc),
                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF1", sT_doc1),
                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF1", sS_doc1),
                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF1", sN_doc1),
                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@ART_COD", sArt_cod),
                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@PROVEEDOR", sProv)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)

    End Function

    Public Function SelectT_DOC(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_T_DOC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectT_MOVINV(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_T_MOVINV", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pDOCMOV", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectT_MOVINV2(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_T_MOVINV3", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pDOCMOV", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectF_PAGO() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_F_PAGO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectF_ENT() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_F_ENT", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectMoneda() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_MON", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
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
    End Function

    Public Function SelectProv() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_PROV_OREQ", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectPer() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_PER", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectPerUsu() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_PER_USU", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectVend() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PER_VEND", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAct() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_ACTIVO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectNomColumn(ByVal sNom As String) As DataTable
        'sDim resultado As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBHEADERS_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pHDR_CAMPO", sNom)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectDir(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_DIR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@CTCT_COD", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAlmac(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_TMOVALM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@CTCT_COD", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DET_DOCUMENTO_SELECTROW_REQ", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getT_CAMB(ByVal fec As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_T_CMB", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec", fec)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getT_CAMB1(ByVal fec As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_T_CMB1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec", fec)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getCodArt(ByVal texto_a_buscar As String, ByVal op As Int16) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Select Case op
            Case 1
                Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SEARCH", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", texto_a_buscar)})
                    If dr.HasRows Then
                        dt.Load(dr)
                    End If
                End Using
            Case 2
                Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SEARCH", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", texto_a_buscar)})

                    If dr.HasRows Then
                        dt.Load(dr)
                    End If
                End Using

        End Select


        Return dt
    End Function

    Public Function SelectAll(ByVal sT_doc As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SELECTALL_OREQ", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectOreqReq(ByVal sT_doc As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_OREQ_REQ", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelectOreqReq1(ByVal sT_doc As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_OREQ_ALM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelectAllPendiente() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_PEN_REQ", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAllPendiente1(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_PENDIENTE", {New Oracle.ManagedDataAccess.Client.OracleParameter("@MANHO", anho),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@MMES", mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAllOP(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_LIST_VERIFICAR_OP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@MANHO", anho),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@MMES", mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAllReqA() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_REQ_PENDIENTE", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectNro(ByVal sCode As String, ByVal sSer As String) As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SELECTNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode)),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sSer))})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero

    End Function

    Public Function SelectNro1(ByVal sCode As String, ByVal sSer As String) As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELECTNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode)),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sSer))})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero

    End Function

    Public Function SelectNro2(ByVal sCode As String, ByVal sSer As String) As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELECTNRO3", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode)),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sSer))})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero

    End Function

    Public Function T_camb(ByVal sFec As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_T_CMB", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sFec))})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelectFamilia() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_FAMILIA", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectComAllFiltro(ByVal saño As String, ByVal smes As String, ByVal serie As String,
                                      ByVal nro As String, ByVal ruc As String, ByVal art As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SELALLOREQFILTRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ANHO", saño),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", smes),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SERIE", serie),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO", nro),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@RUC", ruc),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@art", art)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function aprobarOrdComp(ByVal estado As String, ByVal tipo As String, ByVal serie As String, ByVal nro As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try
            If estado = "A" Then
                updateOrdComp(estado, tipo, serie, nro, cn, sqlTrans)
            End If

            If estado = "D" Then
                updateOrdComp(estado, tipo, serie, nro, cn, sqlTrans)
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

    Public Function aprobarOrdProd(ByVal estado As String, ByVal tipo As String, ByVal serie As String, ByVal nro As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try
            If estado = "A" Then
                updateOrdProd(estado, tipo, serie, nro, cn, sqlTrans)
            End If

            If estado = "D" Then
                updateOrdProd(estado, tipo, serie, nro, cn, sqlTrans)
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

    Private Sub updateOrdComp(ByVal estado As String, ByVal tipo As String, ByVal serie As String, ByVal nro As String,
                              ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                              ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_APROBAR_ORDCOMP"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("MESTADO", OracleDbType.Varchar2).Value = estado
        cmd.Parameters.Add("MTIPO", OracleDbType.Varchar2).Value = tipo
        cmd.Parameters.Add("MSERIE", OracleDbType.Varchar2).Value = serie
        cmd.Parameters.Add("MNRO", OracleDbType.Varchar2).Value = nro
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Private Sub updateOrdProd(ByVal estado As String, ByVal tipo As String, ByVal serie As String, ByVal nro As String,
                              ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                              ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_APROBAR_ORDPROD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("MESTADO", OracleDbType.Varchar2).Value = estado
        cmd.Parameters.Add("MTIPO", OracleDbType.Varchar2).Value = tipo
        cmd.Parameters.Add("MSERIE", OracleDbType.Varchar2).Value = serie
        cmd.Parameters.Add("MNRO", OracleDbType.Varchar2).Value = nro
        cmd.ExecuteNonQuery()

        cmd.Dispose()
    End Sub
End Class
