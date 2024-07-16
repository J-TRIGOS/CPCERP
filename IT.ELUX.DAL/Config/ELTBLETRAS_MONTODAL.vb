Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBLETRAS_MONTODAL
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

    Public Function VerificarRepetido(ByVal Code As String, ByVal Code2 As String, ByVal Code3 As String) As Boolean
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CTABANCO_VERIFICAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode", Code),
                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode2", Code2), New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode3", Code3)})
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function

    Public Function SelectMaxLibro() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LIB_CONT_LASTCOD", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Public Function SelectAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_LIB_CONT_SELECTALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRow(ByVal sTdoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_LIB_CONT_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", sTdoc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SaveRow(ByVal ELTBLETRAS_MONTOBE As ELTBLETRAS_MONTOBE, ByVal flagAccion As String) As String
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

                InsertRow(ELTBLETRAS_MONTOBE, cn, sqlTrans)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBLETRAS_MONTOBE, cn, sqlTrans)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELTBLETRAS_MONTOBE, cn, sqlTrans)
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

    Private Sub DeleteRow(ByVal ELTBLETRAS_MONTOBE As ELTBLETRAS_MONTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_LIB_CONT_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ELLIB_CONTBE.cod
        cmd.ExecuteNonQuery()

    End Sub

    Private Sub InsertRow(ByVal ELTBLETRAS_MONTOBE As ELTBLETRAS_MONTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_LETRAMON_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.t_doc_ref
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.ser_doc_ref
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.nro_doc_ref
        cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.t_doc_ref1
        cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.ser_doc_ref1
        cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.nro_doc_ref1
        cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.proveedor
        cmd.Parameters.Add("@montos", OracleDbType.Double).Value = ELTBLETRAS_MONTOBE.montos
        cmd.Parameters.Add("@montod", OracleDbType.Double).Value = ELTBLETRAS_MONTOBE.montod
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = ELTBLETRAS_MONTOBE.moneda

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
    Private Sub UpdateRow(ByVal ELTBLETRAS_MONTOBE As ELTBLETRAS_MONTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_LIB_CONT_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELLIB_CONTBE.cod
        'cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = ELLIB_CONTBE.nom
        'cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = ELLIB_CONTBE.estado
        'cmd.ExecuteNonQuery()
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
    Public Function VerificarRepetido(ByVal cod As String) As Boolean
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LIB_CONT_VERIFICAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod)})
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function
End Class
