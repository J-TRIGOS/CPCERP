Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class CUENTABANCODAL

    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String
    'Public ELMVLOGSBE As New ELMVLOGSBE

    Public Function VerificarRepetido(ByVal Code As String, ByVal Code2 As String, ByVal Code3 As String) As Boolean
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CTABANCO_VERIFICAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode", Code),
                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode2", Code2), New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode3", Code3)})
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function

    Public Function SelectbancoCOD(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_BANCOCOD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectedBanco() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_BANCO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRow(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTABANCO_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sTDoc", sTDoc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@sSDoc", sSDoc), New Oracle.ManagedDataAccess.Client.OracleParameter("@sNDoc", sNDoc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTABANCO_SELECTALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function


    Private Sub InsertRow(ByVal CUENTABANCOBE As CUENTABANCOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CTABANCO_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase         
        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = CUENTABANCOBE.anho
        cmd.Parameters.Add("@cbco_cod", OracleDbType.Varchar2).Value = CUENTABANCOBE.cbco_cod
        cmd.Parameters.Add("@cta_cod", OracleDbType.Varchar2).Value = CUENTABANCOBE.cta_cod
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

    Private Sub UpdateRow(ByVal CUENTABANCOBE As CUENTABANCOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CTABANCO_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = CUENTABANCOBE.anho
        cmd.Parameters.Add("@cbco_cod", OracleDbType.Varchar2).Value = CUENTABANCOBE.cbco_cod
        cmd.Parameters.Add("@cta_cod", OracleDbType.Varchar2).Value = CUENTABANCOBE.cta_cod
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

    Public Function SaveRow(ByVal CUENTABANCOBE As CUENTABANCOBE, ByVal flagAccion As String) As String
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
                InsertRow(CUENTABANCOBE, cn, sqlTrans)
            End If

            If flagAccion = "M" Then
                UpdateRow(CUENTABANCOBE, cn, sqlTrans)
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
