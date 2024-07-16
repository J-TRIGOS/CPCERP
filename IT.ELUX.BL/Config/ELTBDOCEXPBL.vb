Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBDOCEXPBL
    Private ELTBDOCEXPDAL As New ELTBDOCEXPDAL
    Public Function SelectRow(ByVal sCode As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sFec As String,
                              ByVal sCTCT As String) As DataTable
        Return ELTBDOCEXPDAL.SelectRow(sCode, sS_doc, sN_doc, sFec, sCTCT)
    End Function
    Public Function Select_Nomconv(ByVal sCod As String) As String
        Return ELTBDOCEXPDAL.Select_Nomconv(sCod)
    End Function
    Public Function SelPais() As DataTable
        Return ELTBDOCEXPDAL.SelPais()
    End Function

    Public Function SelConv() As DataTable
        Return ELTBDOCEXPDAL.SelConv()
    End Function

    Public Function SaveRow(ByVal ELTBDOCEXPBE As ELTBDOCEXPBE, ByVal ELTBDETDOCEXPBE As ELTBDETDOCEXPBE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE,
                               ByVal dg As DataGridView) As String
        Return ELTBDOCEXPDAL.SaveRow(ELTBDOCEXPBE, ELTBDETDOCEXPBE, flagAccion, ELMVLOGSBE, dg)
    End Function
    Public Function AsientoPR(ByVal flagAccion As String, ByVal sAño As String, ByVal sMes As String, ByVal sNro As String, ByVal sSer As String, ByVal sTipo As String,
                              ByVal sUs As String, ByVal sProv As String, ByVal dg As DataGridView, ByVal flujo As String, ByVal caja As String) As String
        Return ELTBDOCEXPDAL.AsientoPR(flagAccion, sAño, sMes, sNro, sSer, sTipo, sUs, sProv, dg, flujo, caja)
    End Function

    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sFec As String,
                               ByVal sCTCT As String) As DataTable
        Return ELTBDOCEXPDAL.getListdgv(sT_doc, sS_doc, sN_doc, sFec, sCTCT)
    End Function
    Public Function getListdgv3(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBDOCEXPDAL.getListdgv3(sT_doc, sS_doc, sN_doc)
    End Function
    Public Function SaveRowAllMes(ByVal flagAccion As String, ByVal sAño As String, ByVal sMes As String, ByVal sUser As String, ByVal dg As DataGridView) As String
        Return ELTBDOCEXPDAL.SaveRowAllMes(flagAccion, sAño, sMes, sUser, dg)
    End Function
End Class
