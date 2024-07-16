Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class SOLMATERIALESDAL
    Inherits BaseDatosORACLE
    Public sNumero As String
    Public sNumero1 As Double
    Private Sub InsertRow(ByVal SOLMATERIALESBE As SOLMATERIALESBE, ByVal ELTBDETSOLMATERIALESBE As ELTBDETSOLMATERIALESBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_SOLMAT_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.T_DOC_REF '1
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.SER_DOC_REF '2
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.NRO_DOC_REF '3
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = SOLMATERIALESBE.FEC_GENE '4
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = SOLMATERIALESBE.EST '5
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = SOLMATERIALESBE.USUARIO '6
        cmd.Parameters.Add("@observa", OracleDbType.Char).Value = SOLMATERIALESBE.OBSERVA '7
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = SOLMATERIALESBE.CCO_COD '8
        cmd.Parameters.Add("@linea", OracleDbType.Char).Value = SOLMATERIALESBE.LINEA '9
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = SOLMATERIALESBE.FEC_ANU '10
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = SOLMATERIALESBE.FEC_DIA '11
        cmd.Parameters.Add("@NRO_ORDEN", OracleDbType.Char).Value = SOLMATERIALESBE.NRO_ORDEN '12
        cmd.Parameters.Add("@SER_ORDEN", OracleDbType.Char).Value = SOLMATERIALESBE.SER_ORDEN '13
        cmd.Parameters.Add("@USUARIO_SOL", OracleDbType.Char).Value = SOLMATERIALESBE.USUARIO_SOL '14
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DETSOLMAT_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBDETSOLMATERIALESBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            ELTBDETSOLMATERIALESBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
            ELTBDETSOLMATERIALESBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))
            ELTBDETSOLMATERIALESBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(3).Value))
            ELTBDETSOLMATERIALESBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(4).Value)), "", RTrim(row.Cells(4).Value))
            ELTBDETSOLMATERIALESBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(5).Value)), "", RTrim(row.Cells(5).Value))
            ELTBDETSOLMATERIALESBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            ELTBDETSOLMATERIALESBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            ELTBDETSOLMATERIALESBE.OBSERVA = IIf(IsDBNull(RTrim(row.Cells("OBSERVA").Value)), "", RTrim(row.Cells("OBSERVA").Value))
            ELTBDETSOLMATERIALESBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
            ELTBDETSOLMATERIALESBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells("ACT_COD").Value)), "", RTrim(row.Cells("ACT_COD").Value))
            ELTBDETSOLMATERIALESBE.ART_ACT = IIf(IsDBNull(RTrim(row.Cells("ART_ACT").Value)), "", RTrim(row.Cells("ART_ACT").Value))
            If IIf(IsDBNull(RTrim(row.Cells("EST1").Value)), "", RTrim(row.Cells("EST1").Value)) = "" Then
                ELTBDETSOLMATERIALESBE.EST1 = "0"
            Else
                ELTBDETSOLMATERIALESBE.EST1 = IIf(IsDBNull(RTrim(row.Cells("EST1").Value)), "", RTrim(row.Cells("EST1").Value))
            End If

            If SOLMATERIALESBE.SER_DOC_REF = ELTBDETSOLMATERIALESBE.SER_DOC_REF1 Then
                ELTBDETSOLMATERIALESBE.NRO_DOC_REF1 = SOLMATERIALESBE.NRO_DOC_REF & "-" & cont
            End If
            ELTBDETSOLMATERIALESBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells("CCO_COD").Value)), "", RTrim(row.Cells("CCO_COD").Value))
            ELTBDETSOLMATERIALESBE.LINEA = IIf(IsDBNull(RTrim(row.Cells("LINEA").Value)), "", RTrim(row.Cells("LINEA").Value))
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.T_DOC_REF '1
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.SER_DOC_REF '2
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.NRO_DOC_REF '3
            'If ELTBDETSOLMATERIALESBE.T_DOC_REF1 = "OPRD" Then
            '    cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.T_DOC_REF1 '4
            '    cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.SER_DOC_REF1 '5
            '    cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = SOLMATERIALESBE.NRO_ORDEN  '6
            'Else
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.T_DOC_REF1 '4
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.SER_DOC_REF1 '5
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.NRO_DOC_REF1 '6
            'End If
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.ART_COD '7
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = ELTBDETSOLMATERIALESBE.CANTIDAD '8
            cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.OBSERVA '9
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.UNIDAD '10
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = SOLMATERIALESBE.FEC_GENE '11
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = SOLMATERIALESBE.EST '12
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = SOLMATERIALESBE.USUARIO '13
            cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = SOLMATERIALESBE.FEC_ANU '10
            cmd.Parameters.Add("@act_cod", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.ACT_COD '10
            cmd.Parameters.Add("@EST1", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.EST1 '10
            cmd.Parameters.Add("@ART_ACT", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.ART_ACT '10
            If SOLMATERIALESBE.NRO_ORDEN = Nothing Then
                cmd.Parameters.Add("@X_EST", OracleDbType.Varchar2).Value = "" '12
            Else
                cmd.Parameters.Add("@X_EST", OracleDbType.Varchar2).Value = "1" '12
            End If
            cmd.Parameters.Add("@cantidad2", OracleDbType.Double).Value = 0 '18
            cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.CCO_COD '10
            cmd.Parameters.Add("@LINEA", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.LINEA '10
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        Next
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso la solicitud de materiales: " + SOLMATERIALESBE.T_DOC_REF + "-" + SOLMATERIALESBE.SER_DOC_REF + "-" + SOLMATERIALESBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub InsertRowN(ByVal SOLMATERIALESBE As SOLMATERIALESBE, ByVal ELTBDETSOLMATERIALESBE As ELTBDETSOLMATERIALESBE,
                           ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                           ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dgv As DataGridView,
                           ByVal sord As String, ByVal nord As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_SOLMAT_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.T_DOC_REF '1
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.SER_DOC_REF '2
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.NRO_DOC_REF '3
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = SOLMATERIALESBE.FEC_GENE '4
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = SOLMATERIALESBE.EST '5
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = SOLMATERIALESBE.USUARIO '6
        cmd.Parameters.Add("@observa", OracleDbType.Char).Value = SOLMATERIALESBE.OBSERVA '7
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = SOLMATERIALESBE.CCO_COD '8
        cmd.Parameters.Add("@linea", OracleDbType.Char).Value = SOLMATERIALESBE.LINEA '9
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = SOLMATERIALESBE.FEC_ANU '10
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = SOLMATERIALESBE.FEC_DIA '11
        cmd.Parameters.Add("@NRO_ORDEN", OracleDbType.Char).Value = nord '12
        cmd.Parameters.Add("@SER_ORDEN", OracleDbType.Char).Value = sord '13
        cmd.Parameters.Add("@USUARIO_SOL", OracleDbType.Char).Value = SOLMATERIALESBE.USUARIO_SOL '14
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        For Each row As DataGridViewRow In dgv.Rows

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DETSOLMAT_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBDETSOLMATERIALESBE.EST1 = "0"
            ELTBDETSOLMATERIALESBE.T_DOC_REF1 = "OPRD"
            ELTBDETSOLMATERIALESBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(0).Value))
            ELTBDETSOLMATERIALESBE.NRO_DOC_REF1 = If(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(1).Value))
            ELTBDETSOLMATERIALESBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))
            ELTBDETSOLMATERIALESBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(3).Value))
            ELTBDETSOLMATERIALESBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells(4).Value)), "", RTrim(row.Cells(4).Value))
            ELTBDETSOLMATERIALESBE.ART_ACT = IIf(IsDBNull(RTrim(row.Cells(13).Value)), "", RTrim(row.Cells(14).Value))
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.T_DOC_REF '1
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.SER_DOC_REF '2
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.NRO_DOC_REF '3
            If ELTBDETSOLMATERIALESBE.T_DOC_REF1 = "OPRD" Then
                cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.T_DOC_REF1 '4
                cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.SER_DOC_REF1 '5
                cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = SOLMATERIALESBE.NRO_ORDEN '6
            Else
                cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = SOLMATERIALESBE.T_DOC_REF '4
                cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = SOLMATERIALESBE.SER_DOC_REF '5
                cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = SOLMATERIALESBE.NRO_DOC_REF '6
            End If
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.ART_COD '7
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = ELTBDETSOLMATERIALESBE.CANTIDAD '8
            cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = "" '9
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.UNIDAD '10
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = SOLMATERIALESBE.FEC_GENE '11
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = SOLMATERIALESBE.EST '12
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = SOLMATERIALESBE.USUARIO '13
            cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = SOLMATERIALESBE.FEC_ANU '10
            cmd.Parameters.Add("@act_cod", OracleDbType.Varchar2).Value = "401M00" '10
            cmd.Parameters.Add("@EST1", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.EST1 '10
            cmd.Parameters.Add("@ART_ACT", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.ART_ACT '11
            cmd.Parameters.Add("@x_est", OracleDbType.Varchar2).Value = "" '11

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso la solicitud de materiales: " + SOLMATERIALESBE.T_DOC_REF + "-" + SOLMATERIALESBE.SER_DOC_REF + "-" + SOLMATERIALESBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRow(ByVal SOLMATERIALESBE As SOLMATERIALESBE, ByVal ELTBDETSOLMATERIALESBE As ELTBDETSOLMATERIALESBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        'Dim contenedor As String
        'Dim contenedor1 As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_SOLMAT_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.T_DOC_REF '1
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.SER_DOC_REF '2
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.NRO_DOC_REF '3
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = SOLMATERIALESBE.FEC_GENE '4
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = SOLMATERIALESBE.EST '5
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = SOLMATERIALESBE.USUARIO '6
        cmd.Parameters.Add("@observa", OracleDbType.Char).Value = SOLMATERIALESBE.OBSERVA '7
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = SOLMATERIALESBE.CCO_COD '8
        cmd.Parameters.Add("@linea", OracleDbType.Char).Value = SOLMATERIALESBE.LINEA '9
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = SOLMATERIALESBE.FEC_ANU '10
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = SOLMATERIALESBE.FEC_DIA '11
        cmd.Parameters.Add("@NRO_ORDEN", OracleDbType.Char).Value = SOLMATERIALESBE.NRO_ORDEN '12
        cmd.Parameters.Add("@SER_ORDEN", OracleDbType.Char).Value = SOLMATERIALESBE.SER_ORDEN '13
        cmd.Parameters.Add("@USUARIO_SOL", OracleDbType.Char).Value = SOLMATERIALESBE.USUARIO_SOL '14
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DETSOLMAT_DEL"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.T_DOC_REF '1
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.SER_DOC_REF '2
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.NRO_DOC_REF '3
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DETSOLMAT_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBDETSOLMATERIALESBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            ELTBDETSOLMATERIALESBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
            ELTBDETSOLMATERIALESBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))
            ELTBDETSOLMATERIALESBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(3).Value))
            ELTBDETSOLMATERIALESBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(4).Value)), "", RTrim(row.Cells(4).Value))
            ELTBDETSOLMATERIALESBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(5).Value)), "", RTrim(row.Cells(5).Value))
            ELTBDETSOLMATERIALESBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            ELTBDETSOLMATERIALESBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            ELTBDETSOLMATERIALESBE.OBSERVA = IIf(IsDBNull(RTrim(row.Cells("OBSERVA").Value)), "", RTrim(row.Cells("OBSERVA").Value))
            ELTBDETSOLMATERIALESBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
            ELTBDETSOLMATERIALESBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells("ACT_COD").Value)), "", RTrim(row.Cells("ACT_COD").Value))
            ELTBDETSOLMATERIALESBE.ART_ACT = IIf(IsDBNull(RTrim(row.Cells("ART_ACT").Value)), "", RTrim(row.Cells("ART_ACT").Value))
            If IIf(IsDBNull(RTrim(row.Cells("EST1").Value)), "", RTrim(row.Cells("EST1").Value)) = "" Then
                ELTBDETSOLMATERIALESBE.EST1 = "0"
            Else
                ELTBDETSOLMATERIALESBE.EST1 = IIf(IsDBNull(RTrim(row.Cells("EST1").Value)), "", RTrim(row.Cells("EST1").Value))
            End If
            ELTBDETSOLMATERIALESBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells("CCO_COD").Value)), "", RTrim(row.Cells("CCO_COD").Value))
            ELTBDETSOLMATERIALESBE.LINEA = IIf(IsDBNull(RTrim(row.Cells("LINEA").Value)), "", RTrim(row.Cells("LINEA").Value))
            ELTBDETSOLMATERIALESBE.CANTIDAD2 = Val(IIf(IsDBNull(RTrim(row.Cells("CANTIDAD2").Value)), "", RTrim(row.Cells("CANTIDAD2").Value)))
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.T_DOC_REF '1
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.SER_DOC_REF '2
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.NRO_DOC_REF '3
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.T_DOC_REF1 '4
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.SER_DOC_REF1 '5
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.NRO_DOC_REF1 '6
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.ART_COD '7
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = ELTBDETSOLMATERIALESBE.CANTIDAD '8
            cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.OBSERVA '9
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.UNIDAD '10
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = SOLMATERIALESBE.FEC_GENE '11
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = SOLMATERIALESBE.EST '12
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = SOLMATERIALESBE.USUARIO '13
            cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = SOLMATERIALESBE.FEC_ANU '14
            cmd.Parameters.Add("@act_cod", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.ACT_COD '15
            cmd.Parameters.Add("@EST1", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.EST1 '16
            cmd.Parameters.Add("@art_act", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.ART_ACT '17
            If SOLMATERIALESBE.NRO_ORDEN = Nothing Then
                cmd.Parameters.Add("@X_EST", OracleDbType.Varchar2).Value = "" '12
            Else
                cmd.Parameters.Add("@X_EST", OracleDbType.Varchar2).Value = "1" '12
            End If
            cmd.Parameters.Add("@cantidad2", OracleDbType.Double).Value = ELTBDETSOLMATERIALESBE.CANTIDAD2 '18
            cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.CCO_COD '10
            cmd.Parameters.Add("@LINEA", OracleDbType.Varchar2).Value = ELTBDETSOLMATERIALESBE.LINEA '10
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        Next
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo la solicitud de materiales: " + SOLMATERIALESBE.T_DOC_REF + "-" + SOLMATERIALESBE.SER_DOC_REF + "-" + SOLMATERIALESBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdCant(ByVal SOLMATERIALESBE As SOLMATERIALESBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        'Dim contenedor1 As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_SOLMAT_UPDCNTAT"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.SER_DOC_REF '2
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.NRO_DOC_REF '3
        cmd.ExecuteNonQuery()
        cmd.Dispose()


    End Sub
    Private Sub UpdDoc(ByVal SOLMATERIALESBE As SOLMATERIALESBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        'Dim contenedor1 As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETSOLM_UPDATE_DOC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.T_DOC_REF '1
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.SER_DOC_REF '2
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = SOLMATERIALESBE.NRO_DOC_REF '3 
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = SOLMATERIALESBE.ART_COD ' 4
        cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = SOLMATERIALESBE.T_DOC_REF1 '5
        cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = SOLMATERIALESBE.SER_DOC_REF1 '6
        cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = SOLMATERIALESBE.NRO_DOC_REF1 '7
        cmd.ExecuteNonQuery()
        cmd.Dispose()


    End Sub
    Public Function UpdRowDoc(ByVal SOLMATERIALESBE As SOLMATERIALESBE, ByVal flagAccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try

            UpdDoc(SOLMATERIALESBE, cn, sqlTrans)
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

            'End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Private Sub UpdateAproSol(ByVal SOLMATERIALESBE As SOLMATERIALESBE, ByVal ELTBDETSOLMATERIALESBE As ELTBDETSOLMATERIALESBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        'Dim contenedor As String
        'Dim contenedor1 As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_SOLMAT_UPDATEAPRO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.NRO_DOC_REF)
        cmd.Parameters.Add("pusuario_vb", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.USUARIO_VB)
        cmd.Parameters.Add("art_cod", OracleDbType.Varchar2).Value = Trim(ELTBDETSOLMATERIALESBE.ART_COD)
        cmd.Parameters.Add("FEC_GENE", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.FEC_GENE)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Aprobo la solicitud de materiales: " + SOLMATERIALESBE.T_DOC_REF + "-" + SOLMATERIALESBE.SER_DOC_REF + "-" + SOLMATERIALESBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateAproSol1(ByVal SOLMATERIALESBE As SOLMATERIALESBE, ByVal ELTBDETSOLMATERIALESBE As ELTBDETSOLMATERIALESBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        'Dim contenedor As String
        'Dim contenedor1 As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_SOLMAT_UPDATEAPRO1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.NRO_DOC_REF)
        cmd.Parameters.Add("pusuario_vb", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.USUARIO_VB)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Aprobo la solicitud de materiales: " + SOLMATERIALESBE.T_DOC_REF + "-" + SOLMATERIALESBE.SER_DOC_REF + "-" + SOLMATERIALESBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateDproSol(ByVal SOLMATERIALESBE As SOLMATERIALESBE, ByVal ELTBDETSOLMATERIALESBE As ELTBDETSOLMATERIALESBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        'Dim contenedor As String
        'Dim contenedor1 As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_SOLMAT_UPDATEDPRO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.NRO_DOC_REF)
        cmd.Parameters.Add("pusuario_vb", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.USUARIO_OB)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Desaprobo la solicitud de materiales: " + SOLMATERIALESBE.T_DOC_REF + "-" + SOLMATERIALESBE.SER_DOC_REF + "-" + SOLMATERIALESBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateReqSol(ByVal SOLMATERIALESBE As SOLMATERIALESBE, ByVal ELTBDETSOLMATERIALESBE As ELTBDETSOLMATERIALESBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        'Dim contenedor As String
        'Dim contenedor1 As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_SOLMAT_UPDATEDPRO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.NRO_DOC_REF)
        cmd.Parameters.Add("pusuario_vb", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.USUARIO_ATENCION)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Desaprobo la solicitud de materiales: " + SOLMATERIALESBE.T_DOC_REF + "-" + SOLMATERIALESBE.SER_DOC_REF + "-" + SOLMATERIALESBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRowAnularSol(ByVal SOLMATERIALESBE As SOLMATERIALESBE, ByVal ELTBDETSOLMATERIALESBE As ELTBDETSOLMATERIALESBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBSOLMATERIALES_ANUDOCU"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.NRO_DOC_REF)
        cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = "A"
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETSOLMATERIALES_ANULAR"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.NRO_DOC_REF)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "5"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Anulo la solicitud de materiales: " + SOLMATERIALESBE.T_DOC_REF + "-" + SOLMATERIALESBE.SER_DOC_REF + "-" + SOLMATERIALESBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRowCerrarSol(ByVal SOLMATERIALESBE As SOLMATERIALESBE, ByVal ELTBDETSOLMATERIALESBE As ELTBDETSOLMATERIALESBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_SOLMAT_UPDATECPRO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(SOLMATERIALESBE.NRO_DOC_REF)
        cmd.Parameters.Add("part_cod", OracleDbType.Varchar2).Value = Trim(ELTBDETSOLMATERIALESBE.ART_COD)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Cerro la solicitud de materiales: " + SOLMATERIALESBE.T_DOC_REF + "-" + SOLMATERIALESBE.SER_DOC_REF + "-" + SOLMATERIALESBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Public Function UpdRow(ByVal SOLMATERIALESBE As SOLMATERIALESBE, ByVal flagAccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try

            UpdCant(SOLMATERIALESBE, cn, sqlTrans)
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

            'End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Public Function SaveRow(ByVal SOLMATERIALESBE As SOLMATERIALESBE, ByVal ELTBDETSOLMATERIALESBE As ELTBDETSOLMATERIALESBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String,
                            ByVal dg As DataGridView) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try
            If flagAccion = "N" Then
                InsertRow(SOLMATERIALESBE, ELTBDETSOLMATERIALESBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If

            If flagAccion = "M" Then
                UpdateRow(SOLMATERIALESBE, ELTBDETSOLMATERIALESBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If

            If flagAccion = "AS" Then
                UpdateAproSol(SOLMATERIALESBE, ELTBDETSOLMATERIALESBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "AS1" Then
                UpdateAproSol1(SOLMATERIALESBE, ELTBDETSOLMATERIALESBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "DS" Then
                UpdateDproSol(SOLMATERIALESBE, ELTBDETSOLMATERIALESBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "RQ" Then
                UpdateReqSol(SOLMATERIALESBE, ELTBDETSOLMATERIALESBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "A" Then
                UpdateRowAnularSol(SOLMATERIALESBE, ELTBDETSOLMATERIALESBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "CSM" Then
                UpdateRowCerrarSol(SOLMATERIALESBE, ELTBDETSOLMATERIALESBE, ELMVLOGSBE, cn, sqlTrans, dg)
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
                If flagAccion <> "DS" And flagAccion <> "AS" And flagAccion <> "CSM" And flagAccion <> "N" Then
                    cn.Dispose()
                End If

            End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Public Function SaveRow1(ByVal SOLMATERIALESBE As SOLMATERIALESBE, ByVal ELTBDETSOLMATERIALESBE As ELTBDETSOLMATERIALESBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String,
                             ByVal dgv As DataGridView, ByVal sord As String, ByVal nord As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try
            If flagAccion = "NN" Then
                InsertRowN(SOLMATERIALESBE, ELTBDETSOLMATERIALESBE, ELMVLOGSBE, cn, sqlTrans, dgv, sord, nord)
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
                'If flagAccion <> "DS" And flagAccion <> "AS" And flagAccion <> "CSM" And flagAccion <> "N" Then
                '    cn.Dispose()
                'End If
            End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Public Function SelectArt(ByVal sTdoc As String, ByVal sSer As String, ByVal sNro As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDETSOLMATERIALES_DOC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@tipo", sTdoc),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser", sSer),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro", sNro)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelectRow(ByVal sTdoc As String, ByVal sSer As String, ByVal sNro As String, ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDETSOLMATERIALES_DOCU", {New Oracle.ManagedDataAccess.Client.OracleParameter("@tipo", sTdoc),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser", sSer),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro", sNro),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@art", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelVerOP(ByVal sCode As String) As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_PREART", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode))})
            '    While dr.Read
            '        sNumero = dr.GetInt32(0)
            '    End While
            'End Using
            'Return sNumero
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If Val(dt.Rows(0).Item(0).ToString) > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 1
        End If
    End Function

    Public Function SelectNro(ByVal sCode As String, ByVal sSer As String) As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SOLMATERIALES_SELECTNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode)),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sSer))})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero

    End Function

    Function listTot(ByVal ser As String, ByVal nro As String) As Int32

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SEARCH_OPEST", {New Oracle.ManagedDataAccess.Client.OracleParameter("@var", Trim(ser)),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@var", Trim(nro))})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero
    End Function

    Public Function SelectAll(ByVal sT_doc As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SOLMATERIALES_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAllUsuario(ByVal sT_doc As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SOLMATERIALES_SELECTALLUsuario", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SOLMAT_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
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
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBDETSOLMAT_SEL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelLinea(ByVal sCode As String) As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SELLINEA_ALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode))})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero
    End Function
    Public Function SelectUsuario(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_USERSYSTEM_DNI", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode))})
            While dr.Read
                sNumero = dr.GetString(0)
            End While
        End Using
        Return sNumero
    End Function
    Public Function getListdgv1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sArt As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SOLDETMAT_SEL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@art_cod", sArt)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectActivos1(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SOLMAT_LIST", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRecursos(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SOLMAT_LIST_RECURSOS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectASQ(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SOLMAT_LIST_ASQ", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectVentas(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SOLMAT_LIST_VENTAS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectALM(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SOLMAT_LIST_ALM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectLOG(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SOLMAT_LIST_LOG", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectCONT(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SOLMAT_LIST_CONT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectMant(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SOLMAT_LIST_MANT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAllAp(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SOLMAT_A", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function list1(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
               ByVal fec As Date, ByVal sCos As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SOLMATERIALES_SEARCH", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", fec),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@sCos", sCos)})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function list2(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String, ByVal sCos As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SOLMATERIALES_SEARCH2", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@sCos", Trim(sCos))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function gArea(ByVal tlinea As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBSOLMAT_AREA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@TLINEA", Trim(tlinea))})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function gArea1(ByVal tlinea As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBSOLMAT_AREA1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@TLINEA", Trim(tlinea))})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
