Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBDETRACCIONBL
    Private ELTBDETRACCIONDAL As New ELTBDETRACCIONDAL
    Public Function SelectRow(ByVal sCode As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBDETRACCIONDAL.SelectRow(sCode, sS_doc, sN_doc)
    End Function
    Public Function SelectAll(ByVal sCode As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Return ELTBDETRACCIONDAL.SelectAll(sCode, sAño, sMes)
    End Function
    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBDETRACCIONDAL.getListdgv(sT_doc, sS_doc, sN_doc)
    End Function
    Public Function list1(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String, ByVal sProv As String)
        Return ELTBDETRACCIONDAL.list1(tdoc, sdoc, ndoc, sProv)
    End Function
    Public Function getListdgv1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sCOD As String) As DataTable
        Return ELTBDETRACCIONDAL.getListdgv1(sT_doc, sS_doc, sN_doc, sCOD)
    End Function
    Public Function SelectNro(ByVal sCode As String, ByVal sSer As String) As Int32
        Return ELTBDETRACCIONDAL.SelectNro(sCode, sSer)
    End Function
    Public Function getTxtDet(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As String
        Return ELTBDETRACCIONDAL.getTxtDet(sT_doc, sS_doc, sN_doc)
    End Function
    Public Function getTxtDet1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As String
        Return ELTBDETRACCIONDAL.getTxtDet1(sT_doc, sS_doc, sN_doc)
    End Function
    Public Function SaveRow(ByVal ELTBDETRACCIONBE As ELTBDETRACCIONBE, ByVal ELTBDETDETRACCIONBE As ELTBDETDETRACCIONBE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE,
                               ByVal dg As DataGridView) As String
        Return ELTBDETRACCIONDAL.SaveRow(ELTBDETRACCIONBE, ELTBDETDETRACCIONBE, flagAccion, ELMVLOGSBE, dg)
    End Function
End Class
