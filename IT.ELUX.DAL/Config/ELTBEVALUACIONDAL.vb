Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBEVALUACIONDAL
    Inherits BaseDatosORACLE
    Public sNumero As String
    Public sNumero1 As String
    Public Function SelectNro(ByVal sCode As String, ByVal sSer As String) As Int32
        sNumero = Nothing
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBEVALUACION_SELECTNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode)),
                                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sSer))})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero
    End Function
    Public Function SelectNroDni(ByVal sCoD As String) As String
        sNumero1 = Nothing
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBEVALUACION_SELECTDNI", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD_DNI", Trim(sCoD))})
            While dr.Read
                sNumero1 = dr.GetString(0)
            End While
        End Using
        Return sNumero1
    End Function
    Function list1(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String, ByVal sProv As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBEVALUACION_SEARHDET", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@Prov", Trim(sProv))})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function getListdgv1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sCOD As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBEVALUACION_SELDET", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc),
                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@sCOD", sCOD)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SaveRow(ByVal ELTBEVALUACIONBE As ELTBEVALUACIONBE, ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try
            If flagAccion = "N" Then
                InsertRow(ELTBEVALUACIONBE, cn, sqlTrans, dg)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBEVALUACIONBE, cn, sqlTrans, dg)
            End If

            If flagAccion = "A" Then
                UpdateCapa(ELTBEVALUACIONBE, cn, sqlTrans, dg)
            End If

            'If flagAccion = "AD" Then
            '    UpdateAprob(ELTBEVALUACIONBE, cn, sqlTrans, dg)
            'End If

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
    Private Sub InsertRow(ByVal ELTBEVALUACIONBE As ELTBEVALUACIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBEVALUACION_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.T_DOC_REF '1
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.SER_DOC_REF '2
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.NRO_DOC_REF '3
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBEVALUACIONBE.FEC_GENE '4
        cmd.Parameters.Add("@est", OracleDbType.Char).Value = ELTBEVALUACIONBE.EST '5
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.EVALUADOR '6
        cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.OBSERVA '7
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = ELTBEVALUACIONBE.FECHA '8
        cmd.Parameters.Add("@t_doc", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.T_DOC_REF1 '9
        cmd.Parameters.Add("@ser_doc", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.SER_DOC_REF1 '10
        cmd.Parameters.Add("@nro_doc", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.NRO_DOC_REF1 '11

        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETEVALUACION_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBEVALUACIONBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            ELTBEVALUACIONBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            ELTBEVALUACIONBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            ELTBEVALUACIONBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELTBEVALUACIONBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELTBEVALUACIONBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELTBEVALUACIONBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells("PER_COD").Value)), "", RTrim(row.Cells("PER_COD").Value))
            ELTBEVALUACIONBE.RPTA1 = IIf(IsDBNull(RTrim(row.Cells("RPTA1").Value)), "", RTrim(row.Cells("RPTA1").Value))
            ELTBEVALUACIONBE.RPTA2 = IIf(IsDBNull(RTrim(row.Cells("RPTA2").Value)), "", RTrim(row.Cells("RPTA2").Value))
            ELTBEVALUACIONBE.RPTA3 = IIf(IsDBNull(RTrim(row.Cells("RPTA3").Value)), "", RTrim(row.Cells("RPTA3").Value))
            ELTBEVALUACIONBE.EVA_CAPA = IIf(IsDBNull(RTrim(row.Cells("EVA_CAPA").Value)), "", RTrim(row.Cells("EVA_CAPA").Value))
            ELTBEVALUACIONBE.ENT_CAPA = IIf(IsDBNull(RTrim(row.Cells("ENT_CAPA").Value)), "", RTrim(row.Cells("ENT_CAPA").Value))
            ELTBEVALUACIONBE.CAPA_NUE = IIf(IsDBNull(RTrim(row.Cells("CAPA_NUE").Value)), "", RTrim(row.Cells("CAPA_NUE").Value))
            ELTBEVALUACIONBE.SURGERENCIA = IIf(IsDBNull(RTrim(row.Cells("SURGERENCIA").Value)), "", RTrim(row.Cells("SURGERENCIA").Value))
            ELTBEVALUACIONBE.COMENTARIOS = IIf(IsDBNull(RTrim(row.Cells("COMENTARIOS").Value)), "", RTrim(row.Cells("COMENTARIOS").Value))
            ELTBEVALUACIONBE.NOT_CAPA = IIf(IsDBNull(RTrim(row.Cells("NOT_CAPA").Value)), "", RTrim(row.Cells("NOT_CAPA").Value))
            ELTBEVALUACIONBE.NOT_EVA = IIf(IsDBNull(RTrim(row.Cells("NOT_EVA").Value)), "", RTrim(row.Cells("NOT_EVA").Value))
            'ELTBEVALUACIONBE.EST = IIf(IsDBNull(RTrim(row.Cells("LINEA_COD").Value)), "", RTrim(row.Cells("LINEA_COD").Value))

            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.T_DOC_REF '1
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.SER_DOC_REF '2
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.NRO_DOC_REF '3
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.T_DOC_REF '4
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.SER_DOC_REF '5
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.NRO_DOC_REF '6
            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.PER_COD '7
            cmd.Parameters.Add("@RPTA1", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.RPTA1  '8
            cmd.Parameters.Add("@RPTA2", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.RPTA2 '9
            cmd.Parameters.Add("@RPTA3", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.RPTA3 '10
            cmd.Parameters.Add("@EVA_CAPA", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.EVA_CAPA '11
            cmd.Parameters.Add("@ENT_CAPA", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.ENT_CAPA '12
            cmd.Parameters.Add("@CAPA_NUE", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.CAPA_NUE '13
            cmd.Parameters.Add("@SURGERENCIA", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.SURGERENCIA '14
            cmd.Parameters.Add("@COMENTARIOS", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.COMENTARIOS '15
            cmd.Parameters.Add("@NOT_CAPA", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.NOT_CAPA '16
            cmd.Parameters.Add("@NOT_EVA", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.NOT_EVA '17
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

    End Sub
    Public Function SelectAll(ByVal Anho As String, ByVal Mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBEVALUACION_SELALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", Anho),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", Mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBEVALUACION_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBDETEVALUACION_SEL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Private Sub UpdateRow(ByVal ELTBEVALUACIONBE As ELTBEVALUACIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBEVALUACION_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.SER_DOC_REF '2
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.NRO_DOC_REF '3
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBEVALUACIONBE.FEC_GENE '4
        cmd.Parameters.Add("@est", OracleDbType.Char).Value = ELTBEVALUACIONBE.EST '5
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.EVALUADOR '6
        cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.OBSERVA '7
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = ELTBEVALUACIONBE.FECHA '8
        cmd.Parameters.Add("@t_doc", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.T_DOC_REF1 '9
        cmd.Parameters.Add("@ser_doc", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.SER_DOC_REF1 '10
        cmd.Parameters.Add("@nro_doc", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.NRO_DOC_REF1 '11
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETEVALUACION_DEL"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.T_DOC_REF '1
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.SER_DOC_REF '2
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.NRO_DOC_REF '3
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETEVALUACION_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBEVALUACIONBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            ELTBEVALUACIONBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            ELTBEVALUACIONBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            ELTBEVALUACIONBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELTBEVALUACIONBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELTBEVALUACIONBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELTBEVALUACIONBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells("PER_COD").Value)), "", RTrim(row.Cells("PER_COD").Value))
            ELTBEVALUACIONBE.RPTA1 = IIf(IsDBNull(RTrim(row.Cells("RPTA1").Value)), "", RTrim(row.Cells("RPTA1").Value))
            ELTBEVALUACIONBE.RPTA2 = IIf(IsDBNull(RTrim(row.Cells("RPTA2").Value)), "", RTrim(row.Cells("RPTA2").Value))
            ELTBEVALUACIONBE.RPTA3 = IIf(IsDBNull(RTrim(row.Cells("RPTA3").Value)), "", RTrim(row.Cells("RPTA3").Value))
            ELTBEVALUACIONBE.EVA_CAPA = IIf(IsDBNull(RTrim(row.Cells("EVA_CAPA").Value)), "", RTrim(row.Cells("EVA_CAPA").Value))
            ELTBEVALUACIONBE.ENT_CAPA = IIf(IsDBNull(RTrim(row.Cells("ENT_CAPA").Value)), "", RTrim(row.Cells("ENT_CAPA").Value))
            ELTBEVALUACIONBE.CAPA_NUE = IIf(IsDBNull(RTrim(row.Cells("CAPA_NUE").Value)), "", RTrim(row.Cells("CAPA_NUE").Value))
            ELTBEVALUACIONBE.SURGERENCIA = IIf(IsDBNull(RTrim(row.Cells("SURGERENCIA").Value)), "", RTrim(row.Cells("SURGERENCIA").Value))
            ELTBEVALUACIONBE.COMENTARIOS = IIf(IsDBNull(RTrim(row.Cells("COMENTARIOS").Value)), "", RTrim(row.Cells("COMENTARIOS").Value))
            ELTBEVALUACIONBE.NOT_CAPA = IIf(IsDBNull(RTrim(row.Cells("NOT_CAPA").Value)), "", RTrim(row.Cells("NOT_CAPA").Value))
            ELTBEVALUACIONBE.NOT_EVA = IIf(IsDBNull(RTrim(row.Cells("NOT_EVA").Value)), "", RTrim(row.Cells("NOT_EVA").Value))
            'ELTBEVALUACIONBE.EST = IIf(IsDBNull(RTrim(row.Cells("LINEA_COD").Value)), "", RTrim(row.Cells("LINEA_COD").Value))

            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.T_DOC_REF '1
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.SER_DOC_REF '2
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.NRO_DOC_REF '3
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.T_DOC_REF '4
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.SER_DOC_REF '5
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.NRO_DOC_REF '6
            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.PER_COD '7
            cmd.Parameters.Add("@RPTA1", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.RPTA1  '8
            cmd.Parameters.Add("@RPTA2", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.RPTA2 '9
            cmd.Parameters.Add("@RPTA3", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.RPTA3 '10
            cmd.Parameters.Add("@EVA_CAPA", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.EVA_CAPA '11
            cmd.Parameters.Add("@ENT_CAPA", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.ENT_CAPA '12
            cmd.Parameters.Add("@CAPA_NUE", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.CAPA_NUE '13
            cmd.Parameters.Add("@SURGERENCIA", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.SURGERENCIA '14
            cmd.Parameters.Add("@COMENTARIOS", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.COMENTARIOS '15
            cmd.Parameters.Add("@NOT_CAPA", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.NOT_CAPA '16
            cmd.Parameters.Add("@NOT_EVA", OracleDbType.Varchar2).Value = ELTBEVALUACIONBE.NOT_EVA '17
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub
    Private Sub UpdateCapa(ByVal ELTBEVALUACIONBE As ELTBEVALUACIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBEVALUACION_ANUDOCU"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBEVALUACIONBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBEVALUACIONBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBEVALUACIONBE.NRO_DOC_REF)
        cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = "1"
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
End Class
