Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBEVALUACIONBL
    Private ELTBEVALUACIONDAL As New ELTBEVALUACIONDAL
    Public Function SelectNro(ByVal sCode As String, ByVal sSer As String) As Int32
        Return ELTBEVALUACIONDAL.SelectNro(sCode, sSer)
    End Function
    Public Function SelectNroDni(ByVal sCod As String) As String
        Return ELTBEVALUACIONDAL.SelectNroDni(sCod)
    End Function
    Public Function list1(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String, ByVal sProv As String)
        Return ELTBEVALUACIONDAL.list1(tdoc, sdoc, ndoc, sProv)
    End Function
    Public Function getListdgv1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sCOD As String) As DataTable
        Return ELTBEVALUACIONDAL.getListdgv1(sT_doc, sS_doc, sN_doc, sCOD)
    End Function
    Public Function SaveRow(ByVal ELTBEVALUACIONBE As ELTBEVALUACIONBE, ByVal flagAccion As String,
                        ByVal dg As DataGridView) As String
        Return ELTBEVALUACIONDAL.SaveRow(ELTBEVALUACIONBE, flagAccion, dg)
    End Function
    Public Function SelectAll(ByVal Anho As String, ByVal Mes As String) As DataTable
        Return ELTBEVALUACIONDAL.SelectAll(Anho, Mes)
    End Function
    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBEVALUACIONDAL.SelectRow(sT_doc, sS_doc, sN_doc)
    End Function
    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBEVALUACIONDAL.getListdgv(sT_doc, sS_doc, sN_doc)
    End Function
End Class
