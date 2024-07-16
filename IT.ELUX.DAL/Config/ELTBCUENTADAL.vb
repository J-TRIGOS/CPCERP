Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBCUENTADAL

    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String
    'Public ELMVLOGSBE As New ELMVLOGSBE

    Public Function SelectAll(ByVal sFecAño As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CUENTA_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ANIO", sFecAño)})
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
    Public Function VerificarRegistro(ByVal sanho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CUENTA_VERIFICAR_REG", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sanho", sanho)})
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
    Public Function SelectRow(ByVal sCode As String, ByVal gsCode2 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CUENTA_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pANHO", sCode), New Oracle.ManagedDataAccess.Client.OracleParameter("@pCOD", gsCode2)})
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

    Public Function SelectMaxTransp() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CLIENTE_LASTCOD", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Public Sub InsertRegistro(ByVal sanho As String)
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim anho_ant As Integer
        anho_ant = sanho
        Try

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_CUENTA_INSERTROW"
            cmd.Connection = cn
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("anho", OracleDbType.Varchar2).Value = sanho
            cmd.Parameters.Add("anho_ant", OracleDbType.Double).Value = anho_ant - 2
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            'actualizar 00-PLAN
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_CUENTA_ACTUALIZAROW"
            cmd.Connection = cn
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("anho", OracleDbType.Varchar2).Value = sanho
            cmd.Parameters.Add("anho_ant", OracleDbType.Double).Value = anho_ant - 2
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            sqlTrans.Commit()
            'resultado = "OK"

        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans.Rollback()
            'resultado = ex.Message
        Catch ex As Exception
            sqlTrans.Rollback()
            'resultado = ex.Message
        Finally
            'If resultado = "OK" Then
            'cn.Dispose()
            'End If
            sqlTrans = Nothing
        End Try

    End Sub
    Private Sub InsertRow(ByVal ELTBCUENTABE As ELTBCUENTABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CUENTA_INSERTDATO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase         
        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELTBCUENTABE.anho '1
        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBCUENTABE.cod '2
        cmd.Parameters.Add("@cta_cod", OracleDbType.Varchar2).Value = ELTBCUENTABE.cta_cod '3
        cmd.Parameters.Add("@mon_cod", OracleDbType.Varchar2).Value = ELTBCUENTABE.mon_cod '4
        cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = ELTBCUENTABE.nom '5
        cmd.Parameters.Add("@fec_ing_ult", OracleDbType.Date).Value = ELTBCUENTABE.fec_ing_ult '6
        cmd.Parameters.Add("@x_cco", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_cco '7
        cmd.Parameters.Add("@x_ctct", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_ctct '8
        cmd.Parameters.Add("@x_t_gasto", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_t_gasto '9
        cmd.Parameters.Add("@x_proy", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_proy '10
        cmd.Parameters.Add("@x_linea", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_linea '11
        cmd.Parameters.Add("@x_hco", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_hco '12
        cmd.Parameters.Add("@x_fuente", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_fuente '13
        cmd.Parameters.Add("@x_padre", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_padre '14
        cmd.Parameters.Add("@x_t_conv", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_t_conv '15
        cmd.Parameters.Add("@x_t_cmb", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_t_cmb '16
        cmd.Parameters.Add("@x_t_saldo", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_t_saldo '17
        cmd.Parameters.Add("@x_t_doc", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_t_doc '18
        cmd.Parameters.Add("@cta_cod_dest", OracleDbType.Varchar2).Value = ELTBCUENTABE.cta_cod_dest '19
        cmd.Parameters.Add("@x_dif_cmb", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_dif_cmb '20
        cmd.Parameters.Add("@t_ajuste_inf_cod", OracleDbType.Varchar2).Value = ELTBCUENTABE.ajuste_inf_cod '21
        cmd.Parameters.Add("@x_labor", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_labor '22
        cmd.Parameters.Add("@x_sucu", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_sucu '23
        cmd.Parameters.Add("@x_modulo", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_modulo '24
        cmd.Parameters.Add("@x_balance", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_balance '25
        cmd.Parameters.Add("@cta_cod_dest_2", OracleDbType.Varchar2).Value = ELTBCUENTABE.cta_cod_dest2 '26
        cmd.Parameters.Add("@bal_cod_abono", OracleDbType.Varchar2).Value = ELTBCUENTABE.bal_cod_abono '27
        cmd.Parameters.Add("@bal_cod_cargo", OracleDbType.Varchar2).Value = ELTBCUENTABE.bal_cod_cargo '28
        cmd.Parameters.Add("@cta_alt_cod", OracleDbType.Varchar2).Value = ELTBCUENTABE.cta_alt_cod '29
        cmd.Parameters.Add("@cta_cod_ajuste1", OracleDbType.Varchar2).Value = ELTBCUENTABE.cta_cod_ajuste1 '30
        cmd.Parameters.Add("@cta_cod_ajuste2", OracleDbType.Varchar2).Value = ELTBCUENTABE.cta_cod_ajuste2 '31
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

    Private Sub UpdateRow(ByVal ELTBCUENTABE As ELTBCUENTABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CUENTA_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELTBCUENTABE.anho
        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBCUENTABE.cod
        cmd.Parameters.Add("@cta_cod", OracleDbType.Varchar2).Value = ELTBCUENTABE.cta_cod
        cmd.Parameters.Add("@mon_cod", OracleDbType.Varchar2).Value = ELTBCUENTABE.mon_cod
        cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = ELTBCUENTABE.nom
        cmd.Parameters.Add("@fec_ing_ult", OracleDbType.Date).Value = ELTBCUENTABE.fec_ing_ult
        cmd.Parameters.Add("@x_cco", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_cco
        cmd.Parameters.Add("@x_ctct", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_ctct
        cmd.Parameters.Add("@x_t_gasto", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_t_gasto
        cmd.Parameters.Add("@x_proy", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_proy
        cmd.Parameters.Add("@x_linea", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_linea
        cmd.Parameters.Add("@x_hco", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_hco
        cmd.Parameters.Add("@x_fuente", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_fuente
        cmd.Parameters.Add("@x_padre", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_padre
        cmd.Parameters.Add("@x_t_conv", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_t_conv
        cmd.Parameters.Add("@x_t_cmb", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_t_cmb
        cmd.Parameters.Add("@x_t_saldo", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_t_saldo
        cmd.Parameters.Add("@x_t_doc", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_t_doc
        cmd.Parameters.Add("@cta_cod_dest", OracleDbType.Varchar2).Value = ELTBCUENTABE.cta_cod_dest
        cmd.Parameters.Add("@x_dif_cmb", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_dif_cmb
        cmd.Parameters.Add("@t_ajuste_inf_cod", OracleDbType.Varchar2).Value = ELTBCUENTABE.ajuste_inf_cod
        cmd.Parameters.Add("@x_labor", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_labor
        cmd.Parameters.Add("@x_sucu", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_sucu
        cmd.Parameters.Add("@x_modulo", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_modulo
        cmd.Parameters.Add("@x_balance", OracleDbType.Varchar2).Value = ELTBCUENTABE.x_balance
        cmd.Parameters.Add("@cta_cod_dest_2", OracleDbType.Varchar2).Value = ELTBCUENTABE.cta_cod_dest2
        cmd.Parameters.Add("@bal_cod_abono", OracleDbType.Varchar2).Value = ELTBCUENTABE.bal_cod_abono
        cmd.Parameters.Add("@bal_cod_cargo", OracleDbType.Varchar2).Value = ELTBCUENTABE.bal_cod_cargo
        cmd.Parameters.Add("@cta_alt_cod", OracleDbType.Varchar2).Value = ELTBCUENTABE.cta_alt_cod
        cmd.Parameters.Add("@cta_cod_ajuste1", OracleDbType.Varchar2).Value = ELTBCUENTABE.cta_cod_ajuste1
        cmd.Parameters.Add("@cta_cod_ajuste2", OracleDbType.Varchar2).Value = ELTBCUENTABE.cta_cod_ajuste2
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
    Private Sub DeleteRow(ByVal ELTBCUENTABE As ELTBCUENTABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CLIENTE_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ELTBCLIENTEBE.cod
        cmd.ExecuteNonQuery()

    End Sub

    Public Function SaveRow(ByVal ELTBCUENTABE As ELTBCUENTABE, ByVal flagAccion As String) As String
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
                InsertRow(ELTBCUENTABE, cn, sqlTrans)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBCUENTABE, cn, sqlTrans)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELTBCUENTABE, cn, sqlTrans)
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
                cn.Dispose()
            End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
End Class
