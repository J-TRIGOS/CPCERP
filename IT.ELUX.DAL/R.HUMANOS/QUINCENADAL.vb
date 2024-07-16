Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect

Public Class QUINCENADAL

    Inherits BaseDatosORACLE

    Public Function ListadoPersonalQUincena(ByVal mes As String, ByVal anho As String, ByVal nn As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CALCULO_QUINCENA", {New Oracle.ManagedDataAccess.Client.OracleParameter("MNN", nn),
                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("MMES", mes),
                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("MANHO", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SaveRow(ByVal flagAccion As String, ByVal anho As String, ByVal mes As String, ByVal dg As DataGridView) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction

        cn = ConnectionBegin()

        sqlTrans = cn.BeginTransaction

        Try
            'N:Nuevo   M:Modificar   E:Eliminar 

            If flagAccion = "N" Then
                InsertRow(cn, sqlTrans, dg, anho, mes)
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

            sqlTrans = Nothing
        End Try
        Return resultado
    End Function

    Private Sub InsertRow(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal dg As DataGridView, ByVal anho As String, ByVal mes As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_INS_QUINCENA"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add("MMES", OracleDbType.Varchar2).Value = mes
            cmd.Parameters.Add("MANHO", OracleDbType.Varchar2).Value = anho
            cmd.Parameters.Add("MPER_COD", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("COD").Value)), "", RTrim(row.Cells("COD").Value))
            cmd.Parameters.Add("@MMONTO", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("MONTO").Value)), "", RTrim(row.Cells("MONTO").Value))
            cmd.Parameters.Add("@MDIAS", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("DIAS").Value)), "", RTrim(row.Cells("DIAS").Value))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

    End Sub
End Class
