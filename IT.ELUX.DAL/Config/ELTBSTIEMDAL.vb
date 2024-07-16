Imports IT.ELUX.BE
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBSTIEMDAL
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNomArt As String
    Private Sub InsPrograma(ByVal ELTBSTIEMBE As ELTBSTIEMBE, ByVal ELTBDETSTIEMBE As ELTBDETSTIEMBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                           ByVal dg As DataGridView)
        Dim HO As Integer = 0
        Dim MI As Integer = 0
        Dim SE As Integer = 0
        Dim cont As Integer = 0
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBSTIEM_INSERTPROG"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBSTIEMBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells("Codigo").Value)), "", RTrim(row.Cells("Codigo").Value))
            ELTBSTIEMBE.D_PROGRAMADO = IIf(IsDBNull(RTrim(row.Cells("FEC_INICIO").Value)), "", RTrim(row.Cells("FEC_INICIO").Value))
            ELTBSTIEMBE.MINUTOS = IIf(IsDBNull(RTrim(row.Cells("Dif_Hora").Value)), 0, RTrim(row.Cells("Dif_Hora").Value))
            'ELTBDETSTIEMBE.NRO_DOC_REF = Trim(ELTBSTIEMBE.NRO_DOC_REF)
            'ELTBDETSTIEMBE.T_DOC_REF1 = Trim(ELTBSTIEMBE.T_DOC_REF)
            cmd.Parameters.Add("@pPER_COD", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.PER_COD)
            cmd.Parameters.Add("@pD_PROGRAMADO", OracleDbType.Date).Value = ELTBSTIEMBE.FEC_GENE
            cmd.Parameters.Add("@pMINUTOS", OracleDbType.Double).Value = Trim(ELTBSTIEMBE.MINUTOS)
            cmd.Parameters.Add("@pUSUARIO", OracleDbType.Varchar2).Value = ELTBSTIEMBE.USUARIO
            cmd.Parameters.Add("@pOP", OracleDbType.Varchar2).Value = ELTBSTIEMBE.OP
            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBSTIEMBE.T_DOC_REF
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBSTIEMBE.SER_DOC_REF
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBSTIEMBE.NRO_DOC_REF
            cmd.Parameters.Add("@PRDO", OracleDbType.Varchar2).Value = ELTBSTIEMBE.PRDO
            cmd.Parameters.Add("@LINEA", OracleDbType.Varchar2).Value = ELTBSTIEMBE.LINEA
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
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Reporte de Horas: " + ELTBDETSTIEMBE.T_DOC_REF + "-" + ELTBDETSTIEMBE.SER_DOC_REF + "-" + ELTBDETSTIEMBE.NRO_DOC_REF
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub InsertRow(ByVal ELTBSTIEMBE As ELTBSTIEMBE, ByVal ELTBDETSTIEMBE As ELTBDETSTIEMBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                           ByVal dg As DataGridView)
        Dim HO As Integer = 0
        Dim MI As Integer = 0
        Dim SE As Integer = 0

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBSTIEM_INSERT"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.NRO_DOC_REF)
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELTBSTIEMBE.PER_COD
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = ELTBSTIEMBE.CCO_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBSTIEMBE.FEC_GENE
        cmd.Parameters.Add("@usuario_rp", OracleDbType.Varchar2).Value = ELTBSTIEMBE.USUARIO_RP
        cmd.Parameters.Add("@usuario_ob", OracleDbType.Varchar2).Value = ELTBSTIEMBE.USUARIO_OB
        cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = ELTBSTIEMBE.OBSERVA
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = ELTBSTIEMBE.FEC_DIA
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELTBSTIEMBE.EST
        cmd.Parameters.Add("@usuario_vb", OracleDbType.Varchar2).Value = ELTBSTIEMBE.USUARIO_VB
        cmd.Parameters.Add("@linea", OracleDbType.Varchar2).Value = ELTBSTIEMBE.LINEA
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETSTIEM_INSERT"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBDETSTIEMBE.T_DOC_REF = Trim(ELTBSTIEMBE.T_DOC_REF)
            ELTBDETSTIEMBE.SER_DOC_REF = Trim(ELTBSTIEMBE.SER_DOC_REF)
            ELTBDETSTIEMBE.NRO_DOC_REF = Trim(ELTBSTIEMBE.NRO_DOC_REF)
            ELTBDETSTIEMBE.T_DOC_REF1 = Trim(ELTBSTIEMBE.T_DOC_REF)
            ELTBDETSTIEMBE.SER_DOC_REF1 = Trim(ELTBSTIEMBE.SER_DOC_REF)
            ELTBDETSTIEMBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells("Codigo").Value)), "", RTrim(row.Cells("Codigo").Value))
            ELTBDETSTIEMBE.HORA_GENE = IIf(IsDBNull(RTrim(row.Cells("Hora_Inicio").Value)), "", RTrim(row.Cells("Hora_Inicio").Value))
            ELTBDETSTIEMBE.HORA_TERMINO = IIf(IsDBNull(RTrim(row.Cells("Hora_Final").Value)), "", RTrim(row.Cells("Hora_Final").Value))
            ELTBDETSTIEMBE.ACT_REALIZAR = IIf(IsDBNull(RTrim(row.Cells("Act_Realizar").Value)), "", RTrim(row.Cells("Act_Realizar").Value))
            ELTBDETSTIEMBE.USUARIO_RP = IIf(IsDBNull(RTrim(row.Cells("USUARIO_RP").Value)), "", RTrim(row.Cells("USUARIO_RP").Value))
            'HO = DateDiff(DateInterval.Hour, IIf(IsDBNull(RTrim(row.Cells("Hora_Inicio").Value)), "", RTrim(row.Cells("Hora_Inicio").Value)), IIf(IsDBNull(RTrim(row.Cells("Hora_Final").Value)), "", RTrim(row.Cells("Hora_Final").Value)))
            'MI = DateDiff(DateInterval.Minute, IIf(IsDBNull(RTrim(row.Cells("Hora_Inicio").Value)), "", RTrim(row.Cells("Hora_Inicio").Value)), IIf(IsDBNull(RTrim(row.Cells("Hora_Final").Value)), "", RTrim(row.Cells("Hora_Final").Value)))
            'SE = DateDiff(DateInterval.Second, IIf(IsDBNull(RTrim(row.Cells("Hora_Inicio").Value)), "", RTrim(row.Cells("Hora_Inicio").Value)), IIf(IsDBNull(RTrim(row.Cells("Hora_Final").Value)), "", RTrim(row.Cells("Hora_Final").Value)))
            'MI = MI Mod 60
            'SE = SE Mod 60
            'ELTBDETSTIEMBE.DIF_HORA = HO.ToString.PadLeft(2, "0") & ":" & MI.ToString.PadLeft(2, "0") & ":" & SE.ToString.PadLeft(2, "0")
            ELTBDETSTIEMBE.FEC_INICIO = IIf(IsDBNull(RTrim(row.Cells("FEC_INICIO").Value)), "", RTrim(row.Cells("FEC_INICIO").Value))
            ELTBDETSTIEMBE.FEC_TERMINO = IIf(IsDBNull(RTrim(row.Cells("FEC_TERMINO").Value)), "", RTrim(row.Cells("FEC_TERMINO").Value))
            ELTBDETSTIEMBE.DIF_HORA = IIf(IsDBNull(RTrim(row.Cells("Num_Hora").Value)), "", RTrim(row.Cells("Num_Hora").Value))
            ELTBDETSTIEMBE.NUM = IIf(IsDBNull(RTrim(row.Cells("Dif_Hora").Value)), "", RTrim(row.Cells("Dif_Hora").Value))
            ELTBDETSTIEMBE.FEC_GENE = ELTBSTIEMBE.FEC_GENE
            ELTBDETSTIEMBE.EST = ELTBSTIEMBE.EST
            ELTBDETSTIEMBE.EST1 = "0"
            'M'    If ELTBSTIEMBE.PER_COD = "46618786" Then
            'M'        ELTBDETSTIEMBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("t_doc_Ref").Value)), "", RTrim(row.Cells("t_doc_Ref").Value))
            'M'        ELTBDETSTIEMBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("ser_doc_Ref").Value)), "", RTrim(row.Cells("ser_doc_Ref").Value))
            'M'        ELTBDETSTIEMBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("nro_doc_ref").Value)), "", RTrim(row.Cells("nro_doc_ref").Value))
            'M'    Else
            'M'        ELTBDETSTIEMBE.NRO_DOC_REF1 = ELTBDETSTIEMBE.NRO_DOC_REF & "-" & cont
            'M'    End If
            'M'
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBSTIEMBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBSTIEMBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBSTIEMBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETSTIEMBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETSTIEMBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETSTIEMBE.NRO_DOC_REF1
            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELTBDETSTIEMBE.PER_COD
            cmd.Parameters.Add("@hora_gene", OracleDbType.Varchar2).Value = ELTBDETSTIEMBE.HORA_GENE
            cmd.Parameters.Add("@hora_termino", OracleDbType.Varchar2).Value = ELTBDETSTIEMBE.HORA_TERMINO
            cmd.Parameters.Add("@act_realizar", OracleDbType.Varchar2).Value = ELTBDETSTIEMBE.ACT_REALIZAR
            'cmd.Parameters.Add("@usuario_ob", OracleDbType.Varchar2).Value = ELTBDETSTIEMBE.USUARIO_OB
            cmd.Parameters.Add("@usuario_rp", OracleDbType.Varchar2).Value = ELTBSTIEMBE.USUARIO_RP
            'cmd.Parameters.Add("@usuario_vb", OracleDbType.Date).Value = ELTBDETSTIEMBE.USUARIO_VB
            cmd.Parameters.Add("@dif_hora", OracleDbType.Varchar2).Value = ELTBDETSTIEMBE.DIF_HORA
            cmd.Parameters.Add("@FEC_INICIO", OracleDbType.Date).Value = ELTBDETSTIEMBE.FEC_INICIO
            cmd.Parameters.Add("@FEC_TERMINO", OracleDbType.Date).Value = ELTBDETSTIEMBE.FEC_TERMINO
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBSTIEMBE.FEC_GENE
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELTBSTIEMBE.EST
            cmd.Parameters.Add("@est1", OracleDbType.Varchar2).Value = ELTBDETSTIEMBE.EST1
            cmd.Parameters.Add("@NUM", OracleDbType.Double).Value = ELTBDETSTIEMBE.NUM

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
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Reporte de Horas: " + ELTBDETSTIEMBE.T_DOC_REF + "-" + ELTBDETSTIEMBE.SER_DOC_REF + "-" + ELTBDETSTIEMBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub AnularRow(ByVal ELTBSTIEMBE As ELTBSTIEMBE, ByVal ELTBDETSTIEMBE As ELTBDETSTIEMBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                           ByVal dg As DataGridView)
        Dim HO As Integer = 0
        Dim MI As Integer = 0
        Dim SE As Integer = 0

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBSTIEM_UPDANU"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.NRO_DOC_REF)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "2"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Anulo el Reporte de Horas: " + ELTBDETSTIEMBE.T_DOC_REF + "-" + ELTBDETSTIEMBE.SER_DOC_REF + "-" + ELTBDETSTIEMBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub UpdateRow(ByVal ELTBSTIEMBE As ELTBSTIEMBE, ByVal ELTBDETSTIEMBE As ELTBDETSTIEMBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBSTIEM_UPDATE"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.NRO_DOC_REF)
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELTBSTIEMBE.PER_COD
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = ELTBSTIEMBE.CCO_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBSTIEMBE.FEC_GENE
        'cmd.Parameters.Add("@usuario_rp", OracleDbType.Varchar2).Value = ELTBSTIEMBE.USUARIO_RP
        'cmd.Parameters.Add("@usuario_ob", OracleDbType.Varchar2).Value = ELTBSTIEMBE.USUARIO_OB
        cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = ELTBSTIEMBE.OBSERVA
        'cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = ELTBSTIEMBE.FEC_DIA
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELTBSTIEMBE.EST
        cmd.Parameters.Add("@linea", OracleDbType.Varchar2).Value = ELTBSTIEMBE.LINEA
        cmd.Parameters.Add("@OBSERVACION", OracleDbType.Varchar2).Value = ELTBSTIEMBE.OBSERVACION_JEFE
        cmd.Parameters.Add("@USUARIO_VB", OracleDbType.Varchar2).Value = ELTBSTIEMBE.USUARIO_VB
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETSTIEM_DEL"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBSTIEMBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBSTIEMBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBSTIEMBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETSTIEM_INSERT"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBDETSTIEMBE.T_DOC_REF = Trim(ELTBSTIEMBE.T_DOC_REF)
            ELTBDETSTIEMBE.SER_DOC_REF = Trim(ELTBSTIEMBE.SER_DOC_REF)
            ELTBDETSTIEMBE.NRO_DOC_REF = Trim(ELTBSTIEMBE.NRO_DOC_REF)
            ELTBDETSTIEMBE.T_DOC_REF1 = Trim(ELTBSTIEMBE.T_DOC_REF)
            ELTBDETSTIEMBE.SER_DOC_REF1 = Trim(ELTBSTIEMBE.SER_DOC_REF)
            ELTBDETSTIEMBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells("Codigo").Value)), "", RTrim(row.Cells("Codigo").Value))
            ELTBDETSTIEMBE.HORA_GENE = IIf(IsDBNull(RTrim(row.Cells("Hora_Inicio").Value)), "", RTrim(row.Cells("Hora_Inicio").Value))
            ELTBDETSTIEMBE.HORA_TERMINO = IIf(IsDBNull(RTrim(row.Cells("Hora_Final").Value)), "", RTrim(row.Cells("Hora_Final").Value))
            ELTBDETSTIEMBE.ACT_REALIZAR = IIf(IsDBNull(RTrim(row.Cells("Act_Realizar").Value)), "", RTrim(row.Cells("Act_Realizar").Value))
            ELTBDETSTIEMBE.USUARIO_RP = IIf(IsDBNull(RTrim(row.Cells("USUARIO_RP").Value)), "", RTrim(row.Cells("USUARIO_RP").Value))
            'HO = DateDiff(DateInterval.Hour, IIf(IsDBNull(RTrim(row.Cells("Hora_Inicio").Value)), "", RTrim(row.Cells("Hora_Inicio").Value)), IIf(IsDBNull(RTrim(row.Cells("Hora_Final").Value)), "", RTrim(row.Cells("Hora_Final").Value)))
            'MI = DateDiff(DateInterval.Minute, IIf(IsDBNull(RTrim(row.Cells("Hora_Inicio").Value)), "", RTrim(row.Cells("Hora_Inicio").Value)), IIf(IsDBNull(RTrim(row.Cells("Hora_Final").Value)), "", RTrim(row.Cells("Hora_Final").Value)))
            'SE = DateDiff(DateInterval.Second, IIf(IsDBNull(RTrim(row.Cells("Hora_Inicio").Value)), "", RTrim(row.Cells("Hora_Inicio").Value)), IIf(IsDBNull(RTrim(row.Cells("Hora_Final").Value)), "", RTrim(row.Cells("Hora_Final").Value)))
            'MI = MI Mod 60
            'SE = SE Mod 60
            'ELTBDETSTIEMBE.DIF_HORA = HO.ToString.PadLeft(2, "0") & ":" & MI.ToString.PadLeft(2, "0") & ":" & SE.ToString.PadLeft(2, "0")
            ELTBDETSTIEMBE.FEC_INICIO = IIf(IsDBNull(RTrim(row.Cells("FEC_INICIO").Value)), "", RTrim(row.Cells("FEC_INICIO").Value))
            ELTBDETSTIEMBE.FEC_TERMINO = IIf(IsDBNull(RTrim(row.Cells("FEC_TERMINO").Value)), "", RTrim(row.Cells("FEC_TERMINO").Value))
            ELTBDETSTIEMBE.DIF_HORA = IIf(IsDBNull(RTrim(row.Cells("Num_Hora").Value)), "", RTrim(row.Cells("Num_Hora").Value))
            ELTBDETSTIEMBE.NUM = IIf(IsDBNull(RTrim(row.Cells("Dif_Hora").Value)), "", RTrim(row.Cells("Dif_Hora").Value))
            ELTBDETSTIEMBE.FEC_GENE = ELTBSTIEMBE.FEC_GENE
            ELTBDETSTIEMBE.EST = ELTBSTIEMBE.EST
            ELTBDETSTIEMBE.EST1 = "0"
            ELTBDETSTIEMBE.NRO_DOC_REF1 = ELTBDETSTIEMBE.NRO_DOC_REF & "-" & cont

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBSTIEMBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBSTIEMBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBSTIEMBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETSTIEMBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETSTIEMBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETSTIEMBE.NRO_DOC_REF1
            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = ELTBDETSTIEMBE.PER_COD
            cmd.Parameters.Add("@hora_gene", OracleDbType.Varchar2).Value = ELTBDETSTIEMBE.HORA_GENE
            cmd.Parameters.Add("@hora_termino", OracleDbType.Varchar2).Value = ELTBDETSTIEMBE.HORA_TERMINO
            cmd.Parameters.Add("@act_realizar", OracleDbType.Varchar2).Value = ELTBDETSTIEMBE.ACT_REALIZAR
            'cmd.Parameters.Add("@usuario_ob", OracleDbType.Varchar2).Value = ELTBDETSTIEMBE.USUARIO_OB
            cmd.Parameters.Add("@usuario_rp", OracleDbType.Varchar2).Value = ELTBSTIEMBE.USUARIO_RP
            'cmd.Parameters.Add("@usuario_vb", OracleDbType.Date).Value = ELTBDETSTIEMBE.USUARIO_VB
            cmd.Parameters.Add("@dif_hora", OracleDbType.Varchar2).Value = ELTBDETSTIEMBE.DIF_HORA
            cmd.Parameters.Add("@FEC_INICIO", OracleDbType.Date).Value = ELTBDETSTIEMBE.FEC_INICIO
            cmd.Parameters.Add("@FEC_TERMINO", OracleDbType.Date).Value = ELTBDETSTIEMBE.FEC_TERMINO
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBSTIEMBE.FEC_GENE
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELTBSTIEMBE.EST
            cmd.Parameters.Add("@est1", OracleDbType.Varchar2).Value = ELTBDETSTIEMBE.EST1
            cmd.Parameters.Add("@NUM", OracleDbType.Double).Value = ELTBDETSTIEMBE.NUM
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
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se modifico el Reporte de Horas: " + ELTBSTIEMBE.T_DOC_REF + "-" + ELTBSTIEMBE.SER_DOC_REF + "-" + ELTBSTIEMBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRowRH(ByVal ELTBSTIEMBE As ELTBSTIEMBE, ByVal ELTBDETSTIEMBE As ELTBDETSTIEMBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBSTIEM_UPDATERH"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.NRO_DOC_REF)
        cmd.Parameters.Add("@OBSERVACIONRH", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.OBSERVACIONRH)
        cmd.Parameters.Add("@USUARIO_VB_RH", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.USUARIO_VB_RH)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se modifico el Reporte de Horas: " + ELTBSTIEMBE.T_DOC_REF + "-" + ELTBSTIEMBE.SER_DOC_REF + "-" + ELTBSTIEMBE.NRO_DOC_REF
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub UpdateRowJF(ByVal ELTBSTIEMBE As ELTBSTIEMBE, ByVal ELTBDETSTIEMBE As ELTBDETSTIEMBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBSTIEM_UPDATEJF"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.NRO_DOC_REF)
        cmd.Parameters.Add("@OBSERVACIONRH", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.OBSERVACIONRH)
        cmd.Parameters.Add("@USUARIO_VB_RH", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.USUARIO_VB_RH)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se modifico el Reporte de Horas: " + ELTBSTIEMBE.T_DOC_REF + "-" + ELTBSTIEMBE.SER_DOC_REF + "-" + ELTBSTIEMBE.NRO_DOC_REF
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    'Metodo para anular 
    Private Sub UpdateRowApro(ByVal ELTBSTIEMBE As ELTBSTIEMBE, ByVal ELTBDETSTIEMBE As ELTBDETSTIEMBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                                    ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PRODUCCION_UPDATEAPRO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.T_DOC_REF)
        'cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.SER_DOC_REF)
        'cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.NRO_DOC_REF)
        'cmd.Parameters.Add("pusuario_vb", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.USUARIO_VB)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        ''cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Aprobo el Reporte de Produccion: " + REPORTE_PRODUCCIONBE.T_DOC_REF + "-" + REPORTE_PRODUCCIONBE.SER_DOC_REF + "-" + REPORTE_PRODUCCIONBE.NRO_DOC_REF
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub UpdateRowDpro(ByVal ELTBSTIEMBE As ELTBSTIEMBE, ByVal ELTBDETSTIEMBE As ELTBDETSTIEMBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                                    ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PRODUCCION_UPDATEDPRO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.T_DOC_REF)
        'cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.SER_DOC_REF)
        'cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.NRO_DOC_REF)
        'cmd.Parameters.Add("pusuario_ob", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.USUARIO_OB)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        ''cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Observo el Reporte de Produccion: " + ELTBSTIEMBE.T_DOC_REF + "-" + REPORTE_PRODUCCIONBE.SER_DOC_REF + "-" + REPORTE_PRODUCCIONBE.NRO_DOC_REF
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub UpdEstHEJ(ByVal ELTBSTIEMBE As ELTBSTIEMBE, ByVal ELTBDETSTIEMBE As ELTBDETSTIEMBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBSTIEM_UPDATEHEJ"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.NRO_DOC_REF)
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.EST)
        cmd.Parameters.Add("@USUARIO_PLANTA", OracleDbType.Varchar2).Value = ELMVLOGSBE.log_codusu
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "5"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se aprobo la Hora extra en Jefatura: " + ELTBSTIEMBE.T_DOC_REF + "-" + ELTBSTIEMBE.SER_DOC_REF + "-" + ELTBSTIEMBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdEstHEJP(ByVal ELTBSTIEMBE As ELTBSTIEMBE, ByVal ELTBDETSTIEMBE As ELTBDETSTIEMBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBSTIEM_UPDATEHEJP"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.NRO_DOC_REF)
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.EST)
        cmd.Parameters.Add("@jefe_planta", OracleDbType.Varchar2).Value = ELMVLOGSBE.log_codusu
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "6"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se aprobo la Hora extra en Jefatura de Planta: " + ELTBSTIEMBE.T_DOC_REF + "-" + ELTBSTIEMBE.SER_DOC_REF + "-" + ELTBSTIEMBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdEstHERH(ByVal ELTBSTIEMBE As ELTBSTIEMBE, ByVal ELTBDETSTIEMBE As ELTBDETSTIEMBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBSTIEM_UPDATEHERH"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.NRO_DOC_REF)
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = Trim(ELTBSTIEMBE.EST)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "7"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Aprobo la Hora Extra para Proceso: " + ELTBSTIEMBE.T_DOC_REF + "-" + ELTBSTIEMBE.SER_DOC_REF + "-" + ELTBSTIEMBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Function SaveRow(ByVal ELTBSTIEMBE As ELTBSTIEMBE, ByVal ELTBDETSTIEMBE As ELTBDETSTIEMBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String,
                            ByVal dg As DataGridView) As String
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
                InsertRow(ELTBSTIEMBE, ELTBDETSTIEMBE, ELMVLOGSBE, cn, sqlTrans, dg)
                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBSTIEMBE, ELTBDETSTIEMBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "A" Then
                AnularRow(ELTBSTIEMBE, ELTBDETSTIEMBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "MRH" Then
                UpdateRowRH(ELTBSTIEMBE, ELTBDETSTIEMBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "MJF" Then
                UpdateRowJF(ELTBSTIEMBE, ELTBDETSTIEMBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "HE" Then
                UpdEstHEJ(ELTBSTIEMBE, ELTBDETSTIEMBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "HEJP" Then
                UpdEstHEJP(ELTBSTIEMBE, ELTBDETSTIEMBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "HERH" Then
                UpdEstHERH(ELTBSTIEMBE, ELTBDETSTIEMBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "HEPROG" Then
                InsPrograma(ELTBSTIEMBE, ELTBDETSTIEMBE, ELMVLOGSBE, cn, sqlTrans, dg)
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
                If flagAccion <> "HE" And flagAccion <> "HEJP" And flagAccion <> "HERH" And flagAccion <> "HEPROG" And
                    flagAccion <> "MJF" And flagAccion <> "MRH" Then
                    cn.Dispose()
                End If

            End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Public Function SelectActivos(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DETALLE_DOCU_PD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectActivos1(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DETALLE_DOCU_PD_3", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAll(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBSTIEM_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectBonoPro(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAllHEJ(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBSTIEM_SELECTALLHEJ", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAllHEJP(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBSTIEM_SELECTALLHEJP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAllHERH(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBSTIEM_SELECTALLHERH", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
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

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DETALLE_DOCU_PD_A", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", sFecAño),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", sFecMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRow(ByVal sCOD As String, ByVal sSER As String, ByVal sNRO As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBSTIEM_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", sCOD),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER", sSER),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO", sNRO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function LastCodigo(ByVal sCode As String, ByVal sSer As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBSTIEM_SELECTNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sCode", sCode),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@sSer", sSer)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)

    End Function
    Public Function lineastiem(ByVal sSer As String, ByVal sNum As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBSTIEM_SELECTLINEA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sSer),
                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sNum)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)

    End Function
    Public Function SelectRow1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PRODUCCION_SelectRow", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
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
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBSTIEM_SELECTNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode)),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sSer))})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero
    End Function

    Public Function SelPermiso(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBUSERPERMISO_EST", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode))})
            While dr.Read
                sNumero = dr.GetString(0)
            End While
        End Using
        Return sNumero
    End Function
    Public Function OK_CCO_COD(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBSTIEM_SELUSRCCO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Public Function VerificarFeriado(ByVal fecha As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_VERIFICAR_FERIADO", {New Oracle.ManagedDataAccess.Client.OracleParameter("FECHA", fecha)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
