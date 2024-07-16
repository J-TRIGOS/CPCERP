Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBPROGPAGODAL
    Inherits BaseDatosORACLE

    Public sNumero As String
    Public sPrueba As String
    Public sNumero1 As String
    Public sNomArt As Integer

    Public Function SelectAll(ByVal sT_doc As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBPROGPAGO_SELALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
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
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBPROGPAGO_SelRow", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectNro1(ByVal sCode As String, ByVal sSer As String, ByVal sfec As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBPROGPAGO_SELECTNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode)),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sSer)),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@pFEC_GENE", Trim(sfec))})
            While dr.Read
                sNumero1 = dr.GetString(0)
            End While
        End Using
        Return sNumero1

    End Function

    Public Function SelectF_PAGO() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_F_PAGO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function


    Public Function SelectT_DOC(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_T_DOC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectMoneda() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_MON", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectCliente() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_CTCTCOD", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectNro1(ByVal sCode As String, ByVal sSer As String) As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBPROGPAGO_SELECTNRO1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode)),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sSer))})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero
    End Function

    Function list1(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String, ByVal pcli As String,
           ByVal fec As Date, ByVal nmon As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBPROGPAGO_SD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@PROVEEDOR", Trim(pcli)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", fec),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@MONEDA", Trim(nmon))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function

    Function list2(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String, ByVal pcli As String, ByVal nmom As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBPROGPAGO_SD1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@PROVEEDOR", Trim(pcli)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@MONEDA", Trim(nmom))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function

    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sPcli As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PROGPAGO_LIST_DET", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@proveedor", sPcli)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function Listtdoc(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBDETPROGPAGO_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
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
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBDETPROGPAGO_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getT_CAMB(ByVal fec As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_T_CMB_V", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec", fec)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectCantDias(ByVal sCod As String) As Integer
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        ' Dim dt As New DataTable
        Try
            Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_CANT_D", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", sCod)})
                If dr.Read Then
                    sNomArt = dr.GetInt32(0)
                End If
            End Using
            Return sNomArt
        Catch ex As Exception

        End Try

