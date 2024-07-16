Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELCAJABANCODAL
    Inherits BaseDatosORACLE
    Public Function SaveRow(ByVal ELCAJABANCOBE As ELCAJABANCOBE, ByVal flagAccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction


        cn = ConnectionBegin()

        sqlTrans = cn.BeginTransaction

        Try
            'N:Nuevo   M:Modificar   E:Eliminar 

            If flagAccion = "N" Then
                InsertRow(ELCAJABANCOBE, cn, sqlTrans)
            End If
            If flagAccion = "N1" Then
                InsertRow1(ELCAJABANCOBE, cn, sqlTrans)
            End If
            If flagAccion = "M" Then
                UpdateRow(ELCAJABANCOBE, cn, sqlTrans)
            End If
            If flagAccion = "M1" Then
                UpdateRow1(ELCAJABANCOBE, cn, sqlTrans)
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
    Private Sub InsertRow(ByVal ELCAJABANCOBE As ELCAJABANCOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_AJUSTSALDOS_UPDATE"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELCAJABANCOBE.anho
        cmd.Parameters.Add("@mes", OracleDbType.Varchar2).Value = ELCAJABANCOBE.mes
        cmd.Parameters.Add("@mes1", OracleDbType.Varchar2).Value = ELCAJABANCOBE.mes1
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub InsertRow1(ByVal ELCAJABANCOBE As ELCAJABANCOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_AJUSTSALDOSI_INSERT"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELCAJABANCOBE.anho
        cmd.Parameters.Add("@monto", OracleDbType.Double).Value = ELCAJABANCOBE.monto
        cmd.Parameters.Add("@banco", OracleDbType.Varchar2).Value = ELCAJABANCOBE.banco
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = ELCAJABANCOBE.moneda
        cmd.Parameters.Add("@mes", OracleDbType.Varchar2).Value = ELCAJABANCOBE.mes

        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRow(ByVal ELCAJABANCOBE As ELCAJABANCOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        'ELIMINAR DETALLE PROGRAMA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBINICIALCB_DEL_SALDO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELCAJABANCOBE.anho
        cmd.Parameters.Add("@mes", OracleDbType.Varchar2).Value = ELCAJABANCOBE.mes1
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_AJUSTSALDOS_UPDATE"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELCAJABANCOBE.anho
        cmd.Parameters.Add("@mes", OracleDbType.Varchar2).Value = ELCAJABANCOBE.mes
        cmd.Parameters.Add("@mes1", OracleDbType.Varchar2).Value = ELCAJABANCOBE.mes1
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRow1(ByVal ELCAJABANCOBE As ELCAJABANCOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        'ELIMINAR DETALLE PROGRAMA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBINICIALCB_DEL_SALDO1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELCAJABANCOBE.anho
        cmd.Parameters.Add("@banco", OracleDbType.Varchar2).Value = ELCAJABANCOBE.banco
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = ELCAJABANCOBE.moneda
        cmd.Parameters.Add("@mes", OracleDbType.Varchar2).Value = ELCAJABANCOBE.mes
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_AJUSTSALDOSI_INSERT"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELCAJABANCOBE.anho
        cmd.Parameters.Add("@monto", OracleDbType.Double).Value = ELCAJABANCOBE.monto
        cmd.Parameters.Add("@banco", OracleDbType.Varchar2).Value = ELCAJABANCOBE.banco
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = ELCAJABANCOBE.moneda
        cmd.Parameters.Add("@mes", OracleDbType.Varchar2).Value = ELCAJABANCOBE.mes

        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Function SelectDataSaldos(ByVal sANHO As String, ByVal sMES As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBSALDOS_SELECT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ANHO", sANHO),
                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sMES)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectDataInicial(ByVal sANHO As String, ByVal sMES As String, ByVal sBCO As String, ByVal sMON As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBINICIALCB_SELECT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ANHO", sANHO),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sMES),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@BCO", sBCO),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@MON", sMON)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
