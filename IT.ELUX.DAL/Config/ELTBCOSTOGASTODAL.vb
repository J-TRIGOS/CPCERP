Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBCOSTOGASTODAL
    Inherits BaseDatosORACLE
    Private Sub InsertRow(ByVal ELTBCOSTOGASTOBE As ELTBCOSTOGASTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBCOSTOGASTO_INS"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBCOSTOGASTOBE.cod
        cmd.Parameters.Add("@descripcion", OracleDbType.Varchar2).Value = ELTBCOSTOGASTOBE.descripcion
        cmd.Parameters.Add("@tipo", OracleDbType.Char).Value = ELTBCOSTOGASTOBE.tipo
        cmd.Parameters.Add("@est", OracleDbType.Char).Value = ELTBCOSTOGASTOBE.est
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Ingreso el costo/gasto: " + ELTBCOSTOGASTOBE.cod + " " + ELTBCOSTOGASTOBE.descripcion
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    'Metodo para Modificar 
    Private Sub UpdateRow(ByVal ELTBCOSTOGASTOBE As ELTBCOSTOGASTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE)
        'realiza registro del catalogo
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBCOSTOGASTO_UPD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pcod", OracleDbType.Varchar2).Value = ELTBCOSTOGASTOBE.cod
        cmd.Parameters.Add("pdescripcion", OracleDbType.Varchar2).Value = ELTBCOSTOGASTOBE.descripcion
        cmd.Parameters.Add("ptipo", OracleDbType.Char).Value = ELTBCOSTOGASTOBE.tipo
        cmd.Parameters.Add("pest", OracleDbType.Char).Value = ELTBCOSTOGASTOBE.est
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Modifico el costo/gasto: " + ELTBCOSTOGASTOBE.cod + " " + ELTBCOSTOGASTOBE.descripcion
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    'Funcion Principal que hara toda la logica para grabar la data
    Public Function SaveRow(ByVal ELTBCOSTOGASTOBE As ELTBCOSTOGASTOBE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE) As String
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
                InsertRow(ELTBCOSTOGASTOBE, cn, sqlTrans, ELMVLOGSBE)

                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBCOSTOGASTOBE, cn, sqlTrans, ELMVLOGSBE)
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
    'Funcion que me va permitir capturar la lista de registros en la tabla y que me va retornar
    'un Datatable
    Public Function SelectRow(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBCOSTOGASTO_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBCOSTOGASTO_SELALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function LastCodigo() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBCOSTOGASTO_COD", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)

    End Function
End Class
