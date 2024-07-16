Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBTRANSPCHOFERDAL

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

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TRANSPCHOFER_SELECTALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRow(ByVal sCode As String, ByVal sCode_cho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TRANSPCHOFER_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode), New Oracle.ManagedDataAccess.Client.OracleParameter("@pCOD_CHOFER", sCode_cho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectMaxTransp(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_TRANSPCHOFER_LASTCOD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", sCode)})
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

    Private Sub InsertRow(ByVal ELTBTRANSPCHOFERBE As ELTBTRANSPCHOFERBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TRANSPCHOFER_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = ELTBTRANSPCHOFERBE.ctct_cod
        cmd.Parameters.Add("@chofer", OracleDbType.Varchar2).Value = ELTBTRANSPCHOFERBE.chofer
        cmd.Parameters.Add("@brevete", OracleDbType.Varchar2).Value = ELTBTRANSPCHOFERBE.brevete
        cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = ELTBTRANSPCHOFERBE.observa
        cmd.Parameters.Add("@cho_cod", OracleDbType.Varchar2).Value = ELTBTRANSPCHOFERBE.cho_cod
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Private Sub UpdateRow(ByVal ELTBTRANSPCHOFERBE As ELTBTRANSPCHOFERBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TRANSPCHOFER_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = ELTBTRANSPCHOFERBE.ctct_cod
        cmd.Parameters.Add("@chofer", OracleDbType.Varchar2).Value = ELTBTRANSPCHOFERBE.chofer
        cmd.Parameters.Add("@brevete", OracleDbType.Varchar2).Value = ELTBTRANSPCHOFERBE.brevete
        cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = ELTBTRANSPCHOFERBE.observa
        cmd.Parameters.Add("@cho_cod", OracleDbType.Varchar2).Value = ELTBTRANSPCHOFERBE.cho_cod

        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ELTBTRANSPCHOFERBE As ELTBTRANSPCHOFERBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TRANSPCHOFER_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@ctct_cod", OracleDbType.Char).Value = ELTBTRANSPCHOFERBE.ctct_cod
        cmd.Parameters.Add("@cho_cod", OracleDbType.Char).Value = ELTBTRANSPCHOFERBE.cho_cod
        cmd.ExecuteNonQuery()

    End Sub

    Public Function SaveRow(ByVal ELTBTRANSPCHOFERBE As ELTBTRANSPCHOFERBE, ByVal flagAccion As String) As String
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
                InsertRow(ELTBTRANSPCHOFERBE, cn, sqlTrans)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBTRANSPCHOFERBE, cn, sqlTrans)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELTBTRANSPCHOFERBE, cn, sqlTrans)
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
