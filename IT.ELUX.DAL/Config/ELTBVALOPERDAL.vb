Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBVALOPERDAL
    Inherits BaseDatosORACLE
    Private Sub InsertRow(ByVal ELTBVALOPERBE As ELTBVALOPERBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal lv As ListBox)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBVALOPER_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@val_codoper", OracleDbType.Varchar2).Value = Trim(ELTBVALOPERBE.val_codoper)

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim i As Integer
        For i = 0 To lv.Items.Count - 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBVALOPER_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBVALOPERBE.val_codval = lv.Items(i).ToString
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@val_codoper", OracleDbType.Varchar2).Value = ELTBVALOPERBE.val_codoper
            cmd.Parameters.Add("@val_codval", OracleDbType.Varchar2).Value = ELTBVALOPERBE.val_codval
            cmd.ExecuteNonQuery()

            cmd.Dispose()
        Next



    End Sub

    Private Sub DeleteRow(ByVal ELTBVALOPERBE As ELTBVALOPERBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBVALOPER_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@val_codoper", OracleDbType.Char).Value = ELTBVALOPERBE.val_codoper

        cmd.ExecuteNonQuery()


    End Sub

    'Funcion Principal que hara toda la logica para grabar la data
    Public Function SaveRow(ByVal ELTBVALOPERBE As ELTBVALOPERBE, ByVal flagAccion As String, ByVal lv As ListBox) As String
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
                InsertRow(ELTBVALOPERBE, cn, sqlTrans, lv)

                'grabar acceso a los menues
            End If

            If flagAccion = "E" Then
                DeleteRow(ELTBVALOPERBE, cn, sqlTrans)
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

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBVALOPER_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            While dr.Read
                lv.Items.Add(dr.GetString(1))
            End While
        End Using
        'Return lv

    End Sub
End Class
