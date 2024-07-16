Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBGRUPCORVALDAL
    Inherits BaseDatosORACLE
    Private Sub InsertRow(ByVal ELTBGRUPCORVALBE As ELTBGRUPCORVALBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal lv As ListBox)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBGRUPCORVAL_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = Trim(ELTBGRUPCORVALBE.cod)

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim i As Integer
        For i = 0 To lv.Items.Count - 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            If ELTBGRUPCORVALBE.cod = "0006" Then
                cmd.CommandText = "SP_ELTBGRUPCORVAL_INSERTROW1"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                ELTBGRUPCORVALBE.cor_val = lv.Items(i).ToString
                'Los parametros que va recibir son las propiedades de la clase 
                cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBGRUPCORVALBE.cod
                cmd.Parameters.Add("@cor_val", OracleDbType.Varchar2).Value = ELTBGRUPCORVALBE.cor_val
                cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = "1"
                cmd.ExecuteNonQuery()

                cmd.Dispose()
            Else
                cmd.CommandText = "SP_ELTBGRUPCORVAL_INSERTROW"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                ELTBGRUPCORVALBE.cor_val = lv.Items(i).ToString
                'Los parametros que va recibir son las propiedades de la clase 
                cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBGRUPCORVALBE.cod
                cmd.Parameters.Add("@cor_val", OracleDbType.Varchar2).Value = ELTBGRUPCORVALBE.cor_val
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If

        Next
    End Sub

    Private Sub UpdateRowRC(ByVal ELTBGRUPCORVALBE As ELTBGRUPCORVALBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal lv As ListView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBGRUPCORVAL_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = Trim(ELTBGRUPCORVALBE.cod)

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim i As Integer
        For i = 0 To lv.Items.Count - 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBGRUPCORVAL_INSERTROW1"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBGRUPCORVALBE.cor_val = lv.Items(i).SubItems(0).Text
            If lv.Items(i).Checked Then
                ELTBGRUPCORVALBE.est = "1"
            Else
                ELTBGRUPCORVALBE.est = ""
            End If
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBGRUPCORVALBE.cod
            cmd.Parameters.Add("@cor_val", OracleDbType.Varchar2).Value = ELTBGRUPCORVALBE.cor_val
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELTBGRUPCORVALBE.est
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        Next
    End Sub

    Private Sub DeleteRow(ByVal ELTBGRUPCORVALBE As ELTBGRUPCORVALBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBGRUPCORVAL_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ELTBGRUPCORVALBE.cod

        cmd.ExecuteNonQuery()


    End Sub

    'Funcion Principal que hara toda la logica para grabar la data
    Public Function SaveRow(ByVal ELTBGRUPCORVALBE As ELTBGRUPCORVALBE, ByVal flagAccion As String, ByVal lv As ListBox) As String
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

            If flagAccion = "N" Or flagAccion = "M" Then
                ''correlativo = LastCodigo()
                ''MonedaBE.mon_codigo = MonedaBE.mon_codigo
                InsertRow(ELTBGRUPCORVALBE, cn, sqlTrans, lv)

                'grabar acceso a los menues
            End If
            If flagAccion = "E" Then
                DeleteRow(ELTBGRUPCORVALBE, cn, sqlTrans)
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

    Public Sub SelectRow(ByVal sCode As String, ByVal lv As ListBox)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim lv As New ListView

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBGRUPCORVAL_SelectRow", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            While dr.Read
                lv.Items.Add(dr.GetString(1))
            End While
        End Using
        'Return lv

    End Sub
    Public Sub SelectRow1(ByVal sCode As String, ByVal lv As ListBox)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim lv As New ListView

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBGRUPCORVAL_SelectRow1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            While dr.Read
                lv.Items.Add(dr.GetString(1))
            End While
        End Using
        'Return lv

    End Sub
    Public Function SelectRow1(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim lv As New ListView
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBGRUPCORVAL_SelectRow", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        'Return lv
        Return dt
    End Function
    Public Function SaveRowRC(ByVal ELTBGRUPCORVALBE As ELTBGRUPCORVALBE, ByVal flagAccion As String, ByVal lv As ListView) As String
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

            If flagAccion = "RC" Then
                UpdateRowRC(ELTBGRUPCORVALBE, cn, sqlTrans, lv)
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
