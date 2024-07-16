Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect

Public Class LETRASDAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    Inherits BaseDatosORACLE
    Public sNumero As String
    Public sPrueba As String
    Public sNumero1 As Double
    Public sNomArt As Integer
    'Metodo para registrar un nuevo 
    Private Sub InsertRow(ByVal LETRASBE As LETRASBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView, ByVal dgmontos As DataGridView, ByVal ELTBLETRAS_MONTOBE As ELTBLETRAS_MONTOBE)
        'Dim contenedor As String

        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_INSERTROW_LT"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans

        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.NRO_DOC_REF
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = LETRASBE.ART_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = LETRASBE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = LETRASBE.EST
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = LETRASBE.MONEDA
        cmd.Parameters.Add("@tprecio_venta", OracleDbType.Double).Value = LETRASBE.TPRECIO_VENTA
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = LETRASBE.FEC_ANU
        cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = LETRASBE.SIGNO
        cmd.Parameters.Add("@tprecio_dventa", OracleDbType.Double).Value = LETRASBE.TPRECIO_DVENTA
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = LETRASBE.USUARIO
        cmd.Parameters.Add("@observa", OracleDbType.Char).Value = LETRASBE.OBSERVA
        cmd.Parameters.Add("@t_movinv", OracleDbType.Char).Value = LETRASBE.T_MOVINV
        cmd.Parameters.Add("@t_igv", OracleDbType.Double).Value = LETRASBE.T_IGV
        cmd.Parameters.Add("@t_igv_dolar", OracleDbType.Double).Value = LETRASBE.T_IGV_DOLAR
        cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = LETRASBE.F_PAGO_ENT
        cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = LETRASBE.FOR_ENT_COD
        cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = LETRASBE.PROVEEDOR
        cmd.Parameters.Add("@FEC_PROV", OracleDbType.Date).Value = LETRASBE.FEC_PROV
        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = LETRASBE.CTCT_COD
        cmd.Parameters.Add("@vendedor", OracleDbType.Varchar2).Value = LETRASBE.VENDEDOR
        cmd.Parameters.Add("@dir_cod", OracleDbType.Varchar2).Value = LETRASBE.DIR_COD
        cmd.Parameters.Add("@NUMPEDIDO", OracleDbType.Varchar2).Value = LETRASBE.NUMPEDIDO
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = LETRASBE.FEC_DIA
        cmd.Parameters.Add("@monto_pagado", OracleDbType.Double).Value = LETRASBE.MONTO_PAGADO
        cmd.Parameters.Add("@monto_pagadod", OracleDbType.Double).Value = LETRASBE.MONTO_PAGADOD
        cmd.Parameters.Add("@pag_parcial", OracleDbType.Double).Value = LETRASBE.PAG_PARCIAL
        cmd.Parameters.Add("@fec_letra", OracleDbType.Date).Value = LETRASBE.FEC_LETRA
        cmd.Parameters.Add("@fec_vigencia", OracleDbType.Date).Value = LETRASBE.FEC_VIGENCIA
        cmd.Parameters.Add("@binteres", OracleDbType.Varchar2).Value = LETRASBE.BINTERES
        cmd.Parameters.Add("@best1", OracleDbType.Varchar2).Value = LETRASBE.EST1
        cmd.Parameters.Add("@x_d", OracleDbType.Varchar2).Value = LETRASBE.X_D
        cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = LETRASBE.ALM_COD
        cmd.Parameters.Add("@NOM_CTCT", OracleDbType.Varchar2).Value = LETRASBE.NOM_CTCT
        cmd.Parameters.Add("@PORCENTAJE", OracleDbType.Varchar2).Value = LETRASBE.PORCENTAJE
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INSLT"
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
            If LETRASBE.MONEDA = "00" Then
                DET_DOCUMENTOBE.UPRECIO_VENTA = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_VENTA").Value)), 0, RTrim(row.Cells("UPRECIO_VENTA").Value)))
                DET_DOCUMENTOBE.UPRECIO_DVENTA = DET_DOCUMENTOBE.UPRECIO_VENTA / DET_DOCUMENTOBE.T_CAMB 'DET_DOCUMENTOBE.UPRECIO_VENTA / LETRASBE.T_CAMB
                DET_DOCUMENTOBE.TPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD, 2)
                DET_DOCUMENTOBE.TPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD / DET_DOCUMENTOBE.T_CAMB, 2) 'Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD / LETRASBE.T_CAMB, 2)
                If LETRASBE.T_IGV > 0 Then
                    DET_DOCUMENTOBE.IGV_IMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_VENTA * 18) / 100, 2)
                    DET_DOCUMENTOBE.IGV_DIMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_DVENTA * 18) / 100, 2)
                Else
                    DET_DOCUMENTOBE.IGV_IMPOR = 0
                    DET_DOCUMENTOBE.IGV_DIMPOR = 0
                End If


            ElseIf LETRASBE.MONEDA = "01" Then
                DET_DOCUMENTOBE.UPRECIO_DVENTA = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DVENTA").Value)), 0, RTrim(row.Cells("UPRECIO_DVENTA").Value)))
                DET_DOCUMENTOBE.UPRECIO_VENTA = DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.T_CAMB 'DET_DOCUMENTOBE.UPRECIO_DVENTA * LETRASBE.T_CAMB
                DET_DOCUMENTOBE.TPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD, 2)
                DET_DOCUMENTOBE.TPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD * DET_DOCUMENTOBE.T_CAMB, 2) 'Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD * LETRASBE.T_CAMB, 2)
                If LETRASBE.T_IGV > 0 Then
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
            'DET_DOCUMENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR").Value)), "", RTrim(row.Cells("PROVEEDOR").Value))
            DET_DOCUMENTOBE.FEC_ENT = IIf(IsDBNull(RTrim(row.Cells("FEC_ENT").Value)), "", RTrim(row.Cells("FEC_ENT").Value))
            DET_DOCUMENTOBE.EST = IIf(IsDBNull(RTrim(row.Cells("EST").Value)), "", RTrim(row.Cells("EST").Value))
            'If LETRASBE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 And LETRASBE.T_DOC_REF = DET_DOCUMENTOBE.T_DOC_REF1 Then
            '    DET_DOCUMENTOBE.NRO_DOC_REF1 = LETRASBE.NRO_DOC_REF & "-" & cont
            'End If
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Mid(DET_DOCUMENTOBE.NRO_DOC_REF1, 1, 7) & "-" & cont
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = LETRASBE.CTCT_COD
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = LETRASBE.EST
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = "-"
            cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
            cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(LETRASBE.T_MOVINV)
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
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = LETRASBE.MONEDA
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = LETRASBE.FEC_GENE
            cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_DIA
            cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = "20100279348"
            cmd.Parameters.Add("@FEC_ENT", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
        'ACTUALIZA CABECERA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDTOTALESGD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.NRO_DOC_REF
        cmd.Parameters.Add("@TPRECIO_VENTA", OracleDbType.Double).Value = DAcumula3
        cmd.Parameters.Add("@TPRECIO_DVENTA", OracleDbType.Double).Value = DAcumula2
        cmd.Parameters.Add("@T_IGV", OracleDbType.Double).Value = DAcumula4
        cmd.Parameters.Add("@T_IGV_DOLAR", OracleDbType.Double).Value = DAcumula5
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'INSERTAR GRID DE LETRA MONTOS
        For Each row As DataGridViewRow In dgmontos.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_LETRAMON_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBLETRAS_MONTOBE.t_doc_ref = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            ELTBLETRAS_MONTOBE.ser_doc_ref = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            ELTBLETRAS_MONTOBE.nro_doc_ref = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            ELTBLETRAS_MONTOBE.t_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELTBLETRAS_MONTOBE.ser_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELTBLETRAS_MONTOBE.nro_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELTBLETRAS_MONTOBE.proveedor = IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR").Value)), "", RTrim(row.Cells("PROVEEDOR").Value))
            ELTBLETRAS_MONTOBE.montos = IIf(IsDBNull(RTrim(row.Cells("MONTOS").Value)), 0, RTrim(row.Cells("MONTOS").Value))
            ELTBLETRAS_MONTOBE.montod = IIf(IsDBNull(RTrim(row.Cells("MONTOD").Value)), 0, RTrim(row.Cells("MONTOD").Value))
            ELTBLETRAS_MONTOBE.moneda = IIf(IsDBNull(RTrim(row.Cells("MONEDA").Value)), "", RTrim(row.Cells("MONEDA").Value))
            ELTBLETRAS_MONTOBE.montos_fact = IIf(IsDBNull(RTrim(row.Cells("MONTO_FACTURA").Value)), 0, RTrim(row.Cells("MONTO_FACTURA").Value))
            ELTBLETRAS_MONTOBE.montod_fact = IIf(IsDBNull(RTrim(row.Cells("MONTO_FACTURAD").Value)), 0, RTrim(row.Cells("MONTO_FACTURAD").Value))
            'ELTBLETRAS_MONTOBE.t_cmb = IIf(IsDBNull(RTrim(row.Cells("T_CMB").Value)), 0, RTrim(row.Cells("T_CMB").Value))

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.t_doc_ref
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.ser_doc_ref
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.nro_doc_ref
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.t_doc_ref1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.ser_doc_ref1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.nro_doc_ref1
            cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.proveedor
            If ELTBLETRAS_MONTOBE.moneda = "01" Then
                cmd.Parameters.Add("@montos", OracleDbType.Double).Value = Math.Round(LETRASBE.T_CAMB * ELTBLETRAS_MONTOBE.montod, 2)
                cmd.Parameters.Add("@montod", OracleDbType.Double).Value = ELTBLETRAS_MONTOBE.montod
            Else
                cmd.Parameters.Add("@montos", OracleDbType.Double).Value = ELTBLETRAS_MONTOBE.montos
                cmd.Parameters.Add("@montod", OracleDbType.Double).Value = 0
            End If
            cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.moneda
            If ELTBLETRAS_MONTOBE.moneda = "01" Then
                cmd.Parameters.Add("@montos_fact", OracleDbType.Double).Value = Math.Round(LETRASBE.T_CAMB * ELTBLETRAS_MONTOBE.montod_fact, 2)
                cmd.Parameters.Add("@montod_fact", OracleDbType.Double).Value = ELTBLETRAS_MONTOBE.montod_fact
            Else
                cmd.Parameters.Add("@montos_fact", OracleDbType.Double).Value = ELTBLETRAS_MONTOBE.montos_fact
                cmd.Parameters.Add("@montod_fact", OracleDbType.Double).Value = Math.Round(ELTBLETRAS_MONTOBE.montos_fact / LETRASBE.T_CAMB, 2)
            End If
            cmd.Parameters.Add("@t_cmb", OracleDbType.Double).Value = Trim(LETRASBE.T_CAMB)
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = LETRASBE.FEC_GENE
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
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + LETRASBE.T_DOC_REF + "-" + LETRASBE.SER_DOC_REF + "-" + LETRASBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub InsertRowFL(ByVal LETRASBE As LETRASBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView, ByVal dgmontos As DataGridView, ByVal dgdet As DataGridView,
                          ByVal ELTBLETRAS_MONTOBE As ELTBLETRAS_MONTOBE)
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim cont As Integer = 0
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        For Each row As DataGridViewRow In dgmontos.Rows 'dg para cabecera
            For Each row1 As DataGridViewRow In dg.Rows
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_DOCUMENTO_INSERTROW_LT"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                LETRASBE.FEC_LETRA = Nothing
                LETRASBE.FEC_PROV = Nothing
                LETRASBE.FEC_ANU = Nothing
                'Los parametros que va recibir son las propiedades de la clase 
                LETRASBE.FEC_VIGENCIA = IIf(IsDBNull(RTrim(row.Cells("FEC_VIGENCIA").Value)), "", RTrim(row.Cells("FEC_VIGENCIA").Value))
                cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = "80"
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
                cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = "07010003"
                cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = LETRASBE.FEC_GENE
                cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = "H"
                cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("MONEDA").Value)), "", RTrim(row.Cells("MONEDA").Value))
                cmd.Parameters.Add("@tprecio_venta", OracleDbType.Double).Value = Val(IIf(IsDBNull(RTrim(row1.Cells("TPRECIO_VENTA").Value)), 0, RTrim(row1.Cells("TPRECIO_VENTA").Value)))
                cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = LETRASBE.FEC_ANU
                cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = "-"
                cmd.Parameters.Add("@tprecio_dventa", OracleDbType.Double).Value = Val(IIf(IsDBNull(RTrim(row1.Cells("TPRECIO_DVENTA").Value)), 0, RTrim(row1.Cells("TPRECIO_DVENTA").Value)))
                cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row1.Cells("USUARIO").Value)), "", RTrim(row1.Cells("USUARIO").Value))
                cmd.Parameters.Add("@observa", OracleDbType.Char).Value = ""
                cmd.Parameters.Add("@t_movinv", OracleDbType.Char).Value = ""
                cmd.Parameters.Add("@t_igv", OracleDbType.Double).Value = Val(IIf(IsDBNull(RTrim(row1.Cells("T_IGV").Value)), 0, RTrim(row1.Cells("T_IGV").Value)))
                cmd.Parameters.Add("@t_igv_dolar", OracleDbType.Double).Value = Val(IIf(IsDBNull(RTrim(row1.Cells("T_IGV_DOLAR").Value)), 0, RTrim(row1.Cells("T_IGV_DOLAR").Value)))
                cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("F_PAGO_ENT").Value)), "", RTrim(row.Cells("F_PAGO_ENT").Value))
                cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = ""
                cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = "20100279348"
                cmd.Parameters.Add("@FEC_PROV", OracleDbType.Date).Value = LETRASBE.FEC_PROV
                cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row1.Cells("CTCT_COD").Value)), "", RTrim(row1.Cells("CTCT_COD").Value))
                cmd.Parameters.Add("@vendedor", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row1.Cells("VENDEDOR").Value)), "", RTrim(row1.Cells("VENDEDOR").Value))
                cmd.Parameters.Add("@dir_cod", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row1.Cells("DIR_COD").Value)), "", RTrim(row1.Cells("DIR_COD").Value))
                cmd.Parameters.Add("@NUMPEDIDO", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row1.Cells("NUMPEDIDO").Value)), "", RTrim(row1.Cells("NUMPEDIDO").Value))
                cmd.Parameters.Add("@FEC_DIA", OracleDbType.Date).Value = LETRASBE.FEC_DIA
                cmd.Parameters.Add("@MONTO_PAGADO", OracleDbType.Double).Value = Val(IIf(IsDBNull(RTrim(row.Cells("MONTOS").Value)), 0, RTrim(row.Cells("MONTOS").Value)))
                cmd.Parameters.Add("@MONTO_PAGADOD", OracleDbType.Double).Value = Val(IIf(IsDBNull(RTrim(row.Cells("MONTOD").Value)), 0, RTrim(row.Cells("MONTOD").Value)))
                cmd.Parameters.Add("@pag_parcial", OracleDbType.Double).Value = 0
                cmd.Parameters.Add("@fec_letra", OracleDbType.Date).Value = LETRASBE.FEC_LETRA
                cmd.Parameters.Add("@fec_vigencia", OracleDbType.Date).Value = LETRASBE.FEC_VIGENCIA
                cmd.Parameters.Add("@binteres", OracleDbType.Varchar2).Value = ""
                cmd.Parameters.Add("@best1", OracleDbType.Varchar2).Value = ""
                cmd.Parameters.Add("@x_d", OracleDbType.Varchar2).Value = ""
                cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = ""
                cmd.Parameters.Add("@NOM_CTCT", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row1.Cells("NOM_CTCT").Value)), "", RTrim(row1.Cells("NOM_CTCT").Value))
                cmd.Parameters.Add("@PERCEPCION", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("PERCEPCION").Value)), "", RTrim(row.Cells("PERCEPCION").Value))
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                LETRASBE.CTCT_COD = IIf(IsDBNull(RTrim(row1.Cells("CTCT_COD").Value)), "", RTrim(row1.Cells("CTCT_COD").Value))
                LETRASBE.MONEDA = IIf(IsDBNull(RTrim(row.Cells("MONEDA").Value)), "", RTrim(row.Cells("MONEDA").Value))
                LETRASBE.T_IGV = Val(IIf(IsDBNull(RTrim(row1.Cells("T_IGV").Value)), 0, RTrim(row1.Cells("T_IGV").Value)))
                LETRASBE.FEC_GENE = IIf(IsDBNull(RTrim(row1.Cells("FEC_GENE").Value)), "", RTrim(row1.Cells("FEC_GENE").Value))
                DET_DOCUMENTOBE.USUARIO = IIf(IsDBNull(RTrim(row1.Cells("USUARIO").Value)), "", RTrim(row1.Cells("USUARIO").Value))
            Next
            '
            For Each row1 As DataGridViewRow In dgdet.Rows
                cont = cont + 1
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_DET_DOCUMENTO_INSLT"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                LETRASBE.T_DOC_REF = "80"
                LETRASBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
                LETRASBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
                DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
                DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
                DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
                DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row1.Cells("CANTIDAD").Value)), 0, RTrim(row1.Cells("CANTIDAD").Value))
                DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row1.Cells("ART_COD").Value)), "", RTrim(row1.Cells("ART_COD").Value))
                DET_DOCUMENTOBE.OBSERVA = IIf(IsDBNull(RTrim(row1.Cells("OBSERVA").Value)), "", RTrim(row1.Cells("OBSERVA").Value))
                DET_DOCUMENTOBE.T_MOVINV = ""
                DET_DOCUMENTOBE.IGV = IIf(IsDBNull(RTrim(row1.Cells("IGV").Value)), 0, RTrim(row1.Cells("IGV").Value))
                DET_DOCUMENTOBE.T_CAMB = IIf(IsDBNull(RTrim(row1.Cells("T_CAMB").Value)), 0, RTrim(row1.Cells("T_CAMB").Value))
                If LETRASBE.MONEDA = "00" Then
                    DET_DOCUMENTOBE.UPRECIO_VENTA = CDbl(IIf(IsDBNull(RTrim(row1.Cells("UPRECIO_VENTA").Value)), 0, RTrim(row1.Cells("UPRECIO_VENTA").Value)))
                    DET_DOCUMENTOBE.UPRECIO_DVENTA = DET_DOCUMENTOBE.UPRECIO_VENTA / DET_DOCUMENTOBE.T_CAMB 'DET_DOCUMENTOBE.UPRECIO_VENTA / LETRASBE.T_CAMB
                    DET_DOCUMENTOBE.TPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD, 2)
                    DET_DOCUMENTOBE.TPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD / DET_DOCUMENTOBE.T_CAMB, 2) 'Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD / LETRASBE.T_CAMB, 2)
                    If LETRASBE.T_IGV > 0 Then
                        DET_DOCUMENTOBE.IGV_IMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_VENTA * 18) / 100, 2)
                        DET_DOCUMENTOBE.IGV_DIMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_DVENTA * 18) / 100, 2)
                    Else
                        DET_DOCUMENTOBE.IGV_IMPOR = 0
                        DET_DOCUMENTOBE.IGV_DIMPOR = 0
                    End If


                ElseIf LETRASBE.MONEDA = "01" Then
                    DET_DOCUMENTOBE.UPRECIO_DVENTA = CDbl(IIf(IsDBNull(RTrim(row1.Cells("UPRECIO_DVENTA").Value)), 0, RTrim(row1.Cells("UPRECIO_DVENTA").Value)))
                    DET_DOCUMENTOBE.UPRECIO_VENTA = DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.T_CAMB 'DET_DOCUMENTOBE.UPRECIO_DVENTA * LETRASBE.T_CAMB
                    DET_DOCUMENTOBE.TPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD, 2)
                    DET_DOCUMENTOBE.TPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD * DET_DOCUMENTOBE.T_CAMB, 2) 'Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD * LETRASBE.T_CAMB, 2)
                    If LETRASBE.T_IGV > 0 Then
                        DET_DOCUMENTOBE.IGV_IMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_VENTA * 18) / 100, 2)
                        DET_DOCUMENTOBE.IGV_DIMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_DVENTA * 18) / 100, 2)
                    Else
                        DET_DOCUMENTOBE.IGV_IMPOR = 0
                        DET_DOCUMENTOBE.IGV_DIMPOR = 0
                    End If

                End If
                'DAcumula = DET_DOCUMENTOBE.UPRECIO_VENTA + DAcumula
                'DAcumula1 = DET_DOCUMENTOBE.UPRECIO_VENTA + DAcumula1
                'DAcumula2 = DET_DOCUMENTOBE.TPRECIO_DVENTA + DAcumula2
                'DAcumula3 = DET_DOCUMENTOBE.TPRECIO_VENTA + DAcumula3
                'DAcumula4 = DET_DOCUMENTOBE.IGV_IMPOR + DAcumula4
                'DAcumula5 = DET_DOCUMENTOBE.IGV_DIMPOR + DAcumula5

                DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row1.Cells("UNIDAD").Value)), "", RTrim(row1.Cells("UNIDAD").Value))
                DET_DOCUMENTOBE.PROVEEDOR = "20100279348"
                DET_DOCUMENTOBE.FEC_ENT = IIf(IsDBNull(RTrim(row1.Cells("FEC_ENT").Value)), "", RTrim(row1.Cells("FEC_ENT").Value))
                DET_DOCUMENTOBE.EST = "H"
                'If LETRASBE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 And LETRASBE.T_DOC_REF = DET_DOCUMENTOBE.T_DOC_REF1 Then
                '    DET_DOCUMENTOBE.NRO_DOC_REF1 = LETRASBE.NRO_DOC_REF & "-" & cont
                'End If
                'Los parametros que va recibir son las propiedades de la clase 
                cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.T_DOC_REF
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.SER_DOC_REF
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.NRO_DOC_REF
                cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
                cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
                cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Mid(DET_DOCUMENTOBE.NRO_DOC_REF1, 1, 7) & "-" & cont
                cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = LETRASBE.CTCT_COD
                cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = LETRASBE.EST
                cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = "-"
                cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
                cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(LETRASBE.T_MOVINV)
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
                cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = LETRASBE.MONEDA
                cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = LETRASBE.FEC_GENE
                cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = LETRASBE.FEC_DIA
                cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = DET_DOCUMENTOBE.PROVEEDOR
                cmd.Parameters.Add("@FEC_ENT", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Next
        Next
        cont = 0
        ''INSERTAR GRID DE LETRA MONTOS
        For Each row As DataGridViewRow In dgmontos.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_LETRAMON_INSERTROW1"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBLETRAS_MONTOBE.t_doc_ref = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            ELTBLETRAS_MONTOBE.ser_doc_ref = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            ELTBLETRAS_MONTOBE.nro_doc_ref = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            ELTBLETRAS_MONTOBE.t_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELTBLETRAS_MONTOBE.ser_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELTBLETRAS_MONTOBE.nro_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            'ELTBLETRAS_MONTOBE.proveedor = IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR").Value)), "", RTrim(row.Cells("PROVEEDOR").Value))
            ELTBLETRAS_MONTOBE.montos = IIf(IsDBNull(RTrim(row.Cells("MONTOS").Value)), 0, RTrim(row.Cells("MONTOS").Value))
            ELTBLETRAS_MONTOBE.montod = IIf(IsDBNull(RTrim(row.Cells("MONTOD").Value)), 0, RTrim(row.Cells("MONTOD").Value))
            ELTBLETRAS_MONTOBE.moneda = IIf(IsDBNull(RTrim(row.Cells("MONEDA").Value)), "", RTrim(row.Cells("MONEDA").Value))
            ELTBLETRAS_MONTOBE.montos_fact = IIf(IsDBNull(RTrim(row.Cells("MONTOS_FACT").Value)), 0, RTrim(row.Cells("MONTOS_FACT").Value))
            ELTBLETRAS_MONTOBE.montod_fact = IIf(IsDBNull(RTrim(row.Cells("MONTOD_FACT").Value)), 0, RTrim(row.Cells("MONTOD_FACT").Value))
            ELTBLETRAS_MONTOBE.f_pago_ent = IIf(IsDBNull(RTrim(row.Cells("F_PAGO_ENT").Value)), "", RTrim(row.Cells("F_PAGO_ENT").Value))
            ELTBLETRAS_MONTOBE.fec_vigencia = IIf(IsDBNull(RTrim(row.Cells("FEC_VIGENCIA").Value)), "", RTrim(row.Cells("FEC_VIGENCIA").Value))
            'ELTBLETRAS_MONTOBE.t_cmb = IIf(IsDBNull(RTrim(row.Cells("T_CMB").Value)), 0, RTrim(row.Cells("T_CMB").Value))

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = "80"
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.ser_doc_ref
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.nro_doc_ref
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.t_doc_ref1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.ser_doc_ref1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.nro_doc_ref1
            cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = LETRASBE.CTCT_COD
            If ELTBLETRAS_MONTOBE.moneda = "01" Then
                cmd.Parameters.Add("@montos", OracleDbType.Double).Value = Math.Round(LETRASBE.T_CAMB * ELTBLETRAS_MONTOBE.montod, 2)
                cmd.Parameters.Add("@montod", OracleDbType.Double).Value = ELTBLETRAS_MONTOBE.montod
            Else
                cmd.Parameters.Add("@montos", OracleDbType.Double).Value = ELTBLETRAS_MONTOBE.montos
                cmd.Parameters.Add("@montod", OracleDbType.Double).Value = 0
            End If
            cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.moneda
            If ELTBLETRAS_MONTOBE.moneda = "01" Then
                cmd.Parameters.Add("@montos_fact", OracleDbType.Double).Value = Math.Round(LETRASBE.T_CAMB * ELTBLETRAS_MONTOBE.montod_fact, 2)
                cmd.Parameters.Add("@montod_fact", OracleDbType.Double).Value = ELTBLETRAS_MONTOBE.montod_fact
            Else
                cmd.Parameters.Add("@montos_fact", OracleDbType.Double).Value = ELTBLETRAS_MONTOBE.montos_fact
                cmd.Parameters.Add("@montod_fact", OracleDbType.Double).Value = Math.Round(ELTBLETRAS_MONTOBE.montos_fact / LETRASBE.T_CAMB, 2)
            End If
            cmd.Parameters.Add("@t_cmb", OracleDbType.Double).Value = Trim(LETRASBE.T_CAMB)
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = LETRASBE.FEC_GENE
            cmd.Parameters.Add("@F_PAGO_ENT", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.f_pago_ent
            cmd.Parameters.Add("@FEC_VIGENCIA", OracleDbType.Date).Value = ELTBLETRAS_MONTOBE.fec_vigencia
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + LETRASBE.T_DOC_REF + "-" + LETRASBE.SER_DOC_REF + "-" + LETRASBE.NRO_DOC_REF
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    'Metodo para Modificar 
    Private Sub UpdateRow(ByVal LETRASBE As LETRASBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView, ByVal dgmontos As DataGridView, ByVal ELTBLETRAS_MONTOBE As ELTBLETRAS_MONTOBE)
        'Dim contenedor As String
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDATEROW_LT"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.NRO_DOC_REF
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = LETRASBE.ART_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = LETRASBE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = LETRASBE.EST
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = LETRASBE.MONEDA
        cmd.Parameters.Add("@tprecio_venta", OracleDbType.Double).Value = LETRASBE.TPRECIO_VENTA
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = LETRASBE.FEC_ANU
        cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = LETRASBE.SIGNO
        cmd.Parameters.Add("@tprecio_dventa", OracleDbType.Double).Value = LETRASBE.TPRECIO_DVENTA
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = LETRASBE.USUARIO
        cmd.Parameters.Add("@observa", OracleDbType.Char).Value = LETRASBE.OBSERVA
        cmd.Parameters.Add("@t_movinv", OracleDbType.Char).Value = LETRASBE.T_MOVINV
        cmd.Parameters.Add("@t_igv", OracleDbType.Double).Value = LETRASBE.T_IGV
        cmd.Parameters.Add("@t_igv_dolar", OracleDbType.Double).Value = LETRASBE.T_IGV_DOLAR
        cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = LETRASBE.F_PAGO_ENT
        cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = LETRASBE.FOR_ENT_COD
        cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = LETRASBE.PROVEEDOR
        cmd.Parameters.Add("@FEC_PROV", OracleDbType.Date).Value = LETRASBE.FEC_PROV
        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = LETRASBE.CTCT_COD
        cmd.Parameters.Add("@vendedor", OracleDbType.Varchar2).Value = LETRASBE.VENDEDOR
        cmd.Parameters.Add("@dir_cod", OracleDbType.Varchar2).Value = LETRASBE.DIR_COD
        cmd.Parameters.Add("@NUMPEDIDO", OracleDbType.Varchar2).Value = LETRASBE.NUMPEDIDO
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = LETRASBE.FEC_DIA
        cmd.Parameters.Add("@monto_pagado", OracleDbType.Double).Value = LETRASBE.MONTO_PAGADO
        cmd.Parameters.Add("@monto_pagadod", OracleDbType.Double).Value = LETRASBE.MONTO_PAGADOD
        cmd.Parameters.Add("@pag_parcial", OracleDbType.Double).Value = LETRASBE.PAG_PARCIAL
        cmd.Parameters.Add("@fec_letra", OracleDbType.Date).Value = LETRASBE.FEC_LETRA
        cmd.Parameters.Add("@fec_vigencia", OracleDbType.Date).Value = LETRASBE.FEC_VIGENCIA
        cmd.Parameters.Add("@binteres", OracleDbType.Varchar2).Value = LETRASBE.BINTERES
        cmd.Parameters.Add("@best1", OracleDbType.Varchar2).Value = LETRASBE.EST1
        cmd.Parameters.Add("@x_d", OracleDbType.Varchar2).Value = LETRASBE.X_D
        cmd.Parameters.Add("@Z_LETRA", OracleDbType.Varchar2).Value = LETRASBE.Z_LETRA
        cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = LETRASBE.ALM_COD
        cmd.Parameters.Add("@NOM_CTCT", OracleDbType.Varchar2).Value = LETRASBE.NOM_CTCT
        cmd.Parameters.Add("@PORCENTAJE", OracleDbType.Varchar2).Value = LETRASBE.PORCENTAJE
        cmd.Parameters.Add("@FARDO1", OracleDbType.Varchar2).Value = LETRASBE.COD_COLOR
        cmd.Parameters.Add("@FARDO2", OracleDbType.Varchar2).Value = LETRASBE.COD_MEDIDA
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCUMENTO_DEL_FC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1


            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INSLT"
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
            DET_DOCUMENTOBE.TPRECIO_VENTA = IIf(IsDBNull(RTrim(row.Cells("TPRECIO_VENTA").Value)), 0, RTrim(row.Cells("TPRECIO_VENTA").Value))
            DET_DOCUMENTOBE.TPRECIO_DVENTA = IIf(IsDBNull(RTrim(row.Cells("TPRECIO_DVENTA").Value)), 0, RTrim(row.Cells("TPRECIO_DVENTA").Value))
            DET_DOCUMENTOBE.IGV = IIf(IsDBNull(RTrim(row.Cells("IGV").Value)), 0, RTrim(row.Cells("IGV").Value))
            DET_DOCUMENTOBE.IGV_IMPOR = IIf(IsDBNull(RTrim(row.Cells("IGV_IMPOR").Value)), 0, RTrim(row.Cells("IGV_IMPOR").Value))
            DET_DOCUMENTOBE.IGV_DIMPOR = IIf(IsDBNull(RTrim(row.Cells("IGV_DIMPOR").Value)), 0, RTrim(row.Cells("IGV_DIMPOR").Value))
            DET_DOCUMENTOBE.T_CAMB = IIf(IsDBNull(RTrim(row.Cells("T_CAMB").Value)), 0, RTrim(row.Cells("T_CAMB").Value))
            If LETRASBE.MONEDA = "00" Then
                DET_DOCUMENTOBE.UPRECIO_VENTA = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_VENTA").Value)), 0, RTrim(row.Cells("UPRECIO_VENTA").Value)))
                DET_DOCUMENTOBE.UPRECIO_DVENTA = DET_DOCUMENTOBE.UPRECIO_VENTA / DET_DOCUMENTOBE.T_CAMB
                DET_DOCUMENTOBE.TPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD, 2)
                DET_DOCUMENTOBE.TPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD / DET_DOCUMENTOBE.T_CAMB, 2)
                If LETRASBE.T_IGV > 0 Then
                    DET_DOCUMENTOBE.IGV_IMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_VENTA * 18) / 100, 2)
                    DET_DOCUMENTOBE.IGV_DIMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_DVENTA * 18) / 100, 2)
                Else
                    DET_DOCUMENTOBE.IGV_IMPOR = 0
                    DET_DOCUMENTOBE.IGV_DIMPOR = 0
                End If


            ElseIf LETRASBE.MONEDA = "01" Then
                DET_DOCUMENTOBE.UPRECIO_DVENTA = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DVENTA").Value)), 0, RTrim(row.Cells("UPRECIO_DVENTA").Value)))
                DET_DOCUMENTOBE.UPRECIO_VENTA = DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.T_CAMB
                DET_DOCUMENTOBE.TPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD, 2)
                DET_DOCUMENTOBE.TPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD * DET_DOCUMENTOBE.T_CAMB, 2)
                If LETRASBE.T_IGV > 0 Then
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
            DET_DOCUMENTOBE.FEC_ENT = IIf(IsDBNull(RTrim(row.Cells("FEC_ENT").Value)), "", RTrim(row.Cells("FEC_ENT").Value))
            DET_DOCUMENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR").Value)), "", RTrim(row.Cells("PROVEEDOR").Value))

            DET_DOCUMENTOBE.EST = IIf(IsDBNull(RTrim(row.Cells("EST").Value)), "", RTrim(row.Cells("EST").Value))
            'If LETRASBE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 And LETRASBE.T_DOC_REF = DET_DOCUMENTOBE.T_DOC_REF1 Then
            '    DET_DOCUMENTOBE.NRO_DOC_REF1 = LETRASBE.NRO_DOC_REF & "-" & cont
            'End If
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Mid(DET_DOCUMENTOBE.NRO_DOC_REF1, 1, 7) & "-" & cont
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = LETRASBE.CTCT_COD
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = LETRASBE.EST
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = "-"
            cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
            cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(LETRASBE.T_MOVINV)
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
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = LETRASBE.MONEDA
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = LETRASBE.FEC_GENE
            cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_DIA
            cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = "20100279348"
            cmd.Parameters.Add("@FEC_ENT", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
        'ACTUALIZA CABECERA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDTOTALESGD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.NRO_DOC_REF
        cmd.Parameters.Add("@TPRECIO_VENTA", OracleDbType.Double).Value = DAcumula3
        cmd.Parameters.Add("@TPRECIO_DVENTA", OracleDbType.Double).Value = DAcumula2
        cmd.Parameters.Add("@T_IGV", OracleDbType.Double).Value = DAcumula4
        cmd.Parameters.Add("@T_IGV_DOLAR", OracleDbType.Double).Value = DAcumula5
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'ELIMINAR DE LA TABLA LETRA MONTOS
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCUMENTO_DEL_MON"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = LETRASBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        For Each row As DataGridViewRow In dgmontos.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_LETRAMON_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBLETRAS_MONTOBE.t_doc_ref = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            ELTBLETRAS_MONTOBE.ser_doc_ref = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            ELTBLETRAS_MONTOBE.nro_doc_ref = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            ELTBLETRAS_MONTOBE.t_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELTBLETRAS_MONTOBE.ser_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELTBLETRAS_MONTOBE.nro_doc_ref1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELTBLETRAS_MONTOBE.proveedor = IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR").Value)), "", RTrim(row.Cells("PROVEEDOR").Value))
            ELTBLETRAS_MONTOBE.montos = IIf(IsDBNull(RTrim(row.Cells("MONTOS").Value)), 0, RTrim(row.Cells("MONTOS").Value))
            ELTBLETRAS_MONTOBE.montod = IIf(IsDBNull(RTrim(row.Cells("MONTOD").Value)), 0, RTrim(row.Cells("MONTOD").Value))
            ELTBLETRAS_MONTOBE.moneda = IIf(IsDBNull(RTrim(row.Cells("MONEDA").Value)), "", RTrim(row.Cells("MONEDA").Value))
            ELTBLETRAS_MONTOBE.montos_fact = IIf(IsDBNull(RTrim(row.Cells("MONTO_FACTURA").Value)), 0, RTrim(row.Cells("MONTO_FACTURA").Value))
            ELTBLETRAS_MONTOBE.montod_fact = IIf(IsDBNull(RTrim(row.Cells("MONTO_FACTURAD").Value)), 0, RTrim(row.Cells("MONTO_FACTURAD").Value))
            'ELTBLETRAS_MONTOBE.t_cmb = IIf(IsDBNull(RTrim(row.Cells("T_CMB").Value)), 0, RTrim(row.Cells("T_CMB").Value))

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.t_doc_ref
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.ser_doc_ref
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.nro_doc_ref
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.t_doc_ref1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.ser_doc_ref1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.nro_doc_ref1
            cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.proveedor
            If LETRASBE.MONEDA = "01" Then
                If ELTBLETRAS_MONTOBE.t_doc_ref <> "07" Then
                    cmd.Parameters.Add("@montos", OracleDbType.Double).Value = Math.Round(LETRASBE.T_CAMB * ELTBLETRAS_MONTOBE.montod, 2)
                    cmd.Parameters.Add("@montod", OracleDbType.Double).Value = ELTBLETRAS_MONTOBE.montod
                End If
            Else
                If ELTBLETRAS_MONTOBE.t_doc_ref <> "07" Then
                    cmd.Parameters.Add("@montos", OracleDbType.Double).Value = ELTBLETRAS_MONTOBE.montos
                    cmd.Parameters.Add("@montod", OracleDbType.Double).Value = 0
                End If
            End If
                cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.moneda
            If ELTBLETRAS_MONTOBE.moneda = "01" Then
                cmd.Parameters.Add("@montos_fact", OracleDbType.Double).Value = Math.Round(LETRASBE.T_CAMB * ELTBLETRAS_MONTOBE.montod_fact, 2)
                cmd.Parameters.Add("@montod_fact", OracleDbType.Double).Value = ELTBLETRAS_MONTOBE.montod_fact
            Else
                cmd.Parameters.Add("@montos_fact", OracleDbType.Double).Value = ELTBLETRAS_MONTOBE.montos_fact
                cmd.Parameters.Add("@montod_fact", OracleDbType.Double).Value = Math.Round(ELTBLETRAS_MONTOBE.montos_fact / LETRASBE.T_CAMB, 2)
            End If

            cmd.Parameters.Add("@t_cmb", OracleDbType.Double).Value = Trim(LETRASBE.T_CAMB)
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = LETRASBE.FEC_GENE
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el Documento: " + LETRASBE.T_DOC_REF + "-" + LETRASBE.SER_DOC_REF + "-" + LETRASBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRowLetra(ByVal LETRASBE As LETRASBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPD_LT_EXC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Limpio Excel de las LT: " + LETRASBE.T_DOC_REF + "-" + LETRASBE.SER_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRowAnularFC(ByVal LETRASBE As LETRASBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDATEROW_ANUFC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(LETRASBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(LETRASBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(LETRASBE.NRO_DOC_REF)
        cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = "A"
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCU_UPD_ANULAR_FC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(LETRASBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(LETRASBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(LETRASBE.NRO_DOC_REF)
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
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Anulo la FC: " + LETRASBE.T_DOC_REF + "-" + LETRASBE.SER_DOC_REF + "-" + LETRASBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Public Function SaveRow(ByVal LETRASBE As LETRASBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal flagAccion As String, ByVal dg As DataGridView, ByVal dgmontos As DataGridView, ByVal ELTBLETRAS_MONTOBE As ELTBLETRAS_MONTOBE) As String
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
                InsertRow(LETRASBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg, dgmontos, ELTBLETRAS_MONTOBE)
                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                UpdateRow(LETRASBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg, dgmontos, ELTBLETRAS_MONTOBE)
            End If
            If flagAccion = "AR" Then
                UpdateRowAnularFC(LETRASBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "UL" Then
                UpdateRowLetra(LETRASBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg)
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
            '    cn.Dispose()
            'End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function

    Public Function SaveRow1(ByVal LETRASBE As LETRASBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal flagAccion As String, ByVal dg As DataGridView, ByVal dgmontos As DataGridView, ByVal dgdet As DataGridView,
                            ByVal ELTBLETRAS_MONTOBE As ELTBLETRAS_MONTOBE) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction
        Try
            'N:Nuevo   M:Modificar   E:Eliminar 
            If flagAccion = "FL" Then
                InsertRowFL(LETRASBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg, dgmontos, dgdet, ELTBLETRAS_MONTOBE)
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

    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DET_DOCUMENTO_SELECTROW_GD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getListLT(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DET_DOCUMENTO_SELECTROW_LT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getListdgvmonto(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DET_DOCUMENTO_SELECTROW_MON", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function getListdgv2(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DET_DOCUMENTO_SELLT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function getListdgvletras() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_TXTLT", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAll(ByVal sT_doc As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SEL_ALL_LETRA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectNro1(ByVal sCode As String, ByVal sSer As String) As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELECTNRO3", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode)),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sSer))})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero

    End Function
    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SelectRow_LT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRowLetra(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBLETRA_MONTOSELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
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

    Public Function SelectCantDias(ByVal sCod As String) As Integer
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        ' Dim dt As New DataTable
        Try
            Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_CANT_D", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", sCod)})
                If dr.Read Then
                    sNomArt = dr.GetInt32(0)
                End If
            End Using
            Return sNomArt
        Catch ex As Exception

        End Try

#Disable Warning BC42353 ' La función 'SelectCantDias' no devuelve un valor en todas las rutas de acceso de código. ¿Falta alguna instrucción 'Return'?
    End Function
#Enable Warning BC42353 ' La función 'SelectCantDias' no devuelve un valor en todas las rutas de acceso de código. ¿Falta alguna instrucción 'Return'?

    Function list3(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
               ByVal fec As Date) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SEARCH3", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", fec)})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt

    End Function
    Function list2(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SEARCH8", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt

    End Function
    Function list1(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
               ByVal fec As Date) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SEARCH9", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", fec)})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt

    End Function

    Public Function AsientoFC(ByVal flagAccion As String, ByVal sAño As String, ByVal sMes As String, ByVal sNro As String, ByVal sSer As String, ByVal sTipo As String, ByVal sEst As String, ByVal dg As DataGridView) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try

            If flagAccion = "Asiento" Then
                Asiento(cn, sqlTrans, sAño, sMes, sNro, sSer, sTipo, sEst, dg)
            End If
            'If flagAccion = "AS" Then
            '    Asiento_Todo(cn, sqlTrans, sAño, sMes, sNro, sSer, sTipo, sEst, dg)
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
            '   cn.Dispose()
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Public Sub Asiento(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sAño As String, ByVal sMes As String, ByVal sNro As String, ByVal sSer As String, ByVal sTipo As String, ByVal sEst As String,
                       ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CONTLETRAS_C2_PR"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sAño", OracleDbType.Varchar2).Value = Trim(sAño)
        cmd.Parameters.Add("@sMes", OracleDbType.Varchar2).Value = Trim(sMes)
        cmd.Parameters.Add("@sNro", OracleDbType.Varchar2).Value = sNro
        cmd.Parameters.Add("@sSer", OracleDbType.Varchar2).Value = sSer
        cmd.Parameters.Add("@sTipo", OracleDbType.Varchar2).Value = sTipo
        cmd.Parameters.Add("@sEst", OracleDbType.Varchar2).Value = sEst
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    'Public Sub Asiento_Todo(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
    '                      ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sAño As String, ByVal sMes As String, ByVal sNro As String, ByVal sSer As String, ByVal sTipo As String, ByVal sEst As String,
    '                   ByVal dg As DataGridView)
    '    Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
    '    For Each row As DataGridViewRow In dg.Rows
    '        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand

    '        cmd.CommandText = "SP_CONTNUVOSOLES_C2_PR"
    '        cmd.Connection = sqlCon
    '        cmd.Transaction = sqlTrans
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Parameters.Add("@sAño", OracleDbType.Varchar2).Value = Trim(sAño)
    '        cmd.Parameters.Add("@sMes", OracleDbType.Varchar2).Value = Trim(sMes)
    '        cmd.Parameters.Add("@sNro", OracleDbType.Varchar2).Value = sNro
    '        cmd.Parameters.Add("@sSer", OracleDbType.Varchar2).Value = sSer
    '        cmd.Parameters.Add("@sTipo", OracleDbType.Varchar2).Value = sTipo
    '        cmd.Parameters.Add("@sEst", OracleDbType.Varchar2).Value = sEst
    '        cmd.ExecuteNonQuery()
    '        cmd.Dispose()
    '    Next

    'End Sub

    Public Function SelectRegVen(ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_REGISTRO_VENTAS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRegVenAll(ByVal sAño As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_REGISTRO_LETRAS_ALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SaveRowAllMes(ByVal flagAccion As String, ByVal sAño As String, ByVal sMes As String, ByVal dg As DataGridView) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try

            If flagAccion = "UPD" Then
                UpdReg(cn, sAño, sMes, sqlTrans, dg)
            End If
            If flagAccion = "AsAll" Then
                AsientoAll(cn, sAño, sMes, sqlTrans, dg)
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
            '   cn.Dispose()
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function

    Public Function SaveRowEst(ByVal LETRASBE As LETRASBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                           ByVal flagAccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try

            If flagAccion = "ACTEST" Then
                ActReg(cn, LETRASBE, ELMVLOGSBE, sqlTrans)
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
            '   cn.Dispose()
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Public Function SaveRowEst1(ByVal LETRASBE As LETRASBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
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

            If flagAccion = "ACTEST1" Then
                ActReg1(cn, LETRASBE, ELMVLOGSBE, sqlTrans, dg)
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
            '   cn.Dispose()
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Public Sub ActReg(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal LETRASBE As LETRASBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                        ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd.CommandText = "SP_DOCUMENTO_UPD_ESTLT"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sT_DOC_REF", OracleDbType.Varchar2).Value = LETRASBE.T_DOC_REF
        cmd.Parameters.Add("@sSER_DOC_REF", OracleDbType.Varchar2).Value = LETRASBE.SER_DOC_REF
        cmd.Parameters.Add("@sNRO_DOC_REF", OracleDbType.Varchar2).Value = LETRASBE.NRO_DOC_REF
        cmd.Parameters.Add("@sX_D", OracleDbType.Varchar2).Value = LETRASBE.X_D
        cmd.Parameters.Add("@sBINTERES", OracleDbType.Varchar2).Value = LETRASBE.BINTERES
        cmd.Parameters.Add("@sEST1", OracleDbType.Varchar2).Value = LETRASBE.EST1
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el Documento: " + LETRASBE.T_DOC_REF + "-" + LETRASBE.SER_DOC_REF + "-" + LETRASBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Sub ActReg1(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal LETRASBE As LETRASBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                        ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        'modificar
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DOCUMENTO_UPD_ESTLT"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@sT_DOC_REF", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value)) 'LETRASBE.T_DOC_REF
            cmd.Parameters.Add("@sSER_DOC_REF", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            cmd.Parameters.Add("@sNRO_DOC_REF", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value)) 'LETRASBE.NRO_DOC_REF
            cmd.Parameters.Add("@sX_D", OracleDbType.Varchar2).Value = LETRASBE.X_D
            cmd.Parameters.Add("@sBINTERES", OracleDbType.Varchar2).Value = LETRASBE.BINTERES
            cmd.Parameters.Add("@sEST1", OracleDbType.Varchar2).Value = LETRASBE.EST1
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el Documento: " + LETRASBE.T_DOC_REF + "-" + LETRASBE.SER_DOC_REF + "-" + LETRASBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Sub UpdReg(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sAño As String, ByVal sMes As String,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                      ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_REGLETRA_UPDASIENTO"
        'cmd.CommandText = "SP_REGLETRA_UPDASIENTO_PRB"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sAño", OracleDbType.Varchar2).Value = Trim(sAño)
        cmd.Parameters.Add("@sMes", OracleDbType.Varchar2).Value = Trim(sMes)

        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Public Sub AsientoAll(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sAño As String, ByVal sMes As String,
                        ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                     ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_CONTLETRAS_C2_PR"
            'cmd.CommandText = "SP_CONTLETRAS_C2_PRUEBA"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@sAño", OracleDbType.Varchar2).Value = Trim(sAño)
            cmd.Parameters.Add("@sMes", OracleDbType.Varchar2).Value = Trim(sMes)
            cmd.Parameters.Add("@sNro", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            cmd.Parameters.Add("@sSer", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            cmd.Parameters.Add("@sTipo", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            cmd.Parameters.Add("@sEst", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("EST").Value)), "", RTrim(row.Cells("EST").Value))
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        Next

    End Sub
    Public Function SelectEstRecogido(ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SELALL_LT_ESTREC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class

