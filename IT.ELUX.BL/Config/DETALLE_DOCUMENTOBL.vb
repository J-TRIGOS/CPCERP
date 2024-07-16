Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class DETALLE_DOCUMENTOBL
    Private DETALLE_DOCUMENTODAL As New DETALLE_DOCUMENTODAL
    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sA_cod As String) As DataTable

        Return DETALLE_DOCUMENTODAL.SelectRow(sT_doc, sS_doc, sN_doc, sA_cod)

    End Function
End Class
