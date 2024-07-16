Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELPERIODODAL

    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNumero2 As Double
    Public sNomArt As String
    Public ELMVLOGSBE As New ELMVLOGSBE

    Public Function SelectAll(ByVal Anho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PERIODO_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", Anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectQuinta(ByVal sPRDO As String, ByVal sCPTO As String, ByVal sTPAGO As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PERIODO_SELQUINTA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sPRDO", sPRDO),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@sCPTO", sCPTO),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@sTPAGO", sTPAGO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function VerificarLinea(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNomArt = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_LINEA_CLIENTE", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
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

    Public Function ContarRegistros() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNomArt = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TAREO_CONTAREG", {})
            While dr.Read

                sNomArt = dr.GetString(0)

            End While
        End Using
        Return sNomArt
    End Function

    Public Function SelectFecPRd(ByVal sCod As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNomArt = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PERIODO_SELFEC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCod)})
            While dr.Read
                sNomArt = dr.GetString(0)
            End While
        End Using
        Return sNomArt
    End Function

    Public Function SelEstPrdo(ByVal sCod As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNomArt = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PERIODO_X_CONT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCod)})
            While dr.Read
                sNomArt = dr.GetString(0)
            End While
        End Using
        Return sNomArt
    End Function

    Public Function SelPrdoMonto(ByVal sCod As String) As Double
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNumero2 = 0
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CPTO_PRDOMONTO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCod)})
            While dr.Read
                sNumero2 = dr.GetDouble(0)
            End While
        End Using
        Return sNumero2
    End Function

    Public Function SelPorc1Monto(ByVal sCod As String, ByVal sAnho As String) As Double
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNumero2 = 0
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PORC1_MONTO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCod),
                                                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@sAnho", sAnho)})
            While dr.Read
                sNumero2 = dr.GetDouble(0)
            End While
        End Using
        Return sNumero2
    End Function

    Public Function SelPorc2Monto(ByVal sCod As String, ByVal sAnho As String) As Double
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNumero2 = 0
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PORC2_MONTO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCod),
                                                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@sAnho", sAnho)})
            While dr.Read
                sNumero2 = dr.GetDouble(0)
            End While
        End Using
        Return sNumero2
    End Function

    Public Function ContarRegistros(ByVal sCod As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNomArt = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TAREO_CONTAREG", {})
            While dr.Read
                sNomArt = dr.GetString(0)
            End While
        End Using
        Return sNomArt
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

    Public Function SelectPerCOD(ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PERSONAL_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PERIODO_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@scode", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRowGrid(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TAREO_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectCIIU() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CLIENTE_CIIU", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectUbigeo() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CLIENTE_UBIGEO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectMaxPeriodo() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PERIODO_LASTCOD", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function
    Public Function SelUIT() As Double
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CALCPLA_SELQUIN", {})
            While dr.Read
                sNumero2 = dr.GetDouble(0)
            End While
        End Using
        Return sNumero2
    End Function
    Public Function VerificarRepetido(ByVal anho As String, ByVal mes As String) As Boolean
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PERIODO_VERIFICAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                       New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", mes)})
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function

    Public Function SelectPeriodoCOD(ByVal anho As String, ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PERIODO_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectPeriodo(ByVal anho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PERIODO_BUSQUEDA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectSuspenCOD(ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SUSPENSION_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectSuspension() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SUSPENSION_BUSQUEDA", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectVendeCod(ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_VENDE_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectCondicionCod(ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_CONDICION_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectPrdoAct() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SELECT_PRDOCONT_ACT", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectPrdoActAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SELECT_PRDOCONT_ACTALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Private Sub InsertRow(ByVal ELPERIODOBE As ELPERIODOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PERIODO_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 

        cmd.Parameters.Add("@cod", OracleDbType.Double).Value = ELPERIODOBE.cod
        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELPERIODOBE.anho
        cmd.Parameters.Add("@nromes", OracleDbType.Varchar2).Value = ELPERIODOBE.nromes
        cmd.Parameters.Add("@num", OracleDbType.Double).Value = ELPERIODOBE.num
        If ELPERIODOBE.fec_ini = Nothing Then
            cmd.Parameters.Add("@fec_ini", OracleDbType.Date).Value = DBNull.Value
            cmd.Parameters.Add("@fec_fin", OracleDbType.Date).Value = DBNull.Value
        Else
            cmd.Parameters.Add("@fec_ini", OracleDbType.Date).Value = ELPERIODOBE.fec_ini
            cmd.Parameters.Add("@fec_fin", OracleDbType.Date).Value = ELPERIODOBE.fec_fin
        End If
        cmd.Parameters.Add("@fec_pag", OracleDbType.Date).Value = ELPERIODOBE.fec_pag
        cmd.Parameters.Add("@t_per_cod", OracleDbType.Varchar2).Value = ELPERIODOBE.t_per_cod
        cmd.Parameters.Add("@x_cont", OracleDbType.Varchar2).Value = ELPERIODOBE.x_cont
        cmd.Parameters.Add("@nroant", OracleDbType.Double).Value = ELPERIODOBE.nroant
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBTAREOBE.id  'cod usu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registro la asistencia : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub

    Private Sub UpdateRow(ByVal ELPERIODOBE As ELPERIODOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim cont As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PERIODO_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@cod", OracleDbType.Double).Value = ELPERIODOBE.cod
        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELPERIODOBE.anho
        cmd.Parameters.Add("@nromes", OracleDbType.Varchar2).Value = ELPERIODOBE.nromes
        cmd.Parameters.Add("@num", OracleDbType.Double).Value = ELPERIODOBE.num
        If ELPERIODOBE.fec_ini = Nothing Then
            cmd.Parameters.Add("@fec_ini", OracleDbType.Date).Value = DBNull.Value
            cmd.Parameters.Add("@fec_fin", OracleDbType.Date).Value = DBNull.Value
        Else
            cmd.Parameters.Add("@fec_ini", OracleDbType.Date).Value = ELPERIODOBE.fec_ini
            cmd.Parameters.Add("@fec_fin", OracleDbType.Date).Value = ELPERIODOBE.fec_fin
        End If
        cmd.Parameters.Add("@fec_pag", OracleDbType.Date).Value = ELPERIODOBE.fec_pag
        cmd.Parameters.Add("@t_per_cod", OracleDbType.Varchar2).Value = ELPERIODOBE.t_per_cod
        cmd.Parameters.Add("@x_cont", OracleDbType.Varchar2).Value = ELPERIODOBE.x_cont
        cmd.Parameters.Add("@nroant", OracleDbType.Double).Value = ELPERIODOBE.nroant
        cmd.ExecuteNonQuery()
        cmd.Dispose()


        '''AUDITORIA
        ''cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        ''cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        ''cmd.Connection = sqlCon
        ''cmd.Transaction = sqlTrans
        ''cmd.CommandType = CommandType.StoredProcedure
        ''cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        ''cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBTAREOBE.usuactu
        ''cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el la asistencia : " + ELTBTAREOBE.cod + " de " + ELTBTAREOBE.fecha + " a " + ELTBTAREOBE.fecha_ingreso
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub

    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ELPERIODOBE As ELPERIODOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TAREO_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Public Function SaveRow(ByVal ELPERIODOBE As ELPERIODOBE, ByVal flagAccion As String) As String
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
                InsertRow(ELPERIODOBE, cn, sqlTrans)
            End If
            If flagAccion = "M" Then
                UpdateRow(ELPERIODOBE, cn, sqlTrans)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELPERIODOBE, cn, sqlTrans)
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
            If resultado = "OK" And flagAccion <> "E" Then
                cn.Dispose()
            End If
            sqlTrans = Nothing
        End Try
        Return resultado
    End Function
    Public Function SaveRowAllMes(ByVal flagAccion As String, ByVal sAño As String, ByVal sUSER As String, ByVal sTipo As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try

            If flagAccion = "UPDMES" Then
                UpdCPTOMes(cn, sAño, sqlTrans, sUSER, sTipo)
            End If
            If flagAccion = "UPDGRA" Then
                UpdCPTOGra(cn, sAño, sqlTrans, sUSER)
            End If
            If flagAccion = "UPDGRA2" Then
                UpdCPTOGra2(cn, sAño, sqlTrans, sUSER, sTipo)
            End If
            If flagAccion = "UPDQUINCENA" Then
                UpdCPTOQUINCENA(cn, sAño, sqlTrans)
            End If
            If flagAccion = "SCTRES" Then
                UpdSctres(cn, sAño, sqlTrans, sUSER, sTipo)
            End If
            If flagAccion = "INSMOV" Then
                InsMov(cn, sAño, sqlTrans, sUSER, sTipo)
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
    Public Function SaveRowQuinta(ByVal CALCPLABE As CALCPLABE, ByVal flagAccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try
            If flagAccion = "DELQuinta" Then
                DELQuin(CALCPLABE, cn, sqlTrans)
            End If
            If flagAccion = "UPDQuinta" Then
                UpdCPTOQuin(CALCPLABE, cn, sqlTrans)
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
    Public Sub UpdSctres(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal prdo As String,
                       ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sUSER As String,
                         ByVal sTipo As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_GENERA_SCTRES"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sPRDO", OracleDbType.Varchar2).Value = Trim(prdo)
        'cmd.Parameters.Add("@sUSER", OracleDbType.Varchar2).Value = Trim(sUSER)
        cmd.Parameters.Add("@sTipo", OracleDbType.Varchar2).Value = Trim(sTipo)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Public Sub InsMov(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal prdo As String,
                       ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sUSER As String,
                         ByVal sTipo As String)
        Dim anho As String = Trim(Mid(sUSER, 1, 4))
        Dim mes As String = Trim(Mid(sUSER, 5, 2))
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_GENASIENTO_PLA"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@ANHO1", OracleDbType.Varchar2).Value = anho
        cmd.Parameters.Add("@MES1", OracleDbType.Varchar2).Value = mes
        cmd.Parameters.Add("@prdo", OracleDbType.Varchar2).Value = Trim(prdo)
        cmd.Parameters.Add("@sTipo", OracleDbType.Varchar2).Value = Trim(sTipo)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Public Sub UpdCPTOMes(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal prdo As String,
                       ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sUSER As String,
                         ByVal sTipo As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_GENERA_PLANILLA4"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("@sPRDO", OracleDbType.Varchar2).Value = Trim(prdo)
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_GENERA_PLANILLA"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sPRDO", OracleDbType.Varchar2).Value = Trim(prdo)
        cmd.Parameters.Add("@sUSER", OracleDbType.Varchar2).Value = Trim(sUSER)
        cmd.Parameters.Add("@sTipo", OracleDbType.Varchar2).Value = Trim(sTipo)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_GENERA_PLANILLA1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sPRDO", OracleDbType.Varchar2).Value = Trim(prdo)
        cmd.Parameters.Add("@sTipo", OracleDbType.Varchar2).Value = Trim(sTipo)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_GENERA_PLANILLA2"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sPRDO", OracleDbType.Varchar2).Value = Trim(prdo)
        cmd.Parameters.Add("@sTipo", OracleDbType.Varchar2).Value = Trim(sTipo)
        cmd.ExecuteNonQuery()
        cmd.Dispose()


    End Sub

    Public Sub UpdCPTOGra(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal prdo As String,
                       ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sUSER As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_GENERA_PLANILLA_GRA"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sPRDO", OracleDbType.Varchar2).Value = Trim(prdo)
        cmd.Parameters.Add("@GSUSER", OracleDbType.Varchar2).Value = Trim(sUSER)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_GENERA_PLANILLA2_GRA"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sPRDO", OracleDbType.Varchar2).Value = Trim(prdo)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Public Sub UpdCPTOGra2(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal prdo As String,
                       ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sUSER As String,
                           ByVal sTipo As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_GENERA_PLANILLA_GRAX"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sPRDO", OracleDbType.Varchar2).Value = Trim(prdo)
        cmd.Parameters.Add("@GSUSER", OracleDbType.Varchar2).Value = Trim(sUSER)
        cmd.Parameters.Add("@sTipo", OracleDbType.Varchar2).Value = Trim(sTipo)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_GENERA_PLANILLA2_GRA"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sPRDO", OracleDbType.Varchar2).Value = Trim(prdo)
        cmd.Parameters.Add("@sTipo", OracleDbType.Varchar2).Value = Trim(sTipo)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Public Sub UpdCPTOQUINCENA(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal prdo As String,
                       ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_GENERA_QUINCENA"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sPRDO", OracleDbType.Varchar2).Value = Trim(prdo)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Public Sub DELQuin(ByVal CALCPLABE As CALCPLABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                      ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DELGENERA_PLANILLAQUINTA"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sPRDO", OracleDbType.Varchar2).Value = Trim(CALCPLABE.PRDO)
        cmd.Parameters.Add("@T_PAGO", OracleDbType.Varchar2).Value = Trim(CALCPLABE.T_PAGO)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Sub UpdCPTOQuin(ByVal CALCPLABE As CALCPLABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                      ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_GENERA_PLANILLAQUINTA"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sPRDO", OracleDbType.Varchar2).Value = Trim(CALCPLABE.PRDO)
        cmd.Parameters.Add("@T_PAGO", OracleDbType.Varchar2).Value = Trim(CALCPLABE.T_PAGO)
        cmd.Parameters.Add("@CPTO", OracleDbType.Varchar2).Value = Trim(CALCPLABE.CPTO)
        cmd.Parameters.Add("@PER_COD", OracleDbType.Varchar2).Value = Trim(CALCPLABE.PER_COD)
        cmd.Parameters.Add("@MONTO", OracleDbType.Double).Value = CALCPLABE.MONTO
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
End Class
