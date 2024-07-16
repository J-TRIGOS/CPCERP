﻿Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBGRUPCORDAL

    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE


    'Funcion que me ve permitir generar el codigo 
    Public Function LastCodigo() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBGRUPCOR_LASTCODIGO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)

    End Function

    'Metodo para registrar un nuevo 
    Private Sub InsertRow(ByVal ELTBGRUPCORBE As ELTBGRUPCORBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBGRUPCOR_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBGRUPCORBE.cod
        cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = ELTBGRUPCORBE.nom
        cmd.Parameters.Add("@est", OracleDbType.Char).Value = ELTBGRUPCORBE.est
        cmd.ExecuteNonQuery()

        cmd.Dispose()


    End Sub

    'Metodo para Modificar 
    Private Sub UpdateRow(ByVal ELTBGRUPCORBE As ELTBGRUPCORBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBGRUPCOR_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pcod", OracleDbType.Varchar2).Value = ELTBGRUPCORBE.cod
        cmd.Parameters.Add("pnom", OracleDbType.Varchar2).Value = ELTBGRUPCORBE.nom
        cmd.Parameters.Add("est", OracleDbType.Char).Value = ELTBGRUPCORBE.est

        cmd.ExecuteNonQuery()

        cmd.Dispose()


    End Sub

    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ELTBGRUPCORBE As ELTBGRUPCORBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBGRUPCOR_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ELTBGRUPCORBE.cod

        cmd.ExecuteNonQuery()


    End Sub

    'Funcion Principal que hara toda la logica para grabar la data
    Public Function SaveRow(ByVal ELTBGRUPCORBE As ELTBGRUPCORBE, ByVal flagAccion As String) As String
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
                InsertRow(ELTBGRUPCORBE, cn, sqlTrans)

                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBGRUPCORBE, cn, sqlTrans)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELTBGRUPCORBE, cn, sqlTrans)
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

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBGRUPCOR_SelectRow", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    'descripcion de la carecteristica
    Function LISTCMB() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBGRUPCOR_DESCRIPCION", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBGRUPCOR_SelectAll", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
End Class
