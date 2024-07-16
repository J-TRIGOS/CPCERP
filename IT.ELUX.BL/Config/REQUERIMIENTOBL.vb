Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class REQUERIMIENTOBL
    Private REQUERIMIENTODAL As New REQUERIMIENTODAL

#Region "Lectura de Datos"

#Region "SQL"

    Public Function SelectAll(ByVal sT_doc As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Return REQUERIMIENTODAL.SelectAll(sT_doc, sAño, sMes)
    End Function

    Public Function SelectOreqReq(ByVal sT_doc As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Return REQUERIMIENTODAL.SelectOreqReq(sT_doc, sAño, sMes)
    End Function

    Public Function SelectOreqReq1(ByVal sT_doc As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Return REQUERIMIENTODAL.SelectOreqReq1(sT_doc, sAño, sMes)
    End Function

    Public Function SelectAllPendiente() As DataTable
        Return REQUERIMIENTODAL.SelectAllPendiente()
    End Function
    Public Function SelectAllPendiente1(ByVal anho As String, ByVal mes As String) As DataTable
        Return REQUERIMIENTODAL.SelectAllPendiente1(anho, mes)
    End Function

    Public Function SelectAllOP(ByVal anho As String, ByVal mes As String) As DataTable
        Return REQUERIMIENTODAL.SelectAllOP(anho, mes)
    End Function

    Public Function SelectAllReqA() As DataTable
        Return REQUERIMIENTODAL.SelectAllReqA()
    End Function

    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return REQUERIMIENTODAL.SelectRow(sT_doc, sS_doc, sN_doc)
    End Function

    Public Function sReqAprob(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sART_COD As String,
                              ByVal sT_doc1 As String, ByVal sS_doc1 As String, ByVal sN_doc1 As String, ByVal sProv As String) As String
        Return REQUERIMIENTODAL.sReqAprob(sT_doc, sS_doc, sN_doc, sART_COD, sT_doc1, sS_doc1, sN_doc1, sProv)
    End Function

    Public Function SelectT_DOC(ByVal sCod As String) As DataTable
        Return REQUERIMIENTODAL.SelectT_DOC(sCod)
    End Function

    Public Function SelectT_MOVINV(ByVal sCod As String) As DataTable
        Return REQUERIMIENTODAL.SelectT_MOVINV(sCod)
    End Function

    Public Function SelectT_MOVINV2(ByVal sCod As String) As DataTable
        Return REQUERIMIENTODAL.SelectT_MOVINV2(sCod)
    End Function

    Public Function T_camb(ByVal sFec As String) As DataTable
        Return REQUERIMIENTODAL.T_camb(sFec)
    End Function

    Public Function SelectF_PAGO() As DataTable
        Return REQUERIMIENTODAL.SelectF_PAGO()
    End Function

    Public Function SelectF_ENT() As DataTable
        Return REQUERIMIENTODAL.SelectF_ENT()
    End Function

    Public Function SelectMoneda() As DataTable
        Return REQUERIMIENTODAL.SelectMoneda()
    End Function

    Public Function SelectCCosto() As DataTable
        Return REQUERIMIENTODAL.SelectCCosto()
    End Function

    Public Function SelectProv() As DataTable
        Return REQUERIMIENTODAL.SelectProv()
    End Function

    Public Function SelectPer() As DataTable
        Return REQUERIMIENTODAL.SelectPer()
    End Function

    Public Function SelectPerUsu() As DataTable
        Return REQUERIMIENTODAL.SelectPerUsu()
    End Function

    Public Function SelectVend() As DataTable
        Return REQUERIMIENTODAL.SelectVend()
    End Function

    Public Function SelectAct() As DataTable
        Return REQUERIMIENTODAL.SelectAct()
    End Function

    Public Function SelectDir(ByVal sCod As String) As DataTable
        Return REQUERIMIENTODAL.SelectDir(sCod)
    End Function

    Public Function SelectAlmac(ByVal sCod As String) As DataTable
        Return REQUERIMIENTODAL.SelectAlmac(sCod)
    End Function

    Public Function SelectNomColumn(ByVal sNom As String) As DataTable
        Return REQUERIMIENTODAL.SelectNomColumn(sNom)
    End Function

    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return REQUERIMIENTODAL.getListdgv(sT_doc, sS_doc, sN_doc)
    End Function

    Public Function getT_CAMB(ByVal fec As String) As DataTable
        Return REQUERIMIENTODAL.getT_CAMB(fec)
    End Function

    Public Function getT_CAMB1(ByVal fec As String) As DataTable
        Return REQUERIMIENTODAL.getT_CAMB1(fec)
    End Function

    Public Function getCodArt(ByVal texto_a_buscar As String, ByVal op As Int16) As DataTable
        Return REQUERIMIENTODAL.getCodArt(texto_a_buscar, op)
    End Function

    Public Function SelectNro(ByVal sCode As String, ByVal sSer As String) As Int32
        Return REQUERIMIENTODAL.SelectNro(sCode, sSer)
    End Function

    Public Function SelectNro1(ByVal sCode As String, ByVal sSer As String) As Int32
        Return REQUERIMIENTODAL.SelectNro1(sCode, sSer)
    End Function
    Public Function SelectNro2(ByVal sCode As String, ByVal sSer As String) As Int32
        Return REQUERIMIENTODAL.SelectNro2(sCode, sSer)
    End Function
    Public Function SelectFamilia() As DataTable
        Return REQUERIMIENTODAL.SelectFamilia()
    End Function

    Public Function SelectComAllFiltro(ByVal saño As String, ByVal smes As String, ByVal serie As String,
                                       ByVal nro As String, ByVal ruc As String, ByVal art As String) As DataTable
        Return REQUERIMIENTODAL.SelectComAllFiltro(saño, smes, serie, nro, ruc, art)
    End Function
#End Region

#End Region

#Region "Grabar Datos"

    Public Function SaveRow(ByVal REQUERIMIENTOBE As REQUERIMIENTOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal flagAccion As String,
                            ByVal dg As DataGridView, ByVal scodcat As String) As String
        Return REQUERIMIENTODAL.SaveRow(REQUERIMIENTOBE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, dg, scodcat)
    End Function

    Public Function aprobarOrdComp(ByVal estado As String, ByVal tipo As String, ByVal serie As String, ByVal nro As String)
        Return REQUERIMIENTODAL.aprobarOrdComp(estado, tipo, serie, nro)
    End Function

    Public Function aprobarOrdProd(ByVal estado As String, ByVal tipo As String, ByVal serie As String, ByVal nro As String)
        Return REQUERIMIENTODAL.aprobarOrdProd(estado, tipo, serie, nro)
    End Function
#End Region
End Class
