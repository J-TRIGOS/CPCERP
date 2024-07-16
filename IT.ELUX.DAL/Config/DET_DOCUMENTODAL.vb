Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class DET_DOCUMENTODAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE


    'Metodo para registrar un nuevo 
    Private Sub InsertRow(ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                            ByVal scodcat As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCUMENTO_DEL_ALM"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@rcc_codcat", OracleDbType.Char).Value = DET_DOCUMENTOBE.T_DOC_REF
        cmd.Parameters.Add("@rcc_codcat", OracleDbType.Char).Value = DET_DOCUMENTOBE.SER_DOC_REF
        cmd.Parameters.Add("@rcc_codcat", OracleDbType.Char).Value = DET_DOCUMENTOBE.NRO_DOC_REF

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows

            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INSALM"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF)
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF)
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CTCT_COD
            cmd.Parameters.Add("@cantidad", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CANTIDAD
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO
            cmd.Parameters.Add("@observa", OracleDbType.Char).Value = DET_DOCUMENTOBE.OBSERVA
            cmd.Parameters.Add("@t_movinv", OracleDbType.Char).Value = DET_DOCUMENTOBE.T_MOVINV
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_GENE
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.UNIDAD
            cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT
            cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.FOR_ENT_COD
            cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_DIA
            cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = DET_DOCUMENTOBE.PROVEEDOR
            cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CCO_COD
            cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE
            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD
            cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
            cmd.Parameters.Add("@fec_lleg", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_LLEG
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.EST
            cmd.Parameters.Add("@REQ", OracleDbType.Varchar2).Value = "U"

            cmd.ExecuteNonQuery()
            cmd.Dispose()

        Next
    End Sub

    Private Sub UpdateRow(ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sAño1 As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCUMENTO_UPDITEMALM"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF)
        cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
        cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
        cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
        cmd.Parameters.Add("@art_cod_act", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD1
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
        cmd.Parameters.Add("@cantidad1", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD1
        cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
        cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_MOVINV
        cmd.Parameters.Add("@alm_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ALM_COD
        cmd.Parameters.Add("@año", OracleDbType.Varchar2).Value = sAño1
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = ELMVLOGSBE.log_codope
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Modifico el Documento: " + DET_DOCUMENTOBE.T_DOC_REF + "-" + DET_DOCUMENTOBE.SER_DOC_REF + "-" + DET_DOCUMENTOBE.NRO_DOC_REF + "-" + DET_DOCUMENTOBE.CANTIDAD1.ToString + "-" + DET_DOCUMENTOBE.ART_COD1
        cmd.ExecuteNonQuery()
        cmd.Dispose()


    End Sub

    Private Sub UpdateRowMG(ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sAño1 As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCUMENTO_UPDITEMALM1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF)
        cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
        cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
        cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
        cmd.Parameters.Add("@art_cod_act", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD1
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
        cmd.Parameters.Add("@cantidad1", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD1
        cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
        cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_MOVINV
        cmd.Parameters.Add("@alm_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ALM_COD
        cmd.Parameters.Add("@año", OracleDbType.Varchar2).Value = sAño1
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        If DET_DOCUMENTOBE.T_DOC_REF1 = "SOLM" Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_SOLMAT_UPDATE_EST11"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF)
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF)
            cmd.Parameters.Add("@T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
            cmd.Parameters.Add("@SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
            cmd.Parameters.Add("@NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(Mid(DET_DOCUMENTOBE.NRO_DOC_REF1, 1, 7))
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
            cmd.Parameters.Add("@art_cod_act", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD1
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_SOLMATE_UPDATE_EST"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(Mid(DET_DOCUMENTOBE.NRO_DOC_REF1, 1, 7))
            cmd.Parameters.Add("@CANTIDAD2", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
            cmd.Parameters.Add("@USUARIOAT", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO
            cmd.Parameters.Add("@EST1", OracleDbType.Varchar2).Value = "3"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf DET_DOCUMENTOBE.T_DOC_REF1 = "82" Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DOCU_UPDCANT82_ALM1"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF)
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF)
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Mid(DET_DOCUMENTOBE.NRO_DOC_REF1, 1, 7)
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DOCU_UPDCANT82_ALM"
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

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = ELMVLOGSBE.log_codope
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Modifico el Documento: " + DET_DOCUMENTOBE.T_DOC_REF + "-" + DET_DOCUMENTOBE.SER_DOC_REF + "-" + DET_DOCUMENTOBE.NRO_DOC_REF + "-" + DET_DOCUMENTOBE.CANTIDAD1.ToString + "-" + DET_DOCUMENTOBE.ART_COD1
        cmd.ExecuteNonQuery()
        cmd.Dispose()


    End Sub
    Private Sub UpdateRowMD(ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DUP_DOCU"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@sOP", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.TIPO_UNIDAD)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF)
        cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.PROVEEDOR)
        cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_GENE
        cmd.Parameters.Add("@FEC_ENT", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT

        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRowUL(ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal dg As DataGridView, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("ordreq").Value)), "", RTrim(row.Cells("ordreq").Value))
            DET_DOCUMENTOBE.UPRECIO_COMPRA = IIf(IsDBNull(RTrim(row.Cells("afecto").Value)), "", RTrim(row.Cells("afecto").Value))
            DET_DOCUMENTOBE.UPRECIO_AFECTOS = IIf(IsDBNull(RTrim(row.Cells("inafecto").Value)), "", RTrim(row.Cells("inafecto").Value))
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DOCU_UPDSERV"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF)
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF)
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
            cmd.Parameters.Add("@UPRECIO_COMPRA", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.UPRECIO_AFECTOS)
            cmd.Parameters.Add("@T_CAMB", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.T_CAMB)
            cmd.Parameters.Add("@UPRECIO_COMPRA", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.UPRECIO_COMPRA)
            cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.PROVEEDOR)
            cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.TIPO_UNIDAD)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCU_UPDTOSERV"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF)
        cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.PROVEEDOR)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub UpdateRowUT(ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal dg As DataGridView, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim cont As Integer = 0
        'For Each row As DataGridViewRow In dg.Rows
        '    cont = cont + 1
        '    DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("ordreq").Value)), "", RTrim(row.Cells("ordreq").Value))
        '    DET_DOCUMENTOBE.UPRECIO_COMPRA = IIf(IsDBNull(RTrim(row.Cells("afecto").Value)), "", RTrim(row.Cells("afecto").Value))
        '    DET_DOCUMENTOBE.UPRECIO_AFECTOS = IIf(IsDBNull(RTrim(row.Cells("inafecto").Value)), "", RTrim(row.Cells("inafecto").Value))
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCU_UPDTOSERV"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF)
        cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.PROVEEDOR)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        'Next
    End Sub
    Private Sub UpdateTransRow(ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCUMENTO_UPDITESMALM"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF)
        cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
        cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
        cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
        cmd.Parameters.Add("@art_cod1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD1
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
        cmd.Parameters.Add("@cantidad1", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD1
        cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
        cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_MOVINV

        cmd.Parameters.Add("@art_codnew1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD1
        cmd.Parameters.Add("@art_codnew2", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD2
        cmd.Parameters.Add("@alm_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA1

        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = ELMVLOGSBE.log_codope
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Modifico el Documento: " + DET_DOCUMENTOBE.T_DOC_REF + "-" + DET_DOCUMENTOBE.SER_DOC_REF + "-" + DET_DOCUMENTOBE.NRO_DOC_REF + "-" + DET_DOCUMENTOBE.CANTIDAD1.ToString + "-" + DET_DOCUMENTOBE.ART_COD1
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    'Funcion Principal que hara toda la logica para grabar la data
    Public Function SaveRow(ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String,
                            ByVal sAño1 As String) As String
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

            'If flagAccion = "N" Then
            '    ''correlativo = LastCodigo()
            '    ''MonedaBE.mon_codigo = MonedaBE.mon_codigo
            '    InsertRow(DET_DOCUMENTOBE, cn, sqlTrans)

            '    'grabar acceso a los menues
            'End If

            If flagAccion = "M" Then
                UpdateRow(DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, sAño1)
            End If
            If flagAccion = "MG" Then
                UpdateRowMG(DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, sAño1)
            End If
            If flagAccion = "MD" Then
                UpdateRowMD(DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans)
            End If

            'If flagAccion = "UL" Then
            'UpdateRowUL(DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans)
            'End If
            If flagAccion = "MT" Then
                UpdateTransRow(DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans)
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
    Public Function SaveRow1(ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal dg As DataGridView, ByVal flagAccion As String) As String
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
            If flagAccion = "UL" Then
                UpdateRowUL(DET_DOCUMENTOBE, dg, cn, sqlTrans)
            End If
            If flagAccion = "UT" Then
                UpdateRowUT(DET_DOCUMENTOBE, dg, cn, sqlTrans)
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
    Public Function SelectAlm(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SELALM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Public Function SelectAll(ByVal sT_doc As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SELECTALL_ALM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function



End Class
