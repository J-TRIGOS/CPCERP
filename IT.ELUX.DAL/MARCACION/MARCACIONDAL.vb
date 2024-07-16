Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect

Public Class MARCACIONDAL

    Inherits BaseDatosORACLE
    Public Function registrarAsistencia(ByVal dni As String, ByVal fecha As String, ByVal pc As String, ByVal usuario As String, ByVal tipo As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction
        Try
            RegistrarAdistenciaDNI(dni, fecha, pc, usuario, tipo, cn, sqlTrans)
            sqlTrans.Commit()
            resultado = "OK"
        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans.Rollback()
            resultado = ex.Message
        Catch ex As Exception
            sqlTrans.Rollback()
            resultado = ex.Message
        Finally
            sqlTrans = Nothing
        End Try
        Return resultado
    End Function
    Private Sub RegistrarAdistenciaDNI(ByVal dni As String, ByVal fecha As String, ByVal pc As String, ByVal usuario As String, ByVal tipo As String, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_REGISTRAR_ASISTENCIA"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@DNI", OracleDbType.NVarchar2).Value = dni
        cmd.Parameters.Add("@MFECHA", OracleDbType.NVarchar2).Value = fecha
        cmd.Parameters.Add("@PC", OracleDbType.NVarchar2).Value = pc
        cmd.Parameters.Add("@USUARIO", OracleDbType.NVarchar2).Value = usuario
        cmd.Parameters.Add("@TIPO", OracleDbType.NVarchar2).Value = tipo
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub


    Function VerificarDNI(ByVal dni As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_VERIFICAR_DNI", {New Oracle.ManagedDataAccess.Client.OracleParameter("@CODIGO", dni)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function BuscarDNI(ByVal gsuser As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BUSCAR_DNIMARCACION", {New Oracle.ManagedDataAccess.Client.OracleParameter("@CODIGO", gsuser)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
