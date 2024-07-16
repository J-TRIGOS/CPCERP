Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELREINGRESOBL
    Private ELREINGRESODAL As New ELREINGRESODAL
    Public Function SelectActivos(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return ELREINGRESODAL.SelectActivos(sFecAño, sFecMes)
    End Function

    Public Function SelectActivos1F(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return ELREINGRESODAL.SelectActivos1F(sFecAño, sFecMes)
    End Function

    Public Function SelectActivos1(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return ELREINGRESODAL.SelectActivos1(sFecAño, sFecMes)
    End Function

    Public Function SelectAll(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable

        Return ELREINGRESODAL.SelectAll(sFecAño, sFecMes)

    End Function

    Public Function SelectAllAp(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable

        Return ELREINGRESODAL.SelectAllAp(sFecAño, sFecMes)

    End Function

    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable

        Return ELREINGRESODAL.SelectRow(sT_doc, sS_doc, sN_doc)

    End Function

    Public Function SelectRow1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable

        Return ELREINGRESODAL.SelectRow1(sT_doc, sS_doc, sN_doc)

    End Function


    Public Function SelectNro(ByVal sCode As String, ByVal sSer As String) As Int32

        Return ELREINGRESODAL.SelectNro(sCode, sSer)

    End Function

#Region "Grabar Datos"

    Public Function SaveRow(ByVal ELREINGRESOBE As ELREINGRESOBE, ByVal DETALLE_DOCUMENTOBE As DETALLE_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String,
                             ByVal scodcat As String) As String

        Return ELREINGRESODAL.SaveRow(ELREINGRESOBE, DETALLE_DOCUMENTOBE, ELMVLOGSBE, flagAccion, scodcat)

    End Function

    Public Function SelectNrodia(ByVal sCode As String, ByVal Mes As String, ByVal dia As String) As String
        Return ELREINGRESODAL.SelectNrodia(sCode, Mes, dia)
    End Function
#End Region
End Class
