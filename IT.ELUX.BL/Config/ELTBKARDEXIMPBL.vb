Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBKARDEXIMPBL
    Private ELTBKARDEXIMPDAL As New ELTBKARDEXIMPDAL
    Public Function list2(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
                        ByVal fec As Date)
        Return ELTBKARDEXIMPDAL.list2(tdoc, sdoc, ndoc, fec)
    End Function


    Public Function SelectAll(ByVal sCode As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Return ELTBKARDEXIMPDAL.SelectAll(sCode, sAño, sMes)
    End Function

    Public Function list(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String)
        Return ELTBKARDEXIMPDAL.list(tdoc, sdoc, ndoc)
    End Function
    Public Function listnodom(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String)
        Return ELTBKARDEXIMPDAL.listnodom(tdoc, sdoc, ndoc)
    End Function
    Public Function list3(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String)
        Return ELTBKARDEXIMPDAL.list3(tdoc, sdoc, ndoc)
    End Function
    Public Function getListdgv1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBKARDEXIMPDAL.getListdgv1(sT_doc, sS_doc, sN_doc)
    End Function

    Public Function SelectMoneda() As DataTable
        Return ELTBKARDEXIMPDAL.SelectMoneda()
    End Function

    Public Function getListdgv2(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sOP As String) As DataTable
        Return ELTBKARDEXIMPDAL.getListdgv2(sT_doc, sS_doc, sN_doc, sOP)
    End Function

    Public Function getListdgv4(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBKARDEXIMPDAL.getListdgv4(sT_doc, sS_doc, sN_doc)
    End Function

    Public Function LastCodigo(ByVal sS_doc As String) As String
        Return ELTBKARDEXIMPDAL.LastCodigo(sS_doc)
    End Function

    Public Function SelectRow(ByVal sCode As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBKARDEXIMPDAL.SelectRow(sCode, sS_doc, sN_doc)
    End Function

    Public Function SelectRowdET(ByVal sCode As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBKARDEXIMPDAL.SelectRowdET(sCode, sS_doc, sN_doc)
    End Function
    Public Function SelectRowCost(ByVal sCode As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBKARDEXIMPDAL.SelectRowCost(sCode, sS_doc, sN_doc)
    End Function
    Public Function SelectT_Prov(ByVal sCod As String) As String
        Return ELTBKARDEXIMPDAL.SelectT_Prov(sCod)
    End Function

    Public Function SelRowDatosAncho(ByVal sCod As String) As Double
        Return ELTBKARDEXIMPDAL.SelRowDatosAncho(sCod)
    End Function

    Public Function SelRowDatosLar(ByVal sCod As String) As Double
        Return ELTBKARDEXIMPDAL.SelRowDatosLar(sCod)
    End Function

    Public Function SelRowDatosdATO(ByVal sCod As String) As Double
        Return ELTBKARDEXIMPDAL.SelRowDatosdATO(sCod)
    End Function

    Public Function SelRowPeso(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String, ByVal sADoc As String, ByVal sNDoc1 As String) As Double
        Return ELTBKARDEXIMPDAL.SelRowPeso(sTDoc, sSDoc, sNDoc, sADoc, sNDoc1)
    End Function

    Public Function SelRowPesoNOMDOM(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String, ByVal sADoc As String, ByVal sNDoc1 As String) As Double
        Return ELTBKARDEXIMPDAL.SelRowPesoNOMDOM(sTDoc, sSDoc, sNDoc, sADoc, sNDoc1)
    End Function

    Public Function SaveRow(ByVal ELTBKARDEXIMPBE As ELTBKARDEXIMPBE, ByVal ELTBDETKARDEXIMPBE As ELTBDETKARDEXIMPBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Return ELTBKARDEXIMPDAL.SaveRow(ELTBKARDEXIMPBE, ELTBDETKARDEXIMPBE, ELMVLOGSBE, flagAccion, dg)
    End Function

    Public Function SaveRowCos(ByVal ELTBKARDEXIMPCOSBE As ELTBKARDEXIMPCOSBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Return ELTBKARDEXIMPDAL.SaveRowCos(ELTBKARDEXIMPCOSBE, ELMVLOGSBE, flagAccion, dg)
    End Function

End Class
