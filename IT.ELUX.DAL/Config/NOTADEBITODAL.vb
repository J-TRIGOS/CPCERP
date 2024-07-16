Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class NOTADEBITODAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    Inherits BaseDatosORACLE
    Public sNumero As String
    Public sPrueba As String
    Public sNumero1 As Double

    'Metodo para registrar un nuevo 
    Private Sub InsertRow(ByVal NOTADEBITOBE As NOTADEBITOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        'Dim contenedor As String
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_INSERTROW_ND"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = NOTADEBITOBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = NOTADEBITOBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = NOTADEBITOBE.NRO_DOC_REF
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = NOTADEBITOBE.ART_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = NOTADEBITOBE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = NOTADEBITOBE.EST
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = NOTADEBITOBE.MONEDA
        cmd.Parameters.Add("@tprecio_venta", OracleDbType.Double).Value = NOTADEBITOBE.TPRECIO_VENTA
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = NOTADEBITOBE.FEC_ANU
        cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = NOTADEBITOBE.SIGNO
        cmd.Parameters.Add("@tprecio_dventa", OracleDbType.Double).Value = NOTADEBITOBE.TPRECIO_DVENTA
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = NOTADEBITOBE.USUARIO
        cmd.Parameters.Add("@observa", OracleDbType.Char).Value = NOTADEBITOBE.OBSERVA
        cmd.Parameters.Add("@t_movinv", OracleDbType.Char).Value = NOTADEBITOBE.T_MOVINV
        cmd.Parameters.Add("@t_igv", OracleDbType.Double).Value = NOTADEBITOBE.T_IGV
        cmd.Parameters.Add("@t_igv_dolar", OracleDbType.Double).Value = NOTADEBITOBE.T_IGV_DOLAR
        cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = NOTADEBITOBE.F_PAGO_ENT
        cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = NOTADEBITOBE.FOR_ENT_COD
        cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = NOTADEBITOBE.PROVEEDOR
        cmd.Parameters.Add("@FEC_PROV", OracleDbType.Date).Value = NOTADEBITOBE.FEC_PROV
        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = NOTADEBITOBE.CTCT_COD
        cmd.Parameters.Add("@vendedor", OracleDbType.Varchar2).Value = NOTADEBITOBE.VENDEDOR
        cmd.Parameters.Add("@dir_cod", OracleDbType.Varchar2).Value = NOTADEBITOBE.DIR_COD
        cmd.Parameters.Add("@NUMPEDIDO", OracleDbType.Varchar2).Value = NOTADEBITOBE.NUMPEDIDO
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = NOTADEBITOBE.FEC_DIA
        'cmd.Parameters.Add("@REG_NRO", OracleDbType.Varchar2).Value = NOTADEBITOBE.REG_NRO
        'cmd.Parameters.Add("@X_RET", OracleDbType.Varchar2).Value = NOTADEBITOBE.X_RET
        cmd.Parameters.Add("@MOT_COD", OracleDbType.Varchar2).Value = NOTADEBITOBE.MOT_COD
        cmd.Parameters.Add("@NOM_CTCT", OracleDbType.Varchar2).Value = NOTADEBITOBE.NOM_CTCT
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INSFC"
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
            'DET_DOCUMENTOBE.UPRECIO_VENTA = IIf(IsDBNull(RTrim(row.Cells("UPRECIO_VENTA").Value)), "", RTrim(row.Cells("UPRECIO_VENTA").Value))
            'DET_DOCUMENTOBE.UPRECIO_DVENTA = IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DVENTA").Value)), "", RTrim(row.Cells("UPRECIO_DVENTA").Value))
            DET_DOCUMENTOBE.IGV = IIf(IsDBNull(RTrim(row.Cells("IGV").Value)), "", RTrim(row.Cells("IGV").Value))
            DET_DOCUMENTOBE.T_CAMB = IIf(IsDBNull(RTrim(row.Cells("T_CAMB").Value)), "", RTrim(row.Cells("T_CAMB").Value))
            'DET_DOCUMENTOBE.TPRECIO_VENTA = (DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD) * (DET_DOCUMENTOBE.IGV / 100) + DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD
            'DET_DOCUMENTOBE.TPRECIO_DVENTA = ((DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD) * (DET_DOCUMENTOBE.IGV / 100) + DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD) / DET_DOCUMENTOBE.T_CAMB
            If NOTADEBITOBE.MONEDA = "00" Then
                DET_DOCUMENTOBE.UPRECIO_VENTA = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_VENTA").Value)), 0, RTrim(row.Cells("UPRECIO_VENTA").Value)))
                DET_DOCUMENTOBE.UPRECIO_DVENTA = DET_DOCUMENTOBE.UPRECIO_VENTA / DET_DOCUMENTOBE.T_CAMB
                DET_DOCUMENTOBE.TPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD, 2)
                DET_DOCUMENTOBE.TPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD / DET_DOCUMENTOBE.T_CAMB, 2)
                If NOTADEBITOBE.T_IGV > 0 Then
                    DET_DOCUMENTOBE.IGV_IMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_VENTA * 18) / 100, 2)
                    DET_DOCUMENTOBE.IGV_DIMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_DVENTA * 18) / 100, 2)
                Else
                    DET_DOCUMENTOBE.IGV_IMPOR = 0
                    DET_DOCUMENTOBE.IGV_DIMPOR = 0
                End If
            ElseIf NOTADEBITOBE.MONEDA = "01" Then
                DET_DOCUMENTOBE.UPRECIO_DVENTA = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DVENTA").Value)), 0, RTrim(row.Cells("UPRECIO_DVENTA").Value)))
                DET_DOCUMENTOBE.UPRECIO_VENTA = DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.T_CAMB
                DET_DOCUMENTOBE.TPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD, 2)
                DET_DOCUMENTOBE.TPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD * DET_DOCUMENTOBE.T_CAMB, 2)
                If NOTADEBITOBE.T_IGV > 0 Then
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
            If NOTADEBITOBE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 And NOTADEBITOBE.T_DOC_REF = DET_DOCUMENTOBE.T_DOC_REF1 Then
                DET_DOCUMENTOBE.NRO_DOC_REF1 = NOTADEBITOBE.NRO_DOC_REF & "-" & cont
            End If
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = NOTADEBITOBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = NOTADEBITOBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = NOTADEBITOBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = NOTADEBITOBE.CTCT_COD
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = NOTADEBITOBE.EST
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = "-"
            cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
            cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(NOTADEBITOBE.T_MOVINV)
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
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = NOTADEBITOBE.MONEDA
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = NOTADEBITOBE.FEC_GENE
            cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_DIA
            cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = DET_DOCUMENTOBE.PROVEEDOR
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
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + NOTADEBITOBE.T_DOC_REF + "-" + NOTADEBITOBE.SER_DOC_REF + "-" + NOTADEBITOBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    'Metodo para Modificar 
    Private Sub UpdateRow(ByVal NOTADEBITOBE As NOTADEBITOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        'Dim contenedor As String
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDATEROW_ND"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = NOTADEBITOBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = NOTADEBITOBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = NOTADEBITOBE.NRO_DOC_REF
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = NOTADEBITOBE.ART_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = NOTADEBITOBE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = NOTADEBITOBE.EST
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = NOTADEBITOBE.MONEDA
        cmd.Parameters.Add("@tprecio_venta", OracleDbType.Double).Value = NOTADEBITOBE.TPRECIO_VENTA
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = NOTADEBITOBE.FEC_ANU
        cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = NOTADEBITOBE.SIGNO
        cmd.Parameters.Add("@tprecio_dventa", OracleDbType.Double).Value = NOTADEBITOBE.TPRECIO_DVENTA
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = NOTADEBITOBE.USUARIO
        cmd.Parameters.Add("@observa", OracleDbType.Char).Value = NOTADEBITOBE.OBSERVA
        cmd.Parameters.Add("@t_movinv", OracleDbType.Char).Value = NOTADEBITOBE.T_MOVINV
        cmd.Parameters.Add("@t_igv", OracleDbType.Double).Value = NOTADEBITOBE.T_IGV
        cmd.Parameters.Add("@t_igv_dolar", OracleDbType.Double).Value = NOTADEBITOBE.T_IGV_DOLAR
        cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = NOTADEBITOBE.F_PAGO_ENT
        cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = NOTADEBITOBE.FOR_ENT_COD
        cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = NOTADEBITOBE.PROVEEDOR
        cmd.Parameters.Add("@FEC_PROV", OracleDbType.Date).Value = NOTADEBITOBE.FEC_PROV
        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = NOTADEBITOBE.CTCT_COD
        cmd.Parameters.Add("@vendedor", OracleDbType.Varchar2).Value = NOTADEBITOBE.VENDEDOR
        cmd.Parameters.Add("@dir_cod", OracleDbType.Varchar2).Value = NOTADEBITOBE.DIR_COD
        cmd.Parameters.Add("@NUMPEDIDO", OracleDbType.Varchar2).Value = NOTADEBITOBE.NUMPEDIDO
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = NOTADEBITOBE.FEC_DIA
        'cmd.Parameters.Add("@X_RET", OracleDbType.Varchar2).Value = NOTADEBITOBE.X_RET
        cmd.Parameters.Add("@MOT_COD", OracleDbType.Varchar2).Value = NOTADEBITOBE.MOT_COD
        cmd.Parameters.Add("@NOM_CTCT", OracleDbType.Varchar2).Value = NOTADEBITOBE.NOM_CTCT
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCUMENTO_DEL_FC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = NOTADEBITOBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = NOTADEBITOBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = NOTADEBITOBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INSFC"
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
            DET_DOCUMENTOBE.TPRECIO_VENTA = IIf(IsDBNull(RTrim(row.Cells("TPRECIO_VENTA").Value)), "", RTrim(row.Cells("TPRECIO_VENTA").Value))
            DET_DOCUMENTOBE.TPRECIO_DVENTA = IIf(IsDBNull(RTrim(row.Cells("TPRECIO_DVENTA").Value)), "", RTrim(row.Cells("TPRECIO_DVENTA").Value))
            'DET_DOCUMENTOBE.UPRECIO_VENTA = IIf(IsDBNull(RTrim(row.Cells("UPRECIO_VENTA").Value)), "", RTrim(row.Cells("UPRECIO_VENTA").Value))
            'DET_DOCUMENTOBE.UPRECIO_DVENTA = IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DVENTA").Value)), "", RTrim(row.Cells("UPRECIO_DVENTA").Value))
            DET_DOCUMENTOBE.IGV = IIf(IsDBNull(RTrim(row.Cells("IGV").Value)), "", RTrim(row.Cells("IGV").Value))
            DET_DOCUMENTOBE.IGV_IMPOR = IIf(IsDBNull(RTrim(row.Cells("IGV_IMPOR").Value)), "", RTrim(row.Cells("IGV_IMPOR").Value))
            DET_DOCUMENTOBE.IGV_DIMPOR = IIf(IsDBNull(RTrim(row.Cells("IGV_DIMPOR").Value)), "", RTrim(row.Cells("IGV_DIMPOR").Value))
            DET_DOCUMENTOBE.T_CAMB = IIf(IsDBNull(RTrim(row.Cells("T_CAMB").Value)), "", RTrim(row.Cells("T_CAMB").Value))
            If NOTADEBITOBE.MONEDA = "00" Then
                DET_DOCUMENTOBE.UPRECIO_VENTA = Math.Round(CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_VENTA").Value)), 0, RTrim(row.Cells("UPRECIO_VENTA").Value))), 2)
                DET_DOCUMENTOBE.UPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA / DET_DOCUMENTOBE.T_CAMB, 2)
                DET_DOCUMENTOBE.TPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD, 2)
                DET_DOCUMENTOBE.TPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD / DET_DOCUMENTOBE.T_CAMB, 2)
                DET_DOCUMENTOBE.IGV_IMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_VENTA * 18) / 100, 2)
                DET_DOCUMENTOBE.IGV_DIMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_DVENTA * 18) / 100, 2)

            ElseIf NOTADEBITOBE.MONEDA = "01" Then
                DET_DOCUMENTOBE.UPRECIO_DVENTA = Math.Round(CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DVENTA").Value)), 0, RTrim(row.Cells("UPRECIO_DVENTA").Value))), 2)
                DET_DOCUMENTOBE.UPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.T_CAMB, 2)
                DET_DOCUMENTOBE.TPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD, 2)
                DET_DOCUMENTOBE.TPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD * DET_DOCUMENTOBE.T_CAMB, 2)
                DET_DOCUMENTOBE.IGV_IMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_VENTA * 18) / 100, 2)
                DET_DOCUMENTOBE.IGV_DIMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_DVENTA * 18) / 100, 2)
            End If
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
            If NOTADEBITOBE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 And NOTADEBITOBE.T_DOC_REF = DET_DOCUMENTOBE.T_DOC_REF1 Then
                DET_DOCUMENTOBE.NRO_DOC_REF1 = NOTADEBITOBE.NRO_DOC_REF & "-" & cont
            End If
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = NOTADEBITOBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = NOTADEBITOBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = NOTADEBITOBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = NOTADEBITOBE.CTCT_COD
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = NOTADEBITOBE.EST
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = "-"
            cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
            cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(NOTADEBITOBE.T_MOVINV)
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
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = NOTADEBITOBE.MONEDA
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = NOTADEBITOBE.FEC_GENE
            cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_DIA
            cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = DET_DOCUMENTOBE.PROVEEDOR
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
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el Documento: " + NOTADEBITOBE.T_DOC_REF + "-" + NOTADEBITOBE.SER_DOC_REF + "-" + NOTADEBITOBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub UpdateRowAnularFC(ByVal NOTADEBITOBE As NOTADEBITOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDATEROW_ANUFC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(NOTADEBITOBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(NOTADEBITOBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(NOTADEBITOBE.NRO_DOC_REF)
        cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = "A"
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCU_UPD_ANULAR_FC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(NOTADEBITOBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(NOTADEBITOBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(NOTADEBITOBE.NRO_DOC_REF)
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
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Anulo la NC: " + NOTADEBITOBE.T_DOC_REF + "-" + NOTADEBITOBE.SER_DOC_REF + "-" + NOTADEBITOBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Public Function SaveRow(ByVal NOTADEBITOBE As NOTADEBITOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
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
                InsertRow(NOTADEBITOBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg)
                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                UpdateRow(NOTADEBITOBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "AR" Then
                UpdateRowAnularFC(NOTADEBITOBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg)
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

    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DET_DOCUMENTO_SELECTROW_NC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAll(ByVal sT_doc As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SELECTALL_FAC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
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
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SelectRow_FC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
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

    Public Function SelectMov_Mot(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_MOV_MOF", {New Oracle.ManagedDataAccess.Client.OracleParameter("@TIP_COD", sCod)})
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

    Public Function getTxtFc(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sEst As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_TXTND", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sT_doc)),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sN_doc)),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@pNRO_DOC_REF", Trim(sS_doc)),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@pEST", Trim(sEst))})
            While dr.Read
                sPrueba = dr.GetString(0)
            End While
        End Using
        Return sPrueba
    End Function

    Public Function getTxtFc1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sEst As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_TXTNDX", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sT_doc)),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sN_doc)),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@pNRO_DOC_REF", Trim(sS_doc)),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@pEST", Trim(sEst))})
            While dr.Read
                sPrueba = dr.GetString(0)
            End While
        End Using
        Return sPrueba
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
        cmd.CommandText = "SP_CONTNUVOSOLES_C2_PR"
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
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_REGISTRO_VENTAS_ALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño)})
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
    Public Sub UpdReg(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sAño As String, ByVal sMes As String,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                      ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_REGVENTA_UPDASIENTO"
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
            cmd.CommandText = "SP_CONTNUVOSOLES_C2_PR"
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
    Public Function SaveRowEst(ByVal NOTADEBITOBE As NOTADEBITOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
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
                ActReg(cn, NOTADEBITOBE, ELMVLOGSBE, sqlTrans)
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
    Public Sub ActReg(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal NOTADEBITOBE As NOTADEBITOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                        ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPD_EST"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sT_DOC_REF", OracleDbType.Varchar2).Value = NOTADEBITOBE.T_DOC_REF
        cmd.Parameters.Add("@sSER_DOC_REF", OracleDbType.Varchar2).Value = NOTADEBITOBE.SER_DOC_REF
        cmd.Parameters.Add("@sNRO_DOC_REF", OracleDbType.Varchar2).Value = NOTADEBITOBE.NRO_DOC_REF
        cmd.Parameters.Add("@sX_D", OracleDbType.Varchar2).Value = NOTADEBITOBE.X_D
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el Documento: " + NOTADEBITOBE.T_DOC_REF + "-" + NOTADEBITOBE.SER_DOC_REF + "-" + NOTADEBITOBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Function SelectEstRecogido(ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SELALL_ND_ESTREC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
