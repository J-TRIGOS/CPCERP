Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELLIQUIDACIONDAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String
    Public Function SelPerAll(ByVal var As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_ROT_All", {New Oracle.ManagedDataAccess.Client.OracleParameter("@var", var)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAll(ByVal Anho As String, ByVal Mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_LIQUIDACION_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", Anho),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", Mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRow(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_LIQUIDACION_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", sTdoc),
                                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sSdoc),
                                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@per_cod", sNdoc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SaveRow(ByVal LIQUIDACIONBE As ELLIQUIDACIONBE, ByVal flagAccion As String) As String
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

                InsertRow(LIQUIDACIONBE, cn, sqlTrans)
            End If

            If flagAccion = "M" Then
                UpdateRow(LIQUIDACIONBE, cn, sqlTrans)
            End If

            If flagAccion = "E" Then
                'DeleteRow(ELCONTRATOBE, cn, sqlTrans)
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
            If resultado = "OK" And flagAccion <> "E" Then
                cn.Dispose()
            End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function

    Private Sub InsertRow(ByVal LIQUIDACIONBE As ELLIQUIDACIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_LIQUIDACION_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = LIQUIDACIONBE.per_cod
        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = LIQUIDACIONBE.anho
        cmd.Parameters.Add("@mes", OracleDbType.Varchar2).Value = LIQUIDACIONBE.mes
        cmd.Parameters.Add("@monto", OracleDbType.Double).Value = LIQUIDACIONBE.monto
        cmd.Parameters.Add("@interes", OracleDbType.Double).Value = LIQUIDACIONBE.interes
        cmd.Parameters.Add("@monto_cts", OracleDbType.Double).Value = LIQUIDACIONBE.monto_cts
        cmd.Parameters.Add("@vacaciones", OracleDbType.Double).Value = LIQUIDACIONBE.vacaciones
        cmd.Parameters.Add("@grati", OracleDbType.Double).Value = LIQUIDACIONBE.gratis
        cmd.Parameters.Add("@Hextras", OracleDbType.Double).Value = LIQUIDACIONBE.Hextras
        cmd.Parameters.Add("@comision", OracleDbType.Double).Value = LIQUIDACIONBE.comision
        cmd.Parameters.Add("@subsidio", OracleDbType.Double).Value = LIQUIDACIONBE.subsidio
        cmd.Parameters.Add("@meses", OracleDbType.Double).Value = LIQUIDACIONBE.meses
        cmd.Parameters.Add("@dias", OracleDbType.Double).Value = LIQUIDACIONBE.dias
        cmd.Parameters.Add("@prdo_pago", OracleDbType.Double).Value = LIQUIDACIONBE.prdo_pago
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = PERBE.COD  'cod usu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo turno"
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub UpdateRow(ByVal LIQUIDACIONBE As ELLIQUIDACIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_LIQUIDACION_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = LIQUIDACIONBE.per_cod
        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = LIQUIDACIONBE.anho
        cmd.Parameters.Add("@mes", OracleDbType.Varchar2).Value = LIQUIDACIONBE.mes
        cmd.Parameters.Add("@monto", OracleDbType.Double).Value = LIQUIDACIONBE.monto
        cmd.Parameters.Add("@interes", OracleDbType.Double).Value = LIQUIDACIONBE.interes
        cmd.Parameters.Add("@monto_cts", OracleDbType.Double).Value = LIQUIDACIONBE.monto_cts
        cmd.Parameters.Add("@vacaciones", OracleDbType.Double).Value = LIQUIDACIONBE.vacaciones
        cmd.Parameters.Add("@grati", OracleDbType.Double).Value = LIQUIDACIONBE.gratis
        cmd.Parameters.Add("@Hextras", OracleDbType.Double).Value = LIQUIDACIONBE.Hextras
        cmd.Parameters.Add("@comision", OracleDbType.Double).Value = LIQUIDACIONBE.comision
        cmd.Parameters.Add("@subsidio", OracleDbType.Double).Value = LIQUIDACIONBE.subsidio
        cmd.Parameters.Add("@meses", OracleDbType.Double).Value = LIQUIDACIONBE.meses
        cmd.Parameters.Add("@dias", OracleDbType.Double).Value = LIQUIDACIONBE.dias
        cmd.Parameters.Add("@prdo_pago", OracleDbType.Double).Value = LIQUIDACIONBE.prdo_pago
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELCONTRATOBE.codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el contrato de: " + ELCONTRATOBE.dni
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Public Function VerificarRepetido(ByVal anho As String, ByVal mes As String, ByVal per_cod As String) As Boolean
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LIQUIDACION_VERIFICAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", mes),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@per_cod", per_cod)})
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function
End Class
