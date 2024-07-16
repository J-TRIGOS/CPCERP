Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports IT.ELUX.Connect
Imports Oracle.ManagedDataAccess.Client
Public Class ELTBRECEPCOMPDAL
    Inherits BaseDatosORACLE
    Public sNumero As String
    Public sNumero1 As Double
    Public sNumReq As String
    Public sNumReq1 As String
    Public sNumArtVenta As String

    Public Function SelectNroArtVenta(ByVal sSer As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        ' Dim dt As New DataTable

        sNumArtVenta = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_RECEPCOMP_SEL1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sSer))})
            While dr.Read
                If IsDBNull(dr.GetString(0)) Then
                    sNumArtVenta = ""
                Else
                    sNumArtVenta = dr.GetString(0)
                End If
            End While
        End Using
        Return sNumArtVenta
    End Function
    Function list1(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBRECEPCOMP_SEARCH", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Public Function getListdgv1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DET_DOCU_SELOREQRECEP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAll(ByVal sFec As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBRECEPCOMP_SELALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pFEC_GENE", sFec)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectNro1(ByVal COD As String) As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBRECEPCMP_NRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pCOD", COD)})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero
    End Function
    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBRECEPCOMP_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function VerNum(ByVal sNRO_DOCU As String, ByVal sSER_DOCU As String, ByVal sPROVEEDOR As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNumReq = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_NUMFCRECEP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sNRO_DOCU", sNRO_DOCU),
                                                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@sSER_DOCU", sSER_DOCU),
                                                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@sPROVEEDOR", sPROVEEDOR)})
            While dr.Read

                If IsDBNull(dr.GetString(0)) Then
                    sNumReq = ""
                Else
                    sNumReq = dr.GetString(0)
                End If

            End While
        End Using
        Return sNumReq
    End Function
    Public Function NumReq(ByVal sNRO_DOCU As String, ByVal sSER_DOCU As String, ByVal sART_COD As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNumReq = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_NUMREQDOC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sNRO_DOCU", sNRO_DOCU),
                                                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@sSER_DOCU", sSER_DOCU),
                                                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@sPROVEEDOR", sART_COD)})
            While dr.Read

                If IsDBNull(dr.GetString(0)) Then
                    sNumReq = ""
                Else
                    sNumReq = dr.GetString(0)
                End If

            End While
        End Using
        Return sNumReq
    End Function
    Public Function FecCreacion(ByVal sNRO_DOCU As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNumReq = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_FECGUIAING", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sNRO_DOCU", sNRO_DOCU)})
            While dr.Read

                If IsDBNull(dr.GetString(0)) Then
                    sNumReq = ""
                Else
                    sNumReq = dr.GetString(0)
                End If

            End While
        End Using
        Return sNumReq
    End Function
    Public Function SelObsReq(ByVal sSER_DOCU As String, ByVal sNRO_DOCU As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNumReq = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_REQOBS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sSER_DOCU", sSER_DOCU),
                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@sNRO_DOCU", sNRO_DOCU)})
            While dr.Read

                If IsDBNull(dr.GetString(0)) Then
                    sNumReq = ""
                Else
                    If dr.GetString(0) = "0" Then
                        sNumReq = ""
                    Else
                        sNumReq = dr.GetString(0)
                    End If
                End If

            End While
        End Using
        Return sNumReq
    End Function
    Public Function SelDetObsReq(ByVal sSER_DOCU As String, ByVal sNRO_DOCU As String, ByVal sART_COD As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNumReq = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DETREQOBS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sSER_DOCU", sSER_DOCU),
                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@sNRO_DOCU", sNRO_DOCU),
                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@ART_COD", sART_COD)})
            While dr.Read

                If IsDBNull(dr.GetString(0)) Then
                    sNumReq = ""
                Else
                    If dr.GetString(0) = "0" Then
                        sNumReq = ""
                    Else
                        sNumReq = dr.GetString(0)
                    End If
                End If
            End While
        End Using
        Return sNumReq
    End Function
    Public Function SelReqOreq(ByVal sSER_DOCU As String, ByVal sNRO_DOCU As String, ByVal sART_COD As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNumReq = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_SELREQOREQ", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sSER_DOCU", sSER_DOCU),
                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@sNRO_DOCU", sNRO_DOCU),
                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@ART_COD", sART_COD)})
            While dr.Read

                If IsDBNull(dr.GetString(0)) Then
                    sNumReq = ""
                Else
                    If dr.GetString(0) = "0" Then
                        sNumReq = ""
                    Else
                        sNumReq = dr.GetString(0)
                    End If
                End If
            End While
        End Using
        Return sNumReq
    End Function
    Public Function SelectRow2(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sArt As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDETRECEPCOMP_SELROW2", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@ART_COD", sArt)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectTipArt(ByVal sArt As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELTIP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ART_COD", sArt)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBDETRECEPCOMP_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectActivos1(ByVal sFec As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDETRECEPCOMP_EST", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC", sFec)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectActivos2(ByVal sFec As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDETRECEPCOMP_ESTADM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC", sFec)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Private Sub InsertRow(ByVal ELTBRECEPCOMPBE As ELTBRECEPCOMPBE, ByVal ELTBDETRECEPCOMPBE As ELTBDETRECEPCOMPBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBRECEPCOMP_INSROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBRECEPCOMPBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBRECEPCOMPBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBRECEPCOMPBE.NRO_DOC_REF
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBRECEPCOMPBE.FEC_GENE
        cmd.Parameters.Add("@USUARIO", OracleDbType.Varchar2).Value = ELTBRECEPCOMPBE.USUARIO
        cmd.Parameters.Add("@OBSERVA", OracleDbType.Varchar2).Value = ELTBRECEPCOMPBE.OBSERVA
        cmd.Parameters.Add("@NRO_DOCU", OracleDbType.Varchar2).Value = ELTBRECEPCOMPBE.NRO_DOCU
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        Dim art_ven1 As String = ""
        Dim ELTBRECEPCOMPDAL As New ELTBRECEPCOMPDAL
        If ELTBDETRECEPCOMPBE.ART_VENTA = "" Then
            art_ven1 = ELTBRECEPCOMPDAL.SelectNroArtVenta(ELTBRECEPCOMPBE.SER_DOC_REF)
            art_ven1 = art_ven1.PadLeft(8, "0")
        End If
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETRECEPCOMP_INSROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBDETRECEPCOMPBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            ELTBDETRECEPCOMPBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            ELTBDETRECEPCOMPBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            ELTBDETRECEPCOMPBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELTBDETRECEPCOMPBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELTBDETRECEPCOMPBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELTBDETRECEPCOMPBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("CTCT_COD").Value)), "", RTrim(row.Cells("CTCT_COD").Value))
            ELTBDETRECEPCOMPBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            ELTBDETRECEPCOMPBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            ELTBDETRECEPCOMPBE.SER_DOCU = IIf(IsDBNull(RTrim(row.Cells("SER_DOCU").Value)), "", RTrim(row.Cells("SER_DOCU").Value))
            ELTBDETRECEPCOMPBE.NRO_DOCU = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU").Value)), "", RTrim(row.Cells("NRO_DOCU").Value))
            ELTBDETRECEPCOMPBE.SER_DOCU1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOCU1").Value)), "", RTrim(row.Cells("SER_DOCU1").Value))
            ELTBDETRECEPCOMPBE.NRO_DOCU1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU1").Value)), "", RTrim(row.Cells("NRO_DOCU1").Value))
            ELTBDETRECEPCOMPBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells("FEC_GENE").Value)), "", RTrim(row.Cells("FEC_GENE").Value))
            ELTBDETRECEPCOMPBE.T_DOCU = IIf(IsDBNull(RTrim(row.Cells("T_DOCU").Value)), "", RTrim(row.Cells("T_DOCU").Value))
            ELTBDETRECEPCOMPBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells("ACT_COD").Value)), "", RTrim(row.Cells("ACT_COD").Value))
            ELTBDETRECEPCOMPBE.ART_VENTA = IIf(IsDBNull(RTrim(row.Cells("ART_VENTA").Value)), "", RTrim(row.Cells("ART_VENTA").Value))
            'ELTBDETRECEPCOMPBE.USUARIO = IIf(IsDBNull(RTrim(row.Cells("USUARIO").Value)), "", RTrim(row.Cells("USUARIO").Value))
            ELTBDETRECEPCOMPBE.ART_PRECIO = IIf(IsDBNull(RTrim(row.Cells("ART_PRECIO").Value)), 0, RTrim(row.Cells("ART_PRECIO").Value))
            ELTBDETRECEPCOMPBE.ART_PRECIOPROM = IIf(IsDBNull(RTrim(row.Cells("ART_PRECIOPROM").Value)), 0, RTrim(row.Cells("ART_PRECIOPROM").Value))
            ELTBDETRECEPCOMPBE.ART_VENTA1 = art_ven1

            art_ven1 = art_ven1 + 1
            art_ven1 = art_ven1.PadLeft(8, "0")

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBRECEPCOMPBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBRECEPCOMPBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBRECEPCOMPBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.NRO_DOC_REF1
            cmd.Parameters.Add("@T_DOCU", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.T_DOCU
            cmd.Parameters.Add("@ser_docu", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.SER_DOCU
            cmd.Parameters.Add("@nro_docu", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.NRO_DOCU
            cmd.Parameters.Add("@ser_docu1", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.SER_DOCU1
            cmd.Parameters.Add("@nro_docu1", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.NRO_DOCU1
            cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.PROVEEDOR
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBDETRECEPCOMPBE.FEC_GENE
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = ELTBRECEPCOMPBE.USUARIO
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = ELTBDETRECEPCOMPBE.CANTIDAD
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.ART_COD
            cmd.Parameters.Add("@NRO_DOCU2", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.NRO_DOCU2
            cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = "0"
            cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.ACT_COD
            cmd.Parameters.Add("@ART_VENTA", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.ART_VENTA
            cmd.Parameters.Add("@ART_PRECIO", OracleDbType.Double).Value = ELTBDETRECEPCOMPBE.ART_PRECIO
            cmd.Parameters.Add("@ART_PRECIOPROM", OracleDbType.Double).Value = ELTBDETRECEPCOMPBE.ART_PRECIOPROM
            cmd.Parameters.Add("@ART_PRECIOPROMN", OracleDbType.Double).Value = ELTBDETRECEPCOMPBE.ART_PRECIOPROMN
            cmd.Parameters.Add("@ART_VENTA1", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.ART_VENTA1
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
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + ELTBRECEPCOMPBE.T_DOC_REF + "-" + ELTBRECEPCOMPBE.SER_DOC_REF + "-" + ELTBRECEPCOMPBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRow(ByVal ELTBRECEPCOMPBE As ELTBRECEPCOMPBE, ByVal ELTBDETRECEPCOMPBE As ELTBDETRECEPCOMPBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBRECEPCOMP_UPDROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBRECEPCOMPBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBRECEPCOMPBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBRECEPCOMPBE.NRO_DOC_REF
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBRECEPCOMPBE.FEC_GENE
        cmd.Parameters.Add("@USUARIO", OracleDbType.Varchar2).Value = ELTBRECEPCOMPBE.USUARIO
        cmd.Parameters.Add("@OBSERVA", OracleDbType.Varchar2).Value = ELTBRECEPCOMPBE.OBSERVA
        cmd.Parameters.Add("@NRO_DOCU", OracleDbType.Double).Value = ELTBRECEPCOMPBE.NRO_DOCU
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETRECEPCOMP_DEL"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBRECEPCOMPBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBRECEPCOMPBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBRECEPCOMPBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETRECEPCOMP_INSROW1"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBDETRECEPCOMPBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            ELTBDETRECEPCOMPBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            ELTBDETRECEPCOMPBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            ELTBDETRECEPCOMPBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELTBDETRECEPCOMPBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELTBDETRECEPCOMPBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELTBDETRECEPCOMPBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("CTCT_COD").Value)), "", RTrim(row.Cells("CTCT_COD").Value))
            ELTBDETRECEPCOMPBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            ELTBDETRECEPCOMPBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            ELTBDETRECEPCOMPBE.SER_DOCU = IIf(IsDBNull(RTrim(row.Cells("SER_DOCU").Value)), "", RTrim(row.Cells("SER_DOCU").Value))
            ELTBDETRECEPCOMPBE.NRO_DOCU = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU").Value)), "", RTrim(row.Cells("NRO_DOCU").Value))
            ELTBDETRECEPCOMPBE.SER_DOCU1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOCU1").Value)), "", RTrim(row.Cells("SER_DOCU1").Value))
            ELTBDETRECEPCOMPBE.NRO_DOCU1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOCU1").Value)), "", RTrim(row.Cells("NRO_DOCU1").Value))
            ELTBDETRECEPCOMPBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells("FEC_GENE").Value)), "", RTrim(row.Cells("FEC_GENE").Value))
            ELTBDETRECEPCOMPBE.T_DOCU = IIf(IsDBNull(RTrim(row.Cells("T_DOCU").Value)), "", RTrim(row.Cells("T_DOCU").Value))
            ELTBDETRECEPCOMPBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells("ACT_COD").Value)), "", RTrim(row.Cells("ACT_COD").Value))
            ELTBDETRECEPCOMPBE.ART_VENTA = IIf(IsDBNull(RTrim(row.Cells("ART_VENTA").Value)), "", RTrim(row.Cells("ART_VENTA").Value))
            ELTBDETRECEPCOMPBE.ART_PRECIO = IIf(IsDBNull(RTrim(row.Cells("ART_PRECIO").Value)), 0, RTrim(row.Cells("ART_PRECIO").Value))
            ELTBDETRECEPCOMPBE.ART_PRECIOPROM = IIf(IsDBNull(RTrim(row.Cells("ART_PRECIOPROM").Value)), 0, RTrim(row.Cells("ART_PRECIOPROM").Value))
            ELTBDETRECEPCOMPBE.ART_PRECIOPROMN = IIf(IsDBNull(RTrim(row.Cells("ART_PRECIOPROMN").Value)), 0, RTrim(row.Cells("ART_PRECIOPROMN").Value))
            'If ELTBDETRECEPCOMPBE.SER_DOC_REF = ELTBDETRECEPCOMPBE.SER_DOC_REF1 And ELTBDETRECEPCOMPBE.T_DOC_REF = ELTBDETRECEPCOMPBE.T_DOC_REF1 Then
            '    ELTBDETRECEPCOMPBE.NRO_DOC_REF1 = ELTBDETRECEPCOMPBE.NRO_DOC_REF & "-" & cont
            'End If
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBRECEPCOMPBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBRECEPCOMPBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBRECEPCOMPBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.NRO_DOC_REF1
            cmd.Parameters.Add("@T_DOCU", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.T_DOCU
            cmd.Parameters.Add("@ser_docu", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.SER_DOCU
            cmd.Parameters.Add("@nro_docu", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.NRO_DOCU
            cmd.Parameters.Add("@ser_docu1", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.SER_DOCU1
            cmd.Parameters.Add("@nro_docu1", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.NRO_DOCU1
            cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.PROVEEDOR
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELTBDETRECEPCOMPBE.FEC_GENE
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = ELTBRECEPCOMPBE.USUARIO
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = ELTBDETRECEPCOMPBE.CANTIDAD
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.ART_COD
            cmd.Parameters.Add("@NRO_DOCU2", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.NRO_DOCU2
            cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.EST
            cmd.Parameters.Add("@NRO_DOCU3", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.NRO_DOCU3
            cmd.Parameters.Add("@SER_DOCU3", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.SER_DOCU3
            cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.ACT_COD
            cmd.Parameters.Add("@ART_VENTA", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.ART_VENTA
            cmd.Parameters.Add("@ART_PRECIO", OracleDbType.Double).Value = ELTBDETRECEPCOMPBE.ART_PRECIO
            cmd.Parameters.Add("@ART_PRECIOPROM", OracleDbType.Double).Value = ELTBDETRECEPCOMPBE.ART_PRECIOPROM
            cmd.Parameters.Add("@ART_PRECIOPROMN", OracleDbType.Double).Value = ELTBDETRECEPCOMPBE.ART_PRECIOPROMN
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
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el Documento: " + ELTBRECEPCOMPBE.T_DOC_REF + "-" + ELTBRECEPCOMPBE.SER_DOC_REF + "-" + ELTBRECEPCOMPBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub InsertRowNac(ByVal GUIAALMACENBE As GUIAALMACENBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVALMABE As ELMVALMABE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal dg As DataGridView, ByVal scodcat As String, ByVal sEst As String)
        Dim contenedor As String
        'Dim nro As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_INSERTROW_ALMNC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.ART_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = GUIAALMACENBE.MONEDA
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = GUIAALMACENBE.FEC_ANU
        cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = GUIAALMACENBE.SIGNO
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
        cmd.Parameters.Add("@observa", OracleDbType.Char).Value = GUIAALMACENBE.OBSERVA
        cmd.Parameters.Add("@t_movinv", OracleDbType.Char).Value = GUIAALMACENBE.T_MOVINV
        cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = GUIAALMACENBE.F_PAGO_ENT
        cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.FOR_ENT_COD
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD
        cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = Trim(GUIAALMACENBE.PROVEEDOR)
        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CTCT_COD
        cmd.Parameters.Add("@dir_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.DIR_COD
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.PER_COD
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
        cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC
        cmd.Parameters.Add("@observa1", OracleDbType.Varchar2).Value = GUIAALMACENBE.OBSERVA1
        cmd.Parameters.Add("@x_m", OracleDbType.Varchar2).Value = GUIAALMACENBE.X_M
        cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
        cmd.Parameters.Add("@NOM_CTCT", OracleDbType.Varchar2).Value = GUIAALMACENBE.NOM_CTCT
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows

            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INSALM"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            'DET_DOCUMENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            'DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
            'DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))
            DET_DOCUMENTOBE.T_DOC_REF1 = "REQ"
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SREQ").Value)), "", RTrim(row.Cells("SREQ").Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NREQ").Value)), "", RTrim(row.Cells("NREQ").Value))
            DET_DOCUMENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells("CTCT_COD").Value)), "", RTrim(row.Cells("CTCT_COD").Value))
            DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells("ACT_COD").Value)), "", RTrim(row.Cells("ACT_COD").Value))
            DET_DOCUMENTOBE.SIGNO = "+"
            DET_DOCUMENTOBE.OBSERVA = ""
            DET_DOCUMENTOBE.T_MOVINV = "E19"
            'DET_DOCUMENTOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells(27).Value)), "", RTrim(row.Cells(27).Value))
            'DET_DOCUMENTOBE.USUARIO = IIf(IsDBNull(RTrim(row.Cells(28).Value)), "", RTrim(row.Cells(28).Value))
            DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
            DET_DOCUMENTOBE.F_PAGO_ENT = ""
            DET_DOCUMENTOBE.FOR_ENT_COD = ""
            'DET_DOCUMENTOBE.FEC_DIA = IIf(IsDBNull(RTrim(row.Cells(32).Value)), "", RTrim(row.Cells(32).Value))
            'DET_DOCUMENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells(33).Value)), "", RTrim(row.Cells(33).Value))
            DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells("CCO_COD").Value)), "", RTrim(row.Cells("CCO_COD").Value))
            DET_DOCUMENTOBE.LOTE = ""
            'DET_DOCUMENTOBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells(37).Value)), "", RTrim(row.Cells(37).Value))
            ' DET_DOCUMENTOBE.FEC_LLEG = IIf(IsDBNull(RTrim(row.Cells(12).Value)), "", RTrim(row.Cells(12).Value))
            DET_DOCUMENTOBE.EST = "H"
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells("ACT_COD").Value)), "", RTrim(row.Cells("ACT_COD").Value))
            DET_DOCUMENTOBE.ART_VENTA = IIf(IsDBNull(RTrim(row.Cells("ART_VENTA").Value)), "", RTrim(row.Cells("ART_VENTA").Value))
            'If GUIAALMACENBE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 And GUIAALMACENBE.T_DOC_REF = DET_DOCUMENTOBE.T_DOC_REF1 Then
            DET_DOCUMENTOBE.NRO_DOC_REF1 = DET_DOCUMENTOBE.NRO_DOC_REF1 & "-" & cont
            'AGREGADO PARA INGRESAR PRECIO EN DETALLE
            DET_DOCUMENTOBE.SUGERENCIA = IIf(IsDBNull(RTrim(row.Cells("ART_VENTA").Value)), "", RTrim(row.Cells("ART_VENTA").Value))
            'End If
            'Los parametros que va recibir son las propiedades de la clase
            If ELMVLOGSBE.log_codusu <> "0001" Then
                If IIf(IsDBNull(RTrim(row.Cells("CT").Value)), "", RTrim(row.Cells("CT").Value)) = "1" Then
                    cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF
                    cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.SER_DOC_REF
                    cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF
                    cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
                    cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
                    cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                    cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CTCT_COD
                    cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                    cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
                    cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO
                    cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
                    cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_MOVINV)
                    cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                    cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                    cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                    cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT
                    cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.FOR_ENT_COD
                    cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
                    cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = GUIAALMACENBE.PROVEEDOR
                    cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CCO_COD
                    cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE
                    cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD
                    cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
                    'cmd.Parameters.Add("@fec_lleg", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_LLEG
                    cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                    cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC
                    cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ACT_COD
                    cmd.Parameters.Add("@ART_VENTA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_VENTA
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ARTICULO_UPDATESTKSUM"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(GUIAALMACENBE.ALM_COD)
                    cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ELMVALMAANHO_INS"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
                    cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
                    cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
                    cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)
                    cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
                    cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                    cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                    cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                    cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                    cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                    cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_MOVINV
                    cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                    cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
                    cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                    cmd.Parameters.Add("@MOV_CCO_COD", OracleDbType.Varchar2).Value = "" 'DET_DOCUMENTOBE.CCO_COD
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If
            Else
                cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.SER_DOC_REF
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF
                cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
                cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
                cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CTCT_COD
                cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
                cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO
                cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
                cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_MOVINV)
                cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT
                cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.FOR_ENT_COD
                cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
                cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = GUIAALMACENBE.PROVEEDOR
                cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CCO_COD
                cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE
                cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD
                cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
                'cmd.Parameters.Add("@fec_lleg", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_LLEG
                cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC
                cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ACT_COD
                cmd.Parameters.Add("@ART_VENTA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_VENTA
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ARTICULO_UPDATESTKSUM"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(GUIAALMACENBE.ALM_COD)
                cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELMVALMAANHO_INS"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
                cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
                cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
                cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)
                cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
                cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_MOVINV
                cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
                cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                cmd.Parameters.Add("@MOV_CCO_COD", OracleDbType.Varchar2).Value = ""  'DET_DOCUMENTOBE.CCO_COD
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
        Next
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + GUIAALMACENBE.T_DOC_REF + "-" + GUIAALMACENBE.SER_DOC_REF + "-" + GUIAALMACENBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub InsertRowNacRecep(ByVal GUIAALMACENBE As GUIAALMACENBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVALMABE As ELMVALMABE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal dg As DataGridView, ByVal scodcat As String, ByVal sEst As String)
        Dim contenedor As String
        'Dim nro As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_INSERTROW_ALMNC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.ART_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = GUIAALMACENBE.MONEDA
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = GUIAALMACENBE.FEC_ANU
        cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = GUIAALMACENBE.SIGNO
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
        cmd.Parameters.Add("@observa", OracleDbType.Char).Value = GUIAALMACENBE.OBSERVA
        cmd.Parameters.Add("@t_movinv", OracleDbType.Char).Value = GUIAALMACENBE.T_MOVINV
        cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = GUIAALMACENBE.F_PAGO_ENT
        cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.FOR_ENT_COD
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD
        cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = Trim(GUIAALMACENBE.PROVEEDOR)
        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CTCT_COD
        cmd.Parameters.Add("@dir_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.DIR_COD
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.PER_COD
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
        cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC
        cmd.Parameters.Add("@observa1", OracleDbType.Varchar2).Value = GUIAALMACENBE.OBSERVA1
        cmd.Parameters.Add("@x_m", OracleDbType.Varchar2).Value = GUIAALMACENBE.X_M
        cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
        cmd.Parameters.Add("@NOM_CTCT", OracleDbType.Varchar2).Value = GUIAALMACENBE.NOM_CTCT
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows

            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INSALMR"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            'DET_DOCUMENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            'DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
            'DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))
            DET_DOCUMENTOBE.T_DOC_REF1 = "REQ"
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SREQ").Value)), "", RTrim(row.Cells("SREQ").Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NREQ").Value)), "", RTrim(row.Cells("NREQ").Value))
            DET_DOCUMENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells("CTCT_COD").Value)), "", RTrim(row.Cells("CTCT_COD").Value))
            DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells("ACT_COD").Value)), "", RTrim(row.Cells("ACT_COD").Value))
            DET_DOCUMENTOBE.SIGNO = "+"
            DET_DOCUMENTOBE.OBSERVA = ""
            DET_DOCUMENTOBE.T_MOVINV = "E19"
            'DET_DOCUMENTOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells(27).Value)), "", RTrim(row.Cells(27).Value))
            'DET_DOCUMENTOBE.USUARIO = IIf(IsDBNull(RTrim(row.Cells(28).Value)), "", RTrim(row.Cells(28).Value))
            DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
            DET_DOCUMENTOBE.F_PAGO_ENT = ""
            DET_DOCUMENTOBE.FOR_ENT_COD = ""
            'DET_DOCUMENTOBE.FEC_DIA = IIf(IsDBNull(RTrim(row.Cells(32).Value)), "", RTrim(row.Cells(32).Value))
            'DET_DOCUMENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells(33).Value)), "", RTrim(row.Cells(33).Value))
            DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells("CCO_COD").Value)), "", RTrim(row.Cells("CCO_COD").Value))
            DET_DOCUMENTOBE.LOTE = ""
            'DET_DOCUMENTOBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells(37).Value)), "", RTrim(row.Cells(37).Value))
            ' DET_DOCUMENTOBE.FEC_LLEG = IIf(IsDBNull(RTrim(row.Cells(12).Value)), "", RTrim(row.Cells(12).Value))
            DET_DOCUMENTOBE.EST = "H"
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells("ACT_COD").Value)), "", RTrim(row.Cells("ACT_COD").Value))
            DET_DOCUMENTOBE.ART_VENTA = IIf(IsDBNull(RTrim(row.Cells("ART_VENTA").Value)), "", RTrim(row.Cells("ART_VENTA").Value))
            'If GUIAALMACENBE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 And GUIAALMACENBE.T_DOC_REF = DET_DOCUMENTOBE.T_DOC_REF1 Then
            DET_DOCUMENTOBE.NRO_DOC_REF1 = DET_DOCUMENTOBE.NRO_DOC_REF1 & "-" & cont
            'AGREGADO PARA INGRESAR PRECIO EN DETALLE
            DET_DOCUMENTOBE.SUGERENCIA = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value)) & "-" & IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            DET_DOCUMENTOBE.CANTIDAD2 = IIf(IsDBNull(RTrim(row.Cells("ART_PRECIO").Value)), 0, RTrim(row.Cells("ART_PRECIO").Value))
            DET_DOCUMENTOBE.CANTIDAD4 = IIf(IsDBNull(RTrim(row.Cells("ART_PRECIOPROM").Value)), 0, RTrim(row.Cells("ART_PRECIOPROM").Value))
            DET_DOCUMENTOBE.CANTIDAD5 = IIf(IsDBNull(RTrim(row.Cells("ART_PRECIOPROMN").Value)), 0, RTrim(row.Cells("ART_PRECIOPROMN").Value))
            'End If
            'Los parametros que va recibir son las propiedades de la clase
            If ELMVLOGSBE.log_codusu <> "0001" Then
                If IIf(IsDBNull(RTrim(row.Cells("CT").Value)), "", RTrim(row.Cells("CT").Value)) = "1" Then
                    cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF
                    cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.SER_DOC_REF
                    cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF
                    cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
                    cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
                    cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                    cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CTCT_COD
                    cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                    cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
                    cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO
                    cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
                    cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_MOVINV)
                    cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                    cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                    cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                    cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT
                    cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.FOR_ENT_COD
                    cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
                    cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = GUIAALMACENBE.PROVEEDOR
                    cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CCO_COD
                    cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE
                    cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD
                    cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
                    cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                    cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC
                    cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ACT_COD
                    cmd.Parameters.Add("@ART_VENTA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_VENTA
                    cmd.Parameters.Add("@CANTIDAD2", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD2
                    cmd.Parameters.Add("@CANTIDAD4", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD4
                    cmd.Parameters.Add("@CANTIDAD5", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD5
                    cmd.Parameters.Add("@SUGERENCIA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SUGERENCIA
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ARTICULO_UPDATESTKSUM"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(GUIAALMACENBE.ALM_COD)
                    cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ARTICULO_UPDPRECIO"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ART_PRECIO", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD4)
                    cmd.Parameters.Add("@ART_CODIGO", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ELMVALMAANHO_INS"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
                    cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
                    cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
                    cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)
                    cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
                    cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                    cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                    cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                    cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                    cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                    cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_MOVINV
                    cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                    cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
                    cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                    cmd.Parameters.Add("@MOV_CCO_COD", OracleDbType.Varchar2).Value = "" 'DET_DOCUMENTOBE.CCO_COD
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If
            Else
                cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.SER_DOC_REF
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF
                cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
                cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
                cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CTCT_COD
                cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
                cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO
                cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
                cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_MOVINV)
                cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT
                cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.FOR_ENT_COD
                cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
                cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = GUIAALMACENBE.PROVEEDOR
                cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CCO_COD
                cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE
                cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD
                cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
                'cmd.Parameters.Add("@fec_lleg", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_LLEG
                cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC
                cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ACT_COD
                cmd.Parameters.Add("@ART_VENTA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_VENTA
                cmd.Parameters.Add("@CANTIDAD2", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD2
                cmd.Parameters.Add("@CANTIDAD4", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD4
                cmd.Parameters.Add("@CANTIDAD5", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD5
                cmd.Parameters.Add("@SUGERENCIA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SUGERENCIA
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ARTICULO_UPDATESTKSUM"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(GUIAALMACENBE.ALM_COD)
                cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ARTICULO_UPDPRECIO"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ART_PRECIO", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD4)
                cmd.Parameters.Add("@ART_CODIGO", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELMVALMAANHO_INS"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
                cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
                cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
                cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)
                cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
                cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_MOVINV
                cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
                cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                cmd.Parameters.Add("@MOV_CCO_COD", OracleDbType.Varchar2).Value = ""  'DET_DOCUMENTOBE.CCO_COD
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
        Next
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + GUIAALMACENBE.T_DOC_REF + "-" + GUIAALMACENBE.SER_DOC_REF + "-" + GUIAALMACENBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub InsertRowNac1(ByVal GUIAALMACENBE As GUIAALMACENBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVALMABE As ELMVALMABE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal dg As DataGridView, ByVal scodcat As String, ByVal sEst As String)
        Dim contenedor As String
        'Dim nro As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_INSERTROW_ALMNC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = "002"
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.ART_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = GUIAALMACENBE.MONEDA
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = GUIAALMACENBE.FEC_ANU
        cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = GUIAALMACENBE.SIGNO
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
        cmd.Parameters.Add("@observa", OracleDbType.Char).Value = GUIAALMACENBE.OBSERVA
        cmd.Parameters.Add("@t_movinv", OracleDbType.Char).Value = "S23"
        cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = GUIAALMACENBE.F_PAGO_ENT
        cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.FOR_ENT_COD
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD
        cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = Trim(GUIAALMACENBE.PROVEEDOR)
        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CTCT_COD
        cmd.Parameters.Add("@dir_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.DIR_COD
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.PER_COD
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
        cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = "S"
        cmd.Parameters.Add("@observa1", OracleDbType.Varchar2).Value = GUIAALMACENBE.OBSERVA1
        cmd.Parameters.Add("@x_m", OracleDbType.Varchar2).Value = GUIAALMACENBE.X_M
        cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
        cmd.Parameters.Add("@NOM_CTCT", OracleDbType.Varchar2).Value = GUIAALMACENBE.NOM_CTCT
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows

            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INSALM"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            'DET_DOCUMENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            'DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
            'DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))
            DET_DOCUMENTOBE.T_DOC_REF1 = "REQ"
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SREQ").Value)), "", RTrim(row.Cells("SREQ").Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NREQ").Value)), "", RTrim(row.Cells("NREQ").Value))
            DET_DOCUMENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells("CTCT_COD").Value)), "", RTrim(row.Cells("CTCT_COD").Value))
            DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells("ACT_COD").Value)), "", RTrim(row.Cells("ACT_COD").Value))
            DET_DOCUMENTOBE.SIGNO = "+"
            DET_DOCUMENTOBE.OBSERVA = ""
            DET_DOCUMENTOBE.T_MOVINV = "S23"
            'DET_DOCUMENTOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells(27).Value)), "", RTrim(row.Cells(27).Value))
            'DET_DOCUMENTOBE.USUARIO = IIf(IsDBNull(RTrim(row.Cells(28).Value)), "", RTrim(row.Cells(28).Value))
            DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
            DET_DOCUMENTOBE.F_PAGO_ENT = ""
            DET_DOCUMENTOBE.FOR_ENT_COD = ""
            'DET_DOCUMENTOBE.FEC_DIA = IIf(IsDBNull(RTrim(row.Cells(32).Value)), "", RTrim(row.Cells(32).Value))
            'DET_DOCUMENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells(33).Value)), "", RTrim(row.Cells(33).Value))
            DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells("CCO_COD").Value)), "", RTrim(row.Cells("CCO_COD").Value))
            DET_DOCUMENTOBE.LOTE = ""
            'DET_DOCUMENTOBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells(37).Value)), "", RTrim(row.Cells(37).Value))
            ' DET_DOCUMENTOBE.FEC_LLEG = IIf(IsDBNull(RTrim(row.Cells(12).Value)), "", RTrim(row.Cells(12).Value))
            DET_DOCUMENTOBE.EST = "H"
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells("ACT_COD").Value)), "", RTrim(row.Cells("ACT_COD").Value))
            'If GUIAALMACENBE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 And GUIAALMACENBE.T_DOC_REF = DET_DOCUMENTOBE.T_DOC_REF1 Then
            DET_DOCUMENTOBE.NRO_DOC_REF1 = DET_DOCUMENTOBE.NRO_DOC_REF1 & "-" & cont
            'End If
            'Los parametros que va recibir son las propiedades de la clase
            If ELMVLOGSBE.log_codusu <> "0001" Then
                If IIf(IsDBNull(RTrim(row.Cells("CT").Value)), "", RTrim(row.Cells("CT").Value)) = "1" Then
                    cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF
                    cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = "002"
                    cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF
                    cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
                    cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
                    cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                    cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CTCT_COD
                    cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                    cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
                    cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO
                    cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
                    cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = "S23"
                    cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                    cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                    cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                    cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT
                    cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.FOR_ENT_COD
                    cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
                    cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = GUIAALMACENBE.PROVEEDOR
                    cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CCO_COD
                    cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE
                    cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD
                    cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
                    'cmd.Parameters.Add("@fec_lleg", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_LLEG
                    cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                    cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = "S"
                    cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ACT_COD
                    cmd.Parameters.Add("@ART_VENTA", OracleDbType.Varchar2).Value = ""
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ARTICULO_UPDATESTKRES"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(GUIAALMACENBE.ALM_COD)
                    cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ELMVALMAANHO_INS1"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
                    cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = "002"
                    cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
                    cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = "S"
                    cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
                    cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                    cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                    cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                    cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                    cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                    cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = "S23"
                    cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                    cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
                    cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                    cmd.Parameters.Add("@S_RECEP", OracleDbType.Varchar2).Value = GUIAALMACENBE.SER_DOCU3
                    cmd.Parameters.Add("@N_RECEP", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOCU3
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If
            Else
                cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = "002"
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF
                cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
                cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
                cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CTCT_COD
                cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
                cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO
                cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
                cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = "S23"
                cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT
                cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.FOR_ENT_COD
                cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
                cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = GUIAALMACENBE.PROVEEDOR
                cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CCO_COD
                cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE
                cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD
                cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
                'cmd.Parameters.Add("@fec_lleg", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_LLEG
                cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = "S"
                cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ACT_COD
                cmd.Parameters.Add("@ART_VENTA", OracleDbType.Varchar2).Value = ""
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ARTICULO_UPDATESTKRES"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(GUIAALMACENBE.ALM_COD)
                cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELMVALMAANHO_INS1"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
                cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = "002"
                cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
                cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = "S"
                cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
                cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = "S23"
                cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
                cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                cmd.Parameters.Add("@S_RECEP", OracleDbType.Varchar2).Value = GUIAALMACENBE.SER_DOCU3
                cmd.Parameters.Add("@N_RECEP", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOCU3
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If


        Next
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + GUIAALMACENBE.T_DOC_REF + "-" + "002" + "-" + GUIAALMACENBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub UpdateRowDD(ByVal ELTBRECEPCOMPBE As ELTBRECEPCOMPBE, ByVal ELTBDETRECEPCOMPBE As ELTBDETRECEPCOMPBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETRECEPCOMP_UPDD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBDETRECEPCOMPBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBDETRECEPCOMPBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBDETRECEPCOMPBE.NRO_DOC_REF)
        cmd.Parameters.Add("@est1", OracleDbType.Varchar2).Value = "4"
        cmd.Parameters.Add("@usuario_ob", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.USUARIO_OB
        cmd.Parameters.Add("@OBSERVA", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.OBSERVA
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Observo el Documento de Recepcion: " + ELTBRECEPCOMPBE.T_DOC_REF + "-" + ELTBRECEPCOMPBE.SER_DOC_REF + "-" + ELTBRECEPCOMPBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRowAD(ByVal ELTBRECEPCOMPBE As ELTBRECEPCOMPBE, ByVal ELTBDETRECEPCOMPBE As ELTBDETRECEPCOMPBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETRECEPCOMP_UPAD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBDETRECEPCOMPBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBDETRECEPCOMPBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBDETRECEPCOMPBE.NRO_DOC_REF)
        cmd.Parameters.Add("@est1", OracleDbType.Varchar2).Value = "3"
        cmd.Parameters.Add("@usuario_Vb", OracleDbType.Varchar2).Value = ELTBDETRECEPCOMPBE.USUARIO_VB

        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "2"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Observo el Documento de Recepcion: " + ELTBDETRECEPCOMPBE.T_DOC_REF + "-" + ELTBDETRECEPCOMPBE.SER_DOC_REF + "-" + ELTBDETRECEPCOMPBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRowED(ByVal ELTBRECEPCOMPBE As ELTBRECEPCOMPBE, ByVal ELTBDETRECEPCOMPBE As ELTBDETRECEPCOMPBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETRECEPCOMP_UPED"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBDETRECEPCOMPBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBDETRECEPCOMPBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBDETRECEPCOMPBE.NRO_DOC_REF)
        cmd.Parameters.Add("@est1", OracleDbType.Varchar2).Value = "2"
        cmd.Parameters.Add("@usuario_Vb", OracleDbType.Varchar2).Value = ""

        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "2"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Envio El Documento de Recepcion: " + ELTBDETRECEPCOMPBE.T_DOC_REF + "-" + ELTBDETRECEPCOMPBE.SER_DOC_REF + "-" + ELTBDETRECEPCOMPBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub UpdateRowAN(ByVal ELTBRECEPCOMPBE As ELTBRECEPCOMPBE, ByVal ELTBDETRECEPCOMPBE As ELTBDETRECEPCOMPBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETRECEPCOMP_UPDD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBRECEPCOMPBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBRECEPCOMPBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBRECEPCOMPBE.NRO_DOC_REF)
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = "1"
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = "A"
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(ELTBDETRECEPCOMPBE.NRO_DOCU2)

        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Anulo el Documento de Recepcion: " + ELTBRECEPCOMPBE.T_DOC_REF + "-" + ELTBRECEPCOMPBE.SER_DOC_REF + "-" + ELTBRECEPCOMPBE.NRO_DOC_REF + "- GUIA " + ELTBDETRECEPCOMPBE.NRO_DOCU2
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRowMod(ByVal GUIAALMACENBE As GUIAALMACENBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVALMABE As ELMVALMABE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal dg As DataGridView, ByVal scodcat As String, ByVal sEst As String)
        Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDATEROW_ALMNC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.Parameters.Add("part_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.ART_COD
        cmd.Parameters.Add("pfec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
        cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
        cmd.Parameters.Add("pmoneda", OracleDbType.Varchar2).Value = GUIAALMACENBE.MONEDA
        cmd.Parameters.Add("pfec_anu", OracleDbType.Date).Value = GUIAALMACENBE.FEC_ANU
        cmd.Parameters.Add("psigno", OracleDbType.Varchar2).Value = GUIAALMACENBE.SIGNO
        cmd.Parameters.Add("pusuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
        cmd.Parameters.Add("pobserva", OracleDbType.Char).Value = GUIAALMACENBE.OBSERVA
        cmd.Parameters.Add("pt_movinv", OracleDbType.Char).Value = GUIAALMACENBE.T_MOVINV
        cmd.Parameters.Add("pf_pago_ent", OracleDbType.Varchar2).Value = GUIAALMACENBE.F_PAGO_ENT
        cmd.Parameters.Add("pfor_ent_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.FOR_ENT_COD
        cmd.Parameters.Add("pcco_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD
        cmd.Parameters.Add("pproveedor", OracleDbType.Char).Value = Trim(GUIAALMACENBE.PROVEEDOR)
        cmd.Parameters.Add("pctct_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CTCT_COD
        cmd.Parameters.Add("pdir_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.DIR_COD
        cmd.Parameters.Add("per_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.PER_COD
        cmd.Parameters.Add("pfec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
        cmd.Parameters.Add("palmac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC
        cmd.Parameters.Add("px_m", OracleDbType.Varchar2).Value = GUIAALMACENBE.X_M
        cmd.Parameters.Add("codalm", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
        cmd.Parameters.Add("NOM_CTCT", OracleDbType.Varchar2).Value = GUIAALMACENBE.NOM_CTCT
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        'DEVOLUCION DE STOCK SIN IMPORTAR QUE MOVIMIENTO HAGA O ELIMINE
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ARTICULO_DVSTOCKALM"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@pT_DOC_REF", OracleDbType.Char).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("@pSER_DOC_REF", OracleDbType.Char).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("@pNRO_DOC_REF", OracleDbType.Char).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.Parameters.Add("@pfec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCUMENTO_DEL_ALM"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@pT_DOC_REF", OracleDbType.Char).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("@pSER_DOC_REF", OracleDbType.Char).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("@pNRO_DOC_REF", OracleDbType.Char).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INSALM"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            DET_DOCUMENTOBE.T_DOC_REF1 = "REQ"
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SREQ").Value)), "", RTrim(row.Cells("SREQ").Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NREQ").Value)), "", RTrim(row.Cells("NREQ").Value))
            DET_DOCUMENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells("CTCT_COD").Value)), "", RTrim(row.Cells("CTCT_COD").Value))
            DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells("ACT_COD").Value)), "", RTrim(row.Cells("ACT_COD").Value))
            DET_DOCUMENTOBE.SIGNO = "+"
            DET_DOCUMENTOBE.OBSERVA = ""
            DET_DOCUMENTOBE.T_MOVINV = "E19"
            DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
            DET_DOCUMENTOBE.F_PAGO_ENT = ""
            DET_DOCUMENTOBE.FOR_ENT_COD = ""
            DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells("CCO_COD").Value)), "", RTrim(row.Cells("CCO_COD").Value))
            DET_DOCUMENTOBE.LOTE = ""
            DET_DOCUMENTOBE.EST = "H"
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells("ACT_COD").Value)), "", RTrim(row.Cells("ACT_COD").Value))
            DET_DOCUMENTOBE.ART_VENTA = IIf(IsDBNull(RTrim(row.Cells("ART_VENTA").Value)), "", RTrim(row.Cells("ART_VENTA").Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = DET_DOCUMENTOBE.NRO_DOC_REF1 & "-" & cont
            If ELMVLOGSBE.log_codusu <> "0001" Then
                If IIf(IsDBNull(RTrim(row.Cells("CT").Value)), "", RTrim(row.Cells("CT").Value)) = "1" Then
                    'Los parametros que va recibir son las propiedades de la clase 
                    cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF
                    cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.SER_DOC_REF
                    cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF
                    cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
                    cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
                    cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                    cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CTCT_COD
                    cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                    cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
                    cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO
                    cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
                    cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_MOVINV)
                    cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                    cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                    cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                    cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT
                    cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.FOR_ENT_COD
                    cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
                    cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = GUIAALMACENBE.PROVEEDOR
                    cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CCO_COD
                    cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE
                    cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD
                    cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
                    'cmd.Parameters.Add("@fec_lleg", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_LLEG
                    cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                    cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC
                    cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ACT_COD
                    cmd.Parameters.Add("@ART_VENTA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_VENTA
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ARTICULO_UPDATESTKSUM"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(GUIAALMACENBE.ALM_COD)
                    cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ELMVALMAANHO_INS"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
                    cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
                    cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
                    cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)
                    cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
                    cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                    cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                    cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                    cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                    cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                    cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_MOVINV
                    cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                    cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
                    cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                    cmd.Parameters.Add("@MOV_CCO_COD", OracleDbType.Varchar2).Value = "" 'DET_DOCUMENTOBE.CCO_COD
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If
            Else
                'Los parametros que va recibir son las propiedades de la clase 
                cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.SER_DOC_REF
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF
                cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
                cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
                cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CTCT_COD
                cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
                cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO
                cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
                cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_MOVINV)
                cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT
                cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.FOR_ENT_COD
                cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
                cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = GUIAALMACENBE.PROVEEDOR
                cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CCO_COD
                cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE
                cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD
                cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
                'cmd.Parameters.Add("@fec_lleg", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_LLEG
                cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC
                cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ACT_COD
                cmd.Parameters.Add("@ART_VENTA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_VENTA
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ARTICULO_UPDATESTKSUM"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(GUIAALMACENBE.ALM_COD)
                cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELMVALMAANHO_INS"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
                cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
                cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
                cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)
                cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
                cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_MOVINV
                cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
                cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                cmd.Parameters.Add("@MOV_CCO_COD", OracleDbType.Varchar2).Value = "" 'DET_DOCUMENTOBE.CCO_COD
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If


        Next
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Actualizo el Documento: " + GUIAALMACENBE.T_DOC_REF + "-" + GUIAALMACENBE.SER_DOC_REF + "-" + GUIAALMACENBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRowModRecep(ByVal GUIAALMACENBE As GUIAALMACENBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVALMABE As ELMVALMABE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal dg As DataGridView, ByVal scodcat As String, ByVal sEst As String)
        Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDATEROW_ALMNC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.Parameters.Add("part_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.ART_COD
        cmd.Parameters.Add("pfec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
        cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
        cmd.Parameters.Add("pmoneda", OracleDbType.Varchar2).Value = GUIAALMACENBE.MONEDA
        cmd.Parameters.Add("pfec_anu", OracleDbType.Date).Value = GUIAALMACENBE.FEC_ANU
        cmd.Parameters.Add("psigno", OracleDbType.Varchar2).Value = GUIAALMACENBE.SIGNO
        cmd.Parameters.Add("pusuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
        cmd.Parameters.Add("pobserva", OracleDbType.Char).Value = GUIAALMACENBE.OBSERVA
        cmd.Parameters.Add("pt_movinv", OracleDbType.Char).Value = GUIAALMACENBE.T_MOVINV
        cmd.Parameters.Add("pf_pago_ent", OracleDbType.Varchar2).Value = GUIAALMACENBE.F_PAGO_ENT
        cmd.Parameters.Add("pfor_ent_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.FOR_ENT_COD
        cmd.Parameters.Add("pcco_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD
        cmd.Parameters.Add("pproveedor", OracleDbType.Char).Value = Trim(GUIAALMACENBE.PROVEEDOR)
        cmd.Parameters.Add("pctct_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CTCT_COD
        cmd.Parameters.Add("pdir_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.DIR_COD
        cmd.Parameters.Add("per_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.PER_COD
        cmd.Parameters.Add("pfec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
        cmd.Parameters.Add("palmac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC
        cmd.Parameters.Add("px_m", OracleDbType.Varchar2).Value = GUIAALMACENBE.X_M
        cmd.Parameters.Add("codalm", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
        cmd.Parameters.Add("NOM_CTCT", OracleDbType.Varchar2).Value = GUIAALMACENBE.NOM_CTCT
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        'DEVOLUCION DE STOCK SIN IMPORTAR QUE MOVIMIENTO HAGA O ELIMINE
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ARTICULO_DVSTOCKALM"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@pT_DOC_REF", OracleDbType.Char).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("@pSER_DOC_REF", OracleDbType.Char).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("@pNRO_DOC_REF", OracleDbType.Char).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.Parameters.Add("@pfec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCUMENTO_DEL_ALM"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@pT_DOC_REF", OracleDbType.Char).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("@pSER_DOC_REF", OracleDbType.Char).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("@pNRO_DOC_REF", OracleDbType.Char).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INSALMR"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            DET_DOCUMENTOBE.T_DOC_REF1 = "REQ"
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SREQ").Value)), "", RTrim(row.Cells("SREQ").Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NREQ").Value)), "", RTrim(row.Cells("NREQ").Value))
            DET_DOCUMENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells("CTCT_COD").Value)), "", RTrim(row.Cells("CTCT_COD").Value))
            DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells("ACT_COD").Value)), "", RTrim(row.Cells("ACT_COD").Value))
            DET_DOCUMENTOBE.SIGNO = "+"
            DET_DOCUMENTOBE.OBSERVA = ""
            DET_DOCUMENTOBE.T_MOVINV = "E19"
            DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
            DET_DOCUMENTOBE.F_PAGO_ENT = ""
            DET_DOCUMENTOBE.FOR_ENT_COD = ""
            DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells("CCO_COD").Value)), "", RTrim(row.Cells("CCO_COD").Value))
            DET_DOCUMENTOBE.LOTE = ""
            DET_DOCUMENTOBE.EST = "H"
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells("ACT_COD").Value)), "", RTrim(row.Cells("ACT_COD").Value))
            DET_DOCUMENTOBE.ART_VENTA = IIf(IsDBNull(RTrim(row.Cells("ART_VENTA").Value)), "", RTrim(row.Cells("ART_VENTA").Value))
            'DET_DOCUMENTOBE.SUGERENCIA = IIf(IsDBNull(RTrim(row.Cells("SUGERENCIA").Value)), "", RTrim(row.Cells("SUGERENCIA").Value))
            'DET_DOCUMENTOBE.TEMPLE = IIf(IsDBNull(RTrim(row.Cells("TEMPLE").Value)), "", RTrim(row.Cells("TEMPLE").Value))
            'DET_DOCUMENTOBE.T_DCTO = IIf(IsDBNull(RTrim(row.Cells("T_DCTO").Value)), "", RTrim(row.Cells("T_DCTO").Value))
            'DET_DOCUMENTOBE.CANTIDAD2 = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD2").Value)), "", RTrim(row.Cells("CANTIDAD2").Value))
            'DET_DOCUMENTOBE.CANTIDAD5 = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD5").Value)), "", RTrim(row.Cells("CANTIDAD5").Value))
            DET_DOCUMENTOBE.SUGERENCIA = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value)) & "-" & IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            DET_DOCUMENTOBE.CANTIDAD2 = IIf(IsDBNull(RTrim(row.Cells("ART_PRECIO").Value)), 0, RTrim(row.Cells("ART_PRECIO").Value))
            DET_DOCUMENTOBE.CANTIDAD4 = IIf(IsDBNull(RTrim(row.Cells("ART_PRECIOPROM").Value)), 0, RTrim(row.Cells("ART_PRECIOPROM").Value))
            DET_DOCUMENTOBE.CANTIDAD5 = IIf(IsDBNull(RTrim(row.Cells("ART_PRECIOPROMN").Value)), 0, RTrim(row.Cells("ART_PRECIOPROMN").Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = DET_DOCUMENTOBE.NRO_DOC_REF1 & "-" & cont
            If ELMVLOGSBE.log_codusu <> "0001" Then
                If IIf(IsDBNull(RTrim(row.Cells("CT").Value)), "", RTrim(row.Cells("CT").Value)) = "1" Then
                    'Los parametros que va recibir son las propiedades de la clase 
                    cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF
                    cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.SER_DOC_REF
                    cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF
                    cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
                    cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
                    cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                    cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CTCT_COD
                    cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                    cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
                    cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO
                    cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
                    cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_MOVINV)
                    cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                    cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                    cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                    cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT
                    cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.FOR_ENT_COD
                    cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
                    cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = GUIAALMACENBE.PROVEEDOR
                    cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CCO_COD
                    cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE
                    cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD
                    cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
                    'cmd.Parameters.Add("@fec_lleg", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_LLEG
                    cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                    cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC
                    cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ACT_COD
                    cmd.Parameters.Add("@ART_VENTA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_VENTA
                    cmd.Parameters.Add("@CANTIDAD2", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD2
                    cmd.Parameters.Add("@CANTIDAD4", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD4
                    cmd.Parameters.Add("@CANTIDAD5", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD5
                    cmd.Parameters.Add("@SUGERENCIA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SUGERENCIA
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ARTICULO_UPDATESTKSUM"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(GUIAALMACENBE.ALM_COD)
                    cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ARTICULO_UPDPRECIO"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ART_PRECIO", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD4)
                    cmd.Parameters.Add("@ART_CODIGO", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ELMVALMAANHO_INS"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
                    cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
                    cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
                    cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)
                    cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
                    cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                    cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                    cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                    cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                    cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                    cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_MOVINV
                    cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                    cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
                    cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                    cmd.Parameters.Add("@MOV_CCO_COD", OracleDbType.Varchar2).Value = "" 'DET_DOCUMENTOBE.CCO_COD
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If
            Else
                'Los parametros que va recibir son las propiedades de la clase 
                cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.SER_DOC_REF
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF
                cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
                cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
                cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CTCT_COD
                cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
                cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO
                cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
                cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_MOVINV)
                cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT
                cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.FOR_ENT_COD
                cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
                cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = GUIAALMACENBE.PROVEEDOR
                cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CCO_COD
                cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE
                cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD
                cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
                'cmd.Parameters.Add("@fec_lleg", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_LLEG
                cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC
                cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ACT_COD
                cmd.Parameters.Add("@ART_VENTA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_VENTA
                cmd.Parameters.Add("@CANTIDAD2", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD2
                cmd.Parameters.Add("@CANTIDAD4", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD4
                cmd.Parameters.Add("@CANTIDAD5", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD5
                cmd.Parameters.Add("@SUGERENCIA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SUGERENCIA
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ARTICULO_UPDATESTKSUM"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(GUIAALMACENBE.ALM_COD)
                cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ARTICULO_UPDPRECIO"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ART_PRECIO", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD4)
                cmd.Parameters.Add("@ART_CODIGO", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELMVALMAANHO_INS"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
                cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
                cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
                cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)
                cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
                cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_MOVINV
                cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
                cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                cmd.Parameters.Add("@MOV_CCO_COD", OracleDbType.Varchar2).Value = "" 'DET_DOCUMENTOBE.CCO_COD
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If


        Next
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Actualizo el Documento: " + GUIAALMACENBE.T_DOC_REF + "-" + GUIAALMACENBE.SER_DOC_REF + "-" + GUIAALMACENBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRowModSalida(ByVal GUIAALMACENBE As GUIAALMACENBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVALMABE As ELMVALMABE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal dg As DataGridView, ByVal scodcat As String, ByVal sEst As String)
        Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDATEROW_ALMNC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.Parameters.Add("part_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.ART_COD
        cmd.Parameters.Add("pfec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
        cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
        cmd.Parameters.Add("pmoneda", OracleDbType.Varchar2).Value = GUIAALMACENBE.MONEDA
        cmd.Parameters.Add("pfec_anu", OracleDbType.Date).Value = GUIAALMACENBE.FEC_ANU
        cmd.Parameters.Add("psigno", OracleDbType.Varchar2).Value = GUIAALMACENBE.SIGNO
        cmd.Parameters.Add("pusuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
        cmd.Parameters.Add("pobserva", OracleDbType.Char).Value = GUIAALMACENBE.OBSERVA
        cmd.Parameters.Add("pt_movinv", OracleDbType.Char).Value = "S23"
        cmd.Parameters.Add("pf_pago_ent", OracleDbType.Varchar2).Value = GUIAALMACENBE.F_PAGO_ENT
        cmd.Parameters.Add("pfor_ent_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.FOR_ENT_COD
        cmd.Parameters.Add("pcco_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD
        cmd.Parameters.Add("pproveedor", OracleDbType.Char).Value = Trim(GUIAALMACENBE.PROVEEDOR)
        cmd.Parameters.Add("pctct_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CTCT_COD
        cmd.Parameters.Add("pdir_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.DIR_COD
        cmd.Parameters.Add("per_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.PER_COD
        cmd.Parameters.Add("pfec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
        cmd.Parameters.Add("palmac", OracleDbType.Varchar2).Value = "S"
        cmd.Parameters.Add("px_m", OracleDbType.Varchar2).Value = GUIAALMACENBE.X_M
        cmd.Parameters.Add("codalm", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ALM_COD
        cmd.Parameters.Add("NOM_CTCT", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NOM_CTCT
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        'DEVOLUCION DE STOCK SIN IMPORTAR QUE MOVIMIENTO HAGA O ELIMINE
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ARTICULO_DVSTOCKALM"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@pT_DOC_REF", OracleDbType.Char).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("@pSER_DOC_REF", OracleDbType.Char).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("@pNRO_DOC_REF", OracleDbType.Char).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.Parameters.Add("pfec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCUMENTO_DEL_ALM"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@pT_DOC_REF", OracleDbType.Char).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("@pSER_DOC_REF", OracleDbType.Char).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("@pNRO_DOC_REF", OracleDbType.Char).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INSALM"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            DET_DOCUMENTOBE.T_DOC_REF1 = "REQ"
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SREQ").Value)), "", RTrim(row.Cells("SREQ").Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NREQ").Value)), "", RTrim(row.Cells("NREQ").Value))
            DET_DOCUMENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells("CTCT_COD").Value)), "", RTrim(row.Cells("CTCT_COD").Value))
            DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells("ACT_COD").Value)), "", RTrim(row.Cells("ACT_COD").Value))
            DET_DOCUMENTOBE.SIGNO = "+"
            DET_DOCUMENTOBE.OBSERVA = ""
            DET_DOCUMENTOBE.T_MOVINV = "S23"
            DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value))
            DET_DOCUMENTOBE.F_PAGO_ENT = ""
            DET_DOCUMENTOBE.FOR_ENT_COD = ""
            DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells("CCO_COD").Value)), "", RTrim(row.Cells("CCO_COD").Value))
            DET_DOCUMENTOBE.LOTE = ""
            DET_DOCUMENTOBE.EST = "H"
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells("ACT_COD").Value)), "", RTrim(row.Cells("ACT_COD").Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = DET_DOCUMENTOBE.NRO_DOC_REF1 & "-" & cont
            If ELMVLOGSBE.log_codusu <> "0001" Then
                If IIf(IsDBNull(RTrim(row.Cells("CT").Value)), "", RTrim(row.Cells("CT").Value)) <> "1" Then
                    'Los parametros que va recibir son las propiedades de la clase 
                    cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF
                    cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = "002"
                    cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF
                    cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
                    cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
                    cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                    cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CTCT_COD
                    cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                    cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
                    cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO
                    cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
                    cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = "S23"
                    cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                    cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                    cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                    cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT
                    cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.FOR_ENT_COD
                    cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
                    cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = GUIAALMACENBE.PROVEEDOR
                    cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CCO_COD
                    cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE
                    cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD
                    cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
                    'cmd.Parameters.Add("@fec_lleg", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_LLEG
                    cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                    cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = "S"
                    cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ACT_COD
                    cmd.Parameters.Add("@ART_VENTA", OracleDbType.Varchar2).Value = ""
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ARTICULO_UPDATESTKRES"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(GUIAALMACENBE.ALM_COD)
                    cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ELMVALMA2019_INS"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
                    cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = "002"
                    cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
                    cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = "S"
                    cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
                    cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                    cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                    cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                    cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                    cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                    cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = "S23"
                    cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                    cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
                    cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If
            Else
                'Los parametros que va recibir son las propiedades de la clase 
                cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = "002"
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF
                cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
                cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
                cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CTCT_COD
                cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
                cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO
                cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
                cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = "S23"
                cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT
                cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.FOR_ENT_COD
                cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
                cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = GUIAALMACENBE.PROVEEDOR
                cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CCO_COD
                cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE
                cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD
                cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
                'cmd.Parameters.Add("@fec_lleg", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_LLEG
                cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = "S"
                cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ACT_COD
                cmd.Parameters.Add("@ART_VENTA", OracleDbType.Varchar2).Value = ""
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ARTICULO_UPDATESTKRES"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(GUIAALMACENBE.ALM_COD)
                cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELMVALMA2019_INS"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
                cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = "002"
                cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
                cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = "S"
                cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
                cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
                cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = "S23"
                cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
                cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If

        Next
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Actualizo el Documento: " + GUIAALMACENBE.T_DOC_REF + "-" + GUIAALMACENBE.SER_DOC_REF + "-" + GUIAALMACENBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Function SaveRow(ByVal ELTBRECEPCOMPBE As ELTBRECEPCOMPBE, ByVal ELTBDETRECEPCOMPBE As ELTBDETRECEPCOMPBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
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
                InsertRow(ELTBRECEPCOMPBE, ELTBDETRECEPCOMPBE, ELMVLOGSBE, cn, sqlTrans, dg)
                'grabar acceso a los menues
            End If
            If flagAccion = "M" Then
                ''correlativo = LastCodigo()
                ''MonedaBE.mon_codigo = MonedaBE.mon_codigo
                UpdateRow(ELTBRECEPCOMPBE, ELTBDETRECEPCOMPBE, ELMVLOGSBE, cn, sqlTrans, dg)
                'grabar acceso a los menues
            End If
            If flagAccion = "AD" Then
                ''correlativo = LastCodigo()
                ''MonedaBE.mon_codigo = MonedaBE.mon_codigo
                UpdateRowAD(ELTBRECEPCOMPBE, ELTBDETRECEPCOMPBE, ELMVLOGSBE, cn, sqlTrans)
                'grabar acceso a los menues
            End If
            If flagAccion = "DD" Then
                ''correlativo = LastCodigo()
                ''MonedaBE.mon_codigo = MonedaBE.mon_codigo
                UpdateRowDD(ELTBRECEPCOMPBE, ELTBDETRECEPCOMPBE, ELMVLOGSBE, cn, sqlTrans)
                'grabar acceso a los menues
            End If
            If flagAccion = "ED" Then
                ''correlativo = LastCodigo()
                ''MonedaBE.mon_codigo = MonedaBE.mon_codigo
                UpdateRowED(ELTBRECEPCOMPBE, ELTBDETRECEPCOMPBE, ELMVLOGSBE, cn, sqlTrans)
                'grabar acceso a los menues
            End If
            If flagAccion = "AN" Then
                ''correlativo = LastCodigo()
                ''MonedaBE.mon_codigo = MonedaBE.mon_codigo
                UpdateRowAN(ELTBRECEPCOMPBE, ELTBDETRECEPCOMPBE, ELMVLOGSBE, cn, sqlTrans)
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
    Public Function SaveRowGuia(ByVal GUIAALMACENBE As GUIAALMACENBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVALMABE As ELMVALMABE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String,
                            ByVal dg As DataGridView, ByVal scodcat As String, ByVal sEst As String) As String
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

            If flagAccion = "CN" Then
                InsertRowNac(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat, sEst)
            End If
            If flagAccion = "CNR" Then
                InsertRowNacRecep(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat, sEst)
            End If
            If flagAccion = "CS" Then
                InsertRowNac1(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat, sEst)
            End If
            If flagAccion = "CM" Then
                UpdateRowMod(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat, sEst)
            End If
            If flagAccion = "CMR" Then
                UpdateRowModRecep(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat, sEst)
            End If
            If flagAccion = "CMS" Then
                UpdateRowModSalida(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat, sEst)
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
End Class
