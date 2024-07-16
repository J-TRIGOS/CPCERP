Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class PROVISIONESDAL
    Inherits BaseDatosORACLE

    Public sPrueba As String = ""
    Public sPruebaS As Integer = 0
    Public Function SelectBS_SSrow(ByVal sCod As String) As String
        sPrueba = ""
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_BS_SS_SEL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pCod", Trim(sCod))})
            While dr.Read
                sPrueba = dr.GetString(1)
            End While
        End Using
        Return sPrueba
    End Function
    Public Function SelectCTA_OPE(ByVal sFec As String, ByVal sCuenta As String) As String
        Try
            sPrueba = ""
            Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
            Dim dt As New DataTable
            Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_CTADEST", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pCod", Trim(sFec)),
                                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@pCod", Trim(sCuenta))})
                While dr.Read
                    sPrueba = dr.GetString(0)
                End While
            End Using
            Return sPrueba
        Catch ex As Exception

        End Try

    End Function
    Function list1(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
               ByVal fec As Date) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SOLPROVISIONES_SEARCH", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function

    Function list2(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
               ByVal fec As Date) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SOLPROVISIONES_SEARCH2", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", Trim(fec))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function

    Function list3(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
               ByVal fec As Date) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SOLPROVISIONES_SEARCH3", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function Select_RegistroComp(ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_REGISTRO_COMPRAS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sAño),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function Select_RegistroNoDom(ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_REGISTRO_NODOM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sAño),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Public Function SelectRegNomDomAll(ByVal sAño As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_REGISTRO_NODOM_ALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function SelectT_OPE_DETRA() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TOPE_DETRA", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function SelectELTBDETRA() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBBSDETRAC_SELALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Public Function SelectRegComAll(ByVal sAño As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_REGISTRO_COMPRAS_ALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function list4(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
               ByVal fec As Date) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SOLPROVISIONES_SEARCH4", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", Trim(fec))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function list5(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SOLPROVISIONES_SEARCH5", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function list6(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
               ByVal fec As Date) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SOLPROVISIONES_SEARCH6", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", Trim(fec))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function list7(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SOLPROVISIONES_SEARCH7", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function list8(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
               ByVal fec As Date) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SOLPROVISIONES_SEARCH8", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", Trim(fec))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function list9(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SOLPROVISIONES_SEARCH9", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function list10(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
               ByVal fec As Date) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SOLPROVISIONES_SEARCH10", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", Trim(fec))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Public Function SelectT_DOC_SEL(ByVal sCod As String) As String
        sPrueba = ""
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_T_DOC_SEL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pCod", Trim(sCod))})
            While dr.Read
                sPrueba = dr.GetString(1)
            End While
        End Using
        Return sPrueba
    End Function
    Public Function Select_MON_row(ByVal sCod As String) As String
        sPrueba = ""
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_MON_SEL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pCod", Trim(sCod))})
            While dr.Read
                sPrueba = dr.GetString(1)
            End While
        End Using
        Return sPrueba
    End Function
    Public Function getT_CAMB(ByVal fec As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_T_CMB", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec", fec)})
            If dr.HasRows Then
                Try
                    dt.Load(dr)
                Catch ex As Exception
                    MsgBox("No hay tipo de cambio para esta fecha")
                End Try

            End If
        End Using
        Return dt
    End Function
    Public Function getT_CAMBvensbs(ByVal fec As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_T_CMB_VEN_SBS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec", fec)})
            If dr.HasRows Then
                Try
                    dt.Load(dr)
                Catch ex As Exception
                    MsgBox("No hay tipo de cambio para esta fecha")
                End Try

            End If
        End Using
        Return dt
    End Function
    Public Function getListdgv1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal Num As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DETPROVISIONES_SELALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@Nro1", Num)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function getListdgv2(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DETPROVISIONES_SELALL1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function getListdgv4(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal num As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DETPROVISIONES_SELALL2", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@num", num)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function getListdgv5(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal Num As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DETPROVISIONES_SELALL3", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@Nro1", Num)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function getListdgv6(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal Num As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DETPROVISIONES_SELALL4", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@Nro1", Num)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectBS_SS() As DataTable

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_BS_SS", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectProvAll(ByVal sAÑO As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SELALLPROV", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAÑO),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ActualizarCTCT(ByVal sAÑO As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ACTUALIZAR_CTCT_COBRANZA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pANHO", sAÑO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectExpAll(ByVal sAÑO As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDOCEXP_SELALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAÑO),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectCtaDif(ByVal sAÑO As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DET_DOCUMENTO_CTACOMP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAÑO),
                                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectCtaRepetida(ByVal sCode As String, ByVal sAÑO As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DET_DOCUMENTO_CTAREP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sCode),
                                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sAÑO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sFec As String,
                               ByVal sCTCT As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SELECTROW_CMP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
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
    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sFec As String,
                               ByVal sCTCT As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DET_DOCUMENTO_SELECTROW_PRV", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
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
    Public Function SelRowPeso(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String, ByVal sADoc As String) As Double
        sPruebaS = 0
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_PESOOREQ", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sTDoc", Trim(sTDoc)),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@sSDoc", Trim(sSDoc)),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@sNDoc", Trim(sNDoc)),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@sADoc", Trim(sADoc))})
            While dr.Read
                sPruebaS = dr.GetDouble(0)
            End While
        End Using
        Return sPruebaS
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
    Public Function SelectT_DOC() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_T_DOC2", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelectT_DOC2() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_T_DOC3", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelectT_OPE(ByVal sFec As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_T_OPE", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sFec", sFec)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function Select_MON() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_MON", {})
            If dr.HasRows Then
                dt.Load(dr)

            End If
        End Using
        Return dt

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
    Public Function Select_Fecha(ByVal sTip As String, ByVal sSer As String, ByVal sNro As String) As String
        sPrueba = ""
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_PROV_FECREC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pCod", Trim(sSer)),
                                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@pCod", Trim(sNro))})
            While dr.Read
                sPrueba = dr.GetDateTime(0)
            End While
        End Using
        Return sPrueba
    End Function
    Public Function SelectCuenta(ByVal sCod As String) As String
        sPrueba = ""
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTCT_CUENTA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pCod", Trim(sCod))})
            While dr.Read
                'sPrueba = dr.GetString(0)
                Try
                    Return dr.GetString(0)
                Catch ex As Exception
                    Return ""
                End Try
            End While
        End Using

    End Function
    Public Function SelectServ(ByVal sCod As String) As String
        sPrueba = ""
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTCT_SERV", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pCod", Trim(sCod))})
            While dr.Read
                'sPrueba = dr.GetString(0)
                Try
                    Return dr.GetString(0)
                Catch ex As Exception
                    Return ""
                End Try
            End While
        End Using
        Try
            Return sPrueba
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function SelectPorc(ByVal sCod As String) As Integer
        sPrueba = ""
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTCT_PORC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pCod", Trim(sCod))})
            While dr.Read
                'sPrueba = dr.GetInt16(0)
                Try
                    Return dr.GetInt16(0)
                Catch ex As Exception
                    Return 0
                End Try
            End While
        End Using


    End Function
    Public Function SelectDescDetrac(ByVal sCod As String) As String
        sPrueba = ""
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBBSDETRAC_SELDES", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pCod", Trim(sCod))})
            While dr.Read
                'sPrueba = dr.GetString(0)
                Try
                    Return dr.GetString(0)
                Catch ex As Exception
                    Return ""
                End Try
            End While
        End Using


    End Function
    Public Function SelectNomDetra(ByVal sCod As String) As String
        sPrueba = ""
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_T_OPE_DETRA_SELDET", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pCod", Trim(sCod))})
            While dr.Read
                'sPrueba = dr.GetString(0)
                Try
                    Return dr.GetString(0)
                Catch ex As Exception
                    Return ""
                End Try

            End While
        End Using
        'Try
        '    Return sPrueba
        'Catch ex As Exception
        '    Return ""
        'End Try

    End Function
    Public Function SelectNomCta(ByVal sCod As String, ByVal syear As String) As String
        sPrueba = ""
        syear = Today.Year
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTA_SELNOM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pCod", Trim(sCod)),
                                                                                                         New Oracle.ManagedDataAccess.Client.OracleParameter("@syear", Trim(syear))})
            While dr.Read
                'sPrueba = dr.GetString(0)
                Try
                    Return dr.GetString(0)
                Catch ex As Exception
                    Return ""
                End Try

            End While
        End Using
        'Try
        '    Return sPrueba
        'Catch ex As Exception
        '    Return ""
        'End Try

    End Function
    Public Function SaveRow(ByVal PROVISIONESBE As PROVISIONESBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal dg As DataGridView) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction

        Try
            'N:Nuevo   M:Modificar   E:Eliminar 

            If flagAccion = "N" Then
                InsertRow(PROVISIONESBE, DET_DOCUMENTOBE, cn, sqlTrans, ELMVLOGSBE, dg)
                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                UpdateRow(PROVISIONESBE, DET_DOCUMENTOBE, cn, sqlTrans, ELMVLOGSBE, dg)
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
    Public Function SaveRLetra(ByVal PROVISIONESBE As PROVISIONESBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal dg As DataGridView) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction

        Try
            'N:Nuevo   M:Modificar   E:Eliminar 

            If flagAccion = "N" Then
                InsertRLetra(PROVISIONESBE, DET_DOCUMENTOBE, cn, sqlTrans, ELMVLOGSBE, dg)
                'grabar acceso a los menues
            End If

            'If flagAccion = "M" Then
            '    UpdateRLetra(PROVISIONESBE, DET_DOCUMENTOBE, cn, sqlTrans, ELMVLOGSBE, dg)
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
            '    cn.Dispose()
            'End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function

    Private Sub InsertRow(ByVal PROVISIONESBE As PROVISIONESBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
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
        cmd.CommandText = "SP_PROVISIONES_INSROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = PROVISIONESBE.T_DOC_REF
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = PROVISIONESBE.SER_DOC_REF
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = PROVISIONESBE.NRO_DOC_REF
        cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = PROVISIONESBE.ART_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = PROVISIONESBE.FEC_GENE
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = PROVISIONESBE.EST
        cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = PROVISIONESBE.MONEDA
        cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = PROVISIONESBE.TPRECIO_COMPRA
        cmd.Parameters.Add("@SIGNO", OracleDbType.Varchar2).Value = PROVISIONESBE.SIGNO
        cmd.Parameters.Add("@TPRECIO_DCOMPRA", OracleDbType.Double).Value = PROVISIONESBE.TPRECIO_DCOMPRA
        cmd.Parameters.Add("@USUARIO", OracleDbType.Varchar2).Value = PROVISIONESBE.USUARIO
        cmd.Parameters.Add("@OBSERVA", OracleDbType.Varchar2).Value = PROVISIONESBE.OBSERVA
        cmd.Parameters.Add("@T_IGV", OracleDbType.Double).Value = PROVISIONESBE.T_IGV
        cmd.Parameters.Add("@T_IGV_DOLAR", OracleDbType.Double).Value = PROVISIONESBE.T_IGV_DOLAR
        cmd.Parameters.Add("@T_DCTO", OracleDbType.Double).Value = PROVISIONESBE.T_DCTO
        cmd.Parameters.Add("@T_DCTO_DOLAR", OracleDbType.Double).Value = PROVISIONESBE.T_DCTO_DOLAR
        cmd.Parameters.Add("@T_OPE", OracleDbType.Varchar2).Value = PROVISIONESBE.T_OPE
        cmd.Parameters.Add("@X_RET", OracleDbType.Varchar2).Value = PROVISIONESBE.X_RET
        cmd.Parameters.Add("@REG_NRO", OracleDbType.Varchar2).Value = PROVISIONESBE.REG_NRO
        cmd.Parameters.Add("@PROVEEDOR ", OracleDbType.Varchar2).Value = PROVISIONESBE.PROVEEDOR
        cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = PROVISIONESBE.TIPO
        cmd.Parameters.Add("@FEC_PROV", OracleDbType.Date).Value = PROVISIONESBE.FEC_PROV
        cmd.Parameters.Add("@T_IES", OracleDbType.Double).Value = PROVISIONESBE.T_IES
        cmd.Parameters.Add("@T_DIES", OracleDbType.Double).Value = PROVISIONESBE.T_DIES
        cmd.Parameters.Add("@T_CTA", OracleDbType.Double).Value = PROVISIONESBE.T_CTA
        cmd.Parameters.Add("@T_DCTA", OracleDbType.Double).Value = PROVISIONESBE.T_DCTA
        cmd.Parameters.Add("@TAFECTO", OracleDbType.Double).Value = PROVISIONESBE.TAFECTO
        cmd.Parameters.Add("@TAFECTOD", OracleDbType.Double).Value = PROVISIONESBE.TAFECTOD
        cmd.Parameters.Add("@TIPO2", OracleDbType.Varchar2).Value = PROVISIONESBE.TIPO2
        cmd.Parameters.Add("@LETRA", OracleDbType.Varchar2).Value = PROVISIONESBE.LETRA
        cmd.Parameters.Add("@FEC_LETRA", OracleDbType.Date).Value = PROVISIONESBE.FEC_LETRA
        cmd.Parameters.Add("@TIPO1", OracleDbType.Varchar2).Value = PROVISIONESBE.TIPO1
        cmd.Parameters.Add("@NRO_PERCEPCION", OracleDbType.Varchar2).Value = PROVISIONESBE.NRO_PERCEPCION
        cmd.Parameters.Add("@EST1", OracleDbType.Varchar2).Value = PROVISIONESBE.EST1
        cmd.Parameters.Add("@DETRACCION", OracleDbType.Varchar2).Value = PROVISIONESBE.DETRACCION
        cmd.Parameters.Add("@FEC_DET", OracleDbType.Date).Value = PROVISIONESBE.FEC_DET
        cmd.Parameters.Add("@F_PAGO_ENT ", OracleDbType.Varchar2).Value = Trim(PROVISIONESBE.F_PAGO_ENT)
        cmd.Parameters.Add("@MONTO_PAGADO ", OracleDbType.Double).Value = Trim(PROVISIONESBE.MONTO_PAGADO)
        cmd.Parameters.Add("@PORCENTAJE ", OracleDbType.Double).Value = Trim(PROVISIONESBE.PORCENTAJE)
        cmd.Parameters.Add("@CTA_CBCO ", OracleDbType.Varchar2).Value = Trim(PROVISIONESBE.CTA_CBCO)
        cmd.Parameters.Add("@FARDO ", OracleDbType.Varchar2).Value = Trim(PROVISIONESBE.FARDO)
        cmd.Parameters.Add("@PROGRAMA ", OracleDbType.Varchar2).Value = Trim(PROVISIONESBE.PROGRAMA)
        cmd.Parameters.Add("@NUMPEDIDO ", OracleDbType.Varchar2).Value = Trim(PROVISIONESBE.NUMPEDIDO)
        cmd.Parameters.Add("@NOM_CTCT ", OracleDbType.Varchar2).Value = Trim(PROVISIONESBE.NOM_CTCT)
        cmd.Parameters.Add("@TIPO07", OracleDbType.Varchar2).Value = Trim(PROVISIONESBE.TIPO7)
        cmd.Parameters.Add("@EST_MERCADERIA", OracleDbType.Varchar2).Value = Trim(PROVISIONESBE.EST_MERCADERIA)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DETPROVISIONES_INSROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            DET_DOCUMENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            DET_DOCUMENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells("CTCT_COD").Value)), "", RTrim(row.Cells("CTCT_COD").Value))
            DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            DET_DOCUMENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells("SIGNO").Value)), "", RTrim(row.Cells("SIGNO").Value))
            DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            DET_DOCUMENTOBE.IGV = IIf(IsDBNull(RTrim(row.Cells("IGV").Value)), 0, RTrim(row.Cells("IGV").Value))
            DET_DOCUMENTOBE.IGV_IMPOR = IIf(IsDBNull(RTrim(row.Cells("IGV_IMPOR").Value)), 0, RTrim(row.Cells("IGV_IMPOR").Value))
            DET_DOCUMENTOBE.IGV_IMPOR = IIf(IsDBNull(RTrim(row.Cells("IGV_DIMPOR").Value)), 0, RTrim(row.Cells("IGV_DIMPOR").Value))
            DET_DOCUMENTOBE.T_CAMB = IIf(IsDBNull(RTrim(row.Cells("T_CAMB").Value)), 0, RTrim(row.Cells("T_CAMB").Value))
            ' DET_DOCUMENTOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells("FEC_GENE").Value)), "", RTrim(row.Cells("FEC_GENE").Value))
            DET_DOCUMENTOBE.USUARIO = IIf(IsDBNull(RTrim(row.Cells("USUARIO").Value)), "", RTrim(row.Cells("USUARIO").Value))
            DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
            DET_DOCUMENTOBE.FEC_DIA = IIf(IsDBNull(RTrim(row.Cells("FEC_DIA").Value)), "", RTrim(row.Cells("FEC_DIA").Value))
            DET_DOCUMENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR").Value)), "", RTrim(row.Cells("PROVEEDOR").Value))
            DET_DOCUMENTOBE.CUENTA = IIf(IsDBNull(RTrim(row.Cells("CUENTA").Value)), "", RTrim(row.Cells("CUENTA").Value))
            DET_DOCUMENTOBE.CUENTA_DEST = IIf(IsDBNull(RTrim(row.Cells("CUENTA_DEST").Value)), "", RTrim(row.Cells("CUENTA_DEST").Value))
            DET_DOCUMENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells("SIGNO").Value)), "", RTrim(row.Cells("SIGNO").Value))
            If IIf(IsDBNull(RTrim(row.Cells("STATUS").Value)), "", RTrim(row.Cells("STATUS").Value)) = "AFECTO" Then
                DET_DOCUMENTOBE.STATUS = "S"
            ElseIf IIf(IsDBNull(RTrim(row.Cells("STATUS").Value)), "", RTrim(row.Cells("STATUS").Value)) = "INAFECTO" Then
                DET_DOCUMENTOBE.STATUS = "N"
            End If

            'DET_DOCUMENTOBE.STATUS = IIf(IsDBNull(RTrim(row.Cells("STATUS").Value)), "", RTrim(row.Cells("STATUS").Value))
            DET_DOCUMENTOBE.UPRECIO_AFECTOS = IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOS").Value)), "", RTrim(row.Cells("UPRECIO_AFECTOS").Value))
            DET_DOCUMENTOBE.UPRECIO_AFECTOD = IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOD").Value)), "", RTrim(row.Cells("UPRECIO_AFECTOD").Value))
            DET_DOCUMENTOBE.IES_IMPOR = IIf(IsDBNull(RTrim(row.Cells("IES_IMPOR").Value)), "", RTrim(row.Cells("IES_IMPOR").Value))
            DET_DOCUMENTOBE.IES_DIMPOR = IIf(IsDBNull(RTrim(row.Cells("IES_DIMPOR").Value)), "", RTrim(row.Cells("IES_DIMPOR").Value))
            DET_DOCUMENTOBE.CTA_IMPOR = IIf(IsDBNull(RTrim(row.Cells("CTA_IMPOR").Value)), "", RTrim(row.Cells("CTA_IMPOR").Value))
            DET_DOCUMENTOBE.CTA_DIMPOR = IIf(IsDBNull(RTrim(row.Cells("CTA_DIMPOR").Value)), "", RTrim(row.Cells("CTA_DIMPOR").Value))
            DET_DOCUMENTOBE.IES = IIf(IsDBNull(RTrim(row.Cells("IES").Value)), 0, RTrim(row.Cells("IES").Value))
            DET_DOCUMENTOBE.CTA = IIf(IsDBNull(RTrim(row.Cells("CTA").Value)), "", RTrim(row.Cells("CTA").Value))
            DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("unidad").Value)), "", RTrim(row.Cells("unidad").Value))
            DET_DOCUMENTOBE.FEC_DIA = IIf(IsDBNull(RTrim(row.Cells("FEC_DIA").Value)), "", RTrim(row.Cells("FEC_DIA").Value))
            DET_DOCUMENTOBE.X_D = IIf(IsDBNull(RTrim(row.Cells("X_D").Value)), "", RTrim(row.Cells("X_D").Value))
            DET_DOCUMENTOBE.PESO = Val(IIf(IsDBNull(RTrim(row.Cells("PESO").Value)), 0, RTrim(row.Cells("PESO").Value)))
            DET_DOCUMENTOBE.NRO_DOCU2 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU2").Value)), 0, RTrim(row.Cells("NRO_DOCU2").Value))
            DET_DOCUMENTOBE.CONFIGURACION = IIf(IsDBNull(RTrim(row.Cells("CONFIGURACION").Value)), 0, RTrim(row.Cells("CONFIGURACION").Value))
            'If PROVISIONESBE.T_DOC_REF = "07" Or PROVISIONESBE.T_DOC_REF = "14" Or PROVISIONESBE.T_DOC_REF = "36" Or
            '    PROVISIONESBE.T_DOC_REF = "01" Then
            DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells("CCO_COD").Value)), "", RTrim(row.Cells("CCO_COD").Value))
            'Else
            '    DET_DOCUMENTOBE.CCO_COD = ""
            'End If


            Dim aep As Integer = PROVISIONESBE.FEC_GENE.Year & (PROVISIONESBE.FEC_GENE.Month).ToString.PadLeft(2, "0")

            'DET_DOCUMENTOBE.NRO_DOCU1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU1").Value)), "", RTrim(row.Cells("NRO_DOCU1").Value))
            If DET_DOCUMENTOBE.STATUS = "S" Then

                If PROVISIONESBE.MONEDA = "00" Then
                    If aep >= 202207 Then
                        DET_DOCUMENTOBE.UPRECIO_COMPRA = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_COMPRA").Value)), 0, RTrim(row.Cells("UPRECIO_COMPRA").Value)))
                        DET_DOCUMENTOBE.UPRECIO_DCOMPRA = DET_DOCUMENTOBE.UPRECIO_COMPRA / DET_DOCUMENTOBE.T_CAMB
                        DET_DOCUMENTOBE.TPRECIO_COMPRA = Math.Round(DET_DOCUMENTOBE.UPRECIO_COMPRA * DET_DOCUMENTOBE.CANTIDAD, 6)
                        DET_DOCUMENTOBE.TPRECIO_DCOMPRA = Math.Round(DET_DOCUMENTOBE.UPRECIO_COMPRA * DET_DOCUMENTOBE.CANTIDAD / DET_DOCUMENTOBE.T_CAMB, 6)
                        If PROVISIONESBE.T_IGV > 0 Then
                            DET_DOCUMENTOBE.IGV_IMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_COMPRA * 7) / 100, 6)
                            DET_DOCUMENTOBE.IGV_DIMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_DCOMPRA * 7) / 100, 6)
                        Else
                            DET_DOCUMENTOBE.IGV_IMPOR = 0
                            DET_DOCUMENTOBE.IGV_DIMPOR = 0
                        End If
                    Else
                        DET_DOCUMENTOBE.UPRECIO_COMPRA = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_COMPRA").Value)), 0, RTrim(row.Cells("UPRECIO_COMPRA").Value)))
                        DET_DOCUMENTOBE.UPRECIO_DCOMPRA = DET_DOCUMENTOBE.UPRECIO_COMPRA / DET_DOCUMENTOBE.T_CAMB
                        DET_DOCUMENTOBE.TPRECIO_COMPRA = Math.Round(DET_DOCUMENTOBE.UPRECIO_COMPRA * DET_DOCUMENTOBE.CANTIDAD, 6)
                        DET_DOCUMENTOBE.TPRECIO_DCOMPRA = Math.Round(DET_DOCUMENTOBE.UPRECIO_COMPRA * DET_DOCUMENTOBE.CANTIDAD / DET_DOCUMENTOBE.T_CAMB, 6)
                        If PROVISIONESBE.T_IGV > 0 Then
                            DET_DOCUMENTOBE.IGV_IMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_COMPRA * 7) / 100, 6)
                            DET_DOCUMENTOBE.IGV_DIMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_DCOMPRA * 7) / 100, 6)
                        Else
                            DET_DOCUMENTOBE.IGV_IMPOR = 0
                            DET_DOCUMENTOBE.IGV_DIMPOR = 0
                        End If
                    End If

                ElseIf PROVISIONESBE.MONEDA = "01" Then
                    If aep >= 202207 Then
                        DET_DOCUMENTOBE.UPRECIO_DCOMPRA = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DCOMPRA").Value)), 0, RTrim(row.Cells("UPRECIO_DCOMPRA").Value)))
                        DET_DOCUMENTOBE.UPRECIO_COMPRA = DET_DOCUMENTOBE.UPRECIO_DCOMPRA * DET_DOCUMENTOBE.T_CAMB
                        DET_DOCUMENTOBE.TPRECIO_DCOMPRA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DCOMPRA * DET_DOCUMENTOBE.CANTIDAD, 2)
                        DET_DOCUMENTOBE.TPRECIO_COMPRA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DCOMPRA * DET_DOCUMENTOBE.CANTIDAD * DET_DOCUMENTOBE.T_CAMB, 2)
                        If PROVISIONESBE.T_IGV > 0 Then
                            DET_DOCUMENTOBE.IGV_IMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_COMPRA * 7) / 100, 2)
                            DET_DOCUMENTOBE.IGV_DIMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_DCOMPRA * 7) / 100, 2)
                        Else
                            DET_DOCUMENTOBE.IGV_IMPOR = 0
                            DET_DOCUMENTOBE.IGV_DIMPOR = 0
                        End If
                    Else
                        DET_DOCUMENTOBE.UPRECIO_DCOMPRA = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DCOMPRA").Value)), 0, RTrim(row.Cells("UPRECIO_DCOMPRA").Value)))
                        DET_DOCUMENTOBE.UPRECIO_COMPRA = DET_DOCUMENTOBE.UPRECIO_DCOMPRA * DET_DOCUMENTOBE.T_CAMB
                        DET_DOCUMENTOBE.TPRECIO_DCOMPRA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DCOMPRA * DET_DOCUMENTOBE.CANTIDAD, 6)
                        DET_DOCUMENTOBE.TPRECIO_COMPRA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DCOMPRA * DET_DOCUMENTOBE.CANTIDAD * DET_DOCUMENTOBE.T_CAMB, 6)
                        If PROVISIONESBE.T_IGV > 0 Then
                            DET_DOCUMENTOBE.IGV_IMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_COMPRA * 7) / 100, 6)
                            DET_DOCUMENTOBE.IGV_DIMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_DCOMPRA * 7) / 100, 6)
                        Else
                            DET_DOCUMENTOBE.IGV_IMPOR = 0
                            DET_DOCUMENTOBE.IGV_DIMPOR = 0
                        End If
                    End If

                End If

                Else
                If PROVISIONESBE.MONEDA = "00" Then
                    DET_DOCUMENTOBE.UPRECIO_AFECTOD = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOS").Value)), 0, RTrim(row.Cells("UPRECIO_AFECTOS").Value))) / DET_DOCUMENTOBE.T_CAMB
                    DET_DOCUMENTOBE.UPRECIO_AFECTOS = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOS").Value)), 0, RTrim(row.Cells("UPRECIO_AFECTOS").Value)))

                    DET_DOCUMENTOBE.TPRECIO_COMPRA = Math.Round(DET_DOCUMENTOBE.UPRECIO_AFECTOS * DET_DOCUMENTOBE.CANTIDAD, 6)
                    DET_DOCUMENTOBE.TPRECIO_DCOMPRA = Math.Round(DET_DOCUMENTOBE.UPRECIO_AFECTOS * DET_DOCUMENTOBE.CANTIDAD / DET_DOCUMENTOBE.T_CAMB, 6)
                    'DET_DOCUMENTOBE.UPRECIO_DCOMPRA = DET_DOCUMENTOBE.UPRECIO_COMPRA / DET_DOCUMENTOBE.T_CAMB
                    DET_DOCUMENTOBE.IGV_IMPOR = 0
                    DET_DOCUMENTOBE.IGV_DIMPOR = 0
                ElseIf PROVISIONESBE.MONEDA = "01" Then
                    DET_DOCUMENTOBE.UPRECIO_AFECTOD = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOD").Value)), 0, RTrim(row.Cells("UPRECIO_AFECTOD").Value)))
                    DET_DOCUMENTOBE.UPRECIO_AFECTOS = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOD").Value)), 0, RTrim(row.Cells("UPRECIO_AFECTOD").Value))) * DET_DOCUMENTOBE.T_CAMB
                    If aep >= 202207 Then
                        DET_DOCUMENTOBE.TPRECIO_COMPRA = Math.Round(DET_DOCUMENTOBE.UPRECIO_AFECTOD * DET_DOCUMENTOBE.CANTIDAD * DET_DOCUMENTOBE.T_CAMB, 2)
                        DET_DOCUMENTOBE.TPRECIO_DCOMPRA = Math.Round(DET_DOCUMENTOBE.UPRECIO_AFECTOD * DET_DOCUMENTOBE.CANTIDAD, 2)
                    Else
                        DET_DOCUMENTOBE.TPRECIO_COMPRA = Math.Round(DET_DOCUMENTOBE.UPRECIO_AFECTOD * DET_DOCUMENTOBE.CANTIDAD * DET_DOCUMENTOBE.T_CAMB, 6)
                        DET_DOCUMENTOBE.TPRECIO_DCOMPRA = Math.Round(DET_DOCUMENTOBE.UPRECIO_AFECTOD * DET_DOCUMENTOBE.CANTIDAD, 6)
                    End If

                    DET_DOCUMENTOBE.IGV_IMPOR = 0
                    DET_DOCUMENTOBE.IGV_DIMPOR = 0
                End If
            End If
            DAcumula = DET_DOCUMENTOBE.UPRECIO_COMPRA + DAcumula
            DAcumula1 = DET_DOCUMENTOBE.UPRECIO_DCOMPRA + DAcumula1
            DAcumula2 = DET_DOCUMENTOBE.TPRECIO_DCOMPRA + DAcumula2
            DAcumula3 = DET_DOCUMENTOBE.TPRECIO_COMPRA + DAcumula3
            DAcumula4 = DET_DOCUMENTOBE.IGV_IMPOR + DAcumula4
            DAcumula5 = DET_DOCUMENTOBE.IGV_DIMPOR + DAcumula5
            DAcumula6 = DET_DOCUMENTOBE.UPRECIO_AFECTOD + DAcumula6
            DAcumula7 = DET_DOCUMENTOBE.UPRECIO_AFECTOS + DAcumula7


            ' DET_DOCUMENTOBE.FEC_LLEG = IIf(IsDBNull(RTrim(row.Cells(12).Value)), "", RTrim(row.Cells(12).Value))
            'contenedor = IIf(IsDBNull(RTrim(row.Cells("FEC_ANU").Value)), ORDENCOMPRABE.FEC_ANU, RTrim(row.Cells("FEC_ANU").Value))

            'DET_DOCUMENTOBE.EST = IIf(IsDBNull(RTrim(row.Cells("EST").Value)), "", RTrim(row.Cells("EST").Value))
            'If PROVISIONESBE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 And PROVISIONESBE.T_DOC_REF = DET_DOCUMENTOBE.T_DOC_REF1 Then
            '    DET_DOCUMENTOBE.NRO_DOC_REF1 = PROVISIONESBE.NRO_DOC_REF & "-" & cont
            'End If
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = PROVISIONESBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = PROVISIONESBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = PROVISIONESBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = PROVISIONESBE.CTCT_COD
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO
            cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.TPRECIO_COMPRA)
            cmd.Parameters.Add("@TPRECIO_DCOMPRA", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.TPRECIO_DCOMPRA)
            cmd.Parameters.Add("@igv", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.IGV)
            cmd.Parameters.Add("@IGV_IMPOR", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.IGV_IMPOR)
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
            cmd.Parameters.Add("@t_camb", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.T_CAMB)
            cmd.Parameters.Add("@UPRECIO_COMPRA", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.UPRECIO_COMPRA)
            cmd.Parameters.Add("@UPRECIO_dCOMPRA", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.UPRECIO_DCOMPRA)
            cmd.Parameters.Add("@IGV_DIMPOR", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.IGV_DIMPOR)
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = PROVISIONESBE.MONEDA
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = PROVISIONESBE.USUARIO
            cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = PROVISIONESBE.PROVEEDOR
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = PROVISIONESBE.FEC_GENE
            cmd.Parameters.Add("@CUENTA", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.CUENTA)
            cmd.Parameters.Add("@CUENTA_DEST", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CUENTA_DEST
            cmd.Parameters.Add("@STATUS", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.STATUS
            cmd.Parameters.Add("@UPRECIO_AFECTOS", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.UPRECIO_AFECTOS)
            cmd.Parameters.Add("@UPRECIO_AFECTOD", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.UPRECIO_AFECTOD)
            cmd.Parameters.Add("@IES_IMPOR", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.IES_IMPOR)
            cmd.Parameters.Add("@IES_DIMPOR", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.IES_DIMPOR)
            cmd.Parameters.Add("@CTA_IMPOR", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CTA_IMPOR)
            cmd.Parameters.Add("@CTA_DIMPOR", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CTA_DIMPOR)
            cmd.Parameters.Add("@IES", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.IES)
            cmd.Parameters.Add("@CTA", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CTA)
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
            'cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_DIA
            cmd.Parameters.Add("@DSCTO", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.DSCTO)
            cmd.Parameters.Add("@DSCTO_IMPOR", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.DSCTO_IMPOR)
            cmd.Parameters.Add("@DSCTO_DIMPOR", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.DSCTO_DIMPOR)
            cmd.Parameters.Add("@F_PAGO_ENT", OracleDbType.Varchar2).Value = Trim(PROVISIONESBE.F_PAGO_ENT)
            cmd.Parameters.Add("@X_D", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.X_D)
            cmd.Parameters.Add("@PESO", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.PESO)
            cmd.Parameters.Add("@NRO_DOCU2", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOCU2)
            cmd.Parameters.Add("@CONFIGURACION", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.CONFIGURACION)
            cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.CCO_COD)
            cmd.Parameters.Add("@NUMPEDIDO", OracleDbType.Varchar2).Value = Trim(PROVISIONESBE.NUMPEDIDO)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
        'ACTUALIZA CABECERA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDTOTALESPV"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = PROVISIONESBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = PROVISIONESBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = PROVISIONESBE.NRO_DOC_REF
        cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = DAcumula3
        cmd.Parameters.Add("@TPRECIO_DVENTA", OracleDbType.Double).Value = DAcumula2
        cmd.Parameters.Add("@T_IGV", OracleDbType.Double).Value = DAcumula4
        cmd.Parameters.Add("@T_IGV_DOLAR", OracleDbType.Double).Value = DAcumula5
        cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = PROVISIONESBE.PROVEEDOR
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        If ELMVLOGSBE.log_codusu = "0001" Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
            cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
            cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el documento de Compra: " + PROVISIONESBE.SER_DOC_REF + "-" + PROVISIONESBE.NRO_DOC_REF + "Proveedor:" + PROVISIONESBE.PROVEEDOR
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

    End Sub
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
    Public Sub UpdReg(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sAño As String, ByVal sMes As String,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                      ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_REGCOMPRA_UPDASIENTO"
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
            cmd.CommandText = "SP_CONTNUVOSOLES_C2_COM"
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
    Public Sub UpdTC(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sAño As String, ByVal sMes As String, ByVal sUser As String,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                      ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_TCAMB_FEC2"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@fec", OracleDbType.Varchar2).Value = sMes
        cmd.Parameters.Add("@suser", OracleDbType.Varchar2).Value = sUser

        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRow(ByVal PROVISIONESBE As PROVISIONESBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal dg As DataGridView)

        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim DAcumula6 As Double = 0
        Dim DAcumula7 As Double = 0
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PROVISIONES_UPDROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = PROVISIONESBE.T_DOC_REF
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = PROVISIONESBE.SER_DOC_REF
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = PROVISIONESBE.NRO_DOC_REF
        cmd.Parameters.Add("@TDOC", OracleDbType.Varchar2).Value = PROVISIONESBE.TDOC
        cmd.Parameters.Add("@SDOC", OracleDbType.Varchar2).Value = PROVISIONESBE.SDOC
        cmd.Parameters.Add("@NDOC", OracleDbType.Varchar2).Value = PROVISIONESBE.NDOC
        cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = PROVISIONESBE.ART_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = PROVISIONESBE.FEC_GENE
        cmd.Parameters.Add("@FEC", OracleDbType.Varchar2).Value = PROVISIONESBE.FEC
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = PROVISIONESBE.EST
        cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = PROVISIONESBE.MONEDA
        cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = PROVISIONESBE.TPRECIO_COMPRA
        cmd.Parameters.Add("@SIGNO", OracleDbType.Varchar2).Value = PROVISIONESBE.SIGNO
        cmd.Parameters.Add("@TPRECIO_DCOMPRA", OracleDbType.Double).Value = PROVISIONESBE.TPRECIO_DCOMPRA
        cmd.Parameters.Add("@USUARIO", OracleDbType.Varchar2).Value = PROVISIONESBE.USUARIO
        cmd.Parameters.Add("@OBSERVA", OracleDbType.Varchar2).Value = PROVISIONESBE.OBSERVA
        cmd.Parameters.Add("@T_IGV", OracleDbType.Double).Value = PROVISIONESBE.T_IGV
        cmd.Parameters.Add("@T_IGV_DOLAR", OracleDbType.Double).Value = PROVISIONESBE.T_IGV_DOLAR
        cmd.Parameters.Add("@T_DCTO", OracleDbType.Double).Value = PROVISIONESBE.T_DCTO
        cmd.Parameters.Add("@T_DCTO_DOLAR", OracleDbType.Double).Value = PROVISIONESBE.T_DCTO_DOLAR
        cmd.Parameters.Add("@T_OPE", OracleDbType.Varchar2).Value = PROVISIONESBE.T_OPE
        cmd.Parameters.Add("@X_RET", OracleDbType.Varchar2).Value = PROVISIONESBE.X_RET
        cmd.Parameters.Add("@REG_NRO", OracleDbType.Varchar2).Value = PROVISIONESBE.REG_NRO
        cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = PROVISIONESBE.PROVEEDOR
        cmd.Parameters.Add("@P", OracleDbType.Varchar2).Value = PROVISIONESBE.P
        cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = PROVISIONESBE.TIPO
        cmd.Parameters.Add("@FEC_PROV", OracleDbType.Date).Value = PROVISIONESBE.FEC_PROV
        cmd.Parameters.Add("@T_IES", OracleDbType.Double).Value = PROVISIONESBE.T_IES
        cmd.Parameters.Add("@T_DIES", OracleDbType.Double).Value = PROVISIONESBE.T_DIES
        cmd.Parameters.Add("@T_CTA", OracleDbType.Double).Value = PROVISIONESBE.T_CTA
        cmd.Parameters.Add("@T_DCTA", OracleDbType.Double).Value = PROVISIONESBE.T_DCTA
        cmd.Parameters.Add("@TAFECTO", OracleDbType.Double).Value = PROVISIONESBE.TAFECTO
        cmd.Parameters.Add("@TAFECTOD", OracleDbType.Double).Value = PROVISIONESBE.TAFECTOD
        cmd.Parameters.Add("@TIPO2", OracleDbType.Varchar2).Value = PROVISIONESBE.TIPO2
        cmd.Parameters.Add("@LETRA", OracleDbType.Varchar2).Value = PROVISIONESBE.LETRA
        cmd.Parameters.Add("@FEC_LETRA", OracleDbType.Date).Value = PROVISIONESBE.FEC_LETRA
        cmd.Parameters.Add("@TIPO1", OracleDbType.Varchar2).Value = PROVISIONESBE.TIPO1
        cmd.Parameters.Add("@NRO_PERCEPCION", OracleDbType.Varchar2).Value = PROVISIONESBE.NRO_PERCEPCION
        cmd.Parameters.Add("@EST1", OracleDbType.Varchar2).Value = PROVISIONESBE.EST1
        cmd.Parameters.Add("@DETRACCION", OracleDbType.Varchar2).Value = PROVISIONESBE.DETRACCION
        cmd.Parameters.Add("@FEC_DET", OracleDbType.Date).Value = PROVISIONESBE.FEC_DET
        cmd.Parameters.Add("@F_PAGO_ENT ", OracleDbType.Varchar2).Value = Trim(PROVISIONESBE.F_PAGO_ENT)
        cmd.Parameters.Add("@MONTO_PAGADO ", OracleDbType.Double).Value = Trim(PROVISIONESBE.MONTO_PAGADO)
        cmd.Parameters.Add("@PORCENTAJE ", OracleDbType.Double).Value = Trim(PROVISIONESBE.PORCENTAJE)
        cmd.Parameters.Add("@CTA_CBCO ", OracleDbType.Varchar2).Value = Trim(PROVISIONESBE.CTA_CBCO)
        cmd.Parameters.Add("@FARDO ", OracleDbType.Varchar2).Value = Trim(PROVISIONESBE.FARDO)
        cmd.Parameters.Add("@PROGRAMA ", OracleDbType.Varchar2).Value = Trim(PROVISIONESBE.PROGRAMA)
        cmd.Parameters.Add("@NUMPEDIDO ", OracleDbType.Varchar2).Value = Trim(PROVISIONESBE.NUMPEDIDO)
        cmd.Parameters.Add("@NOM_CTCT ", OracleDbType.Varchar2).Value = Trim(PROVISIONESBE.NOM_CTCT)
        cmd.Parameters.Add("@TIPO7", OracleDbType.Varchar2).Value = Trim(PROVISIONESBE.TIPO7)
        cmd.Parameters.Add("@EST_MERCADERIA", OracleDbType.Varchar2).Value = Trim(PROVISIONESBE.EST_MERCADERIA)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCUMENTO_DEL_PRV"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = PROVISIONESBE.TDOC
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = PROVISIONESBE.SDOC
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = PROVISIONESBE.NDOC
        cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = PROVISIONESBE.P
        cmd.Parameters.Add("@FEC", OracleDbType.Varchar2).Value = PROVISIONESBE.FECP
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim cont As Integer = 0
        Dim aep As Integer = PROVISIONESBE.FEC_PROV.Year & (PROVISIONESBE.FEC_PROV.Month).ToString.PadLeft(2, "0")
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DETPROVISIONES_INSROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            DET_DOCUMENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            DET_DOCUMENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells("CTCT_COD").Value)), "", RTrim(row.Cells("CTCT_COD").Value))
            DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            DET_DOCUMENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells("SIGNO").Value)), "", RTrim(row.Cells("SIGNO").Value))
            DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            DET_DOCUMENTOBE.IGV = IIf(IsDBNull(RTrim(row.Cells("IGV").Value)), 0, RTrim(row.Cells("IGV").Value))
            DET_DOCUMENTOBE.IGV_IMPOR = IIf(IsDBNull(RTrim(row.Cells("IGV_IMPOR").Value)), 0, RTrim(row.Cells("IGV_IMPOR").Value))
            DET_DOCUMENTOBE.IGV_IMPOR = IIf(IsDBNull(RTrim(row.Cells("IGV_DIMPOR").Value)), 0, RTrim(row.Cells("IGV_DIMPOR").Value))
            DET_DOCUMENTOBE.T_CAMB = IIf(IsDBNull(RTrim(row.Cells("T_CAMB").Value)), 0, RTrim(row.Cells("T_CAMB").Value))
            'DET_DOCUMENTOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells("FEC_GENE").Value)), "", RTrim(row.Cells("FEC_GENE").Value))
            DET_DOCUMENTOBE.USUARIO = IIf(IsDBNull(RTrim(row.Cells("USUARIO").Value)), "", RTrim(row.Cells("USUARIO").Value))
            DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
            'DET_DOCUMENTOBE.FEC_DIA = IIf(IsDBNull(RTrim(row.Cells("FEC_DIA").Value)), "", RTrim(row.Cells("FEC_DIA").Value))
            DET_DOCUMENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR").Value)), "", RTrim(row.Cells("PROVEEDOR").Value))
            DET_DOCUMENTOBE.CUENTA = IIf(IsDBNull(RTrim(row.Cells("CUENTA").Value)), "", RTrim(row.Cells("CUENTA").Value))
            DET_DOCUMENTOBE.CUENTA_DEST = IIf(IsDBNull(RTrim(row.Cells("CUENTA_DEST").Value)), "", RTrim(row.Cells("CUENTA_DEST").Value))
            DET_DOCUMENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells("SIGNO").Value)), "", RTrim(row.Cells("SIGNO").Value))
            DET_DOCUMENTOBE.NRO_DOCU2 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU2").Value)), "", RTrim(row.Cells("NRO_DOCU2").Value))
            DET_DOCUMENTOBE.CONFIGURACION = IIf(IsDBNull(RTrim(row.Cells("CONFIGURACION").Value)), "", RTrim(row.Cells("CONFIGURACION").Value))
            If IIf(IsDBNull(RTrim(row.Cells("STATUS").Value)), "", RTrim(row.Cells("STATUS").Value)) = "AFECTO" Then
                DET_DOCUMENTOBE.STATUS = "S"
            ElseIf IIf(IsDBNull(RTrim(row.Cells("STATUS").Value)), "", RTrim(row.Cells("STATUS").Value)) = "INAFECTO" Then
                DET_DOCUMENTOBE.STATUS = "N"
            End If

            'DET_DOCUMENTOBE.STATUS = IIf(IsDBNull(RTrim(row.Cells("STATUS").Value)), "", RTrim(row.Cells("STATUS").Value))
            If Val(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOS").Value)), 0, RTrim(row.Cells("UPRECIO_AFECTOS").Value))) = 0 Then
                DET_DOCUMENTOBE.UPRECIO_AFECTOS = 0
            Else
                DET_DOCUMENTOBE.UPRECIO_AFECTOS = Val(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOS").Value)), 0, RTrim(row.Cells("UPRECIO_AFECTOS").Value))) * 1000
            End If
            If Val(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOD").Value)), 0, RTrim(row.Cells("UPRECIO_AFECTOD").Value))) = 0 Then
                DET_DOCUMENTOBE.UPRECIO_AFECTOD = 0
            Else
                DET_DOCUMENTOBE.UPRECIO_AFECTOD = Val(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_AFECTOD").Value)), 0, RTrim(row.Cells("UPRECIO_AFECTOD").Value))) * 1000
            End If
            If Val(IIf(IsDBNull(RTrim(row.Cells("IES_IMPOR").Value)), 0, RTrim(row.Cells("IES_IMPOR").Value))) = 0 Then
                DET_DOCUMENTOBE.IES_IMPOR = 0
            Else
                DET_DOCUMENTOBE.IES_IMPOR = IIf(IsDBNull(RTrim(row.Cells("IES_IMPOR").Value)), 0, RTrim(row.Cells("IES_IMPOR").Value))
            End If
            If IIf(IsDBNull(RTrim(row.Cells("IES_DIMPOR").Value)), 0, RTrim(row.Cells("IES_DIMPOR").Value)) = "" Then
                DET_DOCUMENTOBE.IES_DIMPOR = 0
            Else
                DET_DOCUMENTOBE.IES_DIMPOR = IIf(IsDBNull(RTrim(row.Cells("IES_DIMPOR").Value)), 0, RTrim(row.Cells("IES_DIMPOR").Value))
            End If
            If IIf(IsDBNull(RTrim(row.Cells("CTA_IMPOR").Value)), 0, RTrim(row.Cells("CTA_IMPOR").Value)) = "" Then
                DET_DOCUMENTOBE.CTA_IMPOR = 0
            Else
                DET_DOCUMENTOBE.CTA_IMPOR = IIf(IsDBNull(RTrim(row.Cells("CTA_IMPOR").Value)), 0, RTrim(row.Cells("CTA_IMPOR").Value))
            End If
            If IIf(IsDBNull(RTrim(row.Cells("CTA_DIMPOR").Value)), 0, RTrim(row.Cells("CTA_DIMPOR").Value)) = "" Then
                DET_DOCUMENTOBE.CTA_DIMPOR = 0
            Else
                DET_DOCUMENTOBE.CTA_DIMPOR = IIf(IsDBNull(RTrim(row.Cells("CTA_DIMPOR").Value)), 0, RTrim(row.Cells("CTA_DIMPOR").Value))
            End If
            If IIf(IsDBNull(RTrim(row.Cells("IES").Value)), 0, RTrim(row.Cells("IES").Value)) = "" Then
                DET_DOCUMENTOBE.IES = 0
            Else
                DET_DOCUMENTOBE.IES = IIf(IsDBNull(RTrim(row.Cells("IES").Value)), 0, RTrim(row.Cells("IES").Value))
            End If
            If IIf(IsDBNull(RTrim(row.Cells("CTA").Value)), 0, RTrim(row.Cells("CTA").Value)) = "" Then
                DET_DOCUMENTOBE.CTA = 0
            Else
                DET_DOCUMENTOBE.CTA = IIf(IsDBNull(RTrim(row.Cells("CTA").Value)), 0, RTrim(row.Cells("CTA").Value))
            End If

            DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("unidad").Value)), 0, RTrim(row.Cells("unidad").Value))
            'DET_DOCUMENTOBE.FEC_DIA = IIf(IsDBNull(RTrim(row.Cells("FEC_DIA").Value)),"", RTrim(row.Cells("FEC_DIA").Value))
            DET_DOCUMENTOBE.X_D = IIf(IsDBNull(RTrim(row.Cells("X_D").Value)), "", RTrim(row.Cells("X_D").Value))
            DET_DOCUMENTOBE.PESO = Val(IIf(IsDBNull(RTrim(row.Cells("PESO").Value)), 0, RTrim(row.Cells("PESO").Value)))
            'If PROVISIONESBE.T_DOC_REF = "07" Or PROVISIONESBE.T_DOC_REF = "14" Or PROVISIONESBE.T_DOC_REF = "36" Or
            '    PROVISIONESBE.T_DOC_REF = "01" Or PROVISIONESBE.T_DOC_REF = "00" Then
            DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells("CCO_COD").Value)), "", RTrim(row.Cells("CCO_COD").Value))
            'Else
            '    DET_DOCUMENTOBE.CCO_COD = ""
            'End If


            'End If
            'DET_DOCUMENTOBE.NRO_DOCU1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU1").Value)), "", RTrim(row.Cells("NRO_DOCU1").Value))
            If DET_DOCUMENTOBE.STATUS = "S" Then
                If PROVISIONESBE.MONEDA = "00" Then
                    If aep >= 202207 Then
                        DET_DOCUMENTOBE.UPRECIO_COMPRA = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_COMPRA").Value)), 0, RTrim(row.Cells("UPRECIO_COMPRA").Value)))
                        DET_DOCUMENTOBE.UPRECIO_DCOMPRA = DET_DOCUMENTOBE.UPRECIO_COMPRA / DET_DOCUMENTOBE.T_CAMB
                        DET_DOCUMENTOBE.TPRECIO_COMPRA = Math.Round(DET_DOCUMENTOBE.UPRECIO_COMPRA * DET_DOCUMENTOBE.CANTIDAD, 2)
                        DET_DOCUMENTOBE.TPRECIO_DCOMPRA = Math.Round(DET_DOCUMENTOBE.UPRECIO_COMPRA * DET_DOCUMENTOBE.CANTIDAD / DET_DOCUMENTOBE.T_CAMB, 2)
                        If PROVISIONESBE.T_IGV > 0 Then
                            DET_DOCUMENTOBE.IGV_IMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_COMPRA * DET_DOCUMENTOBE.IGV) / 100, 2)
                            DET_DOCUMENTOBE.IGV_DIMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_DCOMPRA * DET_DOCUMENTOBE.IGV) / 100, 2)
                        Else
                            DET_DOCUMENTOBE.IGV_IMPOR = 0
                            DET_DOCUMENTOBE.IGV_DIMPOR = 0
                        End If
                    Else
                        DET_DOCUMENTOBE.UPRECIO_COMPRA = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_COMPRA").Value)), 0, RTrim(row.Cells("UPRECIO_COMPRA").Value)))
                        DET_DOCUMENTOBE.UPRECIO_DCOMPRA = DET_DOCUMENTOBE.UPRECIO_COMPRA / DET_DOCUMENTOBE.T_CAMB
                        DET_DOCUMENTOBE.TPRECIO_COMPRA = Math.Round(DET_DOCUMENTOBE.UPRECIO_COMPRA * DET_DOCUMENTOBE.CANTIDAD, 6)
                        DET_DOCUMENTOBE.TPRECIO_DCOMPRA = Math.Round(DET_DOCUMENTOBE.UPRECIO_COMPRA * DET_DOCUMENTOBE.CANTIDAD / DET_DOCUMENTOBE.T_CAMB, 6)
                        If PROVISIONESBE.T_IGV > 0 Then
                            DET_DOCUMENTOBE.IGV_IMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_COMPRA * DET_DOCUMENTOBE.IGV) / 100, 6)
                            DET_DOCUMENTOBE.IGV_DIMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_DCOMPRA * DET_DOCUMENTOBE.IGV) / 100, 6)
                        Else
                            DET_DOCUMENTOBE.IGV_IMPOR = 0
                            DET_DOCUMENTOBE.IGV_DIMPOR = 0
                        End If
                    End If



                ElseIf PROVISIONESBE.MONEDA = "01" Then
                    If aep >= 202207 Then
                        DET_DOCUMENTOBE.UPRECIO_DCOMPRA = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DCOMPRA").Value)), 0, RTrim(row.Cells("UPRECIO_DCOMPRA").Value)))
                        DET_DOCUMENTOBE.UPRECIO_COMPRA = DET_DOCUMENTOBE.UPRECIO_DCOMPRA * DET_DOCUMENTOBE.T_CAMB
                        DET_DOCUMENTOBE.TPRECIO_DCOMPRA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DCOMPRA * DET_DOCUMENTOBE.CANTIDAD, 2)
                        DET_DOCUMENTOBE.TPRECIO_COMPRA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DCOMPRA * DET_DOCUMENTOBE.CANTIDAD * DET_DOCUMENTOBE.T_CAMB, 2)
                        If PROVISIONESBE.T_IGV > 0 Then
                            DET_DOCUMENTOBE.IGV_IMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_COMPRA * DET_DOCUMENTOBE.IGV) / 100, 2)
                            DET_DOCUMENTOBE.IGV_DIMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_DCOMPRA * DET_DOCUMENTOBE.IGV) / 100, 2)
                        Else
                            DET_DOCUMENTOBE.IGV_IMPOR = 0
                            DET_DOCUMENTOBE.IGV_DIMPOR = 0
                        End If
                    Else
                        DET_DOCUMENTOBE.UPRECIO_DCOMPRA = CDbl(IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DCOMPRA").Value)), 0, RTrim(row.Cells("UPRECIO_DCOMPRA").Value)))
                        DET_DOCUMENTOBE.UPRECIO_COMPRA = DET_DOCUMENTOBE.UPRECIO_DCOMPRA * DET_DOCUMENTOBE.T_CAMB
                        DET_DOCUMENTOBE.TPRECIO_DCOMPRA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DCOMPRA * DET_DOCUMENTOBE.CANTIDAD, 6)
                        DET_DOCUMENTOBE.TPRECIO_COMPRA = Math.Round(DET_DOCUMENTOBE.UPRECIO_DCOMPRA * DET_DOCUMENTOBE.CANTIDAD * DET_DOCUMENTOBE.T_CAMB, 6)
                        If PROVISIONESBE.T_IGV > 0 Then
                            DET_DOCUMENTOBE.IGV_IMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_COMPRA * DET_DOCUMENTOBE.IGV) / 100, 6)
                            DET_DOCUMENTOBE.IGV_DIMPOR = Math.Round((DET_DOCUMENTOBE.TPRECIO_DCOMPRA * DET_DOCUMENTOBE.IGV) / 100, 6)
                        Else
                            DET_DOCUMENTOBE.IGV_IMPOR = 0
                            DET_DOCUMENTOBE.IGV_DIMPOR = 0
                        End If
                    End If


                End If
            Else
                If PROVISIONESBE.MONEDA = "00" Then
                    DET_DOCUMENTOBE.UPRECIO_DCOMPRA = 0
                    DET_DOCUMENTOBE.UPRECIO_COMPRA = 0
                    If aep >= 202207 Then
                        DET_DOCUMENTOBE.TPRECIO_COMPRA = Math.Round((DET_DOCUMENTOBE.UPRECIO_AFECTOS / 1000) * DET_DOCUMENTOBE.CANTIDAD, 6)
                        DET_DOCUMENTOBE.TPRECIO_DCOMPRA = Math.Round((DET_DOCUMENTOBE.UPRECIO_AFECTOS / 1000) * DET_DOCUMENTOBE.CANTIDAD / DET_DOCUMENTOBE.T_CAMB, 6)
                    Else
                        DET_DOCUMENTOBE.TPRECIO_COMPRA = Math.Round((DET_DOCUMENTOBE.UPRECIO_AFECTOS / 1000) * DET_DOCUMENTOBE.CANTIDAD, 6)
                        DET_DOCUMENTOBE.TPRECIO_DCOMPRA = Math.Round((DET_DOCUMENTOBE.UPRECIO_AFECTOS / 1000) * DET_DOCUMENTOBE.CANTIDAD / DET_DOCUMENTOBE.T_CAMB, 6)
                    End If

                    DET_DOCUMENTOBE.IGV_IMPOR = 0
                    DET_DOCUMENTOBE.IGV_DIMPOR = 0
                ElseIf PROVISIONESBE.MONEDA = "01" Then
                    DET_DOCUMENTOBE.UPRECIO_DCOMPRA = 0
                    DET_DOCUMENTOBE.UPRECIO_COMPRA = 0
                    DET_DOCUMENTOBE.UPRECIO_AFECTOS = Val(DET_DOCUMENTOBE.UPRECIO_AFECTOD) * DET_DOCUMENTOBE.T_CAMB
                    If aep >= 202207 Then
                        DET_DOCUMENTOBE.TPRECIO_DCOMPRA = Math.Round((DET_DOCUMENTOBE.UPRECIO_AFECTOD / 1000) * DET_DOCUMENTOBE.CANTIDAD, 2)
                        DET_DOCUMENTOBE.TPRECIO_COMPRA = Math.Round((DET_DOCUMENTOBE.UPRECIO_AFECTOD / 1000) * DET_DOCUMENTOBE.CANTIDAD * DET_DOCUMENTOBE.T_CAMB, 2)
                    Else
                        DET_DOCUMENTOBE.TPRECIO_DCOMPRA = Math.Round((DET_DOCUMENTOBE.UPRECIO_AFECTOD / 1000) * DET_DOCUMENTOBE.CANTIDAD, 6)
                        DET_DOCUMENTOBE.TPRECIO_COMPRA = Math.Round((DET_DOCUMENTOBE.UPRECIO_AFECTOD / 1000) * DET_DOCUMENTOBE.CANTIDAD * DET_DOCUMENTOBE.T_CAMB, 6)
                    End If

                    DET_DOCUMENTOBE.IGV_IMPOR = 0
                    DET_DOCUMENTOBE.IGV_DIMPOR = 0
                End If
            End If
            'If aep >= 202206 Then
            DAcumula = DET_DOCUMENTOBE.UPRECIO_COMPRA + DAcumula
            DAcumula1 = DET_DOCUMENTOBE.UPRECIO_DCOMPRA + DAcumula1
            'If DET_DOCUMENTOBE.STATUS = "S" Then
            DAcumula2 = DET_DOCUMENTOBE.TPRECIO_DCOMPRA + DAcumula2
            DAcumula3 = DET_DOCUMENTOBE.TPRECIO_COMPRA + DAcumula3
            'End If
            DAcumula4 = DET_DOCUMENTOBE.IGV_IMPOR + DAcumula4
            DAcumula5 = DET_DOCUMENTOBE.IGV_DIMPOR + DAcumula5
            'Else

            'End If



            ' DET_DOCUMENTOBE.FEC_LLEG = IIf(IsDBNull(RTrim(row.Cells(12).Value)), "", RTrim(row.Cells(12).Value))
            'contenedor = IIf(IsDBNull(RTrim(row.Cells("FEC_ANU").Value)), ORDENCOMPRABE.FEC_ANU, RTrim(row.Cells("FEC_ANU").Value))

            'DET_DOCUMENTOBE.EST = IIf(IsDBNull(RTrim(row.Cells("EST").Value)), "", RTrim(row.Cells("EST").Value))
            'If PROVISIONESBE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 And PROVISIONESBE.T_DOC_REF = DET_DOCUMENTOBE.T_DOC_REF1 Then
            '    DET_DOCUMENTOBE.NRO_DOC_REF1 = PROVISIONESBE.NRO_DOC_REF & "-" & cont
            'End If
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = PROVISIONESBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = PROVISIONESBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = PROVISIONESBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = PROVISIONESBE.CTCT_COD
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO
            cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.TPRECIO_COMPRA)
            cmd.Parameters.Add("@TPRECIO_DCOMPRA", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.TPRECIO_DCOMPRA)
            cmd.Parameters.Add("@igv", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.IGV)
            cmd.Parameters.Add("@IGV_IMPOR", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.IGV_IMPOR)
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
            cmd.Parameters.Add("@t_camb", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.T_CAMB)
            cmd.Parameters.Add("@UPRECIO_COMPRA", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.UPRECIO_COMPRA)
            cmd.Parameters.Add("@UPRECIO_dCOMPRA", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.UPRECIO_DCOMPRA)
            cmd.Parameters.Add("@IGV_DIMPOR", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.IGV_DIMPOR)
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = PROVISIONESBE.MONEDA
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = PROVISIONESBE.USUARIO
            cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = PROVISIONESBE.PROVEEDOR
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = PROVISIONESBE.FEC_GENE
            cmd.Parameters.Add("@CUENTA", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.CUENTA)
            cmd.Parameters.Add("@CUENTA_DEST", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CUENTA_DEST
            cmd.Parameters.Add("@STATUS", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.STATUS
            If DET_DOCUMENTOBE.UPRECIO_AFECTOS = 0 Then
                cmd.Parameters.Add("@UPRECIO_AFECTOS", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.UPRECIO_AFECTOS)
            Else
                cmd.Parameters.Add("@UPRECIO_AFECTOS", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.UPRECIO_AFECTOS) / 1000
            End If
            If DET_DOCUMENTOBE.UPRECIO_AFECTOD = 0 Then
                cmd.Parameters.Add("@UPRECIO_AFECTOD", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.UPRECIO_AFECTOD)
            Else
                cmd.Parameters.Add("@UPRECIO_AFECTOD", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.UPRECIO_AFECTOD) / 1000
            End If
            cmd.Parameters.Add("@IES_IMPOR", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.IES_IMPOR)
            cmd.Parameters.Add("@IES_DIMPOR", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.IES_DIMPOR)
            cmd.Parameters.Add("@CTA_IMPOR", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CTA_IMPOR)
            cmd.Parameters.Add("@CTA_DIMPOR", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CTA_DIMPOR)
            cmd.Parameters.Add("@IES", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.IES)
            cmd.Parameters.Add("@CTA", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CTA)
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
            'cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_DIA
            cmd.Parameters.Add("@DSCTO", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.DSCTO)
            cmd.Parameters.Add("@DSCTO_IMPOR", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.DSCTO_IMPOR)
            cmd.Parameters.Add("@DSCTO_DIMPOR", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.DSCTO_DIMPOR)
            cmd.Parameters.Add("@F_PAGO_ENT", OracleDbType.Varchar2).Value = Trim(PROVISIONESBE.F_PAGO_ENT)
            cmd.Parameters.Add("@X_D", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.X_D)
            cmd.Parameters.Add("@PESO", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.PESO)
            cmd.Parameters.Add("@NRO_DOCU2", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOCU2)
            cmd.Parameters.Add("@CONFIGURACION", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.CONFIGURACION)
            cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.CCO_COD)
            cmd.Parameters.Add("@NUMPEDIDO ", OracleDbType.Varchar2).Value = Trim(PROVISIONESBE.NUMPEDIDO)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
        'ACTUALIZA CABECERA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDTOTALESPV"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = PROVISIONESBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = PROVISIONESBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = PROVISIONESBE.NRO_DOC_REF
        'If aep >= 202206 Then
        '    cmd.Parameters.Add("@TPRECIO_VENTA", OracleDbType.Double).Value = Math.Round(DAcumula3, 2)
        '    cmd.Parameters.Add("@TPRECIO_DVENTA", OracleDbType.Double).Value = Math.Round(DAcumula2, 2)
        '    cmd.Parameters.Add("@T_IGV", OracleDbType.Double).Value = Math.Round(DAcumula4, 2)
        '    cmd.Parameters.Add("@T_IGV_DOLAR", OracleDbType.Double).Value = Math.Round(DAcumula5, 2)
        'Else
        cmd.Parameters.Add("@TPRECIO_VENTA", OracleDbType.Double).Value = DAcumula3
            cmd.Parameters.Add("@TPRECIO_DVENTA", OracleDbType.Double).Value = DAcumula2
            cmd.Parameters.Add("@T_IGV", OracleDbType.Double).Value = DAcumula4
            cmd.Parameters.Add("@T_IGV_DOLAR", OracleDbType.Double).Value = DAcumula5
        'End If

        cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = PROVISIONESBE.PROVEEDOR
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        If ELMVLOGSBE.log_codusu <> "0001" Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "2"
            cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
            cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Actualizo el documento de Compra: " + PROVISIONESBE.SER_DOC_REF + "-" + PROVISIONESBE.NRO_DOC_REF + "Proveedor:" + PROVISIONESBE.PROVEEDOR
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

    End Sub
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
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sAño As String, ByVal sMes As String, ByVal sNro As String, ByVal sSer As String, ByVal sTipo As String, ByVal sUS As String,
                      ByVal sProv As String, ByVal dg As DataGridView, ByVal flujo As String, ByVal caja As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CONTNUVOSOLES_C2_COM"
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
        'cmd.Parameters.Add("@TIPO7", OracleDbType.Varchar2).Value = flujo
        'cmd.Parameters.Add("@EST_MERCADERIA", OracleDbType.Varchar2).Value = caja
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub InsertRLetra(ByVal PROVISIONESBE As PROVISIONESBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand


        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PROVISIONES_INSROWLT"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            Dim FECHA As Date = IIf(IsDBNull(RTrim(row.Cells("FEC_LETRA").Value)), "", RTrim(row.Cells("FEC_LETRA").Value))
            Dim mesfecha As String
            Dim mesdia As String
            If FECHA.Month.ToString.Length = "1" Then
                mesfecha = "0" & FECHA.Month.ToString
            Else
                mesfecha = FECHA.Month.ToString
            End If
            If FECHA.Day.ToString.Length = "1" Then
                mesdia = "0" & FECHA.Day.ToString
            Else
                mesdia = FECHA.Day.ToString
            End If

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = "H"
            cmd.Parameters.Add("@FEC_LETRA", OracleDbType.Date).Value = FECHA
            cmd.Parameters.Add("@COD", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("CODIGO").Value)), "", RTrim(row.Cells("CODIGO").Value))
            cmd.Parameters.Add("@NRO_DOC", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC").Value)), "", RTrim(row.Cells("NRO_DOC").Value))
            cmd.Parameters.Add("@MONTO", OracleDbType.Double).Value = CDbl(IIf(IsDBNull(RTrim(row.Cells("MONTO").Value)), 0, RTrim(row.Cells("MONTO").Value)))
            cmd.Parameters.Add("@PROVEDOR", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR").Value)), 0, RTrim(row.Cells("PROVEEDOR").Value))
            cmd.Parameters.Add("@MONTOD", OracleDbType.Double).Value = CDbl(IIf(IsDBNull(RTrim(row.Cells("MONTOD").Value)), 0, RTrim(row.Cells("MONTOD").Value)))
            cmd.Parameters.Add("@T_CMB", OracleDbType.Double).Value = CDbl(IIf(IsDBNull(RTrim(row.Cells("T_CMB").Value)), 0, RTrim(row.Cells("T_CMB").Value)))
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("MONEDA").Value)), 0, RTrim(row.Cells("MONEDA").Value))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub
    Public Function getListProvDet(ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_RPTREG_COMPRAS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sAño", sAño),
                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@sMes", sMes)})
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

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SELALLPROVFILTRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ANHO", saño), New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", smes),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@TIPO", tipo), New Oracle.ManagedDataAccess.Client.OracleParameter("@SERIE", serie),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO", nro), New Oracle.ManagedDataAccess.Client.OracleParameter("@REG_NRO", reg_nro),
                                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@RUC", ruc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class