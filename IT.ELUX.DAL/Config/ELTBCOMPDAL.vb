Imports IT.ELUX.BE
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBCOMPDAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    'Metodo para registrar un nuevo 
    Private Sub InsertRow(ByVal ELTBCOMPBE As ELTBCOMPBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                          ByVal sCodart As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBCOMP_DELETEROW1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@esp_codart", OracleDbType.Char).Value = Trim(sCodart)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBCOMP_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cont = cont + 1
            ELTBCOMPBE.cmp_codart = sCodart
            ELTBCOMPBE.cmp_codcom = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
            ELTBCOMPBE.cmp_cantidad = IIf(IsDBNull(RTrim(row.Cells(2).Value)), 0, RTrim(row.Cells(2).Value))
            ELTBCOMPBE.cmp_factor = 0.00
            ELTBCOMPBE.cmp_tipo = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            ELTBCOMPBE.chx_factor = IIf(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(3).Value))

            If ELTBCOMPBE.chx_factor = "True" Then
                ELTBCOMPBE.chx_factor = 1
            Else
                ELTBCOMPBE.chx_factor = 0
            End If

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@cmp_codart", OracleDbType.Char).Value = RTrim(ELTBCOMPBE.cmp_codart)
            cmd.Parameters.Add("@cmp_codcom", OracleDbType.Char).Value = Mid(ELTBCOMPBE.cmp_codcom, 1, 8)
            cmd.Parameters.Add("@cmp_cantidad", OracleDbType.Double).Value = ELTBCOMPBE.cmp_cantidad
            cmd.Parameters.Add("@cmp_factor", OracleDbType.Double).Value = ELTBCOMPBE.cmp_factor
            cmd.Parameters.Add("@cmp_tipo", OracleDbType.Varchar2).Value = ELTBCOMPBE.cmp_tipo
            cmd.Parameters.Add("@cmp_chk_fac", OracleDbType.Varchar2).Value = ELTBCOMPBE.chx_factor
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub

    Private Sub InsertRow1(ByVal ELTBCOMPBE As ELTBCOMPBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                          ByVal sCodart As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBCOMP_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@esp_codart", OracleDbType.Char).Value = Trim(sCodart)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBCOMP_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cont = cont + 1
            ELTBCOMPBE.cmp_codart = sCodart
            ELTBCOMPBE.cmp_codcom = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
            ELTBCOMPBE.cmp_cantidad = IIf(IsDBNull(RTrim(row.Cells(2).Value)), 0, RTrim(row.Cells(2).Value))
            ELTBCOMPBE.cmp_factor = 0.00
            ELTBCOMPBE.cmp_tipo = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            ELTBCOMPBE.chx_factor = IIf(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(3).Value))

            If ELTBCOMPBE.chx_factor = "True" Then
                ELTBCOMPBE.chx_factor = 1
            Else
                ELTBCOMPBE.chx_factor = 0
            End If

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@cmp_codart", OracleDbType.Char).Value = RTrim(ELTBCOMPBE.cmp_codart)
            cmd.Parameters.Add("@cmp_codcom", OracleDbType.Char).Value = Mid(ELTBCOMPBE.cmp_codcom, 1, 8)
            cmd.Parameters.Add("@cmp_cantidad", OracleDbType.Double).Value = ELTBCOMPBE.cmp_cantidad
            cmd.Parameters.Add("@cmp_factor", OracleDbType.Double).Value = ELTBCOMPBE.cmp_factor
            cmd.Parameters.Add("@cmp_tipo", OracleDbType.Varchar2).Value = ELTBCOMPBE.cmp_tipo
            cmd.Parameters.Add("@cmp_chk_fac", OracleDbType.Varchar2).Value = ELTBCOMPBE.chx_factor
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub

    Private Sub InsertRowCMP(ByVal ELTBCOMPBE As ELTBCOMPBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                          ByVal sCodart As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBCOMP_DELETEROW1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@esp_codart", OracleDbType.Char).Value = Trim(ELTBCOMPBE.cmp_codart)
        cmd.Parameters.Add("@cmp_codcom", OracleDbType.Char).Value = Mid(ELTBCOMPBE.cmp_codcom, 1, 8)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBCOMP_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'cont = cont + 1
        'ELTBCOMPBE.cmp_codart = IIf(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(3).Value))
        'ELTBCOMPBE.cmp_codcom = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
        'ELTBCOMPBE.cmp_cantidad = IIf(IsDBNull(RTrim(row.Cells(2).Value)), 0, RTrim(row.Cells(2).Value))
        'ELTBCOMPBE.cmp_factor = 0.00
        'ELTBCOMPBE.cmp_tipo = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
        'ELTBCOMPBE.cmp_codartraiz = IIf(IsDBNull(RTrim(row.Cells(4).Value)), "", RTrim(row.Cells(4).Value))

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@cmp_codart", OracleDbType.Char).Value = RTrim(ELTBCOMPBE.cmp_codart)
        cmd.Parameters.Add("@cmp_codcom", OracleDbType.Char).Value = Mid(ELTBCOMPBE.cmp_codcom, 1, 8)
        cmd.Parameters.Add("@cmp_cantidad", OracleDbType.Double).Value = ELTBCOMPBE.cmp_cantidad
        cmd.Parameters.Add("@cmp_factor", OracleDbType.Double).Value = ELTBCOMPBE.cmp_factor
        cmd.Parameters.Add("@cmp_tipo", OracleDbType.Varchar2).Value = ELTBCOMPBE.cmp_tipo
        cmd.Parameters.Add("@cmp_chk_fac", OracleDbType.Varchar2).Value = 0
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        'Next
    End Sub

    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ELTBCOMPBE As ELTBCOMPBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                          ByVal sCodart As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBCOMP_DELETEROW1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@CMP_CODART", OracleDbType.Char).Value = ELTBCOMPBE.cmp_codart
        cmd.Parameters.Add("@CMP_CODART", OracleDbType.Char).Value = ELTBCOMPBE.cmp_codcom
        cmd.ExecuteNonQuery()
    End Sub


    Private Sub DeleteRow1(ByVal ELTBCOMPBE As ELTBCOMPBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                          ByVal sCodart As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBCOMP1_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@CMP_CODART", OracleDbType.Char).Value = ELTBCOMPBE.cmp_codart
        cmd.Parameters.Add("@CMP_CODART", OracleDbType.Char).Value = ELTBCOMPBE.cmp_codartraiz
        cmd.ExecuteNonQuery()
    End Sub

    'Funcion Principal que hara toda la logica para grabar la data
    Public Function SaveRow(ByVal ELTBCOMPBE As ELTBCOMPBE, ByVal flagAccion As String, ByVal dg As DataGridView,
                          ByVal sCodArt As String) As String
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
                InsertRow(ELTBCOMPBE, cn, sqlTrans, dg, sCodArt)
                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                InsertRow(ELTBCOMPBE, cn, sqlTrans, dg, sCodArt)
            End If

            If flagAccion = "NS" Then
                InsertRow1(ELTBCOMPBE, cn, sqlTrans, dg, sCodArt)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELTBCOMPBE, cn, sqlTrans, dg, sCodArt)
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
    Public Function SaveRowCMP(ByVal ELTBCOMPBE As ELTBCOMPBE, ByVal flagAccion As String, ByVal dg As DataGridView,
                          ByVal sCodArt As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction

        Try
            If flagAccion = "N" Then
                InsertRowCMP(ELTBCOMPBE, cn, sqlTrans, dg, sCodArt)
            End If

            If flagAccion = "M" Then
                InsertRowCMP(ELTBCOMPBE, cn, sqlTrans, dg, sCodArt)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELTBCOMPBE, cn, sqlTrans, dg, sCodArt)
            End If



            If flagAccion = "ER" Then
                DeleteRow1(ELTBCOMPBE, cn, sqlTrans, dg, sCodArt)
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
            'If resultado = "OK" Then
            '    cn.Dispose()
            'End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    'Funcion que me va permitir capturar la lista de registros en la tabla y que me va retornar
    'un Datatable
    Public Function SelectRow(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBCOMP_SelectRow", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectAll(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBCOMP_SelectAll", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using

        Return dt

    End Function
End Class
