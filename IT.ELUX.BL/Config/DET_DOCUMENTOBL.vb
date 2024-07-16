Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class DET_DOCUMENTOBL
    Private DET_DOCUMENTODAL As New DET_DOCUMENTODAL
#Region "Lectura de Datos"

#Region "SP"

#End Region

#Region "SQL"

    Public Function SelectAll(ByVal sT_doc As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Return DET_DOCUMENTODAL.SelectAll(sT_doc, sAño, sMes)
    End Function

    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return DET_DOCUMENTODAL.SelectRow(sT_doc, sS_doc, sN_doc)
    End Function

    Public Function SelectAlm(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As String
        Return DET_DOCUMENTODAL.SelectAlm(sT_doc, sS_doc, sN_doc)
    End Function

    'Public Function ListDt(ByVal sql As String) As DataTable

    '    Return ELTBUSERDAL.ListDt(sql)

    'End Function

#End Region

#End Region

#Region "Grabar Datos"


    Public Function SaveRow(ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String, ByVal sAño As String) As String

        Return DET_DOCUMENTODAL.SaveRow(DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, sAño)

    End Function
    Public Function SaveRow1(ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal dg As DataGridView, ByVal flagAccion As String) As String

        Return DET_DOCUMENTODAL.SaveRow1(DET_DOCUMENTOBE, dg, flagAccion)

    End Function

#End Region

End Class
