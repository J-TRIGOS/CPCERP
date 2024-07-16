Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class COSTOS_EXPBL
    Private COSTOS_EXPDAL As New COSTOS_EXPDAL
#Region "SQL"


    Public Function SelectRow(ByVal sT_DOC As String, ByVal sS_DOC As String, ByVal sN_DOC As String) As DataTable
        Return COSTOS_EXPDAL.SelectRow(sT_DOC, sS_DOC, sN_DOC)
    End Function

    'Public Function SelectDescripcion() As DataTable
    '    Return COSTO_EXPDAL.LISTCMB()
    'End Function

    'Public Function ListDt(ByVal sql As String) As DataTable

    '    Return ELTBUSERDAL.ListDt(sql)

    'End Function

#End Region

#Region "Grabar Datos"

    Public Function SaveRow(ByVal COSTOS_EXPBE As COSTOS_EXPBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String) As String
        Return COSTOS_EXPDAL.SaveRow(COSTOS_EXPBE, ELMVLOGSBE, flagAccion)
    End Function

#End Region
End Class
