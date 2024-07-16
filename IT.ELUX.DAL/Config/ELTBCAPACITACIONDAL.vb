Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBCAPACITACIONDAL
    Inherits BaseDatosORACLE
    Public sNumero As String = ""
    Public sNumero1 As String = ""

    Public Function SelectCCosto() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_CCOSTO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
        End
    End Function
    Public Function SelectNro(ByVal sCode As String, ByVal sSer As String) As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBCONTSEG_SELECTNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode)),
                                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sSer))})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero

    End Function

    Public Function SelectAll(ByVal Anho As String, ByVal Mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBCONTSEG_SELALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", Anho),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", Mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAllTo(ByVal Anho As String, ByVal Mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBCONTSEG_SELALLTO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", Anho),
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
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBCONTSEG_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
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
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBDETCONTSEG_SEL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function getListdgv1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBDETCONTSEG_SEL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectTema(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBTEMASEG_SELECT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pCOD", Trim(sCod))})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getCapacitacion1() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBTEMASEG_SELALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectNroCod() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBTEMASEG_SELECTNRO", {})
            While dr.Read
                sNumero1 = dr.GetString(0)
            End While
        End Using
        Return sNumero1
    End Function
    Public Function SaveRow(ByVal ELTBCAPACITACIONBE As ELTBCAPACITACIONBE, ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try
            If flagAccion = "N" Then
                InsertRow(ELTBCAPACITACIONBE, cn, sqlTrans, dg)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBCAPACITACIONBE, cn, sqlTrans, dg)
            End If

            If flagAccion = "A" Then
                UpdateCapa(ELTBCAPACITACIONBE, cn, sqlTrans, dg)
            End If

            If flagAccion = "AD" Then
                UpdateAprob(ELTBCAPACITACIONBE, cn, sqlTrans, dg)
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
            '    If flagAccion <> "DS" And flagAccion <> "AS" And flagAccion <> "CSM" And flagAccion <> "N" Then
            '        cn.Dispose()
            '    End If
            '
            'End If
            'sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Private Sub InsertRow(ByVal ELTBCAPACITACIONBE As ELTBCAPACITACIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CAPSEG_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.T_DOC_REF '1
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.SER_DOC_REF '2
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.NRO_DOC_REF '3
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBCAPACITACIONBE.FEC_GENE '4
        cmd.Parameters.Add("@est", OracleDbType.Char).Value = ELTBCAPACITACIONBE.EST '5
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.PER_COD '6
        cmd.Parameters.Add("@tema", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.TEMA '7
        cmd.Parameters.Add("@act_cod", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.ACT_COD '8
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = ELTBCAPACITACIONBE.FEC_DIA '9
        cmd.Parameters.Add("@hor_ini", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.HOR_INI '10
        cmd.Parameters.Add("@hor_fin", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.HOR_FIN '11
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.USUARIO '12
        cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.OBSERVA '13
        cmd.Parameters.Add("@tipo", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.TIPO '14
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETCONTSEG_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBCAPACITACIONBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            ELTBCAPACITACIONBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            ELTBCAPACITACIONBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            ELTBCAPACITACIONBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELTBCAPACITACIONBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELTBCAPACITACIONBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELTBCAPACITACIONBE.PER_COD1 = IIf(IsDBNull(RTrim(row.Cells("PER_COD").Value)), "", RTrim(row.Cells("PER_COD").Value))
            ELTBCAPACITACIONBE.LINEA_COD = IIf(IsDBNull(RTrim(row.Cells("LINEA_COD").Value)), "", RTrim(row.Cells("LINEA_COD").Value))

            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.T_DOC_REF '1
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.SER_DOC_REF '2
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.NRO_DOC_REF '3
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.T_DOC_REF1 '4
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.SER_DOC_REF1 '5
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.NRO_DOC_REF1 '6
            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.PER_COD1 '7
            cmd.Parameters.Add("@linea_cod", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.LINEA_COD '8

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

    End Sub

    Private Sub UpdateRow(ByVal ELTBCAPACITACIONBE As ELTBCAPACITACIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBCONTSEG_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.T_DOC_REF '1
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.SER_DOC_REF '2
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.NRO_DOC_REF '3
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBCAPACITACIONBE.FEC_GENE '4
        cmd.Parameters.Add("@est", OracleDbType.Char).Value = ELTBCAPACITACIONBE.EST '5
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.PER_COD '6
        cmd.Parameters.Add("@tema", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.TEMA '7
        cmd.Parameters.Add("@act_cod", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.ACT_COD '8
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = ELTBCAPACITACIONBE.FEC_DIA '9
        cmd.Parameters.Add("@hor_ini", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.HOR_INI '10
        cmd.Parameters.Add("@hor_fin", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.HOR_FIN '11
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.USUARIO '12
        cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.OBSERVA '13
        cmd.Parameters.Add("@tipo", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.TIPO '14
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETCONTSEG_DEL"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.T_DOC_REF '1
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.SER_DOC_REF '2
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.NRO_DOC_REF '3
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETCONTSEG_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBCAPACITACIONBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            ELTBCAPACITACIONBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            ELTBCAPACITACIONBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            ELTBCAPACITACIONBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELTBCAPACITACIONBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELTBCAPACITACIONBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELTBCAPACITACIONBE.PER_COD1 = IIf(IsDBNull(RTrim(row.Cells("PER_COD").Value)), "", RTrim(row.Cells("PER_COD").Value))
            ELTBCAPACITACIONBE.LINEA_COD = IIf(IsDBNull(RTrim(row.Cells("LINEA_COD").Value)), "", RTrim(row.Cells("LINEA_COD").Value))

            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.T_DOC_REF '1
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.SER_DOC_REF '2
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.NRO_DOC_REF '3
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.T_DOC_REF1 '4
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.SER_DOC_REF1 '5
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.NRO_DOC_REF1 '6
            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.PER_COD1 '7
            cmd.Parameters.Add("@linea_cod", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.LINEA_COD '8

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub
    Public Function SaveRows(ByVal ELTBCAPACITACIONBE As ELTBCAPACITACIONBE, ByVal flagAccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try
            If flagAccion = "N" Then
                InsertRows(ELTBCAPACITACIONBE, cn, sqlTrans)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBCAPACITACIONBE, cn, sqlTrans)
            End If

            If flagAccion = "A" Then
                UpdatTema(ELTBCAPACITACIONBE, cn, sqlTrans)
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
            '    If flagAccion <> "DS" And flagAccion <> "AS" And flagAccion <> "CSM" And flagAccion <> "N" Then
            '        cn.Dispose()
            '    End If
            '
            'End If
            'sqlTrans = Nothing
        End Try

        Return resultado
    End Function
    Private Sub InsertRows(ByVal ELTBCAPACITACIONBE As ELTBCAPACITACIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBTEMASEG_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@codigo", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.CODIGO  '1
        cmd.Parameters.Add("@tema", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.TEMA1     '2
        cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.EST1    '3
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub UpdatTema(ByVal ELTBCAPACITACIONBE As ELTBCAPACITACIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBTEMASEG_ANUDOCU"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pcod", OracleDbType.Varchar2).Value = Trim(ELTBCAPACITACIONBE.CODIGO)
        cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = "A"
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateCapa(ByVal ELTBCAPACITACIONBE As ELTBCAPACITACIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBCONTSEG_ANUDOCU"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBCAPACITACIONBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBCAPACITACIONBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBCAPACITACIONBE.NRO_DOC_REF)
        cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = "1"
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRow(ByVal ELTBCAPACITACIONBE As ELTBCAPACITACIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBTEMASEG_UPDATE"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@codigo", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.CODIGO  '1
        cmd.Parameters.Add("@tema", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.TEMA1     '2
        cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.EST1    '3
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Function list(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBCONTSEG_PER", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function

    Public Function SelectApro(ByVal sFec As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBCONTSEG_EST", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC", sFec)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Private Sub UpdateAprob(ByVal ELTBCAPACITACIONBE As ELTBCAPACITACIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBCONTSEG_UPDATEAPROB"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.T_DOC_REF '1
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.SER_DOC_REF '2
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.NRO_DOC_REF '3
        cmd.Parameters.Add("@usuario_vb", OracleDbType.Varchar2).Value = ELTBCAPACITACIONBE.USUARIO_VB '4
        cmd.Parameters.Add("@est", OracleDbType.Char).Value = 2 '5
        cmd.Parameters.Add("@fec_apr", OracleDbType.Date).Value = DateTime.Now() '6
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Function SelectReporte() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBREPORTES", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
