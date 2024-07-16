Imports IT.ELUX.BE
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBRECCDAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE


    Private Sub InsertRow(ByVal ELTBRECCBE As ELTBRECCBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                          ByVal scodcat As String)
        'Recorrido para vaciar el grid
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBRECC_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@rcc_codcat", OracleDbType.Char).Value = ELTBRECCBE.rcc_codcat

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBRECC_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBRECCBE.rcc_codcar = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            ELTBRECCBE.rcc_codcat = scodcat
            cmd.Parameters.Add("@rcc_codcar", OracleDbType.Char).Value = ELTBRECCBE.rcc_codcar
            cmd.Parameters.Add("@rcc_codcat", OracleDbType.Char).Value = ELTBRECCBE.rcc_codcat
            cmd.Parameters.Add("@rcc_item", OracleDbType.Char).Value = Format(cont, "000")
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub


    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ELTBRECCBE As ELTBRECCBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBRECC_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@rcc_codcat", OracleDbType.Char).Value = ELTBRECCBE.rcc_codcat

        cmd.ExecuteNonQuery()


    End Sub

    'Funcion Principal que hara toda la logica para grabar la data
    Public Function SaveRow(ByVal ELTBRECCBE As ELTBRECCBE, ByVal flagAccion As String, ByVal dg As DataGridView,
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
                InsertRow(ELTBRECCBE, cn, sqlTrans, dg, scodcat)

                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                'UpdateRow(ELTBRECCBE, cn, sqlTrans)
                InsertRow(ELTBRECCBE, cn, sqlTrans, dg, scodcat)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELTBRECCBE, cn, sqlTrans)
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

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBRECC_SelectRow", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectAll(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBRECC_SelectRow", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using

        Return dt

    End Function
End Class
