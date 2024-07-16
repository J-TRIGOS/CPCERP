Imports IT.ELUX.BE
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBKARDEXDAL
    Inherits BaseDatosORACLE
    Public Function SelectAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_SELAL1", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelRow() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_CONT_COD", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelRowPRECIO() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_SELPRECIO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelTipMov(ByVal sSER As String, ByVal sNRO As String, ByVal sART As String, ByVal sANHO As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_KARDEX_TMOV", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sSER),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sNRO),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sART),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sANHO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function

    Public Function SelNroPrd(ByVal sTDOC As String, ByVal sSER As String, ByVal sNRO As String, ByVal sART As String, ByVal sANHO As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SEL_NRORPD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sTDOC),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sSER),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sNRO),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sART),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sANHO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function

    Public Function SelNroPrd00ALM(ByVal sTDOC As String, ByVal sSER As String, ByVal sNRO As String, ByVal sART As String, ByVal sANHO As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SEL_NRORPD00ALM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sTDOC),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sSER),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sNRO),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sART),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sANHO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function
    Public Function SelPrdSolm(ByVal sTDOC As String, ByVal sSER As String, ByVal sNRO As String, ByVal sART As String, ByVal sANHO As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SEL_NROSOLM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sTDOC),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sSER),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sNRO),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sART),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sANHO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function
    Public Function SelPrdSolmSABC(ByVal sTDOC As String, ByVal sSER As String, ByVal sNRO As String, ByVal sART As String, ByVal sANHO As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SEL_NROSOLMSABC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sTDOC),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sSER),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sNRO),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sART),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sANHO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function
    Public Function SelNroRein(ByVal sTDOC As String, ByVal sSER As String, ByVal sNRO As String, ByVal sART As String, ByVal sANHO As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SEL_NROREIN", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sTDOC),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sSER),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sNRO),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sART),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sANHO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function
    Public Function SelNroReinSABC(ByVal sTDOC As String, ByVal sSER As String, ByVal sNRO As String, ByVal sART As String, ByVal sANHO As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SEL_NROREINSABC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sTDOC),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sSER),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sNRO),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sART),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sANHO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function
    Public Function SelNroFall(ByVal sTDOC As String, ByVal sSER As String, ByVal sNRO As String, ByVal sART As String, ByVal sANHO As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SEL_NROFALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sTDOC),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sSER),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sNRO),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sART),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sANHO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function
    Public Function SelNroSolmPrd(ByVal sTDOC As String, ByVal sSER As String, ByVal sNRO As String, ByVal sART As String, ByVal sANHO As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SEL_NROSOLMOP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sTDOC),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sSER),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sNRO),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sART),
                                                                           New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sANHO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function
    Public Function SelPrecioTransf(ByVal sANHO As String, ByVal smes1 As String, ByVal smes2 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEXPP_TRANS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sANHO),
                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("@smes1", smes1),
                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("@smes2", smes2)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelPrecioTransf3(ByVal sANHO As String, ByVal smes1 As String, ByVal smes2 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEXK_TRANS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sANHO),
                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("@smes1", smes1),
                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("@smes2", smes2)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelRow2(ByVal sCod As String, ByVal sFam As String, ByVal sCodArt As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_CONT_COD_INS1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sCod", sCod),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@sFam", sFam),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@sCodArt", sCodArt)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function


    Public Function SelListaArt(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_LISTA_ART", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sCod", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelRow3(ByVal sCod As String, ByVal sFam As String, ByVal sCodArt As String, ByVal sAnho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_CONT_COD_INS2", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sCod", sCod),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@sFam", sFam),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@sCodArt", sCodArt),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@sAnho", sAnho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelRow4(ByVal sCod As String, ByVal sCodArt As String, ByVal sAnho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_CONT_COD_INS3", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sCod", sCod),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@sCodArt", sCodArt),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@sAnho", sAnho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelRow1() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_CONT_COD_INS", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelRowKar(ByVal AÑO As String, ByVal fec As Date, ByVal fec2 As Date,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_GRIDALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", AÑO),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", fec),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", fec2),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", alm),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelRowKar1(ByVal AÑO As String, ByVal fec As String, ByVal fec2 As String,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_GRIDALL_ULT1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", AÑO),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", fec),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", fec2),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", alm),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelRowKar2(ByVal AÑO As String, ByVal fec As String, ByVal fec2 As String,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_GRIDALL_ULT2", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", AÑO),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", fec),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", fec2),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", alm),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelRowKar3(ByVal AÑO As String, ByVal fec As String, ByVal fec2 As String,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_GRIDALL_ULT3", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", AÑO),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", fec),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", fec2),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", alm),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelRowKar4(ByVal AÑO As String, ByVal fec As String, ByVal fec2 As String,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_GRIDALL_ULTK3", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", AÑO),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", fec),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", fec2),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", alm),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelRowKar5(ByVal AÑO As String, ByVal fec As String, ByVal fec2 As String,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_GRIDALL_ULT4", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", AÑO),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", fec),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", fec2),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", alm),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectTEMP_KARDEX_MOV(ByVal sANHO As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TEMP_KARDEX_MOV", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sANHO", sANHO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelRowKarxCont(ByVal AÑO As String, ByVal fec As String, ByVal fec2 As String,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_GRIDALL_ULTCONT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", AÑO),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", fec),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", fec2),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", alm),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelRowKarx6(ByVal AÑO As String, ByVal fec As String, ByVal fec2 As String,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_GRIDALL_ULTK4", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", AÑO),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", fec),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", fec2),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", alm),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelRowKarx7(ByVal AÑO As String, ByVal fec As String, ByVal fec2 As String,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_GRIDALL_ULTK6", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", AÑO),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", fec),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", fec2),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", alm),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelRowKarx8(ByVal AÑO As String, ByVal fec As String, ByVal fec2 As String,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_GRIDALL_ULTK8", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", AÑO),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", fec),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", fec2),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", alm),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelRowKarPP6(ByVal AÑO As String, ByVal fec As String, ByVal fec2 As String,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEXPP_GRIDALL_ULTK4", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", AÑO),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", fec),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", fec2),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", alm),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelRowKar7(ByVal AÑO As String, ByVal fec As String, ByVal fec2 As String,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_GRIDALL_ULTK5", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", AÑO),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", fec),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", fec2),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", alm),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelPrecio(ByVal tDOC As String, ByVal SDOC As String, ByVal NDOC As String, ByVal ART As String,
                              ByVal pCANTIDAD As Double) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_GRIDPRECIO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", tDOC),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", SDOC),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", NDOC),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", ART),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@CANTIDAD", pCANTIDAD)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelPrecioPRD(ByVal NDOC As String, ByVal ART As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_GRIDPRECIO2", {New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", NDOC),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", ART)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelPrecioPRDSolm(ByVal NDOC As String, ByVal ART As String, ByVal T_MOVINV As String, ByVal FEC As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEXPP_PRSOLM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@NDOC", NDOC),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ART", ART),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@T_MOVINV", T_MOVINV),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC", FEC)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelPrecioPRDSolmKARDEXK(ByVal NDOC As String, ByVal ART As String, ByVal T_MOVINV As String, ByVal FEC As Date) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEXPP_PRSOLMKARDEXK", {New Oracle.ManagedDataAccess.Client.OracleParameter("@NDOC", NDOC),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ART", ART),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@T_MOVINV", T_MOVINV),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC", FEC)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelPrecio1(ByVal tDOC As String, ByVal SDOC As String, ByVal NDOC As String, ByVal ART As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_GRIDPRECIO1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", tDOC),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", SDOC),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", NDOC),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", ART)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelPrecioOC(ByVal tDOC As String, ByVal SDOC As String, ByVal NDOC As String, ByVal ART As String, ByVal ANHO1 As String, ByVal ANHO2 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_GRIDPRECIOOC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", SDOC),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@pNRO_DOC_REF", NDOC),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@pCOD_ART", ART),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ANHO1", ANHO1),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ANHO2", ANHO2)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelCuentaComprasNC(ByVal tDOC As String, ByVal SDOC As String, ByVal NDOC As String, ByVal ART As String, ByVal ANHO1 As String, ByVal ANHO2 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_GRIDCUENTAOCNC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", SDOC),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", NDOC),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", ART),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ANHO1", ANHO1),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ANHO2", ANHO2)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelCuentaCompras(ByVal tDOC As String, ByVal SDOC As String, ByVal NDOC As String, ByVal ART As String, ByVal ANHO1 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_GRIDCUENTAOC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", Trim(SDOC)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", Trim(NDOC)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ART", Trim(ART)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ANHO1", Trim(ANHO1))})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelCuenta_destComprasNC(ByVal tDOC As String, ByVal SDOC As String, ByVal NDOC As String, ByVal ART As String, ByVal ANHO1 As String, ByVal ANHO2 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_GRIDCUENTA_DESTOC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", SDOC),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", NDOC),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ART", ART),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ANHO1", ANHO1)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelCuenta_destCompras(ByVal tDOC As String, ByVal SDOC As String, ByVal NDOC As String, ByVal ART As String, ByVal ANHO1 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_KARDEX_GRIDCUENTA_DESTOC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", SDOC),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", NDOC),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ART", ART),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ANHO1", ANHO1)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelPrecio2(ByVal SDOC As String, ByVal NDOC As String, ByVal ART As String, ByVal Anho As String, ByVal X As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBARTPREMOVSEL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@SDOC", SDOC),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NDOC", NDOC),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ART", ART),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@Anho", Anho),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@pX", X)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SaveRow(ByVal ELTBKARDEXBE As ELTBKARDEXBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal flagAccion As String, ByVal dg As DataGridView,
                          ByVal sublinea As String, ByVal sfam As String, ByVal sart As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try
            If flagAccion = "N" Then
                InsertRow(ELTBKARDEXBE, cn, sqlTrans, dg, sublinea)
            End If
            If flagAccion = "N1" Then
                InsertRow1(ELTBKARDEXBE, cn, sqlTrans, dg, sublinea, sfam, sart)
            End If
            If flagAccion = "N2" Then
                InsertRow2(ELTBKARDEXBE, cn, sqlTrans, dg, sublinea, sfam, sart)
            End If
            If flagAccion = "N3" Then
                InsertRow3(ELTBKARDEXBE, cn, sqlTrans, dg, sublinea, sfam, sart)
            End If
            If flagAccion = "N4" Then
                InsKardexPP(ELTBKARDEXBE, cn, sqlTrans, dg, sublinea, sfam, sart)
            End If
            If flagAccion = "N5" Then
                InsKardexk(ELTBKARDEXBE, cn, sqlTrans, dg, sublinea, sfam, sart)
            End If
            If flagAccion = "N7" Then
                InsertRow7(ELTBKARDEXBE, cn, sqlTrans, dg, sublinea, sfam, sart)
            End If
            If flagAccion = "MOVPRECIO" Then
                InsertRowPrecio(cn, sqlTrans, dg)
            End If
            sqlTrans.Commit()
            resultado = "OK"

        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans.Rollback()
            resultado = ex.Message
        Catch ex As Exception
            'If resultado = "OK" Then
            '    cn.Dispose()
            'End If
            resultado = ex.Message
        Finally
            'cn.Dispose()
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Private Sub InsertRow(ByVal ELTBKARDEXBE As ELTBKARDEXBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                          ByVal sublinea As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_KARDEX_DELCONT2"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@pSUBLINEA", OracleDbType.Varchar2).Value = sublinea
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        'For Each row As DataRow In dg.Rows
        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_KARDEX_CONT2"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            'cont = cont + 1
            ELTBKARDEXBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            ELTBKARDEXBE.NINICIAL = IIf(IsDBNull(RTrim(row.Cells("nInicial").Value)), 0, RTrim(row.Cells("nInicial").Value))
            ELTBKARDEXBE.PERIODO = IIf(IsDBNull(RTrim(row.Cells("PERIODO").Value)), "", RTrim(row.Cells("PERIODO").Value))
            ELTBKARDEXBE.RUC = IIf(IsDBNull(RTrim(row.Cells("RUC").Value)), "", RTrim(row.Cells("RUC").Value))
            ELTBKARDEXBE.FAM_CONT = IIf(IsDBNull(RTrim(row.Cells("FAM_CONT").Value)), "", RTrim(row.Cells("FAM_CONT").Value))
            ELTBKARDEXBE.RAZON_SOCIAL = IIf(IsDBNull(RTrim(row.Cells("RAZON_SOCIAL").Value)), "", RTrim(row.Cells("RAZON_SOCIAL").Value))
            ELTBKARDEXBE.ESTABLECIMIENTO = IIf(IsDBNull(RTrim(row.Cells("ESTABLECIMIENTO").Value)), "", RTrim(row.Cells("ESTABLECIMIENTO").Value))
            ELTBKARDEXBE.NOM_ART = IIf(IsDBNull(RTrim(row.Cells("NOM_ART").Value)), "", RTrim(row.Cells("NOM_ART").Value))
            ELTBKARDEXBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
            ELTBKARDEXBE.FECHA = IIf(IsDBNull(RTrim(row.Cells("FECHA").Value)), "", RTrim(row.Cells("FECHA").Value))
            ELTBKARDEXBE.TIPO_DOC = IIf(IsDBNull(RTrim(row.Cells("TIPO_DOC").Value)), "", RTrim(row.Cells("TIPO_DOC").Value))
            ELTBKARDEXBE.SERIE_NRO = IIf(IsDBNull(RTrim(row.Cells("SERIE_NRO").Value)), "", RTrim(row.Cells("SERIE_NRO").Value))
            ELTBKARDEXBE.NRO_DOCU = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU").Value)), "", RTrim(row.Cells("NRO_DOCU").Value))
            ELTBKARDEXBE.TIPO_OPERACION = IIf(IsDBNull(RTrim(row.Cells("TIPO_OPERACION").Value)), "", RTrim(row.Cells("TIPO_OPERACION").Value))
            ELTBKARDEXBE.COD_OPE = IIf(IsDBNull(RTrim(row.Cells("cod_ope").Value)), "", RTrim(row.Cells("cod_ope").Value))
            ELTBKARDEXBE.NOM_OPE = IIf(IsDBNull(RTrim(row.Cells("nom_ope").Value)), "", RTrim(row.Cells("nom_ope").Value))
            ELTBKARDEXBE.CANT_ENTRADA = IIf(IsDBNull(RTrim(row.Cells("CANT_ENTRADA").Value)), 0, RTrim(row.Cells("CANT_ENTRADA").Value))
            ELTBKARDEXBE.CANT_SALIDA = IIf(IsDBNull(RTrim(row.Cells("CANT_SALIDA").Value)), 0, RTrim(row.Cells("CANT_SALIDA").Value))
            ELTBKARDEXBE.PRECIO = IIf(IsDBNull(RTrim(row.Cells("PRECIO").Value)), 0, RTrim(row.Cells("PRECIO").Value))
            ELTBKARDEXBE.ACUM = IIf(IsDBNull(RTrim(row.Cells("ACUMULADO").Value)), 0, RTrim(row.Cells("ACUMULADO").Value))
            ELTBKARDEXBE.PRECIO_ENTRADA = IIf(IsDBNull(RTrim(row.Cells("PRECIO_ENTRADA").Value)), 0, RTrim(row.Cells("PRECIO_ENTRADA").Value))
            ELTBKARDEXBE.PRECIO_SALIDA = IIf(IsDBNull(RTrim(row.Cells("PRECIO_SALIDA").Value)), 0, RTrim(row.Cells("PRECIO_SALIDA").Value))
            ELTBKARDEXBE.ALM_COD = IIf(IsDBNull(RTrim(row.Cells("ALM_COD").Value)), "", RTrim(row.Cells("ALM_COD").Value))
            ELTBKARDEXBE.COSTO_ENTRADA = IIf(IsDBNull(RTrim(row.Cells("COSTO_ENTRADA").Value)), 0, RTrim(row.Cells("COSTO_ENTRADA").Value))
            ELTBKARDEXBE.PRECIO_SALDO = IIf(IsDBNull(RTrim(row.Cells("PRECIO_SALDO").Value)), 0, RTrim(row.Cells("PRECIO_SALDO").Value))
            ELTBKARDEXBE.COSTO_SALDO = IIf(IsDBNull(RTrim(row.Cells("COSTO_SALDO").Value)), 0, RTrim(row.Cells("COSTO_SALDO").Value))
            ELTBKARDEXBE.CANTIDAD_SALDO = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD_SALDO").Value)), 0, RTrim(row.Cells("CANTIDAD_SALDO").Value))
            ELTBKARDEXBE.T_MOVIM = IIf(IsDBNull(RTrim(row.Cells(27).Value)), "", RTrim(row.Cells(27).Value))
            ELTBKARDEXBE.NOM_T_MOVIM = IIf(IsDBNull(RTrim(row.Cells(28).Value)), 0, RTrim(row.Cells(28).Value))
            'ELTBKARDEXBE.COSTO_SALIDA = IIf(IsDBNull(RTrim(row.Cells(29).Value)), 0, RTrim(row.Cells(29).Value))
            ELTBKARDEXBE.DOC_REQ = IIf(IsDBNull(RTrim(row.Cells("DOC_REQ").Value)), "", RTrim(row.Cells("DOC_REQ").Value))
            ELTBKARDEXBE.DOC_OREQ = IIf(IsDBNull(RTrim(row.Cells("DOC_OREQ").Value)), "", RTrim(row.Cells("DOC_OREQ").Value))
            ELTBKARDEXBE.COSTO_SALIDA = IIf(IsDBNull(RTrim(row.Cells("COSTO_SALIDA").Value)), 0, RTrim(row.Cells("COSTO_SALIDA").Value))
            ELTBKARDEXBE.CUENTA = IIf(IsDBNull(RTrim(row.Cells("CUENTA").Value)), "", RTrim(row.Cells("CUENTA").Value))
            ELTBKARDEXBE.CUENTA_DEST = IIf(IsDBNull(RTrim(row.Cells("CUENTA_DEST").Value)), "", RTrim(row.Cells("CUENTA_DEST").Value))
            ELTBKARDEXBE.NRO_PRD = IIf(IsDBNull(RTrim(row.Cells("NRO_RPD").Value)), "", RTrim(row.Cells("NRO_RPD").Value))




            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@NINICIAL", OracleDbType.Double).Value = ELTBKARDEXBE.NINICIAL
            cmd.Parameters.Add("@PERIODO", OracleDbType.Varchar2).Value = ELTBKARDEXBE.PERIODO
            cmd.Parameters.Add("@RUC", OracleDbType.Varchar2).Value = ELTBKARDEXBE.RUC
            cmd.Parameters.Add("@RAZON_SOCIAL", OracleDbType.Varchar2).Value = ELTBKARDEXBE.RAZON_SOCIAL
            cmd.Parameters.Add("@ESTABLECIMIENTO", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ESTABLECIMIENTO
            cmd.Parameters.Add("@FAM_CONT", OracleDbType.Varchar2).Value = ELTBKARDEXBE.FAM_CONT
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ART_COD
            cmd.Parameters.Add("@UNIDAD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.UNIDAD
            cmd.Parameters.Add("@NOM_ART", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NOM_ART
            cmd.Parameters.Add("@FECHA", OracleDbType.Date).Value = ELTBKARDEXBE.FECHA
            cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ALM_COD
            cmd.Parameters.Add("@TIPO_DOC", OracleDbType.Varchar2).Value = ELTBKARDEXBE.TIPO_DOC
            cmd.Parameters.Add("@SERIE_NRO", OracleDbType.Varchar2).Value = ELTBKARDEXBE.SERIE_NRO
            cmd.Parameters.Add("@NRO_DOCU", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NRO_DOCU
            cmd.Parameters.Add("@TIPO_OPERACION", OracleDbType.Varchar2).Value = ELTBKARDEXBE.TIPO_OPERACION
            cmd.Parameters.Add("@COD_OPE", OracleDbType.Varchar2).Value = ELTBKARDEXBE.COD_OPE
            cmd.Parameters.Add("@NOM_OPE", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NOM_OPE
            cmd.Parameters.Add("@CANT_ENTRADA", OracleDbType.Double).Value = ELTBKARDEXBE.CANT_ENTRADA
            cmd.Parameters.Add("@CANT_SALIDA", OracleDbType.Double).Value = ELTBKARDEXBE.CANT_SALIDA
            cmd.Parameters.Add("@ACUM", OracleDbType.Double).Value = ELTBKARDEXBE.ACUM
            cmd.Parameters.Add("@PRECIO", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO
            cmd.Parameters.Add("@PRECIO_ENTRADA", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO_ENTRADA
            cmd.Parameters.Add("@PRECIO_SALIDA", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO_SALIDA
            cmd.Parameters.Add("@COSTO_ENTRADA", OracleDbType.Double).Value = ELTBKARDEXBE.COSTO_ENTRADA
            cmd.Parameters.Add("@PRECIO_SALDO", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO_SALDO
            cmd.Parameters.Add("@COSTO_SALDO", OracleDbType.Double).Value = ELTBKARDEXBE.COSTO_SALDO
            cmd.Parameters.Add("@CANTIDAD_SALDO", OracleDbType.Double).Value = ELTBKARDEXBE.CANTIDAD_SALDO
            cmd.Parameters.Add("@T_MOVIM", OracleDbType.Varchar2).Value = ELTBKARDEXBE.T_MOVIM
            cmd.Parameters.Add("@NOM_T_MOVIM", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NOM_T_MOVIM
            cmd.Parameters.Add("@COSTO_SALIDA", OracleDbType.Double).Value = ELTBKARDEXBE.COSTO_SALIDA
            cmd.Parameters.Add("@CUENTA", OracleDbType.Varchar2).Value = ELTBKARDEXBE.CUENTA
            cmd.Parameters.Add("@CUENTA_DEST", OracleDbType.Varchar2).Value = ELTBKARDEXBE.CUENTA_DEST
            cmd.Parameters.Add("@DOC_REQ", OracleDbType.Varchar2).Value = ELTBKARDEXBE.DOC_REQ
            cmd.Parameters.Add("@DOC_OREQ", OracleDbType.Varchar2).Value = ELTBKARDEXBE.DOC_OREQ
            cmd.Parameters.Add("@NRO_PRD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NRO_PRD
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next


    End Sub

    Private Sub InsertRow1(ByVal ELTBKARDEXBE As ELTBKARDEXBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                           ByVal sublinea As String, ByVal sfam As String, ByVal sart As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_KARDEX_DELCONT3"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sublinea", OracleDbType.Varchar2).Value = sublinea
        cmd.Parameters.Add("@sfam", OracleDbType.Varchar2).Value = sfam
        cmd.Parameters.Add("@sart", OracleDbType.Varchar2).Value = sart
        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELTBKARDEXBE.AÑO
        cmd.ExecuteNonQuery()
        cmd.Dispose()



        Dim cont As Integer = 0
        'For Each row As DataRow In dg.Rows
        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_KARDEX_CONT2"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            'cont = cont + 1
            ELTBKARDEXBE.NINICIAL = IIf(IsDBNull(RTrim(row.Cells("nInicial").Value)), 0, RTrim(row.Cells("nInicial").Value))
            ELTBKARDEXBE.PERIODO = IIf(IsDBNull(RTrim(row.Cells("PERIODO").Value)), "", RTrim(row.Cells("PERIODO").Value))
            ELTBKARDEXBE.RUC = IIf(IsDBNull(RTrim(row.Cells("RUC").Value)), "", RTrim(row.Cells("RUC").Value))
            ELTBKARDEXBE.RAZON_SOCIAL = IIf(IsDBNull(RTrim(row.Cells("RAZON_SOCIAL").Value)), "", RTrim(row.Cells("RAZON_SOCIAL").Value))
            ELTBKARDEXBE.ESTABLECIMIENTO = IIf(IsDBNull(RTrim(row.Cells("ESTABLECIMIENTO").Value)), "", RTrim(row.Cells("ESTABLECIMIENTO").Value))
            ELTBKARDEXBE.FAM_CONT = IIf(IsDBNull(RTrim(row.Cells("FAM_CONT").Value)), "", RTrim(row.Cells("FAM_CONT").Value))
            ELTBKARDEXBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            ELTBKARDEXBE.NOM_ART = IIf(IsDBNull(RTrim(row.Cells("NOM_ART").Value)), "", RTrim(row.Cells("NOM_ART").Value))
            ELTBKARDEXBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
            ELTBKARDEXBE.FECHA = IIf(IsDBNull(RTrim(row.Cells("FECHA").Value)), "", RTrim(row.Cells("FECHA").Value))
            ELTBKARDEXBE.TIPO_DOC = IIf(IsDBNull(RTrim(row.Cells("TIPO_DOC").Value)), "", RTrim(row.Cells("TIPO_DOC").Value))
            ELTBKARDEXBE.SERIE_NRO = IIf(IsDBNull(RTrim(row.Cells("SERIE_NRO").Value)), "", RTrim(row.Cells("SERIE_NRO").Value))
            ELTBKARDEXBE.NRO_DOCU = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU").Value)), "", RTrim(row.Cells("NRO_DOCU").Value))
            ELTBKARDEXBE.TIPO_OPERACION = IIf(IsDBNull(RTrim(row.Cells("TIPO_OPERACION").Value)), "", RTrim(row.Cells("TIPO_OPERACION").Value))
            ELTBKARDEXBE.COD_OPE = IIf(IsDBNull(RTrim(row.Cells("cod_ope").Value)), "", RTrim(row.Cells("cod_ope").Value))
            ELTBKARDEXBE.NOM_OPE = IIf(IsDBNull(RTrim(row.Cells("nom_ope").Value)), "", RTrim(row.Cells("nom_ope").Value))
            ELTBKARDEXBE.CANT_ENTRADA = IIf(IsDBNull(RTrim(row.Cells("CANT_ENTRADA").Value)), 0, RTrim(row.Cells("CANT_ENTRADA").Value))
            ELTBKARDEXBE.CANT_SALIDA = IIf(IsDBNull(RTrim(row.Cells("CANT_SALIDA").Value)), 0, RTrim(row.Cells("CANT_SALIDA").Value))
            ELTBKARDEXBE.PRECIO = IIf(IsDBNull(RTrim(row.Cells("PRECIO").Value)), 0, RTrim(row.Cells("PRECIO").Value))
            ELTBKARDEXBE.ACUM = IIf(IsDBNull(RTrim(row.Cells("ACUMULADO").Value)), 0, RTrim(row.Cells("ACUMULADO").Value))
            ELTBKARDEXBE.PRECIO_ENTRADA = IIf(IsDBNull(RTrim(row.Cells("PRECIO_ENTRADA").Value)), 0, RTrim(row.Cells("PRECIO_ENTRADA").Value))
            ELTBKARDEXBE.PRECIO_SALIDA = IIf(IsDBNull(RTrim(row.Cells("PRECIO_SALIDA").Value)), 0, RTrim(row.Cells("PRECIO_SALIDA").Value))
            ELTBKARDEXBE.ALM_COD = IIf(IsDBNull(RTrim(row.Cells("ALM_COD").Value)), "", RTrim(row.Cells("ALM_COD").Value))
            ELTBKARDEXBE.COSTO_ENTRADA = IIf(IsDBNull(RTrim(row.Cells("COSTO_ENTRADA").Value)), 0, RTrim(row.Cells("COSTO_ENTRADA").Value))
            ELTBKARDEXBE.PRECIO_SALDO = IIf(IsDBNull(RTrim(row.Cells("PRECIO_SALDO").Value)), 0, RTrim(row.Cells("PRECIO_SALDO").Value))
            ELTBKARDEXBE.COSTO_SALDO = IIf(IsDBNull(RTrim(row.Cells("COSTO_SALDO").Value)), 0, RTrim(row.Cells("COSTO_SALDO").Value))
            ELTBKARDEXBE.CANTIDAD_SALDO = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD_SALDO").Value)), 0, RTrim(row.Cells("CANTIDAD_SALDO").Value))
            ELTBKARDEXBE.T_MOVIM = IIf(IsDBNull(RTrim(row.Cells("T_MOVIN").Value)), 0, RTrim(row.Cells("T_MOVIN").Value))
            ELTBKARDEXBE.NOM_T_MOVIM = IIf(IsDBNull(RTrim(row.Cells("NOM_T_MOVIN").Value)), 0, RTrim(row.Cells("NOM_T_MOVIN").Value))
            ELTBKARDEXBE.COSTO_SALIDA = IIf(IsDBNull(RTrim(row.Cells("COSTO_SALIDA").Value)), 0, RTrim(row.Cells("COSTO_SALIDA").Value))

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@NINICIAL", OracleDbType.Double).Value = ELTBKARDEXBE.NINICIAL
            cmd.Parameters.Add("@PERIODO", OracleDbType.Varchar2).Value = ELTBKARDEXBE.PERIODO
            cmd.Parameters.Add("@RUC", OracleDbType.Varchar2).Value = ELTBKARDEXBE.RUC
            cmd.Parameters.Add("@RAZON_SOCIAL", OracleDbType.Varchar2).Value = ELTBKARDEXBE.RAZON_SOCIAL
            cmd.Parameters.Add("@ESTABLECIMIENTO", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ESTABLECIMIENTO
            cmd.Parameters.Add("@FAM_CONT", OracleDbType.Varchar2).Value = ELTBKARDEXBE.FAM_CONT
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ART_COD
            cmd.Parameters.Add("@NOM_ART", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NOM_ART
            cmd.Parameters.Add("@UNIDAD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.UNIDAD
            cmd.Parameters.Add("@FECHA", OracleDbType.Date).Value = ELTBKARDEXBE.FECHA
            cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ALM_COD
            cmd.Parameters.Add("@TIPO_DOC", OracleDbType.Varchar2).Value = ELTBKARDEXBE.TIPO_DOC
            cmd.Parameters.Add("@SERIE_NRO", OracleDbType.Varchar2).Value = ELTBKARDEXBE.SERIE_NRO
            cmd.Parameters.Add("@NRO_DOCU", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NRO_DOCU
            cmd.Parameters.Add("@TIPO_OPERACION", OracleDbType.Varchar2).Value = ELTBKARDEXBE.TIPO_OPERACION
            cmd.Parameters.Add("@COD_OPE", OracleDbType.Varchar2).Value = ELTBKARDEXBE.COD_OPE
            cmd.Parameters.Add("@NOM_OPE", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NOM_OPE
            cmd.Parameters.Add("@CANT_ENTRADA", OracleDbType.Double).Value = ELTBKARDEXBE.CANT_ENTRADA
            cmd.Parameters.Add("@CANT_SALIDA", OracleDbType.Double).Value = ELTBKARDEXBE.CANT_SALIDA
            cmd.Parameters.Add("@ACUM", OracleDbType.Double).Value = ELTBKARDEXBE.ACUM
            cmd.Parameters.Add("@PRECIO", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO
            cmd.Parameters.Add("@PRECIO_ENTRADA", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO_ENTRADA
            cmd.Parameters.Add("@PRECIO_SALIDA", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO_SALIDA
            cmd.Parameters.Add("@COSTO_ENTRADA", OracleDbType.Double).Value = ELTBKARDEXBE.COSTO_ENTRADA
            cmd.Parameters.Add("@PRECIO_SALDO", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO_SALDO
            cmd.Parameters.Add("@COSTO_SALDO", OracleDbType.Double).Value = ELTBKARDEXBE.COSTO_SALDO
            cmd.Parameters.Add("@CANTIDAD_SALDO", OracleDbType.Double).Value = ELTBKARDEXBE.CANTIDAD_SALDO
            cmd.Parameters.Add("@T_MOVIM", OracleDbType.Varchar2).Value = ELTBKARDEXBE.T_MOVIM
            cmd.Parameters.Add("@NOM_T_MOVIM", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NOM_T_MOVIM
            cmd.Parameters.Add("@COSTO_SALIDA", OracleDbType.Double).Value = ELTBKARDEXBE.COSTO_SALIDA

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next


    End Sub
    Private Sub InsertRow2(ByVal ELTBKARDEXBE As ELTBKARDEXBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                           ByVal sublinea As String, ByVal sfam As String, ByVal sart As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_KARDEX_DELCONT3K"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sublinea", OracleDbType.Varchar2).Value = sublinea
        cmd.Parameters.Add("@sfam", OracleDbType.Varchar2).Value = sfam
        cmd.Parameters.Add("@sart", OracleDbType.Varchar2).Value = sart
        cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELTBKARDEXBE.AÑO
        cmd.ExecuteNonQuery()
        cmd.Dispose()



        Dim cont As Integer = 0
        'For Each row As DataRow In dg.Rows
        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_KARDEX_CONT2K"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            'cont = cont + 1
            ELTBKARDEXBE.NINICIAL = IIf(IsDBNull(RTrim(row.Cells("nInicial").Value)), 0, RTrim(row.Cells("nInicial").Value))
            ELTBKARDEXBE.PERIODO = IIf(IsDBNull(RTrim(row.Cells("PERIODO").Value)), "", RTrim(row.Cells("PERIODO").Value))
            ELTBKARDEXBE.RUC = IIf(IsDBNull(RTrim(row.Cells("RUC").Value)), "", RTrim(row.Cells("RUC").Value))
            ELTBKARDEXBE.RAZON_SOCIAL = IIf(IsDBNull(RTrim(row.Cells("RAZON_SOCIAL").Value)), "", RTrim(row.Cells("RAZON_SOCIAL").Value))
            ELTBKARDEXBE.ESTABLECIMIENTO = IIf(IsDBNull(RTrim(row.Cells("ESTABLECIMIENTO").Value)), "", RTrim(row.Cells("ESTABLECIMIENTO").Value))
            ELTBKARDEXBE.FAM_CONT = IIf(IsDBNull(RTrim(row.Cells("FAM_CONT").Value)), "", RTrim(row.Cells("FAM_CONT").Value))
            ELTBKARDEXBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            ELTBKARDEXBE.NOM_ART = IIf(IsDBNull(RTrim(row.Cells("NOM_ART").Value)), "", RTrim(row.Cells("NOM_ART").Value))
            ELTBKARDEXBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
            ELTBKARDEXBE.FECHA = IIf(IsDBNull(RTrim(row.Cells("FECHA").Value)), "", RTrim(row.Cells("FECHA").Value))
            ELTBKARDEXBE.TIPO_DOC = IIf(IsDBNull(RTrim(row.Cells("TIPO_DOC").Value)), "", RTrim(row.Cells("TIPO_DOC").Value))
            ELTBKARDEXBE.SERIE_NRO = IIf(IsDBNull(RTrim(row.Cells("SERIE_NRO").Value)), "", RTrim(row.Cells("SERIE_NRO").Value))
            ELTBKARDEXBE.NRO_DOCU = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU").Value)), "", RTrim(row.Cells("NRO_DOCU").Value))
            ELTBKARDEXBE.TIPO_OPERACION = IIf(IsDBNull(RTrim(row.Cells("TIPO_OPERACION").Value)), "", RTrim(row.Cells("TIPO_OPERACION").Value))
            ELTBKARDEXBE.COD_OPE = IIf(IsDBNull(RTrim(row.Cells("cod_ope").Value)), "", RTrim(row.Cells("cod_ope").Value))
            ELTBKARDEXBE.NOM_OPE = IIf(IsDBNull(RTrim(row.Cells("nom_ope").Value)), "", RTrim(row.Cells("nom_ope").Value))
            ELTBKARDEXBE.CANT_ENTRADA = IIf(IsDBNull(RTrim(row.Cells("CANT_ENTRADA").Value)), 0, RTrim(row.Cells("CANT_ENTRADA").Value))
            ELTBKARDEXBE.CANT_SALIDA = IIf(IsDBNull(RTrim(row.Cells("CANT_SALIDA").Value)), 0, RTrim(row.Cells("CANT_SALIDA").Value))
            ELTBKARDEXBE.PRECIO = IIf(IsDBNull(RTrim(row.Cells("PRECIO").Value)), 0, RTrim(row.Cells("PRECIO").Value))
            ELTBKARDEXBE.ACUM = IIf(IsDBNull(RTrim(row.Cells("ACUMULADO").Value)), 0, RTrim(row.Cells("ACUMULADO").Value))
            ELTBKARDEXBE.PRECIO_ENTRADA = IIf(IsDBNull(RTrim(row.Cells("PRECIO_ENTRADA").Value)), 0, RTrim(row.Cells("PRECIO_ENTRADA").Value))
            ELTBKARDEXBE.PRECIO_SALIDA = IIf(IsDBNull(RTrim(row.Cells("PRECIO_SALIDA").Value)), 0, RTrim(row.Cells("PRECIO_SALIDA").Value))
            ELTBKARDEXBE.ALM_COD = IIf(IsDBNull(RTrim(row.Cells("ALM_COD").Value)), "", RTrim(row.Cells("ALM_COD").Value))
            ELTBKARDEXBE.COSTO_ENTRADA = IIf(IsDBNull(RTrim(row.Cells("COSTO_ENTRADA").Value)), 0, RTrim(row.Cells("COSTO_ENTRADA").Value))
            ELTBKARDEXBE.PRECIO_SALDO = IIf(IsDBNull(RTrim(row.Cells("PRECIO_SALDO").Value)), 0, RTrim(row.Cells("PRECIO_SALDO").Value))
            ELTBKARDEXBE.COSTO_SALDO = IIf(IsDBNull(RTrim(row.Cells("COSTO_SALDO").Value)), 0, RTrim(row.Cells("COSTO_SALDO").Value))
            ELTBKARDEXBE.CANTIDAD_SALDO = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD_SALDO").Value)), 0, RTrim(row.Cells("CANTIDAD_SALDO").Value))
            ELTBKARDEXBE.T_MOVIM = IIf(IsDBNull(RTrim(row.Cells("T_MOVIN").Value)), 0, RTrim(row.Cells("T_MOVIN").Value))
            ELTBKARDEXBE.NOM_T_MOVIM = IIf(IsDBNull(RTrim(row.Cells("NOM_T_MOVIN").Value)), 0, RTrim(row.Cells("NOM_T_MOVIN").Value))
            ELTBKARDEXBE.COSTO_SALIDA = IIf(IsDBNull(RTrim(row.Cells("COSTO_SALIDA").Value)), 0, RTrim(row.Cells("COSTO_SALIDA").Value))
            ELTBKARDEXBE.NRO_PRD = IIf(IsDBNull(RTrim(row.Cells("NRO_PRD").Value)), "", RTrim(row.Cells("NRO_PRD").Value))
            ELTBKARDEXBE.CUENTA = IIf(IsDBNull(RTrim(row.Cells("CUENTA").Value)), "", RTrim(row.Cells("CUENTA").Value))
            ELTBKARDEXBE.CUENTA_DEST = IIf(IsDBNull(RTrim(row.Cells("CUENTA_DEST").Value)), "", RTrim(row.Cells("CUENTA_DEST").Value))

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@NINICIAL", OracleDbType.Double).Value = ELTBKARDEXBE.NINICIAL
            cmd.Parameters.Add("@PERIODO", OracleDbType.Varchar2).Value = ELTBKARDEXBE.PERIODO
            cmd.Parameters.Add("@RUC", OracleDbType.Varchar2).Value = ELTBKARDEXBE.RUC
            cmd.Parameters.Add("@RAZON_SOCIAL", OracleDbType.Varchar2).Value = ELTBKARDEXBE.RAZON_SOCIAL
            cmd.Parameters.Add("@ESTABLECIMIENTO", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ESTABLECIMIENTO
            cmd.Parameters.Add("@FAM_CONT", OracleDbType.Varchar2).Value = ELTBKARDEXBE.FAM_CONT
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ART_COD
            cmd.Parameters.Add("@NOM_ART", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NOM_ART
            cmd.Parameters.Add("@UNIDAD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.UNIDAD
            cmd.Parameters.Add("@FECHA", OracleDbType.Date).Value = ELTBKARDEXBE.FECHA
            cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ALM_COD
            cmd.Parameters.Add("@TIPO_DOC", OracleDbType.Varchar2).Value = ELTBKARDEXBE.TIPO_DOC
            cmd.Parameters.Add("@SERIE_NRO", OracleDbType.Varchar2).Value = ELTBKARDEXBE.SERIE_NRO
            cmd.Parameters.Add("@NRO_DOCU", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NRO_DOCU
            cmd.Parameters.Add("@TIPO_OPERACION", OracleDbType.Varchar2).Value = ELTBKARDEXBE.TIPO_OPERACION
            cmd.Parameters.Add("@COD_OPE", OracleDbType.Varchar2).Value = ELTBKARDEXBE.COD_OPE
            cmd.Parameters.Add("@NOM_OPE", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NOM_OPE
            cmd.Parameters.Add("@CANT_ENTRADA", OracleDbType.Double).Value = ELTBKARDEXBE.CANT_ENTRADA
            cmd.Parameters.Add("@CANT_SALIDA", OracleDbType.Double).Value = ELTBKARDEXBE.CANT_SALIDA
            cmd.Parameters.Add("@ACUM", OracleDbType.Double).Value = ELTBKARDEXBE.ACUM
            cmd.Parameters.Add("@PRECIO", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO
            cmd.Parameters.Add("@PRECIO_ENTRADA", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO_ENTRADA
            cmd.Parameters.Add("@PRECIO_SALIDA", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO_SALIDA
            cmd.Parameters.Add("@COSTO_ENTRADA", OracleDbType.Double).Value = ELTBKARDEXBE.COSTO_ENTRADA
            cmd.Parameters.Add("@PRECIO_SALDO", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO_SALDO
            cmd.Parameters.Add("@COSTO_SALDO", OracleDbType.Double).Value = ELTBKARDEXBE.COSTO_SALDO
            cmd.Parameters.Add("@CANTIDAD_SALDO", OracleDbType.Double).Value = ELTBKARDEXBE.CANTIDAD_SALDO
            cmd.Parameters.Add("@T_MOVIM", OracleDbType.Varchar2).Value = ELTBKARDEXBE.T_MOVIM
            cmd.Parameters.Add("@NOM_T_MOVIM", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NOM_T_MOVIM
            cmd.Parameters.Add("@COSTO_SALIDA", OracleDbType.Double).Value = ELTBKARDEXBE.COSTO_SALIDA
            cmd.Parameters.Add("@NRO_PRD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NRO_PRD
            cmd.Parameters.Add("@CUENTA", OracleDbType.Varchar2).Value = ELTBKARDEXBE.CUENTA
            cmd.Parameters.Add("@CUENTA_DEST", OracleDbType.Varchar2).Value = ELTBKARDEXBE.CUENTA_DEST


            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next


    End Sub
    Private Sub InsertRow3(ByVal ELTBKARDEXBE As ELTBKARDEXBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                           ByVal sublinea As String, ByVal sfam As String, ByVal sart As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        If sfam = "TRANS" Then
            For Each row As DataGridViewRow In dg.Rows
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_KARDEXPP_DELCONT4K"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                ELTBKARDEXBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@sublinea", OracleDbType.Varchar2).Value = sublinea
                cmd.Parameters.Add("@sfam", OracleDbType.Varchar2).Value = sfam
                cmd.Parameters.Add("@sart", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ART_COD
                cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELTBKARDEXBE.AÑO
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Next

            Dim cont As Integer = 0
            'For Each row As DataRow In dg.Rows
            For Each row As DataGridViewRow In dg.Rows
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_KARDEXPP_CONT2K"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                'cont = cont + 1
                ELTBKARDEXBE.NINICIAL = IIf(IsDBNull(RTrim(row.Cells("nInicial").Value)), 0, RTrim(row.Cells("nInicial").Value))
                ELTBKARDEXBE.PERIODO = IIf(IsDBNull(RTrim(row.Cells("PERIODO").Value)), "", RTrim(row.Cells("PERIODO").Value))
                ELTBKARDEXBE.RUC = IIf(IsDBNull(RTrim(row.Cells("RUC").Value)), "", RTrim(row.Cells("RUC").Value))
                ELTBKARDEXBE.RAZON_SOCIAL = IIf(IsDBNull(RTrim(row.Cells("RAZON_SOCIAL").Value)), "", RTrim(row.Cells("RAZON_SOCIAL").Value))
                ELTBKARDEXBE.ESTABLECIMIENTO = IIf(IsDBNull(RTrim(row.Cells("ESTABLECIMIENTO").Value)), "", RTrim(row.Cells("ESTABLECIMIENTO").Value))
                ELTBKARDEXBE.FAM_CONT = IIf(IsDBNull(RTrim(row.Cells("FAM_CONT").Value)), "", RTrim(row.Cells("FAM_CONT").Value))
                ELTBKARDEXBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
                ELTBKARDEXBE.NOM_ART = IIf(IsDBNull(RTrim(row.Cells("NOM_ART").Value)), "", RTrim(row.Cells("NOM_ART").Value))
                ELTBKARDEXBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
                ELTBKARDEXBE.FECHA = IIf(IsDBNull(RTrim(row.Cells("FECHA").Value)), "", RTrim(row.Cells("FECHA").Value))
                ELTBKARDEXBE.TIPO_DOC = IIf(IsDBNull(RTrim(row.Cells("TIPO_DOC").Value)), "", RTrim(row.Cells("TIPO_DOC").Value))
                ELTBKARDEXBE.SERIE_NRO = IIf(IsDBNull(RTrim(row.Cells("SERIE_NRO").Value)), "", RTrim(row.Cells("SERIE_NRO").Value))
                ELTBKARDEXBE.NRO_DOCU = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU").Value)), "", RTrim(row.Cells("NRO_DOCU").Value))
                ELTBKARDEXBE.TIPO_OPERACION = IIf(IsDBNull(RTrim(row.Cells("TIPO_OPERACION").Value)), "", RTrim(row.Cells("TIPO_OPERACION").Value))
                ELTBKARDEXBE.COD_OPE = IIf(IsDBNull(RTrim(row.Cells("cod_ope").Value)), "", RTrim(row.Cells("cod_ope").Value))
                ELTBKARDEXBE.NOM_OPE = IIf(IsDBNull(RTrim(row.Cells("nom_ope").Value)), "", RTrim(row.Cells("nom_ope").Value))
                ELTBKARDEXBE.CANT_ENTRADA = IIf(IsDBNull(RTrim(row.Cells("CANT_ENTRADA").Value)), 0, RTrim(row.Cells("CANT_ENTRADA").Value))
                ELTBKARDEXBE.CANT_SALIDA = IIf(IsDBNull(RTrim(row.Cells("CANT_SALIDA").Value)), 0, RTrim(row.Cells("CANT_SALIDA").Value))
                ELTBKARDEXBE.PRECIO = IIf(IsDBNull(RTrim(row.Cells("PRECIO").Value)), 0, RTrim(row.Cells("PRECIO").Value))
                ELTBKARDEXBE.ACUM = IIf(IsDBNull(RTrim(row.Cells("ACUMULADO").Value)), 0, RTrim(row.Cells("ACUMULADO").Value))
                ELTBKARDEXBE.PRECIO_ENTRADA = IIf(IsDBNull(RTrim(row.Cells("PRECIO_ENTRADA").Value)), 0, RTrim(row.Cells("PRECIO_ENTRADA").Value))
                ELTBKARDEXBE.PRECIO_SALIDA = IIf(IsDBNull(RTrim(row.Cells("PRECIO_SALIDA").Value)), 0, RTrim(row.Cells("PRECIO_SALIDA").Value))
                ELTBKARDEXBE.ALM_COD = IIf(IsDBNull(RTrim(row.Cells("ALM_COD").Value)), "", RTrim(row.Cells("ALM_COD").Value))
                ELTBKARDEXBE.COSTO_ENTRADA = IIf(IsDBNull(RTrim(row.Cells("COSTO_ENTRADA").Value)), 0, RTrim(row.Cells("COSTO_ENTRADA").Value))
                ELTBKARDEXBE.PRECIO_SALDO = IIf(IsDBNull(RTrim(row.Cells("PRECIO_SALDO").Value)), 0, RTrim(row.Cells("PRECIO_SALDO").Value))
                ELTBKARDEXBE.COSTO_SALDO = IIf(IsDBNull(RTrim(row.Cells("COSTO_SALDO").Value)), 0, RTrim(row.Cells("COSTO_SALDO").Value))
                ELTBKARDEXBE.CANTIDAD_SALDO = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD_SALDO").Value)), 0, RTrim(row.Cells("CANTIDAD_SALDO").Value))
                ELTBKARDEXBE.T_MOVIM = IIf(IsDBNull(RTrim(row.Cells("T_MOVIN").Value)), 0, RTrim(row.Cells("T_MOVIN").Value))
                ELTBKARDEXBE.NOM_T_MOVIM = IIf(IsDBNull(RTrim(row.Cells("NOM_T_MOVIN").Value)), 0, RTrim(row.Cells("NOM_T_MOVIN").Value))
                ELTBKARDEXBE.COSTO_SALIDA = IIf(IsDBNull(RTrim(row.Cells("COSTO_SALIDA").Value)), 0, RTrim(row.Cells("COSTO_SALIDA").Value))
                ELTBKARDEXBE.NRO_PRD = IIf(IsDBNull(RTrim(row.Cells("NRO_RPD").Value)), "", RTrim(row.Cells("NRO_RPD").Value))

                'Los parametros que va recibir son las propiedades de la clase 
                cmd.Parameters.Add("@NINICIAL", OracleDbType.Double).Value = ELTBKARDEXBE.NINICIAL
                cmd.Parameters.Add("@PERIODO", OracleDbType.Varchar2).Value = ELTBKARDEXBE.PERIODO
                cmd.Parameters.Add("@RUC", OracleDbType.Varchar2).Value = ELTBKARDEXBE.RUC
                cmd.Parameters.Add("@RAZON_SOCIAL", OracleDbType.Varchar2).Value = ELTBKARDEXBE.RAZON_SOCIAL
                cmd.Parameters.Add("@ESTABLECIMIENTO", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ESTABLECIMIENTO
                cmd.Parameters.Add("@FAM_CONT", OracleDbType.Varchar2).Value = ELTBKARDEXBE.FAM_CONT
                cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ART_COD
                cmd.Parameters.Add("@NOM_ART", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NOM_ART
                cmd.Parameters.Add("@UNIDAD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.UNIDAD
                cmd.Parameters.Add("@FECHA", OracleDbType.Date).Value = ELTBKARDEXBE.FECHA
                cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ALM_COD
                cmd.Parameters.Add("@TIPO_DOC", OracleDbType.Varchar2).Value = ELTBKARDEXBE.TIPO_DOC
                cmd.Parameters.Add("@SERIE_NRO", OracleDbType.Varchar2).Value = ELTBKARDEXBE.SERIE_NRO
                cmd.Parameters.Add("@NRO_DOCU", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NRO_DOCU
                cmd.Parameters.Add("@TIPO_OPERACION", OracleDbType.Varchar2).Value = ELTBKARDEXBE.TIPO_OPERACION
                cmd.Parameters.Add("@COD_OPE", OracleDbType.Varchar2).Value = ELTBKARDEXBE.COD_OPE
                cmd.Parameters.Add("@NOM_OPE", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NOM_OPE
                cmd.Parameters.Add("@CANT_ENTRADA", OracleDbType.Double).Value = ELTBKARDEXBE.CANT_ENTRADA
                cmd.Parameters.Add("@CANT_SALIDA", OracleDbType.Double).Value = ELTBKARDEXBE.CANT_SALIDA
                cmd.Parameters.Add("@ACUM", OracleDbType.Double).Value = ELTBKARDEXBE.ACUM
                cmd.Parameters.Add("@PRECIO", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO
                cmd.Parameters.Add("@PRECIO_ENTRADA", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO_ENTRADA
                cmd.Parameters.Add("@PRECIO_SALIDA", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO_SALIDA
                cmd.Parameters.Add("@COSTO_ENTRADA", OracleDbType.Double).Value = ELTBKARDEXBE.COSTO_ENTRADA
                cmd.Parameters.Add("@PRECIO_SALDO", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO_SALDO
                cmd.Parameters.Add("@COSTO_SALDO", OracleDbType.Double).Value = ELTBKARDEXBE.COSTO_SALDO
                cmd.Parameters.Add("@CANTIDAD_SALDO", OracleDbType.Double).Value = ELTBKARDEXBE.CANTIDAD_SALDO
                cmd.Parameters.Add("@T_MOVIM", OracleDbType.Varchar2).Value = ELTBKARDEXBE.T_MOVIM
                cmd.Parameters.Add("@NOM_T_MOVIM", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NOM_T_MOVIM
                cmd.Parameters.Add("@COSTO_SALIDA", OracleDbType.Double).Value = ELTBKARDEXBE.COSTO_SALIDA
                cmd.Parameters.Add("@NRO_PRD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NRO_PRD
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Next
        Else
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_KARDEXPP_DELCONT4K"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@sublinea", OracleDbType.Varchar2).Value = sublinea
            cmd.Parameters.Add("@sfam", OracleDbType.Varchar2).Value = sfam
            cmd.Parameters.Add("@sart", OracleDbType.Varchar2).Value = sart
            cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELTBKARDEXBE.AÑO
            cmd.ExecuteNonQuery()
            cmd.Dispose()



            Dim cont As Integer = 0
            'For Each row As DataRow In dg.Rows
            For Each row As DataGridViewRow In dg.Rows
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_KARDEXPP_CONT2K"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                'cont = cont + 1
                ELTBKARDEXBE.NINICIAL = IIf(IsDBNull(RTrim(row.Cells("nInicial").Value)), 0, RTrim(row.Cells("nInicial").Value))
                ELTBKARDEXBE.PERIODO = IIf(IsDBNull(RTrim(row.Cells("PERIODO").Value)), "", RTrim(row.Cells("PERIODO").Value))
                ELTBKARDEXBE.RUC = IIf(IsDBNull(RTrim(row.Cells("RUC").Value)), "", RTrim(row.Cells("RUC").Value))
                ELTBKARDEXBE.RAZON_SOCIAL = IIf(IsDBNull(RTrim(row.Cells("RAZON_SOCIAL").Value)), "", RTrim(row.Cells("RAZON_SOCIAL").Value))
                ELTBKARDEXBE.ESTABLECIMIENTO = IIf(IsDBNull(RTrim(row.Cells("ESTABLECIMIENTO").Value)), "", RTrim(row.Cells("ESTABLECIMIENTO").Value))
                ELTBKARDEXBE.FAM_CONT = IIf(IsDBNull(RTrim(row.Cells("FAM_CONT").Value)), "", RTrim(row.Cells("FAM_CONT").Value))
                ELTBKARDEXBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
                ELTBKARDEXBE.NOM_ART = IIf(IsDBNull(RTrim(row.Cells("NOM_ART").Value)), "", RTrim(row.Cells("NOM_ART").Value))
                ELTBKARDEXBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
                ELTBKARDEXBE.FECHA = IIf(IsDBNull(RTrim(row.Cells("FECHA").Value)), "", RTrim(row.Cells("FECHA").Value))
                ELTBKARDEXBE.TIPO_DOC = IIf(IsDBNull(RTrim(row.Cells("TIPO_DOC").Value)), "", RTrim(row.Cells("TIPO_DOC").Value))
                ELTBKARDEXBE.SERIE_NRO = IIf(IsDBNull(RTrim(row.Cells("SERIE_NRO").Value)), "", RTrim(row.Cells("SERIE_NRO").Value))
                ELTBKARDEXBE.NRO_DOCU = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU").Value)), "", RTrim(row.Cells("NRO_DOCU").Value))
                ELTBKARDEXBE.TIPO_OPERACION = IIf(IsDBNull(RTrim(row.Cells("TIPO_OPERACION").Value)), "", RTrim(row.Cells("TIPO_OPERACION").Value))
                ELTBKARDEXBE.COD_OPE = IIf(IsDBNull(RTrim(row.Cells("cod_ope").Value)), "", RTrim(row.Cells("cod_ope").Value))
                ELTBKARDEXBE.NOM_OPE = IIf(IsDBNull(RTrim(row.Cells("nom_ope").Value)), "", RTrim(row.Cells("nom_ope").Value))
                ELTBKARDEXBE.CANT_ENTRADA = IIf(IsDBNull(RTrim(row.Cells("CANT_ENTRADA").Value)), 0, RTrim(row.Cells("CANT_ENTRADA").Value))
                ELTBKARDEXBE.CANT_SALIDA = IIf(IsDBNull(RTrim(row.Cells("CANT_SALIDA").Value)), 0, RTrim(row.Cells("CANT_SALIDA").Value))
                ELTBKARDEXBE.PRECIO = IIf(IsDBNull(RTrim(row.Cells("PRECIO").Value)), 0, RTrim(row.Cells("PRECIO").Value))
                ELTBKARDEXBE.ACUM = IIf(IsDBNull(RTrim(row.Cells("ACUMULADO").Value)), 0, RTrim(row.Cells("ACUMULADO").Value))
                ELTBKARDEXBE.PRECIO_ENTRADA = IIf(IsDBNull(RTrim(row.Cells("PRECIO_ENTRADA").Value)), 0, RTrim(row.Cells("PRECIO_ENTRADA").Value))
                ELTBKARDEXBE.PRECIO_SALIDA = IIf(IsDBNull(RTrim(row.Cells("PRECIO_SALIDA").Value)), 0, RTrim(row.Cells("PRECIO_SALIDA").Value))
                ELTBKARDEXBE.ALM_COD = IIf(IsDBNull(RTrim(row.Cells("ALM_COD").Value)), "", RTrim(row.Cells("ALM_COD").Value))
                ELTBKARDEXBE.COSTO_ENTRADA = IIf(IsDBNull(RTrim(row.Cells("COSTO_ENTRADA").Value)), 0, RTrim(row.Cells("COSTO_ENTRADA").Value))
                ELTBKARDEXBE.PRECIO_SALDO = IIf(IsDBNull(RTrim(row.Cells("PRECIO_SALDO").Value)), 0, RTrim(row.Cells("PRECIO_SALDO").Value))
                ELTBKARDEXBE.COSTO_SALDO = IIf(IsDBNull(RTrim(row.Cells("COSTO_SALDO").Value)), 0, RTrim(row.Cells("COSTO_SALDO").Value))
                ELTBKARDEXBE.CANTIDAD_SALDO = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD_SALDO").Value)), 0, RTrim(row.Cells("CANTIDAD_SALDO").Value))
                ELTBKARDEXBE.T_MOVIM = IIf(IsDBNull(RTrim(row.Cells("T_MOVIN").Value)), 0, RTrim(row.Cells("T_MOVIN").Value))
                ELTBKARDEXBE.NOM_T_MOVIM = IIf(IsDBNull(RTrim(row.Cells("NOM_T_MOVIN").Value)), 0, RTrim(row.Cells("NOM_T_MOVIN").Value))
                ELTBKARDEXBE.COSTO_SALIDA = IIf(IsDBNull(RTrim(row.Cells("COSTO_SALIDA").Value)), 0, RTrim(row.Cells("COSTO_SALIDA").Value))
                ELTBKARDEXBE.NRO_PRD = IIf(IsDBNull(RTrim(row.Cells("NRO_RPD").Value)), "", RTrim(row.Cells("NRO_RPD").Value))

                'Los parametros que va recibir son las propiedades de la clase 
                cmd.Parameters.Add("@NINICIAL", OracleDbType.Double).Value = ELTBKARDEXBE.NINICIAL
                cmd.Parameters.Add("@PERIODO", OracleDbType.Varchar2).Value = ELTBKARDEXBE.PERIODO
                cmd.Parameters.Add("@RUC", OracleDbType.Varchar2).Value = ELTBKARDEXBE.RUC
                cmd.Parameters.Add("@RAZON_SOCIAL", OracleDbType.Varchar2).Value = ELTBKARDEXBE.RAZON_SOCIAL
                cmd.Parameters.Add("@ESTABLECIMIENTO", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ESTABLECIMIENTO
                cmd.Parameters.Add("@FAM_CONT", OracleDbType.Varchar2).Value = ELTBKARDEXBE.FAM_CONT
                cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ART_COD
                cmd.Parameters.Add("@NOM_ART", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NOM_ART
                cmd.Parameters.Add("@UNIDAD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.UNIDAD
                cmd.Parameters.Add("@FECHA", OracleDbType.Date).Value = ELTBKARDEXBE.FECHA
                cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ALM_COD
                cmd.Parameters.Add("@TIPO_DOC", OracleDbType.Varchar2).Value = ELTBKARDEXBE.TIPO_DOC
                cmd.Parameters.Add("@SERIE_NRO", OracleDbType.Varchar2).Value = ELTBKARDEXBE.SERIE_NRO
                cmd.Parameters.Add("@NRO_DOCU", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NRO_DOCU
                cmd.Parameters.Add("@TIPO_OPERACION", OracleDbType.Varchar2).Value = ELTBKARDEXBE.TIPO_OPERACION
                cmd.Parameters.Add("@COD_OPE", OracleDbType.Varchar2).Value = ELTBKARDEXBE.COD_OPE
                cmd.Parameters.Add("@NOM_OPE", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NOM_OPE
                cmd.Parameters.Add("@CANT_ENTRADA", OracleDbType.Double).Value = ELTBKARDEXBE.CANT_ENTRADA
                cmd.Parameters.Add("@CANT_SALIDA", OracleDbType.Double).Value = ELTBKARDEXBE.CANT_SALIDA
                cmd.Parameters.Add("@ACUM", OracleDbType.Double).Value = ELTBKARDEXBE.ACUM
                cmd.Parameters.Add("@PRECIO", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO
                cmd.Parameters.Add("@PRECIO_ENTRADA", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO_ENTRADA
                cmd.Parameters.Add("@PRECIO_SALIDA", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO_SALIDA
                cmd.Parameters.Add("@COSTO_ENTRADA", OracleDbType.Double).Value = ELTBKARDEXBE.COSTO_ENTRADA
                cmd.Parameters.Add("@PRECIO_SALDO", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO_SALDO
                cmd.Parameters.Add("@COSTO_SALDO", OracleDbType.Double).Value = ELTBKARDEXBE.COSTO_SALDO
                cmd.Parameters.Add("@CANTIDAD_SALDO", OracleDbType.Double).Value = ELTBKARDEXBE.CANTIDAD_SALDO
                cmd.Parameters.Add("@T_MOVIM", OracleDbType.Varchar2).Value = ELTBKARDEXBE.T_MOVIM
                cmd.Parameters.Add("@NOM_T_MOVIM", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NOM_T_MOVIM
                cmd.Parameters.Add("@COSTO_SALIDA", OracleDbType.Double).Value = ELTBKARDEXBE.COSTO_SALIDA
                cmd.Parameters.Add("@NRO_PRD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NRO_PRD
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Next
        End If
    End Sub
    Private Sub InsertRow7(ByVal ELTBKARDEXBE As ELTBKARDEXBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                           ByVal sublinea As String, ByVal sfam As String, ByVal sart As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        If sfam = "3" Then
            For Each row As DataGridViewRow In dg.Rows
                ELTBKARDEXBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_KARDEX_DELCONT3K"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@sublinea", OracleDbType.Varchar2).Value = sublinea
                cmd.Parameters.Add("@sfam", OracleDbType.Varchar2).Value = ""
                cmd.Parameters.Add("@sart", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ART_COD
                cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELTBKARDEXBE.AÑO
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Next

        Else
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_KARDEX_DELCONT3K"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@sublinea", OracleDbType.Varchar2).Value = sublinea
            cmd.Parameters.Add("@sfam", OracleDbType.Varchar2).Value = sfam
            cmd.Parameters.Add("@sart", OracleDbType.Varchar2).Value = sart
            cmd.Parameters.Add("@anho", OracleDbType.Varchar2).Value = ELTBKARDEXBE.AÑO
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If


        Dim cont As Integer = 0
        'For Each row As DataRow In dg.Rows
        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_KARDEXK_CONT2K"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            'cont = cont + 1
            ELTBKARDEXBE.NINICIAL = IIf(IsDBNull(RTrim(row.Cells("nInicial").Value)), 0, RTrim(row.Cells("nInicial").Value))
            ELTBKARDEXBE.PERIODO = IIf(IsDBNull(RTrim(row.Cells("PERIODO").Value)), "", RTrim(row.Cells("PERIODO").Value))
            ELTBKARDEXBE.RUC = IIf(IsDBNull(RTrim(row.Cells("RUC").Value)), "", RTrim(row.Cells("RUC").Value))
            ELTBKARDEXBE.RAZON_SOCIAL = IIf(IsDBNull(RTrim(row.Cells("RAZON_SOCIAL").Value)), "", RTrim(row.Cells("RAZON_SOCIAL").Value))
            ELTBKARDEXBE.ESTABLECIMIENTO = IIf(IsDBNull(RTrim(row.Cells("ESTABLECIMIENTO").Value)), "", RTrim(row.Cells("ESTABLECIMIENTO").Value))
            ELTBKARDEXBE.FAM_CONT = IIf(IsDBNull(RTrim(row.Cells("FAM_CONT").Value)), "", RTrim(row.Cells("FAM_CONT").Value))
            ELTBKARDEXBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            ELTBKARDEXBE.NOM_ART = IIf(IsDBNull(RTrim(row.Cells("NOM_ART").Value)), "", RTrim(row.Cells("NOM_ART").Value))
            ELTBKARDEXBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
            ELTBKARDEXBE.FECHA = IIf(IsDBNull(RTrim(row.Cells("FECHA").Value)), "", RTrim(row.Cells("FECHA").Value))
            ELTBKARDEXBE.TIPO_DOC = IIf(IsDBNull(RTrim(row.Cells("TIPO_DOC").Value)), "", RTrim(row.Cells("TIPO_DOC").Value))
            ELTBKARDEXBE.SERIE_NRO = IIf(IsDBNull(RTrim(row.Cells("SERIE_NRO").Value)), "", RTrim(row.Cells("SERIE_NRO").Value))
            ELTBKARDEXBE.NRO_DOCU = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU").Value)), "", RTrim(row.Cells("NRO_DOCU").Value))
            ELTBKARDEXBE.TIPO_OPERACION = IIf(IsDBNull(RTrim(row.Cells("TIPO_OPERACION").Value)), "", RTrim(row.Cells("TIPO_OPERACION").Value))
            ELTBKARDEXBE.COD_OPE = IIf(IsDBNull(RTrim(row.Cells("cod_ope").Value)), "", RTrim(row.Cells("cod_ope").Value))
            ELTBKARDEXBE.NOM_OPE = IIf(IsDBNull(RTrim(row.Cells("nom_ope").Value)), "", RTrim(row.Cells("nom_ope").Value))
            ELTBKARDEXBE.CANT_ENTRADA = IIf(IsDBNull(RTrim(row.Cells("CANT_ENTRADA").Value)), 0, RTrim(row.Cells("CANT_ENTRADA").Value))
            ELTBKARDEXBE.CANT_SALIDA = IIf(IsDBNull(RTrim(row.Cells("CANT_SALIDA").Value)), 0, RTrim(row.Cells("CANT_SALIDA").Value))
            ELTBKARDEXBE.PRECIO = IIf(IsDBNull(RTrim(row.Cells("PRECIO").Value)), 0, RTrim(row.Cells("PRECIO").Value))
            ELTBKARDEXBE.ACUM = IIf(IsDBNull(RTrim(row.Cells("ACUMULADO").Value)), 0, RTrim(row.Cells("ACUMULADO").Value))
            ELTBKARDEXBE.PRECIO_ENTRADA = IIf(IsDBNull(RTrim(row.Cells("PRECIO_ENTRADA").Value)), 0, RTrim(row.Cells("PRECIO_ENTRADA").Value))
            ELTBKARDEXBE.PRECIO_SALIDA = IIf(IsDBNull(RTrim(row.Cells("PRECIO_SALIDA").Value)), 0, RTrim(row.Cells("PRECIO_SALIDA").Value))
            ELTBKARDEXBE.ALM_COD = IIf(IsDBNull(RTrim(row.Cells("ALM_COD").Value)), "", RTrim(row.Cells("ALM_COD").Value))
            ELTBKARDEXBE.COSTO_ENTRADA = IIf(IsDBNull(RTrim(row.Cells("COSTO_ENTRADA").Value)), 0, RTrim(row.Cells("COSTO_ENTRADA").Value))
            ELTBKARDEXBE.PRECIO_SALDO = IIf(IsDBNull(RTrim(row.Cells("PRECIO_SALDO").Value)), 0, RTrim(row.Cells("PRECIO_SALDO").Value))
            ELTBKARDEXBE.COSTO_SALDO = IIf(IsDBNull(RTrim(row.Cells("COSTO_SALDO").Value)), 0, RTrim(row.Cells("COSTO_SALDO").Value))
            ELTBKARDEXBE.CANTIDAD_SALDO = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD_SALDO").Value)), 0, RTrim(row.Cells("CANTIDAD_SALDO").Value))
            ELTBKARDEXBE.T_MOVIM = IIf(IsDBNull(RTrim(row.Cells("T_MOVIN").Value)), 0, RTrim(row.Cells("T_MOVIN").Value))
            ELTBKARDEXBE.NOM_T_MOVIM = IIf(IsDBNull(RTrim(row.Cells("NOM_T_MOVIN").Value)), 0, RTrim(row.Cells("NOM_T_MOVIN").Value))
            ELTBKARDEXBE.COSTO_SALIDA = IIf(IsDBNull(RTrim(row.Cells("COSTO_SALIDA").Value)), 0, RTrim(row.Cells("COSTO_SALIDA").Value))
            ELTBKARDEXBE.NRO_PRD = IIf(IsDBNull(RTrim(row.Cells("NRO_RPD").Value)), "", RTrim(row.Cells("NRO_RPD").Value))
            ELTBKARDEXBE.CUENTA = IIf(IsDBNull(RTrim(row.Cells("CUENTA").Value)), "", RTrim(row.Cells("CUENTA").Value))
            ELTBKARDEXBE.CUENTA_DEST = IIf(IsDBNull(RTrim(row.Cells("CUENTA_DEST").Value)), "", RTrim(row.Cells("CUENTA_DEST").Value))

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@NINICIAL", OracleDbType.Double).Value = ELTBKARDEXBE.NINICIAL
            cmd.Parameters.Add("@PERIODO", OracleDbType.Varchar2).Value = ELTBKARDEXBE.PERIODO
            cmd.Parameters.Add("@RUC", OracleDbType.Varchar2).Value = ELTBKARDEXBE.RUC
            cmd.Parameters.Add("@RAZON_SOCIAL", OracleDbType.Varchar2).Value = ELTBKARDEXBE.RAZON_SOCIAL
            cmd.Parameters.Add("@ESTABLECIMIENTO", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ESTABLECIMIENTO
            cmd.Parameters.Add("@FAM_CONT", OracleDbType.Varchar2).Value = ELTBKARDEXBE.FAM_CONT
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ART_COD
            cmd.Parameters.Add("@NOM_ART", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NOM_ART
            cmd.Parameters.Add("@UNIDAD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.UNIDAD
            cmd.Parameters.Add("@FECHA", OracleDbType.Date).Value = ELTBKARDEXBE.FECHA
            cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ALM_COD
            cmd.Parameters.Add("@TIPO_DOC", OracleDbType.Varchar2).Value = ELTBKARDEXBE.TIPO_DOC
            cmd.Parameters.Add("@SERIE_NRO", OracleDbType.Varchar2).Value = ELTBKARDEXBE.SERIE_NRO
            cmd.Parameters.Add("@NRO_DOCU", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NRO_DOCU
            cmd.Parameters.Add("@TIPO_OPERACION", OracleDbType.Varchar2).Value = ELTBKARDEXBE.TIPO_OPERACION
            cmd.Parameters.Add("@COD_OPE", OracleDbType.Varchar2).Value = ELTBKARDEXBE.COD_OPE
            cmd.Parameters.Add("@NOM_OPE", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NOM_OPE
            cmd.Parameters.Add("@CANT_ENTRADA", OracleDbType.Double).Value = ELTBKARDEXBE.CANT_ENTRADA
            cmd.Parameters.Add("@CANT_SALIDA", OracleDbType.Double).Value = ELTBKARDEXBE.CANT_SALIDA
            cmd.Parameters.Add("@ACUM", OracleDbType.Double).Value = ELTBKARDEXBE.ACUM
            cmd.Parameters.Add("@PRECIO", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO
            cmd.Parameters.Add("@PRECIO_ENTRADA", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO_ENTRADA
            cmd.Parameters.Add("@PRECIO_SALIDA", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO_SALIDA
            cmd.Parameters.Add("@COSTO_ENTRADA", OracleDbType.Double).Value = ELTBKARDEXBE.COSTO_ENTRADA
            cmd.Parameters.Add("@PRECIO_SALDO", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO_SALDO
            cmd.Parameters.Add("@COSTO_SALDO", OracleDbType.Double).Value = ELTBKARDEXBE.COSTO_SALDO
            cmd.Parameters.Add("@CANTIDAD_SALDO", OracleDbType.Double).Value = ELTBKARDEXBE.CANTIDAD_SALDO
            cmd.Parameters.Add("@T_MOVIM", OracleDbType.Varchar2).Value = ELTBKARDEXBE.T_MOVIM
            cmd.Parameters.Add("@NOM_T_MOVIM", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NOM_T_MOVIM
            cmd.Parameters.Add("@COSTO_SALIDA", OracleDbType.Double).Value = ELTBKARDEXBE.COSTO_SALIDA
            cmd.Parameters.Add("@NRO_PRD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NRO_PRD
            cmd.Parameters.Add("@CUENTA", OracleDbType.Varchar2).Value = ELTBKARDEXBE.CUENTA
            cmd.Parameters.Add("@CUENTA_DEST", OracleDbType.Varchar2).Value = ELTBKARDEXBE.CUENTA_DEST
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub
    Private Sub InsKardexPP(ByVal ELTBKARDEXBE As ELTBKARDEXBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                           ByVal sublinea As String, ByVal sfam As String, ByVal sart As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBARTPREMOV_DELKARDEXPP"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBKARDEXBE.SERIE_NRO = IIf(IsDBNull(RTrim(row.Cells("SERIE_NRO").Value)), "", RTrim(row.Cells("SERIE_NRO").Value))
            ELTBKARDEXBE.NRO_DOCU = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU").Value)), "", RTrim(row.Cells("NRO_DOCU").Value))
            ELTBKARDEXBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            cmd.Parameters.Add("@pT_DOC_REF", OracleDbType.Varchar2).Value = "SALM"
            cmd.Parameters.Add("@pSER_DOC_REF", OracleDbType.Varchar2).Value = ELTBKARDEXBE.SERIE_NRO
            cmd.Parameters.Add("@pNRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NRO_DOCU
            cmd.Parameters.Add("@pART_COD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ART_COD
            cmd.Parameters.Add("@pANHO", OracleDbType.Varchar2).Value = ELTBKARDEXBE.AÑO
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBARTPREMOV_INSKARDEXPP"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBKARDEXBE.SERIE_NRO = IIf(IsDBNull(RTrim(row.Cells("SERIE_NRO").Value)), "", RTrim(row.Cells("SERIE_NRO").Value))
            ELTBKARDEXBE.NRO_DOCU = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU").Value)), "", RTrim(row.Cells("NRO_DOCU").Value))
            ELTBKARDEXBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            ELTBKARDEXBE.PRECIO = IIf(IsDBNull(RTrim(row.Cells("NRO_PRECIOSALDO").Value)), 0, RTrim(row.Cells("NRO_PRECIOSALDO").Value))
            cmd.Parameters.Add("@pT_DOC_REF", OracleDbType.Varchar2).Value = "SALM"
            cmd.Parameters.Add("@pSER_DOC_REF", OracleDbType.Varchar2).Value = ELTBKARDEXBE.SERIE_NRO
            cmd.Parameters.Add("@pNRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NRO_DOCU
            cmd.Parameters.Add("@pART_COD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ART_COD
            cmd.Parameters.Add("@pANHO", OracleDbType.Varchar2).Value = ELTBKARDEXBE.AÑO
            cmd.Parameters.Add("@pU_PRECIO", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub

    Private Sub InsKardexk(ByVal ELTBKARDEXBE As ELTBKARDEXBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                           ByVal sublinea As String, ByVal sfam As String, ByVal sart As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBARTPREMOV_DELKARDEXK"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBKARDEXBE.SERIE_NRO = IIf(IsDBNull(RTrim(row.Cells("SERIE_NRO").Value)), "", RTrim(row.Cells("SERIE_NRO").Value))
            ELTBKARDEXBE.NRO_DOCU = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU").Value)), "", RTrim(row.Cells("NRO_DOCU").Value))
            ELTBKARDEXBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            cmd.Parameters.Add("@pT_DOC_REF", OracleDbType.Varchar2).Value = "SALM"
            cmd.Parameters.Add("@pSER_DOC_REF", OracleDbType.Varchar2).Value = ELTBKARDEXBE.SERIE_NRO
            cmd.Parameters.Add("@pNRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NRO_DOCU
            cmd.Parameters.Add("@pART_COD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ART_COD
            cmd.Parameters.Add("@pANHO", OracleDbType.Varchar2).Value = Mid(ELTBKARDEXBE.AÑO, 1, 4)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBARTPREMOV_INSKARDEXK"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBKARDEXBE.SERIE_NRO = IIf(IsDBNull(RTrim(row.Cells("SERIE_NRO").Value)), "", RTrim(row.Cells("SERIE_NRO").Value))
            ELTBKARDEXBE.NRO_DOCU = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU").Value)), "", RTrim(row.Cells("NRO_DOCU").Value))
            ELTBKARDEXBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            ELTBKARDEXBE.PRECIO = IIf(IsDBNull(RTrim(row.Cells("NRO_PRECIOSALDO").Value)), 0, RTrim(row.Cells("NRO_PRECIOSALDO").Value))
            cmd.Parameters.Add("@pT_DOC_REF", OracleDbType.Varchar2).Value = "SALM"
            cmd.Parameters.Add("@pSER_DOC_REF", OracleDbType.Varchar2).Value = ELTBKARDEXBE.SERIE_NRO
            cmd.Parameters.Add("@pNRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBKARDEXBE.NRO_DOCU
            cmd.Parameters.Add("@pART_COD", OracleDbType.Varchar2).Value = ELTBKARDEXBE.ART_COD
            cmd.Parameters.Add("@pANHO", OracleDbType.Varchar2).Value = Mid(ELTBKARDEXBE.AÑO, 1, 4)
            cmd.Parameters.Add("@pU_PRECIO", OracleDbType.Double).Value = ELTBKARDEXBE.PRECIO

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub
    Private Sub InsertRowPrecio(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)


        Dim cont As Integer = 0
        'For Each row As DataRow In dg.Rows
        For Each row As DataGridViewRow In dg.Rows
            Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
            'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_KARDEX_PRECIOUPD"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            'cont = cont + 1

            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("TIPO").Value)), "", RTrim(row.Cells("TIPO").Value))
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("SERIE").Value)), "", RTrim(row.Cells("SERIE").Value))
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NUMERO").Value)), "", RTrim(row.Cells("NUMERO").Value))
            cmd.Parameters.Add("@ART", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("ART").Value)), "", RTrim(row.Cells("ART").Value))
            cmd.Parameters.Add("@UPRECIO", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("UPRECIO").Value)), 0, RTrim(row.Cells("UPRECIO").Value))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next


    End Sub

    Public Function ActualizarFechaCompra(ByVal codigo As String, ByVal tipo As String, ByVal serie As String, ByVal nro As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ACT_FECHACOMPRA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@CODIGO", codigo),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@TIPO", tipo),
                                                                                            New Oracle.ManagedDataAccess.Client.OracleParameter("@SERIE", serie),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO", nro)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
