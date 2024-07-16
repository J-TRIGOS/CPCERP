Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ARTICULODAL

    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumeroD As Double
    Public sNumero1 As String
    Public sNomArt As String = ""
    'Public ELMVLOGSBE As New ELMVLOGSBE

    'Funcion que me ve permitir generar el codigo 
    Public Function LastCodigo(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_LASTCODIGO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Public Function getMedida(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_MED_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            If dt.Rows.Count = 1 Then
                Return dt.Rows(0).Item(0)
            Else
                Return ""
            End If
        Catch ex As Exception

        End Try


    End Function

    Public Function getUniMed(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_UNIMED", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            If dt.Rows.Count = 1 Then
                Return dt.Rows(0).Item(0)
            Else
                Return ""
            End If
        Catch ex As Exception

        End Try


    End Function

    Public Function getMedida_old(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_MED_COD_OLD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            If dt.Rows.Count = 1 Then
                Return dt.Rows(0).Item(0)
            Else
                Return ""
            End If
        Catch ex As Exception

        End Try


    End Function

    Public Function LastCodAntiguo() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_LASTCOD_ANTIGUO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Public Function SetStock(ByVal sCode As String) As Double
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_STK_ACT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        End If
    End Function
    Public Function CodCCNU() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_CCNU", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function CodCCNU1() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_CCNU1", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelPreOrd(ByVal sArt As String, ByVal sCTCT As String, ByVal sMoneda As String) As Double
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_PRE_ORD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sArt", sArt),
                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("@sCTCT", sCTCT),
                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("@sMoneda", sMoneda)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        End If
    End Function
    Public Function SelPreFec(ByVal sArt As String, ByVal sCTCT As String, ByVal sMoneda As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_PRE_FEC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sArt", sArt),
                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("@sCTCT", sCTCT),
                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("@sMoneda", sMoneda)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        End If
    End Function
    Public Function SetPrecio(ByVal sCode As String, ByVal sCliente As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_DETDOCUMENTO_PREVEN", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode),
                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@cliente", sCliente)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Try
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item(1)
            End If
        Catch ex As Exception

        End Try

    End Function
    Public Function SetPrecio1(ByVal sCode As String, ByVal sCliente As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_DETDOCUMENTO_PREVEN", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode),
                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@cliente", sCliente)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Try
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item(0)
            End If
        Catch ex As Exception

        End Try
    End Function
    'Metodo para registrar un nuevo 
    Private Sub InsertRow(ByVal ARTICULOBE As ARTICULOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ARTICULO_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ARTICULOBE.art_cod
        cmd.Parameters.Add("@art_descri", OracleDbType.Varchar2).Value = ARTICULOBE.art_descri
        cmd.Parameters.Add("@art_slinea", OracleDbType.Char).Value = ARTICULOBE.art_slinea
        cmd.Parameters.Add("@ccosto_cod", OracleDbType.Char).Value = ARTICULOBE.ccosto_cod
        cmd.Parameters.Add("@alm_cod", OracleDbType.Char).Value = ARTICULOBE.alm_cod
        cmd.Parameters.Add("@uni_cod", OracleDbType.Char).Value = ARTICULOBE.uni_cod
        'cmd.Parameters.Add("@ubi_artcod", OracleDbType.Char).Value = ARTICULOBE.ubi_artcod
        cmd.Parameters.Add("@est", OracleDbType.Char).Value = ARTICULOBE.est
        cmd.Parameters.Add("@x_kardex", OracleDbType.Char).Value = ARTICULOBE.x_kardex
        cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ARTICULOBE.cod
        cmd.Parameters.Add("@nom", OracleDbType.Char).Value = ARTICULOBE.nom
        cmd.Parameters.Add("@art_codcat", OracleDbType.Char).Value = ARTICULOBE.art_codcat
        cmd.Parameters.Add("@fam1", OracleDbType.Char).Value = ARTICULOBE.fam1
        cmd.Parameters.Add("@fam2", OracleDbType.Char).Value = ARTICULOBE.fam2
        cmd.Parameters.Add("@fam3", OracleDbType.Char).Value = ARTICULOBE.fam3
        cmd.Parameters.Add("@fam4", OracleDbType.Char).Value = ARTICULOBE.fam4
        cmd.Parameters.Add("@fam5", OracleDbType.Char).Value = ARTICULOBE.fam5
        cmd.Parameters.Add("@part_apreq", OracleDbType.Varchar2).Value = ARTICULOBE.art_aproreq
        cmd.Parameters.Add("@temp_art", OracleDbType.Varchar2).Value = ARTICULOBE.temp_art
        cmd.Parameters.Add("@stkmin", OracleDbType.Double).Value = ARTICULOBE.stkmin
        cmd.Parameters.Add("@medida", OracleDbType.Varchar2).Value = ARTICULOBE.medida
        cmd.Parameters.Add("@medida_nuevo", OracleDbType.Varchar2).Value = ARTICULOBE.medida_nuevo
        cmd.Parameters.Add("@cod_proc", OracleDbType.Varchar2).Value = ARTICULOBE.cod_proc
        cmd.Parameters.Add("@solm", OracleDbType.Varchar2).Value = ARTICULOBE.art_solm
        cmd.Parameters.Add("@fec_ini", OracleDbType.Date).Value = ARTICULOBE.fecini
        cmd.Parameters.Add("@cod_sunat", OracleDbType.Varchar2).Value = ARTICULOBE.codsunat
        cmd.Parameters.Add("@pEST_INIOP", OracleDbType.Varchar2).Value = ARTICULOBE.est_trabajo
        cmd.Parameters.Add("@pFEC_INIOP", OracleDbType.Varchar2).Value = ARTICULOBE.fec_initra
        cmd.Parameters.Add("@pFEC_FINOP", OracleDbType.Varchar2).Value = ARTICULOBE.fec_fintra
        cmd.Parameters.Add("@pEST_BAJA", OracleDbType.Varchar2).Value = ARTICULOBE.est_baja
        cmd.Parameters.Add("@pMOT_BAJA", OracleDbType.Varchar2).Value = ARTICULOBE.mot_baja
        cmd.Parameters.Add("@pFEC_BAJA", OracleDbType.Varchar2).Value = ARTICULOBE.fec_baja
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_EL_TBARTSTOCK_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pART_CODIGO", OracleDbType.Char).Value = ARTICULOBE.art_cod
        cmd.Parameters.Add("pART_CODALM", OracleDbType.Char).Value = ARTICULOBE.ubi_artcod
        cmd.Parameters.Add("pART_STOACT", OracleDbType.Double).Value = 0
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_EL_TBARTSTOCK2023INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pART_CODIGO", OracleDbType.Char).Value = ARTICULOBE.art_cod
        cmd.Parameters.Add("pART_CODALM", OracleDbType.Char).Value = ARTICULOBE.ubi_artcod
        cmd.Parameters.Add("pART_STOACT", OracleDbType.Double).Value = 0
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el articulo: " + ARTICULOBE.art_cod
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub InsertRow1(ByVal ARTICULOBE As ARTICULOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ARTICULO_INSERTROW1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ARTICULOBE.art_cod
        cmd.Parameters.Add("@art_descri", OracleDbType.Varchar2).Value = ARTICULOBE.art_descri
        cmd.Parameters.Add("@art_slinea", OracleDbType.Char).Value = ARTICULOBE.art_slinea
        cmd.Parameters.Add("@ccosto_cod", OracleDbType.Char).Value = ARTICULOBE.ccosto_cod
        cmd.Parameters.Add("@alm_cod", OracleDbType.Char).Value = ARTICULOBE.alm_cod
        cmd.Parameters.Add("@uni_cod", OracleDbType.Char).Value = ARTICULOBE.uni_cod
        'cmd.Parameters.Add("@ubi_artcod", OracleDbType.Char).Value = ARTICULOBE.ubi_artcod
        cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ARTICULOBE.cod
        cmd.Parameters.Add("@nom", OracleDbType.Char).Value = ARTICULOBE.nom
        cmd.Parameters.Add("@part_apreq", OracleDbType.Varchar2).Value = ARTICULOBE.art_aproreq
        cmd.Parameters.Add("@temp_art", OracleDbType.Varchar2).Value = ARTICULOBE.temp_art
        cmd.Parameters.Add("@medida", OracleDbType.Varchar2).Value = ARTICULOBE.medida
        cmd.Parameters.Add("@medida_nuevo", OracleDbType.Varchar2).Value = ARTICULOBE.medida_nuevo
        cmd.Parameters.Add("@cod_proc", OracleDbType.Varchar2).Value = ARTICULOBE.cod_proc
        cmd.Parameters.Add("@art_solm", OracleDbType.Varchar2).Value = ARTICULOBE.art_solm
        cmd.Parameters.Add("@pEST_INIOP", OracleDbType.Varchar2).Value = ARTICULOBE.est_trabajo
        cmd.Parameters.Add("@pFEC_INIOP", OracleDbType.Varchar2).Value = ARTICULOBE.fec_initra
        cmd.Parameters.Add("@pFEC_FINOP", OracleDbType.Varchar2).Value = ARTICULOBE.fec_fintra
        cmd.Parameters.Add("@pEST_BAJA", OracleDbType.Varchar2).Value = ARTICULOBE.est_baja
        cmd.Parameters.Add("@pMOT_BAJA", OracleDbType.Varchar2).Value = ARTICULOBE.mot_baja
        cmd.Parameters.Add("@pFEC_BAJA", OracleDbType.Varchar2).Value = ARTICULOBE.fec_baja
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_EL_TBARTSTOCK_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pART_CODIGO", OracleDbType.Char).Value = ARTICULOBE.art_cod
        cmd.Parameters.Add("pART_CODALM", OracleDbType.Char).Value = ARTICULOBE.ubi_artcod
        cmd.Parameters.Add("pART_STOACT", OracleDbType.Double).Value = 0
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_EL_TBARTSTOCK2018INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pART_CODIGO", OracleDbType.Char).Value = ARTICULOBE.art_cod
        cmd.Parameters.Add("pART_CODALM", OracleDbType.Char).Value = ARTICULOBE.ubi_artcod
        cmd.Parameters.Add("pART_STOACT", OracleDbType.Double).Value = 0
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_EL_TBARTSTOCK2019INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pART_CODIGO", OracleDbType.Char).Value = ARTICULOBE.art_cod
        cmd.Parameters.Add("pART_CODALM", OracleDbType.Char).Value = ARTICULOBE.ubi_artcod
        cmd.Parameters.Add("pART_STOACT", OracleDbType.Double).Value = 0
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_EL_TBARTSTOCK2020INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pART_CODIGO", OracleDbType.Char).Value = ARTICULOBE.art_cod
        cmd.Parameters.Add("pART_CODALM", OracleDbType.Char).Value = ARTICULOBE.ubi_artcod
        cmd.Parameters.Add("pART_STOACT", OracleDbType.Double).Value = 0
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_EL_TBARTSTOCK2021INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pART_CODIGO", OracleDbType.Char).Value = ARTICULOBE.art_cod
        cmd.Parameters.Add("pART_CODALM", OracleDbType.Char).Value = ARTICULOBE.ubi_artcod
        cmd.Parameters.Add("pART_STOACT", OracleDbType.Double).Value = 0
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_EL_TBARTSTOCK2022INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pART_CODIGO", OracleDbType.Char).Value = ARTICULOBE.art_cod
        cmd.Parameters.Add("pART_CODALM", OracleDbType.Char).Value = ARTICULOBE.ubi_artcod
        cmd.Parameters.Add("pART_STOACT", OracleDbType.Double).Value = 0
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el articulo: " + ARTICULOBE.art_cod
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    'Metodo para Modificar 
    Private Sub UpdateRow(ByVal ARTICULOBE As ARTICULOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE)
        'realiza registro del catalogo
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ARTICULO_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("part_cod", OracleDbType.Char).Value = ARTICULOBE.art_cod
        cmd.Parameters.Add("part_descri", OracleDbType.Varchar2).Value = ARTICULOBE.art_descri
        cmd.Parameters.Add("part_slinea", OracleDbType.Varchar2).Value = ARTICULOBE.art_slinea
        cmd.Parameters.Add("pccosto_cod", OracleDbType.Char).Value = ARTICULOBE.ccosto_cod
        cmd.Parameters.Add("palm_cod", OracleDbType.Varchar2).Value = ARTICULOBE.alm_cod
        cmd.Parameters.Add("puni_cod", OracleDbType.Varchar2).Value = ARTICULOBE.uni_cod
        'cmd.Parameters.Add("pubi_artcod", OracleDbType.Varchar2).Value = ARTICULOBE.ubi_artcod
        cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = ARTICULOBE.est
        cmd.Parameters.Add("px_kardex", OracleDbType.Varchar2).Value = ARTICULOBE.x_kardex
        cmd.Parameters.Add("pcod", OracleDbType.Varchar2).Value = ARTICULOBE.cod
        cmd.Parameters.Add("pnom", OracleDbType.Char).Value = ARTICULOBE.nom
        cmd.Parameters.Add("part_codcat", OracleDbType.Char).Value = ARTICULOBE.art_codcat
        cmd.Parameters.Add("pfam1", OracleDbType.Varchar2).Value = ARTICULOBE.fam1
        cmd.Parameters.Add("pfam2", OracleDbType.Varchar2).Value = ARTICULOBE.fam2
        cmd.Parameters.Add("pfam3", OracleDbType.Varchar2).Value = ARTICULOBE.fam3
        cmd.Parameters.Add("pfam4", OracleDbType.Varchar2).Value = ARTICULOBE.fam4
        cmd.Parameters.Add("pfam5", OracleDbType.Varchar2).Value = ARTICULOBE.fam5
        cmd.Parameters.Add("part_apreq", OracleDbType.Varchar2).Value = ARTICULOBE.art_aproreq
        cmd.Parameters.Add("pstkmin", OracleDbType.Double).Value = ARTICULOBE.stkmin
        cmd.Parameters.Add("pmedida", OracleDbType.Varchar2).Value = ARTICULOBE.medida
        cmd.Parameters.Add("pmedida_nuevo", OracleDbType.Varchar2).Value = ARTICULOBE.medida_nuevo
        cmd.Parameters.Add("pcod_proc", OracleDbType.Varchar2).Value = ARTICULOBE.cod_proc
        cmd.Parameters.Add("@solm", OracleDbType.Varchar2).Value = ARTICULOBE.art_solm
        cmd.Parameters.Add("@fec_ini", OracleDbType.Date).Value = ARTICULOBE.fecini
        cmd.Parameters.Add("@cod_sunat", OracleDbType.Varchar2).Value = ARTICULOBE.codsunat
        cmd.Parameters.Add("@pEST_INIOP", OracleDbType.Varchar2).Value = ARTICULOBE.est_trabajo
        cmd.Parameters.Add("@pFEC_INIOP", OracleDbType.Varchar2).Value = ARTICULOBE.fec_initra
        cmd.Parameters.Add("@pFEC_FINOP", OracleDbType.Varchar2).Value = ARTICULOBE.fec_fintra
        cmd.Parameters.Add("@pEST_BAJA", OracleDbType.Varchar2).Value = ARTICULOBE.est_baja
        cmd.Parameters.Add("@pMOT_BAJA", OracleDbType.Varchar2).Value = ARTICULOBE.mot_baja
        cmd.Parameters.Add("@pFEC_BAJA", OracleDbType.Varchar2).Value = ARTICULOBE.fec_baja
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Modifico el articulo: " + ARTICULOBE.art_cod + " " + ARTICULOBE.art_descri + "a" + ARTICULOBE.art_descritemp
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub UpdateRow1(ByVal ARTICULOBE As ARTICULOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ARTICULO_UPDATEROW1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ARTICULOBE.art_cod
        cmd.Parameters.Add("@art_descri", OracleDbType.Char).Value = ARTICULOBE.art_descri
        cmd.Parameters.Add("@art_slinea", OracleDbType.Char).Value = ARTICULOBE.art_slinea
        cmd.Parameters.Add("@ccosto_cod", OracleDbType.Char).Value = ARTICULOBE.ccosto_cod
        cmd.Parameters.Add("@alm_cod", OracleDbType.Char).Value = ARTICULOBE.alm_cod
        cmd.Parameters.Add("@uni_cod", OracleDbType.Char).Value = ARTICULOBE.uni_cod
        'cmd.Parameters.Add("@ubi_artcod", OracleDbType.Char).Value = ARTICULOBE.ubi_artcod
        cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ARTICULOBE.cod
        cmd.Parameters.Add("@part_apreq", OracleDbType.Varchar2).Value = ARTICULOBE.art_aproreq
        cmd.Parameters.Add("@temp_art", OracleDbType.Varchar2).Value = ARTICULOBE.temp_art
        cmd.Parameters.Add("@medida", OracleDbType.Varchar2).Value = ARTICULOBE.medida
        cmd.Parameters.Add("@medida_nuevo", OracleDbType.Varchar2).Value = ARTICULOBE.medida_nuevo
        cmd.Parameters.Add("@cod_proc", OracleDbType.Varchar2).Value = ARTICULOBE.cod_proc
        cmd.Parameters.Add("@art_solm", OracleDbType.Varchar2).Value = ARTICULOBE.art_solm
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Modifico el articulo: " + ARTICULOBE.art_cod + " " + ARTICULOBE.art_descri + "a" + ARTICULOBE.art_descritemp
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdatePrecio(ByVal ARTICULOBE As ARTICULOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE)
        'realiza registro del catalogo
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ARTICULO_UPD_PRE"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("part_cod", OracleDbType.Char).Value = ARTICULOBE.art_cod
        cmd.Parameters.Add("pprecio", OracleDbType.Double).Value = ARTICULOBE.precio
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Modifico el precio del articulo: " & ARTICULOBE.art_cod & " a " & ARTICULOBE.precio
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdatePrecio1(ByVal ARTICULOBE As ARTICULOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE)
        'realiza registro del catalogo
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ARTICULO_UPD_PRE_01"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("part_cod", OracleDbType.Char).Value = ARTICULOBE.art_cod
        cmd.Parameters.Add("pprecio", OracleDbType.Double).Value = ARTICULOBE.precio
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateKardex(ByVal ARTICULOBE As ARTICULOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ARTICULO_UDPK"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ARTICULOBE.art_cod
        cmd.Parameters.Add("@x_kardex", OracleDbType.Char).Value = ARTICULOBE.x_kardex
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ARTICULOBE As ARTICULOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ARTICULO_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@art_cod", OracleDbType.Char).Value = ARTICULOBE.art_cod

        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub UpdateFamilia(ByVal ARTICULOBE As ARTICULOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ARTICULO_UDMF"
        cmd.Connection = sqlCon
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("cod", OracleDbType.Varchar2).Value = ARTICULOBE.art_cod
        cmd.Parameters.Add("familia", OracleDbType.Varchar2).Value = ARTICULOBE.fam1
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Modifico la familia del articulo: " & ARTICULOBE.art_cod & " de " & ARTICULOBE.fam2 & " a " & ARTICULOBE.fam1
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    'Funcion Principal que hara toda la logica para grabar la data
    Public Function SaveRow(ByVal ARTICULOBE As ARTICULOBE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE) As String
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
                InsertRow(ARTICULOBE, cn, sqlTrans, ELMVLOGSBE)

                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                UpdateRow(ARTICULOBE, cn, sqlTrans, ELMVLOGSBE)
            End If

            If flagAccion = "E" Then
                DeleteRow(ARTICULOBE, cn, sqlTrans, ELMVLOGSBE)
            End If

            If flagAccion = "PRECIO" Then
                UpdatePrecio(ARTICULOBE, cn, sqlTrans, ELMVLOGSBE)
            End If

            If flagAccion = "PRECIO1" Then
                UpdatePrecio1(ARTICULOBE, cn, sqlTrans, ELMVLOGSBE)
            End If
            If flagAccion = "MK" Then 'actualizar Kardex
                UpdateKardex(ARTICULOBE, cn, sqlTrans, ELMVLOGSBE)
            End If
            If flagAccion = "MF" Then 'actualizar Familia
                UpdateFamilia(ARTICULOBE, cn, sqlTrans, ELMVLOGSBE)
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
            If resultado = "OK" And flagAccion <> "M" And flagAccion <> "MK" And flagAccion <> "MF" Then
                cn.Dispose()
            End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function

    Public Function SaveRowfast(ByVal ARTICULOBE As ARTICULOBE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE) As String
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
                InsertRow1(ARTICULOBE, cn, sqlTrans, ELMVLOGSBE)
                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                UpdateRow1(ARTICULOBE, cn, sqlTrans, ELMVLOGSBE)
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
            'If resultado = "OK" And flagAccion <> "M" And flagAccion <> "MK" And flagAccion <> "MF" Then
            '    cn.Dispose()
            'End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function

    'Funcion que me va permitir capturar la lista de registros en la tabla y que me va retornar
    'un Datatable
    Public Function SelectRow(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SelectRow", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRow1(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELPRE_ANHO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getListdgv(ByVal sCodecat As String, ByVal sCodeart As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_CAR_DATO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCodecat), New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCodeart)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getListdgvAct(ByVal sCodecat As String, ByVal sCodeart As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_CAR_DATO_ACTIVO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCodecat), New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCodeart)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getListdgvVehi(ByVal sCodecat As String, ByVal sCodeart As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_CAR_DATO_VEHI", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCodecat), New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCodeart)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getListdgv1(ByVal sCodeArt As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_COMP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCodeArt)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getListdgv2(ByVal sCodeArt As String) As DataTable ', ByVal sIndex As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_COMP1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCodeArt)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function getListdgv4(ByVal sCodeArt As String, ByVal sCodeArt1 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_COMP6", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCodeArt),
                                                                              New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCodeArt1)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    'CREADO PARA PROBAR
    Public Function getListdgv5(ByVal sCodeArt As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_COMP5", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCodeArt)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getListdgv3(ByVal sCodeArt As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_COMP_TMP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCodeArt)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function


    Public Function getListdgv4(ByVal sCodeArt As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_COMP2", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCodeArt)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getListdgv6(ByVal sCodeArt As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_COMP3", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCodeArt)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function getListdgv7(ByVal sCodeArt As String, ByVal opcion As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_COMP4", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCodeArt),
                                                                             New Oracle.ManagedDataAccess.Client.OracleParameter("@code", opcion)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAll(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SelectAll", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAll1(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SelectAll1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelectELTBARTSTOCKALL(ByVal sCode As String, ByVal sAlm As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBARTSTOCK_SELALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@codalm", sAlm)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelectAllprecio(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SEL_PRECIO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectArt(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SelectArt", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectArt5(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SelectArt5", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectUniMed(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SelectUni", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            While dr.Read
                sUnid = dr.GetString(0)
            End While
        End Using
        Return sUnid
    End Function

    Public Function SelectNomGrupCor(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SELGRUPCORNOM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            While dr.Read
                sUnid = dr.GetString(0)
            End While
        End Using
        Return sUnid
    End Function

    Public Function SelectNom(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELNOMART", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            While dr.Read
                sUnid = dr.GetString(0)
            End While
        End Using
        Return sUnid
    End Function

    Public Function SelectNomCCNU(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBCCNU_SELNOMART", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            While dr.Read
                sUnid = dr.GetString(0)
            End While
        End Using
        Return sUnid
    End Function
    Public Function SelVerSerSolm(ByVal sCode As String, ByVal sSer As String, ByVal sNro As String, ByVal sArt As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDEN_PROGRAM_SOLMSER", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sCode", Trim(sCode)),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@sSer", Trim(sSer)),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@sNro", Trim(sNro)),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@sArt", Trim(sArt))})
            While dr.Read
                If dr.GetString(0) = "-" Then
                    sNumero1 = ""
                Else
                    sNumero1 = dr.GetString(0)
                End If

            End While
        End Using
        Return sNumero1

    End Function

    Public Function SelVerNroSolm(ByVal sCode As String, ByVal sSer As String, ByVal sNro As String, ByVal sArt As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDEN_PROGRAM_SOLMNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sCode", Trim(sCode)),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@sSer", Trim(sSer)),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@sNro", Trim(sNro)),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@sArt", Trim(sArt))})
            While dr.Read
                If dr.GetString(0) = "-" Then
                    sNumero1 = ""
                Else
                    sNumero1 = dr.GetString(0)
                End If
            End While
        End Using
        Return sNumero1

    End Function

    Public Function SelectNro(ByVal sCode As String, ByVal sSer As String) As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELECTNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode)),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sSer))})
            '    While dr.Read
            '        sNumero = dr.GetInt32(0)
            '    End While
            'End Using
            'Return sNumero
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If Val(dt.Rows(0).Item(0).ToString) > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 1
        End If
    End Function

    Public Function SelPrecioArt(ByVal sCode As String) As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_PREART", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode))})
            '    While dr.Read
            '        sNumero = dr.GetInt32(0)
            '    End While
            'End Using
            'Return sNumero
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If Val(dt.Rows(0).Item(0).ToString) > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 1
        End If
    End Function

    Public Function SelectNro1(ByVal sCode As String, ByVal sSer As String, ByVal sfec As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELECTNRO1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode)),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sSer)),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@pFEC_GENE", Trim(sfec))})
            While dr.Read
                sNumero1 = dr.GetString(0)
            End While
        End Using
        Return sNumero1

    End Function

    Public Function SelectAct() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELECACT", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectAct1(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        sNomArt = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELECACT1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            While dr.Read
                sNomArt = dr.GetString(1)
            End While
        End Using
        Return sNomArt
    End Function

    Public Function SelectArt1(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SelectArt1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectArt6(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SelectArt6", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectArt2(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        'Try
        sNomArt = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SelectArt2", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            While dr.Read
                sNomArt = dr.GetString(0)
            End While
        End Using
        Return sNomArt
    End Function

    Public Function SelectArt7(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        'Try
        sNomArt = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SEARCH7", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            While dr.Read
                If IsDBNull(dr.GetString(0)) Then
                    sNomArt = ""
                Else
                    sNomArt = dr.GetString(0)
                End If
            End While
        End Using
        Return sNomArt
    End Function

    Public Function SelectArt3(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNomArt = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SelectArt3", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            While dr.Read

                If IsDBNull(dr.GetString(0)) Then
                    sNomArt = ""
                Else
                    sNomArt = dr.GetString(0)
                End If
            End While
        End Using
        Return sNomArt
    End Function


    Public Function SelectContar(ByVal sCode As String, ByVal sCtct As String) As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_CONTAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode),
                                                                                                              New Oracle.ManagedDataAccess.Client.OracleParameter("@sCtct", sCtct)})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero

    End Function

    Public Function ContRep(ByVal sCode As String, ByVal sCtct As String) As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTCOUNT_CMP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode),
                                                                                                            New Oracle.ManagedDataAccess.Client.OracleParameter("@sCtct", sCtct)})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero

    End Function

#Region "Listar Combos"
    Function getListcmb() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_LINES", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getListSerArtD(ByVal sTip As String, ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELECTDEV", {New Oracle.ManagedDataAccess.Client.OracleParameter("@tipo", sTip),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using

        Return dt
    End Function

    Function getListNroArtD(ByVal sTip As String, ByVal sSer As String, ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELECTNDEV", {New Oracle.ManagedDataAccess.Client.OracleParameter("@tipo", sTip),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@ser", sSer),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using

        Return dt
    End Function

    Function ListadoCC() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BUSCAR_CC_COSTEO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getListcmb1() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_LINESS", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getListcmb2() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_LINESX", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getListcmblin1() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_LINES2", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getListLinearticulo() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_LINES1", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getListcmb1(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SUBLINES", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function SelectCCxArt(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CC_X_ARTICULO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getcmbsub1(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SUBLINES4", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function SelectDescripcion3(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SUBLINES3", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getListSubLinea1(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SUBLINES2", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getListSubLin() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_LINSUB", {New Oracle.ManagedDataAccess.Client.OracleParameter()})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getListcmb2(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SUBLINES1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getListcmb3() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_FAMILIA1", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getListcmb4() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_FAMILIA2", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getListcmb5() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_FAMILIA3", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getListcmb6() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_FAMILIA4", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getListcmb7() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_FAMILIA5", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getListcmb8() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_UNI", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function Art_CompExp(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_CMPEXP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getListcmb9() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_CCOSTO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getListcmb10() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_CATALOGO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getListcmb11() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_ALM", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getListcmb12() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_MEDIDA", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getListcmb13() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_LINEA", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getListcmb14() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_MEDIDA_NUEVO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getListcmb15(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        sNomArt = ""
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_MEDIDA_ANT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            While dr.Read
                sNomArt = dr.GetString(0)
            End While
        End Using
        Return sNomArt
    End Function
    Function art_cco(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        sNomArt = ""
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_CCOCOD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            While dr.Read
                sNomArt = dr.GetString(0)
            End While
        End Using
        Return sNomArt
    End Function
    Function ProcNom(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        sNomArt = ""
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_PROCNOM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            While dr.Read
                sNomArt = dr.GetString(0)
            End While
        End Using
        Return sNomArt
    End Function
    Function VerProc(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        sNomArt = ""
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_VERPROC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            While dr.Read
                sNomArt = dr.GetString(0)
            End While
        End Using
        Return sNomArt
    End Function
    Function getArticuloAnterior() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SEARCH", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getArticuloAntE17() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SEARCHE17", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getArticuloAnterior1() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SEARCH1", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getArticuloActivo() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SEARCH_ACTIVO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getArticuloAnterior2() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SEARCH3", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getArticuloAnterior4() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SEARCH4", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getArticuloAnterior5() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SEARCH5", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getArticuloAnterior6() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SEARCH6", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getArticuloAnterior7() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELECTART8", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getArticuloAnterior8() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SEARCH8", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getArtLineaSub(ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SEARCHLINSUB", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getArticulocliente(ByVal sRuc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SEARCH_CLI", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sRuc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getArtMant() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SEARCHMAN", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getOpciones(ByVal sCat As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CARAVAL_SELECTVAL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCat)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getArtstk(ByVal sCodAlm As String, ByVal sSubLinea As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_STK", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ART_SLINEA", sSubLinea),
                                                                            New Oracle.ManagedDataAccess.Client.OracleParameter("@ART_CODALM", sCodAlm)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectArticuloStock(ByVal sCod As String, ByVal sAlm As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_VERIFICAR_STOCK_FISICO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sCod", sCod),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@sAlm", sAlm)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function verificarUSuario(ByVal codUser As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_VERIFICAR_CCO_USER", {New Oracle.ManagedDataAccess.Client.OracleParameter("@CODUSER", codUser)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

#End Region

    Public Function ReporteKardex(ByVal flagAccion As String, ByVal ARTICULOBE As ARTICULOBE) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try

            If flagAccion = "stockprecio" Then
                MOVIM_STOCK(cn, sqlTrans, ARTICULOBE)
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
    Public Function UpdRow(ByVal ARTICULOBE As ARTICULOBE, ByVal flagAccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction
        Try
            UpdCant(ARTICULOBE, cn, sqlTrans)
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
            '    If flagAccion <> "DS" And flagAccion <> "AS" And flagAccion <> "CSM" And flagAccion <> "N" Then
            '        cn.Dispose()
            '    End If

            'End If
            sqlTrans = Nothing
        End Try
        Return resultado
    End Function
    Private Sub UpdCant(ByVal ARTICULOBE As ARTICULOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        'Dim contenedor1 As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_AJUSTART_UPDATE"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@alm_cod", OracleDbType.Varchar2).Value = ARTICULOBE.alm_cod '1
        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ARTICULOBE.anho '2
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ARTICULOBE.art_cod '3
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Sub MOVIM_STOCK(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ARTICULOBE As ARTICULOBE)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        'Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "DELETE FROM EL_RPTKARNEGATIVO"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.Text
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ARTICULO_PRECIO_REPORTE"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@DATE1", OracleDbType.Varchar2).Value = ARTICULOBE.fam1
        cmd.Parameters.Add("@DATE2", OracleDbType.Varchar2).Value = ARTICULOBE.fam2
        cmd.Parameters.Add("@altura1", OracleDbType.Varchar2).Value = ARTICULOBE.precio
        cmd.Parameters.Add("@altura2", OracleDbType.Varchar2).Value = ARTICULOBE.stkmin
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

End Class
