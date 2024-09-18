Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports System.Data
'Imports System.Data.OracleClient
'Imports Oracle.DataAccess.Client
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBALMACENDAL

    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE


    'Funcion que me ve permitir generar el codigo 
    Public Function LastCodigo() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBALMACEN_LASTCODIGO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)

    End Function

    'Metodo para registrar un nuevo 
    Private Sub InsertRow(ByVal ELTBALMACENBE As ELTBALMACENBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBALMACEN_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@usu_codigo", OracleDbType.Varchar2).Value = ELTBALMACENBE.alm_codigo
        cmd.Parameters.Add("@usu_descri", OracleDbType.Varchar2).Value = ELTBALMACENBE.alm_descri
        cmd.Parameters.Add("@alm_direccion", OracleDbType.Varchar2).Value = ELTBALMACENBE.alm_direccion
        cmd.Parameters.Add("@usu_codest", OracleDbType.Char).Value = ELTBALMACENBE.alm_codest
        cmd.ExecuteNonQuery()

        cmd.Dispose()


    End Sub

    'Metodo para Modificar 
    Private Sub UpdateRow(ByVal ELTBALMACENBE As ELTBALMACENBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBALMACEN_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("palm_codigo", OracleDbType.Varchar2).Value = ELTBALMACENBE.alm_codigo
        cmd.Parameters.Add("palm_descri", OracleDbType.Varchar2).Value = ELTBALMACENBE.alm_descri
        cmd.Parameters.Add("palm_direccion", OracleDbType.Varchar2).Value = ELTBALMACENBE.alm_direccion
        cmd.Parameters.Add("palm_codest", OracleDbType.Char).Value = ELTBALMACENBE.alm_codest

        cmd.ExecuteNonQuery()

        cmd.Dispose()


    End Sub

    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ELTBALMACENBE As ELTBALMACENBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBALMACEN_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@usu_codigo", OracleDbType.Char).Value = ELTBALMACENBE.alm_codigo

        cmd.ExecuteNonQuery()


    End Sub

    'Funcion Principal que hara toda la logica para grabar la data
    Public Function SaveRow(ByVal ELTBALMACENBE As ELTBALMACENBE, ByVal flagAccion As String) As String
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
                InsertRow(ELTBALMACENBE, cn, sqlTrans)

                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBALMACENBE, cn, sqlTrans)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELTBALMACENBE, cn, sqlTrans)
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

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBALMACEN_SelectRow", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBALMACEN_SelectAll", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectAll1() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBALMACEN_SelectAll1", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SavedataFallados(ByVal modulo As String, ByVal estado As String, ByVal anho As String, ByVal mes As String) As String
        Dim resultado As String = "OK"
        Dim cnF As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTransF As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cnF = ConnectionBeginF()
        '' cn.Open()
        sqlTransF = cnF.BeginTransaction

        Try
            InsertDataFallados(modulo, estado, anho, mes, cnF, sqlTransF)

            sqlTransF.Commit()
            resultado = "OK"

        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTransF.Rollback()
            resultado = ex.Message
        Catch ex As Exception
            sqlTransF.Rollback()
            resultado = ex.Message
        Finally
            If resultado = "OK" Then
                'cnF.Dispose()
            End If
            sqlTransF = Nothing
        End Try

        Return resultado
    End Function

    Public Function SavedataReingresos(ByVal modulo As String, ByVal estado As String, ByVal anho As String, ByVal mes As String) As String
        Dim resultado As String = "OK"
        Dim cnR As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTransR As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cnR = ConnectionBeginR()
        '' cn.Open()
        sqlTransR = cnR.BeginTransaction

        Try
            InsertDataReingresos(modulo, estado, anho, mes, cnR, sqlTransR)

            sqlTransR.Commit()
            resultado = "OK"

        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTransR.Rollback()
            resultado = ex.Message
        Catch ex As Exception
            sqlTransR.Rollback()
            resultado = ex.Message
        Finally
            If resultado = "OK" Then
                ' cnR.Dispose()
            End If
            sqlTransR = Nothing
        End Try

        Return resultado
    End Function
    Public Function SavedataAProduccion(ByVal modulo As String, ByVal estado As String, ByVal anho As String, ByVal mes As String) As String
        Dim resultado As String = "OK"
        Dim cnP As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTransP As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cnP = ConnectionBeginP()
        '' cn.Open()
        sqlTransP = cnP.BeginTransaction

        Try
            InsertDataProduccion(modulo, estado, anho, mes, cnP, sqlTransP)

            sqlTransP.Commit()
            resultado = "OK"

        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTransP.Rollback()
            resultado = ex.Message
        Catch ex As Exception
            sqlTransP.Rollback()
            resultado = ex.Message
        Finally
            If resultado = "OK" Then
                ' cnP.Dispose()
            End If
            sqlTransP = Nothing
        End Try

        Return resultado
    End Function

    Public Function SavedataAlmacen(ByVal modulo As String, ByVal estado As String, ByVal anho As String, ByVal mes As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBeginA()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try
            InsertDataAlmacen(modulo, estado, anho, mes, cn, sqlTrans)

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
                'cn.Dispose()
            End If
            sqlTrans = Nothing
        End Try

        Return resultado
    End Function

    Public Function SelectCierreMes(ByVal manho As String, ByVal mmes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SELECT_CIERRMES", {New Oracle.ManagedDataAccess.Client.OracleParameter("@MANHO", manho),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MMES", mmes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function


    Private Sub InsertDataProduccion(ByVal modulo As String, ByVal estado As String, ByVal anho As String, ByVal mes As String, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ACT_CIERREMES"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@MMODULO", OracleDbType.Varchar2).Value = modulo
        cmd.Parameters.Add("@MESTADO", OracleDbType.Varchar2).Value = estado
        cmd.Parameters.Add("@MANHO", OracleDbType.Varchar2).Value = anho
        cmd.Parameters.Add("@MMES", OracleDbType.Varchar2).Value = mes
        cmd.ExecuteNonQuery()

        cmd.Dispose()
    End Sub

    Private Sub InsertDataFallados(ByVal modulo As String, ByVal estado As String, ByVal anho As String, ByVal mes As String, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ACT_CIERREMES"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@MMODULO", OracleDbType.Varchar2).Value = modulo
        cmd.Parameters.Add("@MESTADO", OracleDbType.Varchar2).Value = estado
        cmd.Parameters.Add("@MANHO", OracleDbType.Varchar2).Value = anho
        cmd.Parameters.Add("@MMES", OracleDbType.Varchar2).Value = mes
        cmd.ExecuteNonQuery()

        cmd.Dispose()
    End Sub

    Private Sub InsertDataReingresos(ByVal modulo As String, ByVal estado As String, ByVal anho As String, ByVal mes As String, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ACT_CIERREMES"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@MMODULO", OracleDbType.Varchar2).Value = modulo
        cmd.Parameters.Add("@MESTADO", OracleDbType.Varchar2).Value = estado
        cmd.Parameters.Add("@MANHO", OracleDbType.Varchar2).Value = anho
        cmd.Parameters.Add("@MMES", OracleDbType.Varchar2).Value = mes
        cmd.ExecuteNonQuery()

        cmd.Dispose()
    End Sub

    Private Sub InsertDataAlmacen(ByVal modulo As String, ByVal estado As String, ByVal anho As String, ByVal mes As String, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ACT_CIERREMES"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@MMODULO", OracleDbType.Varchar2).Value = modulo
        cmd.Parameters.Add("@MESTADO", OracleDbType.Varchar2).Value = estado
        cmd.Parameters.Add("@MANHO", OracleDbType.Varchar2).Value = anho
        cmd.Parameters.Add("@MMES", OracleDbType.Varchar2).Value = mes
        cmd.ExecuteNonQuery()

        cmd.Dispose()
    End Sub
End Class
