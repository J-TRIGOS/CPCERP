Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class PARCIALDAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String
    Private Sub InsertRow(ByVal PARCIALBE As PARCIALBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        For Each row As DataGridViewRow In dg.Rows
            PARCIALBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            PARCIALBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
            PARCIALBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))
            PARCIALBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(3).Value))
            PARCIALBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells(4).Value)), "", RTrim(row.Cells(4).Value))
            PARCIALBE.FEC_ENT = IIf(IsDBNull(RTrim(row.Cells(5).Value)), "", RTrim(row.Cells(5).Value))
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PARCIAL_DEL"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(PARCIALBE.T_DOC_REF)
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(PARCIALBE.SER_DOC_REF)
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(PARCIALBE.NRO_DOC_REF)
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = Trim(PARCIALBE.ART_COD)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
        For Each row As DataGridViewRow In dg.Rows
            PARCIALBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            PARCIALBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
            PARCIALBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))
            PARCIALBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(3).Value))
            PARCIALBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells(4).Value)), "", RTrim(row.Cells(4).Value))
            PARCIALBE.FEC_ENT = IIf(IsDBNull(RTrim(row.Cells(5).Value)), "", RTrim(row.Cells(5).Value))
            If IIf(IsDBNull(RTrim(row.Cells(6).Value)), "", RTrim(row.Cells(6).Value)) = "Activo" Or IIf(IsDBNull(RTrim(row.Cells(6).Value)), "", RTrim(row.Cells(6).Value)) = "ACTIVO" Then
                PARCIALBE.EST = "H"
            Else
                PARCIALBE.EST = "A"
            End If
            'PARCIALBE.EST = IIf(IsDBNull(RTrim(row.Cells(6).Value)), "", RTrim(row.Cells(6).Value))
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PARCIAL_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(PARCIALBE.T_DOC_REF)
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(PARCIALBE.SER_DOC_REF)
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(PARCIALBE.NRO_DOC_REF)
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = Trim(PARCIALBE.ART_COD)
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = Trim(PARCIALBE.CANTIDAD)
            cmd.Parameters.Add("@fec_ent", OracleDbType.Varchar2).Value = Trim(PARCIALBE.FEC_ENT)
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = Trim(PARCIALBE.EST)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
            cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
            cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el parcial: " + PARCIALBE.ART_COD
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        Next

    End Sub
    'Funcion Principal que hara toda la logica para grabar la data
    Public Function SaveRow(ByVal PARCIALBE As PARCIALBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String,
                            ByVal dgv As DataGridView) As String
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

            If flagAccion = "M" Then
                ''correlativo = LastCodigo()
                ''MonedaBE.mon_codigo = MonedaBE.mon_codigo
                InsertRow(PARCIALBE, ELMVLOGSBE, cn, sqlTrans, dgv)

                'grabar acceso a los menues
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
    Public Function getListdgv(ByVal sTip As String, ByVal sSer As String, ByVal sNro As String, ByVal sArt As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PARCIAL_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sTip", sTip),
                                                                              New Oracle.ManagedDataAccess.Client.OracleParameter("@sSer", sSer),
                                                                              New Oracle.ManagedDataAccess.Client.OracleParameter("@sNro", sNro),
                                                                              New Oracle.ManagedDataAccess.Client.OracleParameter("@sArt", sArt)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
