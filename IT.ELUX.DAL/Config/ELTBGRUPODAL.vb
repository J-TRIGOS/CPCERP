Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBGRUPODAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE


    'Funcion que me ve permitir generar el codigo 
    Public Function LastCodigo() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBGRUPO_LASTCODIGO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)

    End Function
    'Metodo para registrar un nuevo 
    Private Sub InsertRow(ByVal ELTBGRUPOBE As ELTBGRUPOBE, ByVal ELTBDETGRUPOBE As ELTBDETGRUPOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                          ByVal cod As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETGRUPO_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@COD_AREA", OracleDbType.Char).Value = ELTBGRUPOBE.cod
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBGRUPO_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBGRUPOBE.cod
        cmd.Parameters.Add("@descripcion", OracleDbType.Varchar2).Value = ELTBGRUPOBE.nom
        cmd.Parameters.Add("@est", OracleDbType.Char).Value = ELTBGRUPOBE.est
        cmd.Parameters.Add("@cco_cod", OracleDbType.Char).Value = ELTBGRUPOBE.cco_cod
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETGRUPO_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBDETGRUPOBE.cod_grupo = cod
            ELTBDETGRUPOBE.per_cod = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            cmd.Parameters.Add("@cod_grupo", OracleDbType.Char).Value = ELTBGRUPOBE.cod
            cmd.Parameters.Add("@per_cod", OracleDbType.Char).Value = ELTBDETGRUPOBE.per_cod
            'cmd.Parameters.Add("@rcc_item", OracleDbType.Char).Value = Format(cont, "000")
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PER_UPDATEROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@cod_grupo", OracleDbType.Char).Value = ELTBGRUPOBE.cod
            cmd.Parameters.Add("@per_cod", OracleDbType.Char).Value = ELTBDETGRUPOBE.per_cod
            'cmd.Parameters.Add("@rcc_item", OracleDbType.Char).Value = Format(cont, "000")
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub

    'Metodo para Modificar 
    Private Sub UpdateRow(ByVal ELTBGRUPOBE As ELTBGRUPOBE, ByVal ELTBDETGRUPOBE As ELTBDETGRUPOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                          ByVal cod As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETGRUPO_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@COD_AREA", OracleDbType.Char).Value = ELTBGRUPOBE.cod
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBGRUPO_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pcod", OracleDbType.Varchar2).Value = ELTBGRUPOBE.cod
        cmd.Parameters.Add("pdescripcion", OracleDbType.Varchar2).Value = ELTBGRUPOBE.nom
        cmd.Parameters.Add("pest", OracleDbType.Char).Value = ELTBGRUPOBE.est
        cmd.Parameters.Add("cco_cod", OracleDbType.Char).Value = ELTBGRUPOBE.cco_cod
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PER_UPDATECLEAN"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@per_cod", OracleDbType.Char).Value = ELTBGRUPOBE.cod

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETGRUPO_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBDETGRUPOBE.cod_grupo = cod
            ELTBDETGRUPOBE.per_cod = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            cmd.Parameters.Add("@cod_grupo", OracleDbType.Char).Value = ELTBGRUPOBE.cod
            cmd.Parameters.Add("@per_cod", OracleDbType.Char).Value = ELTBDETGRUPOBE.per_cod
            'cmd.Parameters.Add("@rcc_item", OracleDbType.Char).Value = Format(cont, "000")
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PER_UPDATEROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@cod_grupo", OracleDbType.Char).Value = ELTBGRUPOBE.cod
            cmd.Parameters.Add("@per_cod", OracleDbType.Char).Value = ELTBDETGRUPOBE.per_cod
            'cmd.Parameters.Add("@rcc_item", OracleDbType.Char).Value = Format(cont, "000")
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        'realiza registro del catalogo



    End Sub

    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ELTBGRUPOBE As ELTBGRUPOBE, ByVal ELTBDETGRUPOBE As ELTBDETGRUPOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                          ByVal cod As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBGRUPO_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ELTBGRUPOBE.cod

        cmd.ExecuteNonQuery()


    End Sub

    'Funcion Principal que hara toda la logica para grabar la data
    Public Function SaveRow(ByVal ELTBGRUPOBE As ELTBGRUPOBE, ByVal ELTBDETGRUPOBE As ELTBDETGRUPOBE, ByVal flagAccion As String,
                            ByVal dg As DataGridView, ByVal cod As String) As String
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
                InsertRow(ELTBGRUPOBE, ELTBDETGRUPOBE, cn, sqlTrans, dg, cod)

                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBGRUPOBE, ELTBDETGRUPOBE, cn, sqlTrans, dg, cod)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELTBGRUPOBE, ELTBDETGRUPOBE, cn, sqlTrans, dg, cod)
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
    Function list1() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBGRUPO_PER", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function list2(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBGRUPO_PER1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function listcco_cod(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_LISTCCO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function listgrupo() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBGRUPO_SEARH", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function

    'Funcion que me va permitir capturar la lista de registros en la tabla y que me va retornar
    'un Datatable
    Public Function SelectRow(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBGRUPO_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
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
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBGRUPO_DESCRIPCION", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBGRUPO_SelectAll", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SearhGroup(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBGRUPO_SEARHGROUP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SearhDetGrup(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDETGRUPO_PER", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SearhCCO() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_RPTETIQUETABUSPERCCO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SearhALLCCO(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CCOSTO_SELALLUBI", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SearhPERCAL() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_RPTETIQUETABUSPERCAL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
