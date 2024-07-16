Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class COSTOS_EXPDAL

    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE

    'Metodo para registrar un nuevo 
    Private Sub InsertRow(ByVal COSTOS_EXPBE As COSTOS_EXPBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_COSTOS_EXP_INS"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        If COSTOS_EXPBE.SUB_TOTAL_EXWORKS = 0 Then
            COSTOS_EXPBE.SUB_TOTAL_EXWORKS = Nothing
        End If
        If COSTOS_EXPBE.GASTOS_AL_FCA = 0 Then
            COSTOS_EXPBE.GASTOS_AL_FCA = Nothing
        End If
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = COSTOS_EXPBE.T_DOC_REF
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = COSTOS_EXPBE.SER_DOC_REF
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = COSTOS_EXPBE.NRO_DOC_REF
        cmd.Parameters.Add("@COD", OracleDbType.Varchar2).Value = COSTOS_EXPBE.COD
        cmd.Parameters.Add("@SUB_TOTAL_EXWORKS", OracleDbType.Double).Value = COSTOS_EXPBE.SUB_TOTAL_EXWORKS
        cmd.Parameters.Add("@GASTOS_AL_FCA", OracleDbType.Double).Value = COSTOS_EXPBE.GASTOS_AL_FCA
        cmd.Parameters.Add("@SUB_TOTAL_FCA", OracleDbType.Double).Value = COSTOS_EXPBE.SUB_TOTAL_FCA
        cmd.Parameters.Add("@TOTAL_FOB_CALLAO", OracleDbType.Double).Value = COSTOS_EXPBE.TOTAL_FOB_CALLAO
        cmd.Parameters.Add("@FLETE_INTERNACIONAL", OracleDbType.Double).Value = COSTOS_EXPBE.FLETE_INTERNACIONAL
        cmd.Parameters.Add("@SEGURO", OracleDbType.Double).Value = COSTOS_EXPBE.SEGURO
        cmd.Parameters.Add("@TOTAL_CPT", OracleDbType.Double).Value = COSTOS_EXPBE.TOTAL_CPT
        cmd.Parameters.Add("@TOTAL_CFR", OracleDbType.Double).Value = COSTOS_EXPBE.TOTAL_CFR
        cmd.Parameters.Add("@TOTAL_CIF", OracleDbType.Double).Value = COSTOS_EXPBE.TOTAL_CIF
        cmd.Parameters.Add("@TOTAL_CIP", OracleDbType.Double).Value = COSTOS_EXPBE.TOTAL_CIP
        cmd.Parameters.Add("@TOTAL_FCA", OracleDbType.Double).Value = COSTOS_EXPBE.TOTAL_FCA
        cmd.Parameters.Add("@PESO_NETO", OracleDbType.Double).Value = COSTOS_EXPBE.PESO_NETO
        cmd.Parameters.Add("@PESO_TOTAL", OracleDbType.Double).Value = COSTOS_EXPBE.PESO_TOTAL
        cmd.Parameters.Add("@X_TOTAL", OracleDbType.Double).Value = COSTOS_EXPBE.X_TOTAL
        cmd.Parameters.Add("@OBSERVA", OracleDbType.Char).Value = COSTOS_EXPBE.OBSERVA
        cmd.Parameters.Add("@CONTENEDOR", OracleDbType.Char).Value = COSTOS_EXPBE.CONTENEDOR
        cmd.Parameters.Add("@PRECINTO", OracleDbType.Char).Value = COSTOS_EXPBE.PRECINTO
        cmd.Parameters.Add("@TOTAL_PAQUETES", OracleDbType.Char).Value = COSTOS_EXPBE.TOTAL_PAQUETES
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso los datos de la exportacion de: " + COSTOS_EXPBE.T_DOC_REF + "-" + COSTOS_EXPBE.SER_DOC_REF + "-" + COSTOS_EXPBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    'Metodo para Modificar 
    Private Sub UpdateRow(ByVal COSTOS_EXPBE As COSTOS_EXPBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_COSTOS_EXP_UPD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = COSTOS_EXPBE.T_DOC_REF
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = COSTOS_EXPBE.SER_DOC_REF
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = COSTOS_EXPBE.NRO_DOC_REF
        cmd.Parameters.Add("@COD", OracleDbType.Varchar2).Value = COSTOS_EXPBE.COD
        cmd.Parameters.Add("@SUB_TOTAL_EXWORKS", OracleDbType.Double).Value = COSTOS_EXPBE.SUB_TOTAL_EXWORKS
        cmd.Parameters.Add("@GASTOS_AL_FCA", OracleDbType.Double).Value = COSTOS_EXPBE.GASTOS_AL_FCA
        cmd.Parameters.Add("@SUB_TOTAL_FCA", OracleDbType.Double).Value = COSTOS_EXPBE.SUB_TOTAL_FCA
        cmd.Parameters.Add("@TOTAL_FOB_CALLAO", OracleDbType.Double).Value = COSTOS_EXPBE.TOTAL_FOB_CALLAO
        cmd.Parameters.Add("@FLETE_INTERNACIONAL", OracleDbType.Double).Value = COSTOS_EXPBE.FLETE_INTERNACIONAL
        cmd.Parameters.Add("@SEGURO", OracleDbType.Double).Value = COSTOS_EXPBE.SEGURO
        cmd.Parameters.Add("@TOTAL_CPT", OracleDbType.Double).Value = COSTOS_EXPBE.TOTAL_CPT
        cmd.Parameters.Add("@TOTAL_CFR", OracleDbType.Double).Value = COSTOS_EXPBE.TOTAL_CFR
        cmd.Parameters.Add("@TOTAL_CIF", OracleDbType.Double).Value = COSTOS_EXPBE.TOTAL_CIF
        cmd.Parameters.Add("@TOTAL_CIP", OracleDbType.Double).Value = COSTOS_EXPBE.TOTAL_CIP
        cmd.Parameters.Add("@TOTAL_FCA", OracleDbType.Double).Value = COSTOS_EXPBE.TOTAL_FCA
        cmd.Parameters.Add("@PESO_NETO", OracleDbType.Double).Value = COSTOS_EXPBE.PESO_NETO
        cmd.Parameters.Add("@PESO_TOTAL", OracleDbType.Double).Value = COSTOS_EXPBE.PESO_TOTAL
        cmd.Parameters.Add("@X_TOTAL", OracleDbType.Double).Value = COSTOS_EXPBE.X_TOTAL
        cmd.Parameters.Add("@OBSERVA", OracleDbType.Varchar2).Value = COSTOS_EXPBE.OBSERVA
        cmd.Parameters.Add("@CONTENEDOR", OracleDbType.Varchar2).Value = COSTOS_EXPBE.CONTENEDOR
        cmd.Parameters.Add("@PRECINTO", OracleDbType.Varchar2).Value = COSTOS_EXPBE.PRECINTO
        cmd.Parameters.Add("@TOTAL_PAQUETES", OracleDbType.Varchar2).Value = COSTOS_EXPBE.TOTAL_PAQUETES
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se modifico los datos de la exportacion de: " + COSTOS_EXPBE.T_DOC_REF + "-" + COSTOS_EXPBE.SER_DOC_REF + "-" + COSTOS_EXPBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub


    'Funcion Principal que hara toda la logica para grabar la data
    Public Function SaveRow(ByVal COSTOS_EXPBE As COSTOS_EXPBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String) As String
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
                InsertRow(COSTOS_EXPBE, ELMVLOGSBE, cn, sqlTrans)

                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                UpdateRow(COSTOS_EXPBE, ELMVLOGSBE, cn, sqlTrans)
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

    ''Funcion que me va permitir capturar la lista de registros en la tabla y que me va retornar un Datatable
    Public Function SelectRow(ByVal sT_DOC As String, ByVal sS_DOC As String, ByVal sN_DOC As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COSTOS_EXP_SelRow", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sT_DOC", sT_DOC),
                                                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("@sS_DOC", sS_DOC),
                                                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("@sN_DOC", sN_DOC)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    'descripcion de la carecteristica
    'Function LISTCMB() As DataTable
    '    Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
    '    Dim dt As New DataTable
    '    Using dr As OracleDataReader = Me.GetDataReader("SP_COSTO_EXP_DESCRIPCION", {})
    '        If dr.HasRows Then
    '            dt.Load(dr)
    '        End If
    '    End Using
    '    Return dt
    'End Function


End Class