#Disable Warning BC42353 ' La función 'SelectCantDias' no devuelve un valor en todas las rutas de acceso de código. ¿Falta alguna instrucción 'Return'?
    End Function

    Public Function SaveRow(ByVal ELTBPROGPAGOBE As ELTBPROGPAGOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                        ByVal flagAccion As String, ByVal dg As DataGridView) As String
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
                InsertRow(ELTBPROGPAGOBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg)
                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBPROGPAGOBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "AR" Then
                UpdateRowAnularFC(ELTBPROGPAGOBE, DET_DOCUMENTOBE, ELMVLOGSBE, cn, sqlTrans, dg)
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


    Private Sub InsertRow(ByVal ELTBPROGPAGOBE As ELTBPROGPAGOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        If ELTBPROGPAGOBE.ANULAR = 1 Then
            cmd.CommandText = "SP_ELTBPROGPAGO_UPDROW_FC"
        Else
            cmd.CommandText = "SP_ELTBPROGPAGO_INSERTROW_FC"
        End If
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.NRO_DOC_REF
        cmd.Parameters.Add("@nro_docu", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.NRO_DOCU
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBPROGPAGOBE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.EST
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.MONEDA
        cmd.Parameters.Add("@tprecio_compra", OracleDbType.Double).Value = ELTBPROGPAGOBE.TPRECIO_COMPRA
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = ELTBPROGPAGOBE.FEC_ANU
        cmd.Parameters.Add("@tprecio_dcompra", OracleDbType.Double).Value = ELTBPROGPAGOBE.TPRECIO_DCOMPRA
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.USUARIO
        cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.OBSERVA
        cmd.Parameters.Add("@t_igv", OracleDbType.Double).Value = ELTBPROGPAGOBE.T_IGV
        cmd.Parameters.Add("@t_igv_dolar", OracleDbType.Double).Value = ELTBPROGPAGOBE.T_IGV_DOLAR
        cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.PROVEEDOR
        cmd.Parameters.Add("@FEC_PROG", OracleDbType.Date).Value = ELTBPROGPAGOBE.FEC_PROG
        cmd.Parameters.Add("@T_OPE", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.T_OPE
        cmd.Parameters.Add("@COD_CBCO", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.COD_CBCO
        cmd.Parameters.Add("@EST_COBRA", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.EST_COBRA
        cmd.Parameters.Add("@ACT_FLUJO", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.ACT_FLUJO
        cmd.Parameters.Add("@FLUJO_CAJA", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.FLUJO_CAJA
        cmd.Parameters.Add("@EXT_BANC", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.EXT_BANC
        cmd.Parameters.Add("@NRO_DOCU1", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.NRO_DOCU1
        cmd.Parameters.Add("@FEC_VIGENCIA", OracleDbType.Date).Value = ELTBPROGPAGOBE.FEC_VIGENCIA
        cmd.Parameters.Add("@PERCEPCION", OracleDbType.Double).Value = ELTBPROGPAGOBE.NRO_PERCEPCION
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        'cmd.Parameters.Add("@PROG_PAGO", OracleDbType.Double).Value = ELTBPROGPAGOBE.PROG_PAGO
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1


            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_ELTBDETPROGPAGO_INSFC1"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            DET_DOCUMENTOBE.OBSERVA = IIf(IsDBNull(RTrim(row.Cells("OBSERVA").Value)), "", RTrim(row.Cells("OBSERVA").Value))
            DET_DOCUMENTOBE.TPRECIO_COMPRA = IIf(IsDBNull(RTrim(row.Cells("TPRECIO_COMPRA").Value)), 0, RTrim(row.Cells("TPRECIO_COMPRA").Value))
            DET_DOCUMENTOBE.TPRECIO_DCOMPRA = IIf(IsDBNull(RTrim(row.Cells("TPRECIO_DCOMPRA").Value)), 0, RTrim(row.Cells("TPRECIO_DCOMPRA").Value))
            DET_DOCUMENTOBE.T_IGV = IIf(IsDBNull(RTrim(row.Cells("T_IGV").Value)), 0, RTrim(row.Cells("T_IGV").Value))
            DET_DOCUMENTOBE.T_IGV_DOLAR = IIf(IsDBNull(RTrim(row.Cells("T_IGV_DOLAR").Value)), 0, RTrim(row.Cells("T_IGV_DOLAR").Value))
            DET_DOCUMENTOBE.USUARIO = IIf(IsDBNull(RTrim(row.Cells("USUARIO").Value)), "", RTrim(row.Cells("USUARIO").Value))
            DET_DOCUMENTOBE.MONEDA = IIf(IsDBNull(RTrim(row.Cells("MONEDA").Value)), "", RTrim(row.Cells("MONEDA").Value))
            DET_DOCUMENTOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells("FEC_GENE").Value)), "", RTrim(row.Cells("FEC_GENE").Value))
            DET_DOCUMENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR").Value)), "", RTrim(row.Cells("PROVEEDOR").Value))
            DET_DOCUMENTOBE.FEC_VENCIMIENTO = IIf(IsDBNull(RTrim(row.Cells("FEC_VEN").Value)), "", RTrim(row.Cells("FEC_VEN").Value))
            DET_DOCUMENTOBE.F_PAGO_ENT = IIf(IsDBNull(RTrim(row.Cells("F_PAGO_ENT").Value)), "", RTrim(row.Cells("F_PAGO_ENT").Value))
            DET_DOCUMENTOBE.CUENTA = IIf(IsDBNull(RTrim(row.Cells("CTA_CBCO").Value)), "", RTrim(row.Cells("CTA_CBCO").Value))
            DET_DOCUMENTOBE.X_RET = IIf(IsDBNull(RTrim(row.Cells("X_RET").Value)), "", RTrim(row.Cells("X_RET").Value))
            DET_DOCUMENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells("SIGNO").Value)), "", RTrim(row.Cells("SIGNO").Value))
            If IIf(IsDBNull(RTrim(row.Cells("STATUS").Value)), "", RTrim(row.Cells("STATUS").Value)) = "AFECTO" Then
                DET_DOCUMENTOBE.STATUS = "S"
            Else
                DET_DOCUMENTOBE.STATUS = "N"
            End If

            DET_DOCUMENTOBE.T_OPE_COD = IIf(IsDBNull(RTrim(row.Cells("T_OPE").Value)), "", RTrim(row.Cells("T_OPE").Value))
            DET_DOCUMENTOBE.OBSERVA1 = IIf(IsDBNull(RTrim(row.Cells("OBSERVA2").Value)), "", RTrim(row.Cells("OBSERVA2").Value))
            DET_DOCUMENTOBE.CUENTA_DEST = IIf(IsDBNull(RTrim(row.Cells("CTA_COD_DEST").Value)), "", RTrim(row.Cells("CTA_COD_DEST").Value))
            DET_DOCUMENTOBE.CUENTITA = IIf(IsDBNull(RTrim(row.Cells("CUENTITA").Value)), "", RTrim(row.Cells("CUENTITA").Value))
            DET_DOCUMENTOBE.T_CAMB = IIf(IsDBNull(RTrim(row.Cells("T_CMB").Value)), "", RTrim(row.Cells("T_CMB").Value))
            DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells("CCO_COD").Value)), "", RTrim(row.Cells("CCO_COD").Value))
            DET_DOCUMENTOBE.RETEN = IIf(IsDBNull(RTrim(row.Cells("RETEN").Value)), "", RTrim(row.Cells("RETEN").Value))
            DET_DOCUMENTOBE.REG_NRO = IIf(IsDBNull(RTrim(row.Cells("REG_NRO").Value)), "", RTrim(row.Cells("REG_NRO").Value))
            ELTBPROGPAGOBE.MONTO_PAGADO = IIf(IsDBNull(RTrim(row.Cells("MONTO_PAGADO").Value)), "", RTrim(row.Cells("MONTO_PAGADO").Value))
            ELTBPROGPAGOBE.MONTO_PAGADOD = IIf(IsDBNull(RTrim(row.Cells("MONTO_DPAGADO").Value)), "", RTrim(row.Cells("MONTO_DPAGADO").Value))
            DET_DOCUMENTOBE.NUEVO = IIf(IsDBNull(RTrim(row.Cells("NUEVO").Value)), "", RTrim(row.Cells("NUEVO").Value))

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.T_DOC_REF
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.SER_DOC_REF
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.NRO_DOC_REF
            cmd.Parameters.Add("@T_DOC_REF1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
            cmd.Parameters.Add("@SER_DOC_REF1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
            cmd.Parameters.Add("@NRO_DOC_REF1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
            cmd.Parameters.Add("@OBSERVA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
            cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = DET_DOCUMENTOBE.TPRECIO_COMPRA
            cmd.Parameters.Add("@TPRECIO_DCOMPRA", OracleDbType.Double).Value = DET_DOCUMENTOBE.TPRECIO_DCOMPRA
            cmd.Parameters.Add("@T_IGV", OracleDbType.Double).Value = DET_DOCUMENTOBE.T_IGV
            cmd.Parameters.Add("@T_IGV_DOLAR", OracleDbType.Double).Value = DET_DOCUMENTOBE.T_IGV_DOLAR
            cmd.Parameters.Add("@USUARIO", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.MONEDA
            cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_GENE
            cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PROVEEDOR
            cmd.Parameters.Add("@FEC_VEN", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_VENCIMIENTO
            cmd.Parameters.Add("@F_PAGO_ENT", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT
            cmd.Parameters.Add("@CUENTA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CUENTA
            cmd.Parameters.Add("@X_RET", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.X_RET
            cmd.Parameters.Add("@SIGNO", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO
            cmd.Parameters.Add("@STATUS", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.STATUS
            cmd.Parameters.Add("@T_OPE_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_OPE_COD
            cmd.Parameters.Add("@OBSERVA2", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA1
            cmd.Parameters.Add("@CUENTA_DEST", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CUENTA_DEST
            cmd.Parameters.Add("@CUENTITA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CUENTITA
            cmd.Parameters.Add("@T_CMB", OracleDbType.Double).Value = DET_DOCUMENTOBE.T_CAMB
            cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CCO_COD
            cmd.Parameters.Add("@RETEN", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.RETEN
            cmd.Parameters.Add("@REG_NRO", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.REG_NRO
            cmd.Parameters.Add("@pMONTO_PAGO", OracleDbType.Double).Value = ELTBPROGPAGOBE.MONTO_PAGADO
            cmd.Parameters.Add("@pMONTO_DPAGO", OracleDbType.Double).Value = ELTBPROGPAGOBE.MONTO_PAGADOD
            cmd.Parameters.Add("@pNUEVO", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NUEVO
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        cont = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBPROGPAGO_UPDREQ_APROB"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(Trim(row.Cells("T_DOC_REF1").Value)), "", Trim(row.Cells("T_DOC_REF1").Value))
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(Trim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(Trim(row.Cells("NRO_DOC_REF1").Value)), "", Trim(row.Cells("NRO_DOC_REF1").Value))
            DET_DOCUMENTOBE.PROVEEDOR = IIf(IsDBNull(Trim(row.Cells("PROVEEDOR").Value)), "", Trim(row.Cells("PROVEEDOR").Value))

            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
            cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PROVEEDOR
            cmd.Parameters.Add("@REQ_APROB", OracleDbType.Varchar2).Value = ""
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub

    Private Sub UpdateRow(ByVal ELTBPROGPAGOBE As ELTBPROGPAGOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'If ELTBPROGPAGOBE.ANULAR = 1 Then
        '    cmd.CommandText = "SP_ELTBPROGPAGO_UPDROW_FC"
        'Else
        cmd.CommandText = "SP_ELTBPROGPAGO_UPDATEROW_FC"
        'End If
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.NRO_DOC_REF
        cmd.Parameters.Add("@nro_docu", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.NRO_DOCU
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBPROGPAGOBE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.EST
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.MONEDA
        cmd.Parameters.Add("@tprecio_compra", OracleDbType.Double).Value = ELTBPROGPAGOBE.TPRECIO_COMPRA
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = ELTBPROGPAGOBE.FEC_ANU
        cmd.Parameters.Add("@tprecio_dcompra", OracleDbType.Double).Value = ELTBPROGPAGOBE.TPRECIO_DCOMPRA
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.USUARIO
        cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.OBSERVA
        cmd.Parameters.Add("@t_igv", OracleDbType.Double).Value = ELTBPROGPAGOBE.T_IGV
        cmd.Parameters.Add("@t_igv_dolar", OracleDbType.Double).Value = ELTBPROGPAGOBE.T_IGV_DOLAR
        cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.PROVEEDOR
        cmd.Parameters.Add("@FEC_PROG", OracleDbType.Date).Value = ELTBPROGPAGOBE.FEC_PROG
        cmd.Parameters.Add("@T_OPE", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.T_OPE
        cmd.Parameters.Add("@COD_CBCO", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.COD_CBCO
        cmd.Parameters.Add("@EST_COBRA", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.EST_COBRA
        cmd.Parameters.Add("@ACT_FLUJO", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.ACT_FLUJO
        cmd.Parameters.Add("@FLUJO_CAJA", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.FLUJO_CAJA
        cmd.Parameters.Add("@EXT_BANC", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.EXT_BANC
        cmd.Parameters.Add("@NRO_DOCU1", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.NRO_DOCU1
        cmd.Parameters.Add("@FEC_VIGENCIA", OracleDbType.Date).Value = ELTBPROGPAGOBE.FEC_VIGENCIA
        cmd.Parameters.Add("@PERCEPCION", OracleDbType.Double).Value = ELTBPROGPAGOBE.NRO_PERCEPCION
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBPROGPAGO_DEL"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'cmd.Parameters.Add("@PROG_PAGO", OracleDbType.Double).Value = ELTBPROGPAGOBE.PROG_PAGO
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1


            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_ELTBDETPROGPAGO_INSFC1"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            DET_DOCUMENTOBE.OBSERVA = IIf(IsDBNull(RTrim(row.Cells("OBSERVA").Value)), "", RTrim(row.Cells("OBSERVA").Value))
            DET_DOCUMENTOBE.TPRECIO_COMPRA = IIf(IsDBNull(RTrim(row.Cells("TPRECIO_COMPRA").Value)), 0, RTrim(row.Cells("TPRECIO_COMPRA").Value))
            DET_DOCUMENTOBE.TPRECIO_DCOMPRA = IIf(IsDBNull(RTrim(row.Cells("TPRECIO_DCOMPRA").Value)), 0, RTrim(row.Cells("TPRECIO_DCOMPRA").Value))
            DET_DOCUMENTOBE.T_IGV = IIf(IsDBNull(RTrim(row.Cells("T_IGV").Value)), 0, RTrim(row.Cells("T_IGV").Value))
            DET_DOCUMENTOBE.T_IGV_DOLAR = IIf(IsDBNull(RTrim(row.Cells("T_IGV_DOLAR").Value)), 0, RTrim(row.Cells("T_IGV_DOLAR").Value))
            DET_DOCUMENTOBE.USUARIO = IIf(IsDBNull(RTrim(row.Cells("USUARIO").Value)), "", RTrim(row.Cells("USUARIO").Value))
            DET_DOCUMENTOBE.MONEDA = IIf(IsDBNull(RTrim(row.Cells("MONEDA").Value)), "", RTrim(row.Cells("MONEDA").Value))
            DET_DOCUMENTOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells("FEC_GENE").Value)), "", RTrim(row.Cells("FEC_GENE").Value))
            DET_DOCUMENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR").Value)), "", RTrim(row.Cells("PROVEEDOR").Value))
            DET_DOCUMENTOBE.FEC_VENCIMIENTO = IIf(IsDBNull(RTrim(row.Cells("FEC_VEN").Value)), "", RTrim(row.Cells("FEC_VEN").Value))
            DET_DOCUMENTOBE.F_PAGO_ENT = IIf(IsDBNull(RTrim(row.Cells("F_PAGO_ENT").Value)), "", RTrim(row.Cells("F_PAGO_ENT").Value))
            DET_DOCUMENTOBE.CUENTA = IIf(IsDBNull(RTrim(row.Cells("CTA_CBCO").Value)), "", RTrim(row.Cells("CTA_CBCO").Value))
            DET_DOCUMENTOBE.X_RET = IIf(IsDBNull(RTrim(row.Cells("X_RET").Value)), "", RTrim(row.Cells("X_RET").Value))
            DET_DOCUMENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells("SIGNO").Value)), "", RTrim(row.Cells("SIGNO").Value))
            If IIf(IsDBNull(RTrim(row.Cells("STATUS").Value)), "", RTrim(row.Cells("STATUS").Value)) = "AFECTO" Then
                DET_DOCUMENTOBE.STATUS = "S"
            Else
                DET_DOCUMENTOBE.STATUS = "N"
            End If

            DET_DOCUMENTOBE.T_OPE_COD = IIf(IsDBNull(RTrim(row.Cells("T_OPE").Value)), "", RTrim(row.Cells("T_OPE").Value))
            DET_DOCUMENTOBE.OBSERVA1 = IIf(IsDBNull(RTrim(row.Cells("OBSERVA2").Value)), "", RTrim(row.Cells("OBSERVA2").Value))
            DET_DOCUMENTOBE.CUENTA_DEST = IIf(IsDBNull(RTrim(row.Cells("CTA_COD_DEST").Value)), "", RTrim(row.Cells("CTA_COD_DEST").Value))
            DET_DOCUMENTOBE.CUENTITA = IIf(IsDBNull(RTrim(row.Cells("CUENTITA").Value)), "", RTrim(row.Cells("CUENTITA").Value))
            DET_DOCUMENTOBE.T_CAMB = IIf(IsDBNull(RTrim(row.Cells("T_CMB").Value)), "", RTrim(row.Cells("T_CMB").Value))
            DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells("CCO_COD").Value)), "", RTrim(row.Cells("CCO_COD").Value))
            DET_DOCUMENTOBE.RETEN = IIf(IsDBNull(RTrim(row.Cells("RETEN").Value)), "", RTrim(row.Cells("RETEN").Value))
            DET_DOCUMENTOBE.REG_NRO = IIf(IsDBNull(RTrim(row.Cells("REG_NRO").Value)), "", RTrim(row.Cells("REG_NRO").Value))
            ELTBPROGPAGOBE.MONTO_PAGADO = IIf(IsDBNull(RTrim(row.Cells("MONTO_PAGADO").Value)), "", RTrim(row.Cells("MONTO_PAGADO").Value))
            ELTBPROGPAGOBE.MONTO_PAGADOD = IIf(IsDBNull(RTrim(row.Cells("MONTO_DPAGADO").Value)), "", RTrim(row.Cells("MONTO_DPAGADO").Value))
            DET_DOCUMENTOBE.NUEVO = IIf(IsDBNull(RTrim(row.Cells("NUEVO").Value)), "", RTrim(row.Cells("NUEVO").Value))


            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.T_DOC_REF
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.SER_DOC_REF
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.NRO_DOC_REF
            cmd.Parameters.Add("@T_DOC_REF1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
            cmd.Parameters.Add("@SER_DOC_REF1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
            cmd.Parameters.Add("@NRO_DOC_REF1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
            cmd.Parameters.Add("@OBSERVA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
            cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = DET_DOCUMENTOBE.TPRECIO_COMPRA
            cmd.Parameters.Add("@TPRECIO_DCOMPRA", OracleDbType.Double).Value = DET_DOCUMENTOBE.TPRECIO_DCOMPRA
            cmd.Parameters.Add("@T_IGV", OracleDbType.Double).Value = DET_DOCUMENTOBE.T_IGV
            cmd.Parameters.Add("@T_IGV_DOLAR", OracleDbType.Double).Value = DET_DOCUMENTOBE.T_IGV_DOLAR
            cmd.Parameters.Add("@USUARIO", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.MONEDA
            cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_GENE
            cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PROVEEDOR
            cmd.Parameters.Add("@FEC_VEN", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_VENCIMIENTO
            cmd.Parameters.Add("@F_PAGO_ENT", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT
            cmd.Parameters.Add("@CUENTA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CUENTA
            cmd.Parameters.Add("@X_RET", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.X_RET
            cmd.Parameters.Add("@SIGNO", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO
            cmd.Parameters.Add("@STATUS", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.STATUS
            cmd.Parameters.Add("@T_OPE_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_OPE_COD
            cmd.Parameters.Add("@OBSERVA2", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA1
            cmd.Parameters.Add("@CUENTA_DEST", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CUENTA_DEST
            cmd.Parameters.Add("@CUENTITA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CUENTITA
            cmd.Parameters.Add("@T_CMB", OracleDbType.Double).Value = DET_DOCUMENTOBE.T_CAMB
            cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CCO_COD
            cmd.Parameters.Add("@RETEN", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.RETEN
            cmd.Parameters.Add("@REG_NRO", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.REG_NRO
            cmd.Parameters.Add("@pMONTO_PAGO", OracleDbType.Double).Value = ELTBPROGPAGOBE.MONTO_PAGADO
            cmd.Parameters.Add("@pMONTO_DPAGO", OracleDbType.Double).Value = ELTBPROGPAGOBE.MONTO_PAGADOD
            cmd.Parameters.Add("@pNUEVO", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NUEVO
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        'cont = 0
        'For Each row As DataGridViewRow In dg.Rows
        '    cont = cont + 1
        '    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        '    cmd.CommandText = "SP_ELTBPROGPAGO_UPDREQ_APROB"
        '    cmd.Connection = sqlCon
        '    cmd.Transaction = sqlTrans
        '    cmd.CommandType = CommandType.StoredProcedure
        '    DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(Trim(row.Cells("T_DOC_REF1").Value)), "", Trim(row.Cells("T_DOC_REF1").Value))
        '    DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(Trim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
        '    DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(Trim(row.Cells("NRO_DOC_REF1").Value)), "", Trim(row.Cells("NRO_DOC_REF1").Value))
        '    DET_DOCUMENTOBE.PROVEEDOR = IIf(IsDBNull(Trim(row.Cells("PROVEEDOR").Value)), "", Trim(row.Cells("PROVEEDOR").Value))

        '    cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
        '    cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
        '    cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
        '    cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PROVEEDOR
        '    cmd.Parameters.Add("@REQ_APROB", OracleDbType.Varchar2).Value = ""
        '    cmd.ExecuteNonQuery()
        '    cmd.Dispose()
        'Next
    End Sub

    Private Sub UpdateRowAnularFC(ByVal ELTBPROGPAGOBE As ELTBPROGPAGOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBPROGPAGO_UPDATE_ANUFC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.T_DOC_REF
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.SER_DOC_REF
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.NRO_DOC_REF
        cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.PROVEEDOR
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = "A"
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBPROGPAGO_UPDREQ_APROB"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
        cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PROVEEDOR
        cmd.Parameters.Add("@REQ_APROB", OracleDbType.Varchar2).Value = ""
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETPROGPAGO_DELETE"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.T_DOC_REF
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.SER_DOC_REF
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.NRO_DOC_REF
        cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = ELTBPROGPAGOBE.PROVEEDOR
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Public Function SelectT_OPE(ByVal sFec As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBPROGPAGO_T_OPE", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sFec", sFec)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectBanco() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBPROGPAGO_CBCO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAct_flujo() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBPROGPAGO_ACT_FLUJO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectFlujo_caja(ByVal sTope As String, ByVal sAflu As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBPROGPAGO_ACT_FLUJO_CAJA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_OPE_COD", sTope),
                                                                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@ACTIV_COD", sAflu)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectCuenta(ByVal sFec As String, ByVal sCuenta As String) As String
        Try
            sPrueba = ""
            Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
            Dim dt As New DataTable
            Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDETPROGPAGO_CTADEST", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pCod", Trim(sFec)),
                                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@pCod", Trim(sCuenta))})
                While dr.Read
                    sPrueba = dr.GetString(0)
                End While
            End Using
            Return sPrueba
        Catch ex As Exception

        End Try
        Return sPrueba
    End Function
    Public Function AsientoFC(ByVal flagAccion As String, ByVal sNro As String, ByVal sSer As String,
                              ByVal sTipo As String, ByVal sProv As String, ByVal dg As DataGridView,
                              ByVal anhomes As String) As String
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
                Asiento(cn, sqlTrans, sNro, sSer, sTipo, sProv, dg, anhomes)
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
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sNro As String, ByVal sSer As String, ByVal sTipo As String, ByVal sProv As String,
                       ByVal dg As DataGridView, ByVal anhomes As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CONTPROGPAGO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("@sAño", OracleDbType.Varchar2).Value = Trim(sAño)
        'cmd.Parameters.Add("@sMes", OracleDbType.Varchar2).Value = Trim(sMes)
        cmd.Parameters.Add("@numero11", OracleDbType.Varchar2).Value = sNro
        cmd.Parameters.Add("@serie11", OracleDbType.Varchar2).Value = sSer
        cmd.Parameters.Add("@tipo11", OracleDbType.Varchar2).Value = sTipo
        'cmd.Parameters.Add("@sEst", OracleDbType.Varchar2).Value = sEst
        cmd.Parameters.Add("@prov", OracleDbType.Varchar2).Value = sProv
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
End Class
