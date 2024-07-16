Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBDETGUIABL
    Private ELTBDETGUIADAL As New ELTBDETGUIADAL

    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sART As String) As DataTable
        Return ELTBDETGUIADAL.SelectRow(sT_doc, sS_doc, sN_doc, sART)
    End Function
    Public Function SaveRow(ByVal ELTBDETGUIABE As ELTBDETGUIABE, ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Return ELTBDETGUIADAL.SaveRow(ELTBDETGUIABE, flagAccion, dg)
    End Function
    Public Function SelectDataFARDO(ByVal TDOC As String, ByVal SDOC As String, ByVal NDOC As String, ByVal ARTICULO As String) As String
        Return ELTBDETGUIADAL.SelectDataFARDO(TDOC, SDOC, NDOC, ARTICULO)
    End Function
    Public Function Ncont() As String
        Return ELTBDETGUIADAL.Ncont()
    End Function
End Class
