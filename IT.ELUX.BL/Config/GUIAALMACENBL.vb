Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class GUIAALMACENBL
    Private GUIAALMACENDAL As New GUIAALMACENDAL
#Region "Lectura de Datos"

#Region "SQL"

    Public Function SelectAll(ByVal sT_doc As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Return GUIAALMACENDAL.SelectAll(sT_doc, sAño, sMes)
    End Function

    Public Function SelectT_MEDIDA() As DataTable
        Return GUIAALMACENDAL.SelectT_MEDIDA()
    End Function
    Public Function SelectAlmac(ByVal sCod As String) As DataTable
        Return GUIAALMACENDAL.SelectAlmac(sCod)
    End Function

    Public Function SelectAllReq(ByVal sAño As String, ByVal sMes As String) As DataTable
        Return GUIAALMACENDAL.SelectAllReq(sAño, sMes)
    End Function

    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return GUIAALMACENDAL.SelectRow(sT_doc, sS_doc, sN_doc)
    End Function

    Public Function SelectRow2(ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return GUIAALMACENDAL.SelectRow2(sS_doc, sN_doc)
    End Function

    Public Function SelectAlm(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As String
        Return GUIAALMACENDAL.SelectAlm(sTdoc, sSdoc, sNdoc)
    End Function

    Public Function SelectObs(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As String
        Return GUIAALMACENDAL.SelectObs(sTdoc, sSdoc, sNdoc)
    End Function

    Public Function SelectMOVINV(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As String
        Return GUIAALMACENDAL.SelectMOVINV(sTdoc, sSdoc, sNdoc)
    End Function

    Public Function SelectDni(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As String
        Return GUIAALMACENDAL.SelectDni(sTdoc, sSdoc, sNdoc)
    End Function

    Public Function SelectProv(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As String
        Return GUIAALMACENDAL.SelectProv(sTdoc, sSdoc, sNdoc)
    End Function

    Public Function SelectFor_ent(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As String
        Return GUIAALMACENDAL.SelectFor_ent(sTdoc, sSdoc, sNdoc)
    End Function

    Public Function SelectNUMPEDIDO(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As String
        Return GUIAALMACENDAL.SelectNUMPEDIDO(sTdoc, sSdoc, sNdoc)
    End Function

    Public Function SelectTotal(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As Double
        Return GUIAALMACENDAL.SelectTotal(sTdoc, sSdoc, sNdoc)
    End Function

    Public Function SelectF_PAGO(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As String
        Return GUIAALMACENDAL.SelectF_PAGO(sTdoc, sSdoc, sNdoc)
    End Function

    Public Function SelectMONEDA(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As String
        Return GUIAALMACENDAL.SelectMONEDA(sTdoc, sSdoc, sNdoc)
    End Function

    Public Function SelectT_MOVINV(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As String
        Return GUIAALMACENDAL.SelectT_MOVINV(sTdoc, sSdoc, sNdoc)
    End Function

    Public Function SelectT_DOC(ByVal sCod As String) As DataTable
        Return GUIAALMACENDAL.SelectT_DOC(sCod)
    End Function

    Public Function SelectT_DOC1() As DataTable
        Return GUIAALMACENDAL.SelectT_DOC1()
    End Function

    Public Function SelectT_MOVINV(ByVal sCod As String) As DataTable
        Return GUIAALMACENDAL.SelectT_MOVINV(sCod)
    End Function

    Public Function SelectF_PAGO() As DataTable
        Return GUIAALMACENDAL.SelectF_PAGO()
    End Function

    Public Function SelectF_ENT() As DataTable
        Return GUIAALMACENDAL.SelectF_ENT()
    End Function

    Public Function SelectMoneda() As DataTable
        Return GUIAALMACENDAL.SelectMoneda()
    End Function

    Public Function SelectCCosto() As DataTable
        Return GUIAALMACENDAL.SelectCCosto()
    End Function

    Public Function SelectCCosto1() As DataTable
        Return GUIAALMACENDAL.SelectCCosto1()
    End Function

    Public Function SelectPer() As DataTable
        Return GUIAALMACENDAL.SelectPer()
    End Function

    Public Function SelectProv() As DataTable
        Return GUIAALMACENDAL.SelectProv()
    End Function

    Public Function SelectDir(ByVal sCod As String) As DataTable
        Return GUIAALMACENDAL.SelectDir(sCod)
    End Function

    Public Function SelectNomColumn(ByVal sNom As String) As DataTable
        Return GUIAALMACENDAL.SelectNomColumn(sNom)
    End Function

    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return GUIAALMACENDAL.getListdgv(sT_doc, sS_doc, sN_doc)
    End Function

    Public Function getListdgv3(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sLinea As String) As DataTable
        Return GUIAALMACENDAL.getListdgv3(sT_doc, sS_doc, sN_doc, sLinea)
    End Function

    Public Function getListdgv4(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return GUIAALMACENDAL.getListdgv4(sT_doc, sS_doc, sN_doc)
    End Function

    Public Function getListdgv5(ByVal sS_doc As String, ByVal sN_doc As String, ByVal sCod As String) As DataTable
        Return GUIAALMACENDAL.getListdgv5(sS_doc, sN_doc, sCod)
    End Function

    Public Function getListdgv2(ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return GUIAALMACENDAL.getListdgv2(sS_doc, sN_doc)
    End Function

    Public Function getListdgv1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sEst As String) As DataTable
        Return GUIAALMACENDAL.getListdgv1(sT_doc, sS_doc, sN_doc, sEst)
    End Function

    Public Function getListdgv6(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return GUIAALMACENDAL.getListdgv6(sT_doc, sS_doc, sN_doc)
    End Function

    Public Function getListdatos(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return GUIAALMACENDAL.getListdatos(sT_doc, sS_doc, sN_doc)
    End Function

    Public Function getCodArt(ByVal texto_a_buscar As String, ByVal op As Int16) As DataTable
        Return GUIAALMACENDAL.getCodArt(texto_a_buscar, op)
    End Function

    Public Function list(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
                         ByVal fec As Date)
        Return GUIAALMACENDAL.list(tdoc, sdoc, ndoc, fec)
    End Function

    Public Function list1(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String)
        Return GUIAALMACENDAL.list1(tdoc, sdoc, ndoc)
    End Function

    Public Function list2(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String)
        Return GUIAALMACENDAL.list2(tdoc, sdoc, ndoc)
    End Function

    Public Function list4(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String)
        Return GUIAALMACENDAL.list4(tdoc, sdoc, ndoc)
    End Function

    Public Function list8(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
               ByVal fec As Date, ByVal scco As String)
        Return GUIAALMACENDAL.list8(tdoc, sdoc, ndoc, fec, scco)
    End Function
    Public Function list9(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
               ByVal fec As Date, ByVal scco As String)
        Return GUIAALMACENDAL.list9(tdoc, sdoc, ndoc, fec, scco)
    End Function

    Public Function list10(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
               ByVal fec As Date, ByVal scco As String)
        Return GUIAALMACENDAL.list10(tdoc, sdoc, ndoc, fec, scco)
    End Function

    Public Function listreq(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String, ByVal ART As String)
        Return GUIAALMACENDAL.listReq(tdoc, sdoc, ndoc, ART)
    End Function

    Public Function list5(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
                         ByVal fec As Date)
        Return GUIAALMACENDAL.list5(tdoc, sdoc, ndoc, fec)
    End Function

    Public Function list7(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
                         ByVal fec As Date)
        Return GUIAALMACENDAL.list7(tdoc, sdoc, ndoc, fec)
    End Function

    Public Function list6(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String)
        Return GUIAALMACENDAL.list6(tdoc, sdoc, ndoc)
    End Function

    Public Function list3(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
                         ByVal fec As Date)
        Return GUIAALMACENDAL.list3(tdoc, sdoc, ndoc, fec)
    End Function

    Public Function SelectAñoMes(ByVal tdoc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return GUIAALMACENDAL.SelectAñoMes(tdoc, sS_doc, sN_doc)
    End Function

    Public Function SelectDatosCOD(ByVal tipo As String, ByVal serie As String, ByVal nro As String) As DataTable
        Return GUIAALMACENDAL.SelectDatosCOD(tipo, serie, nro)
    End Function
    'Public Function ListDt(ByVal sql As String) As DataTable

    '    Return ELTBUSERDAL.ListDt(sql)

    'End Function

#End Region

#End Region

#Region "Grabar Datos"


    Public Function SaveRow(ByVal GUIAALMACENBE As GUIAALMACENBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVALMABE As ELMVALMABE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String,
                            ByVal dg As DataGridView, ByVal scodcat As String, ByVal sEst As String) As String

        Return GUIAALMACENDAL.SaveRow(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, flagAccion, dg, scodcat, sEst)

    End Function

#End Region


    Public Function VerificarCierre(ByVal modulo As String, ByVal mesCierre As String, ByVal anhoCierre As String) As DataTable
        Return GUIAALMACENDAL.VerificarCierre(modulo, mesCierre, anhoCierre)
    End Function

End Class
