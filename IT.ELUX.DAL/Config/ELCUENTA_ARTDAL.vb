Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELCUENTA_ARTDAL
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

    Public Function VerificarRepetido(ByVal anho As String, ByVal art_cod As String) As Boolean
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CUENTA_ART_VERIFICAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@art_cod", art_cod)})
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

    Public Function SelectAll(ByVal anho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CUENTA_ART_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using

        Return dt
    End Function

    Public Function SelectArticuloCuenta() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_CUENTA_ART", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using

        Return dt
    End Function

    Public Function SelectRow(ByVal sTdoc As String, ByVal sSDoc As String, ByVal sNDoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CUENTA_ART_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@stdoc", sTdoc),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@ssdoc", sSDoc),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@sndoc", sNDoc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function

    Public Function SaveRow(ByVal ELCUENTA_ARTBE As ELCUENTA_ARTBE, ByVal flagAccion As String) As String
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
                InsertRow(ELCUENTA_ARTBE, cn, sqlTrans)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELCUENTA_ARTBE, cn, sqlTrans)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELCUENTA_ARTBE, cn, sqlTrans)
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

    Private Sub DeleteRow(ByVal ELCUENTA_ARTBE As ELCUENTA_ARTBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_LIB_CONT_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ELLIB_CONTBE.cod
        cmd.ExecuteNonQuery()

    End Sub

    Private Sub InsertRow(ByVal ELCUENTA_ARTBE As ELCUENTA_ARTBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CUENTA_ART_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELCUENTA_ARTBE.art_anho
        cmd.Parameters.Add("@codigo", OracleDbType.Varchar2).Value = ELCUENTA_ARTBE.art_codigo
        cmd.Parameters.Add("@cuenta", OracleDbType.Varchar2).Value = ELCUENTA_ARTBE.art_cuenta
        cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = ELCUENTA_ARTBE.art_estado

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
    Private Sub UpdateRow(ByVal ELCUENTA_ARTBE As ELCUENTA_ARTBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CUENTA_ART_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELCUENTA_ARTBE.art_anho
        cmd.Parameters.Add("@codigo", OracleDbType.Varchar2).Value = ELCUENTA_ARTBE.art_codigo
        cmd.Parameters.Add("@cuenta", OracleDbType.Varchar2).Value = ELCUENTA_ARTBE.art_cuenta
        cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = ELCUENTA_ARTBE.art_estado

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
    Public Function SelectAllOrden(ByVal anho As String, ByVal mes As String, ByVal estado As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CUENTA_ART_SELECTALLORDEN", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", mes),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@estado", estado)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using

        Return dt
    End Function
    Public Function SelectAllOREQ(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ORDEN_OREQ_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using

        Return dt
    End Function
End Class
