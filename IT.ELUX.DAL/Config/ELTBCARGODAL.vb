Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBCARGODAL
    Inherits BaseDatosORACLE
    Public ELTBCARGOBE As New ELTBCARGOBE
    Public sNumero As String
    Public Function SelectAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBCARGO_SELALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRow(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBCARGO_SELNOM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sCod", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectNro() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBCARGO_SELNRO", {})
            While dr.Read
                sNumero = dr.GetString(0)
            End While
        End Using
        Return sNumero
    End Function
    Private Sub InsertRow(ByVal ELTBCARGOBE As ELTBCARGOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBCARGO_INSROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBCARGOBE.CARGO_COD
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBCARGOBE.CARGO_DESCRI
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub UpdateRow(ByVal ELTBCARGOBE As ELTBCARGOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBCARGO_UPD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBCARGOBE.CARGO_COD
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBCARGOBE.CARGO_DESCRI
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Public Function SaveRow(ByVal ELTBCARGOBE As ELTBCARGOBE, ByVal flagAccion As String) As String
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
                InsertRow(ELTBCARGOBE, cn, sqlTrans)
                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBCARGOBE, cn, sqlTrans)
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
