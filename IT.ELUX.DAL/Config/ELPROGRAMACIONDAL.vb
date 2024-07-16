Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELPROGRAMACIONDAL

    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String
    Public ELMVLOGSBE As New ELMVLOGSBE

    Public Function SelectAll(ByVal Anho As String, ByVal Mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PROGRAMACION_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", Anho),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", Mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function VerificarLinea(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNomArt = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_LINEA_CLIENTE", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            While dr.Read

                If IsDBNull(dr.GetString(0)) Then
                    sNomArt = ""
                Else
                    sNomArt = dr.GetString(0)
                End If
            End While
        End Using
        Return sNomArt
    End Function

    Public Function ContarRegistros() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNomArt = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TAREO_CONTAREG", {})
            While dr.Read

                sNomArt = dr.GetString(0)

            End While
        End Using
        Return sNomArt
    End Function

    Public Function SelectVendedor() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_VENDEDOR", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectPerCOD(ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PERSONAL_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRow(ByVal sCode As String, ByVal sCode2 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PROGRAMACION_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@per_cod", sCode), New Oracle.ManagedDataAccess.Client.OracleParameter("@prdo_cod", sCode2)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRowGrid(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TAREO_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectCIIU() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CLIENTE_CIIU", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectUbigeo() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CLIENTE_UBIGEO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectMaxTransp() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CLIENTE_LASTCOD", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function
    Public Function VerificarRepetido(ByVal Code As String, ByVal Prdo As String) As Boolean
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_VACACIONES_VERIFICAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Code", Code),
                                                       New Oracle.ManagedDataAccess.Client.OracleParameter("@Prdo", Prdo)})
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function

    Public Function SelectAreaCOD(ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_AREA_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectArea() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_AREA_BUSQUEDA", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectPeriodoCOD(ByVal anho As String, ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PERIODO_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectPeriodo(ByVal anho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PERIODO_BUSQUEDA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectSuspenCOD(ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SUSPENSION_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectSuspension() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SUSPENSION_BUSQUEDA", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectVendeCod(ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_VENDE_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectCondicionCod(ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_CONDICION_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Private Sub InsertRow(ByVal ELPROGRAMACIONBE As ELPROGRAMACIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dgvdatos As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0


        'Los parametros que va recibir son las propiedades de la clase

        For Each row As DataGridViewRow In dgvdatos.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PROGRAMACION_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            ELPROGRAMACIONBE.per_cod = IIf(IsDBNull(RTrim(row.Cells("PER_COD").Value)), "", RTrim(row.Cells("PER_COD").Value))
            ELPROGRAMACIONBE.d_programado = IIf(IsDBNull(RTrim(row.Cells("D_PROGRAMADO").Value)), "", RTrim(row.Cells("D_PROGRAMADO").Value))
            ELPROGRAMACIONBE.observacion = IIf(IsDBNull(RTrim(row.Cells("OBSERVACION").Value)), "", RTrim(row.Cells("OBSERVACION").Value))
            ELPROGRAMACIONBE.minutos = IIf(String.IsNullOrEmpty(RTrim(row.Cells("MINUTOS").Value)), 0, RTrim(row.Cells("MINUTOS").Value))
            ELPROGRAMACIONBE.prdo_cod = IIf(String.IsNullOrEmpty(RTrim(row.Cells("PRDO_COD").Value)), 0, RTrim(row.Cells("PRDO_COD").Value))
            ELPROGRAMACIONBE.linea_cod = IIf(IsDBNull(RTrim(row.Cells("LINEA_COD").Value)), "", RTrim(row.Cells("LINEA_COD").Value))
            ELPROGRAMACIONBE.tiempo_dscto = IIf(String.IsNullOrEmpty(RTrim(row.Cells("TIEMPO_DSCTO").Value)), 0, RTrim(row.Cells("TIEMPO_DSCTO").Value))
            ELPROGRAMACIONBE.dscto = IIf(String.IsNullOrEmpty(RTrim(row.Cells("DSCTO").Value)), 0, RTrim(row.Cells("DSCTO").Value))
            ELPROGRAMACIONBE.min1 = IIf(String.IsNullOrEmpty(RTrim(row.Cells("MIN1").Value)), 0, RTrim(row.Cells("MIN1").Value))
            ELPROGRAMACIONBE.min2 = IIf(String.IsNullOrEmpty(RTrim(row.Cells("MIN2").Value)), 0, RTrim(row.Cells("MIN2").Value))
            ELPROGRAMACIONBE.t_dscto1 = IIf(String.IsNullOrEmpty(RTrim(row.Cells("T_DSCTO1").Value)), 0, RTrim(row.Cells("T_DSCTO1").Value))
            ELPROGRAMACIONBE.t_dscto2 = IIf(String.IsNullOrEmpty(RTrim(row.Cells("T_DSCTO2").Value)), 0, RTrim(row.Cells("T_DSCTO2").Value))

            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELPROGRAMACIONBE.per_cod
            cmd.Parameters.Add("@d_programado", OracleDbType.Date).Value = ELPROGRAMACIONBE.d_programado
            cmd.Parameters.Add("@observacion", OracleDbType.Varchar2).Value = ELPROGRAMACIONBE.observacion
            cmd.Parameters.Add("@minutos", OracleDbType.Double).Value = ELPROGRAMACIONBE.minutos
            cmd.Parameters.Add("@prdo_cod", OracleDbType.Double).Value = ELPROGRAMACIONBE.prdo_cod
            cmd.Parameters.Add("@linea_cod", OracleDbType.Varchar2).Value = ELPROGRAMACIONBE.linea_cod
            cmd.Parameters.Add("@tiempo_dscto", OracleDbType.Double).Value = ELPROGRAMACIONBE.tiempo_dscto
            cmd.Parameters.Add("@dscto", OracleDbType.Double).Value = ELPROGRAMACIONBE.dscto
            cmd.Parameters.Add("@min1", OracleDbType.Double).Value = ELPROGRAMACIONBE.min1
            cmd.Parameters.Add("@min2", OracleDbType.Double).Value = ELPROGRAMACIONBE.min2
            cmd.Parameters.Add("@t_dscto1", OracleDbType.Double).Value = ELPROGRAMACIONBE.t_dscto1
            cmd.Parameters.Add("@t_dscto2", OracleDbType.Double).Value = ELPROGRAMACIONBE.t_dscto2
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        Next

        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBTAREOBE.id  'cod usu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registro la asistencia : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub

    Private Sub UpdateRow(ByVal ELPROGRAMACIONBE As ELPROGRAMACIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dgvdatos As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim cont As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PROGRAMACION_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELPROGRAMACIONBE.per_cod
        cmd.Parameters.Add("@d_programado", OracleDbType.Date).Value = ELPROGRAMACIONBE.d_programado
        cmd.Parameters.Add("@observacion", OracleDbType.Varchar2).Value = ELPROGRAMACIONBE.observacion
        cmd.Parameters.Add("@minutos", OracleDbType.Double).Value = ELPROGRAMACIONBE.minutos
        cmd.Parameters.Add("@prdo_cod", OracleDbType.Double).Value = ELPROGRAMACIONBE.prdo_cod
        cmd.Parameters.Add("@linea_cod", OracleDbType.Varchar2).Value = ELPROGRAMACIONBE.linea_cod
        cmd.Parameters.Add("@tiempo_dscto", OracleDbType.Double).Value = ELPROGRAMACIONBE.tiempo_dscto
        cmd.Parameters.Add("@dscto", OracleDbType.Double).Value = ELPROGRAMACIONBE.dscto
        cmd.Parameters.Add("@min1", OracleDbType.Double).Value = ELPROGRAMACIONBE.min1
        cmd.Parameters.Add("@min2", OracleDbType.Double).Value = ELPROGRAMACIONBE.min2
        cmd.Parameters.Add("@t_dscto1", OracleDbType.Double).Value = ELPROGRAMACIONBE.t_dscto1
        cmd.Parameters.Add("@t_dscto2", OracleDbType.Double).Value = ELPROGRAMACIONBE.t_dscto2
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        ''AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBTAREOBE.usuactu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el la asistencia : " + ELTBTAREOBE.cod + " de " + ELTBTAREOBE.fecha + " a " + ELTBTAREOBE.fecha_ingreso
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub

    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ELPROGRAMACIONBE As ELPROGRAMACIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TAREO_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ELTBTAREOBE.cod
        'cmd.Parameters.Add("@fecha", OracleDbType.Date).Value = ELTBTAREOBE.fecha
        'cmd.Parameters.Add("@id", OracleDbType.Varchar2).Value = ELTBTAREOBE.id
        'cmd.ExecuteNonQuery()

        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBTAREOBE.usuactu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se eliminó la asistencia : " + ELTBTAREOBE.cod + "-" + ELTBTAREOBE.fecha
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Public Function SaveRow(ByVal ELPROGRAMACIONBE As ELPROGRAMACIONBE, ByVal flagAccion As String, ByVal dgvdatos As DataGridView) As String
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
                InsertRow(ELPROGRAMACIONBE, cn, sqlTrans, dgvdatos)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELPROGRAMACIONBE, cn, sqlTrans, dgvdatos)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELPROGRAMACIONBE, cn, sqlTrans)
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
End Class
