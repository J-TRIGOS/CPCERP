Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBREGISTRO_NRODAL

    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String
    'Public ELMVLOGSBE As New ELMVLOGSBE

    Public Function SelectAll(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CT_REG_NRO_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ANIO", sFecAño), New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
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
    Public Function SelectRow(ByVal sCode As String, ByVal sCode2 As String, ByVal sCode3 As String, ByVal sCode4 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CT_REG_NRO_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode), New Oracle.ManagedDataAccess.Client.OracleParameter("@code2", sCode2),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@code3", sCode3), New Oracle.ManagedDataAccess.Client.OracleParameter("@code4", sCode4)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function VerificarRegistro(ByVal sanho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CT_REG_NRO_VERIFICAR_REG", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sanho", sanho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
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

    Public Function SelectPrefBanco() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_PREF_BANCO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectPrefBancoCOD(ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CODIGO_PREF_BANCO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function VerificarRepetido(ByVal Code As String, ByVal Code2 As String, ByVal Code3 As String, ByVal Code4 As String) As Boolean
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CT_NRO_RG_VERIFICAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode", Code), New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode2", Code2),
                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode3", Code3), New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode4", Code4)})
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function
    Public Function SelectTipOpeCOD(ByVal anio As String, ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CODIGO_T_OPE", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anio", anio), New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod)})
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

        Dim cmd, cmd2, cmd3, cmd4, cmd5, cmd6, cmd7, cmd8, cmd9, cmd10 As New Oracle.ManagedDataAccess.Client.OracleCommand

        Try

            For index As Integer = 0 To 11
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_CT_REG_NRO_INSERTROW"
                cmd.Connection = cn
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("anho", OracleDbType.Varchar2).Value = sanho
                cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = (index + 1).ToString().PadLeft(2, "0")
                cmd.Parameters.Add("t_ope_cod", OracleDbType.Varchar2).Value = "001"
                cmd.Parameters.Add("pref_bco", OracleDbType.Varchar2).Value = "$"
                cmd.Parameters.Add("reg_nro", OracleDbType.Varchar2).Value = sanho.Substring(2) + "" + (index + 1).ToString().PadLeft(2, "0") + "" + "0001"
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_CT_REG_NRO_INSERTROW"
                cmd.Connection = cn
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("anho", OracleDbType.Varchar2).Value = sanho
                cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = (index + 1).ToString().PadLeft(2, "0")
                cmd.Parameters.Add("t_ope_cod", OracleDbType.Varchar2).Value = "002"
                cmd.Parameters.Add("pref_bco", OracleDbType.Varchar2).Value = "$"
                cmd.Parameters.Add("reg_nro", OracleDbType.Varchar2).Value = sanho.Substring(2) + "" + (index + 1).ToString().PadLeft(2, "0") + "" + "0001"
                cmd.ExecuteNonQuery()
                cmd.Dispose()


                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_CT_REG_NRO_INSERTROW"
                cmd.Connection = cn
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("anho", OracleDbType.Varchar2).Value = sanho
                cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = (index + 1).ToString().PadLeft(2, "0")
                cmd.Parameters.Add("t_ope_cod", OracleDbType.Varchar2).Value = "007"
                cmd.Parameters.Add("pref_bco", OracleDbType.Varchar2).Value = "$"
                cmd.Parameters.Add("reg_nro", OracleDbType.Varchar2).Value = sanho.Substring(2) + "" + (index + 1).ToString().PadLeft(2, "0") + "" + "0001"
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_CT_REG_NRO_INSERTROW"
                cmd.Connection = cn
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("anho", OracleDbType.Varchar2).Value = sanho
                cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = (index + 1).ToString().PadLeft(2, "0")
                cmd.Parameters.Add("t_ope_cod", OracleDbType.Varchar2).Value = "008"
                cmd.Parameters.Add("pref_bco", OracleDbType.Varchar2).Value = "$"
                cmd.Parameters.Add("reg_nro", OracleDbType.Varchar2).Value = sanho.Substring(2) + "" + (index + 1).ToString().PadLeft(2, "0") + "" + "0001"
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_CT_REG_NRO_INSERTROW"
                cmd.Connection = cn
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("anho", OracleDbType.Varchar2).Value = sanho
                cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = (index + 1).ToString().PadLeft(2, "0")
                cmd.Parameters.Add("t_ope_cod", OracleDbType.Varchar2).Value = "009"
                cmd.Parameters.Add("pref_bco", OracleDbType.Varchar2).Value = "$"
                cmd.Parameters.Add("reg_nro", OracleDbType.Varchar2).Value = sanho.Substring(2) + "" + (index + 1).ToString().PadLeft(2, "0") + "" + "0001"
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_CT_REG_NRO_INSERTROW"
                cmd.Connection = cn
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("anho", OracleDbType.Varchar2).Value = sanho
                cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = (index + 1).ToString().PadLeft(2, "0")
                cmd.Parameters.Add("t_ope_cod", OracleDbType.Varchar2).Value = "010"
                cmd.Parameters.Add("pref_bco", OracleDbType.Varchar2).Value = "11"
                cmd.Parameters.Add("reg_nro", OracleDbType.Varchar2).Value = sanho.Substring(2) + "" + (index + 1).ToString().PadLeft(2, "0") + "11" + "0001"
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_CT_REG_NRO_INSERTROW"
                cmd.Connection = cn
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("anho", OracleDbType.Varchar2).Value = sanho
                cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = (index + 1).ToString().PadLeft(2, "0")
                cmd.Parameters.Add("t_ope_cod", OracleDbType.Varchar2).Value = "010"
                cmd.Parameters.Add("pref_bco", OracleDbType.Varchar2).Value = "12"
                cmd.Parameters.Add("reg_nro", OracleDbType.Varchar2).Value = sanho.Substring(2) + "" + (index + 1).ToString().PadLeft(2, "0") + "12" + "0001"
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_CT_REG_NRO_INSERTROW"
                cmd.Connection = cn
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("anho", OracleDbType.Varchar2).Value = sanho
                cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = (index + 1).ToString().PadLeft(2, "0")
                cmd.Parameters.Add("t_ope_cod", OracleDbType.Varchar2).Value = "013"
                cmd.Parameters.Add("pref_bco", OracleDbType.Varchar2).Value = "11"
                cmd.Parameters.Add("reg_nro", OracleDbType.Varchar2).Value = sanho.Substring(2) + "" + (index + 1).ToString().PadLeft(2, "0") + "11" + "0001"
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_CT_REG_NRO_INSERTROW"
                cmd.Connection = cn
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("anho", OracleDbType.Varchar2).Value = sanho
                cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = (index + 1).ToString().PadLeft(2, "0")
                cmd.Parameters.Add("t_ope_cod", OracleDbType.Varchar2).Value = "013"
                cmd.Parameters.Add("pref_bco", OracleDbType.Varchar2).Value = "12"
                cmd.Parameters.Add("reg_nro", OracleDbType.Varchar2).Value = sanho.Substring(2) + "" + (index + 1).ToString().PadLeft(2, "0") + "12" + "0001"
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_CT_REG_NRO_INSERTROW"
                cmd.Connection = cn
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("anho", OracleDbType.Varchar2).Value = sanho
                cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = (index + 1).ToString().PadLeft(2, "0")
                cmd.Parameters.Add("t_ope_cod", OracleDbType.Varchar2).Value = "013"
                cmd.Parameters.Add("pref_bco", OracleDbType.Varchar2).Value = "22"
                cmd.Parameters.Add("reg_nro", OracleDbType.Varchar2).Value = sanho.Substring(2) + "" + (index + 1).ToString().PadLeft(2, "0") + "22" + "0001"
                cmd.ExecuteNonQuery()
                cmd.Dispose()

            Next

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
    Private Sub InsertRow(ByVal ELTBREGISTRO_NROBE As ELTBREGISTRO_NROBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CT_REG_NRO_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase         
        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELTBREGISTRO_NROBE.anho
        cmd.Parameters.Add("@mes", OracleDbType.Varchar2).Value = ELTBREGISTRO_NROBE.mes
        cmd.Parameters.Add("@t_ope_cod", OracleDbType.Varchar2).Value = ELTBREGISTRO_NROBE.t_ope_cod
        cmd.Parameters.Add("@pref_bco", OracleDbType.Varchar2).Value = ELTBREGISTRO_NROBE.pref_bco
        cmd.Parameters.Add("@reg_nro", OracleDbType.Varchar2).Value = ELTBREGISTRO_NROBE.reg_nro
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

    Private Sub UpdateRow(ByVal ELTBREGISTRO_NROBE As ELTBREGISTRO_NROBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CT_REG_NRO_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELTBREGISTRO_NROBE.anho
        cmd.Parameters.Add("@mes", OracleDbType.Varchar2).Value = ELTBREGISTRO_NROBE.mes
        cmd.Parameters.Add("@t_ope_cod", OracleDbType.Varchar2).Value = ELTBREGISTRO_NROBE.t_ope_cod
        cmd.Parameters.Add("@pref_bco", OracleDbType.Varchar2).Value = ELTBREGISTRO_NROBE.pref_bco
        cmd.Parameters.Add("@reg_nro", OracleDbType.Varchar2).Value = ELTBREGISTRO_NROBE.reg_nro
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
    Private Sub DeleteRow(ByVal ELTBREGISTRO_NROBE As ELTBREGISTRO_NROBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CLIENTE_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ELTBCLIENTEBE.cod
        cmd.ExecuteNonQuery()

    End Sub

    Public Function SaveRow(ByVal ELTBREGISTRO_NROBE As ELTBREGISTRO_NROBE, ByVal flagAccion As String) As String
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
                InsertRow(ELTBREGISTRO_NROBE, cn, sqlTrans)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBREGISTRO_NROBE, cn, sqlTrans)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELTBREGISTRO_NROBE, cn, sqlTrans)
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

    Public Function SelectBanco() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_LISTADO_BANCOS", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
