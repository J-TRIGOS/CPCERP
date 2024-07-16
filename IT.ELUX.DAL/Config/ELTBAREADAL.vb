Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBAREADAL

    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE

    Public sNumero As String
    'Funcion que me ve permitir generar el codigo 
    Public Function LastCodigo() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBAREA_LASTCODIGO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)

    End Function

    Public Function CodExiste(ByVal sCod As String, ByVal sCCO As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBAREA_LINCCO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCod),
                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCCO)})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero
    End Function

    Public Function SelNomLin(ByVal sCod As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBAREA_NOMLIN", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCod)})
            While dr.Read
                sNumero = dr.GetString(0)
            End While
        End Using
        Return sNumero
    End Function

    'Metodo para registrar un nuevo 
    Private Sub InsertRow(ByVal ELTBAREABE As ELTBAREABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBAREA_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBAREABE.cod
        cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = ELTBAREABE.nom
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = ELTBAREABE.cco_cod
        cmd.Parameters.Add("@situacion", OracleDbType.Char).Value = ELTBAREABE.situacion
        cmd.ExecuteNonQuery()
        cmd.Dispose()


    End Sub

    'Metodo para Modificar 
    Private Sub UpdateRow(ByVal ELTBAREABE As ELTBAREABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBAREA_DELETEROW1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBAREABE.cco_cod
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        For Each row As DataGridViewRow In dg.Rows
            If IIf(IsDBNull(RTrim(row.Cells("Est").Value)), "", RTrim(row.Cells("Est").Value)) = "Activo" Then
                ELTBAREABE.situacion = "H"
            Else
                ELTBAREABE.situacion = "A"
            End If
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBAREA_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("pcod_area", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("COD").Value)), "", RTrim(row.Cells("COD").Value))
            cmd.Parameters.Add("pnom", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NOM").Value)), "", RTrim(row.Cells("NOM").Value))
            cmd.Parameters.Add("pcco_cod", OracleDbType.Varchar2).Value = ELTBAREABE.cco_cod
            cmd.Parameters.Add("psituacion", OracleDbType.Char).Value = ELTBAREABE.situacion
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next



    End Sub
    'Funcion Principal que hara toda la logica para grabar la data
    Public Function SaveRow(ByVal ELTBAREABE As ELTBAREABE, ByVal flagAccion As String, ByVal dg As DataGridView) As String
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
                InsertRow(ELTBAREABE, cn, sqlTrans, dg)
                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBAREABE, cn, sqlTrans, dg)
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

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBAREA_SelectRow", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
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
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBAREA_DESCRIPCION", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBAREA_SelectAll", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
End Class
