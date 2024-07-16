Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBTRANSPDAL

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

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TRANSP_SELECTALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TRANSP_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectMaxTransp() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_TRANSP_LASTCOD", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Private Sub InsertRow(ByVal ELTBTRANSPBE As ELTBTRANSPBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TRANSP_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        'cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBTRANSPBE.cod
        cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = ELTBTRANSPBE.nom
        cmd.Parameters.Add("@dir", OracleDbType.Varchar2).Value = ELTBTRANSPBE.dir
        cmd.Parameters.Add("@placa", OracleDbType.Varchar2).Value = ELTBTRANSPBE.placa
        cmd.Parameters.Add("@ruc", OracleDbType.Varchar2).Value = ELTBTRANSPBE.ruc
        cmd.Parameters.Add("@telf", OracleDbType.Varchar2).Value = ELTBTRANSPBE.telf
        cmd.Parameters.Add("@brevete", OracleDbType.Varchar2).Value = ELTBTRANSPBE.brevete
        cmd.Parameters.Add("@certificado", OracleDbType.Varchar2).Value = ELTBTRANSPBE.certificado
        cmd.Parameters.Add("@marca", OracleDbType.Varchar2).Value = ELTBTRANSPBE.marca
        cmd.Parameters.Add("@vehi", OracleDbType.Varchar2).Value = ELTBTRANSPBE.vehi
        cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = ELTBTRANSPBE.estado
        cmd.Parameters.Add("@id", OracleDbType.Int32).Value = ELTBTRANSPBE.id
        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = ELTBTRANSPBE.ctct_cod

        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Private Sub UpdateRow(ByVal ELTBTRANSPBE As ELTBTRANSPBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TRANSP_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBTRANSPBE.cod
        cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = ELTBTRANSPBE.nom
        cmd.Parameters.Add("@dir", OracleDbType.Varchar2).Value = ELTBTRANSPBE.dir
        cmd.Parameters.Add("@placa", OracleDbType.Varchar2).Value = ELTBTRANSPBE.placa
        cmd.Parameters.Add("@ruc", OracleDbType.Varchar2).Value = ELTBTRANSPBE.ruc
        cmd.Parameters.Add("@telf", OracleDbType.Varchar2).Value = ELTBTRANSPBE.telf
        cmd.Parameters.Add("@brevete", OracleDbType.Varchar2).Value = ELTBTRANSPBE.brevete
        cmd.Parameters.Add("@certificado", OracleDbType.Varchar2).Value = ELTBTRANSPBE.certificado
        cmd.Parameters.Add("@marca", OracleDbType.Varchar2).Value = ELTBTRANSPBE.marca
        cmd.Parameters.Add("@vehi", OracleDbType.Varchar2).Value = ELTBTRANSPBE.vehi
        cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = ELTBTRANSPBE.estado
        cmd.Parameters.Add("@id", OracleDbType.Int32).Value = ELTBTRANSPBE.id
        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = ELTBTRANSPBE.ctct_cod

        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ELTBTRANSPBE As ELTBTRANSPBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TRANSP_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ELTBTRANSPBE.cod
        cmd.ExecuteNonQuery()

    End Sub

    Public Function SaveRow(ByVal ELTBTRANSPBE As ELTBTRANSPBE, ByVal flagAccion As String) As String
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
                InsertRow(ELTBTRANSPBE, cn, sqlTrans)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBTRANSPBE, cn, sqlTrans)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELTBTRANSPBE, cn, sqlTrans)
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
