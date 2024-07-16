Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class GUIADESPACHODAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    Inherits BaseDatosORACLE
    Public sNumero As String
    Public sNumero1 As Double
    'Dim DAcumula As Double = 0
    'Dim DAcumula1 As Double = 0
    'Dim DAcumula2 As Double = 0
    'Dim DAcumula3 As Double = 0
    'Dim DAcumula4 As Double = 0
    'Dim DAcumula5 As Double = 0
    Private Sub UpdateRowActa(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView, ByVal tpaquete As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            If (cont < 2) Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_DET_DOCUMENTO_DEL_ACTA"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INS_ACTA"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            'cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = "" 'IIf(IsDBNull(RTrim(row.Cells("LOTE").Value)), "", RTrim(row.Cells("LOTE").Value))
            'cmd.Parameters.Add("@fec_prov", OracleDbType.Varchar2).Value = "" 'IIf(IsDBNull(RTrim(row.Cells("FEC_PROV").Value)), "", RTrim(row.Cells("FEC_PROV").Value))
            cmd.Parameters.Add("@n_bolsas", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("N_BOLSAS").Value)), "", RTrim(row.Cells("N_BOLSAS").Value))
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "0", RTrim(row.Cells("CANTIDAD").Value))
            cmd.Parameters.Add("@t_paquete", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("PAQUETE").Value)), "0", RTrim(row.Cells("PAQUETE").Value))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub
    Private Sub UpdateRowTot(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView, ByVal tpaquete As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim cont As Integer = 0
        Dim fec As Date
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            If (cont < 2) Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELMVALMA_2021TOTDEL"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
            fec = IIf(IsDBNull(RTrim(row.Cells("FEC_GENE").Value)), "", RTrim(row.Cells("FEC_GENE").Value))
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELMVALMA_2021TOTINS"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value))
            cmd.Parameters.Add("@T_MOVINV", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("T_MOVINV").Value)), "", RTrim(row.Cells("T_MOVINV").Value))
            cmd.Parameters.Add("@TRANS", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("TRANS").Value)), "", RTrim(row.Cells("TRANS").Value))
            cmd.Parameters.Add("@ANHO", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("ANHO").Value)), "", RTrim(row.Cells("ANHO").Value))
            cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = fec
            cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("ALM_COD").Value)), "", RTrim(row.Cells("ALM_COD").Value))
            cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("CTCT_COD").Value)), "", RTrim(row.Cells("CTCT_COD").Value))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub
    Private Sub UpdateRowTotArt(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView, ByVal tpaquete As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim cont As Integer = 0
        Dim fec As Date
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            If (cont < 2) Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELMVALMA_2021TOTDELART"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
                cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
            fec = IIf(IsDBNull(RTrim(row.Cells("FEC_GENE").Value)), "", RTrim(row.Cells("FEC_GENE").Value))
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELMVALMA_2021TOTUPD"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value))
            cmd.Parameters.Add("@T_MOVINV", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("T_MOVINV").Value)), "", RTrim(row.Cells("T_MOVINV").Value))
            cmd.Parameters.Add("@TRANS", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("TRANS").Value)), "", RTrim(row.Cells("TRANS").Value))
            cmd.Parameters.Add("@ANHO", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("ANHO").Value)), "", RTrim(row.Cells("ANHO").Value))
            cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = fec
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub
    Private Sub DeleteRowTot(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView, ByVal tpaquete As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            If (cont < 2) Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELMVALMA_2021TOTDEL"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
        Next
    End Sub
    Private Sub SaveRowActa(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView, ByVal tpaquete As String)
        Dim cont As Integer = 0
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INS_ACTA"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            'cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = "" 'IIf(IsDBNull(RTrim(row.Cells("LOTE").Value)), "", RTrim(row.Cells("LOTE").Value))
            'cmd.Parameters.Add("@fec_prov", OracleDbType.Varchar2).Value = "" 'IIf(IsDBNull(RTrim(row.Cells("FEC_PROV").Value)), "", RTrim(row.Cells("FEC_PROV").Value))
            cmd.Parameters.Add("@n_bolsas", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("N_BOLSAS").Value)), "", RTrim(row.Cells("N_BOLSAS").Value))
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "0", RTrim(row.Cells("CANTIDAD").Value))
            cmd.Parameters.Add("@t_paquete", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("PAQUETE").Value)), "0", RTrim(row.Cells("PAQUETE").Value))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub
    'Metodo para registrar un nuevo 
    Private Sub InsertRow(ByVal GUIADESPACHOBE As GUIADESPACHOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        'Dim contenedor As String
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_INSERTROW_GD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.NRO_DOC_REF
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = GUIADESPACHOBE.ART_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIADESPACHOBE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIADESPACHOBE.EST
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = GUIADESPACHOBE.MONEDA
        cmd.Parameters.Add("@tprecio_venta", OracleDbType.Double).Value = GUIADESPACHOBE.TPRECIO_VENTA
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = GUIADESPACHOBE.FEC_ANU
        cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = GUIADESPACHOBE.SIGNO
        cmd.Parameters.Add("@tprecio_dventa", OracleDbType.Double).Value = GUIADESPACHOBE.TPRECIO_DVENTA
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = GUIADESPACHOBE.USUARIO
        cmd.Parameters.Add("@observa", OracleDbType.Char).Value = GUIADESPACHOBE.OBSERVA
        cmd.Parameters.Add("@t_movinv", OracleDbType.Char).Value = GUIADESPACHOBE.T_MOVINV
        cmd.Parameters.Add("@t_igv", OracleDbType.Double).Value = GUIADESPACHOBE.T_IGV
        cmd.Parameters.Add("@t_igv_dolar", OracleDbType.Double).Value = GUIADESPACHOBE.T_IGV_DOLAR
        cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = GUIADESPACHOBE.F_PAGO_ENT
        cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = GUIADESPACHOBE.FOR_ENT_COD
        cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = GUIADESPACHOBE.PROVEEDOR
        cmd.Parameters.Add("@FEC_PROV", OracleDbType.Date).Value = GUIADESPACHOBE.FEC_PROV
        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = GUIADESPACHOBE.CTCT_COD
        cmd.Parameters.Add("@vendedor", OracleDbType.Varchar2).Value = GUIADESPACHOBE.VENDEDOR
        cmd.Parameters.Add("@dir_cod", OracleDbType.Varchar2).Value = GUIADESPACHOBE.DIR_COD
        cmd.Parameters.Add("@NUMPEDIDO", OracleDbType.Varchar2).Value = GUIADESPACHOBE.NUMPEDIDO
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIADESPACHOBE.FEC_DIA
        cmd.Parameters.Add("@CANAL", OracleDbType.Varchar2).Value = GUIADESPACHOBE.CANAL
        cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = GUIADESPACHOBE.ALM_COD
        cmd.Parameters.Add("@NOM_CTCT", OracleDbType.Varchar2).Value = GUIADESPACHOBE.NOM_CTCT
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INSGD"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            DET_DOCUMENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            DET_DOCUMENTOBE.NRO_DOCU1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU1").Value)), "", RTrim(row.Cells("NRO_DOCU1").Value))
            DET_DOCUMENTOBE.SERIE_SOLI = IIf(IsDBNull(RTrim(row.Cells("SERIE_SOLI").Value)), "", RTrim(row.Cells("SERIE_SOLI").Value))
            DET_DOCUMENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells("CTCT_COD").Value)), "", RTrim(row.Cells("CTCT_COD").Value))
            DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value))
            DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            DET_DOCUMENTOBE.OBSERVA = IIf(IsDBNull(RTrim(row.Cells("OBSERVA").Value)), "", RTrim(row.Cells("OBSERVA").Value))
            DET_DOCUMENTOBE.T_MOVINV = IIf(IsDBNull(RTrim(row.Cells("T_MOVINV").Value)), "", RTrim(row.Cells("T_MOVINV").Value))
            If IIf(IsDBNull(RTrim(row.Cells("PESO").Value)), 0, RTrim(row.Cells("PESO").Value)) = "" Then
                DET_DOCUMENTOBE.PESO = 0
            Else
                DET_DOCUMENTOBE.PESO = IIf(IsDBNull(RTrim(row.Cells("PESO").Value)), 0, RTrim(row.Cells("PESO").Value))
            End If
            If IIf(IsDBNull(RTrim(row.Cells("FEC_ENT").Value)), "", RTrim(row.Cells("FEC_ENT").Value)) <> "" Then
                DET_DOCUMENTOBE.FEC_ENT = IIf(IsDBNull(RTrim(row.Cells("FEC_ENT").Value)), "", RTrim(row.Cells("FEC_ENT").Value))
            End If

            'DET_DOCUMENTOBE.UPRECIO_VENTA = IIf(String.IsNullOrEmpty(RTrim(row.Cells("UPRECIO_VENTA").Value)), 0, row.Cells("UPRECIO_VENTA").Value)
            'DET_DOCUMENTOBE.UPRECIO_DVENTA = IIf(String.IsNullOrEmpty(RTrim(row.Cells("UPRECIO_DVENTA").Value)), 0, Format(row.Cells("UPRECIO_DVENTA").Value, “##,##0.00”))
            DET_DOCUMENTOBE.IGV = IIf(String.IsNullOrEmpty(RTrim(row.Cells("IGV").Value)), 0, RTrim(row.Cells("IGV").Value))
            'DET_DOCUMENTOBE.IGV_IMPOR = IIf(String.IsNullOrEmpty(RTrim(row.Cells("IGV_IMPOR").Value)), 0, RTrim(row.Cells("IGV_IMPOR").Value))
            'DET_DOCUMENTOBE.IGV_DIMPOR = IIf(String.IsNullOrEmpty(RTrim(row.Cells("IGV_DIMPOR").Value)), 0, RTrim(row.Cells("IGV_DIMPOR").Value))
            DET_DOCUMENTOBE.T_CAMB = IIf(String.IsNullOrEmpty(RTrim(row.Cells("T_CAMB").Value)), 0, RTrim(row.Cells("T_CAMB").Value))
            DET_DOCUMENTOBE.CANTIDAD5 = cont

            'DET_DOCUMENTOBE.TPRECIO_VENTA = DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD
            'DET_DOCUMENTOBE.TPRECIO_DVENTA = DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD
            'DET_DOCUMENTOBE.IGV_IMPOR = (DET_DOCUMENTOBE.TPRECIO_VENTA * 18) / 100
            'DET_DOCUMENTOBE.IGV_DIMPOR = (DET_DOCUMENTOBE.TPRECIO_DVENTA * 18) / 100
            If GUIADESPACHOBE.MONEDA = "00" Then
                DET_DOCUMENTOBE.UPRECIO_VENTA = Math.Round(CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_VENTA").Value)), 0, RTrim(row.Cells("UPRECIO_VENTA").Value))), 2)
                DET_DOCUMENTOBE.UPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA / DET_DOCUMENTOBE.T_CAMB, 2)
                DET_DOCUMENTOBE.TPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD, 2)
                DET_DOCUMENTOBE.TPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD / DET_DOCUMENTOBE.T_CAMB, 2)
                If GUIADESPACHOBE.T_IGV > 0 Then
                    DET_DOCUMENTOBE.IGV_IMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_VENTA * 18) / 100, 2)
                    DET_DOCUMENTOBE.IGV_DIMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_DVENTA * 18) / 100, 2)
                Else
                    DET_DOCUMENTOBE.IGV_IMPOR = 0
                    DET_DOCUMENTOBE.IGV_DIMPOR = 0
                End If

            ElseIf GUIADESPACHOBE.MONEDA = "01" Then
                DET_DOCUMENTOBE.UPRECIO_DVENTA = Math.Round(CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DVENTA").Value)), 0, RTrim(row.Cells("UPRECIO_DVENTA").Value))), 2)
                DET_DOCUMENTOBE.UPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.T_CAMB, 2)
                DET_DOCUMENTOBE.TPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD, 2)
                DET_DOCUMENTOBE.TPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD * DET_DOCUMENTOBE.T_CAMB, 2)
                If GUIADESPACHOBE.T_IGV > 0 Then
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
            'AGREGADO PARA TRANSFERENCIA
            DET_DOCUMENTOBE.REPROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("REPROVEEDOR").Value)), "", RTrim(row.Cells("REPROVEEDOR").Value))
            DET_DOCUMENTOBE.RETRANSPORTISTA = IIf(IsDBNull(RTrim(row.Cells("RETRANSPORTISTA").Value)), "", RTrim(row.Cells("RETRANSPORTISTA").Value))
            DET_DOCUMENTOBE.MARCA1 = IIf(IsDBNull(RTrim(row.Cells("MARCA1").Value)), "", RTrim(row.Cells("MARCA1").Value))

            DET_DOCUMENTOBE.EST = IIf(IsDBNull(RTrim(row.Cells("EST").Value)), "", RTrim(row.Cells("EST").Value))
            If GUIADESPACHOBE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 And GUIADESPACHOBE.T_DOC_REF = DET_DOCUMENTOBE.T_DOC_REF1 Then
                DET_DOCUMENTOBE.NRO_DOC_REF1 = GUIADESPACHOBE.NRO_DOC_REF & "-" & cont
            End If
            DET_DOCUMENTOBE.TRANSP_COD = IIf(IsDBNull(RTrim(row.Cells("TRANSP_COD").Value)), "", RTrim(row.Cells("TRANSP_COD").Value))
            DET_DOCUMENTOBE.CHOFER = IIf(IsDBNull(RTrim(row.Cells("CHOFER").Value)), "", RTrim(row.Cells("CHOFER").Value))
            'DET_DOCUMENTOBE.BREVETE = IIf(IsDBNull(RTrim(row.Cells("BREVETE").Value)), "", RTrim(row.Cells("BREVETE").Value))
            'DET_DOCUMENTOBE.PLACA = IIf(IsDBNull(RTrim(row.Cells("PLACA").Value)), "", RTrim(row.Cells("PLACA").Value))
            'DET_DOCUMENTOBE.MARCA = IIf(IsDBNull(RTrim(row.Cells("MARCA").Value)), "", RTrim(row.Cells("MARCA").Value))
            DET_DOCUMENTOBE.CONFIGURACION = IIf(IsDBNull(RTrim(row.Cells("CONFIGURACION").Value)), "", RTrim(row.Cells("CONFIGURACION").Value))
            'DET_DOCUMENTOBE.CERTIFICADO = IIf(IsDBNull(RTrim(row.Cells("CERTIFICADO").Value)), "", RTrim(row.Cells("CERTIFICADO").Value))
            DET_DOCUMENTOBE.TIPO_UNIDAD = IIf(IsDBNull(RTrim(row.Cells("TIPO_UNIDAD").Value)), "", RTrim(row.Cells("TIPO_UNIDAD").Value))
            DET_DOCUMENTOBE.COLOR = IIf(IsDBNull(RTrim(row.Cells("COLOR").Value)), "", RTrim(row.Cells("COLOR").Value))
            'DET_DOCUMENTOBE.NRO_DOCU2 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU2").Value)), "", RTrim(row.Cells("NRO_DOCU2").Value))
            DET_DOCUMENTOBE.ALM_COD = IIf(IsDBNull(RTrim(row.Cells("ALM_COD").Value)), "0001", RTrim(row.Cells("ALM_COD").Value))

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@correlativo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CANTIDAD5
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Mid(DET_DOCUMENTOBE.NRO_DOC_REF1, 1, 7) & "-" & cont
            cmd.Parameters.Add("@serie_soli", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SERIE_SOLI
            cmd.Parameters.Add("@nro_docu1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOCU1
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = GUIADESPACHOBE.CTCT_COD
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIADESPACHOBE.EST
            cmd.Parameters.Add("@alm_cod,", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ALM_COD
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = "-"
            cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
            cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(GUIADESPACHOBE.T_MOVINV)
            cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
            cmd.Parameters.Add("@TPRECIO_VENTA", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.TPRECIO_VENTA)
            cmd.Parameters.Add("@TPRECIO_dVENTA", OracleDbType.Double).Value = DET_DOCUMENTOBE.TPRECIO_DVENTA
            cmd.Parameters.Add("@igv", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.IGV)
            cmd.Parameters.Add("@IGV_IMPOR", OracleDbType.Double).Value = DET_DOCUMENTOBE.IGV_IMPOR
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
            cmd.Parameters.Add("@t_camb", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.T_CAMB)
            cmd.Parameters.Add("@UPRECIO_VENTA", OracleDbType.Double).Value = DET_DOCUMENTOBE.UPRECIO_VENTA
            cmd.Parameters.Add("@UPRECIO_dVENTA", OracleDbType.Double).Value = DET_DOCUMENTOBE.UPRECIO_DVENTA
            cmd.Parameters.Add("@IGV_DIMPOR", OracleDbType.Double).Value = DET_DOCUMENTOBE.IGV_DIMPOR
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = GUIADESPACHOBE.MONEDA
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_GENE
            cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_DIA
            cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PROVEEDOR
            cmd.Parameters.Add("@transp_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.TRANSP_COD
            cmd.Parameters.Add("@chofer", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CHOFER
            cmd.Parameters.Add("@brevete", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.BREVETE
            cmd.Parameters.Add("@placa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PLACA
            cmd.Parameters.Add("@marca", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.MARCA
            cmd.Parameters.Add("@configuracion", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CONFIGURACION
            cmd.Parameters.Add("@certificado", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CERTIFICADO
            cmd.Parameters.Add("@tipo_unidad", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.TIPO_UNIDAD
            cmd.Parameters.Add("@serie_transp", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.COLOR
            cmd.Parameters.Add("@nro_transp", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOCU2
            cmd.Parameters.Add("@peso", OracleDbType.Double).Value = DET_DOCUMENTOBE.PESO
            cmd.Parameters.Add("@REPROVEEDOR", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.REPROVEEDOR
            cmd.Parameters.Add("@RETRANSPORTISTA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.RETRANSPORTISTA
            cmd.Parameters.Add("@MARCA1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.MARCA1

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            Dim almacen As String = ""
            Dim almacen1 As String = ""
            If GUIADESPACHOBE.T_MOVINV <> "S32" And GUIADESPACHOBE.T_MOVINV <> "S36" And
                GUIADESPACHOBE.T_MOVINV <> "S38" And GUIADESPACHOBE.T_MOVINV <> "E28" Then
                If GUIADESPACHOBE.T_MOVINV = "S31" Then
                    If GUIADESPACHOBE.SER_DOC_REF = "001" Then
                        almacen = "0001"
                    ElseIf GUIADESPACHOBE.SER_DOC_REF = "003" Then
                        almacen = "0002"
                    ElseIf GUIADESPACHOBE.SER_DOC_REF = "004" Then
                        almacen = "0003"
                    End If
                    If GUIADESPACHOBE.CANAL = "0001" Then
                        almacen1 = "0001"
                    ElseIf GUIADESPACHOBE.CANAL = "0002" Then
                        almacen1 = "0002"
                    ElseIf GUIADESPACHOBE.CANAL = "0003" Then
                        almacen1 = "0003"
                    End If
                    'RESTA STOCK PARA DESPACHO
                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ARTICULO_UPDATESTKRES"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = almacen
                    cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    'RESTA STOCK PARA DESPACHO
                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ARTICULO_UPDATESTKSUM"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = almacen1
                    cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    'INSERTAR MOVIEMIENTO ALMACEN
                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ELMVALMAANHO_INS"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF)             '0
                    cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)         '1
                    cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = GUIADESPACHOBE.NRO_DOC_REF                '2
                    cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = "S"                                        '3
                    cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = almacen                                        '4
                    cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)                  '5
                    cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT                            '6
                    cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)                    '7
                    cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD                         '8
                    cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIADESPACHOBE.EST                             '9
                    cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = GUIADESPACHOBE.USUARIO                         '10
                    cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = GUIADESPACHOBE.T_MOVINV                        '11
                    cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)           '12
                    cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)       '13
                    cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)       '14
                    cmd.Parameters.Add("@MOV_CCO_COD", OracleDbType.Varchar2).Value = ""  'Trim(DET_DOCUMENTOBE.CCO_COD)            '15
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    'INSERTAR MOVIEMIENTO ALMACEN DEL SEGUNDO ALMACEN
                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ELMVALMAANHO_INS"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF)              '0
                    cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)          '1
                    cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = GUIADESPACHOBE.NRO_DOC_REF                 '2
                    cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = "E"                                         '3
                    cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = almacen1                                        '4
                    cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)                   '5
                    cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT                             '6
                    cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)                     '7
                    cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD                          '8
                    cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIADESPACHOBE.EST                              '9
                    cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO                         '10
                    cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = "E22"                                           '11
                    cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)            '12
                    cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)        '13
                    cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)        '14
                    cmd.Parameters.Add("@MOV_CCO_COD", OracleDbType.Varchar2).Value = "" 'Trim(DET_DOCUMENTOBE.CCO_COD)              '15
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                Else
                    'RESTA STOCK PARA DESPACHO
                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ARTICULO_UPDATESTKRES"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = GUIADESPACHOBE.ALM_COD
                    cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    'INSERTAR MOVIEMIENTO ALMACEN
                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ELMVALMAANHO_INS"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF)                '0
                    cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)            '1
                    cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = GUIADESPACHOBE.NRO_DOC_REF                   '2
                    cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = "S"                                           '3
                    cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = GUIADESPACHOBE.ALM_COD                            '4
                    cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)                     '5
                    cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT                               '6
                    cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)                       '7
                    cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD                            '8
                    cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIADESPACHOBE.EST                                '9
                    cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO                           '10
                    cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = GUIADESPACHOBE.T_MOVINV                           '11
                    cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)              '12
                    cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)          '13
                    cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)          '14
                    cmd.Parameters.Add("@MOV_CCO_COD", OracleDbType.Varchar2).Value = "" 'Trim(DET_DOCUMENTOBE.CCO_COD)                '15
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If

            End If
            If DET_DOCUMENTOBE.T_DOC_REF1 = "82" Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_DOCU_UPDCANT82"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Mid(DET_DOCUMENTOBE.NRO_DOC_REF1, 1, 7)
                cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If


            If Mid(DET_DOCUMENTOBE.OBSERVA, 1, 1) = "F" And Mid(DET_DOCUMENTOBE.OBSERVA, 11, 1) = "N" Then
                ' Cambia el estado a pendiente para liberar los fardos anteriores
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELTBDETGUIA_UPDATE_FAR"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("pT_DOC", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
                cmd.Parameters.Add("pS_DOC", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
                cmd.Parameters.Add("pN_DOC", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                cmd.Parameters.Add("pART_COD", OracleDbType.Varchar2).Value = ""
                cmd.Parameters.Add("pEST", OracleDbType.Varchar2).Value = "P"
                cmd.Parameters.Add("pCOD_FAR", OracleDbType.Varchar2).Value = ""
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                Dim nro1 As Integer = Math.Round(Len(DET_DOCUMENTOBE.OBSERVA) / 11)
                Dim nro2 As Integer = 1
                For i = 0 To nro1 - 1
                    ' Cambia el estado a habilitado para señalar su usa y modifica el campo de n_doc 
                    ' para ubicar el documento en la tabla de fardo
                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ELTBDETGUIA_UPDATE_FAR"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("pT_DOC", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
                    cmd.Parameters.Add("pS_DOC", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
                    cmd.Parameters.Add("pN_DOC", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                    cmd.Parameters.Add("pART_COD", OracleDbType.Varchar2).Value = ""
                    cmd.Parameters.Add("pART_COD", OracleDbType.Varchar2).Value = "H"
                    cmd.Parameters.Add("pCOD_FAR", OracleDbType.Varchar2).Value = Mid(DET_DOCUMENTOBE.OBSERVA, nro2, 11)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    nro2 = nro2 + 12
                Next
            End If

        Next
        'ACTUALIZA CABECERA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDTOTALESGD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.NRO_DOC_REF
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
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + GUIADESPACHOBE.T_DOC_REF + "-" + GUIADESPACHOBE.SER_DOC_REF + "-" + GUIADESPACHOBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    'Metodo para Modificar 
    Private Sub UpdateRow(ByVal GUIADESPACHOBE As GUIADESPACHOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                          ByVal scodcat As String, ByVal sEst As String, ByVal dg1 As DataTable)
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim almacen As String
        'REGULARIZAR STOCKS 
        'If GUIADESPACHOBE.T_MOVINV = "S31" Then

        If GUIADESPACHOBE.SER_DOC_REF = "001" Then
            almacen = "0001"
        ElseIf GUIADESPACHOBE.SER_DOC_REF = "003" Then
            almacen = "0002"
        ElseIf GUIADESPACHOBE.SER_DOC_REF = "004" Then
            almacen = "0003"
        End If


        'ACTUALIZAR DOCUMENTO
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDATEROW_GD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.NRO_DOC_REF
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = GUIADESPACHOBE.ART_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIADESPACHOBE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIADESPACHOBE.EST
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = GUIADESPACHOBE.MONEDA
        cmd.Parameters.Add("@tprecio_venta", OracleDbType.Double).Value = GUIADESPACHOBE.TPRECIO_VENTA
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = GUIADESPACHOBE.FEC_ANU
        cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = GUIADESPACHOBE.SIGNO
        cmd.Parameters.Add("@tprecio_dventa", OracleDbType.Double).Value = GUIADESPACHOBE.TPRECIO_DVENTA
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = GUIADESPACHOBE.USUARIO
        cmd.Parameters.Add("@observa", OracleDbType.Char).Value = GUIADESPACHOBE.OBSERVA
        cmd.Parameters.Add("@t_movinv", OracleDbType.Char).Value = GUIADESPACHOBE.T_MOVINV
        cmd.Parameters.Add("@t_igv", OracleDbType.Double).Value = GUIADESPACHOBE.T_IGV
        cmd.Parameters.Add("@t_igv_dolar", OracleDbType.Double).Value = GUIADESPACHOBE.T_IGV_DOLAR
        cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = GUIADESPACHOBE.F_PAGO_ENT
        cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = GUIADESPACHOBE.FOR_ENT_COD
        cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = GUIADESPACHOBE.PROVEEDOR
        cmd.Parameters.Add("@FEC_PROV", OracleDbType.Date).Value = GUIADESPACHOBE.FEC_PROV
        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = GUIADESPACHOBE.CTCT_COD
        cmd.Parameters.Add("@vendedor", OracleDbType.Varchar2).Value = GUIADESPACHOBE.VENDEDOR
        cmd.Parameters.Add("@dir_cod", OracleDbType.Varchar2).Value = GUIADESPACHOBE.DIR_COD
        cmd.Parameters.Add("@NUMPEDIDO", OracleDbType.Varchar2).Value = GUIADESPACHOBE.NUMPEDIDO
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIADESPACHOBE.FEC_DIA
        cmd.Parameters.Add("@CANAL", OracleDbType.Varchar2).Value = GUIADESPACHOBE.CANAL
        cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = GUIADESPACHOBE.ALM_COD
        cmd.Parameters.Add("@NOM_CTCT", OracleDbType.Varchar2).Value = GUIADESPACHOBE.NOM_CTCT
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        If GUIADESPACHOBE.EST <> "A" Then

            'DEVOLUCION DE STOCK SIN IMPORTAR QUE MOVIMIENTO HAGA O ELIMINE
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ARTICULO_DVSTOCKALM"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@pT_DOC_REF", OracleDbType.Char).Value = Trim(GUIADESPACHOBE.T_DOC_REF)
            cmd.Parameters.Add("@pSER_DOC_REF", OracleDbType.Char).Value = Trim(GUIADESPACHOBE.SER_DOC_REF)
            cmd.Parameters.Add("@pNRO_DOC_REF", OracleDbType.Char).Value = Trim(GUIADESPACHOBE.NRO_DOC_REF)
            cmd.Parameters.Add("pfec_gene", OracleDbType.Date).Value = GUIADESPACHOBE.FEC_GENE
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            'ELIMINAR DETALLE DET_DOCUMENTO    
            'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            'cmd.CommandText = "SP_DET_DOCUMENTO_DEL_GD"
            'cmd.Connection = sqlCon
            'cmd.Transaction = sqlTrans
            'cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.T_DOC_REF
            'cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.SER_DOC_REF
            'cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.NRO_DOC_REF
            'cmd.ExecuteNonQuery()
            'cmd.Dispose()

            Dim cont As Integer = 0
            For Each row As DataGridViewRow In dg.Rows

                cont = cont + 1

                DET_DOCUMENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
                DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
                DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
                DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
                DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
                DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
                DET_DOCUMENTOBE.NRO_DOCU1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU1").Value)), "", RTrim(row.Cells("NRO_DOCU1").Value))
                DET_DOCUMENTOBE.SERIE_SOLI = IIf(IsDBNull(RTrim(row.Cells("SERIE_SOLI").Value)), "", RTrim(row.Cells("SERIE_SOLI").Value))
                DET_DOCUMENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells("CTCT_COD").Value)), "", RTrim(row.Cells("CTCT_COD").Value))
                DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value))
                DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
                DET_DOCUMENTOBE.OBSERVA = IIf(IsDBNull(RTrim(row.Cells("OBSERVA").Value)), "", RTrim(row.Cells("OBSERVA").Value))
                DET_DOCUMENTOBE.T_MOVINV = IIf(IsDBNull(RTrim(row.Cells("T_MOVINV").Value)), "", RTrim(row.Cells("T_MOVINV").Value))
                If IIf(IsDBNull(RTrim(row.Cells("FEC_ENT").Value)), "", RTrim(row.Cells("FEC_ENT").Value)) <> "" Then
                    DET_DOCUMENTOBE.FEC_ENT = IIf(IsDBNull(RTrim(row.Cells("FEC_ENT").Value)), "", RTrim(row.Cells("FEC_ENT").Value))
                End If

                'DET_DOCUMENTOBE.UPRECIO_VENTA = IIf(String.IsNullOrEmpty(RTrim(row.Cells("UPRECIO_VENTA").Value)), 0, row.Cells("UPRECIO_VENTA").Value)
                'DET_DOCUMENTOBE.UPRECIO_DVENTA = IIf(String.IsNullOrEmpty(RTrim(row.Cells("UPRECIO_DVENTA").Value)), 0, Format(row.Cells("UPRECIO_DVENTA").Value, “##,##0.00”))
                DET_DOCUMENTOBE.IGV = IIf(String.IsNullOrEmpty(RTrim(row.Cells("IGV").Value)), 0, RTrim(row.Cells("IGV").Value))
                'DET_DOCUMENTOBE.IGV_IMPOR = IIf(String.IsNullOrEmpty(RTrim(row.Cells("IGV_IMPOR").Value)), 0, RTrim(row.Cells("IGV_IMPOR").Value))
                'DET_DOCUMENTOBE.IGV_DIMPOR = IIf(String.IsNullOrEmpty(RTrim(row.Cells("IGV_DIMPOR").Value)), 0, RTrim(row.Cells("IGV_DIMPOR").Value))
                DET_DOCUMENTOBE.T_CAMB = IIf(String.IsNullOrEmpty(RTrim(row.Cells("T_CAMB").Value)), 0, RTrim(row.Cells("T_CAMB").Value))
                DET_DOCUMENTOBE.CANTIDAD5 = cont

                'DET_DOCUMENTOBE.TPRECIO_VENTA = DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD
                'DET_DOCUMENTOBE.TPRECIO_DVENTA = DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD
                'DET_DOCUMENTOBE.IGV_IMPOR = (DET_DOCUMENTOBE.TPRECIO_VENTA * 18) / 100
                'DET_DOCUMENTOBE.IGV_DIMPOR = (DET_DOCUMENTOBE.TPRECIO_DVENTA * 18) / 100
                If GUIADESPACHOBE.MONEDA = "00" Then
                    DET_DOCUMENTOBE.UPRECIO_VENTA = Math.Round(CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_VENTA").Value)), 0, RTrim(row.Cells("UPRECIO_VENTA").Value))), 2)
                    DET_DOCUMENTOBE.UPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA / DET_DOCUMENTOBE.T_CAMB, 2)
                    DET_DOCUMENTOBE.TPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD, 2)
                    DET_DOCUMENTOBE.TPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_VENTA * DET_DOCUMENTOBE.CANTIDAD / DET_DOCUMENTOBE.T_CAMB, 2)
                    If GUIADESPACHOBE.T_IGV > 0 Then
                        DET_DOCUMENTOBE.IGV_IMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_VENTA * 18) / 100, 2)
                        DET_DOCUMENTOBE.IGV_DIMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_DVENTA * 18) / 100, 2)
                    Else
                        DET_DOCUMENTOBE.IGV_IMPOR = 0
                        DET_DOCUMENTOBE.IGV_DIMPOR = 0
                    End If

                ElseIf GUIADESPACHOBE.MONEDA = "01" Then
                    DET_DOCUMENTOBE.UPRECIO_DVENTA = Math.Round(CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DVENTA").Value)), 0, RTrim(row.Cells("UPRECIO_DVENTA").Value))), 2)
                    DET_DOCUMENTOBE.UPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.T_CAMB, 2)
                    DET_DOCUMENTOBE.TPRECIO_DVENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD, 2)
                    DET_DOCUMENTOBE.TPRECIO_VENTA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DVENTA * DET_DOCUMENTOBE.CANTIDAD * DET_DOCUMENTOBE.T_CAMB, 2)
                    If GUIADESPACHOBE.T_IGV > 0 Then
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
                If IIf(IsDBNull(RTrim(row.Cells("PESO").Value)), 0, RTrim(row.Cells("PESO").Value)) = "" Then
                    DET_DOCUMENTOBE.PESO = 0
                Else
                    DET_DOCUMENTOBE.PESO = IIf(IsDBNull(RTrim(row.Cells("PESO").Value)), 0, RTrim(row.Cells("PESO").Value))
                End If
                DET_DOCUMENTOBE.EST = IIf(IsDBNull(RTrim(row.Cells("EST").Value)), "", RTrim(row.Cells("EST").Value))
                If GUIADESPACHOBE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 And GUIADESPACHOBE.T_DOC_REF = DET_DOCUMENTOBE.T_DOC_REF1 Then
                    DET_DOCUMENTOBE.NRO_DOC_REF1 = GUIADESPACHOBE.NRO_DOC_REF & "-" & cont
                End If
                DET_DOCUMENTOBE.TRANSP_COD = IIf(IsDBNull(RTrim(row.Cells("TRANSP_COD").Value)), "", RTrim(row.Cells("TRANSP_COD").Value))
                DET_DOCUMENTOBE.CHOFER = IIf(IsDBNull(RTrim(row.Cells("CHOFER").Value)), "", RTrim(row.Cells("CHOFER").Value))
                'DET_DOCUMENTOBE.BREVETE = IIf(IsDBNull(RTrim(row.Cells("BREVETE").Value)), "", RTrim(row.Cells("BREVETE").Value))
                'DET_DOCUMENTOBE.PLACA = IIf(IsDBNull(RTrim(row.Cells("PLACA").Value)), "", RTrim(row.Cells("PLACA").Value))
                ' DET_DOCUMENTOBE.MARCA = IIf(IsDBNull(RTrim(row.Cells("MARCA").Value)), "", RTrim(row.Cells("MARCA").Value))
                DET_DOCUMENTOBE.CONFIGURACION = IIf(IsDBNull(RTrim(row.Cells("CONFIGURACION").Value)), "", RTrim(row.Cells("CONFIGURACION").Value))
                'AGREGADO PARA TRANSFERENCIA
                DET_DOCUMENTOBE.REPROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("REPROVEEDOR").Value)), "", RTrim(row.Cells("REPROVEEDOR").Value))
                DET_DOCUMENTOBE.RETRANSPORTISTA = IIf(IsDBNull(RTrim(row.Cells("RETRANSPORTISTA").Value)), "", RTrim(row.Cells("RETRANSPORTISTA").Value))
                DET_DOCUMENTOBE.MARCA1 = IIf(IsDBNull(RTrim(row.Cells("MARCA1").Value)), "", RTrim(row.Cells("MARCA1").Value))
                'DET_DOCUMENTOBE.CERTIFICADO = IIf(IsDBNull(RTrim(row.Cells("CERTIFICADO").Value)), "", RTrim(row.Cells("CERTIFICADO").Value))
                DET_DOCUMENTOBE.TIPO_UNIDAD = IIf(IsDBNull(RTrim(row.Cells("TIPO_UNIDAD").Value)), "", RTrim(row.Cells("TIPO_UNIDAD").Value))
                DET_DOCUMENTOBE.COLOR = IIf(IsDBNull(RTrim(row.Cells("COLOR").Value)), "", RTrim(row.Cells("COLOR").Value))
                'DET_DOCUMENTOBE.NRO_DOCU2 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU2").Value)), "", RTrim(row.Cells("NRO_DOCU2").Value))
                DET_DOCUMENTOBE.ALM_COD = IIf(IsDBNull(RTrim(row.Cells("ALM_COD").Value)), "0001", RTrim(row.Cells("ALM_COD").Value))
                'REGRESAR LA CANTIDAD 4 A SU ORIGEN
                If cont = 1 Then
                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_DET_DOCUMENTO_DEL_GD"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.T_DOC_REF
                    cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.SER_DOC_REF
                    cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.NRO_DOC_REF
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    If DET_DOCUMENTOBE.T_DOC_REF1 = "82" Then
                        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                        cmd.CommandText = "SP_ARTICULO_DVSTOCKALM_DES"
                        cmd.Connection = sqlCon
                        cmd.Transaction = sqlTrans
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIADESPACHOBE.T_DOC_REF)
                        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIADESPACHOBE.SER_DOC_REF)
                        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = Mid(GUIADESPACHOBE.NRO_DOC_REF, 1, 7)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                    End If
                    'And cont = 1 Then
                End If


                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_DET_DOCUMENTO_INSGD"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                'Los parametros que va recibir son las propiedades de la clase 
                cmd.Parameters.Add("@correlativo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CANTIDAD5
                cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.T_DOC_REF
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.SER_DOC_REF
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.NRO_DOC_REF
                cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
                cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
                cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                cmd.Parameters.Add("@serie_soli", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SERIE_SOLI
                cmd.Parameters.Add("@nro_docu1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOCU1
                cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = GUIADESPACHOBE.CTCT_COD
                cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIADESPACHOBE.EST
                cmd.Parameters.Add("@alm_cod,", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ALM_COD
                cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = "-"
                cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
                cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(GUIADESPACHOBE.T_MOVINV)
                cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
                cmd.Parameters.Add("@TPRECIO_VENTA", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.TPRECIO_VENTA)
                cmd.Parameters.Add("@TPRECIO_dVENTA", OracleDbType.Double).Value = DET_DOCUMENTOBE.TPRECIO_DVENTA
                cmd.Parameters.Add("@igv", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.IGV)
                cmd.Parameters.Add("@IGV_IMPOR", OracleDbType.Double).Value = DET_DOCUMENTOBE.IGV_IMPOR
                cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
                cmd.Parameters.Add("@t_camb", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.T_CAMB)
                cmd.Parameters.Add("@UPRECIO_VENTA", OracleDbType.Double).Value = DET_DOCUMENTOBE.UPRECIO_VENTA
                cmd.Parameters.Add("@UPRECIO_dVENTA", OracleDbType.Double).Value = DET_DOCUMENTOBE.UPRECIO_DVENTA
                cmd.Parameters.Add("@IGV_DIMPOR", OracleDbType.Double).Value = DET_DOCUMENTOBE.IGV_DIMPOR
                cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO
                cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = GUIADESPACHOBE.MONEDA
                cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIADESPACHOBE.FEC_GENE
                cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_DIA
                cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PROVEEDOR
                cmd.Parameters.Add("@transp_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.TRANSP_COD
                cmd.Parameters.Add("@chofer", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CHOFER
                cmd.Parameters.Add("@brevete", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.BREVETE
                cmd.Parameters.Add("@placa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PLACA
                cmd.Parameters.Add("@marca", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.MARCA
                cmd.Parameters.Add("@configuracion", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CONFIGURACION
                cmd.Parameters.Add("@certificado", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CERTIFICADO
                cmd.Parameters.Add("@tipo_unidad", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.TIPO_UNIDAD
                cmd.Parameters.Add("@serie_transp", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.COLOR
                cmd.Parameters.Add("@nro_transp", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOCU2
                cmd.Parameters.Add("@peso", OracleDbType.Double).Value = DET_DOCUMENTOBE.PESO
                cmd.Parameters.Add("@REPROVEEDOR", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.REPROVEEDOR
                cmd.Parameters.Add("@RETRANSPORTISTA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.RETRANSPORTISTA
                cmd.Parameters.Add("@MARCA1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.MARCA1
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                Dim almacen1 As String = ""
                If GUIADESPACHOBE.EST <> "A" Then
                    If GUIADESPACHOBE.T_MOVINV <> "S32" And GUIADESPACHOBE.T_MOVINV <> "S36" And
                        GUIADESPACHOBE.T_MOVINV <> "S38" And GUIADESPACHOBE.T_MOVINV <> "E28" Then
                        If GUIADESPACHOBE.T_MOVINV = "S31" Then
                            If GUIADESPACHOBE.SER_DOC_REF = "001" Then
                                almacen = "0001"
                            ElseIf GUIADESPACHOBE.SER_DOC_REF = "003" Then
                                almacen = "0002"
                            ElseIf GUIADESPACHOBE.SER_DOC_REF = "004" Then
                                almacen = "0003"
                            End If
                            If GUIADESPACHOBE.CANAL = "0001" Then
                                almacen1 = "0001"
                            ElseIf GUIADESPACHOBE.CANAL = "0002" Then
                                almacen1 = "0002"
                            ElseIf GUIADESPACHOBE.CANAL = "0003" Then
                                almacen1 = "0003"
                            End If
                            'RESTA STOCK PARA DESPACHO
                            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                            cmd.CommandText = "SP_ARTICULO_UPDATESTKRES"
                            cmd.Connection = sqlCon
                            cmd.Transaction = sqlTrans
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                            cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = almacen
                            cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()

                            'RESTA STOCK PARA DESPACHO
                            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                            cmd.CommandText = "SP_ARTICULO_UPDATESTKSUM"
                            cmd.Connection = sqlCon
                            cmd.Transaction = sqlTrans
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                            cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = almacen1
                            cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()

                            'INSERTAR MOVIEMIENTO ALMACEN
                            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                            cmd.CommandText = "SP_ELMVALMAANHO_INS"
                            cmd.Connection = sqlCon
                            cmd.Transaction = sqlTrans
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF)             '0
                            cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)         '1
                            cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = GUIADESPACHOBE.NRO_DOC_REF                '2
                            cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = "S"                                        '3
                            cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = almacen                                        '4
                            cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)                  '5
                            cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT                            '6
                            cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)                    '7
                            cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD                         '8
                            cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIADESPACHOBE.EST                             '9
                            cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = GUIADESPACHOBE.USUARIO                         '10
                            cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = GUIADESPACHOBE.T_MOVINV                        '11
                            cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)           '12
                            cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)       '13
                            cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)       '14
                            cmd.Parameters.Add("@MOV_CCO_COD", OracleDbType.Varchar2).Value = "" 'Trim(DET_DOCUMENTOBE.CCO_COD)             '15
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()

                            'INSERTAR MOVIEMIENTO ALMACEN DEL SEGUNDO ALMACEN
                            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                            cmd.CommandText = "SP_ELMVALMAANHO_INS"
                            cmd.Connection = sqlCon
                            cmd.Transaction = sqlTrans
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF)            '0
                            cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)        '1
                            cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = GUIADESPACHOBE.NRO_DOC_REF               '2
                            cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = "E"                                       '3
                            cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = almacen1                                      '4
                            cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)                 '5
                            cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT                           '6
                            cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)                   '7
                            cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD                        '8
                            cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIADESPACHOBE.EST                            '9
                            cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO                       '10
                            cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = "E22"                                         '11
                            cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)          '12
                            cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)      '13
                            cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)      '14
                            cmd.Parameters.Add("@MOV_CCO_COD", OracleDbType.Varchar2).Value = "" 'Trim(DET_DOCUMENTOBE.CCO_COD)            '15
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()

                        Else
                            'RESTA STOCK PARA DESPACHO
                            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                            cmd.CommandText = "SP_ARTICULO_UPDATESTKRES"
                            cmd.Connection = sqlCon
                            cmd.Transaction = sqlTrans
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                            cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = GUIADESPACHOBE.ALM_COD
                            cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()

                            'INSERTAR MOVIEMIENTO ALMACEN
                            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                            cmd.CommandText = "SP_ELMVALMAANHO_INS"
                            cmd.Connection = sqlCon
                            cmd.Transaction = sqlTrans
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF)          '0
                            cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)      '1
                            cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = GUIADESPACHOBE.NRO_DOC_REF             '2
                            cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = "S"                                     '3
                            cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = GUIADESPACHOBE.ALM_COD                      '4
                            cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)               '5
                            cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT                         '6
                            cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)                 '7
                            cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD                      '8
                            cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIADESPACHOBE.EST                          '9
                            cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO                     '10
                            cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = GUIADESPACHOBE.T_MOVINV                     '11
                            cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)        '12
                            cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)    '13
                            cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)    '14
                            cmd.Parameters.Add("@MOV_CCO_COD", OracleDbType.Varchar2).Value = "" 'Trim(DET_DOCUMENTOBE.CCO_COD)          '15
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                        End If

                    End If
                End If
                'VOLVER A SUMAR STOCK
                If DET_DOCUMENTOBE.T_DOC_REF1 = "82" Then
                        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                        cmd.CommandText = "SP_DOCU_UPDCANT82"
                        cmd.Connection = sqlCon
                        cmd.Transaction = sqlTrans
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.Add("@T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                        cmd.Parameters.Add("@SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                        cmd.Parameters.Add("@NRO_DOC_REF1", OracleDbType.Varchar2).Value = Mid(DET_DOCUMENTOBE.NRO_DOC_REF1, 1, 7)
                        cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                        cmd.Parameters.Add("@CANTIDAD", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    End If

                    'ACTUALIZA CABECERA
                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_DOCUMENTO_UPDTOTALESGD"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.T_DOC_REF
                    cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.SER_DOC_REF
                    cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIADESPACHOBE.NRO_DOC_REF
                    cmd.Parameters.Add("@TPRECIO_VENTA", OracleDbType.Double).Value = DAcumula3
                    cmd.Parameters.Add("@TPRECIO_DVENTA", OracleDbType.Double).Value = DAcumula2
                    cmd.Parameters.Add("@T_IGV", OracleDbType.Double).Value = DAcumula4
                    cmd.Parameters.Add("@T_IGV_DOLAR", OracleDbType.Double).Value = DAcumula5
                    cmd.ExecuteNonQuery()
                cmd.Dispose()

                If Mid(DET_DOCUMENTOBE.OBSERVA, 1, 1) = "F" And Mid(DET_DOCUMENTOBE.OBSERVA, 11, 1) = "N" Then
                    ' Cambia el estado a pendiente para liberar los fardos anteriores
                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ELTBDETGUIA_UPDATE_FAR"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("pT_DOC", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
                    cmd.Parameters.Add("pS_DOC", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
                    cmd.Parameters.Add("pN_DOC", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                    cmd.Parameters.Add("pART_COD", OracleDbType.Varchar2).Value = ""
                    cmd.Parameters.Add("pEST", OracleDbType.Varchar2).Value = "P"
                    cmd.Parameters.Add("pCOD_FAR", OracleDbType.Varchar2).Value = ""
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    Dim nro1 As Integer = Math.Round(Len(DET_DOCUMENTOBE.OBSERVA) / 11)
                    Dim nro2 As Integer = 1
                    For i = 0 To nro1 - 1
                        ' Cambia el estado a habilitado para señalar su usa y modifica el campo de n_doc 
                        ' para ubicar el documento en la tabla de fardo
                        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                        cmd.CommandText = "SP_ELTBDETGUIA_UPDATE_FAR"
                        cmd.Connection = sqlCon
                        cmd.Transaction = sqlTrans
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.Add("pT_DOC", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
                        cmd.Parameters.Add("pS_DOC", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
                        cmd.Parameters.Add("pN_DOC", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                        cmd.Parameters.Add("pART_COD", OracleDbType.Varchar2).Value = ""
                        cmd.Parameters.Add("pART_COD", OracleDbType.Varchar2).Value = "H"
                        cmd.Parameters.Add("pCOD_FAR", OracleDbType.Varchar2).Value = Mid(DET_DOCUMENTOBE.OBSERVA, nro2, 11)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        nro2 = nro2 + 12
                    Next
                End If
            Next
        End If

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Actualizo el Documento: " + GUIADESPACHOBE.T_DOC_REF + "-" + GUIADESPACHOBE.SER_DOC_REF + "-" + GUIADESPACHOBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRowAnularOC(ByVal GUIADESPACHOBE As GUIADESPACHOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView, ByVal sEst As String)
        Dim almacen As String = ""
        Dim almacen1 As String = ""
        If sEst = "H" And GUIADESPACHOBE.EST = "A" Then
            If GUIADESPACHOBE.SER_DOC_REF = "001" Then
                almacen = "0001"
            ElseIf GUIADESPACHOBE.SER_DOC_REF = "003" Then
                almacen = "0002"
            ElseIf GUIADESPACHOBE.SER_DOC_REF = "004" Then
                almacen = "0003"
            End If
            If GUIADESPACHOBE.CANAL = "0001" Then
                almacen1 = "0001"
            ElseIf GUIADESPACHOBE.CANAL = "0002" Then
                almacen1 = "0002"
            ElseIf GUIADESPACHOBE.CANAL = "0003" Then
                almacen1 = "0003"
            End If
            Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DOCUMENTO_UPDATEROW_ANUOC"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIADESPACHOBE.T_DOC_REF)
            cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIADESPACHOBE.SER_DOC_REF)
            cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIADESPACHOBE.NRO_DOC_REF)
            cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = "A"
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            'cmd.CommandText = "SP_DET_DOCU_UPD_ANULAR_OC"
            'cmd.Connection = sqlCon
            'cmd.Transaction = sqlTrans
            'cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIADESPACHOBE.T_DOC_REF)
            'cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIADESPACHOBE.SER_DOC_REF)
            'cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIADESPACHOBE.NRO_DOC_REF)
            'cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = "A"
            'cmd.ExecuteNonQuery()
            'cmd.Dispose()



            For Each row As DataGridViewRow In dg.Rows
                DET_DOCUMENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
                DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
                DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))
                DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(3).Value))
                DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(4).Value)), "", RTrim(row.Cells(4).Value))
                DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(5).Value)), "", RTrim(row.Cells(5).Value))
                DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells(7).Value)), "", RTrim(row.Cells(7).Value))
                DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells(8).Value)), "", RTrim(row.Cells(8).Value))
                DET_DOCUMENTOBE.T_MOVINV = IIf(IsDBNull(RTrim(row.Cells("T_MOVINV").Value)), "", RTrim(row.Cells("T_MOVINV").Value))
                If GUIADESPACHOBE.T_MOVINV = "S31" Then
                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_DET_DOCUANHO_UPD_ANULAR1"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF)
                    cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)
                    cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF)
                    cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                    cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                    cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
                    cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = "A"
                    cmd.Parameters.Add("@COD_ALM", OracleDbType.Varchar2).Value = almacen
                    cmd.Parameters.Add("@COD_ALM1", OracleDbType.Varchar2).Value = almacen1
                    cmd.Parameters.Add("@pART_COD", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@pT_MOVINV", OracleDbType.Varchar2).Value = Trim(GUIADESPACHOBE.ALMAC)
                    cmd.Parameters.Add("@pCANTIDAD", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                    cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = GUIADESPACHOBE.FEC_GENE
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                Else
                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_DET_DOCU_UPDANHO_ANULAR"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF)
                    cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)
                    cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF)
                    cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                    cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                    cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
                    cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = "A"
                    cmd.Parameters.Add("@pART_COD", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@pT_MOVINV", OracleDbType.Varchar2).Value = Trim(GUIADESPACHOBE.ALMAC)
                    cmd.Parameters.Add("@pCANTIDAD", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                    cmd.Parameters.Add("@pALM_COD", OracleDbType.Varchar2).Value = Trim(GUIADESPACHOBE.ALM_COD)
                    cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = GUIADESPACHOBE.FEC_GENE
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If

            Next

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "5"
            cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
            cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Anulo la OC: " + GUIADESPACHOBE.T_DOC_REF + "-" + GUIADESPACHOBE.SER_DOC_REF + "-" + GUIADESPACHOBE.NRO_DOC_REF
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If
    End Sub
    Private Sub UpdateRowCerrar(ByVal GUIADESPACHOBE As GUIADESPACHOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOC_CER_OC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIADESPACHOBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIADESPACHOBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIADESPACHOBE.NRO_DOC_REF)
        cmd.Parameters.Add("pART_COD", OracleDbType.Varchar2).Value = Trim(GUIADESPACHOBE.ART_COD1)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "5"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Cerro un item de la OC: " + GUIADESPACHOBE.T_DOC_REF + "-" + GUIADESPACHOBE.SER_DOC_REF + "-" + GUIADESPACHOBE.NRO_DOC_REF + "-" + GUIADESPACHOBE.ART_COD1
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Function SaveRow(ByVal GUIADESPACHOBE As GUIADESPACHOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal flagAccion As String, ByVal dg As DataGridView, ByVal scodcat As String, ByVal sEst As String, ByVal dg1 As DataTable) As String
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
                InsertRow(GUIADESPACHOBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "M" Then
                UpdateRow(GUIADESPACHOBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat, sEst, dg1)
            End If
            If flagAccion = "AR" Then
                UpdateRowAnularOC(GUIADESPACHOBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg, sEst)
            End If
            If flagAccion = "C" Then
                UpdateRowCerrar(GUIADESPACHOBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "NA" Then
                SaveRowActa(cn, sqlTrans, dg, scodcat)
            End If
            If flagAccion = "MA" Then
                UpdateRowActa(cn, sqlTrans, dg, scodcat)
            End If
            If flagAccion = "TOT" Then
                UpdateRowTot(cn, sqlTrans, dg, scodcat)
            End If
            If flagAccion = "TOTART" Then
                UpdateRowTotArt(cn, sqlTrans, dg, scodcat)
            End If
            If flagAccion = "ET" Then
                DeleteRowTot(cn, sqlTrans, dg, scodcat)
            End If
            'sqlTrans.Commit()
            ''resultado = "OK"
            'If flagAccion = "N" Or flagAccion = "M" Then
            '    UpdateRowCabecera(GUIADESPACHOBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg)
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
        Using dr As OracleDataReader = Me.GetDataReader("SP_DET_DOCUMENTO_SELECTROW_GD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function getDatostransp(ByVal sT_codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_TRANS_DATOS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAll(ByVal sT_doc As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SELECTALL_DES", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
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
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELECTNRO2", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode)),
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
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SelectRow", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRowActa(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SELECTROWACTA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
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
    Public Function SelectT_Transp() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TRANSP_COMBO", {})
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

    Public Function SelectDirProv() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_PROV_DIR", {})
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
    Public Function SelectMaxTrans(ByVal sAnio As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_TRANS_LASTCODIGO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_anio", sAnio)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using

        Return dt.Rows(0).Item(0)
    End Function

    Public Function getListdgv_GD(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DET_DOCUMENTO_SELECT_REQ_GD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectT_TranspTractor(ByVal tcod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TRANSPTRACTORES_COMBO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_cod", tcod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectT_TranspChofer(ByVal tcod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TRANSPCHOFER_COMBO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_cod", tcod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getDatostranspTractor(ByVal sT_codigo As String, ByVal codtrans As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_TRANSPTRACTOR_DATOS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@placa", sT_codigo),
                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@codtrans", codtrans)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRowcodChofer(ByVal cod As String, ByVal chofer As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_COD_CHOFER", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod), New Oracle.ManagedDataAccess.Client.OracleParameter("@chofer", chofer)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Try
            Return dt.Rows(0).Item(0)
        Catch ex As Exception

        End Try

    End Function
    Public Function SelectT_TranspChoferRow(ByVal tcod As String, ByVal tcode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TRANSPCHOFER_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_cod", tcod), New Oracle.ManagedDataAccess.Client.OracleParameter("@t_code", tcode)})

            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Public Function SelectGetUbigeo(ByVal cliente As String, ByVal dir As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_GUIADESPACHO_GETUBIGEO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cliente", cliente),
                                                                                                            New Oracle.ManagedDataAccess.Client.OracleParameter("@dir", dir)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectGetCodviru(ByVal cliente As String, ByVal articulo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_GUIADESPACHO_GETCOD_VIR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cliente", cliente),
                                                                                                                       New Oracle.ManagedDataAccess.Client.OracleParameter("@articulo", articulo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectGetCantidadPallets(ByVal cantidadpallets As Double, ByVal diametro As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_GUIADESPACHO_GETCANTPALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cantidadpallets", cantidadpallets),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@diametro", diametro)})

            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectDataOP(ByVal TDOC As String, ByVal SDOC As String, ByVal NDOC As String, ByVal ARTICULO As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBDETDOCOP_SELECTOP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC", TDOC),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@S_DOC", SDOC),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@N_DOC", NDOC),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@ARTICULO", ARTICULO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using

        Return dt.Rows(0).Item(0)
    End Function
End Class
