Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBDETGUIADAL
    Inherits BaseDatosORACLE
    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sART As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDETGUIA_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@sART", sART)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectDataFARDO(ByVal TDOC As String, ByVal SDOC As String, ByVal NDOC As String, ByVal ARTICULO As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBDETGUIA_SELECTFD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC", TDOC),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@S_DOC", SDOC),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@N_DOC", NDOC),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@ARTICULO", ARTICULO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using

        Return dt.Rows(0).Item(0)
    End Function
    Public Function SaveRow(ByVal ELTBDETGUIABE As ELTBDETGUIABE, ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction
        Try
            'N:Nuevo   M:Modificar   E:Eliminar 
            If flagAccion = "N" Then
                InsertRow(ELTBDETGUIABE, cn, sqlTrans, dg)
            End If
            If flagAccion = "M" Then
                UpdateRow(ELTBDETGUIABE, cn, sqlTrans, dg)
            End If
            ''If flagAccion = "A" Then
            ''    DeleteUpdateRow(ELTBDETDOCOPBE, cn, sqlTrans, dg)
            ''End If
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
    Private Sub InsertRow(ByVal ELTBDETGUIABE As ELTBDETGUIABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        ' cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        ' cmd.CommandText = "SP_ELTBDETGUIA_DEL"
        ' cmd.Connection = sqlCon
        ' cmd.Transaction = sqlTrans
        ' cmd.CommandType = CommandType.StoredProcedure
        ' cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETGUIABE.T_DOC_REF
        ' cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETGUIABE.SER_DOC_REF
        ' cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETGUIABE.NRO_DOC_REF
        ' cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBDETGUIABE.ART_COD
        ' cmd.ExecuteNonQuery()
        ' cmd.Dispose()
        Dim NroCodFardo As String
        NroCodFardo = ELTBDETGUIABE.CFardo
        NroCodFardo = Mid(NroCodFardo, 2, 5)



        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETGUIA_INSROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            Dim NroFardo As String = ""
            Dim NroCodFardoN As String = ""
            Dim CodF As String = ""
            Dim CodN As String = ""

            ELTBDETGUIABE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("t_doc_ref").Value)), "", RTrim(row.Cells("t_doc_ref").Value))            '0
            ELTBDETGUIABE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))      '1
            ELTBDETGUIABE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))      '2
            ELTBDETGUIABE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))         '3
            ELTBDETGUIABE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))   '4

            If (cont).ToString.Length = 1 Then
                NroFardo = "0000000" & (cont).ToString
            ElseIf (cont).ToString.Length = 2 Then
                NroFardo = "000000" & (cont).ToString
            ElseIf (cont).ToString.Length = 3 Then
                NroFardo = "00000" & (cont).ToString
            ElseIf (cont).ToString.Length = 4 Then
                NroFardo = "0000" & (cont).ToString
            ElseIf (cont).ToString.Length = 5 Then
                NroFardo = "000" & (cont).ToString
            ElseIf (cont).ToString.Length = 6 Then
                NroFardo = "00" & (cont).ToString
            ElseIf (cont).ToString.Length = 7 Then
                NroFardo = "0" & (cont).ToString
            ElseIf (cont).ToString.Length = 6 Then
                NroFardo = (cont).ToString
            End If
            ELTBDETGUIABE.NRO_DOC_REF1 = NroFardo                                                                                          '5
            ELTBDETGUIABE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))                '6

            NroCodFardoN = IIf(IsDBNull(RTrim(row.Cells("COD_FAR").Value)), "", RTrim(row.Cells("COD_FAR").Value))
            CodN = Mid(NroCodFardoN, 7, 5)
            ELTBDETGUIABE.COD_FAR = "F" & NroCodFardo & CodN                                                                               '7

            ELTBDETGUIABE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells("FEC_GENE").Value)), "", RTrim(row.Cells("FEC_GENE").Value))             '9
            ELTBDETGUIABE.ESTADO = IIf(IsDBNull(RTrim(row.Cells("ESTADO").Value)), "", RTrim(row.Cells("ESTADO").Value))                   '10
            ELTBDETGUIABE.PESO_NETO = IIf(IsDBNull(RTrim(row.Cells("PESO_NETO").Value)), "", RTrim(row.Cells("PESO_NETO").Value))          '11
            ELTBDETGUIABE.PESO_BRUTO = IIf(IsDBNull(RTrim(row.Cells("PESO_BRUTO").Value)), "", RTrim(row.Cells("PESO_BRUTO").Value))       '12
            ELTBDETGUIABE.HOJAS = IIf(IsDBNull(RTrim(row.Cells("HOJAS").Value)), "", RTrim(row.Cells("HOJAS").Value))                      '13

            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETGUIABE.T_DOC_REF        '0
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETGUIABE.SER_DOC_REF    '1
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETGUIABE.NRO_DOC_REF    '2
            cmd.Parameters.Add("@T_DOC_REF1", OracleDbType.Varchar2).Value = ELTBDETGUIABE.T_DOC_REF1      '3
            cmd.Parameters.Add("@SER_DOC_REF1", OracleDbType.Varchar2).Value = ELTBDETGUIABE.SER_DOC_REF1  '4
            cmd.Parameters.Add("@NRO_DOC_REF1", OracleDbType.Varchar2).Value = ELTBDETGUIABE.NRO_DOC_REF1  '5
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBDETGUIABE.ART_COD            '6
            cmd.Parameters.Add("@COD_FAR", OracleDbType.Varchar2).Value = ELTBDETGUIABE.COD_FAR            '7
            cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBDETGUIABE.FEC_GENE              '9
            cmd.Parameters.Add("@ESTADO", OracleDbType.Varchar2).Value = ELTBDETGUIABE.ESTADO              '10
            cmd.Parameters.Add("@PESO_NETO", OracleDbType.Double).Value = ELTBDETGUIABE.PESO_NETO          '11
            cmd.Parameters.Add("@PESO_BRUTO", OracleDbType.Double).Value = ELTBDETGUIABE.PESO_BRUTO        '12
            cmd.Parameters.Add("@HOJAS", OracleDbType.Double).Value = ELTBDETGUIABE.HOJAS                '13
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            NroCodFardo = NroCodFardo + 1
        Next

    End Sub
    Private Sub UpdateRow(ByVal ELTBDETGUIABE As ELTBDETGUIABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim NroCodFardo As String
        NroCodFardo = ELTBDETGUIABE.CFardo
        NroCodFardo = Mid(NroCodFardo, 2, 5)

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETGUIA_INSROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            Dim NroFardo As String = ""
            Dim NroCodFardoN As String = ""
            Dim CodF As String = ""
            Dim CodN As String = ""

            ELTBDETGUIABE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("t_doc_ref").Value)), "", RTrim(row.Cells("t_doc_ref").Value))            '0
            ELTBDETGUIABE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))      '1
            ELTBDETGUIABE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))      '2
            ELTBDETGUIABE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))         '3
            ELTBDETGUIABE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))   '4

            If (cont).ToString.Length = 1 Then
                NroFardo = "0000000" & (cont).ToString
            ElseIf (cont).ToString.Length = 2 Then
                NroFardo = "000000" & (cont).ToString
            ElseIf (cont).ToString.Length = 3 Then
                NroFardo = "00000" & (cont).ToString
            ElseIf (cont).ToString.Length = 4 Then
                NroFardo = "0000" & (cont).ToString
            ElseIf (cont).ToString.Length = 5 Then
                NroFardo = "000" & (cont).ToString
            ElseIf (cont).ToString.Length = 6 Then
                NroFardo = "00" & (cont).ToString
            ElseIf (cont).ToString.Length = 7 Then
                NroFardo = "0" & (cont).ToString
            ElseIf (cont).ToString.Length = 6 Then
                NroFardo = (cont).ToString
            End If
            ELTBDETGUIABE.NRO_DOC_REF1 = NroFardo                                                                                          '5
            ELTBDETGUIABE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))                '6


            If IIf(IsDBNull(RTrim(row.Cells("ESTADO").Value)), "", RTrim(row.Cells("ESTADO").Value)) = "U" Then
                NroCodFardoN = IIf(IsDBNull(RTrim(row.Cells("COD_FAR").Value)), "", RTrim(row.Cells("COD_FAR").Value))
                CodN = Mid(NroCodFardoN, 7, 5)
                ELTBDETGUIABE.COD_FAR = "F" & NroCodFardo & CodN                                                                           '7
                NroCodFardo = NroCodFardo + 1
            Else
                ELTBDETGUIABE.COD_FAR = IIf(IsDBNull(RTrim(row.Cells("COD_FAR").Value)), "", RTrim(row.Cells("COD_FAR").Value))            '7
            End If

            ELTBDETGUIABE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells("FEC_GENE").Value)), "", RTrim(row.Cells("FEC_GENE").Value))             '9
            ELTBDETGUIABE.ESTADO = IIf(IsDBNull(RTrim(row.Cells("ESTADO").Value)), "", RTrim(row.Cells("ESTADO").Value))                   '10
            ELTBDETGUIABE.PESO_NETO = IIf(IsDBNull(RTrim(row.Cells("PESO_NETO").Value)), "", RTrim(row.Cells("PESO_NETO").Value))          '11
            ELTBDETGUIABE.PESO_BRUTO = IIf(IsDBNull(RTrim(row.Cells("PESO_BRUTO").Value)), "", RTrim(row.Cells("PESO_BRUTO").Value))       '12
            ELTBDETGUIABE.HOJAS = IIf(IsDBNull(RTrim(row.Cells("HOJAS").Value)), "", RTrim(row.Cells("HOJAS").Value))                      '13

            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETGUIABE.T_DOC_REF        '0
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETGUIABE.SER_DOC_REF    '1
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETGUIABE.NRO_DOC_REF    '2
            cmd.Parameters.Add("@T_DOC_REF1", OracleDbType.Varchar2).Value = ELTBDETGUIABE.T_DOC_REF1      '3
            cmd.Parameters.Add("@SER_DOC_REF1", OracleDbType.Varchar2).Value = ELTBDETGUIABE.SER_DOC_REF1  '4
            cmd.Parameters.Add("@NRO_DOC_REF1", OracleDbType.Varchar2).Value = ELTBDETGUIABE.NRO_DOC_REF1  '5
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBDETGUIABE.ART_COD            '6

            cmd.Parameters.Add("@COD_FAR", OracleDbType.Varchar2).Value = ELTBDETGUIABE.COD_FAR            '7

            cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBDETGUIABE.FEC_GENE              '9
            cmd.Parameters.Add("@ESTADO", OracleDbType.Char).Value = ELTBDETGUIABE.ESTADO                  '10
            cmd.Parameters.Add("@PESO_NETO", OracleDbType.Double).Value = ELTBDETGUIABE.PESO_NETO          '11
            cmd.Parameters.Add("@PESO_BRUTO", OracleDbType.Double).Value = ELTBDETGUIABE.PESO_BRUTO        '12
            cmd.Parameters.Add("@HOJAS", OracleDbType.Double).Value = ELTBDETGUIABE.HOJAS                  '13
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        Next

    End Sub
    Private Sub AnularRow(ByVal ELTBDETGUIABE As ELTBDETGUIABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETGUIA_UPEST"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETGUIABE.T_DOC_REF
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETGUIABE.SER_DOC_REF
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETGUIABE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Function Ncont() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBDETGUIA_NCONT", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function
End Class
