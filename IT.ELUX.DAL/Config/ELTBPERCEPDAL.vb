Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBPERCEPDAL
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sPrueba As String
    Public Function SelectAll(ByVal anho As String, ByVal smes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBPERCEP_SELALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", smes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function getTxtFc(ByVal sANHO As String, ByVal sMES As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_RPTELTBPERCEP_TXT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sANHO", Trim(sANHO)),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@sMES", Trim(sMES))})
            While dr.Read
                sPrueba = dr.GetString(0)
            End While
        End Using
        Return sPrueba
    End Function
    Public Function SelectNro(ByVal sAnho As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBPERCEP_SELNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sAnho))})
            '    While dr.Read
            '        sNumero = dr.GetInt32(0)
            '    End While
            'End Using
            'Return sNumero
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        ' If Val(dt.Rows(0).Item(0).ToString) > 0 Then
        Return dt.Rows(0).Item(0)
        'Else
        '    Return 1
        'End If
    End Function
    Public Function SelectRow(ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDETPERCEP_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sN_doc", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRow1(ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBPERCEP_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sN_doc", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SaveRow(ByVal ELTBPERCEPBE As ELTBPERCEPBE, ByVal ELTBDETPERCEPBE As ELTBDETPERCEPBE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal dg As DataGridView) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction

        Try
            'N:Nuevo   M:Modificar   E:Eliminar 

            If flagAccion = "N" Then
                InsertRow(ELTBPERCEPBE, ELTBDETPERCEPBE, cn, sqlTrans, ELMVLOGSBE, dg)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBPERCEPBE, ELTBDETPERCEPBE, cn, sqlTrans, ELMVLOGSBE, dg)
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
    Private Sub InsertRow(ByVal ELTBPERCEPBE As ELTBPERCEPBE, ByVal ELTBDETPERCEPBE As ELTBDETPERCEPBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBPERCEP_INSROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBPERCEPBE.T_DOC_REF
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBPERCEPBE.SER_DOC_REF
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBPERCEPBE.NRO_DOC_REF
        cmd.Parameters.Add("@FEC_PERC", OracleDbType.Date).Value = ELTBPERCEPBE.FEC_PERC
        cmd.Parameters.Add("@MONPERC", OracleDbType.Double).Value = ELTBPERCEPBE.MONPERC
        cmd.Parameters.Add("@CTCT_COD", OracleDbType.Varchar2).Value = ELTBPERCEPBE.CTCT_COD
        cmd.Parameters.Add("@NOMCTCT", OracleDbType.Varchar2).Value = ELTBPERCEPBE.NOMCTCT
        cmd.Parameters.Add("@NDOCU", OracleDbType.Varchar2).Value = ELTBPERCEPBE.NDOCU
        cmd.Parameters.Add("@MES", OracleDbType.Varchar2).Value = ELTBPERCEPBE.MES.PadLeft(2, "0")
        cmd.Parameters.Add("@ANHO", OracleDbType.Varchar2).Value = ELTBPERCEPBE.ANHO
        cmd.Parameters.Add("@TAZA", OracleDbType.Double).Value = ELTBPERCEPBE.TAZA
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETPERCEP_INSROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBDETPERCEPBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            ELTBDETPERCEPBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            ELTBDETPERCEPBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            ELTBDETPERCEPBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELTBDETPERCEPBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELTBDETPERCEPBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELTBDETPERCEPBE.FEC_COMP = IIf(IsDBNull(RTrim(row.Cells("FEC_COMP").Value)), "", RTrim(row.Cells("FEC_COMP").Value))
            ELTBDETPERCEPBE.MONTO = IIf(IsDBNull(RTrim(row.Cells("MONTO").Value)), "", RTrim(row.Cells("MONTO").Value))

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBDETPERCEPBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBDETPERCEPBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBDETPERCEPBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETPERCEPBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETPERCEPBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETPERCEPBE.NRO_DOC_REF1
            cmd.Parameters.Add("@FEC_COMP", OracleDbType.Date).Value = ELTBDETPERCEPBE.FEC_COMP
            cmd.Parameters.Add("@MONTO", OracleDbType.Double).Value = ELTBDETPERCEPBE.MONTO
            cmd.Parameters.Add("@NDOCU", OracleDbType.Varchar2).Value = ELTBPERCEPBE.NDOCU
            cmd.Parameters.Add("@CTCT_COD", OracleDbType.Varchar2).Value = ELTBPERCEPBE.CTCT_COD
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
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el documento de Compra: " + ELTBDETPERCEPBE.NDOCU
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub UpdateRow(ByVal ELTBPERCEPBE As ELTBPERCEPBE, ByVal ELTBDETPERCEPBE As ELTBDETPERCEPBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBPERCEP_UPDROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBPERCEPBE.T_DOC_REF
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBPERCEPBE.SER_DOC_REF
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBPERCEPBE.NRO_DOC_REF
        cmd.Parameters.Add("@FEC_PERC", OracleDbType.Date).Value = ELTBPERCEPBE.FEC_PERC
        cmd.Parameters.Add("@MONPERC", OracleDbType.Double).Value = ELTBPERCEPBE.MONPERC
        cmd.Parameters.Add("@CTCT_COD", OracleDbType.Varchar2).Value = ELTBPERCEPBE.CTCT_COD
        cmd.Parameters.Add("@NOMCTCT", OracleDbType.Varchar2).Value = ELTBPERCEPBE.NOMCTCT
        cmd.Parameters.Add("@NDOCU", OracleDbType.Varchar2).Value = ELTBPERCEPBE.NDOCU
        cmd.Parameters.Add("@MES", OracleDbType.Varchar2).Value = ELTBPERCEPBE.MES.PadLeft(2, "0")
        cmd.Parameters.Add("@ANHO", OracleDbType.Varchar2).Value = ELTBPERCEPBE.ANHO
        cmd.Parameters.Add("@TAZA", OracleDbType.Double).Value = ELTBPERCEPBE.TAZA
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBPERCEP_DEL"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@NDOCU", OracleDbType.Varchar2).Value = ELTBPERCEPBE.NDOCU
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETPERCEP_INSROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBDETPERCEPBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            ELTBDETPERCEPBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            ELTBDETPERCEPBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            ELTBDETPERCEPBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELTBDETPERCEPBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELTBDETPERCEPBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELTBDETPERCEPBE.FEC_COMP = IIf(IsDBNull(RTrim(row.Cells("FEC_COMP").Value)), "", RTrim(row.Cells("FEC_COMP").Value))
            ELTBDETPERCEPBE.MONTO = IIf(IsDBNull(RTrim(row.Cells("MONTO").Value)), "", RTrim(row.Cells("MONTO").Value))

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBDETPERCEPBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBDETPERCEPBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBDETPERCEPBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETPERCEPBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETPERCEPBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETPERCEPBE.NRO_DOC_REF1
            cmd.Parameters.Add("@FEC_COMP", OracleDbType.Date).Value = ELTBDETPERCEPBE.FEC_COMP
            cmd.Parameters.Add("@MONTO", OracleDbType.Double).Value = ELTBDETPERCEPBE.MONTO
            cmd.Parameters.Add("@NDOCU", OracleDbType.Varchar2).Value = ELTBPERCEPBE.NDOCU
            cmd.Parameters.Add("@CTCT_COD", OracleDbType.Varchar2).Value = ELTBPERCEPBE.CTCT_COD
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
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el documento de Compra: " + ELTBDETPERCEPBE.NDOCU
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
End Class
