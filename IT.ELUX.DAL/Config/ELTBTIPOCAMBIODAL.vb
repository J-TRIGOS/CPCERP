Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBTIPOCAMBIODAL

    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String
    'Public ELMVLOGSBE As New ELMVLOGSBE

    Public Function SelectAll(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TIPOCAMBIO_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ANIO", sFecAño), New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAll1(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TIPOCAMBIO_SELECTALL1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ANIO", sFecAño), New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TIPOCAMBIO_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRow1(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TIPOCAMBIO_SELECTROW1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectMaxTransp() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_TIPOCAMBIO_LASTCOD", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Public Function SelectT_Moneda() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TIPOCAMBIO_COMBO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function Verificar_Repetido(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TIPOCAMBIO_REPETIDO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Cod", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Private Sub InsertRow(ByVal ELTBTIPOCAMBIOBE As ELTBTIPOCAMBIOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TIPOCAMBIO_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@fec", OracleDbType.Varchar2).Value = ELTBTIPOCAMBIOBE.fec
        cmd.Parameters.Add("@mon_cod", OracleDbType.Varchar2).Value = ELTBTIPOCAMBIOBE.mon_cod
        cmd.Parameters.Add("@mon_cod_ref", OracleDbType.Varchar2).Value = ELTBTIPOCAMBIOBE.mon_cod_ref
        cmd.Parameters.Add("@compra", OracleDbType.Double).Value = ELTBTIPOCAMBIOBE.compra
        cmd.Parameters.Add("@venta", OracleDbType.Double).Value = ELTBTIPOCAMBIOBE.venta
        cmd.Parameters.Add("@tipo", OracleDbType.Char).Value = ELTBTIPOCAMBIOBE.tipo
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Private Sub UpdateRow(ByVal ELTBTIPOCAMBIOBE As ELTBTIPOCAMBIOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TIPOCAMBIO_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@fec", OracleDbType.Varchar2).Value = ELTBTIPOCAMBIOBE.fec
        cmd.Parameters.Add("@mon_cod", OracleDbType.Varchar2).Value = ELTBTIPOCAMBIOBE.mon_cod
        cmd.Parameters.Add("@mon_cod_ref", OracleDbType.Varchar2).Value = ELTBTIPOCAMBIOBE.mon_cod_ref
        cmd.Parameters.Add("@compra", OracleDbType.Double).Value = ELTBTIPOCAMBIOBE.compra
        cmd.Parameters.Add("@venta", OracleDbType.Double).Value = ELTBTIPOCAMBIOBE.venta
        cmd.Parameters.Add("@tipo", OracleDbType.Char).Value = ELTBTIPOCAMBIOBE.tipo
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Private Sub UpdCMB(ByVal ELTBTIPOCAMBIOBE As ELTBTIPOCAMBIOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_TCAMB_FEC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@fec", OracleDbType.Varchar2).Value = ELTBTIPOCAMBIOBE.fec1
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub


    Private Sub UpdCMB1(ByVal ELTBTIPOCAMBIOBE As ELTBTIPOCAMBIOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_TCAMB_FEC1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@fec", OracleDbType.Varchar2).Value = ELTBTIPOCAMBIOBE.fec1
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ELTBTIPOCAMBIOBE As ELTBTIPOCAMBIOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TIPOCAMBIO_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@fec", OracleDbType.Char).Value = ELTBTIPOCAMBIOBE.fec
        cmd.ExecuteNonQuery()

    End Sub

    Public Function SaveRow(ByVal ELTBTIPOCAMBIOBE As ELTBTIPOCAMBIOBE, ByVal flagAccion As String) As String
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
                InsertRow(ELTBTIPOCAMBIOBE, cn, sqlTrans)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBTIPOCAMBIOBE, cn, sqlTrans)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELTBTIPOCAMBIOBE, cn, sqlTrans)
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
            If resultado = "OK" And flagAccion <> "M" Then
                cn.Dispose()
            End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Public Function SaveRowCmb(ByVal ELTBTIPOCAMBIOBE As ELTBTIPOCAMBIOBE, ByVal flagAccion As String) As String
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
            If flagAccion = "UC" Then
                UpdCMB(ELTBTIPOCAMBIOBE, cn, sqlTrans)
            End If
            If flagAccion = "UCT" Then
                UpdCMB1(ELTBTIPOCAMBIOBE, cn, sqlTrans)
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
            'If resultado = "OK" Then
            '    cn.Dispose()
            'End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function

    Public Function CalcularDolares(ByVal mon As String, ByVal monto As Double, ByVal tc As Double) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CALCULAR_DOLARES", {New Oracle.ManagedDataAccess.Client.OracleParameter("@MON", mon),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@MONTO", monto),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@TC", tc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
