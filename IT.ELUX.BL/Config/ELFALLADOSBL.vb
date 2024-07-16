Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELFALLADOSBL

    Private ELFALLADOSDAL As New ELFALLADOSDAL
    Public Function SelectActivos(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable

        Return ELFALLADOSDAL.SelectActivos(sFecAño, sFecMes)

    End Function
    Public Function SelectActivos1F(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return ELFALLADOSDAL.SelectActivos1F(sFecAño, sFecMes)
    End Function
    Public Function SelectActivos1(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable

        Return ELFALLADOSDAL.SelectActivos1(sFecAño, sFecMes)

    End Function

    Public Function SelectAll(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable

        Return ELFALLADOSDAL.SelectAll(sFecAño, sFecMes)

    End Function

    Public Function SelectAllAp(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable

        Return ELFALLADOSDAL.SelectAllAp(sFecAño, sFecMes)

    End Function

    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable

        Return ELFALLADOSDAL.SelectRow(sT_doc, sS_doc, sN_doc)

    End Function

    Public Function SelectRow1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable

        Return ELFALLADOSDAL.SelectRow1(sT_doc, sS_doc, sN_doc)

    End Function


    Public Function SelectNro(ByVal sCode As String, ByVal sSer As String) As Int32

        Return ELFALLADOSDAL.SelectNro(sCode, sSer)

    End Function

#Region "Grabar Datos"

    Public Function SaveRow(ByVal ELFALLADOSBE As ELFALLADOSBE, ByVal DETALLE_DOCUMENTOBE As DETALLE_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String,
                             ByVal scodcat As String) As String

        Return ELFALLADOSDAL.SaveRow(ELFALLADOSBE, DETALLE_DOCUMENTOBE, ELMVLOGSBE, flagAccion, scodcat)

    End Function

    Public Function SelectNrodia(ByVal sCode As String, ByVal Mes As String, ByVal dia As String) As String
        Return ELFALLADOSDAL.SelectNrodia(sCode, Mes, dia)
    End Function
#End Region
End Class
