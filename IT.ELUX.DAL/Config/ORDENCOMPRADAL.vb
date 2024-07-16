﻿Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ORDENCOMPRADAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    Inherits BaseDatosORACLE
    Public sNumero As String
    Public sNumero1 As Double
    'Metodo para registrar un nuevo 
    Private Sub InsertRow(ByVal ORDENCOMPRABE As ORDENCOMPRABE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        'Dim contenedor As String
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_INSERTROW_OC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ORDENCOMPRABE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ORDENCOMPRABE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ORDENCOMPRABE.NRO_DOC_REF
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ORDENCOMPRABE.ART_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ORDENCOMPRABE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ORDENCOMPRABE.EST
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = ORDENCOMPRABE.MONEDA
        cmd.Parameters.Add("@tprecio_venta", OracleDbType.Double).Value = ORDENCOMPRABE.TPRECIO_VENTA
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = ORDENCOMPRABE.FEC_ANU
        cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = ORDENCOMPRABE.SIGNO
        cmd.Parameters.Add("@tprecio_dventa", OracleDbType.Double).Value = ORDENCOMPRABE.TPRECIO_DVENTA
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = ORDENCOMPRABE.USUARIO
        cmd.Parameters.Add("@observa", OracleDbType.Char).Value = ORDENCOMPRABE.OBSERVA
        cmd.Parameters.Add("@t_movinv", OracleDbType.Char).Value = ORDENCOMPRABE.T_MOVINV
        cmd.Parameters.Add("@t_igv", OracleDbType.Double).Value = ORDENCOMPRABE.T_IGV
        cmd.Parameters.Add("@t_igv_dolar", OracleDbType.Double).Value = ORDENCOMPRABE.T_IGV_DOLAR
        cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = ORDENCOMPRABE.F_PAGO_ENT
        cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = ORDENCOMPRABE.FOR_ENT_COD
        cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = ORDENCOMPRABE.PROVEEDOR
        cmd.Parameters.Add("@FEC_PROV", OracleDbType.Date).Value = ORDENCOMPRABE.FEC_PROV
        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = ORDENCOMPRABE.CTCT_COD
        cmd.Parameters.Add("@vendedor", OracleDbType.Varchar2).Value = ORDENCOMPRABE.VENDEDOR
        cmd.Parameters.Add("@dir_cod", OracleDbType.Varchar2).Value = ORDENCOMPRABE.DIR_COD
        cmd.Parameters.Add("@NUMPEDIDO", OracleDbType.Varchar2).Value = ORDENCOMPRABE.NUMPEDIDO
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = ORDENCOMPRABE.FEC_DIA
        cmd.Parameters.Add("@NOM_CTCT", OracleDbType.Varchar2).Value = ORDENCOMPRABE.NOM_CTCT
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INSOC"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            DET_DOCUMENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            DET_DOCUMENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells("CTCT_COD").Value)), "", RTrim(row.Cells("CTCT_COD").Value))
            DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            DET_DOCUMENTOBE.OBSERVA = IIf(IsDBNull(RTrim(row.Cells("OBSERVA").Value)), "", RTrim(row.Cells("OBSERVA").Value))
            DET_DOCUMENTOBE.T_MOVINV = IIf(IsDBNull(RTrim(row.Cells("T_MOVINV").Value)), "", RTrim(row.Cells("T_MOVINV").Value))
            DET_DOCUMENTOBE.IGV = IIf(IsDBNull(RTrim(row.Cells("IGV").Value)), "", RTrim(row.Cells("IGV").Value))
            DET_DOCUMENTOBE.T_CAMB = IIf(IsDBNull(RTrim(row.Cells("T_CAMB").Value)), "", RTrim(row.Cells("T_CAMB").Value))
            'DET_DOCUMENTOBE.TPRECIO_VENTA = (DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD) * (DET_DOCUMENTOBE.IGV / 100) + DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD
            'DET_DOCUMENTOBE.TPRECIO_DVENTA = ((DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD) * (DET_DOCUMENTOBE.IGV / 100) + DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD) / DET_DOCUMENTOBE.T_CAMB
            If ORDENCOMPRABE.MONEDA = "00" Then
                DET_DOCUMENTOBE.UPRECIO_VENTA = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_VENTA").Value)), 0, RTrim(row.Cells("UPRECIO_VENTA").Value)))
                DET_DOCUMENTOBE.UPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA / DET_DOCUMENTOBE.T_CAMB, 2)
                DET_DOCUMENTOBE.TPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD, 2)
                DET_DOCUMENTOBE.TPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD / DET_DOCUMENTOBE.T_CAMB, 2)
                If ORDENCOMPRABE.T_IGV > 0 Then
                    DET_DOCUMENTOBE.IGV_IMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_VENTA * 18) / 100, 2)
                    DET_DOCUMENTOBE.IGV_DIMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_DVENTA * 18) / 100, 2)
                Else
                    DET_DOCUMENTOBE.IGV_IMPOR = 0
                    DET_DOCUMENTOBE.IGV_DIMPOR = 0
                End If

            ElseIf ORDENCOMPRABE.MONEDA = "01" Then
                DET_DOCUMENTOBE.UPRECIO_DVENTA = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DVENTA").Value)), 0, RTrim(row.Cells("UPRECIO_DVENTA").Value)))
                DET_DOCUMENTOBE.UPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.T_CAMB, 2)
                DET_DOCUMENTOBE.TPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD, 2)
                DET_DOCUMENTOBE.TPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD * DET_DOCUMENTOBE.T_CAMB, 2)
                If ORDENCOMPRABE.T_IGV > 0 Then
                    DET_DOCUMENTOBE.IGV_IMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_VENTA * 18) / 100, 2)
                    DET_DOCUMENTOBE.IGV_DIMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_DVENTA * 18) / 100, 2)
                Else
                    DET_DOCUMENTOBE.IGV_IMPOR = 0
                    DET_DOCUMENTOBE.IGV_DIMPOR = 0
                End If
            End If
            DAcumula = DET_DOCUMENTOBE.UPRECIO_VENTA + DAcumula
            DAcumula1 = DET_DOCUMENTOBE.UPRECIO_VENTA + DAcumula1
            DAcumula2 = DET_DOCUMENTOBE.TPRECIO_DVENTA + DAcumula2
            DAcumula3 = DET_DOCUMENTOBE.TPRECIO_VENTA + DAcumula3
            DAcumula4 = DET_DOCUMENTOBE.IGV_IMPOR + DAcumula4
            DAcumula5 = DET_DOCUMENTOBE.IGV_DIMPOR + DAcumula5
            DET_DOCUMENTOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells("FEC_GENE").Value)), "", RTrim(row.Cells("FEC_GENE").Value))
            DET_DOCUMENTOBE.USUARIO = IIf(IsDBNull(RTrim(row.Cells("USUARIO").Value)), "", RTrim(row.Cells("USUARIO").Value))
            DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
            DET_DOCUMENTOBE.FEC_DIA = IIf(IsDBNull(RTrim(row.Cells("FEC_DIA").Value)), "", RTrim(row.Cells("FEC_DIA").Value))
            DET_DOCUMENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR").Value)), "", RTrim(row.Cells("PROVEEDOR").Value))
            ' DET_DOCUMENTOBE.FEC_LLEG = IIf(IsDBNull(RTrim(row.Cells(12).Value)), "", RTrim(row.Cells(12).Value))
            'contenedor = IIf(IsDBNull(RTrim(row.Cells("FEC_ANU").Value)), ORDENCOMPRABE.FEC_ANU, RTrim(row.Cells("FEC_ANU").Value))

            DET_DOCUMENTOBE.EST = IIf(IsDBNull(RTrim(row.Cells("EST").Value)), "", RTrim(row.Cells("EST").Value))
            If ORDENCOMPRABE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 And ORDENCOMPRABE.T_DOC_REF = DET_DOCUMENTOBE.T_DOC_REF1 Then
                DET_DOCUMENTOBE.NRO_DOC_REF1 = ORDENCOMPRABE.NRO_DOC_REF & "-" & cont
            End If
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ORDENCOMPRABE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ORDENCOMPRABE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ORDENCOMPRABE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = ORDENCOMPRABE.CTCT_COD
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ORDENCOMPRABE.EST
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = "-"
            cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
            cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(ORDENCOMPRABE.T_MOVINV)
            cmd.Parameters.Add("@TPRECIO_VENTA", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.TPRECIO_VENTA)
            cmd.Parameters.Add("@TPRECIO_dVENTA", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.TPRECIO_DVENTA)
            cmd.Parameters.Add("@igv", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.IGV)
            cmd.Parameters.Add("@IGV_IMPOR", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.IGV_IMPOR)
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
            cmd.Parameters.Add("@t_camb", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.T_CAMB)
            cmd.Parameters.Add("@UPRECIO_VENTA", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.UPRECIO_VENTA)
            cmd.Parameters.Add("@UPRECIO_dVENTA", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.UPRECIO_DVENTA)
            cmd.Parameters.Add("@IGV_DIMPOR", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.IGV_DIMPOR)
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = ORDENCOMPRABE.MONEDA
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ORDENCOMPRABE.FEC_GENE
            cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_DIA
            cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = DET_DOCUMENTOBE.PROVEEDOR
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
        'ACTUALIZA CABECERA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDTOTALESGD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ORDENCOMPRABE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ORDENCOMPRABE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ORDENCOMPRABE.NRO_DOC_REF
        cmd.Parameters.Add("@TPRECIO_VENTA", OracleDbType.Double).Value = DAcumula3
        cmd.Parameters.Add("@TPRECIO_DVENTA", OracleDbType.Double).Value = DAcumula2
        cmd.Parameters.Add("@T_IGV", OracleDbType.Double).Value = DAcumula4
        cmd.Parameters.Add("@T_IGV_DOLAR", OracleDbType.Double).Value = DAcumula5
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + ORDENCOMPRABE.T_DOC_REF + "-" + ORDENCOMPRABE.SER_DOC_REF + "-" + ORDENCOMPRABE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    'Metodo para Modificar 
    Private Sub UpdateRow(ByVal ORDENCOMPRABE As ORDENCOMPRABE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        'Dim contenedor As String
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDATEROW_OC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ORDENCOMPRABE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ORDENCOMPRABE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ORDENCOMPRABE.NRO_DOC_REF
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ORDENCOMPRABE.ART_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ORDENCOMPRABE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ORDENCOMPRABE.EST
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = ORDENCOMPRABE.MONEDA
        cmd.Parameters.Add("@tprecio_venta", OracleDbType.Double).Value = ORDENCOMPRABE.TPRECIO_VENTA
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = ORDENCOMPRABE.FEC_ANU
        cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = ORDENCOMPRABE.SIGNO
        cmd.Parameters.Add("@tprecio_dventa", OracleDbType.Double).Value = ORDENCOMPRABE.TPRECIO_DVENTA
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = ORDENCOMPRABE.USUARIO
        cmd.Parameters.Add("@observa", OracleDbType.Char).Value = ORDENCOMPRABE.OBSERVA
        cmd.Parameters.Add("@t_movinv", OracleDbType.Char).Value = ORDENCOMPRABE.T_MOVINV
        cmd.Parameters.Add("@t_igv", OracleDbType.Double).Value = ORDENCOMPRABE.T_IGV
        cmd.Parameters.Add("@t_igv_dolar", OracleDbType.Double).Value = ORDENCOMPRABE.T_IGV_DOLAR
        cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = ORDENCOMPRABE.F_PAGO_ENT
        cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = ORDENCOMPRABE.FOR_ENT_COD
        cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = ORDENCOMPRABE.PROVEEDOR
        cmd.Parameters.Add("@FEC_PROV", OracleDbType.Date).Value = ORDENCOMPRABE.FEC_PROV
        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = ORDENCOMPRABE.CTCT_COD
        cmd.Parameters.Add("@vendedor", OracleDbType.Varchar2).Value = ORDENCOMPRABE.VENDEDOR
        cmd.Parameters.Add("@dir_cod", OracleDbType.Varchar2).Value = ORDENCOMPRABE.DIR_COD
        cmd.Parameters.Add("@NUMPEDIDO", OracleDbType.Varchar2).Value = ORDENCOMPRABE.NUMPEDIDO
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = ORDENCOMPRABE.FEC_DIA
        cmd.Parameters.Add("@NOM_CTCT", OracleDbType.Varchar2).Value = ORDENCOMPRABE.NOM_CTCT
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCUMENTO_DEL_OC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ORDENCOMPRABE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ORDENCOMPRABE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ORDENCOMPRABE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INSOC"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            DET_DOCUMENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            DET_DOCUMENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells("CTCT_COD").Value)), "", RTrim(row.Cells("CTCT_COD").Value))
            DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            DET_DOCUMENTOBE.OBSERVA = IIf(IsDBNull(RTrim(row.Cells("OBSERVA").Value)), "", RTrim(row.Cells("OBSERVA").Value))
            DET_DOCUMENTOBE.T_MOVINV = IIf(IsDBNull(RTrim(row.Cells("T_MOVINV").Value)), "", RTrim(row.Cells("T_MOVINV").Value))
            'DET_DOCUMENTOBE.TPRECIO_VENTA = IIf(IsDBNull(RTrim(row.Cells("TPRECIO_VENTA").Value)), "", RTrim(row.Cells("TPRECIO_VENTA").Value))
            'DET_DOCUMENTOBE.TPRECIO_DVENTA = IIf(IsDBNull(RTrim(row.Cells("TPRECIO_DVENTA").Value)), "", RTrim(row.Cells("TPRECIO_DVENTA").Value))
            'DET_DOCUMENTOBE.UPRECIO_VENTA = IIf(IsDBNull(RTrim(row.Cells("UPRECIO_VENTA").Value)), "", RTrim(row.Cells("UPRECIO_VENTA").Value))
            'DET_DOCUMENTOBE.UPRECIO_DVENTA = IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DVENTA").Value)), "", RTrim(row.Cells("UPRECIO_DVENTA").Value))
            DET_DOCUMENTOBE.IGV = IIf(IsDBNull(RTrim(row.Cells("IGV").Value)), "", RTrim(row.Cells("IGV").Value))
            DET_DOCUMENTOBE.IGV_IMPOR = IIf(IsDBNull(RTrim(row.Cells("IGV_IMPOR").Value)), "", RTrim(row.Cells("IGV_IMPOR").Value))
            DET_DOCUMENTOBE.IGV_DIMPOR = IIf(IsDBNull(RTrim(row.Cells("IGV_DIMPOR").Value)), "", RTrim(row.Cells("IGV_DIMPOR").Value))
            DET_DOCUMENTOBE.T_CAMB = IIf(IsDBNull(RTrim(row.Cells("T_CAMB").Value)), "", RTrim(row.Cells("T_CAMB").Value))
            'DET_DOCUMENTOBE.TPRECIO_VENTA = DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD
            'DET_DOCUMENTOBE.TPRECIO_DVENTA = DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD
            'DET_DOCUMENTOBE.IGV_IMPOR = (DET_DOCUMENTOBE.TPRECIO_VENTA * 18) / 100
            'DET_DOCUMENTOBE.IGV_DIMPOR = (DET_DOCUMENTOBE.TPRECIO_DVENTA * 18) / 100
            If ORDENCOMPRABE.MONEDA = "00" Then
                DET_DOCUMENTOBE.UPRECIO_VENTA = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_VENTA").Value)), 0, RTrim(row.Cells("UPRECIO_VENTA").Value)))
                DET_DOCUMENTOBE.UPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA / DET_DOCUMENTOBE.T_CAMB, 2)
                DET_DOCUMENTOBE.TPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD, 2)
                DET_DOCUMENTOBE.TPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD / DET_DOCUMENTOBE.T_CAMB, 2)
                If ORDENCOMPRABE.T_IGV > 0 Then
                    DET_DOCUMENTOBE.IGV_IMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_VENTA * 18) / 100, 2)
                    DET_DOCUMENTOBE.IGV_DIMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_DVENTA * 18) / 100, 2)
                Else
                    DET_DOCUMENTOBE.IGV_IMPOR = 0
                    DET_DOCUMENTOBE.IGV_DIMPOR = 0
                End If

            ElseIf ORDENCOMPRABE.MONEDA = "01" Then
                DET_DOCUMENTOBE.UPRECIO_DVENTA = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DVENTA").Value)), 0, RTrim(row.Cells("UPRECIO_DVENTA").Value)))
                DET_DOCUMENTOBE.UPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.T_CAMB, 2)
                DET_DOCUMENTOBE.TPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD, 2)
                DET_DOCUMENTOBE.TPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD * DET_DOCUMENTOBE.T_CAMB, 2)
                If ORDENCOMPRABE.T_IGV > 0 Then
                    DET_DOCUMENTOBE.IGV_IMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_VENTA * 18) / 100, 2)
                    DET_DOCUMENTOBE.IGV_DIMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_DVENTA * 18) / 100, 2)
                Else
                    DET_DOCUMENTOBE.IGV_IMPOR = 0
                    DET_DOCUMENTOBE.IGV_DIMPOR = 0
                End If
            End If
            DAcumula = DET_DOCUMENTOBE.UPRECIO_VENTA + DAcumula
            DAcumula1 = DET_DOCUMENTOBE.UPRECIO_VENTA + DAcumula1
            DAcumula2 = DET_DOCUMENTOBE.TPRECIO_DVENTA + DAcumula2
            DAcumula3 = DET_DOCUMENTOBE.TPRECIO_VENTA + DAcumula3
            DAcumula4 = DET_DOCUMENTOBE.IGV_IMPOR + DAcumula4
            DAcumula5 = DET_DOCUMENTOBE.IGV_DIMPOR + DAcumula5
            DET_DOCUMENTOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells("FEC_GENE").Value)), "", RTrim(row.Cells("FEC_GENE").Value))
            DET_DOCUMENTOBE.USUARIO = IIf(IsDBNull(RTrim(row.Cells("USUARIO").Value)), "", RTrim(row.Cells("USUARIO").Value))
            DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
            If IIf(IsDBNull(RTrim(row.Cells("FEC_DIA").Value)), "", RTrim(row.Cells("FEC_DIA").Value)) = "" Then
                DET_DOCUMENTOBE.FEC_DIA = DateTime.Now
            Else
                DET_DOCUMENTOBE.FEC_DIA = IIf(IsDBNull(RTrim(row.Cells("FEC_DIA").Value)), DateTime.Now, RTrim(row.Cells("FEC_DIA").Value))
            End If

            DET_DOCUMENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR").Value)), "", RTrim(row.Cells("PROVEEDOR").Value))
            ' DET_DOCUMENTOBE.FEC_LLEG = IIf(IsDBNull(RTrim(row.Cells(12).Value)), "", RTrim(row.Cells(12).Value))
            'contenedor = IIf(IsDBNull(RTrim(row.Cells("fec_anu").Value)), ORDENCOMPRABE.FEC_ANU, RTrim(row.Cells("fec_anu").Value))

            DET_DOCUMENTOBE.EST = IIf(IsDBNull(RTrim(row.Cells("EST").Value)), "", RTrim(row.Cells("EST").Value))
            If ORDENCOMPRABE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 And ORDENCOMPRABE.T_DOC_REF = DET_DOCUMENTOBE.T_DOC_REF1 Then
                DET_DOCUMENTOBE.NRO_DOC_REF1 = ORDENCOMPRABE.NRO_DOC_REF & "-" & cont
            End If
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ORDENCOMPRABE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ORDENCOMPRABE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ORDENCOMPRABE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = ORDENCOMPRABE.CTCT_COD
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ORDENCOMPRABE.EST
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = "-"
            cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
            cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(ORDENCOMPRABE.T_MOVINV)
            cmd.Parameters.Add("@TPRECIO_VENTA", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.TPRECIO_VENTA)
            cmd.Parameters.Add("@TPRECIO_dVENTA", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.TPRECIO_DVENTA)
            cmd.Parameters.Add("@igv", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.IGV)
            cmd.Parameters.Add("@IGV_IMPOR", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.IGV_IMPOR)
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
            cmd.Parameters.Add("@t_camb", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.T_CAMB)
            cmd.Parameters.Add("@UPRECIO_VENTA", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.UPRECIO_VENTA)
            cmd.Parameters.Add("@UPRECIO_dVENTA", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.UPRECIO_DVENTA)
            cmd.Parameters.Add("@IGV_DIMPOR", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.IGV_DIMPOR)
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = ORDENCOMPRABE.MONEDA
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ORDENCOMPRABE.FEC_GENE
            cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_DIA
            cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = DET_DOCUMENTOBE.PROVEEDOR
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        Next

        'ACTUALIZA CABECERA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDTOTALESGD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ORDENCOMPRABE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ORDENCOMPRABE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ORDENCOMPRABE.NRO_DOC_REF
        cmd.Parameters.Add("@TPRECIO_VENTA", OracleDbType.Double).Value = DAcumula3
        cmd.Parameters.Add("@TPRECIO_DVENTA", OracleDbType.Double).Value = DAcumula2
        cmd.Parameters.Add("@T_IGV", OracleDbType.Double).Value = DAcumula4
        cmd.Parameters.Add("@T_IGV_DOLAR", OracleDbType.Double).Value = DAcumula5
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el Documento: " + ORDENCOMPRABE.T_DOC_REF + "-" + ORDENCOMPRABE.SER_DOC_REF + "-" + ORDENCOMPRABE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub UpdateRowAnularOC(ByVal ORDENCOMPRABE As ORDENCOMPRABE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDATEROW_ANUOC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(ORDENCOMPRABE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(ORDENCOMPRABE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(ORDENCOMPRABE.NRO_DOC_REF)
        cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = "A"
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCU_UPD_ANULAR_OC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ORDENCOMPRABE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ORDENCOMPRABE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ORDENCOMPRABE.NRO_DOC_REF)
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
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Anulo la OC: " + ORDENCOMPRABE.T_DOC_REF + "-" + ORDENCOMPRABE.SER_DOC_REF + "-" + ORDENCOMPRABE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRowCerrar(ByVal ORDENCOMPRABE As ORDENCOMPRABE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOC_CER_OC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(ORDENCOMPRABE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(ORDENCOMPRABE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(ORDENCOMPRABE.NRO_DOC_REF)
        cmd.Parameters.Add("pART_COD", OracleDbType.Varchar2).Value = Trim(ORDENCOMPRABE.ART_COD1)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "5"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Cerro un item de la OC: " + ORDENCOMPRABE.T_DOC_REF + "-" + ORDENCOMPRABE.SER_DOC_REF + "-" + ORDENCOMPRABE.NRO_DOC_REF + "-" + ORDENCOMPRABE.ART_COD1
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateFecProv(ByVal ORDENCOMPRABE As ORDENCOMPRABE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DOCUMENTO_FPROV_UOC"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            DET_DOCUMENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells("CTCT_COD").Value)), "", RTrim(row.Cells("CTCT_COD").Value))
            cmd.Parameters.Add("pFEC_PROV", OracleDbType.Date).Value = ORDENCOMPRABE.FEC_PROV
            cmd.Parameters.Add("pNRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF)
            cmd.Parameters.Add("pCTCT_COD", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.CTCT_COD)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

    End Sub
    Public Function SelectNroAnu(ByVal sTip As String, ByVal sSer As String, ByVal sNro As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ORDENCOMP_SELNRO_EST", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sTip),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sSer),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sNro)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    'Funcion Principal que hara toda la logica para grabar la data
    Public Function SaveRow(ByVal ORDENCOMPRABE As ORDENCOMPRABE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal flagAccion As String, ByVal dg As DataGridView) As String
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
                ''correlativo = LastCodigo()
                ''MonedaBE.mon_codigo = MonedaBE.mon_codigo
                InsertRow(ORDENCOMPRABE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg)
                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                UpdateRow(ORDENCOMPRABE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "AR" Then
                UpdateRowAnularOC(ORDENCOMPRABE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "C" Then
                UpdateRowCerrar(ORDENCOMPRABE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "PROV" Then
                UpdateFecProv(ORDENCOMPRABE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg)
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
                If flagAccion <> "C" And flagAccion <> "PROV" And flagAccion <> "N" Then
                    cn.Dispose()
                End If
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

    Public Function SelectT_MOVINV() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_T_MOVINV2", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectF_PAGO() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_F_PAGO1", {})
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

    Public Function SelectVendedor() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_VENDEDOR", {})
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

    Public Function SelectProv() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_PROV", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectCliente() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_CTCTCOD", {})
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

    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DET_DOCUMENTO_SELECTROW_OC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
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

    Public Function SelectCatalogo(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_CAT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sCode", Trim(sCode))})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        If dt.Rows.Count >= 1 Then
            Return dt.Rows(0).Item(0)
        Else
            Return ""
        End If

    End Function
    Public Function SelectF_PAGO_ENT_Ult(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_F_PAGO_ENT_82", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sCode", Trim(sCode))})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            'Return
            MsgBox("No hay Forma de Pago")
        End Try


    End Function
    Public Function SelectOC(ByVal sCode As String, ByVal sNUM As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_NUMPEDIDO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sCode", Trim(sCode)),
                                                                                                                       New Oracle.ManagedDataAccess.Client.OracleParameter("@sNUM", Trim(sNUM))})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
            'MsgBox("No hay Forma de Pago")
        End Try


    End Function
    Public Function SelectAll(ByVal sT_doc As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SELECTALL_COMP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Function lv_fec(ByVal fec1 As Date, ByVal fec2 As Date) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ORDENCOMPRA_SEARCHFROV", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec1", fec1),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@fec2", fec2)})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt

    End Function
    Function SearchNro(ByVal sNRO As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ORDENCOMPRA_SEARCHNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sNRO", sNRO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt

    End Function

    Function ArtNro(ByVal sNRO As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ORDENCOMPRA_SEARCHART", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sNRO", sNRO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function FecProv(ByVal sNRO As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_ORDENCOMPRA_SEARCHOCX", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sNRO", sNRO)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
            'MsgBox("No hay Forma de Pago")
        End Try

    End Function
    Public Function SelProv(ByVal sNRO As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDENCOMPRA_PROVOC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sNRO", Trim(sNRO))})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
            'MsgBox("No hay Forma de Pago")
        End Try
    End Function

    Public Function SelProv(ByVal sNRO As String, ByVal sART As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDENCOMPRA_PROVOC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sNRO", Trim(sNRO)),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@sART", Trim(sART))})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
            'MsgBox("No hay Forma de Pago")
        End Try
    End Function
    Public Function SelCantOT(ByVal sNRO As String, ByVal sART As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDENCOMPRA_PROVCANT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sNRO", Trim(sNRO)),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@sART", Trim(sART))})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
            'MsgBox("No hay Forma de Pago")
        End Try
    End Function
    Public Function SelectComAllFiltro(ByVal saño As String, ByVal smes As String, ByVal serie As String,
                                       ByVal nro As String, ByVal ruc As String, ByVal art As String,
                                       ByVal nart As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SELALLOCFILTRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ANHO", saño),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", smes),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SERIE", serie),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO", nro),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@RUC", ruc),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@art", art),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nart", nart)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
