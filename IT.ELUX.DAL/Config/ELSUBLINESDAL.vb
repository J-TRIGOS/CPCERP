Imports IT.ELUX.BE
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELSUBLINESDAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE


    'Funcion que me ve permitir generar el codigo 
    Public Function LastCodigo(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_ELSUBLINES_LASTCODIGO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)

    End Function

    'Metodo para registrar un nuevo 
    Private Sub InsertRow(ByVal ELSUBLINESBE As ELSUBLINESBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByRef dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_SUBLINES_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@lin_codigo", OracleDbType.Varchar2).Value = Trim(ELSUBLINESBE.lin_codigo)

        cmd.ExecuteNonQuery()
        cmd.Dispose()


        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBLINES_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELSUBLINESBE.lin_codigo = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            ELSUBLINESBE.lin_descri = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
            ELSUBLINESBE.lin_codest = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("plin_codigo", OracleDbType.Varchar2).Value = ELSUBLINESBE.lin_codigo
            cmd.Parameters.Add("plin_descri", OracleDbType.Varchar2).Value = ELSUBLINESBE.lin_descri
            cmd.Parameters.Add("plin_codest", OracleDbType.Char).Value = IIf(UCase(ELSUBLINESBE.lin_codest) = "ACTIVO", "1", "0")
            cmd.ExecuteNonQuery()

            cmd.Dispose()
        Next
    End Sub

    ''Metodo para Modificar 
    'Private Sub UpdateRow(ByVal ELSUBLINESBE As ELSUBLINESBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
    '                      ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByRef dg As DataGridView)

    '    Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
    '    cmd.CommandText = "SP_ELTBLINES_UPDATEROW"
    '    cmd.Connection = sqlCon
    '    cmd.Transaction = sqlTrans
    '    cmd.CommandType = CommandType.StoredProcedure

    '    cmd.Parameters.Add("plin_codigo", OracleDbType.Varchar2).Value = ELSUBLINESBE.lin_codigo
    '    cmd.Parameters.Add("plin_descri", OracleDbType.Varchar2).Value = ELSUBLINESBE.lin_descri
    '    cmd.Parameters.Add("plin_codest", OracleDbType.Char).Value = ELSUBLINESBE.lin_codest

    '    cmd.ExecuteNonQuery()

    '    cmd.Dispose()


    'End Sub

    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ELSUBLINESBE As ELSUBLINESBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByRef dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_SUBLINES_DELETEROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@usu_codigo", OracleDbType.Char).Value = ELSUBLINESBE.lin_codigo
        cmd.ExecuteNonQuery()


    End Sub

    'Funcion Principal que hara toda la logica para grabar la data
    Public Function SaveRow(ByVal ELSUBLINESBE As ELSUBLINESBE, ByVal flagAccion As String, ByVal dg As DataGridView) As String
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
                InsertRow(ELSUBLINESBE, cn, sqlTrans, dg)

                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                InsertRow(ELSUBLINESBE, cn, sqlTrans, dg)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELSUBLINESBE, cn, sqlTrans, dg)
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

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBLINES_SelectRow", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectAll(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELSUBLINES_SelectAll", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using

        Return dt

    End Function
End Class
