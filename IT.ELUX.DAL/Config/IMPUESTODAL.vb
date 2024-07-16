Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class IMPUESTODAL

    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String
    'Public ELMVLOGSBE As New ELMVLOGSBE

    Public Function SelectAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_IMPTO_SELECTALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectTipImpto() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_IMPTO", {})
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
    Public Function SelectTipImptoCOD(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTA_OPE_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRow(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_IMPUESTO_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function VerificarRegistro() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CT_REG_NRO_VERIFICAR_REG", {})
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

    Public Function VerificarRepetido(ByVal Code As String) As Boolean
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_IMPUESTO_VERIFICAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode", Code)})
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function

    Public Function SelectCta(ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTA_OPE_CUENTA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function VerificarRepetido(ByVal tipo As String, ByVal doc As String, ByVal afecto As String, ByVal importe As String) As Boolean
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CTA_OPE_RG_VERIFICAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@tipo", tipo), New Oracle.ManagedDataAccess.Client.OracleParameter("@doc", doc),
                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@afecto", afecto), New Oracle.ManagedDataAccess.Client.OracleParameter("@importe", importe)})
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

    Private Sub InsertRow(ByVal IMPUESTOBE As IMPUESTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_IMPUESTO_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase         
        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = IMPUESTOBE.cod
        cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = IMPUESTOBE.nom
        cmd.Parameters.Add("@tipo", OracleDbType.Varchar2).Value = IMPUESTOBE.tipo
        cmd.Parameters.Add("@porc", OracleDbType.Double).Value = IMPUESTOBE.porc
        cmd.Parameters.Add("@afecto", OracleDbType.Varchar2).Value = IMPUESTOBE.afecto
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

    Private Sub UpdateRow(ByVal IMPUESTOBE As IMPUESTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_IMPUESTO_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = IMPUESTOBE.cod
        cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = IMPUESTOBE.nom
        cmd.Parameters.Add("@tipo", OracleDbType.Varchar2).Value = IMPUESTOBE.tipo
        cmd.Parameters.Add("@porc", OracleDbType.Double).Value = IMPUESTOBE.porc
        cmd.Parameters.Add("@afecto", OracleDbType.Varchar2).Value = IMPUESTOBE.afecto
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
    Private Sub DeleteRow(ByVal ELTBCUENTA_OPBE As ELTBCUENTA_OPBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CLIENTE_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ELTBCLIENTEBE.cod
        cmd.ExecuteNonQuery()

    End Sub

    Public Function SaveRow(ByVal IMPUESTOBE As IMPUESTOBE, ByVal flagAccion As String) As String
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
                InsertRow(IMPUESTOBE, cn, sqlTrans)
            End If

            If flagAccion = "M" Then
                UpdateRow(IMPUESTOBE, cn, sqlTrans)
            End If

            If flagAccion = "E" Then
                'DeleteRow(IMPUESTOBE, cn, sqlTrans)
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
