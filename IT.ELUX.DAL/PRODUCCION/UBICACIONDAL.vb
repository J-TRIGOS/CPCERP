Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect

Public Class UBICACIONDAL

    Inherits BaseDatosORACLE
    Public Function VerificarCodPiso(ByVal codAlm As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_VERIFICAR_CODPISO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD_ALM", codAlm)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function VerificarAlmPiso(ByVal codAlm As String, ByVal codPiso As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_VERIFICAR_CODALMPISO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD_ALM", codAlm),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@COD_PISO", codPiso)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ObtenerDatosUbicacion(ByVal codAlm As String, ByVal codPiso As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OBTENER_DATAUBIC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD_ALM", codAlm),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@COD_PISO", codPiso)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ObtenerDataPisos(ByVal codAlm As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OBTENER_DATAPISOS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD_ALM", codAlm)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectDataPisos(ByVal codAlm As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SELECT_DATAPISOS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD_ALM", codAlm)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SaveRow(ByVal codUbi As String, ByVal codAlm As String, ByVal codPiso As String, ByVal nomPiso As String, ByVal flagaccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction

        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction

        Try
            If flagaccion = "NP" Then
                InsertRow(cn, sqlTrans, codAlm, codPiso, nomPiso)
                sqlTrans.Commit()
                resultado = "OK"
            End If
            If flagaccion = "EP" Then
                UpdateRow(cn, sqlTrans, codAlm, codPiso, nomPiso)
                sqlTrans.Commit()
                resultado = "OK"
            End If

            If flagaccion = "NU" Then
                InsertRowUbicacion(cn, sqlTrans, codUbi, codAlm, codPiso, nomPiso)
                sqlTrans.Commit()
                resultado = "OK"
            End If
            If flagaccion = "EU" Then
                UpdateRowUbicacion(cn, sqlTrans, codUbi, codAlm, codPiso, nomPiso)
                sqlTrans.Commit()
                resultado = "OK"
            End If
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

    Private Sub InsertRow(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                    ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal codAlm As String, ByVal codPiso As String, ByVal nomPiso As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_REGISTRO_CODPISO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("CODALM", OracleDbType.Varchar2).Value = codAlm
        cmd.Parameters.Add("CODPISO", OracleDbType.Varchar2).Value = codPiso
        cmd.Parameters.Add("NOMPISO", OracleDbType.Varchar2).Value = nomPiso
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub UpdateRow(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                    ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal codAlm As String, ByVal codPiso As String, ByVal nomPiso As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_UPDATE_CODPISO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("CODALM", OracleDbType.Varchar2).Value = codAlm
        cmd.Parameters.Add("CODPISO", OracleDbType.Varchar2).Value = codPiso
        cmd.Parameters.Add("NOMPISO", OracleDbType.Varchar2).Value = nomPiso
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub InsertRowUbicacion(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                   ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal codUbi As String, ByVal codAlm As String, ByVal codPiso As String, ByVal nomPiso As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_REGISTRO_CODUBIC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("CODALM", OracleDbType.Varchar2).Value = codAlm
        cmd.Parameters.Add("CODPISO", OracleDbType.Varchar2).Value = codPiso
        cmd.Parameters.Add("CODUBI", OracleDbType.Varchar2).Value = codPiso
        cmd.Parameters.Add("NOMUBI", OracleDbType.Varchar2).Value = nomPiso
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub UpdateRowUbicacion(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                    ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal codUbi As String, ByVal codAlm As String, ByVal codPiso As String, ByVal nomPiso As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_UPDATE_CODUBIC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("CODALM", OracleDbType.Varchar2).Value = codAlm
        cmd.Parameters.Add("CODPISO", OracleDbType.Varchar2).Value = codPiso
        cmd.Parameters.Add("CODUBI", OracleDbType.Varchar2).Value = codPiso
        cmd.Parameters.Add("NOMUBI", OracleDbType.Varchar2).Value = nomPiso
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
End Class
