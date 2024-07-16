Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class CCOSTODAL
    Inherits BaseDatosORACLE

    Private Sub InsertRow(ByVal CCOSTOBE As CCOSTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CCOSTO_INS"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        ''Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = CCOSTOBE.cod
        cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = CCOSTOBE.nom
        cmd.Parameters.Add("@ccosto_codigo", OracleDbType.Varchar2).Value = CCOSTOBE.ccosto_codigo
        cmd.Parameters.Add("@ccosto_cod", OracleDbType.Varchar2).Value = CCOSTOBE.ccosto_uninego
        cmd.Parameters.Add("@est", OracleDbType.Char).Value = CCOSTOBE.est
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el centro de costo: " + CCOSTOBE.cod
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Function SelectAllLines() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CCOSTO_SELECTALLCCO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    'Metodo para Modificar 
    Private Sub UpdateRow(ByVal CCOSTOBE As CCOSTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE)
        'realiza registro del catalogo
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CCOSTO_UPD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pcod", OracleDbType.Char).Value = CCOSTOBE.cod
        cmd.Parameters.Add("pnom", OracleDbType.Varchar2).Value = CCOSTOBE.nom
        cmd.Parameters.Add("pccosto_codigo", OracleDbType.Varchar2).Value = CCOSTOBE.ccosto_codigo
        cmd.Parameters.Add("pccosto_uninego", OracleDbType.Varchar2).Value = CCOSTOBE.ccosto_uninego
        cmd.Parameters.Add("pest", OracleDbType.Char).Value = CCOSTOBE.est

        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Modifico el Centro de Costo: " + CCOSTOBE.cod + " " + CCOSTOBE.nom
        cmd.ExecuteNonQuery()
        cmd.Dispose()



    End Sub

    'Funcion Principal que hara toda la logica para grabar la data
    Public Function SaveRow(ByVal CCOSTOBE As CCOSTOBE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE) As String
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

                InsertRow(CCOSTOBE, cn, sqlTrans, ELMVLOGSBE)

                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                UpdateRow(CCOSTOBE, cn, sqlTrans, ELMVLOGSBE)
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

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CCOSTO_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Function SelectClasi() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBCOSTOGASTO_LISTA", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function


    Public Function SelectAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CCOSTO_SELALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function LastCodigo() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_CCOSTO_SELNRO1", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)

    End Function
    Public Function LastCodigo1(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_CCOSTO_SELNRO2", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)

    End Function

    Public Function SelectNom(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_CCOSTO_SELNOM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Try
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function Selectcodlin(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_CCOSTO_SELNOM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Try
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function getListdgv(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CCOSTO_SELROWLINEA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
