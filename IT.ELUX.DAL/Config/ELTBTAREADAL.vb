Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBTAREADAL
    Inherits BaseDatosORACLE
    Public sNumero As String
    Public Function SelectNro1() As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBTAREA_SELNRO", {})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero
    End Function
    Public Function SelectRow(ByVal sCOD As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBTAREA_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sCOD", sCOD)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBTAREA_SELALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Private Sub InsertRow(ByVal ELTBTAREABE As ELTBTAREABE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBTAREA_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBTAREABE.cod
        cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = ELTBTAREABE.nom
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELTBTAREABE.est
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso la tarea: " + ELTBTAREABE.cod + "-" + ELTBTAREABE.nom
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub UpdateRow(ByVal ELTBTAREABE As ELTBTAREABE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBTAREA_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBTAREABE.cod
        cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = ELTBTAREABE.nom
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELTBTAREABE.est
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo la tarea: " + ELTBTAREABE.cod + "-" + ELTBTAREABE.nom
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Public Function SaveRow(ByVal ELTBTAREABE As ELTBTAREABE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction
        Try
            'N:Nuevo   M:Modificar   E:Eliminar 
            If flagAccion = "N" Then
                ''correlativo = LastCodigo()
                InsertRow(ELTBTAREABE, ELMVLOGSBE, cn, sqlTrans)
                'grabar acceso a los menues
            End If
            If flagAccion = "M" Then
                ''correlativo = LastCodigo()
                UpdateRow(ELTBTAREABE, ELMVLOGSBE, cn, sqlTrans)
                'grabar acceso a los menues
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

End Class
