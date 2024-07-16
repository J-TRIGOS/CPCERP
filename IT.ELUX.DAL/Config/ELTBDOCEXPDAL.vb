Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBDOCEXPDAL
    Inherits BaseDatosORACLE
    Private sPrueba As String
    Public Function AsientoPR(ByVal flagAccion As String, ByVal sAño As String, ByVal sMes As String, ByVal sNro As String, ByVal sSer As String, ByVal sTipo As String,
                              ByVal sUs As String, ByVal sProv As String, ByVal dg As DataGridView, ByVal flujo As String, ByVal caja As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try

            If flagAccion = "Asiento" Then
                Asiento(cn, sqlTrans, sAño, sMes, sNro, sSer, sTipo, sUs, sProv, dg, flujo, caja)
            End If
            'If flagAccion = "AS" Then
            '    Asiento_Todo(cn, sqlTrans, sAño, sMes, sNro, sSer, sTipo, sEst, dg)
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
            '   cn.Dispose()
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Public Sub Asiento(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sAño As String,
                       ByVal sMes As String, ByVal sNro As String, ByVal sSer As String, ByVal sTipo As String, ByVal sUS As String,
                      ByVal sProv As String, ByVal dg As DataGridView, ByVal flujo As String, ByVal caja As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CONTNUVOSOLES_C2_NODOM"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sAño", OracleDbType.Varchar2).Value = Trim(sAño)
        cmd.Parameters.Add("@sMes", OracleDbType.Varchar2).Value = Trim(sMes)
        cmd.Parameters.Add("@sNro", OracleDbType.Varchar2).Value = sNro
        cmd.Parameters.Add("@sSer", OracleDbType.Varchar2).Value = sSer
        cmd.Parameters.Add("@sTipo", OracleDbType.Varchar2).Value = sTipo
        cmd.Parameters.Add("@sPROV", OracleDbType.Varchar2).Value = sProv
        cmd.Parameters.Add("@sEst", OracleDbType.Varchar2).Value = sUS
        'cmd.Parameters.Add("@mFlujo", OracleDbType.Varchar2).Value = flujo
        'cmd.Parameters.Add("@mCaja", OracleDbType.Varchar2).Value = caja
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Function SaveRow(ByVal ELTBDOCEXPBE As ELTBDOCEXPBE, ByVal ELTBDETDOCEXPBE As ELTBDETDOCEXPBE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE,
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
                ''correlativo = LastCodigo()
                ''MonedaBE.mon_codigo = MonedaBE.mon_codigo
                InsertRow(ELTBDOCEXPBE, ELTBDETDOCEXPBE, cn, sqlTrans, ELMVLOGSBE, dg)
                'grabar acceso a los menues
            End If
            If flagAccion = "M" Then
                UpdateRow(ELTBDOCEXPBE, ELTBDETDOCEXPBE, cn, sqlTrans, ELMVLOGSBE, dg)
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
            If resultado = "OK" And flagAccion <> "M" And flagAccion <> "MK" And flagAccion <> "MF" Then
                cn.Dispose()
            End If
            sqlTrans = Nothing
        End Try
        Return resultado
    End Function

    Private Sub InsertRow(ByVal ELTBDOCEXPBE As ELTBDOCEXPBE, ByVal ELTBDETDOCEXPBE As ELTBDETDOCEXPBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal dg As DataGridView)

        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim DAcumula6 As Double = 0
        Dim DAcumula7 As Double = 0
        Dim DAcumula8 As Double = 0
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDOCEXP_INSROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.T_DOC_REF
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.SER_DOC_REF
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.NRO_DOC_REF
        cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = ELTBDOCEXPBE.TPRECIO_COMPRA
        cmd.Parameters.Add("@TPRECIO_DCOMPRA", OracleDbType.Double).Value = ELTBDOCEXPBE.TPRECIO_DCOMPRA
        cmd.Parameters.Add("@T_OPE", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.T_OPE
        cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.ART_COD
        cmd.Parameters.Add("@FEC_PROV", OracleDbType.Date).Value = ELTBDOCEXPBE.FEC_PROV
        cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBDOCEXPBE.FEC_GENE
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.EST
        cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.PROVEEDOR
        cmd.Parameters.Add("@OBSERVA", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.OBSERVA
        cmd.Parameters.Add("@F_PAGO_ENT", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.F_PAGO_ENT
        cmd.Parameters.Add("@TIPO1", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.TIPO1
        cmd.Parameters.Add("@NRO_PERCEPCION", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.NRO_PERCEPCION
        cmd.Parameters.Add("@TIPO2", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.TIPO2
        cmd.Parameters.Add("@T_CAMB", OracleDbType.Double).Value = ELTBDOCEXPBE.T_CAMB
        cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.MONEDA
        cmd.Parameters.Add("@EST1", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.EST1
        cmd.Parameters.Add("@X_RET ", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.X_RET
        cmd.Parameters.Add("@DETRACCION", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.DETRACCION
        cmd.Parameters.Add("@FEC_DET", OracleDbType.Date).Value = ELTBDOCEXPBE.FEC_DET
        cmd.Parameters.Add("@LETRA", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.LETRA
        cmd.Parameters.Add("@FEC_LETRA", OracleDbType.Date).Value = ELTBDOCEXPBE.FEC_LETRA
        cmd.Parameters.Add("@T_IGV", OracleDbType.Double).Value = ELTBDOCEXPBE.T_IGV
        cmd.Parameters.Add("@T_IGV_DOLAR", OracleDbType.Double).Value = ELTBDOCEXPBE.T_IGV_DOLAR
        cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.TIPO
        cmd.Parameters.Add("@REG_NRO", OracleDbType.Double).Value = Val(ELTBDOCEXPBE.REG_NRO)
        cmd.Parameters.Add("@SIGNO", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.SIGNO
        cmd.Parameters.Add("@T_DCTO", OracleDbType.Double).Value = ELTBDOCEXPBE.T_DCTO
        cmd.Parameters.Add("@T_DCTO_DOLAR", OracleDbType.Double).Value = ELTBDOCEXPBE.T_DCTO_DOLAR
        cmd.Parameters.Add("@USUARIO", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.USUARIO
        cmd.Parameters.Add("@MONTO_PAGADO", OracleDbType.Double).Value = ELTBDOCEXPBE.MONTO_PAGADO
        cmd.Parameters.Add("@PROGRAMA", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.PROGRAMA
        cmd.Parameters.Add("@PORCENTAJE", OracleDbType.Double).Value = ELTBDOCEXPBE.PORCENTAJE
        cmd.Parameters.Add("@FARDO", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.FARDO
        cmd.Parameters.Add("@CTA_CBCO ", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.CTA_CBCO)
        cmd.Parameters.Add("@TAFECTOD ", OracleDbType.Double).Value = Trim(ELTBDOCEXPBE.TAFECTOD)
        cmd.Parameters.Add("@TAFECTO ", OracleDbType.Double).Value = Trim(ELTBDOCEXPBE.TAFECTO)
        cmd.Parameters.Add("@T_DIES ", OracleDbType.Double).Value = Trim(ELTBDOCEXPBE.T_DIES)
        cmd.Parameters.Add("@T_IES ", OracleDbType.Double).Value = Trim(ELTBDOCEXPBE.T_IES)
        cmd.Parameters.Add("@T_DCTA ", OracleDbType.Double).Value = Trim(ELTBDOCEXPBE.T_DCTA)
        cmd.Parameters.Add("@T_CTA ", OracleDbType.Double).Value = Trim(ELTBDOCEXPBE.T_CTA)
        cmd.Parameters.Add("@T_CMP ", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.T_CMP)
        cmd.Parameters.Add("@S_CMP ", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.S_CMP)
        cmd.Parameters.Add("@N_CMP ", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.N_CMP)
        cmd.Parameters.Add("@ANO_CMP ", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.ANO_CMP)
        cmd.Parameters.Add("@T_CONV ", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.T_CONV)
        cmd.Parameters.Add("@PAIS ", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.PAIS)
        cmd.Parameters.Add("@T_RENTA ", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.T_RENTA)
        cmd.Parameters.Add("@EST_OPORT ", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.EST_OPORT)
        cmd.Parameters.Add("@FEC_vensbs", OracleDbType.Date).Value = ELTBDOCEXPBE.FEC_VENSBS
        cmd.Parameters.Add("@ADVALOR", OracleDbType.Double).Value = ELTBDOCEXPBE.ADVALORE
        cmd.Parameters.Add("@TIPO7 ", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.TIPO7)
        cmd.Parameters.Add("@EST_MERCADERIA ", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.EST_MERCADERIA)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETDOCEXP_INSROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBDETDOCEXPBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            ELTBDETDOCEXPBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            ELTBDETDOCEXPBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            ELTBDETDOCEXPBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELTBDETDOCEXPBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELTBDETDOCEXPBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELTBDETDOCEXPBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells("CTCT_COD").Value)), "", RTrim(row.Cells("CTCT_COD").Value))
            ELTBDETDOCEXPBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            ELTBDETDOCEXPBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells("SIGNO").Value)), "", RTrim(row.Cells("SIGNO").Value))
            ELTBDETDOCEXPBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            ELTBDETDOCEXPBE.IGV = IIf(IsDBNull(RTrim(row.Cells("IGV").Value)), 0, RTrim(row.Cells("IGV").Value))
            ELTBDETDOCEXPBE.IGV_IMPOR = IIf(IsDBNull(RTrim(row.Cells("IGV_IMPOR").Value)), 0, RTrim(row.Cells("IGV_IMPOR").Value))
            ELTBDETDOCEXPBE.IGV_IMPOR = IIf(IsDBNull(RTrim(row.Cells("IGV_DIMPOR").Value)), 0, RTrim(row.Cells("IGV_DIMPOR").Value))
            ELTBDETDOCEXPBE.T_CAMB = IIf(IsDBNull(RTrim(row.Cells("T_CAMB").Value)), 0, RTrim(row.Cells("T_CAMB").Value))
            ' DET_DOCUMENTOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells("FEC_GENE").Value)), "", RTrim(row.Cells("FEC_GENE").Value))
            ELTBDETDOCEXPBE.USUARIO = IIf(IsDBNull(RTrim(row.Cells("USUARIO").Value)), "", RTrim(row.Cells("USUARIO").Value))
            ELTBDETDOCEXPBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
            ELTBDETDOCEXPBE.FEC_DIA = IIf(IsDBNull(RTrim(row.Cells("FEC_DIA").Value)), "", RTrim(row.Cells("FEC_DIA").Value))
            ELTBDETDOCEXPBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR").Value)), "", RTrim(row.Cells("PROVEEDOR").Value))
            ELTBDETDOCEXPBE.CUENTA = IIf(IsDBNull(RTrim(row.Cells("CUENTA").Value)), "", RTrim(row.Cells("CUENTA").Value))
            ELTBDETDOCEXPBE.CUENTA_DEST = IIf(IsDBNull(RTrim(row.Cells("CUENTA_DEST").Value)), "", RTrim(row.Cells("CUENTA_DEST").Value))
            ELTBDETDOCEXPBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells("SIGNO").Value)), "", RTrim(row.Cells("SIGNO").Value))
            If IIf(IsDBNull(RTrim(row.Cells("STATUS").Value)), "", RTrim(row.Cells("STATUS").Value)) = "AFECTO" Then
                ELTBDETDOCEXPBE.STATUS = "S"
            ElseIf IIf(IsDBNull(RTrim(row.Cells("STATUS").Value)), "", RTrim(row.Cells("STATUS").Value)) = "INAFECTO" Then
                ELTBDETDOCEXPBE.STATUS = "N"
            End If

            'DET_DOCUMENTOBE.STATUS = IIf(IsDBNull(RTrim(row.Cells("STATUS").Value)), "", RTrim(row.Cells("STATUS").Value))
            ELTBDETDOCEXPBE.UPRECIO_AFECTOS = IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOS").Value)), "", RTrim(row.Cells("UPRECIO_AFECTOS").Value))
            ELTBDETDOCEXPBE.UPRECIO_AFECTOD = IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOD").Value)), "", RTrim(row.Cells("UPRECIO_AFECTOD").Value))
            ELTBDETDOCEXPBE.IES_IMPOR = IIf(IsDBNull(RTrim(row.Cells("IES_IMPOR").Value)), "", RTrim(row.Cells("IES_IMPOR").Value))
            ELTBDETDOCEXPBE.IES_DIMPOR = IIf(IsDBNull(RTrim(row.Cells("IES_DIMPOR").Value)), "", RTrim(row.Cells("IES_DIMPOR").Value))
            ELTBDETDOCEXPBE.CTA_IMPOR = IIf(IsDBNull(RTrim(row.Cells("CTA_IMPOR").Value)), "", RTrim(row.Cells("CTA_IMPOR").Value))
            ELTBDETDOCEXPBE.CTA_DIMPOR = IIf(IsDBNull(RTrim(row.Cells("CTA_DIMPOR").Value)), "", RTrim(row.Cells("CTA_DIMPOR").Value))
            ELTBDETDOCEXPBE.IES = IIf(IsDBNull(RTrim(row.Cells("IES").Value)), 0, RTrim(row.Cells("IES").Value))
            ELTBDETDOCEXPBE.CTA = IIf(IsDBNull(RTrim(row.Cells("CTA").Value)), "", RTrim(row.Cells("CTA").Value))
            ELTBDETDOCEXPBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("unidad").Value)), "", RTrim(row.Cells("unidad").Value))
            ELTBDETDOCEXPBE.FEC_DIA = IIf(IsDBNull(RTrim(row.Cells("FEC_DIA").Value)), "", RTrim(row.Cells("FEC_DIA").Value))
            ELTBDETDOCEXPBE.X_D = IIf(IsDBNull(RTrim(row.Cells("X_D").Value)), "", RTrim(row.Cells("X_D").Value))
            ELTBDETDOCEXPBE.PESO = Val(IIf(IsDBNull(RTrim(row.Cells("PESO").Value)), 0, RTrim(row.Cells("PESO").Value)))
            ELTBDETDOCEXPBE.SDOC = IIf(IsDBNull(RTrim(row.Cells("SREQ").Value)), "", RTrim(row.Cells("SREQ").Value))
            ELTBDETDOCEXPBE.NDOC = IIf(IsDBNull(RTrim(row.Cells("NREQ").Value)), "", RTrim(row.Cells("NREQ").Value))
            ELTBDETDOCEXPBE.ADVALOR = IIf(IsDBNull(RTrim(row.Cells("ADVALORE").Value)), 0, RTrim(row.Cells("ADVALORE").Value))
            ELTBDETDOCEXPBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells("CCO_COD").Value)), 0, RTrim(row.Cells("CCO_COD").Value))

            If ELTBDETDOCEXPBE.ADVALOR = 1 Then
                ELTBDETDOCEXPBE.ADVALOR = 0
            End If

            'DET_DOCUMENTOBE.NRO_DOCU1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU1").Value)), "", RTrim(row.Cells("NRO_DOCU1").Value))
            If ELTBDETDOCEXPBE.STATUS = "S" Then
                If ELTBDOCEXPBE.MONEDA = "00" Then
                    ELTBDETDOCEXPBE.UPRECIO_COMPRA = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_COMPRA").Value)), 0, RTrim(row.Cells("UPRECIO_COMPRA").Value)))
                    ELTBDETDOCEXPBE.UPRECIO_DCOMPRA = ELTBDETDOCEXPBE.UPRECIO_COMPRA / ELTBDETDOCEXPBE.T_CAMB
                    ELTBDETDOCEXPBE.TPRECIO_COMPRA = Math.Round(ELTBDETDOCEXPBE.UPRECIO_COMPRA * ELTBDETDOCEXPBE.CANTIDAD, 6)
                    ELTBDETDOCEXPBE.TPRECIO_DCOMPRA = Math.Round(ELTBDETDOCEXPBE.UPRECIO_COMPRA * ELTBDETDOCEXPBE.CANTIDAD / ELTBDETDOCEXPBE.T_CAMB, 6)
                    If ELTBDOCEXPBE.T_IGV > 0 Then
                        ELTBDETDOCEXPBE.IGV_IMPOR = Math.Round((ELTBDETDOCEXPBE.TPRECIO_COMPRA * 18) / 100, 6)
                        ELTBDETDOCEXPBE.IGV_DIMPOR = Math.Round((ELTBDETDOCEXPBE.TPRECIO_DCOMPRA * 18) / 100, 6)
                    Else
                        ELTBDETDOCEXPBE.IGV_IMPOR = 0
                        ELTBDETDOCEXPBE.IGV_DIMPOR = 0
                    End If
                ElseIf ELTBDOCEXPBE.MONEDA = "01" Then
                    ELTBDETDOCEXPBE.UPRECIO_DCOMPRA = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DCOMPRA").Value)), 0, RTrim(row.Cells("UPRECIO_DCOMPRA").Value)))
                    ELTBDETDOCEXPBE.UPRECIO_COMPRA = ELTBDETDOCEXPBE.UPRECIO_DCOMPRA * ELTBDETDOCEXPBE.T_CAMB
                    ELTBDETDOCEXPBE.TPRECIO_DCOMPRA = Math.Round(ELTBDETDOCEXPBE.UPRECIO_DCOMPRA * ELTBDETDOCEXPBE.CANTIDAD, 6)
                    ELTBDETDOCEXPBE.TPRECIO_COMPRA = Math.Round(ELTBDETDOCEXPBE.UPRECIO_DCOMPRA * ELTBDETDOCEXPBE.CANTIDAD * ELTBDETDOCEXPBE.T_CAMB, 6)
                    If ELTBDOCEXPBE.T_IGV > 0 Then
                        ELTBDETDOCEXPBE.IGV_IMPOR = Math.Round((ELTBDETDOCEXPBE.TPRECIO_COMPRA * 18) / 100, 6)
                        ELTBDETDOCEXPBE.IGV_DIMPOR = Math.Round((ELTBDETDOCEXPBE.TPRECIO_DCOMPRA * 18) / 100, 6)
                    Else
                        ELTBDETDOCEXPBE.IGV_IMPOR = 0
                        ELTBDETDOCEXPBE.IGV_DIMPOR = 0
                    End If
                End If
            Else
                If ELTBDOCEXPBE.MONEDA = "00" Then
                    ELTBDETDOCEXPBE.UPRECIO_AFECTOD = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOS").Value)), 0, RTrim(row.Cells("UPRECIO_AFECTOS").Value))) / ELTBDETDOCEXPBE.T_CAMB
                    ELTBDETDOCEXPBE.UPRECIO_AFECTOS = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOS").Value)), 0, RTrim(row.Cells("UPRECIO_AFECTOS").Value)))
                    ELTBDETDOCEXPBE.TPRECIO_COMPRA = Math.Round(ELTBDETDOCEXPBE.UPRECIO_AFECTOS * ELTBDETDOCEXPBE.CANTIDAD, 6)
                    ELTBDETDOCEXPBE.TPRECIO_DCOMPRA = Math.Round(ELTBDETDOCEXPBE.UPRECIO_AFECTOS * ELTBDETDOCEXPBE.CANTIDAD / ELTBDETDOCEXPBE.T_CAMB, 6)
                    'DET_DOCUMENTOBE.UPRECIO_DCOMPRA = DET_DOCUMENTOBE.UPRECIO_COMPRA / DET_DOCUMENTOBE.T_CAMB
                    ELTBDETDOCEXPBE.IGV_IMPOR = 0
                    ELTBDETDOCEXPBE.IGV_DIMPOR = 0
                ElseIf ELTBDOCEXPBE.MONEDA = "01" Then
                    ELTBDETDOCEXPBE.UPRECIO_AFECTOD = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOD").Value)), 0, RTrim(row.Cells("UPRECIO_AFECTOD").Value)))
                    ELTBDETDOCEXPBE.UPRECIO_AFECTOS = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOD").Value)), 0, RTrim(row.Cells("UPRECIO_AFECTOD").Value))) * ELTBDETDOCEXPBE.T_CAMB
                    ELTBDETDOCEXPBE.TPRECIO_COMPRA = Math.Round(ELTBDETDOCEXPBE.UPRECIO_AFECTOD * ELTBDETDOCEXPBE.CANTIDAD * ELTBDETDOCEXPBE.T_CAMB, 6)
                    ELTBDETDOCEXPBE.TPRECIO_DCOMPRA = Math.Round(ELTBDETDOCEXPBE.UPRECIO_AFECTOD * ELTBDETDOCEXPBE.CANTIDAD, 6)
                    ELTBDETDOCEXPBE.IGV_IMPOR = 0
                    ELTBDETDOCEXPBE.IGV_DIMPOR = 0
                End If
            End If
            DAcumula = ELTBDETDOCEXPBE.UPRECIO_COMPRA + DAcumula
            DAcumula1 = ELTBDETDOCEXPBE.UPRECIO_DCOMPRA + DAcumula1
            DAcumula2 = ELTBDETDOCEXPBE.TPRECIO_DCOMPRA + DAcumula2
            DAcumula3 = ELTBDETDOCEXPBE.TPRECIO_COMPRA + DAcumula3
            DAcumula4 = ELTBDETDOCEXPBE.IGV_IMPOR + DAcumula4
            DAcumula5 = ELTBDETDOCEXPBE.IGV_DIMPOR + DAcumula5
            DAcumula6 = ELTBDETDOCEXPBE.UPRECIO_AFECTOD + DAcumula6
            DAcumula7 = ELTBDETDOCEXPBE.UPRECIO_AFECTOS + DAcumula7


            ' DET_DOCUMENTOBE.FEC_LLEG = IIf(IsDBNull(RTrim(row.Cells(12).Value)), "", RTrim(row.Cells(12).Value))
            'contenedor = IIf(IsDBNull(RTrim(row.Cells("FEC_ANU").Value)), ORDENCOMPRABE.FEC_ANU, RTrim(row.Cells("FEC_ANU").Value))

            'DET_DOCUMENTOBE.EST = IIf(IsDBNull(RTrim(row.Cells("EST").Value)), "", RTrim(row.Cells("EST").Value))
            'If PROVISIONESBE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 And PROVISIONESBE.T_DOC_REF = DET_DOCUMENTOBE.T_DOC_REF1 Then
            '    DET_DOCUMENTOBE.NRO_DOC_REF1 = PROVISIONESBE.NRO_DOC_REF & "-" & cont
            'End If
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETDOCEXPBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETDOCEXPBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETDOCEXPBE.NRO_DOC_REF1
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = ELTBDETDOCEXPBE.CTCT_COD
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = ELTBDETDOCEXPBE.CANTIDAD
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = ELTBDETDOCEXPBE.SIGNO
            cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.TPRECIO_COMPRA)
            cmd.Parameters.Add("@TPRECIO_DCOMPRA", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.TPRECIO_DCOMPRA)
            cmd.Parameters.Add("@igv", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.IGV)
            cmd.Parameters.Add("@IGV_IMPOR", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.IGV_IMPOR)
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELTBDETDOCEXPBE.ART_COD
            cmd.Parameters.Add("@t_camb", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.T_CAMB)
            cmd.Parameters.Add("@UPRECIO_COMPRA", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.UPRECIO_COMPRA)
            cmd.Parameters.Add("@UPRECIO_dCOMPRA", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.UPRECIO_DCOMPRA)
            cmd.Parameters.Add("@IGV_DIMPOR", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.IGV_DIMPOR)
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.MONEDA
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = ELTBDETDOCEXPBE.USUARIO
            cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = ELTBDOCEXPBE.PROVEEDOR
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBDOCEXPBE.FEC_GENE
            cmd.Parameters.Add("@CUENTA", OracleDbType.Varchar2).Value = Trim(ELTBDETDOCEXPBE.CUENTA)
            cmd.Parameters.Add("@CUENTA_DEST", OracleDbType.Varchar2).Value = ELTBDETDOCEXPBE.CUENTA_DEST
            cmd.Parameters.Add("@STATUS", OracleDbType.Varchar2).Value = ELTBDETDOCEXPBE.STATUS
            cmd.Parameters.Add("@UPRECIO_AFECTOS", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.UPRECIO_AFECTOS)
            cmd.Parameters.Add("@UPRECIO_AFECTOD", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.UPRECIO_AFECTOD)
            cmd.Parameters.Add("@IES_IMPOR", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.IES_IMPOR)
            cmd.Parameters.Add("@IES_DIMPOR", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.IES_DIMPOR)
            cmd.Parameters.Add("@CTA_IMPOR", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.CTA_IMPOR)
            cmd.Parameters.Add("@CTA_DIMPOR", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.CTA_DIMPOR)
            cmd.Parameters.Add("@IES", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.IES)
            cmd.Parameters.Add("@CTA", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.CTA)
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(ELTBDETDOCEXPBE.UNIDAD)
            'cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_DIA
            cmd.Parameters.Add("@DSCTO", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.DSCTO)
            cmd.Parameters.Add("@DSCTO_IMPOR", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.DSCTO_IMPOR)
            cmd.Parameters.Add("@DSCTO_DIMPOR", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.DSCTO_DIMPOR)
            cmd.Parameters.Add("@F_PAGO_ENT", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.F_PAGO_ENT)
            cmd.Parameters.Add("@X_D", OracleDbType.Varchar2).Value = Trim(ELTBDETDOCEXPBE.X_D)
            cmd.Parameters.Add("@PESO", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.PESO)
            cmd.Parameters.Add("@SDOC", OracleDbType.Varchar2).Value = Trim(ELTBDETDOCEXPBE.SDOC)
            cmd.Parameters.Add("@NDOC", OracleDbType.Varchar2).Value = Trim(ELTBDETDOCEXPBE.NDOC)
            cmd.Parameters.Add("@ADVALORE", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.ADVALOR)
            cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = Trim(ELTBDETDOCEXPBE.CCO_COD)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
        'ACTUALIZA CABECERA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDOCEXP_UPDTOT"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.NRO_DOC_REF
        cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = DAcumula3
        cmd.Parameters.Add("@TPRECIO_DVENTA", OracleDbType.Double).Value = DAcumula2
        cmd.Parameters.Add("@T_IGV", OracleDbType.Double).Value = DAcumula4
        cmd.Parameters.Add("@T_IGV_DOLAR", OracleDbType.Double).Value = DAcumula5
        cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.PROVEEDOR
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el documento no Domiciliado de Compra: " + ELTBDOCEXPBE.NRO_DOC_REF
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub

    'Metodo para Modificar 
    Private Sub UpdateRow(ByVal ELTBDOCEXPBE As ELTBDOCEXPBE, ByVal ELTBDETDOCEXPBE As ELTBDETDOCEXPBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal dg As DataGridView)
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim DAcumula6 As Double = 0
        Dim DAcumula7 As Double = 0
        Dim DAcumula8 As Double = 0
        'realiza registro del catalogo
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDOCEXP_UPDROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.T_DOC_REF
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.SER_DOC_REF
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.NRO_DOC_REF
        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.TDOC
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.SDOC
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.NDOC
        cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = ELTBDOCEXPBE.TPRECIO_COMPRA
        cmd.Parameters.Add("@TPRECIO_DCOMPRA", OracleDbType.Double).Value = ELTBDOCEXPBE.TPRECIO_DCOMPRA
        cmd.Parameters.Add("@T_OPE", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.T_OPE
        cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.ART_COD
        cmd.Parameters.Add("@FEC_PROV", OracleDbType.Date).Value = ELTBDOCEXPBE.FEC_PROV
        cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBDOCEXPBE.FEC_GENE
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.EST
        cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.PROVEEDOR
        cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.P
        cmd.Parameters.Add("@OBSERVA", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.OBSERVA
        cmd.Parameters.Add("@F_PAGO_ENT", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.F_PAGO_ENT
        cmd.Parameters.Add("@TIPO1", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.TIPO1
        cmd.Parameters.Add("@NRO_PERCEPCION", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.NRO_PERCEPCION
        cmd.Parameters.Add("@TIPO2", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.TIPO2
        cmd.Parameters.Add("@T_CAMB", OracleDbType.Double).Value = ELTBDOCEXPBE.T_CAMB
        cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.MONEDA
        cmd.Parameters.Add("@EST1", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.EST1
        cmd.Parameters.Add("@X_RET ", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.X_RET
        cmd.Parameters.Add("@DETRACCION", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.DETRACCION
        cmd.Parameters.Add("@FEC_DET", OracleDbType.Date).Value = ELTBDOCEXPBE.FEC_DET
        cmd.Parameters.Add("@LETRA", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.LETRA
        cmd.Parameters.Add("@FEC_LETRA", OracleDbType.Date).Value = ELTBDOCEXPBE.FEC_LETRA
        cmd.Parameters.Add("@T_IGV", OracleDbType.Double).Value = ELTBDOCEXPBE.T_IGV
        cmd.Parameters.Add("@T_IGV_DOLAR", OracleDbType.Double).Value = ELTBDOCEXPBE.T_IGV_DOLAR
        cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.TIPO
        cmd.Parameters.Add("@REG_NRO", OracleDbType.Double).Value = Val(ELTBDOCEXPBE.REG_NRO)
        cmd.Parameters.Add("@SIGNO", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.SIGNO
        cmd.Parameters.Add("@T_DCTO", OracleDbType.Double).Value = ELTBDOCEXPBE.T_DCTO
        cmd.Parameters.Add("@T_DCTO_DOLAR", OracleDbType.Double).Value = ELTBDOCEXPBE.T_DCTO_DOLAR
        cmd.Parameters.Add("@USUARIO", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.USUARIO
        cmd.Parameters.Add("@MONTO_PAGADO", OracleDbType.Double).Value = ELTBDOCEXPBE.MONTO_PAGADO
        cmd.Parameters.Add("@PROGRAMA", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.PROGRAMA
        cmd.Parameters.Add("@PORCENTAJE", OracleDbType.Double).Value = ELTBDOCEXPBE.PORCENTAJE
        cmd.Parameters.Add("@FARDO", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.FARDO
        cmd.Parameters.Add("@CTA_CBCO ", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.CTA_CBCO)
        cmd.Parameters.Add("@TAFECTOD ", OracleDbType.Double).Value = Trim(ELTBDOCEXPBE.TAFECTOD)
        cmd.Parameters.Add("@TAFECTO ", OracleDbType.Double).Value = Trim(ELTBDOCEXPBE.TAFECTO)
        cmd.Parameters.Add("@T_DIES ", OracleDbType.Double).Value = Trim(ELTBDOCEXPBE.T_DIES)
        cmd.Parameters.Add("@T_IES ", OracleDbType.Double).Value = Trim(ELTBDOCEXPBE.T_IES)
        cmd.Parameters.Add("@T_DCTA ", OracleDbType.Double).Value = Trim(ELTBDOCEXPBE.T_DCTA)
        cmd.Parameters.Add("@T_CTA ", OracleDbType.Double).Value = Trim(ELTBDOCEXPBE.T_CTA)
        cmd.Parameters.Add("@T_CMP ", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.T_CMP)
        cmd.Parameters.Add("@S_CMP ", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.S_CMP)
        cmd.Parameters.Add("@N_CMP ", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.N_CMP)
        cmd.Parameters.Add("@ANO_CMP ", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.ANO_CMP)
        cmd.Parameters.Add("@T_CONV ", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.T_CONV)
        cmd.Parameters.Add("@PAIS ", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.PAIS)
        cmd.Parameters.Add("@T_RENTA ", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.T_RENTA)
        cmd.Parameters.Add("@EST_OPORT ", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.EST_OPORT)
        cmd.Parameters.Add("@FEC_vensbs", OracleDbType.Date).Value = ELTBDOCEXPBE.FEC_VENSBS
        cmd.Parameters.Add("@ADVALORE", OracleDbType.Double).Value = ELTBDOCEXPBE.ADVALORE
        cmd.Parameters.Add("@TIPO7 ", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.TIPO7)
        cmd.Parameters.Add("@EST_MERCADERIA ", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.EST_MERCADERIA)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETDOCEXP_DEL"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.TDOC
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.SDOC
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.NDOC
        cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.P
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETDOCEXP_INSROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBDETDOCEXPBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            ELTBDETDOCEXPBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            ELTBDETDOCEXPBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            ELTBDETDOCEXPBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELTBDETDOCEXPBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELTBDETDOCEXPBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELTBDETDOCEXPBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells("CTCT_COD").Value)), "", RTrim(row.Cells("CTCT_COD").Value))
            ELTBDETDOCEXPBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            ELTBDETDOCEXPBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells("SIGNO").Value)), "", RTrim(row.Cells("SIGNO").Value))
            ELTBDETDOCEXPBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            ELTBDETDOCEXPBE.IGV = IIf(IsDBNull(RTrim(row.Cells("IGV").Value)), 0, RTrim(row.Cells("IGV").Value))
            ELTBDETDOCEXPBE.IGV_IMPOR = IIf(IsDBNull(RTrim(row.Cells("IGV_IMPOR").Value)), 0, RTrim(row.Cells("IGV_IMPOR").Value))
            ELTBDETDOCEXPBE.IGV_IMPOR = IIf(IsDBNull(RTrim(row.Cells("IGV_DIMPOR").Value)), 0, RTrim(row.Cells("IGV_DIMPOR").Value))
            ELTBDETDOCEXPBE.T_CAMB = IIf(IsDBNull(RTrim(row.Cells("T_CAMB").Value)), 0, RTrim(row.Cells("T_CAMB").Value))
            ' DET_DOCUMENTOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells("FEC_GENE").Value)), "", RTrim(row.Cells("FEC_GENE").Value))
            ELTBDETDOCEXPBE.USUARIO = IIf(IsDBNull(RTrim(row.Cells("USUARIO").Value)), "", RTrim(row.Cells("USUARIO").Value))
            ELTBDETDOCEXPBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
            ELTBDETDOCEXPBE.FEC_DIA = IIf(IsDBNull(RTrim(row.Cells("FEC_DIA").Value)), "", RTrim(row.Cells("FEC_DIA").Value))
            ELTBDETDOCEXPBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR").Value)), "", RTrim(row.Cells("PROVEEDOR").Value))
            ELTBDETDOCEXPBE.CUENTA = IIf(IsDBNull(RTrim(row.Cells("CUENTA").Value)), "", RTrim(row.Cells("CUENTA").Value))
            ELTBDETDOCEXPBE.CUENTA_DEST = IIf(IsDBNull(RTrim(row.Cells("CUENTA_DEST").Value)), "", RTrim(row.Cells("CUENTA_DEST").Value))
            ELTBDETDOCEXPBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells("SIGNO").Value)), "", RTrim(row.Cells("SIGNO").Value))
            ELTBDETDOCEXPBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells("CCO_COD").Value)), "", RTrim(row.Cells("CCO_COD").Value))
            If IIf(IsDBNull(RTrim(row.Cells("STATUS").Value)), "", RTrim(row.Cells("STATUS").Value)) = "AFECTO" Then
                ELTBDETDOCEXPBE.STATUS = "S"
            ElseIf IIf(IsDBNull(RTrim(row.Cells("STATUS").Value)), "", RTrim(row.Cells("STATUS").Value)) = "INAFECTO" Then
                ELTBDETDOCEXPBE.STATUS = "N"
            End If

            'DET_DOCUMENTOBE.STATUS = IIf(IsDBNull(RTrim(row.Cells("STATUS").Value)), "", RTrim(row.Cells("STATUS").Value))
            ELTBDETDOCEXPBE.UPRECIO_AFECTOS = IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOS").Value)), "", RTrim(row.Cells("UPRECIO_AFECTOS").Value))
            ELTBDETDOCEXPBE.UPRECIO_AFECTOD = IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOD").Value)), "", RTrim(row.Cells("UPRECIO_AFECTOD").Value))
            ELTBDETDOCEXPBE.IES_IMPOR = IIf(IsDBNull(RTrim(row.Cells("IES_IMPOR").Value)), "", RTrim(row.Cells("IES_IMPOR").Value))
            ELTBDETDOCEXPBE.IES_DIMPOR = IIf(IsDBNull(RTrim(row.Cells("IES_DIMPOR").Value)), "", RTrim(row.Cells("IES_DIMPOR").Value))
            ELTBDETDOCEXPBE.CTA_IMPOR = IIf(IsDBNull(RTrim(row.Cells("CTA_IMPOR").Value)), "", RTrim(row.Cells("CTA_IMPOR").Value))
            ELTBDETDOCEXPBE.CTA_DIMPOR = IIf(IsDBNull(RTrim(row.Cells("CTA_DIMPOR").Value)), "", RTrim(row.Cells("CTA_DIMPOR").Value))
            ELTBDETDOCEXPBE.IES = IIf(IsDBNull(RTrim(row.Cells("IES").Value)), 0, RTrim(row.Cells("IES").Value))
            ELTBDETDOCEXPBE.CTA = IIf(IsDBNull(RTrim(row.Cells("CTA").Value)), "", RTrim(row.Cells("CTA").Value))
            ELTBDETDOCEXPBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("unidad").Value)), "", RTrim(row.Cells("unidad").Value))
            ELTBDETDOCEXPBE.FEC_DIA = IIf(IsDBNull(RTrim(row.Cells("FEC_DIA").Value)), "", RTrim(row.Cells("FEC_DIA").Value))
            ELTBDETDOCEXPBE.X_D = IIf(IsDBNull(RTrim(row.Cells("X_D").Value)), "", RTrim(row.Cells("X_D").Value))
            ELTBDETDOCEXPBE.PESO = Val(IIf(IsDBNull(RTrim(row.Cells("PESO").Value)), 0, RTrim(row.Cells("PESO").Value)))
            ELTBDETDOCEXPBE.SDOC = IIf(IsDBNull(RTrim(row.Cells("SREQ").Value)), "", RTrim(row.Cells("SREQ").Value))
            ELTBDETDOCEXPBE.NDOC = IIf(IsDBNull(RTrim(row.Cells("NREQ").Value)), "", RTrim(row.Cells("NREQ").Value))
            ELTBDETDOCEXPBE.ADVALOR = IIf(IsDBNull(RTrim(row.Cells("ADVALORE").Value)), "", RTrim(row.Cells("ADVALORE").Value))

            'DET_DOCUMENTOBE.NRO_DOCU1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU1").Value)), "", RTrim(row.Cells("NRO_DOCU1").Value))
            If ELTBDETDOCEXPBE.STATUS = "S" Then
                If ELTBDOCEXPBE.MONEDA = "00" Then
                    ELTBDETDOCEXPBE.UPRECIO_COMPRA = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_COMPRA").Value)), 0, RTrim(row.Cells("UPRECIO_COMPRA").Value)))
                    ELTBDETDOCEXPBE.UPRECIO_DCOMPRA = ELTBDETDOCEXPBE.UPRECIO_COMPRA / ELTBDETDOCEXPBE.T_CAMB
                    ELTBDETDOCEXPBE.TPRECIO_COMPRA = Math.Round(ELTBDETDOCEXPBE.UPRECIO_COMPRA * ELTBDETDOCEXPBE.CANTIDAD, 6)
                    ELTBDETDOCEXPBE.TPRECIO_DCOMPRA = Math.Round(ELTBDETDOCEXPBE.UPRECIO_COMPRA * ELTBDETDOCEXPBE.CANTIDAD / ELTBDETDOCEXPBE.T_CAMB, 6)
                    If ELTBDOCEXPBE.T_IGV > 0 Then
                        ELTBDETDOCEXPBE.IGV_IMPOR = Math.Round((ELTBDETDOCEXPBE.TPRECIO_COMPRA * 18) / 100, 6)
                        ELTBDETDOCEXPBE.IGV_DIMPOR = Math.Round((ELTBDETDOCEXPBE.TPRECIO_DCOMPRA * 18) / 100, 6)
                    Else
                        ELTBDETDOCEXPBE.IGV_IMPOR = 0
                        ELTBDETDOCEXPBE.IGV_DIMPOR = 0
                    End If
                ElseIf ELTBDOCEXPBE.MONEDA = "01" Then
                    ELTBDETDOCEXPBE.UPRECIO_DCOMPRA = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DCOMPRA").Value)), 0, RTrim(row.Cells("UPRECIO_DCOMPRA").Value)))
                    ELTBDETDOCEXPBE.UPRECIO_COMPRA = ELTBDETDOCEXPBE.UPRECIO_DCOMPRA * ELTBDETDOCEXPBE.T_CAMB
                    ELTBDETDOCEXPBE.TPRECIO_DCOMPRA = Math.Round(ELTBDETDOCEXPBE.UPRECIO_DCOMPRA * ELTBDETDOCEXPBE.CANTIDAD, 6)
                    ELTBDETDOCEXPBE.TPRECIO_COMPRA = Math.Round(ELTBDETDOCEXPBE.UPRECIO_DCOMPRA * ELTBDETDOCEXPBE.CANTIDAD * ELTBDETDOCEXPBE.T_CAMB, 6)
                    If ELTBDOCEXPBE.T_IGV > 0 Then
                        ELTBDETDOCEXPBE.IGV_IMPOR = Math.Round((ELTBDETDOCEXPBE.TPRECIO_COMPRA * 18) / 100, 6)
                        ELTBDETDOCEXPBE.IGV_DIMPOR = Math.Round((ELTBDETDOCEXPBE.TPRECIO_DCOMPRA * 18) / 100, 6)
                    Else
                        ELTBDETDOCEXPBE.IGV_IMPOR = 0
                        ELTBDETDOCEXPBE.IGV_DIMPOR = 0
                    End If
                End If
            Else
                If ELTBDOCEXPBE.MONEDA = "00" Then
                    ELTBDETDOCEXPBE.UPRECIO_AFECTOD = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOS").Value)), 0, RTrim(row.Cells("UPRECIO_AFECTOS").Value))) / ELTBDETDOCEXPBE.T_CAMB
                    ELTBDETDOCEXPBE.UPRECIO_AFECTOS = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOS").Value)), 0, RTrim(row.Cells("UPRECIO_AFECTOS").Value)))
                    ELTBDETDOCEXPBE.TPRECIO_COMPRA = Math.Round(ELTBDETDOCEXPBE.UPRECIO_AFECTOS * ELTBDETDOCEXPBE.CANTIDAD, 6)
                    ELTBDETDOCEXPBE.TPRECIO_DCOMPRA = Math.Round(ELTBDETDOCEXPBE.UPRECIO_AFECTOS * ELTBDETDOCEXPBE.CANTIDAD / ELTBDETDOCEXPBE.T_CAMB, 6)
                    'DET_DOCUMENTOBE.UPRECIO_DCOMPRA = DET_DOCUMENTOBE.UPRECIO_COMPRA / DET_DOCUMENTOBE.T_CAMB
                    ELTBDETDOCEXPBE.IGV_IMPOR = 0
                    ELTBDETDOCEXPBE.IGV_DIMPOR = 0
                ElseIf ELTBDOCEXPBE.MONEDA = "01" Then
                    ELTBDETDOCEXPBE.UPRECIO_AFECTOD = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOD").Value)), 0, RTrim(row.Cells("UPRECIO_AFECTOD").Value)))
                    ELTBDETDOCEXPBE.UPRECIO_AFECTOS = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOD").Value)), 0, RTrim(row.Cells("UPRECIO_AFECTOD").Value))) * ELTBDETDOCEXPBE.T_CAMB
                    ELTBDETDOCEXPBE.TPRECIO_COMPRA = Math.Round(ELTBDETDOCEXPBE.UPRECIO_AFECTOD * ELTBDETDOCEXPBE.CANTIDAD * ELTBDETDOCEXPBE.T_CAMB, 6)
                    ELTBDETDOCEXPBE.TPRECIO_DCOMPRA = Math.Round(ELTBDETDOCEXPBE.UPRECIO_AFECTOD * ELTBDETDOCEXPBE.CANTIDAD, 6)
                    ELTBDETDOCEXPBE.IGV_IMPOR = 0
                    ELTBDETDOCEXPBE.IGV_DIMPOR = 0
                End If
            End If
            DAcumula = ELTBDETDOCEXPBE.UPRECIO_COMPRA + DAcumula
            DAcumula1 = ELTBDETDOCEXPBE.UPRECIO_DCOMPRA + DAcumula1
            DAcumula2 = ELTBDETDOCEXPBE.TPRECIO_DCOMPRA + DAcumula2
            DAcumula3 = ELTBDETDOCEXPBE.TPRECIO_COMPRA + DAcumula3
            DAcumula4 = ELTBDETDOCEXPBE.IGV_IMPOR + DAcumula4
            DAcumula5 = ELTBDETDOCEXPBE.IGV_DIMPOR + DAcumula5
            DAcumula6 = ELTBDETDOCEXPBE.UPRECIO_AFECTOD + DAcumula6
            DAcumula7 = ELTBDETDOCEXPBE.UPRECIO_AFECTOS + DAcumula7


            ' DET_DOCUMENTOBE.FEC_LLEG = IIf(IsDBNull(RTrim(row.Cells(12).Value)), "", RTrim(row.Cells(12).Value))
            'contenedor = IIf(IsDBNull(RTrim(row.Cells("FEC_ANU").Value)), ORDENCOMPRABE.FEC_ANU, RTrim(row.Cells("FEC_ANU").Value))

            'DET_DOCUMENTOBE.EST = IIf(IsDBNull(RTrim(row.Cells("EST").Value)), "", RTrim(row.Cells("EST").Value))
            'If PROVISIONESBE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 And PROVISIONESBE.T_DOC_REF = DET_DOCUMENTOBE.T_DOC_REF1 Then
            '    DET_DOCUMENTOBE.NRO_DOC_REF1 = PROVISIONESBE.NRO_DOC_REF & "-" & cont
            'End If
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETDOCEXPBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETDOCEXPBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETDOCEXPBE.NRO_DOC_REF1
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = ELTBDETDOCEXPBE.CTCT_COD
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = ELTBDETDOCEXPBE.CANTIDAD
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = ELTBDETDOCEXPBE.SIGNO
            cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.TPRECIO_COMPRA)
            cmd.Parameters.Add("@TPRECIO_DCOMPRA", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.TPRECIO_DCOMPRA)
            cmd.Parameters.Add("@igv", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.IGV)
            cmd.Parameters.Add("@IGV_IMPOR", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.IGV_IMPOR)
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELTBDETDOCEXPBE.ART_COD
            cmd.Parameters.Add("@t_camb", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.T_CAMB)
            cmd.Parameters.Add("@UPRECIO_COMPRA", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.UPRECIO_COMPRA)
            cmd.Parameters.Add("@UPRECIO_dCOMPRA", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.UPRECIO_DCOMPRA)
            cmd.Parameters.Add("@IGV_DIMPOR", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.IGV_DIMPOR)
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.MONEDA
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = ELTBDETDOCEXPBE.USUARIO
            cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = ELTBDOCEXPBE.PROVEEDOR
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBDOCEXPBE.FEC_GENE
            cmd.Parameters.Add("@CUENTA", OracleDbType.Varchar2).Value = Trim(ELTBDETDOCEXPBE.CUENTA)
            cmd.Parameters.Add("@CUENTA_DEST", OracleDbType.Varchar2).Value = ELTBDETDOCEXPBE.CUENTA_DEST
            cmd.Parameters.Add("@STATUS", OracleDbType.Varchar2).Value = ELTBDETDOCEXPBE.STATUS
            cmd.Parameters.Add("@UPRECIO_AFECTOS", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.UPRECIO_AFECTOS)
            cmd.Parameters.Add("@UPRECIO_AFECTOD", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.UPRECIO_AFECTOD)
            cmd.Parameters.Add("@IES_IMPOR", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.IES_IMPOR)
            cmd.Parameters.Add("@IES_DIMPOR", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.IES_DIMPOR)
            cmd.Parameters.Add("@CTA_IMPOR", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.CTA_IMPOR)
            cmd.Parameters.Add("@CTA_DIMPOR", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.CTA_DIMPOR)
            cmd.Parameters.Add("@IES", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.IES)
            cmd.Parameters.Add("@CTA", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.CTA)
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(ELTBDETDOCEXPBE.UNIDAD)
            'cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_DIA
            cmd.Parameters.Add("@DSCTO", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.DSCTO)
            cmd.Parameters.Add("@DSCTO_IMPOR", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.DSCTO_IMPOR)
            cmd.Parameters.Add("@DSCTO_DIMPOR", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.DSCTO_DIMPOR)
            cmd.Parameters.Add("@F_PAGO_ENT", OracleDbType.Varchar2).Value = Trim(ELTBDOCEXPBE.F_PAGO_ENT)
            cmd.Parameters.Add("@X_D", OracleDbType.Varchar2).Value = Trim(ELTBDETDOCEXPBE.X_D)
            cmd.Parameters.Add("@PESO", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.PESO)
            cmd.Parameters.Add("@SDOC", OracleDbType.Varchar2).Value = Trim(ELTBDETDOCEXPBE.SDOC)
            cmd.Parameters.Add("@NDOC", OracleDbType.Varchar2).Value = Trim(ELTBDETDOCEXPBE.NDOC)
            cmd.Parameters.Add("@ADVALOR", OracleDbType.Double).Value = Trim(ELTBDETDOCEXPBE.ADVALOR)
            cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = Trim(ELTBDETDOCEXPBE.CCO_COD)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
        'ACTUALIZA CABECERA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDOCEXP_UPDTOT"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.NRO_DOC_REF
        cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = DAcumula3
        cmd.Parameters.Add("@TPRECIO_DVENTA", OracleDbType.Double).Value = DAcumula2
        cmd.Parameters.Add("@T_IGV", OracleDbType.Double).Value = DAcumula4
        cmd.Parameters.Add("@T_IGV_DOLAR", OracleDbType.Double).Value = DAcumula5
        cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = ELTBDOCEXPBE.PROVEEDOR
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Modifico el articulo: " + ELTBDOCEXPBE.ART_COD
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub

    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sFec As String,
                                  ByVal sCTCT As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDOCEXP_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sFec),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@CTCT_COD", sCTCT)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function Select_Nomconv(ByVal sCod As String) As String
        sPrueba = ""
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDOCEXP_TNOMCONV", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pCod", Trim(sCod))})
            While dr.Read
                sPrueba = dr.GetString(0)
            End While
        End Using
        Return sPrueba
    End Function
    Public Function SelPais() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDOCEXP_SELPAIS", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelConv() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDOCEXP_SELCONV", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sFec As String,
                              ByVal sCTCT As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBDETDOCEXP_SEL_PRV", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sFec),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@CTCT_COD", sCTCT)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function getListdgv3(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SOLPROVISIONES_LETRA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SaveRowAllMes(ByVal flagAccion As String, ByVal sAño As String, ByVal sMes As String, ByVal sUser As String, ByVal dg As DataGridView) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try
            If flagAccion = "UPD" Then
                UpdReg(cn, sAño, sMes, sqlTrans, dg)
            End If
            If flagAccion = "AsAll" Then
                AsientoAll(cn, sAño, sMes, sqlTrans, dg)
            End If
            If flagAccion = "TC" Then
                UpdTC(cn, sAño, sMes, sUser, sqlTrans, dg)
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
    Public Sub UpdTC(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sAño As String, ByVal sMes As String, ByVal sUser As String,
                       ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                    ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCEXP_TCAMBFEC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@fec", OracleDbType.Varchar2).Value = sMes
        'cmd.Parameters.Add("@suser", OracleDbType.Varchar2).Value = sUser

        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Sub UpdReg(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sAño As String, ByVal sMes As String,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                      ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_REGCOMPRA_UPDASIENTOEXP"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sAño", OracleDbType.Varchar2).Value = Trim(sAño)
        cmd.Parameters.Add("@sMes", OracleDbType.Varchar2).Value = Trim(sMes)

        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Sub AsientoAll(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sAño As String, ByVal sMes As String,
                       ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                    ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_CONTNUVOSOLES_C2_NODOM"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@sAño", OracleDbType.Varchar2).Value = Trim(sAño)
            cmd.Parameters.Add("@sMes", OracleDbType.Varchar2).Value = Trim(sMes)
            cmd.Parameters.Add("@sNro", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            cmd.Parameters.Add("@sSer", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            cmd.Parameters.Add("@sTipo", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            cmd.Parameters.Add("@sProv", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR").Value)), "", RTrim(row.Cells("PROVEEDOR").Value))
            cmd.Parameters.Add("@sUS", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("USUARIO").Value)), "", RTrim(row.Cells("USUARIO").Value))
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        Next

    End Sub
End Class
