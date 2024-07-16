Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBMOVIMIENTODAL

    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String
    'Public ELMVLOGSBE As New ELMVLOGSBE

    Public Function SelectAll(ByVal sFecAño As String, ByVal sFecmes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TBMOVIMIENTO_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ANIO", sFecAño), New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecmes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectT_Moneda() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TIPOCAMBIO_COMBO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectT_Documento() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_T_DOCUMENTO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectTipOpe(ByVal Anio As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_T_OPE", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Anio", Anio)})
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

    Public Function SelectActi_Serv() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CLIENTE_COMBO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRow(ByVal sCode As String, ByVal gsCode2 As String, ByVal gsCode3 As String, ByVal gsCode4 As String, ByVal gsCode5 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_MOVIMIENTO_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ANHO", sCode), New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", gsCode2),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@T_OPE_COD", gsCode3), New Oracle.ManagedDataAccess.Client.OracleParameter("@REG_NRO", gsCode4),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SEQ", gsCode5)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function VerificarRepetido(ByVal Code As String, ByVal Code2 As String) As Boolean
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CUENTA_VERIFICAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode", Code), New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode2", Code2)})
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function
    Public Function SelectRowGrid(ByVal sCode As String, ByVal sOpcion As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CLIENTEGRID_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode), New Oracle.ManagedDataAccess.Client.OracleParameter("@opcion", sOpcion)})
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

    Public Function SelectMaxTransp(ByVal sFecAño As String, ByVal sFecmes As String, ByVal sTipo_ope As String, ByVal sNro_reg As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_TBMOVIMIENTO_LASTCOD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ANHO", sFecAño), New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecmes),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@T_OPE_COD", sTipo_ope), New Oracle.ManagedDataAccess.Client.OracleParameter("@REG_NRO", sNro_reg)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Private Sub InsertRow(ByVal ELTBMOVIMIENTOBE As ELTBMOVIMIENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TBMOVIMIENTO_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase         
        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.anho
        cmd.Parameters.Add("@mes", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.mes
        cmd.Parameters.Add("@t_ope_cod", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.t_ope_cod
        cmd.Parameters.Add("@reg_nro", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.reg_nro
        cmd.Parameters.Add("@seq", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.seq
        cmd.Parameters.Add("@cta_cod", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.cta_cod
        cmd.Parameters.Add("@fec", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.fec
        cmd.Parameters.Add("@serie_nro", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.serie_nro
        cmd.Parameters.Add("@t_doc_cod", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.t_doc_cod
        cmd.Parameters.Add("@mon_cod", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.mon_cod
        cmd.Parameters.Add("@impto_cod", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.impto_cod
        cmd.Parameters.Add("@comp_cpto", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.comp_cpto
        cmd.Parameters.Add("@comp_fec", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.comp_fec
        cmd.Parameters.Add("@comp_nro", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.comp_nro
        cmd.Parameters.Add("@ctct_reg_nro", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.ctct_reg_nro
        cmd.Parameters.Add("@impor", OracleDbType.Double).Value = ELTBMOVIMIENTOBE.impor
        cmd.Parameters.Add("@impor_me", OracleDbType.Double).Value = ELTBMOVIMIENTOBE.impor_me
        cmd.Parameters.Add("@ruc", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.ruc
        cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.signo
        cmd.Parameters.Add("@t_cmb", OracleDbType.Double).Value = ELTBMOVIMIENTOBE.t_cmb
        cmd.Parameters.Add("@x_prov", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.x_prov
        cmd.Parameters.Add("@volumen", OracleDbType.Double).Value = ELTBMOVIMIENTOBE.volumen
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBCLIENTEBE.Dia4  'cod usu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registro el cliente : " + ELTBCLIENTEBE.cod + "-" + ELTBCLIENTEBE.nom
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub

    Private Sub UpdateRow(ByVal ELTBMOVIMIENTOBE As ELTBMOVIMIENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TBMOVIMIENTO_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase         
        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.anho
        cmd.Parameters.Add("@mes", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.mes
        cmd.Parameters.Add("@t_ope_cod", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.t_ope_cod
        cmd.Parameters.Add("@reg_nro", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.reg_nro
        cmd.Parameters.Add("@seq", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.seq
        cmd.Parameters.Add("@cta_cod", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.cta_cod
        cmd.Parameters.Add("@fec", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.fec
        cmd.Parameters.Add("@serie_nro", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.serie_nro
        cmd.Parameters.Add("@t_doc_cod", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.t_doc_cod
        cmd.Parameters.Add("@mon_cod", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.mon_cod
        cmd.Parameters.Add("@impto_cod", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.impto_cod
        cmd.Parameters.Add("@comp_cpto", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.comp_cpto
        cmd.Parameters.Add("@comp_fec", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.comp_fec
        cmd.Parameters.Add("@comp_nro", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.comp_nro
        cmd.Parameters.Add("@ctct_reg_nro", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.ctct_reg_nro
        cmd.Parameters.Add("@impor", OracleDbType.Double).Value = ELTBMOVIMIENTOBE.impor
        cmd.Parameters.Add("@impor_me", OracleDbType.Double).Value = ELTBMOVIMIENTOBE.impor_me
        cmd.Parameters.Add("@ruc", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.ruc
        cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.signo
        cmd.Parameters.Add("@t_cmb", OracleDbType.Double).Value = ELTBMOVIMIENTOBE.t_cmb
        cmd.Parameters.Add("@x_prov", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.x_prov
        cmd.Parameters.Add("@volumen", OracleDbType.Double).Value = ELTBMOVIMIENTOBE.volumen
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBCLIENTEBE.Dia4  'cod usu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el cliente : " + ELTBCLIENTEBE.cod + "-" + ELTBCLIENTEBE.nom
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub

    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ELTBMOVIMIENTOBE As ELTBMOVIMIENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TBMOVIMIENTO_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@ANHO", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.anho
        cmd.Parameters.Add("@MES", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.mes
        cmd.Parameters.Add("@T_OPE_COD", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.t_ope_cod
        cmd.Parameters.Add("@NRO_REG", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.reg_nro
        cmd.Parameters.Add("@SEQ", OracleDbType.Varchar2).Value = ELTBMOVIMIENTOBE.seq
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Public Function SaveRow(ByVal ELTBMOVIMIENTOBE As ELTBMOVIMIENTOBE, ByVal flagAccion As String) As String
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
                InsertRow(ELTBMOVIMIENTOBE, cn, sqlTrans)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBMOVIMIENTOBE, cn, sqlTrans)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELTBMOVIMIENTOBE, cn, sqlTrans)
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
End Class
