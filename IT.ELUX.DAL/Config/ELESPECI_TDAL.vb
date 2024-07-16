Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELESPECI_TDAL
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
    Public Function SelectArt4(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELECTART4", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

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

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ESPECI_T_SELECTALL", {})
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

    Public Function SelectRow(ByVal sTdoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ESPECI_T_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", sTdoc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SaveRow(ByVal ELESPECI_TBE As ELESPECI_TBE, ByVal flagAccion As String) As String
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

                InsertRow(ELESPECI_TBE, cn, sqlTrans)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELESPECI_TBE, cn, sqlTrans)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELESPECI_TBE, cn, sqlTrans)
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

    Private Sub DeleteRow(ByVal ELESPECI_TBE As ELESPECI_TBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_LIB_CONT_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ELLIB_CONTBE.cod
        cmd.ExecuteNonQuery()

    End Sub

    Private Sub InsertRow(ByVal ELESPECI_TBE As ELESPECI_TBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ESPECI_T_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@cod_articulo", OracleDbType.Varchar2).Value = ELESPECI_TBE.cod_articulo
        cmd.Parameters.Add("@altura_cuerpo", OracleDbType.Varchar2).Value = ELESPECI_TBE.altura_cuerpo
        cmd.Parameters.Add("@ac1", OracleDbType.Varchar2).Value = ELESPECI_TBE.ac1
        cmd.Parameters.Add("@ac2", OracleDbType.Varchar2).Value = ELESPECI_TBE.ac2
        cmd.Parameters.Add("@ac3", OracleDbType.Varchar2).Value = ELESPECI_TBE.ac3
        cmd.Parameters.Add("@altura_env_tapa", OracleDbType.Varchar2).Value = ELESPECI_TBE.altura_env_tapa
        cmd.Parameters.Add("@aet1", OracleDbType.Varchar2).Value = ELESPECI_TBE.aet1
        cmd.Parameters.Add("@aet2", OracleDbType.Varchar2).Value = ELESPECI_TBE.aet2
        cmd.Parameters.Add("@aet3", OracleDbType.Varchar2).Value = ELESPECI_TBE.aet3
        cmd.Parameters.Add("@diametro_interno", OracleDbType.Varchar2).Value = ELESPECI_TBE.diametro_interno
        cmd.Parameters.Add("@Di1", OracleDbType.Varchar2).Value = ELESPECI_TBE.Di1
        cmd.Parameters.Add("@Di2", OracleDbType.Varchar2).Value = ELESPECI_TBE.Di2
        cmd.Parameters.Add("@Di3", OracleDbType.Varchar2).Value = ELESPECI_TBE.Di3
        cmd.Parameters.Add("@diametro_externo", OracleDbType.Varchar2).Value = ELESPECI_TBE.diametro_externo
        cmd.Parameters.Add("@De1", OracleDbType.Varchar2).Value = ELESPECI_TBE.De1
        cmd.Parameters.Add("@De2", OracleDbType.Varchar2).Value = ELESPECI_TBE.De2
        cmd.Parameters.Add("@De3", OracleDbType.Varchar2).Value = ELESPECI_TBE.De3
        cmd.Parameters.Add("@ancho_envase", OracleDbType.Varchar2).Value = ELESPECI_TBE.ancho_envase
        cmd.Parameters.Add("@ae1", OracleDbType.Varchar2).Value = ELESPECI_TBE.ae1
        cmd.Parameters.Add("@ae2", OracleDbType.Varchar2).Value = ELESPECI_TBE.ae2
        cmd.Parameters.Add("@ae3", OracleDbType.Varchar2).Value = ELESPECI_TBE.ae3
        cmd.Parameters.Add("@largo_envase", OracleDbType.Varchar2).Value = ELESPECI_TBE.largo_envase
        cmd.Parameters.Add("@le1", OracleDbType.Varchar2).Value = ELESPECI_TBE.le1
        cmd.Parameters.Add("@le2", OracleDbType.Varchar2).Value = ELESPECI_TBE.le2
        cmd.Parameters.Add("@le3", OracleDbType.Varchar2).Value = ELESPECI_TBE.le3
        cmd.Parameters.Add("@altura_tapa", OracleDbType.Varchar2).Value = ELESPECI_TBE.altura_tapa
        cmd.Parameters.Add("@ata1", OracleDbType.Varchar2).Value = ELESPECI_TBE.ata1
        cmd.Parameters.Add("@ata2", OracleDbType.Varchar2).Value = ELESPECI_TBE.ata2
        cmd.Parameters.Add("@ata3", OracleDbType.Varchar2).Value = ELESPECI_TBE.ata3
        cmd.Parameters.Add("@peso_envase", OracleDbType.Varchar2).Value = ELESPECI_TBE.peso_envase
        cmd.Parameters.Add("@pe1", OracleDbType.Varchar2).Value = ELESPECI_TBE.pe1
        cmd.Parameters.Add("@pe2", OracleDbType.Varchar2).Value = ELESPECI_TBE.pe2
        cmd.Parameters.Add("@pe3", OracleDbType.Varchar2).Value = ELESPECI_TBE.pe3
        cmd.Parameters.Add("@altura_asa", OracleDbType.Varchar2).Value = ELESPECI_TBE.altura_asa
        cmd.Parameters.Add("@aa1", OracleDbType.Varchar2).Value = ELESPECI_TBE.aa1
        cmd.Parameters.Add("@aa2", OracleDbType.Varchar2).Value = ELESPECI_TBE.aa2
        cmd.Parameters.Add("@aa3", OracleDbType.Varchar2).Value = ELESPECI_TBE.aa3

        cmd.Parameters.Add("@acabado_F_envase", OracleDbType.Varchar2).Value = ELESPECI_TBE.acabado_F_envase
        cmd.Parameters.Add("@embalaje_primario", OracleDbType.Varchar2).Value = ELESPECI_TBE.embalaje_primario
        cmd.Parameters.Add("@embalaje_secundario", OracleDbType.Varchar2).Value = ELESPECI_TBE.embalaje_secundario
        cmd.Parameters.Add("@separadores", OracleDbType.Varchar2).Value = ELESPECI_TBE.separadores
        cmd.Parameters.Add("@nro_envase", OracleDbType.Varchar2).Value = ELESPECI_TBE.nro_envase
        cmd.Parameters.Add("@espesor_hojalata", OracleDbType.Varchar2).Value = ELESPECI_TBE.espesor_hojalata
        cmd.Parameters.Add("@temple_hojalata", OracleDbType.Varchar2).Value = ELESPECI_TBE.temple_hojalata

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
    Private Sub UpdateRow(ByVal ELESPECI_TBE As ELESPECI_TBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ESPECI_T_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@cod_articulo", OracleDbType.Varchar2).Value = ELESPECI_TBE.cod_articulo
        cmd.Parameters.Add("@altura_cuerpo", OracleDbType.Varchar2).Value = ELESPECI_TBE.altura_cuerpo
        cmd.Parameters.Add("@ac1", OracleDbType.Varchar2).Value = ELESPECI_TBE.ac1
        cmd.Parameters.Add("@ac2", OracleDbType.Varchar2).Value = ELESPECI_TBE.ac2
        cmd.Parameters.Add("@ac3", OracleDbType.Varchar2).Value = ELESPECI_TBE.ac3
        cmd.Parameters.Add("@altura_env_tapa", OracleDbType.Varchar2).Value = ELESPECI_TBE.altura_env_tapa
        cmd.Parameters.Add("@aet1", OracleDbType.Varchar2).Value = ELESPECI_TBE.aet1
        cmd.Parameters.Add("@aet2", OracleDbType.Varchar2).Value = ELESPECI_TBE.aet2
        cmd.Parameters.Add("@aet3", OracleDbType.Varchar2).Value = ELESPECI_TBE.aet3
        cmd.Parameters.Add("@diametro_interno", OracleDbType.Varchar2).Value = ELESPECI_TBE.diametro_interno
        cmd.Parameters.Add("@Di1", OracleDbType.Varchar2).Value = ELESPECI_TBE.Di1
        cmd.Parameters.Add("@Di2", OracleDbType.Varchar2).Value = ELESPECI_TBE.Di2
        cmd.Parameters.Add("@Di3", OracleDbType.Varchar2).Value = ELESPECI_TBE.Di3
        cmd.Parameters.Add("@diametro_externo", OracleDbType.Varchar2).Value = ELESPECI_TBE.diametro_externo
        cmd.Parameters.Add("@De1", OracleDbType.Varchar2).Value = ELESPECI_TBE.De1
        cmd.Parameters.Add("@De2", OracleDbType.Varchar2).Value = ELESPECI_TBE.De2
        cmd.Parameters.Add("@De3", OracleDbType.Varchar2).Value = ELESPECI_TBE.De3
        cmd.Parameters.Add("@ancho_envase", OracleDbType.Varchar2).Value = ELESPECI_TBE.ancho_envase
        cmd.Parameters.Add("@ae1", OracleDbType.Varchar2).Value = ELESPECI_TBE.ae1
        cmd.Parameters.Add("@ae2", OracleDbType.Varchar2).Value = ELESPECI_TBE.ae2
        cmd.Parameters.Add("@ae3", OracleDbType.Varchar2).Value = ELESPECI_TBE.ae3
        cmd.Parameters.Add("@largo_envase", OracleDbType.Varchar2).Value = ELESPECI_TBE.largo_envase
        cmd.Parameters.Add("@le1", OracleDbType.Varchar2).Value = ELESPECI_TBE.le1
        cmd.Parameters.Add("@le2", OracleDbType.Varchar2).Value = ELESPECI_TBE.le2
        cmd.Parameters.Add("@le3", OracleDbType.Varchar2).Value = ELESPECI_TBE.le3
        cmd.Parameters.Add("@altura_tapa", OracleDbType.Varchar2).Value = ELESPECI_TBE.altura_tapa
        cmd.Parameters.Add("@ata1", OracleDbType.Varchar2).Value = ELESPECI_TBE.ata1
        cmd.Parameters.Add("@ata2", OracleDbType.Varchar2).Value = ELESPECI_TBE.ata2
        cmd.Parameters.Add("@ata3", OracleDbType.Varchar2).Value = ELESPECI_TBE.ata3
        cmd.Parameters.Add("@peso_envase", OracleDbType.Varchar2).Value = ELESPECI_TBE.peso_envase
        cmd.Parameters.Add("@pe1", OracleDbType.Varchar2).Value = ELESPECI_TBE.pe1
        cmd.Parameters.Add("@pe2", OracleDbType.Varchar2).Value = ELESPECI_TBE.pe2
        cmd.Parameters.Add("@pe3", OracleDbType.Varchar2).Value = ELESPECI_TBE.pe3
        cmd.Parameters.Add("@altura_asa", OracleDbType.Varchar2).Value = ELESPECI_TBE.altura_asa
        cmd.Parameters.Add("@aa1", OracleDbType.Varchar2).Value = ELESPECI_TBE.aa1
        cmd.Parameters.Add("@aa2", OracleDbType.Varchar2).Value = ELESPECI_TBE.aa2
        cmd.Parameters.Add("@aa3", OracleDbType.Varchar2).Value = ELESPECI_TBE.aa3

        cmd.Parameters.Add("@acabado_F_envase", OracleDbType.Varchar2).Value = ELESPECI_TBE.acabado_F_envase
        cmd.Parameters.Add("@embalaje_primario", OracleDbType.Varchar2).Value = ELESPECI_TBE.embalaje_primario
        cmd.Parameters.Add("@embalaje_secundario", OracleDbType.Varchar2).Value = ELESPECI_TBE.embalaje_secundario
        cmd.Parameters.Add("@separadores", OracleDbType.Varchar2).Value = ELESPECI_TBE.separadores
        cmd.Parameters.Add("@nro_envase", OracleDbType.Varchar2).Value = ELESPECI_TBE.nro_envase
        cmd.Parameters.Add("@espesor_hojalata", OracleDbType.Varchar2).Value = ELESPECI_TBE.espesor_hojalata
        cmd.Parameters.Add("@temple_hojalata", OracleDbType.Varchar2).Value = ELESPECI_TBE.temple_hojalata

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
        Using dr As OracleDataReader = Me.GetDataReader("SP_ESPECI_T_VERIFICAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod)})
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function
End Class
