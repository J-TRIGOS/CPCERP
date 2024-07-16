Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect

Public Class VACUNADAL
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String

    Public Function ListadoVacunados() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LISTADO_VACUNADOS", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ListadoNoVacunados() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PERSONAL_NO_VACUNADO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarPersonalActivo() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PESONAL_ACTIVO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ListadoVacuna(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LISTADO_VACUNA_PER", {New Oracle.ManagedDataAccess.Client.OracleParameter("@CODIGO", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function grabarDatos(ByVal vacunabe As VACUNABE, ByVal flagAccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction

        cn = ConnectionBegin()

        sqlTrans = cn.BeginTransaction

        Try
            'N:Nuevo   M:Modificar   E:Eliminar 

            If flagAccion = "N" Then
                InsertRow(vacunabe, cn, sqlTrans)
                'grabar acceso a los menues
                sqlTrans.Commit()
                resultado = "OK"
            End If
            If flagAccion = "M" Then
                DeleteRow(vacunabe, cn, sqlTrans)
                sqlTrans.Commit()
                'grabar acceso a los menues
                resultado = "OK"
            End If

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

    Private Sub InsertRow(ByVal vacunabe As VACUNABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_REGISTRO_VACUNAS"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@CODIGO", OracleDbType.Varchar2).Value = vacunabe.PER_COD
        cmd.Parameters.Add("@EMPLEADO", OracleDbType.Varchar2).Value = vacunabe.EMPLEADO
        cmd.Parameters.Add("@DOSIS", OracleDbType.Varchar2).Value = vacunabe.DOSIS
        cmd.Parameters.Add("@LABORATORIO", OracleDbType.Varchar2).Value = vacunabe.LABORATORIO
        cmd.Parameters.Add("@FECHA", OracleDbType.Varchar2).Value = vacunabe.FEC_VACUNA
        cmd.Parameters.Add("@LUGAR", OracleDbType.Varchar2).Value = vacunabe.LUGAR
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub DeleteRow(ByVal vacunabe As VACUNABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DELETE_VACUNAS"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@CODIGO", OracleDbType.Varchar2).Value = vacunabe.PER_COD
        cmd.Parameters.Add("@DOSIS", OracleDbType.Varchar2).Value = vacunabe.DOSIS
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
End Class

