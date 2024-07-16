Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBKARDEXIMPDAL
    Inherits BaseDatosORACLE
    Public sPrueba As String = ""
    Public sPruebaS As Double = 0
    Dim cont_kard As Integer = 0
    Function list2(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
              ByVal fec As Date) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBKARDEXIMP_SEARCH", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", Trim(fec))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function

    Function list(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBKARDEXIMP_SEARCH1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function listnodom(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBKARDEXIMP_NODOM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function list3(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBKARDEXIMP_SEARCH3", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Public Function SelectAll(ByVal sT_doc As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBKARDEXIMP_SEL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getListdgv2(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sOP As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBKARDEXIMP_SELALL1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sOP)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function getListdgv4(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBKARDEXIMP_SELALL4", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
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
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBKARDEXIMP_SELALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
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

    Public Function LastCodigo(ByVal sS_doc As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBKARDEXIMP_LASTCODIGO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Public Function SelectT_Prov(ByVal sCod As String) As String
        sPrueba = ""
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_PROV_OC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pCod", Trim(sCod))})
            While dr.Read
                sPrueba = dr.GetString(1)
            End While
        End Using
        Return sPrueba
    End Function
    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBKARDEXIMP_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRowdET(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDETKARDEXIMP_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRowCost(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBKARDEXIMPCOS_SEL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelRowDatosAncho(ByVal sCod As String) As Double
        sPrueba = ""
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_KARIMPANC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pCod", Trim(sCod))})
            While dr.Read
                sPrueba = dr.GetDouble(0)
            End While
        End Using
        Return sPrueba
    End Function

    Public Function SelRowDatosLar(ByVal sCod As String) As Double
        sPrueba = ""
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_KARIMPLAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pCod", Trim(sCod))})
            While dr.Read
                sPrueba = dr.GetDouble(0)
            End While
        End Using
        Return sPrueba
    End Function

    Public Function SelRowDatosdATO(ByVal sCod As String) As Double
        sPruebaS = 0
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_KARIMPDATO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pCod", Trim(sCod))})
            While dr.Read
                sPruebaS = dr.GetDouble(0)
            End While
        End Using
        Return sPruebaS
    End Function

    Public Function SelRowPeso(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String, ByVal sADoc As String, ByVal sNDoc1 As String) As Double
        sPruebaS = 0
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_KARIMPCOSPESO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sTDoc", Trim(sTDoc)),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@sSDoc", Trim(sSDoc)),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@sNDoc", Trim(sNDoc)),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@sADoc", Trim(sADoc)),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@sNDoc1", Trim(sNDoc1))})
            While dr.Read
                sPruebaS = dr.GetDouble(0)
            End While
        End Using
        Return sPruebaS
    End Function

    Public Function SelRowPesoNOMDOM(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String, ByVal sADoc As String, ByVal sNDoc1 As String) As Double
        sPruebaS = 0
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_KARIMPCOSPESONODOM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sTDoc", Trim(sTDoc)),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@sSDoc", Trim(sSDoc)),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@sNDoc", Trim(sNDoc)),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@sADoc", Trim(sADoc)),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@sNDoc1", Trim(sNDoc1))})
            While dr.Read
                sPruebaS = dr.GetDouble(0)
            End While
        End Using
        Return sPruebaS
    End Function

    Public Function SaveRow(ByVal ELTBKARDEXIMPBE As ELTBKARDEXIMPBE, ByVal ELTBDETKARDEXIMPBE As ELTBDETKARDEXIMPBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
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
                InsertRow(ELTBKARDEXIMPBE, ELTBDETKARDEXIMPBE, ELMVLOGSBE, cn, sqlTrans, dg)
            End If
            If flagAccion = "M" Then
                UpdateRow(ELTBKARDEXIMPBE, ELTBDETKARDEXIMPBE, ELMVLOGSBE, cn, sqlTrans, dg)
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
    Public Function SaveRowCos(ByVal ELTBKARDEXIMPCOSBE As ELTBKARDEXIMPCOSBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
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
            If flagAccion <> "Limpiar" Then
                InsertRowCos(ELTBKARDEXIMPCOSBE, ELMVLOGSBE, cn, sqlTrans, dg)
            Else
                InsertRowLimpiar(ELTBKARDEXIMPCOSBE, ELMVLOGSBE, cn, sqlTrans, dg)
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
    Private Sub InsertRow(ByVal ELTBKARDEXIMPBE As ELTBKARDEXIMPBE, ByVal ELTBDETKARDEXIMPBE As ELTBDETKARDEXIMPBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        'Dim contenedor As String
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim dia As String = System.DateTime.Now
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBKARDEXIMP_INS"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.NRO_DOC_REF
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBKARDEXIMPBE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.EST
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.MONEDA
        cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = ELTBKARDEXIMPBE.TPRECIO_COMPRA
        cmd.Parameters.Add("@TPRECIO_DCOMPRA", OracleDbType.Double).Value = ELTBKARDEXIMPBE.TPRECIO_DCOMPRA
        cmd.Parameters.Add("@USUARIO", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.PERSONAL
        cmd.Parameters.Add("@OBSERVA", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.OBSERVA
        cmd.Parameters.Add("@T_IGV", OracleDbType.Double).Value = ELTBKARDEXIMPBE.T_IGV
        cmd.Parameters.Add("@T_DIGV", OracleDbType.Double).Value = ELTBKARDEXIMPBE.T_DIGV
        cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.PROVEEDOR
        cmd.Parameters.Add("@FEC_DIA", OracleDbType.Varchar2).Value = dia
        cmd.Parameters.Add("@FEC_DUA", OracleDbType.Date).Value = ELTBKARDEXIMPBE.FEC_DUA
        cmd.Parameters.Add("@NRO_DUA", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.NRO_DUA
        cmd.Parameters.Add("@FEC_DOCU", OracleDbType.Date).Value = ELTBKARDEXIMPBE.FEC_DOCU
        cmd.Parameters.Add("@NRO_DOCU", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.NRO_DOCU
        cmd.Parameters.Add("@SER_OREQ", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.SER_OREQ
        cmd.Parameters.Add("@NRO_OREQ", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.NRO_OREQ
        cmd.Parameters.Add("@SER_DOCU", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.SER_DOCU
        cmd.Parameters.Add("@NRO_GUIA", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.NRO_GUIA
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETKARDEXIMP_INS"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBDETKARDEXIMPBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            ELTBDETKARDEXIMPBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            ELTBDETKARDEXIMPBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            ELTBDETKARDEXIMPBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELTBDETKARDEXIMPBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELTBDETKARDEXIMPBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELTBDETKARDEXIMPBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            ELTBDETKARDEXIMPBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value))
            ELTBDETKARDEXIMPBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR").Value)), "", RTrim(row.Cells("PROVEEDOR").Value))
            ELTBDETKARDEXIMPBE.UPRECIO_COMPRA = IIf(IsDBNull(RTrim(row.Cells("UPRECIO_COMPRA").Value)), 0, RTrim(row.Cells("UPRECIO_COMPRA").Value))
            ELTBDETKARDEXIMPBE.UPRECIO_DCOMPRA = IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DCOMPRA").Value)), 0, RTrim(row.Cells("UPRECIO_DCOMPRA").Value))
            ELTBDETKARDEXIMPBE.T_IGV = IIf(IsDBNull(RTrim(row.Cells("T_IGV").Value)), 0, RTrim(row.Cells("T_IGV").Value))
            ELTBDETKARDEXIMPBE.T_DIGV = IIf(IsDBNull(RTrim(row.Cells("T_DIGV").Value)), 0, RTrim(row.Cells("T_DIGV").Value))
            DAcumula = DAcumula + ELTBDETKARDEXIMPBE.UPRECIO_COMPRA * IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value))
            DAcumula1 = DAcumula1 + ELTBDETKARDEXIMPBE.UPRECIO_DCOMPRA * IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value))
            DAcumula2 = DAcumula2 + ELTBDETKARDEXIMPBE.T_IGV
            DAcumula3 = DAcumula3 + ELTBDETKARDEXIMPBE.T_DIGV
            ELTBDETKARDEXIMPBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
            ELTBDETKARDEXIMPBE.EST = IIf(IsDBNull(RTrim(row.Cells("EST").Value)), "", RTrim(row.Cells("EST").Value))
            ELTBDETKARDEXIMPBE.ADVALORE = Val(IIf(IsDBNull(RTrim(row.Cells("ADVALORE").Value)), "", RTrim(row.Cells("ADVALORE").Value)))
            ELTBDETKARDEXIMPBE.FEC_DIA = System.DateTime.Now.ToString
            'ELTBDETKARDEXIMPBE.T_CAMB = IIf(IsDBNull(RTrim(row.Cells("T_CAMB").Value)), 0, RTrim(row.Cells("T_CAMB").Value))
            ELTBDETKARDEXIMPBE.MONEDA = ELTBKARDEXIMPBE.MONEDA
            ELTBDETKARDEXIMPBE.FEC_DOCU = IIf(IsDBNull(RTrim(row.Cells("FEC_DOCU").Value)), 0, RTrim(row.Cells("FEC_DOCU").Value))
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETKARDEXIMPBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETKARDEXIMPBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETKARDEXIMPBE.NRO_DOC_REF1
            cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBKARDEXIMPBE.FEC_GENE
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBDETKARDEXIMPBE.ART_COD
            cmd.Parameters.Add("@CANTIDAD", OracleDbType.Double).Value = ELTBDETKARDEXIMPBE.CANTIDAD
            cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = ELTBDETKARDEXIMPBE.PROVEEDOR
            cmd.Parameters.Add("@UPRECIO_COMPRA", OracleDbType.Double).Value = ELTBDETKARDEXIMPBE.UPRECIO_COMPRA
            cmd.Parameters.Add("@UPRECIO_dCOMPRA", OracleDbType.Double).Value = ELTBDETKARDEXIMPBE.UPRECIO_DCOMPRA
            cmd.Parameters.Add("@T_IGV", OracleDbType.Double).Value = ELTBDETKARDEXIMPBE.T_IGV
            cmd.Parameters.Add("@T_DIGV", OracleDbType.Double).Value = ELTBDETKARDEXIMPBE.T_DIGV
            cmd.Parameters.Add("@UNIDAD", OracleDbType.Varchar2).Value = ELTBDETKARDEXIMPBE.UNIDAD
            cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = ELTBDETKARDEXIMPBE.EST
            cmd.Parameters.Add("@fec_dia", OracleDbType.Varchar2).Value = dia
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.MONEDA
            cmd.Parameters.Add("@FEC_DOCU", OracleDbType.Date).Value = ELTBDETKARDEXIMPBE.FEC_DOCU
            cmd.Parameters.Add("@ADVALORE", OracleDbType.Double).Value = ELTBDETKARDEXIMPBE.ADVALORE
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
        'ACTUALIZA CABECERA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBKARDEXIMP_UPDTOT"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.NRO_DOC_REF
        cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = DAcumula
        cmd.Parameters.Add("@TPRECIO_DCOMPRA", OracleDbType.Double).Value = DAcumula1
        cmd.Parameters.Add("@T_IGV", OracleDbType.Double).Value = DAcumula2
        cmd.Parameters.Add("@T_DIGV", OracleDbType.Double).Value = DAcumula3
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + FACTURACIONBE.T_DOC_REF + "-" + FACTURACIONBE.SER_DOC_REF + "-" + FACTURACIONBE.NRO_DOC_REF
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub UpdateRow(ByVal ELTBKARDEXIMPBE As ELTBKARDEXIMPBE, ByVal ELTBDETKARDEXIMPBE As ELTBDETKARDEXIMPBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        'Dim contenedor As String
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim dia As String = System.DateTime.Now
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBKARDEXIMP_UPD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.NRO_DOC_REF
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBKARDEXIMPBE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.EST
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.MONEDA
        cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = ELTBKARDEXIMPBE.TPRECIO_COMPRA
        cmd.Parameters.Add("@TPRECIO_DCOMPRA", OracleDbType.Double).Value = ELTBKARDEXIMPBE.TPRECIO_DCOMPRA
        cmd.Parameters.Add("@USUARIO", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.PERSONAL
        cmd.Parameters.Add("@OBSERVA", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.OBSERVA
        cmd.Parameters.Add("@T_IGV", OracleDbType.Double).Value = ELTBKARDEXIMPBE.T_IGV
        cmd.Parameters.Add("@T_DIGV", OracleDbType.Double).Value = ELTBKARDEXIMPBE.T_DIGV
        cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.PROVEEDOR
        cmd.Parameters.Add("@FEC_DIA", OracleDbType.Varchar2).Value = dia
        cmd.Parameters.Add("@FEC_DUA", OracleDbType.Date).Value = ELTBKARDEXIMPBE.FEC_DUA
        cmd.Parameters.Add("@NRO_DUA", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.NRO_DUA
        cmd.Parameters.Add("@NRO_DUA", OracleDbType.Date).Value = ELTBKARDEXIMPBE.FEC_DOCU
        cmd.Parameters.Add("@NRO_DOCU", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.NRO_DOCU
        cmd.Parameters.Add("@SER_OREQ", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.SER_OREQ
        cmd.Parameters.Add("@NRO_OREQ", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.NRO_OREQ
        cmd.Parameters.Add("@SER_DOCU", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.SER_DOCU
        cmd.Parameters.Add("@NRO_GUIA", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.NRO_GUIA
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETKARDEXIMP_DEL"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETKARDEXIMP_INS"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBDETKARDEXIMPBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            ELTBDETKARDEXIMPBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            ELTBDETKARDEXIMPBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            ELTBDETKARDEXIMPBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELTBDETKARDEXIMPBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELTBDETKARDEXIMPBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELTBDETKARDEXIMPBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            ELTBDETKARDEXIMPBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value))
            ELTBDETKARDEXIMPBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR").Value)), "", RTrim(row.Cells("PROVEEDOR").Value))
            ELTBDETKARDEXIMPBE.UPRECIO_COMPRA = IIf(IsDBNull(RTrim(row.Cells("UPRECIO_COMPRA").Value)), 0, RTrim(row.Cells("UPRECIO_COMPRA").Value))
            ELTBDETKARDEXIMPBE.UPRECIO_DCOMPRA = IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DCOMPRA").Value)), 0, RTrim(row.Cells("UPRECIO_DCOMPRA").Value))
            ELTBDETKARDEXIMPBE.T_IGV = IIf(IsDBNull(RTrim(row.Cells("T_IGV").Value)), 0, RTrim(row.Cells("T_IGV").Value))
            ELTBDETKARDEXIMPBE.T_DIGV = IIf(IsDBNull(RTrim(row.Cells("T_DIGV").Value)), 0, RTrim(row.Cells("T_DIGV").Value))
            DAcumula = DAcumula + ELTBDETKARDEXIMPBE.UPRECIO_COMPRA * IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value))
            DAcumula1 = DAcumula1 + ELTBDETKARDEXIMPBE.UPRECIO_DCOMPRA * IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value))
            DAcumula2 = DAcumula2 + ELTBDETKARDEXIMPBE.T_IGV
            DAcumula3 = DAcumula3 + ELTBDETKARDEXIMPBE.T_DIGV
            ELTBDETKARDEXIMPBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
            ELTBDETKARDEXIMPBE.EST = IIf(IsDBNull(RTrim(row.Cells("EST").Value)), "", RTrim(row.Cells("EST").Value))
            ELTBDETKARDEXIMPBE.ADVALORE = IIf(IsDBNull(RTrim(row.Cells("ADVALORE").Value)), 0, RTrim(row.Cells("ADVALORE").Value))
            'ELTBDETKARDEXIMPBE.FEC_DIA = System.DateTime.Now.ToString
            'ELTBDETKARDEXIMPBE.T_CAMB = IIf(IsDBNull(RTrim(row.Cells("T_CAMB").Value)), 0, RTrim(row.Cells("T_CAMB").Value))
            ELTBDETKARDEXIMPBE.MONEDA = ELTBKARDEXIMPBE.MONEDA
            ELTBDETKARDEXIMPBE.FEC_DOCU = IIf(IsDBNull(RTrim(row.Cells("FEC_DOCU").Value)), 0, RTrim(row.Cells("FEC_DOCU").Value))
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETKARDEXIMPBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETKARDEXIMPBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETKARDEXIMPBE.NRO_DOC_REF1
            cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBKARDEXIMPBE.FEC_GENE
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBDETKARDEXIMPBE.ART_COD
            cmd.Parameters.Add("@CANTIDAD", OracleDbType.Double).Value = ELTBDETKARDEXIMPBE.CANTIDAD
            cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = ELTBDETKARDEXIMPBE.PROVEEDOR
            cmd.Parameters.Add("@UPRECIO_COMPRA", OracleDbType.Double).Value = ELTBDETKARDEXIMPBE.UPRECIO_COMPRA
            cmd.Parameters.Add("@UPRECIO_dCOMPRA", OracleDbType.Double).Value = ELTBDETKARDEXIMPBE.UPRECIO_DCOMPRA
            cmd.Parameters.Add("@T_IGV", OracleDbType.Double).Value = ELTBDETKARDEXIMPBE.T_IGV
            cmd.Parameters.Add("@T_DIGV", OracleDbType.Double).Value = ELTBDETKARDEXIMPBE.T_DIGV
            cmd.Parameters.Add("@UNIDAD", OracleDbType.Varchar2).Value = ELTBDETKARDEXIMPBE.UNIDAD
            cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = ELTBDETKARDEXIMPBE.EST
            cmd.Parameters.Add("@fec_dia", OracleDbType.Varchar2).Value = dia
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.MONEDA
            cmd.Parameters.Add("@FEC_DOCU", OracleDbType.Date).Value = ELTBDETKARDEXIMPBE.FEC_DOCU
            cmd.Parameters.Add("@ADVALORE", OracleDbType.Double).Value = Val(ELTBDETKARDEXIMPBE.ADVALORE)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
        'ACTUALIZA CABECERA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBKARDEXIMP_UPDTOT"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPBE.NRO_DOC_REF
        cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = DAcumula
        cmd.Parameters.Add("@TPRECIO_DCOMPRA", OracleDbType.Double).Value = DAcumula1
        cmd.Parameters.Add("@T_IGV", OracleDbType.Double).Value = DAcumula2
        cmd.Parameters.Add("@T_DIGV", OracleDbType.Double).Value = DAcumula3
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + FACTURACIONBE.T_DOC_REF + "-" + FACTURACIONBE.SER_DOC_REF + "-" + FACTURACIONBE.NRO_DOC_REF
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub InsertRowCos(ByVal ELTBKARDEXIMPCOSBE As ELTBKARDEXIMPCOSBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        'Dim contenedor As String
        cont_kard = 0
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        For Each row As DataGridViewRow In dg.Rows
            cont_kard = cont_kard + 1
            ELTBKARDEXIMPCOSBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            ELTBKARDEXIMPCOSBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            ELTBKARDEXIMPCOSBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            ELTBKARDEXIMPCOSBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELTBKARDEXIMPCOSBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELTBKARDEXIMPCOSBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELTBKARDEXIMPCOSBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
            ELTBKARDEXIMPCOSBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            ELTBKARDEXIMPCOSBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value))
            ELTBKARDEXIMPCOSBE.UPRECIO_COMPRA = Val(IIf(IsDBNull(RTrim(row.Cells("TPRECIO_COMPRA").Value)), 0, RTrim(row.Cells("TPRECIO_COMPRA").Value)))
            ELTBKARDEXIMPCOSBE.COSTO_COMUN = Val(IIf(IsDBNull(RTrim(row.Cells("COSTO_COMUN").Value)), 0, RTrim(row.Cells("COSTO_COMUN").Value)))
            ELTBKARDEXIMPCOSBE.COSTO_REPARTIDO = Val(IIf(IsDBNull(RTrim(row.Cells("CTO_RPTO").Value)), 0, RTrim(row.Cells("CTO_RPTO").Value)))
            ELTBKARDEXIMPCOSBE.COSTO_TOTAL = Val(IIf(IsDBNull(RTrim(row.Cells("CTO_TOT").Value)), 0, RTrim(row.Cells("CTO_TOT").Value)))
            ELTBKARDEXIMPCOSBE.PRECIO_UNITARIO = Val(IIf(IsDBNull(RTrim(row.Cells("PRECIO_UNI").Value)), 0, RTrim(row.Cells("PRECIO_UNI").Value)))
            ELTBKARDEXIMPCOSBE.ANCHO = Val(IIf(IsDBNull(RTrim(row.Cells("ANCHO").Value)), 0, RTrim(row.Cells("ANCHO").Value)))
            ELTBKARDEXIMPCOSBE.LARGO = Val(IIf(IsDBNull(RTrim(row.Cells("LARGO").Value)), 0, RTrim(row.Cells("LARGO").Value)))
            ELTBKARDEXIMPCOSBE.DATO_CONV = Val(IIf(IsDBNull(RTrim(row.Cells("DATO_CONV").Value)), 0, RTrim(row.Cells("DATO_CONV").Value)))
            ELTBKARDEXIMPCOSBE.PESO = Val(IIf(IsDBNull(RTrim(row.Cells("PESO").Value)), 0, RTrim(row.Cells("PESO").Value)))
            ELTBKARDEXIMPCOSBE.CANTIDAD_TOTAL = Val(IIf(IsDBNull(RTrim(row.Cells("CANTIDAD_TOTAL").Value)), 0, RTrim(row.Cells("CANTIDAD_TOTAL").Value)))
            ELTBKARDEXIMPCOSBE.PRECIO_TOTAL = Val(IIf(IsDBNull(RTrim(row.Cells("PRECIO_TOTAL").Value)), 0, RTrim(row.Cells("PRECIO_TOTAL").Value)))
            ELTBKARDEXIMPCOSBE.PESO_TOTAL = Val(IIf(IsDBNull(RTrim(row.Cells("PESO_TOTAL").Value)), 0, RTrim(row.Cells("PESO_TOTAL").Value)))
            ELTBKARDEXIMPCOSBE.TIPO = Val(IIf(IsDBNull(RTrim(row.Cells("TIPO").Value)), 0, RTrim(row.Cells("TIPO").Value)))
            If cont_kard = 1 Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELTBKARDEXIMPCOS_DEL"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = Trim(ELTBKARDEXIMPCOSBE.T_DOC_REF)
                cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = Trim(ELTBKARDEXIMPCOSBE.SER_DOC_REF)
                cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Trim(ELTBKARDEXIMPCOSBE.NRO_DOC_REF)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBKARDEXIMPCOS_INS"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPCOSBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPCOSBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBKARDEXIMPCOSBE.NRO_DOC_REF1
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBKARDEXIMPCOSBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBKARDEXIMPCOSBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBKARDEXIMPCOSBE.NRO_DOC_REF
            cmd.Parameters.Add("@UNIDAD", OracleDbType.Varchar2).Value = ELTBKARDEXIMPCOSBE.UNIDAD
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBKARDEXIMPCOSBE.ART_COD
            cmd.Parameters.Add("@CANTIDAD", OracleDbType.Double).Value = ELTBKARDEXIMPCOSBE.CANTIDAD
            cmd.Parameters.Add("@UPRECIO_COMPRA", OracleDbType.Double).Value = ELTBKARDEXIMPCOSBE.UPRECIO_COMPRA
            cmd.Parameters.Add("@COSTO_COMUN", OracleDbType.Double).Value = ELTBKARDEXIMPCOSBE.COSTO_COMUN
            cmd.Parameters.Add("@COSTO_REPARTIDO", OracleDbType.Double).Value = ELTBKARDEXIMPCOSBE.COSTO_REPARTIDO
            cmd.Parameters.Add("@COSTO_TOTAL", OracleDbType.Double).Value = ELTBKARDEXIMPCOSBE.COSTO_TOTAL
            cmd.Parameters.Add("@PRECIO_UNITARIO", OracleDbType.Double).Value = ELTBKARDEXIMPCOSBE.PRECIO_UNITARIO
            cmd.Parameters.Add("@ANCHO", OracleDbType.Double).Value = ELTBKARDEXIMPCOSBE.ANCHO
            cmd.Parameters.Add("@LARGO", OracleDbType.Double).Value = ELTBKARDEXIMPCOSBE.LARGO
            cmd.Parameters.Add("@DATO_CONV", OracleDbType.Double).Value = ELTBKARDEXIMPCOSBE.DATO_CONV
            cmd.Parameters.Add("@PESO", OracleDbType.Double).Value = ELTBKARDEXIMPCOSBE.PESO
            cmd.Parameters.Add("@PRECIO_TOTAL", OracleDbType.Double).Value = ELTBKARDEXIMPCOSBE.PRECIO_TOTAL
            cmd.Parameters.Add("@CANTIDAD_TOTAL", OracleDbType.Double).Value = ELTBKARDEXIMPCOSBE.CANTIDAD_TOTAL
            cmd.Parameters.Add("@PESO_TOTAL", OracleDbType.Double).Value = ELTBKARDEXIMPCOSBE.PESO_TOTAL
            cmd.Parameters.Add("@TIPO", OracleDbType.Double).Value = ELTBKARDEXIMPCOSBE.TIPO
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
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + FACTURACIONBE.T_DOC_REF + "-" + FACTURACIONBE.SER_DOC_REF + "-" + FACTURACIONBE.NRO_DOC_REF
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub InsertRowLimpiar(ByVal ELTBKARDEXIMPCOSBE As ELTBKARDEXIMPCOSBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        'Dim contenedor As String
        cont_kard = 0
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        For Each row As DataGridViewRow In dg.Rows
            cont_kard = cont_kard + 1
            ELTBKARDEXIMPCOSBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            ELTBKARDEXIMPCOSBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            ELTBKARDEXIMPCOSBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            ELTBKARDEXIMPCOSBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELTBKARDEXIMPCOSBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELTBKARDEXIMPCOSBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELTBKARDEXIMPCOSBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
            ELTBKARDEXIMPCOSBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            ELTBKARDEXIMPCOSBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value))
            ELTBKARDEXIMPCOSBE.UPRECIO_COMPRA = Val(IIf(IsDBNull(RTrim(row.Cells("TPRECIO_COMPRA").Value)), 0, RTrim(row.Cells("TPRECIO_COMPRA").Value)))
            ELTBKARDEXIMPCOSBE.COSTO_COMUN = Val(IIf(IsDBNull(RTrim(row.Cells("COSTO_COMUN").Value)), 0, RTrim(row.Cells("COSTO_COMUN").Value)))
            ELTBKARDEXIMPCOSBE.COSTO_REPARTIDO = Val(IIf(IsDBNull(RTrim(row.Cells("CTO_RPTO").Value)), 0, RTrim(row.Cells("CTO_RPTO").Value)))
            ELTBKARDEXIMPCOSBE.COSTO_TOTAL = Val(IIf(IsDBNull(RTrim(row.Cells("CTO_TOT").Value)), 0, RTrim(row.Cells("CTO_TOT").Value)))
            ELTBKARDEXIMPCOSBE.PRECIO_UNITARIO = Val(IIf(IsDBNull(RTrim(row.Cells("PRECIO_UNI").Value)), 0, RTrim(row.Cells("PRECIO_UNI").Value)))
            ELTBKARDEXIMPCOSBE.ANCHO = Val(IIf(IsDBNull(RTrim(row.Cells("ANCHO").Value)), 0, RTrim(row.Cells("ANCHO").Value)))
            ELTBKARDEXIMPCOSBE.LARGO = Val(IIf(IsDBNull(RTrim(row.Cells("LARGO").Value)), 0, RTrim(row.Cells("LARGO").Value)))
            ELTBKARDEXIMPCOSBE.DATO_CONV = Val(IIf(IsDBNull(RTrim(row.Cells("DATO_CONV").Value)), 0, RTrim(row.Cells("DATO_CONV").Value)))
            ELTBKARDEXIMPCOSBE.PESO = Val(IIf(IsDBNull(RTrim(row.Cells("PESO").Value)), 0, RTrim(row.Cells("PESO").Value)))
            ELTBKARDEXIMPCOSBE.CANTIDAD_TOTAL = Val(IIf(IsDBNull(RTrim(row.Cells("CANTIDAD_TOTAL").Value)), 0, RTrim(row.Cells("CANTIDAD_TOTAL").Value)))
            ELTBKARDEXIMPCOSBE.PRECIO_TOTAL = Val(IIf(IsDBNull(RTrim(row.Cells("PRECIO_TOTAL").Value)), 0, RTrim(row.Cells("PRECIO_TOTAL").Value)))
            ELTBKARDEXIMPCOSBE.PESO_TOTAL = Val(IIf(IsDBNull(RTrim(row.Cells("PESO_TOTAL").Value)), 0, RTrim(row.Cells("PESO_TOTAL").Value)))
            ELTBKARDEXIMPCOSBE.TIPO = Val(IIf(IsDBNull(RTrim(row.Cells("TIPO").Value)), 0, RTrim(row.Cells("TIPO").Value)))
            If cont_kard = 1 Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELTBKARDEXIMPCOS_DEL"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = Trim(ELTBKARDEXIMPCOSBE.T_DOC_REF)
                cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = Trim(ELTBKARDEXIMPCOSBE.SER_DOC_REF)
                cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Trim(ELTBKARDEXIMPCOSBE.NRO_DOC_REF)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
        Next

        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + FACTURACIONBE.T_DOC_REF + "-" + FACTURACIONBE.SER_DOC_REF + "-" + FACTURACIONBE.NRO_DOC_REF
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
End Class
