Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class TMP_HOREXTBL
    Private TMP_HOREXTDAL As New TMP_HOREXTDAL
    Public Function ReportePrograma(ByVal TMP_HOREXTBE As TMP_HOREXTBE, ByVal flagAccion As String) As String
        'Verifica el kardex
        Return TMP_HOREXTDAL.ReportePrograma(TMP_HOREXTBE, flagAccion)
    End Function
End Class
