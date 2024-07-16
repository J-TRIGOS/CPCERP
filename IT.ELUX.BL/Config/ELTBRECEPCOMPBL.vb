Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBRECEPCOMPBL
    Private ELTBRECEPCOMPDAL As New ELTBRECEPCOMPDAL
    Public Function SelectNroArtVenta(ByVal sSer As String) As String
        Return ELTBRECEPCOMPDAL.SelectNroArtVenta(sSer)
    End Function

    Public Function list1(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String)
        Return ELTBRECEPCOMPDAL.list1(tdoc, sdoc, ndoc)
    End Function
    Public Function VerNum(ByVal sNRO_DOCU As String, ByVal sSER_DOCU As String, ByVal sPROVEEDOR As String) As String
        Return ELTBRECEPCOMPDAL.VerNum(sNRO_DOCU, sSER_DOCU, sPROVEEDOR)
    End Function
    Public Function NumReq(ByVal sNRO_DOCU As String, ByVal sSER_DOCU As String, ByVal sART_COD As String) As String
        Return ELTBRECEPCOMPDAL.NumReq(sNRO_DOCU, sSER_DOCU, sART_COD)
    End Function
    Public Function FecCreacion(ByVal sNRO_DOCU As String) As String
        Return ELTBRECEPCOMPDAL.FecCreacion(sNRO_DOCU)
    End Function
    Public Function SelObsReq(ByVal sSER_DOCU As String, ByVal sNRO_DOCU As String) As String
        Return ELTBRECEPCOMPDAL.SelObsReq(sSER_DOCU, sNRO_DOCU)
    End Function
    Public Function SelDetObsReq(ByVal sSER_DOCU As String, ByVal sNRO_DOCU As String, ByVal sART_COD As String) As String
        Return ELTBRECEPCOMPDAL.SelDetObsReq(sSER_DOCU, sNRO_DOCU, sART_COD)
    End Function
    Public Function SelReqOreq(ByVal sSER_DOCU As String, ByVal sNRO_DOCU As String, ByVal sART_COD As String) As String
        Return ELTBRECEPCOMPDAL.SelReqOreq(sSER_DOCU, sNRO_DOCU, sART_COD)
    End Function
    Public Function getListdgv1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBRECEPCOMPDAL.getListdgv1(sT_doc, sS_doc, sN_doc)
    End Function
    Public Function SelectAll(ByVal sFec As String) As DataTable
        Return ELTBRECEPCOMPDAL.SelectAll(sFec)
    End Function
    Public Function SelectNro1(ByVal COD As String) As Int32
        Return ELTBRECEPCOMPDAL.SelectNro1(COD)
    End Function
    Public Function SelectRow(ByVal sCode As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBRECEPCOMPDAL.SelectRow(sCode, sS_doc, sN_doc)
    End Function
    Public Function SelectRow2(ByVal sCode As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sArt As String) As DataTable
        Return ELTBRECEPCOMPDAL.SelectRow2(sCode, sS_doc, sN_doc, sArt)
    End Function
    Public Function SelectTipArt(ByVal sArt As String) As DataTable
        Return ELTBRECEPCOMPDAL.SelectTipArt(sArt)
    End Function
    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBRECEPCOMPDAL.getListdgv(sT_doc, sS_doc, sN_doc)
    End Function
    Public Function SelectActivos1(ByVal sFec As String) As DataTable
        Return ELTBRECEPCOMPDAL.SelectActivos1(sFec)
    End Function
    Public Function SelectActivos2(ByVal sFec As String) As DataTable
        Return ELTBRECEPCOMPDAL.SelectActivos2(sFec)
    End Function
    Public Function SaveRow(ByVal ELTBRECEPCOMPBE As ELTBRECEPCOMPBE, ByVal ELTBDETRECEPCOMPBE As ELTBDETRECEPCOMPBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Return ELTBRECEPCOMPDAL.SaveRow(ELTBRECEPCOMPBE, ELTBDETRECEPCOMPBE, ELMVLOGSBE, flagAccion, dg)
    End Function
    Public Function SaveRowGuia(ByVal GUIAALMACENBE As GUIAALMACENBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVALMABE As ELMVALMABE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String,
                           ByVal dg As DataGridView, ByVal scodcat As String, ByVal sEst As String) As String

        Return ELTBRECEPCOMPDAL.SaveRowGuia(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, flagAccion, dg, scodcat, sEst)

    End Function
End Class
