Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBTAREODAL

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

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TAREO_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", Anho),
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

    Public Function SelectCondiPago() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CLIENTE_FPAGO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectPais() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_PAIS", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectPaisCod(ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_PAIS_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectActi_Serv() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CLIENTE_COMBO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRow(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CLIENTE_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
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
    Public Function VerificarRepetido(ByVal Code As String) As Boolean
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CLIENTE_VERIFICAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode", Code)})
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        End Using
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

    Private Sub InsertRow(ByVal ELTBTAREOBE As ELTBTAREOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dgtareo As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'AGREGAR DIRECCIONES
        Dim i As Integer = 0
        Dim fecha, fecha_ing As Date
        'Dim cont As Integer = ELTBTAREOBE.id

        fecha_ing = DateTime.Now.ToString("yyyy/MM/dd")

        For Each row As DataGridViewRow In dgtareo.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_TAREO_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBTAREOBE.cod = IIf(IsDBNull(RTrim(row.Cells("COD").Value)), "", RTrim(row.Cells("COD").Value))
            fecha = IIf(IsDBNull(RTrim(row.Cells("FECHA").Value)), "", RTrim(row.Cells("FECHA").Value))
            'If fecha.ToString("dd'/'MM'/'yyyy") = DateTime.Now.ToString("dd'/'MM'/'yyyy") And ELTBTAREOBE.cod = "45871325" Then fecha = fecha.AddMinutes(-7)
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBTAREOBE.cod
            cmd.Parameters.Add("@fecha", OracleDbType.Date).Value = fecha
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = ELTBTAREOBE.usuario
            cmd.Parameters.Add("@fecha_ing", OracleDbType.Date).Value = fecha_ing
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        'AUDITORIA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBTAREOBE.id  'cod usu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registro la asistencia : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub UpdateRow(ByVal ELTBTAREOBE As ELTBTAREOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dgtareo As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim cont As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TAREO_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBTAREOBE.cod
        cmd.Parameters.Add("@fecha", OracleDbType.Date).Value = ELTBTAREOBE.fecha
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = ELTBTAREOBE.usuario
        cmd.Parameters.Add("@id", OracleDbType.Varchar2).Value = ELTBTAREOBE.id
        cmd.Parameters.Add("@fecha_ing", OracleDbType.Date).Value = ELTBTAREOBE.fecha_ingreso
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AUDITORIA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBTAREOBE.usuactu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el la asistencia : " + ELTBTAREOBE.cod + " de " + ELTBTAREOBE.fecha + " a " + ELTBTAREOBE.fecha_ingreso
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ELTBTAREOBE As ELTBTAREOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TAREO_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ELTBTAREOBE.cod
        cmd.Parameters.Add("@fecha", OracleDbType.Date).Value = ELTBTAREOBE.fecha
        cmd.Parameters.Add("@id", OracleDbType.Varchar2).Value = ELTBTAREOBE.id
        cmd.ExecuteNonQuery()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBTAREOBE.usuactu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se eliminó la asistencia : " + ELTBTAREOBE.cod + "-" + ELTBTAREOBE.fecha
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Public Function SaveRow(ByVal ELTBTAREOBE As ELTBTAREOBE, ByVal flagAccion As String, ByVal dgtareo As DataGridView) As String
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

                InsertRow(ELTBTAREOBE, cn, sqlTrans, dgtareo)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBTAREOBE, cn, sqlTrans, dgtareo)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELTBTAREOBE, cn, sqlTrans)
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
