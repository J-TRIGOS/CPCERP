Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBSISTINTCALIDADDAL
    Inherits BaseDatosORACLE
    Public sNumero As String = ""
    Public Function SelectCodif() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBCODIFICACIONDOCU_SEL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SISTINTCALIDAD_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelectNro(ByVal sCode As String, ByVal sSer As String) As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SISTINTCALIDAD_SELECTNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode)),
                                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sSer))})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero

    End Function
    Public Function SelectAll(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SISTINTCALIDAD_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SaveRow(ByVal ELTBSISTINTCALIDADBE As ELTBSISTINTCALIDADBE, ByVal flagAccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try
            If flagAccion = "N" Then
                InsertRow(ELTBSISTINTCALIDADBE, cn, sqlTrans)
            End If

            ' If flagAccion = "M" Then
            '     UpdateRow(ELTBCAPACITACIONBE, cn, sqlTrans, dg)
            ' End If
            '
            'If flagAccion = "A" Then
            '    UpdateCapa(ELTBCAPACITACIONBE, cn, sqlTrans, dg)
            'End If
            '
            'If flagAccion = "AD" Then
            '    UpdateAprob(ELTBCAPACITACIONBE, cn, sqlTrans, dg)
            'End If
            '
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
            '    If flagAccion <> "DS" And flagAccion <> "AS" And flagAccion <> "CSM" And flagAccion <> "N" Then
            '        cn.Dispose()
            '    End If
            '
            'End If
            'sqlTrans = Nothing
        End Try

        Return resultado

    End Function

    Private Sub InsertRow(ByVal ELTBSISTINTCALIDADBE As ELTBSISTINTCALIDADBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBSISTINCALIDAD_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBSISTINTCALIDADBE.T_DOC_REF '1
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBSISTINTCALIDADBE.SER_DOC_REF '2
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBSISTINTCALIDADBE.NRO_DOC_REF '3
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBSISTINTCALIDADBE.FEC_GENE '4
        cmd.Parameters.Add("@est", OracleDbType.Char).Value = ELTBSISTINTCALIDADBE.ESTADO '5
        cmd.Parameters.Add("@codificacion", OracleDbType.Varchar2).Value = ELTBSISTINTCALIDADBE.CODIFICACION '6
        cmd.Parameters.Add("@tema", OracleDbType.Varchar2).Value = ELTBSISTINTCALIDADBE.TEMA '7
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = ELTBSISTINTCALIDADBE.CCO '8
        cmd.Parameters.Add("@nompdf", OracleDbType.Varchar2).Value = ELTBSISTINTCALIDADBE.NOMPDF '9
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        '  Dim cont As Integer = 0
        '  For Each row As DataGridViewRow In dg.Rows
        '      cont = cont + 1
        '      cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        '      cmd.CommandText = "SP_ELTBDETCONTSEG_INSERTROW"
        '      cmd.Connection = sqlCon
        '      cmd.Transaction = sqlTrans
        '      cmd.CommandType = CommandType.StoredProcedure
        '      ELTBCAPACITACIONBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
        '      ELTBCAPACITACIONBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
        '      ELTBCAPACITACIONBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
        '      ELTBCAPACITACIONBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
        '      ELTBCAPACITACIONBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
        '      ELTBCAPACITACIONBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
        '      ELTBCAPACITACIONBE.PER_COD1 = IIf(IsDBNull(RTrim(row.Cells("PER_COD").Value)), "", RTrim(row.Cells("PER_COD").Value))
        '      ELTBCAPACITACIONBE.LINEA_COD = IIf(IsDBNull(RTrim(row.Cells("LINEA_COD").Value)), "", RTrim(row.Cells("LINEA_COD").Value))
        '
        '      cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.T_DOC_REF '1
        '      cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.SER_DOC_REF '2
        '      cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.NRO_DOC_REF '3
        '      cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.T_DOC_REF1 '4
        '      cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.SER_DOC_REF1 '5
        '      cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.NRO_DOC_REF1 '6
        '      cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.PER_COD1 '7
        '      cmd.Parameters.Add("@linea_cod", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.LINEA_COD '8
        '
        '      cmd.ExecuteNonQuery()
        '      cmd.Dispose()
        '  Next

    End Sub
End Class
