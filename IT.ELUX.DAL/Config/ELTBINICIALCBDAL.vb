Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBINICIALCBDAL
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public Function SelectAll(ByVal anho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBINICIALCB_SELALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRow(ByVal sANHO As String, ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBINICIALCB_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sANHO", sANHO),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@sCode", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function BuscarCB(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBINICIALCB_BUSCTA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SaveRow(ByVal ELTBINICIALCBBE As ELTBINICIALCBBE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE) As String
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
                InsertRow(ELTBINICIALCBBE, cn, sqlTrans, ELMVLOGSBE)

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
            If resultado = "OK" And flagAccion <> "M" And flagAccion <> "MK" And flagAccion <> "MF" Then
                cn.Dispose()
            End If
            sqlTrans = Nothing
        End Try

        Return resultado
    End Function
    Private Sub InsertRow(ByVal ELTBINICIALCBBE As ELTBINICIALCBBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBINICIALCB_INS"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@ANHO", OracleDbType.Varchar2).Value = ELTBINICIALCBBE.ANHO
        cmd.Parameters.Add("@CTABCO", OracleDbType.Varchar2).Value = ELTBINICIALCBBE.CTABCO
        cmd.Parameters.Add("@MONTO", OracleDbType.Double).Value = ELTBINICIALCBBE.MONTO
        cmd.ExecuteNonQuery()
        cmd.Dispose()


        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso la cuenta: " + ELTBINICIALCBBE.CTABCO
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
End Class
