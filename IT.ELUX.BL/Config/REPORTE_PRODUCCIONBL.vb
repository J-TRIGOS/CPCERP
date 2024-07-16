Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class REPORTE_PRODUCCIONBL

    Private REPORTE_PRODUCCIONDAL As New REPORTE_PRODUCCIONDAL
    Public Function SelectActivos(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable

        Return REPORTE_PRODUCCIONDAL.SelectActivos(sFecAño, sFecMes)

    End Function
    Public Function SelectActivos1F(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return REPORTE_PRODUCCIONDAL.SelectActivos1F(sFecAño, sFecMes)
    End Function
    Public Function SelectActivos1R(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return REPORTE_PRODUCCIONDAL.SelectActivos1R(sFecAño, sFecMes)
    End Function
    Public Function SelectActivos1(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable

        Return REPORTE_PRODUCCIONDAL.SelectActivos1(sFecAño, sFecMes)

    End Function

    Public Function SelectAll(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable

        Return REPORTE_PRODUCCIONDAL.SelectAll(sFecAño, sFecMes)

    End Function

    Public Function SelectAllAp(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable

        Return REPORTE_PRODUCCIONDAL.SelectAllAp(sFecAño, sFecMes)

    End Function

    Public Function SelectAllFal(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return REPORTE_PRODUCCIONDAL.SelectAllFal(sFecAño, sFecMes)
    End Function

    Public Function SelectAllRein(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return REPORTE_PRODUCCIONDAL.SelectAllRein(sFecAño, sFecMes)
    End Function

    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable

        Return REPORTE_PRODUCCIONDAL.SelectRow(sT_doc, sS_doc, sN_doc)

    End Function

    Public Function SelectRow1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable

        Return REPORTE_PRODUCCIONDAL.SelectRow1(sT_doc, sS_doc, sN_doc)

    End Function


    Public Function SelectNro(ByVal sCode As String, ByVal sSer As String) As Int32

        Return REPORTE_PRODUCCIONDAL.SelectNro(sCode, sSer)

    End Function

#Region "Grabar Datos"

    Public Function SaveRow(ByVal REPORTE_PRODUCCIONBE As REPORTE_PRODUCCIONBE, ByVal DETALLE_DOCUMENTOBE As DETALLE_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String,
                             ByVal scodcat As String) As String
        Return REPORTE_PRODUCCIONDAL.SaveRow(REPORTE_PRODUCCIONBE, DETALLE_DOCUMENTOBE, ELMVLOGSBE, flagAccion, scodcat)
    End Function

    Public Function SaveRow1(ByVal sTDOC As String, ByVal sSDOC As String, ByVal sNDOC As String) As String
        Return REPORTE_PRODUCCIONDAL.SaveRow1(sTDOC, sSDOC, sNDOC)
    End Function

    Public Function SelectNrodia(ByVal sCode As String, ByVal Mes As String, ByVal dia As String) As String
        Return REPORTE_PRODUCCIONDAL.SelectNrodia(sCode, Mes, dia)
    End Function
#End Region
End Class
