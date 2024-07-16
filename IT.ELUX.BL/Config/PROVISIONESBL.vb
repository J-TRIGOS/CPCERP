Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class PROVISIONESBL
    Private PROVISIONESDAL As New PROVISIONESDAL
    Public Function SelectBS_SS() As DataTable
        Return PROVISIONESDAL.SelectBS_SS()
    End Function
    Public Function Select_MON_row(ByVal sCod As String) As String
        Return PROVISIONESDAL.Select_MON_row(sCod)
    End Function
    Public Function SelectBS_SSrow(ByVal sCod As String) As String
        Return PROVISIONESDAL.SelectBS_SSrow(sCod)
    End Function
    Public Function SelectCTA_OPE(ByVal sFec As String, ByVal sCuenta As String) As String
        Return PROVISIONESDAL.SelectCTA_OPE(sFec, sCuenta)
    End Function
    Public Function list1(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
                         ByVal fec As Date)
        Return PROVISIONESDAL.list1(tdoc, sdoc, ndoc, fec)
    End Function

    Public Function list2(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
                         ByVal fec As Date)
        Return PROVISIONESDAL.list2(tdoc, sdoc, ndoc, fec)
    End Function

    Public Function list3(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
                         ByVal fec As Date)
        Return PROVISIONESDAL.list3(tdoc, sdoc, ndoc, fec)
    End Function

    Public Function list4(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
                         ByVal fec As Date)
        Return PROVISIONESDAL.list4(tdoc, sdoc, ndoc, fec)
    End Function
    Public Function list5(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String)
        Return PROVISIONESDAL.list5(tdoc, sdoc, ndoc)
    End Function
    Public Function list6(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
                         ByVal fec As Date)
        Return PROVISIONESDAL.list6(tdoc, sdoc, ndoc, fec)
    End Function
    Public Function list7(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String)
        Return PROVISIONESDAL.list7(tdoc, sdoc, ndoc)
    End Function
    Public Function list8(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
                         ByVal fec As Date)
        Return PROVISIONESDAL.list8(tdoc, sdoc, ndoc, fec)
    End Function
    Public Function list9(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String)
        Return PROVISIONESDAL.list9(tdoc, sdoc, ndoc)
    End Function
    Public Function list10(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
                         ByVal fec As Date)
        Return PROVISIONESDAL.list10(tdoc, sdoc, ndoc, fec)
    End Function
    Public Function SelectT_DOC_SEL(ByVal sCod As String) As String
        Return PROVISIONESDAL.SelectT_DOC_SEL(sCod)
    End Function
    Public Function SelectProvAll(ByVal sAÑO As String, ByVal sMes As String) As DataTable
        Return PROVISIONESDAL.SelectProvAll(sAÑO, sMes)
    End Function

    Public Function ActualizarCTCT(ByVal sAÑO As String) As DataTable
        Return PROVISIONESDAL.ActualizarCTCT(sAÑO)
    End Function
    Public Function SelectExpAll(ByVal sAÑO As String, ByVal sMes As String) As DataTable
        Return PROVISIONESDAL.SelectExpAll(sAÑO, sMes)
    End Function
    Public Function SelectCtaDif(ByVal sAÑO As String, ByVal sMes As String) As DataTable
        Return PROVISIONESDAL.SelectCtaDif(sAÑO, sMes)
    End Function
    Public Function SelectCtaRepetida(ByVal sCode As String, ByVal sAÑO As String) As DataTable
        Return PROVISIONESDAL.SelectCtaRepetida(sCode, sAÑO)
    End Function
    Public Function SelectRow(ByVal sCode As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sFec As String,
                               ByVal sCTCT As String) As DataTable
        Return PROVISIONESDAL.SelectRow(sCode, sS_doc, sN_doc, sFec, sCTCT)
    End Function
    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sFec As String,
                               ByVal sCTCT As String) As DataTable
        Return PROVISIONESDAL.getListdgv(sT_doc, sS_doc, sN_doc, sFec, sCTCT)
    End Function
    Public Function SelRowPeso(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String, ByVal sADoc As String) As Double
        Return PROVISIONESDAL.SelRowPeso(sTDoc, sSDoc, sNDoc, sADoc)
    End Function
    Public Function getListdgv1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal Num As String) As DataTable
        Return PROVISIONESDAL.getListdgv1(sT_doc, sS_doc, sN_doc, Num)
    End Function
    Public Function getListdgv2(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return PROVISIONESDAL.getListdgv2(sT_doc, sS_doc, sN_doc)
    End Function
    Public Function getListdgv3(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return PROVISIONESDAL.getListdgv3(sT_doc, sS_doc, sN_doc)
    End Function
    Public Function getListdgv4(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal num As String) As DataTable
        Return PROVISIONESDAL.getListdgv4(sT_doc, sS_doc, sN_doc, num)
    End Function
    Public Function getListdgv5(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal Num As String) As DataTable
        Return PROVISIONESDAL.getListdgv5(sT_doc, sS_doc, sN_doc, Num)
    End Function
    Public Function getListdgv6(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal Num As String) As DataTable
        Return PROVISIONESDAL.getListdgv6(sT_doc, sS_doc, sN_doc, Num)
    End Function
    Public Function SelectT_DOC() As DataTable
        Return PROVISIONESDAL.SelectT_DOC()
    End Function
    Public Function SelectT_DOC2() As DataTable
        Return PROVISIONESDAL.SelectT_DOC2()
    End Function
    Public Function SelectT_OPE(ByVal sFec As String) As DataTable
        Return PROVISIONESDAL.SelectT_OPE(sFec)
    End Function
    Public Function Select_MON() As DataTable
        Return PROVISIONESDAL.Select_MON()
    End Function
    Public Function SelectT_Prov(ByVal sCod As String) As String
        Return PROVISIONESDAL.SelectT_Prov(sCod)
    End Function
    Public Function Select_Fecha(ByVal sTip As String, ByVal sSer As String, ByVal sNro As String) As String
        Return PROVISIONESDAL.Select_Fecha(sTip, sSer, sNro)
    End Function
    Public Function SelectCuenta(ByVal sCod As String) As String
        Return PROVISIONESDAL.SelectCuenta(sCod)
    End Function
    Public Function SelectServ(ByVal sCod As String) As String
        Return PROVISIONESDAL.SelectServ(sCod)
    End Function
    Public Function SelectPorc(ByVal sCod As String) As Integer
        Return PROVISIONESDAL.SelectPorc(sCod)
    End Function
    Public Function SelectDescDetrac(ByVal sCod As String) As String
        Return PROVISIONESDAL.SelectDescDetrac(sCod)
    End Function
    Public Function SelectNomDetra(ByVal sCod As String) As String
        Return PROVISIONESDAL.SelectNomDetra(sCod)
    End Function
    Public Function SelectNomCta(ByVal sCod As String, ByVal syear As String) As String
        Return PROVISIONESDAL.SelectNomCta(sCod, syear)
    End Function
    Public Function Select_RegistroComp(ByVal sAño As String, ByVal sMes As String) As DataTable
        Return PROVISIONESDAL.Select_RegistroComp(sAño, sMes)
    End Function
    Public Function Select_RegistroNoDom(ByVal sAño As String, ByVal sMes As String) As DataTable
        Return PROVISIONESDAL.Select_RegistroNoDom(sAño, sMes)
    End Function
    Public Function SelectT_OPE_DETRA() As DataTable
        Return PROVISIONESDAL.SelectT_OPE_DETRA()
    End Function
    Public Function SelectELTBDETRA() As DataTable
        Return PROVISIONESDAL.SelectELTBDETRA()
    End Function
    Public Function SelectRegComAll(ByVal sAño As String) As DataTable
        Return PROVISIONESDAL.SelectRegComAll(sAño)
    End Function
    Public Function SelectRegNomDomAll(ByVal sAño As String) As DataTable
        Return PROVISIONESDAL.SelectRegNomDomAll(sAño)
    End Function
    Public Function getT_CAMB(ByVal fec As String) As DataTable
        Return PROVISIONESDAL.getT_CAMB(fec)
    End Function
    Public Function getT_CAMBvensbs(ByVal fec As String) As DataTable
        Return PROVISIONESDAL.getT_CAMBvensbs(fec)
    End Function
    Public Function AsientoPR(ByVal flagAccion As String, ByVal sAño As String, ByVal sMes As String, ByVal sNro As String, ByVal sSer As String, ByVal sTipo As String,
                              ByVal sUs As String, ByVal sProv As String, ByVal dg As DataGridView, ByVal flujo As String, ByVal caja As String) As String
        Return PROVISIONESDAL.AsientoPR(flagAccion, sAño, sMes, sNro, sSer, sTipo, sUs, sProv, dg, flujo, caja)
    End Function

    Public Function getListProvDet(ByVal sAño As String, ByVal sMes As String) As DataTable
        Return PROVISIONESDAL.getListProvDet(sAño, sMes)
    End Function

    Public Function SelectProvAllFiltro(ByVal saño As String, ByVal smes As String, ByVal tipo As String,
                                  ByVal serie As String, ByVal nro As String, ByVal reg_nro As String,
                                  ByVal ruc As String, ByVal saño1 As String, ByVal smes1 As String) As DataTable
        Return PROVISIONESDAL.SelectProvAllFiltro(saño, smes, tipo, serie, nro, reg_nro, ruc, saño1, smes1)
    End Function
#Region "Save"
    Public Function SaveRowAllMes(ByVal flagAccion As String, ByVal sAño As String, ByVal sMes As String, ByVal sUser As String, ByVal dg As DataGridView) As String
        Return PROVISIONESDAL.SaveRowAllMes(flagAccion, sAño, sMes, sUser, dg)
    End Function
    Public Function SaveRow(ByVal PROVISIONESBE As PROVISIONESBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE,
                               ByVal dg As DataGridView) As String
        Return PROVISIONESDAL.SaveRow(PROVISIONESBE, DET_DOCUMENTOBE, flagAccion, ELMVLOGSBE, dg)
    End Function
    Public Function SaveRLetra(ByVal PROVISIONESBE As PROVISIONESBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE,
                                ByVal dg As DataGridView) As String
        Return PROVISIONESDAL.SaveRLetra(PROVISIONESBE, DET_DOCUMENTOBE, flagAccion, ELMVLOGSBE, dg)
    End Function
#End Region

End Class
