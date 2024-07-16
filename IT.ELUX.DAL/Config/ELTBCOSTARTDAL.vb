Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBCOSTARTDAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    Inherits BaseDatosORACLE
    Public sNumero As String
    Public sPrueba As String
    Public sNumero1 As Double
    Public Function SelectMPSP(ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_RPT_ELTBARTCOST_ARTMP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectCorte(ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_RPT_ELTBARTCOST_ARTMP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectCMP(ByVal sAño As String, ByVal sMes As String, ByVal sTip As String) As Double
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBCOSTART_CONT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sMes", sMes),
                                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@sAño", sAño),
                                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@sTip", sTip)})
            While dr.Read
                sNumero1 = dr.GetDouble(0)
            End While
        End Using
        Return sNumero1
    End Function
    Public Function SelectMPCP(ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBARTCOST_SELMPCP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Private Sub InsertRow(ByVal ELTBCOSTARTBE As ELTBCOSTARTBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        'Dim contenedor As String
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        For Each row As DataGridViewRow In dg.Rows
            Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBCOSTART_INS"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            cmd.Parameters.Add("@PRECIO", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("PRECIO").Value)), 0, RTrim(row.Cells("PRECIO").Value))
            cmd.Parameters.Add("@MES", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("MES").Value)), "", RTrim(row.Cells("MES").Value))
            cmd.Parameters.Add("@ANHO", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("ANHO").Value)), "", RTrim(row.Cells("ANHO").Value))
            cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("TIPO").Value)), "", RTrim(row.Cells("TIPO").Value))
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        Next



        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + FACTURACIONBE.T_DOC_REF + "-" + FACTURACIONBE.SER_DOC_REF + "-" + FACTURACIONBE.NRO_DOC_REF
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub

    Public Sub LimpiarCos(ByVal ELTBCOSTARTBE As ELTBCOSTARTBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBCOSTART_DEL"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@MES", OracleDbType.Varchar2).Value = ELTBCOSTARTBE.MES
        cmd.Parameters.Add("@ANHO", OracleDbType.Varchar2).Value = ELTBCOSTARTBE.ANHO
        cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = ELTBCOSTARTBE.TIPO
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Function SaveRow(ByVal ELTBCOSTARTBE As ELTBCOSTARTBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                           ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction
        Try
            'N:Nuevo   M:Modificar   E:Eliminar 

            If flagAccion = "N" Then
                InsertRow(ELTBCOSTARTBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "ECOS" Then
                LimpiarCos(ELTBCOSTARTBE, cn, sqlTrans)
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
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
End Class
