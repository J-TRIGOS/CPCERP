Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELPAGO_DOCUMENTODAL

    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String

    Public Function SelectTipodocCOD(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_TDOC_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectMonCOD(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_MON_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectProveedorCOD(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_PROVEEDOR_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelPerAll(ByVal var As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_ROT_All", {New Oracle.ManagedDataAccess.Client.OracleParameter("@var", var)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectTipoC(ByVal var As DateTime) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PAGO_DOCUMENTO_TC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@var", var)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Public Function SelectAll(ByVal ANHO As String, ByVal MES As String, ByVal ope As String, ByVal mon As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PAGO_DOCUMENTO_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ANHO", ANHO),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", MES),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@OPE", ope),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@MON", mon)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarCtaBanco(ByVal bcoCod As String, ByVal anho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_CTA_BANCO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@BCOCOD", bcoCod),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@MANHO", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectTipodoc() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_T_DOCUMENTO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarCentroCosto() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SEL_CCOCOD", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectMoneda() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_MONEDA", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectProveedor() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_PROVEEDOR", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectCentroCosto() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_CECOSTO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectCentroCosto1() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_CCOSTO1", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectCentroCostoCOD(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_CENCOSTO_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function list1(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String, ByVal registro As String,
                         ByVal moneda As String, ByVal proveedor As String, ByVal var1 As String, ByVal gendesde As Date,
                         ByVal genhasta As Date, ByVal T_OPE As String) As DataTable

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PAGO_DOCUMENTO_SEARCH", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)), New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)), New Oracle.ManagedDataAccess.Client.OracleParameter("@REGISTRO", Trim(registro)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@MONEDA", Trim(moneda)), New Oracle.ManagedDataAccess.Client.OracleParameter("@PROVEEDOR", Trim(proveedor)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@VAR1", Trim(var1)), New Oracle.ManagedDataAccess.Client.OracleParameter("@GENDESDE", gendesde),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@GENHASTA", genhasta), New Oracle.ManagedDataAccess.Client.OracleParameter("@T_OPE", T_OPE)})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function

    Public Function SelectRow(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PAGO_DOCUMENTO_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sTDoc", sTDoc),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@sSDoc", sSDoc),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@sNDoc", sNDoc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRowDetalle(ByVal sTdoc As String, ByVal sSDoc As String, ByVal sNDoc As String, ByVal sCos As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PAGO_DOCUMENTO_SELEDET", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sTDoc", sTdoc),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@sSDoc", sSDoc),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@sNDoc", sNDoc),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@sCos", sCos)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SaveRow(ByVal ELPAGO_DOCUMENTOBE As ELPAGO_DOCUMENTOBE, ByVal flagAccion As String, ByVal dg As DataGridView, ByVal ELPAGO_DET_DOCUMENTOBE As ELPAGO_DET_DOCUMENTOBE) As String
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
                InsertRow(ELPAGO_DOCUMENTOBE, cn, sqlTrans, dg, ELPAGO_DET_DOCUMENTOBE)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELPAGO_DOCUMENTOBE, cn, sqlTrans, dg, ELPAGO_DET_DOCUMENTOBE)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELPAGO_DOCUMENTOBE, cn, sqlTrans)
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
            'If resultado = "OK" And flagAccion <> "E" Then
            '    cn.Dispose()
            'End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function

    Private Sub DeleteRow(ByVal ELPAGO_DOCUMENTOBE As ELPAGO_DOCUMENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DEL_PAGOCOBRANZA"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@OPE", OracleDbType.NVarchar2).Value = ELPAGO_DOCUMENTOBE.t_ope
        cmd.Parameters.Add("@TIP", OracleDbType.NVarchar2).Value = ELPAGO_DOCUMENTOBE.t_doc_ref
        cmd.Parameters.Add("@SER", OracleDbType.NVarchar2).Value = ELPAGO_DOCUMENTOBE.ser_doc_ref
        cmd.Parameters.Add("@NRO", OracleDbType.NVarchar2).Value = ELPAGO_DOCUMENTOBE.nro_doc_ref
        cmd.Parameters.Add("@REG", OracleDbType.NVarchar2).Value = ELPAGO_DOCUMENTOBE.regcontable
        cmd.Parameters.Add("@FEC", OracleDbType.Date).Value = ELPAGO_DOCUMENTOBE.fec_gene
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub InsertRow(ByVal ELPAGO_DOCUMENTOBE As ELPAGO_DOCUMENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView, ByVal ELPAGO_DET_DOCUMENTOBE As ELPAGO_DET_DOCUMENTOBE)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PAGO_DOCUMENTO_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_ope", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.t_ope
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.t_doc_ref
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.ser_doc_ref
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.nro_doc_ref
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELPAGO_DOCUMENTOBE.fec_gene
        cmd.Parameters.Add("@cbco_cod", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.cbco_cod
        cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = ELPAGO_DOCUMENTOBE.cantidad
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = ELPAGO_DOCUMENTOBE.fec_dia
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.moneda
        cmd.Parameters.Add("@est1", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.est1
        cmd.Parameters.Add("@concepto", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.concepto
        cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.proveedor
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.cco_cod
        cmd.Parameters.Add("@cobranza", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.cobranza
        cmd.Parameters.Add("@tipo1", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.tipo1
        cmd.Parameters.Add("@fec_vigencia", OracleDbType.Date).Value = ELPAGO_DOCUMENTOBE.fec_vigencia
        cmd.Parameters.Add("@reten", OracleDbType.Double).Value = ELPAGO_DOCUMENTOBE.reten
        cmd.Parameters.Add("@porcentaje", OracleDbType.Double).Value = ELPAGO_DOCUMENTOBE.porcentaje
        cmd.Parameters.Add("@fec_pago", OracleDbType.Date).Value = ELPAGO_DOCUMENTOBE.fec_pago
        cmd.Parameters.Add("@regcontable", OracleDbType.Double).Value = ELPAGO_DOCUMENTOBE.regcontable
        cmd.Parameters.Add("@pagoparcial", OracleDbType.Double).Value = ELPAGO_DOCUMENTOBE.pagoparcial
        cmd.Parameters.Add("@totalsoles", OracleDbType.Double).Value = ELPAGO_DOCUMENTOBE.totalsoles
        cmd.Parameters.Add("@totaldolar", OracleDbType.Double).Value = ELPAGO_DOCUMENTOBE.totaldolar
        cmd.Parameters.Add("@pTIPO07", OracleDbType.Varchar2).Value = ""
        cmd.Parameters.Add("@pEST_MERCANCIA", OracleDbType.Varchar2).Value = ""
        cmd.Parameters.Add("@pREG_NRO", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.regcontable
        cmd.Parameters.Add("@pTCAMBIOSBS", OracleDbType.Double).Value = ELPAGO_DOCUMENTOBE.tcambiosbs
        cmd.Parameters.Add("@pCTACOD", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.cta_cod
        cmd.Parameters.Add("@pUSUARIO", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.usuario
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PAGO_DOCUMENTO_INSDET"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            ELPAGO_DET_DOCUMENTOBE.t_doc_ref = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            ELPAGO_DET_DOCUMENTOBE.ser_doc_ref = IIf(IsDBNull(RTrim(row.Cells("SERIE_DOC_REF").Value)), "", RTrim(row.Cells("SERIE_DOC_REF").Value))
            ELPAGO_DET_DOCUMENTOBE.nro_doc_ref = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC").Value)), "", RTrim(row.Cells("NRO_DOC").Value))
            ELPAGO_DET_DOCUMENTOBE.afecto = IIf(IsDBNull(RTrim(row.Cells("afecto").Value)), "", RTrim(row.Cells("afecto").Value))
            ELPAGO_DET_DOCUMENTOBE.cuenta = IIf(IsDBNull(RTrim(row.Cells("cuenta").Value)), "", RTrim(row.Cells("cuenta").Value))
            ELPAGO_DET_DOCUMENTOBE.cuenta_Dest = IIf(IsDBNull(RTrim(row.Cells("cta_des").Value)), "", RTrim(row.Cells("cta_des").Value))
            ELPAGO_DET_DOCUMENTOBE.proveedor = IIf(IsDBNull(RTrim(row.Cells("codigo").Value)), "", RTrim(row.Cells("codigo").Value))
            ELPAGO_DET_DOCUMENTOBE.signo = IIf(IsDBNull(RTrim(row.Cells("signo").Value)), "", RTrim(row.Cells("signo").Value))
            ELPAGO_DET_DOCUMENTOBE.fec_gene = IIf(IsDBNull(RTrim(row.Cells("fecha").Value)), "", RTrim(row.Cells("fecha").Value))
            ELPAGO_DET_DOCUMENTOBE.t_cambio = IIf(IsDBNull(RTrim(row.Cells("t_Cambio").Value)), "", RTrim(row.Cells("t_cambio").Value))
            ELPAGO_DET_DOCUMENTOBE.mon = IIf(IsDBNull(RTrim(row.Cells("mon").Value)), "", RTrim(row.Cells("mon").Value))
            ELPAGO_DET_DOCUMENTOBE.tprecio_compra = IIf(IsDBNull(RTrim(row.Cells("t_soles").Value)), "0", RTrim(row.Cells("t_soles").Value))
            ELPAGO_DET_DOCUMENTOBE.tprecio_dcompra = IIf(IsDBNull(RTrim(row.Cells("t_dolares").Value)), "0", RTrim(row.Cells("t_dolares").Value))
            ELPAGO_DET_DOCUMENTOBE.o_compra = IIf(IsDBNull(RTrim(row.Cells("o_compra").Value)), "", RTrim(row.Cells("o_compra").Value))
            ELPAGO_DET_DOCUMENTOBE.tipo7 = IIf(IsDBNull(RTrim(row.Cells("CODFLUJO").Value)), "", RTrim(row.Cells("CODFLUJO").Value))
            ELPAGO_DET_DOCUMENTOBE.est_mercaderia = IIf(IsDBNull(RTrim(row.Cells("CODCAJA").Value)), "", RTrim(row.Cells("CODCAJA").Value))
            ELPAGO_DET_DOCUMENTOBE.t_ope_cod = ELPAGO_DOCUMENTOBE.t_ope
            ELPAGO_DET_DOCUMENTOBE.TEMPLE = IIf(IsDBNull(RTrim(row.Cells("ESTCOM").Value)), "", RTrim(row.Cells("ESTCOM").Value))
            ELPAGO_DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells("CCO_COD").Value)), "", RTrim(row.Cells("CCO_COD").Value))
            If Not ELPAGO_DET_DOCUMENTOBE.CCO_COD = "" Then
                ELPAGO_DET_DOCUMENTOBE.CCO_COD = ELPAGO_DET_DOCUMENTOBE.CCO_COD.ToString.Substring(0, 3)
            End If
            If ELPAGO_DOCUMENTOBE.t_ope = "013" And ELPAGO_DET_DOCUMENTOBE.CCO_COD = "" Then
                ELPAGO_DET_DOCUMENTOBE.CCO_COD = "306"
            End If

            Try
                If row.Cells("Reparar").EditedFormattedValue = True Then
                    ELPAGO_DET_DOCUMENTOBE.reparar = "1"
                Else
                    ELPAGO_DET_DOCUMENTOBE.reparar = "0"
                End If
            Catch ex As Exception
                ELPAGO_DET_DOCUMENTOBE.reparar = "0"
            End Try

            ''Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.t_doc_ref
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.ser_doc_ref
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.nro_doc_ref
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.t_doc_ref
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.ser_doc_ref
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.nro_doc_ref
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = "02170001"
            cmd.Parameters.Add("@afecto", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.afecto.Substring(0, 1)
            cmd.Parameters.Add("@cuenta", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.cuenta
            cmd.Parameters.Add("@cuenta_dest", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.cuenta_Dest
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.proveedor
            cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.proveedor
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.signo
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELPAGO_DET_DOCUMENTOBE.fec_gene
            cmd.Parameters.Add("@t_cambio", OracleDbType.Double).Value = ELPAGO_DET_DOCUMENTOBE.t_cambio
            cmd.Parameters.Add("@mon", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.mon
            cmd.Parameters.Add("@tprecio_compra", OracleDbType.Double).Value = ELPAGO_DET_DOCUMENTOBE.tprecio_compra
            cmd.Parameters.Add("@tprecio_dcompra", OracleDbType.Double).Value = ELPAGO_DET_DOCUMENTOBE.tprecio_dcompra
            cmd.Parameters.Add("@o_compra", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.o_compra
            cmd.Parameters.Add("@mt_ope_cod", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.t_ope_cod
            cmd.Parameters.Add("@mx_D", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.reparar
            cmd.Parameters.Add("@TIPO7", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.tipo7
            cmd.Parameters.Add("@EST_MERCADERIA", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.est_mercaderia.PadLeft(2, "0")
            cmd.Parameters.Add("@ESTCOM", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.TEMPLE
            cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.CCO_COD
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = PERBE.COD  'cod usu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo turno"
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub

    Private Sub UpdateRow(ByVal ELPAGO_DOCUMENTOBE As ELPAGO_DOCUMENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView, ByVal ELPAGO_DET_DOCUMENTOBE As ELPAGO_DET_DOCUMENTOBE)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PAGO_DOCUMENTO_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_ope", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.t_ope
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.t_doc_ref
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.ser_doc_ref
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.nro_doc_ref
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELPAGO_DOCUMENTOBE.fec_gene
        cmd.Parameters.Add("@cbco_cod", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.cbco_cod
        cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = ELPAGO_DOCUMENTOBE.cantidad
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = ELPAGO_DOCUMENTOBE.fec_dia
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.moneda
        cmd.Parameters.Add("@est1", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.est1
        cmd.Parameters.Add("@concepto", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.concepto
        cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.proveedor
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.cco_cod
        cmd.Parameters.Add("@cobranza", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.cobranza
        cmd.Parameters.Add("@tipo1", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.tipo1
        cmd.Parameters.Add("@fec_vigencia", OracleDbType.Date).Value = ELPAGO_DOCUMENTOBE.fec_vigencia
        cmd.Parameters.Add("@reten", OracleDbType.Double).Value = ELPAGO_DOCUMENTOBE.reten
        cmd.Parameters.Add("@porcentaje", OracleDbType.Double).Value = ELPAGO_DOCUMENTOBE.porcentaje
        cmd.Parameters.Add("@fec_pago", OracleDbType.Date).Value = ELPAGO_DOCUMENTOBE.fec_pago
        cmd.Parameters.Add("@regcontable", OracleDbType.Double).Value = ELPAGO_DOCUMENTOBE.regcontable
        cmd.Parameters.Add("@totalsoles", OracleDbType.Double).Value = ELPAGO_DOCUMENTOBE.totalsoles
        cmd.Parameters.Add("@totaldolar", OracleDbType.Double).Value = ELPAGO_DOCUMENTOBE.totaldolar
        cmd.Parameters.Add("@pTIPO07", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.tipo07
        cmd.Parameters.Add("@pEST_MERCANCIA", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.est_mercancia
        cmd.Parameters.Add("@pTCAMBIOSBS", OracleDbType.Double).Value = ELPAGO_DOCUMENTOBE.tcambiosbs
        cmd.Parameters.Add("@pCTACOD", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.cta_cod
        cmd.Parameters.Add("@pUSUACT", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.usuario
        cmd.Parameters.Add("@reg_nro", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.reg_contable1
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'ELIMINAR DETALLE PAGO DOCUMENTO
        cmd.Parameters.Add("@pagoparcial", OracleDbType.Double).Value = ELPAGO_DOCUMENTOBE.pagoparcial
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PAGO_DOCUMENTO_DEL_DETALLE"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.t_doc_ref
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.ser_doc_ref
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.nro_doc_ref
        cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.proveedor
        cmd.Parameters.Add("@t_ope", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.t_ope
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        'ELIMINAR DETALLE PAGO DOCUMENTO

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PAGO_DOCUMENTO_INSDET"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            ELPAGO_DET_DOCUMENTOBE.t_doc_ref = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            ELPAGO_DET_DOCUMENTOBE.ser_doc_ref = IIf(IsDBNull(RTrim(row.Cells("SERIE_DOC_REF").Value)), "", RTrim(row.Cells("SERIE_DOC_REF").Value))
            ELPAGO_DET_DOCUMENTOBE.nro_doc_ref = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC").Value)), "", RTrim(row.Cells("NRO_DOC").Value))
            ELPAGO_DET_DOCUMENTOBE.afecto = IIf(IsDBNull(RTrim(row.Cells("afecto").Value)), "", RTrim(row.Cells("afecto").Value))
            ELPAGO_DET_DOCUMENTOBE.cuenta = IIf(IsDBNull(RTrim(row.Cells("cuenta").Value)), "", RTrim(row.Cells("cuenta").Value))
            ELPAGO_DET_DOCUMENTOBE.cuenta_Dest = IIf(IsDBNull(RTrim(row.Cells("cta_des").Value)), "", RTrim(row.Cells("cta_des").Value))
            ELPAGO_DET_DOCUMENTOBE.proveedor = IIf(IsDBNull(RTrim(row.Cells("codigo").Value)), "", RTrim(row.Cells("codigo").Value))
            ELPAGO_DET_DOCUMENTOBE.signo = IIf(IsDBNull(RTrim(row.Cells("signo").Value)), "", RTrim(row.Cells("signo").Value))
            ELPAGO_DET_DOCUMENTOBE.fec_gene = IIf(IsDBNull(RTrim(row.Cells("fecha").Value)), "", RTrim(row.Cells("fecha").Value))
            ELPAGO_DET_DOCUMENTOBE.t_cambio = IIf(IsDBNull(RTrim(row.Cells("t_Cambio").Value)), "", RTrim(row.Cells("t_cambio").Value))
            ELPAGO_DET_DOCUMENTOBE.mon = IIf(IsDBNull(RTrim(row.Cells("mon").Value)), "", RTrim(row.Cells("mon").Value))
            ELPAGO_DET_DOCUMENTOBE.tprecio_compra = IIf(IsDBNull(RTrim(row.Cells("t_soles").Value)), "0", RTrim(row.Cells("t_soles").Value))
            ELPAGO_DET_DOCUMENTOBE.tprecio_dcompra = IIf(IsDBNull(RTrim(row.Cells("t_dolares").Value)), "0", RTrim(row.Cells("t_dolares").Value))
            ELPAGO_DET_DOCUMENTOBE.o_compra = IIf(IsDBNull(RTrim(row.Cells("o_compra").Value)), "", RTrim(row.Cells("o_compra").Value))
            ELPAGO_DET_DOCUMENTOBE.t_ope_cod = ELPAGO_DOCUMENTOBE.t_ope
            ELPAGO_DET_DOCUMENTOBE.tipo7 = IIf(IsDBNull(RTrim(row.Cells("CODFLUJO").Value)), "", RTrim(row.Cells("CODFLUJO").Value))
            ELPAGO_DET_DOCUMENTOBE.est_mercaderia = IIf(IsDBNull(RTrim(row.Cells("CODCAJA").Value)), "", RTrim(row.Cells("CODCAJA").Value))
            ELPAGO_DET_DOCUMENTOBE.TEMPLE = IIf(IsDBNull(RTrim(row.Cells("ESTCOM").Value)), "", RTrim(row.Cells("ESTCOM").Value))
            ELPAGO_DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells("CCO_COD").Value)), "", RTrim(row.Cells("CCO_COD").Value))
            If Not ELPAGO_DET_DOCUMENTOBE.CCO_COD = "" Then
                ELPAGO_DET_DOCUMENTOBE.CCO_COD = ELPAGO_DET_DOCUMENTOBE.CCO_COD.ToString.Substring(0, 3)

            End If
            If ELPAGO_DOCUMENTOBE.t_ope = "010" Then
                Try
                    If row.Cells("Reparar").EditedFormattedValue = True Then
                        If cont = 1 Then
                            ELPAGO_DET_DOCUMENTOBE.reparar = "0"
                        Else
                            ELPAGO_DET_DOCUMENTOBE.reparar = "1"
                        End If
                        'ELPAGO_DET_DOCUMENTOBE.reparar = "1"
                    Else
                        If cont = 1 Then
                            ELPAGO_DET_DOCUMENTOBE.reparar = "1"
                        Else
                            ELPAGO_DET_DOCUMENTOBE.reparar = "0"
                        End If
                    End If
                Catch ex As Exception
                    ELPAGO_DET_DOCUMENTOBE.reparar = "0"
                End Try
            End If

            If ELPAGO_DOCUMENTOBE.t_ope = "013" Then
                If row.Cells("Reparar").EditedFormattedValue = True Then
                    ELPAGO_DET_DOCUMENTOBE.reparar = "1"
                Else
                    ELPAGO_DET_DOCUMENTOBE.reparar = "0"
                End If
            End If
            'ELPAGO_DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells("CCO_COD").Value)), "", RTrim(row.Cells("CCO_COD").Value))
            'If Not ELPAGO_DET_DOCUMENTOBE.CCO_COD = "" Then
            '    ELPAGO_DET_DOCUMENTOBE.CCO_COD = ELPAGO_DET_DOCUMENTOBE.CCO_COD.ToString.Substring(0, 3)
            'End If
            If ELPAGO_DOCUMENTOBE.t_ope = "013" And ELPAGO_DET_DOCUMENTOBE.CCO_COD = "" Then
                ELPAGO_DET_DOCUMENTOBE.CCO_COD = "306"
            End If
            ''Los parametros que va recibir son las propiedades de la clase

            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.t_doc_ref
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.ser_doc_ref
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.nro_doc_ref
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.t_doc_ref
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.ser_doc_ref
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.nro_doc_ref
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = "02170001"
            cmd.Parameters.Add("@afecto", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.afecto.Substring(0, 1)
            cmd.Parameters.Add("@cuenta", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.cuenta
            cmd.Parameters.Add("@cuenta_dest", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.cuenta_Dest
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.proveedor
            cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = ELPAGO_DOCUMENTOBE.proveedor
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.signo
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELPAGO_DET_DOCUMENTOBE.fec_gene
            cmd.Parameters.Add("@t_cambio", OracleDbType.Double).Value = ELPAGO_DET_DOCUMENTOBE.t_cambio
            cmd.Parameters.Add("@mon", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.mon
            cmd.Parameters.Add("@tprecio_compra", OracleDbType.Double).Value = ELPAGO_DET_DOCUMENTOBE.tprecio_compra
            cmd.Parameters.Add("@tprecio_dcompra", OracleDbType.Double).Value = ELPAGO_DET_DOCUMENTOBE.tprecio_dcompra
            cmd.Parameters.Add("@o_compra", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.o_compra
            cmd.Parameters.Add("@mt_ope_cod", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.t_ope_cod
            cmd.Parameters.Add("@mx_D", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.reparar
            cmd.Parameters.Add("@TIPO7", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.tipo7
            cmd.Parameters.Add("@EST_MERCADERIA", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.est_mercaderia.PadLeft(2, "0")
            cmd.Parameters.Add("@ESTCOM", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.TEMPLE
            cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = ELPAGO_DET_DOCUMENTOBE.CCO_COD
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next


        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELCONTRATOBE.codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el contrato de: " + ELCONTRATOBE.dni
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub

    Public Function VerificarRepetido(ByVal cod As String) As Boolean
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LIB_CONT_VERIFICAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod)})
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function



    Public Function SaveRowRegCont(ByVal MOV_CTBE As MOV_CTBE, ByVal flagaccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction
        Try
            If flagaccion = "N" Then
                InsertRowRegCont(MOV_CTBE, cn, sqlTrans)
            End If

            If flagaccion = "M" Then
                'UpdateRow(ELPAGO_DOCUMENTOBE, cn, sqlTrans, dg, ELPAGO_DET_DOCUMENTOBE)
            End If

            If flagaccion = "E" Then
                
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

    Public Sub InsertRowRegCont(ByVal MOV_CTBE As MOV_CTBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_REGCONT_PAGO_COBRANZA"
        'cmd.CommandText = "SP_REGCONT_PAGO_COBRANZA_T"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@MANHO", OracleDbType.NVarchar2).Value = MOV_CTBE.ANHO
        cmd.Parameters.Add("@MMES", OracleDbType.NVarchar2).Value = MOV_CTBE.MES
        cmd.Parameters.Add("@MT_OPE_COD", OracleDbType.NVarchar2).Value = MOV_CTBE.T_OPE_COD
        cmd.Parameters.Add("@MREG_NRO", OracleDbType.NVarchar2).Value = MOV_CTBE.REG_NRO
        cmd.Parameters.Add("@MSEQ", OracleDbType.Int16).Value = MOV_CTBE.SEQ
        cmd.Parameters.Add("@MCTA_COD", OracleDbType.NVarchar2).Value = MOV_CTBE.CTA_COD
        cmd.Parameters.Add("@MCONTRA_CTA_COD", OracleDbType.NVarchar2).Value = MOV_CTBE.CONTRA_CTA_COD
        cmd.Parameters.Add("@MCTCT_COD", OracleDbType.NVarchar2).Value = MOV_CTBE.CTCT_COD
        cmd.Parameters.Add("@MFEC", OracleDbType.NVarchar2).Value = MOV_CTBE.FEC
        cmd.Parameters.Add("@MSERIE_NRO", OracleDbType.NVarchar2).Value = MOV_CTBE.SERIE_NRO
        cmd.Parameters.Add("@MT_DOC_COD", OracleDbType.NVarchar2).Value = MOV_CTBE.T_DOC_COD
        cmd.Parameters.Add("@MMON_COD", OracleDbType.NVarchar2).Value = MOV_CTBE.MON_COD
        cmd.Parameters.Add("@MCCO_COD", OracleDbType.NVarchar2).Value = MOV_CTBE.CCO_COD
        cmd.Parameters.Add("@MFUENTE_COD", OracleDbType.NVarchar2).Value = MOV_CTBE.FUENTE_COD
        cmd.Parameters.Add("@MPROY_COD", OracleDbType.NVarchar2).Value = MOV_CTBE.PROY_COD
        cmd.Parameters.Add("@MCHEQ_NRO", OracleDbType.NVarchar2).Value = MOV_CTBE.CHEQ_NRO
        cmd.Parameters.Add("@MCOMP_CPTO", OracleDbType.NVarchar2).Value = MOV_CTBE.COMP_CPTO
        cmd.Parameters.Add("@MCOMP_FEC", OracleDbType.NVarchar2).Value = MOV_CTBE.COMP_FEC
        cmd.Parameters.Add("@MCOMP_NRO", OracleDbType.NVarchar2).Value = MOV_CTBE.COMP_NRO
        cmd.Parameters.Add("@MIMPOR", OracleDbType.Double).Value = MOV_CTBE.IMPOR
        cmd.Parameters.Add("@MIMPOR_ME", OracleDbType.Double).Value = MOV_CTBE.IMPOR_ME
        cmd.Parameters.Add("@MPROG_FEC", OracleDbType.NVarchar2).Value = MOV_CTBE.PROG_FEC
        cmd.Parameters.Add("@MRUC", OracleDbType.NVarchar2).Value = MOV_CTBE.RUC
        cmd.Parameters.Add("@MSIGNO", OracleDbType.NVarchar2).Value = MOV_CTBE.SIGNO
        cmd.Parameters.Add("@MT_CMB", OracleDbType.Double).Value = MOV_CTBE.T_CMB
        cmd.Parameters.Add("@MX_PROV", OracleDbType.NVarchar2).Value = MOV_CTBE.X_PROV
        cmd.Parameters.Add("@MUSUARIO", OracleDbType.NVarchar2).Value = MOV_CTBE.USUARIO
        cmd.Parameters.Add("@MLABOR_COD", OracleDbType.NVarchar2).Value = MOV_CTBE.labor_cod
        cmd.Parameters.Add("@MT_EST_TES_COD", OracleDbType.NVarchar2).Value = MOV_CTBE.t_est_tes_cod
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Public Function ObtenerImporteRegCont(ByVal anho As String, ByVal mes As String, ByVal ope As String, ByVal regCont As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CALCULO_IMP_PAGOCOBRANZA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@MANHO", anho),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@MMES", mes),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@MOPE", ope),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@MREGCONT", regCont)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ActualizarRegContable(ByVal MOV_CTBE As MOV_CTBE, ByVal prefBanco As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ACT_REGCONT_PAGCOB", {New Oracle.ManagedDataAccess.Client.OracleParameter("@MANHO", MOV_CTBE.ANHO),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@MMES", MOV_CTBE.MES),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@MOPE", MOV_CTBE.T_OPE_COD),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@MREGISTRO", MOV_CTBE.REG_NRO),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@PREFIJO", prefBanco)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function VerificarNumeroDoc(ByVal opeDoc As String, ByVal tipoDoc As String, ByVal serDoc As String, ByVal numDoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_VERIFICAR_NUMERO_PAGO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@OPEDOC", opeDoc),
                                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@TIPODOC", tipoDoc),
                                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@SERDOC", serDoc),
                                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@NUMDOC", numDoc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function VerificarTCSBS(ByVal ope As String, ByVal fecha As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_VERIFICAR_TCSBS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@OPE", ope),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@FECHA", fecha)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function VerificarDiferenciaTC(ByVal regCont As String, ByVal mes As String, ByVal anho As String, ByVal ope As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_VERIFICAR_DIFERENCIATC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@REGCONT", regCont),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@MMES", mes),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@MANHO", anho),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@OPE", ope)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ActualizarDiferenciaTC(ByVal regCont As String, ByVal mes As String, ByVal anho As String, ByVal ope As String, ByVal dif As Double) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ACTUALIZAR_DIF_TC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@REGCONT", regCont),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@MMES", mes),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@MANHO", anho),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@OPE", ope),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@DIFERENCIA", dif)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectProvAllFiltro(ByVal saño As String, ByVal smes As String, ByVal tipo As String,
                                  ByVal serie As String, ByVal nro As String, ByVal reg_nro As String,
                                  ByVal ruc As String, ByVal saño1 As String, ByVal smes1 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PAGO_DOCUMENTO_FILTRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ANHO", saño), New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", smes),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@TIPO", tipo), New Oracle.ManagedDataAccess.Client.OracleParameter("@SERIE", serie),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO", nro), New Oracle.ManagedDataAccess.Client.OracleParameter("@REG_NRO", reg_nro),
                                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@RUC", ruc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectFactAllFiltro(ByVal saño As String, ByVal smes As String, ByVal tipo As String,
                                  ByVal serie As String, ByVal nro As String, ByVal reg_nro As String,
                                  ByVal ruc As String, ByVal saño1 As String, ByVal smes1 As String, ByVal obs As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_FACTURA_DOCUMENTO_FILTRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ANHO", saño), New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", smes),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@TIPO", tipo), New Oracle.ManagedDataAccess.Client.OracleParameter("@SERIE", serie),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO", nro), New Oracle.ManagedDataAccess.Client.OracleParameter("@REG_NRO", reg_nro),
                                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@RUC", ruc), New Oracle.ManagedDataAccess.Client.OracleParameter("@observa1", obs)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarCtasDestino(ByVal cta As String, ByVal anho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_CTA_DEST_DEST", {New Oracle.ManagedDataAccess.Client.OracleParameter("@CTA", cta),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@ANHO", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function actualizarTablaMOVCT(ByVal MOV_CTBE As MOV_CTBE, ByVal mmes As String, ByVal manho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ACTUALIZAR_MOVCT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@OPE", MOV_CTBE.T_OPE_COD),
                                                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("@REGCONT", MOV_CTBE.REG_NRO),
                                                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("@MMES", mmes),
                                                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("@MANHO", manho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ContarMovctTemporal(ByVal ope As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CONTAR_AC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@OPE", ope)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Sub ProcesarMovctTemporal(ByVal ope As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PROCESAR_MOVCTTEMPORAL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@MOPE", ope)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
    End Sub

    Public Function ListadoGuiasFact(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_RPT_FACT_GUIADES", {New Oracle.ManagedDataAccess.Client.OracleParameter("@MMES", mes),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@MANHO", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SaveRowAllMes(ByVal flagAccion As String, ByVal sAño As String, ByVal sMes As String, ByVal tope As String, ByVal usuario As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try
            If flagAccion = "AsAll" Then
                AsientoAll(cn, sAño, sMes, sqlTrans, tope, usuario)
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
    Public Sub AsientoAll(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sAño As String, ByVal sMes As String,
                        ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal tope As String, ByVal usuario As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CONTPAGOS_C"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sAño", OracleDbType.Varchar2).Value = Trim(sAño)
        cmd.Parameters.Add("@sMes", OracleDbType.Varchar2).Value = Trim(sMes)
        cmd.Parameters.Add("@sNro", OracleDbType.Varchar2).Value = tope
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

End Class

