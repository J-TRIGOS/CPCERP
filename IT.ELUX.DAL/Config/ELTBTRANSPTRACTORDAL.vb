Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBTRANSPTRACTORDAL

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

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TRANSPTRACTOR_SELECTALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRow(ByVal sCode As String, ByVal sCode_cho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TRANSPTRACTOR_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode), New Oracle.ManagedDataAccess.Client.OracleParameter("@pCOD_CHOFER", sCode_cho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectMaxTransp(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_TRANSPTRACTOR_LASTCOD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Public Function SelectT_Transp() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TRANSP_COMBO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Private Sub InsertRow(ByVal ELTBTRANSPTRACTORBE As ELTBTRANSPTRACTORBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TRANSPTRACTOR_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = ELTBTRANSPTRACTORBE.ctct_cod
        cmd.Parameters.Add("@placa", OracleDbType.Varchar2).Value = ELTBTRANSPTRACTORBE.placa
        cmd.Parameters.Add("@nro", OracleDbType.Varchar2).Value = "1"
        cmd.Parameters.Add("@marca", OracleDbType.Varchar2).Value = ELTBTRANSPTRACTORBE.marca
        cmd.Parameters.Add("@tipo", OracleDbType.Varchar2).Value = ELTBTRANSPTRACTORBE.tipo
        cmd.Parameters.Add("@observacion", OracleDbType.Varchar2).Value = ELTBTRANSPTRACTORBE.observacion
        cmd.Parameters.Add("@certificado", OracleDbType.Varchar2).Value = ELTBTRANSPTRACTORBE.certificado
        cmd.Parameters.Add("@config_vehi", OracleDbType.Varchar2).Value = ELTBTRANSPTRACTORBE.config_vehi
        cmd.Parameters.Add("@cor", OracleDbType.Varchar2).Value = ELTBTRANSPTRACTORBE.cor
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Private Sub UpdateRow(ByVal ELTBTRANSPTRACTORBE As ELTBTRANSPTRACTORBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TRANSPTRACTOR_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = ELTBTRANSPTRACTORBE.ctct_cod
        cmd.Parameters.Add("@placa", OracleDbType.Varchar2).Value = ELTBTRANSPTRACTORBE.placa
        cmd.Parameters.Add("@nro", OracleDbType.Varchar2).Value = "1"
        cmd.Parameters.Add("@marca", OracleDbType.Varchar2).Value = ELTBTRANSPTRACTORBE.marca
        cmd.Parameters.Add("@tipo", OracleDbType.Varchar2).Value = ELTBTRANSPTRACTORBE.tipo
        cmd.Parameters.Add("@observacion", OracleDbType.Varchar2).Value = ELTBTRANSPTRACTORBE.observacion
        cmd.Parameters.Add("@certificado", OracleDbType.Varchar2).Value = ELTBTRANSPTRACTORBE.certificado
        cmd.Parameters.Add("@config_vehi", OracleDbType.Varchar2).Value = ELTBTRANSPTRACTORBE.config_vehi
        cmd.Parameters.Add("@cor", OracleDbType.Varchar2).Value = ELTBTRANSPTRACTORBE.cor

        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ELTBTRANSPTRACTORBE As ELTBTRANSPTRACTORBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TRANSPTRACTOR_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@ctct_cod", OracleDbType.Char).Value = ELTBTRANSPTRACTORBE.ctct_cod
        cmd.Parameters.Add("@cho_cod", OracleDbType.Char).Value = ELTBTRANSPTRACTORBE.cor
        cmd.ExecuteNonQuery()

    End Sub

    Public Function SaveRow(ByVal ELTBTRANSPTRACTORBE As ELTBTRANSPTRACTORBE, ByVal flagAccion As String) As String
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
                InsertRow(ELTBTRANSPTRACTORBE, cn, sqlTrans)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBTRANSPTRACTORBE, cn, sqlTrans)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELTBTRANSPTRACTORBE, cn, sqlTrans)
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
