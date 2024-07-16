Imports IT.ELUX.BE
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBESPEDAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE


    'Funcion que me ve permitir generar el codigo 
    Public Function LastCodigo(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_ELSUBLINES_LASTCODIGO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)

    End Function

    'Metodo para registrar un nuevo 
    Private Sub InsertRow(ByVal ELTBESPEBE As ELTBESPEBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                          ByVal sCodart As String, ByVal sCodCat As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBESPE_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@esp_codart", OracleDbType.Char).Value = Trim(sCodart)

        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        'For Each row As DataRow In dg.Rows
        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBESPE_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cont = cont + 1
            ELTBESPEBE.esp_codart = sCodart
            ELTBESPEBE.esp_codcat = sCodCat
            ELTBESPEBE.esp_codcar = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            ELTBESPEBE.esp_dato = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@esp_codart", OracleDbType.Char).Value = ELTBESPEBE.esp_codart
            cmd.Parameters.Add("@esp_codcar", OracleDbType.Char).Value = Mid(ELTBESPEBE.esp_codcar, 1, 4)
            cmd.Parameters.Add("@esp_codcat", OracleDbType.Char).Value = ELTBESPEBE.esp_codcat
            cmd.Parameters.Add("@esp_dato", OracleDbType.Varchar2).Value = ELTBESPEBE.esp_dato
            cmd.ExecuteNonQuery()

            cmd.Dispose()
        Next


    End Sub


    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ELTBESPEBE As ELTBESPEBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                          ByVal sCodart As String, ByVal sCodCat As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBESPE_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@ESP_CODART", OracleDbType.Char).Value = sCodart

        cmd.ExecuteNonQuery()


    End Sub

    'Funcion Principal que hara toda la logica para grabar la data
    Public Function SaveRow(ByVal ELTBESPEBE As ELTBESPEBE, ByVal flagAccion As String, ByVal dg As DataGridView,
                          ByVal sCodArt As String, ByVal sCodCat As String) As String
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
                InsertRow(ELTBESPEBE, cn, sqlTrans, dg, sCodArt, sCodCat)

                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                InsertRow(ELTBESPEBE, cn, sqlTrans, dg, sCodArt, sCodCat)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELTBESPEBE, cn, sqlTrans, dg, sCodArt, sCodCat)
            End If

            sqlTrans.Commit()
            resultado = "OK"

        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans.Rollback()
            resultado = ex.Message
        Catch ex As Exception
            If resultado = "OK" Then
                cn.Dispose()
            End If
            resultado = ex.Message
        Finally
            cn.Dispose()
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function

    'Funcion que me va permitir capturar la lista de registros en la tabla y que me va retornar
    'un Datatable
    Public Function SelectRow(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBLINES_SelectRow", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectAll(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELSUBLINES_SelectAll", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using

        Return dt

    End Function
End Class
