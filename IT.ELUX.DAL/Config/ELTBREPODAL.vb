Imports IT.ELUX.BE
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBREPODAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE


    Private Sub InsertRow(ByVal ELTBREPOBE As ELTBREPOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                          ByVal scodcat As String)
        'Recorrido para vaciar el grid
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBREPO_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@RPO_CODPROC", OracleDbType.Char).Value = ELTBREPOBE.RPO_CODPROC

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBREPO_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBREPOBE.RPO_CODOPER = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            ELTBREPOBE.RPO_CODPROC = scodcat
            cmd.Parameters.Add("@RPO_CODPROC", OracleDbType.Char).Value = ELTBREPOBE.RPO_CODPROC
            cmd.Parameters.Add("@RPO_CODOPER", OracleDbType.Char).Value = ELTBREPOBE.RPO_CODOPER
            cmd.Parameters.Add("@RPO_ITEM", OracleDbType.Char).Value = Format(cont, "000")
            cmd.Parameters.Add("@CANTIDAD", OracleDbType.Double).Value = ELTBREPOBE.CANTIDAD
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub


    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ELTBREPOBE As ELTBREPOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBREPO_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@RPO_CODPROC", OracleDbType.Char).Value = ELTBREPOBE.RPO_CODPROC

        cmd.ExecuteNonQuery()


    End Sub

    'Funcion Principal que hara toda la logica para grabar la data
    Public Function SaveRow(ByVal ELTBREPOBE As ELTBREPOBE, ByVal flagAccion As String, ByVal dg As DataGridView,
                            ByVal scodcat As String) As String
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
                InsertRow(ELTBREPOBE, cn, sqlTrans, dg, scodcat)

                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                'UpdateRow(ELTBRECCBE, cn, sqlTrans)
                InsertRow(ELTBREPOBE, cn, sqlTrans, dg, scodcat)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELTBREPOBE, cn, sqlTrans)
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

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBREPO_SelectRow", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectAll(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBREPO_SelectRow", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using

        Return dt

    End Function

    Public Sub ActualizarUnidxHora(ByVal codigo As String, ByVal unid As String)
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction

        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction


        Try
            'N:Nuevo   M:Modificar   E:Eliminar 


            UpdateRow(codigo, unid, cn, sqlTrans)

            sqlTrans.Commit()


        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans.Rollback()

        Catch ex As Exception
            sqlTrans.Rollback()

        Finally
            sqlTrans = Nothing
        End Try
        cn.Close()
    End Sub

    Public Sub UpdateRow(ByVal codigo As String, ByVal unid As String, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ACTUALIZAR_UNID_PROCEO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@CODIGO", OracleDbType.Varchar2).Value = codigo
        cmd.Parameters.Add("@UNIDADES", OracleDbType.Varchar2).Value = unid
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub


End Class
