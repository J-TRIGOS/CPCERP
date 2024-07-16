Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELVACACIONESDAL

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

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_VACACIONES_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", Anho),
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

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_VACACIONES_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@per_cod", sCode), New Oracle.ManagedDataAccess.Client.OracleParameter("@prdo_cod", sCode2)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectVacaciones(ByVal sPer As String, ByVal sfec1 As String, ByVal sFec2 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_VACACIONES_SELECTVACA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@per_cod", sPer),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_ini", sfec1),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_fin", sFec2)})
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
    Public Function SelectPeriodo2(ByVal anho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PERIODO_BUSQUEDA2", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho)})
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

    Private Sub InsertRow(ByVal ELVACACIONESBE As ELVACACIONESBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_VACACIONES_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELVACACIONESBE.per_cod
        cmd.Parameters.Add("@dias", OracleDbType.Double).Value = ELVACACIONESBE.dias
        If ELVACACIONESBE.fec_ini_vac = Nothing Then
            cmd.Parameters.Add("@fec_ini_vac", OracleDbType.Date).Value = DBNull.Value
        Else
            cmd.Parameters.Add("@fec_ini_vac", OracleDbType.Date).Value = ELVACACIONESBE.fec_ini_vac
        End If
        If ELVACACIONESBE.fec_fin_vac = Nothing Then
            cmd.Parameters.Add("@fec_fin_vac", OracleDbType.Date).Value = DBNull.Value
        Else
            cmd.Parameters.Add("@fec_fin_vac", OracleDbType.Date).Value = ELVACACIONESBE.fec_fin_vac
        End If
        cmd.Parameters.Add("@observacion", OracleDbType.Varchar2).Value = ELVACACIONESBE.observacion
        cmd.Parameters.Add("@prdo_cod", OracleDbType.Double).Value = ELVACACIONESBE.prdo_cod
        cmd.Parameters.Add("@susp_cod", OracleDbType.Varchar2).Value = ELVACACIONESBE.susp_cod
        cmd.Parameters.Add("@fec_ini", OracleDbType.Date).Value = ELVACACIONESBE.fec_ini
        cmd.Parameters.Add("@fec_fin", OracleDbType.Date).Value = ELVACACIONESBE.fec_fin
        cmd.ExecuteNonQuery()
        cmd.Dispose()

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

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBVACACIONGOZE_INSERT"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELVACACIONESBE.per_cod = IIf(IsDBNull(RTrim(row.Cells("per_cod").Value)), "", RTrim(row.Cells("per_cod").Value))
            ELVACACIONESBE.fec_ini = IIf(IsDBNull(RTrim(row.Cells("gose_ini").Value)), "", RTrim(row.Cells("gose_ini").Value))
            ELVACACIONESBE.fec_fin = IIf(IsDBNull(RTrim(row.Cells("gose_fin").Value)), "", RTrim(row.Cells("gose_fin").Value))
            ELVACACIONESBE.fec_ini_vac = IIf(IsDBNull(RTrim(row.Cells("vacaciones_ini").Value)), "", RTrim(row.Cells("vacaciones_ini").Value))
            ELVACACIONESBE.fec_fin_vac = IIf(IsDBNull(RTrim(row.Cells("vacaciones_fin").Value)), "", RTrim(row.Cells("vacaciones_fin").Value))
            ELVACACIONESBE.dias = IIf(IsDBNull(RTrim(row.Cells("dias").Value)), "", RTrim(row.Cells("dias").Value))
            ELVACACIONESBE.prdo_cod = IIf(IsDBNull(RTrim(row.Cells("prdo_cod").Value)), "", RTrim(row.Cells("prdo_cod").Value))
            ELVACACIONESBE.susp_cod = IIf(IsDBNull(RTrim(row.Cells("susp_cod").Value)), "", RTrim(row.Cells("susp_cod").Value))
            ELVACACIONESBE.indice = IIf(IsDBNull(RTrim(row.Cells("indice").Value)), "", RTrim(row.Cells("indice").Value))

            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELVACACIONESBE.per_cod '1
            cmd.Parameters.Add("@fec_ini", OracleDbType.Date).Value = ELVACACIONESBE.fec_ini '2
            cmd.Parameters.Add("@fec_fin", OracleDbType.Date).Value = ELVACACIONESBE.fec_fin '3
            cmd.Parameters.Add("@fec_ini_vac", OracleDbType.Date).Value = ELVACACIONESBE.fec_ini_vac '4
            cmd.Parameters.Add("@fec_fin_vac", OracleDbType.Date).Value = ELVACACIONESBE.fec_fin_vac '5
            cmd.Parameters.Add("@dias", OracleDbType.Double).Value = ELVACACIONESBE.dias '6
            cmd.Parameters.Add("@prdo_cod", OracleDbType.Varchar2).Value = ELVACACIONESBE.prdo_cod '7
            cmd.Parameters.Add("@susp_cod", OracleDbType.Varchar2).Value = ELVACACIONESBE.susp_cod '8
            cmd.Parameters.Add("@indice", OracleDbType.Double).Value = ELVACACIONESBE.indice '9

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

    End Sub

    Private Sub UpdateRow(ByVal ELVACACIONESBE As ELVACACIONESBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_VACACIONES_UPDROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELVACACIONESBE.per_cod
        cmd.Parameters.Add("@dias", OracleDbType.Double).Value = ELVACACIONESBE.dias
        cmd.Parameters.Add("@fec_ini_vac", OracleDbType.Date).Value = ELVACACIONESBE.fec_ini_vac
        cmd.Parameters.Add("@fec_fin_vac", OracleDbType.Date).Value = ELVACACIONESBE.fec_fin_vac
        cmd.Parameters.Add("@observacion", OracleDbType.Varchar2).Value = ELVACACIONESBE.observacion
        cmd.Parameters.Add("@prdo_cod", OracleDbType.Double).Value = ELVACACIONESBE.prdo_cod
        cmd.Parameters.Add("@susp_cod", OracleDbType.Varchar2).Value = ELVACACIONESBE.susp_cod
        cmd.Parameters.Add("@fec_ini", OracleDbType.Date).Value = ELVACACIONESBE.fec_ini
        cmd.Parameters.Add("@fec_fin", OracleDbType.Date).Value = ELVACACIONESBE.fec_fin
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




        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBVACACIONESGOZE_DEL"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELVACACIONESBE.per_cod
        cmd.Parameters.Add("@fec_ini", OracleDbType.Date).Value = ELVACACIONESBE.fec_ini_vac
        cmd.Parameters.Add("@fec_fin", OracleDbType.Date).Value = ELVACACIONESBE.fec_fin_vac

        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBVACACIONGOZE_INSERT"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELVACACIONESBE.per_cod = IIf(IsDBNull(RTrim(row.Cells("per_cod").Value)), "", RTrim(row.Cells("per_cod").Value))
            ELVACACIONESBE.fec_ini = IIf(IsDBNull(RTrim(row.Cells("gose_ini").Value)), "", RTrim(row.Cells("gose_ini").Value))
            ELVACACIONESBE.fec_fin = IIf(IsDBNull(RTrim(row.Cells("gose_fin").Value)), "", RTrim(row.Cells("gose_fin").Value))
            ELVACACIONESBE.fec_ini_vac = IIf(IsDBNull(RTrim(row.Cells("vacaciones_ini").Value)), "", RTrim(row.Cells("vacaciones_ini").Value))
            ELVACACIONESBE.fec_fin_vac = IIf(IsDBNull(RTrim(row.Cells("vacaciones_fin").Value)), "", RTrim(row.Cells("vacaciones_fin").Value))
            ELVACACIONESBE.dias = IIf(IsDBNull(RTrim(row.Cells("dias").Value)), "", RTrim(row.Cells("dias").Value))
            ELVACACIONESBE.prdo_cod = IIf(IsDBNull(RTrim(row.Cells("prdo_cod").Value)), "", RTrim(row.Cells("prdo_cod").Value))
            ELVACACIONESBE.susp_cod = IIf(IsDBNull(RTrim(row.Cells("susp_cod").Value)), "", RTrim(row.Cells("susp_cod").Value))
            ELVACACIONESBE.indice = IIf(IsDBNull(RTrim(row.Cells("indice").Value)), "", RTrim(row.Cells("indice").Value))

            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELVACACIONESBE.per_cod '1
            cmd.Parameters.Add("@fec_ini", OracleDbType.Date).Value = ELVACACIONESBE.fec_ini '2
            cmd.Parameters.Add("@fec_fin", OracleDbType.Date).Value = ELVACACIONESBE.fec_fin '3
            cmd.Parameters.Add("@fec_ini_vac", OracleDbType.Date).Value = ELVACACIONESBE.fec_ini_vac '4
            cmd.Parameters.Add("@fec_fin_vac", OracleDbType.Date).Value = ELVACACIONESBE.fec_fin_vac '5
            cmd.Parameters.Add("@dias", OracleDbType.Double).Value = ELVACACIONESBE.dias '6
            cmd.Parameters.Add("@prdo_cod", OracleDbType.Double).Value = ELVACACIONESBE.prdo_cod '7
            cmd.Parameters.Add("@susp_cod", OracleDbType.Varchar2).Value = ELVACACIONESBE.susp_cod '8
            cmd.Parameters.Add("@indice", OracleDbType.Double).Value = ELVACACIONESBE.indice '9

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub

    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ELVACACIONESBE As ELVACACIONESBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_VACACIONES_DELROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELVACACIONESBE.per_cod
        cmd.Parameters.Add("@prdo_cod", OracleDbType.Varchar2).Value = ELVACACIONESBE.prdo_cod
        cmd.Parameters.Add("@susp_cod", OracleDbType.Varchar2).Value = ELVACACIONESBE.susp_cod
        cmd.ExecuteNonQuery()

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

    Public Function SaveRow(ByVal ELVACACIONESBE As ELVACACIONESBE, ByVal flagAccion As String, ByVal dg As DataGridView) As String
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
                InsertRow(ELVACACIONESBE, cn, sqlTrans, dg)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELVACACIONESBE, cn, sqlTrans, dg)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELVACACIONESBE, cn, sqlTrans)
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
