Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class PERDAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String
    Private Sub InsertRow(ByVal PERBE As PERBE, ByVal ASI_CPTOBE As ASI_CPTOBE, ByVal DERECHOHABBE As DERECHOHABBE,
                          ByVal DHAB_DIRBE As DHAB_DIRBE, ByVal dgvcpto As DataGridView, ByVal dgvdep As DataGridView,
                          ByVal dgvdirdep As DataGridView, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PER_INSROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@COD", OracleDbType.Varchar2).Value = PERBE.COD
        cmd.Parameters.Add("@APE1", OracleDbType.Varchar2).Value = PERBE.APE1
        cmd.Parameters.Add("@APE2", OracleDbType.Varchar2).Value = PERBE.APE2
        cmd.Parameters.Add("@NOM1", OracleDbType.Varchar2).Value = PERBE.NOM1
        cmd.Parameters.Add("@NOM2", OracleDbType.Varchar2).Value = PERBE.NOM2
        cmd.Parameters.Add("@ID_NRO", OracleDbType.Varchar2).Value = PERBE.ID_NRO
        cmd.Parameters.Add("@LE", OracleDbType.Varchar2).Value = PERBE.LE
        cmd.Parameters.Add("@LM", OracleDbType.Varchar2).Value = PERBE.LM
        cmd.Parameters.Add("@X_SEXO", OracleDbType.Varchar2).Value = PERBE.X_SEXO
        cmd.Parameters.Add("@NN", OracleDbType.Varchar2).Value = PERBE.NN
        cmd.Parameters.Add("@X_ESTCIV", OracleDbType.Varchar2).Value = PERBE.X_ESTCIV
        cmd.Parameters.Add("@NAC", OracleDbType.Varchar2).Value = PERBE.NAC
        cmd.Parameters.Add("@NRO_HIJO", OracleDbType.Int32).Value = PERBE.NRO_HIJO
        cmd.Parameters.Add("@COD_EDUCATIVO", OracleDbType.Varchar2).Value = PERBE.COD_EDUCATIVO
        cmd.Parameters.Add("@FEC_NAC", OracleDbType.Date).Value = PERBE.FEC_NAC
        cmd.Parameters.Add("@FEC_EMIDNI", OracleDbType.Date).Value = PERBE.FECEMIDNI
        cmd.Parameters.Add("@UBIGEO_NAC", OracleDbType.Varchar2).Value = PERBE.UBIGEO_NAC
        cmd.Parameters.Add("@DIREC", OracleDbType.Varchar2).Value = PERBE.DIREC
        cmd.Parameters.Add("@TELF", OracleDbType.Varchar2).Value = PERBE.TELF
        cmd.Parameters.Add("@UBIGEO", OracleDbType.Varchar2).Value = PERBE.UBIGEO
        cmd.Parameters.Add("@EMAIL", OracleDbType.Varchar2).Value = PERBE.EMAIL
        cmd.Parameters.Add("@X_CHE", OracleDbType.Varchar2).Value = PERBE.X_CHE
        cmd.Parameters.Add("@SIT_COD", OracleDbType.Varchar2).Value = PERBE.SIT_COD
        cmd.Parameters.Add("@CARGO_COD", OracleDbType.Int32).Value = PERBE.CARGO_COD
        cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = PERBE.CCO_COD
        cmd.Parameters.Add("@X_SET", OracleDbType.Varchar2).Value = PERBE.X_SET
        cmd.Parameters.Add("@T_TRAB", OracleDbType.Varchar2).Value = PERBE.T_TRAB
        cmd.Parameters.Add("@CARGO_CODIGO", OracleDbType.Varchar2).Value = PERBE.CARGO_CODIGO
        cmd.Parameters.Add("@CARGO", OracleDbType.Varchar2).Value = PERBE.CARGO
        cmd.Parameters.Add("@LINEA_COD", OracleDbType.Varchar2).Value = PERBE.LINEA_COD
        cmd.Parameters.Add("@TALLA", OracleDbType.Varchar2).Value = PERBE.TALLA
        cmd.Parameters.Add("@TALLA1", OracleDbType.Varchar2).Value = PERBE.TALLA1
        cmd.Parameters.Add("@FEC_ING", OracleDbType.Date).Value = PERBE.FEC_ING
        cmd.Parameters.Add("@FEC_ICESE", OracleDbType.Date).Value = PERBE.FEC_ICESE
        cmd.Parameters.Add("@MOTI_BAJA_COD", OracleDbType.Varchar2).Value = PERBE.MOTI_BAJA_COD
        cmd.Parameters.Add("@CONTRATO_PRDO", OracleDbType.Varchar2).Value = PERBE.CONTRATO_PRDO
        cmd.Parameters.Add("@AFP_COD", OracleDbType.Varchar2).Value = PERBE.AFP_COD
        cmd.Parameters.Add("@NRO_AFP", OracleDbType.Varchar2).Value = PERBE.NRO_AFP
        cmd.Parameters.Add("@IPSS", OracleDbType.Varchar2).Value = PERBE.IPSS
        cmd.Parameters.Add("@GRA_MES", OracleDbType.Int32).Value = PERBE.GRA_MES
        cmd.Parameters.Add("@X_COMISION", OracleDbType.Varchar2).Value = PERBE.X_COMISION
        cmd.Parameters.Add("@CTA_DOLAR", OracleDbType.Varchar2).Value = PERBE.CTA_DOLAR
        cmd.Parameters.Add("@X_VENDE", OracleDbType.Varchar2).Value = PERBE.X_VENDE
        cmd.Parameters.Add("@T_GRA", OracleDbType.Varchar2).Value = PERBE.T_GRA
        cmd.Parameters.Add("@NRO_CTA_BANCO", OracleDbType.Varchar2).Value = PERBE.NRO_CTA_BANCO
        cmd.Parameters.Add("@BCO_CTS_COD", OracleDbType.Varchar2).Value = PERBE.BCO_CTS_COD
        cmd.Parameters.Add("@NRO_CTA_CTS", OracleDbType.Varchar2).Value = PERBE.NRO_CTA_CTS
        cmd.Parameters.Add("@OBS", OracleDbType.Varchar2).Value = PERBE.OBS
        cmd.Parameters.Add("@MES_TIEMPO_SERV", OracleDbType.Int32).Value = PERBE.MES_TIEMPO_SERV
        cmd.Parameters.Add("@T_REM", OracleDbType.Varchar2).Value = PERBE.T_REM
        cmd.Parameters.Add("@TOT_DIA", OracleDbType.Varchar2).Value = PERBE.TOT_DIA
        cmd.Parameters.Add("@TOT_HOR", OracleDbType.Varchar2).Value = PERBE.TOT_HOR
        cmd.Parameters.Add("@TOT_MIN", OracleDbType.Varchar2).Value = PERBE.TOT_MIN
        cmd.Parameters.Add("@TARDE", OracleDbType.Varchar2).Value = PERBE.TARDE
        cmd.Parameters.Add("@pPER_ANHO", OracleDbType.Varchar2).Value = PERBE.PER_ANHO
        cmd.Parameters.Add("@pPER_QUINTA", OracleDbType.Int32).Value = PERBE.PER_QUINTA
        cmd.Parameters.Add("@FEC_AFP", OracleDbType.Date).Value = PERBE.FEC_AFP
        cmd.Parameters.Add("@CCO_COD_NUEVO", OracleDbType.Varchar2).Value = PERBE.CCO_COD_NUEVO
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'Dim codigo, monto As String
        For Each row As DataGridViewRow In dgvcpto.Rows
            ASI_CPTOBE.per_cod = IIf(IsDBNull(RTrim(row.Cells("DNI").Value)), "", RTrim(row.Cells("DNI").Value))
            ASI_CPTOBE.cpto_cod = IIf(IsDBNull(RTrim(row.Cells("CODIGO").Value)), "", RTrim(row.Cells("CODIGO").Value))
            ASI_CPTOBE.monto = IIf(IsDBNull(RTrim(row.Cells("MONTO").Value)), 0, RTrim(row.Cells("MONTO").Value))
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PERASI_CPTO_INSROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@COD", OracleDbType.Varchar2).Value = PERBE.COD
            cmd.Parameters.Add("@PER_COD", OracleDbType.Varchar2).Value = ASI_CPTOBE.cpto_cod
            cmd.Parameters.Add("@PER_COD", OracleDbType.Double).Value = ASI_CPTOBE.monto
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
        For Each row As DataGridViewRow In dgvdep.Rows
            DERECHOHABBE.COD = IIf(IsDBNull(RTrim(row.Cells("COD").Value)), "", RTrim(row.Cells("COD").Value))
            DERECHOHABBE.APE1 = IIf(IsDBNull(RTrim(row.Cells("APE1").Value)), "", RTrim(row.Cells("APE1").Value))
            DERECHOHABBE.APE2 = IIf(IsDBNull(RTrim(row.Cells("APE2").Value)), "", RTrim(row.Cells("APE2").Value))
            DERECHOHABBE.NOM1 = IIf(IsDBNull(RTrim(row.Cells("NOM1").Value)), "", RTrim(row.Cells("NOM1").Value))
            DERECHOHABBE.NOM2 = IIf(IsDBNull(RTrim(row.Cells("NOM2").Value)), "", RTrim(row.Cells("NOM2").Value))
            If IIf(IsDBNull(RTrim(row.Cells("FEC_NAC").Value)), "", RTrim(row.Cells("FEC_NAC").Value)) <> "" Then
                DERECHOHABBE.FEC_NAC = IIf(IsDBNull(RTrim(row.Cells("FEC_NAC").Value)), "", RTrim(row.Cells("FEC_NAC").Value))
            End If
            DERECHOHABBE.X_TDOC = IIf(IsDBNull(RTrim(row.Cells("X_TDOC").Value)), "", RTrim(row.Cells("X_TDOC").Value))
            DERECHOHABBE.LE = IIf(IsDBNull(RTrim(row.Cells("LE").Value)), "", RTrim(row.Cells("LE").Value))
            DERECHOHABBE.VINCULO_COD = IIf(IsDBNull(RTrim(row.Cells("VINCULO_COD").Value)), "", RTrim(row.Cells("VINCULO_COD").Value))
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PERDERECHOHAB_INSROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@COD", OracleDbType.Varchar2).Value = DERECHOHABBE.COD
            cmd.Parameters.Add("@APE1", OracleDbType.Varchar2).Value = DERECHOHABBE.APE1
            cmd.Parameters.Add("@APE2", OracleDbType.Varchar2).Value = DERECHOHABBE.APE2
            cmd.Parameters.Add("@NOM1", OracleDbType.Varchar2).Value = DERECHOHABBE.NOM1
            cmd.Parameters.Add("@NOM2", OracleDbType.Varchar2).Value = DERECHOHABBE.NOM2
            cmd.Parameters.Add("@FEC_NAC", OracleDbType.Date).Value = DERECHOHABBE.FEC_NAC
            cmd.Parameters.Add("@X_TDOC", OracleDbType.Varchar2).Value = DERECHOHABBE.X_TDOC
            cmd.Parameters.Add("@LE", OracleDbType.Varchar2).Value = DERECHOHABBE.LE
            cmd.Parameters.Add("@VINCULO_COD", OracleDbType.Varchar2).Value = DERECHOHABBE.VINCULO_COD
            cmd.Parameters.Add("@PER_COD", OracleDbType.Varchar2).Value = PERBE.COD
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
        For Each row As DataGridViewRow In dgvdirdep.Rows
            DHAB_DIRBE.DIR_COD = IIf(IsDBNull(RTrim(row.Cells("DIR_COD").Value)), "", RTrim(row.Cells("DIR_COD").Value))
            DHAB_DIRBE.TIP_VIA_COD = IIf(IsDBNull(RTrim(row.Cells("TIP_VIA_COD").Value)), "", RTrim(row.Cells("TIP_VIA_COD").Value))
            DHAB_DIRBE.NRO_DPTO = IIf(IsDBNull(RTrim(row.Cells("NRO_DPTO").Value)), "", RTrim(row.Cells("NRO_DPTO").Value))
            DHAB_DIRBE.INT_VIA = IIf(IsDBNull(RTrim(row.Cells("INT_VIA").Value)), "", RTrim(row.Cells("INT_VIA").Value))
            DHAB_DIRBE.MZA_VIA = IIf(IsDBNull(RTrim(row.Cells("MZA_VIA").Value)), "", RTrim(row.Cells("MZA_VIA").Value))
            DHAB_DIRBE.LOTE_VIA = IIf(IsDBNull(RTrim(row.Cells("LOTE_VIA").Value)), "", RTrim(row.Cells("LOTE_VIA").Value))
            DHAB_DIRBE.KILOM_VIA = IIf(IsDBNull(RTrim(row.Cells("KILOM_VIA").Value)), "", RTrim(row.Cells("KILOM_VIA").Value))
            DHAB_DIRBE.BLOCK_VIA = IIf(IsDBNull(RTrim(row.Cells("BLOCK_VIA").Value)), "", RTrim(row.Cells("BLOCK_VIA").Value))
            DHAB_DIRBE.ETAPA_VIA = IIf(IsDBNull(RTrim(row.Cells("ETAPA_VIA").Value)), "", RTrim(row.Cells("ETAPA_VIA").Value))
            DHAB_DIRBE.TIP_ZONA_COD = IIf(IsDBNull(RTrim(row.Cells("TIP_ZONA_COD").Value)), "", RTrim(row.Cells("TIP_ZONA_COD").Value))
            DHAB_DIRBE.REF_ZONA = IIf(IsDBNull(RTrim(row.Cells("REF_ZONA").Value)), "", RTrim(row.Cells("REF_ZONA").Value))
            DHAB_DIRBE.UBIGEO = IIf(IsDBNull(RTrim(row.Cells("UBIGEO").Value)), "", RTrim(row.Cells("UBIGEO").Value))
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PERDHAB_DIR_INSROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@DIR_COD", OracleDbType.Varchar2).Value = DHAB_DIRBE.DIR_COD
            cmd.Parameters.Add("@TIP_VIA_COD", OracleDbType.Varchar2).Value = DHAB_DIRBE.TIP_VIA_COD
            cmd.Parameters.Add("@NRO_DPTO", OracleDbType.Varchar2).Value = DHAB_DIRBE.NRO_DPTO
            cmd.Parameters.Add("@INT_VIA", OracleDbType.Varchar2).Value = DHAB_DIRBE.INT_VIA
            cmd.Parameters.Add("@MZA_VIA", OracleDbType.Varchar2).Value = DHAB_DIRBE.MZA_VIA
            cmd.Parameters.Add("@LOTE_VIA", OracleDbType.Varchar2).Value = DHAB_DIRBE.LOTE_VIA
            cmd.Parameters.Add("@KILOM_VIA", OracleDbType.Varchar2).Value = DHAB_DIRBE.KILOM_VIA
            cmd.Parameters.Add("@BLOCK_VIA", OracleDbType.Varchar2).Value = DHAB_DIRBE.BLOCK_VIA
            cmd.Parameters.Add("@ETAPA_VIA", OracleDbType.Varchar2).Value = DHAB_DIRBE.ETAPA_VIA
            cmd.Parameters.Add("@TIP_ZONA_COD", OracleDbType.Varchar2).Value = DHAB_DIRBE.TIP_ZONA_COD
            cmd.Parameters.Add("@REF_ZONA", OracleDbType.Varchar2).Value = DHAB_DIRBE.REF_ZONA
            cmd.Parameters.Add("@UBIGEO", OracleDbType.Varchar2).Value = DHAB_DIRBE.UBIGEO
            cmd.Parameters.Add("@PER_COD", OracleDbType.Varchar2).Value = DHAB_DIRBE.PER_COD
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
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Personal: " + PERBE.COD + "-" + PERBE.APE1 + " " + PERBE.APE2 + " " + PERBE.NOM1 + " " + PERBE.NOM2
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    'Metodo para Modificar 
    Private Sub UpdateRow(ByVal PERBE As PERBE, ByVal ASI_CPTOBE As ASI_CPTOBE, ByVal DERECHOHABBE As DERECHOHABBE,
                          ByVal DHAB_DIRBE As DHAB_DIRBE, ByVal dgvcpto As DataGridView, ByVal dgvdep As DataGridView,
                          ByVal dgvdirdep As DataGridView, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PER_UPDROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@COD", OracleDbType.Varchar2).Value = PERBE.COD
        cmd.Parameters.Add("@APE1", OracleDbType.Varchar2).Value = PERBE.APE1
        cmd.Parameters.Add("@APE2", OracleDbType.Varchar2).Value = PERBE.APE2
        cmd.Parameters.Add("@NOM1", OracleDbType.Varchar2).Value = PERBE.NOM1
        cmd.Parameters.Add("@NOM2", OracleDbType.Varchar2).Value = PERBE.NOM2
        cmd.Parameters.Add("@ID_NRO", OracleDbType.Varchar2).Value = PERBE.ID_NRO
        cmd.Parameters.Add("@LE", OracleDbType.Varchar2).Value = PERBE.LE
        cmd.Parameters.Add("@LM", OracleDbType.Varchar2).Value = PERBE.LM
        cmd.Parameters.Add("@X_SEXO", OracleDbType.Varchar2).Value = PERBE.X_SEXO
        cmd.Parameters.Add("@NN", OracleDbType.Varchar2).Value = PERBE.NN
        cmd.Parameters.Add("@X_ESTCIV", OracleDbType.Varchar2).Value = PERBE.X_ESTCIV
        cmd.Parameters.Add("@NAC", OracleDbType.Varchar2).Value = PERBE.NAC
        cmd.Parameters.Add("@NRO_HIJO", OracleDbType.Int32).Value = PERBE.NRO_HIJO
        cmd.Parameters.Add("@COD_EDUCATIVO", OracleDbType.Varchar2).Value = PERBE.COD_EDUCATIVO
        cmd.Parameters.Add("@FEC_NAC", OracleDbType.Date).Value = PERBE.FEC_NAC
        cmd.Parameters.Add("@FEC_EMIDNI", OracleDbType.Date).Value = PERBE.FECEMIDNI
        cmd.Parameters.Add("@UBIGEO_NAC", OracleDbType.Varchar2).Value = PERBE.UBIGEO_NAC
        cmd.Parameters.Add("@DIREC", OracleDbType.Varchar2).Value = PERBE.DIREC
        cmd.Parameters.Add("@TELF", OracleDbType.Varchar2).Value = PERBE.TELF
        cmd.Parameters.Add("@UBIGEO", OracleDbType.Varchar2).Value = PERBE.UBIGEO
        cmd.Parameters.Add("@EMAIL", OracleDbType.Varchar2).Value = PERBE.EMAIL
        cmd.Parameters.Add("@X_CHE", OracleDbType.Varchar2).Value = PERBE.X_CHE
        cmd.Parameters.Add("@SIT_COD", OracleDbType.Varchar2).Value = PERBE.SIT_COD
        cmd.Parameters.Add("@CARGO_COD", OracleDbType.Int32).Value = PERBE.CARGO_COD
        cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = PERBE.CCO_COD
        cmd.Parameters.Add("@X_SET", OracleDbType.Varchar2).Value = PERBE.X_SET
        cmd.Parameters.Add("@T_TRAB", OracleDbType.Varchar2).Value = PERBE.T_TRAB
        cmd.Parameters.Add("@CARGO_CODIGO", OracleDbType.Varchar2).Value = PERBE.CARGO_CODIGO
        cmd.Parameters.Add("@CARGO", OracleDbType.Varchar2).Value = PERBE.CARGO
        cmd.Parameters.Add("@LINEA_COD", OracleDbType.Varchar2).Value = PERBE.LINEA_COD
        cmd.Parameters.Add("@TALLA", OracleDbType.Varchar2).Value = PERBE.TALLA
        cmd.Parameters.Add("@TALLA1", OracleDbType.Varchar2).Value = PERBE.TALLA1
        cmd.Parameters.Add("@FEC_ING", OracleDbType.Date).Value = PERBE.FEC_ING
        cmd.Parameters.Add("@FEC_ICESE", OracleDbType.Date).Value = PERBE.FEC_ICESE
        cmd.Parameters.Add("@MOTI_BAJA_COD", OracleDbType.Varchar2).Value = PERBE.MOTI_BAJA_COD
        cmd.Parameters.Add("@CONTRATO_PRDO", OracleDbType.Varchar2).Value = PERBE.CONTRATO_PRDO
        cmd.Parameters.Add("@AFP_COD", OracleDbType.Varchar2).Value = PERBE.AFP_COD
        cmd.Parameters.Add("@NRO_AFP", OracleDbType.Varchar2).Value = PERBE.NRO_AFP
        cmd.Parameters.Add("@IPSS", OracleDbType.Varchar2).Value = PERBE.IPSS
        cmd.Parameters.Add("@GRA_MES", OracleDbType.Int32).Value = PERBE.GRA_MES
        cmd.Parameters.Add("@X_COMISION", OracleDbType.Varchar2).Value = PERBE.X_COMISION
        cmd.Parameters.Add("@CTA_DOLAR", OracleDbType.Varchar2).Value = PERBE.CTA_DOLAR
        cmd.Parameters.Add("@X_VENDE", OracleDbType.Varchar2).Value = PERBE.X_VENDE
        cmd.Parameters.Add("@T_GRA", OracleDbType.Varchar2).Value = PERBE.T_GRA
        cmd.Parameters.Add("@NRO_CTA_BANCO", OracleDbType.Varchar2).Value = PERBE.NRO_CTA_BANCO
        cmd.Parameters.Add("@BCO_CTS_COD", OracleDbType.Varchar2).Value = PERBE.BCO_CTS_COD
        cmd.Parameters.Add("@NRO_CTA_CTS", OracleDbType.Varchar2).Value = PERBE.NRO_CTA_CTS
        cmd.Parameters.Add("@OBS", OracleDbType.Varchar2).Value = PERBE.OBS
        cmd.Parameters.Add("@MES_TIEMPO_SERV", OracleDbType.Int32).Value = PERBE.MES_TIEMPO_SERV
        cmd.Parameters.Add("@T_REM", OracleDbType.Varchar2).Value = PERBE.T_REM
        cmd.Parameters.Add("@TOT_DIA", OracleDbType.Varchar2).Value = PERBE.TOT_DIA
        cmd.Parameters.Add("@TOT_HOR", OracleDbType.Varchar2).Value = PERBE.TOT_HOR
        cmd.Parameters.Add("@TOT_MIN", OracleDbType.Varchar2).Value = PERBE.TOT_MIN
        cmd.Parameters.Add("@TARDE", OracleDbType.Varchar2).Value = PERBE.TARDE
        cmd.Parameters.Add("@pPER_ANHO", OracleDbType.Varchar2).Value = PERBE.PER_ANHO
        cmd.Parameters.Add("@pPER_QUINTA", OracleDbType.Int32).Value = PERBE.PER_QUINTA
        cmd.Parameters.Add("@FEC_AFP", OracleDbType.Date).Value = PERBE.FEC_AFP
        cmd.Parameters.Add("@CCO_COD_NUEVO", OracleDbType.Varchar2).Value = PERBE.CCO_COD_NUEVO
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PER_DEL_CPTODERDHAB"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@COD", OracleDbType.Varchar2).Value = PERBE.COD
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'Dim codigo, monto As String
        For Each row As DataGridViewRow In dgvcpto.Rows
            ASI_CPTOBE.per_cod = IIf(IsDBNull(RTrim(row.Cells("Dni").Value)), "", RTrim(row.Cells("Dni").Value))
            ASI_CPTOBE.cpto_cod = IIf(IsDBNull(RTrim(row.Cells("CODIGO").Value)), "", RTrim(row.Cells("CODIGO").Value))
            ASI_CPTOBE.monto = IIf(IsDBNull(RTrim(row.Cells("MONTO").Value)), 0, RTrim(row.Cells("MONTO").Value))
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PERASI_CPTO_INSROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@COD", OracleDbType.Varchar2).Value = PERBE.COD
            cmd.Parameters.Add("@PER_COD", OracleDbType.Varchar2).Value = ASI_CPTOBE.cpto_cod
            cmd.Parameters.Add("@PER_COD", OracleDbType.Double).Value = ASI_CPTOBE.monto
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
        For Each row As DataGridViewRow In dgvdep.Rows
            DERECHOHABBE.COD = IIf(IsDBNull(RTrim(row.Cells("COD").Value)), "", RTrim(row.Cells("COD").Value))
            DERECHOHABBE.APE1 = IIf(IsDBNull(RTrim(row.Cells("APE1").Value)), "", RTrim(row.Cells("APE1").Value))
            DERECHOHABBE.APE2 = IIf(IsDBNull(RTrim(row.Cells("APE2").Value)), "", RTrim(row.Cells("APE2").Value))
            DERECHOHABBE.NOM1 = IIf(IsDBNull(RTrim(row.Cells("NOM1").Value)), "", RTrim(row.Cells("NOM1").Value))
            DERECHOHABBE.NOM2 = IIf(IsDBNull(RTrim(row.Cells("NOM2").Value)), "", RTrim(row.Cells("NOM2").Value))
            If IIf(IsDBNull(RTrim(row.Cells("FEC_NAC").Value)), "", RTrim(row.Cells("FEC_NAC").Value)) <> "" Then
                DERECHOHABBE.FEC_NAC = IIf(IsDBNull(RTrim(row.Cells("FEC_NAC").Value)), "", RTrim(row.Cells("FEC_NAC").Value))
            End If
            DERECHOHABBE.X_TDOC = IIf(IsDBNull(RTrim(row.Cells("X_TDOC").Value)), "", RTrim(row.Cells("X_TDOC").Value))
            DERECHOHABBE.LE = IIf(IsDBNull(RTrim(row.Cells("LE").Value)), "", RTrim(row.Cells("LE").Value))
            DERECHOHABBE.VINCULO_COD = IIf(IsDBNull(RTrim(row.Cells("VINCULO_COD").Value)), "", RTrim(row.Cells("VINCULO_COD").Value))
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PERDERECHOHAB_INSROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@COD", OracleDbType.Varchar2).Value = DERECHOHABBE.COD
            cmd.Parameters.Add("@APE1", OracleDbType.Varchar2).Value = DERECHOHABBE.APE1
            cmd.Parameters.Add("@APE2", OracleDbType.Varchar2).Value = DERECHOHABBE.APE2
            cmd.Parameters.Add("@NOM1", OracleDbType.Varchar2).Value = DERECHOHABBE.NOM1
            cmd.Parameters.Add("@NOM2", OracleDbType.Varchar2).Value = DERECHOHABBE.NOM2
            cmd.Parameters.Add("@FEC_NAC", OracleDbType.Date).Value = DERECHOHABBE.FEC_NAC
            cmd.Parameters.Add("@X_TDOC", OracleDbType.Varchar2).Value = DERECHOHABBE.X_TDOC
            cmd.Parameters.Add("@LE", OracleDbType.Varchar2).Value = DERECHOHABBE.LE
            cmd.Parameters.Add("@VINCULO_COD", OracleDbType.Varchar2).Value = DERECHOHABBE.VINCULO_COD
            cmd.Parameters.Add("@PER_COD", OracleDbType.Varchar2).Value = PERBE.COD
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
        For Each row As DataGridViewRow In dgvdirdep.Rows
            DHAB_DIRBE.DIR_COD = IIf(IsDBNull(RTrim(row.Cells("DIR_COD").Value)), "", RTrim(row.Cells("DIR_COD").Value))
            DHAB_DIRBE.TIP_VIA_COD = IIf(IsDBNull(RTrim(row.Cells("TIP_VIA_COD").Value)), "", RTrim(row.Cells("TIP_VIA_COD").Value))
            DHAB_DIRBE.NRO_DPTO = IIf(IsDBNull(RTrim(row.Cells("NRO_DPTO").Value)), "", RTrim(row.Cells("NRO_DPTO").Value))
            DHAB_DIRBE.INT_VIA = IIf(IsDBNull(RTrim(row.Cells("INT_VIA").Value)), "", RTrim(row.Cells("INT_VIA").Value))
            DHAB_DIRBE.MZA_VIA = IIf(IsDBNull(RTrim(row.Cells("MZA_VIA").Value)), "", RTrim(row.Cells("MZA_VIA").Value))
            DHAB_DIRBE.LOTE_VIA = IIf(IsDBNull(RTrim(row.Cells("LOTE_VIA").Value)), "", RTrim(row.Cells("LOTE_VIA").Value))
            DHAB_DIRBE.KILOM_VIA = IIf(IsDBNull(RTrim(row.Cells("KILOM_VIA").Value)), "", RTrim(row.Cells("KILOM_VIA").Value))
            DHAB_DIRBE.BLOCK_VIA = IIf(IsDBNull(RTrim(row.Cells("BLOCK_VIA").Value)), "", RTrim(row.Cells("BLOCK_VIA").Value))
            DHAB_DIRBE.ETAPA_VIA = IIf(IsDBNull(RTrim(row.Cells("ETAPA_VIA").Value)), "", RTrim(row.Cells("ETAPA_VIA").Value))
            DHAB_DIRBE.TIP_ZONA_COD = IIf(IsDBNull(RTrim(row.Cells("TIP_ZONA_COD").Value)), "", RTrim(row.Cells("TIP_ZONA_COD").Value))
            DHAB_DIRBE.REF_ZONA = IIf(IsDBNull(RTrim(row.Cells("REF_ZONA").Value)), "", RTrim(row.Cells("REF_ZONA").Value))
            DHAB_DIRBE.UBIGEO = IIf(IsDBNull(RTrim(row.Cells("UBIGEO").Value)), "", RTrim(row.Cells("UBIGEO").Value))
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PERDHAB_DIR_INSROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@DIR_COD", OracleDbType.Varchar2).Value = DHAB_DIRBE.DIR_COD
            cmd.Parameters.Add("@TIP_VIA_COD", OracleDbType.Varchar2).Value = DHAB_DIRBE.TIP_VIA_COD
            cmd.Parameters.Add("@NRO_DPTO", OracleDbType.Varchar2).Value = DHAB_DIRBE.NRO_DPTO
            cmd.Parameters.Add("@INT_VIA", OracleDbType.Varchar2).Value = DHAB_DIRBE.INT_VIA
            cmd.Parameters.Add("@MZA_VIA", OracleDbType.Varchar2).Value = DHAB_DIRBE.MZA_VIA
            cmd.Parameters.Add("@LOTE_VIA", OracleDbType.Varchar2).Value = DHAB_DIRBE.LOTE_VIA
            cmd.Parameters.Add("@KILOM_VIA", OracleDbType.Varchar2).Value = DHAB_DIRBE.KILOM_VIA
            cmd.Parameters.Add("@BLOCK_VIA", OracleDbType.Varchar2).Value = DHAB_DIRBE.BLOCK_VIA
            cmd.Parameters.Add("@ETAPA_VIA", OracleDbType.Varchar2).Value = DHAB_DIRBE.ETAPA_VIA
            cmd.Parameters.Add("@TIP_ZONA_COD", OracleDbType.Varchar2).Value = DHAB_DIRBE.TIP_ZONA_COD
            cmd.Parameters.Add("@REF_ZONA", OracleDbType.Varchar2).Value = DHAB_DIRBE.REF_ZONA
            cmd.Parameters.Add("@UBIGEO", OracleDbType.Varchar2).Value = DHAB_DIRBE.UBIGEO
            cmd.Parameters.Add("@PER_COD", OracleDbType.Varchar2).Value = DHAB_DIRBE.PER_COD
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
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el Personal: " + PERBE.COD + "-" + PERBE.APE1 + " " + PERBE.APE2 + " " + PERBE.NOM1 + " " + PERBE.NOM2
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub UpdateRow1(ByVal PERBE As PERBE, ByVal ASI_CPTOBE As ASI_CPTOBE, ByVal DERECHOHABBE As DERECHOHABBE,
                          ByVal DHAB_DIRBE As DHAB_DIRBE, ByVal dgvcpto As DataGridView, ByVal dgvdep As DataGridView,
                          ByVal dgvdirdep As DataGridView, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PER_UPDROW1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@COD", OracleDbType.Varchar2).Value = PERBE.COD
        cmd.Parameters.Add("@APE1", OracleDbType.Varchar2).Value = PERBE.APE1
        cmd.Parameters.Add("@APE2", OracleDbType.Varchar2).Value = PERBE.APE2
        cmd.Parameters.Add("@NOM1", OracleDbType.Varchar2).Value = PERBE.NOM1
        cmd.Parameters.Add("@NOM2", OracleDbType.Varchar2).Value = PERBE.NOM2
        cmd.Parameters.Add("@ID_NRO", OracleDbType.Varchar2).Value = PERBE.ID_NRO
        cmd.Parameters.Add("@LE", OracleDbType.Varchar2).Value = PERBE.LE
        cmd.Parameters.Add("@LM", OracleDbType.Varchar2).Value = PERBE.LM
        cmd.Parameters.Add("@X_SEXO", OracleDbType.Varchar2).Value = PERBE.X_SEXO
        cmd.Parameters.Add("@NN", OracleDbType.Varchar2).Value = PERBE.NN
        cmd.Parameters.Add("@X_ESTCIV", OracleDbType.Varchar2).Value = PERBE.X_ESTCIV
        cmd.Parameters.Add("@NAC", OracleDbType.Varchar2).Value = PERBE.NAC
        cmd.Parameters.Add("@NRO_HIJO", OracleDbType.Int32).Value = PERBE.NRO_HIJO
        cmd.Parameters.Add("@COD_EDUCATIVO", OracleDbType.Varchar2).Value = PERBE.COD_EDUCATIVO
        cmd.Parameters.Add("@FEC_NAC", OracleDbType.Date).Value = PERBE.FEC_NAC
        cmd.Parameters.Add("@FEC_EMIDNI", OracleDbType.Date).Value = PERBE.FECEMIDNI
        cmd.Parameters.Add("@UBIGEO_NAC", OracleDbType.Varchar2).Value = PERBE.UBIGEO_NAC
        cmd.Parameters.Add("@DIREC", OracleDbType.Varchar2).Value = PERBE.DIREC
        cmd.Parameters.Add("@TELF", OracleDbType.Varchar2).Value = PERBE.TELF
        cmd.Parameters.Add("@UBIGEO", OracleDbType.Varchar2).Value = PERBE.UBIGEO
        cmd.Parameters.Add("@EMAIL", OracleDbType.Varchar2).Value = PERBE.EMAIL
        cmd.Parameters.Add("@X_CHE", OracleDbType.Varchar2).Value = PERBE.X_CHE
        cmd.Parameters.Add("@SIT_COD", OracleDbType.Varchar2).Value = PERBE.SIT_COD
        cmd.Parameters.Add("@CARGO_COD", OracleDbType.Int32).Value = PERBE.CARGO_COD
        cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = PERBE.CCO_COD
        cmd.Parameters.Add("@X_SET", OracleDbType.Varchar2).Value = PERBE.X_SET
        cmd.Parameters.Add("@T_TRAB", OracleDbType.Varchar2).Value = PERBE.T_TRAB
        cmd.Parameters.Add("@CARGO_CODIGO", OracleDbType.Varchar2).Value = PERBE.CARGO_CODIGO
        cmd.Parameters.Add("@CARGO", OracleDbType.Varchar2).Value = PERBE.CARGO
        cmd.Parameters.Add("@LINEA_COD", OracleDbType.Varchar2).Value = PERBE.LINEA_COD
        cmd.Parameters.Add("@TALLA", OracleDbType.Varchar2).Value = PERBE.TALLA
        cmd.Parameters.Add("@TALLA1", OracleDbType.Varchar2).Value = PERBE.TALLA1
        cmd.Parameters.Add("@FEC_ING", OracleDbType.Date).Value = PERBE.FEC_ING
        cmd.Parameters.Add("@FEC_ICESE", OracleDbType.Date).Value = PERBE.FECC_ICESE  ''
        cmd.Parameters.Add("@MOTI_BAJA_COD", OracleDbType.Varchar2).Value = PERBE.MOTI_BAJA_COD
        cmd.Parameters.Add("@CONTRATO_PRDO", OracleDbType.Varchar2).Value = PERBE.CONTRATO_PRDO
        cmd.Parameters.Add("@AFP_COD", OracleDbType.Varchar2).Value = PERBE.AFP_COD
        cmd.Parameters.Add("@NRO_AFP", OracleDbType.Varchar2).Value = PERBE.NRO_AFP
        cmd.Parameters.Add("@IPSS", OracleDbType.Varchar2).Value = PERBE.IPSS
        cmd.Parameters.Add("@GRA_MES", OracleDbType.Int32).Value = PERBE.GRA_MES
        cmd.Parameters.Add("@X_COMISION", OracleDbType.Varchar2).Value = PERBE.X_COMISION
        cmd.Parameters.Add("@CTA_DOLAR", OracleDbType.Varchar2).Value = PERBE.CTA_DOLAR
        cmd.Parameters.Add("@X_VENDE", OracleDbType.Varchar2).Value = PERBE.X_VENDE
        cmd.Parameters.Add("@T_GRA", OracleDbType.Varchar2).Value = PERBE.T_GRA
        cmd.Parameters.Add("@NRO_CTA_BANCO", OracleDbType.Varchar2).Value = PERBE.NRO_CTA_BANCO
        cmd.Parameters.Add("@BCO_CTS_COD", OracleDbType.Varchar2).Value = PERBE.BCO_CTS_COD
        cmd.Parameters.Add("@NRO_CTA_CTS", OracleDbType.Varchar2).Value = PERBE.NRO_CTA_CTS
        cmd.Parameters.Add("@OBS", OracleDbType.Varchar2).Value = PERBE.OBS
        cmd.Parameters.Add("@MES_TIEMPO_SERV", OracleDbType.Int32).Value = PERBE.MES_TIEMPO_SERV
        cmd.Parameters.Add("@T_REM", OracleDbType.Varchar2).Value = PERBE.T_REM
        cmd.Parameters.Add("@TOT_DIA", OracleDbType.Varchar2).Value = PERBE.TOT_DIA
        cmd.Parameters.Add("@TOT_HOR", OracleDbType.Varchar2).Value = PERBE.TOT_HOR
        cmd.Parameters.Add("@TOT_MIN", OracleDbType.Varchar2).Value = PERBE.TOT_MIN
        cmd.Parameters.Add("@TARDE", OracleDbType.Varchar2).Value = PERBE.TARDE
        cmd.Parameters.Add("@CCO_COD_NUEVO", OracleDbType.Varchar2).Value = PERBE.CCO_COD_NUEVO
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PER_DEL_CPTODERDHAB"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@COD", OracleDbType.Varchar2).Value = PERBE.COD
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'Dim codigo, monto As String
        For Each row As DataGridViewRow In dgvcpto.Rows
            ASI_CPTOBE.per_cod = IIf(IsDBNull(RTrim(row.Cells("Dni").Value)), "", RTrim(row.Cells("Dni").Value))
            ASI_CPTOBE.cpto_cod = IIf(IsDBNull(RTrim(row.Cells("CODIGO").Value)), "", RTrim(row.Cells("CODIGO").Value))
            ASI_CPTOBE.monto = IIf(IsDBNull(RTrim(row.Cells("MONTO").Value)), 0, RTrim(row.Cells("MONTO").Value))
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PERASI_CPTO_INSROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@COD", OracleDbType.Varchar2).Value = PERBE.COD
            cmd.Parameters.Add("@PER_COD", OracleDbType.Varchar2).Value = ASI_CPTOBE.cpto_cod
            cmd.Parameters.Add("@PER_COD", OracleDbType.Double).Value = ASI_CPTOBE.monto
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
        For Each row As DataGridViewRow In dgvdep.Rows
            DERECHOHABBE.COD = IIf(IsDBNull(RTrim(row.Cells("COD").Value)), "", RTrim(row.Cells("COD").Value))
            DERECHOHABBE.APE1 = IIf(IsDBNull(RTrim(row.Cells("APE1").Value)), "", RTrim(row.Cells("APE1").Value))
            DERECHOHABBE.APE2 = IIf(IsDBNull(RTrim(row.Cells("APE2").Value)), "", RTrim(row.Cells("APE2").Value))
            DERECHOHABBE.NOM1 = IIf(IsDBNull(RTrim(row.Cells("NOM1").Value)), "", RTrim(row.Cells("NOM1").Value))
            DERECHOHABBE.NOM2 = IIf(IsDBNull(RTrim(row.Cells("NOM2").Value)), "", RTrim(row.Cells("NOM2").Value))
            If IIf(IsDBNull(RTrim(row.Cells("FEC_NAC").Value)), "", RTrim(row.Cells("FEC_NAC").Value)) <> "" Then
                DERECHOHABBE.FEC_NAC = IIf(IsDBNull(RTrim(row.Cells("FEC_NAC").Value)), "", RTrim(row.Cells("FEC_NAC").Value))
            End If
            DERECHOHABBE.X_TDOC = IIf(IsDBNull(RTrim(row.Cells("X_TDOC").Value)), "", RTrim(row.Cells("X_TDOC").Value))
            DERECHOHABBE.LE = IIf(IsDBNull(RTrim(row.Cells("LE").Value)), "", RTrim(row.Cells("LE").Value))
            DERECHOHABBE.VINCULO_COD = IIf(IsDBNull(RTrim(row.Cells("VINCULO_COD").Value)), "", RTrim(row.Cells("VINCULO_COD").Value))
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PERDERECHOHAB_INSROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@COD", OracleDbType.Varchar2).Value = DERECHOHABBE.COD
            cmd.Parameters.Add("@APE1", OracleDbType.Varchar2).Value = DERECHOHABBE.APE1
            cmd.Parameters.Add("@APE2", OracleDbType.Varchar2).Value = DERECHOHABBE.APE2
            cmd.Parameters.Add("@NOM1", OracleDbType.Varchar2).Value = DERECHOHABBE.NOM1
            cmd.Parameters.Add("@NOM2", OracleDbType.Varchar2).Value = DERECHOHABBE.NOM2
            cmd.Parameters.Add("@FEC_NAC", OracleDbType.Date).Value = DERECHOHABBE.FEC_NAC
            cmd.Parameters.Add("@X_TDOC", OracleDbType.Varchar2).Value = DERECHOHABBE.X_TDOC
            cmd.Parameters.Add("@LE", OracleDbType.Varchar2).Value = DERECHOHABBE.LE
            cmd.Parameters.Add("@VINCULO_COD", OracleDbType.Varchar2).Value = DERECHOHABBE.VINCULO_COD
            cmd.Parameters.Add("@PER_COD", OracleDbType.Varchar2).Value = PERBE.COD
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
        For Each row As DataGridViewRow In dgvdirdep.Rows
            DHAB_DIRBE.DIR_COD = IIf(IsDBNull(RTrim(row.Cells("DIR_COD").Value)), "", RTrim(row.Cells("DIR_COD").Value))
            DHAB_DIRBE.TIP_VIA_COD = IIf(IsDBNull(RTrim(row.Cells("TIP_VIA_COD").Value)), "", RTrim(row.Cells("TIP_VIA_COD").Value))
            DHAB_DIRBE.NRO_DPTO = IIf(IsDBNull(RTrim(row.Cells("NRO_DPTO").Value)), "", RTrim(row.Cells("NRO_DPTO").Value))
            DHAB_DIRBE.INT_VIA = IIf(IsDBNull(RTrim(row.Cells("INT_VIA").Value)), "", RTrim(row.Cells("INT_VIA").Value))
            DHAB_DIRBE.MZA_VIA = IIf(IsDBNull(RTrim(row.Cells("MZA_VIA").Value)), "", RTrim(row.Cells("MZA_VIA").Value))
            DHAB_DIRBE.LOTE_VIA = IIf(IsDBNull(RTrim(row.Cells("LOTE_VIA").Value)), "", RTrim(row.Cells("LOTE_VIA").Value))
            DHAB_DIRBE.KILOM_VIA = IIf(IsDBNull(RTrim(row.Cells("KILOM_VIA").Value)), "", RTrim(row.Cells("KILOM_VIA").Value))
            DHAB_DIRBE.BLOCK_VIA = IIf(IsDBNull(RTrim(row.Cells("BLOCK_VIA").Value)), "", RTrim(row.Cells("BLOCK_VIA").Value))
            DHAB_DIRBE.ETAPA_VIA = IIf(IsDBNull(RTrim(row.Cells("ETAPA_VIA").Value)), "", RTrim(row.Cells("ETAPA_VIA").Value))
            DHAB_DIRBE.TIP_ZONA_COD = IIf(IsDBNull(RTrim(row.Cells("TIP_ZONA_COD").Value)), "", RTrim(row.Cells("TIP_ZONA_COD").Value))
            DHAB_DIRBE.REF_ZONA = IIf(IsDBNull(RTrim(row.Cells("REF_ZONA").Value)), "", RTrim(row.Cells("REF_ZONA").Value))
            DHAB_DIRBE.UBIGEO = IIf(IsDBNull(RTrim(row.Cells("UBIGEO").Value)), "", RTrim(row.Cells("UBIGEO").Value))
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PERDHAB_DIR_INSROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@DIR_COD", OracleDbType.Varchar2).Value = DHAB_DIRBE.DIR_COD
            cmd.Parameters.Add("@TIP_VIA_COD", OracleDbType.Varchar2).Value = DHAB_DIRBE.TIP_VIA_COD
            cmd.Parameters.Add("@NRO_DPTO", OracleDbType.Varchar2).Value = DHAB_DIRBE.NRO_DPTO
            cmd.Parameters.Add("@INT_VIA", OracleDbType.Varchar2).Value = DHAB_DIRBE.INT_VIA
            cmd.Parameters.Add("@MZA_VIA", OracleDbType.Varchar2).Value = DHAB_DIRBE.MZA_VIA
            cmd.Parameters.Add("@LOTE_VIA", OracleDbType.Varchar2).Value = DHAB_DIRBE.LOTE_VIA
            cmd.Parameters.Add("@KILOM_VIA", OracleDbType.Varchar2).Value = DHAB_DIRBE.KILOM_VIA
            cmd.Parameters.Add("@BLOCK_VIA", OracleDbType.Varchar2).Value = DHAB_DIRBE.BLOCK_VIA
            cmd.Parameters.Add("@ETAPA_VIA", OracleDbType.Varchar2).Value = DHAB_DIRBE.ETAPA_VIA
            cmd.Parameters.Add("@TIP_ZONA_COD", OracleDbType.Varchar2).Value = DHAB_DIRBE.TIP_ZONA_COD
            cmd.Parameters.Add("@REF_ZONA", OracleDbType.Varchar2).Value = DHAB_DIRBE.REF_ZONA
            cmd.Parameters.Add("@UBIGEO", OracleDbType.Varchar2).Value = DHAB_DIRBE.UBIGEO
            cmd.Parameters.Add("@PER_COD", OracleDbType.Varchar2).Value = DHAB_DIRBE.PER_COD
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
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el Personal: " + PERBE.COD + "-" + PERBE.APE1 + " " + PERBE.APE2 + " " + PERBE.NOM1 + " " + PERBE.NOM2
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Public Function SaveRow(ByVal PERBE As PERBE, ByVal ASI_CPTOBE As ASI_CPTOBE, ByVal DERECHOHABBE As DERECHOHABBE,
                          ByVal DHAB_DIRBE As DHAB_DIRBE, ByVal dgvcpto As DataGridView, ByVal dgvdep As DataGridView,
                          ByVal dgvdirdep As DataGridView, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagaccion As String) As String
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

            If flagaccion = "N" Then
                InsertRow(PERBE, ASI_CPTOBE, DERECHOHABBE, DHAB_DIRBE, dgvcpto, dgvdep, dgvdirdep, ELMVLOGSBE, cn, sqlTrans)
                'grabar acceso a los menues
            End If

            If flagaccion = "M" Then
                UpdateRow(PERBE, ASI_CPTOBE, DERECHOHABBE, DHAB_DIRBE, dgvcpto, dgvdep, dgvdirdep, ELMVLOGSBE, cn, sqlTrans)
            End If

            If flagaccion = "MM" Then
                UpdateRow1(PERBE, ASI_CPTOBE, DERECHOHABBE, DHAB_DIRBE, dgvcpto, dgvdep, dgvdirdep, ELMVLOGSBE, cn, sqlTrans)
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
    Public Function Save(ByVal PERBE As PERBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal dgvcpto As DataGridView,
                         ByVal flagaccion As String) As String
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

            If flagaccion = "M" Then
                UPDdias(PERBE, ELMVLOGSBE, cn, sqlTrans)
                'grabar acceso a los menues
            End If
            If flagaccion = "MD" Then
                UPDdiasPer(PERBE, ELMVLOGSBE, dgvcpto, cn, sqlTrans)
                'grabar acceso a los menues
            End If
            If flagaccion = "CP" Then
                UPDCPTO(PERBE, ELMVLOGSBE, cn, sqlTrans)
                'grabar acceso a los menues
            End If
            If flagaccion = "D" Then
                UPDD(PERBE, ELMVLOGSBE, dgvcpto, cn, sqlTrans)
                'grabar acceso a los menues
            End If
            If flagaccion = "TA" Then
                INSTAREO(PERBE, ELMVLOGSBE, dgvcpto, cn, sqlTrans)
                'grabar acceso a los menues
            End If
            If flagaccion = "TH" Then
                INSHORAS(PERBE, ELMVLOGSBE, dgvcpto, cn, sqlTrans)
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
            'If resultado = "OK" Then
            '    cn.Dispose()
            'End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Private Sub UPDdias(ByVal PERBE As PERBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PER_LIMPIAR_DIAS"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@NN", OracleDbType.Varchar2).Value = PERBE.NN
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub UPDCPTO(ByVal PERBE As PERBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PER_LIMPIAR_ASICPTO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@NN", OracleDbType.Varchar2).Value = PERBE.NN
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub UPDdiasPer(ByVal PERBE As PERBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal dgvcpto As DataGridView,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PER_LIMPIAR_DIAS"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@NN", OracleDbType.Varchar2).Value = PERBE.NN
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub UPDD(ByVal PERBE As PERBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal dgvcpto As DataGridView,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        For Each row As DataGridViewRow In dgvcpto.Rows
            PERBE.COD = IIf(IsDBNull(RTrim(row.Cells("COD").Value)), "", RTrim(row.Cells("COD").Value))
            PERBE.TOT_DIA = IIf(IsDBNull(RTrim(row.Cells("TOT_DIA").Value)), "", RTrim(row.Cells("TOT_DIA").Value))
            PERBE.TOT_HOR = IIf(IsDBNull(RTrim(row.Cells("TOT_HOR").Value)), "", RTrim(row.Cells("TOT_HOR").Value))
            PERBE.TOT_MIN = IIf(IsDBNull(RTrim(row.Cells("TOT_MIN").Value)), "", RTrim(row.Cells("TOT_MIN").Value))

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PER_UPD_DIAS"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@COD", OracleDbType.Varchar2).Value = PERBE.COD
            cmd.Parameters.Add("@TOT_DIA", OracleDbType.Double).Value = PERBE.TOT_DIA
            cmd.Parameters.Add("@TOT_HOR", OracleDbType.Double).Value = PERBE.TOT_HOR
            cmd.Parameters.Add("@TOT_MIN", OracleDbType.Double).Value = PERBE.TOT_MIN

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

    End Sub
    Private Sub INSTAREO(ByVal PERBE As PERBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal dgvcpto As DataGridView,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd.CommandText = "DELETE FROM T_TAREO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        For Each row As DataGridViewRow In dgvcpto.Rows
            PERBE.COD = IIf(IsDBNull(RTrim(row.Cells("COD").Value)), "", RTrim(row.Cells("COD").Value))
            PERBE.FEC_ING = IIf(IsDBNull(RTrim(row.Cells("FECHA").Value)), "", RTrim(row.Cells("FECHA").Value))


            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PERINSTAREO"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@COD", OracleDbType.Varchar2).Value = PERBE.COD
            cmd.Parameters.Add("@TOT_DIA", OracleDbType.Date).Value = PERBE.FEC_ING

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

    End Sub
    Private Sub INSHORAS(ByVal PERBE As PERBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal dgvcpto As DataGridView,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd.CommandText = "DELETE FROM T_TAREOINC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        For Each row As DataGridViewRow In dgvcpto.Rows
            'PERBE.COD = IIf(IsDBNull(RTrim(row.Cells("COD").Value)), "", RTrim(row.Cells("COD").Value))
            'PERBE.FEC_ING = IIf(IsDBNull(RTrim(row.Cells("FECHA").Value)), "", RTrim(row.Cells("FECHA").Value))


            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PERINSTAREOINC"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@COD", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            cmd.Parameters.Add("@TOT_DIA", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            cmd.Parameters.Add("@TOT_DIA", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            cmd.Parameters.Add("@TOT_DIA", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("PER_COD").Value)), "", RTrim(row.Cells("PER_COD").Value))
            cmd.Parameters.Add("@TOT_DIA", OracleDbType.Date).Value = IIf(IsDBNull(RTrim(row.Cells("FEC_INICIO").Value)), "", RTrim(row.Cells("FEC_INICIO").Value))
            cmd.Parameters.Add("@TOT_DIA", OracleDbType.Date).Value = IIf(IsDBNull(RTrim(row.Cells("FEC_TERMINO").Value)), "", RTrim(row.Cells("FEC_TERMINO").Value))
            cmd.Parameters.Add("@TOT_DIA", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("HORA_INICIO").Value)), "", RTrim(row.Cells("HORA_INICIO").Value))
            cmd.Parameters.Add("@TOT_DIA", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("HORA_TERMINO").Value)), "", RTrim(row.Cells("HORA_TERMINO").Value))
            cmd.Parameters.Add("@TOT_DIA", OracleDbType.Date).Value = IIf(IsDBNull(RTrim(row.Cells("FEC_GENE").Value)), "", RTrim(row.Cells("FEC_GENE").Value))
            cmd.Parameters.Add("@TOT_DIA", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NUM_DIF").Value)), "", RTrim(row.Cells("NUM_DIF").Value))
            cmd.Parameters.Add("@TOT_DIA", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("FECHA_MAX").Value)), "", RTrim(row.Cells("FECHA_MAX").Value))
            cmd.Parameters.Add("@TOT_DIA", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("FECHA_MIN").Value)), "", RTrim(row.Cells("FECHA_MIN").Value))

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

    End Sub
    Public Function SelPerAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_All", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelDocPrestamo() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_TDOC_PRESTAMO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelPerAllObr() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_All_OBR", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelPerAll1() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_All", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelPerDias(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_ACT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sCod", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelPerDifHorAs(ByVal sFec As String, ByVal sFec1 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_RPTPERASINC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sFec),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sFec1)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelPerHorTareo(ByVal sFec As String, ByVal sFec1 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_RPTPERTAREOMES", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sFec),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sFec1)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelPerHorInc(ByVal sFec As String, ByVal sFec1 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_RPTPERTAREOMES", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sFec),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sFec1)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelPerAllActivos() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_All_ACTIVOS", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelPerActivosTemp(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_ACT_TEMP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelPerAllActivosTemp(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_All_ACT_TEMP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelPerEmailCor(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_EMAIL_COR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function
    Public Function SelectApeNom(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PER_NOM_COMPLETO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count >= 1 Then
            Return dt.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function
    Public Function SelPerAllContrato() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_SELAllNN", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelPerAllContratoNuevo(ByVal sBusAlm As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_SELAllNNNUEVO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sBusAlm)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectTipEducativo(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PER_TIP_EDUCATIVO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count >= 1 Then
            Return dt.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function
    Public Function SelectNomUbiProv(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PER_NOMUBI_PROV", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count >= 1 Then
            Return dt.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function
    Public Function SelectNomUbiDpto(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PER_NOMUBI_DPTO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count >= 1 Then
            Return dt.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function
    Public Function SelectNomUbiNac(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PER_NOMUBIGEO_NAC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count >= 1 Then
            Return dt.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function
    Public Function SelectCodEdu() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_COD_EDUCATIVO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectCodEduNom(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_PER_COD_EDUCATIVONOM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function SelectCargoOcupacion() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_COD_OCUPACION", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectCargoOcu(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_PER_COD_OCUSELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function SelectCargo() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_COD_CARGO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectCargoNom(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_PER_COD_CARGONOM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function SelectLinea(ByVal centroCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_COD_LINEA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@CCOCOD", centroCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectLineaNom(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_PER_COD_LINEANOM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function
    'Public Function SelectNom(ByVal sCode As String) As String
    '    Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
    '    Dim dt As New DataTable
    '    Try
    '        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_COD_LINEANOM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
    '            If dr.HasRows Then
    '                dt.Load(dr)
    '            End If
    '        End Using
    '        Return dt.Rows(0).Item(0)
    '    Catch ex As Exception
    '        Return ""
    '    End Try
    'End Function
    Public Function SelectContrato() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_COD_CONTRATO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectContratoIni(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_PER_COD_CONTRATOFINI", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function SelectPrdoFecIni(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_PER_COD_PRDOINI", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function SelectContratoFin(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_PER_COD_CONTRATOFFIN", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function SelectPerCPTO() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PERCPTO_SEL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectBcoCTS() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_COD_BCOCTS", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectBcoCTSNom(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_PER_COD_BCOCTSNOM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function SelectRow(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PER_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sCod", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectContratoprd(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PER_COD_ELTBCONTRATO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sCod", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelPerCargo(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_SELCARGO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Try
            Return dt.Rows(0).Item(0)
        Catch ex As Exception

        End Try
    End Function

    Public Function SelPerCargoNew(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_PER_SELELTBCARGO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function SelLineaCod(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_PER_SELLINEA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function SelCco_Cod(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_PER_CCOCOD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function SelPERCpto(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_PERCPTO_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(1)
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function SelPrdoContratoFin(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_PER_SELPRDOCONTRATOFIN", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function SelPrdoContratoIni(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_PER_SELPRDOCONTRATOINI", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function SelCTABCOCTS(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_PER_NOMCTABCOCTS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function SelPerViaAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PERVIA_SELALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelPerViaRow(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_PERVIA_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function SelPerZonaAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PERVIA_SELALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelPerZonaRow(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_PERVIA_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Sub ActualizarProcedureBoleta(ByVal PRDO As String, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "CREATE OR REPLACE PROCEDURE LOGI.SP_RPT_PL_BOLETA_TIPO_CPTOX1 (gridOUT out sys_refcursor) IS
                           BEGIN open gridOUT for select b.t_cpto,a.prdo_cod,a.CPTO_COD,decode(b.porc,null,b.nom,b.nom||'  '||b.porc||'%')nom,
                           a.PER_COD,a.T_PAGO,a.MONTO,b.p_impres from calcpla a,cpto b where a.cpto_cod=b.cod and b.t_cpto='01' and a.monto>0 AND a.prdo_cod = " & PRDO & " order by b.p_impres; 
                           END;"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "CREATE OR REPLACE PROCEDURE LOGI.SP_RPT_PL_BOLETA_TIPO_CPTOX2 (gridOUT out sys_refcursor) IS
                           BEGIN open gridOUT for select b.t_cpto,a.prdo_cod,a.CPTO_COD,decode(b.porc,null,b.nom,b.nom||'  '||b.porc||'%')nom,
                           a.PER_COD,a.T_PAGO,a.MONTO,b.p_impres from calcpla a,cpto b where a.cpto_cod=b.cod and b.t_cpto='02' and a.monto>0 AND A.CPTO_COD NOT IN ('022') 
                           AND a.prdo_cod = " & PRDO & " order by b.p_impres;      
                           END;"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "CREATE OR REPLACE PROCEDURE LOGI.SP_RPT_PL_BOLETA_TIPO_CPTOX3 (GridOUT out sys_refcursor) IS
                           BEGIN open gridOUT for select b.t_cpto,a.prdo_cod,a.CPTO_COD,decode(b.porc,null,b.nom,b.nom||'  '||b.porc||'%')nom,
                           a.PER_COD,a.T_PAGO,a.MONTO,b.p_impres from calcpla a,cpto b where a.cpto_cod=b.cod AND b.t_cpto='03' and a.monto>0 AND a.prdo_cod = " & PRDO & " order by b.p_impres; 
                           END;"

        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Public Function ActualizarSPBoleta(ByVal PRDO As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction
        Try
            ActualizarProcedureBoleta(PRDO, cn, sqlTrans)
            sqlTrans.Commit()
            resultado = "OK"

        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans.Rollback()
            resultado = ex.Message
        Catch ex As Exception
            sqlTrans.Rollback()
            resultado = ex.Message
        Finally
            '   cn.Dispose()
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Private Sub InsertPlanilla(ByVal sTip As String, ByVal sSer As String, ByVal sNro As String, ByVal sCmb As Double,
                                ByVal sFec As Date,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PER_INSPLAN"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        Dim a As String = sFec.Year
        Dim m As String = sFec.Month
        Dim d As String = sFec.Day
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@sTip", OracleDbType.Varchar2).Value = sTip
        cmd.Parameters.Add("@sNro", OracleDbType.Varchar2).Value = sNro
        cmd.Parameters.Add("@a", OracleDbType.Varchar2).Value = a
        cmd.Parameters.Add("@m", OracleDbType.Varchar2).Value = m.PadLeft(2, "0")
        cmd.Parameters.Add("@sCmb", OracleDbType.Double).Value = sCmb
        cmd.Parameters.Add("@d", OracleDbType.Varchar2).Value = d.PadLeft(2, "0")
        cmd.ExecuteNonQuery()
        cmd.Dispose()


        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Personal: " + PERBE.COD + "-" + PERBE.APE1 + " " + PERBE.APE2 + " " + PERBE.NOM1 + " " + PERBE.NOM2
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub InsertPlanilla1(ByVal sTip As String, ByVal sSer As String, ByVal sNro As String, ByVal sCmb As Double,
                                ByVal sFec As Date,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PER_INSPLANDETDIARIO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        Dim a As String = sFec.Year
        Dim m As String = sFec.Month
        Dim d As String = sFec.Day
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@sTip", OracleDbType.Varchar2).Value = sTip
        cmd.Parameters.Add("@sNro", OracleDbType.Varchar2).Value = sNro
        cmd.Parameters.Add("@a", OracleDbType.Varchar2).Value = a
        cmd.Parameters.Add("@m", OracleDbType.Varchar2).Value = m.PadLeft(2, "0")
        cmd.Parameters.Add("@sCmb", OracleDbType.Double).Value = sCmb
        cmd.Parameters.Add("@d", OracleDbType.Varchar2).Value = d.PadLeft(2, "0")
        cmd.ExecuteNonQuery()

        cmd.Dispose()


        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Personal: " + PERBE.COD + "-" + PERBE.APE1 + " " + PERBE.APE2 + " " + PERBE.NOM1 + " " + PERBE.NOM2
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub InsertCTS(ByVal sTip As String, ByVal sSer As String, ByVal sNro As String, ByVal sCmb As Double,
                                ByVal sFec As Date, ByVal sPRDO As String,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PER_INSCTS"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        Dim a As String = sFec.Year
        Dim m As String = sFec.Month
        Dim d As String = sFec.Day
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@sTip", OracleDbType.Varchar2).Value = sTip
        cmd.Parameters.Add("@sNro", OracleDbType.Varchar2).Value = sNro
        cmd.Parameters.Add("@a", OracleDbType.Varchar2).Value = a
        cmd.Parameters.Add("@m", OracleDbType.Varchar2).Value = m
        cmd.Parameters.Add("@sCmb", OracleDbType.Double).Value = sCmb
        cmd.Parameters.Add("@d", OracleDbType.Varchar2).Value = d
        cmd.Parameters.Add("@pprdo", OracleDbType.Varchar2).Value = sPRDO
        cmd.ExecuteNonQuery()
        cmd.Dispose()


        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Personal: " + PERBE.COD + "-" + PERBE.APE1 + " " + PERBE.APE2 + " " + PERBE.NOM1 + " " + PERBE.NOM2
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub InsertCTS1(ByVal sTip As String, ByVal sSer As String, ByVal sNro As String, ByVal sCmb As Double,
                                ByVal sFec As Date, ByVal sPRDO As String,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PER_INSCTSDETDIARIO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        Dim a As String = sFec.Year
        Dim m As String = sFec.Month
        Dim d As String = sFec.Day
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@sTip", OracleDbType.Varchar2).Value = sTip
        cmd.Parameters.Add("@sNro", OracleDbType.Varchar2).Value = sNro
        cmd.Parameters.Add("@a", OracleDbType.Varchar2).Value = a
        cmd.Parameters.Add("@m", OracleDbType.Varchar2).Value = m
        cmd.Parameters.Add("@sCmb", OracleDbType.Double).Value = sCmb
        cmd.Parameters.Add("@d", OracleDbType.Varchar2).Value = d
        cmd.Parameters.Add("@pprdo", OracleDbType.Varchar2).Value = sPRDO
        cmd.ExecuteNonQuery()
        cmd.Dispose()


        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Personal: " + PERBE.COD + "-" + PERBE.APE1 + " " + PERBE.APE2 + " " + PERBE.NOM1 + " " + PERBE.NOM2
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub InsertGRA(ByVal sTip As String, ByVal sSer As String, ByVal sNro As String, ByVal sCmb As Double,
                                ByVal sFec As Date, ByVal sPRDO As String,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PER_INSGRA"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        Dim a As String = sFec.Year
        Dim m As String = sFec.Month
        Dim d As String = sFec.Day
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@sTip", OracleDbType.Varchar2).Value = sTip
        cmd.Parameters.Add("@sNro", OracleDbType.Varchar2).Value = sNro
        cmd.Parameters.Add("@a", OracleDbType.Varchar2).Value = a
        cmd.Parameters.Add("@m", OracleDbType.Varchar2).Value = m
        cmd.Parameters.Add("@sCmb", OracleDbType.Double).Value = sCmb
        cmd.Parameters.Add("@d", OracleDbType.Varchar2).Value = d
        cmd.Parameters.Add("@pprdo", OracleDbType.Varchar2).Value = sPRDO
        cmd.ExecuteNonQuery()
        cmd.Dispose()


        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Personal: " + PERBE.COD + "-" + PERBE.APE1 + " " + PERBE.APE2 + " " + PERBE.NOM1 + " " + PERBE.NOM2
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub InsertGRA1(ByVal sTip As String, ByVal sSer As String, ByVal sNro As String, ByVal sCmb As Double,
                                ByVal sFec As Date, ByVal sPRDO As String,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PER_INSGRADETDIARIO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        Dim a As String = sFec.Year
        Dim m As String = sFec.Month
        Dim d As String = sFec.Day
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@sTip", OracleDbType.Varchar2).Value = sTip
        cmd.Parameters.Add("@sNro", OracleDbType.Varchar2).Value = sNro
        cmd.Parameters.Add("@a", OracleDbType.Varchar2).Value = a
        cmd.Parameters.Add("@m", OracleDbType.Varchar2).Value = m
        cmd.Parameters.Add("@sCmb", OracleDbType.Double).Value = sCmb
        cmd.Parameters.Add("@d", OracleDbType.Varchar2).Value = d
        cmd.Parameters.Add("@pprdo", OracleDbType.Varchar2).Value = sPRDO
        cmd.ExecuteNonQuery()
        cmd.Dispose()


        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Personal: " + PERBE.COD + "-" + PERBE.APE1 + " " + PERBE.APE2 + " " + PERBE.NOM1 + " " + PERBE.NOM2
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub InsertVACA(ByVal sTip As String, ByVal sSer As String, ByVal sNro As String, ByVal sCmb As Double,
                                ByVal sFec As Date, ByVal sPRDO As String,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PER_INSVACA"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        Dim a As String = sFec.Year
        Dim m As String = sFec.Month
        Dim d As String = sFec.Day
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@sTip", OracleDbType.Varchar2).Value = sTip
        cmd.Parameters.Add("@sNro", OracleDbType.Varchar2).Value = sNro
        cmd.Parameters.Add("@a", OracleDbType.Varchar2).Value = a
        cmd.Parameters.Add("@m", OracleDbType.Varchar2).Value = m
        cmd.Parameters.Add("@sCmb", OracleDbType.Double).Value = sCmb
        cmd.Parameters.Add("@d", OracleDbType.Varchar2).Value = d
        cmd.Parameters.Add("@pprdo", OracleDbType.Varchar2).Value = sPRDO
        cmd.ExecuteNonQuery()
        cmd.Dispose()


        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Personal: " + PERBE.COD + "-" + PERBE.APE1 + " " + PERBE.APE2 + " " + PERBE.NOM1 + " " + PERBE.NOM2
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub InsertVACA1(ByVal sTip As String, ByVal sSer As String, ByVal sNro As String, ByVal sCmb As Double,
                                ByVal sFec As Date, ByVal sPRDO As String,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PER_INSVACADETDIARIO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        Dim a As String = sFec.Year
        Dim m As String = sFec.Month
        Dim d As String = sFec.Day
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@sTip", OracleDbType.Varchar2).Value = sTip
        cmd.Parameters.Add("@sNro", OracleDbType.Varchar2).Value = sNro
        cmd.Parameters.Add("@a", OracleDbType.Varchar2).Value = a
        cmd.Parameters.Add("@m", OracleDbType.Varchar2).Value = m
        cmd.Parameters.Add("@sCmb", OracleDbType.Double).Value = sCmb
        cmd.Parameters.Add("@d", OracleDbType.Varchar2).Value = d
        cmd.Parameters.Add("@pprdo", OracleDbType.Varchar2).Value = sPRDO
        cmd.ExecuteNonQuery()
        cmd.Dispose()


        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Personal: " + PERBE.COD + "-" + PERBE.APE1 + " " + PERBE.APE2 + " " + PERBE.NOM1 + " " + PERBE.NOM2
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Public Function InsAsPlan(ByVal sTip As String, ByVal sSer As String, ByVal sNro As String, ByVal sCmb As Double, ByVal sFec As Date,
                              ByVal sFla As String, ByVal sPRDO As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction
        Try
            If sFla = "PLAN" Then
                InsertPlanilla(sTip, sSer, sNro, sCmb, sFec, cn, sqlTrans)
            End If
            If sFla = "PLAN1" Then
                InsertPlanilla1(sTip, sSer, sNro, sCmb, sFec, cn, sqlTrans)
            End If
            If sFla = "GRA" Then
                InsertGRA(sTip, sSer, sNro, sCmb, sFec, sPRDO, cn, sqlTrans)
            End If
            If sFla = "GRA1" Then
                InsertGRA1(sTip, sSer, sNro, sCmb, sFec, sPRDO, cn, sqlTrans)
            End If
            If sFla = "CTS" Then
                InsertCTS(sTip, sSer, sNro, sCmb, sFec, sPRDO, cn, sqlTrans)
            End If
            If sFla = "CTS1" Then
                InsertCTS1(sTip, sSer, sNro, sCmb, sFec, sPRDO, cn, sqlTrans)
            End If
            If sFla = "VACA" Then
                InsertVACA(sTip, sSer, sNro, sCmb, sFec, sPRDO, cn, sqlTrans)
            End If
            If sFla = "VACA1" Then
                InsertVACA1(sTip, sSer, sNro, sCmb, sFec, sPRDO, cn, sqlTrans)
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
            '   cn.Dispose()
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Public Function ActualizarBoletas(ByVal prdo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ACTUALIZAR_PLANILLAS", {New Oracle.ManagedDataAccess.Client.OracleParameter("PERIIODO", prdo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ActualizarBoletasGra(ByVal prdo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ACTUALIZAR_PLANILLAS_GRA", {New Oracle.ManagedDataAccess.Client.OracleParameter("PERIIODO", prdo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarCCOCOD() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SEL_CCOCOD", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
