Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBPERCEPBL
    Private ELTBPERCEPDAL As New ELTBPERCEPDAL
    Public Function SelectAll(ByVal anho As String, ByVal smes As String) As DataTable
        Return ELTBPERCEPDAL.SelectAll(anho, smes)
    End Function
    Public Function SelectNro(ByVal sAnho As String) As String
        Return ELTBPERCEPDAL.SelectNro(sAnho)
    End Function

    Public Function getTxtFc(ByVal anho As String, ByVal smes As String) As String
        Return ELTBPERCEPDAL.getTxtFc(anho, smes)
    End Function

    Public Function SelectRow(ByVal sN_doc As String) As DataTable
        Return ELTBPERCEPDAL.SelectRow(sN_doc)
    End Function
    Public Function SelectRow1(ByVal sN_doc As String) As DataTable
        Return ELTBPERCEPDAL.SelectRow1(sN_doc)
    End Function
    Public Function SaveRow(ByVal ELTBPERCEPBE As ELTBPERCEPBE, ByVal ELTBDETPERCEPBE As ELTBDETPERCEPBE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE,
                              ByVal dg As DataGridView) As String
        Return ELTBPERCEPDAL.SaveRow(ELTBPERCEPBE, ELTBDETPERCEPBE, flagAccion, ELMVLOGSBE, dg)
    End Function
End Class
